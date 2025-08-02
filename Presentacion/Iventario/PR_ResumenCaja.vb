Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Public Class PR_ResumenCaja

    Public _nameButton As String
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem
    Dim Vendedor As String = ""
    Dim Cliente As String = ""


    Public Sub _prIniciarTodo()
        tbFechaI.Value = Now.Date
        tbFechaF.Value = Now.Date
        _PMIniciarTodo()
        'L_prAbrirConexion(gs_Ip, gs_UsuarioSql, gs_ClaveSql, gs_NombreBD)
        Me.Text = "REPORTE DE PAGOS"
        MReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        _IniciarComponentes()
    End Sub
    Public Sub _IniciarComponentes()
        tbVendedor.ReadOnly = True
        tbCliente.ReadOnly = True
        tbVendedor.Enabled = False
        tbCliente.Enabled = False
        CheckTodosVendedor.CheckValue = True
        CheckTodoCliente.CheckValue = True


    End Sub
    Public Sub _prInterpretarDatos(ByRef _dt As DataTable)
        'General Cliente
        If (CheckTodosVendedor.Checked And CheckTodoCliente.Checked) Then
            _dt = L_prResumenCobrosGeneralAlmacenVendedor(tbFechaI.Value.ToString("yyyy/MM/dd"), tbFechaF.Value.ToString("yyyy/MM/dd"))
        End If
        'Por vendedor
        If (checkUnaVendedor.Checked And CheckTodoCliente.Checked) Then
            If (tbCodigoVendedor.Text.Length > 0) Then
                _dt = L_prResumenCobrosPorVendedorTodosAlmacen(tbFechaI.Value.ToString("yyyy/MM/dd"), tbFechaF.Value.ToString("yyyy/MM/dd"), tbCodigoVendedor.Text)
            End If

        End If
        'Por Cliente
        If (CheckTodosVendedor.Checked And CheckUnaCliente.Checked) Then
            If (tbCliente.SelectedIndex >= 0) Then
                _dt = L_prResumenCobrosTodosVendedorUnaAlmacen(tbFechaI.Value.ToString("yyyy/MM/dd"), tbFechaF.Value.ToString("yyyy/MM/dd"), tbCodCliente.Text)
            End If

        End If
        'Por cliente y vendedor
        If (checkUnaVendedor.Checked And CheckUnaCliente.Checked) Then
            If (tbCodCliente.Text.Length >= 0 And tbCodigoVendedor.Text.Length > 0) Then
                _dt = L_prResumenCobrosUnaVendedorUnaAlmacen(tbFechaI.Value.ToString("yyyy/MM/dd"), tbFechaF.Value.ToString("yyyy/MM/dd"), tbCodCliente.Text, tbCodigoVendedor.Text)
                Vendedor = "" + tbVendedor.Text
                Cliente = "" + tbClientes.Text
            End If
        End If
    End Sub
    Private Sub _prCargarReporte()
        Dim _dt As New DataTable
        _prInterpretarDatos(_dt)
        If (_dt.Rows.Count > 0) Then
            If (checkUnaVendedor.Checked And CheckUnaCliente.Checked And tbCodigoVendedor.Text.Length > 0 And tbCodCliente.Text.Length > 0) Then
                Dim objrep As New R_ResumenCreditoCliente1
                objrep.SetDataSource(_dt)
                Dim fechaI As String = tbFechaI.Value.ToString("dd/MM/yyyy")
                Dim fechaF As String = tbFechaF.Value.ToString("dd/MM/yyyy")
                objrep.SetParameterValue("usuario", L_Usuario)
                objrep.SetParameterValue("fechaI", fechaI)
                objrep.SetParameterValue("fechaF", fechaF)
                objrep.SetParameterValue("vendedor", Vendedor)
                objrep.SetParameterValue("cliente", Cliente)
                MReportViewer.ReportSource = objrep
                MReportViewer.Show()
                MReportViewer.BringToFront()
            Else
                Dim objrep As New R_ResumenCreditoVendedor
                objrep.SetDataSource(_dt)
                Dim fechaI As String = tbFechaI.Value.ToString("dd/MM/yyyy")
                Dim fechaF As String = tbFechaF.Value.ToString("dd/MM/yyyy")
                objrep.SetParameterValue("usuario", L_Usuario)
                objrep.SetParameterValue("fechaI", fechaI)
                objrep.SetParameterValue("fechaF", fechaF)
                MReportViewer.ReportSource = objrep
                MReportViewer.Show()
                MReportViewer.BringToFront()
            End If


        Else
            ToastNotification.Show(Me, "NO HAY DATOS PARA LOS PARAMETROS SELECCIONADOS..!!!",
                                       My.Resources.INFORMATION, 2000,
                                       eToastGlowColor.Blue,
                                       eToastPosition.BottomLeft)
            MReportViewer.ReportSource = Nothing
        End If
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        _prCargarReporte()
    End Sub

    Private Sub PR_ResumenCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
    End Sub

    Private Sub checkUnaVendedor_CheckValueChanged(sender As Object, e As EventArgs) Handles checkUnaVendedor.CheckValueChanged
        If (checkUnaVendedor.Checked) Then
            CheckTodosVendedor.CheckValue = False
            tbVendedor.Enabled = True
            tbVendedor.BackColor = Color.White
            tbVendedor.Focus()
        End If
    End Sub

    Private Sub CheckTodosVendedor_CheckValueChanged(sender As Object, e As EventArgs) Handles CheckTodosVendedor.CheckValueChanged
        If (CheckTodosVendedor.Checked) Then
            checkUnaVendedor.CheckValue = False
            tbVendedor.Enabled = True
            tbVendedor.BackColor = Color.Gainsboro
            tbVendedor.Clear()
            tbCodigoVendedor.Clear()

        End If
    End Sub

    Private Sub CheckUnaALmacen_CheckValueChanged(sender As Object, e As EventArgs) Handles CheckUnaCliente.CheckValueChanged
        If (CheckUnaCliente.Checked) Then
            CheckTodoCliente.CheckValue = False
            tbClientes.Enabled = True
            tbCliente.BackColor = Color.White
            tbClientes.BackColor = Color.White
            tbClientes.Focus()
            tbClientes.ReadOnly = False
            _prCargarComboLibreriaSucursal(tbCliente)
            If (CType(tbCliente.DataSource, DataTable).Rows.Count > 0) Then
                tbCliente.SelectedIndex = 0

            End If
        End If
    End Sub

    Private Sub CheckTodosAlmacen_CheckValueChanged(sender As Object, e As EventArgs) Handles CheckTodoCliente.CheckValueChanged
        If (CheckTodoCliente.Checked) Then
            CheckUnaCliente.CheckValue = False
            tbCliente.Enabled = True
            tbCliente.BackColor = Color.Gainsboro
            tbClientes.BackColor = Color.Gainsboro
            tbClientes.Clear()
            tbCliente.ReadOnly = True
            _prCargarComboLibreriaSucursal(tbCliente)
            CType(tbCliente.DataSource, DataTable).Rows.Clear()
            tbCliente.SelectedIndex = -1

        End If
    End Sub

    Private Sub _prCargarComboLibreriaSucursal(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_fnListarSucursales()
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("aanumi").Width = 60
            .DropDownList.Columns("aanumi").Caption = "COD"
            .DropDownList.Columns.Add("aabdes").Width = 500
            .DropDownList.Columns("aabdes").Caption = "SUCURSAL"
            .ValueMember = "aanumi"
            .DisplayMember = "aabdes"
            .DataSource = dt
            .Refresh()
        End With
    End Sub

    Private Sub tbVendedor_KeyDown_1(sender As Object, e As KeyEventArgs) Handles tbVendedor.KeyDown
        If (checkUnaVendedor.Checked) Then
            If e.KeyData = Keys.Control + Keys.Enter Then
                Dim dt As DataTable
                dt = L_fnMostrarEmpleadoVendedor()
                Dim listEstCeldas As New List(Of Modelo.Celda)
                listEstCeldas.Add(New Modelo.Celda("ecId", True, "ID", 50))
                listEstCeldas.Add(New Modelo.Celda("ecNomb", True, "Nombre", 180))
                listEstCeldas.Add(New Modelo.Celda("ec_lbIdLib", False, "ec_lbIdLib", 180))
                listEstCeldas.Add(New Modelo.Celda("lbdesc", True, "Tipo de Empleado", 180))
                listEstCeldas.Add(New Modelo.Celda("ecCi", True, "N. Documento", 100))
                listEstCeldas.Add(New Modelo.Celda("ecDir", False, "Direccion", 180))
                listEstCeldas.Add(New Modelo.Celda("ecTelf", True, "Teléfono", 180))
                listEstCeldas.Add(New Modelo.Celda("ecMail", False, "ecMail", 180))
                listEstCeldas.Add(New Modelo.Celda("ecEst", False, "ecEst".ToUpper, 150))
                listEstCeldas.Add(New Modelo.Celda("Estado", True, "Estado", 150))
                listEstCeldas.Add(New Modelo.Celda("ecFNac", True, "F.de Nacimiento", 150))
                listEstCeldas.Add(New Modelo.Celda("ecFIngr", False, "F.de Ingreso".ToUpper, 150))
                listEstCeldas.Add(New Modelo.Celda("ecImg", False, "ecImg".ToUpper, 150))
                listEstCeldas.Add(New Modelo.Celda("ecFecha", False, "ecImg".ToUpper, 150))
                listEstCeldas.Add(New Modelo.Celda("ecHora", False, "ecImg".ToUpper, 150))
                listEstCeldas.Add(New Modelo.Celda("ecUsuario", False, "ecImg".ToUpper, 150))
                Dim ef = New Efecto
                ef.tipo = 3
                ef.dt = dt
                ef.SeleclCol = 1
                ef.listEstCeldas = listEstCeldas
                ef.alto = 50
                ef.ancho = 260
                ef.Context = "Seleccione Vendedor".ToUpper
                ef.ShowDialog()
                Dim bandera As Boolean = False
                bandera = ef.band
                If (bandera = True) Then
                    Dim Row As Janus.Windows.GridEX.GridEXRow = ef.Row
                    If (IsNothing(Row)) Then
                        tbVendedor.Focus()
                        Return
                    End If
                    tbCodigoVendedor.Text = Row.Cells("ecId").Value
                    tbVendedor.Text = Row.Cells("ecNomb").Value
                    btnGenerar.Focus()
                End If

            End If

        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub tbClientes_KeyDown(sender As Object, e As KeyEventArgs) Handles tbClientes.KeyDown
        If (CheckUnaCliente.Checked) Then
            If e.KeyData = Keys.Control + Keys.Enter Then
                Dim dt As DataTable
                dt = L_fnMostrarClientes()
                'caid, caci, canomb, caapell, cadir, catelf, camail, cafecha, cahora, causuario
                Dim listEstCeldas As New List(Of Modelo.Celda)
                listEstCeldas.Add(New Modelo.Celda("caid,", False, "ID", 50))
                listEstCeldas.Add(New Modelo.Celda("caci", True, "CI", 80))
                listEstCeldas.Add(New Modelo.Celda("canomb", True, "NOMBRE", 180))
                listEstCeldas.Add(New Modelo.Celda("caapell", True, "APELLIDOS", 280))
                listEstCeldas.Add(New Modelo.Celda("cadir", True, "DIRECCION".ToUpper, 150))
                listEstCeldas.Add(New Modelo.Celda("catelf", True, "TELEFONO", 220))
                listEstCeldas.Add(New Modelo.Celda("camail", True, "E MAIL".ToUpper, 200))
                listEstCeldas.Add(New Modelo.Celda("cafecha", False, "FECHA".ToUpper, 150, "MM/dd,YYYY"))
                listEstCeldas.Add(New Modelo.Celda("cahora,", False, "ID", 50))
                listEstCeldas.Add(New Modelo.Celda("causuario,", False, "ID", 50))
                Dim ef = New Efecto
                ef.tipo = 5
                ef.dt = dt
                ef.SeleclCol = 2
                ef.listEstCeldas = listEstCeldas
                ef.alto = 50
                ef.ancho = 300
                ef.NameLabel = "APELLIDOS :"
                ef.NamelColumna = "caapell"
                ef.Context = "Seleccione Cliente".ToUpper
                ef.ShowDialog()
                Dim bandera As Boolean = False
                bandera = ef.band
                If (bandera = True) Then
                    Try
                        Dim Row As Janus.Windows.GridEX.GridEXRow = ef.Row
                        tbCodCliente.Text = Row.Cells("caid").Value
                        tbClientes.Text = Row.Cells("canomb").Value + " " + Row.Cells("caapell").Value
                    Catch ex As Exception
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub PR_ResumenCaja_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        _prCambiarColorPlomoOscuro(Presentacion.Principal.btnReportePagos)
    End Sub
End Class