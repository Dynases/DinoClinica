Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar

Public Class Pr_PacientesPorDia
    Dim Veterinario As String = ""
    Dim Genero As String = ""

    Public Sub _prIniciarTodo()
        tbFechaI.Value = Now.Date
        tbFechaF.Value = Now.Date
        _PMIniciarTodo()
        Me.Text = "REPORTE VETERINARIO"
        MReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        _IniciarComponentes()
    End Sub

    Public Sub _IniciarComponentes()
        cbVeterinario.ReadOnly = True
        cbGenero.ReadOnly = True
        cbVeterinario.Enabled = False
        cbGenero.Enabled = False

    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

    End Sub
    Private Sub _prCargarReporte()
        Dim _dt As New DataTable
        _prInterpretarDatos(_dt)
        If (_dt.Rows.Count > 0) Then
            Dim objrep As New R_PacientesPorDia
            Dim FechaI As String = tbFechaI.Value.ToString("dd/MM/yyyy")
            Dim FechaF As String = tbFechaF.Value.ToString("dd/MM/yyyy")
            objrep.SetDataSource(_dt)
            objrep.SetParameterValue("fechaI", FechaI)
            objrep.SetParameterValue("fechaF", FechaF)
            objrep.SetParameterValue("Veterinario", Veterinario)
            objrep.SetParameterValue("Genero", Genero)
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

    Public Sub _prInterpretarDatos(ByRef _dt As DataTable)
        Dim FechaI As String = tbFechaI.Value.ToString("dd/MM/yyyy")
        Dim FechaF As String = tbFechaF.Value.ToString("dd/MM/yyyy")

        If (CheckTodosVeterinario.Checked And checkTodosGenero.Checked) Then
            Veterinario = "TODOS LOS VETERINARIOS"
            Genero = "TODAS LAS ESPECIES"
            _dt = L_fnTodosPacientesPorDia(FechaI, FechaF)

        End If
        If (checkUnVeterinario.Checked And checkTodosGenero.Checked) Then
            Genero = "TODAS LAS ESPECIES"
            Veterinario = "" + cbVeterinario.Text
            _dt = L_fnUnVeterinarioTodosGenero(FechaI, FechaF, Veterinario)

        End If
        If (checkUnVeterinario.Checked And checkUnGenero.Checked) Then
            Veterinario = "" + cbVeterinario.Text
            Genero = "" + cbGenero.Text
            _dt = L_fnUnVeterinarioUnGenero(FechaI, FechaF, Veterinario, Genero)

        End If
        If (CheckTodosVeterinario.Checked And checkUnGenero.Checked) Then
            Veterinario = "TODOS LOS VETERINARIOS"
            Genero = "" + cbGenero.Text
            _dt = L_fnTodosVeterinarioUnGenero(FechaI, FechaF, Genero)

        End If

    End Sub
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        _prCargarReporte()
    End Sub

    Private Sub Pr_PacientesPorDia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
    End Sub

    Private Sub CheckTodosGenero__CheckValueChanged(sender As Object, e As EventArgs) Handles checkTodosGenero.CheckValueChanged
        If (checkTodosGenero.Checked) Then
            checkUnGenero.CheckValue = False
            cbGenero.Enabled = True
            cbGenero.BackColor = Color.Gainsboro
            cbGenero.ReadOnly = True
            _prCargarComboLibreria(cbGenero, 2, 1)
            CType(cbGenero.DataSource, DataTable).Rows.Clear()
            cbGenero.SelectedIndex = -1
        End If
    End Sub

    Private Sub checkUnGenero_CheckedChanged(sender As Object, e As EventArgs) Handles checkUnGenero.CheckedChanged
        If (checkUnGenero.Checked) Then
            checkTodosGenero.CheckValue = False
            cbGenero.Enabled = True
            cbGenero.BackColor = Color.White
            cbGenero.Focus()
            cbGenero.ReadOnly = False
            _prCargarComboLibreria(cbGenero, 2, 1)
            If (CType(cbGenero.DataSource, DataTable).Rows.Count > 0) Then
                cbGenero.SelectedIndex = 0

            End If
        End If
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
    Private Sub checkUnVeterinario_CheckedChanged(sender As Object, e As EventArgs) Handles checkUnVeterinario.CheckedChanged
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

    Private Sub Pr_PacientesPorDia_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        _prCambiarColorPlomoOscuro(Presentacion.Principal.btnPacientesAten)
    End Sub
End Class