Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX
Imports System.IO
Imports DevComponents.DotNetBar.Controls
Public Class F1_Reg_Pacientes
#Region "VARIABLES"
    Public _IdCliente, _Iniciar, _MPos As Integer
    Private _Limpiar As Boolean

#End Region
#Region "EVENTOS"
    Private Sub F1_Reg_Pacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
        superTabControl1.SelectedTabIndex = 0
    End Sub
    Private Sub JGBusqMascotas_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGBusqMascotas.EditingCell
        e.Cancel = True
    End Sub
    '************Verifica si el Combobox fue llenado 
    Private Sub cbEspecie_ValueChanged(sender As Object, e As EventArgs) Handles cbEspecie.ValueChanged
        If cbEspecie.SelectedIndex < 0 And cbEspecie.Text <> String.Empty Then
            btnEspecie.Visible = True
        Else
            btnEspecie.Visible = False
        End If
    End Sub
    '************Verifica si el Combobox fue llenado 
    Private Sub cbRaza_ValueChanged(sender As Object, e As EventArgs) Handles cbRaza.ValueChanged
        If cbRaza.SelectedIndex < 0 And cbRaza.Text <> String.Empty Then
            btnRaza.Visible = True
        Else
            btnRaza.Visible = False
        End If
    End Sub
    '***Muestra el primer registro de la Grilla
    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        If JGBusqMascotas.RowCount > 0 Then
            _MPos = 0
            _prMostrarPaciente(_MPos)
        End If
    End Sub
    '***Muestra el anterior registro de la Grilla
    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If _MPos > 0 And JGBusqMascotas.RowCount > 0 Then
            _MPos = _MPos - 1
            _prMostrarPaciente(_MPos)
        End If
    End Sub
    '***Muestra el siguiente registro de la Grilla
    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If _MPos < JGBusqMascotas.RowCount - 1 Then
            _MPos = _MPos + 1
            _prMostrarPaciente(_MPos)
        End If
    End Sub
    '***Muestra el ultimo registro de la Grilla
    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        If JGBusqMascotas.RowCount > 0 Then
            _MPos = JGBusqMascotas.RowCount - 1
            _prMostrarPaciente(_MPos)
        End If
    End Sub
    '********Guarda y carga el combobox 
    Private Sub btnEspecie_Click(sender As Object, e As EventArgs) Handles btnEspecie.Click
        Dim _Id As String = ""
        ''If L_fnExisteLibreria("2", "1", cbEspecie.Text) Then
        If L_fnGrabarLibreria(_Id, "2", "1", cbEspecie.Text) Then
            _prCargarComboLibreria(cbEspecie, "2", "1")
            cbEspecie.SelectedIndex = CType(cbEspecie.DataSource, DataTable).Rows.Count - 1
        End If
        'Else
        '    Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
        '    ToastNotification.Show(Me, "La especie especificada ya existe", img, 3000, eToastGlowColor.Red, eToastPosition.TopCenter)
        'End If
    End Sub

    Private Sub btnRaza_Click(sender As Object, e As EventArgs) Handles btnRaza.Click
        Dim _Id As String = ""
        'If L_fnExisteLibreria("2", "2", cbRaza.Text) Then
        If L_fnGrabarLibreria(_Id, "2", "2", cbRaza.Text) Then
            _prCargarComboLibreria(cbRaza, "2", "2")
            cbRaza.SelectedIndex = CType(cbRaza.DataSource, DataTable).Rows.Count - 1
        End If
        'Else
        '    Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
        '    ToastNotification.Show(Me, "La raza especificada ya existe", img, 3000, eToastGlowColor.Red, eToastPosition.TopCenter)
        'End If
    End Sub

    Private Sub JGBusqMascotas_SelectionChanged_1(sender As Object, e As EventArgs) Handles JGBusqMascotas.SelectionChanged
        If JGBusqMascotas.Row >= 0 And JGBusqMascotas.RowCount > 0 Then
            _MPos = JGBusqMascotas.Row
            _prMostrarPaciente(_MPos)
        End If
    End Sub
