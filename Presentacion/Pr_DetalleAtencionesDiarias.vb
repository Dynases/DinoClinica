Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Public Class Pr_DetalleAtencionesDiarias
    Public _nameButton As String
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem

    Public Sub _prIniciarTodo()
        tbFechaI.Value = Now.Date
        tbFechaF.Value = Now.Date

        _PMIniciarTodo()

        Me.Text = "DETALLE DE ATENCIONES DIARIAS"
        MReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        _IniciarComponentes()
    End Sub
    Public Sub _IniciarComponentes()
        _prCargarComboLibreriaTurno(cbTurno)
        _prCargarComboLibreriaSucursal(cbSucursal)
    End Sub

    Private Sub _prCargarReporte()
        Dim _dt As New DataTable
        _dt = L_DetalleAtencionDiarioTurno(tbFechaI.Value.ToString("yyyy/MM/dd"), tbFechaF.Value.ToString("yyyy/MM/dd"), 1, cbSucursal.Value)

        If (_dt.Rows.Count > 0) Then

            Dim objrep As New R_DetalleAtencionDiaria
            objrep.SetDataSource(_dt)
            Dim fechaI As String = tbFechaI.Value.ToString("dd/MM/yyyy")
            Dim fechaF As String = tbFechaF.Value.ToString("dd/MM/yyyy")
            objrep.SetParameterValue("usuario", L_Usuario)
            objrep.SetParameterValue("fechaI", fechaI)
            objrep.SetParameterValue("fechaF", fechaF)
            objrep.SetParameterValue("Turno", "General")
            objrep.SetParameterValue("Almacen", cbSucursal.Text)
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

    Private Sub Pr_DetalleAtencionesDiarias_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        _prCambiarColorPlomoOscuro(Presentacion.Principal.btnDetalleAtenciones)
    End Sub
End Class