Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX
Imports System.IO
Public Class F1_Fic_ReciboCirugia
#Region "VARIABLES"
    Public _IdInternacion, _MPos, _IdPaciente As Integer
    Private _Limpiar As Boolean
    Dim Modificado As Boolean = False
    Dim _codeBar As Integer = 1
#End Region
#Region "EVENTOS"
    Private Sub F1_Fic_ReciboInt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
        superTabControl1.SelectedTabIndex = 0
    End Sub
    'DESHABILITA LA GRILLA
    Private Sub JGDetalleReciboCir_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGDetalleReciboCir.EditingCell
        Try
            If (_fnAccesible()) Then
                'Habilitar solo las columnas de cantidad, detalle
                If (e.Column.Index = JGDetalleReciboCir.RootTable.Columns("rpPrec").Index Or
                    e.Column.Index = JGDetalleReciboCir.RootTable.Columns("rpCant").Index) Then
                    'Or e.Column.Index = JGDetalleReciboCir.RootTable.Columns("rpDesc").Index 
                    If JGDetalleReciboCir.GetValue("rpEst2").ToString = 0 Then
                        e.Cancel = False
                    Else
                        e.Cancel = True
                    End If
                Else
                    e.Cancel = True
                End If
            Else
                e.Cancel = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace, "Consulte con el administrador del sistema")
        End Try
    End Sub
    Public Function _fnAccesible()
        Return dtpFechaRC.Enabled = True
    End Function
    'PRIMERO
    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        If JGBusqRecibosC.RowCount > 0 Then
            _MPos = 0
            _prMostrarRecibo(_MPos)
        End If
    End Sub
    'ANTERIOR
    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If _MPos > 0 And JGBusqRecibosC.RowCount > 0 Then
            _MPos = _MPos - 1
            _prMostrarRecibo(_MPos)
        End If
    End Sub
    'SIGUIENTE
    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If _MPos < JGBusqRecibosC.RowCount - 1 Then
            _MPos = _MPos + 1
            _prMostrarRecibo(_MPos)
        End If
    End Sub
    'ULTIMO
    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        If JGBusqRecibosC.RowCount > 0 Then
            _MPos = JGBusqRecibosC.RowCount - 1
            _prMostrarRecibo(_MPos)
        End If
    End Sub
    'SELECCIONAR GRILLA
    Private Sub JGBusqRecibosC_SelectionChanged(sender As Object, e As EventArgs) Handles JGBusqRecibosC.SelectionChanged
        If JGBusqRecibosC.Row >= 0 And JGBusqRecibosC.RowCount >= 0 Then
            '_MPos = JGBusqRecibosC.Row
            _prMostrarRecibo(JGBusqRecibosC.Row)
        End If
    End Sub
    Private Sub JGDetalleReciboCir_KeyDown(sender As Object, e As KeyEventArgs) Handles JGDetalleReciboCir.KeyDown
        If (Not _fnAccesible()) Then
            Return
        End If
        '        If (e.KeyData = Keys.Enter) Then
        '            Dim f, c As Integer
        '            c = JGDetalleReciboCir.Col
        '            f = JGDetalleReciboCir.Row
        '            If (JGDetalleReciboCir.Col = JGDetalleReciboCir.RootTable.Columns("rpCant").Index) Then
        '                If (JGDetalleReciboCir.GetValue("Servicio") <> String.Empty) Then
        '                    _prAddDetalleRecibo()
        '                    ' _HabilitarProductos()
        '                Else
        '                    ToastNotification.Show(Me, "Seleccione un servicio Por Favor", My.Resources.WARNING, 3000, eToastGlowColor.Red, eToastPosition.TopCenter)
        '                End If

        '            End If
        '            If (JGDetalleReciboCir.Col = JGDetalleReciboCir.RootTable.Columns("Servicio").Index) Then
        '                If (JGDetalleReciboCir.GetValue("Servicio") <> String.Empty) Then
        '                    _prAddDetalleRecibo()
        '                    '_HabilitarProductos()
        '                Else
        '                    ToastNotification.Show(Me, "Seleccione un Servicio Por Favor", My.Resources.WARNING, 3000, eToastGlowColor.Red, eToastPosition.TopCenter)
        '                End If

        '            End If
        'salirIf:
        '        End If
        '        If (e.KeyData = Keys.Control + Keys.Enter And JGDetalleReciboCir.Row >= 0 And
        '            JGDetalleReciboCir.Col = JGDetalleReciboCir.RootTable.Columns("Servicio").Index) Then
        '            Dim indexfil As Integer = JGDetalleReciboCir.Row
        '            Dim indexcol As Integer = JGDetalleReciboCir.Col
        '            '_HabilitarProductos()

        '        End If
        If (e.KeyData = Keys.Escape And JGDetalleReciboCir.Row >= 0) Then
            _prEliminarFila()
        End If
        If (e.KeyData = Keys.Control + Keys.S And JGDetalleReciboCir.Row >= 0) Then
            txtDescripcion.Select()
        End If
    End Sub
    Private Sub swInternacion_ValueChanged(sender As Object, e As EventArgs) Handles swInternacion.ValueChanged
        If (_fnAccesible()) Then
            If (swInternacion.Value = True) Then
                txtIdReciboI.BackColor = Color.White
                txtIdReciboI.ReadOnly = True
                txtIdReciboI.Enabled = True
                txtIdReciboI.Focus()
            Else
                txtIdReciboI.BackColor = Color.LightGray
                txtIdReciboI.ReadOnly = True
                txtIdReciboI.Enabled = False
            End If
        End If
    End Sub
    Private Sub JGDetalleReciboCir_CellEdited(sender As Object, e As ColumnActionEventArgs) Handles JGDetalleReciboCir.CellEdited
        Try
            If (e.Column.Index = JGDetalleReciboCir.RootTable.Columns("rpCant").Index) Then
                If (Not IsNumeric(JGDetalleReciboCir.GetValue("rpCant")) Or JGDetalleReciboCir.GetValue("rpCant").ToString = String.Empty Or IsDBNull(JGDetalleReciboCir.GetValue("rpCant"))) Then
                    JGDetalleReciboCir.SetValue("rpCant", 1)
                    JGDetalleReciboCir.SetValue("rpTotal", JGDetalleReciboCir.GetValue("rpPrec"))
                Else
                    If (JGDetalleReciboCir.GetValue("rpCant") > 0) Then
                        Dim cant As Integer = JGDetalleReciboCir.GetValue("rpCant")
                        'Dim stock As Integer = JGDetalleReciboCir.GetValue("stock"
                        Dim stock As Integer = 1000
                        If (cant > stock) Then
                            Dim lin As Integer = JGDetalleReciboCir.GetValue("rpId")
                            Dim pos As Integer = -1
                            _fnObtenerFilaDetalle(pos, lin)
                            CType(JGDetalleReciboCir.DataSource, DataTable).Rows(pos).Item("rpCant") = 0
                            CType(JGDetalleReciboCir.DataSource, DataTable).Rows(pos).Item("rpTotal") = CType(JGDetalleReciboCir.DataSource, DataTable).Rows(pos).Item("rpPrec")
                            CType(JGDetalleReciboCir.DataSource, DataTable).Rows(pos).Item("rpTotal2") = JGDetalleReciboCir.GetValue("tbpcos") * 1
                            CType(JGDetalleReciboCir.DataSource, DataTable).Rows(pos).Item("tbtotdesc") = 0
                            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                            ToastNotification.Show(Me, "La cantidad de la venta no debe ser mayor al del stock" & vbCrLf &
                            "Stock=" + Str(stock).ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
                            JGDetalleReciboCir.SetValue("rpCant", 0)
                            JGDetalleReciboCir.SetValue("rpTotal", JGDetalleReciboCir.GetValue("rpPrec"))
                            JGDetalleReciboCir.SetValue("rpTotal2", JGDetalleReciboCir.GetValue("tbpcos") * 1)
                            JGDetalleReciboCir.SetValue("tbtotdesc", 0)
                            _prCalcularPrecioTotal()
                        Else
                            If (cant = stock) Then
                                'JGDetalleReciboCir.SelectedFormatStyle.ForeColor = Color.Blue
                                'JGDetalleReciboCir.CurrentRow.Cells.Item(e.Column).FormatStyle = New GridEXFormatStyle
                                'JGDetalleReciboCir.CurrentRow.Cells(e.Column).FormatStyle.BackColor = Color.Pink
                                'JGDetalleReciboCir.CurrentRow.Cells.Item(e.Column).FormatStyle.BackColor = Color.DodgerBlue
                                'JGDetalleReciboCir.CurrentRow.Cells.Item(e.Column).FormatStyle.ForeColor = Color.White
                                'JGDetalleReciboCir.CurrentRow.Cells.Item(e.Column).FormatStyle.FontBold = TriState.True
                            End If
                        End If

                    Else

                        JGDetalleReciboCir.SetValue("rpCant", 1)
                        JGDetalleReciboCir.SetValue("rpTotal", JGDetalleReciboCir.GetValue("rpPrec"))
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace, "Consulte con el administrador del sistema")
        End Try
    End Sub

    Private Sub JGDetalleReciboCir_MouseClick(sender As Object, e As MouseEventArgs) Handles JGDetalleReciboCir.MouseClick
        Try
            If (JGDetalleReciboCir.RowCount >= 2) Then
                If (JGDetalleReciboCir.CurrentColumn.Index = JGDetalleReciboCir.RootTable.Columns("img").Index) Then
                    _prEliminarFila()
                End If
            End If
            If (Not _fnAccesible()) Then
                Return
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Consulte con el administrador del sistema")
        End Try
    End Sub
    Private Sub JGDetalleReciboCir_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles JGDetalleReciboCir.CellValueChanged
        Try
            If (e.Column.Index = JGDetalleReciboCir.RootTable.Columns("rpCant").Index) Or (e.Column.Index = JGDetalleReciboCir.RootTable.Columns("rpPrec").Index) Then
                If (Not IsNumeric(JGDetalleReciboCir.GetValue("rpCant")) Or JGDetalleReciboCir.GetValue("rpCant").ToString = String.Empty) Then
                    Dim lin As Integer = JGDetalleReciboCir.GetValue("rpId")
                    Dim pos As Integer = -1
                    _fnObtenerFilaDetalle(pos, lin)
                    CType(JGDetalleReciboCir.DataSource, DataTable).Rows(pos).Item("rpCant") = 1
                    CType(JGDetalleReciboCir.DataSource, DataTable).Rows(pos).Item("rpTotal") = CType(JGDetalleReciboCir.DataSource, DataTable).Rows(pos).Item("rpPrec")
                Else
                    If (JGDetalleReciboCir.GetValue("rpCant") > 0) Then
                        Dim rowIndex As Integer = JGDetalleReciboCir.Row
                        Dim lin As Integer = JGDetalleReciboCir.GetValue("rpId")
                        Dim pos As Integer = -1
                        _fnObtenerFilaDetalle(pos, lin)
                        P_PonerTotal(rowIndex)
                    Else
                        Dim lin As Integer = JGDetalleReciboCir.GetValue("rpId")
                        Dim pos As Integer = -1
                        _fnObtenerFilaDetalle(pos, lin)
                        CType(JGDetalleReciboCir.DataSource, DataTable).Rows(pos).Item("rpCant") = 1
                        CType(JGDetalleReciboCir.DataSource, DataTable).Rows(pos).Item("rpTotal") = CType(JGDetalleReciboCir.DataSource, DataTable).Rows(pos).Item("rpPrec")
                        _prCalcularPrecioTotal()
                    End If
                End If
            End If
            If txtIdReciboI.Text <> String.Empty Then
                If (e.Column.Index = JGDetalleReciboCir.RootTable.Columns("rpDesc").Index) Then
                    Dim lin As Integer = JGDetalleReciboCir.GetValue("rpId")
                    Dim pos As Integer = -1
                    _fnObtenerFilaDetalle(pos, lin)
                    Dim _tabla As DataTable = L_fnMostrarReciboIntDetalle(txtIdReciboI.Text)
                    If _tabla.Rows.Count > 0 Then
                        Dim _fila As DataRow() = _tabla.Select("rpId =" + lin.ToString())
                        If _fila.Count > 0 Then
                            Dim estado As Integer = CType(JGDetalleReciboCir.DataSource, DataTable).Rows(pos).Item("estado")
                            If (estado = 1) Then
                                CType(JGDetalleReciboCir.DataSource, DataTable).Rows(pos).Item("estado") = 2
                            End If
                        End If
                    End If

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Consulte con el administrador del sistema")
        End Try
    End Sub
    Private Sub btnAgregarC_Click(sender As Object, e As EventArgs) Handles btnAgregarC.Click
        _prAddDetalleRecibo(0)
        _prCalcularPrecioTotal()
        _prLimpiarText()
        JGDetalleReciboCir.Select()
    End Sub
    Private Sub txtCirugia_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCirugia.KeyDown
        Try

            If e.KeyData = Keys.Control + Keys.Enter Then
                If (_fnAccesible()) Then
                    Dim dt As DataTable
                    dt = L_fnMostrarFichaClinicaCirugiaRecibo()
                    If dt.Rows.Count > 0 Then
                        Dim listEstCeldas As New List(Of Modelo.Celda)
                        listEstCeldas.Add(New Modelo.Celda("cfId", True, "ID CIRUGIA", 100))
                        listEstCeldas.Add(New Modelo.Celda("fbId", True, "ID F. CLINICA", 100))
                        listEstCeldas.Add(New Modelo.Celda("cfFechaAten", True, "FECHA", 100, "dd/MM/yyyy"))
                        listEstCeldas.Add(New Modelo.Celda("Cliente", True, "CLIENTE".ToUpper, 190))
                        listEstCeldas.Add(New Modelo.Celda("pbId", False, "IDPACIENTE".ToUpper, 140))
                        listEstCeldas.Add(New Modelo.Celda("pbnomb", True, "PACIENTE".ToUpper, 140))
                        listEstCeldas.Add(New Modelo.Celda("cfProc", True, "PROCEDIMIENTO".ToUpper, 170, "0.00"))
                        listEstCeldas.Add(New Modelo.Celda("cfObser", True, "OBSERVACION".ToUpper, 170, "0.00"))
                        Dim ef = New Efecto
                        ef.tipo = 3
                        ef.dt = dt
                        ef.SeleclCol = 2
                        ef.listEstCeldas = listEstCeldas
                        ef.alto = 80
                        ef.ancho = 240
                        ef.Context = "Seleccione una Cirugía".ToUpper
                        ef.ShowDialog()
                        Dim bandera As Boolean = False
                        bandera = ef.band
                        If (bandera = True) Then
                            Dim Row As Janus.Windows.GridEX.GridEXRow = ef.Row
                            txtCirugia.Text = Row.Cells("cfId").Value
                            _IdPaciente = Row.Cells("pbId").Value
                            txtPacienteC.Text = Row.Cells("pbnomb").Value
                            txtPropietarioC.Text = Row.Cells("Cliente").Value
                            txtDescripcion.Select()
                            swInternacion.Enabled = True
                        End If
                    Else
                        ToastNotification.Show(Me, "NO EXISTE FICHAS DE CIRUGIAS PARA ENLAZAR A UN RECIBO..!!!",
                                               My.Resources.WARNING, 2000,
                                               eToastGlowColor.Blue,
                                               eToastPosition.TopCenter)
                    End If


                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Consulte con el administrador del sistema")
        End Try
    End Sub
