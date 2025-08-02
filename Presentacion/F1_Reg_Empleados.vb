Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX
Imports System.IO

Public Class F1_Reg_Empleados
#Region "VARIABLES"
    Public _IdCliente, _Iniciar, _MPos As Integer
    Private _Limpiar As Boolean
    Dim RutaGlobal As String = gs_CarpetaRaiz
    Dim RutaTemporal As String = "C:\Temporal"
    Dim nameImg As String = "Default.jpg"
    Dim Modificado As Boolean = False
#End Region
#Region "EVENTOS"
    Private Sub F1_Reg_Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
        superTabControl1.SelectedTabIndex = 0
    End Sub
    Private Sub JGBusqEmpleados_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGBusqEmpleados.EditingCell
        e.Cancel = True
    End Sub
    Private Sub BtAdicionar_Click(sender As Object, e As EventArgs) Handles BtAdicionar.Click
        _fnCopiarImagenRutaDefinida()
        btnGrabar.Focus()
    End Sub
    Private Sub cbTipoEmpleado_ValueChanged(sender As Object, e As EventArgs) Handles cbTipoEmpleado.ValueChanged
        If cbTipoEmpleado.SelectedIndex < 0 And cbTipoEmpleado.Text <> String.Empty Then
            btnTipoEmpleado.Visible = True
        Else
            btnTipoEmpleado.Visible = False
        End If
    End Sub
    Private Sub btnTipoEmpleado_Click(sender As Object, e As EventArgs) Handles btnTipoEmpleado.Click
        Dim _Id As String = ""
        ''If L_fnExisteLibreria("2", "1", cbEspecie.Text) Then
        If L_fnGrabarLibreria(_Id, "4", "1", cbTipoEmpleado.Text) Then
            _prCargarComboLibreria(cbTipoEmpleado, "4", "1")
            cbTipoEmpleado.SelectedIndex = CType(cbTipoEmpleado.DataSource, DataTable).Rows.Count - 1
        End If
    End Sub
    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        If JGBusqEmpleados.RowCount > 0 Then
            _MPos = 0
            _prMostrarEmpleado(_MPos)
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If _MPos > 0 And JGBusqEmpleados.RowCount > 0 Then
            _MPos = _MPos - 1
            _prMostrarEmpleado(_MPos)
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If _MPos < JGBusqEmpleados.RowCount - 1 Then
            _MPos = _MPos + 1
            _prMostrarEmpleado(_MPos)
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        If JGBusqEmpleados.RowCount > 0 Then
            _MPos = JGBusqEmpleados.RowCount - 1
            _prMostrarEmpleado(_MPos)
        End If
    End Sub
    Private Sub JGBusqEmpleados_SelectionChanged(sender As Object, e As EventArgs) Handles JGBusqEmpleados.SelectionChanged
        If JGBusqEmpleados.Row >= 0 And JGBusqEmpleados.RowCount > 0 Then
            _MPos = JGBusqEmpleados.Row
            _prMostrarEmpleado(_MPos)
        End If
    End Sub
