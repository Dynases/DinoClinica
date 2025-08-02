Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX
Imports System.IO

Public Class F1_Con_Consultorios
#Region "VARIABLES"
    Public _MPos As Integer
    Private _Limpiar As Boolean
    Dim Modificado As Boolean = False
    Public Modificar As Boolean = False
#End Region


#Region "METODOS PRIVADOS"
    Private Sub _prIniciarTodo()
        _prInhabilitar()
        _PMAsignarPermisos()
        _prCargarConsultorios()
        _prMostrarUsuario(0)
        _prCargarIcono()
    End Sub

    Private Sub _PCargarComboRol(ByVal cb As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim _Ds As New DataSet
        _Ds = L_Rol_General(0)

        cb.DropDownList.Columns.Clear()

        cb.DropDownList.Columns.Add(_Ds.Tables(0).Columns("ybnumi").ToString).Width = 60
        cb.DropDownList.Columns(0).Caption = "Código".ToUpper
        cb.DropDownList.Columns.Add(_Ds.Tables(0).Columns("ybrol").ToString).Width = 200
        cb.DropDownList.Columns(1).Caption = "Rol".ToUpper

        cb.ValueMember = _Ds.Tables(0).Columns("ybnumi").ToString
        cb.DisplayMember = _Ds.Tables(0).Columns("ybrol").ToString
        cb.DataSource = _Ds.Tables(0)
        cb.Refresh()
    End Sub
    Private Sub _prInhabilitar()
        txtIdConsultorio.ReadOnly = True
        dtpFecha.Enabled = False
        txtNro.ReadOnly = True
        swEstado.Enabled = False
        JGBusqConsultorios.Enabled = True
        _Limpiar = False
    End Sub
    Private Sub _prLimpiar()
        txtIdConsultorio.Clear()
        dtpFecha.Value = Now.Date
        txtNro.ResetText()
        swEstado.Value = True

    End Sub
    Private Sub _prHabilitar()
        txtIdConsultorio.ReadOnly = True
        dtpFecha.Enabled = True
        txtNro.ReadOnly = False
        swEstado.Enabled = True
    End Sub
    Private Sub _prCargarIcono()
        Dim blah As New Bitmap(New Bitmap(My.Resources.user), 20, 20)
        Dim ico As Icon = Icon.FromHandle(blah.GetHicon())
        Me.Icon = ico
    End Sub
    Private Sub _prCargarConsultorios()
        Dim _tabla As DataTable = L_fnMostrarConsultorio()
        JGBusqConsultorios.DataSource = _tabla
        JGBusqConsultorios.RetrieveStructure()
        JGBusqConsultorios.AlternatingColors = True

        With JGBusqConsultorios.RootTable.Columns("ccId")
            .Width = 70
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "Id"
            .Visible = True
        End With
        With JGBusqConsultorios.RootTable.Columns("ccFecha")
            .Width = 90
            .Caption = "Fecha"
            .Visible = True
        End With
        With JGBusqConsultorios.RootTable.Columns("ccNro")
            .Width = 120
            .Caption = "Consul. Nro."
            .Visible = True
        End With
        With JGBusqConsultorios.RootTable.Columns("ccEst")
            .Width = 100
            .Caption = "Estado"
            .Visible = False
        End With
        With JGBusqConsultorios.RootTable.Columns("Estado")
            .Width = 90
            .Caption = "Estado"
            .Visible = True
        End With
        With JGBusqConsultorios.RootTable.Columns("ccFechaA")
            .Visible = False
        End With
        With JGBusqConsultorios.RootTable.Columns("ccHora")
            .Visible = False
        End With
        With JGBusqConsultorios.RootTable.Columns("ccUsuario")
            .Visible = False
        End With

        With JGBusqConsultorios
            .DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub
    Private Sub _prMostrarUsuario(_POS As Integer)
        If JGBusqConsultorios.RowCount <> 0 Then
            JGBusqConsultorios.Row = _POS
            With JGBusqConsultorios
                txtIdConsultorio.Text = .GetValue("ccId")
                dtpFecha.Value = .GetValue("ccFecha")
                txtNro.Text = .GetValue("ccNro")
                swEstado.Value = .GetValue("ccEst")

                LblPaginacion.Text = Str(_POS + 1) + "/" + JGBusqConsultorios.RowCount.ToString

                'Muestra el bubblebar(quien registró el usuario)
                lbFecha.Text = CType(.GetValue("ccFechaA"), Date).ToString("dd/MM/yyyy")
                lbHora.Text = .GetValue("ccHora").ToString
                lbUsuario.Text = .GetValue("ccUsuario").ToString
            End With
        End If

    End Sub

    Public Sub _prFiltrar()
        'cargo el buscador
        _prCargarConsultorios()
        If JGBusqConsultorios.RowCount > 0 Then
            _MPos = 0
            _prMostrarUsuario(_MPos)
        Else
            _prLimpiar()
            LblPaginacion.Text = "0/0"
        End If
    End Sub

#End Region

#Region "METODOS PRIVADOS OVERRRIDABLES"
    Public Overrides Sub _PMONuevo()
        _prLimpiar()
        _prHabilitar()
        JGBusqConsultorios.Enabled = False
        txtNro.Focus()
        Modificar = False
    End Sub


    Public Overrides Function _PMOValidarCampos() As Boolean
        Dim Existe As Boolean = L_fnValidarSiExisteConsultorio(txtNro.Text)
        If Modificar = False Then
            If Existe Then
                Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                ToastNotification.Show(Me, "No Puede agregar este Nro. de Consultorio porque ya existe ".ToUpper, img, 3000, eToastGlowColor.Red, eToastPosition.TopCenter)
                Return False
            End If
        End If

        Return True
    End Function
    ''*****GRABA EL REGISTRO*****''
    Public Overrides Function _PMOGrabarRegistro() As Boolean

        Dim res As Boolean = L_fnGrabarConsultorio(txtIdConsultorio.Text, dtpFecha.Value.ToString("yyyy/MM/dd"), txtNro.Text, IIf(swEstado.Value, 1, 0))
        If res Then
            Modificado = False

            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Id del Consultorio ".ToUpper + txtIdConsultorio.Text + " Grabado con éxito.".ToUpper,
                                      img, 3000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )
            txtNro.Focus()
            _prCargarConsultorios()
            _prLimpiar()
            _Limpiar = True
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "El consultorio no pudo ser insertado".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)

        End If
        Return res
    End Function
    Public Overrides Sub _PMOModificar()
        _prHabilitar()
        txtNro.ReadOnly = False
        Modificar = True
    End Sub

    ''*****MODIFICA EL REGISTRO*****''
    Public Overrides Function _PMOModificarRegistro() As Boolean
        Dim res As Boolean = L_fnModificarConsultorio(txtIdConsultorio.Text, dtpFecha.Value.ToString("yyyy/MM/dd"), txtNro.Text, IIf(swEstado.Value, 1, 0))
        If res Then
            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Id del Consultorio ".ToUpper + txtIdConsultorio.Text + " Modificado con éxito.".ToUpper,
                                      img, 3000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )
            _prFiltrar()
            _Limpiar = True
            Modificar = False
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "El consultorio no pudo ser modificado".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)
        End If
        Return res
    End Function
    ''*****ELIMINAR EL REGISTRO*****''
    Public Overrides Sub _PMOEliminarRegistro()
        Dim ef = New Efecto
        ef.tipo = 2
        ef.Context = "¿esta seguro de eliminar el registro?".ToUpper
        ef.Header = "mensaje principal".ToUpper
        ef.ShowDialog()
        Dim bandera As Boolean = False
        bandera = ef.band
        If (bandera = True) Then
            Dim mensajeError As String = ""
            Dim res As Boolean = L_fnEliminarConsultorio(txtIdConsultorio.Text, mensajeError)
            If res Then
                Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)

                ToastNotification.Show(Me, "Código del consultorio ".ToUpper + txtIdConsultorio.Text + " eliminado con éxito.".ToUpper,
                                          img, 2000,
                                          eToastGlowColor.Green,
                                          eToastPosition.TopCenter)

                _prFiltrar()
            Else
                Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                ToastNotification.Show(Me, mensajeError, img, 3000, eToastGlowColor.Red, eToastPosition.TopCenter)
            End If
        End If
    End Sub

    Public Overrides Sub _PMOSalir()
        _prInhabilitar()
        _prFiltrar()
    End Sub


