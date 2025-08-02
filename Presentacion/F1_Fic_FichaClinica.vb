Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX
Imports System.IO

Public Class F1_Fic_FichaClinica
#Region "Variables"
    Public _IdPaciente, _Iniciar, _MPos, _faId, _fbId, _fbEstado, _Consultorio, _IdVeterinario As Integer
    Public _Paciente, _NombreVeterinario As String
    Private _Limpiar As Boolean
    Private _HoraInicial As String
    Private TablaImagenes As DataTable
    Private RutaTemporal As String = "C:\Tempora"
    Private RutaGlobal As String = gs_CarpetaRaiz
    Private _Nombre As String = ""
    Private mstream1 = New MemoryStream()
    Private _swCirugia As Boolean = False
    Private L_Usuario As String = "DEFAULT"
    Private totalRegistro As Integer
    Private estaCargando As Boolean = False
    Private Event RenderizarDgvListado()
    Private dtItem, dtItemDetalle As DataTable
    Private estaVizualizando As Boolean = True
    Private banderaP2 As Boolean = False, banderaP3 As Boolean = False, banderaP4 As Boolean = False, banderaP5 As Boolean = False, banderaP6 As Boolean = False
#End Region

#Region "Eventos"
    Private Sub F1_Fic_FichaClinica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        superTabControl1.SelectedTabIndex = 0
        _prIniciarTodo()
    End Sub

    Private Sub JGListaArchivos_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGListaArchivos.EditingCell
        e.Cancel = True
    End Sub

    Private Sub btnRecibo_Click(sender As Object, e As EventArgs) Handles btnRecibo.Click
        Dim frm As New F1_Fic_Recibo
        frm._IdFicha = txtIdFicha.Text
        frm._IdPaciente = txtIdMascota.Text
        frm.Show()
    End Sub

    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click
        Try
            btnGuardarArchivo.Enabled = True
            _fnCopiarImagenRutaDefinida()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub dgvListado_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListado.SelectionChanged
        If estaCargando Then Return
        If (dgvListado.RowCount >= 0) Then
            _prMostrarRegistroTodo()
            '_prMostrarRegistro()
        End If
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        If dgvListado.RowCount > 0 Then
            _MPos = 0
            _dgvListado.Rows(_MPos).Selected = True
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If _MPos > 0 And dgvListado.RowCount > 0 Then
            _MPos = _MPos - 1
            _dgvListado.Rows(_MPos).Selected = True
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If _MPos < dgvListado.RowCount - 1 Then
            _MPos = _MPos + 1
            _dgvListado.Rows(_MPos).Selected = True
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        If dgvListado.RowCount > 0 Then
            _MPos = dgvListado.RowCount - 1
            _dgvListado.Rows(_MPos).Selected = True
        End If
    End Sub

    Private Sub btnGuardarArchivo_Click(sender As Object, e As EventArgs) Handles btnGuardarArchivo.Click
        _prPasarImagenTabla()
        btnGuardarArchivo.Enabled = False
        txtDecripcionA.Clear()
    End Sub

    Private Sub JGListaArchivos_DoubleClick(sender As Object, e As EventArgs) Handles JGListaArchivos.DoubleClick
        Try
            If JGListaArchivos.GetValue("Estado") <> 0 Then
                Dim A = RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino\" + "FichaClinica_" + txtIdFicha.Text.Trim + JGListaArchivos.GetValue("feImg")
                'Shell("rundll32.exe C:\WINDOWS\system32\shimgvw.dll,ImageView_Fullscreen " + RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino\" + "FichaClinica_" + txtIdFicha.Text.Trim + JGListaArchivos.GetValue("feImg"))
                Process.Start(A)
            Else
                Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                ToastNotification.Show(Me, "Para vizualizar la imagen debe guardar la ficha clinica".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)
            End If
        Catch ex As Exception
            ''Throw New Exception(ex.Message, ex)
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "No se encuentra la imagen, no se puede visualizar".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)
        End Try
    End Sub

    Private Sub txtIdVeterinario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdVeterinario.KeyDown
        If e.KeyData = Keys.Control + Keys.Enter Then
            Dim dt As DataTable
            dt = L_fnMostrarEmpleadoVeterinarios()
            Dim listEstCeldas As New List(Of Modelo.Celda)
            listEstCeldas.Add(New Modelo.Celda("ecId,", True, "ID", 50))
            listEstCeldas.Add(New Modelo.Celda("ecNomb", True, "Nombre", 180))
            listEstCeldas.Add(New Modelo.Celda("ec_lbIdLib", False, "ec_lbIdLib", 180))
            listEstCeldas.Add(New Modelo.Celda("lbdesc", True, "Tipo de Empleado", 180))
            listEstCeldas.Add(New Modelo.Celda("ecCi", True, "N. Documento", 130))
            listEstCeldas.Add(New Modelo.Celda("ecDir", False, "Direccion", 180))
            listEstCeldas.Add(New Modelo.Celda("ecTelf", False, "ecTelf", 180))
            listEstCeldas.Add(New Modelo.Celda("ecMail", False, "ecMail", 180))
            listEstCeldas.Add(New Modelo.Celda("ecEst", False, "ecEst".ToUpper, 150))
            listEstCeldas.Add(New Modelo.Celda("Estado", False, "Estado".ToUpper, 150))
            listEstCeldas.Add(New Modelo.Celda("ecFNac", False, "F.de Nacimiento".ToUpper, 150))
            listEstCeldas.Add(New Modelo.Celda("ecFIngr", False, "F.de Ingreso".ToUpper, 150))
            listEstCeldas.Add(New Modelo.Celda("ecImg", False, "ecImg".ToUpper, 150))
            listEstCeldas.Add(New Modelo.Celda("ecFecha", False, "ecFecha".ToUpper, 150))
            listEstCeldas.Add(New Modelo.Celda("ecHora", False, "ecHora".ToUpper, 150))
            listEstCeldas.Add(New Modelo.Celda("ecUsuario", False, "ecUsuario".ToUpper, 150))
            Dim ef = New Efecto
            ef.tipo = 3
            ef.dt = dt
            ef.SeleclCol = 1
            ef.listEstCeldas = listEstCeldas
            ef.alto = 160
            ef.ancho = 310
            ef.Context = "Seleccione Empleado".ToUpper
            ef.ShowDialog()
            Dim bandera As Boolean = False
            bandera = ef.band
            If (bandera = True) Then
                Dim Row As Janus.Windows.GridEX.GridEXRow = ef.Row
                If (IsNothing(Row)) Then
                    txtNombVeterinario.Focus()
                    Return
                End If
                txtIdVeterinario.Text = Row.Cells("ecId").Value
                txtNombVeterinario.Text = Row.Cells("ecNomb").Value
            End If
        End If
    End Sub

    Private Sub chbCirugia_CheckedChanged(sender As Object, e As EventArgs) Handles chbCirugia.CheckedChanged
        If chbCirugia.Checked Then
            'Cirugia
            txtPesoC.IsInputReadOnly = False
            txtEdadC.ReadOnly = False
            txtResponsable.ReadOnly = False
            txtTelefonoC.ReadOnly = False
            txtImportadora.ReadOnly = False
            txtClasificacion.ReadOnly = False
            txtProcedimiento.ReadOnly = False
            txtObservacionC.ReadOnly = False

            dtpFCirugía.Value = Now.Date
            txtPesoC.Text = ""
            txtEdadC.Text = ""
            txtResponsable.Text = ""
            txtTelefonoC.Text = ""
            txtImportadora.Text = ""
            txtClasificacion.Text = ""
            txtProcedimiento.Text = ""
            txtObservacionC.Text = ""
        Else
            'Cirugia
            dtpFCirugía.Enabled = False
            txtPesoC.IsInputReadOnly = True
            txtEdadC.ReadOnly = True
            txtResponsable.ReadOnly = True
            txtTelefonoC.ReadOnly = True
            txtImportadora.ReadOnly = True
            txtClasificacion.ReadOnly = True
            txtProcedimiento.ReadOnly = True
            txtObservacionC.ReadOnly = True
        End If
    End Sub

    Private Sub chbExcDelgCC_CheckedChanged(sender As Object, e As EventArgs) Handles chbExcDelgCC.CheckedChanged
        If chbExcDelgCC.Checked Then
            txtScoreCorporal.Text = "1"
        End If
    End Sub

    Private Sub chbBajoPesoCC_CheckedChanged(sender As Object, e As EventArgs) Handles chbBajoPesoCC.CheckedChanged
        If chbBajoPesoCC.Checked Then
            txtScoreCorporal.Text = "2"
        End If
    End Sub

    Private Sub chbPesoIdealCC_CheckedChanged(sender As Object, e As EventArgs) Handles chbPesoIdealCC.CheckedChanged
        If chbPesoIdealCC.Checked Then
            txtScoreCorporal.Text = "3"
        End If
    End Sub

    Private Sub chbSobrepesoCC_CheckedChanged(sender As Object, e As EventArgs) Handles chbSobrepesoCC.CheckedChanged
        If chbSobrepesoCC.Checked Then
            txtScoreCorporal.Text = "4"
        End If
    End Sub

    Private Sub chbSobExtremoCC_CheckedChanged(sender As Object, e As EventArgs) Handles chbSobExtremoCC.CheckedChanged
        If chbSobExtremoCC.Checked Then
            txtScoreCorporal.Text = "5"
        End If
    End Sub

    Private Sub JGFechasSeg_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGFechasSeg.EditingCell
        e.Cancel = True
        txtSeguimiento.Text = JGFechasSeg.GetValue("fjSeguimiento")
        txtValoracion.Text = JGFechasSeg.GetValue("fjValoracion")
        txtProManejo.Text = JGFechasSeg.GetValue("fjProtocoloM")
    End Sub

    Private Sub JGBusqFichaClinica_EditingCell(sender As Object, e As EditingCellEventArgs)
        e.Cancel = True
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        If txtIdFicha.Text <> String.Empty Then
            Dim res As Boolean = L_fnModificarFichaClinicaAlta(txtIdFicha.Text)
            If res Then
                Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
                ToastNotification.Show(Me, "Id de la ficha clinica ".ToUpper + txtIdFicha.Text + " dado de Alta con Exito.".ToUpper,
                                       img, 3000,
                                       eToastGlowColor.Green,
                                       eToastPosition.TopCenter)
                _prInhabilitar()
                _prFiltrar()
            Else
                Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                ToastNotification.Show(Me, "El alta de la ficha clinica no pudo ser insertado".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)
            End If
        End If
    End Sub

    Private Sub EventoRenderizarDgvListado() Handles Me.RenderizarDgvListado
        _MPos = 0
        If dgvListado.Rows.Count = 0 Then
            _prLimpiar()
            _prLLenarPorDefecto() '-------------------ELIMINAR
        Else
            dgvListado.Rows(_MPos).Selected = True
        End If
    End Sub

    Private Sub txtTRPliegue_ValueChanged(sender As Object, e As EventArgs) Handles txtTRPliegue.ValueChanged
        If (txtTLCapilar.Text <= 2 And txtTRPliegue.Value <= 2) Then
            chbPorDeshi1.Checked = True
        ElseIf (txtTLCapilar.Text <= 2 And (txtTRPliegue.Value >= 3 And txtTRPliegue.Value <= 5)) Then
            chbPorDeshi2.Checked = True
        ElseIf ((txtTLCapilar.Text >= 3 And txtTLCapilar.Text <= 4) And (txtTRPliegue.Value >= 3 And txtTRPliegue.Value <= 10)) Then
            chbPorDeshi3.Checked = True
        ElseIf (txtTLCapilar.Text > 5 And txtTRPliegue.Value > 5) Then
            chbPorDeshi4.Checked = True
        ElseIf (txtTLCapilar.Text > 5 And txtTRPliegue.Value = 0) Then
            chbPorDeshi5.Checked = True
        Else
            chbPorDeshi1.Checked = False
            chbPorDeshi2.Checked = False
            chbPorDeshi3.Checked = False
            chbPorDeshi4.Checked = False
            chbPorDeshi5.Checked = False
        End If
    End Sub

    Private Sub F1_Fic_FichaClinica_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        _prCambiarColorPlomoOscuro(Presentacion.Principal.btnFichaClinica)
    End Sub

    Private Sub txtPeso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPeso.KeyPress
        g_prValidarTextBox(1, e)
    End Sub

    Private Sub JGListaArchivos_MouseClick(sender As Object, e As MouseEventArgs) Handles JGListaArchivos.MouseClick
        If (Not _fnAccesible()) Then
            Return
        End If
        If (JGListaArchivos.RowCount >= 1) Then
            If (JGListaArchivos.CurrentColumn.Index = JGListaArchivos.RootTable.Columns("imgelim").Index) Then
                _prEliminarFila()
            End If
        End If
    End Sub

    Private Sub chbInternacion_CheckedChanged(sender As Object, e As EventArgs) Handles chbInternacion.CheckedChanged
        If chbInternacion.Checked Then
            txtIdInt.Text = ""
            dtpFInternacion.Value = Now.Date
            txtEdadI.Text = ""
            txtTelefonoI.Text = ""
            txtObservacionesI.Text = ""
            txtRequiere.Text = ""
            txtHoraInt.Text = ""
        End If
    End Sub

    Private Sub JGInternacion_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGInternacion.EditingCell
        e.Cancel = True
        txtIdInt.Text = JGInternacion.GetValue("igId")
        dtpFInternacion.Value = JGInternacion.GetValue("igFechaIng")
        txtEdadI.Text = JGInternacion.GetValue("igEdad")
        txtTelefonoI.Text = JGInternacion.GetValue("igTelf")
        txtObservacionesI.Text = JGInternacion.GetValue("igMotInter")
        txtRequiere.Text = JGInternacion.GetValue("igRequer")
        txtHoraInt.Text = JGInternacion.GetValue("igHora")
    End Sub

    Private Sub JGCirugia_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGCirugia.EditingCell
        e.Cancel = True
        txtIdCir.Text = JGCirugia.GetValue("cfId")
        dtpFCirugía.Value = JGCirugia.GetValue("cfFechaAten")
        txtPesoC.Text = JGCirugia.GetValue("cfPeso")
        txtEdadC.Text = JGCirugia.GetValue("cfEdad")
        txtResponsable.Text = JGCirugia.GetValue("cfRespon")
        txtTelefonoC.Text = JGCirugia.GetValue("cfTelef")
        txtImportadora.Text = JGCirugia.GetValue("cfImport")
        txtClasificacion.Text = JGCirugia.GetValue("cfClasASA")
        txtProcedimiento.Text = JGCirugia.GetValue("cfProc")
        txtObservacionC.Text = JGCirugia.GetValue("cfObser")
    End Sub

    Private Sub btnBusqueda_Click(sender As Object, e As EventArgs) Handles btnBusqueda.Click
        Dim filtro() As String
        Dim busqueda As String = txtBusqueda.Text
        filtro = Split(busqueda)
        If filtro.Length = 1 Then
            _prListarFichaClinica(filtro.Length, filtro(0))
        ElseIf filtro.Length = 2 Then
            _prListarFichaClinica(filtro.Length, filtro(0), filtro(1))
        ElseIf filtro.Length = 3 Then
            _prListarFichaClinica(filtro.Length, filtro(0), filtro(1), filtro(2))
        ElseIf filtro.Length = 4 Then
            _prListarFichaClinica(filtro.Length, filtro(0), filtro(1), filtro(2), filtro(3))
        ElseIf filtro.Length = 5 Then
            _prListarFichaClinica(filtro.Length, filtro(0), filtro(1), filtro(2), filtro(3), filtro(4))
        End If
    End Sub

    Private Sub dgvListado_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvListado.CellFormatting
        If e.ColumnIndex = dgvListado.Columns("peso_kg").Index AndAlso e.Value IsNot Nothing Then
            Dim valor As Decimal
            If Decimal.TryParse(e.Value.ToString(), valor) Then
                e.Value = String.Format("{0:0.00} kg", valor)
                e.FormattingApplied = True
            End If
        End If
    End Sub

    Private Sub stcFichaClinica_SelectedTabChanging(sender As Object, e As SuperTabStripSelectedTabChangingEventArgs) Handles stcFichaClinica.SelectedTabChanging
        Dim indice As Integer = stcFichaClinica.Tabs.IndexOf(e.NewValue)
        Dim valor As Integer = _fnObtnerNumero(txtIdFicha.Text)
        Select Case indice
            'Case 1
            '    If Not banderaP2 Then _prCargarP2()
            '    banderaP2 = True
            'Case 2
            '    If Not banderaP3 Then _prCargarP3(valor)
            '    banderaP3 = True
            Case 3
                If Not banderaP4 Then _prCargarP4(valor)
                banderaP4 = True
            Case 4
                If Not banderaP5 Then _prCargarP5(valor)
                banderaP5 = True
            Case 5
                If Not banderaP6 Then _prCargarP6(valor)
                banderaP6 = True
        End Select
    End Sub

    Private Sub txtTLCapilar_KeyPress(sender As Object, e As KeyPressEventArgs)
        g_prValidarTextBox(1, e)
    End Sub

    Private Sub JGBusqFichaClinica_DoubleClick(sender As Object, e As EventArgs)
        superTabControl1.SelectedTabIndex = 0
    End Sub
