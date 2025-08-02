Imports Janus.Windows.GridEX
Imports Modelo.MGlobal
Imports Logica.AccesoLogica

Public Class Modelo3
#Region "VARIABLES LOCALES"
    Public _MPos As Integer
    Public _MNuevo As Boolean
    Public _MModificar As Boolean
    Public _MListEstBuscador As List(Of Celda)

#End Region
#Region "METODOS PRIVADOS"
    Public Sub _PMIniciarTodo()
        TxtNombreUsu.Text = MGlobal.gs_usuario
        TxtNombreUsu.ReadOnly = True
        _MListEstBuscador = _PMOGetListEstructuraBuscador()
        _PMFiltrar()
        _PMInhabilitar()
        _PMOHabilitarFocus()
        ' AddHandler JGrM_Buscador.SelectionChanged, AddressOf JGrM_Buscador_SelectionChanged
    End Sub
    Private Sub _PMCargarBuscador()

        Dim dtBuscador As DataTable = _PMOGetTablaBuscador()
        JGrM_Buscador.DataSource = dtBuscador
        JGrM_Buscador.RetrieveStructure() 'Recuperar estructura

        For i = 0 To _MListEstBuscador.Count - 1
            Dim campo As String = _MListEstBuscador.Item(i).campo
            With JGrM_Buscador.RootTable.Columns(campo)
                If _MListEstBuscador.Item(i).visible = True Then
                    .Caption = _MListEstBuscador.Item(i).titulo
                    .Width = _MListEstBuscador.Item(i).tamano
                    .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center

                    Dim col As DataColumn = dtBuscador.Columns(campo)
                    Dim tipo As Type = col.DataType 'Formato el dato
                    If tipo.ToString = "System.Int32" Or tipo.ToString = "System.Decimal" Or tipo.ToString = "System.Double" Then
                        .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                    End If 'Formato string
                    If _MListEstBuscador.Item(i).formato <> String.Empty Then
                        .FormatString = _MListEstBuscador.Item(i).formato
                    End If
                Else
                    .Visible = False
                End If
            End With
        Next

        'Habilitar Filtradores
        With JGrM_Buscador
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With

    End Sub
    Private Sub _PMNuevo()
        _MNuevo = True
        _PMOLimpiar()
        _PMHabilitar()
        _PMONuevo()
        'MRlAccion.Text = "NUEVO"
        '_PMOLimpiar()
    End Sub
    Private Sub _PMModificar()
        _MNuevo = False
        _PMHabilitar()
        _PMOModificar()
        'MRlAccion.Text = "MODIFICAR"
    End Sub
    Private Sub _PMEliminar()
        _PMOEliminarRegistro()
    End Sub
    Private Sub _PMGuardar()
        If _PMOValidarCampos() = False Then
            Exit Sub
        End If
        'Registro o modificacion
        If _MNuevo = True Then
            _PMOGrabarRegistro()
        Else
            _PMInhabilitar()
            _PMOModificarRegistro()
        End If
    End Sub
    Private Sub _PMHabilitar()
        JGrM_Buscador.Enabled = False
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnGrabar.Enabled = True
        PanelNavegacion.Enabled = False
    End Sub
    Public Sub _PMInhabilitar()
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        btnGrabar.Enabled = False
        PanelNavegacion.Enabled = True
        JGrM_Buscador.Enabled = True
    End Sub
    Public Sub _PMFiltrar()
        'cargo el buscador
        _PMCargarBuscador()
        If JGrM_Buscador.RowCount > 0 Then
            _MPos = 0
            _PMOMostrarRegistro(_MPos)
        Else
            _PMOLimpiar()
            LblPaginacion.Text = "0/0"
        End If
    End Sub
    Public Sub _PMAsignarPermisos()
        TxtNombreUsu.Text = MGlobal.gs_usuario
        Dim dtRolUsu As DataTable = L_prRolDetalleGeneral(MGlobal.gi_userRol, _nameButton)

        Dim show As Boolean = dtRolUsu.Rows(0).Item("ycshow")
        Dim add As Boolean = dtRolUsu.Rows(0).Item("ycadd")
        Dim modif As Boolean = dtRolUsu.Rows(0).Item("ycmod")
        Dim del As Boolean = dtRolUsu.Rows(0).Item("ycdel")

        If add = False Then
            btnNuevo.Visible = False
        End If
        If modif = False Then
            btnModificar.Visible = False
        End If
        If del = False Then
            btnEliminar.Visible = False
        End If
    End Sub
#End Region
#Region "METODOS OVERRIDABLES"
    Public Overridable Function _PMOGetTablaBuscador() As DataTable
        Return New DataTable
    End Function
    Public Overridable Sub _PMOMostrarRegistro(_N As Integer)
    End Sub
    Public Overridable Function _PMOGetListEstructuraBuscador() As List(Of Celda)
        Return Nothing
    End Function
    Public Overridable Function _PMOGrabarRegistro() As Boolean
        Return False
    End Function
    Public Overridable Function _PMOValidarCampos() As Boolean
        Return False
    End Function
    Public Overridable Function _PMOModificarRegistro() As Boolean
        Return False
    End Function
    Public Overridable Sub _PMOEliminarRegistro()
    End Sub
    Public Overridable Sub _PMOHabilitarFocus()
    End Sub
    Public Overridable Sub _PMONuevo()
    End Sub
    Public Overridable Sub _PMOModificar()
    End Sub
    Public Overridable Sub _PMOLimpiar()
    End Sub
    Public Overridable Sub _PMOHabilitar()
    End Sub
    Public Overridable Sub _PMOInhabilitar()
    End Sub
    Public Overridable Sub _PMOLimpiarErrores()
        'SE USA
    End Sub
    Public Overridable Sub _PMOSalir()

    End Sub
#End Region
#Region "EVENTOS"
    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        _PMGuardar()
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        _PMNuevo()
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        _PMModificar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        _PMEliminar()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If btnGrabar.Enabled = True Then
            _PMInhabilitar()
            _PMOSalir()
            ' _PMPrimerRegistro() Nohay un Grilla para recorrer los datos
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Modelo0_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If (gs_mayusculas <> 0) Then
            e.KeyChar = e.KeyChar.ToString.ToUpper
        End If
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            e.Handled = True
            P_Moverenfoque()
        End If
    End Sub
    Private Sub P_Moverenfoque()
        SendKeys.Send("{TAB}")
    End Sub

    Private Sub JGrM_Buscador_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGrM_Buscador.EditingCell
        e.Cancel = True
    End Sub
    Private Sub MFlyoutUsuario_PrepareContent(sender As Object, e As EventArgs) Handles MFlyoutUsuario.PrepareContent
        If sender Is BubbleBarUsuario And btnGrabar.Enabled = False Then
            MFlyoutUsuario.BorderColor = Color.FromArgb(&HC0, 0, 0)
            MFlyoutUsuario.Content = PanelUsuario
        End If
    End Sub


#End Region


End Class