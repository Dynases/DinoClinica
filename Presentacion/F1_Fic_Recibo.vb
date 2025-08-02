Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX
Imports System.IO
Public Class F1_Fic_Recibo
#Region "VARIABLES"
    Public _IdFicha, _MPos, _IdPaciente As Integer
    Private _Limpiar As Boolean
    Dim Modificado As Boolean = False
    Dim _codeBar As Integer = 1
#End Region
#Region "Eventos"
    'INICIO
    Private Sub F1_Fic_Recibo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
        superTabControl1.SelectedTabIndex = 0
        'JGDetalleRecibo.Select()
    End Sub
    'DESHABILITA LA GRILLA
    Private Sub JGDetalleRecibo_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGDetalleRecibo.EditingCell
        If (_fnAccesible()) Then
            'Habilitar solo las columnas de cantidad, detalle
            If e.Column.Index = JGDetalleRecibo.RootTable.Columns("rlCant").Index Then
                '(Or e.Column.Index = JGDetalleRecibo.RootTable.Columns("Servicio").Index 
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        Else
            e.Cancel = True
        End If

    End Sub
    Public Function _fnAccesible()
        Return dtpFrecibo.Enabled = True
    End Function
    'PRIMERO
    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        If JGBusqRecibos.RowCount > 0 Then
            _MPos = 0
            _prMostrarRecibo(_MPos)
        End If
    End Sub
    'ANTERIOR
    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If _MPos > 0 And JGBusqRecibos.RowCount > 0 Then
            _MPos = _MPos - 1
            _prMostrarRecibo(_MPos)
        End If
    End Sub
    'SIGUIENTE
    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If _MPos < JGBusqRecibos.RowCount - 1 Then
            _MPos = _MPos + 1
            _prMostrarRecibo(_MPos)
        End If
    End Sub
    'ULTIMO
    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        If JGBusqRecibos.RowCount > 0 Then
            _MPos = JGBusqRecibos.RowCount - 1
            _prMostrarRecibo(_MPos)
        End If
    End Sub
    'SELECCIONAR GRILLA
    Private Sub JGBusqRecibos_SelectionChanged(sender As Object, e As EventArgs) Handles JGBusqRecibos.SelectionChanged
        If JGBusqRecibos.Row >= 0 And JGBusqRecibos.RowCount >= 0 Then
            '_MPos = JGBusqRecibos.Row
            _prMostrarRecibo(JGBusqRecibos.Row)
        End If
    End Sub
    Private Sub JGDetalleRecibo_Enter(sender As Object, e As EventArgs) Handles JGDetalleRecibo.Enter
        If (_fnAccesible()) Then
            JGDetalleRecibo.Focus()
            If (JGDetalleRecibo.RowCount <= 0) Then
                _prAddDetalleRecibo()
            End If
            JGDetalleRecibo.Row = 0
        End If
        JGDetalleRecibo.Select()
        If _codeBar = 1 Then
            JGDetalleRecibo.Col = 4
            JGDetalleRecibo.Row = 0
        End If
    End Sub

    Private Sub JGDetalleRecibo_KeyDown(sender As Object, e As KeyEventArgs) Handles JGDetalleRecibo.KeyDown
        Try
            If (Not _fnAccesible()) Then
                Return
            End If
            If (e.KeyData = Keys.Enter) Then
                Dim f, c As Integer
                c = JGDetalleRecibo.Col
                f = JGDetalleRecibo.Row
                If (JGDetalleRecibo.Col = JGDetalleRecibo.RootTable.Columns("rlCant").Index) Then
                    If (JGDetalleRecibo.GetValue("Servicio") <> String.Empty) Then
                        _prAddDetalleRecibo()
                        _HabilitarProductos()
                    Else
                        ToastNotification.Show(Me, "Seleccione un servicio Por Favor", My.Resources.WARNING, 3000, eToastGlowColor.Red, eToastPosition.TopCenter)
                    End If

                End If
                If (JGDetalleRecibo.Col = JGDetalleRecibo.RootTable.Columns("Servicio").Index) Then
                    If (JGDetalleRecibo.GetValue("Servicio") <> String.Empty) Then
                        _prAddDetalleRecibo()
                        _HabilitarProductos()
                    Else
                        ToastNotification.Show(Me, "Seleccione un Servicio Por Favor", My.Resources.WARNING, 3000, eToastGlowColor.Red, eToastPosition.TopCenter)
                    End If

                End If
