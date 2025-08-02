Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX
Imports Logica.AccesoLogica
Public Class F_Fic_FichaAtencionCliente
#Region "Variables"
    Public _nameButton As String
    Public idVet As String
    Public NombVet As String
#End Region
#Region "Eventos"
    Private Sub btnAbrirFicha_Click(sender As Object, e As EventArgs) Handles btnAbrirFicha.Click
        Modelo.MGlobal._nameButton = Principal.btnFichaClinica.Name
        Dim dtVeterinario As DataTable = L_ObtenerVeterinario(L_Usuario)
        If dtVeterinario.Rows.Count > 0 Then
            idVet = dtVeterinario.Rows(0).Item("ua_ecId")
            NombVet = dtVeterinario.Rows(0).Item("ecNomb")
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "Su usuario no está enlazado a un Veterinario, no puede abrir ficha".ToUpper, img, 4500, eToastGlowColor.Red, eToastPosition.TopCenter)
            Exit Sub
        End If

        L_fnActualizarEstadoFicha(JGFichasAtencion.GetValue("faid"))
        '_prCargarFichaAtencion()

        If JGFichasAtencion.RowCount > 0 Then
            Dim frm As New F1_Fic_FichaClinica
            Dim _fbId As Integer
            'Verificamos si el paciente tiene alguna Ficha CLinica y obtiene su codigo si tiene
            If L_fnMostrarIdFichaClinica(_fbId, JGFichasAtencion.GetValue("pbid")) Then
                If (MessageBox.Show("Desea abrir una nueva ficha clinica", "Pregunta..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                    'Nueva Ficha
                    frm._IdPaciente = JGFichasAtencion.GetValue("pbid")
                    frm._Paciente = JGFichasAtencion.GetValue("pbnomb")
                    frm._faId = JGFichasAtencion.GetValue("faid")
                    frm._Iniciar = 1
                    frm._fbEstado = IIf(JGFichasAtencion.GetValue("EstadoPaciente") = "Emergencia", 3, 1)
                    frm._Consultorio = JGFichasAtencion.GetValue("faConsultorio")
                    frm._IdVeterinario = idVet
                    frm._NombreVeterinario = NombVet
                Else
                    'Modificar ficha
                    frm._fbId = _fbId
                    frm._faId = JGFichasAtencion.GetValue("faid")
                    frm._Iniciar = 2
                    frm._fbEstado = IIf(JGFichasAtencion.GetValue("EstadoPaciente") = "Emergencia", 3, 2)

                End If
            Else
                'Nueva Ficha
                frm._IdPaciente = JGFichasAtencion.GetValue("pbid")
                frm._Paciente = JGFichasAtencion.GetValue("pbnomb")
                frm._faId = JGFichasAtencion.GetValue("faid")
                frm._Iniciar = 1
                frm._fbEstado = frm._Iniciar = IIf(JGFichasAtencion.GetValue("EstadoPaciente") = "Emergencia", 3, 1)
                frm._Consultorio = JGFichasAtencion.GetValue("faConsultorio")
                frm._IdVeterinario = idVet
                frm._NombreVeterinario = NombVet
            End If
            frm.Show()
            frm.txtHistoria.Focus()
            Me.Refresh()
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "La ficha de atención se encuentra vacía".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)
        End If
    End Sub
    Private Sub F_Fic_FichaAtencion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prCargarFichaAtencion()
    End Sub
    Private Sub TmActualizar_Tick(sender As Object, e As EventArgs) Handles TmActualizar.Tick
        _prCargarFichaAtencion()
    End Sub
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        _prCargarFichaAtencion()
    End Sub
    Private Sub JGFichasAtencion_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGFichasAtencion.EditingCell
        e.Cancel = True
    End Sub
    Private Sub btnArriba_Click(sender As Object, e As EventArgs) Handles btnArriba.Click
        If JGFichasAtencion.RowCount <> 0 Then
            If JGFichasAtencion.Row > 0 Then
                Dim dt As DataTable = CType(JGFichasAtencion.DataSource, DataTable)
                'Obtiene una fila anterior
                Dim result As DataRow() = dt.Select("faPriori=" + Convert.ToString(JGFichasAtencion.GetValue("faPriori") - 1))
                'Pregunta por fila actial
                If JGFichasAtencion.GetValue("EstadoPaciente") <> "EMERGENCIA" Then
                    'Pregunta por la fila anterior
                    If (result(0).Item("EstadoPaciente").ToString() <> "EMERGENCIA") Then
                        L_fnModificarOrdenacionFichaAtencion(JGFichasAtencion.GetValue("faid"), JGFichasAtencion.GetValue("faPriori"), 1)
                        _prCargarFichaAtencion()
                    Else
                        Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                        ToastNotification.Show(Me, "No es posible subir el registro".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)
                    End If
                Else
                    L_fnModificarOrdenacionFichaAtencion(JGFichasAtencion.GetValue("faid"), JGFichasAtencion.GetValue("faPriori"), 1)
                    _prCargarFichaAtencion()
                End If
            Else
                Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                ToastNotification.Show(Me, "No es posible subir el registro".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)
            End If
        End If
    End Sub

    Private Sub btnAbajo_Click(sender As Object, e As EventArgs) Handles btnAbajo.Click
        If JGFichasAtencion.RowCount <> 0 Then
            If JGFichasAtencion.Row <> JGFichasAtencion.RowCount - 1 Then
                L_fnModificarOrdenacionFichaAtencion(JGFichasAtencion.GetValue("faid"), JGFichasAtencion.GetValue("faPriori"), 2)
                _prCargarFichaAtencion()
            Else
                Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                ToastNotification.Show(Me, "No es posible bajar el registro".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)
            End If
        End If
    End Sub
#End Region
#Region "Metodos Privados"
    Public Sub _prCargarFichaAtencion()
        Dim tFichaClinica As DataTable = L_fnMostrarListaFichaAtencion()
        JGFichasAtencion.DataSource = tFichaClinica
        JGFichasAtencion.RetrieveStructure()
        JGFichasAtencion.AlternatingColors = True



        With JGFichasAtencion.RootTable.Columns("faPriori")
            .Width = 70
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "Número"
            .Visible = True
        End With
        With JGFichasAtencion.RootTable.Columns("faid")
            .Width = 70
            .Caption = "Id" 'Id Ficha Atencion
            .Visible = False
        End With
        With JGFichasAtencion.RootTable.Columns("caid")
            .Width = 70
            .Caption = "Id Propietario"
            .Visible = False
        End With
        With JGFichasAtencion.RootTable.Columns("Propietario")
            .Width = 350
            .Caption = "Propietario"
                .Visible = True
            End With
            With JGFichasAtencion.RootTable.Columns("pbid")
                .Width = 70
                .Caption = "Id Mascota"
                .Visible = False
            End With
            With JGFichasAtencion.RootTable.Columns("pbnomb")
                .Width = 220
                .Caption = "Paciente"
                .Visible = True
            End With
            With JGFichasAtencion.RootTable.Columns("Estado")
                .Width = 140
                .Caption = "Estado"
                .Visible = True
            End With
            With JGFichasAtencion.RootTable.Columns("EstadoPaciente")
                .Width = 170
                .Caption = "Estado de Paciente"
                .Visible = True
            End With
            With JGFichasAtencion.RootTable.Columns("fa_fbId")
                .Width = 140
                .Caption = "IdFicha"
                .Visible = False
            End With
        With JGFichasAtencion.RootTable.Columns("faFechaAten")
            .Width = 135
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "Fecha Atención"
            .Visible = True
        End With
        With JGFichasAtencion.RootTable.Columns("fbFechaProx")
            .Width = 145
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                .Caption = "Fecha Reconsulta"
                .Visible = True
            End With
            With JGFichasAtencion.RootTable.Columns("faConsultorio")
                .Caption = "IdConsul"
                .Visible = False
            End With
            With JGFichasAtencion.RootTable.Columns("ccNro")
                .Width = 130
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                .Caption = "Consultorio Nro."
                .Visible = True
            End With
            With JGFichasAtencion
                .DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
                .FilterMode = FilterMode.Automatic
                .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
                .GroupByBoxVisible = False
                'diseño de la grilla
                .VisualStyle = VisualStyle.Office2007
            End With
        _prAplicarCondiccionJanusSinLote()
        If tFichaClinica.Rows.Count > 0 Then
            JGFichasAtencion.Row = JGFichasAtencion.RowCount - 1
        End If
    End Sub
    Public Sub _prAplicarCondiccionJanusSinLote()
        Dim fc As GridEXFormatCondition
        fc = New GridEXFormatCondition(JGFichasAtencion.RootTable.Columns("Estado"), ConditionOperator.Equal, "EN ESPERA")
        'fc.FormatStyle.FontBold = TriState.True
        fc.FormatStyle.ForeColor = Color.White
        fc.FormatStyle.BackColor = Color.Orange
        JGFichasAtencion.RootTable.FormatConditions.Add(fc)
        fc = New GridEXFormatCondition(JGFichasAtencion.RootTable.Columns("EstadoPaciente"), ConditionOperator.Equal, "EMERGENCIA")
        'fc.FormatStyle.FontBold = TriState.True
        fc.FormatStyle.ForeColor = Color.White
        fc.FormatStyle.BackColor = Color.Red
        JGFichasAtencion.RootTable.FormatConditions.Add(fc)
        fc = New GridEXFormatCondition(JGFichasAtencion.RootTable.Columns("Estado"), ConditionOperator.Equal, "ATENDIDO")
        'fc.FormatStyle.FontBold = TriState.True
        fc.FormatStyle.ForeColor = Color.White
        fc.FormatStyle.BackColor = Color.Green
        JGFichasAtencion.RootTable.FormatConditions.Add(fc)
        fc = New GridEXFormatCondition(JGFichasAtencion.RootTable.Columns("Estado"), ConditionOperator.Equal, "EN ATENCION")
        'fc.FormatStyle.FontBold = TriState.True
        fc.FormatStyle.ForeColor = Color.White
        fc.FormatStyle.BackColor = Color.SteelBlue
        JGFichasAtencion.RootTable.FormatConditions.Add(fc)
    End Sub

    Private Sub F_Fic_FichaAtencion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        _prCambiarColorPlomoOscuro(Presentacion.Principal.btnFichaAtencion)
    End Sub

#End Region
#Region "Metodos Overridable"

#End Region

End Class