#End Region

#Region "Metodos Privados"
    Private Sub _prIniciarTodo()
        totalRegistro = L_fnListarIDFichasClinicas()
        _HoraInicial = DateTime.Now.ToShortTimeString()
        _prRenderizarGrillaFichaClinicaSeguimiento(-1)
        _prRenderizarGrillaImagenes(-1)
        _prRenderizarGrillaCirugia(-1)
        _prRenderizarGrillaInternacion(-1)
        Select Case _Iniciar
            Case 1
                _MNuevo = True
                btnNuevo.PerformClick()
                txtIdMascota.Text = _IdPaciente
                txtMascota.Text = _Paciente
                cbConsultorio.Value = _Consultorio
                txtIdVeterinario.Text = _IdVeterinario
                txtNombVeterinario.Text = _NombreVeterinario
                _prMostrarPaciente()

                _prAddDetalleSeguimiento()
                _prRenderizarGrillaCirugia(-1)
                _prRenderizarGrillaInternacion(-1)
                pnlBusqueda.Visible = False
            Case 2
                _MNuevo = False
                _prRenderizarGrillaFichaClinicaSeguimiento(-1)
                btnModificar.PerformClick()
                _prObtenerPorIdFichaClinica(_fbId)
                _prMostrarRegistroTodo()
                btnNuevo.Enabled = False
                btnModificar.Enabled = False
                btnEliminar.Enabled = False
                pnlBusqueda.Visible = False
            Case 3
                _PMAsignarPermisos()
                _prCargarComboConsultorios(cbConsultorio)
                _prCargarIcono()
                _prListarFichaClinica()
                _prCrearCarpetaImagenes()
                _prCrearCarpetaTemporal()
                _prHabilitarMenu(1)
                _prInhabilitar()
                btnNuevo.Enabled = False
        End Select
    End Sub

    Private Sub _prCargarComboConsultorios(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_fnMostrarConsultorio()

        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("ccNro").Width = 120
            .DropDownList.Columns("ccNro").Caption = "Consultorio Nro."
            .ValueMember = "ccId"
            .DisplayMember = "ccNro"
            .DataSource = dt
            .Refresh()
        End With
    End Sub

    Private Sub _prCargarIcono()
        Dim blah As New Bitmap(New Bitmap(My.Resources.fichaclinica1), 20, 20)
        Dim ico As Icon = Icon.FromHandle(blah.GetHicon())
        Me.Icon = ico
    End Sub

    Private Sub _prMostrarPaciente()
        Dim valor As Integer
        If String.IsNullOrEmpty(txtIdMascota.Text.Trim()) Then
            valor = -1
        Else
            valor = Convert.ToInt32(txtIdMascota.Text)
        End If

        Dim dtPadiente As DataTable = L_MostrarPacientePorId(valor)
        'Cirugia
        txtPropietarioC.Text = dtPadiente.Rows(0).Item("cacliente")
        txtPacienteC.Text = dtPadiente.Rows(0).Item("pbnomb")
        txtEspecieC.Text = dtPadiente.Rows(0).Item("Especie")
        txtSexoC.Text = dtPadiente.Rows(0).Item("pbsex")
        'Internacion
        txtPropietarioI.Text = dtPadiente.Rows(0).Item("cacliente")
        txtPacienteI.Text = dtPadiente.Rows(0).Item("pbnomb")
        txtEspecieI.Text = dtPadiente.Rows(0).Item("Especie")
        txtSexoI.Text = dtPadiente.Rows(0).Item("pbsex")
    End Sub

    Private Sub _prHabilitarMenu(tipo As Integer)
        If tipo = 1 Then
            If _Iniciar = 1 Or _Iniciar = 2 Then
                btnNuevo.Enabled = False
                btnModificar.Enabled = False
                btnEliminar.Enabled = False
                btnGrabar.Enabled = True
                btnAlta.Enabled = True
                PanelNavegacion.Enabled = False
                superTabItem2.Enabled = False
            End If
        Else
            'btnNuevo.Enabled = True
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
            btnAlta.Enabled = True
            btnGrabar.Enabled = False
            PanelNavegacion.Enabled = True
            superTabItem2.Enabled = True
        End If
    End Sub

    Private Sub _prObtenerDetalle(ByRef tabla As DataTable)
        'GRUPO - LINEA - VALOR1 - VALOR 2, VALOR 3, VALOR 4, VALOR 5
        tabla.Rows.Add("FIC.CLIN0022.Horarios", 1, IIf(chbNormalH.Checked, 1, 0),
                                                   IIf(chbEmergenciaH.Checked, 2, 0), 0, 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.CondicionCorporal", 2,
                                                   IIf(chbExcDelgCC.Checked, 1, 0),
                                                   IIf(chbBajoPesoCC.Checked, 2, 0),
                                                   IIf(chbPesoIdealCC.Checked, 3, 0),
                                                   IIf(chbSobrepesoCC.Checked, 4, 0),
                                                   IIf(chbSobExtremoCC.Checked, 5, 0))
        tabla.Rows.Add("FIC.CLIN0022.Mucosas", 3,
                                                   IIf(chbPalidasM.Checked, 1, 0),
                                                   IIf(chbNormalesM.Checked, 2, 0),
                                                   IIf(chbHiperemicasM.Checked, 3, 0), 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.Dentadura", 4,
                                                   IIf(chbNormalD.Checked, 1, 0),
                                                   IIf(chbAnormalD.Checked, 2, 0), 0, 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.DanoPeriontal", 5,
                                                   IIf(chbunoDP.Checked, 1, 0),
                                                   IIf(chbdosDP.Checked, 2, 0),
                                                   IIf(chbtresDP.Checked, 3, 0), 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.Encias", 6,
                                                   IIf(chbNormalE.Checked, 1, 0),
                                                   IIf(chbAnormalE.Checked, 2, 0), 0, 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.Gingivitis", 7,
                                                   IIf(chbLeveG.Checked, 1, 0),
                                                   IIf(chbModeradaG.Checked, 2, 0),
                                                   IIf(chbSeveraG.Checked, 3, 0), 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.Sarro", 8,
                                                  IIf(chbLeveS.Checked, 1, 0),
                                                  IIf(chbModeradoS.Checked, 2, 0),
                                                  IIf(chbSeveroS.Checked, 3, 0), 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.MasaOral", 9, IIf(chbMasaOral.Checked, 1, 0), 0, 0, 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.PorcentajeDeshidratacion", 10,
                                                   IIf(chbPorDeshi1.Checked, 1, 0),
                                                   IIf(chbPorDeshi2.Checked, 2, 0),
                                                   IIf(chbPorDeshi3.Checked, 3, 0),
                                                   IIf(chbPorDeshi4.Checked, 4, 0),
                                                   IIf(chbPorDeshi5.Checked, 5, 0))
        tabla.Rows.Add("FIC.CLIN0022.Ojos", 11,
                                                  IIf(chbNormalO.Checked, 1, 0),
                                                  IIf(chbAnormalO.Checked, 2, 0),
                                                  IIf(chbDerechoO.Checked, 3, 0),
                                                  IIf(chbIzquierdoO.Checked, 4, 0), 0)
        tabla.Rows.Add("FIC.CLIN0022.Orejas", 12,
                                                  IIf(chbNormalOr.Checked, 1, 0),
                                                  IIf(chbAnormalOr.Checked, 2, 0),
                                                  IIf(chbDerechaOr.Checked, 3, 0),
                                                  IIf(chbIzquierdaOr.Checked, 4, 0), 0)
        tabla.Rows.Add("FIC.CLIN0022.Corazon", 13,
                                              IIf(chbNormalC.Checked, 1, 0),
                                              IIf(chbAnormalC.Checked, 2, 0),
                                              IIf(chbRuidosCardiacos.Checked, 3, 0), 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.Pulmones", 14,
                                              IIf(chbNormalP.Checked, 1, 0),
                                              IIf(chbAnormalP.Checked, 2, 0),
                                              IIf(chbRuidosRespP.Checked, 3, 0), 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.PielPelo", 15,
                                              IIf(chbNormalPe.Checked, 1, 0),
                                              IIf(chbAnormalPe.Checked, 2, 0), 0, 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.Linfonodulos", 16,
                                              IIf(chbNormalL.Checked, 1, 0),
                                              IIf(chbAnormalL.Checked, 2, 0), 0, 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.SistemaNervioso", 17,
                                              IIf(chbNormalSN.Checked, 1, 0),
                                              IIf(chbAnormalSN.Checked, 2, 0), 0, 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.SistemaGenitoUrinario", 18,
                                      IIf(chbNormalG.Checked, 1, 0),
                                      IIf(chbAnormalG.Checked, 2, 0), 0, 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.SistemaMusculoEsqueletico", 19,
                                      IIf(chbNormalSME.Checked, 1, 0),
                                      IIf(chbAnormalSME.Checked, 2, 0), 0, 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.SistemaMusculoEsqueletico", 20,
                                           IIf(chbmpostizq.Checked, 3, 0),
                                           IIf(chbmpostder.Checked, 4, 0),
                                           IIf(chbPelvis.Checked, 5, 0),
                                           IIf(chbAbdomen.Checked, 6, 0),
                                           IIf(chbTorax.Checked, 7, 0))
        tabla.Rows.Add("FIC.CLIN0022.SistemaMusculoEsqueletico", 21,
                                           IIf(chbmantizq.Checked, 8, 0),
                                           IIf(chbmantder.Checked, 9, 0),
                                           IIf(chbCabeza.Checked, 10, 0), 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.Abdomen", 22,
                                    IIf(chbNormalA.Checked, 1, 0),
                                    IIf(chbAnormalA.Checked, 2, 0), 0, 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.Dolor", 23,
                                          IIf(chbAgudoD.Checked, 1, 0),
                                          IIf(chbLeveD.Checked, 2, 0),
                                          IIf(chbModeradoD.Checked, 3, 0),
                                          IIf(chbSeveroD.Checked, 4, 0), 0)
        tabla.Rows.Add("FIC.CLIN0022.LocalizadoRegion", 24,
                                        IIf(chbEstomago.Checked, 1, 0),
                                        IIf(chbHigado.Checked, 2, 0),
                                        IIf(chbPancreas.Checked, 3, 0),
                                        IIf(chbProstata.Checked, 4, 0),
                                        IIf(chbUtero.Checked, 5, 0))
        tabla.Rows.Add("FIC.CLIN0022.LocalizadoRegion", 25,
                                        IIf(chbVejiga.Checked, 6, 0),
                                        IIf(chbIdelgado.Checked, 7, 0),
                                        IIf(chbIGrueso.Checked, 8, 0), 0, 0)
        tabla.Rows.Add("FIC.CLIN0022.Alteraciones", 26,
                                         IIf(chbExtraño.Checked, 1, 0),
                                         IIf(chblineal.Checked, 2, 0),
                                         IIf(chbMabdominal.Checked, 3, 0),
                                         IIf(chbIntu.Checked, 4, 0),
                                         IIf(chbAscitis.Checked, 5, 0))
        tabla.Rows.Add("FIC.CLIN0022.ExamenesComplementarios", 27,
                                      IIf(chbLaboratorio.Checked, 1, 0),
                                      IIf(chbEcografia.Checked, 2, 0),
                                      IIf(chbRadiografia.Checked, 3, 0), 0, 0)
    End Sub

    Private Sub _prListarFichaClinica(Optional cant As Integer = 1, Optional _filtro As String = "", Optional _filtro1 As String = "", Optional _filtro2 As String = "", Optional _filtro3 As String = "", Optional _filtro4 As String = "")
        Dim dt As New DataTable
        dt = L_fnListarFichasClinicas(cant, 50000, _filtro, _filtro1, _filtro2, _filtro3, _filtro4)
        _prRenderizarGrillaListado(dt)
    End Sub

    Private Sub _prObtenerPorIdFichaClinica(_id As Integer)
        Dim dt As New DataTable
        dt = L_fnMostrarFichaClinicaUno(_id)
        _prRenderizarGrillaListado(dt)
    End Sub

    Private Sub _prRenderizarGrillaListado(_dt As DataTable)
        estaCargando = True
        dgvListado.DataSource = _dt
        With dgvListado
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .RowHeadersVisible = False
            .ReadOnly = True
            .AllowUserToAddRows = False
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

            .Columns("id").Width = 50
            .Columns("id").HeaderText = "ID"
            .Columns("veterinario").Width = 200
            .Columns("veterinario").HeaderText = "Especialista"
            .Columns("cliente").Width = 200
            .Columns("cliente").HeaderText = "Paciente"
            .Columns("paciente").Width = 100
            .Columns("paciente").HeaderText = "Paciente"
            .Columns("paciente").Visible = False
            .Columns("peso_kg").HeaderText = "Peso KG."
            .Columns("peso_kg").Visible = False
            .Columns("fecha_atencion").DefaultCellStyle.Format = "dd/MM/yyyy"
            .Columns("fecha_atencion").HeaderText = "Fecha de atención"
            .Columns("reconsulta").DefaultCellStyle.Format = "dd/MM/yyyy"
            .Columns("reconsulta").HeaderText = "Fecha de reconsulta"
        End With

        For Each columna As DataGridViewColumn In dgvListado.Columns
            columna.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        If dgvListado.Rows.Count > 0 Then dgvListado.Rows(0).Selected = False
        estaCargando = False
        RaiseEvent RenderizarDgvListado()
    End Sub

    Private Sub _prRenderizarGrillaFichaClinicaSeguimiento(_fbId As String)
        Dim dt As New DataTable
        dt = L_prMostrarFichaClinicaSeguimiento(_fbId)
        If CType(JGFechasSeg.DataSource, DataTable) IsNot Nothing Then
            CType(JGFechasSeg.DataSource, DataTable).Clear()
        End If

        JGFechasSeg.DataSource = dt
        JGFechasSeg.RetrieveStructure()
        JGFechasSeg.AlternatingColors = True

        With JGFechasSeg.RootTable.Columns("fjId")
            .Width = 100
            .Caption = "Id"
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Visible = False
        End With
        With JGFechasSeg.RootTable.Columns("fj_FbId")
            .Width = 100
            .Caption = "IdFicha"
            .Visible = False

        End With
        With JGFechasSeg.RootTable.Columns("Estado")
            .Width = 90
            .Visible = False
            .Caption = "Estado"
        End With
        With JGFechasSeg.RootTable.Columns("fjSeguimiento")
            .Width = 180
            .Caption = "Seguimiento"
            .Visible = False
        End With
        With JGFechasSeg.RootTable.Columns("fjValoracion")
            .Width = 180
            .Caption = "Valoración"
            .Visible = False
        End With
        With JGFechasSeg.RootTable.Columns("fjProtocoloM")
            .Width = 180
            .Caption = "ProtocoloM"
            .Visible = False
        End With
        With JGFechasSeg.RootTable.Columns("fjFecha")
            .Width = 130
            .Caption = "Fecha"
            .Visible = True
        End With
        With JGFechasSeg.RootTable.Columns("fjHora")
            .Width = 130
            .Visible = True
            .Caption = "Hora"
        End With
        With JGFechasSeg.RootTable.Columns("fjUsuario")
            .Width = 190
            .Caption = "Usuario"
            .Visible = True
        End With
        With JGFechasSeg
            .DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub

    Private Sub _prRenderizarGrillaCirugia(_fbId As String)
        Dim dt As New DataTable
        dt = L_prMostrarFechaCirugia(_fbId)
        JGCirugia.DataSource = dt
        JGCirugia.RetrieveStructure()
        JGCirugia.AlternatingColors = True

        With JGCirugia.RootTable.Columns("cfId")
            .Width = 100
            .Caption = "IdCirugía"
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Visible = True
        End With
        With JGCirugia.RootTable.Columns("cf_FbId")
            .Width = 100
            .Caption = "IdFicha"
            .Visible = False
        End With
        With JGCirugia.RootTable.Columns("cfEst")
            .Width = 90
            .Visible = False
            .Caption = "Estado"
        End With
        With JGCirugia.RootTable.Columns("cfFechaAten")
            .Width = 90
            .Caption = "Fecha Cir."
            .Visible = True
        End With
        With JGCirugia.RootTable.Columns("cfPeso")
            .Visible = False
        End With
        With JGCirugia.RootTable.Columns("cfEdad")
            .Visible = False
        End With
        With JGCirugia.RootTable.Columns("cfRespon")
            .Width = 180
            .Visible = False
        End With
        With JGCirugia.RootTable.Columns("cfTelef")
            .Width = 130
            .Visible = False
        End With
        With JGCirugia.RootTable.Columns("cfImport")
            .Width = 130
            .Visible = False
        End With
        With JGCirugia.RootTable.Columns("cfClasASA")
            .Width = 130
            .Visible = False
        End With
        With JGCirugia.RootTable.Columns("cfProc")
            .Width = 130
            .Visible = False
        End With
        With JGCirugia.RootTable.Columns("cfObser")
            .Width = 130
            .Visible = False
        End With
        With JGCirugia.RootTable.Columns("cfUsuario")
            .Width = 150
            .Caption = "Usuario"
            .Visible = True
        End With
        With JGCirugia
            .DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub

    Private Sub _prRenderizarGrillaInternacion(_fbId As String)
        Dim dt As New DataTable
        dt = L_prMostrarInternación(_fbId)
        JGInternacion.DataSource = dt
        JGInternacion.RetrieveStructure()
        JGInternacion.AlternatingColors = True

        With JGInternacion.RootTable.Columns("igId")
            .Width = 100
            .Caption = "IdInternación"
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Visible = True
        End With
        With JGInternacion.RootTable.Columns("ig_fbId")
            .Width = 100
            .Caption = "IdFicha"
            .Visible = False
        End With
        With JGInternacion.RootTable.Columns("igEst")
            .Width = 90
            .Visible = False
            .Caption = "Estado"
        End With
        With JGInternacion.RootTable.Columns("igFechaIng")
            .Width = 90
            .Caption = "Fecha Int."
            .Visible = True
        End With
        With JGInternacion.RootTable.Columns("igEdad")
            .Width = 180
            .Visible = False
        End With
        With JGInternacion.RootTable.Columns("igTelf")
            .Width = 180
            .Visible = False
        End With
        With JGInternacion.RootTable.Columns("igMotInter")
            .Width = 130

            .Visible = False
        End With
        With JGInternacion.RootTable.Columns("igRequer")
            .Width = 130
            .Visible = False
        End With
        With JGInternacion.RootTable.Columns("igHoraInter")
            .Width = 70
            .Caption = "Hora"
            .Visible = True
        End With
        With JGInternacion.RootTable.Columns("igHora")
            .Width = 70
            .Visible = False
        End With
        With JGInternacion.RootTable.Columns("igUsuario")
            .Width = 150
            .Caption = "Usuario"
            .Visible = True
        End With
        With JGInternacion
            .DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub

    Public Sub _prMostrarRegistroTodo()
        Dim id As Integer = _fnObtnerNumero(dgvListado.CurrentRow.Cells("id").Value) 'txtIdFicha.Text)
        dtItem = L_fnObtenerFichaClinicaPorID(id)
        dtItemDetalle = L_fnMostrarFichaClinicaDetalle(id)
        stcFichaClinica.SelectedTabIndex = 0
        If dtItem.Rows.Count > 0 And dtItemDetalle.Rows.Count > 0 Then
            _prCargarP1()
            _prCargarP2()
            _prCargarP5(id)
            _prCargarP6(id)
        End If
        _prCargarP3(id)
        _prCargarP4(id)


        _prLimpiarBanderas(True)
    End Sub

    Public Sub _prMostrarRegistro()
        dtItem = L_fnObtenerFichaClinicaPorID(dgvListado.SelectedRows(0).Cells("id").Value)
        dtItemDetalle = L_fnMostrarFichaClinicaDetalle(dgvListado.SelectedRows(0).Cells("id").Value)
        stcFichaClinica.SelectedTabIndex = 0
        _prCargarP1()

        Dim existeFichaClinicaAlta As Boolean = L_fnExisteFichaClinicaAlta(txtIdFicha.Text)
        btnModificar.Enabled = existeFichaClinicaAlta
        btnEliminar.Enabled = existeFichaClinicaAlta
        btnRecibo.Enabled = existeFichaClinicaAlta
        btnAlta.Enabled = existeFichaClinicaAlta

        _prLimpiarBanderas(False)
    End Sub

    Private Sub _prCargarP1()
        txtIdFicha.Text = dtItem.Rows(0)("fbid")
        txtMascota.Text = dtItem.Rows(0)("pbnomb")
        txtIdMascota.Text = dtItem.Rows(0)("fb_pbid")
        dtpFechaFC.Value = dtItem.Rows(0)("fbFechaAten")
        cbConsultorio.Value = IIf(IsDBNull(dtItem.Rows(0)("fbConsultorio")), Nothing, dtItem.Rows(0)("fbConsultorio"))
        txtIdVeterinario.Text = dtItem.Rows(0)("fb_ecId")
        txtNombVeterinario.Text = dtItem.Rows(0)("ecNomb")
        txtHistoria.Text = dtItem.Rows(0)("fbHist")
        txtExaminacion.Text = dtItem.Rows(0)("fbExam")
        txtTemperatura.Text = dtItem.Rows(0)("fbTempe")
        txtPeso.Text = dtItem.Rows(0)("fbPeso")
        txtFCardiaca.Text = dtItem.Rows(0)("fbFreCar")
        txtFRespiratoria.Text = dtItem.Rows(0)("fbFreRes")
        txtScoreCorporal.Text = dtItem.Rows(0)("fbSCorp")
        txtTLCapilar.Text = dtItem.Rows(0)("fbTiemCapi")
        txtTRPliegue.Text = dtItem.Rows(0)("fbTiemRPlie")

        For Each fila As DataRow In dtItemDetalle.Rows
            Select Case fila.Item("fc_fdLinea")
                Case 1
                    chbNormalH.Checked = fila.Item("fcVal1") <> 0
                    chbEmergenciaH.Checked = fila.Item("fcVal2") <> 0
                Case 2
                    chbExcDelgCC.Checked = fila.Item("fcVal1") <> 0
                    chbBajoPesoCC.Checked = fila.Item("fcVal2") <> 0
                    chbPesoIdealCC.Checked = fila.Item("fcVal3") <> 0
                    chbSobrepesoCC.Checked = fila.Item("fcVal4") <> 0
                    chbSobExtremoCC.Checked = fila.Item("fcVal5") <> 0
                Case 3
                    chbPalidasM.Checked = fila.Item("fcVal1") <> 0
                    chbNormalesM.Checked = fila.Item("fcVal2") <> 0
                    chbHiperemicasM.Checked = fila.Item("fcVal3") <> 0
                Case 4
                    chbNormalD.Checked = fila.Item("fcVal1") <> 0
                    chbAnormalD.Checked = fila.Item("fcVal2") <> 0
                Case 5
                    chbunoDP.Checked = fila.Item("fcVal1") <> 0
                    chbdosDP.Checked = fila.Item("fcVal2") <> 0
                    chbtresDP.Checked = fila.Item("fcVal3") <> 0
                Case 6
                    chbNormalE.Checked = fila.Item("fcVal1") <> 0
                    chbAnormalE.Checked = fila.Item("fcVal2") <> 0
                Case 7
                    chbLeveG.Checked = fila.Item("fcVal1") <> 0
                    chbModeradaG.Checked = fila.Item("fcVal2") <> 0
                    chbSeveraG.Checked = fila.Item("fcVal3") <> 0
                Case 8
                    chbLeveS.Checked = fila.Item("fcVal1") <> 0
                    chbModeradoS.Checked = fila.Item("fcVal2") <> 0
                    chbSeveroS.Checked = fila.Item("fcVal3") <> 0
                Case 9
                    chbMasaOral.Checked = fila.Item("fcVal1") <> 0
                Case 10
                    chbPorDeshi1.Checked = fila.Item("fcVal1") <> 0
                    chbPorDeshi2.Checked = fila.Item("fcVal2") <> 0
                    chbPorDeshi3.Checked = fila.Item("fcVal3") <> 0
                    chbPorDeshi4.Checked = fila.Item("fcVal4") <> 0
                    chbPorDeshi5.Checked = fila.Item("fcVal5") <> 0
            End Select
        Next

        'Muestra la cantidad de registros
        LblPaginacion.Text = Str(dgvListado.SelectedRows(0).Index + 1) + " de " + dgvListado.RowCount.ToString + "    Total: " + totalRegistro.ToString

        'Muestra el bubblebar(que usuario registró la Ficha Clínica)
        lbFecha.Text = CType(dtItem.Rows(0)("fbFecha"), Date).ToString("dd/MM/yyyy")
        lbHora.Text = dtItem.Rows(0)("fbHora").ToString
        lbUsuario.Text = dtItem.Rows(0)("fbUsuario").ToString
    End Sub

    Private Sub _prCargarP2()
        For Each fila As DataRow In dtItemDetalle.Rows
            Select Case fila.Item("fc_fdLinea")
                Case 11 'Ojos
                    chbNormalO.Checked = fila.Item("fcVal1") <> 0
                    chbAnormalO.Checked = fila.Item("fcVal2") <> 0
                    chbDerechoO.Checked = fila.Item("fcVal3") <> 0
                    chbIzquierdoO.Checked = fila.Item("fcVal4") <> 0
                Case 12 'Orejas
                    chbNormalOr.Checked = fila.Item("fcVal1") <> 0
                    chbAnormalOr.Checked = fila.Item("fcVal2") <> 0
                    chbDerechaOr.Checked = fila.Item("fcVal3") <> 0
                    chbIzquierdaOr.Checked = fila.Item("fcVal4") <> 0
                Case 13 'Corazon
                    chbNormalC.Checked = fila.Item("fcVal1") <> 0
                    chbAnormalC.Checked = fila.Item("fcVal2") <> 0
                    chbRuidosCardiacos.Checked = fila.Item("fcVal3") <> 0
                Case 14 'Pulmones
                    chbNormalP.Checked = fila.Item("fcVal1") <> 0
                    chbAnormalP.Checked = fila.Item("fcVal2") <> 0
                    chbRuidosCardiacos.Checked = fila.Item("fcVal3") <> 0
                Case 15 'Piel y pelo
                    chbNormalPe.Checked = fila.Item("fcVal1") <> 0
                    chbAnormalPe.Checked = fila.Item("fcVal2") <> 0
                Case 16 'Linfonodulos
                    chbNormalL.Checked = fila.Item("fcVal1") <> 0
                    chbAnormalL.Checked = fila.Item("fcVal2") <> 0
                Case 17 'Sitema nervioso
                    chbNormalSN.Checked = fila.Item("fcVal1") <> 0
                    chbAnormalSN.Checked = fila.Item("fcVal2") <> 0
                Case 18 'Sistema Genitourinario
                    chbNormalG.Checked = fila.Item("fcVal1") <> 0
                    chbAnormalG.Checked = fila.Item("fcVal2") <> 0
                Case 19 'Sistema musculo esqueletico Linea 1
                    chbNormalSME.Checked = fila.Item("fcVal1") <> 0
                    chbAnormalSME.Checked = fila.Item("fcVal2") <> 0
                Case 20 'Sistema musculo esqueletico Linea 2
                    chbmpostizq.Checked = fila.Item("fcVal1") <> 0
                    chbmpostder.Checked = fila.Item("fcVal2") <> 0
                    chbPelvis.Checked = fila.Item("fcVal3") <> 0
                    chbAbdomen.Checked = fila.Item("fcVal4") <> 0
                    chbTorax.Checked = fila.Item("fcVal5") <> 0
                Case 21 'Sistema musculo esqueletico Linea 3
                    chbmantizq.Checked = fila.Item("fcVal1") <> 0
                    chbmantder.Checked = fila.Item("fcVal2") <> 0
                    chbCabeza.Checked = fila.Item("fcVal3") <> 0
                Case 22 'Abdomen
                    chbNormalA.Checked = fila.Item("fcVal1") <> 0
                    chbAnormalA.Checked = fila.Item("fcVal2") <> 0
                Case 23 'Dolor
                    chbAgudoD.Checked = fila.Item("fcVal1") <> 0
                    chbLeveD.Checked = fila.Item("fcVal2") <> 0
                    chbModeradoD.Checked = fila.Item("fcVal3") <> 0
                    chbSeveroD.Checked = fila.Item("fcVal4") <> 0
                Case 24 'Localizado en region linea 1
                    chbEstomago.Checked = fila.Item("fcVal1") <> 0
                    chbHigado.Checked = fila.Item("fcVal2") <> 0
                    chbPancreas.Checked = fila.Item("fcVal3") <> 0
                    chbProstata.Checked = fila.Item("fcVal4") <> 0
                    chbUtero.Checked = fila.Item("fcVal5") <> 0
                Case 25 'Localizado en region linea 2
                    chbVejiga.Checked = fila.Item("fcVal1") <> 0
                    chbIdelgado.Checked = fila.Item("fcVal2") <> 0
                    chbIGrueso.Checked = fila.Item("fcVal3") <> 0
                Case 26 'Alteraciones
                    chbExtraño.Checked = fila.Item("fcVal1") <> 0
                    chblineal.Checked = fila.Item("fcVal2") <> 0
                    chbMabdominal.Checked = fila.Item("fcVal3") <> 0
                    chbIntu.Checked = fila.Item("fcVal4") <> 0
                    chbAscitis.Checked = fila.Item("fcVal5") <> 0
            End Select
        Next
        txtNotas.Text = dtItem.Rows(0)("fbNotas")
    End Sub

    Private Sub _prCargarP3(id As Integer)
        For Each fila As DataRow In dtItemDetalle.Rows
            Select Case fila.Item("fc_fdLinea")
                Case 26 'Examenes complementarios
                    chbLaboratorio.Checked = fila.Item("fcVal1") <> 0
                    chbEcografia.Checked = fila.Item("fcVal2") <> 0
                    chbRadiografia.Checked = fila.Item("fcVal3") <> 0
            End Select
        Next
        _prRenderizarGrillaFichaClinicaSeguimiento(id)
        txtValoracion.Text = JGFechasSeg.GetValue("fjValoracion")
        txtProManejo.Text = JGFechasSeg.GetValue("fjProtocoloM")
        txtSeguimiento.Text = JGFechasSeg.GetValue("fjSeguimiento")
        'dtpFProxVisita.Value = dtItem.Rows(0)("fbFechaProx")
        If Not estaVizualizando Then _prAddDetalleSeguimiento()
    End Sub

    Public Sub _prCargarP4(id As Integer)
        _prRenderizarGrillaImagenes(id)

        If Not estaVizualizando Then _prCargarIconELiminar()
    End Sub

    Public Sub _prCargarP5(id As Integer)
        _prRenderizarGrillaCirugia(id)
        _prLimpiarCirugia()
        _prMostrarPaciente()

        If Not L_fnExisteCirugia(txtIdFicha.Text) Then
            Dim _tabla As DataTable = L_fnMostrarCirugiaPorID(id)
            If _tabla.Rows.Count <> 0 Then
                txtIdCir.Text = _tabla.Rows(0).Item("cfId")
                dtpFCirugía.Value = _tabla.Rows(0).Item("cfFechaAten")
                txtPesoC.Text = _tabla.Rows(0).Item("cfPeso")
                txtEdadC.Text = _tabla.Rows(0).Item("cfEdad")
                txtResponsable.Text = _tabla.Rows(0).Item("cfRespon")
                txtTelefonoC.Text = _tabla.Rows(0).Item("cfTelef")
                txtImportadora.Text = _tabla.Rows(0).Item("cfImport")
                txtClasificacion.Text = _tabla.Rows(0).Item("cfClasASA")
                txtProcedimiento.Text = _tabla.Rows(0).Item("cfProc")
                txtObservacionC.Text = _tabla.Rows(0).Item("cfObser")
            End If
        End If
    End Sub

    Public Sub _prCargarP6(id As Integer)
        _prRenderizarGrillaInternacion(id)
        _prLimpiarInternacion()
        _prMostrarPaciente()

        If Not L_fnExisteInternacion(txtIdFicha.Text) Then
            Dim _tabla As DataTable = L_fnMostrarInternacionPorID(id)
            If _tabla.Rows.Count <> 0 Then
                txtIdInt.Text = _tabla.Rows(0).Item("igId")
                dtpFInternacion.Value = _tabla.Rows(0).Item("igFechaIng")
                txtEdadI.Text = _tabla.Rows(0).Item("igEdad")
                txtTelefonoI.Text = _tabla.Rows(0).Item("igTelf")
                txtObservacionesI.Text = _tabla.Rows(0).Item("igMotInter")
                txtRequiere.Text = _tabla.Rows(0).Item("igRequer")
                txtHoraInt.Text = _tabla.Rows(0).Item("igHoraInter")
            End If
        End If
    End Sub

    Public Sub _prRenderizarGrillaImagenes(id As Integer)
        TablaImagenes = L_prMostrarImagenesFichaClinica(id)
        JGListaArchivos.DataSource = TablaImagenes
        JGListaArchivos.RetrieveStructure()
        JGListaArchivos.AlternatingColors = True
        With JGListaArchivos.RootTable.Columns("feId")
            .Width = 150
            .Caption = "Id"
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Visible = False
        End With
        With JGListaArchivos.RootTable.Columns("fe_FbId")
            .Width = 100
            .Caption = "IdFicha"
            .Visible = False
        End With
        With JGListaArchivos.RootTable.Columns("feDesc")
            .Width = 300
            .Visible = True
            .Caption = "Descripción"
        End With
        With JGListaArchivos.RootTable.Columns("feImg")
            .Width = 500
            .Caption = "Imagen"
            .Visible = True
        End With
        With JGListaArchivos.RootTable.Columns("img")
            .Width = 130
            .Visible = False
            .Caption = "Img"
        End With
        With JGListaArchivos.RootTable.Columns("imgelim")
            .Width = 90
            .Visible = False
            .Caption = "Eliminar"
        End With
        With JGListaArchivos.RootTable.Columns("estado")
            .Width = 150
            .Caption = "Estado"
            .Visible = False
        End With
        With JGListaArchivos.RootTable.Columns("feFechaReg")
            .Width = 150
            .Caption = "Fecha"
            .Visible = True
        End With

        With JGListaArchivos
            .DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub

    Private Sub _prLimpiarCirugia()
        'Cirugia
        chbCirugia.Checked = False
        dtpFCirugía.Value = DateTime.Today()
        txtPesoC.ResetText()
        txtEdadC.Clear()
        txtResponsable.Clear()
        txtTelefonoC.Clear()
        txtImportadora.Clear()
        txtClasificacion.Clear()
        txtProcedimiento.Clear()
        txtObservacionC.Clear()
    End Sub

    Private Sub _prLimpiarInternacion()
        'Internacion
        chbInternacion.Checked = False
        dtpFInternacion.Value = DateTime.Today()
        txtEdadI.Clear()
        txtTelefonoI.Clear()
        txtObservacionesI.Clear()
        txtRequiere.Clear()
        txtHoraInt.Clear()
    End Sub

    Private Sub _prLimpiar()
        'Imagenes

        _prRenderizarGrillaFichaClinicaSeguimiento(-1)
        txtDecripcionA.Clear()
        dtpFechaAnexo.Value = DateTime.Today
        'Texbox
        txtIdFicha.Clear()
        cbConsultorio.Value = Nothing
        txtIdVeterinario.Clear()
        txtIdVeterinario.Focus()
        txtExaminacion.Clear()
        txtFCardiaca.Clear()
        txtFRespiratoria.Clear()
        txtHistoria.Clear()
        txtIdFicha.Clear()
        txtIdMascota.Clear()
        txtIdVeterinario.Clear()
        txtMascota.Clear()
        txtNombVeterinario.Clear()
        txtNotas.Clear()
        txtPeso.Clear()
        txtProManejo.Clear()
        txtScoreCorporal.Clear()
        txtScoreCorporal.Clear()
        txtSeguimiento.Clear()
        txtTemperatura.Clear()
        txtTLCapilar.Text = "1"
        txtTRPliegue.Value = 1
        txtValoracion.Clear()
        'DateTime
        dtpFechaFC.Value = DateTime.Today()
        dtpFProxVisita.Value = DateTime.Today()
        'CheckBox
        chbNormalH.Checked = True
        chbEmergenciaH.Checked = False
        chbExcDelgCC.Checked = True
        chbBajoPesoCC.Checked = False
        chbPesoIdealCC.Checked = False
        chbSobrepesoCC.Checked = False
        chbSobExtremoCC.Checked = False
        chbPalidasM.Checked = True
        chbNormalesM.Checked = False
        chbHiperemicasM.Checked = False
        chbNormalD.Checked = True
        chbAnormalD.Checked = False
        chbunoDP.Checked = False
        chbdosDP.Checked = False
        chbtresDP.Checked = False
        chbNormalE.Checked = True
        chbAnormalE.Checked = False
        chbLeveG.Checked = False
        chbModeradaG.Checked = False
        chbSeveraG.Checked = False
        chbLeveS.Checked = False
        chbModeradoS.Checked = False
        chbSeveroS.Checked = False
        chbMasaOral.Checked = False
        chbPorDeshi1.Checked = True
        chbPorDeshi2.Checked = False
        chbPorDeshi3.Checked = False
        chbPorDeshi4.Checked = False
        chbPorDeshi5.Checked = False
        'Ojos
        chbNormalO.Checked = True
        chbAnormalO.Checked = False
        chbDerechoO.Checked = False
        chbIzquierdoO.Checked = False
        'Orejas
        chbNormalOr.Checked = True
        chbAnormalOr.Checked = False
        chbDerechaOr.Checked = False
        chbIzquierdaOr.Checked = False
        'Corazon
        chbNormalC.Checked = True
        chbAnormalC.Checked = False
        chbRuidosCardiacos.Checked = False
        'Pulmones
        chbNormalP.Checked = True
        chbAnormalP.Checked = False
        chbRuidosCardiacos.Checked = False
        'Piel y pelo
        chbNormalPe.Checked = True
        chbAnormalPe.Checked = False
        'Linfonodulos
        chbNormalL.Checked = True
        chbAnormalL.Checked = False
        'Sitema nervioso
        chbNormalSN.Checked = True
        chbAnormalSN.Checked = False
        'Sistema Genitourinario
        chbNormalG.Checked = True
        chbAnormalG.Checked = False
        'Sistema musculo esqueletico Linea 1
        chbNormalSME.Checked = True
        chbAnormalSME.Checked = False
        ' musculo esqueletico Linea 2
        chbmpostizq.Checked = False
        chbmpostder.Checked = False
        chbPelvis.Checked = False
        chbAbdomen.Checked = False
        chbTorax.Checked = False
        'Sistema musculo esqueletico Linea 3
        chbmantizq.Checked = False
        chbmantder.Checked = False
        chbCabeza.Checked = False
        'Abdomen
        chbNormalA.Checked = True
        chbAnormalA.Checked = False
        'Dolor
        chbAgudoD.Checked = False
        chbLeveD.Checked = False
        chbModeradoD.Checked = False
        chbSeveroD.Checked = False
        'Localizado en region linea 1
        chbEstomago.Checked = False
        chbHigado.Checked = False
        chbPancreas.Checked = False
        chbProstata.Checked = False
        chbUtero.Checked = False
        'Localizado en region linea 2
        chbVejiga.Checked = False
        chbIdelgado.Checked = False
        chbIGrueso.Checked = False
        'Alteraciones
        chbExtraño.Checked = False
        chblineal.Checked = False
        chbMabdominal.Checked = False
        chbIntu.Checked = False
        chbAscitis.Checked = False
        'Examenes complementarios
        chbLaboratorio.Checked = False
        chbEcografia.Checked = False
        chbRadiografia.Checked = False
        'Limpiar la las imagenes agregadas
        'Cirugia
        chbCirugia.Checked = False
        dtpFCirugía.Value = DateTime.Today()
        txtPesoC.ResetText()
        txtEdadC.Clear()
        txtResponsable.Clear()
        txtTelefonoC.Clear()
        txtImportadora.Clear()
        txtClasificacion.Clear()
        txtProcedimiento.Clear()
        txtObservacionC.Clear()
        'Internacion
        chbInternacion.Checked = False
        dtpFInternacion.Value = DateTime.Today()
        txtEdadI.Clear()
        txtTelefonoI.Clear()
        txtObservacionesI.Clear()
        txtRequiere.Clear()
        txtHoraInt.Clear()
        'Grilla

        LblPaginacion.Text = "0 de 0    Total: " + totalRegistro.ToString
    End Sub

    Private Sub _prLLenarPorDefecto()
        txtPeso.Text = "0"
        txtExaminacion.Text = "Sin Datos"
        txtHistoria.Text = "Sin Historia"
    End Sub

    Private Sub _prHabilitar()
        'Imagen
        _prRenderizarGrillaFichaClinicaSeguimiento(-1)
        _prAddDetalleSeguimiento()
        btnAlta.Enabled = False
        btnRecibo.Enabled = False
        '  _prCargarImagen(-1)
        btnGuardarArchivo.Enabled = True
        btnExaminar.Enabled = True
        dtpFechaAnexo.Enabled = True
        txtDecripcionA.ReadOnly = False
        'Texbox
        txtIdFicha.ReadOnly = False
        cbConsultorio.Enabled = True
        'txtIdVeterinario.ReadOnly = False
        txtExaminacion.ReadOnly = False
        txtFCardiaca.ReadOnly = False
        txtFRespiratoria.ReadOnly = False
        txtHistoria.ReadOnly = False
        txtIdFicha.ReadOnly = False
        txtIdMascota.ReadOnly = False
        txtMascota.ReadOnly = False
        'TxtNombreUsu.ReadOnly = False
        'txtNombVeterinario.ReadOnly = False
        txtNotas.ReadOnly = False
        txtPeso.ReadOnly = False
        txtProManejo.ReadOnly = False
        txtScoreCorporal.ReadOnly = False
        txtScoreCorporal.ReadOnly = False
        txtSeguimiento.ReadOnly = False
        txtTemperatura.ReadOnly = False
        txtTLCapilar.IsInputReadOnly = False
        txtTRPliegue.IsInputReadOnly = False
        txtValoracion.ReadOnly = False
        'DateTime
        dtpFechaFC.Enabled = True
        dtpFProxVisita.Enabled = True
        'CheckBox
        chbNormalH.Enabled = True
        chbEmergenciaH.Enabled = True
        chbExcDelgCC.Enabled = True
        chbBajoPesoCC.Enabled = True
        chbPesoIdealCC.Enabled = True
        chbSobrepesoCC.Enabled = True
        chbSobExtremoCC.Enabled = True
        chbPalidasM.Enabled = True
        chbNormalesM.Enabled = True
        chbHiperemicasM.Enabled = True
        chbNormalD.Enabled = True
        chbAnormalD.Enabled = True
        chbunoDP.Enabled = True
        chbdosDP.Enabled = True
        chbtresDP.Enabled = True
        chbNormalE.Enabled = True
        chbAnormalE.Enabled = True
        chbLeveG.Enabled = True
        chbModeradaG.Enabled = True
        chbSeveraG.Enabled = True
        chbLeveS.Enabled = True
        chbModeradoS.Enabled = True
        chbSeveroS.Enabled = True
        chbMasaOral.Enabled = True
        chbPorDeshi1.Enabled = True
        chbPorDeshi2.Enabled = True
        chbPorDeshi3.Enabled = True
        chbPorDeshi4.Enabled = True
        chbPorDeshi5.Enabled = True
        'Ojos
        chbNormalO.Enabled = True
        chbAnormalO.Enabled = True
        chbDerechoO.Enabled = True
        chbIzquierdoO.Enabled = True
        'Orejas
        chbNormalOr.Enabled = True
        chbAnormalOr.Enabled = True
        chbDerechaOr.Enabled = True
        chbIzquierdaOr.Enabled = True
        'Corazon
        chbNormalC.Enabled = True
        chbAnormalC.Enabled = True
        chbRuidosCardiacos.Enabled = True
        'Pulmones
        chbNormalP.Enabled = True
        chbAnormalP.Enabled = True
        chbRuidosCardiacos.Enabled = True
        'Piel y pelo
        chbNormalPe.Enabled = True
        chbAnormalPe.Enabled = True
        'Linfonodulos
        chbNormalL.Enabled = True
        chbAnormalL.Enabled = True
        'Sitema nervioso
        chbNormalSN.Enabled = True
        chbAnormalSN.Enabled = True
        'Sistema Genitourinario
        chbNormalG.Enabled = True
        chbAnormalG.Enabled = True
        'Sistema musculo esqueletico Linea 1
        chbNormalSME.Enabled = True
        chbAnormalSME.Enabled = True
        ' musculo esqueletico Linea 2
        chbmpostizq.Enabled = True
        chbmpostder.Enabled = True
        chbPelvis.Enabled = True
        chbAbdomen.Enabled = True
        chbTorax.Enabled = True
        'Sistema musculo esqueletico Linea 3
        chbmantizq.Enabled = True
        chbmantder.Enabled = True
        chbCabeza.Enabled = True
        'Abdomen
        chbNormalA.Enabled = True
        chbAnormalA.Enabled = True
        'Dolor
        chbAgudoD.Enabled = True
        chbLeveD.Enabled = True
        chbModeradoD.Enabled = True
        chbSeveroD.Enabled = True
        'Localizado en region linea 1
        chbEstomago.Enabled = True
        chbHigado.Enabled = True
        chbPancreas.Enabled = True
        chbProstata.Enabled = True
        chbUtero.Enabled = True
        'Localizado en region linea 2
        chbVejiga.Enabled = True
        chbIdelgado.Enabled = True
        chbIGrueso.Enabled = True
        'Alteraciones
        chbExtraño.Enabled = True
        chblineal.Enabled = True
        chbMabdominal.Enabled = True
        chbIntu.Enabled = True
        chbAscitis.Enabled = True
        'Examenes complementarios
        chbLaboratorio.Enabled = True
        chbEcografia.Enabled = True
        chbRadiografia.Enabled = True
        'Limpiar la las imagenes agregadas
        _prCrearCarpetaImagenes()
        _prCrearCarpetaTemporal()
        'Cirugia
        chbCirugia.Enabled = True
        dtpFCirugía.Enabled = True
        txtPesoC.IsInputReadOnly = False
        txtEdadC.ReadOnly = False
        txtResponsable.ReadOnly = False
        txtTelefonoC.ReadOnly = False
        txtImportadora.ReadOnly = False
        txtClasificacion.ReadOnly = False
        txtProcedimiento.ReadOnly = False
        txtObservacionC.ReadOnly = False
        'Internacion
        chbInternacion.Enabled = True
        dtpFInternacion.Enabled = True
        txtEdadI.ReadOnly = False
        txtTelefonoI.ReadOnly = False
        txtObservacionesI.ReadOnly = False
        txtRequiere.ReadOnly = False
        txtHoraInt.ReadOnly = False
    End Sub

    Private Sub _prInhabilitar()
        btnAlta.Enabled = True
        btnRecibo.Enabled = True
        'Imagen
        btnGuardarArchivo.Enabled = False
        btnExaminar.Enabled = False
        dtpFechaAnexo.Enabled = False
        txtDecripcionA.ReadOnly = True
        'Texbox
        txtIdFicha.ReadOnly = True
        cbConsultorio.Enabled = False
        txtIdVeterinario.ReadOnly = True
        txtExaminacion.ReadOnly = True
        txtFCardiaca.ReadOnly = True
        txtFRespiratoria.ReadOnly = True
        txtHistoria.ReadOnly = True
        txtIdFicha.ReadOnly = True
        txtIdMascota.ReadOnly = True
        txtIdVeterinario.ReadOnly = True
        txtMascota.ReadOnly = True
        TxtNombreUsu.ReadOnly = True
        txtNombVeterinario.ReadOnly = True
        txtNotas.ReadOnly = True
        txtPeso.ReadOnly = True
        txtProManejo.ReadOnly = True
        txtScoreCorporal.ReadOnly = True
        txtScoreCorporal.ReadOnly = True
        txtSeguimiento.ReadOnly = True
        txtTemperatura.ReadOnly = True
        txtTLCapilar.IsInputReadOnly = True
        txtTRPliegue.IsInputReadOnly = True
        txtValoracion.ReadOnly = True
        'DateTime
        dtpFechaFC.Enabled = False
        dtpFProxVisita.Enabled = False
        'CheckBox
        chbNormalH.Enabled = False
        chbEmergenciaH.Enabled = False
        chbExcDelgCC.Enabled = False
        chbBajoPesoCC.Enabled = False
        chbPesoIdealCC.Enabled = False
        chbSobrepesoCC.Enabled = False
        chbSobExtremoCC.Enabled = False
        chbPalidasM.Enabled = False
        chbNormalesM.Enabled = False
        chbHiperemicasM.Enabled = False
        chbNormalD.Enabled = False
        chbAnormalD.Enabled = False
        chbRuidosRespP.Enabled = False
        chbunoDP.Enabled = False
        chbdosDP.Enabled = False
        chbtresDP.Enabled = False
        chbNormalE.Enabled = False
        chbAnormalE.Enabled = False
        chbLeveG.Enabled = False
        chbModeradaG.Enabled = False
        chbSeveraG.Enabled = False
        chbLeveS.Enabled = False
        chbModeradoS.Enabled = False
        chbSeveroS.Enabled = False
        chbMasaOral.Enabled = False
        chbPorDeshi1.Enabled = False
        chbPorDeshi2.Enabled = False
        chbPorDeshi3.Enabled = False
        chbPorDeshi4.Enabled = False
        chbPorDeshi5.Enabled = False
        'Ojos
        chbNormalO.Enabled = False
        chbAnormalO.Enabled = False
        chbDerechoO.Enabled = False
        chbIzquierdoO.Enabled = False
        'Orejas
        chbNormalOr.Enabled = False
        chbAnormalOr.Enabled = False
        chbDerechaOr.Enabled = False
        chbIzquierdaOr.Enabled = False
        'Corazon
        chbNormalC.Enabled = False
        chbAnormalC.Enabled = False
        chbRuidosCardiacos.Enabled = False
        'Pulmones
        chbNormalP.Enabled = False
        chbAnormalP.Enabled = False
        chbRuidosCardiacos.Enabled = False
        'Piel y pelo
        chbNormalPe.Enabled = False
        chbAnormalPe.Enabled = False
        'Linfonodulos
        chbNormalL.Enabled = False
        chbAnormalL.Enabled = False
        'Sitema nervioso
        chbNormalSN.Enabled = False
        chbAnormalSN.Enabled = False
        'Sistema Genitourinario
        chbNormalG.Enabled = False
        chbAnormalG.Enabled = False
        'Sistema musculo esqueletico Linea 1
        chbNormalSME.Enabled = False
        chbAnormalSME.Enabled = False
        ' musculo esqueletico Linea 2
        chbmpostizq.Enabled = False
        chbmpostder.Enabled = False
        chbPelvis.Enabled = False
        chbAbdomen.Enabled = False
        chbTorax.Enabled = False
        'Sistema musculo esqueletico Linea 3
        chbmantizq.Enabled = False
        chbmantder.Enabled = False
        chbCabeza.Enabled = False
        'Abdomen
        chbNormalA.Enabled = False
        chbAnormalA.Enabled = False
        'Dolor
        chbAgudoD.Enabled = False
        chbLeveD.Enabled = False
        chbModeradoD.Enabled = False
        chbSeveroD.Enabled = False
        'Localizado en region linea 1
        chbEstomago.Enabled = False
        chbHigado.Enabled = False
        chbPancreas.Enabled = False
        chbProstata.Enabled = False
        chbUtero.Enabled = False
        'Localizado en region linea 2
        chbVejiga.Enabled = False
        chbIdelgado.Enabled = False
        chbIGrueso.Enabled = False
        'Alteraciones
        chbExtraño.Enabled = False
        chblineal.Enabled = False
        chbMabdominal.Enabled = False
        chbIntu.Enabled = False
        chbAscitis.Enabled = False
        'Examenes complementarios
        chbLaboratorio.Enabled = False
        chbEcografia.Enabled = False
        chbRadiografia.Enabled = False
        'Limpiar la las imagenes agregadas
        'Cirugia
        chbCirugia.Enabled = False
        dtpFCirugía.Enabled = False
        txtPesoC.IsInputReadOnly = True  'Por verificar
        txtEdadC.ReadOnly = False
        txtResponsable.ReadOnly = True
        txtTelefonoC.ReadOnly = True
        txtImportadora.ReadOnly = True
        txtClasificacion.ReadOnly = True
        txtProcedimiento.ReadOnly = True
        txtObservacionC.ReadOnly = True
        'Internacion
        chbInternacion.Enabled = False
        dtpFInternacion.Enabled = False
        txtEdadI.ReadOnly = True
        txtTelefonoI.ReadOnly = True
        txtObservacionesI.ReadOnly = True
        txtRequiere.ReadOnly = True
        txtHoraInt.ReadOnly = True
    End Sub

    Public Sub _prFiltrar()
        If _Iniciar = 2 Then _prObtenerPorIdFichaClinica(_fbId)
        If dgvListado.RowCount > 0 Then
            _dgvListado.Rows(IIf(_MPos <= dgvListado.RowCount - 1, _MPos, 0)).Selected = True
        Else
            '_prLimpiar()
        End If
        estaVizualizando = True
    End Sub

    Private Function _fnCopiarImagenRutaDefinida() As String
        'copio la imagen en la carpeta del sistema
        'Dim archivo As New OpenFileDialog
        'archivo.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.ToString
        'archivo.Filter = "Todos los archivos (*.*)|*.*"
        'archivo.Multiselect = True
        'If (archivo.ShowDialog = DialogResult.OK) Then

        'End If
        Dim file As New OpenFileDialog()
        file.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.ToString
        file.Filter = "Todos los archivos (*.*)|*.*"
        file.Multiselect = True
        If file.ShowDialog() = DialogResult.OK Then
            Dim ruta As String = file.FileName
            Dim bytes = ArchivoABytes(ruta)

            If file.CheckFileExists = True Then
                Dim img As New Bitmap(New Bitmap(ruta))
                Dim a As Object = file.GetType.ToString

                Dim da As String = Str(Now.Day).Trim + Str(Now.Month).Trim + Str(Now.Year).Trim + Str(Now.Hour) + Str(Now.Minute) + Str(Now.Second)
                _Nombre = "\Imagen_" + da + ".jpg".Trim
                If (_fnActionNuevo()) Then
                    Dim mstream = New MemoryStream()
                    'a.fe_FbId ,a.feDesc ,A.feImg,Cast(null as image) as img,1 as estado
                    img.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    '.Rows.Add(0, txtIdFicha.Text, txtDecripcionA.Text, _Nombre, mstream.ToArray(), 0)
                    mstream1 = mstream
                    mstream.Dispose()

                Else
                    Dim mstream = New MemoryStream()
                    img.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    'a.ienumi , a.ienumiti4, a.ieimg, Cast(null As image) As img, 1 as estado
                    'TablaImagenes.Rows.Add(0, txtIdFicha.Text, txtDecripcionA.Text, _Nombre, mstream.ToArray(), 0)
                    mstream1 = mstream
                    mstream.Dispose()

                End If
                img.Save(RutaTemporal + _Nombre, System.Drawing.Imaging.ImageFormat.Jpeg)
            End If
            Return _Nombre
        End If
        Return "default.jpg"
    End Function

    Private Function ArchivoABytes(ByVal pth As String) As Byte()
        Try
            Dim fs As New FileStream(pth, FileMode.Open)
            fs.Position = 0
            Dim bytes(0 To fs.Length - 1) As Byte
            fs.Read(bytes, 0, fs.Length)
            fs.Close()
            '            File.Delete(pth)
            Return bytes
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    Public Function ObtenCampoPorNombre(ByVal aNombreCampo As String, sqlDataRow As DataRow) As Object
        Try
            ObtenCampoPorNombre = Nothing
            If sqlDataRow Is Nothing Then
                Exit Function
            End If
            If IsDBNull(sqlDataRow.Item(aNombreCampo)) Then
                Exit Function
            End If
            ObtenCampoPorNombre = sqlDataRow.Item(aNombreCampo)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Function _prPasarImagenTabla() As String
        'copio la imagen en la carpeta del sistema
        If txtDecripcionA.Text <> String.Empty Then
            Dim Bin As New MemoryStream
            Dim img As New Bitmap(My.Resources.delete, 20, 20)
            img.Save(Bin, Imaging.ImageFormat.Png)
            If (_fnActionNuevo()) Then
                TablaImagenes.Rows.Add(0, 0, txtDecripcionA.Text, _Nombre, mstream1.ToArray(), Bin.GetBuffer, 0, dtpFechaAnexo.Value.ToString("yyyy/MM/dd"))
                mstream1.Dispose()
                JGListaArchivos.RootTable.Columns("imgelim").Visible = True
            Else
                TablaImagenes.Rows.Add(0, _fnObtnerNumero(txtIdFicha.Text), txtDecripcionA.Text, _Nombre, mstream1.ToArray(), Bin.GetBuffer, 0, dtpFechaAnexo.Value.ToString("yyyy/MM/dd"))
                mstream1.Dispose()
                JGListaArchivos.RootTable.Columns("imgelim").Visible = True
            End If
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "Debe agregar una descripcion".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)
        End If
        Return "default.jpg"
    End Function

    Public Function _fnActionNuevo() As Boolean
        Return txtIdFicha.Text = String.Empty
    End Function

    Private Sub _prCrearCarpetaTemporal()
        If System.IO.Directory.Exists(RutaTemporal) = False Then
            System.IO.Directory.CreateDirectory(RutaTemporal)
        Else
            Try
                My.Computer.FileSystem.DeleteDirectory(RutaTemporal, FileIO.DeleteDirectoryOption.DeleteAllContents)
                My.Computer.FileSystem.CreateDirectory(RutaTemporal)
            Catch
            End Try
        End If
    End Sub

    Private Sub _prCrearCarpetaImagenes()
        Dim rutaDestino As String = RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino\"

        If System.IO.Directory.Exists(RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino\") = False Then
            If System.IO.Directory.Exists(RutaGlobal + "\Imagenes") = False Then
                System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes")
                If System.IO.Directory.Exists(RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino")
                End If
            Else
                If System.IO.Directory.Exists(RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino")

                End If
            End If
        End If
    End Sub

    Private Sub _prCrearCarpetaImagenes(carpetaFinal As String)
        Dim rutaDestino As String = RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino\" + carpetaFinal + "\"

        If System.IO.Directory.Exists(RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino\" + carpetaFinal) = False Then
            If System.IO.Directory.Exists(RutaGlobal + "\Imagenes") = False Then
                System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes")
                If System.IO.Directory.Exists(RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino")
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino\" + carpetaFinal + "\")
                End If
            Else
                If System.IO.Directory.Exists(RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino")
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino\" + carpetaFinal + "\")
                Else
                    If System.IO.Directory.Exists(RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino\" + carpetaFinal) = False Then
                        System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino\" + carpetaFinal + "\")
                    End If

                End If
            End If
        End If
    End Sub

    Public Sub _prGuardarImagenes(_ruta As String)
        For i As Integer = 0 To TablaImagenes.Rows.Count - 1 Step 1
            Dim estado As Integer = TablaImagenes.Rows(i).Item("estado")
            If (estado = 0) Then
                Dim bm As Bitmap = Nothing
                Dim by As Byte() = TablaImagenes.Rows(i).Item("img")
                Dim ms As New MemoryStream(by)
                bm = New Bitmap(ms)
                Try
                    bm.Save(_ruta + TablaImagenes.Rows(i).Item("feImg"), System.Drawing.Imaging.ImageFormat.Jpeg)
                Catch
                End Try
            End If
            If (estado = -1) Then
                Try
                    Application.DoEvents()
                    TablaImagenes.Rows(i).Item("img") = Nothing
                    If (File.Exists(_ruta + TablaImagenes.Rows(i).Item("feImg"))) Then
                        My.Computer.FileSystem.DeleteFile(_ruta + TablaImagenes.Rows(i).Item("feImg"))
                    End If
                Catch
                End Try
            End If
        Next
    End Sub

    Private Sub _prAddDetalleSeguimiento()
        Try
            CType(JGFechasSeg.DataSource, DataTable).Rows.Add(0, 0, 2, "", "", "", DateTime.Now, DateTime.Now.ToShortTimeString(), TxtNombreUsu.Text)
            JGFechasSeg.Row = IIf(JGFechasSeg.RowCount = 0, 0, JGFechasSeg.RowCount - 1)
            JGFechasSeg.Select()
            txtSeguimiento.Text = JGFechasSeg.GetValue("fjSeguimiento")
            txtValoracion.Text = JGFechasSeg.GetValue("fjValoracion")
            txtProManejo.Text = JGFechasSeg.GetValue("fjProtocoloM")
        Catch
        End Try
    End Sub

    Private Sub _prEditDetalleSeguimiento()
        JGFechasSeg.Row = IIf(JGFechasSeg.RowCount = 0, 0, JGFechasSeg.RowCount - 1)
        If JGFechasSeg.GetValue("Estado") = 2 Then
            CType(JGFechasSeg.DataSource, DataTable).Rows(JGFechasSeg.RowCount - 1).Item("fjSeguimiento") = txtSeguimiento.Text
            JGFechasSeg.SetValue("fjSeguimiento", txtSeguimiento.Text)
            CType(JGFechasSeg.DataSource, DataTable).Rows(JGFechasSeg.RowCount - 1).Item("fjValoracion") = txtValoracion.Text
            JGFechasSeg.SetValue("fjValoracion", txtValoracion.Text)
            CType(JGFechasSeg.DataSource, DataTable).Rows(JGFechasSeg.RowCount - 1).Item("fjProtocoloM") = txtProManejo.Text
            JGFechasSeg.SetValue("fjProtocoloM", txtProManejo.Text)
        End If
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click

    End Sub

    Public Sub _prLimpiarBanderas(bandera As Boolean)
        banderaP2 = bandera
        banderaP3 = bandera
        banderaP4 = bandera
        banderaP5 = bandera
        banderaP6 = bandera
    End Sub

    Public Function _fnAccesible()
        Return btnGrabar.Enabled = True
    End Function

    Public Sub _prEliminarFila()
        If (JGListaArchivos.Row >= 0) Then
            If (JGListaArchivos.RowCount >= 1) Then
                Dim estado As Integer = JGListaArchivos.GetValue("estado")
                Dim pos As Integer = -1
                Dim lin As Integer = JGListaArchivos.GetValue("feId")
                _fnObtenerFilaDetalle(pos, lin)
                If (estado = 0) Then
                    CType(JGListaArchivos.DataSource, DataTable).Rows(pos).Item("estado") = -2

                End If
                If (estado = 1) Then
                    CType(JGListaArchivos.DataSource, DataTable).Rows(pos).Item("estado") = -1
                End If
                JGListaArchivos.RootTable.ApplyFilter(New Janus.Windows.GridEX.GridEXFilterCondition(JGListaArchivos.RootTable.Columns("estado"), Janus.Windows.GridEX.ConditionOperator.GreaterThanOrEqualTo, 0))

            End If
        End If
    End Sub

    Public Sub _fnObtenerFilaDetalle(ByRef pos As Integer, id As Integer)
        For i As Integer = 0 To CType(JGListaArchivos.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim _Id As Integer = CType(JGListaArchivos.DataSource, DataTable).Rows(i).Item("feId")
            If (_Id = id) Then
                pos = i
                Return
            End If
        Next
    End Sub

    Public Sub _prCargarIconELiminar()
        Try
            For i As Integer = 0 To CType(JGListaArchivos.DataSource, DataTable).Rows.Count - 1 Step 1
                Dim Bin As New MemoryStream
                Dim img As New Bitmap(My.Resources.delete, 20, 20)
                img.Save(Bin, Imaging.ImageFormat.Png)
                CType(JGListaArchivos.DataSource, DataTable).Rows(i).Item("imgelim") = Bin.GetBuffer
                JGListaArchivos.RootTable.Columns("imgelim").Visible = True
            Next
        Catch
        End Try
    End Sub

    Public Function _fnObtnerNumero(text As String) As Integer
        Dim valor As Integer
        If String.IsNullOrEmpty(text.Trim()) Then
            valor = -1
        Else
            valor = Convert.ToInt32(text)
        End If
        Return valor
    End Function
#End Region

#Region "Metodos privados overridable"
    Public Overrides Function _PMOGrabarRegistro() As Boolean
        Dim tFichaClinicaDetalle As DataTable = L_fnMostrarFichaClinicaVacia()
        Dim bandera As Boolean = False
        _prObtenerDetalle(tFichaClinicaDetalle)
        'Ingresa ala grilla el seguimiento
        _prEditDetalleSeguimiento()

        'Guarda la Ficha Clinica
        Dim res As Boolean = L_fnGrabarFichaClinica(txtIdFicha.Text, txtIdMascota.Text, txtIdVeterinario.Text, dtpFechaFC.Value.ToString("yyyy/MM/dd"),
                                                    dtpFProxVisita.Value.ToString("yyyy/MM/dd"), _HoraInicial, DateTime.Now.ToShortTimeString(), txtHistoria.Text, txtExaminacion.Text,
                                                    txtTemperatura.Text, txtPeso.Text, txtFCardiaca.Text, txtFRespiratoria.Text, txtScoreCorporal.Text,
                                                    txtTLCapilar.Text, txtTRPliegue.Text, txtNotas.Text, txtValoracion.Text, txtProManejo.Text, tFichaClinicaDetalle, _faId, TablaImagenes, CType(JGFechasSeg.DataSource, DataTable), cbConsultorio.Value)
        If res Then
            'Guarda la Cirugia
            If chbCirugia.Checked Then
                Dim idCirugia As Integer
                Dim res2 As Boolean = L_fnGrabarCirugia(idCirugia, txtIdFicha.Text, dtpFCirugía.Value.ToString("yyyy/MM/dd"), IIf(txtPesoC.Text = String.Empty, 0, txtPesoC.Text), txtEdadC.Text, txtResponsable.Text,
                                                        txtTelefonoC.Text, txtImportadora.Text, txtClasificacion.Text, txtProcedimiento.Text, txtObservacionC.Text)
            End If
            'Guarda la internacion
            If chbInternacion.Checked Then
                Dim idInternacion As Integer
                Dim res2 As Boolean = L_fnGrabarInternacion(idInternacion, txtIdFicha.Text, dtpFInternacion.Value.ToString("yyyy/MM/dd"),
                                                            txtEdadI.Text, txtTelefonoI.Text, txtObservacionesI.Text, txtRequiere.Text, txtHoraInt.Text)
            End If
            _prCrearCarpetaImagenes("FichaClinica_" + txtIdFicha.Text.Trim)
            _prGuardarImagenes(RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino\" + "FichaClinica_" + txtIdFicha.Text.Trim + "\")
            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Id de la ficha clinica ".ToUpper + txtIdFicha.Text + " Grabado con Exito.".ToUpper,
                                      img, 3000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )
            _prHabilitarMenu(2)
            _prInhabilitar()
            _prFiltrar()
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "La ficha clinica no pudo ser insertado".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)
        End If
        Return res
    End Function

    Public Overrides Function _PMOModificarRegistro() As Boolean
        Dim tFichaClinicaDetalle As DataTable = L_fnMostrarFichaClinicaVacia()
        Dim bandera As Boolean = False
        _prObtenerDetalle(tFichaClinicaDetalle)
        'Ingresa ala grilla el seguimiento
        _prEditDetalleSeguimiento()
        Dim res As Boolean = L_fnModificarFichaClinica(txtIdFicha.Text, txtIdMascota.Text, txtIdVeterinario.Text, dtpFechaFC.Value.ToString("yyyy/MM/dd"),
                                                    dtpFProxVisita.Value.ToString("yyyy/MM/dd"), _HoraInicial, DateTime.Now.TimeOfDay.ToString(), txtHistoria.Text, txtExaminacion.Text,
                                                    txtTemperatura.Text, txtPeso.Text, txtFCardiaca.Text, txtFRespiratoria.Text, txtScoreCorporal.Text,
                                                    txtTLCapilar.Text, txtTRPliegue.Text, txtNotas.Text, txtValoracion.Text, txtProManejo.Text, tFichaClinicaDetalle, _faId, TablaImagenes, CType(JGFechasSeg.DataSource, DataTable))
        If res Then
            _prCrearCarpetaImagenes("FichaClinica_" + txtIdFicha.Text.Trim)
            _prGuardarImagenes(RutaGlobal + "\Imagenes\Imagenes FichaClinicaDino\" + "FichaClinica_" + txtIdFicha.Text.Trim + "\")
            'Cirugia
            If chbCirugia.Checked Then
                'Dim idCirugia As Integer
                'If L_fnExisteCirugia(txtIdFicha.Text) Then
                '    'Guarda Cirugia
                '    Dim res2 As Boolean = L_fnGrabarCirugia(idCirugia, txtIdFicha.Text, dtpFCirugía.Value.ToString("yyyy/MM/dd"), txtPesoC.Text, txtEdadC.Text, txtResponsable.Text,
                '                                            txtTelefonoC.Text, txtImportadora.Text, txtClasificacion.Text, txtProcedimiento.Text, txtObservacionC.Text)
                'Else
                '    'Modifica Cirugia
                '    Dim res2 As Boolean = L_fnMoficicarCirugia(txtIdCir.Text, txtIdFicha.Text, dtpFCirugía.Value.ToString("yyyy/MM/dd"), txtPesoC.Text, txtEdadC.Text, txtResponsable.Text,
                '                                            txtTelefonoC.Text, txtImportadora.Text, txtClasificacion.Text, txtProcedimiento.Text, txtObservacionC.Text)
                'End If

                'Guarda Cirugia
                Dim idCirugia As Integer
                Dim res2 As Boolean = L_fnGrabarCirugia(idCirugia, txtIdFicha.Text, dtpFCirugía.Value.ToString("yyyy/MM/dd"), IIf(txtPesoC.Text = String.Empty, 0, txtPesoC.Text), txtEdadC.Text, txtResponsable.Text,
                                                            txtTelefonoC.Text, txtImportadora.Text, txtClasificacion.Text, txtProcedimiento.Text, txtObservacionC.Text)
            Else
                'Modifica Cirugia
                If txtIdCir.Text <> String.Empty Then
                    Dim res2 As Boolean = L_fnMoficicarCirugia(txtIdCir.Text, txtIdFicha.Text, dtpFCirugía.Value.ToString("yyyy/MM/dd"), IIf(txtPesoC.Text = String.Empty, 0, txtPesoC.Text), txtEdadC.Text, txtResponsable.Text,
                                                            txtTelefonoC.Text, txtImportadora.Text, txtClasificacion.Text, txtProcedimiento.Text, txtObservacionC.Text)
                End If

            End If
            'Internacion
            If chbInternacion.Checked Then
                Dim idInternacion As Integer
                'If L_fnExisteInternacion(txtIdFicha.Text) Then
                '    Dim res2 As Boolean = L_fnGrabarInternacion(idInternacion, txtIdFicha.Text, dtpFInternacion.Value.ToString("yyyy/MM/dd"),
                '                        txtEdadI.Text, txtTelefonoI.Text, txtObservacionesI.Text, txtRequiere.Text, txtHoraInt.Text)
                'Else
                '    'Modifica Internación
                '    Dim res2 As Boolean = L_fnModificarInternacion(idInternacion, txtIdFicha.Text, dtpFInternacion.Value.ToString("yyyy/MM/dd"),
                '                                            txtEdadI.Text, txtTelefonoI.Text, txtObservacionesI.Text, txtRequiere.Text, txtHoraInt.Text)
                'End If

                Dim res2 As Boolean = L_fnGrabarInternacion(idInternacion, txtIdFicha.Text, dtpFInternacion.Value.ToString("yyyy/MM/dd"),
                                       txtEdadI.Text, txtTelefonoI.Text, txtObservacionesI.Text, txtRequiere.Text, txtHoraInt.Text)
            Else
                'Modifica Cirugia
                If txtIdInt.Text <> String.Empty Then
                    Dim res2 As Boolean = L_fnModificarInternacion(txtIdInt.Text, txtIdFicha.Text, dtpFInternacion.Value.ToString("yyyy/MM/dd"),
                                                            txtEdadI.Text, txtTelefonoI.Text, txtObservacionesI.Text, txtRequiere.Text, txtHoraInt.Text)
                End If
            End If


            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Id de la ficha clinica ".ToUpper + txtIdFicha.Text + " Modificado con Exito.".ToUpper,
                                      img, 3000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )
            _prInhabilitar()
            _prFiltrar()
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "La ficha clinica no pudo ser modificada".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)
        End If
        Return res
    End Function

    Public Overrides Sub _PMONuevo()
        stcFichaClinica.SelectedTabIndex = 0
        estaVizualizando = False
        _prLimpiarBanderas(True)
        _prLimpiar()
        _prLLenarPorDefecto() '--------------------ELIMINAR
        _prHabilitar()
    End Sub

    Public Overrides Sub _PMOModificar()
        stcFichaClinica.SelectedTabIndex = 0
        estaVizualizando = False
        _prLimpiarBanderas(False)
        _prHabilitar()

        If _Iniciar = 3 Then
            _prMostrarRegistroTodo()
        End If
        'Deshabilitar campos que no deberian poder modificarse
        cbConsultorio.ReadOnly = True
        txtIdVeterinario.Enabled = False
        dtpFechaFC.Enabled = False
        _prCargarIconELiminar()
    End Sub

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
            If L_fnExisteEliminarCirugia(txtIdFicha.Text) Then
                'Elimina la ficha clinica
                Dim res As Boolean = L_fnEliminarFichaClinica(txtIdFicha.Text, mensajeError)
                If res Then
                    'Elimina Cirugia
                    L_fnEliminarCirugia(txtIdFicha.Text, mensajeError)
                    'Elimina internacion
                    L_fnEliminarInternacion(txtIdFicha.Text, mensajeError)
                    Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
                    ToastNotification.Show(Me, "Código de la ficha clinica ".ToUpper + txtIdFicha.Text + " eliminado con Exito.".ToUpper,
                                              img, 2000,
                                              eToastGlowColor.Green,
                                              eToastPosition.TopCenter)
                    _MPos = 0
                    _prFiltrar()
                Else
                    Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                    ToastNotification.Show(Me, mensajeError, img, 3000, eToastGlowColor.Red, eToastPosition.TopCenter)
                End If
            Else
                Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                ToastNotification.Show(Me, "No se puede eliminar el registro de Cirugia por que esta siendo usado por el siguiente programa: RECIBO DE CIRUGIA", img, 3000, eToastGlowColor.Red, eToastPosition.TopCenter)
            End If
        End If
    End Sub

    Public Overrides Function _PMOValidarCampos() As Boolean
        Dim _ok As Boolean = True
        MEP.Clear()
        If txtIdVeterinario.Text = String.Empty Then
            txtIdVeterinario.BackColor = Color.Red
            MEP.SetError(txtIdVeterinario, "ingrese un veterinario!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Seleccione un veterinario para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        Else
            txtIdVeterinario.BackColor = Color.White
            MEP.SetError(txtIdVeterinario, "")
        End If
        If dtpFechaFC.Value > dtpFProxVisita.Value Then
            MEP.SetError(txtHistoria, "Ingrese una fecha de proxima consulta!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Ingrese una fecha de próxima consulta clinica para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        End If
        If txtHistoria.Text = String.Empty Then
            txtHistoria.BackColor = Color.Red
            MEP.SetError(txtHistoria, "Ingrese una historia!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Ingrese una historia clinica para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        Else
            txtHistoria.BackColor = Color.White
            MEP.SetError(txtHistoria, "")
        End If
        If txtExaminacion.Text = String.Empty Then
            txtExaminacion.BackColor = Color.Red
            MEP.SetError(txtExaminacion, "Ingrese una examinación!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Ingrese una examinación clinica para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        Else
            txtExaminacion.BackColor = Color.White
            MEP.SetError(txtExaminacion, "")
        End If

        If txtPeso.Text = String.Empty Then
            txtPeso.BackColor = Color.Red
            MEP.SetError(txtPeso, "Ingrese un peso!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Ingrese un peso de la mascota para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        Else
            txtPeso.BackColor = Color.White
            MEP.SetError(txtPeso, "")
        End If
        If txtSeguimiento.Text = String.Empty And txtIdFicha.Text = String.Empty Then
            txtSeguimiento.BackColor = Color.Red
            MEP.SetError(txtSeguimiento, "Ingrese un seguimiento!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Ingrese un seguimiento clinico para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        Else
            txtSeguimiento.BackColor = Color.White
            MEP.SetError(txtSeguimiento, "")
        End If
        If chbCirugia.Checked = True Then
            If txtPesoC.Text = String.Empty Then
                txtPesoC.BackColor = Color.Red
                MEP.SetError(txtPesoC, "Ingrese un peso!".ToUpper)
                _ok = False
                Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                ToastNotification.Show(Me, "Ingrese un peso de la mascota para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
            Else
                txtPesoC.BackColor = Color.White
                MEP.SetError(txtPesoC, "")
            End If
            If txtEdadC.Text = String.Empty Then
                txtEdadC.BackColor = Color.Red
                MEP.SetError(txtEdadC, "Ingrese edad!".ToUpper)
                _ok = False
                Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                ToastNotification.Show(Me, "Ingrese edad de la mascota para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
            Else
                txtEdadC.BackColor = Color.White
                MEP.SetError(txtEdadC, "")
            End If
            If txtResponsable.Text = String.Empty Then
                txtResponsable.BackColor = Color.Red
                MEP.SetError(txtResponsable, "Ingrese responsable!".ToUpper)
                _ok = False
                Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                ToastNotification.Show(Me, "Ingrese responsable de la mascota para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
            Else
                txtResponsable.BackColor = Color.White
                MEP.SetError(txtResponsable, "")
            End If
            If txtTelefonoC.Text = String.Empty Then
                txtTelefonoC.BackColor = Color.Red
                MEP.SetError(txtTelefonoC, "Ingrese teléfono!".ToUpper)
                _ok = False
                Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                ToastNotification.Show(Me, "Ingrese teléfono para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
            Else
                txtTelefonoC.BackColor = Color.White
                MEP.SetError(txtTelefonoC, "")
            End If
            If txtClasificacion.Text = String.Empty Then
                txtClasificacion.BackColor = Color.Red
                MEP.SetError(txtClasificacion, "Ingrese clasificación ASA!".ToUpper)
                _ok = False
                Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                ToastNotification.Show(Me, "Ingrese clasificación ASA para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
            Else
                txtClasificacion.BackColor = Color.White
                MEP.SetError(txtClasificacion, "")
            End If
            If txtProcedimiento.Text = String.Empty Then
                txtProcedimiento.BackColor = Color.Red
                MEP.SetError(txtProcedimiento, "Ingrese procedimiento!".ToUpper)
                _ok = False
                Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                ToastNotification.Show(Me, "Ingrese procedimiento para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
            Else
                txtProcedimiento.BackColor = Color.White
                MEP.SetError(txtProcedimiento, "")
            End If
        End If
        If chbInternacion.Checked = True Then
            If txtEdadI.Text = String.Empty Then
                txtEdadI.BackColor = Color.Red
                MEP.SetError(txtEdadI, "Ingrese edad!".ToUpper)
                _ok = False
                Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                ToastNotification.Show(Me, "Ingrese edad para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
            Else
                txtEdadI.BackColor = Color.White
                MEP.SetError(txtEdadI, "")
            End If

            If txtTelefonoI.Text = String.Empty Then
                txtTelefonoI.BackColor = Color.Red
                MEP.SetError(txtTelefonoI, "Ingrese teléfono!".ToUpper)
                _ok = False
                Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                ToastNotification.Show(Me, "Ingrese teléfono para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
            Else
                txtTelefonoI.BackColor = Color.White
                MEP.SetError(txtTelefonoI, "")
            End If
            If txtObservacionesI.Text = String.Empty Then
                txtObservacionesI.BackColor = Color.Red
                MEP.SetError(txtObservacionesI, "Ingrese motivo de internación!".ToUpper)
                _ok = False
                Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                ToastNotification.Show(Me, "Ingrese motivo de internación para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
            Else
                txtObservacionesI.BackColor = Color.White
                MEP.SetError(txtObservacionesI, "")
            End If
            If txtRequiere.Text = String.Empty Then
                txtRequiere.BackColor = Color.Red
                MEP.SetError(txtRequiere, "Ingrese se requiere!".ToUpper)
                _ok = False
                Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                ToastNotification.Show(Me, "Ingrese se requiere para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
            Else
                txtRequiere.BackColor = Color.White
                MEP.SetError(txtRequiere, "")
            End If
            If txtHoraInt.Text = String.Empty Then
                txtHoraInt.BackColor = Color.Red
                MEP.SetError(txtHoraInt, "Ingrese hora de internación!".ToUpper)
                _ok = False
                Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                ToastNotification.Show(Me, "Ingrese hora de internación para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
            Else
                txtHoraInt.BackColor = Color.White
                MEP.SetError(txtHoraInt, "")
            End If

        End If


        MHighlighterFocus.UpdateHighlights()
        Return _ok
    End Function

    Public Overrides Sub _PMOSalir()
        If _Iniciar = 3 Then
            _prInhabilitar()
            _prFiltrar()
        Else
            Me.Close()
        End If
    End Sub
#End Region
End Class