salirIf:
            End If
            If (e.KeyData = Keys.Control + Keys.Enter And JGDetalleRecibo.Row >= 0 And
                JGDetalleRecibo.Col = JGDetalleRecibo.RootTable.Columns("Servicio").Index) Then
                Dim indexfil As Integer = JGDetalleRecibo.Row
                Dim indexcol As Integer = JGDetalleRecibo.Col
                _HabilitarProductos()

            End If
            If (e.KeyData = Keys.Escape And JGDetalleRecibo.Row >= 0) Then
                _prEliminarFila()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Consulte con el administrador del sistema")
        End Try
    End Sub

    Private Sub JGDetalleRecibo_CellEdited(sender As Object, e As ColumnActionEventArgs) Handles JGDetalleRecibo.CellEdited
        Try
            If (e.Column.Index = JGDetalleRecibo.RootTable.Columns("rlCant").Index) Then
                If (Not IsNumeric(JGDetalleRecibo.GetValue("rlCant")) Or JGDetalleRecibo.GetValue("rlCant").ToString = String.Empty Or IsDBNull(JGDetalleRecibo.GetValue("rlCant"))) Then
                    JGDetalleRecibo.SetValue("rlCant", 1)
                    JGDetalleRecibo.SetValue("rlTotal", JGDetalleRecibo.GetValue("rlPrec"))
                Else
                    If (JGDetalleRecibo.GetValue("rlCant") > 0) Then
                        Dim cant As Integer = JGDetalleRecibo.GetValue("rlCant")
                        'Dim stock As Integer = JGDetalleRecibo.GetValue("stock"
                        Dim stock As Integer = 1000
                        If (cant > stock) Then
                            Dim lin As Integer = JGDetalleRecibo.GetValue("rlId")
                            Dim pos As Integer = -1
                            _fnObtenerFilaDetalle(pos, lin)
                            CType(JGDetalleRecibo.DataSource, DataTable).Rows(pos).Item("rlCant") = 0
                            CType(JGDetalleRecibo.DataSource, DataTable).Rows(pos).Item("rlTotal") = CType(JGDetalleRecibo.DataSource, DataTable).Rows(pos).Item("rlPrec")
                            CType(JGDetalleRecibo.DataSource, DataTable).Rows(pos).Item("rlTotal2") = JGDetalleRecibo.GetValue("tbpcos") * 1
                            CType(JGDetalleRecibo.DataSource, DataTable).Rows(pos).Item("tbtotdesc") = 0
                            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                            ToastNotification.Show(Me, "La cantidad de la venta no debe ser mayor al del stock" & vbCrLf &
                            "Stock=" + Str(stock).ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
                            JGDetalleRecibo.SetValue("rlCant", 0)
                            JGDetalleRecibo.SetValue("rlTotal", JGDetalleRecibo.GetValue("rlPrec"))
                            JGDetalleRecibo.SetValue("rlTotal2", JGDetalleRecibo.GetValue("tbpcos") * 1)
                            JGDetalleRecibo.SetValue("tbtotdesc", 0)
                            _prCalcularPrecioTotal()
                        Else
                            If (cant = stock) Then
                                'JGDetalleRecibo.SelectedFormatStyle.ForeColor = Color.Blue
                                'JGDetalleRecibo.CurrentRow.Cells.Item(e.Column).FormatStyle = New GridEXFormatStyle
                                'JGDetalleRecibo.CurrentRow.Cells(e.Column).FormatStyle.BackColor = Color.Pink
                                'JGDetalleRecibo.CurrentRow.Cells.Item(e.Column).FormatStyle.BackColor = Color.DodgerBlue
                                'JGDetalleRecibo.CurrentRow.Cells.Item(e.Column).FormatStyle.ForeColor = Color.White
                                'JGDetalleRecibo.CurrentRow.Cells.Item(e.Column).FormatStyle.FontBold = TriState.True
                            End If
                        End If

                    Else

                        JGDetalleRecibo.SetValue("rlCant", 1)
                        JGDetalleRecibo.SetValue("rlTotal", JGDetalleRecibo.GetValue("rlPrec"))
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Consulte con el administrador del sistema")
        End Try
    End Sub

    Private Sub JGDetalleRecibo_MouseClick(sender As Object, e As MouseEventArgs) Handles JGDetalleRecibo.MouseClick
        If (Not _fnAccesible()) Then
            Return
        End If
        If (JGDetalleRecibo.RowCount >= 2) Then
            If (JGDetalleRecibo.CurrentColumn.Index = JGDetalleRecibo.RootTable.Columns("img").Index) Then
                _prEliminarFila()
            End If
        End If
    End Sub
    Private Sub JGDetalleRecibo_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles JGDetalleRecibo.CellValueChanged
        Try
            If (e.Column.Index = JGDetalleRecibo.RootTable.Columns("rlCant").Index) Or (e.Column.Index = JGDetalleRecibo.RootTable.Columns("rlPrec").Index) Then
                If (Not IsNumeric(JGDetalleRecibo.GetValue("rlCant")) Or JGDetalleRecibo.GetValue("rlCant").ToString = String.Empty) Then
                    Dim lin As Integer = JGDetalleRecibo.GetValue("rlId")
                    Dim pos As Integer = -1
                    _fnObtenerFilaDetalle(pos, lin)
                    CType(JGDetalleRecibo.DataSource, DataTable).Rows(pos).Item("rlCant") = 1
                    CType(JGDetalleRecibo.DataSource, DataTable).Rows(pos).Item("rlTotal") = CType(JGDetalleRecibo.DataSource, DataTable).Rows(pos).Item("rlPrec")
                Else
                    If (JGDetalleRecibo.GetValue("rlCant") > 0) Then
                        Dim rowIndex As Integer = JGDetalleRecibo.Row
                        Dim lin As Integer = JGDetalleRecibo.GetValue("rlId")
                        Dim pos As Integer = -1
                        _fnObtenerFilaDetalle(pos, lin)
                        P_PonerTotal(rowIndex)
                    Else
                        Dim lin As Integer = JGDetalleRecibo.GetValue("rlId")
                        Dim pos As Integer = -1
                        _fnObtenerFilaDetalle(pos, lin)
                        CType(JGDetalleRecibo.DataSource, DataTable).Rows(pos).Item("rlCant") = 1
                        CType(JGDetalleRecibo.DataSource, DataTable).Rows(pos).Item("rlTotal") = CType(JGDetalleRecibo.DataSource, DataTable).Rows(pos).Item("rlPrec")
                        _prCalcularPrecioTotal()
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
        _MNuevo = True
        _prCargarRecibo()
        _prHabilitar()
        _prLimpiar()
        _prMostrarCampo()
        '_prCargarReciboDetalle(-1)
        '_prAddDetalleRecibo()
        _prHabilitarMenu(1)
        btnNuevo.Visible = False
    End Sub
    Private Sub _prMostrarCampo()
        Dim _tabla As DataTable = L_MostrarPacientes()
        If _tabla.Rows.Count <> 0 Then
            Dim _FilaPaciente As DataRow()
            _FilaPaciente = _tabla.Select("pbid=" + _IdPaciente.ToString)
            _tabla = _FilaPaciente.CopyToDataTable
            'Cirugia
            txtNPropietarioR.Text = _tabla.Rows(0).Item("cacliente")
            txtPacienteR.Text = _tabla.Rows(0).Item("pbnomb")
        End If
    End Sub
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
    Private Sub _prMostrarRecibo(_POS As Integer)

        If JGBusqRecibos.RowCount <> 0 Then
            JGBusqRecibos.Row = _POS
            With JGBusqRecibos
                txtIdRecibo.Text = .GetValue("rkId")
                dtpFrecibo.Value = .GetValue("rkFechaIng")
                txtNPropietarioR.Text = .GetValue("Cliente")
                txtPacienteR.Text = .GetValue("pbnomb")
                txtObservacionR.Text = .GetValue("rkObser")
                tbPagado.Text = .GetValue("rkPagado")
                txtTotalR.Text = .GetValue("rkTotal")
                txtEstadoVenta.Text = .GetValue("Venta")
                'Cargar el detalle
                _prCargarReciboDetalle(IIf(txtIdRecibo.Text = String.Empty, 0, txtIdRecibo.Text))
                LblPaginacion.Text = Str(_POS + 1) + "/" + JGBusqRecibos.RowCount.ToString
            End With
        End If

    End Sub
    Private Sub _prCargarRecibo()
        Dim _tabla As DataTable = L_fnMostrarRecibo()
        JGBusqRecibos.DataSource = _tabla
        JGBusqRecibos.RetrieveStructure()
        JGBusqRecibos.AlternatingColors = True
        '	--rkId, rk_fbId, rkEst, rkFechaIng,Cliente,pbnomb, rkObser, rkDesc, rkTotal
        With JGBusqRecibos.RootTable.Columns("rkId")
            .Width = 70
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "Id"
            .Visible = True
        End With
        With JGBusqRecibos.RootTable.Columns("rk_fbId")
            .Width = 70
            .Caption = "IdFicha"
            .Visible = False
        End With
        With JGBusqRecibos.RootTable.Columns("rkEst")
            .Width = 100
            .Caption = "rkEst"
            .Visible = False
        End With
        With JGBusqRecibos.RootTable.Columns("rkFechaIng")
            .Width = 120
            .Caption = "Fecha"
            .Visible = True
        End With
        With JGBusqRecibos.RootTable.Columns("Cliente")
            .Width = 190
            .Caption = "Cliente"
            .Visible = True
        End With
        With JGBusqRecibos.RootTable.Columns("pbnomb")
            .Width = 150
            .Caption = "Paciente"
            .Visible = True
        End With
        With JGBusqRecibos.RootTable.Columns("rkObser")
            .Width = 150
            .Caption = "Observacion"
            .Visible = False
        End With
        With JGBusqRecibos.RootTable.Columns("rkPagado")
            .Width = 150
            .Caption = "Pagado Por"
            .Visible = False
        End With
        With JGBusqRecibos.RootTable.Columns("rkTotal")
            .Width = 120
            .Caption = "Total"
            .FormatString = "0.00"
            .Visible = True
        End With
        With JGBusqRecibos.RootTable.Columns("rkFecha")
            .Width = 150
            .Caption = "Fecha"
            .Visible = False
        End With
        With JGBusqRecibos.RootTable.Columns("rkHora")
            .Width = 150
            .Caption = "Hora"
            .Visible = False
        End With
        With JGBusqRecibos.RootTable.Columns("rkUsuario")
            .Width = 120
            .Caption = "Usuario"
            .Visible = False
        End With
        With JGBusqRecibos.RootTable.Columns("Venta")
            .Width = 120
            .Caption = "Venta"
            .Visible = True
        End With
        With JGBusqRecibos
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
    Private Sub _prCargarReciboDetalle(rkId As String)
        Dim _tabla As DataTable = L_fnMostrarReciboDetalle(rkId)
        JGDetalleRecibo.DataSource = _tabla
        JGDetalleRecibo.RetrieveStructure()
        JGDetalleRecibo.AlternatingColors = True
        'rlId, rl_rkId, rl_scId, rlEst, Servicio, rlCant,rlPrec, rlTotal,
        With JGDetalleRecibo.RootTable.Columns("rlId")
            .Width = 70
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "IdDetalle"
            .Visible = False
        End With
        With JGDetalleRecibo.RootTable.Columns("rl_rkId")
            .Width = 70
            .Caption = "IdRecibo"
            .Visible = False
        End With
        With JGDetalleRecibo.RootTable.Columns("rl_scId")
            .Width = 100
            .Caption = "Id"
            .Visible = False
        End With
        With JGDetalleRecibo.RootTable.Columns("rlEst")
            .Width = 100
            .Caption = "Estado"
            .Visible = False
        End With
        With JGDetalleRecibo.RootTable.Columns("Servicio")
            .Width = 270
            .Caption = "Descripción"
            .Visible = True
        End With
        With JGDetalleRecibo.RootTable.Columns("rlCant")
            .Width = 180
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Caption = "Cantidad"
            .Visible = True
        End With
        With JGDetalleRecibo.RootTable.Columns("rlPrec")
            .Width = 180
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Caption = "Precio"
            .FormatString = "0.00"
            .Visible = True
        End With
        With JGDetalleRecibo.RootTable.Columns("rlTotal")
            .Width = 180
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Caption = "Total"
            .FormatString = "0.00"
            .Visible = True
        End With
        With JGDetalleRecibo.RootTable.Columns("Estado")
            .Width = 100
            .Caption = "Estado"
            .Visible = False
        End With
        With JGDetalleRecibo.RootTable.Columns("Img")
            .Width = 90
            .CellStyle.ImageHorizontalAlignment = ImageHorizontalAlignment.Center
            .Caption = "Eliminar"
            .Visible = False
        End With
        With JGDetalleRecibo.RootTable.Columns("rlFecha")
            .Width = 150
            .Caption = "Fecha"
            .Visible = False
        End With
        With JGDetalleRecibo.RootTable.Columns("rlHora")
            .Width = 150
            .Caption = "Hora"
            .Visible = False
        End With
        With JGDetalleRecibo.RootTable.Columns("rlUsuario")
            .Width = 150
            .Caption = "Usuario"
            .Visible = False
        End With


        With JGDetalleRecibo
            '.DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            '.FilterMode = FilterMode.Automatic
            '.FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub
    Private Sub _prInhabilitar()
        txtIdRecibo.ReadOnly = True
        txtNPropietarioR.ReadOnly = True
        txtObservacionR.ReadOnly = True
        txtPacienteR.ReadOnly = True
        txtTotalR.IsInputReadOnly = True
        dtpFrecibo.Enabled = False
        _Limpiar = False
        txtDescripcion.ReadOnly = True
        diPrecio.IsInputReadOnly = True
        btnAgregarC.Enabled = False
        tbPagado.ReadOnly = True
    End Sub
    Private Sub _prHabilitar()
        txtIdRecibo.ReadOnly = False
        txtNPropietarioR.ReadOnly = False
        txtObservacionR.ReadOnly = False
        txtPacienteR.ReadOnly = False
        txtTotalR.IsInputReadOnly = False
        dtpFrecibo.Enabled = True
        txtDescripcion.ReadOnly = False
        diPrecio.IsInputReadOnly = False
        btnAgregarC.Enabled = True
        tbPagado.ReadOnly = False
    End Sub
    Private Sub _prLimpiar()
        txtIdRecibo.Clear()
        txtNPropietarioR.Clear()
        txtObservacionR.Clear()
        txtPacienteR.Clear()
        txtTotalR.ResetText()
        dtpFrecibo.Value = DateTime.Today()
        txtEstadoVenta.Clear()
        txtDescripcion.Clear()
        diPrecio.ResetText()
        tbPagado.Clear()
        _prCargarReciboDetalle(-1)
        '_prAddDetalleRecibo()

    End Sub
    Private Sub _prAddDetalleRecibo()
        Dim Bin As New MemoryStream
        Dim img As New Bitmap(My.Resources.delete, 28, 28)
        img.Save(Bin, Imaging.ImageFormat.Png)
        'seg.fjId,seg.fj_FbId,seg.fjEstado,seg.fjSeguimientomiento,seg.fjFecha,seg.fjHora,seg.fjUsuario
        CType(JGDetalleRecibo.DataSource, DataTable).Rows.Add(_fnSiguienteNumi() + 1, 0, 0, 0, "", 0, 0, 0, DateTime.Now, DateTime.Now.ToShortTimeString(), L_Usuario, 0, Bin.GetBuffer)
    End Sub

    Private Sub _prAddDetalleReciboDescripcionPrecio()
        Dim Bin As New MemoryStream
        Dim img As New Bitmap(My.Resources.delete, 28, 28)
        img.Save(Bin, Imaging.ImageFormat.Png)
        CType(JGDetalleRecibo.DataSource, DataTable).Rows.Add(_fnSiguienteNumi() + 1, 0, 0, 0, txtDescripcion.Text, 1, IIf(diPrecio.Value = 0 Or diPrecio.Text = "", 0, diPrecio.Text),
                                                              IIf(diPrecio.Value = 0 Or diPrecio.Text = "", 0, diPrecio.Text), DateTime.Now, DateTime.Now.ToShortTimeString(), L_Usuario, 0, Bin.GetBuffer)


    End Sub
    Public Function _fnSiguienteNumi()
        Dim dt As DataTable = CType(JGDetalleRecibo.DataSource, DataTable)
        Dim rows() As DataRow = dt.Select("rlId=MAX(rlId)")
        If (rows.Count > 0) Then
            Return rows(rows.Count - 1).Item("rlId")
        End If
        Return 1
    End Function
    Public Sub _prFiltrar(tipo As Integer)
        _prCargarRecibo()
        If JGBusqRecibos.RowCount > 0 Then
            _MPos = 0
            _prMostrarRecibo(IIf(tipo = 1, _MPos, JGBusqRecibos.RowCount - 1))
        Else
            _prLimpiar()
            LblPaginacion.Text = "0/0"
        End If
    End Sub
    Public Sub _prCalcularPrecioTotal()
        txtTotalR.Text = JGDetalleRecibo.GetTotal(JGDetalleRecibo.RootTable.Columns("rlTotal"), AggregateFunction.Sum)
    End Sub
    Public Sub _prEliminarFila()
        Try
            If (JGDetalleRecibo.Row >= 0) Then
                If (JGDetalleRecibo.RowCount >= 2) Then
                    Dim estado As Integer = JGDetalleRecibo.GetValue("estado")
                    Dim pos As Integer = -1
                    Dim lin As Integer = JGDetalleRecibo.GetValue("rlId")
                    _fnObtenerFilaDetalle(pos, lin)
                    If (estado = 0) Then
                        CType(JGDetalleRecibo.DataSource, DataTable).Rows(pos).Item("estado") = -2

                    End If
                    If (estado = 1) Then
                        CType(JGDetalleRecibo.DataSource, DataTable).Rows(pos).Item("estado") = -1
                    End If
                    JGDetalleRecibo.RootTable.ApplyFilter(New Janus.Windows.GridEX.GridEXFilterCondition(JGDetalleRecibo.RootTable.Columns("estado"), Janus.Windows.GridEX.ConditionOperator.GreaterThanOrEqualTo, 0))
                    _prCalcularPrecioTotal()
                    JGDetalleRecibo.Select()
                    JGDetalleRecibo.Col = 5
                    JGDetalleRecibo.Row = JGDetalleRecibo.RowCount - 1
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Consulte con el administrador del sistema")
        End Try
    End Sub
    Public Sub _fnObtenerFilaDetalle(ByRef pos As Integer, id As Integer)
        For i As Integer = 0 To CType(JGDetalleRecibo.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim _Id As Integer = CType(JGDetalleRecibo.DataSource, DataTable).Rows(i).Item("rlId")
            If (_Id = id) Then
                pos = i
                Return
            End If
        Next
    End Sub
    Private Sub _prCargarAyudaServicios()
        Dim dt As DataTable
        dt = L_fnMostrarServicio()
        JGServicio.DataSource = dt
        JGServicio.RetrieveStructure()
        JGServicio.AlternatingColors = True
        JGServicio.RowFormatStyle.Font = New Font("arial", 10)
        'scId,scDesc, scPrecio, scEst, 

        With JGServicio.RootTable.Columns("scId")
            .Width = 200
            .TextAlignment = TextAlignment.Center
            .Caption = "ID SERVICIO"
            .Visible = True
        End With
        With JGServicio.RootTable.Columns("scDesc")
            .Width = 350
            .Visible = True
            .Caption = "DESCRIPCIÓN"
        End With

        With JGServicio.RootTable.Columns("scPrecio")
            .Width = 200
            .Visible = True
            .Caption = "PRECIO"
            .FormatString = "0.00"
        End With
        With JGServicio.RootTable.Columns("scEst")
            .Width = 150
            .Visible = False
            .Caption = "Cantidad Clases"
        End With
        With JGServicio.RootTable.Columns("Estado")
            .Width = 150
            .Visible = False
            .Caption = "Estado"
        End With

        With JGServicio
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
        End With
        JGServicio.RootTable.HeaderFormatStyle.FontBold = TriState.True

    End Sub
    Private Sub _HabilitarProductos()
        _prCargarServicios()
    End Sub
    Private Sub _prCargarServicios()
        Dim dtname As DataTable = L_fnNameLabel()
        Dim dt As New DataTable

        dt = L_fnMostrarReciboDetalleServicio(CType(JGDetalleRecibo.DataSource, DataTable))

        Dim listEstCeldas As New List(Of Modelo.Celda)

        listEstCeldas.Add(New Modelo.Celda("scId,", True, "Id", 50))
        listEstCeldas.Add(New Modelo.Celda("scDesc", True, "Servicio", 150))
        listEstCeldas.Add(New Modelo.Celda("scPrecio", True, "Precio", 120))
        listEstCeldas.Add(New Modelo.Celda("estado", False, "", 280))

        Dim frmAyuda As Modelo.ModeloAyuda2
        frmAyuda = New Modelo.ModeloAyuda2(780, 170, dt, "", listEstCeldas, "Servicio", "scDesc")
        Dim tamano As Size = New Size((50 * 700) / 100, 400) 'Me.Size.Height)
        'Dim tamano As Size = New Size((35 * Me.Size.Width) / 100, 500) 'Me.Size.Height)
        '42
        frmAyuda.Size = tamano
        frmAyuda.ShowDialog()
        If frmAyuda.seleccionado = True Then
            Dim Row As Janus.Windows.GridEX.GridEXRow
            Row = frmAyuda.filaSelect
            Dim pos As Integer = -1
            JGDetalleRecibo.Row = JGDetalleRecibo.RowCount - 1
            '_fnObtenerFilaDetalle(pos, JGDetalleRecibo.GetValue("rlId"))
            _fnObtenerFilaDetalle(pos, JGDetalleRecibo.GetValue("rlId")) ' COd Det
            Dim numiProd = Row.Cells("scId").Value 'Cod Profucto
            CType(JGDetalleRecibo.DataSource, DataTable).Rows(pos).Item("rl_scId") = Row.Cells("scId").Value
            CType(JGDetalleRecibo.DataSource, DataTable).Rows(pos).Item("Servicio") = Row.Cells("scDesc").Value
            CType(JGDetalleRecibo.DataSource, DataTable).Rows(pos).Item("rlPrec") = Row.Cells("scPrecio").Value
            CType(JGDetalleRecibo.DataSource, DataTable).Rows(pos).Item("rlCant") = 1
            CType(JGDetalleRecibo.DataSource, DataTable).Rows(pos).Item("rlEst") = Row.Cells("estado").Value
            CType(JGDetalleRecibo.DataSource, DataTable).Rows(pos).Item("rlTotal") = Row.Cells("scPrecio").Value
            'CType(JGDetalleRecibo.DataSource, DataTable).Rows(pos).Item("rlId") = 0
            CType(JGDetalleRecibo.DataSource, DataTable).Rows(pos).Item("rl_rkId") = 0
            _prCalcularPrecioTotal()
            _DesHabilitarProductos()
            'FilaSelectLote = Nothing
        End If
    End Sub
    Private Sub _DesHabilitarProductos()
        JGDetalleRecibo.Select()
        JGDetalleRecibo.Col = 5
        JGDetalleRecibo.Row = JGDetalleRecibo.RowCount - 1
        JGDetalleRecibo.SetValue("rlCant", 1)
        ' JGDetalleRecibo.SetValue("rlCant", DBNull.Value)
    End Sub
    Public Sub P_PonerTotal(rowIndex As Integer)
        If (rowIndex < JGDetalleRecibo.RowCount) Then
            Dim lin As Integer = JGDetalleRecibo.GetValue("rlId")
            Dim pos As Integer = -1
            _fnObtenerFilaDetalle(pos, lin)
            Dim cant As Double = JGDetalleRecibo.GetValue("rlCant")
            Dim uni As Double = JGDetalleRecibo.GetValue("rlPrec")
            Dim dt As DataTable = CType(JGDetalleRecibo.DataSource, DataTable)
            If (pos >= 0) Then
                Dim TotalUnitario As Double = cant * uni
                CType(JGDetalleRecibo.DataSource, DataTable).Rows(pos).Item("rlTotal") = TotalUnitario
                JGDetalleRecibo.SetValue("rlTotal", TotalUnitario)
                Dim estado As Integer = CType(JGDetalleRecibo.DataSource, DataTable).Rows(pos).Item("estado")
                If (estado = 1) Then
                    CType(JGDetalleRecibo.DataSource, DataTable).Rows(pos).Item("estado") = 2
                End If
            End If
            _prCalcularPrecioTotal()
        End If
    End Sub
    Private Sub _prImprimir()
        Try
            Dim dt As DataTable = L_fnMostrarReciboReporte(txtIdRecibo.Text)
            If (dt.Rows.Count > 0) Then
                If Not IsNothing(P_Global.Visualizador) Then
                    P_Global.Visualizador.Close()
                End If
                P_Global.Visualizador = New Visualizador
                Dim objrep As New R_Recibo
                objrep.SetDataSource(dt)
                P_Global.Visualizador.CrGeneral.ReportSource = objrep 'Comentar
                P_Global.Visualizador.WindowState = FormWindowState.Maximized
                P_Global.Visualizador.Show() 'Comentar
                P_Global.Visualizador.BringToFront() 'ComentarS
            Else
                ToastNotification.Show(Me, "NO HAY DATOS PARA LOS PARAMETROS SELECCIONADOS..!!!",
                                           My.Resources.WARNING, 2000,
                                           eToastGlowColor.Blue,
                                           eToastPosition.BottomLeft)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region
#Region "METODOS PRIVADOS OVERRRIDABLES"
    Public Overrides Function _PMOGrabarRegistro() As Boolean
        Dim res As Boolean = L_fnGrabarRecibo(txtIdRecibo.Text, _IdFicha, dtpFrecibo.Value, txtObservacionR.Text, txtTotalR.Text, CType(JGDetalleRecibo.DataSource, DataTable), tbPagado.Text)
        If res Then
            Modificado = False
            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Id del recibo ".ToUpper + txtIdRecibo.Text + " Grabado con Exito.".ToUpper,
                                      img, 3000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )
            txtObservacionR.Focus()
            _prInhabilitar()
            _prFiltrar(2)
            _Limpiar = True
            btnGrabar.Enabled = False
            'Dim info As New TaskDialogInfo("RECIBO".ToUpper, eTaskDialogIcon.Delete, "RECIBO".ToUpper, "¿Desea imprimir el recibo?".ToUpper, eTaskDialogButton.Yes Or eTaskDialogButton.Cancel, eTaskDialogBackgroundColor.Blue)
            'Dim result As eTaskDialogResult = TaskDialog.Show(info)
            'If result = eTaskDialogResult.Yes Then
            '    _prImprimir()
            'End If
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "El recibo no pudo ser insertado".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)
        End If
        Return res
    End Function
    ''*****MODDIFICA EL REGISTRO*****''
    Public Overrides Function _PMOModificarRegistro() As Boolean
        Dim res As Boolean = L_fnModificarRecibo(txtIdRecibo.Text, _IdFicha, dtpFrecibo.Value, txtObservacionR.Text,
                                                 txtTotalR.Text, CType(JGDetalleRecibo.DataSource, DataTable), tbPagado.Text)
        If res Then
            Modificado = False
            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Id del recibo ".ToUpper + txtIdRecibo.Text + " Modificado con Exito.".ToUpper,
                                      img, 3000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )
            _prInhabilitar()
            _prFiltrar(2)
            'Dim info As New TaskDialogInfo("RECIBO".ToUpper, eTaskDialogIcon.Delete, "RECIBO".ToUpper, "¿Desea imprimir el recibo?".ToUpper, eTaskDialogButton.Yes Or eTaskDialogButton.Cancel, eTaskDialogBackgroundColor.Blue)
            'Dim result As eTaskDialogResult = TaskDialog.Show(info)
            'If result = eTaskDialogResult.Yes Then
            '    _prImprimir()
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
            Dim res As Boolean = L_fnEliminarRecibo(txtIdRecibo.Text, mensajeError)
            If res Then
                Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)

                ToastNotification.Show(Me, "Código del recibo ".ToUpper + txtIdRecibo.Text + " eliminado con Exito.".ToUpper,
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
        If JGDetalleRecibo.RowCount = 0 Then
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Ingrese un servicio para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        End If

        If txtNPropietarioR.Text = String.Empty Then
            txtNPropietarioR.BackColor = Color.Red
            MEP.SetError(txtNPropietarioR, "Ingrese un propietario!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Ingrese un propietario para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        Else
            txtNPropietarioR.BackColor = Color.White
            MEP.SetError(txtNPropietarioR, "")
        End If

        If txtPacienteR.Text = String.Empty Then
            txtPacienteR.BackColor = Color.Red
            MEP.SetError(txtPacienteR, "Ingrese un Paciente!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Ingrese paciente para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        Else
            txtPacienteR.BackColor = Color.White
            MEP.SetError(txtPacienteR, "")
        End If
        MHighlighterFocus.UpdateHighlights()
        Return _ok
    End Function
    Public Overrides Sub _PMONuevo()
        'JGBusqRecibos.Enabled = False 'Deshabilita el buscador de la Grilla
        _prLimpiar()
        _prHabilitar()
    End Sub
    Public Overrides Sub _PMOModificar()
        'JGBusqRecibos.Enabled = False 'Deshabilita el buscador de la Grilla
        If txtEstadoVenta.Text = "NO" Then
            _prHabilitar()
            _prCargarIconELiminar()
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "No se puede modificar porque ya está enlazada a una Venta".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
            btnGrabar.Enabled = False
            Exit Sub
        End If

    End Sub
    Public Sub _prCargarIconELiminar()
        For i As Integer = 0 To CType(JGDetalleRecibo.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim Bin As New MemoryStream
            Dim img As New Bitmap(My.Resources.delete, 20, 20)
            img.Save(Bin, Imaging.ImageFormat.Png)
            CType(JGDetalleRecibo.DataSource, DataTable).Rows(i).Item("img") = Bin.GetBuffer
            JGDetalleRecibo.RootTable.Columns("img").Visible = True
        Next

    End Sub
    Private Sub btnAgregarC_Click(sender As Object, e As EventArgs) Handles btnAgregarC.Click
        If txtDescripcion.Text = String.Empty Or diPrecio.Text = String.Empty Or diPrecio.Value = 0 Then
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Debe llenar Descripción y Precio mayor a 0 para agregar".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        Else
            _prAddDetalleReciboDescripcionPrecio()
            _prCalcularPrecioTotal()
            txtDescripcion.Clear()
            diPrecio.ResetText()
        End If

    End Sub

    Private Sub JGBusqRecibos_DoubleClick(sender As Object, e As EventArgs) Handles JGBusqRecibos.DoubleClick
        superTabControl1.SelectedTabIndex = 0
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        _prImprimir()
    End Sub

    Public Overrides Sub _PMOSalir()
        _prInhabilitar()
        _prFiltrar(1)
    End Sub
#End Region
End Class