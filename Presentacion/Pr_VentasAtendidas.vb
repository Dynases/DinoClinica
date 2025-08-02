Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Public Class Pr_VentasAtendidas
    Public _nameButton As String
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem

    Public Sub _prIniciarTodo()
        tbFechaI.Value = Now.Date
        tbFechaF.Value = Now.Date
        _PMIniciarTodo()
        'L_prAbrirConexion(gs_Ip, gs_UsuarioSql, gs_ClaveSql, gs_NombreBD)
        Me.Text = "VENTAS ATENDIDAS"
        MReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        _IniciarComponentes()
    End Sub
    Public Sub _IniciarComponentes()
        tbClientes.ReadOnly = True
        tbRecibo.ReadOnly = True
        tbClientes.Enabled = False
        tbRecibo.Enabled = False
        CheckTodosCliente.CheckValue = True
        CheckTodoRecibo.CheckValue = True


    End Sub
    Public Sub _prInterpretarDatos(ByRef _dt As DataTable)
        'General Cliente
        If (CheckTodosCliente.Checked And CheckTodoRecibo.Checked) Then
            _dt = L_prVentasAtendidas(tbFechaI.Value.ToString("yyyy/MM/dd"), tbFechaF.Value.ToString("yyyy/MM/dd"))
        End If
        'Por Cliente
        If (checkUnaCliente.Checked And CheckTodoRecibo.Checked) Then
            If (tbCodCliente.Text.Length > 0) Then
                _dt = L_prVentasAtendidasCliente(tbFechaI.Value.ToString("yyyy/MM/dd"), tbFechaF.Value.ToString("yyyy/MM/dd"), tbCodCliente.Text)
            End If

        End If
        'Por RECIBO
        If (CheckTodosCliente.Checked And CheckUnaRecibo.Checked) Then
            If (tbRecibo.SelectedIndex >= 0) Then
                _dt = L_prVentasAtendidasRecibo(tbFechaI.Value.ToString("yyyy/MM/dd"), tbFechaF.Value.ToString("yyyy/MM/dd"), tbRecibo.Value)
            End If
        End If
        'Por cliente y RECIBO
        If (checkUnaCliente.Checked And CheckUnaRecibo.Checked) Then
            If (tbRecibo.SelectedIndex >= 0 And tbCodCliente.Text.Length > 0) Then
                _dt = L_prVentasAtendidasReciboCliente(tbFechaI.Value.ToString("yyyy/MM/dd"), tbFechaF.Value.ToString("yyyy/MM/dd"), tbRecibo.Value, tbCodCliente.Text)
            End If
        End If
    End Sub
    Private Sub _prCargarReporte()
        Dim _dt As New DataTable
        _prInterpretarDatos(_dt)
        If (_dt.Rows.Count > 0) Then
            Dim objrep As New R_VentasAtendidas
            objrep.SetDataSource(_dt)
            Dim fechaI As String = tbFechaI.Value.ToString("dd/MM/yyyy")
            Dim fechaF As String = tbFechaF.Value.ToString("dd/MM/yyyy")
            objrep.SetParameterValue("usuario", L_Usuario)
            objrep.SetParameterValue("fechaI", fechaI)
            objrep.SetParameterValue("fechaF", fechaF)
            MReportViewer.ReportSource = objrep
            MReportViewer.Show()
            MReportViewer.BringToFront()
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

    Private Sub checkUnaVendedor_CheckValueChanged(sender As Object, e As EventArgs) Handles checkUnaCliente.CheckValueChanged
        If (checkUnaCliente.Checked) Then
            CheckTodosCliente.CheckValue = False
            tbClientes.Enabled = True
            tbClientes.BackColor = Color.White
            tbClientes.Focus()

        End If
    End Sub

    Private Sub CheckTodosVendedor_CheckValueChanged(sender As Object, e As EventArgs) Handles CheckTodosCliente.CheckValueChanged
        If (CheckTodosCliente.Checked) Then
            checkUnaCliente.CheckValue = False
            tbClientes.Enabled = True
            tbClientes.BackColor = Color.Gainsboro
            tbClientes.Clear()
            tbCodCliente.Clear()

        End If
    End Sub

    Private Sub CheckUnaALmacen_CheckValueChanged(sender As Object, e As EventArgs) Handles CheckUnaRecibo.CheckValueChanged
        If (CheckUnaRecibo.Checked) Then
            CheckTodoRecibo.CheckValue = False
            tbRecibo.Enabled = True
            tbRecibo.BackColor = Color.White
            tbRecibo.Focus()
            tbRecibo.ReadOnly = False
            _prCargarComboLibreriaSucursal(tbRecibo)
            If (CType(tbRecibo.DataSource, DataTable).Rows.Count > 0) Then
                tbRecibo.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub CheckTodosAlmacen_CheckValueChanged(sender As Object, e As EventArgs) Handles CheckTodoRecibo.CheckValueChanged
        If (CheckTodoRecibo.Checked) Then
            CheckUnaRecibo.CheckValue = False
            tbRecibo.Enabled = True
            tbRecibo.BackColor = Color.Gainsboro
            tbRecibo.ReadOnly = True
            _prCargarComboLibreriaSucursal(tbRecibo)
            CType(tbRecibo.DataSource, DataTable).Rows.Clear()
            tbRecibo.SelectedIndex = -1
        End If
    End Sub

    Private Sub _prCargarComboLibreriaSucursal(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_prTipoRecibo()
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("IdRecibo").Width = 60
            .DropDownList.Columns("IdRecibo").Caption = "COD"
            .DropDownList.Columns.Add("Recibo").Width = 500
            .DropDownList.Columns("Recibo").Caption = "RECIBO"
            .ValueMember = "IdRecibo"
            .DisplayMember = "Recibo"
            .DataSource = dt
            .Refresh()
        End With
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub tbClientes_KeyDown(sender As Object, e As KeyEventArgs) Handles tbClientes.KeyDown
        If e.KeyData = Keys.Control + Keys.Enter Then
            Dim dt As DataTable
            dt = L_fnMostrarClientes()
            'caid, caci, canomb, caapell, cadir, catelf, camail, cafecha, cahora, causuario
            Dim listEstCeldas As New List(Of Modelo.Celda)
            listEstCeldas.Add(New Modelo.Celda("caid,", False, "ID", 50))
            listEstCeldas.Add(New Modelo.Celda("caci", True, "CI", 80))
            listEstCeldas.Add(New Modelo.Celda("canomb", True, "NOMBRE", 180))
            listEstCeldas.Add(New Modelo.Celda("caapell", True, "APELLIDO", 280))
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
            ef.ancho = 260
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
    End Sub

    Private Sub Pr_VentasAtendidas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        _prCambiarColorPlomoOscuro(Presentacion.Principal.btnVentasAtendidas)
    End Sub
End Class