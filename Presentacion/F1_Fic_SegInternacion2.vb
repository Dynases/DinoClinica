Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX
Imports System.IO
Public Class F1_Fic_SegInternacion2
#Region "VARIABLES"
    Public _IdCliente, _Iniciar, _MPos, _MPos2, _IdPaciente As Integer
    Private _Limpiar As Boolean
    Dim Modificado As Boolean = False
    Dim NuevoSeg As Boolean = False

    Dim ModificarEF As Boolean = False
    Dim ModificarSV As Boolean = False
    Dim ModificarM As Boolean = False
    Dim ModificarA As Boolean = False
    Dim ModificarF As Boolean = False
    Dim ModificarEC As Boolean = False
    Dim ModificarT As Boolean = False

#End Region
#Region "Eventos"
    Private Sub F1_FIC_SegInternacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
        superTabControl1.SelectedTabIndex = 0
    End Sub
    Private Sub txtIdFicInter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdFicInter.KeyDown
        If e.KeyData = Keys.Control + Keys.Enter Then
            Dim dt As DataTable
            dt = L_fnMostrarFichaClinicaConInternacion()

            If dt.Rows.Count > 0 Then
                Dim listEstCeldas As New List(Of Modelo.Celda)
                listEstCeldas.Add(New Modelo.Celda("igId,", True, "Id Internación", 100))
                listEstCeldas.Add(New Modelo.Celda("ig_fbId", True, "Id Ficha", 90))
                listEstCeldas.Add(New Modelo.Celda("igEst", False, "Estado", 180))
                listEstCeldas.Add(New Modelo.Celda("cacliente", True, "Propietario", 210))
                listEstCeldas.Add(New Modelo.Celda("pbId", False, "IdPaciente", 150))
                listEstCeldas.Add(New Modelo.Celda("pbnomb", True, "Paciente", 150))
                listEstCeldas.Add(New Modelo.Celda("Especie", True, "Especie", 120))
                listEstCeldas.Add(New Modelo.Celda("pbsex", True, "Sexo", 120))
                listEstCeldas.Add(New Modelo.Celda("igFechaIng", True, "Fecha Int.", 90, ("dd/MM/yyyy")))
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
                    txtIdFicInter.Text = Row.Cells("igId").Value
                    txtPropietarioI.Text = Row.Cells("cacliente").Value
                    txtTelefonoI.Text = Row.Cells("igTelf").Value
                    txtPacienteI.Text = Row.Cells("pbnomb").Value
                    _IdPaciente = Row.Cells("pbId").Value
                    txtEdadI.Text = Row.Cells("igEdad").Value
                    txtSexoI.Text = Row.Cells("pbsex").Value
                    txtEspecieI.Text = Row.Cells("Especie").Value
                    txtMotivoI.Text = Row.Cells("igMotInter").Value
                End If
            Else
                Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                ToastNotification.Show(Me, "No existe Fichas de Internación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)

            End If

        End If
    End Sub
    Private Sub JGBusqSeguimiento_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGBusqSeguimiento.EditingCell
        e.Cancel = True
    End Sub

    Private Sub JGSeguimiento_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGMonitoreo.EditingCell
        e.Cancel = True
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


    Private Sub btnSeguimiento_Click(sender As Object, e As EventArgs) Handles btnSeguimiento.Click
        _prHabilitar()
        _prHabilitarMenu(1)
        _LimpiarDet()
        NuevoSeg = True
        JGMonitoreo.Enabled = False
        _MNuevo = False 'Manda a Formulario 1, Modificar

        'Deshabilito el Id Ficha Clinica
        txtIdFicInter.ReadOnly = True
        txtIdFicInter.Enabled = False

        ''Poner el False todos los modificar de los detalles para que ponga la fecha y hora actual del sistema
        ModificarEF = False
        ModificarSV = False
        ModificarM = False
        ModificarA = False
        ModificarF = False
        ModificarEC = False
        ModificarT = False

    End Sub
#End Region
#Region "METODOS PRIVADOS"
    Private Sub _prIniciarTodo()
        'Carga eL Combobox
        _prCargarComboTurno(cbTurno)
        _prCargarComboTurno(cbTurnoEF)
        _prCargarComboTurno(cbTurnoF)
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
                txtId.Text = .GetValue("ihId")
                txtIdFicInter.Text = .GetValue("ih_fbId")
                txtPropietarioI.Text = .GetValue("cliente")
                txtTelefonoI.Text = .GetValue("igTelf")
                txtPacienteI.Text = .GetValue("pbnomb")
                txtEdadI.Text = .GetValue("igEdad")
                txtSexoI.Text = .GetValue("pbsex")
                txtEspecieI.Text = .GetValue("Especie")
                dtpFechaSeg.Value = .GetValue("ihFechaIng")
                txtMotivoI.Text = .GetValue("igMotInter")
                cbTurno.Value = .GetValue("ihTurno")

                'Mostrar Detalles
                _prDetalleExamenFisico(.GetValue("ihId"))
                _prDetalleSignosVitales(.GetValue("ihId"))
                _prDetalleMonitoreo(.GetValue("ihId"))
                _prDetalleAlimentacion(.GetValue("ihId"))
                _prDetalleFluidoTerapia(.GetValue("ihId"))
                _prDetalleEstudiosC(.GetValue("ihId"))
                _prDetalleTratamiento(.GetValue("ihId"))


                'Muestra la cantidad DE FILAS en la Grilla
                LblPaginacion.Text = Str(JGBusqSeguimiento.Row + 1) + "/" + JGBusqSeguimiento.RowCount.ToString

                'Muestra el bubblebar(que usuario registró el Seguimiento de la internación)
                lbFecha.Text = CType(.GetValue("ihFecha"), Date).ToString("dd/MM/yyyy")
                lbHora.Text = .GetValue("ihHora").ToString
                lbUsuario.Text = .GetValue("ihUsuario").ToString
            End With
        End If
    End Sub

    Private Sub _prMostrarExamenFisico(_POS As Integer)
        Dim muc, desh, dol, grado As String
        If JGExamenFisico.RowCount <> 0 Then
            JGExamenFisico.Row = _POS
            With JGExamenFisico
                cbTurnoEF.Value = .GetValue("iiTurnoEF")
                txtHoraEF.Text = .GetValue("iiHoraEF")
                dtpFechaEF.Value = .GetValue("iiFechaEF")

                muc = .GetValue("iiMucosas")
                _prMostrarMucosas(muc)
                desh = .GetValue("iiDeshidratacion")
                _prMostrarDeshidratacion(desh)
                dol = .GetValue("iiDolor")
                _prMostrarDolor(dol)
                grado = .GetValue("iiGradoConciencia")
                _prMostrarGradoConciencia(grado)

            End With
        End If
    End Sub
    Private Sub _prMostrarMucosas(ByRef mucosas As String)
        If mucosas = chbRosadas.Text Then
            chbRosadas.Checked = True
        ElseIf mucosas = chbPalidas.Text Then
            chbPalidas.Checked = True
        ElseIf mucosas = chbIctericas.Text Then
            chbIctericas.Checked = True
        ElseIf mucosas = chbCianoticas.Text Then
            chbCianoticas.Checked = True
        End If
    End Sub
    Private Sub _prMostrarDeshidratacion(ByRef deshidratacion As String)
        If deshidratacion = chb0_5.Text Then
            chb0_5.Checked = True
        ElseIf deshidratacion = chb5_7.Text Then
            chb5_7.Checked = True
        ElseIf deshidratacion = chb8_10.Text Then
            chb8_10.Checked = True
        End If
    End Sub
    Private Sub _prMostrarDolor(ByRef dolor As String)
        If dolor = chbLeve.Text Then
            chbLeve.Checked = True
            chbModerado.Checked = False
            chbSevero.Checked = False
        ElseIf dolor = chbModerado.Text Then
            chbModerado.Checked = True
            chbLeve.Checked = False
            chbSevero.Checked = False
        ElseIf dolor = chbSevero.Text Then
            chbSevero.Checked = True
            chbLeve.Checked = False
            chbModerado.Checked = False
        ElseIf dolor = "" Then
            chbLeve.Checked = False
            chbModerado.Checked = False
            chbSevero.Checked = False
        End If
    End Sub
    Private Sub _prMostrarGradoConciencia(ByRef gradoconc As String)
        If gradoconc = chbEstable.Text Then
            chbEstable.Checked = True
        ElseIf gradoconc = chbSemicomatoso.Text Then
            chbSemicomatoso.Checked = True
        ElseIf gradoconc = chbComa.Text Then
            chbComa.Checked = True
        End If
    End Sub
    Private Sub _prMostrarSignosVitales(_POS As Integer)
        If JGSignosVitales.RowCount <> 0 Then
            JGSignosVitales.Row = _POS
            With JGSignosVitales
                txtVomitos.Text = .GetValue("ijVomitos")
                txtDiarreas.Text = .GetValue("ijDiarreas")
                txtConvulsiones.Text = .GetValue("ijConvulsiones")
                txtInfartos.Text = .GetValue("ijInfartos")
                txtMiccion.Text = .GetValue("ijMiccion")
                txtDefecacion.Text = .GetValue("ijDefecacion")
                txtOtrosSV.Text = .GetValue("ijOtros")

                dtpFechaSV.Value = .GetValue("ijFechaSV")
                txtHoraSV.Text = .GetValue("ijHoraSV")

            End With
        End If
    End Sub
    Private Sub _prMostrarMonitoreo(_POS As Integer)
        If JGMonitoreo.RowCount <> 0 Then
            JGMonitoreo.Row = _POS
            With JGMonitoreo
                txtT.Text = .GetValue("ikT")
                txtFC.Text = .GetValue("ikFC")
                txtFR.Text = .GetValue("ikFR")
                txtPeso.Text = .GetValue("ikPeso")
                txtSPO2.Text = .GetValue("ikSPO2")
                txtPSys.Text = .GetValue("ikPSys")
                txtPDys.Text = .GetValue("ikPDys")
                txtMED.Text = .GetValue("ikMED")
                txtTRC.Text = .GetValue("ikTRC")

                dtpFechaM.Value = .GetValue("ikFechaM")
                txtHoraM.Text = .GetValue("ikHoraM")

            End With
        End If
    End Sub
    Private Sub _prMostrarAlimentacion(_POS As Integer)
        If JGAlimentacion.RowCount <> 0 Then
            JGAlimentacion.Row = _POS
            With JGAlimentacion
                txtRequerimiento.Text = .GetValue("ilReq")
                txtPVM.Text = .GetValue("ilPVM")
                txtRecovery.Text = .GetValue("ilRecovery")
                txtPolloLic.Text = .GetValue("ilPolloLic")
                txtPolloDesm.Text = .GetValue("ilPolloDesm")
                txtNPO.Text = .GetValue("ilNPO")
                txtAgua.Text = .GetValue("ilAgua")
                txtObs.Text = .GetValue("ilObs")

                dtpFechaA.Value = .GetValue("ilFechaA")
                txtHoraA.Text = .GetValue("ilHoraA")

            End With
        End If
    End Sub

    Private Sub _prMostrarFluidoterapia(_POS As Integer)
        If JGFluidoterapia.RowCount <> 0 Then
            JGFluidoterapia.Row = _POS
            With JGFluidoterapia
                cbTurnoF.Value = .GetValue("imTurnoF")
                txtFluidos.Text = .GetValue("imFluidos")
                txtHoraInicio.Text = .GetValue("imHoraI")
                txtHoraTermino.Text = .GetValue("imHoraT")
                txtCantidad.Text = .GetValue("imCantidad")

                dtpFechaF.Value = .GetValue("imFechaF")
                txtHoraF.Text = .GetValue("imHoraF")

            End With
        End If
    End Sub

    Private Sub _prMostrarEstudiosC(_POS As Integer)
        If JGEstudiosC.RowCount <> 0 Then
            JGEstudiosC.Row = _POS
            With JGEstudiosC
                txtEstudiosComplem.Text = .GetValue("inEstudiosC")
                dtpFechaEC.Value = .GetValue("inFechaEC")
                txtHoraEC.Text = .GetValue("inHoraEC")

            End With
        End If
    End Sub
    Private Sub _prMostrarTratamiento(_POS As Integer)
        If JGTratamiento.RowCount <> 0 Then
            JGTratamiento.Row = _POS
            With JGTratamiento
                txtTratamiento.Text = .GetValue("ioTratamiento")
                dtpFechaT.Value = .GetValue("ioFechaT")
                txtHoraT.Text = .GetValue("ioHoraT")

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
            .Width = 80
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "Id Seg."
            .Visible = True
        End With
        With JGBusqSeguimiento.RootTable.Columns("ih_fbId")
            .Width = 100
            .Caption = "Id Internación"
            .Visible = True
        End With
        With JGBusqSeguimiento.RootTable.Columns("ig_fbId")
            .Width = 120
            .Caption = "IdFichaClínica"
            .Visible = True
        End With
        With JGBusqSeguimiento.RootTable.Columns("ih_pbId")
            .Width = 150
            .Caption = "IdPaciente"
            .Visible = False
        End With
        With JGBusqSeguimiento.RootTable.Columns("caid")
            .Visible = False
        End With
        With JGBusqSeguimiento.RootTable.Columns("cliente")
            .Width = 250
            .Caption = "Cliente"
            .Visible = True
        End With
        With JGBusqSeguimiento.RootTable.Columns("igTelf")
            .Visible = False
        End With
        With JGBusqSeguimiento.RootTable.Columns("pbid")
            .Width = 100
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "IdPaciente"
            .Visible = False
        End With
        With JGBusqSeguimiento.RootTable.Columns("pbnomb")
            .Width = 150
            .Caption = "Paciente"
            .Visible = True
        End With
        With JGBusqSeguimiento.RootTable.Columns("igEdad")
            .Visible = False
        End With
        With JGBusqSeguimiento.RootTable.Columns("pbsex")
            .Width = 120
            .Caption = "Sexo"
            .Visible = True
        End With
        With JGBusqSeguimiento.RootTable.Columns("Especie")
            .Width = 130
            .Visible = True
            .Caption = "Especie"
        End With
        With JGBusqSeguimiento.RootTable.Columns("igMotInter")
            .Visible = False
        End With
        With JGBusqSeguimiento.RootTable.Columns("ihFechaIng")
            .Width = 100
            .Caption = "Fecha"
            .Visible = True
        End With
        With JGBusqSeguimiento.RootTable.Columns("ihTurno")
            .Visible = False
        End With
        With JGBusqSeguimiento.RootTable.Columns("haTurno")
            .Width = 100
            .Caption = "Turno"
            .Visible = True
        End With

        With JGBusqSeguimiento.RootTable.Columns("ihFecha")
            .Visible = False
        End With
        With JGBusqSeguimiento.RootTable.Columns("ihHora")
            .Visible = False
        End With
        With JGBusqSeguimiento.RootTable.Columns("ihUsuario")
            .Width = 130
            .Caption = "Usuario"
            .Visible = True
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
    Private Sub _prDetalleExamenFisico(idInternacion As String)
        Dim _tabla As DataTable = L_fnMostrarExamenFisico(idInternacion)
        JGExamenFisico.DataSource = _tabla
        JGExamenFisico.RetrieveStructure()
        JGExamenFisico.AlternatingColors = True

        With JGExamenFisico.RootTable.Columns("iiId")
            .Width = 100
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "Id"
            .Visible = False
        End With
        With JGExamenFisico.RootTable.Columns("ii_ihId")
            .Width = 150
            .Caption = "IdInteracion"
            .Visible = False
        End With
        With JGExamenFisico.RootTable.Columns("iiEst")
            .Visible = False
        End With
        With JGExamenFisico.RootTable.Columns("iiFechaEF")
            .Width = 100
            .Caption = "Fecha"
            .Visible = True
        End With
        With JGExamenFisico.RootTable.Columns("iiHoraEF")
            .Width = 100
            .Caption = "Hora"
            .Visible = True
        End With
        With JGExamenFisico.RootTable.Columns("iiTurnoEF")
            .Width = 100
            .Caption = "IdTurno"
            .Visible = False
        End With
        With JGExamenFisico.RootTable.Columns("haTurno")
            .Width = 100
            .Caption = "Turno"
            .Visible = True
        End With
        With JGExamenFisico.RootTable.Columns("iiMucosas")
            .Width = 100
            .Caption = "Mucosas"
            .Visible = True
        End With
        With JGExamenFisico.RootTable.Columns("iiDeshidratacion")
            .Width = 100
            .Caption = "Deshidratación"
            .Visible = True
        End With
        With JGExamenFisico.RootTable.Columns("iiDolor")
            .Width = 100
            .Caption = "Dolor"
            .Visible = True
        End With
        With JGExamenFisico.RootTable.Columns("iiGradoConciencia")
            .Width = 150
            .Caption = "Grado de Conciencia"
            .Visible = True
        End With
        With JGExamenFisico.RootTable.Columns("iiFecha")
            .Width = 100
            .Caption = "Fecha"
            .Visible = False
        End With
        With JGExamenFisico.RootTable.Columns("iiHora")
            .Width = 100
            .Caption = "Hora"
            .Visible = False
        End With
        With JGExamenFisico.RootTable.Columns("iiusuario")
            .Width = 150
            .Caption = "Usuario"
            .Visible = True
        End With
        With JGExamenFisico.RootTable.Columns("estado")
            .Visible = False
        End With
        With JGExamenFisico.RootTable.Columns("img")
            .Width = 80
            .Caption = "Eliminar".ToUpper
            .CellStyle.ImageHorizontalAlignment = ImageHorizontalAlignment.Center
            .Visible = False
        End With

        With JGExamenFisico
            '.DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            '.FilterMode = FilterMode.Automatic
            '.FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub

    Private Sub _prDetalleSignosVitales(idInternacion As String)
        Dim _tabla As DataTable = L_fnMostrarSignosVitales(idInternacion)
        JGSignosVitales.DataSource = _tabla
        JGSignosVitales.RetrieveStructure()
        JGSignosVitales.AlternatingColors = True

        With JGSignosVitales.RootTable.Columns("ijId")
            .Width = 100
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "Id"
            .Visible = False
        End With
        With JGSignosVitales.RootTable.Columns("ij_ihId")
            .Width = 150
            .Caption = "IdInteracion"
            .Visible = False
        End With
        With JGSignosVitales.RootTable.Columns("ijEst")
            .Visible = False
        End With
        With JGSignosVitales.RootTable.Columns("ijFechaSV")
            .Width = 100
            .Caption = "Fecha"
            .Visible = True
        End With
        With JGSignosVitales.RootTable.Columns("ijHoraSV")
            .Width = 100
            .Caption = "Hora"
            .Visible = True
        End With
        With JGSignosVitales.RootTable.Columns("ijVomitos")
            .Width = 100
            .Caption = "Vómitos"
            .Visible = True
        End With
        With JGSignosVitales.RootTable.Columns("ijDiarreas")
            .Width = 100
            .Caption = "Diarreas"
            .Visible = True
        End With
        With JGSignosVitales.RootTable.Columns("ijConvulsiones")
            .Width = 100
            .Caption = "Convulsiones"
            .Visible = True
        End With
        With JGSignosVitales.RootTable.Columns("ijInfartos")
            .Width = 100
            .Caption = "Infartos"
            .Visible = True
        End With
        With JGSignosVitales.RootTable.Columns("ijMiccion")
            .Width = 100
            .Caption = "Micción"
            .Visible = True
        End With
        With JGSignosVitales.RootTable.Columns("ijDefecacion")
            .Width = 100
            .Caption = "Defecación"
            .Visible = True
        End With
        With JGSignosVitales.RootTable.Columns("ijOtros")
            .Width = 150
            .Caption = "Otros"
            .Visible = True
        End With
        With JGSignosVitales.RootTable.Columns("ijFecha")
            .Width = 100
            .Caption = "Fecha"
            .Visible = False
        End With
        With JGSignosVitales.RootTable.Columns("ijHora")
            .Width = 100
            .Caption = "Hora"
            .Visible = False
        End With
        With JGSignosVitales.RootTable.Columns("ijUsuario")
            .Width = 150
            .Caption = "Usuario"
            .Visible = True
        End With
        With JGSignosVitales.RootTable.Columns("estado")
            .Visible = False
        End With
        With JGSignosVitales.RootTable.Columns("img")
            .Width = 80
            .Caption = "Eliminar".ToUpper
            .CellStyle.ImageHorizontalAlignment = ImageHorizontalAlignment.Center
            .Visible = False
        End With

        With JGSignosVitales
            '.DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            '.FilterMode = FilterMode.Automatic
            '.FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub

    Private Sub _prDetalleMonitoreo(idInternacion As String)
        Dim _tabla As DataTable = L_fnMostrarMonitoreo(idInternacion)
        JGMonitoreo.DataSource = _tabla
        JGMonitoreo.RetrieveStructure()
        JGMonitoreo.AlternatingColors = True

        With JGMonitoreo.RootTable.Columns("ikId")
            .Width = 100
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "Id"
            .Visible = False
        End With
        With JGMonitoreo.RootTable.Columns("ik_ihId")
            .Width = 150
            .Caption = "IdInteracion"
            .Visible = False
        End With
        With JGMonitoreo.RootTable.Columns("ikEst")
            .Caption = "Estado"
            .Visible = False
        End With
        With JGMonitoreo.RootTable.Columns("ikFechaM")
            .Width = 100
            .Caption = "Fecha"
            .Visible = True
        End With
        With JGMonitoreo.RootTable.Columns("ikHoraM")
            .Width = 100
            .Caption = "Hora"
            .Visible = True
        End With
        With JGMonitoreo.RootTable.Columns("ikT")
            .Width = 100
            .Caption = "T"
            .Visible = True
        End With
        With JGMonitoreo.RootTable.Columns("ikFC")
            .Width = 100
            .Caption = "FC"
            .Visible = True
        End With
        With JGMonitoreo.RootTable.Columns("ikFR")
            .Width = 100
            .Caption = "FR"
            .Visible = True
        End With
        With JGMonitoreo.RootTable.Columns("ikPeso")
            .Width = 100
            .Caption = "Peso"
            .Visible = True
        End With
        With JGMonitoreo.RootTable.Columns("ikSPO2")
            .Width = 100
            .Caption = "SPO2"
            .Visible = True
        End With
        With JGMonitoreo.RootTable.Columns("ikPSys")
            .Width = 100
            .Caption = "PSys"
            .Visible = True
        End With
        With JGMonitoreo.RootTable.Columns("ikPDys")
            .Width = 100
            .Caption = "PDys"
            .Visible = True
        End With
        With JGMonitoreo.RootTable.Columns("ikMED")
            .Width = 100
            .Caption = "MED"
            .Visible = True
        End With
        With JGMonitoreo.RootTable.Columns("ikTRC")
            .Width = 100
            .Caption = "TRC"
            .Visible = True
        End With
        With JGMonitoreo.RootTable.Columns("ikFecha")
            .Width = 100
            .Caption = "Fecha"
            .Visible = False
        End With
        With JGMonitoreo.RootTable.Columns("ikHora")
            .Width = 100
            .Caption = "Hora"
            .Visible = False
        End With
        With JGMonitoreo.RootTable.Columns("ikUsuario")
            .Width = 150
            .Caption = "Usuario"
            .Visible = True
        End With
        With JGMonitoreo.RootTable.Columns("estado")
            .Visible = False
        End With
        With JGMonitoreo.RootTable.Columns("img")
            .Width = 80
            .Caption = "Eliminar".ToUpper
            .CellStyle.ImageHorizontalAlignment = ImageHorizontalAlignment.Center
            .Visible = False
        End With

        With JGMonitoreo
            '.DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            '.FilterMode = FilterMode.Automatic
            '.FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub

    Private Sub _prDetalleAlimentacion(idInternacion As String)
        Dim _tabla As DataTable = L_fnMostrarAlimentacion(idInternacion)
        JGAlimentacion.DataSource = _tabla
        JGAlimentacion.RetrieveStructure()
        JGAlimentacion.AlternatingColors = True

        With JGAlimentacion.RootTable.Columns("ilId")
            .Width = 100
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "Id"
            .Visible = False
        End With
        With JGAlimentacion.RootTable.Columns("il_ihId")
            .Width = 150
            .Caption = "IdInteracion"
            .Visible = False
        End With
        With JGAlimentacion.RootTable.Columns("ilEst")
            .Visible = False
        End With
        With JGAlimentacion.RootTable.Columns("ilFechaA")
            .Width = 100
            .Caption = "Fecha"
            .Visible = True
        End With
        With JGAlimentacion.RootTable.Columns("ilHoraA")
            .Width = 100
            .Caption = "Hora"
            .Visible = True
        End With
        With JGAlimentacion.RootTable.Columns("ilReq")
            .Width = 100
            .Caption = "Requerimiento"
            .Visible = True
        End With
        With JGAlimentacion.RootTable.Columns("ilPVM")
            .Width = 100
            .Caption = "PVM"
            .Visible = True
        End With
        With JGAlimentacion.RootTable.Columns("ilRecovery")
            .Width = 100
            .Caption = "Recovery"
            .Visible = True
        End With
        With JGAlimentacion.RootTable.Columns("ilPolloLic")
            .Width = 100
            .Caption = "PolloLicuado"
            .Visible = True
        End With
        With JGAlimentacion.RootTable.Columns("ilPolloDesm")
            .Width = 100
            .Caption = "PolloDesmenuzado"
            .Visible = True
        End With
        With JGAlimentacion.RootTable.Columns("ilNPO")
            .Width = 100
            .Caption = "NPO"
            .Visible = True
        End With
        With JGAlimentacion.RootTable.Columns("ilAgua")
            .Width = 100
            .Caption = "Agua"
            .Visible = True
        End With
        With JGAlimentacion.RootTable.Columns("ilObs")
            .Width = 150
            .Caption = "Observaciones"
            .Visible = True
        End With
        With JGAlimentacion.RootTable.Columns("ilFecha")
            .Width = 100
            .Caption = "Fecha"
            .Visible = False
        End With
        With JGAlimentacion.RootTable.Columns("ilHora")
            .Width = 100
            .Caption = "Hora"
            .Visible = False
        End With
        With JGAlimentacion.RootTable.Columns("ilUsuario")
            .Width = 150
            .Caption = "Usuario"
            .Visible = True
        End With
        With JGAlimentacion.RootTable.Columns("estado")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With JGAlimentacion.RootTable.Columns("img")
            .Width = 80
            .Caption = "Eliminar".ToUpper
            .CellStyle.ImageHorizontalAlignment = ImageHorizontalAlignment.Center
            .Visible = False
        End With

        With JGAlimentacion
            '.DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            '.FilterMode = FilterMode.Automatic
            '.FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub
    Private Sub _prDetalleFluidoTerapia(idInternacion As String)
        Dim _tabla As DataTable = L_fnMostrarFluidoterapia(idInternacion)
        JGFluidoterapia.DataSource = _tabla
        JGFluidoterapia.RetrieveStructure()
        JGFluidoterapia.AlternatingColors = True

        With JGFluidoterapia.RootTable.Columns("imId")
            .Width = 100
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "Id"
            .Visible = False
        End With
        With JGFluidoterapia.RootTable.Columns("im_ihId")
            .Width = 150
            .Caption = "IdInteracion"
            .Visible = False
        End With
        With JGFluidoterapia.RootTable.Columns("imEst")
            .Visible = False
        End With
        With JGFluidoterapia.RootTable.Columns("imFechaF")
            .Width = 100
            .Caption = "Fecha"
            .Visible = True
        End With
        With JGFluidoterapia.RootTable.Columns("imHoraF")
            .Width = 100
            .Caption = "Hora"
            .Visible = True
        End With
        With JGFluidoterapia.RootTable.Columns("imTurnoF")
            .Width = 100
            .Caption = "IdTurno"
            .Visible = False
        End With
        With JGFluidoterapia.RootTable.Columns("haTurno")
            .Width = 100
            .Caption = "Turno"
            .Visible = True
        End With
        With JGFluidoterapia.RootTable.Columns("imFluidos")
            .Width = 100
            .Caption = "Fluidos"
            .Visible = True
        End With
        With JGFluidoterapia.RootTable.Columns("imHoraI")
            .Width = 100
            .Caption = "HoraInicio"
            .Visible = True
        End With

        With JGFluidoterapia.RootTable.Columns("imHoraT")
            .Width = 100
            .Caption = "HoraTermino"
            .Visible = True
        End With
        With JGFluidoterapia.RootTable.Columns("imCantidad")
            .Width = 100
            .Caption = "Cantidad"
            .Visible = True
        End With
        With JGFluidoterapia.RootTable.Columns("imFecha")
            .Width = 100
            .Caption = "Fecha"
            .Visible = False
        End With
        With JGFluidoterapia.RootTable.Columns("imHora")
            .Width = 100
            .Caption = "Hora"
            .Visible = False
        End With
        With JGFluidoterapia.RootTable.Columns("imUsuario")
            .Width = 150
            .Caption = "Usuario"
            .Visible = True
        End With
        With JGFluidoterapia.RootTable.Columns("estado")
            .Visible = False
        End With
        With JGFluidoterapia.RootTable.Columns("img")
            .Width = 80
            .Caption = "Eliminar".ToUpper
            .CellStyle.ImageHorizontalAlignment = ImageHorizontalAlignment.Center
            .Visible = False
        End With

        With JGFluidoterapia
            '.DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            '.FilterMode = FilterMode.Automatic
            '.FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub

    Private Sub _prDetalleEstudiosC(idInternacion As String)
        Dim _tabla As DataTable = L_fnMostrarEstudiosC(idInternacion)
        JGEstudiosC.DataSource = _tabla
        JGEstudiosC.RetrieveStructure()
        JGEstudiosC.AlternatingColors = True

        With JGEstudiosC.RootTable.Columns("inId")
            .Width = 100
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "Id"
            .Visible = False
        End With
        With JGEstudiosC.RootTable.Columns("in_ihId")
            .Width = 150
            .Caption = "IdInteracion"
            .Visible = False
        End With
        With JGEstudiosC.RootTable.Columns("inEst")
            .Visible = False
        End With
        With JGEstudiosC.RootTable.Columns("inFechaEC")
            .Width = 100
            .Caption = "Fecha"
            .Visible = True
        End With
        With JGEstudiosC.RootTable.Columns("inHoraEC")
            .Width = 100
            .Caption = "Hora"
            .Visible = True
        End With
        With JGEstudiosC.RootTable.Columns("inEstudiosC")
            .Width = 250
            .Caption = "EstudiosComplementarios"
            .Visible = True
        End With
        With JGEstudiosC.RootTable.Columns("inFecha")
            .Width = 100
            .Caption = "Fecha"
            .Visible = False
        End With
        With JGEstudiosC.RootTable.Columns("inHora")
            .Width = 100
            .Caption = "Hora"
            .Visible = False
        End With
        With JGEstudiosC.RootTable.Columns("inUsuario")
            .Width = 150
            .Caption = "Usuario"
            .Visible = True
        End With
        With JGEstudiosC.RootTable.Columns("estado")
            .Visible = False
        End With
        With JGEstudiosC.RootTable.Columns("img")
            .Width = 80
            .Caption = "Eliminar".ToUpper
            .CellStyle.ImageHorizontalAlignment = ImageHorizontalAlignment.Center
            .Visible = False
        End With

        With JGEstudiosC
            '.DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            '.FilterMode = FilterMode.Automatic
            '.FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub

    Private Sub _prDetalleTratamiento(idInternacion As String)
        Dim _tabla As DataTable = L_fnMostrarTratamiento(idInternacion)
        JGTratamiento.DataSource = _tabla
        JGTratamiento.RetrieveStructure()
        JGTratamiento.AlternatingColors = True

        With JGTratamiento.RootTable.Columns("ioId")
            .Width = 100
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "Id"
            .Visible = False
        End With
        With JGTratamiento.RootTable.Columns("io_ihId")
            .Width = 150
            .Caption = "IdInteracion"
            .Visible = False
        End With
        With JGTratamiento.RootTable.Columns("ioEst")
            .Visible = False
        End With
        With JGTratamiento.RootTable.Columns("ioFechaT")
            .Width = 100
            .Caption = "Fecha"
            .Visible = True
        End With
        With JGTratamiento.RootTable.Columns("ioHoraT")
            .Width = 100
            .Caption = "Hora"
            .Visible = True
        End With
        With JGTratamiento.RootTable.Columns("ioTratamiento")
            .Width = 350
            .Caption = "Tratamiento"
            .Visible = True
        End With
        With JGTratamiento.RootTable.Columns("ioFecha")
            .Width = 100
            .Caption = "Fecha"
            .Visible = False
        End With
        With JGTratamiento.RootTable.Columns("ioHora")
            .Width = 100
            .Caption = "Hora"
            .Visible = False
        End With
        With JGTratamiento.RootTable.Columns("ioUsuario")
            .Width = 150
            .Caption = "Usuario"
            .Visible = True
        End With
        With JGTratamiento.RootTable.Columns("estado")
            .Visible = False
        End With
        With JGTratamiento.RootTable.Columns("img")
            .Width = 80
            .Caption = "Eliminar".ToUpper
            .CellStyle.ImageHorizontalAlignment = ImageHorizontalAlignment.Center
            .Visible = False
        End With

        With JGTratamiento
            '.DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            '.FilterMode = FilterMode.Automatic
            '.FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub
    Private Sub _prInhabilitar()
        JGMonitoreo.Enabled = True
        txtIdFicInter.ReadOnly = True
        txtIdFicInter.Enabled = False
        'txtPacienteI.ReadOnly = True
        dtpFechaSeg.Enabled = False
        cbTurno.Enabled = False

        ''Detalle Examen Físico
        cbTurnoEF.Enabled = False
        PanelMucosas.Enabled = False
        PanelDeshidratacion.Enabled = False
        PanelDolor.Enabled = False
        PanelGradoConciencia.Enabled = False
        btnAgregarEF.Enabled = False


        ''Detalle Signos Vitales
        txtVomitos.ReadOnly = True
        txtDiarreas.ReadOnly = True
        txtConvulsiones.ReadOnly = True
        txtInfartos.ReadOnly = True
        txtMiccion.ReadOnly = True
        txtDefecacion.ReadOnly = True
        txtOtrosSV.ReadOnly = True
        btnAgregarSV.Enabled = False
        btnLimpiarSV.Enabled = False

        ''Detalle Monitoreo
        txtT.ReadOnly = True
        txtFC.ReadOnly = True
        txtFR.ReadOnly = True
        txtPeso.ReadOnly = True
        txtSPO2.ReadOnly = True
        txtPSys.ReadOnly = True
        txtPDys.ReadOnly = True
        txtMED.ReadOnly = True
        txtTRC.ReadOnly = True
        btnAgregarM.Enabled = False
        btnLimpiarM.Enabled = False

        ''Detalle Alimentacion
        txtRequerimiento.IsInputReadOnly = True
        txtPVM.ReadOnly = True
        txtRecovery.ReadOnly = True
        txtPolloLic.ReadOnly = True
        txtPolloDesm.ReadOnly = True
        txtNPO.ReadOnly = True
        txtAgua.ReadOnly = True
        txtObs.ReadOnly = True
        btnAgregarA.Enabled = False
        btnLimpiarA.Enabled = False

        ''Detalle Fluidoterapia
        cbTurnoF.Enabled = False
        txtFluidos.ReadOnly = True
        txtHoraInicio.ReadOnly = True
        txtHoraTermino.ReadOnly = True
        txtCantidad.ReadOnly = True
        btnAgregarF.Enabled = False
        btnLimpiarF.Enabled = False

        ''Detalle Estudios Complementarios
        txtEstudiosComplem.ReadOnly = True
        btnAgregarEC.Enabled = False
        btnLimpiarEC.Enabled = False

        ''Detalle Tratamiento
        txtTratamiento.ReadOnly = True
        btnAgregarT.Enabled = False
        btnLimpiarT.Enabled = False

        _Limpiar = False
    End Sub
    Private Sub _prHabilitar()
        JGMonitoreo.Enabled = True
        'txtPacienteI.ReadOnly = False
        txtIdFicInter.ReadOnly = False
        txtIdFicInter.Enabled = True
        dtpFechaSeg.Enabled = True
        cbTurno.Enabled = True

        ''Detalle Examen Físico
        cbTurnoEF.Enabled = True
        PanelMucosas.Enabled = True
        PanelDeshidratacion.Enabled = True
        PanelDolor.Enabled = True
        PanelGradoConciencia.Enabled = True
        btnAgregarEF.Enabled = True

        ''Detalle Signos Vitales
        txtVomitos.ReadOnly = False
        txtDiarreas.ReadOnly = False
        txtConvulsiones.ReadOnly = False
        txtInfartos.ReadOnly = False
        txtMiccion.ReadOnly = False
        txtDefecacion.ReadOnly = False
        txtOtrosSV.ReadOnly = False
        btnAgregarSV.Enabled = True
        btnLimpiarSV.Enabled = True

        ''Detalle Monitoreo
        txtT.ReadOnly = False
        txtFC.ReadOnly = False
        txtFR.ReadOnly = False
        txtPeso.ReadOnly = False
        txtSPO2.ReadOnly = False
        txtPSys.ReadOnly = False
        txtPDys.ReadOnly = False
        txtMED.ReadOnly = False
        txtTRC.ReadOnly = False
        btnAgregarM.Enabled = True
        btnLimpiarM.Enabled = True

        ''Detalle Alimentacion
        txtRequerimiento.IsInputReadOnly = False
        txtPVM.ReadOnly = False
        txtRecovery.ReadOnly = False
        txtPolloLic.ReadOnly = False
        txtPolloDesm.ReadOnly = False
        txtNPO.ReadOnly = False
        txtAgua.ReadOnly = False
        txtObs.ReadOnly = False
        btnAgregarA.Enabled = True
        btnLimpiarA.Enabled = True

        ''Detalle Fluidoterapia
        cbTurnoF.Enabled = True
        txtFluidos.ReadOnly = False
        txtHoraInicio.ReadOnly = False
        txtHoraTermino.ReadOnly = False
        txtCantidad.ReadOnly = False
        btnAgregarF.Enabled = True
        btnLimpiarF.Enabled = True

        ''Detalle Estudios Complementarios
        txtEstudiosComplem.ReadOnly = False
        btnAgregarEC.Enabled = True
        btnLimpiarEC.Enabled = True

        ''Detalle Tratamiento
        txtTratamiento.ReadOnly = False
        btnAgregarT.Enabled = True
        btnLimpiarT.Enabled = True
    End Sub

    Private Sub _LimpiarDet()
        _LimpiarExamenFísico()
        _LimpiarSignosVitales()
        _LimpiarMonitoreo()
        _LimpiarAlimentacion()
        _LimpiarFluidoterapia()
        _LimpiarEstudiosComplementarios()
        _LimpiarTratamiento()
    End Sub


    Private Sub _LimpiarExamenFísico()
        'Limpio Examen Físico
        cbTurno.Value = 1
        chbRosadas.Checked = True
        chb0_5.Checked = True
        chbLeve.Checked = False
        chbModerado.Checked = False
        chbSevero.Checked = False
        chbEstable.Checked = True
        txtHoraEF.Clear()
        dtpFechaEF.Value = Date.Now
    End Sub
    Private Sub _LimpiarSignosVitales()
        'Limpio Signos Vitales
        txtVomitos.Clear()
        txtDiarreas.Clear()
        txtConvulsiones.Clear()
        txtInfartos.Clear()
        txtMiccion.Clear()
        txtDefecacion.Clear()
        txtOtrosSV.Clear()
        txtHoraSV.Clear()
        dtpFechaSV.Value = Date.Now
    End Sub
    Private Sub _LimpiarMonitoreo()
        ''Limpio Monitoreo
        txtT.Clear()
        txtFC.Clear()
        txtFR.Clear()
        txtPeso.Clear()
        txtSPO2.Clear()
        txtPSys.Clear()
        txtPDys.Clear()
        txtMED.Clear()
        txtTRC.Clear()
        txtHoraM.Clear()
        dtpFechaM.Value = Date.Now
    End Sub

    Private Sub _LimpiarAlimentacion()
        ''Limpio Alimentacion
        txtRequerimiento.ResetText()
        txtPVM.Clear()
        txtRecovery.Clear()
        txtPolloLic.Clear()
        txtPolloDesm.Clear()
        txtNPO.Clear()
        txtAgua.Clear()
        txtObs.Clear()
        txtHoraA.Clear()
        dtpFechaA.Value = Date.Now
    End Sub
    Private Sub _LimpiarFluidoterapia()
        ''Detalle Fluidoterapia
        cbTurnoF.Value = 1
        txtFluidos.Clear()
        txtHoraInicio.Clear()
        txtHoraTermino.Clear()
        txtCantidad.Clear()
        txtHoraF.Clear()
        dtpFechaF.Value = Date.Now
    End Sub
    Private Sub _LimpiarEstudiosComplementarios()
        ''Detalle Estudios Complementarios
        txtEstudiosComplem.Clear()
        txtHoraEC.Clear()
        dtpFechaEC.Value = Date.Now
    End Sub
    Private Sub _LimpiarTratamiento()
        ''Detalle Tratamiento
        txtTratamiento.Clear()
        txtHoraT.Clear()
        dtpFechaT.Value = Date.Now
    End Sub

    Private Sub _prLimpiar()
        JGMonitoreo.Enabled = True
        txtId.Clear()
        txtIdFicInter.Clear()
        'txtIdFicClinica.Focus()
        txtPropietarioI.Clear()
        txtTelefonoI.Clear()
        txtPacienteI.Clear()
        txtEdadI.Clear()
        txtSexoI.Clear()
        txtEspecieI.Clear()
        dtpFechaSeg.Value = DateTime.Now
        txtMotivoI.Clear()


        If (_Limpiar = False) Then
            _prSeleccionarCombo(cbTurno)
        End If

        _LimpiarDet()

        _prDetalleExamenFisico(-1)
        _prDetalleSignosVitales(-1)
        _prDetalleMonitoreo(-1)
        _prDetalleAlimentacion(-1)
        _prDetalleFluidoTerapia(-1)
        _prDetalleEstudiosC(-1)
        _prDetalleTratamiento(-1)

        ''Poner el False todos los modificar de los detalles para que ponga la fecha y hora actual del sistema
        ModificarEF = False
        ModificarSV = False
        ModificarM = False
        ModificarA = False
        ModificarF = False
        ModificarEC = False
        ModificarT = False

        txtIdFicInter.Focus()
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
    Private Sub _prCargarComboTurno(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_DeterminarTurno()
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("haIdTurno").Width = 70
            .DropDownList.Columns("haIdTurno").Caption = "COD"
            .DropDownList.Columns.Add("haTurno").Width = 200
            .DropDownList.Columns("haTurno").Caption = "TURNO"
            .ValueMember = "haIdTurno"
            .DisplayMember = "haTurno"
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
    Public Sub _prCargarIconELiminarEF()
        For i As Integer = 0 To CType(JGExamenFisico.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim Bin As New MemoryStream
            Dim img As New Bitmap(My.Resources.delete, 28, 28)
            img.Save(Bin, Imaging.ImageFormat.Png)
            CType(JGExamenFisico.DataSource, DataTable).Rows(i).Item("img") = Bin.GetBuffer
            JGExamenFisico.RootTable.Columns("img").Visible = True
        Next
    End Sub
    Public Sub _prCargarIconELiminarSV()
        For i As Integer = 0 To CType(JGSignosVitales.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim Bin As New MemoryStream
            Dim img As New Bitmap(My.Resources.delete, 28, 28)
            img.Save(Bin, Imaging.ImageFormat.Png)
            CType(JGSignosVitales.DataSource, DataTable).Rows(i).Item("img") = Bin.GetBuffer
            JGSignosVitales.RootTable.Columns("img").Visible = True
        Next
    End Sub
    Public Sub _prCargarIconELiminarM()
        For i As Integer = 0 To CType(JGMonitoreo.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim Bin As New MemoryStream
            Dim img As New Bitmap(My.Resources.delete, 28, 28)
            img.Save(Bin, Imaging.ImageFormat.Png)
            CType(JGMonitoreo.DataSource, DataTable).Rows(i).Item("img") = Bin.GetBuffer
            JGMonitoreo.RootTable.Columns("img").Visible = True
        Next
    End Sub
    Public Sub _prCargarIconELiminarA()
        For i As Integer = 0 To CType(JGAlimentacion.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim Bin As New MemoryStream
            Dim img As New Bitmap(My.Resources.delete, 28, 28)
            img.Save(Bin, Imaging.ImageFormat.Png)
            CType(JGAlimentacion.DataSource, DataTable).Rows(i).Item("img") = Bin.GetBuffer
            JGAlimentacion.RootTable.Columns("img").Visible = True
        Next
    End Sub
    Public Sub _prCargarIconELiminarF()
        For i As Integer = 0 To CType(JGFluidoterapia.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim Bin As New MemoryStream
            Dim img As New Bitmap(My.Resources.delete, 28, 28)
            img.Save(Bin, Imaging.ImageFormat.Png)
            CType(JGFluidoterapia.DataSource, DataTable).Rows(i).Item("img") = Bin.GetBuffer
            JGFluidoterapia.RootTable.Columns("img").Visible = True
        Next
    End Sub
    Public Sub _prCargarIconELiminarEC()
        For i As Integer = 0 To CType(JGEstudiosC.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim Bin As New MemoryStream
            Dim img As New Bitmap(My.Resources.delete, 28, 28)
            img.Save(Bin, Imaging.ImageFormat.Png)
            CType(JGEstudiosC.DataSource, DataTable).Rows(i).Item("img") = Bin.GetBuffer
            JGEstudiosC.RootTable.Columns("img").Visible = True
        Next
    End Sub
    Public Sub _prCargarIconELiminarT()
        For i As Integer = 0 To CType(JGTratamiento.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim Bin As New MemoryStream
            Dim img As New Bitmap(My.Resources.delete, 28, 28)
            img.Save(Bin, Imaging.ImageFormat.Png)
            CType(JGTratamiento.DataSource, DataTable).Rows(i).Item("img") = Bin.GetBuffer
            JGTratamiento.RootTable.Columns("img").Visible = True
        Next
    End Sub
    Private Sub _prAddDetalleExamenFisico()
        Dim Bin As New MemoryStream
        Dim img As New Bitmap(My.Resources.delete, 28, 28)
        img.Save(Bin, Imaging.ImageFormat.Png)

        Dim Mucosas As String = ""
        Dim Deshidratacion As String = ""
        Dim Dolor As String = ""
        Dim GradoConciencia As String = ""
        _prObtenerMucosas(Mucosas)
        _prObtenerDeshidratacion(Deshidratacion)
        _prObtenerDolor(Dolor)
        _prObtenerGradoConciencia(GradoConciencia)
        Dim Hora = Now.Hour.ToString("D2") + ":" + Now.Minute.ToString("D2")

        If ModificarEF = False Then
            CType(JGExamenFisico.DataSource, DataTable).Rows.Add(1, 0, 1, Date.Now, Hora, cbTurnoEF.Value, cbTurnoEF.Text, Mucosas, Deshidratacion, Dolor, GradoConciencia, Now.Date, Hora, gs_user, 0, Bin.GetBuffer)
        Else
            CType(JGExamenFisico.DataSource, DataTable).Rows.Add(1, 0, 1, dtpFechaEF.Value, txtHoraEF.Text, cbTurnoEF.Value, cbTurnoEF.Text, Mucosas, Deshidratacion, Dolor, GradoConciencia, Now.Date, Hora, gs_user, 0, Bin.GetBuffer)
        End If
    End Sub
    Private Sub _prObtenerMucosas(ByRef mucosas As String)
        If chbRosadas.Checked = True Then
            mucosas = chbRosadas.Text
        ElseIf chbPalidas.Checked = True Then
            mucosas = chbPalidas.Text
        ElseIf chbIctericas.Checked = True Then
            mucosas = chbIctericas.Text
        ElseIf chbCianoticas.Checked = True Then
            mucosas = chbCianoticas.Text
        End If
    End Sub
    Private Sub _prObtenerDeshidratacion(ByRef deshidratacion As String)
        If chb0_5.Checked = True Then
            deshidratacion = chb0_5.Text
        ElseIf chb5_7.Checked = True Then
            deshidratacion = chb5_7.Text
        ElseIf chb8_10.Checked = True Then
            deshidratacion = chb8_10.Text
        End If
    End Sub
    Private Sub _prObtenerDolor(ByRef dolor As String)
        If chbLeve.Checked = True Then
            dolor = chbLeve.Text
        ElseIf chbModerado.Checked = True Then
            dolor = chbModerado.Text
        ElseIf chbSevero.Checked = True Then
            dolor = chbSevero.Text
        End If
    End Sub
    Private Sub _prObtenerGradoConciencia(ByRef gradoconc As String)
        If chbEstable.Checked = True Then
            gradoconc = chbEstable.Text
        ElseIf chbSemicomatoso.Checked = True Then
            gradoconc = chbSemicomatoso.Text
        ElseIf chbComa.Checked = True Then
            gradoconc = chbComa.Text
        End If
    End Sub
    Public Function _fnSiguienteNumiEF()
        Dim dt As DataTable = CType(JGExamenFisico.DataSource, DataTable)
        Dim rows() As DataRow = dt.Select("iiId=MAX(iiId)")
        If (rows.Count > 0) Then
            Return rows(rows.Count - 1).Item("iiId")
        End If
        Return 1
    End Function

    Private Sub _prAddDetalleSignosVitales()
        Dim Bin As New MemoryStream
        Dim img As New Bitmap(My.Resources.delete, 28, 28)
        img.Save(Bin, Imaging.ImageFormat.Png)

        Dim Hora = Now.Hour.ToString("D2") + ":" + Now.Minute.ToString("D2")

        If ModificarSV = False Then
            CType(JGSignosVitales.DataSource, DataTable).Rows.Add(1, 0, 1, Date.Now, Hora, txtVomitos.Text,
                                                                  txtDiarreas.Text, txtConvulsiones.Text, txtInfartos.Text,
                                                                  txtMiccion.Text, txtDefecacion.Text, txtOtrosSV.Text, Now.Date,
                                                                  Hora, gs_user, 0, Bin.GetBuffer)
        Else
            CType(JGSignosVitales.DataSource, DataTable).Rows.Add(1, 0, 1, dtpFechaSV.Value, txtHoraSV.Text, txtVomitos.Text,
                                                                  txtDiarreas.Text, txtConvulsiones.Text, txtInfartos.Text,
                                                                  txtMiccion.Text, txtDefecacion.Text, txtOtrosSV.Text, Now.Date,
                                                                  Hora, gs_user, 0, Bin.GetBuffer)
        End If
    End Sub
    Public Function _fnSiguienteNumiSV()
        Dim dt As DataTable = CType(JGSignosVitales.DataSource, DataTable)
        Dim rows() As DataRow = dt.Select("ijId=MAX(ijId)")
        If (rows.Count > 0) Then
            Return rows(rows.Count - 1).Item("ijId")
        End If
        Return 1
    End Function

    Private Sub _prAddDetalleMonitoreo()
        Dim Bin As New MemoryStream
        Dim img As New Bitmap(My.Resources.delete, 28, 28)
        img.Save(Bin, Imaging.ImageFormat.Png)

        Dim Hora = Now.Hour.ToString("D2") + ":" + Now.Minute.ToString("D2")

        If ModificarM = False Then
            CType(JGMonitoreo.DataSource, DataTable).Rows.Add(1, 0, 1, Date.Now, Hora, txtT.Text,
                                                                  txtFC.Text, txtFR.Text, txtPeso.Text, txtSPO2.Text,
                                                                  txtPSys.Text, txtPDys.Text, txtMED.Text, txtTRC.Text, Now.Date,
                                                                  Hora, gs_user, 0, Bin.GetBuffer)
        Else
            CType(JGMonitoreo.DataSource, DataTable).Rows.Add(1, 0, 1, dtpFechaM.Value, txtHoraM.Text, txtT.Text,
                                                                  txtFC.Text, txtFR.Text, txtPeso.Text, txtSPO2.Text,
                                                                  txtPSys.Text, txtPDys.Text, txtMED.Text, txtTRC.Text, Now.Date,
                                                                  Hora, gs_user, 0, Bin.GetBuffer)
        End If
    End Sub
    Private Sub _prAddDetalleAlimentacion()
        Dim Bin As New MemoryStream
        Dim img As New Bitmap(My.Resources.delete, 28, 28)
        img.Save(Bin, Imaging.ImageFormat.Png)
        If txtRequerimiento.Text = String.Empty Then
            Dim img2 As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "Es necesario que llene el campo Requerimiento(kcal)".ToUpper, img2, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)
            Exit Sub
        End If
        Dim Hora = Now.Hour.ToString("D2") + ":" + Now.Minute.ToString("D2")

        If ModificarA = False Then
            CType(JGAlimentacion.DataSource, DataTable).Rows.Add(1, 0, 1, Date.Now, Hora, txtRequerimiento.Text,
                                                                  txtPVM.Text, txtRecovery.Text, txtPolloLic.Text,
                                                                  txtPolloDesm.Text, txtNPO.Text, txtAgua.Text, txtObs.Text,
                                                                  Now.Date, Hora, gs_user, 0, Bin.GetBuffer)
        Else
            CType(JGAlimentacion.DataSource, DataTable).Rows.Add(1, 0, 1, dtpFechaA.Value, txtHoraA.Text, txtRequerimiento.Text,
                                                                  txtPVM.Text, txtRecovery.Text, txtPolloLic.Text,
                                                                  txtPolloDesm.Text, txtNPO.Text, txtAgua.Text, txtObs.Text,
                                                                  Now.Date, Hora, gs_user, 0, Bin.GetBuffer)
        End If
    End Sub
    Private Sub _prAddDetalleFluidoterapia()
        Dim Bin As New MemoryStream
        Dim img As New Bitmap(My.Resources.delete, 28, 28)
        img.Save(Bin, Imaging.ImageFormat.Png)

        Dim Hora = Now.Hour.ToString("D2") + ":" + Now.Minute.ToString("D2")

        If ModificarF = False Then
            CType(JGFluidoterapia.DataSource, DataTable).Rows.Add(1, 0, 1, Date.Now, Hora, cbTurnoF.Value, cbTurnoF.Text,
                                                                  txtFluidos.Text, txtHoraInicio.Text, txtHoraTermino.Text,
                                                                  txtCantidad.Text, Now.Date, Hora, gs_user, 0, Bin.GetBuffer)
        Else
            CType(JGFluidoterapia.DataSource, DataTable).Rows.Add(1, 0, 1, dtpFechaF.Value, txtHoraT.Text, cbTurnoF.Value, cbTurnoF.Text,
                                                                  txtFluidos.Text, txtHoraInicio.Text, txtHoraTermino.Text,
                                                                  txtCantidad.Text, Now.Date, Hora, gs_user, 0, Bin.GetBuffer)
        End If
    End Sub
    Private Sub _prAddDetalleEstudiosC()
        Dim Bin As New MemoryStream
        Dim img As New Bitmap(My.Resources.delete, 28, 28)
        img.Save(Bin, Imaging.ImageFormat.Png)

        Dim Hora = Now.Hour.ToString("D2") + ":" + Now.Minute.ToString("D2")

        If ModificarEC = False Then
            CType(JGEstudiosC.DataSource, DataTable).Rows.Add(1, 0, 1, Date.Now, Hora, txtEstudiosComplem.Text,
                                                               Now.Date, Hora, gs_user, 0, Bin.GetBuffer)
        Else
            CType(JGEstudiosC.DataSource, DataTable).Rows.Add(1, 0, 1, dtpFechaEC.Value, txtHoraEC.Text, txtEstudiosComplem.Text,
                                                               Now.Date, Hora, gs_user, 0, Bin.GetBuffer)
        End If
    End Sub

    Private Sub _prAddDetalleTratamiento()
        Dim Bin As New MemoryStream
        Dim img As New Bitmap(My.Resources.delete, 28, 28)
        img.Save(Bin, Imaging.ImageFormat.Png)

        Dim Hora = Now.Hour.ToString("D2") + ":" + Now.Minute.ToString("D2")

        If ModificarEC = False Then
            CType(JGTratamiento.DataSource, DataTable).Rows.Add(1, 0, 1, Date.Now, Hora, txtTratamiento.Text,
                                                               Now.Date, Hora, gs_user, 0, Bin.GetBuffer)
        Else
            CType(JGTratamiento.DataSource, DataTable).Rows.Add(1, 0, 1, dtpFechaT.Value, txtHoraT.Text, txtTratamiento.Text,
                                                               Now.Date, Hora, gs_user, 0, Bin.GetBuffer)
        End If
    End Sub
#End Region
#Region "METODOS PRIVADOS OVERRRIDABLES"
    Public Overrides Function _PMOGrabarRegistro() As Boolean
        Dim ihId As Integer

        Dim res As Boolean = L_fnGrabarInternacionSeg(ihId, txtIdFicInter.Text, _IdPaciente, dtpFechaSeg.Value.ToString("yyyy/MM/dd"),
                                                      cbTurno.Value, 1, CType(JGExamenFisico.DataSource, DataTable),
                                                      CType(JGSignosVitales.DataSource, DataTable), CType(JGMonitoreo.DataSource, DataTable),
                                                      CType(JGAlimentacion.DataSource, DataTable), CType(JGFluidoterapia.DataSource, DataTable),
                                                      CType(JGEstudiosC.DataSource, DataTable), CType(JGTratamiento.DataSource, DataTable))
        If res Then
            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Id del Seguimiento de internacion ".ToUpper + ihId.ToString() + " Grabado con Exito.".ToUpper,
                                          img, 3000,
                                          eToastGlowColor.Green,
                                          eToastPosition.TopCenter
                                          )
            _Limpiar = True
            NuevoSeg = False
            _prHabilitarMenu(2)
            _prInhabilitar()
            _prFiltrar(2)
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "El seguimiento no pudo ser insertado".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)

        End If
        Return res

    End Function
    ''*****MODDIFICA EL REGISTRO*****''
    Public Overrides Function _PMOModificarRegistro() As Boolean
        Dim ihId As Integer
        Dim res As Boolean

        res = L_fnModificarInternacionSeg(txtId.Text, txtIdFicInter.Text, _IdPaciente, dtpFechaSeg.Value.ToString("yyyy/MM/dd"),
                                                      cbTurno.Value, 2, CType(JGExamenFisico.DataSource, DataTable),
                                                      CType(JGSignosVitales.DataSource, DataTable), CType(JGMonitoreo.DataSource, DataTable),
                                                      CType(JGAlimentacion.DataSource, DataTable), CType(JGFluidoterapia.DataSource, DataTable),
                                                      CType(JGEstudiosC.DataSource, DataTable), CType(JGTratamiento.DataSource, DataTable))
        If res Then
            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Id del Seguimiento de internacion fue ".ToUpper + ihId.ToString() + " Modificado con Exito.".ToUpper,
                                          img, 3000,
                                          eToastGlowColor.Green,
                                          eToastPosition.TopCenter
                                          )
            _prInhabilitar()
            _prFiltrar(2)
            _Limpiar = True
            NuevoSeg = False
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "El seguimiento no pudo ser Modificado".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)

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
        If txtIdFicInter.Text = String.Empty Then
            txtIdFicInter.BackColor = Color.Red
            MEP.SetError(txtIdFicInter, "Seleccione una ficha!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Seleccione una ficha para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        Else
            txtIdFicInter.BackColor = Color.White
            MEP.SetError(txtIdFicInter, "")
        End If
        'If txtFrecuencias.Text = String.Empty Then
        '    txtFrecuencias.BackColor = Color.Red
        '    MEP.SetError(txtFrecuencias, "Ingrese una frecuencia!".ToUpper)
        '    _ok = False
        '    Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
        '    ToastNotification.Show(Me, "Ingrese una frecuencia para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        'Else
        '    txtFrecuencias.BackColor = Color.White
        '    MEP.SetError(txtFrecuencias, "")
        'End If
        'If txtMedProtocolo.Text = String.Empty Then
        '    txtMedProtocolo.BackColor = Color.Red
        '    MEP.SetError(txtMedProtocolo, "Ingrese una medicación!".ToUpper)
        '    _ok = False
        '    Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
        '    ToastNotification.Show(Me, "Ingrese una medicación para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        'Else
        '    txtMedProtocolo.BackColor = Color.White
        '    MEP.SetError(txtMedProtocolo, "")
        'End If
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
        txtIdFicInter.BackColor = Color.White
        cbTurno.BackColor = Color.White
        ' txtFrecuencias.BackColor = Color.White
        'txtMedProtocolo.BackColor = Color.White
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

    Private Sub btnAgregarEF_Click(sender As Object, e As EventArgs) Handles btnAgregarEF.Click
        If cbTurnoEF.SelectedIndex < 0 Then
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "Debe Seleccionar un turno!".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)
            Exit Sub
        End If
        _prAddDetalleExamenFisico()
    End Sub


    Private Sub JGExamenFisico_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGExamenFisico.EditingCell
        e.Cancel = True
    End Sub

    Private Sub JGExamenFisico_SelectionChanged(sender As Object, e As EventArgs) Handles JGExamenFisico.SelectionChanged
        If JGExamenFisico.Row >= 0 And JGExamenFisico.RowCount > 0 Then
            _MPos2 = JGExamenFisico.Row 'Count - 1
            _prMostrarExamenFisico(_MPos2)
        Else
            _LimpiarExamenFísico()
        End If
    End Sub

    Private Sub JGExamenFisico_MouseClick(sender As Object, e As MouseEventArgs) Handles JGExamenFisico.MouseClick
        'If (Not _fnAccesible()) Then
        '    Return
        'End If

        'If (JGExamenFisico.RowCount >= 2) Then
        '    If (JGExamenFisico.CurrentColumn.Index = JGExamenFisico.RootTable.Columns("img").Index) Then
        '        _prEliminarFilaEF()
        '    End If
        'End If
    End Sub
    Public Function _fnAccesible()
        Return dtpFechaSeg.Enabled = True
    End Function
    Public Sub _prEliminarFilaEF()
        If (JGExamenFisico.Row >= 0) Then
            If (JGExamenFisico.RowCount >= 2) Then
                Dim estado As Integer = JGExamenFisico.GetValue("estado")
                Dim pos As Integer = -1
                Dim lin As Integer = JGExamenFisico.GetValue("iiId")
                _fnObtenerFilaDetalle(pos, lin)
                If (estado = 0) Then
                    CType(JGExamenFisico.DataSource, DataTable).Rows(pos).Item("estado") = -2
                End If
                If (estado = 1) Then
                    CType(JGExamenFisico.DataSource, DataTable).Rows(pos).Item("estado") = -1
                End If
                JGExamenFisico.RootTable.ApplyFilter(New Janus.Windows.GridEX.GridEXFilterCondition(JGExamenFisico.RootTable.Columns("estado"), Janus.Windows.GridEX.ConditionOperator.GreaterThanOrEqualTo, 0))

            End If
        End If
    End Sub
    Public Sub _fnObtenerFilaDetalle(ByRef pos As Integer, numi As Integer)
        For i As Integer = 0 To CType(JGExamenFisico.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim _numi As Integer = CType(JGExamenFisico.DataSource, DataTable).Rows(i).Item("iiId")
            If (_numi = numi) Then
                pos = i
                Return
            End If
        Next

    End Sub

    Public Sub _prEliminarFilaSV()
        If (JGSignosVitales.Row >= 0) Then
            If (JGSignosVitales.RowCount >= 2) Then
                Dim estado As Integer = JGSignosVitales.GetValue("estado")
                Dim pos As Integer = -1
                Dim lin As Integer = JGSignosVitales.GetValue("ijId")
                _fnObtenerFilaDetalleSV(pos, lin)
                If (estado = 0) Then
                    CType(JGSignosVitales.DataSource, DataTable).Rows(pos).Item("estado") = -2
                End If
                If (estado = 1) Then
                    CType(JGSignosVitales.DataSource, DataTable).Rows(pos).Item("estado") = -1
                End If
                JGSignosVitales.RootTable.ApplyFilter(New Janus.Windows.GridEX.GridEXFilterCondition(JGSignosVitales.RootTable.Columns("estado"), Janus.Windows.GridEX.ConditionOperator.GreaterThanOrEqualTo, 0))

            End If
        End If
    End Sub
    Public Sub _fnObtenerFilaDetalleSV(ByRef pos As Integer, numi As Integer)
        For i As Integer = 0 To CType(JGSignosVitales.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim _numi As Integer = CType(JGSignosVitales.DataSource, DataTable).Rows(i).Item("ijId")
            If (_numi = numi) Then
                pos = i
                Return
            End If
        Next
    End Sub
    Public Sub _prEliminarFilaM()
        If (JGMonitoreo.Row >= 0) Then
            If (JGMonitoreo.RowCount >= 2) Then
                Dim estado As Integer = JGMonitoreo.GetValue("estado")
                Dim pos As Integer = -1
                Dim lin As Integer = JGMonitoreo.GetValue("ikId")
                _fnObtenerFilaDetalleM(pos, lin)
                If (estado = 0) Then
                    CType(JGMonitoreo.DataSource, DataTable).Rows(pos).Item("estado") = -2
                End If
                If (estado = 1) Then
                    CType(JGMonitoreo.DataSource, DataTable).Rows(pos).Item("estado") = -1
                End If
                JGMonitoreo.RootTable.ApplyFilter(New Janus.Windows.GridEX.GridEXFilterCondition(JGMonitoreo.RootTable.Columns("estado"), Janus.Windows.GridEX.ConditionOperator.GreaterThanOrEqualTo, 0))

            End If
        End If
    End Sub
    Public Sub _fnObtenerFilaDetalleM(ByRef pos As Integer, numi As Integer)
        For i As Integer = 0 To CType(JGMonitoreo.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim _numi As Integer = CType(JGMonitoreo.DataSource, DataTable).Rows(i).Item("ikId")
            If (_numi = numi) Then
                pos = i
                Return
            End If
        Next
    End Sub

    Public Sub _prEliminarFilaA()
        If (JGAlimentacion.Row >= 0) Then
            If (JGAlimentacion.RowCount >= 2) Then
                Dim estado As Integer = JGAlimentacion.GetValue("estado")
                Dim pos As Integer = -1
                Dim lin As Integer = JGAlimentacion.GetValue("ilId")
                _fnObtenerFilaDetalleA(pos, lin)
                If (estado = 0) Then
                    CType(JGAlimentacion.DataSource, DataTable).Rows(pos).Item("estado") = -2
                End If
                If (estado = 1) Then
                    CType(JGAlimentacion.DataSource, DataTable).Rows(pos).Item("estado") = -1
                End If
                JGAlimentacion.RootTable.ApplyFilter(New Janus.Windows.GridEX.GridEXFilterCondition(JGAlimentacion.RootTable.Columns("estado"), Janus.Windows.GridEX.ConditionOperator.GreaterThanOrEqualTo, 0))

            End If
        End If
    End Sub
    Public Sub _fnObtenerFilaDetalleA(ByRef pos As Integer, numi As Integer)
        For i As Integer = 0 To CType(JGAlimentacion.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim _numi As Integer = CType(JGAlimentacion.DataSource, DataTable).Rows(i).Item("ilId")
            If (_numi = numi) Then
                pos = i
                Return
            End If
        Next
    End Sub

    Public Sub _prEliminarFilaF()
        If (JGFluidoterapia.Row >= 0) Then
            If (JGFluidoterapia.RowCount >= 2) Then
                Dim estado As Integer = JGFluidoterapia.GetValue("estado")
                Dim pos As Integer = -1
                Dim lin As Integer = JGFluidoterapia.GetValue("imId")
                _fnObtenerFilaDetalleF(pos, lin)
                If (estado = 0) Then
                    CType(JGFluidoterapia.DataSource, DataTable).Rows(pos).Item("estado") = -2
                End If
                If (estado = 1) Then
                    CType(JGFluidoterapia.DataSource, DataTable).Rows(pos).Item("estado") = -1
                End If
                JGFluidoterapia.RootTable.ApplyFilter(New Janus.Windows.GridEX.GridEXFilterCondition(JGFluidoterapia.RootTable.Columns("estado"), Janus.Windows.GridEX.ConditionOperator.GreaterThanOrEqualTo, 0))

            End If
        End If
    End Sub
    Public Sub _fnObtenerFilaDetalleF(ByRef pos As Integer, numi As Integer)
        For i As Integer = 0 To CType(JGFluidoterapia.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim _numi As Integer = CType(JGFluidoterapia.DataSource, DataTable).Rows(i).Item("imId")
            If (_numi = numi) Then
                pos = i
                Return
            End If
        Next
    End Sub

    Public Sub _prEliminarFilaEC()
        If (JGEstudiosC.Row >= 0) Then
            If (JGEstudiosC.RowCount >= 2) Then
                Dim estado As Integer = JGEstudiosC.GetValue("estado")
                Dim pos As Integer = -1
                Dim lin As Integer = JGEstudiosC.GetValue("inId")
                _fnObtenerFilaDetalleEC(pos, lin)
                If (estado = 0) Then
                    CType(JGEstudiosC.DataSource, DataTable).Rows(pos).Item("estado") = -2
                End If
                If (estado = 1) Then
                    CType(JGEstudiosC.DataSource, DataTable).Rows(pos).Item("estado") = -1
                End If
                JGEstudiosC.RootTable.ApplyFilter(New Janus.Windows.GridEX.GridEXFilterCondition(JGEstudiosC.RootTable.Columns("estado"), Janus.Windows.GridEX.ConditionOperator.GreaterThanOrEqualTo, 0))

            End If
        End If
    End Sub
    Public Sub _fnObtenerFilaDetalleEC(ByRef pos As Integer, numi As Integer)
        For i As Integer = 0 To CType(JGEstudiosC.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim _numi As Integer = CType(JGEstudiosC.DataSource, DataTable).Rows(i).Item("inId")
            If (_numi = numi) Then
                pos = i
                Return
            End If
        Next
    End Sub
    Public Sub _prEliminarFilaT()
        If (JGTratamiento.Row >= 0) Then
            If (JGTratamiento.RowCount >= 2) Then
                Dim estado As Integer = JGTratamiento.GetValue("estado")
                Dim pos As Integer = -1
                Dim lin As Integer = JGTratamiento.GetValue("ioId")
                _fnObtenerFilaDetalleT(pos, lin)
                If (estado = 0) Then
                    CType(JGTratamiento.DataSource, DataTable).Rows(pos).Item("estado") = -2
                End If
                If (estado = 1) Then
                    CType(JGTratamiento.DataSource, DataTable).Rows(pos).Item("estado") = -1
                End If
                JGTratamiento.RootTable.ApplyFilter(New Janus.Windows.GridEX.GridEXFilterCondition(JGTratamiento.RootTable.Columns("estado"), Janus.Windows.GridEX.ConditionOperator.GreaterThanOrEqualTo, 0))

            End If
        End If
    End Sub
    Public Sub _fnObtenerFilaDetalleT(ByRef pos As Integer, numi As Integer)
        For i As Integer = 0 To CType(JGTratamiento.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim _numi As Integer = CType(JGTratamiento.DataSource, DataTable).Rows(i).Item("ioId")
            If (_numi = numi) Then
                pos = i
                Return
            End If
        Next
    End Sub
    Private Sub btnAgregarSV_Click(sender As Object, e As EventArgs) Handles btnAgregarSV.Click
        _prAddDetalleSignosVitales()
    End Sub

    Private Sub btnAgregarM_Click(sender As Object, e As EventArgs) Handles btnAgregarM.Click
        _prAddDetalleMonitoreo()
    End Sub

    Private Sub btnAgregarA_Click(sender As Object, e As EventArgs) Handles btnAgregarA.Click
        _prAddDetalleAlimentacion()
    End Sub

    Private Sub btnAgregarF_Click(sender As Object, e As EventArgs) Handles btnAgregarF.Click
        _prAddDetalleFluidoterapia()
    End Sub

    Private Sub btnAgregarEC_Click(sender As Object, e As EventArgs) Handles btnAgregarEC.Click
        _prAddDetalleEstudiosC()
    End Sub

    Private Sub btnAgregarT_Click(sender As Object, e As EventArgs) Handles btnAgregarT.Click
        _prAddDetalleTratamiento()
    End Sub

    Private Sub JGSignosVitales_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGSignosVitales.EditingCell
        e.Cancel = True
    End Sub

    Private Sub JGAlimentacion_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGAlimentacion.EditingCell
        e.Cancel = True
    End Sub

    Private Sub JGFluidoterapia_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGFluidoterapia.EditingCell
        e.Cancel = True
    End Sub

    Private Sub JGEstudiosC_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGEstudiosC.EditingCell
        e.Cancel = True
    End Sub

    Private Sub JGTratamiento_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGTratamiento.EditingCell
        e.Cancel = True
    End Sub

    Private Sub JGExamenFisico_Click(sender As Object, e As EventArgs) Handles JGExamenFisico.Click
        If (Not _fnAccesible()) Then
            Return
        End If

        If (JGExamenFisico.RowCount >= 2) Then
            If (JGExamenFisico.CurrentColumn.Index = JGExamenFisico.RootTable.Columns("img").Index) Then
                _prEliminarFilaEF()
            End If
        End If
    End Sub

    Private Sub JGSignosVitales_SelectionChanged(sender As Object, e As EventArgs) Handles JGSignosVitales.SelectionChanged
        If JGSignosVitales.Row >= 0 And JGSignosVitales.RowCount > 0 Then
            _MPos2 = JGSignosVitales.Row
            _prMostrarSignosVitales(_MPos2)
        Else
            _LimpiarSignosVitales()
        End If
    End Sub

    Private Sub JGMonitoreo_SelectionChanged(sender As Object, e As EventArgs) Handles JGMonitoreo.SelectionChanged
        If JGMonitoreo.Row >= 0 And JGMonitoreo.RowCount > 0 Then
            _MPos2 = JGMonitoreo.Row
            _prMostrarMonitoreo(_MPos2)
        Else
            _LimpiarMonitoreo()
        End If
    End Sub

    Private Sub JGAlimentacion_SelectionChanged(sender As Object, e As EventArgs) Handles JGAlimentacion.SelectionChanged
        If JGAlimentacion.Row >= 0 And JGAlimentacion.RowCount > 0 Then
            _MPos2 = JGAlimentacion.Row
            _prMostrarAlimentacion(_MPos2)
        Else
            _LimpiarAlimentacion()
        End If
    End Sub

    Private Sub JGFluidoterapia_SelectionChanged(sender As Object, e As EventArgs) Handles JGFluidoterapia.SelectionChanged
        If JGFluidoterapia.Row >= 0 And JGFluidoterapia.RowCount > 0 Then
            _MPos2 = JGFluidoterapia.Row
            _prMostrarFluidoterapia(_MPos2)
        Else
            _LimpiarFluidoterapia()
        End If
    End Sub

    Private Sub JGEstudiosC_SelectionChanged(sender As Object, e As EventArgs) Handles JGEstudiosC.SelectionChanged
        If JGEstudiosC.Row >= 0 And JGEstudiosC.RowCount > 0 Then
            _MPos2 = JGEstudiosC.Row
            _prMostrarEstudiosC(_MPos2)
        Else
            _LimpiarEstudiosComplementarios()
        End If

    End Sub

    Private Sub JGTratamiento_SelectionChanged(sender As Object, e As EventArgs) Handles JGTratamiento.SelectionChanged
        If JGTratamiento.Row >= 0 And JGTratamiento.RowCount > 0 Then
            _MPos2 = JGTratamiento.Row
            _prMostrarTratamiento(_MPos2)
        Else
            _LimpiarTratamiento()
        End If
    End Sub

    Private Sub JGSignosVitales_Click(sender As Object, e As EventArgs) Handles JGSignosVitales.Click
        If (Not _fnAccesible()) Then
            Return
        End If

        If (JGSignosVitales.RowCount >= 2) Then
            If (JGSignosVitales.CurrentColumn.Index = JGSignosVitales.RootTable.Columns("img").Index) Then
                _prEliminarFilaSV()
            End If
        End If
    End Sub

    Private Sub JGMonitoreo_Click(sender As Object, e As EventArgs) Handles JGMonitoreo.Click
        If (Not _fnAccesible()) Then
            Return
        End If

        If (JGMonitoreo.RowCount >= 2) Then
            If (JGMonitoreo.CurrentColumn.Index = JGMonitoreo.RootTable.Columns("img").Index) Then
                _prEliminarFilaM()
            End If
        End If
    End Sub

    Private Sub JGAlimentacion_Click(sender As Object, e As EventArgs) Handles JGAlimentacion.Click
        If (Not _fnAccesible()) Then
            Return
        End If

        If (JGAlimentacion.RowCount >= 2) Then
            If (JGAlimentacion.CurrentColumn.Index = JGAlimentacion.RootTable.Columns("img").Index) Then
                _prEliminarFilaA()
            End If
        End If
    End Sub

    Private Sub JGFluidoterapia_Click(sender As Object, e As EventArgs) Handles JGFluidoterapia.Click
        If (Not _fnAccesible()) Then
            Return
        End If

        If (JGFluidoterapia.RowCount >= 2) Then
            If (JGFluidoterapia.CurrentColumn.Index = JGFluidoterapia.RootTable.Columns("img").Index) Then
                _prEliminarFilaF()
            End If
        End If
    End Sub

    Private Sub JGEstudiosC_Click(sender As Object, e As EventArgs) Handles JGEstudiosC.Click
        If (Not _fnAccesible()) Then
            Return
        End If

        If (JGEstudiosC.RowCount >= 2) Then
            If (JGEstudiosC.CurrentColumn.Index = JGEstudiosC.RootTable.Columns("img").Index) Then
                _prEliminarFilaEC()
            End If
        End If
    End Sub

    Private Sub JGTratamiento_Click(sender As Object, e As EventArgs) Handles JGTratamiento.Click
        If (Not _fnAccesible()) Then
            Return
        End If

        If (JGTratamiento.RowCount >= 2) Then
            If (JGTratamiento.CurrentColumn.Index = JGTratamiento.RootTable.Columns("img").Index) Then
                _prEliminarFilaT()
            End If
        End If
    End Sub

    Private Sub BtnLimpiarSV_Click(sender As Object, e As EventArgs) Handles btnLimpiarSV.Click
        _LimpiarSignosVitales()
    End Sub

    Private Sub btnLimpiarM_Click(sender As Object, e As EventArgs) Handles btnLimpiarM.Click
        _LimpiarMonitoreo()
    End Sub

    Private Sub btnLimpiarA_Click(sender As Object, e As EventArgs) Handles btnLimpiarA.Click
        _LimpiarAlimentacion()
    End Sub

    Private Sub btnLimpiarF_Click(sender As Object, e As EventArgs) Handles btnLimpiarF.Click
        _LimpiarFluidoterapia()
    End Sub

    Private Sub btnLimpiarEC_Click(sender As Object, e As EventArgs) Handles btnLimpiarEC.Click
        _LimpiarEstudiosComplementarios()
    End Sub

    Private Sub btnLimpiarT_Click(sender As Object, e As EventArgs) Handles btnLimpiarT.Click
        _LimpiarTratamiento()
    End Sub

    Private Sub F1_Fic_SegInternacion2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        _prCambiarColorPlomoOscuro(Presentacion.Principal.btnSegInternacion)
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

        ''Poner en True los Modificar de los Detalles para que recupere Fecha y Hora del que se está modificando
        ModificarEF = True
        ModificarSV = True
        ModificarM = True
        ModificarA = True
        ModificarF = True
        ModificarEC = True
        ModificarT = True

        _prCargarIconELiminarEF()
        _prCargarIconELiminarSV()
        _prCargarIconELiminarM()
        _prCargarIconELiminarA()
        _prCargarIconELiminarF()
        _prCargarIconELiminarEC()
        _prCargarIconELiminarT()

    End Sub

    Public Overrides Sub _PMOSalir()
        _prInhabilitar()
        _prFiltrar(1)
    End Sub
#End Region
End Class