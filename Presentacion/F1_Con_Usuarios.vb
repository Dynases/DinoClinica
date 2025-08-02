Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX
Imports System.IO

Public Class F1_Con_Usuarios
#Region "VARIABLES"
    Public _MPos As Integer
    Private _Limpiar As Boolean
    Dim Modificado As Boolean = False
#End Region


#Region "METODOS PRIVADOS"
    Private Sub _prIniciarTodo()
        _PCargarComboRol(cbRol)
        _prCargarComboLibreriaSucursal(cbSuc)
        _prInhabilitar()
        _PMAsignarPermisos()
        _prCargarUsuario()
        _prMostrarUsuario(0)
        _prCargarIcono()
    End Sub

    Private Sub _PCargarComboRol(ByVal cb As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim _Ds As New DataSet
        _Ds = L_Rol_General(0)

        cb.DropDownList.Columns.Clear()

        cb.DropDownList.Columns.Add(_Ds.Tables(0).Columns("ybnumi").ToString).Width = 60
        cb.DropDownList.Columns(0).Caption = "Código".ToUpper
        cb.DropDownList.Columns.Add(_Ds.Tables(0).Columns("ybrol").ToString).Width = 200
        cb.DropDownList.Columns(1).Caption = "Rol".ToUpper

        cb.ValueMember = _Ds.Tables(0).Columns("ybnumi").ToString
        cb.DisplayMember = _Ds.Tables(0).Columns("ybrol").ToString
        cb.DataSource = _Ds.Tables(0)
        cb.Refresh()
    End Sub
    Private Sub _prInhabilitar()
        txtIdUsuario.ReadOnly = True
        txtUsuario.ReadOnly = True
        txtContraseña.ReadOnly = True
        cbRol.Enabled = False
        cbSuc.Enabled = False
        txtIdEmpleadoU.ReadOnly = True
        txtNombEmpleadoU.ReadOnly = True
        dtpFIngresoU.Enabled = False
        swEstadoU.Enabled = False
        swEmergencia.Enabled = False

        JGBusqUsuarios.Enabled = True

        _Limpiar = False
    End Sub
    Private Sub _prLimpiar()
        txtIdUsuario.Clear()
        txtUsuario.Clear()
        txtContraseña.Clear()
        cbRol.Value = Nothing
        cbRol.SelectedIndex = 0
        txtIdEmpleadoU.Clear()
        txtNombEmpleadoU.Clear()
        dtpFIngresoU.Value = Now.Date
        'cbRol.SelectedIndex = -1
        swEstadoU.Value = True
        swEmergencia.Value = False
    End Sub
    Private Sub _prHabilitar()
        txtIdUsuario.ReadOnly = True
        txtUsuario.ReadOnly = False
        txtContraseña.ReadOnly = False
        cbRol.Enabled = True
        cbSuc.Enabled = True
        txtIdEmpleadoU.ReadOnly = False
        txtNombEmpleadoU.ReadOnly = False
        dtpFIngresoU.Enabled = True
        swEstadoU.Enabled = True
        swEmergencia.Enabled = True
    End Sub
    Private Sub _prCargarIcono()
        Dim blah As New Bitmap(New Bitmap(My.Resources.user), 20, 20)
        Dim ico As Icon = Icon.FromHandle(blah.GetHicon())
        Me.Icon = ico
    End Sub
    Private Sub _prCargarUsuario()
        Dim _tabla As DataTable = L_fnMostrarUsuario()
        JGBusqUsuarios.DataSource = _tabla
        JGBusqUsuarios.RetrieveStructure()
        JGBusqUsuarios.AlternatingColors = True

        With JGBusqUsuarios.RootTable.Columns("uaId")
            .Width = 70
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "Id"
            .Visible = True
        End With
        With JGBusqUsuarios.RootTable.Columns("ua_ecId")
            .Width = 190
            .Caption = "IdEmpleado"
            .Visible = False
        End With
        With JGBusqUsuarios.RootTable.Columns("ecNomb")
            .Width = 190
            .Caption = "Nombre Empleado"
            .Visible = False
        End With
        With JGBusqUsuarios.RootTable.Columns("uaUser")
            .Width = 190
            .Caption = "Usuario"
            .Visible = True
        End With
        With JGBusqUsuarios.RootTable.Columns("uaPass")
            .Width = 100
            .Caption = "Pass"
            .Visible = False
        End With
        With JGBusqUsuarios.RootTable.Columns("uaRol")
            .Width = 150
            .Caption = "IdRol"
            .Visible = False
        End With
        With JGBusqUsuarios.RootTable.Columns("ybrol")
            .Width = 190
            .Caption = "Rol"
            .Visible = True
        End With
        With JGBusqUsuarios.RootTable.Columns("uaFIngreso")
            .Width = 90
            .Caption = "Fecha"
            .Visible = True
        End With
        With JGBusqUsuarios.RootTable.Columns("uaEst")
            .Width = 90
            .Caption = "uaEst"
            .Visible = False
        End With
        With JGBusqUsuarios.RootTable.Columns("Estado")
            .Width = 90
            .Caption = "Estado"
            .Visible = True
        End With
        With JGBusqUsuarios.RootTable.Columns("uaEmer")
            .Width = 90
            .Caption = "Emergencia"
            .Visible = False
        End With
        With JGBusqUsuarios.RootTable.Columns("uaFecha")
            .Visible = False
        End With
        With JGBusqUsuarios.RootTable.Columns("uaHora")
            .Visible = False
        End With
        With JGBusqUsuarios.RootTable.Columns("uaUsuario")
            .Visible = False
        End With
        With JGBusqUsuarios.RootTable.Columns("uaSucursal")
            .Visible = False
        End With

        With JGBusqUsuarios
            .DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub
    Private Sub _prMostrarUsuario(_POS As Integer)
        If JGBusqUsuarios.RowCount <> 0 Then
            JGBusqUsuarios.Row = _POS
            With JGBusqUsuarios
                txtIdUsuario.Text = .GetValue("uaId")
                txtUsuario.Text = .GetValue("uaUser")
                txtContraseña.Text = .GetValue("uaPass")
                cbRol.Value = .GetValue("uaRol")
                cbSuc.Value = .GetValue("uaSucursal")
                txtIdEmpleadoU.Text = .GetValue("ua_ecId")
                txtNombEmpleadoU.Text = .GetValue("ecNomb")
                dtpFIngresoU.Value = .GetValue("uaFIngreso")
                swEstadoU.Value = .GetValue("uaEst")
                swEmergencia.Value = .GetValue("uaEmer")
                LblPaginacion.Text = Str(_POS + 1) + "/" + JGBusqUsuarios.RowCount.ToString

                'Muestra el bubblebar(quien registró el usuario)
                lbFecha.Text = CType(.GetValue("uaFecha"), Date).ToString("dd/MM/yyyy")
                lbHora.Text = .GetValue("uaHora").ToString
                lbUsuario.Text = .GetValue("uaUsuario").ToString
            End With
        End If

    End Sub

    Public Sub _prFiltrar()
        'cargo el buscador
        _prCargarUsuario()
        If JGBusqUsuarios.RowCount > 0 Then
            _MPos = 0
            _prMostrarUsuario(_MPos)
        Else
            _prLimpiar()
            LblPaginacion.Text = "0/0"
        End If
    End Sub

#End Region

#Region "METODOS PRIVADOS OVERRRIDABLES"
    Public Overrides Sub _PMONuevo()
        _prLimpiar()
        _prHabilitar()
        JGBusqUsuarios.Enabled = False
        txtUsuario.Focus()
    End Sub
    ''*****GRABA EL REGISTRO*****''
    Public Overrides Function _PMOGrabarRegistro() As Boolean

        Dim res As Boolean = L_fnGrabarUsuario(txtIdUsuario.Text, txtIdEmpleadoU.Text, txtUsuario.Text, txtContraseña.Text, cbRol.Value,
                                               dtpFIngresoU.Value.ToString("yyyy/MM/dd"), IIf(swEstadoU.Value, 1, 0), IIf(swEmergencia.Value, 1, 0),
                                                cbSuc.Value)
        If res Then
            Modificado = False

            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Id del usuario ".ToUpper + txtIdUsuario.Text + " Grabado con Exito.".ToUpper,
                                      img, 3000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )
            txtUsuario.Focus()
            _prCargarUsuario()
            _prLimpiar()
            _Limpiar = True
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "El usuario no pudo ser insertado".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)

        End If
        Return res
    End Function
    Public Overrides Sub _PMOModificar()
        _prHabilitar()
    End Sub

    ''*****MODDIFICA EL REGISTRO*****''
    Public Overrides Function _PMOModificarRegistro() As Boolean
        Dim res As Boolean = L_fnModificarUsuario(txtIdUsuario.Text, txtIdEmpleadoU.Text, txtUsuario.Text, txtContraseña.Text, cbRol.Value,
                                                  dtpFIngresoU.Value.ToString("yyyy/MM/dd"), IIf(swEstadoU.Value, 1, 0), IIf(swEmergencia.Value, 1, 0),
                                                  cbSuc.Value)
        If res Then
            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Id del Usuario ".ToUpper + txtIdUsuario.Text + " Modificado con Exito.".ToUpper,
                                      img, 3000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )
            _prFiltrar()
            _Limpiar = True
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "El usuario no pudo ser modificado".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)
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
            Dim res As Boolean = L_fnEliminarUsuario(txtIdUsuario.Text, mensajeError)
            If res Then
                Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)

                ToastNotification.Show(Me, "Código del usuario ".ToUpper + txtIdUsuario.Text + " eliminado con éxito.".ToUpper,
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

    Public Overrides Sub _PMOSalir()
        _prInhabilitar()
        _prFiltrar()
    End Sub


#End Region

#Region "EVENTOS"
    Private Sub F1_Con_Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
    End Sub
    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        If JGBusqUsuarios.RowCount > 0 Then
            _MPos = 0
            _prMostrarUsuario(_MPos)
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If _MPos > 0 And JGBusqUsuarios.RowCount > 0 Then
            _MPos = _MPos - 1
            _prMostrarUsuario(_MPos)
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If _MPos < JGBusqUsuarios.RowCount - 1 Then
            _MPos = _MPos + 1
            _prMostrarUsuario(_MPos)
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        If JGBusqUsuarios.RowCount > 0 Then
            _MPos = JGBusqUsuarios.RowCount - 1
            _prMostrarUsuario(_MPos)
        End If
    End Sub

    Private Sub JGBusqUsuarios_SelectionChanged(sender As Object, e As EventArgs) Handles JGBusqUsuarios.SelectionChanged
        If JGBusqUsuarios.Row >= 0 And JGBusqUsuarios.RowCount > 0 Then
            _MPos = JGBusqUsuarios.Row
            _prMostrarUsuario(_MPos)
        End If
    End Sub

    Private Sub txtIdEmpleadoU_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdEmpleadoU.KeyDown
        If e.KeyData = Keys.Control + Keys.Enter Then
            Dim dt As DataTable
            dt = L_fnMostrarEmpleado()
            Dim listEstCeldas As New List(Of Modelo.Celda)
            listEstCeldas.Add(New Modelo.Celda("ecId,", True, "ID", 50))
            listEstCeldas.Add(New Modelo.Celda("ecNomb", True, "Nombre", 210))
            listEstCeldas.Add(New Modelo.Celda("ec_lbIdLib", False, "ec_lbIdLib", 180))
            listEstCeldas.Add(New Modelo.Celda("lbdesc", True, "Tipo de Empleado", 180))
            listEstCeldas.Add(New Modelo.Celda("ecCi", False, "N. Documento", 100))
            listEstCeldas.Add(New Modelo.Celda("ecDir", False, "Direccion", 180))
            listEstCeldas.Add(New Modelo.Celda("ecTelf", False, "ecTelf", 180))
            listEstCeldas.Add(New Modelo.Celda("ecMail", False, "ecMail", 180))
            listEstCeldas.Add(New Modelo.Celda("ecEst", False, "ecEst".ToUpper, 150))
            listEstCeldas.Add(New Modelo.Celda("Estado", False, "Estado".ToUpper, 150))
            listEstCeldas.Add(New Modelo.Celda("ecFNac", False, "F.de Nacimiento".ToUpper, 150))
            listEstCeldas.Add(New Modelo.Celda("ecFIngr", False, "F.de Ingreso".ToUpper, 150))
            listEstCeldas.Add(New Modelo.Celda("ecImg", False, "ecImg".ToUpper, 150))
            listEstCeldas.Add(New Modelo.Celda("ecFecha", False, "ecFecha".ToUpper, 150))
            listEstCeldas.Add(New Modelo.Celda("ecHora", False, "ecHora".ToUpper, 150))
            listEstCeldas.Add(New Modelo.Celda("ecUsuario", False, "ecUsuario".ToUpper, 150))

            Dim ef = New Efecto
            ef.tipo = 3
            ef.dt = dt
            ef.SeleclCol = 2
            ef.listEstCeldas = listEstCeldas
            ef.alto = 600
            ef.ancho = 230
            ef.Context = "Seleccione Empleado".ToUpper
            ef.ShowDialog()
            Dim bandera As Boolean = False
            bandera = ef.band
            If (bandera = True) Then
                Dim Row As Janus.Windows.GridEX.GridEXRow = ef.Row
                txtIdEmpleadoU.Text = Row.Cells("ecId").Value
                txtNombEmpleadoU.Text = Row.Cells("ecNomb").Value
            End If
        End If
    End Sub

    Private Sub _prCargarComboLibreriaSucursal(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_fnListarSucursales()
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("aanumi").Width = 60
            .DropDownList.Columns("aanumi").Caption = "COD"
            .DropDownList.Columns.Add("aabdes").Width = 300
            .DropDownList.Columns("aabdes").Caption = "ALMACEN-SUC"
            .ValueMember = "aanumi"
            .DisplayMember = "aabdes"
            .DataSource = dt
            .Refresh()
        End With
    End Sub
    Private Sub JGBusqUsuarios_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGBusqUsuarios.EditingCell
        e.Cancel = True
    End Sub

    Private Sub F1_Con_Usuarios_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        _prCambiarColorPlomoOscuro(Presentacion.Principal.btnUsuarios)
    End Sub






#End Region


End Class