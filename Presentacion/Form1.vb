Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX
Imports Logica.AccesoLogica
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Pruebas de subida Raul
        'Pruebas Lily
        _prCargarFichaAtencion()
    End Sub
    'cambioooos
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
            .Width = 180
            .Caption = "Propietario"
            .Visible = True
        End With
        With JGFichasAtencion.RootTable.Columns("pbid")
            .Width = 70
            .Caption = "Id Mascota"
            .Visible = False
        End With
        With JGFichasAtencion.RootTable.Columns("pbnomb")
            .Width = 170
            .Caption = "Nombre de máscota"
            .Visible = True
        End With
        With JGFichasAtencion.RootTable.Columns("Estado")
            .Width = 140
            .Caption = "Estado"
            .Visible = True
        End With
        With JGFichasAtencion.RootTable.Columns("EstadoPaciente")
            .Width = 140
            .Caption = "Estado de paciente"
            .Visible = True
        End With
        With JGFichasAtencion.RootTable.Columns("fa_fbId")
            .Width = 140
            .Caption = "IdFicha"
            .Visible = False
        End With
        With JGFichasAtencion.RootTable.Columns("faFechaAten")
            .Width = 130
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "Fecha de atención"
            .Visible = True
        End With
        With JGFichasAtencion.RootTable.Columns("fbFechaProx")
            .Width = 130
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "Fecha de reconsulta"
            .Visible = True
        End With
        With JGFichasAtencion
            '.DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            '.FilterMode = FilterMode.Automatic
            '.FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            '.GroupByBoxVisible = False
            ''diseño de la grilla
            '.VisualStyle = VisualStyle.Office2007
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            JGFichasAtencion.VisualStyle = VisualStyle.Office2007
        End With
        _prAplicarCondiccionJanusSinLote()
    End Sub

    Public Sub _prAplicarCondiccionJanusSinLote()
        Dim fc As GridEXFormatCondition
        fc = New GridEXFormatCondition(JGFichasAtencion.RootTable.Columns("Estado"), ConditionOperator.Equal, "EN ESPERA")
        'fc.FormatStyle.FontBold = TriState.True
        fc.FormatStyle.ForeColor = Color.Black
        fc.FormatStyle.BackColor = Color.Orange
        JGFichasAtencion.RootTable.FormatConditions.Add(fc)
        fc = New GridEXFormatCondition(JGFichasAtencion.RootTable.Columns("EstadoPaciente"), ConditionOperator.Equal, "EMERGENCIA")
        'fc.FormatStyle.FontBold = TriState.True
        fc.FormatStyle.ForeColor = Color.Black
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
        fc.FormatStyle.BackColor = Color.YellowGreen
        JGFichasAtencion.RootTable.FormatConditions.Add(fc)
    End Sub
End Class