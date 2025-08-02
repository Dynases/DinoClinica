Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.ToolTips
Imports System.Drawing
Imports DevComponents.DotNetBar.Controls
Imports System.Threading
Imports System.Drawing.Text
Imports Logica.AccesoLogica
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar
Imports System.IO
Imports DevComponents.DotNetBar.SuperGrid
Imports GMap.NET.MapProviders
Imports GMap.NET
Imports GMap.NET.WindowsForms.Markers
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Text


Public Class F0_Cobrar_Cliente

#Region "Variables Globales"
    Dim precio As DataTable
    Public _nameButton As String
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem
    Dim Bin As New MemoryStream
    Dim G_Lote As Boolean = False '1=igual a mostrar las columnas de lote y fecha de Vencimiento
#End Region
#Region "METODOS PRIVADOS"

    Private Sub _IniciarTodo()


        L_prAbrirConexion(gs_Ip, gs_UsuarioSql, gs_ClaveSql, gs_NombreBD)
        'Me.WindowState = FormWindowState.Maximized
        '_prAsignarPermisos()
        Me.Text = "PAGO CLIENTE"
        Dim blah As New Bitmap(New Bitmap(My.Resources.cobro), 20, 20)
        Dim ico As Icon = Icon.FromHandle(blah.GetHicon())
        Me.Icon = ico
        _prCargarTablaPagos(-1)
        tbCodigo.ReadOnly = True

        tbNombre.ReadOnly = True
        tbFechaVenta.Value = Now.Date
        'tbnrocod.Focus()
        tbnrocod.Select()

    End Sub

    Private Sub _Limpiar()
        tbCodigo.Clear()
        tbnrocod.Clear()
        tbFechaVenta.Value = Now.Date
        tbNombre.Clear()
        tbTotalCobrado.Text = 0
        tbTotalCobrar.Text = 0
        tbSaldo.Text = 0
        tbNombre.Clear()

        _prCargarTablaPagos(-1)
        '_prAddDetalle()
        tbnrocod.Focus()



    End Sub
    'Private Sub _prAsignarPermisos()
    '    Dim dtRolUsu As DataTable = L_prRolDetalleGeneral(gi_userRol, _nameButton)
    '    Dim show As Boolean = dtRolUsu.Rows(0).Item("ycshow")
    '    Dim add As Boolean = dtRolUsu.Rows(0).Item("ycadd")
    '    Dim modif As Boolean = dtRolUsu.Rows(0).Item("ycmod")
    '    Dim del As Boolean = dtRolUsu.Rows(0).Item("ycdel")
    '    If add = False Then
    '        btnNuevo.Visible = False
    '    End If
    '    If modif = False Then
    '        btnModificar.Visible = False
    '    End If
    '    If del = False Then
    '        btnEliminar.Visible = False
    '    End If
    'End Sub
    Private Sub _prCargarTablaPagos(_numi As Integer)

        Dim dt As New DataTable
        dt = L_fnObtenerLasVentasCreditoPorCliente(_numi)
        '_prCargarIconDelete(dt)
        gr_detalle.DataSource = dt
        gr_detalle.RetrieveStructure()
        gr_detalle.AlternatingColors = True
        '      ' a.tcnumi, NroDoc,as factura,a.tctv1numi ,a.tcty4clie ,  cliente,a.tcty4vend, vendedor,a.tcfdoc
        ',a.tcfvencre,totalfactura, pendiente, PagoAc, Pagar
        With gr_detalle.RootTable.Columns("factura")
            .Width = 100
            .Visible = False
        End With
        With gr_detalle.RootTable.Columns("tctv1numi")
            .Width = 100
            .Visible = False
        End With
        With gr_detalle.RootTable.Columns("tcty4clie")
            .Width = 100
            .Visible = False
        End With
        With gr_detalle.RootTable.Columns("cliente")
            .Width = 100
            .Visible = False
        End With
        With gr_detalle.RootTable.Columns("pendiente2")
            .Width = 100
            .Visible = False
        End With
        With gr_detalle.RootTable.Columns("tcty4vend")
            .Width = 100
            .Visible = False
        End With
        With gr_detalle.RootTable.Columns("vendedor")
            .Width = 100
            .Visible = False
        End With
        With gr_detalle.RootTable.Columns("pendiente2")
            .Width = 100
            .Visible = False
        End With
        With gr_detalle.RootTable.Columns("tcnumi")
            .Width = 100
            .Visible = False
        End With
        With gr_detalle.RootTable.Columns("NroDoc")
            .Width = 150
            .Visible = True
            .TextAlignment = TextAlignment.Far
            .Caption = "Nro documento"
        End With
        With gr_detalle.RootTable.Columns("paciente")
            .Width = 150
            .Visible = True
            .TextAlignment = TextAlignment.Near
            .Caption = "Paciente"
        End With

        With gr_detalle.RootTable.Columns("tcfdoc")
            .Caption = "Fecha Factura"
            .Width = 120
            .TextAlignment = TextAlignment.Center
            .Visible = True
        End With

        With gr_detalle.RootTable.Columns("tcfvencre")
            .Caption = "Fecha Vencimiento"
            .TextAlignment = TextAlignment.Center
            .Width = 160
            .Visible = False
        End With
        With gr_detalle.RootTable.Columns("totalfactura")
            .Caption = "Monto Total"
            .Width = 180
            .TextAlignment = TextAlignment.Far
            .FormatString = "0.00"
            .AggregateFunction = AggregateFunction.Sum
            .Visible = True
        End With
        With gr_detalle.RootTable.Columns("pendiente")
            .Caption = "Saldo"
            .Width = 180
            .TextAlignment = TextAlignment.Far
            .FormatString = "0.00"
            .AggregateFunction = AggregateFunction.Sum
            .Visible = True
        End With

        With gr_detalle.RootTable.Columns("PagoAc")
            .Caption = "Total Pagado"
            .Width = 180
            .TextAlignment = TextAlignment.Far
            .FormatString = "0.00"
            .AggregateFunction = AggregateFunction.Sum
            .Visible = True
        End With

        With gr_detalle.RootTable.Columns("Pagar")
            .Width = 100
            .Visible = False
            .Caption = "Pagar!"
        End With



        With gr_detalle
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
            .VisualStyle = VisualStyle.Office2007


            .RowHeaders = InheritableBoolean.True
            .TotalRow = InheritableBoolean.True
            .TotalRowFormatStyle.BackColor = Color.Gold
            .TotalRowPosition = TotalRowPosition.BottomFixed
        End With
        _prAplicarCondiccionJanus()
        _prCalcularTotal()
    End Sub
    Private Sub _prCargarDetalleVenta(_IdVenta As String)
        Dim dt As New DataTable
        dt = L_fnMostrarVentaDetalle(_IdVenta)
        JGDetalleVenta.DataSource = dt
        JGDetalleVenta.RetrieveStructure()
        JGDetalleVenta.AlternatingColors = True
        With JGDetalleVenta.RootTable.Columns("vbId")
            .Width = 100
            .Caption = "CODIGO"
            .Visible = False
        End With
        With JGDetalleVenta.RootTable.Columns("vb_vaId")
            .Width = 90
            .Visible = False
        End With
        With JGDetalleVenta.RootTable.Columns("vb_tyfnumi")
            .Width = 80
            .Visible = True
            .Caption = "Id" ''Id Producto
        End With
        With JGDetalleVenta.RootTable.Columns("yfcprod")
            .Caption = "Cod Producto"
            .Width = 100
            .Visible = False
        End With
        With JGDetalleVenta.RootTable.Columns("Producto")
            .Caption = "Producto"
            .Width = 250
            .Visible = True
        End With
        With JGDetalleVenta.RootTable.Columns("vbEst")
            .Caption = "Estado"
            .Width = 100
            .Visible = False
        End With

        With JGDetalleVenta.RootTable.Columns("vbUMin")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
        End With
        With JGDetalleVenta.RootTable.Columns("vbCant")
            .Width = 120
            .Caption = "Cantidad"
            .FormatString = "0"
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
        End With
        With JGDetalleVenta.RootTable.Columns("unidad")
            .Width = 100
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .Caption = "Unidad".ToUpper
        End With
        With JGDetalleVenta.RootTable.Columns("vbPrec")
            .Width = 120
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .FormatString = "0.00"
            .Caption = "Precio U.".ToUpper
        End With
        With JGDetalleVenta.RootTable.Columns("vbPTotal")
            .Width = 110
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .FormatString = "0.00"
            .Caption = "Sub Total".ToUpper
        End With
        With JGDetalleVenta.RootTable.Columns("vbPorc")
            .Width = 100
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .FormatString = "0.00"
            .Caption = "P.Desc(%)".ToUpper
        End With
        With JGDetalleVenta.RootTable.Columns("vbDesc")
            .Width = 100
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .FormatString = "0.00"
            .Caption = "M.Desc".ToUpper
        End With
        With JGDetalleVenta.RootTable.Columns("vbTotDesc")
            .Width = 110
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .FormatString = "0.00"
            .Caption = "Total".ToUpper
        End With
        With JGDetalleVenta.RootTable.Columns("vbObs")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With JGDetalleVenta.RootTable.Columns("vbPCosto")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
        End With
        With JGDetalleVenta.RootTable.Columns("vbPTot2")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
        End With
        With JGDetalleVenta.RootTable.Columns("vbfecha")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With JGDetalleVenta.RootTable.Columns("vbHora")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With JGDetalleVenta.RootTable.Columns("vbUsuario")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With JGDetalleVenta.RootTable.Columns("estado")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With JGDetalleVenta.RootTable.Columns("img")
            .Width = 80
            .Caption = "Eliminar".ToUpper
            .CellStyle.ImageHorizontalAlignment = ImageHorizontalAlignment.Center
            .Visible = False
        End With
        If (G_Lote = True) Then
            With JGDetalleVenta.RootTable.Columns("vbLote")
                .Width = 120
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
                .Visible = False
                .Caption = "LOTE"
            End With
            With JGDetalleVenta.RootTable.Columns("vbFechaVenc")
                .Width = 120
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
                .Visible = False
                .Caption = "FECHA VENC."
                .FormatString = "yyyy/MM/dd"
            End With
        Else
            With JGDetalleVenta.RootTable.Columns("vbLote")
                .Width = 120
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
                .Visible = False
                .Caption = "LOTE"
            End With
            With JGDetalleVenta.RootTable.Columns("vbFechaVenc")
                .Width = 120
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
                .Visible = False
                .Caption = "FECHA VENC."
                .FormatString = "yyyy/MM/dd"
            End With
        End If
        With JGDetalleVenta.RootTable.Columns("stock")
            .Width = 120
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With JGDetalleVenta.RootTable.Columns("vbEst2")
            .Width = 5
            .Visible = False
        End With
        With JGDetalleVenta
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub
    Private Sub P_GenerarReporte(_IdCliente As String, _IdVenta As DataTable)
        Try
            Dim dt As DataTable = L_fnCobranzaRecibo(_IdCliente, _IdVenta)
            Dim total As Double = dt.Compute("SUM(UltimoPago)", "")
            Dim totald As Double = (total / 6.96)
            Dim fechaven As String = dt.Rows(0).Item("tcfdoc")
            If Not IsNothing(P_Global.Visualizador) Then
                P_Global.Visualizador.Close()
            End If
            Dim ParteEntera As Long
            Dim ParteDecimal As Double
            ParteEntera = Int(total)
            ParteDecimal = total - ParteEntera
            Dim li As String = Modelo.ConvertirLiteral.A_fnConvertirLiteral(CDbl(ParteEntera)) + " con " +
        IIf(ParteDecimal.ToString.Equals("0"), "00", ParteDecimal.ToString) + "/100 Bolivianos"

            If (dt.Rows.Count > 0) Then
                If Not IsNothing(P_Global.Visualizador) Then
                    P_Global.Visualizador.Close()
                End If

                P_Global.Visualizador = New Visualizador
                Dim objrep As New R_CreditoPagoTotal
                objrep.Subreports.Item("R_CreditoPago.rpt").SetDataSource(dt)
                objrep.SetDataSource(dt)

                'objrep.SetParameterValue("TotalBs", li)
                objrep.SetParameterValue("TotalBs", li, "R_CreditoPago.rpt")
                objrep.SetParameterValue("TotalBs", li, "R_CreditoPago.rpt - 01")
                objrep.SetParameterValue("usuario", L_Usuario, "R_CreditoPago.rpt")
                objrep.SetParameterValue("usuario", L_Usuario, "R_CreditoPago.rpt - 01")

                P_Global.Visualizador.CrGeneral.ReportSource = objrep 'Comentar
                P_Global.Visualizador.ShowDialog() 'Comentar
                P_Global.Visualizador.BringToFront() 'Comentar
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
    Public Sub _prAplicarCondiccionJanus()
        Dim fc As GridEXFormatCondition
        fc = New GridEXFormatCondition(gr_detalle.RootTable.Columns("pendiente"), ConditionOperator.Equal, 0)
        fc.FormatStyle.BackColor = Color.Green
        gr_detalle.RootTable.FormatConditions.Add(fc)
    End Sub
    Function _prObtenerCodigo() As DataTable
        Dim s As String = ""
        Dim dt As DataTable = L_fnObtenerEncabezadoPago(-1)
        Dim sb As StringBuilder = New StringBuilder()
        Dim tcnumi As Integer = 0
        Dim vbtctv1 As Integer = 0
        For i As Integer = 0 To CType(gr_detalle.DataSource, DataTable).Rows.Count - 1 Step 1
            If CType(gr_detalle.DataSource, DataTable).Rows(i).Item("PagoAc") <> 0 Then
                tcnumi = CType(gr_detalle.DataSource, DataTable).Rows(i).Item("tcnumi")
                vbtctv1 = CType(gr_detalle.DataSource, DataTable).Rows(i).Item("tctv1numi")
                dt.Rows.Add(tcnumi, vbtctv1)
                's = CType(gr_detalle.DataSource, DataTable).Rows(i).Item("tctv1numi").ToString() + "," + s
            End If
        Next
        'sb.Append(s)
        'sb.Length -= 1
        Return dt
    End Function
    Public Sub _prImiprimirNotaPago(IdCliente As String, IdVenta As DataTable)
        Dim ef = New Efecto
        ef.tipo = 2
        ef.Context = "MENSAJE PRINCIPAL".ToUpper
        ef.Header = "¿Desea imprimir la nota de venta?".ToUpper
        ef.ShowDialog()
        Dim bandera As Boolean = False
        bandera = ef.band
        If (bandera = True) Then
            P_GenerarReporte(IdCliente, IdVenta) 'Imprime Directo
        End If
    End Sub
    Private Sub F0_Cobrar_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _IniciarTodo()
    End Sub



    Private Sub Bt1Generar_Click(sender As Object, e As EventArgs) Handles Bt1Generar.Click
        If (tbCodigo.Text <> String.Empty) Then
            tbSaldo.Value = 0
            tbTotalCobrado.Value = 0
            tbTotalCobrar.Value = 0
            _prCargarTablaPagos(tbCodigo.Text)
        End If
    End Sub

    Private Sub gr_detalle_EditingCell(sender As Object, e As EditingCellEventArgs) Handles gr_detalle.EditingCell

        If (e.Column.Index = gr_detalle.RootTable.Columns("PagoAc").Index) Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Public Sub _prSumarTotales()
        Dim dt As DataTable = CType(gr_detalle.DataSource, DataTable)
        Dim Cobrado As Double = 0
        Dim Saldo As Double = 0
        For i As Integer = 0 To dt.Rows.Count - 1
            Cobrado = Cobrado + dt.Rows(i).Item("PagoAc")
            Saldo = Saldo + dt.Rows(i).Item("pendiente")
        Next
        tbTotalCobrado.Value = Cobrado
        tbSaldo.Value = Saldo

    End Sub

    Private Sub gr_detalle_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles gr_detalle.CellValueChanged
        ''Dim rowIndex As Integer = gr_detalle.CurrentRow.RowIndex
        Dim rowIndex As Integer = gr_detalle.Row
        'Columna de Precio Venta
        Dim ob As Boolean = gr_detalle.GetValue("Pagar")


        If (e.Column.Index = gr_detalle.RootTable.Columns("Pagar").Index) Then

            ''''''''ÁQUI VERIFICO EL CHECK DE PAGAR TODO EL SALDO
            'If (ob = True) Then
            '    'pendiente, PagoAc, Pagar
            '    tbTotalCobrado.Value = tbTotalCobrado.Value + gr_detalle.GetValue("pendiente")
            '    tbSaldo.Value = tbSaldo.Value - gr_detalle.GetValue("pendiente")
            '    gr_detalle.SetValue("PagoAc", gr_detalle.GetValue("pendiente"))
            '    gr_detalle.SetValue("pendiente", 0)

            'Else
            '    tbTotalCobrado.Value = tbTotalCobrado.Value - gr_detalle.GetValue("PagoAc")
            '    tbSaldo.Value = tbSaldo.Value + gr_detalle.GetValue("PagoAc")
            '    gr_detalle.SetValue("pendiente", gr_detalle.GetValue("pendiente") + gr_detalle.GetValue("PagoAc"))
            '    gr_detalle.SetValue("PagoAc", 0)
            'End If
            '_prCalcularTotal()
        End If
        ''''''''''''''Aqui se valida por el monto del saldo '''''''''''''''


        If (e.Column.Index = gr_detalle.RootTable.Columns("PagoAc").Index) Then


            If (Not IsNumeric(gr_detalle.GetValue("PagoAc")) Or gr_detalle.GetValue("PagoAc").ToString = String.Empty Or IsDBNull(gr_detalle.GetValue("PagoAc"))) Then

                Dim lin As Integer = gr_detalle.GetValue("tcnumi")
                Dim pos As Integer = -1
                _fnObtenerFilaDetalle(pos, gr_detalle.GetValue("tcnumi"))
                CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("pendiente") = CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("pendiente2")
                CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("PagoAc") = 0
                CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("pagar") = False

                gr_detalle.SetValue("pendiente", gr_detalle.GetValue("pendiente2"))
                gr_detalle.SetValue("pagar", False)
                gr_detalle.SetValue("PagoAc", 0)

                _prSumarTotales()
            Else
                If (gr_detalle.GetValue("PagoAc") >= 0 And gr_detalle.GetValue("PagoAc") <= gr_detalle.GetValue("pendiente2")) Then
                    Dim lin As Integer = gr_detalle.GetValue("tcnumi")
                    Dim pos As Integer = -1
                    _fnObtenerFilaDetalle(pos, gr_detalle.GetValue("tcnumi"))
                    CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("pendiente") = CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("pendiente2") - gr_detalle.GetValue("PagoAc")
                    CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("PagoAc") = gr_detalle.GetValue("PagoAc")
                    gr_detalle.SetValue("pendiente", gr_detalle.GetValue("pendiente2") - gr_detalle.GetValue("PagoAc"))

                    gr_detalle.SetValue("pagar", True)
                    CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("pagar") = True

                    _prSumarTotales()
                Else
                    If (gr_detalle.GetValue("PagoAc") > gr_detalle.GetValue("pendiente2")) Then
                        Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                        ToastNotification.Show(Me, "El monto a pagar es mayor al saldo: " + Str(gr_detalle.GetValue("pendiente2")), img, 5000, eToastGlowColor.Red, eToastPosition.TopCenter)
                        Dim lin As Integer = gr_detalle.GetValue("tcnumi")
                        Dim pos As Integer = -1
                        _fnObtenerFilaDetalle(pos, gr_detalle.GetValue("tcnumi"))
                        CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("pendiente") = CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("pendiente2")
                        CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("PagoAc") = 0

                        'gr_detalle.SetValue("pendiente", gr_detalle.GetValue("pendiente") + gr_detalle.GetValue("PagoAc"))
                        gr_detalle.SetValue("pendiente", gr_detalle.GetValue("pendiente2"))
                        gr_detalle.SetValue("PagoAc", 0)
                        gr_detalle.SetValue("pagar", False)
                        CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("pagar") = True
                        _prSumarTotales()
                    End If
                End If

            End If
        End If

    End Sub

    Public Sub _fnObtenerFilaDetalle(ByRef pos As Integer, numi As Integer)
        For i As Integer = 0 To CType(gr_detalle.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim _numi As Integer = CType(gr_detalle.DataSource, DataTable).Rows(i).Item("tcnumi")
            If (_numi = numi) Then
                pos = i
                Return
            End If
        Next

    End Sub
    Public Sub _prCalcularTotal()


        tbSaldo.Text = gr_detalle.GetTotal(gr_detalle.RootTable.Columns("pendiente"), AggregateFunction.Sum)
        tbTotalCobrar.Text = gr_detalle.GetTotal(gr_detalle.RootTable.Columns("PagoAc"), AggregateFunction.Sum) + gr_detalle.GetTotal(gr_detalle.RootTable.Columns("pendiente"), AggregateFunction.Sum)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        Me.Close()

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        '_tenumi As String, _tefdoc As String, _tety4vend As Integer, _teobs As String, detalle As DataTable
        Dim numi As String = ""
        Dim img2 As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
        If (tbCodigo.Text = String.Empty) Then
            ToastNotification.Show(Me, "No existen datos validos".ToUpper, img2, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
            Return

        End If
        If (CType(gr_detalle.DataSource, DataTable).Rows.Count <= 0) Then
            ToastNotification.Show(Me, "No existen datos validos".ToUpper, img2, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
            Return

        End If
        Dim dtCobro As DataTable = L_fnCobranzasObtenerLosPagos(-1)
        Dim bandera As Boolean = False

        _prInterpretarDatosCobranza(dtCobro, bandera)

        Dim Turno As Integer = 0
        P_DeterminarTurno(Turno)

        If (bandera = False) Then
            ToastNotification.Show(Me, "Seleccione un detalle de la lista de pendientes".ToUpper, img2, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
            Return
        End If
        Dim res As Boolean = L_fnGrabarCobranza2(numi, tbFechaVenta.Value.ToString("yyyy/MM/dd"), 0, "", dtCobro, Turno, gi_userSuc)


        If res Then

            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "El Pago Ha Sido ".ToUpper + " Grabado con Exito.".ToUpper,
                                      img, 2000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )

            _prImiprimirNotaPago(tbnrocod.Text, _prObtenerCodigo)
            _Limpiar()

        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "La Compra no pudo ser insertado".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)

        End If
    End Sub
    Public Function _fnAccesible()
        Return tbFechaVenta.Enabled = True
    End Function
#End Region

#Region "Eventos Formulario"
    Sub _prInterpretarDatosCobranza(ByRef dt As DataTable, ByRef bandera As Boolean)
        '       numidetalle, NroDoc, factura, numiCredito, numiCobranza, A.tctv1numi
        ',a.tcty4clie ,cliente,detalle.tdfechaPago, PagoAc, NumeroRecibo, DescBanco, banco, detalle.tdnrocheque,
        'img,estado,pendiente
        Dim Bin As New MemoryStream
        Dim img As New Bitmap(My.Resources.delete, 28, 28)
        img.Save(Bin, Imaging.ImageFormat.Png)
        Dim dtcobro As DataTable = CType(gr_detalle.DataSource, DataTable)
        For i As Integer = 0 To dtcobro.Rows.Count - 1 Step 1
            Dim pago As Double = dtcobro.Rows(i).Item("PagoAc")
            Dim estado As Boolean = dtcobro.Rows(i).Item("Pagar")
            If (estado = True) Then
                '             td.tdtv12numi ,@tenumi ,td.tdnrodoc ,@newFecha ,td.tdmonto ,td.tdnrorecibo ,td.tdty3banco,
                'td.tdnrocheque, @newFecha  ,@newHora  ,@teuact

                '              a.tcnumi, NroDoc,as factura, a.tctv1numi, a.tcty4clie, cliente, a.tcty4vend, vendedor, a.tcfdoc
                ',a.tcfvencre,totalfactura, pendiente, PagoAc, Pagar
                If (pago > 0) Then
                    dt.Rows.Add(0, dtcobro.Rows(i).Item("tcnumi"), 0, dtcobro.Rows(i).Item("NroDoc"),
                                            Now.Date, pago, 0, dtcobro.Rows(i).Item("tcty4vend"), 0, Now.Date,
                                            "", "", Bin.ToArray, 0)
                    bandera = True
                End If

            End If

        Next
    End Sub


    Private Sub tbnrocod_KeyDown(sender As Object, e As KeyEventArgs) Handles tbnrocod.KeyDown
        If e.KeyData = Keys.Enter Then
            Dim dt As DataTable
            If (tbnrocod.Text = String.Empty) Then
                Return
            End If
            dt = L_fnListarClientesUno(tbnrocod.Text)
            If (Not IsDBNull(dt)) Then
                If (dt.Rows.Count > 0) Then
                    tbCodigo.Text = dt.Rows(0).Item("ydnumi")
                    tbnrocod.Text = dt.Rows(0).Item("ydcod")
                    tbNombre.Text = dt.Rows(0).Item("yddesc")
                    _prCargarTablaPagos(dt.Rows(0).Item("ydnumi"))
                Else
                    Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                    ToastNotification.Show(Me, "Los Datos Del Cliente No Existe en el sistema".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
                    tbCodigo.Clear()
                    tbnrocod.Clear()
                    tbNombre.Clear()

                End If
            Else
                Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                ToastNotification.Show(Me, "Los Datos Del Cliente No Existe en el sistema".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
                tbCodigo.Clear()
                tbnrocod.Clear()
                tbNombre.Clear()
            End If
        End If

        If e.KeyData = Keys.Control + Keys.Enter Then

            Dim dt As DataTable

            dt = L_fnMostrarClientes()
            'caid, caci, canomb, caapell, cadir, catelf, camail, cafecha, cahora, causuario
            Dim listEstCeldas As New List(Of Modelo.Celda)
            listEstCeldas.Add(New Modelo.Celda("caid,", False, "ID", 80))
            listEstCeldas.Add(New Modelo.Celda("caci", True, "CI", 50))
            listEstCeldas.Add(New Modelo.Celda("canomb", True, "NOMBRE", 180))
            listEstCeldas.Add(New Modelo.Celda("caapell", True, "APELLIDO", 280))
            listEstCeldas.Add(New Modelo.Celda("cadir", True, "DIRECCION".ToUpper, 150))
            listEstCeldas.Add(New Modelo.Celda("catelf", True, "TELEFONO", 220))
            listEstCeldas.Add(New Modelo.Celda("camail", True, "E MAIL".ToUpper, 200))
            listEstCeldas.Add(New Modelo.Celda("cafecha", False, "FECHA".ToUpper, 150, "MM/dd,YYYY"))
            listEstCeldas.Add(New Modelo.Celda("cahora,", False, "ID", 50))
            listEstCeldas.Add(New Modelo.Celda("causuario,", False, "ID", 50))
            Dim ef = New Efecto
            ef.tipo = 5
            ef.dt = dt
            ef.SeleclCol = 2
            ef.listEstCeldas = listEstCeldas
            ef.alto = 70
            ef.ancho = 190
            ef.NameLabel = "APELLIDOS:"
            ef.NamelColumna = "caapell"
            ef.Context = "Seleccione Cliente".ToUpper
            ef.ShowDialog()
            Dim bandera As Boolean = False
            bandera = ef.band
            If (bandera = True) Then
                Try
                    Dim Row As Janus.Windows.GridEX.GridEXRow = ef.Row
                    tbCodigo.Text = Row.Cells("caid").Value
                    tbnrocod.Text = Row.Cells("caid").Value
                    tbNombre.Text = Row.Cells("canomb").Value + " " + Row.Cells("caapell").Value
                    _prCargarTablaPagos(Row.Cells("caid").Value)
                Catch ex As Exception

                End Try
            Else
                tbCodigo.Clear()
                tbnrocod.Clear()
                tbNombre.Clear()
                Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                ToastNotification.Show(Me, "Los Datos Del Cliente No Existe en el sistema".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
            End If

        End If


    End Sub

    Private Sub tbnrocod_TextChanged(sender As Object, e As EventArgs) Handles tbnrocod.TextChanged
        If (tbnrocod.Text = String.Empty) Then
            tbCodigo.Clear()
            tbNombre.Clear()
            _prCargarTablaPagos(-1)
        End If
    End Sub

    Private Sub gr_detalle_CellEdited(sender As Object, e As ColumnActionEventArgs) Handles gr_detalle.CellEdited

        'tbTotalCobrado.Value = (gr_detalle.GetTotal(gr_detalle.RootTable.Columns("PagoAc"), AggregateFunction.Sum))
        'tbSaldo.Value = (gr_detalle.GetTotal(gr_detalle.RootTable.Columns("pendiente"), AggregateFunction.Sum))
    End Sub

    Private Sub gr_detalle_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles gr_detalle.CellUpdated

        'tbTotalCobrado.Value = (gr_detalle.GetTotal(gr_detalle.RootTable.Columns("PagoAc"), AggregateFunction.Sum))
        'tbSaldo.Value = (gr_detalle.GetTotal(gr_detalle.RootTable.Columns("pendiente"), AggregateFunction.Sum))
    End Sub

    Private Sub gr_detalle_KeyDown(sender As Object, e As KeyEventArgs) Handles gr_detalle.KeyDown
        Try
            If (Not _fnAccesible()) Then
                Return
            End If
            If (e.KeyData = Keys.Control + Keys.Enter And gr_detalle.Row >= 0) Then
                ' Dim indexfil As Integer = JGDetalleVenta.Row
                ' Dim indexcol As Integer = JGDetalleVenta.Col
                _HabilitarDetalleVenta()
            End If
            If (e.KeyData = Keys.Escape And JGDetalleVenta.Row >= 0) Then
                '_prEliminarFila()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ("Consulte con el administrador del sistema"))
        End Try
    End Sub
    Private Sub _HabilitarDetalleVenta()
        gpDetalleVenta.Visible = True
        gpDetalleVenta.Height = 172
        _prCargarDetalleVenta(gr_detalle.GetValue("tctv1numi").ToString())
        JGDetalleVenta.Focus()
    End Sub
    Private Sub _prEliminarDetalleVenta()
        CType(JGDetalleVenta.DataSource, DataTable).Rows.Clear()
        gpDetalleVenta.Visible = False
        gpDetalleVenta.Height = 40
    End Sub

    Private Sub JGDetalleVenta_KeyDown(sender As Object, e As KeyEventArgs) Handles JGDetalleVenta.KeyDown
        Try
            If (Not _fnAccesible()) Then
                Return
            End If
            If (e.KeyData = Keys.Escape And JGDetalleVenta.Row >= 0) Then
                _prEliminarDetalleVenta()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ("Consulte con el administrador del sistema"))
        End Try
    End Sub

    Private Sub F0_Cobrar_Cliente_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        _prCambiarColorPlomoOscuro(Presentacion.Principal.btnPagosCliente)
    End Sub
#End Region



End Class