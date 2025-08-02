Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX
Imports System.IO
Public Class F1_Con_Servicios
#Region "VARIABLES"
    Public _IdCliente, _Iniciar, _MPos As Integer
    Private _Limpiar As Boolean
    Dim Modificado As Boolean = False
#End Region

#Region "EVENTOS"
    Private Sub F1_Con_Servicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
        superTabControl1.SelectedTabIndex = 0
    End Sub

    Private Sub JGServicios_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGServicios.EditingCell
        e.Cancel = True
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        If JGServicios.RowCount > 0 Then
            _MPos = 0
            _prMostrarServicio(_MPos)
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If _MPos > 0 And JGServicios.RowCount > 0 Then
            _MPos = _MPos - 1
            _prMostrarServicio(_MPos)
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If _MPos < JGServicios.RowCount - 1 Then
            _MPos = _MPos + 1
            _prMostrarServicio(_MPos)
        End If
    End Sub
    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        If JGServicios.RowCount > 0 Then
            _MPos = JGServicios.RowCount - 1
            _prMostrarServicio(_MPos)
        End If
    End Sub

    Private Sub JGServicios_SelectionChanged(sender As Object, e As EventArgs) Handles JGServicios.SelectionChanged
        If JGServicios.Row >= 0 And JGServicios.RowCount > 0 Then
            _MPos = JGServicios.Row
            _prMostrarServicio(_MPos)
        End If
    End Sub

#End Region
#Region "METODOS PRIVADOS"
    Private Sub _prIniciarTodo()
        'Carga eL Combobox
        _prInhabilitar()
        _prCargarServicio()
        _PMAsignarPermisos()
        _prMostrarServicio(0)
    End Sub
    Private Sub _prMostrarServicio(_POS As Integer)
        If JGServicios.RowCount <> 0 Then
            JGServicios.Row = _POS
            With JGServicios
                '--scId, scDesc, scPrecio, scEst, scFecha, scHora, scUsuario
                txtIdServicio.Text = .GetValue("scId")
                txtDescripcion.Text = .GetValue("scDesc")
                diPrecio.Text = .GetValue("scPrecio")
                swEstadoS.Value = .GetValue("scEst")
                LblPaginacion.Text = Str(_POS + 1) + "/" + JGServicios.RowCount.ToString
                'Muestra el bubblebar(que usuario registró el servicio)
                lbFecha.Text = CType(.GetValue("scFecha"), Date).ToString("dd/MM/yyyy")
                lbHora.Text = .GetValue("scHora").ToString
                lbUsuario.Text = .GetValue("scUsuario").ToString
            End With
        End If
    End Sub
    Private Sub _prCargarServicio()
        Dim _tabla As DataTable = L_fnMostrarServicio()
        JGServicios.DataSource = _tabla
        JGServicios.RetrieveStructure()
        JGServicios.AlternatingColors = True

        With JGServicios.RootTable.Columns("scId")
            .Width = 100
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "Id"
            .Visible = True
        End With
        With JGServicios.RootTable.Columns("scDesc")
            .Width = 200
            .Caption = "Descripción"
            .Visible = True
        End With
        With JGServicios.RootTable.Columns("scPrecio")
            .Width = 180
            .FormatString = "0.00"
            .Caption = "Precio"
            .Visible = True
        End With
        With JGServicios.RootTable.Columns("scEst")
            .Width = 150
            .Caption = "scEst"
            .Visible = False
        End With
        With JGServicios.RootTable.Columns("Estado")
            .Width = 200
            .Caption = "Estado"
            .Visible = True
        End With
        With JGServicios.RootTable.Columns("scFecha")
            .Visible = False
        End With
        With JGServicios.RootTable.Columns("scHora")
            .Visible = False
        End With
        With JGServicios.RootTable.Columns("scUsuario")
            .Visible = False
        End With
        With JGServicios
            .DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub
    Private Sub _prInHabilitar()
        txtIdServicio.ReadOnly = True
        txtDescripcion.ReadOnly = True
        diPrecio.IsInputReadOnly = True
        swEstadoS.Enabled = False
        _Limpiar = False
    End Sub
    Private Sub _prHabilitar()
        txtIdServicio.ReadOnly = False
        txtDescripcion.ReadOnly = False
        diPrecio.IsInputReadOnly = False
        swEstadoS.Enabled = True
    End Sub
    Private Sub _prLimpiar()
        txtIdServicio.Clear()
        txtDescripcion.Clear()
        diPrecio.ResetText()
        swEstadoS.Value = 1
    End Sub
    Public Sub _prFiltrar()
        'cargo el buscador
        _prCargarServicio()
        If JGServicios.RowCount > 0 Then
            _MPos = 0
            _prMostrarServicio(_MPos)
        Else
            _prLimpiar()
            LblPaginacion.Text = "0/0"
        End If
    End Sub
