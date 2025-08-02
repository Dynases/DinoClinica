Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Public Class Pr_VentasServicios
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

        tbRecibo.ReadOnly = True

        tbRecibo.Enabled = False

        CheckUnaRecibo.CheckValue = True


    End Sub
    Public Sub _prInterpretarDatos(ByRef _dt As DataTable)

        'Por RECIBO
        If (CheckUnaRecibo.Checked) Then
            If (tbRecibo.SelectedIndex >= 0) Then
                _dt = L_prVentasAtendidasServicio(tbFechaI.Value.ToString("yyyy/MM/dd"), tbFechaF.Value.ToString("yyyy/MM/dd"), tbRecibo.Value)
            End If
        Else
            _dt = L_prVentasAtendidasServicio(tbFechaI.Value.ToString("yyyy/MM/dd"), tbFechaF.Value.ToString("yyyy/MM/dd"), -1)
        End If

    End Sub
    Private Sub _prCargarReporte()
        Dim _dt As New DataTable
        _prInterpretarDatos(_dt)
        If (_dt.Rows.Count > 0) Then
            Dim objrep As New R_VentasServicios
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
        dt = L_fnListarServicio()
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("scId").Width = 60
            .DropDownList.Columns("scId").Caption = "COD"
            .DropDownList.Columns.Add("scDesc").Width = 500
            .DropDownList.Columns("scDesc").Caption = "SERVICIO"
            .ValueMember = "scId"
            .DisplayMember = "scDesc"
            .DataSource = dt
            .Refresh()
        End With
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub



    Private Sub Pr_VentasAtendidas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        _prCambiarColorPlomoOscuro(Presentacion.Principal.btnVentasAtendidas)
    End Sub
End Class