#End Region

#Region "EVENTOS"

    Private Sub F1_Con_Consultorios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
    End Sub
    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        If JGBusqConsultorios.RowCount > 0 Then
            _MPos = 0
            _prMostrarUsuario(_MPos)
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If _MPos > 0 And JGBusqConsultorios.RowCount > 0 Then
            _MPos = _MPos - 1
            _prMostrarUsuario(_MPos)
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If _MPos < JGBusqConsultorios.RowCount - 1 Then
            _MPos = _MPos + 1
            _prMostrarUsuario(_MPos)
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        If JGBusqConsultorios.RowCount > 0 Then
            _MPos = JGBusqConsultorios.RowCount - 1
            _prMostrarUsuario(_MPos)
        End If
    End Sub

    Private Sub JGBusqConsultorios_SelectionChanged(sender As Object, e As EventArgs) Handles JGBusqConsultorios.SelectionChanged
        If JGBusqConsultorios.Row >= 0 And JGBusqConsultorios.RowCount > 0 Then
            _MPos = JGBusqConsultorios.Row
            _prMostrarUsuario(_MPos)
        End If
    End Sub

    Private Sub JGBusqConsultorios_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGBusqConsultorios.EditingCell
        e.Cancel = True
    End Sub

    Private Sub F1_Con_Consultorios_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        _prCambiarColorPlomoOscuro(Presentacion.Principal.btnConsultorios)
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

    End Sub










#End Region


End Class