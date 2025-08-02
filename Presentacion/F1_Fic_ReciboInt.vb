Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX
Imports System.IO
Public Class F1_Fic_ReciboInt
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
    Private Sub JGDetalleReciboInt_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGDetalleReciboInt.EditingCell
        If (_fnAccesible()) Then
            'Habilitar solo las columnas de cantidad, detalle
            If (e.Column.Index = JGDetalleReciboInt.RootTable.Columns("rnObser").Index Or
                e.Column.Index = JGDetalleReciboInt.RootTable.Columns("rnDesc").Index Or
                   e.Column.Index = JGDetalleReciboInt.RootTable.Columns("rnPrec").Index Or
                e.Column.Index = JGDetalleReciboInt.RootTable.Columns("rnCant").Index) Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        Else
            e.Cancel = True
        End If

    End Sub
    Public Function _fnAccesible()
        Return dtpFechaRI.Enabled = True
    End Function
    'PRIMERO
    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        If JGBusqRecibosI.RowCount > 0 Then
            _MPos = 0
            _prMostrarRecibo(_MPos)
        End If
    End Sub
    'ANTERIOR
    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If _MPos > 0 And JGBusqRecibosI.RowCount > 0 Then
            _MPos = _MPos - 1
            _prMostrarRecibo(_MPos)
        End If
    End Sub
    'SIGUIENTE
    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If _MPos < JGBusqRecibosI.RowCount - 1 Then
            _MPos = _MPos + 1
            _prMostrarRecibo(_MPos)
        End If
    End Sub
    'ULTIMO
    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        If JGBusqRecibosI.RowCount > 0 Then
            _MPos = JGBusqRecibosI.RowCount - 1
            _prMostrarRecibo(_MPos)
        End If
    End Sub
    'SELECCIONAR GRILLA
    Private Sub JGBusqRecibosI_SelectionChanged(sender As Object, e As EventArgs) Handles JGBusqRecibosI.SelectionChanged
        If JGBusqRecibosI.Row >= 0 And JGBusqRecibosI.RowCount >= 0 Then
            '_MPos = JGBusqRecibosI.Row
            _prMostrarRecibo(JGBusqRecibosI.Row)
        End If
    End Sub
    'Private Sub JGDetalleReciboInt_Enter(sender As Object, e As EventArgs) Handles JGDetalleReciboInt.Enter
    '    If (_fnAccesible()) Then
    '        JGDetalleReciboInt.Focus()
    '        If (JGDetalleReciboInt.RowCount <= 0) Then
    '            '_prAddDetalleRecibo()
    '        End If
    '        JGDetalleReciboInt.Row = 0
    '    End If
    '    JGDetalleReciboInt.Select()
    '    If _codeBar = 1 Then
    '        JGDetalleReciboInt.Col = 6 'Cantidad
    '        JGDetalleReciboInt.Row = 0
    '    End If
    'End Sub

    Private Sub JGDetalleReciboInt_KeyDown(sender As Object, e As KeyEventArgs) Handles JGDetalleReciboInt.KeyDown
        If (Not _fnAccesible()) Then
            Return
        End If
        '        If (e.KeyData = Keys.Enter) Then
        '            Dim f, c As Integer
        '            c = JGDetalleReciboInt.Col
        '            f = JGDetalleReciboInt.Row
        '            If (JGDetalleReciboInt.Col = JGDetalleReciboInt.RootTable.Columns("rnCant").Index) Then
        '                If (JGDetalleReciboInt.GetValue("Servicio") <> String.Empty) Then
        '                    _prAddDetalleRecibo()
        '                    ' _HabilitarProductos()
        '                Else
        '                    ToastNotification.Show(Me, "Seleccione un servicio Por Favor", My.Resources.WARNING, 3000, eToastGlowColor.Red, eToastPosition.TopCenter)
        '                End If

        '            End If
        '            If (JGDetalleReciboInt.Col = JGDetalleReciboInt.RootTable.Columns("Servicio").Index) Then
        '                If (JGDetalleReciboInt.GetValue("Servicio") <> String.Empty) Then
        '                    _prAddDetalleRecibo()
        '                    '_HabilitarProductos()
        '                Else
        '                    ToastNotification.Show(Me, "Seleccione un Servicio Por Favor", My.Resources.WARNING, 3000, eToastGlowColor.Red, eToastPosition.TopCenter)
        '                End If

        '            End If
        'salirIf:
        '        End If
        '        If (e.KeyData = Keys.Control + Keys.Enter And JGDetalleReciboInt.Row >= 0 And
        '            JGDetalleReciboInt.Col = JGDetalleReciboInt.RootTable.Columns("Servicio").Index) Then
        '            Dim indexfil As Integer = JGDetalleReciboInt.Row
        '            Dim indexcol As Integer = JGDetalleReciboInt.Col
        '            '_HabilitarProductos()

        '        End If
        If (e.KeyData = Keys.Escape And JGDetalleReciboInt.Row >= 0) Then
            _prEliminarFila()
        End If
        If (e.KeyData = Keys.Control + Keys.S And JGDetalleReciboInt.Row >= 0) Then
            txtObservacionI.Select()
        End If
    End Sub

    Private Sub JGDetalleReciboInt_CellEdited(sender As Object, e As ColumnActionEventArgs) Handles JGDetalleReciboInt.CellEdited
        If (e.Column.Index = JGDetalleReciboInt.RootTable.Columns("rnCant").Index) Then
            If (Not IsNumeric(JGDetalleReciboInt.GetValue("rnCant")) Or JGDetalleReciboInt.GetValue("rnCant").ToString = String.Empty Or IsDBNull(JGDetalleReciboInt.GetValue("rnCant"))) Then
                JGDetalleReciboInt.SetValue("rnCant", 1)
                JGDetalleReciboInt.SetValue("rnTotal", JGDetalleReciboInt.GetValue("rnPrec"))
            Else
                If (JGDetalleReciboInt.GetValue("rnCant") > 0) Then
                    Dim cant As Integer = JGDetalleReciboInt.GetValue("rnCant")
                    'Dim stock As Integer = JGDetalleReciboInt.GetValue("stock"
                    Dim stock As Integer = 1000
                    If (cant > stock) Then
                        Dim lin As Integer = JGDetalleReciboInt.GetValue("rnId")
                        Dim pos As Integer = -1
                        _fnObtenerFilaDetalle(pos, lin)
                        CType(JGDetalleReciboInt.DataSource, DataTable).Rows(pos).Item("rnCant") = 0
                        CType(JGDetalleReciboInt.DataSource, DataTable).Rows(pos).Item("rnTotal") = CType(JGDetalleReciboInt.DataSource, DataTable).Rows(pos).Item("rnPrec")
                        CType(JGDetalleReciboInt.DataSource, DataTable).Rows(pos).Item("rnTotal2") = JGDetalleReciboInt.GetValue("tbpcos") * 1
                        CType(JGDetalleReciboInt.DataSource, DataTable).Rows(pos).Item("tbtotdesc") = 0
                        Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                        ToastNotification.Show(Me, "La cantidad de la venta no debe ser mayor al del stock" & vbCrLf &
                        "Stock=" + Str(stock).ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
                        JGDetalleReciboInt.SetValue("rnCant", 0)
                        JGDetalleReciboInt.SetValue("rnTotal", JGDetalleReciboInt.GetValue("rnPrec"))
                        JGDetalleReciboInt.SetValue("rnTotal2", JGDetalleReciboInt.GetValue("tbpcos") * 1)
                        JGDetalleReciboInt.SetValue("tbtotdesc", 0)
                        _prCalcularPrecioTotal()
                    Else
                        If (cant = stock) Then
                            'JGDetalleReciboInt.SelectedFormatStyle.ForeColor = Color.Blue
                            'JGDetalleReciboInt.CurrentRow.Cells.Item(e.Column).FormatStyle = New GridEXFormatStyle
                            'JGDetalleReciboInt.CurrentRow.Cells(e.Column).FormatStyle.BackColor = Color.Pink
                            'JGDetalleReciboInt.CurrentRow.Cells.Item(e.Column).FormatStyle.BackColor = Color.DodgerBlue
                            'JGDetalleReciboInt.CurrentRow.Cells.Item(e.Column).FormatStyle.ForeColor = Color.White
                            'JGDetalleReciboInt.CurrentRow.Cells.Item(e.Column).FormatStyle.FontBold = TriState.True
                        End If
                    End If

                Else

                    JGDetalleReciboInt.SetValue("rnCant", 1)
                    JGDetalleReciboInt.SetValue("rnTotal", JGDetalleReciboInt.GetValue("rnPrec"))
                End If
            End If
        End If
    End Sub

    Private Sub JGDetalleReciboInt_MouseClick(sender As Object, e As MouseEventArgs) Handles JGDetalleReciboInt.MouseClick
        If (Not _fnAccesible()) Then
            Return
        End If
        If (JGDetalleReciboInt.RowCount >= 2) Then
            If (JGDetalleReciboInt.CurrentColumn.Index = JGDetalleReciboInt.RootTable.Columns("img").Index) Then
                _prEliminarFila()
            End If
        End If
    End Sub
    Private Sub JGDetalleReciboInt_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles JGDetalleReciboInt.CellValueChanged
        If (e.Column.Index = JGDetalleReciboInt.RootTable.Columns("rnCant").Index) Or (e.Column.Index = JGDetalleReciboInt.RootTable.Columns("rnPrec").Index) Then
            If (Not IsNumeric(JGDetalleReciboInt.GetValue("rnCant")) Or JGDetalleReciboInt.GetValue("rnCant").ToString = String.Empty) Then
                Dim lin As Integer = JGDetalleReciboInt.GetValue("rnId")
                Dim pos As Integer = -1
                _fnObtenerFilaDetalle(pos, lin)
                CType(JGDetalleReciboInt.DataSource, DataTable).Rows(pos).Item("rnCant") = 1
                CType(JGDetalleReciboInt.DataSource, DataTable).Rows(pos).Item("rnTotal") = CType(JGDetalleReciboInt.DataSource, DataTable).Rows(pos).Item("rnPrec")
            Else
                If (JGDetalleReciboInt.GetValue("rnCant") > 0) Then
                    Dim rowIndex As Integer = JGDetalleReciboInt.Row
                    Dim lin As Integer = JGDetalleReciboInt.GetValue("rnId")
                    Dim pos As Integer = -1
                    _fnObtenerFilaDetalle(pos, lin)
                    P_PonerTotal(rowIndex)
                Else
                    Dim lin As Integer = JGDetalleReciboInt.GetValue("rnId")
                    Dim pos As Integer = -1
                    _fnObtenerFilaDetalle(pos, lin)
                    CType(JGDetalleReciboInt.DataSource, DataTable).Rows(pos).Item("rnCant") = 1
                    CType(JGDetalleReciboInt.DataSource, DataTable).Rows(pos).Item("rnTotal") = CType(JGDetalleReciboInt.DataSource, DataTable).Rows(pos).Item("rnPrec")
                    _prCalcularPrecioTotal()
                End If
            End If
        End If
        If txtIdReciboI.Text <> String.Empty Then
            If (e.Column.Index = JGDetalleReciboInt.RootTable.Columns("rnObser").Index) Or (e.Column.Index = JGDetalleReciboInt.RootTable.Columns("rnDesc").Index) Then
                Dim lin As Integer = JGDetalleReciboInt.GetValue("rnId")
                Dim pos As Integer = -1
                _fnObtenerFilaDetalle(pos, lin)
                Dim _tabla As DataTable = L_fnMostrarReciboIntDetalle(txtIdReciboI.Text)
                If _tabla.Rows.Count > 0 Then
                    Dim _fila As DataRow() = _tabla.Select("rnId =" + lin.ToString())
                    If _fila.Count > 0 Then
                        'CType(JGDetalleReciboInt.DataSource, DataTable).Rows(pos).Item("rnObser") = IIf(CType(JGDetalleReciboInt.DataSource, DataTable).Rows(pos).Item("rnObser") = String.Empty,
                        '                                                                         _tabla.Rows(0).Item("rnObser"), CType(JGDetalleReciboInt.DataSource, DataTable).Rows(pos).Item("rnObser"))
                        'CType(JGDetalleReciboInt.DataSource, DataTable).Rows(pos).Item("rnDesc") = IIf(CType(JGDetalleReciboInt.DataSource, DataTable).Rows(pos).Item("rnDesc") = String.Empty,
                        '                                                                         _tabla.Rows(0).Item("rnDesc"), CType(JGDetalleReciboInt.DataSource, DataTable).Rows(pos).Item("rnDesc"))
                        Dim estado As Integer = CType(JGDetalleReciboInt.DataSource, DataTable).Rows(pos).Item("estado")
                        If (estado = 1) Then
                            CType(JGDetalleReciboInt.DataSource, DataTable).Rows(pos).Item("estado") = 2
                        End If
                    End If


                End If

            End If
        End If
    End Sub
    Private Sub btnAgregarI_Click(sender As Object, e As EventArgs) Handles btnAgregarI.Click
        _prAddDetalleRecibo()
        _prCalcularPrecioTotal()
        _prLimpiarText()
        JGDetalleReciboInt.Select()
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
        txtTratamiento.Select()
        btnNuevo.Visible = False
    End Sub
    Private Sub _prMostrarCampo()
        If _IdPaciente <> 0 Then
            Dim _tabla As DataTable = L_MostrarPacientes()
            If _tabla.Rows.Count <> 0 Then
                Dim _FilaPaciente As DataRow()
                _FilaPaciente = _tabla.Select("pbid=" + _IdPaciente.ToString)
                _tabla = _FilaPaciente.CopyToDataTable
                txtPropietarioI.Text = _tabla.Rows(0).Item("cacliente")
                txtPacienteI.Text = _tabla.Rows(0).Item("pbnomb")
            End If
        End If
    End Sub
    Private Sub _prAddDetalleRecibo()
        Dim Bin As New MemoryStream
        Dim img As New Bitmap(My.Resources.delete, 28, 28)
        img.Save(Bin, Imaging.ImageFormat.Png)
        ''--rnId, rn_rmId, rnEst, rnFechaReg, rnObser, rnDesc, rnCant, rnPrec, rnTotal, rnFecha, rnHora, rnUsuario
        CType(JGDetalleReciboInt.DataSource, DataTable).Rows.Add(_fnSiguienteNumi() + 1, 0, 0, DateTime.Now, txtObservacionI.Text, txtDescripcion.Text,
                                                                 1, IIf(diPrecio.Value = 0 Or diPrecio.Text = "", 0, diPrecio.Text),
                                                                 IIf(diPrecio.Value = 0 Or diPrecio.Text = "", 0, diPrecio.Text),
                                                                 DateTime.Now, DateTime.Now.ToShortTimeString(), L_Usuario, 0, Bin.GetBuffer)
    End Sub
    Public Function _fnSiguienteNumi()
        Dim dt As DataTable = CType(JGDetalleReciboInt.DataSource, DataTable)
        Dim rows() As DataRow = dt.Select("rnId=MAX(rnId)")
        If (rows.Count > 0) Then
            Return rows(rows.Count - 1).Item("rnId")
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
        txtObservacionI.Clear()
        txtDescripcion.Clear()
        diPrecio.ResetText()
    End Sub
    Private Sub _prMostrarRecibo(_POS As Integer)
        If JGBusqRecibosI.RowCount <> 0 Then
            JGBusqRecibosI.Row = _POS
            With JGBusqRecibosI
                txtIdReciboI.Text = .GetValue("rmId")
                dtpFechaRI.Value = .GetValue("rmFechaIng")
                txtPropietarioI.Text = .GetValue("Cliente")
                txtPacienteI.Text = .GetValue("pbnomb")
                txtTratamiento.Text = .GetValue("rmTratam")
                txtTotalR.Text = .GetValue("rmTotal")
                'Cargar el detalle
                _prCargarReciboDetalle(IIf(txtIdReciboI.Text = String.Empty, 0, txtIdReciboI.Text))
                LblPaginacion.Text = Str(_POS + 1) + "/" + JGBusqRecibosI.RowCount.ToString
            End With
        End If

    End Sub
    Private Sub _prCargarRecibo()
        Dim _tabla As DataTable = L_fnMostrarReciboInt(0) 'Muestra todos los recibos
        JGBusqRecibosI.DataSource = _tabla
        JGBusqRecibosI.RetrieveStructure()
        JGBusqRecibosI.AlternatingColors = True
        '--rmId, rm_IhID, rm_PbId, rmEst, rmFechaIng,Cliente,pbnomb, rmTratam, rmTotal, rmFecha, rmHora, rmusuario
        With JGBusqRecibosI.RootTable.Columns("rmId")
            .Width = 90
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "Id"
            .Visible = True
        End With
        With JGBusqRecibosI.RootTable.Columns("rm_IhID")
            .Width = 90
            .Caption = "Id Seg.Internacion"
            .Visible = True
        End With
        With JGBusqRecibosI.RootTable.Columns("rm_PbId")
            .Width = 70
            .Caption = "IdPaciente"
            .Visible = False
        End With
        With JGBusqRecibosI.RootTable.Columns("rmEst")
            .Width = 100
            .Caption = "rmEst"
            .Visible = False
        End With
        With JGBusqRecibosI.RootTable.Columns("rmFechaIng")
            .Width = 120
            .Caption = "Fecha"
            .Visible = True
        End With
        With JGBusqRecibosI.RootTable.Columns("Cliente")
            .Width = 180
            .Caption = "Cliente"
            .Visible = True
        End With
        With JGBusqRecibosI.RootTable.Columns("pbnomb")
            .Width = 180
            .Caption = "Paciente"
            .Visible = True
        End With
        With JGBusqRecibosI.RootTable.Columns("rmTratam")
            .Width = 200
            .Caption = "Tratamiento"
            .Visible = True
        End With
        With JGBusqRecibosI.RootTable.Columns("rmTotal")
            .Width = 120
            .Caption = "Total"
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .FormatString = "0.00"
            .Visible = True
        End With
        With JGBusqRecibosI.RootTable.Columns("rmFecha")
            .Width = 150
            .Caption = "Fecha"
            .Visible = False
        End With
        With JGBusqRecibosI.RootTable.Columns("rmHora")
            .Width = 150
            .Caption = "Hora"
            .Visible = False
        End With
        With JGBusqRecibosI.RootTable.Columns("rmUsuario")
            .Width = 120
            .Caption = "Usuario"
            .Visible = False
        End With
        With JGBusqRecibosI.RootTable.Columns("Venta")
            .Width = 100
            .Caption = "Venta"
            .Visible = True
        End With
        With JGBusqRecibosI
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
    Private Sub _prCargarReciboDetalle(rnId As String)
        Dim _tabla As DataTable = L_fnMostrarReciboIntDetalle(rnId)
        JGDetalleReciboInt.DataSource = _tabla
        JGDetalleReciboInt.RetrieveStructure()
        JGDetalleReciboInt.AlternatingColors = True
        '--rnId, rn_rmId, rnEst, rnFechaReg, rnObser, rnDesc, rnCant, rnPrec, rnTotal, rnFecha, rnHora, rnUsuario
        With JGDetalleReciboInt.RootTable.Columns("rnId")
            .Width = 70
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Caption = "IdDetalle"
            .Visible = False
        End With
        With JGDetalleReciboInt.RootTable.Columns("rn_rmId")
            .Width = 70
            .Caption = "IdRecibo"
            .Visible = False
        End With
        With JGDetalleReciboInt.RootTable.Columns("rnEst")
            .Width = 100
            .Caption = "Estado"
            .Visible = False
        End With
        With JGDetalleReciboInt.RootTable.Columns("rnFechaReg")
            .Width = 100
            .Caption = "Fecha"
            .Visible = True
        End With
        With JGDetalleReciboInt.RootTable.Columns("rnObser")
            .Width = 160
            .Caption = "Observación"
            .Visible = True
        End With
        With JGDetalleReciboInt.RootTable.Columns("rnDesc")
            .Width = 160
            .Caption = "Descripción"
            .Visible = True
        End With
        With JGDetalleReciboInt.RootTable.Columns("rnCant")
            .Width = 120
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Caption = "Cantidad"
            .Visible = True
        End With
        With JGDetalleReciboInt.RootTable.Columns("rnPrec")
            .Width = 120
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Caption = "Precio"
            .FormatString = "0.00"
            .Visible = True
        End With
        With JGDetalleReciboInt.RootTable.Columns("rnTotal")
            .Width = 120
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Caption = "Total"
            .FormatString = "0.00"
            .Visible = True
        End With
        With JGDetalleReciboInt.RootTable.Columns("Img")
            .Width = 90
            .CellStyle.ImageHorizontalAlignment = ImageHorizontalAlignment.Center
            .Caption = "Eliminar"
            .Visible = True
        End With
        With JGDetalleReciboInt.RootTable.Columns("Estado")
            .Width = 90
            .CellStyle.ImageHorizontalAlignment = ImageHorizontalAlignment.Center
            .Caption = "estado"
            .Visible = False
        End With
        With JGDetalleReciboInt.RootTable.Columns("rnFecha")
            .Width = 150
            .Caption = "Fecha"
            .Visible = False
        End With
        With JGDetalleReciboInt.RootTable.Columns("rnHora")
            .Width = 150
            .Caption = "Hora"
            .Visible = False
        End With
        With JGDetalleReciboInt.RootTable.Columns("rnUsuario")
            .Width = 150
            .Caption = "Usuario"
            .Visible = False
        End With
        With JGDetalleReciboInt
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
        txtPropietarioI.ReadOnly = True
        txtTratamiento.ReadOnly = True
        txtPacienteI.ReadOnly = True
        txtObservacionI.ReadOnly = True
        txtDescripcion.ReadOnly = True
        diPrecio.IsInputReadOnly = True
        txtTotalR.IsInputReadOnly = True
        _Limpiar = False
        dtpFechaRI.Enabled = False
    End Sub
    Private Sub _prHabilitar()
        txtIdReciboI.ReadOnly = False
        txtPropietarioI.ReadOnly = False
        txtTratamiento.ReadOnly = False
        txtPacienteI.ReadOnly = False
        txtObservacionI.ReadOnly = False
        txtDescripcion.ReadOnly = False
        diPrecio.IsInputReadOnly = False
        txtTotalR.IsInputReadOnly = False
        dtpFechaRI.Enabled = True
    End Sub
    Private Sub _prLimpiar()
        txtIdReciboI.Clear()
        txtPropietarioI.Clear()
        txtTratamiento.Clear()
        txtPacienteI.Clear()
        txtObservacionI.Clear()
        txtDescripcion.Clear()
        txtTotalR.ResetText()
        diPrecio.ResetText()
        dtpFechaRI.Value = DateTime.Today()
        _prCargarReciboDetalle(-1)
        '_prAddDetalleRecibo()
    End Sub

    Public Sub _prFiltrar(tipo As Integer)
        _prCargarRecibo()
        If JGBusqRecibosI.RowCount > 0 Then
            _MPos = 0
            _prMostrarRecibo(IIf(tipo = 1, _MPos, JGBusqRecibosI.RowCount - 1))
        Else
            _prLimpiar()
            LblPaginacion.Text = "0/0"
        End If
    End Sub
    Public Sub _prCalcularPrecioTotal()
        txtTotalR.Text = JGDetalleReciboInt.GetTotal(JGDetalleReciboInt.RootTable.Columns("rnTotal"), AggregateFunction.Sum)
    End Sub
    Public Sub _prEliminarFila()
        If (JGDetalleReciboInt.Row >= 0) Then
            If (JGDetalleReciboInt.RowCount >= 2) Then
                Dim estado As Integer = JGDetalleReciboInt.GetValue("estado")
                Dim pos As Integer = -1
                Dim lin As Integer = JGDetalleReciboInt.GetValue("rnId")
                _fnObtenerFilaDetalle(pos, lin)
                If (estado = 0) Then
                    CType(JGDetalleReciboInt.DataSource, DataTable).Rows(pos).Item("estado") = -2

                End If
                If (estado = 1) Then
                    CType(JGDetalleReciboInt.DataSource, DataTable).Rows(pos).Item("estado") = -1
                End If
                JGDetalleReciboInt.RootTable.ApplyFilter(New Janus.Windows.GridEX.GridEXFilterCondition(JGDetalleReciboInt.RootTable.Columns("estado"), Janus.Windows.GridEX.ConditionOperator.GreaterThanOrEqualTo, 0))
                _prCalcularPrecioTotal()
                JGDetalleReciboInt.Select()
                JGDetalleReciboInt.Col = 5
                JGDetalleReciboInt.Row = JGDetalleReciboInt.RowCount - 1
            End If
        End If
    End Sub
    Public Sub _fnObtenerFilaDetalle(ByRef pos As Integer, id As Integer)
        For i As Integer = 0 To CType(JGDetalleReciboInt.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim _Id As Integer = CType(JGDetalleReciboInt.DataSource, DataTable).Rows(i).Item("rnId")
            If (_Id = id) Then
                pos = i
                Return
            End If
        Next
    End Sub
    Private Sub _DesHabilitarProductos()
        JGDetalleReciboInt.Select()
        JGDetalleReciboInt.Col = 5
        JGDetalleReciboInt.Row = JGDetalleReciboInt.RowCount - 1
        JGDetalleReciboInt.SetValue("rnCant", 1)
        ' JGDetalleReciboInt.SetValue("rnCant", DBNull.Value)
    End Sub
    Public Sub P_PonerTotal(rowIndex As Integer)
        If (rowIndex < JGDetalleReciboInt.RowCount) Then
            Dim lin As Integer = JGDetalleReciboInt.GetValue("rnId")
            Dim pos As Integer = -1
            _fnObtenerFilaDetalle(pos, lin)
            Dim cant As Double = JGDetalleReciboInt.GetValue("rnCant")
            Dim uni As Double = JGDetalleReciboInt.GetValue("rnPrec")
            Dim dt As DataTable = CType(JGDetalleReciboInt.DataSource, DataTable)
            If (pos >= 0) Then
                Dim TotalUnitario As Double = cant * uni
                CType(JGDetalleReciboInt.DataSource, DataTable).Rows(pos).Item("rnTotal") = TotalUnitario
                JGDetalleReciboInt.SetValue("rnTotal", TotalUnitario)
                Dim estado As Integer = CType(JGDetalleReciboInt.DataSource, DataTable).Rows(pos).Item("estado")
                If (estado = 1) Then
                    CType(JGDetalleReciboInt.DataSource, DataTable).Rows(pos).Item("estado") = 2
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
        Dim res As Boolean = L_fnGrabarReciboInt(txtIdReciboI.Text, _IdInternacion, _IdPaciente, dtpFechaRI.Value, txtTratamiento.Text, txtTotalR.Text, CType(JGDetalleReciboInt.DataSource, DataTable))
        If res Then
            Modificado = False
            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Id del recibo ".ToUpper + txtIdReciboI.Text + " Grabado con Exito.".ToUpper,
                                      img, 3000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )
            txtTratamiento.Focus()
            _prInhabilitar()
            _prFiltrar(2)
            _Limpiar = True
            btnGrabar.Enabled = False
            'Dim info As New TaskDialogInfo("RECIBO".ToUpper, eTaskDialogIcon.Delete, "RECIBO".ToUpper, "¿Desea imprimir el recibo?".ToUpper, eTaskDialogButton.Yes Or eTaskDialogButton.Cancel, eTaskDialogBackgroundColor.Blue)
            'Dim result As eTaskDialogResult = TaskDialog.Show(info)
            'If result = eTaskDialogResult.Yes Then
            '    ' _prImprimir()
            'End If
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "El recibo no pudo ser insertado".ToUpper, img, 2500, eToastGlowColor.Red, eToastPosition.TopCenter)
        End If
        Return res
    End Function
    ''*****MODDIFICA EL REGISTRO*****''
    Public Overrides Function _PMOModificarRegistro() As Boolean
        Dim res As Boolean = L_fnModificarReciboInt(txtIdReciboI.Text, _IdInternacion, _IdPaciente, dtpFechaRI.Value, txtTratamiento.Text, txtTotalR.Text, CType(JGDetalleReciboInt.DataSource, DataTable))
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
            Dim res As Boolean = L_fnEliminarReciboInt(txtIdReciboI.Text, mensajeError)
            If res Then
                Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)

                ToastNotification.Show(Me, "Código del recibo ".ToUpper + txtIdReciboI.Text + " eliminado con Exito.".ToUpper,
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
        If JGDetalleReciboInt.RowCount = 0 Then
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Ingrese un servicio para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        End If

        If txtPropietarioI.Text = String.Empty Then
            txtPropietarioI.BackColor = Color.Red
            MEP.SetError(txtPropietarioI, "Ingrese un propietario!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Ingrese un propietario para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        Else
            txtPropietarioI.BackColor = Color.White
            MEP.SetError(txtPropietarioI, "")
        End If

        If txtPacienteI.Text = String.Empty Then
            txtPacienteI.BackColor = Color.Red
            MEP.SetError(txtPacienteI, "Ingrese un Paciente!".ToUpper)
            _ok = False
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Ingrese paciente para efectuar la grabación".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        Else
            txtPacienteI.BackColor = Color.White
            MEP.SetError(txtPacienteI, "")
        End If
        MHighlighterFocus.UpdateHighlights()
        Return _ok
    End Function
    Public Overrides Sub _PMONuevo()
        'JGBusqRecibosI.Enabled = False 'Deshabilita el buscador de la Grilla
        _prLimpiar()
        _prHabilitar()
    End Sub

    Private Sub MpanelSuperior_Paint(sender As Object, e As PaintEventArgs) Handles MpanelSuperior.Paint

    End Sub

    Public Overrides Sub _PMOModificar()
        'JGBusqRecibosI.Enabled = False 'Deshabilita el buscador de la Grilla
        Dim pos As Integer = JGBusqRecibosI.Row
        '_prVerificar(pos)
        If _prVerificar(pos) = True Then
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "No se puede modificar porque ya se tomó el recibo en Venta o ya esta en Recibo cirugia".ToUpper, img, 3500, eToastGlowColor.Red, eToastPosition.TopCenter)
            btnNuevo.Enabled = True
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
            btnGrabar.Enabled = False
            PanelNavegacion.Enabled = True
            superTabItem2.Enabled = True
        Else
            _prHabilitar()
            _prCargarIconELiminar()
        End If

    End Sub
    Public Sub _prCargarIconELiminar()
        For i As Integer = 0 To CType(JGDetalleReciboInt.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim Bin As New MemoryStream
            Dim img As New Bitmap(My.Resources.delete, 20, 20)
            img.Save(Bin, Imaging.ImageFormat.Png)
            CType(JGDetalleReciboInt.DataSource, DataTable).Rows(i).Item("img") = Bin.GetBuffer
            JGDetalleReciboInt.RootTable.Columns("img").Visible = True
        Next

    End Sub
    Private Sub JGBusqRecibosI_DoubleClick(sender As Object, e As EventArgs) Handles JGBusqRecibosI.DoubleClick
        superTabControl1.SelectedTabIndex = 0
    End Sub

    Private Function _prVerificar(_POS As Integer) As Boolean
        Dim Result As Boolean
        If JGBusqRecibosI.RowCount <> 0 Then
            JGBusqRecibosI.Row = _POS
            With JGBusqRecibosI
                Dim VentaSiNo As Integer = .GetValue("rmEst")

                If VentaSiNo = 2 Or VentaSiNo = 3 Then
                    Result = True
                Else
                    Result = False
                End If

            End With
        End If
        Return Result
    End Function
    Public Overrides Sub _PMOSalir()
        _prInhabilitar()
        _prFiltrar(1)
    End Sub
#End Region
End Class