#End Region

#Region "METODOS PRIVADOS"
    Private Sub _prIniciarTodo()
        '_MNuevo = True
        _prCargarRecibo()
        '_prHabilitar()
        '_prLimpiar()
        '_prHabilitarMenu(1)
        _prInhabilitar()
    End Sub

    Private Sub _prAddDetalleRecibo(Estado2 As Integer)
        Dim Bin As New MemoryStream
        Dim img As New Bitmap(My.Resources.delete, 28, 28)
        img.Save(Bin, Imaging.ImageFormat.Png)
        ''--rpId, rn_roId, rpEst, rpFechaReg, rnObser, rpDesc, rpCant, rpPrec, rpTotal, rpFecha, rpHora, rpUsuario
        CType(JGDetalleReciboCir.DataSource, DataTable).Rows.Add(_fnSiguienteNumi() + 1, 0, 0, DateTime.Now, txtDescripcion.Text,
                                                                 1, IIf(diPrecio.Value = 0 Or diPrecio.Text = "", 0, diPrecio.Text),
                                                                 IIf(diPrecio.Value = 0 Or diPrecio.Text = "", 0, diPrecio.Text),
                                                                 DateTime.Now, DateTime.Now.ToShortTimeString(), L_Usuario, 0, Bin.GetBuffer, Estado2)
    End Sub
    Public Function _fnSiguienteNumi()
        Dim dt As DataTable = CType(JGDetalleReciboCir.DataSource, DataTable)
        Dim rows() As DataRow = dt.Select("rpId=MAX(rpId)")
        If (rows.Count > 0) Then
            Return rows(rows.Count - 1).Item("rpId")
        End If
        Return 1
    End Function
    Private Sub _prHabilitarMenu(tipo As Integer)
        If tipo = 1 Then
            btnNuevo.Enabled = False
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
            btnGrabar.Enabled = True
            PanelNavegacion.Enabled = False
            superTabItem2.Enabled = False

        End If
    End Sub
    Private Sub _prLimpiarText()
        txtDescripcion.Clear()
        diPrecio.ResetText()
    End Sub
    Private Sub _prMostrarRecibo(_POS As Integer)
        If JGBusqRecibosC.RowCount <> 0 Then
            JGBusqRecibosC.Row = _POS
            With JGBusqRecibosC
                txtIdReciboC.Text = .GetValue("roId")
                txtCirugia.Text = .GetValue("ro_cfId")
                txtIdReciboI.Text = .GetValue("ro_rmId")
                _IdPaciente = .GetValue("pbid")
                dtpFechaRC.Value = .GetValue("roFechaIng")
                txtPropietarioC.Text = .GetValue("Cliente")
                txtPacienteC.Text = .GetValue("pbnomb")
                txtTotalRC.Text = .GetValue("roTotal")
                swInternacion.Value = IIf(txtIdReciboI.Text = 0, False, True)
                'Cargar el detalle
                _prCargarReciboDetalle(IIf(txtIdReciboC.Text = String.Empty, 0, txtIdReciboC.Text))
                LblPaginacion.Text = Str(_POS + 1) + "/" + JGBusqRecibosC.RowCount.ToString
            End With
        End If

    End Sub
    Private Sub _prCargarRecibo()
        Dim _tabla As DataTable = L_fnMostrarReciboCir()
        JGBusqRecibosC.DataSource = _tabla
        JGBusqRecibosC.RetrieveStructure()
        JGBusqRecibosC.AlternatingColors = True
        '--roId, ro_cfId, ro_PbId, roEst, roFechaIng,Cliente,pbnomb, rmTratam, roTotal, roFecha, roHora, rmusuario
        With JGBusqRecibosC.RootTable.Columns("roId")
            .Width = 100
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "IdRecibo"
            .Visible = True
        End With
        With JGBusqRecibosC.RootTable.Columns("ro_cfId")
            .Width = 70
            .Caption = "IdCirugia"
            .Visible = False
        End With
        With JGBusqRecibosC.RootTable.Columns("ro_PbId")
            .Width = 70
            .Caption = "IdPaciente"
            .Visible = False
        End With
        With JGBusqRecibosC.RootTable.Columns("ro_rmId")
            .Width = 70
            .Caption = "IdRecInternacion"
            .Visible = False
        End With
        With JGBusqRecibosC.RootTable.Columns("roEst")
            .Width = 100
            .Caption = "roEst"
            .Visible = False
        End With
        With JGBusqRecibosC.RootTable.Columns("roFechaIng")
            .Width = 120
            .Caption = "Fecha"
            .Visible = True
        End With
        With JGBusqRecibosC.RootTable.Columns("Cliente")
            .Width = 270
            .Caption = "Cliente"
            .Visible = True
        End With
        With JGBusqRecibosC.RootTable.Columns("pbid")
            .Width = 180
            .Caption = "IdPaciente"
            .Visible = False
        End With
        With JGBusqRecibosC.RootTable.Columns("pbnomb")
            .Width = 200
            .Caption = "Paciente"
            .Visible = True
        End With
        With JGBusqRecibosC.RootTable.Columns("roTotal")
            .Width = 120
            .Caption = "Total"
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .FormatString = "0.00"
            .Visible = True
        End With
        With JGBusqRecibosC.RootTable.Columns("roFecha")
            .Width = 150
            .Caption = "Fecha"
            .Visible = False
        End With
        With JGBusqRecibosC.RootTable.Columns("roHora")
            .Width = 150
            .Caption = "Hora"
            .Visible = False
        End With
        With JGBusqRecibosC.RootTable.Columns("roUsuario")
            .Width = 150
            .Caption = "Usuario"
            .Visible = False
        End With
        With JGBusqRecibosC.RootTable.Columns("Venta")
            .Width = 100
            .Caption = "Venta"
            .Visible = True
        End With
        With JGBusqRecibosC
            .DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007

        End With
        If (_tabla.Rows.Count <= 0) Then
            _prCargarReciboDetalle(-1)
        End If
    End Sub
    Private Sub _prCargarReciboDetalle(rpId As String)
        Dim _tabla As DataTable = L_fnMostrarReciboCirDetalle(rpId)
        JGDetalleReciboCir.DataSource = _tabla
        JGDetalleReciboCir.RetrieveStructure()
        JGDetalleReciboCir.AlternatingColors = True
        '--rpId, rn_roId, rpEst, rpFechaReg, rpDesc, rpCant, rpPrec, rpTotal, rpFecha, rpHora, rpUsuario
        With JGDetalleReciboCir.RootTable.Columns("rpId")
            .Width = 70
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "IdDetalle"
            .Visible = False
        End With
        With JGDetalleReciboCir.RootTable.Columns("rp_roId")
            .Width = 70
            .Caption = "IdRecibo"
            .Visible = False
        End With
        With JGDetalleReciboCir.RootTable.Columns("rpEst")
            .Width = 100
            .Caption = "Estado"
            .Visible = False
        End With
        With JGDetalleReciboCir.RootTable.Columns("rpFechaReg")
            .Width = 100
            .Caption = "Fecha"
            .Visible = True
        End With
        With JGDetalleReciboCir.RootTable.Columns("rpDesc")
            .Width = 290
            .Caption = "Descripción"
            .Visible = True
        End With
        With JGDetalleReciboCir.RootTable.Columns("rpCant")
            .Width = 130
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Caption = "Cantidad"
            .Visible = True
        End With
        With JGDetalleReciboCir.RootTable.Columns("rpPrec")
            .Width = 130
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Caption = "Precio"
            .FormatString = "0.00"
            .Visible = True
        End With
        With JGDetalleReciboCir.RootTable.Columns("rpTotal")
            .Width = 130
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Caption = "Total"
            .FormatString = "0.00"
            .Visible = True
        End With
        With JGDetalleReciboCir.RootTable.Columns("Img")
            .Width = 100
            .CellStyle.ImageHorizontalAlignment = ImageHorizontalAlignment.Center
            .Caption = "Eliminar"
            .Visible = True
        End With
        With JGDetalleReciboCir.RootTable.Columns("Estado")
            .Width = 90
            .CellStyle.ImageHorizontalAlignment = ImageHorizontalAlignment.Center
            .Caption = "estado"
            .Visible = False
        End With
        With JGDetalleReciboCir.RootTable.Columns("rpFecha")
            .Width = 150
            .Caption = "Fecha"
            .Visible = False
        End With
        With JGDetalleReciboCir.RootTable.Columns("rpHora")
            .Width = 150
            .Caption = "Hora"
            .Visible = False
        End With
        With JGDetalleReciboCir.RootTable.Columns("rpUsuario")
            .Width = 150
            .Caption = "Usuario"
            .Visible = False
        End With
        With JGDetalleReciboCir.RootTable.Columns("rpEst2")
            .Width = 100
            .Caption = "Estado2"
            .Visible = False
        End With
        With JGDetalleReciboCir
            '.DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            '.FilterMode = FilterMode.Automatic
            '.FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub
    Private Sub _prInhabilitar()
        txtIdReciboI.ReadOnly = True
        txtPropietarioC.ReadOnly = True
        txtPacienteC.ReadOnly = True
        txtDescripcion.ReadOnly = True
        diPrecio.IsInputReadOnly = True
        txtTotalRC.IsInputReadOnly = True
        txtCirugia.ReadOnly = True
        _Limpiar = False
        dtpFechaRC.Enabled = False
        btnAgregarC.Enabled = False
        swInternacion.Enabled = False

    End Sub
    Private Sub _prHabilitar()
        txtIdReciboI.ReadOnly = False
        txtCirugia.ReadOnly = False
        txtPropietarioC.ReadOnly = False
        txtPacienteC.ReadOnly = False
        txtDescripcion.ReadOnly = False
        diPrecio.IsInputReadOnly = False
        txtTotalRC.IsInputReadOnly = False
        btnAgregarC.Enabled = True
        dtpFechaRC.Enabled = True
        swInternacion.Enabled = True
        swInternacion.Value = False
    End Sub
    Private Sub _prLimpiar()
        txtCirugia.Clear()
        txtIdReciboC.Clear()
        txtIdReciboI.Clear()
        txtPropietarioC.Clear()
        txtPacienteC.Clear()
        txtDescripcion.Clear()
        txtTotalRC.ResetText()
        diPrecio.ResetText()
        dtpFechaRC.Value = DateTime.Today()
        _prCargarReciboDetalle(-1)
        txtCirugia.Focus()
        'swInternacion.Value = False
        '_prAddDetalleRecibo()
    End Sub

    Public Sub _prFiltrar(tipo As Integer)
        _prCargarRecibo()
        If JGBusqRecibosC.RowCount > 0 Then
            _MPos = 0
            _prMostrarRecibo(IIf(tipo = 1, _MPos, JGBusqRecibosC.RowCount - 1))
        Else
            _prLimpiar()
            LblPaginacion.Text = "0/0"
        End If
    End Sub
    Public Sub _prCalcularPrecioTotal()
        txtTotalRC.Text = JGDetalleReciboCir.GetTotal(JGDetalleReciboCir.RootTable.Columns("rpTotal"), AggregateFunction.Sum)
    End Sub
    Public Sub _prEliminarFila()
        Dim estado, estado2 As Integer
        'Elimina el todo el detalle de recibo de Internacion
        If (JGDetalleReciboCir.Row >= 0) Then
            If (JGDetalleReciboCir.RowCount >= 2) Then
                estado2 = JGDetalleReciboCir.GetValue("rpEst2") 'Verifica si pertenece a detalle de internacion
                If estado2 = 1 Then
                    Dim info As New TaskDialogInfo("RECIBO".ToUpper, eTaskDialogIcon.Delete, "RECIBO".ToUpper, "¿Esta seguro de eliminar el detalle de Recibo de Internación?".ToUpper, eTaskDialogButton.Yes Or eTaskDialogButton.Cancel, eTaskDialogBackgroundColor.Blue)
                    Dim result As eTaskDialogResult = TaskDialog.Show(info)
                    If result = eTaskDialogResult.Yes Then
                        If (estado2 = 1) Then
                            For i As Integer = 0 To CType(JGDetalleReciboCir.DataSource, DataTable).Rows.Count - 1 Step 1
                                estado = CType(JGDetalleReciboCir.DataSource, DataTable).Rows(i).Item("Estado")
                                estado2 = CType(JGDetalleReciboCir.DataSource, DataTable).Rows(i).Item("rpEst2")
                                If estado2 = 1 Then
                                    If estado = 0 Then
                                        CType(JGDetalleReciboCir.DataSource, DataTable).Rows(i).Item("estado") = -2
                                    End If
                                    If estado = 1 Then
                                        CType(JGDetalleReciboCir.DataSource, DataTable).Rows(i).Item("estado") = -1
                                    End If
                                End If
                            Next
                            txtIdReciboI.Clear()
                            swInternacion.Value = False
                        End If
                    Else
                        Return
                    End If
                Else
                    'Elimina normal
                    estado = JGDetalleReciboCir.GetValue("estado")
                    Dim pos As Integer = -1
                    Dim lin As Integer = JGDetalleReciboCir.GetValue("rpId")
                    _fnObtenerFilaDetalle(pos, lin)
                    If (estado = 0) Then
                        CType(JGDetalleReciboCir.DataSource, DataTable).Rows(pos).Item("estado") = -2

                    End If
                    If (estado = 1) Then
                        CType(JGDetalleReciboCir.DataSource, DataTable).Rows(pos).Item("estado") = -1
                    End If
                End If
                JGDetalleReciboCir.RootTable.ApplyFilter(New Janus.Windows.GridEX.GridEXFilterCondition(JGDetalleReciboCir.RootTable.Columns("estado"), Janus.Windows.GridEX.ConditionOperator.GreaterThanOrEqualTo, 0))
                _prCalcularPrecioTotal()
                JGDetalleReciboCir.Select()
                JGDetalleReciboCir.Col = 5
                If JGDetalleReciboCir.RowCount = 0 Then
                    _prAddDetalleRecibo(0)
                End If
                JGDetalleReciboCir.Row = JGDetalleReciboCir.RowCount - 1
            End If
        End If
    End Sub
    Public Sub _fnObtenerFilaDetalle(ByRef pos As Integer, id As Integer)
        For i As Integer = 0 To CType(JGDetalleReciboCir.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim _Id As Integer = CType(JGDetalleReciboCir.DataSource, DataTable).Rows(i).Item("rpId")
            If (_Id = id) Then
                pos = i
                Return
            End If
        Next
    End Sub
    Private Sub _DesHabilitarProductos()
        JGDetalleReciboCir.Select()
        JGDetalleReciboCir.Col = 5
        JGDetalleReciboCir.Row = JGDetalleReciboCir.RowCount - 1
        JGDetalleReciboCir.SetValue("rpCant", 1)
        ' JGDetalleReciboCir.SetValue("rpCant", DBNull.Value)
    End Sub
    Public Sub P_PonerTotal(rowIndex As Integer)
        If (rowIndex < JGDetalleReciboCir.RowCount) Then
            Dim lin As Integer = JGDetalleReciboCir.GetValue("rpId")
            Dim pos As Integer = -1
            _fnObtenerFilaDetalle(pos, lin)
            Dim cant As Double = JGDetalleReciboCir.GetValue("rpCant")
            Dim uni As Double = JGDetalleReciboCir.GetValue("rpPrec")
            Dim dt As DataTable = CType(JGDetalleReciboCir.DataSource, DataTable)
            If (pos >= 0) Then
                Dim TotalUnitario As Double = cant * uni
                CType(JGDetalleReciboCir.DataSource, DataTable).Rows(pos).Item("rpTotal") = TotalUnitario
                JGDetalleReciboCir.SetValue("rpTotal", TotalUnitario)
                Dim estado As Integer = CType(JGDetalleReciboCir.DataSource, DataTable).Rows(pos).Item("estado")
                If (estado = 1) Then
                    CType(JGDetalleReciboCir.DataSource, DataTable).Rows(pos).Item("estado") = 2
                End If
            End If
            _prCalcularPrecioTotal()
        End If
    End Sub
    'Private Sub _prImprimir()
    '    Try
    '        Dim dt As DataTable = L_fnMostrarReciboReporte(txtIdReciboI.Text)
    '        If (dt.Rows.Count > 0) Then
    '            If Not IsNothing(P_Global.Visualizador) Then
    '                P_Global.Visualizador.Close()
    '            End If
    '            P_Global.Visualizador = New Visualizador
    '            Dim objrep As New R_Recibo
    '            objrep.SetDataSource(dt)
    '            P_Global.Visualizador.CrGeneral.ReportSource = objrep 'Comentar
    '            P_Global.Visualizador.WindowState = FormWindowState.Maximized
    '            P_Global.Visualizador.Show() 'Comentar
    '            P_Global.Visualizador.BringToFront() 'ComentarS
    '        Else
    '            ToastNotification.Show(Me, "NO HAY DATOS PARA LOS PARAMETROS SELECCIONADOS..!!!",
    '                                       My.Resources.WARNING, 2000,
    '                                       eToastGlowColor.Blue,
    '                                       eToastPosition.BottomLeft)
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub
#End Region

#Region "METODOS PRIVADOS OVERRRIDABLES"
    Public Overrides Function _PMOGrabarRegistro() As Boolean
        Dim res As Boolean = L_fnGrabarReciboCir(txtIdReciboC.Text, txtCirugia.Text, _IdPaciente, IIf(txtIdReciboI.Text = String.Empty, 0, txtIdReciboI.Text), dtpFechaRC.Value, txtTotalRC.Text, CType(JGDetalleReciboCir.DataSource, DataTable))
        If res Then
            Modificado = False
            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Id del recibo ".ToUpper + txtIdReciboI.Text + " Grabado con Exito.".ToUpper,
                                      img, 3000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )
            txtCirugia.Focus()
            '_prInhabilitar()
            _prFiltrar(2)
            _prLimpiar()
            _Limpiar = True
            btnGrabar.Enabled = False
            'Dim info As New TaskDialogInfo("RECIBO".ToUpper, eTaskDialogIcon.Delete, "RECIBO".ToUpper, "¿Desea imprimir el recibo?".ToUpper, eTaskDialogButton.Yes Or eTaskDialogButton.Cancel, eTaskDialogBackgroundColor.Blue)
            'Dim result As eTaskDialogResult = TaskDialog.Show(info)
            'If result = eTaskDialogResult.Yes Then
            '    '_prImprimir()
            'End If
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "El recibo no pudo ser insertado".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)
        End If
        Return res
    End Function
    ''*****MODDIFICA EL REGISTRO*****''
    Public Overrides Function _PMOModificarRegistro() As Boolean
        Dim res As Boolean = L_fnModificarReciboCir(txtIdReciboC.Text, txtCirugia.Text, _IdPaciente, IIf(txtIdReciboI.Text = String.Empty, 0, txtIdReciboI.Text), dtpFechaRC.Value, txtTotalRC.Text, CType(JGDetalleReciboCir.DataSource, DataTable))
        If res Then
            Modificado = False
            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Id del recibo ".ToUpper + txtIdReciboI.Text + " Modificado con Exito.".ToUpper,
                                      img, 3000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )
            _prInhabilitar()
            _prFiltrar(2)
            'Dim info As New TaskDialogInfo("RECIBO".ToUpper, eTaskDialogIcon.Delete, "RECIBO".ToUpper, "¿Desea imprimir el recibo?".ToUpper, eTaskDialogButton.Yes Or eTaskDialogButton.Cancel, eTaskDialogBackgroundColor.Blue)
            'Dim result As eTaskDialogResult = TaskDialog.Show(info)
            'If result = eTaskDialogResult.Yes Then
            '    '_prImprimir()
            'End If
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "El recibo no pudo ser modificado".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)

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
            Dim res As Boolean = L_fnEliminarReciboCir(txtIdReciboC.Text, mensajeError, IIf(txtIdReciboI.Text = String.Empty, 0, txtIdReciboI.Text))
            If res Then
                Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)

                ToastNotification.Show(Me, "Código del recibo ".ToUpper + txtIdReciboC.Text + " eliminado con Exito.".ToUpper,
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
        If JGDetalleReciboCir.RowCount = 0 Then
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Ingrese un servicio para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        End If

        If txtPropietarioC.Text = String.Empty Then
            txtPropietarioC.BackColor = Color.Red
            MEP.SetError(txtPropietarioC, "Ingrese un propietario!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Ingrese un propietario para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        Else
            txtPropietarioC.BackColor = Color.White
            MEP.SetError(txtPropietarioC, "")
        End If

        If txtPacienteC.Text = String.Empty Then
            txtPacienteC.BackColor = Color.Red
            MEP.SetError(txtPacienteC, "Ingrese un Paciente!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Ingrese paciente para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        Else
            txtPacienteC.BackColor = Color.White
            MEP.SetError(txtPacienteC, "")
        End If
        MHighlighterFocus.UpdateHighlights()
        Return _ok
    End Function
    Public Overrides Sub _PMONuevo()
        _prLimpiar()
        _prHabilitar()
        swInternacion.Enabled = False
        txtCirugia.Focus()
    End Sub

    Private Sub txtIdReciboI_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdReciboI.KeyDown
        If (_fnAccesible()) Then
            If e.KeyData = Keys.Control + Keys.Enter Then
                If txtCirugia.Text = "0" Or txtCirugia.Text = String.Empty Then
                    Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                    ToastNotification.Show(Me, "Debe seleccionar una cirugia".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)
                    txtCirugia.Select()
                    Return
                End If
                If _IdPaciente = 0 Then
                    Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                    ToastNotification.Show(Me, "Debe selecciona una cirugia".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)
                    txtCirugia.Select()
                    Return
                End If
                Dim dt As DataTable
                'rmId, rm_IhID, rm_PbId, rmEst, rmFechaIng,Cliente,pbnomb, rmTratam, rmTotal, rmFecha, rmHora, rmusuario
                dt = L_fnMostrarReciboIntXPaciente(1, _IdPaciente) 'Muestra los recibos, excepto los que ya tiene una venta
                If dt.Rows.Count > 0 Then
                    Dim listEstCeldas As New List(Of Modelo.Celda)
                    listEstCeldas.Add(New Modelo.Celda("rmId", True, "ID", 100))
                    listEstCeldas.Add(New Modelo.Celda("rm_IhID", False, "ID S. INTERNACION", 100))
                    listEstCeldas.Add(New Modelo.Celda("rm_PbId", False, "ID PACIENTE", 100))
                    listEstCeldas.Add(New Modelo.Celda("rmEst", False, "ESTADO", 100))
                    listEstCeldas.Add(New Modelo.Celda("rmFechaIng", True, "FECHA", 100, "dd/MM/yyyy"))
                    listEstCeldas.Add(New Modelo.Celda("Cliente", True, "CLIENTE".ToUpper, 140))
                    listEstCeldas.Add(New Modelo.Celda("pbnomb", True, "PACIENTE".ToUpper, 140))
                    listEstCeldas.Add(New Modelo.Celda("rmTratam", True, "TRATAMIENTO".ToUpper, 140))
                    listEstCeldas.Add(New Modelo.Celda("rmTotal", True, "TOTAL".ToUpper, 140))
                    listEstCeldas.Add(New Modelo.Celda("rmFecha", False, "FECGA".ToUpper, 140))
                    listEstCeldas.Add(New Modelo.Celda("rmHora", False, "HORA".ToUpper, 140))
                    listEstCeldas.Add(New Modelo.Celda("rmusuario", False, "USUARIO".ToUpper, 150))
                    Dim ef = New Efecto
                    ef.tipo = 3
                    ef.dt = dt
                    ef.SeleclCol = 2
                    ef.listEstCeldas = listEstCeldas
                    ef.alto = 50
                    ef.ancho = 350
                    ef.Context = "Seleccione una Recibo de Internación".ToUpper
                    ef.ShowDialog()
                    Dim bandera As Boolean = False
                    bandera = ef.band
                    If (bandera = True) Then
                        Dim Row As Janus.Windows.GridEX.GridEXRow = ef.Row
                        ' _CodEmpleado = Row.Cells("paven").Value
                        txtIdReciboI.Text = Row.Cells("rmId").Value
                        _prCargarProductoDeRecibo(Row.Cells("rmId").Value)
                        JGDetalleReciboCir.Select()
                        JGDetalleReciboCir.Col = 5
                        JGDetalleReciboCir.Row = JGDetalleReciboCir.RowCount - 1

                    End If
                End If
            End If
        End If
    End Sub
    Sub _prCargarProductoDeRecibo(IdReciboInt As Integer)
        Dim dt As DataTable = L_fnMostrarReciboIntDetalle(IdReciboInt)
        Dim Suma As Decimal = 0
        If (dt.Rows.Count > 0) Then
            'CType(JGDetalleReciboCir.DataSource, DataTable).Rows.Clear()
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim numiServicio As Integer = dt.Rows(i).Item("rnId")
                Dim nameServicio As String = dt.Rows(i).Item("rnDesc")
                Dim lote As String = ""
                Dim FechaVenc As Date = Now.Date
                Dim cant As Double = dt.Rows(i).Item("rnCant")
                Dim iccven As Double = 0
                _prAddDetalleRecibo(1) ' Estado2 = 3 pertenece un detalle
                '--rnId, rn_rmId, rnEst, rnFechaReg, rnObser, rnDesc, rnCant, rnPrec, rnTotal, rnFecha, rnHora, rnUsuario
                ''--rpId, rn_roId, rpEst, rpFechaReg, rpDesc, rpCant, rpPrec, rpTotal, rpFecha, rpHora, rpUsuario
                JGDetalleReciboCir.Row = JGDetalleReciboCir.RowCount - 1
                JGDetalleReciboCir.SetValue("rpId", numiServicio)
                JGDetalleReciboCir.SetValue("rpDesc", nameServicio)
                'JGDetalleReciboCir.SetValue("unidad", "UN")
                JGDetalleReciboCir.SetValue("rpCant", dt.Rows(i).Item("rnCant"))
                'JGDetalleReciboCir.SetValue("vbUMin", 1rnPrec
                JGDetalleReciboCir.SetValue("rpPrec", dt.Rows(i).Item("rnPrec"))
                JGDetalleReciboCir.SetValue("rpTotal", dt.Rows(i).Item("rnTotal"))
                'JGDetalleReciboCir.SetValue("vbDesc", "0.00")
                'JGDetalleReciboCir.SetValue("vbPorc", "0.00")
                ''JGDetalleReciboCir.SetValue("vbPTotal", dt.Rows(i).Item("rlTotal"))
                'JGDetalleReciboCir.SetValue("vbTotDesc", dt.Rows(i).Item("rlTotal"))
                'JGDetalleReciboCir.SetValue("vbLote", lote)
                'JGDetalleReciboCir.SetValue("vbFechaVenc", FechaVenc)
                'JGDetalleReciboCir.SetValue("stock", iccven)
                'JGDetalleReciboCir.SetValue("vbUsuario", L_Usuario)

                'Suma = dt.Rows(i).Item("rnTotal") + Suma
            Next
            txtTotalRC.Text = JGDetalleReciboCir.GetTotal(JGDetalleReciboCir.RootTable.Columns("rpTotal"), AggregateFunction.Sum)
            txtTotalRC.Text = txtTotalRC.Text + dt.Rows(dt.Rows.Count - 1).Item("rnTotal")
            '_prCalcularPrecioTotal()
            'JGDetalleReciboCir.Select()
            'txtTotalRC.Value = Suma
        End If
    End Sub

    Private Sub F1_Fic_ReciboCirugia_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        _prCambiarColorPlomoOscuro(Presentacion.Principal.btnReciboCirugia)
    End Sub

    Private Sub JGBusqRecibosC_DoubleClick(sender As Object, e As EventArgs) Handles JGBusqRecibosC.DoubleClick
        superTabControl1.SelectedTabIndex = 0
    End Sub

    Public Overrides Sub _PMOModificar()
        _prHabilitar()
    End Sub

    Public Overrides Sub _PMOSalir()
        _prInhabilitar()
        _prFiltrar(1)
    End Sub
#End Region
End Class