#End Region
#Region "METODOS PRIVADOS"
    Private Sub _prIniciarTodo()
        'Carga eL Combobox
        _prCargarComboLibreria(cbEspecie, 2, 1)
        _prCargarComboLibreria(cbRaza, 2, 2)
        _PMAsignarPermisos()
        If modificarPac = False Then
            _prCargarPaciente()
        Else
            _prCargarPacienteUnCliente()
            modificarPac = False
        End If

        _prMostrarPaciente(0)
        _prHabilitarMenu()
        'Inicia directo a realizar un Registro
        If _Iniciar = 1 Then
            _MNuevo = True
            _prHabilitar()
            _prLimpiar()
            'Inicia a visualizar el registro
        ElseIf _Iniciar = 3 Then
            _prInhabilitar()
        End If
        btnEspecie.Visible = False
        btnRaza.Visible = False
    End Sub
    Private Sub _prMostrarPaciente(_POS As Integer)
        If JGBusqMascotas.RowCount <> 0 Then
            JGBusqMascotas.Row = _POS
            Dim dt As DataTable = CType(JGBusqMascotas.DataSource, DataTable)
            Try
                txtIdMascota.Text = JGBusqMascotas.GetValue("pbid").ToString
            Catch ex As Exception
                Exit Sub
            End Try
            With JGBusqMascotas
                txtIdMascota.Text = .GetValue("pbid")
                txtNMascota.Text = .GetValue("pbnomb")
                dtpFnac.Value = .GetValue("pbfnac")
                chbMacho.Checked = IIf(.GetValue("pbsex") = "MACHO", True, False)
                chbHembra.Checked = IIf(.GetValue("pbsex") = "HEMBRA", True, False)
                chbSi.Checked = IIf(.GetValue("pbester") = "SI", True, False)
                chbNo.Checked = IIf(.GetValue("pbester") = "NO", True, False)
                txtColor.Text = .GetValue("pbcolor")
                txtEstado.Text = .GetValue("pbdest")
                txtSeñas.Text = .GetValue("pbseñas")
                dtpFIngresoM.Value = .GetValue("pbfingr")
                cbEspecie.Value = .GetValue("pbespec")
                cbRaza.Value = .GetValue("pbraza")
                ''cOMBOBOX RAZA Y ESPECIFICACION
                'Muestra la cantidad DE FILAS en la Grilla
                LblPaginacion.Text = Str(_POS + 1) + "/" + JGBusqMascotas.RowCount.ToString
                'Muestra el bubblebar(que usuario registró el paciente)
                lbFecha.Text = CType(.GetValue("pbfingr"), Date).ToString("dd/MM/yyyy")
                lbHora.Text = .GetValue("pbhora").ToString
                lbUsuario.Text = .GetValue("pbusuario").ToString
            End With
        End If

    End Sub
    Private Sub _prCargarPaciente()
        Dim _tabla As DataTable = L_MostrarPacientes()
        JGBusqMascotas.DataSource = _tabla
        JGBusqMascotas.RetrieveStructure()
        JGBusqMascotas.AlternatingColors = True
        With JGBusqMascotas.RootTable.Columns("pbid")
            .Width = 65
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "Id"
            .Visible = True
        End With
        With JGBusqMascotas.RootTable.Columns("pb_caid")
            .Width = 70
            .Caption = "Id_Cliente"
            .Visible = False
        End With
        With JGBusqMascotas.RootTable.Columns("cacliente")
            .Width = 120
            .Caption = "Cliente"
            .Visible = True
        End With
        With JGBusqMascotas.RootTable.Columns("pbnomb")
            .Width = 120
            .Caption = "Nombre"
            .Visible = True
        End With
        With JGBusqMascotas.RootTable.Columns("pbespec")
            .Width = 110
            .Caption = "pbespec"
            .Visible = False
        End With
        With JGBusqMascotas.RootTable.Columns("Especie")
            .Width = 110
            .Caption = "Especie"
            .Visible = True
        End With
        With JGBusqMascotas.RootTable.Columns("pbfnac")
            .Width = 120
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "F. Nacimiento"
            .Visible = True
        End With
        With JGBusqMascotas.RootTable.Columns("pbraza")
            .Width = 100
            .Caption = "Raza"
            .Visible = False
        End With
        With JGBusqMascotas.RootTable.Columns("Raza")
            .Width = 100
            .Caption = "Raza"
            .Visible = True
        End With
        With JGBusqMascotas.RootTable.Columns("pbsex")
            .Width = 82
            .Caption = "Sexo"
            .Visible = True
        End With
        With JGBusqMascotas.RootTable.Columns("pbcolor")
            .Width = 100
            .Caption = "Color"
            .Visible = True
        End With
        With JGBusqMascotas.RootTable.Columns("pbester")
            .Width = 100
            .Caption = "Esterilizado"
            .Visible = True
        End With
        With JGBusqMascotas.RootTable.Columns("pbdest")
            .Width = 100
            .Caption = "Descripción Estado"
            .Visible = True
        End With
        With JGBusqMascotas.RootTable.Columns("pbseñas")
            .Width = 100
            .Caption = "Señas"
            .Visible = True
        End With
        With JGBusqMascotas.RootTable.Columns("pbfingr")
            .Width = 100
            .Caption = "F. Ingreso"
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Visible = True
        End With
        With JGBusqMascotas.RootTable.Columns("pbest")
            .Width = 100
            .Caption = "Estado"
            .Visible = False
        End With
        With JGBusqMascotas.RootTable.Columns("pbhora")
            .Visible = False
        End With
        With JGBusqMascotas.RootTable.Columns("pbusuario")
            .Visible = False
        End With
        With JGBusqMascotas
            .DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub
    Private Sub _prCargarPacienteUnCliente()
        Dim _tabla As DataTable = L_fnMostrarPaciente(_caidcli)
        JGBusqMascotas.DataSource = _tabla
        JGBusqMascotas.RetrieveStructure()
        JGBusqMascotas.AlternatingColors = True
        With JGBusqMascotas.RootTable.Columns("pbid")
            .Width = 65
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "Id"
            .Visible = True
        End With
        With JGBusqMascotas.RootTable.Columns("pb_caid")
            .Width = 70
            .Caption = "Id_Cliente"
            .Visible = False
        End With
        With JGBusqMascotas.RootTable.Columns("cacliente")
            .Width = 120
            .Caption = "Cliente"
            .Visible = True
        End With
        With JGBusqMascotas.RootTable.Columns("pbnomb")
            .Width = 120
            .Caption = "Nombre"
            .Visible = True
        End With
        With JGBusqMascotas.RootTable.Columns("pbespec")
            .Width = 110
            .Caption = "pbespec"
            .Visible = False
        End With
        With JGBusqMascotas.RootTable.Columns("Especie")
            .Width = 110
            .Caption = "Especie"
            .Visible = True
        End With
        With JGBusqMascotas.RootTable.Columns("pbfnac")
            .Width = 120
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "F. Nacimiento"
            .Visible = True
        End With
        With JGBusqMascotas.RootTable.Columns("pbraza")
            .Width = 100
            .Caption = "Raza"
            .Visible = False
        End With
        With JGBusqMascotas.RootTable.Columns("Raza")
            .Width = 100
            .Caption = "Raza"
            .Visible = True
        End With
        With JGBusqMascotas.RootTable.Columns("pbsex")
            .Width = 82
            .Caption = "Sexo"
            .Visible = True
        End With
        With JGBusqMascotas.RootTable.Columns("pbcolor")
            .Width = 100
            .Caption = "Color"
            .Visible = True
        End With
        With JGBusqMascotas.RootTable.Columns("pbester")
            .Width = 100
            .Caption = "Esterilizado"
            .Visible = True
        End With
        With JGBusqMascotas.RootTable.Columns("pbdest")
            .Width = 100
            .Caption = "Descripción Estado"
            .Visible = True
        End With
        With JGBusqMascotas.RootTable.Columns("pbseñas")
            .Width = 100
            .Caption = "Señas"
            .Visible = True
        End With
        With JGBusqMascotas.RootTable.Columns("pbfingr")
            .Width = 100
            .Caption = "F. Ingreso"
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Visible = True
        End With
        With JGBusqMascotas.RootTable.Columns("pbest")
            .Width = 100
            .Caption = "Estado"
            .Visible = False
        End With
        With JGBusqMascotas.RootTable.Columns("pbhora")
            .Visible = False
        End With
        With JGBusqMascotas.RootTable.Columns("pbusuario")
            .Visible = False
        End With
        With JGBusqMascotas
            .DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub
    '***********Pone en estado Visible el menu
    Private Sub _prHabilitarMenu()
        If _Iniciar = 1 Then
            btnNuevo.Enabled = False
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
            btnGrabar.Enabled = True
        ElseIf _Iniciar = 3 Then
            btnNuevo.Enabled = False
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
            btnGrabar.Enabled = False
        ElseIf _Iniciar = 4 Then
            btnNuevo.Enabled = True
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
            btnGrabar.Enabled = False
            btnSalir.Enabled = True
        End If
    End Sub
    Private Sub _prInhabilitar()
        txtIdMascota.ReadOnly = True
        txtNMascota.ReadOnly = True
        txtSeñas.ReadOnly = True
        txtColor.ReadOnly = True
        txtEstado.ReadOnly = True
        cbEspecie.ReadOnly = True
        cbRaza.ReadOnly = True
        dtpFnac.Enabled = False
        dtpFIngresoM.Enabled = False
        JGBusqMascotas.Enabled = True
        chbMacho.Enabled = False
        chbHembra.Enabled = False
        chbSi.Enabled = False
        chbNo.Enabled = False
        btnEspecie.Visible = False
        btnRaza.Visible = False
        _Limpiar = False
    End Sub
    Private Sub _prHabilitar()
        txtIdMascota.ReadOnly = False
        txtNMascota.ReadOnly = False
        txtSeñas.ReadOnly = False
        txtEstado.ReadOnly = False
        txtColor.ReadOnly = False
        cbEspecie.ReadOnly = False
        cbRaza.ReadOnly = False
        dtpFnac.Enabled = True
        dtpFIngresoM.Enabled = True
        chbMacho.Enabled = True
        chbHembra.Enabled = True
        chbSi.Enabled = True
        chbNo.Enabled = True
    End Sub
    Private Sub _prLimpiar()
        txtIdMascota.Clear()
        txtNMascota.Clear()
        txtNMascota.Focus()
        txtSeñas.Clear()
        txtColor.Clear()
        txtEstado.Clear()
        chbHembra.Checked = False
        chbMacho.Checked = True
        chbSi.Checked = True
        chbNo.Checked = False
        dtpFnac.Value = DateTime.Today()
        dtpFIngresoM.Value = DateTime.Today()
        If (_Limpiar = False) Then
            _prSeleccionarCombo(cbRaza)
            _prSeleccionarCombo(cbEspecie)
        End If
    End Sub
    Public Sub _prFiltrar()
        'cargo el buscador
        _prCargarPaciente()
        If JGBusqMascotas.RowCount > 0 Then
            _MPos = 0
            _prMostrarPaciente(_MPos)
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
#End Region
#Region "METODOS SOBRECARGADOS"
    ''*****GRABAR EL REGISTRO *****''
    Public Overrides Function _PMOGrabarRegistro() As Boolean
        Dim res As Boolean = L_fnGrabarPaciente(txtIdMascota.Text, _IdCliente, txtNMascota.Text, cbEspecie.Value, dtpFnac.Value.ToString("yyyy/MM/dd"), cbRaza.Value,
                                                IIf(chbMacho.Checked = True, "MACHO", "HEMBRA"), txtColor.Text, IIf(chbSi.Checked = True, "SI", "NO"),
                                                txtEstado.Text, txtSeñas.Text, dtpFIngresoM.Value.ToString("yyyy/MM/dd"))
        If res Then
            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Id de la mascota ".ToUpper + txtIdMascota.Text + " Grabado con Exito.".ToUpper,
                                      img, 3000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )
            txtNMascota.Focus()
            _prLimpiar()
            _prCargarPaciente()
            _Limpiar = True
            _Iniciar = 4
            _prHabilitarMenu()
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "La mascota no pudo ser insertado".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)

        End If
        Return res
    End Function
    ''*****MODDIFICA EL REGISTRO*****''
    Public Overrides Function _PMOModificarRegistro() As Boolean
        Dim res As Boolean = L_fnModificarPaciente(txtIdMascota.Text, JGBusqMascotas.GetValue("pb_caid"), txtNMascota.Text, cbEspecie.Value, dtpFnac.Value.ToString("yyyy/MM/dd"), cbRaza.Value,
                                                IIf(chbMacho.Checked = True, "MACHO", "HEMBRA"), txtColor.Text, IIf(chbSi.Checked = True, "SI", "NO"),
                                                txtEstado.Text, txtSeñas.Text, dtpFIngresoM.Value.ToString("yyyy/MM/dd"))
        If res Then
            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Id de la mascota ".ToUpper + txtIdMascota.Text + " Modificado con Exito.".ToUpper,
                                      img, 3000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )
            txtNMascota.Focus()
            _prCargarPaciente()
            _prMostrarPaciente(_MPos)
            _prInhabilitar()
            _Limpiar = True
            btnNuevo.Enabled = IIf(_Iniciar = 3, False, True)
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "La mascota no pudo ser modificada".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)
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
            Dim res As Boolean = L_fnEliminarPaciente(txtIdMascota.Text, mensajeError)
            If res Then
                Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)

                ToastNotification.Show(Me, "Código de mascota ".ToUpper + txtIdMascota.Text + " eliminado con Exito.".ToUpper,
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
        If txtNMascota.Text = String.Empty Then
            txtNMascota.BackColor = Color.Red
            MEP.SetError(txtNMascota, "ingrese el nombre!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Ingrese el nombre de la Mascota para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        Else
            txtNMascota.BackColor = Color.White
            MEP.SetError(txtNMascota, "")
        End If

        If txtColor.Text = String.Empty Then
            txtColor.BackColor = Color.Red
            MEP.SetError(txtColor, "Ingrese un color!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Ingrese el color de la Mascota para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        Else
            txtColor.BackColor = Color.White
            MEP.SetError(txtColor, "")
        End If
        If cbEspecie.SelectedIndex < 0 Then
            cbEspecie.BackColor = Color.Red
            MEP.SetError(cbEspecie, "Seleccione una especie!".ToUpper)
            _ok = False
        Else
            cbEspecie.BackColor = Color.White
            MEP.SetError(cbEspecie, "")
        End If
        If cbRaza.SelectedIndex < 0 Then
            cbRaza.BackColor = Color.Red
            MEP.SetError(cbRaza, "Seleccione una raza!".ToUpper)
            _ok = False
        Else
            cbRaza.BackColor = Color.White
            MEP.SetError(cbRaza, "")
        End If
        MHighlighterFocus.UpdateHighlights()
        Return _ok
    End Function
    Public Overrides Sub _PMONuevo()
        'JGBusqMascotas.Enabled = False 'Deshabilita el buscador de la Grilla
        _prLimpiar()
        _prHabilitar()
    End Sub

    Private Sub JGBusqMascotas_DoubleClick(sender As Object, e As EventArgs) Handles JGBusqMascotas.DoubleClick
        superTabControl1.SelectedTabIndex = 0
    End Sub

    Private Sub F1_Reg_Pacientes_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        _prCambiarColorPlomoOscuro(Presentacion.Principal.btnPacientes)
    End Sub

    Public Overrides Sub _PMOModificar()
        'JGBusqMascotas.Enabled = False 'Deshabilita el buscador de la Grilla
        _prHabilitar()
    End Sub
    Public Overrides Sub _PMOSalir()
        _prInhabilitar()
        _prFiltrar()
        btnNuevo.Enabled = IIf(_Iniciar = 3, False, True)
    End Sub

#End Region
End Class