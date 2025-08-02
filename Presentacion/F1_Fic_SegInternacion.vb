Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX
Imports System.IO
Public Class F1_Fic_SegInternacion
#Region "VARIABLES"
    Public _IdCliente, _Iniciar, _MPos, _MPos2, _IdPaciente As Integer
    Private _Limpiar As Boolean
    Dim Modificado As Boolean = False
    Dim NuevoSeg As Boolean = False
#End Region
#Region "Eventos"
    Private Sub F1_FIC_SegInternacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
        superTabControl1.SelectedTabIndex = 0
    End Sub
    Private Sub txtIdFicClinica_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdFicClinica.KeyDown
        If e.KeyData = Keys.Control + Keys.Enter Then
            Dim dt As DataTable
            dt = L_fnMostrarInternacion()
            Dim listEstCeldas As New List(Of Modelo.Celda)
            listEstCeldas.Add(New Modelo.Celda("igId,", False, "ID", 50))
            listEstCeldas.Add(New Modelo.Celda("ig_fbId", True, "Id Ficha", 90))
            listEstCeldas.Add(New Modelo.Celda("igEst", False, "Estado", 180))
            listEstCeldas.Add(New Modelo.Celda("cacliente", True, "Propietario", 210))
            listEstCeldas.Add(New Modelo.Celda("pbId", False, "IdPaciente", 150))
            listEstCeldas.Add(New Modelo.Celda("pbnomb", True, "Paciente", 150))
            listEstCeldas.Add(New Modelo.Celda("Especie", True, "Especie", 120))
            listEstCeldas.Add(New Modelo.Celda("pbsex", True, "Sexo", 120))
            listEstCeldas.Add(New Modelo.Celda("igFechaIng", True, "Fecha Int.", 90))
            listEstCeldas.Add(New Modelo.Celda("igEdad", True, "Edad", 100))
            listEstCeldas.Add(New Modelo.Celda("igTelf", False, "Telefono", 130))
            listEstCeldas.Add(New Modelo.Celda("igMotInter", False, "igMotInter", 180))
            listEstCeldas.Add(New Modelo.Celda("igRequer", False, "igRequer", 180))
            listEstCeldas.Add(New Modelo.Celda("igHoraInter", True, "Hora Int.".ToUpper, 100))
            Dim ef = New Efecto
            ef.tipo = 3
            ef.dt = dt
            ef.SeleclCol = 2
            ef.listEstCeldas = listEstCeldas
            ef.alto = 80
            ef.ancho = 190
            ef.Context = "Seleccione una Internación".ToUpper
            ef.ShowDialog()
            Dim bandera As Boolean = False
            bandera = ef.band
            If (bandera = True) Then
                Dim Row As Janus.Windows.GridEX.GridEXRow = ef.Row
                txtIdFicClinica.Text = Row.Cells("ig_fbId").Value
                txtPacienteI.Text = Row.Cells("pbnomb").Value
                _IdPaciente = Row.Cells("pbId").Value
            End If
        End If
    End Sub
    Private Sub JGBusqSeguimiento_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGBusqSeguimiento.EditingCell
        e.Cancel = True
    End Sub

    Private Sub JGSeguimiento_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGSeguimiento.EditingCell
        e.Cancel = True
    End Sub

    Private Sub cbTurno_ValueChanged(sender As Object, e As EventArgs) Handles cbTurno.ValueChanged
        If cbTurno.SelectedIndex < 0 And cbTurno.Text <> String.Empty Then
            btnTurno.Visible = True
        Else
            btnTurno.Visible = False
        End If
    End Sub

    Private Sub btnTurno_Click(sender As Object, e As EventArgs) Handles btnTurno.Click
        Dim _Id As String = ""
        ''If L_fnExisteLibreria("2", "1", cbEspecie.Text) Then
        If L_fnGrabarLibreria(_Id, "5", "1", cbTurno.Text) Then
            _prCargarComboLibreria(cbTurno, "5", "1")
            cbTurno.SelectedIndex = CType(cbTurno.DataSource, DataTable).Rows.Count - 1
        End If
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        If JGBusqSeguimiento.RowCount > 0 Then
            _MPos = 0
            _prMostrarInternacionSeg(_MPos)
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If _MPos > 0 And JGBusqSeguimiento.RowCount > 0 Then
            _MPos = _MPos - 1
            _prMostrarInternacionSeg(_MPos)
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If _MPos < JGBusqSeguimiento.RowCount - 1 Then
            _MPos = _MPos + 1
            _prMostrarInternacionSeg(_MPos)
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        If JGBusqSeguimiento.RowCount > 0 Then
            _MPos = JGBusqSeguimiento.RowCount - 1
            _prMostrarInternacionSeg(_MPos)
        End If
    End Sub

    Private Sub JGBusqSeguimiento_SelectionChanged(sender As Object, e As EventArgs) Handles JGBusqSeguimiento.SelectionChanged
        If JGBusqSeguimiento.Row >= 0 And JGBusqSeguimiento.RowCount > 0 Then
            _MPos = JGBusqSeguimiento.Row
            _prMostrarInternacionSeg(_MPos)
        End If
    End Sub

    Private Sub JGSeguimiento_SelectionChanged(sender As Object, e As EventArgs) Handles JGSeguimiento.SelectionChanged
        If JGSeguimiento.Row >= 0 And JGSeguimiento.RowCount > 0 Then
            _MPos2 = JGSeguimiento.Row 'Count - 1
            _prMostrarInternacionSegDet(_MPos2)
        End If
    End Sub
    Private Sub btnSeguimiento_Click(sender As Object, e As EventArgs) Handles btnSeguimiento.Click
        _prHabilitar()
        _prHabilitarMenu(1)
        _LimpiarDet()
        NuevoSeg = True
        JGSeguimiento.Enabled = False
        _MNuevo = False 'Manda a Formulario 1, Modificar
    End Sub