#End Region
#Region "METODOS PRIVADOS OVERRRIDABLES"
    Public Overrides Function _PMOGrabarRegistro() As Boolean
        Dim res As Boolean = L_fnGrabarServicio(txtIdServicio.Text,
                                                txtDescripcion.Text, diPrecio.Value, IIf(swEstadoS.Value, 1, 0))
        If res Then
            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Id del Servicio ".ToUpper + txtIdServicio.Text + " Grabado con Exito.".ToUpper,
                                      img, 3000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )
            txtDescripcion.Focus()
            _prCargarServicio()
            _prLimpiar()
            _Limpiar = True
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "El servicio no pudo ser insertado".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)

        End If
        Return res
    End Function
    ''*****MODDIFICA EL REGISTRO*****''
    Public Overrides Function _PMOModificarRegistro() As Boolean
        Dim res As Boolean = L_fnModificarServicio(txtIdServicio.Text,
                                                txtDescripcion.Text, diPrecio.Value, IIf(swEstadoS.Value, 1, 0))
        If res Then
            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Id del Servicio ".ToUpper + txtIdServicio.Text + " Modificado con Exito.".ToUpper,
                                      img, 3000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )
            _prInHabilitar()
            _prFiltrar()
            _Limpiar = True
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "El servicio no pudo ser modificado".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)

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
            Dim res As Boolean = L_fnEliminarServicio(txtIdServicio.Text, mensajeError)
            If res Then
                Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)

                ToastNotification.Show(Me, "Código del servicio ".ToUpper + txtIdServicio.Text + " eliminado con Exito.".ToUpper,
                                          img, 2000,
                                          eToastGlowColor.Green,
                                          eToastPosition.TopCenter)
                _prInHabilitar()
                _prFiltrar()
            Else
                Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                ToastNotification.Show(Me, mensajeError, img, 3000, eToastGlowColor.Red, eToastPosition.TopCenter)
            End If
        End If
    End Sub
    Public Overrides Function _PMOValidarCampos() As Boolean
        Dim _ok As Boolean = True
        MEP.Clear()
        If txtDescripcion.Text = String.Empty Then
            txtDescripcion.BackColor = Color.Red
            MEP.SetError(txtDescripcion, "ingrese una descripción!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Ingrese una  descripción del servicio para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        Else
            txtDescripcion.BackColor = Color.White
            MEP.SetError(txtDescripcion, "")
        End If
        If diPrecio.Text = String.Empty Then
            diPrecio.BackColor = Color.Red
            MEP.SetError(diPrecio, "Ingrese un precio!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Ingrese un precio del servicio para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        Else
            diPrecio.BackColor = Color.White
            MEP.SetError(diPrecio, "")
        End If
        MHighlighterFocus.UpdateHighlights()
        Return _ok
    End Function
    Public Overrides Sub _PMONuevo()
        _prLimpiar()
        _prHabilitar()
        txtDescripcion.Focus()
    End Sub

    Private Sub gpDatosGral_Click(sender As Object, e As EventArgs) Handles gpDatosGral.Click

    End Sub

    Private Sub F1_Con_Servicios_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        _prCambiarColorPlomoOscuro(Presentacion.Principal.btnServicios)
    End Sub


    Public Overrides Sub _PMOModificar()
        _prHabilitar()
    End Sub
    Public Overrides Sub _PMOSalir()
        _prInhabilitar()
        _prFiltrar()
    End Sub
#End Region
End Class