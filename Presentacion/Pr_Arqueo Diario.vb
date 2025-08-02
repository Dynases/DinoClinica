Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Public Class Pr_ArqueoDiario
    Public _nameButton As String
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem

    Public Sub _prIniciarTodo()
        tbFechaI.Value = Now.Date
        tbFechaF.Value = Now.Date

        _PMIniciarTodo()
        'L_prAbrirConexion(gs_Ip, gs_UsuarioSql, gs_ClaveSql, gs_NombreBD)
        Me.Text = "ARQUEO DIARIO"
        MReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        _IniciarComponentes()
    End Sub
    Public Sub _IniciarComponentes()
        _prCargarComboLibreriaTurno(cbTurno)
        _prCargarComboLibreriaSucursal(cbSucursal)
        'cbTurno.ReadOnly = True
        'cbTurno.Enabled = False
    End Sub

    Private Sub _prCargarReporte()
        Dim _dt As New DataTable
        _dt = L_ArqueoDiarioTurno(tbFechaI.Value.ToString("yyyy/MM/dd"), tbFechaF.Value.ToString("yyyy/MM/dd"), 1, cbSucursal.Value)

        'If (_dt.Rows.Count > 0 And _dt.Rows(0).Item("Importe") > 0) Then
        If (_dt.Rows.Count > 0) Then
            Dim TotalIngresos As Decimal = _dt.Compute("SUM(Importe)", "Glosa='10 TOTAL INGRESOS'")
            Dim TotalEgresos As Decimal = _dt.Compute("SUM(Importe)", "Glosa='11 TOTAL EGRESOS'")
            Dim Total As Decimal = TotalIngresos - TotalEgresos

            Dim objrep As New R_ArqueoDiario
            objrep.SetDataSource(_dt)
            Dim fechaI As String = tbFechaI.Value.ToString("dd/MM/yyyy")
            Dim fechaF As String = tbFechaF.Value.ToString("dd/MM/yyyy")
            objrep.SetParameterValue("usuario", L_Usuario)
            objrep.SetParameterValue("fechaI", fechaI)
            objrep.SetParameterValue("fechaF", fechaF)
            objrep.SetParameterValue("Turno", "General")
            objrep.SetParameterValue("Almacen", cbSucursal.Text)
            objrep.SetParameterValue("TotalIngresos", TotalIngresos)
            objrep.SetParameterValue("TotalEgresos", TotalEgresos)
            objrep.SetParameterValue("Total", Total)
            MReportViewer.ReportSource = objrep
            MReportViewer.Show()
            MReportViewer.BringToFront()
        Else
            ToastNotification.Show(Me, "NO HAY DATOS PARA LOS PARAMETROS SELECCIONADOS..!!!",
                                       My.Resources.INFORMATION, 2000,
                                       eToastGlowColor.Blue,
                                       eToastPosition.TopCenter)
            MReportViewer.ReportSource = Nothing
        End If
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        'If cbTurno.Text = String.Empty Then
        '    ToastNotification.Show(Me, "Debe Seleccionar un Turno..!!!".ToUpper,
        '                               My.Resources.INFORMATION, 2000,
        '                               eToastGlowColor.Blue,
        '                               eToastPosition.TopCenter)
        'Else
        If cbSucursal.Text = String.Empty Then
                ToastNotification.Show(Me, "Debe Seleccionar un Almacen-Sucursal..!!!".ToUpper,
                                           My.Resources.INFORMATION, 2000,
                                           eToastGlowColor.Blue,
                                           eToastPosition.TopCenter)

            Else
                _prCargarReporte()
        End If
    End Sub

    Private Sub PR_ResumenCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
    End Sub


    Private Sub _prCargarComboLibreriaTurno(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_DeterminarTurno()
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("haIdTurno").Width = 60
            .DropDownList.Columns("haIdTurno").Caption = "COD"
            .DropDownList.Columns.Add("haTurno").Width = 90
            .DropDownList.Columns("haTurno").Caption = "RECIBO"
            .ValueMember = "haIdTurno"
            .DisplayMember = "haTurno"
            .DataSource = dt
            .Refresh()
        End With
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Pr_ArqueoDiario_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        _prCambiarColorPlomoOscuro(Presentacion.Principal.btnArqueoDiario)
    End Sub
End Class