#End Region
#Region "METODOS PRIVADOS"
    Private Sub _prIniciarTodo()
        'Carga eL Combobox
        _prCargarComboLibreria(cbTurno, 5, 1)
        _prInhabilitar()
        _PMAsignarPermisos()
        _prCargarInternacionSeg()
        _prMostrarInternacionSeg(0)
    End Sub
    Private Sub _prHabilitarMenu(tipo As Integer)
        If tipo = 1 Then
            btnNuevo.Enabled = False
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
            btnGrabar.Enabled = True
            superTabItem2.Enabled = False
            PanelNavegacion.Enabled = False
        Else
            btnNuevo.Enabled = True
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
            btnGrabar.Enabled = False
            superTabItem2.Enabled = True
            PanelNavegacion.Enabled = True
        End If

    End Sub
    Private Sub _prMostrarInternacionSeg(_POS As Integer)
        If JGBusqSeguimiento.RowCount <> 0 Then
            JGBusqSeguimiento.Row = _POS
            With JGBusqSeguimiento
                'ihId, ih_fbId, ihFechaIng,pac.pbnomb, ihTurno, ihDiag, ihResp, ihPasoTur
                txtIdFicClinica.Text = .GetValue("ih_fbId")
                txtPacienteI.Text = .GetValue("pbnomb")
                txtDiagnostico.Text = .GetValue("ihDiag")
                txtResponsable.Text = .GetValue("ihResp")
                _prCargarInternacionSegDet(.GetValue("ihId"))
                dtpFechaSeg.Value = .GetValue("ihFechaIng")
                'Muestra la cantidad DE FILAS en la Grilla
                LblPaginacion.Text = Str(JGBusqSeguimiento.Row + 1) + "/" + JGBusqSeguimiento.RowCount.ToString

                'Muestra el bubblebar(que usuario registró el Seguimiento de la internación)
                lbFecha.Text = CType(.GetValue("ihFecha"), Date).ToString("dd/MM/yyyy")
                lbHora.Text = .GetValue("ihHora").ToString
                lbUsuario.Text = .GetValue("ihUsuario").ToString
            End With
        End If
    End Sub
    Private Sub _prMostrarInternacionSegDet(_POS As Integer)
        If JGSeguimiento.RowCount <> 0 Then
            JGSeguimiento.Row = _POS
            With JGSeguimiento
                ''iiId, ii_ihId, iiHoraTurn, iiObser, iiFrec, iiMedPro, iiAlim
                txtObsRequerimientos.Text = .GetValue("iiObser")
                txtFrecuencias.Text = .GetValue("iiFrec")
                txtOtros.Text = .GetValue("iiOtros")
                txtMedProtocolo.Text = .GetValue("iiMedPro")
                txtAlimentacion.Text = .GetValue("iiAlim")
                txtPasoTurno.Text = .GetValue("iiPasoTur")
                cbTurno.Value = .GetValue("iiTurno")
                'Falta Mostrar el iiFechaReg
            End With
        End If
    End Sub
    Private Sub _prCargarInternacionSeg()
        Dim _tabla As DataTable = L_fnMostrarInternacionSeg()
        JGBusqSeguimiento.DataSource = _tabla
        JGBusqSeguimiento.RetrieveStructure()
        JGBusqSeguimiento.AlternatingColors = True
        'ihId, ih_fbId, ihFechaIng,pac.pbnomb, ihTurno, ihDiag, ihResp, ihPasoTur
        With JGBusqSeguimiento.RootTable.Columns("ihId")
            .Width = 65
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "Id"
            .Visible = True
        End With
        With JGBusqSeguimiento.RootTable.Columns("ih_fbId")
            .Width = 150
            .Caption = "IdFicha"
            .Visible = False
        End With
        With JGBusqSeguimiento.RootTable.Columns("ihFechaIng")
            .Width = 100
            .Caption = "Fecha"
            .Visible = True
        End With
        With JGBusqSeguimiento.RootTable.Columns("pbid")
            .Width = 100
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "IdPaciente"
            .Visible = False
        End With
        With JGBusqSeguimiento.RootTable.Columns("cliente")
            .Width = 170
            .Caption = "Cliente"
            .Visible = True
        End With
        With JGBusqSeguimiento.RootTable.Columns("pbnomb")
            .Width = 160
            .Caption = "Paciente"
            .Visible = True
        End With
        With JGBusqSeguimiento.RootTable.Columns("ihResp")
            .Width = 170
            .Caption = "Responsable"
            .Visible = True
        End With
        With JGBusqSeguimiento.RootTable.Columns("ihDiag")
            .Width = 280
            .Caption = "Diagnóstico"
            .Visible = True
        End With
        With JGBusqSeguimiento.RootTable.Columns("ihFecha")
            .Visible = False
        End With
        With JGBusqSeguimiento.RootTable.Columns("ihHora")
            .Visible = False
        End With
        With JGBusqSeguimiento.RootTable.Columns("ihUsuario")
            .Visible = False
        End With
        With JGBusqSeguimiento.RootTable.Columns("pbId1")
            .Visible = False
        End With
        With JGBusqSeguimiento
            .DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub
    Private Sub _prCargarInternacionSegDet(idInternacion As String)
        Dim _tabla As DataTable
        '_tabla= L_fnMostrarInternacionSegDet(idInternacion)
        JGSeguimiento.DataSource = _tabla
        JGSeguimiento.RetrieveStructure()
        JGSeguimiento.AlternatingColors = True
        'iiId, ii_ihId, iiHoraTurn, iiObser, iiFrec, iiMedPro, iiAlim
        With JGSeguimiento.RootTable.Columns("iiId")
            .Width = 100
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "Id"
            .Visible = False
        End With
        With JGSeguimiento.RootTable.Columns("ii_ihId")
            .Width = 150
            .Caption = "IdInteracion"
            .Visible = False
        End With
        With JGSeguimiento.RootTable.Columns("iiTurno")
            .Width = 100
            .Caption = "Turno"
            .Visible = False
        End With
        With JGSeguimiento.RootTable.Columns("iiFechaIng")
            .Width = 100
            .Caption = "Fecha"
            .Visible = True
        End With
        With JGSeguimiento.RootTable.Columns("lbdesc")
            .Width = 100
            .Caption = "Turno"
            .Visible = True
        End With
        With JGSeguimiento.RootTable.Columns("iiHoraTurn")
            .Width = 100
            .Caption = "Hora"
            .Visible = True
        End With
        With JGSeguimiento.RootTable.Columns("iiObser")
            .Width = 200
            .Caption = "Observación"
            .Visible = True
        End With
        With JGSeguimiento.RootTable.Columns("iiFrec")
            .Width = 200
            .Caption = "Frecuencia"
            .Visible = True
        End With
        With JGSeguimiento.RootTable.Columns("iiMedPro")
            .Width = 200
            .Caption = "Medicación"
            .Visible = True
        End With
        With JGSeguimiento.RootTable.Columns("iiAlim")
            .Width = 200
            .Caption = "Alimentación"
            .Visible = True
        End With
        With JGSeguimiento.RootTable.Columns("iiPasoTur")
            .Width = 180
            .Caption = "Paso de Turno"
            .Visible = True
        End With
        With JGSeguimiento.RootTable.Columns("iiOtros")
            .Width = 200
            .Caption = "Otros"
            .Visible = True
        End With

        With JGSeguimiento
            '.DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            '.FilterMode = FilterMode.Automatic
            '.FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub
    Private Sub _prInhabilitar()
        JGSeguimiento.Enabled = True
        txtIdFicClinica.ReadOnly = True
        txtPacienteI.ReadOnly = True
        txtDiagnostico.ReadOnly = True
        txtObsRequerimientos.ReadOnly = True
        dtpFechaSeg.Enabled = False
        'Detalle
        txtResponsable.ReadOnly = True
        txtFrecuencias.ReadOnly = True
        txtOtros.ReadOnly = True
        txtMedProtocolo.ReadOnly = True
        txtAlimentacion.ReadOnly = True
        cbTurno.Enabled = False
        txtPasoTurno.ReadOnly = True
        _Limpiar = False
    End Sub
    Private Sub _prHabilitar()
        JGSeguimiento.Enabled = True
        txtIdFicClinica.ReadOnly = False
        txtPacienteI.ReadOnly = False
        txtDiagnostico.ReadOnly = False
        txtObsRequerimientos.ReadOnly = False
        dtpFechaSeg.Enabled = True
        'Detalle
        txtResponsable.ReadOnly = False
        cbTurno.Enabled = True
        txtFrecuencias.ReadOnly = False
        txtOtros.ReadOnly = False
        txtMedProtocolo.ReadOnly = False
        txtAlimentacion.ReadOnly = False
        txtPasoTurno.ReadOnly = False
    End Sub

    Private Sub _LimpiarDet()
        txtObsRequerimientos.Clear()
        txtFrecuencias.Clear()
        txtFrecuencias.Text += "FR=  " + vbNewLine
        txtFrecuencias.Text += "FC=  " + vbNewLine
        txtFrecuencias.Text += "T=  " + vbNewLine
        txtOtros.Clear()
        txtMedProtocolo.Clear()
        txtAlimentacion.Clear()
        txtPasoTurno.Clear()
        '_prCargarComboLibreria(cbTurno, 5, 1)
        cbTurno.Value = 1
    End Sub
    Private Sub _prLimpiar()
        JGSeguimiento.Enabled = True
        txtIdFicClinica.Clear()
        txtIdFicClinica.Focus()
        txtPacienteI.Clear()
        txtDiagnostico.Clear()
        txtResponsable.Clear()
        dtpFechaSeg.Value = DateTime.Now
        _LimpiarDet()
        _prCargarInternacionSegDet(-1)
        If (_Limpiar = False) Then
            _prSeleccionarCombo(cbTurno)
        End If
    End Sub
    Public Sub _prFiltrar(tipo As Integer)
        'cargo el buscador
        _prCargarInternacionSeg()
        If JGBusqSeguimiento.RowCount > 0 Then
            _MPos = 0
            _prMostrarInternacionSeg(IIf(tipo = 1, _MPos, JGBusqSeguimiento.RowCount - 1))
        Else
            _prLimpiar()
            LblPaginacion.Text = "0/0"
        End If
    End Sub
    Public Sub _prSeleccionarCombo(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        If (CType(mCombo.DataSource, DataTable).Rows.Count > 0) Then
            mCombo.SelectedIndex = 0
        Else
            mCombo.SelectedIndex = -1
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
    Private Sub _prGuardarSeguimiento()
        'Dim ihId As Integer
        'Dim res As Boolean = L_fnModificarInternacionSeg(JGBusqSeguimiento.GetValue("ihId"), txtIdFicClinica.Text, dtpFechaSeg.Value.ToString("yyyy/MM/dd"),
        '                                              txtDiagnostico.Text, txtResponsable.Text,
        '                                              1, 0, DateTime.Now.Date.ToString("yyyy/MM/dd"), cbTurno.Value, DateTime.Now.ToShortTimeString(),
        '                                              txtObsRequerimientos.Text, txtFrecuencias.Text, txtOtros.Text, txtMedProtocolo.Text, txtAlimentacion.Text, txtPasoTurno.Text)
        'If res Then
        '    Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
        '    ToastNotification.Show(Me, "Id del Seguimiento de internacion fue ".ToUpper + ihId.ToString() + " Grabado con Exito.".ToUpper,
        '                              img, 3000,
        '                              eToastGlowColor.Green,
        '                              eToastPosition.TopCenter
        '                              )
        '    _prInhabilitar()
        '    _prFiltrar(2)
        '    _Limpiar = True
        '    NuevoSeg = False

        'Else
        '    Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
        '    ToastNotification.Show(Me, "El seguimiento no pudo ser Grabado".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)

        'End If
    End Sub
#End Region
#Region "METODOS PRIVADOS OVERRRIDABLES"
    Public Overrides Function _PMOGrabarRegistro() As Boolean
        'Dim ihId As Integer

        'Dim res As Boolean = L_fnGrabarInternacionSeg(ihId, txtIdFicClinica.Text, _IdPaciente, dtpFechaSeg.Value.ToString("yyyy/MM/dd"),
        '                                              txtDiagnostico.Text, txtResponsable.Text,
        '                                              1, DateTime.Now.Date.ToString("yyyy/MM/dd"), cbTurno.Value, DateTime.Now.ToShortTimeString(),
        '                                              txtObsRequerimientos.Text, txtFrecuencias.Text, txtOtros.Text, txtMedProtocolo.Text, txtAlimentacion.Text, txtPasoTurno.Text)
        'If res Then
        '    Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
        '    ToastNotification.Show(Me, "Id del Seguimiento de internacion ".ToUpper + ihId.ToString() + " Grabado con Exito.".ToUpper,
        '                                  img, 3000,
        '                                  eToastGlowColor.Green,
        '                                  eToastPosition.TopCenter
        '                                  )
        '    _Limpiar = True
        '    NuevoSeg = False
        '    _prHabilitarMenu(2)
        '    _prInhabilitar()
        '    _prFiltrar(2)
        'Else
        '    Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
        '    ToastNotification.Show(Me, "El seguimiento no pudo ser insertado".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)

        'End If
        'Return res

    End Function
    ''*****MODDIFICA EL REGISTRO*****''
    Public Overrides Function _PMOModificarRegistro() As Boolean
        'Dim ihId As Integer
        'Dim res As Boolean
        'If NuevoSeg Then
        '    _prGuardarSeguimiento()
        '    res = True
        'Else
        '    res = L_fnModificarInternacionSeg(JGBusqSeguimiento.GetValue("ihId"), txtIdFicClinica.Text, dtpFechaSeg.Value.ToString("yyyy/MM/dd"),
        '                                      txtDiagnostico.Text, txtResponsable.Text,
        '                                      2, JGSeguimiento.GetValue("iiId"), DateTime.Now.Date.ToString("yyyy/MM/dd"), cbTurno.Value,
        '                                      JGSeguimiento.GetValue("iiHoraTurn"), txtObsRequerimientos.Text, txtFrecuencias.Text, txtOtros.Text, txtMedProtocolo.Text, txtAlimentacion.Text, txtPasoTurno.Text)
        '    If res Then
        '        Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
        '        ToastNotification.Show(Me, "Id del Seguimiento de internacion fue ".ToUpper + ihId.ToString() + " Modificado con Exito.".ToUpper,
        '                                  img, 3000,
        '                                  eToastGlowColor.Green,
        '                                  eToastPosition.TopCenter
        '                                  )
        '        _prInhabilitar()
        '        _prFiltrar(2)
        '        _Limpiar = True
        '        NuevoSeg = False
        '    Else
        '        Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
        '        ToastNotification.Show(Me, "El seguimiento no pudo ser Modificado".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)

        '    End If
        'End If
        'Return res
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
            Dim res As Boolean = L_fnEliminarInternacionSeg(JGBusqSeguimiento.GetValue("ihId"), mensajeError)
            If res Then
                Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)

                ToastNotification.Show(Me, "Código del Seguimiento ".ToUpper + JGBusqSeguimiento.GetValue("ihId").ToString() + " eliminado con Exito.".ToUpper,
                                          img, 2000,
                                          eToastGlowColor.Green,
                                          eToastPosition.TopCenter)
                _prFiltrar(1)
            Else
                Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                ToastNotification.Show(Me, mensajeError, img, 3000, eToastGlowColor.Red, eToastPosition.TopCenter)
            End If
        End If
    End Sub
    Public Overrides Function _PMOValidarCampos() As Boolean
        Dim _ok As Boolean = True
        MEP.Clear()
        If txtIdFicClinica.Text = String.Empty Then
            txtIdFicClinica.BackColor = Color.Red
            MEP.SetError(txtIdFicClinica, "Seleccione una ficha!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Seleccione una ficha para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        Else
            txtIdFicClinica.BackColor = Color.White
            MEP.SetError(txtIdFicClinica, "")
        End If
        If txtFrecuencias.Text = String.Empty Then
            txtFrecuencias.BackColor = Color.Red
            MEP.SetError(txtFrecuencias, "Ingrese una frecuencia!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Ingrese una frecuencia para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        Else
            txtFrecuencias.BackColor = Color.White
            MEP.SetError(txtFrecuencias, "")
        End If
        If txtMedProtocolo.Text = String.Empty Then
            txtMedProtocolo.BackColor = Color.Red
            MEP.SetError(txtMedProtocolo, "Ingrese una medicación!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Ingrese una medicación para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        Else
            txtMedProtocolo.BackColor = Color.White
            MEP.SetError(txtMedProtocolo, "")
        End If
        If cbTurno.SelectedIndex < 0 Then
            cbTurno.BackColor = Color.Red
            MEP.SetError(cbTurno, "Seleccione un turno!".ToUpper)
            _ok = False
        Else
            cbTurno.BackColor = Color.White
            MEP.SetError(cbTurno, "")
        End If
        MHighlighterFocus.UpdateHighlights()
        Return _ok
    End Function
    Public Overrides Sub _PMOLimpiarErrores()
        MEP.Clear()
        txtIdFicClinica.BackColor = Color.White
        cbTurno.BackColor = Color.White
        txtFrecuencias.BackColor = Color.White
        txtMedProtocolo.BackColor = Color.White
    End Sub

    Private Sub btnFClinica_Click(sender As Object, e As EventArgs) Handles btnFClinica.Click
        Modelo.MGlobal._nameButton = Principal.btnFichaClinica.Name
        If JGBusqSeguimiento.RowCount > 0 Then
            Dim frm As New F1_Fic_FichaClinica
            Dim _fbId As Integer
            'Verificamos si el paciente tiene alguna Ficha CLinica y obtiene su codigo si tiene
            If L_fnMostrarIdFichaClinica(_fbId, JGBusqSeguimiento.GetValue("pbId")) Then
                frm._fbId = _fbId
                frm._Iniciar = 2
            Else
                'Nueva Ficha
                frm._IdPaciente = JGBusqSeguimiento.GetValue("pbId")
                frm._Paciente = JGBusqSeguimiento.GetValue("pbnomb")
                frm._Iniciar = 1
            End If
            frm.Show()
            Me.Refresh()
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "La ficha de seguimiento se encuentra vacía".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)
        End If


    End Sub

    Private Sub btnReciboI_Click(sender As Object, e As EventArgs) Handles btnReciboI.Click
        Dim frm As New F1_Fic_ReciboInt
        frm._IdPaciente = JGBusqSeguimiento.GetValue("pbId")
        frm._IdInternacion = JGBusqSeguimiento.GetValue("ihId") 'Id INTERNACION 
        frm.Show()
    End Sub

    Public Overrides Sub _PMONuevo()
        'JGBusqEmpleados.Enabled = False 'Deshabilita el buscador de la Grilla
        _prLimpiar()
        _prHabilitar()
    End Sub
    Public Overrides Sub _PMOModificar()
        'JGBusqEmpleados.Enabled = False 'Deshabilita el buscador de la Grilla
        _prHabilitar()

    End Sub
    Public Overrides Sub _PMOSalir()
        _prInhabilitar()
        _prFiltrar(1)
    End Sub
#End Region
End Class