Imports Janus.Windows.GridEX
Imports Modelo.MGlobal
Imports Logica.AccesoLogica

Public Class Modelo1

#Region "VARIABLES LOCALES"
    Public _MNuevo As Boolean

#End Region
#Region "EVENTOS"
    Private Sub Modelo1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _PMhabilitar()
        'superTabControl1.SelectedTabIndex = 0
        TxtNombreUsu.Text = gs_usuario

    End Sub
    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If _PMOValidarCampos() = False Then
            Exit Sub
        End If
        'Registro o modificacion
        If _MNuevo = True Then
            _PMOGrabarRegistro()
        Else
            _PMhabilitar()
            _PMOModificarRegistro()
        End If

    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If btnGrabar.Enabled = True Then
            _PMhabilitar()
            _PMOSalir()
            ' _PMPrimerRegistro() Nohay un Grilla para recorrer los datos
        Else
            Me.Close()
        End If
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        _MNuevo = True
        _PMInHabilitar()
        _PMONuevo()

    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        _MNuevo = False
        _PMInHabilitar()
        _PMOModificar()
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        _PMOEliminarRegistro()
    End Sub
    Private Sub ModeloHor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If (gs_mayusculas <> 0) Then
            e.KeyChar = e.KeyChar.ToString.ToUpper
        End If
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            e.Handled = True
            P_Moverenfoque()
        End If
    End Sub

#End Region
#Region "METODOS PRIVADOS"'MPR = Modelo metodos privados
    Private Sub _PMInHabilitar()
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnGrabar.Enabled = True
        PanelNavegacion.Enabled = False
        superTabItem2.Enabled = False
        _PMOLimpiarErrores()
    End Sub
    Private Sub _PMhabilitar()
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        btnGrabar.Enabled = False
        PanelNavegacion.Enabled = True
        superTabItem2.Enabled = True
    End Sub
    Private Sub P_Moverenfoque()
        SendKeys.Send("{TAB}")
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
    Public Overridable Sub _PMONuevo()
    End Sub
    Public Overridable Sub _PMOModificar()
    End Sub
    Public Overridable Function _PMOGrabarRegistro() As Boolean
        Return True
    End Function
    Public Overridable Function _PMOValidarCampos() As Boolean
        Return True
    End Function
    Public Overridable Function _PMOModificarRegistro() As Boolean
        Return True
    End Function
    Public Overridable Sub _PMOEliminarRegistro()
    End Sub
    Public Overridable Sub _PMOSalir()
    End Sub
    Public Overridable Sub _PMOHabilitar()
    End Sub
    Public Overridable Sub _PMOInHabilitar()
    End Sub
    Public Overridable Sub _PMOLimpiarErrores()

    End Sub

    Private Sub MFlyoutUsuario_PrepareContent(sender As Object, e As EventArgs) Handles MFlyoutUsuario.PrepareContent
        If sender Is BubbleBarUsuario And btnGrabar.Enabled = False Then
            MFlyoutUsuario.BorderColor = Color.FromArgb(&HC0, 0, 0)
            MFlyoutUsuario.Content = PanelUsuario
        End If
    End Sub

#End Region
End Class