#End Region
#Region "METODOS PRIVADOS"
    Private Sub _prIniciarTodo()
        'Carga eL Combobox
        _prCargarComboLibreria(cbTipoEmpleado, 4, 1)
        _prInhabilitar()
        _PMAsignarPermisos()
        _prCargarEmpleado()
        _prMostrarEmpleado(0)
        btnTipoEmpleado.Enabled = False
    End Sub
    Private Sub _prMostrarEmpleado(_POS As Integer)
        If JGBusqEmpleados.RowCount <> 0 Then
            JGBusqEmpleados.Row = _POS
            With JGBusqEmpleados
                txtIdEmpleado.Text = .GetValue("ecid")
                cbTipoEmpleado.Text = .GetValue("lbdesc")
                txtNombApellE.Text = .GetValue("ecNomb")
                txtCIEmpleado.Text = .GetValue("ecCi")
                txtDireccionE.Text = .GetValue("ecDir")
                txtCelE.Text = .GetValue("ecTelf")
                txtMailE.Text = .GetValue("ecMail")
                dtpFIngresoE.Value = .GetValue("ecFIngr")
                dtpFnacE.Value = .GetValue("ecFNac")
                swEstadoE.Value = .GetValue("ecEst")
                ''cOMBOBOX RAZA Y ESPECIFICACION
                'Muestra la cantidad DE FILAS en la Grilla
                LblPaginacion.Text = Str(_POS + 1) + "/" + JGBusqEmpleados.RowCount.ToString
                'Muestra el bubblebar(que usuario registró el empleado)
                lbFecha.Text = CType(.GetValue("ecFecha"), Date).ToString("dd/MM/yyyy")
                lbHora.Text = .GetValue("ecHora").ToString
                lbUsuario.Text = .GetValue("ecUsuario").ToString
            End With
            Dim name As String = JGBusqEmpleados.GetValue("ecimg")
            If name.Equals("Default.jpg") Or Not File.Exists(RutaGlobal + "\Imagenes\Imagenes EmpleadosDiVet" + name) Then

                Dim im As New Bitmap(My.Resources.pantalla)
                PictureBox1.Image = im
            Else
                If (File.Exists(RutaGlobal + "\Imagenes\Imagenes EmpleadosDiVet" + name)) Then
                    Dim Bin As New MemoryStream
                    Dim im As New Bitmap(New Bitmap(RutaGlobal + "\Imagenes\Imagenes EmpleadosDiVet" + name))
                    im.Save(Bin, System.Drawing.Imaging.ImageFormat.Jpeg)
                    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                    PictureBox1.Image = Image.FromStream(Bin)
                    Bin.Dispose()
                End If
            End If
        End If

    End Sub
    Private Sub _prCargarEmpleado()
        Dim _tabla As DataTable = L_fnMostrarEmpleado()
        JGBusqEmpleados.DataSource = _tabla
        JGBusqEmpleados.RetrieveStructure()
        JGBusqEmpleados.AlternatingColors = True
        'ecId, ec_lbIdLib, ecCi, ecNomb, ecDir, ecTelf, ecMail, ecFNac, ecFIngr, ecEst, ecImg, ecFecha, ecHora, ecUsuario
        With JGBusqEmpleados.RootTable.Columns("ecId")
            .Width = 70
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "Id"
            .Visible = True
        End With
        With JGBusqEmpleados.RootTable.Columns("ecNomb")
            .Width = 150
            .Caption = "Nombre"
            .Visible = True
        End With
        With JGBusqEmpleados.RootTable.Columns("ec_lbIdLib")
            .Width = 100
            .Caption = "ec_lbIdLib"
            .Visible = False
        End With
        With JGBusqEmpleados.RootTable.Columns("lbdesc")
            .Width = 150
            .Caption = "Tipo de Personal"
            .Visible = True
        End With
        With JGBusqEmpleados.RootTable.Columns("ecCi")
            .Width = 90
            .Caption = "CI"
            .Visible = True
        End With
        With JGBusqEmpleados.RootTable.Columns("ecDir")
            .Width = 90
            .Caption = "Dirección"
            .Visible = True
        End With
        With JGBusqEmpleados.RootTable.Columns("Estado")
            .Width = 110
            .Caption = "Estado"
            .Visible = True
        End With
        With JGBusqEmpleados.RootTable.Columns("ecEst")
            .Width = 110
            .Caption = "ecEst"
            .Visible = False
        End With
        With JGBusqEmpleados.RootTable.Columns("ecTelf")
            .Width = 130
            .Caption = "Teléfono"
            .Visible = True
        End With
        With JGBusqEmpleados.RootTable.Columns("ecMail")
            .Width = 120
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "Email"
            .Visible = False
        End With
        With JGBusqEmpleados.RootTable.Columns("ecImg")
            .Width = 100
            .Caption = "Imagen"
            .Visible = False
        End With
        With JGBusqEmpleados.RootTable.Columns("ecFNac")
            .Width = 120
            .Caption = "Fecha Nacimiento"
            .Visible = True
        End With
        With JGBusqEmpleados.RootTable.Columns("ecFIngr")
            .Width = 120
            .Caption = "Fecha Ingreso"
            .Visible = True
        End With
        With JGBusqEmpleados.RootTable.Columns("ecFecha")
            .Visible = False
        End With
        With JGBusqEmpleados.RootTable.Columns("ecHora")
            .Visible = False
        End With
        With JGBusqEmpleados.RootTable.Columns("ecUsuario")
            .Visible = False
        End With
        With JGBusqEmpleados
            .DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub
    Private Sub _prInhabilitar()
        txtIdEmpleado.ReadOnly = True
        txtCelE.ReadOnly = True
        txtNombApellE.ReadOnly = True
        txtDireccionE.ReadOnly = True
        txtCelE.ReadOnly = True
        txtMailE.ReadOnly = True
        dtpFIngresoE.Enabled = False
        dtpFnacE.Enabled = False
        dtpFIngresoE.Enabled = False
        swEstadoE.Enabled = False
        cbTipoEmpleado.Enabled = False
        btnTipoEmpleado.Enabled = False

        JGBusqEmpleados.Enabled = True
        'btnEspecie.Visible = False
        'btnRaza.Visible = False
        _Limpiar = False
    End Sub
    Private Sub _prHabilitar()
        txtIdEmpleado.ReadOnly = False
        txtCelE.ReadOnly = False
        txtNombApellE.ReadOnly = False
        txtDireccionE.ReadOnly = False
        txtCelE.ReadOnly = False
        txtMailE.ReadOnly = False
        dtpFIngresoE.Enabled = True
        dtpFnacE.Enabled = True
        swEstadoE.Enabled = True
        cbTipoEmpleado.Enabled = True
        btnTipoEmpleado.Enabled = True
        'btnEspecie.Visible = False
        'btnRaza.Visible = False
    End Sub
    Private Sub _prLimpiar()
        txtIdEmpleado.Clear()
        txtCelE.Clear()
        txtNombApellE.Clear()
        txtDireccionE.Clear()
        txtCelE.Clear()
        txtMailE.Clear()
        txtCIEmpleado.Value = 0
        swEstadoE.Value = 1
        dtpFnacE.Value = DateTime.Today()
        dtpFIngresoE.Value = DateTime.Today()
        txtIdEmpleado.Text = ""
        If (_Limpiar = False) Then
            _prSeleccionarCombo(cbTipoEmpleado)
        End If
        PictureBox1.Image = My.Resources.pantalla
    End Sub
    Public Sub _prFiltrar()
        'cargo el buscador
        _prCargarEmpleado()
        If JGBusqEmpleados.RowCount > 0 Then
            _MPos = 0
            _prMostrarEmpleado(_MPos)
        Else
            _prLimpiar()
            LblPaginacion.Text = "0/0"
        End If
    End Sub
    Public Sub _prSeleccionarCombo(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        If (CType(mCombo.DataSource, DataTable).Rows.Count > 0) Then
            mCombo.SelectedIndex = 0
        Else
            mCombo.SelectedIndex = -1
        End If
    End Sub
    Private Sub _prCargarComboLibreria(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo, cod1 As String, cod2 As String)
        Dim dt As New DataTable
        dt = L_fnMostrarLibreria(cod1, cod2)
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("lbidlib").Width = 70
            .DropDownList.Columns("lbidlib").Caption = "COD"
            .DropDownList.Columns.Add("lbdesc").Width = 200
            .DropDownList.Columns("lbdesc").Caption = "DESCRIPCION"
            .ValueMember = "lbidlib"
            .DisplayMember = "lbdesc"
            .DataSource = dt
            .Refresh()
        End With
    End Sub
    Private Sub _prCrearCarpetaTemporal()
        If System.IO.Directory.Exists(RutaTemporal) = False Then
            System.IO.Directory.CreateDirectory(RutaTemporal)
        Else
            Try
                My.Computer.FileSystem.DeleteDirectory(RutaTemporal, FileIO.DeleteDirectoryOption.DeleteAllContents)
                My.Computer.FileSystem.CreateDirectory(RutaTemporal)
                'My.Computer.FileSystem.DeleteDirectory(RutaTemporal, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
                'System.IO.Directory.CreateDirectory(RutaTemporal)
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub _prCrearCarpetaImagenes()
        Dim rutaDestino As String = RutaGlobal + "\Imagenes\Imagenes EmpleadosDiVet\"

        If System.IO.Directory.Exists(RutaGlobal + "\Imagenes\Imagenes EmpleadosDiVet\") = False Then
            If System.IO.Directory.Exists(RutaGlobal + "\Imagenes") = False Then
                System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes")
                If System.IO.Directory.Exists(RutaGlobal + "\Imagenes\Imagenes EmpleadosDiVet") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes\Imagenes EmpleadosDiVet")
                End If
            Else
                If System.IO.Directory.Exists(RutaGlobal + "\Imagenes\Imagenes EmpleadosDiVet") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes\Imagenes EmpleadosDiVet")

                End If
            End If
        End If
    End Sub
    Private Function _fnCopiarImagenRutaDefinida() As String
        'copio la imagen en la carpeta del sistema

        Dim file As New OpenFileDialog()
        file.Filter = "Ficheros JPG o JPEG o PNG|*.jpg;*.jpeg;*.png" &
                      "|Ficheros GIF|*.gif" &
                      "|Ficheros BMP|*.bmp" &
                      "|Ficheros PNG|*.png" &
                      "|Ficheros TIFF|*.tif"
        If file.ShowDialog() = DialogResult.OK Then
            Dim ruta As String = file.FileName


            If file.CheckFileExists = True Then
                Dim img As New Bitmap(New Bitmap(ruta))
                Dim imgM As New Bitmap(New Bitmap(ruta))
                Dim Bin As New MemoryStream
                imgM.Save(Bin, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim a As Object = file.GetType.ToString
                If (_fnActionNuevo()) Then
                    Dim mayor As Integer
                    mayor = JGBusqEmpleados.GetTotal(JGBusqEmpleados.RootTable.Columns("ecId"), AggregateFunction.Max)
                    nameImg = "\Imagen_" + Str(mayor + 1).Trim + ".jpg"
                    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                    PictureBox1.Image = Image.FromStream(Bin)

                    img.Save(RutaTemporal + nameImg, System.Drawing.Imaging.ImageFormat.Jpeg)
                    img.Dispose()
                Else

                    nameImg = "\Imagen_" + Str(txtIdEmpleado.Text).Trim + ".jpg"
                    PictureBox1.Image = Image.FromStream(Bin)
                    img.Save(RutaTemporal + nameImg, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Modificado = True
                    img.Dispose()

                End If
            End If

            Return nameImg
        End If

        Return "default.jpg"
    End Function
    Public Function _fnActionNuevo() As Boolean
        Return txtIdEmpleado.Text = String.Empty
    End Function
    Private Sub _fnMoverImagenRuta(Folder As String, name As String)
        'copio la imagen en la carpeta del sistema
        If (Not name.Equals("Default.jpg") And File.Exists(RutaTemporal + name)) Then
            Dim img As New Bitmap(New Bitmap(RutaTemporal + name), 500, 300)
            PictureBox1.Image.Dispose()
            PictureBox1.Image = Nothing
            Try
                My.Computer.FileSystem.CopyFile(RutaTemporal + name,
     Folder + name, overwrite:=True)
            Catch ex As System.IO.IOException
            End Try
        End If
    End Sub
    Public Sub _PrEliminarImage()
        If (Not (_fnActionNuevo()) And (File.Exists(RutaGlobal + "\Imagenes\Imagenes EmpleadosDiVet\Imagen_" + txtIdEmpleado.Text + ".jpg"))) Then
            PictureBox1.Image.Dispose()
            PictureBox1.Image = Nothing
            Try
                My.Computer.FileSystem.DeleteFile(RutaGlobal + "\Imagenes\Imagenes EmpleadosDiVet\Imagen_" + txtIdEmpleado.Text + ".jpg")
            Catch ex As Exception

            End Try
        End If
    End Sub
#End Region
#Region "METODOS PRIVADOS OVERRRIDABLES"
    Public Overrides Function _PMOGrabarRegistro() As Boolean
        Dim res As Boolean = L_fnGrabarEnpleado(txtIdEmpleado.Text, cbTipoEmpleado.Value, IIf(txtCIEmpleado.Text = String.Empty, 0, txtCIEmpleado.Text), txtNombApellE.Text,
                                                txtDireccionE.Text, txtCelE.Text, txtMailE.Text, dtpFnacE.Value.ToString("yyyy/MM/dd"),
                                               dtpFIngresoE.Value.ToString("yyyy/MM/dd"), nameImg, IIf(swEstadoE.Value, 1, 0))
        If res Then
            Modificado = False
            _fnMoverImagenRuta(RutaGlobal + "\Imagenes\Imagenes EmpleadosDiVet", nameImg)
            nameImg = "Default.jpg"

            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Id del personal ".ToUpper + txtIdEmpleado.Text + " Grabado con Exito.".ToUpper,
                                      img, 3000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )
            txtCIEmpleado.Focus()
            _prCargarEmpleado()
            _prLimpiar()
            _Limpiar = True
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "El personal no pudo ser insertado".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)

        End If
        Return res
    End Function
    ''*****MODDIFICA EL REGISTRO*****''
    Public Overrides Function _PMOModificarRegistro() As Boolean
        Dim res As Boolean = L_fnModificarEnpleado(txtIdEmpleado.Text, cbTipoEmpleado.Value, IIf(txtCIEmpleado.Text = String.Empty, 0, txtCIEmpleado.Text), txtNombApellE.Text, txtDireccionE.Text, txtCelE.Text, txtMailE.Text, dtpFnacE.Value.ToString("yyyy/MM/dd"),
                                               dtpFIngresoE.Value.ToString("yyyy/MM/dd"), nameImg, IIf(swEstadoE.Value, 1, 0))
        If res Then
            If (Modificado = True) Then
                _fnMoverImagenRuta(RutaGlobal + "\Imagenes\Imagenes EmpleadosDiVet", nameImg)
                Modificado = False
            End If
            nameImg = "Default.jpg"
            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Id del Personal ".ToUpper + txtIdEmpleado.Text + " Modificado con Exito.".ToUpper,
                                      img, 3000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )
            'Filtrar
            '_prCargarPaciente()
            '_prMostrarPaciente(_MPos)
            _prInhabilitar()
            _prFiltrar()
            _Limpiar = True
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "El personal no pudo ser modificado".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)
        End If
        Return res
    End Function

    ''*****ELIMINAR EL REGISTRO*****''
    Public Overrides Sub _PMOEliminarRegistro()
        Dim ef = New Efecto
        ef.tipo = 2
        ef.Context = "¿esta seguro de eliminar el registro?".ToUpper
        ef.Header = "mensaje principal".ToUpper
        ef.ShowDialog()
        Dim bandera As Boolean = False
        bandera = ef.band
        If (bandera = True) Then
            Dim mensajeError As String = ""
            Dim res As Boolean = L_fnEliminarEmpleado(txtIdEmpleado.Text, mensajeError)
            If res Then
                _PrEliminarImage()
                Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)

                ToastNotification.Show(Me, "Código del personal ".ToUpper + txtIdEmpleado.Text + " eliminado con Exito.".ToUpper,
                                          img, 2000,
                                          eToastGlowColor.Green,
                                          eToastPosition.TopCenter)

                _prFiltrar()
            Else
                Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                ToastNotification.Show(Me, mensajeError, img, 3000, eToastGlowColor.Red, eToastPosition.TopCenter)
            End If
        End If
    End Sub
    Public Overrides Function _PMOValidarCampos() As Boolean
        Dim _ok As Boolean = True
        MEP.Clear()
        If txtCIEmpleado.Text = String.Empty Then
            txtCIEmpleado.BackColor = Color.Red
            MEP.SetError(txtCIEmpleado, "ingrese el Ci!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Ingrese el CI del personal para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        Else
            txtCIEmpleado.BackColor = Color.White
            MEP.SetError(txtCIEmpleado, "")
        End If

        If cbTipoEmpleado.SelectedIndex < 0 Then
            cbTipoEmpleado.BackColor = Color.Red
            MEP.SetError(cbTipoEmpleado, "Seleccione un tipo de personal!".ToUpper)
            _ok = False
        Else
            cbTipoEmpleado.BackColor = Color.White
            MEP.SetError(cbTipoEmpleado, "")
        End If
        If txtNombApellE.Text = String.Empty Then
            txtNombApellE.BackColor = Color.Red
            MEP.SetError(txtNombApellE, "Ingrese un Nombre!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Ingrese el Nombre y Apellido del personal para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        Else
            txtNombApellE.BackColor = Color.White
            MEP.SetError(txtNombApellE, "")
        End If
        MHighlighterFocus.UpdateHighlights()
        Return _ok
    End Function
    Public Overrides Sub _PMONuevo()
        'JGBusqEmpleados.Enabled = False 'Deshabilita el buscador de la Grilla
        _prLimpiar()
        _prHabilitar()
        JGBusqEmpleados.Enabled = False
        txtCIEmpleado.Focus()
    End Sub

    Private Sub F1_Reg_Empleados_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        _prCambiarColorPlomoOscuro(Presentacion.Principal.btnEmpleados)
    End Sub

    Public Overrides Sub _PMOModificar()
        'JGBusqEmpleados.Enabled = False 'Deshabilita el buscador de la Grilla
        _prHabilitar()
    End Sub
    Public Overrides Sub _PMOSalir()
        _prInhabilitar()
        _prFiltrar()
    End Sub
#End Region

End Class