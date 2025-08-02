Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX
Imports System.IO
Imports DevComponents.DotNetBar.Controls


Public Class Pr_MascotasAtendidas
    Dim Veterinario As String = ""


    Public Sub _prIniciarTodo()
        tbFechaI.Value = Now.Date
        tbFechaF.Value = Now.Date
        _PMIniciarTodo()
        _prCargarComboVeterinario(cbVeterinario)
        MReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        _IniciarComponentes()

    End Sub

    Public Sub _IniciarComponentes()
        cbVeterinario.ReadOnly = True
        cbVeterinario.Enabled = False
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

    End Sub
    Private Sub _prCargarReporte()
        Dim _dt As New DataTable
        _prInterpretarDatos1(_dt)
        If (_dt.Rows.Count > 0) Then
            Dim objrep As New R_MascotasAtendidas
            Dim FechaI As String = tbFechaI.Value.ToString("dd/MM/yyyy")
            Dim FechaF As String = tbFechaF.Value.ToString("dd/MM/yyyy")
            objrep.SetDataSource(_dt)
            objrep.SetParameterValue("fechaI", FechaI)
            objrep.SetParameterValue("fechaF", FechaF)
            objrep.SetParameterValue("Veterinario", Veterinario)
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

    Private Sub _prCargarComboVeterinario(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_fnObtenerVeterinario()
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("ecId").Width = 60
            .DropDownList.Columns("ecId").Caption = "COD"
            .DropDownList.Columns.Add("ecNomb").Width = 250
            .DropDownList.Columns("ecNomb").Caption = "NOMBRE"
            .ValueMember = "ecId"
            .DisplayMember = "ecNomb"
            .DataSource = dt
            .Refresh()
        End With

    End Sub

    Public Sub _prInterpretarDatos1(ByRef _dt As DataTable)
        Dim FechaI As String = tbFechaI.Value.ToString("yyyy/MM/dd")
        Dim FechaF As String = tbFechaF.Value.ToString("yyyy/MM/dd")

        If (CheckTodosVeterinario.Checked) Then
            Veterinario = "TODOS LOS VETERINARIOS"
            _dt = L_fnMascotasAtendidas(FechaI, FechaF)

        End If

        If (checkUnVeterinario.Checked) Then
            Veterinario = "" + cbVeterinario.Text
            _dt = L_fnUnVeterinario(FechaI, FechaF, Veterinario)

        End If

    End Sub


    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        _prCargarReporte()
    End Sub

    Private Sub Pr_MascotasAtendidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
    End Sub

    Private Sub CheckTodosVeterinario_CheckValueChanged(sender As Object, e As EventArgs) Handles CheckTodosVeterinario.CheckValueChanged
        If (CheckTodosVeterinario.Checked) Then
            checkUnVeterinario.CheckValue = False
            cbVeterinario.Enabled = True
            cbVeterinario.BackColor = Color.Gainsboro
            cbVeterinario.ReadOnly = True
            _prCargarComboVeterinario(cbVeterinario)
            CType(cbVeterinario.DataSource, DataTable).Rows.Clear()
            cbVeterinario.SelectedIndex = -1
        End If
    End Sub

    Private Sub checkUnVeterinario_CheckValueChanged(sender As Object, e As EventArgs) Handles checkUnVeterinario.CheckValueChanged
        If (checkUnVeterinario.Checked) Then
            CheckTodosVeterinario.CheckValue = False
            cbVeterinario.Enabled = True
            cbVeterinario.BackColor = Color.White
            cbVeterinario.Focus()
            cbVeterinario.ReadOnly = False
            _prCargarComboVeterinario(cbVeterinario)
            If (CType(cbVeterinario.DataSource, DataTable).Rows.Count > 0) Then
                cbVeterinario.SelectedIndex = 0
            End If
        End If

    End Sub

    Private Sub Pr_MascotasAtendidas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        _prCambiarColorPlomoOscuro(Presentacion.Principal.btnRepVetMascAten)
    End Sub
End Class