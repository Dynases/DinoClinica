Imports Logica.AccesoLogica
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar
Imports System.IO
Imports System.Drawing
Imports DevComponents.DotNetBar.Controls
Imports System.Threading
Imports System.Drawing.Text
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Drawing.Printing
Imports CrystalDecisions.Shared
Imports System.Math
Imports Modelo
Imports Facturacion

Public Class F1_Ven_Proforma
#Region "Variables Globales"
    Public _MPos As Integer
    Dim _CodCliente As Integer = 0
    Dim _CodEmpleado As Integer '= 2076 'definido por defecto el primer vendedor
    Dim _CodPaciente As Integer = 0
    Dim OcultarFact As Integer = 0
    Dim _codeBar As Integer = 1
    Dim _dias As Integer = 0
    Public _nameButton As String
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem
    Dim FilaSelectLote As DataRow = Nothing
    Dim Table_Producto As DataTable
    Dim G_Lote As Boolean = False '1=igual a mostrar las columnas de lote y fecha de Vencimiento
    Dim _tablaDetalle As DataTable
    Dim _tablaDetalle2 As DataTable
#End Region
#Region "Eventos"
    Private Sub F1_Ven_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
        superTabControl1.SelectedTabIndex = 0

    End Sub
    'Primero
    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        If grVentas.RowCount > 0 Then
            _MPos = 0
            _prMostrarRegistro(_MPos)
        End If
    End Sub
    'Anterior
    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If _MPos > 0 And grVentas.RowCount > 0 Then
            _MPos = _MPos - 1
            _prMostrarRegistro(_MPos)
        End If
    End Sub
    'Seguiente
    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If _MPos < grVentas.RowCount - 1 Then
            _MPos = _MPos + 1
            _prMostrarRegistro(_MPos)
        End If
    End Sub
    'Ultimo
    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        If grVentas.RowCount > 0 Then
            _MPos = grVentas.RowCount - 1
            _prMostrarRegistro(_MPos)
        End If
    End Sub
    'Seleccion Grilla Venta
    Private Sub grVentas_SelectionChanged(sender As Object, e As EventArgs) Handles grVentas.SelectionChanged
        If grVentas.Row >= 0 And grVentas.RowCount >= 0 Then
            '_MPos = JGBusqRecibos.Row
            _prMostrarRegistro(grVentas.Row)
        End If
    End Sub
    'Seleccionar Cliente

    Private Sub txtIdCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdCliente.KeyDown
        If (_fnAccesible()) Then
            If e.KeyData = Keys.Control + Keys.Enter Then
                Dim dt As DataTable
                dt = L_fnMostrarClientes()
                'caid, caci, canomb, caapell, cadir, catelf, camail, cafecha, cahora, causuario
                Dim listEstCeldas As New List(Of Modelo.Celda)
                listEstCeldas.Add(New Modelo.Celda("caid,", False, "ID", 50))
                listEstCeldas.Add(New Modelo.Celda("caci", True, "CI", 80))
                listEstCeldas.Add(New Modelo.Celda("canomb", True, "NOMBRE", 180))
                listEstCeldas.Add(New Modelo.Celda("caapell", True, "APELLIDO", 280))
                listEstCeldas.Add(New Modelo.Celda("cadir", True, "DIRECCION".ToUpper, 150))
                listEstCeldas.Add(New Modelo.Celda("catelf", True, "TELEFONO", 220))
                listEstCeldas.Add(New Modelo.Celda("camail", True, "E MAIL".ToUpper, 200))
                listEstCeldas.Add(New Modelo.Celda("cafecha", False, "FECHA".ToUpper, 150, "MM/dd,YYYY"))
                listEstCeldas.Add(New Modelo.Celda("cahora,", False, "ID", 50))
                listEstCeldas.Add(New Modelo.Celda("cafechanac,", False, "ID", 50))
                listEstCeldas.Add(New Modelo.Celda("causuario,", False, "ID", 50))
                Dim ef = New Efecto
                ef.tipo = 3
                ef.dt = dt
                ef.SeleclCol = 2
                ef.listEstCeldas = listEstCeldas
                ef.alto = 50
                ef.ancho = 280
                ef.Context = "Seleccione Cliente".ToUpper
                ef.ShowDialog()
                Dim bandera As Boolean = False
                bandera = ef.band
                If (bandera = True) Then
                    Dim Row As Janus.Windows.GridEX.GridEXRow = ef.Row
                    If (IsNothing(Row)) Then
                        txtIdCliente.Focus()
                        Return
                    End If
                    _CodCliente = Row.Cells("caid").Value
                    _CodPaciente = Row.Cells("caid").Value
                    txtIdCliente.Text = Row.Cells("caid").Value
                    txtCliente.Text = Row.Cells("canomb").Value + " " + Row.Cells("caapell").Value
                    txtIdPaciente.Select()
                End If
            End If
        End If
    End Sub
    Private Sub txtIdPaciente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdPaciente.KeyDown
        If (_fnAccesible()) Then
            If e.KeyData = Keys.Control + Keys.Enter Then
                If (_CodCliente <= 0) Then
                    Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                    ToastNotification.Show(Me, "Por Favor Seleccione un Cliente con Ctrl+Enter".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
                    txtIdCliente.Focus()
                    Return

                End If
                Dim dt As DataTable
                dt = L_fnMostrarPaciente(txtIdCliente.Text)
                If dt.Rows.Count <> 0 Then
                    'Pac.pbid, Pac.pb_caid,Cli.canomb + ' '+ cli.caapell as cacliente, Pac.pbnomb, 
                    'Pac.pbespec, lib1.lbdesc As Especie, Pac.pbfnac, Pac.pbraza, lib2.lbdesc As Raza, Pac.pbsex,
                    'Pac.pbcolor, Pac.pbester, Pac.pbdest, Pac.pbseñas, Pac.pbfingr, Pac.pbest - -PASCIENTE
                    Dim listEstCeldas As New List(Of Modelo.Celda)
                    listEstCeldas.Add(New Modelo.Celda("pbid,", False, "ID", 50))
                    listEstCeldas.Add(New Modelo.Celda("pb_caid", False, "pbest", 50))
                    listEstCeldas.Add(New Modelo.Celda("cacliente", True, "CLIENTE", 150))
                    listEstCeldas.Add(New Modelo.Celda("pbnomb", True, "PACIENTE", 150))
                    listEstCeldas.Add(New Modelo.Celda("pbespec", False, "ESPECIE".ToUpper, 150))
                    listEstCeldas.Add(New Modelo.Celda("Especie", True, "ESPECIE", 220))
                    listEstCeldas.Add(New Modelo.Celda("pbfnac", False, "pbfnac", 220))
                    listEstCeldas.Add(New Modelo.Celda("pbraza", False, "E MAIL".ToUpper, 200))
                    listEstCeldas.Add(New Modelo.Celda("Raza", False, "RAZA", 120))
                    listEstCeldas.Add(New Modelo.Celda("pbsex,", True, "SEXO", 100))
                    listEstCeldas.Add(New Modelo.Celda("pbcolor,", True, "COLOR", 120))
                    listEstCeldas.Add(New Modelo.Celda("pbester,", False, "Esterilacion", 50))
                    listEstCeldas.Add(New Modelo.Celda("pbdest,", False, "ID", 50))
                    listEstCeldas.Add(New Modelo.Celda("pbseñas,", False, "ID", 50))
                    listEstCeldas.Add(New Modelo.Celda("pbfingr,", False, "ID", 50))
                    listEstCeldas.Add(New Modelo.Celda("pbest,", False, "ID", 50))
                    listEstCeldas.Add(New Modelo.Celda("pbhora,", False, "ID", 50))
                    listEstCeldas.Add(New Modelo.Celda("pbusuario,", False, "ID", 50))
                    Dim ef = New Efecto
                    ef.tipo = 3
                    ef.dt = dt
                    ef.SeleclCol = 2
                    ef.listEstCeldas = listEstCeldas
                    ef.alto = 70
                    ef.ancho = 310
                    ef.Context = "Seleccione un Paciente".ToUpper
                    ef.ShowDialog()
                    Dim bandera As Boolean = False
                    bandera = ef.band
                    If (bandera = True) Then
                        Dim Row As Janus.Windows.GridEX.GridEXRow = ef.Row
                        If (IsNothing(Row)) Then
                            txtIdCliente.Focus()
                            Return
                        End If
                        _CodPaciente = Row.Cells("pbid").Value
                        txtIdPaciente.Text = Row.Cells("pbid").Value
                        txtPaciente.Text = Row.Cells("pbnomb").Value
                        txtIdVendedor.Focus()
                    End If
                End If
            End If

        End If
    End Sub
    'Seleccionar Empleado
    Private Sub txtIdVendedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdVendedor.KeyDown
        If btnNuevo.Enabled = False Then
            If e.KeyData = Keys.Control + Keys.Enter Then
                Dim dt As DataTable
                dt = L_fnMostrarEmpleadoVendedor()
                Dim listEstCeldas As New List(Of Modelo.Celda)
                listEstCeldas.Add(New Modelo.Celda("ecId,", True, "ID", 50))
                listEstCeldas.Add(New Modelo.Celda("ecNomb", True, "Nombre", 180))
                listEstCeldas.Add(New Modelo.Celda("ec_lbIdLib", False, "ec_lbIdLib", 180))
                listEstCeldas.Add(New Modelo.Celda("lbdesc", True, "Tipo de Empleado", 180))
                listEstCeldas.Add(New Modelo.Celda("ecCi", True, "N. Documento", 100))
                listEstCeldas.Add(New Modelo.Celda("ecDir", False, "Direccion", 180))
                listEstCeldas.Add(New Modelo.Celda("ecTelf", True, "Teléfono", 180))
                listEstCeldas.Add(New Modelo.Celda("ecMail", False, "ecMail", 180))
                listEstCeldas.Add(New Modelo.Celda("ecEst", False, "ecEst".ToUpper, 150))
                listEstCeldas.Add(New Modelo.Celda("Estado", True, "Estado", 150))
                listEstCeldas.Add(New Modelo.Celda("ecFNac", False, "F. de Nacimiento", 150))
                listEstCeldas.Add(New Modelo.Celda("ecFIngr", False, "F. de Ingreso".ToUpper, 150))
                listEstCeldas.Add(New Modelo.Celda("ecImg", False, "ecImg".ToUpper, 150))
                listEstCeldas.Add(New Modelo.Celda("ecFecha", False, "ecImg".ToUpper, 150))
                listEstCeldas.Add(New Modelo.Celda("ecHora", False, "ecImg".ToUpper, 150))
                listEstCeldas.Add(New Modelo.Celda("ecUsuario", False, "ecImg".ToUpper, 150))
                Dim ef = New Efecto
                ef.tipo = 3
                ef.dt = dt
                ef.SeleclCol = 2
                ef.listEstCeldas = listEstCeldas
                ef.alto = 50
                ef.ancho = 350
                ef.Context = "Seleccione Empleado".ToUpper
                ef.ShowDialog()
                Dim bandera As Boolean = False
                bandera = ef.band
                If (bandera = True) Then
                    Dim Row As Janus.Windows.GridEX.GridEXRow = ef.Row
                    If (IsNothing(Row)) Then
                        txtIdVendedor.Focus()
                        Return
                    End If
                    txtIdVendedor.Text = Row.Cells("ecId").Value
                    txtVendedor.Text = Row.Cells("ecNomb").Value
                    _CodEmpleado = Row.Cells("ecId").Value
                    JGdetalleVenta.Select()
                    JGdetalleVenta.Col = 3
                    JGdetalleVenta.Row = JGdetalleVenta.RowCount - 1
                End If
            End If
        End If
    End Sub


    'Celdas que se podran Modificar
    Private Sub JGdetalleVenta_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGdetalleVenta.EditingCell
        If (_fnAccesible()) Then
            If (e.Column.Index = JGdetalleVenta.RootTable.Columns("vbCant").Index Or
                e.Column.Index = JGdetalleVenta.RootTable.Columns("vbPorc").Index Or
                e.Column.Index = JGdetalleVenta.RootTable.Columns("vbDesc").Index) Then
                If JGdetalleVenta.GetValue("vbEst2").ToString = 0 Then
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
    End Sub
    'Evento Enter
    Private Sub JGdetalleVenta_Enter(sender As Object, e As EventArgs) Handles JGdetalleVenta.Enter
        If (_fnAccesible()) Then
            If (_CodCliente <= 0) Then
                ToastNotification.Show(Me, "           Antes de Continuar Por favor Seleccione un Cliente!!             ", My.Resources.WARNING, 4000, eToastGlowColor.Red, eToastPosition.TopCenter)
                txtIdCliente.Focus()
                Return
            End If
            If (_CodEmpleado <= 0) Then
                ToastNotification.Show(Me, "           Antes de Continuar Por favor Seleccione un Vendedor!!             ", My.Resources.WARNING, 4000, eToastGlowColor.Red, eToastPosition.TopCenter)
                txtIdVendedor.Focus()
                Return
            End If
            'JGdetalleVenta.Select()
            If _codeBar = 1 Then
                If gb_CodigoBarra Then
                    JGdetalleVenta.Col = 3
                    JGdetalleVenta.Row = 0
                Else
                    JGdetalleVenta.Col = 5
                    JGdetalleVenta.Row = 0
                End If
            End If
        End If
    End Sub
    'Evento KeyDown Precionar combinacion de teclas
    Private Sub JGdetalleVenta_KeyDown(sender As Object, e As KeyEventArgs) Handles JGdetalleVenta.KeyDown
        Try
            If (Not _fnAccesible()) Then
                Return
            End If
            If (e.KeyData = Keys.Enter) Then
                Dim f, c As Integer
                c = JGdetalleVenta.Col
                f = JGdetalleVenta.Row
                If (JGdetalleVenta.Col = JGdetalleVenta.RootTable.Columns("vbCant").Index) Then
                    If (JGdetalleVenta.GetValue("producto") <> String.Empty) Then
                        _prAddDetalleVenta(0)
                        _HabilitarProductos()
                    Else
                        ToastNotification.Show(Me, "Seleccione un Producto Por Favor", My.Resources.WARNING, 3000, eToastGlowColor.Red, eToastPosition.TopCenter)
                    End If
                End If
                If (JGdetalleVenta.Col = JGdetalleVenta.RootTable.Columns("producto").Index) Then
                    If (JGdetalleVenta.GetValue("producto") <> String.Empty) Then
                        _prAddDetalleVenta(0)
                        _HabilitarProductos()
                    Else
                        ToastNotification.Show(Me, "Seleccione un Producto Por Favor", My.Resources.WARNING, 3000, eToastGlowColor.Red, eToastPosition.TopCenter)
                    End If
                End If
salirIf:
            End If

            If (e.KeyData = Keys.Control + Keys.Enter And JGdetalleVenta.Row >= 0 And
                JGdetalleVenta.Col = JGdetalleVenta.RootTable.Columns("producto").Index) Then
                Dim indexfil As Integer = JGdetalleVenta.Row
                Dim indexcol As Integer = JGdetalleVenta.Col
                _HabilitarProductos()
            End If
            If (e.KeyData = Keys.Escape And JGdetalleVenta.Row >= 0) Then
                _prEliminarFila()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ("Consulte con el administrador del sistema"))
        End Try
    End Sub
    'Evento Click
    Private Sub JGdetalleVenta_MouseClick(sender As Object, e As MouseEventArgs) Handles JGdetalleVenta.MouseClick
        Try
            If (Not _fnAccesible()) Then
                Return
            End If
            If (JGdetalleVenta.RowCount >= 2) Then
                If (JGdetalleVenta.CurrentColumn.Index = JGdetalleVenta.RootTable.Columns("img").Index) Then
                    _prEliminarFila()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Consulte con el administrador del sistema")
        End Try
    End Sub
    'Evento CellEdited

    Private Sub JGdetalleVenta_CellEdited(sender As Object, e As ColumnActionEventArgs) Handles JGdetalleVenta.CellEdited
        Try
            If (e.Column.Index = JGdetalleVenta.RootTable.Columns("vbCant").Index) Then
                If (Not IsNumeric(JGdetalleVenta.GetValue("vbCant")) Or JGdetalleVenta.GetValue("vbCant").ToString = String.Empty) Then
                    JGdetalleVenta.SetValue("vbCant", 1)
                    JGdetalleVenta.SetValue("vbPTotal", JGdetalleVenta.GetValue("vbPrec"))
                    JGdetalleVenta.SetValue("vbPorc", 0)
                    JGdetalleVenta.SetValue("vbDesc", 0)
                    JGdetalleVenta.SetValue("vbTotDesc", JGdetalleVenta.GetValue("vbPrec"))
                Else
                    If (JGdetalleVenta.GetValue("vbCant") > 0) Then
                        Dim cant As Integer = JGdetalleVenta.GetValue("vbCant")
                        Dim stock As Integer = JGdetalleVenta.GetValue("stock")
                        'If (cant > stock) Then
                        '    Dim lin As Integer = JGdetalleVenta.GetValue("vbId")
                        '    Dim pos As Integer = -1
                        '    _fnObtenerFilaDetalle(pos, lin)
                        '    CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbCant") = 1
                        '    CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPTotal") = CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPrec")
                        '    CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPTot2") = JGdetalleVenta.GetValue("vbPCosto") * 1
                        '    CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbTotDesc") = CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPrec") * 1
                        '    Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                        '    ToastNotification.Show(Me, "La cantidad de la venta no debe ser mayor al del stock".ToUpper & vbCrLf &
                        '    "Stock=".ToUpper + Str(stock) + " . Primero debe hacer regularizar el inventario".ToUpper, img, 6000, eToastGlowColor.Red, eToastPosition.TopCenter)
                        '    JGdetalleVenta.SetValue("vbCant", 1)
                        '    JGdetalleVenta.SetValue("vbPTotal", JGdetalleVenta.GetValue("vbPrec"))
                        '    JGdetalleVenta.SetValue("vbPTot2", JGdetalleVenta.GetValue("vbPCosto") * 1)
                        '    JGdetalleVenta.SetValue("vbTotDesc", JGdetalleVenta.GetValue("vbPrec") * 1)

                        '    _prCalcularPrecioTotal()
                        'Else
                        If (cant = stock) Then
                                'JGdetalleVenta.SelectedFormatStyle.ForeColor = Color.Blue
                                'JGdetalleVenta.CurrentRow.Cells.Item(e.Column).FormatStyle = New GridEXFormatStyle
                                'JGdetalleVenta.CurrentRow.Cells(e.Column).FormatStyle.BackColor = Color.Pink
                                'JGdetalleVenta.CurrentRow.Cells.Item(e.Column).FormatStyle.BackColor = Color.DodgerBlue
                                'JGdetalleVenta.CurrentRow.Cells.Item(e.Column).FormatStyle.ForeColor = Color.White
                                'JGdetalleVenta.CurrentRow.Cells.Item(e.Column).FormatStyle.FontBold = TriState.True
                            End If
                        End If

                    'Else

                    '    JGdetalleVenta.SetValue("vbCant", 1)
                    '    JGdetalleVenta.SetValue("vbPTotal", JGdetalleVenta.GetValue("vbPrec"))
                    '    JGdetalleVenta.SetValue("vbPorc", 0)
                    '    JGdetalleVenta.SetValue("vbDesc", 0)
                    '    JGdetalleVenta.SetValue("vbTotDesc", JGdetalleVenta.GetValue("vbPrec"))

                    'End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Consulte con el administrador del sistema")
        End Try
    End Sub
    'Evento CellValueChanged, cambios en una celda
    Private Sub JGdetalleVenta_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles JGdetalleVenta.CellValueChanged
        Try
            If (e.Column.Index = JGdetalleVenta.RootTable.Columns("vbCant").Index) Or (e.Column.Index = JGdetalleVenta.RootTable.Columns("vbPrec").Index) Then

                If (Not IsNumeric(JGdetalleVenta.GetValue("vbCant")) Or JGdetalleVenta.GetValue("vbCant").ToString = String.Empty) Then

                    'grDetalle.GetRow(rowIndex).Cells("cant").Value = 1
                    '  grDetalle.CurrentRow.Cells.Item("cant").Value = 1
                    Dim lin As Integer = JGdetalleVenta.GetValue("vbId")
                    Dim pos As Integer = -1
                    _fnObtenerFilaDetalle(pos, lin)
                    CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbCant") = 1
                    CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPTotal") = CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPrec")

                    CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPorc") = 0
                    CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbDesc") = 0
                    CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbTotDesc") = CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPrec") * 1
                    'JGdetalleVenta.SetValue("vbCant", 1)
                    'JGdetalleVenta.SetValue("vbPTotal", JGdetalleVenta.GetValue("vbPrec"))
                Else
                    If (JGdetalleVenta.GetValue("vbCant") > 0) Then
                        Dim rowIndex As Integer = JGdetalleVenta.Row
                        Dim porcdesc As Double = JGdetalleVenta.GetValue("vbPorc")
                        Dim montodesc As Double = ((JGdetalleVenta.GetValue("vbPrec") * JGdetalleVenta.GetValue("vbCant")) * (porcdesc / 100))
                        Dim lin As Integer = JGdetalleVenta.GetValue("vbId")
                        Dim pos As Integer = -1
                        _fnObtenerFilaDetalle(pos, lin)
                        CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbDesc") = montodesc
                        JGdetalleVenta.SetValue("vbDesc", montodesc)
                        P_PonerTotal(rowIndex)

                    Else
                        Dim lin As Integer = JGdetalleVenta.GetValue("vbId")
                        Dim pos As Integer = -1
                        _fnObtenerFilaDetalle(pos, lin)
                        CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbCant") = 1
                        CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPTotal") = CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPrec")
                        CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbTotDesc") = CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPrec") * 1
                        _prCalcularPrecioTotal()
                        'JGdetalleVenta.SetValue("vbCant", 1)
                        'JGdetalleVenta.SetValue("vbPTotal", JGdetalleVenta.GetValue("vbPrec"))

                    End If
                End If
            End If
            '''''''''''''''''''''PORCENTAJE DE DESCUENTO '''''''''''''''''''''
            If (e.Column.Index = JGdetalleVenta.RootTable.Columns("vbPorc").Index) Then
                If (Not IsNumeric(JGdetalleVenta.GetValue("vbPorc")) Or JGdetalleVenta.GetValue("vbPorc").ToString = String.Empty) Then

                    'grDetalle.GetRow(rowIndex).Cells("cant").Value = 1
                    '  grDetalle.CurrentRow.Cells.Item("cant").Value = 1
                    Dim lin As Integer = JGdetalleVenta.GetValue("vbId")
                    Dim pos As Integer = -1
                    _fnObtenerFilaDetalle(pos, lin)
                    CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPorc") = 0
                    CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbDesc") = 0
                    CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbTotDesc") = CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPTotal")
                    'JGdetalleVenta.SetValue("vbCant", 1)
                    'JGdetalleVenta.SetValue("vbPTotal", JGdetalleVenta.GetValue("vbPrec"))
                Else
                    If (JGdetalleVenta.GetValue("vbPorc") > 0 And JGdetalleVenta.GetValue("vbPorc") <= 100) Then

                        Dim porcdesc As Double = JGdetalleVenta.GetValue("vbPorc")
                        Dim montodesc As Double = (JGdetalleVenta.GetValue("vbPTotal") * (porcdesc / 100))
                        Dim lin As Integer = JGdetalleVenta.GetValue("vbId")
                        Dim pos As Integer = -1
                        _fnObtenerFilaDetalle(pos, lin)
                        CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbDesc") = montodesc
                        JGdetalleVenta.SetValue("vbDesc", montodesc)

                        Dim rowIndex As Integer = JGdetalleVenta.Row
                        P_PonerTotal(rowIndex)

                    Else
                        Dim lin As Integer = JGdetalleVenta.GetValue("vbId")
                        Dim pos As Integer = -1
                        _fnObtenerFilaDetalle(pos, lin)
                        CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPorc") = 0
                        CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbDesc") = 0
                        CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbTotDesc") = CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPTotal")
                        JGdetalleVenta.SetValue("vbPorc", 0)
                        JGdetalleVenta.SetValue("vbDesc", 0)
                        JGdetalleVenta.SetValue("vbTotDesc", JGdetalleVenta.GetValue("vbPTotal"))
                        _prCalcularPrecioTotal()
                        'JGdetalleVenta.SetValue("vbCant", 1)
                        'JGdetalleVenta.SetValue("vbPTotal", JGdetalleVenta.GetValue("vbPrec"))

                    End If
                End If
            End If


            '''''''''''''''''''''MONTO DE DESCUENTO '''''''''''''''''''''
            If (e.Column.Index = JGdetalleVenta.RootTable.Columns("vbDesc").Index) Then
                If (Not IsNumeric(JGdetalleVenta.GetValue("vbDesc")) Or JGdetalleVenta.GetValue("vbDesc").ToString = String.Empty) Then

                    'grDetalle.GetRow(rowIndex).Cells("cant").Value = 1
                    '  grDetalle.CurrentRow.Cells.Item("cant").Value = 1
                    Dim lin As Integer = JGdetalleVenta.GetValue("vbId")
                    Dim pos As Integer = -1
                    _fnObtenerFilaDetalle(pos, lin)
                    CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPorc") = 0
                    CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbDesc") = 0
                    CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbTotDesc") = CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPTotal")
                    'JGdetalleVenta.SetValue("vbCant", 1)
                    'JGdetalleVenta.SetValue("vbPTotal", JGdetalleVenta.GetValue("vbPrec"))
                Else
                    If (JGdetalleVenta.GetValue("vbDesc") > 0 And JGdetalleVenta.GetValue("vbDesc") <= JGdetalleVenta.GetValue("vbPTotal")) Then

                        Dim montodesc As Double = JGdetalleVenta.GetValue("vbDesc")
                        Dim pordesc As Double = ((montodesc * 100) / JGdetalleVenta.GetValue("vbPTotal"))

                        Dim lin As Integer = JGdetalleVenta.GetValue("vbId")
                        Dim pos As Integer = -1
                        _fnObtenerFilaDetalle(pos, lin)
                        CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbDesc") = montodesc
                        CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPorc") = pordesc

                        JGdetalleVenta.SetValue("vbPorc", pordesc)
                        Dim rowIndex As Integer = JGdetalleVenta.Row
                        P_PonerTotal(rowIndex)

                    Else
                        Dim lin As Integer = JGdetalleVenta.GetValue("vbId")
                        Dim pos As Integer = -1
                        _fnObtenerFilaDetalle(pos, lin)
                        CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPorc") = 0
                        CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbDesc") = 0
                        CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbTotDesc") = CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPTotal")
                        JGdetalleVenta.SetValue("vbPorc", 0)
                        JGdetalleVenta.SetValue("vbDesc", 0)
                        JGdetalleVenta.SetValue("vbTotDesc", JGdetalleVenta.GetValue("vbPTotal"))
                        _prCalcularPrecioTotal()
                        'JGdetalleVenta.SetValue("vbCant", 1)
                        'JGdetalleVenta.SetValue("vbPTotal", JGdetalleVenta.GetValue("vbPrec"))

                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Consulte con el administrador del sistema")
        End Try
    End Sub

    Private Sub JGProductos_KeyDown(sender As Object, e As KeyEventArgs) Handles JGProductos.KeyDown
        Try
            If (Not _fnAccesible()) Then
                Return
            End If
            If (e.KeyData = Keys.Enter) Then
                Dim f, c As Integer
                c = JGProductos.Col
                f = JGProductos.Row
                If (f >= 0) Then

                    If (IsNothing(FilaSelectLote)) Then
                        ''''''''''''''''''''''''
                        If (G_Lote = True) Then
                            InsertarProductosConLote()
                        Else
                            InsertarProductosSinLote()
                        End If
                        '''''''''''''''
                    Else

                        '_fnExisteProductoConLote()
                        Dim pos As Integer = -1
                        JGdetalleVenta.Row = JGdetalleVenta.RowCount - 1
                        _fnObtenerFilaDetalle(pos, JGdetalleVenta.GetValue("vbId"))
                        Dim numiProd = FilaSelectLote.Item("yfnumi")
                        Dim lote As String = JGProductos.GetValue("iclot")
                        Dim FechaVenc As Date = JGProductos.GetValue("icfven")
                        If (Not _fnExisteProductoConLote(numiProd, lote, FechaVenc)) Then
                            'b.yfcdprod1, a.iclot, a.icfven, a.iccven
                            'CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("tbty5prod") = JGProductos.GetValue("yfnumi")
                            'CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("codigo") = JGProductos.GetValue("yfcprod")
                            'CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("yfcbarra") = JGProductos.GetValue("yfcbarra")
                            'CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("Servicio") = JGProductos.GetValue("yfcdprod1")
                            'CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbCant") = JGProductos.GetValue("yfumin")
                            'CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("unidad") = JGProductos.GetValue("UnidMin")
                            'CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPrec") = JGProductos.GetValue("yhprecio")
                            'CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPTotal") = JGProductos.GetValue("yhprecio")
                            'CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbTotDesc") = JGProductos.GetValue("yhprecio")
                            'CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbCant") = 1

                            CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vb_tyfnumi") = FilaSelectLote.Item("yfnumi")
                            CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("yfcprod") = FilaSelectLote.Item("yfcprod")
                            'CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("yfcbarra") = FilaSelectLote.Item("yfcbarra")
                            CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("producto") = FilaSelectLote.Item("yfcdprod1")
                            CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbUMin") = FilaSelectLote.Item("yfumin")
                            CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("unidad") = FilaSelectLote.Item("UnidMin")
                            CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPrec") = FilaSelectLote.Item("yhprecio")
                            CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPTotal") = FilaSelectLote.Item("yhprecio")
                            CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbTotDesc") = FilaSelectLote.Item("yhprecio")
                            CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbCant") = 1
                            'If (gb_FacturaIncluirICE) Then
                            '    CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPCosto") = FilaSelectLote.Item("pcos")
                            'Else
                            '    CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPCosto") = 0
                            'End If
                            CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPCosto") = FilaSelectLote.Item("pcos")
                            CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPTot2") = FilaSelectLote.Item("pcos")

                            CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbLote") = JGProductos.GetValue("iclot")
                            CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbfechaVenc") = JGProductos.GetValue("icfven")
                            CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("stock") = JGProductos.GetValue("iccven")
                            _prCalcularPrecioTotal()
                            _DesHabilitarProductos()
                            FilaSelectLote = Nothing
                        Else
                            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                            ToastNotification.Show(Me, "El producto con el lote ya existe modifique su cantidad".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
                        End If
                    End If

                End If
            End If
            If e.KeyData = Keys.Escape Then
                _DesHabilitarProductos()
                FilaSelectLote = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Consulte con el administrador del sistema")
        End Try
    End Sub

    Private Sub txtIdReciboV_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdReciboV.KeyDown
        Try
            If (_fnAccesible()) Then
                If e.KeyData = Keys.Control + Keys.Enter Then
                    Dim dt As DataTable
                    If swServicio.Value Then
                        dt = L_fnMostrarVentaRecibo()
                    End If
                    If swInternacion.Value Then
                        dt = L_fnMostrarVentaReciboInternacion()

                    End If
                    If swCirugia.Value Then
                        dt = L_fnMostrarVentaReciboCirugia()
                    End If
                    Dim listEstCeldas As New List(Of Modelo.Celda)
                    listEstCeldas.Add(New Modelo.Celda("Id", True, "ID", 120))
                    listEstCeldas.Add(New Modelo.Celda("Fecha", True, "FECHA", 120, "dd/MM/yyyy"))
                    listEstCeldas.Add(New Modelo.Celda("IdCliente", False, "", 50))
                    listEstCeldas.Add(New Modelo.Celda("Cliente", True, "CLIENTE".ToUpper, 150))
                    listEstCeldas.Add(New Modelo.Celda("IdPaciente", False, "IDPACIENTE".ToUpper, 150))
                    listEstCeldas.Add(New Modelo.Celda("Paciente", True, "PACIENTE".ToUpper, 150))
                    listEstCeldas.Add(New Modelo.Celda("Observacion", True, "OBSERVACION".ToUpper, 120))
                    listEstCeldas.Add(New Modelo.Celda("Total", True, "TOTAL".ToUpper, 120))

                    Dim ef = New Efecto
                    ef.tipo = 3
                    ef.dt = dt
                    ef.SeleclCol = 2
                    ef.listEstCeldas = listEstCeldas
                    ef.alto = 50
                    ef.ancho = 255
                    ef.Context = "Seleccione Recibo".ToUpper
                    If ef.dt.Rows.Count = 0 Then
                        Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                        ToastNotification.Show(Me, "No existen Recibos Pendientes para la Cobranza".ToUpper, img, 3000, eToastGlowColor.Red, eToastPosition.TopCenter)
                        Exit Sub
                    Else

                        ef.ShowDialog()
                        Dim bandera As Boolean = False
                        bandera = ef.band
                        If (bandera = True) Then
                            Dim Row As Janus.Windows.GridEX.GridEXRow = ef.Row
                            _CodCliente = Row.Cells("IdCliente").Value
                            _CodPaciente = Row.Cells("IdPaciente").Value
                            txtIdPaciente.Text = Row.Cells("IdPaciente").Value
                            txtPaciente.Text = Row.Cells("Paciente").Value
                            txtIdCliente.Text = Row.Cells("IdCliente").Value
                            txtCliente.Text = Row.Cells("cliente").Value
                            txtIdReciboV.Text = Row.Cells("Id").Value
                            _prCargarProductoDeRecibo(Row.Cells("Id").Value)
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Consulte con el administrador del sistema")
        End Try
    End Sub

    Private Sub swServicio_ValueChanged(sender As Object, e As EventArgs) Handles swServicio.ValueChanged
        Try
            If (_fnAccesible()) Then
                If (swServicio.Value = True) Then
                    swCirugia.Value = False
                    swInternacion.Value = False
                    txtIdReciboV.BackColor = Color.White
                    txtIdReciboV.ReadOnly = True
                    txtIdReciboV.Enabled = True
                    txtIdReciboV.Focus()
                Else
                    txtIdReciboV.BackColor = Color.LightGray
                    txtIdReciboV.ReadOnly = True
                    txtIdReciboV.Enabled = False
                    txtIdReciboV.Clear()
                    txtIdPaciente.Clear()
                    txtPaciente.Clear()
                    txtIdCliente.Clear()
                    txtCliente.Clear()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Consulte con el administrador del sistema")
        End Try
    End Sub
    Private Sub swInternacion_ValueChanged(sender As Object, e As EventArgs) Handles swInternacion.ValueChanged
        Try
            If (_fnAccesible()) Then
                If (swInternacion.Value = True) Then
                    swServicio.Value = False
                    swCirugia.Value = False
                    txtIdReciboV.BackColor = Color.White
                    txtIdReciboV.ReadOnly = True
                    txtIdReciboV.Enabled = True
                    txtIdReciboV.Focus()
                Else
                    txtIdReciboV.BackColor = Color.LightGray
                    txtIdReciboV.ReadOnly = True
                    txtIdReciboV.Enabled = False
                    txtIdReciboV.Clear()
                    txtIdPaciente.Clear()
                    txtPaciente.Clear()
                    txtIdCliente.Clear()
                    txtCliente.Clear()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Consulte con el administrador del sistema")
        End Try
    End Sub

    Private Sub swCirugia_ValueChanged(sender As Object, e As EventArgs) Handles swCirugia.ValueChanged
        Try
            If (_fnAccesible()) Then
                If (swCirugia.Value = True) Then
                    swServicio.Value = False
                    swInternacion.Value = False
                    txtIdReciboV.BackColor = Color.White
                    txtIdReciboV.ReadOnly = True
                    txtIdReciboV.Enabled = True
                    txtIdReciboV.Focus()
                Else
                    txtIdReciboV.BackColor = Color.LightGray
                    txtIdReciboV.ReadOnly = True
                    txtIdReciboV.Enabled = False
                    txtIdReciboV.Clear()
                    txtIdPaciente.Clear()
                    txtPaciente.Clear()
                    txtIdCliente.Clear()
                    txtCliente.Clear()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Consulte con el administrador del sistema")
        End Try
    End Sub
    Private Sub txtPDesc_ValueChanged(sender As Object, e As EventArgs) Handles txtPDesc.ValueChanged
        Try
            If (txtPDesc.Focused) Then
                If (Not txtPDesc.Text = String.Empty And Not txtTotalNeto.Text = String.Empty) Then
                    If (txtPDesc.Value = 0 Or txtPDesc.Value > 100) Then
                        txtPDesc.Value = 0
                        txtMdesc.Value = 0
                        _prCalcularPrecioTotal()
                    Else
                        Dim porcdesc As Double = txtPDesc.Value
                        Dim montodesc As Double = (JGdetalleVenta.GetTotal(JGdetalleVenta.RootTable.Columns("vbTotDesc"), AggregateFunction.Sum) * (porcdesc / 100))
                        txtMdesc.Value = montodesc
                        txtTotalNeto.Value = JGdetalleVenta.GetTotal(JGdetalleVenta.RootTable.Columns("vbTotDesc"), AggregateFunction.Sum) - montodesc
                    End If
                End If
                If (txtPDesc.Text = String.Empty) Then
                    txtMdesc.Value = 0
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Consulte con el administrador del sistema")
        End Try
    End Sub

    Private Sub txtMdesc_ValueChanged(sender As Object, e As EventArgs) Handles txtMdesc.ValueChanged
        Try
            If (txtMdesc.Focused) Then
                If (Not txtMdesc.Text = String.Empty And Not txtTotalNeto.Text = String.Empty) Then
                    Dim montodesc As Double = txtMdesc.Value
                    Dim porDesc As Double = ((montodesc * 100) / JGdetalleVenta.GetTotal(JGdetalleVenta.RootTable.Columns("vbTotDesc"), AggregateFunction.Sum))
                    txtPDesc.Value = porDesc
                    txtTotalNeto.Value = JGdetalleVenta.GetTotal(JGdetalleVenta.RootTable.Columns("vbTotDesc"), AggregateFunction.Sum) - montodesc
                End If
                If (txtMdesc.Text = String.Empty) Then
                    txtMdesc.Value = 0
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Consulte con el administrador del sistema")
        End Try
    End Sub
    'Cambio 
    Private Sub txtMontoPagado_ValueChanged(sender As Object, e As EventArgs) Handles txtMontoPagado.ValueChanged
        Try
            If txtMontoPagado.Focus Then
                If Not txtTotalNeto.Text = String.Empty And Not txtTotalNeto.Text = "0.00" Then
                    If cbTipoVenta.Value = 0 Then 'CREDITO
                        If Not txtTotalNeto.Value = 0 And txtMontoPagado.Value >= txtAcuenta.Value Then
                            'txtCambio.Text = txtMontoPagado.Value - txtTotalNeto.Value
                            txtCambio.Text = txtMontoPagado.Value - txtAcuenta.Value
                        Else
                            txtCambio.Value = 0
                        End If
                    Else
                        If Not txtTotalNeto.Value = 0 And txtMontoPagado.Value >= txtTotalNeto.Value Then
                            txtCambio.Text = txtMontoPagado.Value - txtTotalNeto.Value
                        Else
                            txtCambio.Value = 0
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Consulte con el administrador del sistema")
        End Try
    End Sub
#End Region
#Region "Metodos Privados"
    Private Sub _prIniciarTodo()
        P_prCargarVariablesIndispensables()
        _prValidarLote()
        _prCargarComboLibreriaSucursal(cbSucursal)
        _prCargarComboLibreria(cbEmision, 6, 1)
        _prCargarComboLibreria(cbTipoVenta, 6, 2)
        _prCargarVenta()
        _prInhabiliitar()
        grVentas.Focus()
        '_prAsignarPermisos()
        'P_prCargarParametro()
        _prCargarNameLabel()
        txtCambio.Text = "0.00"
        txtMontoPagado.Text = "0,00"
        cbSucursal.Value = 1
    End Sub

    Private Sub P_prCargarVariablesIndispensables()
        If (gb_FacturaEmite) Then
            gi_IVA = CDbl(IIf(L_fnGetIVA().Rows(0).Item("scdebfis").ToString.Equals(""), gi_IVA, L_fnGetIVA().Rows(0).Item("scdebfis").ToString))
            gi_ICE = CDbl(IIf(L_fnGetICE().Rows(0).Item("scice").ToString.Equals(""), gi_ICE, L_fnGetICE().Rows(0).Item("scice").ToString))
        End If
    End Sub
    Private Sub _prCargarVenta()
        Dim dt As New DataTable
        dt = L_fnMostrarProforma(IIf(swMostrar.Value = True, 1, 0))
        grVentas.DataSource = dt
        grVentas.RetrieveStructure()
        grVentas.AlternatingColors = True
        With grVentas.RootTable.Columns("vaId")
            .Width = 100
            .Caption = "Nro Recibo"
            .Visible = True
        End With
        With grVentas.RootTable.Columns("va_rkId")
            .Width = 90
            .Visible = False
        End With
        With grVentas.RootTable.Columns("va_roId")
            .Width = 90
            .Visible = False
        End With
        With grVentas.RootTable.Columns("va_rmId")
            .Width = 90
            .Visible = False
        End With
        With grVentas.RootTable.Columns("va_pbId")
            .Width = 90
            .Visible = False
        End With
        With grVentas.RootTable.Columns("va_rkId")
            .Width = 90
            .Visible = False
        End With
        With grVentas.RootTable.Columns("vaAlm")
            .Width = 100
            .Caption = "Almacen"
            .Visible = False
        End With

        With grVentas.RootTable.Columns("vaFechaDoc")
            .Width = 100
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            .Caption = "Fecha Proforma"
        End With
        With grVentas.RootTable.Columns("va_caId")
            .Width = 90
            .Visible = False
        End With
        With grVentas.RootTable.Columns("Cliente")
            .Width = 280
            .Visible = True
            .Caption = "Paciente"
        End With
        With grVentas.RootTable.Columns("pbnomb")
            .Width = 170
            .Visible = False
            .Caption = "Paciente"
        End With
        With grVentas.RootTable.Columns("va_ecId")
            .Width = 160
            .Visible = False
        End With
        With grVentas.RootTable.Columns("Empleado")
            .Width = 200
            .Visible = True
            .Caption = "Vendedor"
        End With
        With grVentas.RootTable.Columns("vaTipoVe")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With grVentas.RootTable.Columns("vaFechaVenCre")
            .Width = 100
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With grVentas.RootTable.Columns("vaObser")
            .Width = 150
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            .Caption = "Observación"
        End With
        With grVentas.RootTable.Columns("vaEst")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With grVentas.RootTable.Columns("vaDesc")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With grVentas.RootTable.Columns("vaTotal")
            .Width = 100
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            .FormatString = "0.00"
            .Caption = "Total"
        End With
        With grVentas.RootTable.Columns("vaFecha")
            .Width = 150
            .Visible = False
        End With
        With grVentas.RootTable.Columns("vaHora")
            .Width = 150
            .Visible = False
        End With
        With grVentas.RootTable.Columns("vaUsuario")
            .Width = 150
            .Visible = False
        End With
        With grVentas.RootTable.Columns("vaCuenta")
            .Width = 150
            .FormatString = "0.00"
            .Visible = False
        End With
        With grVentas.RootTable.Columns("vaEmision")
            .Visible = False
        End With
        With grVentas.RootTable.Columns("emision")
            .Width = 120
            .Visible = False
            .Caption = "Emisión"
        End With
        With grVentas.RootTable.Columns("vaTarjeta")
            .Visible = False
        End With
        With grVentas.RootTable.Columns("vaTransferencia")
            .Visible = False
        End With
        With grVentas.RootTable.Columns("TipoVenta")
            .Width = 100
            .Visible = False
            .Caption = "Tipo Venta"
        End With
        With grVentas.RootTable.Columns("Turno")
            .Width = 90
            .Visible = True
            .Caption = "Turno"
        End With
        With grVentas
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
        End With
        If (dt.Rows.Count <= 0) Then
            _prCargarDetalleVenta(-1)
        End If
    End Sub
    Private Sub _prCargarDetalleVenta(_IdVenta As String)
        Dim dt As New DataTable
        dt = L_fnMostrarProformaDetalle(_IdVenta)
        JGdetalleVenta.DataSource = dt
        JGdetalleVenta.RetrieveStructure()
        JGdetalleVenta.AlternatingColors = True
        With JGdetalleVenta.RootTable.Columns("vbId")
            .Width = 100
            .Caption = "CODIGO"
            .Visible = False
        End With
        With JGdetalleVenta.RootTable.Columns("vb_vaId")
            .Width = 90
            .Visible = False
        End With
        With JGdetalleVenta.RootTable.Columns("vb_tyfnumi")
            .Width = 80
            .Visible = True
            .Caption = "Id" ''Id Producto
        End With
        With JGdetalleVenta.RootTable.Columns("yfcprod")
            .Caption = "Cod Producto"
            .Width = 100
            .Visible = False
        End With
        With JGdetalleVenta.RootTable.Columns("Producto")
            .Caption = "Producto"
            .Width = 250
            .Visible = True
        End With
        With JGdetalleVenta.RootTable.Columns("vbEst")
            .Caption = "Estado"
            .Width = 100
            .Visible = False
        End With

        With JGdetalleVenta.RootTable.Columns("vbUMin")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
        End With
        With JGdetalleVenta.RootTable.Columns("vbCant")
            .Width = 120
            .Caption = "Cantidad"
            .FormatString = "0"
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
        End With
        With JGdetalleVenta.RootTable.Columns("unidad")
            .Width = 100
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .Caption = "Unidad".ToUpper
        End With
        With JGdetalleVenta.RootTable.Columns("vbPrec")
            .Width = 120
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .FormatString = "0.00"
            .Caption = "Precio U.".ToUpper
        End With
        With JGdetalleVenta.RootTable.Columns("vbPTotal")
            .Width = 110
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            .FormatString = "0.00"
            .Caption = "Sub Total".ToUpper
        End With
        With JGdetalleVenta.RootTable.Columns("vbPorc")
            .Width = 100
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            .FormatString = "0.00"
            .Caption = "P.Desc(%)".ToUpper
        End With
        With JGdetalleVenta.RootTable.Columns("vbDesc")
            .Width = 100
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            .FormatString = "0.00"
            .Caption = "M.Desc".ToUpper
        End With
        With JGdetalleVenta.RootTable.Columns("vbTotDesc")
            .Width = 110
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .FormatString = "0.00"
            .Caption = "Total".ToUpper
        End With
        With JGdetalleVenta.RootTable.Columns("vbObs")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With JGdetalleVenta.RootTable.Columns("vbPCosto")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
        End With
        With JGdetalleVenta.RootTable.Columns("vbPTot2")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
        End With
        With JGdetalleVenta.RootTable.Columns("vbfecha")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With JGdetalleVenta.RootTable.Columns("vbHora")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With JGdetalleVenta.RootTable.Columns("vbUsuario")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With JGdetalleVenta.RootTable.Columns("estado")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With JGdetalleVenta.RootTable.Columns("img")
            .Width = 80
            .Caption = "Eliminar".ToUpper
            .CellStyle.ImageHorizontalAlignment = ImageHorizontalAlignment.Center
            .Visible = False
        End With
        If (G_Lote = True) Then
            With JGdetalleVenta.RootTable.Columns("vbLote")
                .Width = 120
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
                .Visible = False
                .Caption = "LOTE"
            End With
            With JGdetalleVenta.RootTable.Columns("vbFechaVenc")
                .Width = 120
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
                .Visible = False
                .Caption = "FECHA VENC."
                .FormatString = "yyyy/MM/dd"
            End With
        Else
            With JGdetalleVenta.RootTable.Columns("vbLote")
                .Width = 120
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
                .Visible = False
                .Caption = "LOTE"
            End With
            With JGdetalleVenta.RootTable.Columns("vbFechaVenc")
                .Width = 120
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
                .Visible = False
                .Caption = "FECHA VENC."
                .FormatString = "yyyy/MM/dd"
            End With
        End If
        With JGdetalleVenta.RootTable.Columns("stock")
            .Width = 120
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With JGdetalleVenta.RootTable.Columns("vbEst2")
            .Width = 5
            .Visible = False
        End With
        With JGdetalleVenta
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub
    Public Sub _prMostrarRegistro(_N As Integer)
        grVentas.Row = _N
        With grVentas
            Dim recibo, reciboCir, reciboInt As Integer

            txtIdVenta.Text = .GetValue("vaId")

            txtIdVendedor.Text = .GetValue("va_ecId")
            txtVendedor.Text = .GetValue("Empleado")
            _CodEmpleado = .GetValue("va_ecId")
            cbEmision.Value = .GetValue("vaEmision")
            cbTipoVenta.Value = .GetValue("vaTipoVe")
            dtpFVenta.Value = .GetValue("vaFechaDoc")
            dtpFCredito.Value = .GetValue("vaFechaVenCre")
            cbSucursal.Value = .GetValue("vaAlm")
            recibo = IIf(.GetValue("va_rkId") = 0, 0, .GetValue("va_rkId"))
            reciboCir = IIf(.GetValue("va_roId") = 0, 0, .GetValue("va_roId"))
            reciboInt = IIf(.GetValue("va_rmId") = 0, 0, .GetValue("va_rmId"))
            If (recibo <> 0) Then
                swServicio.Value = True
                swCirugia.Value = False
                swInternacion.Value = False
                txtIdReciboV.Text = recibo
            ElseIf (reciboCir <> 0) Then
                swServicio.Value = False
                swCirugia.Value = True
                swInternacion.Value = False
                txtIdReciboV.Text = reciboCir
            ElseIf (reciboInt <> 0) Then
                swServicio.Value = False
                swCirugia.Value = False
                swInternacion.Value = True
                txtIdReciboV.Text = reciboInt
            End If
            If recibo = False And reciboCir = False And reciboInt = False Then
                swServicio.Value = False
                swCirugia.Value = False
                swInternacion.Value = False
                txtIdReciboV.Clear()
                txtIdReciboV.BackColor = Color.LightGray
                txtIdReciboV.ReadOnly = True
                txtIdReciboV.Enabled = False
            End If
            _CodCliente = .GetValue("va_caId")
            txtIdCliente.Text = .GetValue("va_caId")
            txtCliente.Text = .GetValue("Cliente")
            _CodPaciente = .GetValue("va_pbId")
            txtIdPaciente.Text = .GetValue("va_pbId")
            txtPaciente.Text = .GetValue("pbnomb")
            lbFecha.Text = CType(.GetValue("vaFecha"), Date).ToString("dd/MM/yyyy")
            lbHora.Text = .GetValue("vaHora").ToString
            lbUsuario.Text = .GetValue("vausuario").ToString
        End With
        _prCargarDetalleVenta(txtIdVenta.Text)
        txtMdesc.Value = grVentas.GetValue("vaDesc")
        'tbIce.Value = grVentas.GetValue("taice")
        _prCalcularPrecioTotal()

        'If swTipoVenta.Value = True Then
        '    txtAcuenta.Value = grVentas.GetValue("vaTotal")
        '    txtSaldo.Value = txtTotalNeto.Value - txtAcuenta.Value
        'Else
        '    txtAcuenta.Value = grVentas.GetValue("vaCuenta")
        '    txtSaldo.Value = txtTotalNeto.Value - txtAcuenta.Value
        'End If

        If cbTipoVenta.Value = 0 Then
            txtAcuenta.Value = grVentas.GetValue("vaCuenta")
            txtSaldo.Value = txtTotalNeto.Value - txtAcuenta.Value

        Else
            'txtAcuenta.Value = grVentas.GetValue("vaTotal")
            'txtSaldo.Value = txtTotalNeto.Value - txtAcuenta.Value
            txtAcuenta.Value = 0
            txtSaldo.Value = 0
        End If

        If cbEmision.Value = 1 Then
            Dim dt As DataTable = L_fnObtenerTabla("TFV001", "fvanitcli, fvadescli1, fvadescli2, fvaautoriz, fvanfac, fvaccont, fvafec", "fvanumi=" + txtIdVenta.Text.Trim)
            If (dt.Rows.Count = 1) Then
                TbNit.Text = dt.Rows(0).Item("fvanitcli").ToString
                TbNombre1.Text = dt.Rows(0).Item("fvadescli1").ToString

                tbNroAutoriz.Text = dt.Rows(0).Item("fvaautoriz").ToString
                tbNroFactura.Text = dt.Rows(0).Item("fvanfac").ToString
                tbCodigoControl.Text = dt.Rows(0).Item("fvaccont").ToString
                dtiFechaFactura.Value = dt.Rows(0).Item("fvafec")

            Else
                TbNit.Clear()
                TbNombre1.Clear()

                tbNroAutoriz.Clear()
                tbNroFactura.Clear()
                tbCodigoControl.Clear()
                dtiFechaFactura.Value = "2000/01/01"
            End If
            btnModificar.Visible = False
        Else
            btnModificar.Visible = True
        End If

        LblPaginacion.Text = Str(grVentas.Row + 1) + "/" + grVentas.RowCount.ToString
        txtMontoPagado.Text = "0.00"
        txtCambio.Text = "0.00"
    End Sub
    Public Sub _prCargarNameLabel()
        Dim dt As DataTable = L_fnNameLabel()
        If (dt.Rows.Count > 0) Then
            _codeBar = 1 'dt.Rows(0).Item("codeBar")
        End If
    End Sub
    Public Sub _prValidarLote()
        Dim dt As DataTable = L_fnPorcUtilidad()
        If (dt.Rows.Count > 0) Then
            Dim lot As Integer = dt.Rows(0).Item("VerLote")
            OcultarFact = dt.Rows(0).Item("VerFactManual")
            If (lot = 1) Then
                G_Lote = True
            Else
                G_Lote = False
            End If

        End If
    End Sub
    Private Sub _prAsignarPermisos()
        Dim dtRolUsu As DataTable = L_prRolDetalleGeneral(gi_userRol, _nameButton)
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
    Private Sub _prInhabiliitar()
        swServicio.IsReadOnly = True
        swInternacion.IsReadOnly = True
        swCirugia.IsReadOnly = True

        cbEmision.ReadOnly = True
        cbTipoVenta.ReadOnly = True
        cbSucursal.ReadOnly = True
        btnImprimir.Enabled = True
        txtIdVenta.ReadOnly = True
        txtCliente.ReadOnly = True
        txtIdReciboV.ReadOnly = True
        txtIdVendedor.ReadOnly = True
        txtIdCliente.ReadOnly = True
        txtVendedor.ReadOnly = True
        txtObservacion.ReadOnly = True
        dtpFVenta.Enabled = False
        dtpFCredito.Enabled = False
        txtIdPaciente.ReadOnly = True
        txtPaciente.ReadOnly = True
        'btnModificar.Enabled = True
        'btnGrabar.Enabled = False
        'btnNuevo.Enabled = True
        'btnEliminar.Enabled = True

        txtSubTotal.IsInputReadOnly = True
        txtMdesc.IsInputReadOnly = True
        txtTotalNeto.IsInputReadOnly = True
        txtAcuenta.IsInputReadOnly = True
        txtSaldo.IsInputReadOnly = True
        txtMontoPagado.IsInputReadOnly = True
        txtCambio.IsInputReadOnly = True
        grVentas.Enabled = True
        'PanelNavegacion.Enabled = True
        JGdetalleVenta.RootTable.Columns("img").Visible = False
        If (GPanelProductos.Visible = True) Then
            _DesHabilitarProductos()
        End If
        FilaSelectLote = Nothing

        'Datos facturacion
        tbNroAutoriz.ReadOnly = True
        tbNroFactura.ReadOnly = True
        tbCodigoControl.ReadOnly = True
        dtiFechaFactura.IsInputReadOnly = True
        dtiFechaFactura.ButtonDropDown.Enabled = False
        TbNit.ReadOnly = True
        TbNombre1.ReadOnly = True
    End Sub
    Private Sub _prhabilitar()
        swServicio.IsReadOnly = False
        swInternacion.IsReadOnly = False
        swCirugia.IsReadOnly = False
        btnImprimir.Enabled = False
        cbEmision.ReadOnly = False
        cbTipoVenta.ReadOnly = False
        txtIdVenta.ReadOnly = False
        txtCliente.ReadOnly = True
        txtIdReciboV.ReadOnly = True
        txtIdVendedor.ReadOnly = False
        txtIdCliente.ReadOnly = True
        txtVendedor.ReadOnly = True
        txtObservacion.ReadOnly = False
        dtpFVenta.Enabled = True
        dtpFCredito.Enabled = True
        txtIdPaciente.ReadOnly = False
        txtPaciente.ReadOnly = True
        'btnModificar.Enabled = True
        'btnGrabar.Enabled = False
        'btnNuevo.Enabled = True
        'btnEliminar.Enabled = True

        txtSubTotal.IsInputReadOnly = False
        txtMdesc.IsInputReadOnly = False
        txtTotalNeto.IsInputReadOnly = False
        txtAcuenta.IsInputReadOnly = False
        txtSaldo.IsInputReadOnly = False
        txtMontoPagado.IsInputReadOnly = False
        txtCambio.IsInputReadOnly = False
        grVentas.Enabled = False

        'Datos facturacion
        TbNit.ReadOnly = False
        TbNombre1.ReadOnly = False
    End Sub
    Private Sub _prLimpiar()
        txtIdVenta.Clear()
        txtIdReciboV.Clear()
        txtIdCliente.Clear()
        txtCliente.Clear()
        txtIdVendedor.Clear()
        txtVendedor.Clear()
        txtIdPaciente.Clear()
        txtPaciente.Clear()

        txtObservacion.Clear()
        swServicio.Value = False
        swCirugia.Value = False
        swInternacion.Value = False
        cbEmision.SelectedIndex = 0
        cbTipoVenta.SelectedIndex = 1
        _CodCliente = 0
        _CodEmpleado = 4 'vendedor por defecto 
        _CodPaciente = 0
        dtpFVenta.Value = Now.Date
        dtpFCredito.Value = Now.Date
        dtpFCredito.Visible = False
        lbVencCredito.Visible = False
        'MSuperTabControl.SelectedTabIndex = 0
        txtSubTotal.Value = 0
        txtMdesc.Value = 0
        txtTotalNeto.Value = 0
        txtAcuenta.Value = 0
        txtMontoPagado.Value = 0
        txtAcuenta.Value = 0
        txtCambio.Value = 0
        With JGdetalleVenta.RootTable.Columns("img")
            .Width = 80
            .Caption = "Eliminar"
            .CellStyle.ImageHorizontalAlignment = ImageHorizontalAlignment.Center
            .Visible = True
        End With
        _prCargarDetalleVenta(-1)
        _prAddDetalleVenta(0)
        If (GPanelProductos.Visible = True) Then
            GPanelProductos.Visible = False
            PanelInferior.Visible = True
        End If
        If (CType(cbSucursal.DataSource, DataTable).Rows.Count > 0) Then
            cbSucursal.SelectedIndex = 0
        End If
        FilaSelectLote = Nothing
        swServicio.Value = False
        txtIdCliente.Focus()
        Table_Producto = Nothing


        If (gi_userSuc > 0) Then
            Dim dt As DataTable = CType(cbSucursal.DataSource, DataTable)
            For i As Integer = 0 To dt.Rows.Count - 1 Step 1

                If (dt.Rows(i).Item("aanumi") = gi_userSuc) Then
                    cbSucursal.SelectedIndex = i
                End If
            Next
        End If


        ''Datos Facturacion
        tbNroAutoriz.Clear()
        tbNroFactura.Clear()
        tbCodigoControl.Clear()
        dtiFechaFactura.Value = Now.Date
        TbNit.Clear()
        TbNombre1.Clear()
    End Sub

    Public Sub _prFiltrar(tipo As Integer)
        'cargo el buscador
        _prCargarVenta()
        If grVentas.RowCount > 0 Then
            _MPos = 0
            _prMostrarRegistro(IIf(tipo = 1, _MPos, grVentas.RowCount - 1))
        Else
            _prLimpiar()
            LblPaginacion.Text = "0/0"
        End If
    End Sub


    Public Sub actualizarSaldoSinLote(ByRef dt As DataTable)
        'b.yfcdprod1 ,a.iclot ,a.icfven  ,a.iccven 

        '      a.vbId ,a.tbtv1numi ,a.tbty5prod ,b.yfcdprod1 as Servicio,a.tbest ,a.vbCant ,a.vbCant ,Umin .ycdes3 as unidad,a.vbPrec ,a.vbPTotal ,a.tbobs ,
        'a.vbPCosto,a.vbLote ,a.vbFechaVenc , a.vbPTotal2, a.tbfact ,a.tbhact ,a.tbuact,1 as estado,Cast(null as Image) as img,
        'Cast (0 as decimal (18,2)) as stock
        Dim _detalle As DataTable = CType(JGdetalleVenta.DataSource, DataTable)

        For i As Integer = 0 To dt.Rows.Count - 1 Step 1
            Dim sum As Integer = 0
            Dim codProducto As Integer = dt.Rows(i).Item("yfnumi")
            For j As Integer = 0 To JGdetalleVenta.RowCount - 1 Step 1
                JGdetalleVenta.Row = j
                Dim estado As Integer = JGdetalleVenta.GetValue("estado")
                If (estado = 0) Then
                    If (codProducto = JGdetalleVenta.GetValue("vb_tyfnumi")) Then
                        sum = sum + JGdetalleVenta.GetValue("vbCant")
                    End If
                End If
            Next
            dt.Rows(i).Item("stock") = dt.Rows(i).Item("stock") - sum
        Next

    End Sub
    '1.-Muestra la Grila para la seleccion del Servicio
    Private Sub _prCargarProductos(_cliente As String)
        If (cbSucursal.SelectedIndex < 0) Then
            Return
        End If
        Dim dtname As DataTable = L_fnNameLabel()
        Dim dt As New DataTable
        If (Not IsNothing(Table_Producto)) Then
            dt = Table_Producto.Copy
        Else
            If (G_Lote = True) Then
                dt = L_fnMostrarVentaProducto(cbSucursal.Value)
                Table_Producto = dt.Copy
            Else
                'dt = L_fnMostrarVentaProducto(cbSucursal.Value, _cliente, CType(JGdetalleVenta.DataSource, DataTable))  ''1=Almacen
                'Table_Producto = dt.Copy
            End If
        End If
        JGProductos.DataSource = dt
        JGProductos.RetrieveStructure()
        JGProductos.AlternatingColors = True
        With JGProductos.RootTable.Columns("yfnumi")
            .Width = 100
            .Caption = "Id"
            .Visible = False

        End With
        With JGProductos.RootTable.Columns("yfcprod")
            .Width = 100
            .Caption = "Id"
            .Visible = True
        End With
        With JGProductos.RootTable.Columns("yfcbarra")
            .Width = 100
            .Caption = "COD. BARRA"
            .Visible = False
            .Visible = gb_CodigoBarra
        End With
        With JGProductos.RootTable.Columns("yfcdprod1")
            .Width = 200
            .Visible = True
            .Caption = "Descripcion"
        End With
        With JGProductos.RootTable.Columns("yfcdprod2")
            .Width = 150
            .Visible = True
            .Caption = "Descripcion Corta"
        End With


        With JGProductos.RootTable.Columns("yfgr1")
            .Width = 160
            .Visible = False
        End With
        If (dtname.Rows.Count > 0) Then

            With JGProductos.RootTable.Columns("grupo1")
                .Width = 120
                .Caption = dtname.Rows(0).Item("Grupo 1").ToString
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
                .Visible = True
            End With
            With JGProductos.RootTable.Columns("grupo2")
                .Width = 120
                .Caption = dtname.Rows(0).Item("Grupo 2").ToString
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
                .Visible = True
            End With

            With JGProductos.RootTable.Columns("grupo3")
                .Width = 120
                .Caption = dtname.Rows(0).Item("Grupo 3").ToString
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
                .Visible = True
            End With
            With JGProductos.RootTable.Columns("grupo4")
                .Width = 120
                .Caption = dtname.Rows(0).Item("Grupo 4").ToString
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
                .Visible = True
            End With
        Else
            With JGProductos.RootTable.Columns("grupo1")
                .Width = 120
                .Caption = "Grupo 1"
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
                .Visible = True
            End With
            With JGProductos.RootTable.Columns("grupo2")
                .Width = 120
                .Caption = "Grupo 2"
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
                .Visible = True
            End With
            With JGProductos.RootTable.Columns("grupo3")
                .Width = 120
                .Caption = "Grupo 3"
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
                .Visible = True
            End With
            With JGProductos.RootTable.Columns("grupo4")
                .Width = 120
                .Caption = "Grupo 4"
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
                .Visible = True
            End With
        End If


        With JGProductos.RootTable.Columns("yfgr2")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With

        With JGProductos.RootTable.Columns("yfgr3")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With

        With JGProductos.RootTable.Columns("yfgr4")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With


        With JGProductos.RootTable.Columns("yfumin")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With JGProductos.RootTable.Columns("UnidMin")
            .Width = 100
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            .Caption = "Unidad Min."
        End With
        With JGProductos.RootTable.Columns("yhprecio")
            .Width = 80
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            '.GridEX.Enabled = False
            .Caption = "Precio"
            .FormatString = "0.00"
        End With
        With JGProductos.RootTable.Columns("pcos")
            .Width = 120
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
            .Caption = "Precio Costo"
            .FormatString = "0.00"
        End With
        With JGProductos.RootTable.Columns("stock")
            .Width = 80
            .FormatString = "0.00"
            .Visible = False
            .Caption = "Stock"
        End With
        With JGProductos
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With
        _prAplicarCondiccionJanusSinLote()
    End Sub
    Public Sub _prAplicarCondiccionJanusSinLote()
        Dim fc As GridEXFormatCondition
        fc = New GridEXFormatCondition(JGProductos.RootTable.Columns("stock"), ConditionOperator.Equal, 0)
        'fc.FormatStyle.FontBold = TriState.True
        fc.FormatStyle.ForeColor = Color.Tan
        JGProductos.RootTable.FormatConditions.Add(fc)
    End Sub
    Public Sub actualizarSaldo(ByRef dt As DataTable, CodProducto As Integer)
        Dim _detalle As DataTable = CType(JGdetalleVenta.DataSource, DataTable)
        For i As Integer = 0 To dt.Rows.Count - 1 Step 1
            Dim lote As String = dt.Rows(i).Item("iclot")
            Dim FechaVenc As Date = dt.Rows(i).Item("icfven")
            Dim sum As Integer = 0
            For j As Integer = 0 To _detalle.Rows.Count - 1
                Dim estado As Integer = _detalle.Rows(j).Item("estado")
                If (estado = 0) Then
                    If (lote = _detalle.Rows(j).Item("vblote") And
                        FechaVenc = _detalle.Rows(j).Item("vbFechaVenc") And CodProducto = _detalle.Rows(j).Item("vb_tyfnumi")) Then
                        sum = sum + _detalle.Rows(j).Item("vbCant")
                    End If
                End If
            Next
            dt.Rows(i).Item("iccven") = dt.Rows(i).Item("iccven") - sum
        Next
    End Sub
    Private Sub _prCargarLotesDeProductos(CodProducto As Integer, nameProducto As String)
        If (cbSucursal.SelectedIndex < 0) Then
            Return
        End If
        Dim dt As New DataTable
        GPanelProductos.Text = nameProducto
        dt = L_fnMostrarVentaProductoLoteProforma(CodProducto, cbSucursal.Value)  ''1=Almacen
        actualizarSaldo(dt, CodProducto)
        JGProductos.DataSource = dt
        JGProductos.RetrieveStructure()
        JGProductos.AlternatingColors = True
        With JGProductos.RootTable.Columns("yfcdprod1")
            .Width = 150
            .Visible = False

        End With
        'b.yfcdprod1 ,a.iclot ,a.icfven  ,a.iccven 
        With JGProductos.RootTable.Columns("iclot")
            .Width = 150
            .Caption = "LOTE"
            .Visible = False

        End With
        With JGProductos.RootTable.Columns("icfven")
            .Width = 160
            .Caption = "FECHA VENCIMIENTO"
            .FormatString = "yyyy/MM/dd"
            .Visible = True

        End With

        With JGProductos.RootTable.Columns("iccven")
            .Width = 150
            .Visible = False
            .Caption = "Stock"
            .FormatString = "0.00"
            .AggregateFunction = AggregateFunction.Sum
        End With


        With JGProductos
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .TotalRow = InheritableBoolean.True
            .TotalRowFormatStyle.BackColor = Color.Gold
            .TotalRowPosition = TotalRowPosition.BottomFixed
            .VisualStyle = VisualStyle.Office2007
        End With
        _prAplicarCondiccionJanusLote()

    End Sub
    Public Sub _prAplicarCondiccionJanusLote()
        Dim fc As GridEXFormatCondition
        fc = New GridEXFormatCondition(JGProductos.RootTable.Columns("iccven"), ConditionOperator.Equal, 0)
        fc.FormatStyle.BackColor = Color.Gold
        fc.FormatStyle.FontBold = TriState.True
        fc.FormatStyle.ForeColor = Color.White
        JGProductos.RootTable.FormatConditions.Add(fc)

        Dim fc2 As GridEXFormatCondition
        fc2 = New GridEXFormatCondition(JGProductos.RootTable.Columns("icfven"), ConditionOperator.LessThanOrEqualTo, Now.Date)
        fc2.FormatStyle.BackColor = Color.Red
        fc2.FormatStyle.FontBold = TriState.True
        fc2.FormatStyle.ForeColor = Color.White
        JGProductos.RootTable.FormatConditions.Add(fc2)
    End Sub
    Private Sub _prAddDetalleVenta(estado2 As Integer)
        '   a.vbId ,a.tbtv1numi ,a.tbty5prod ,b.yfcdprod1 as Servicio,a.tbest ,a.vbCant ,a.vbCant ,Umin .ycdes3 as unidad,a.vbPrec ,a.vbPTotal ,a.tbobs ,
        'a.vbPCosto,a.vbLote ,a.vbFechaVenc , a.vbPTotal2, a.tbfact ,a.tbhact ,a.tbuact,1 as estado,Cast(null as Image) as img
        Dim Bin As New MemoryStream
        Dim img As New Bitmap(My.Resources.delete, 28, 28)
        img.Save(Bin, Imaging.ImageFormat.Png)
        CType(JGdetalleVenta.DataSource, DataTable).Rows.Add(_fnSiguienteNumi() + 1, 0, 0, 0, "", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0, "20170101", CDate("2017/01/01"), Now.Date, "", "", 0, Bin.GetBuffer, 0, estado2)
    End Sub

    Public Function _fnSiguienteNumi()
        Dim dt As DataTable = CType(JGdetalleVenta.DataSource, DataTable)
        Dim rows() As DataRow = dt.Select("vbId=MAX(vbId)")
        If (rows.Count > 0) Then
            Return rows(rows.Count - 1).Item("vbId")
        End If
        Return 1
    End Function
    Public Function _fnAccesible()
        Return dtpFVenta.Enabled = True
    End Function
    Private Sub _HabilitarProductos()
        GPanelProductos.Visible = True
        'PanelTotal.Visible = False
        PanelInferior.Visible = False
        _prCargarProductos(Str(_CodCliente))
        JGProductos.Focus()
        JGProductos.MoveTo(JGProductos.FilterRow)
        JGProductos.Col = 2
    End Sub
    Private Sub _HabilitarFocoDetalle(fila As Integer)
        _prCargarProductos(Str(_CodCliente))
        JGdetalleVenta.Focus()
        JGdetalleVenta.Row = fila
        JGdetalleVenta.Col = 2
    End Sub
    Private Sub _DesHabilitarProductos()
        GPanelProductos.Visible = False
        'PanelTotal.Visible = True
        PanelInferior.Visible = True
        JGdetalleVenta.Select()
        JGdetalleVenta.Col = 4 '-Codigo dede Servicior
        JGdetalleVenta.Row = JGdetalleVenta.RowCount - 1

    End Sub

    Public Sub _fnObtenerFilaDetalle(ByRef pos As Integer, numi As Integer)
        For i As Integer = 0 To CType(JGdetalleVenta.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim _numi As Integer = CType(JGdetalleVenta.DataSource, DataTable).Rows(i).Item("vbId")
            If (_numi = numi) Then
                pos = i
                Return
            End If
        Next

    End Sub

    Public Sub _fnObtenerFilaDetalleProducto(ByRef pos As Integer, numi As Integer)
        For i As Integer = 0 To CType(JGProductos.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim _numi As Integer = CType(JGProductos.DataSource, DataTable).Rows(i).Item("yfnumi")
            If (_numi = numi) Then
                pos = i
                Return
            End If
        Next

    End Sub

    Public Function _fnExisteProducto(idprod As Integer) As Boolean
        For i As Integer = 0 To CType(JGdetalleVenta.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim _idprod As Integer = CType(JGdetalleVenta.DataSource, DataTable).Rows(i).Item("vb_tyfnumi")
            Dim estado As Integer = CType(JGdetalleVenta.DataSource, DataTable).Rows(i).Item("estado")
            If (_idprod = idprod And estado >= 0) Then

                Return True
            End If
        Next
        Return False
    End Function

    Public Function _fnExisteProductoConLote(idprod As Integer, lote As String, fechaVenci As Date) As Boolean
        For i As Integer = 0 To CType(JGdetalleVenta.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim _idprod As Integer = CType(JGdetalleVenta.DataSource, DataTable).Rows(i).Item("vb_tyfnumi")
            Dim estado As Integer = CType(JGdetalleVenta.DataSource, DataTable).Rows(i).Item("estado")
            '          a.vbId ,a.tbtv1numi ,a.tbty5prod ,b.yfcdprod1 as Servicio,a.tbest ,a.vbCant ,a.vbCant ,Umin .ycdes3 as unidad,a.vbPrec ,a.vbPTotal ,a.tbobs ,
            'a.vbPCosto,a.vbLote ,a.vbFechaVenc , a.vbPTotal2, a.tbfact ,a.tbhact ,a.tbuact,1 as estado,Cast(null as Image) as img,
            'Cast (0 as decimal (18,2)) as stock
            Dim _LoteDetalle As String = CType(JGdetalleVenta.DataSource, DataTable).Rows(i).Item("vbLote")
            Dim _FechaVencDetalle As Date = CType(JGdetalleVenta.DataSource, DataTable).Rows(i).Item("vbFechaVenc")
            If (_idprod = idprod And estado >= 0 And lote = _LoteDetalle And fechaVenci = _FechaVencDetalle) Then
                Return True
            End If
        Next
        Return False
    End Function
    Public Sub P_PonerTotal(rowIndex As Integer)
        If (rowIndex < JGdetalleVenta.RowCount) Then

            Dim lin As Integer = JGdetalleVenta.GetValue("vbId")
            Dim pos As Integer = -1
            _fnObtenerFilaDetalle(pos, lin)
            Dim cant As Double = JGdetalleVenta.GetValue("vbCant")
            Dim uni As Double = JGdetalleVenta.GetValue("vbPrec")
            Dim cos As Double = JGdetalleVenta.GetValue("vbPCosto")
            Dim MontoDesc As Double = JGdetalleVenta.GetValue("vbDesc")
            Dim dt As DataTable = CType(JGdetalleVenta.DataSource, DataTable)
            If (pos >= 0) Then
                Dim TotalUnitario As Double = cant * uni
                Dim TotalCosto As Double = cant * cos
                'grDetalle.SetValue("lcmdes", montodesc)
                CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPTotal") = TotalUnitario
                CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbTotDesc") = TotalUnitario - MontoDesc
                JGdetalleVenta.SetValue("vbPTotal", TotalUnitario)
                JGdetalleVenta.SetValue("vbTotDesc", TotalUnitario - MontoDesc)

                CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPTot2") = TotalCosto
                JGdetalleVenta.SetValue("vbPTot2", TotalCosto)

                Dim estado As Integer = CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("estado")
                If (estado = 1) Then
                    CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("estado") = 2
                End If
            End If
            _prCalcularPrecioTotal()
        End If
    End Sub
    Public Sub _prCalcularPrecioTotal()
        Dim montodesc As Double = txtMdesc.Value
        Dim pordesc As Double = ((montodesc * 100) / JGdetalleVenta.GetTotal(JGdetalleVenta.RootTable.Columns("vbTotDesc"), AggregateFunction.Sum))
        txtPDesc.Value = pordesc
        txtSubTotal.Value = JGdetalleVenta.GetTotal(JGdetalleVenta.RootTable.Columns("vbTotDesc"), AggregateFunction.Sum)
        'tbIce.Value = JGdetalleVenta.GetTotal(JGdetalleVenta.RootTable.Columns("vbPTotal2"), AggregateFunction.Sum) * (gi_ICE / 100)
        If (gb_FacturaIncluirICE = True) Then
            'txtTotalNeto.Value = JGdetalleVenta.GetTotal(JGdetalleVenta.RootTable.Columns("vbTotDesc"), AggregateFunction.Sum) - montodesc + tbIce.Value
        Else
            txtTotalNeto.Value = JGdetalleVenta.GetTotal(JGdetalleVenta.RootTable.Columns("vbTotDesc"), AggregateFunction.Sum) - montodesc
        End If
    End Sub
    Public Sub _prEliminarFilaRecibo2()
        If (JGdetalleVenta.Row >= 0) Then
            If (JGdetalleVenta.RowCount >= 1) Then
                Dim estado As Integer
                For i As Integer = 0 To CType(JGdetalleVenta.DataSource, DataTable).Rows.Count - 1 Step 1
                    estado = CType(JGdetalleVenta.DataSource, DataTable).Rows(i).Item("estado")
                    If (estado = 0) Then
                        CType(JGdetalleVenta.DataSource, DataTable).Rows(i).Item("estado") = -2
                    End If
                    If (estado = 1) Then
                        CType(JGdetalleVenta.DataSource, DataTable).Rows(i).Item("estado") = -1
                    End If
                Next
            End If
            JGdetalleVenta.Row = JGdetalleVenta.RowCount - 1
        End If
    End Sub
    Sub _prEliminarFilaRecibo3()
        JGdetalleVenta.RootTable.ApplyFilter(New Janus.Windows.GridEX.GridEXFilterCondition(JGdetalleVenta.RootTable.Columns("estado"), Janus.Windows.GridEX.ConditionOperator.GreaterThanOrEqualTo, 0))
        _prCalcularPrecioTotal()
        'JGdetalleVenta.Select()
        'If JGdetalleVenta.RowCount = 0 Then
        '    _prAddDetalleVenta(0)
        'End If
        JGdetalleVenta.Row = JGdetalleVenta.RowCount - 1
        JGdetalleVenta.Col = 3
        JGdetalleVenta.Refetch()
        JGdetalleVenta.Refresh()
    End Sub
    Public Sub _prEliminarFilaRecibo()
        If (JGdetalleVenta.Row >= 0) Then
            If (JGdetalleVenta.RowCount >= 2) Then
                Dim estado, estado2 As Integer
                If txtIdReciboV.Text <> 0 Then
                    For i As Integer = 0 To CType(JGdetalleVenta.DataSource, DataTable).Rows.Count - 1 Step 1
                        estado = CType(JGdetalleVenta.DataSource, DataTable).Rows(i).Item("estado")
                        estado2 = CType(JGdetalleVenta.DataSource, DataTable).Rows(i).Item("vbEst2")
                        If estado2 <> 0 Then
                            If (estado = 0) Then
                                CType(JGdetalleVenta.DataSource, DataTable).Rows(i).Item("estado") = -2
                            End If
                            If (
                                estado = 1) Then
                                CType(JGdetalleVenta.DataSource, DataTable).Rows(i).Item("estado") = -1
                            End If
                        End If
                    Next
                    JGdetalleVenta.RootTable.ApplyFilter(New Janus.Windows.GridEX.GridEXFilterCondition(JGdetalleVenta.RootTable.Columns("estado"), Janus.Windows.GridEX.ConditionOperator.GreaterThanOrEqualTo, 0))
                    _prCalcularPrecioTotal()
                    'JGdetalleVenta.Select()
                    If JGdetalleVenta.RowCount = 0 Then
                        _prAddDetalleVenta(0)
                    End If
                    JGdetalleVenta.Row = JGdetalleVenta.RowCount - 1
                    JGdetalleVenta.Col = 3
                    JGdetalleVenta.Refetch()
                    JGdetalleVenta.Refresh()
                End If
            End If
        End If
    End Sub
    Private Sub _prCambiarEstado()
        Dim estado As Integer
        estado = JGdetalleVenta.GetValue("estado")
        Dim pos As Integer = -1
        Dim lin As Integer = JGdetalleVenta.GetValue("vbId")
        _fnObtenerFilaDetalle(pos, lin)
        If (estado = 0) Then
            CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("estado") = -2
        End If
        If (estado = 1) Then
            CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("estado") = -1
        End If
    End Sub
    Public Sub _prEliminarFila()
        '********* EL DETALLE DE CUALQUIER RECIBO*******************
        If (JGdetalleVenta.Row >= 0) Then
            If (JGdetalleVenta.RowCount >= 2) Then
                Dim estado, estado2 As Integer
                If txtIdReciboV.Text <> String.Empty Or txtIdReciboV.Text <> "0" Then
                    estado2 = JGdetalleVenta.GetValue("vbEst2")
                    If estado2 <> 0 Then
                        Dim ef = New Efecto
                        ef.tipo = 2
                        ef.Context = "Eliminar recibo".ToUpper
                        ef.Header = "Se eliminará el recibo, cliente y paciente. ¿Esta seguro de eliminar el det. Recibo?".ToUpper
                        ef.ShowDialog()
                        Dim bandera As Boolean = False
                        bandera = ef.band
                        If (bandera = True) Then
                            For i As Integer = 0 To CType(JGdetalleVenta.DataSource, DataTable).Rows.Count - 1 Step 1
                                estado = CType(JGdetalleVenta.DataSource, DataTable).Rows(i).Item("estado")
                                estado2 = CType(JGdetalleVenta.DataSource, DataTable).Rows(i).Item("vbEst2")
                                If estado2 <> 0 Then
                                    If (estado = 0) Then
                                        CType(JGdetalleVenta.DataSource, DataTable).Rows(i).Item("estado") = -2
                                    End If
                                    If (estado = 1) Then
                                        CType(JGdetalleVenta.DataSource, DataTable).Rows(i).Item("estado") = -1
                                    End If
                                End If
                            Next
                            txtIdReciboV.Clear()
                            swCirugia.Value = False
                            swInternacion.Value = False
                            swServicio.Value = False
                        End If
                    Else
                        '********************ELIMINA EL DETALLE DE PRODUCTO****************
                        _prCambiarEstado()
                    End If
                Else
                    _prCambiarEstado()
                End If
                JGdetalleVenta.RootTable.ApplyFilter(New Janus.Windows.GridEX.GridEXFilterCondition(JGdetalleVenta.RootTable.Columns("estado"), Janus.Windows.GridEX.ConditionOperator.GreaterThanOrEqualTo, 0))
                _prCalcularPrecioTotal()
                JGdetalleVenta.Select()
                JGdetalleVenta.Col = 3
                If JGdetalleVenta.RowCount = 0 Then
                    _prAddDetalleVenta(0)
                End If
                JGdetalleVenta.Row = JGdetalleVenta.RowCount - 1
            End If
        End If
        JGdetalleVenta.Refetch()
        JGdetalleVenta.Refresh()
    End Sub
    Private Sub _prCargarComboLibreriaSucursal(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_fnListarSucursales()
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("aanumi").Width = 60
            .DropDownList.Columns("aanumi").Caption = "COD"
            .DropDownList.Columns.Add("aabdes").Width = 300
            .DropDownList.Columns("aabdes").Caption = "ALMACEN-SUC"
            .ValueMember = "aanumi"
            .DisplayMember = "aabdes"
            .DataSource = dt
            .Refresh()
        End With
    End Sub
    Private Sub _prCargarComboLibreria(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo, cod1 As String, cod2 As String)
        Dim dt As New DataTable
        dt = L_fnMostrarLibreria(cod1, cod2)
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("lbidlib").Width = 70
            .DropDownList.Columns("lbidlib").Caption = "COD"
            .DropDownList.Columns.Add("lbdesc").Width = 150
            .DropDownList.Columns("lbdesc").Caption = "DESCRIPCION"
            .ValueMember = "lbidlib"
            .DisplayMember = "lbdesc"
            .DataSource = dt
            .Refresh()
        End With
    End Sub
    Public Sub _prImiprimirNotaVenta(numi As String)
        Dim ef = New Efecto
        ef.tipo = 2
        ef.Context = "MENSAJE PRINCIPAL".ToUpper
        ef.Header = "¿Desea imprimir la nota de venta?".ToUpper
        ef.ShowDialog()
        Dim bandera As Boolean = False
        bandera = ef.band
        If (bandera = True) Then
            P_GenerarReporte(numi) 'Imprime Directo
        End If
    End Sub
    'Public Sub _prImiprimirFacturaPreimpresa(numi As String)
    '    Dim ef = New Efecto
    '    ef.tipo = 2
    '    ef.Context = "MENSAJE PRINCIPAL".ToUpper
    '    ef.Header = "¿desea imprimir la factura Preimpresa?".ToUpper
    '    ef.ShowDialog()
    '    Dim bandera As Boolean = False
    '    bandera = ef.band
    '    If (bandera = True) Then
    '        P_GenerarReporteFactura(numi)
    '    End If
    'End Sub

    'Private Sub _prSalir()
    '    If btnGrabar.Enabled = True Then
    '        _prInhabiliitar()
    '        If grVentas.RowCount > 0 Then
    '            _prMostrarRegistro(0)
    '        End If
    '    Else
    '        _modulo.Select()
    '        _tab.Close()
    '    End If
    'End Sub
    Public Sub _prCargarIconELiminar()
        For i As Integer = 0 To CType(JGdetalleVenta.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim Bin As New MemoryStream
            Dim img As New Bitmap(My.Resources.delete, 28, 28)
            img.Save(Bin, Imaging.ImageFormat.Png)
            CType(JGdetalleVenta.DataSource, DataTable).Rows(i).Item("img") = Bin.GetBuffer
            JGdetalleVenta.RootTable.Columns("img").Visible = True
        Next
    End Sub
    Public Sub _PrimerRegistro()
        Dim _MPos As Integer
        If grVentas.RowCount > 0 Then
            _MPos = 0
            ''   _prMostrarRegistro(_MPos)
            grVentas.Row = _MPos
        End If
    End Sub
    'Pasa de la grilla de Productos a la grilla de Detalle
    Public Sub InsertarProductosSinLote()
        Dim pos As Integer = -1
        JGdetalleVenta.Row = JGdetalleVenta.RowCount - 1
        _fnObtenerFilaDetalle(pos, JGdetalleVenta.GetValue("vbId"))
        Dim existe As Boolean = _fnExisteProducto(JGProductos.GetValue("yfnumi"))
        If ((pos >= 0) And (Not existe)) Then
            CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vb_tyfnumi") = JGProductos.GetValue("yfnumi")
            CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("yfcprod") = JGProductos.GetValue("yfcprod")
            'CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("yfcbarra") = JGProductos.GetValue("yfcbarra")
            CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("Producto") = JGProductos.GetValue("yfcdprod1")
            CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbUMin") = JGProductos.GetValue("yfumin")
            CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("unidad") = JGProductos.GetValue("UnidMin")
            CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPrec") = JGProductos.GetValue("yhprecio")
            CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPTotal") = JGProductos.GetValue("yhprecio")
            CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbTotDesc") = JGProductos.GetValue("yhprecio")
            CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbCant") = 1
            If (gb_FacturaIncluirICE) Then
                CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPCosto") = JGProductos.GetValue("pcos")
            Else
                CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPCosto") = 0
            End If
            'Modif aqui
            CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPCosto") = JGProductos.GetValue("pcos")
            CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("vbPTot2") = JGProductos.GetValue("pcos")
            '
            CType(JGdetalleVenta.DataSource, DataTable).Rows(pos).Item("stock") = JGProductos.GetValue("stock")
            _prCalcularPrecioTotal()
            _DesHabilitarProductos()
        Else
            If (existe) Then
                Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                ToastNotification.Show(Me, "El producto ya existe en el detalle".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
            End If
        End If
    End Sub
    Public Sub InsertarProductosConLote()
        Dim pos As Integer = -1
        JGdetalleVenta.Row = JGdetalleVenta.RowCount - 1
        _fnObtenerFilaDetalleProducto(pos, JGProductos.GetValue("yfnumi"))
        Dim posProducto As Integer = JGProductos.Row
        FilaSelectLote = CType(JGProductos.DataSource, DataTable).Rows(pos)


        'If (JGProductos.GetValue("stock") > 0) Then
        _prCargarLotesDeProductos(JGProductos.GetValue("yfnumi"), JGProductos.GetValue("yfcdprod1"))
        'Else
        'Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
        'ToastNotification.Show(Me, "El Producto: ".ToUpper + JGProductos.GetValue("yfcdprod1") + " NO CUENTA CON STOCK DISPONIBLE", img, 5000, eToastGlowColor.Red, eToastPosition.TopCenter)
        'FilaSelectLote = Nothing
        'End If
    End Sub

    Public Function P_fnImageToByteArray(ByVal imageIn As Image) As Byte()
        Dim ms As New System.IO.MemoryStream()
        imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Return ms.ToArray()
    End Function
    Sub _prCargarProductoDeRecibo(IdRecibo As Integer)
        Dim dt As DataTable
        Dim estado2 As Integer = 0
        If swServicio.Value Then
            dt = L_fnMostrarVentaReciboDet(IdRecibo)
            estado2 = 1
        End If
        If swInternacion.Value Then
            dt = L_fnMostrarVentaReciboInternacionDet(IdRecibo)
            estado2 = 3
        End If
        If swCirugia.Value Then
            dt = L_fnMostrarVentaReciboCirugianDet(IdRecibo)
            estado2 = 2
        End If
        Dim Suma As Decimal = 0
        If (dt.Rows.Count > 0) Then
            '_prEliminarFilaRecibo2()
            '_prExtraer()
            '_tablaDetalle = CType(JGdetalleVenta.DataSource, DataTable)
            '_tablaDetalle2 = _tablaDetalle
            CType(JGdetalleVenta.DataSource, DataTable).Rows.Clear()
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim numiServicio As Integer = dt.Rows(i).Item("IdProducto")
                Dim nameServicio As String = dt.Rows(i).Item("Producto")
                Dim lote As String = ""
                Dim FechaVenc As Date = Now.Date
                Dim cant As Double = dt.Rows(i).Item("Cantidad")
                Dim iccven As Double = 0
                _prAddDetalleVenta(estado2)
                JGdetalleVenta.Row = JGdetalleVenta.RowCount - 1
                CType(JGdetalleVenta.DataSource, DataTable).Rows(JGdetalleVenta.RowCount - 1).Item("vb_tyfnumi") = numiServicio
                CType(JGdetalleVenta.DataSource, DataTable).Rows(JGdetalleVenta.Row).Item("Producto") = nameServicio
                CType(JGdetalleVenta.DataSource, DataTable).Rows(JGdetalleVenta.Row).Item("unidad") = "UN"
                CType(JGdetalleVenta.DataSource, DataTable).Rows(JGdetalleVenta.Row).Item("vbCant") = dt.Rows(i).Item("Cantidad")
                CType(JGdetalleVenta.DataSource, DataTable).Rows(JGdetalleVenta.Row).Item("vbUMin") = 1
                CType(JGdetalleVenta.DataSource, DataTable).Rows(JGdetalleVenta.Row).Item("vbPrec") = dt.Rows(i).Item("Precio")
                CType(JGdetalleVenta.DataSource, DataTable).Rows(JGdetalleVenta.Row).Item("vbPTotal") = dt.Rows(i).Item("Total")
                CType(JGdetalleVenta.DataSource, DataTable).Rows(JGdetalleVenta.Row).Item("vbDesc") = "0.00"
                CType(JGdetalleVenta.DataSource, DataTable).Rows(JGdetalleVenta.Row).Item("vbPorc") = "0.00"
                CType(JGdetalleVenta.DataSource, DataTable).Rows(JGdetalleVenta.Row).Item("vbTotDesc") = dt.Rows(i).Item("Total")
                CType(JGdetalleVenta.DataSource, DataTable).Rows(JGdetalleVenta.Row).Item("vbLote") = lote
                CType(JGdetalleVenta.DataSource, DataTable).Rows(JGdetalleVenta.Row).Item("vbFechaVenc") = FechaVenc
                CType(JGdetalleVenta.DataSource, DataTable).Rows(JGdetalleVenta.Row).Item("stock") = iccven
                CType(JGdetalleVenta.DataSource, DataTable).Rows(JGdetalleVenta.Row).Item("vbUsuario") = L_Usuario

                'JGdetalleVenta.SetValue("vb_tyfnumi", numiServicio)
                'JGdetalleVenta.SetValue("Producto", nameServicio)
                'JGdetalleVenta.SetValue("unidad", "UN")
                'JGdetalleVenta.SetValue("vbCant", dt.Rows(i).Item("Cantidad"))
                'JGdetalleVenta.SetValue("vbUMin", 1)
                'JGdetalleVenta.SetValue("vbPrec", dt.Rows(i).Item("Precio"))
                'JGdetalleVenta.SetValue("vbPTotal", dt.Rows(i).Item("Total"))
                'JGdetalleVenta.SetValue("vbDesc", "0.00")
                'JGdetalleVenta.SetValue("vbPorc", "0.00")
                ''JGdetalleVenta.SetValue("vbPTotal", dt.Rows(i).Item("rlTotal"))
                'JGdetalleVenta.SetValue("vbTotDesc", dt.Rows(i).Item("Total"))
                'Dim AUX As String = JGdetalleVenta.GetValue("vbTotDesc")
                'JGdetalleVenta.SetValue("vbLote", lote)
                'JGdetalleVenta.SetValue("vbFechaVenc", FechaVenc)
                'JGdetalleVenta.SetValue("stock", iccven)
                'JGdetalleVenta.SetValue("vbUsuario", L_Usuario)
                ''_prCalcularReciboTotal()
                'Suma = dt.Rows(i).Item("Total") + Suma
            Next
            _prEliminarFilaRecibo3()
            _prCalcularPrecioTotal()
            txtIdVendedor.Focus()
        End If
    End Sub
    Public Sub _prCalcularReciboTotal()
        Dim AUX As String = JGdetalleVenta.GetValue("vbPTotal")
        txtSubTotal.Value = JGdetalleVenta.GetTotal(JGdetalleVenta.RootTable.Columns("vbTotDesc"), SummaryOperation.Sum)
        'Dim AUX1 As String JGdetalleVenta.RootTable.Columns("vbPTotal")
        'txtSubTotal.Value = Suma
        txtTotalNeto.Value = JGdetalleVenta.GetTotal(JGdetalleVenta.RootTable.Columns("vbTotDesc"), AggregateFunction.Sum)
    End Sub
    Function _prVeriicar() As Boolean
        'If JGdetalleVenta.RowCount > 0 And JGdetalleVenta.RowCount <= 1 Then
        '    Dim inicial = CType(JGdetalleVenta.DataSource, DataTable).Rows(0).Item("vb_tyfnumi")
        '    If inicial = 0 Then
        '        CType(JGdetalleVenta.DataSource, DataTable).Rows(0).Item("vbEst2") = estado
        '        Return True
        '    End If
        'End If
        'Return False
        JGdetalleVenta.Refresh()
        Dim res As Boolean = False
        For i As Integer = 0 To CType(JGdetalleVenta.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim inicial = CType(JGdetalleVenta.DataSource, DataTable).Rows(i).Item("vb_tyfnumi")
            If inicial = 0 Then
                CType(JGdetalleVenta.DataSource, DataTable).Rows(i).Item("estado") = -2
                JGdetalleVenta.RootTable.ApplyFilter(New Janus.Windows.GridEX.GridEXFilterCondition(JGdetalleVenta.RootTable.Columns("estado"), Janus.Windows.GridEX.ConditionOperator.GreaterThanOrEqualTo, 0))
                res = True
            End If
        Next
        Return res
    End Function
    Sub _prExtraer()
        Dim estado As Integer
        If _MNuevo = False Then 'Modificar
            For i As Integer = 0 To CType(JGdetalleVenta.DataSource, DataTable).Rows.Count - 1 Step 1
                estado = CType(JGdetalleVenta.DataSource, DataTable).Rows(i).Item("estado")
                If (estado = 0) Then
                    CType(JGdetalleVenta.DataSource, DataTable).Rows(i).Item("estado") = -2
                End If
                If (estado = 1) Then
                    CType(JGdetalleVenta.DataSource, DataTable).Rows(i).Item("estado") = -1
                End If
            Next
        End If
    End Sub
    Sub _prUnirTabla()
        If _MNuevo = False Then 'Modificar
            _tablaDetalle.Merge(CType(JGdetalleVenta.DataSource, DataTable), True, MissingSchemaAction.Add)
            JGdetalleVenta.DataSource = _tablaDetalle
        End If
    End Sub
    Public Sub _prPedirLotesProducto(ByRef lote As String, ByRef FechaVenc As Date, ByRef iccven As Double, CodProducto As Integer, nameProducto As String, cant As Integer)
        Dim dt As New DataTable
        dt = L_fnMostrarVentaProductoLote(CodProducto, cbSucursal.Value)  ''1=Almacen
        'b.yfcdprod1 ,a.iclot ,a.icfven  ,a.iccven 
        Dim listEstCeldas As New List(Of Modelo.Celda)
        listEstCeldas.Add(New Modelo.Celda("yfcdprod1,", False, "", 150))
        listEstCeldas.Add(New Modelo.Celda("iclot", True, "LOTE", 150))
        listEstCeldas.Add(New Modelo.Celda("icfven", True, "FECHA VENCIMIENTO", 180, "dd/MM/yyyy"))
        listEstCeldas.Add(New Modelo.Celda("iccven", False, "Stock".ToUpper, 150, "0.00"))
        Dim ef = New Efecto
        ef.tipo = 3
        ef.dt = dt
        ef.SeleclCol = 2
        ef.listEstCeldas = listEstCeldas
        ef.alto = 50
        ef.ancho = 350
        ef.Context = "Producto ".ToUpper + nameProducto + "  cantidad=" + Str(cant)
        ef.ShowDialog()
        Dim bandera As Boolean = False
        bandera = ef.band
        'b.yfcdprod1 ,a.iclot ,a.icfven  ,a.iccven 
        If (bandera = True) Then
            Dim Row As Janus.Windows.GridEX.GridEXRow = ef.Row
            lote = Row.Cells("iclot").Value
            FechaVenc = Row.Cells("icfven").Value
            iccven = Row.Cells("iccven").Value
        End If
    End Sub
    Private Sub P_GenerarReporte(vaId As String)
        Try
            Dim total As Double
            Dim dt As DataTable = L_fnMostrarProformaReporte(vaId)
            Dim _DsDatos_Factura As DataSet = L_Reporte_Factura_Cia("1")


            If dt.Rows(0).Item("vaCuenta") = 0 Then
                total = dt.Compute("SUM(vbTotDesc)", "") - dt.Rows(0).Item("vaDesc")
            Else
                total = dt.Rows(0).Item("vaCuenta")
            End If

            'Dim total As Double = dt.Compute("SUM(vbTotDesc)", "")

            Dim totald As Double = (total / 6.96)
            Dim fechaven As String = dt.Rows(0).Item("vaFechaDoc")
            If Not IsNothing(P_Global.Visualizador) Then
                P_Global.Visualizador.Close()
            End If
            Dim ParteEntera As Long
            Dim ParteDecimal As Double
            ParteEntera = Int(total)
            ParteDecimal = total - ParteEntera
            Dim _TotalDecimal2 As String = Math.Truncate(CDbl(ParteDecimal) * 100)

            '    Dim li As String = ConvertirLiteral.A_fnConvertirLiteral(CDbl(ParteEntera)) + " con " +
            'IIf(ParteDecimal.ToString.Equals("0"), "00", (ParteDecimal.ToString)) + "/100 Bolivianos"

            Dim li As String = ConvertirLiteral.A_fnConvertirLiteral(CDbl(ParteEntera)) + " con " +
            IIf(ParteDecimal.ToString.Equals("0"), "00", (_TotalDecimal2)) + "/100 Bolivianos"

            If (dt.Rows.Count > 0) Then
                If Not IsNothing(P_Global.Visualizador) Then
                    P_Global.Visualizador.Close()
                End If
                '
                'If dt.Rows.Count <= 6 Then
                P_Global.Visualizador = New Visualizador
                    Dim objrep As New R_Proforma

                    'objrep.SetDataSource(dt)
                    'objrep.Subreports.Item("R_Venta.rpt").SetParameterValue("TotalBs", li)

                    'objrep.Subreports.Item("R_Venta.rpt").SetParameterValue("usuario", L_Usuario)
                    'objrep.Subreports.Item("R_Venta.rpt").SetParameterValue("estado", 1)

                    '
                    'P_Global.Visualizador.CrGeneral.ReportSource = objrep 'Comentar
                    'P_Global.Visualizador.Show() 'Comentar
                    'P_Global.Visualizador.BringToFront() 'Comentar

                    'objrep.SetParameterValue("usuario", L_Usuario)
                    'objrep.SetParameterValue("estado", 1)
                    objrep.SetDataSource(dt)
                    objrep.SetParameterValue("TotalBs", li)
                    objrep.SetParameterValue("Paciente", txtPaciente.Text)
                    objrep.SetParameterValue("ENombre", _DsDatos_Factura.Tables(0).Rows(0).Item("scneg").ToString)
                    objrep.SetParameterValue("Direccionpr", _DsDatos_Factura.Tables(0).Rows(0).Item("scdir").ToString)
                    objrep.SetParameterValue("Telefonopr", _DsDatos_Factura.Tables(0).Rows(0).Item("sctelf").ToString)
                    objrep.SetParameterValue("ECiudadPais", _DsDatos_Factura.Tables(0).Rows(0).Item("scpai").ToString)

                    'objrep.SetParameterValue("Paciente", txtPaciente.Text, "R_Venta.rpt - 01")
                    'objrep.SetParameterValue("ENombre", _DsDatos_Factura.Tables(0).Rows(0).Item("scneg").ToString, "R_Venta.rpt - 01")
                    'objrep.SetParameterValue("Direccionpr", _DsDatos_Factura.Tables(0).Rows(0).Item("scdir").ToString, "R_Venta.rpt - 01")
                    'objrep.SetParameterValue("Telefonopr", _DsDatos_Factura.Tables(0).Rows(0).Item("sctelf").ToString, "R_Venta.rpt - 01")
                    'objrep.SetParameterValue("ECiudadPais", _DsDatos_Factura.Tables(0).Rows(0).Item("scpai").ToString, "R_Venta.rpt - 01")
                    P_Global.Visualizador.CrGeneral.ReportSource = objrep 'Comentar
                    'P_Global.Visualizador.WindowState = FormWindowState.Maximized
                    P_Global.Visualizador.ShowDialog() 'Comentar
                    P_Global.Visualizador.BringToFront() 'Comentar

                'objrep.Subreports.Item("R_Venta.rpt").SetDataSource(dt)
                'objrep.SetDataSource(dt)
                'objrep.PrintToPrinter(1, False, 1, 1)

                'Else
                '    P_Global.Visualizador = New Visualizador
                '    Dim objrep As New R_Venta

                '    'objrep.Subreports.Item("R_Venta.rpt").SetDataSource(dt)

                '    objrep.SetDataSource(dt)
                '    objrep.SetParameterValue("TotalBs", li)
                '    objrep.SetParameterValue("Paciente", txtPaciente.Text)
                '    objrep.SetParameterValue("ENombre", _DsDatos_Factura.Tables(0).Rows(0).Item("scneg").ToString)
                '    objrep.SetParameterValue("Direccionpr", _DsDatos_Factura.Tables(0).Rows(0).Item("scdir").ToString)
                '    objrep.SetParameterValue("Telefonopr", _DsDatos_Factura.Tables(0).Rows(0).Item("sctelf").ToString)
                '    objrep.SetParameterValue("ECiudadPais", _DsDatos_Factura.Tables(0).Rows(0).Item("scpai").ToString)
                '    P_Global.Visualizador.CrGeneral.ReportSource = objrep 'Comentar
                '    P_Global.Visualizador.ShowDialog() 'Comentar
                '    P_Global.Visualizador.BringToFront() 'Comentar


                'End If


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
#Region "Metodos Overridable"
    Public Overrides Function _PMOGrabarRegistro() As Boolean
        'If _prValidar() = False Then
        '    Exit Function
        'End If
        Dim Turno As Integer = 0
        P_DeterminarTurno(Turno)

        'cbTipoVenta.Value=0 Credito, cbTipoVenta.Value=1 Contado, cbTipoVenta.Value=2 Tarjeta, cbTipoVenta.Value=3 Transferencia   
        Dim res As Boolean = L_fnGrabarProforma(txtIdVenta.Text, IIf(swServicio.Value, txtIdReciboV.Text, 0), IIf(swCirugia.Value, txtIdReciboV.Text, 0), IIf(swInternacion.Value, txtIdReciboV.Text, 0), _CodPaciente, _CodCliente, _CodEmpleado, cbTipoVenta.Value, dtpFVenta.Value.ToString("yyyy/MM/dd"),
                                             dtpFCredito.Value.ToString("yyyy/MM/dd"), txtObservacion.Text, txtMdesc.Value, txtTotalNeto.Value,
                                             CType(JGdetalleVenta.DataSource, DataTable), cbSucursal.Value, IIf(cbTipoVenta.Value = 0, txtAcuenta.Value, 0), cbEmision.Value, IIf(cbTipoVenta.Value = 2, txtTotalNeto.Value, 0), IIf(cbTipoVenta.Value = 3, txtTotalNeto.Value, 0), Turno)
        If res Then

            If (gb_FacturaEmite) Then
                'And TbNit.Text <> String.Empty And TbNit.Text <> String.Empty
                If cbEmision.Value = 1 Then
                    P_fnGenerarFactura(txtIdVenta.Text)
                End If
            End If

            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Código de Venta ".ToUpper + txtIdVenta.Text + " Grabado con Exito.".ToUpper,
                                      img, 2000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )
            '_prImiprimirNotaVenta(txtIdVenta.Text)
            _prCargarVenta()
            _prLimpiar()
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "La Venta no pudo ser insertado".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        End If
        Return res
    End Function


    Private Function P_fnGenerarFactura(numi As String) As Boolean
        Dim res As Boolean = False
        res = P_fnGrabarFacturarTFV001(numi) ' Grabar en la TFV001
        If (res) Then
            If (P_fnValidarFactura()) Then
                'Validar para facturar
                P_prImprimirFacturar(numi, True, True) '_Codigo de a tabla TV001
            Else
                'Volver todo al estada anterior
                ToastNotification.Show(Me, "No es posible facturar, vuelva a ingresar he intente nuevamente!!!".ToUpper,
                                       My.Resources.OK,
                                       5 * 1000,
                                       eToastGlowColor.Red,
                                       eToastPosition.MiddleCenter)
            End If

            If (Not TbNit.Text.Trim.Equals("0")) Then
                L_Grabar_Nit(TbNit.Text.Trim, TbNombre1.Text.Trim, "")
            Else
                L_Grabar_Nit(TbNit.Text, "S/N", "")
            End If
        End If

        Return res
    End Function
    Private Function P_fnGrabarFacturarTFV001(numi As String) As Boolean
        Dim a As Double = CDbl(txtTotalNeto.Value + txtMdesc.Value)
        'Dim b As Double = CDbl(IIf(IsDBNull(tbIce.Value), 0, tbIce.Value)) 'Ya esta calculado el 55% del ICE
        Dim b As Double = CDbl("0")
        Dim c As Double = CDbl("0")
        Dim d As Double = CDbl("0")
        Dim e As Double = a - b - c - d
        Dim f As Double = CDbl(txtMdesc.Value)
        Dim g As Double = e - f
        Dim h As Double = g * (gi_IVA / 100)
        Dim _Hora As String = Now.Hour.ToString("D2") + ":" + Now.Minute.ToString("D2")
        Dim res As Boolean = False
        'Grabado de Cabecera Factura
        L_Grabar_Factura(numi,
                        dtiFechaFactura.Value.ToString("yyyy/MM/dd"),
                        IIf(Val(tbNroFactura.Text) = 0, "0", tbNroFactura.Text),
                        IIf(Val(tbNroAutoriz.Text) = 0, "0", tbNroAutoriz.Text),
                        "1",
                        TbNit.Text.Trim,
                        "0",
                        TbNombre1.Text,
                        "",
                        CStr(Format(a, "####0.00")),
                        CStr(Format(b, "####0.00")),
                        CStr(Format(c, "####0.00")),
                        CStr(Format(d, "####0.00")),
                        CStr(Format(e, "####0.00")),
                        CStr(Format(f, "####0.00")),
                        CStr(Format(g, "####0.00")),
                        CStr(Format(h, "####0.00")),
                        "",
                        Now.Date.ToString("yyyy/MM/dd"),
                        "''",
                        cbSucursal.Value,
                        numi,
                         _Hora)

        'Grabado de Detalle de Factura
        JGdetalleVenta.Update()

        'Dim s As String = ""
        For Each fil As GridEXRow In JGdetalleVenta.GetRows
            If (Not fil.Cells("vbCant").Value.ToString.Trim.Equals("") And
                Not fil.Cells("vb_tyfnumi").Value.ToString.Trim.Equals("0")) Then
                's = fil.Cells("codP").Value
                's = fil.Cells("des").Value
                's = fil.Cells("can").Value
                's = fil.Cells("imp").Value
                L_Grabar_Factura_Detalle(numi.ToString,
                                        fil.Cells("vb_tyfnumi").Value.ToString.Trim,
                                        fil.Cells("Producto").Value.ToString.Trim,
                                        fil.Cells("vbCant").Value.ToString.Trim,
                                        fil.Cells("vbPrec").Value.ToString.Trim,
                                        numi)
                res = True
            End If
        Next
        Return res
    End Function
    Private Function P_fnValidarFactura() As Boolean
        Return True
    End Function
    Private Sub P_prImprimirFacturar(numi As String, impFactura As Boolean, grabarPDF As Boolean)
        MP_ImprimirFactura(numi, impFactura, grabarPDF, False)
    End Sub
    Private Sub MP_ImprimirFactura(numi As String, impFactura As Boolean, grabarPDF As Boolean, reimprimir As Boolean)

        Dim _Fecha, _FechaAl As Date
        Dim _DsFactura, _DsDosificacion, _DsDatos_Factura, _DsRutaImpresora As New DataSet
        Dim _Autorizacion, _Nit, _Fechainv, _Total, _Key, _Cod_Control, _Hora,
            _Literal, _TotalDecimal, _TotalDecimal2 As String
        Dim I, _NumFac, _numidosif, _TotalCC As Integer
        Dim ice, _Desc, _TotalLi As Decimal
        Dim _VistaPrevia As Integer = 0

        _Desc = CDbl(txtMdesc.Value)
        If Not IsNothing(P_Global.Visualizador) Then
            P_Global.Visualizador.Close()
        End If

        _DsFactura = L_Reporte_Factura(numi, numi)

        If reimprimir Then
            _Fecha = _DsFactura.Tables(0).Rows(0).Item("fvafec").ToString
        Else
            _Fecha = Now.Date
        End If

        _DsDosificacion = L_Dosificacion("1", "1", _Fecha)

        If reimprimir Then
            '_Fecha = _DsFactura.Tables(0).Rows(0).Item("fvafec").ToString
            _Hora = _DsFactura.Tables(0).Rows(0).Item("fvahora").ToString
            _NumFac = CInt(_DsFactura.Tables(0).Rows(0).Item("fvanfac"))
        Else
            '_Fecha = Now.Date
            _Hora = Now.Hour.ToString("D2") + ":" + Now.Minute.ToString("D2")
            _NumFac = CInt(_DsDosificacion.Tables(0).Rows(0).Item("sbnfac")) + 1
        End If


        _Autorizacion = _DsDosificacion.Tables(0).Rows(0).Item("sbautoriz").ToString
        _Nit = _DsFactura.Tables(0).Rows(0).Item("fvanitcli").ToString
        _Fechainv = Microsoft.VisualBasic.Right(_Fecha.ToShortDateString, 4) +
                    Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(_Fecha.ToShortDateString, 5), 2) +
                    Microsoft.VisualBasic.Left(_Fecha.ToShortDateString, 2)
        _Total = _DsFactura.Tables(0).Rows(0).Item("fvatotal").ToString
        ice = _DsFactura.Tables(0).Rows(0).Item("fvaimpsi")
        _numidosif = _DsDosificacion.Tables(0).Rows(0).Item("sbnumi").ToString
        _Key = _DsDosificacion.Tables(0).Rows(0).Item("sbkey")
        _FechaAl = _DsDosificacion.Tables(0).Rows(0).Item("sbfal")

        If reimprimir = False Then
            Dim maxNFac As Integer = L_fnObtenerMaxIdTabla("TFV001", "fvanfac", "fvaautoriz = " + _Autorizacion)
            _NumFac = maxNFac + 1
        End If

        _TotalCC = Math.Round(CDbl(_Total), MidpointRounding.AwayFromZero)
        _Cod_Control = ControlCode.generateControlCode(_Autorizacion, _NumFac, _Nit, _Fechainv, CStr(_TotalCC), _Key)

        'Literal 
        _TotalLi = _DsFactura.Tables(0).Rows(0).Item("fvasubtotal") - _DsFactura.Tables(0).Rows(0).Item("fvadesc")
        _TotalDecimal = _TotalLi - Math.Truncate(_TotalLi)
        _TotalDecimal2 = CDbl(_TotalDecimal) * 100

        'Dim li As String = Facturacion.ConvertirLiteral.A_fnConvertirLiteral(CDbl(_Total) - CDbl(_TotalDecimal)) + " con " + IIf(_TotalDecimal2.Equals("0"), "00", _TotalDecimal2) + "/100 Bolivianos"
        _Literal = Facturacion.ConvertirLiteral.A_fnConvertirLiteral(CDbl(_TotalLi) - CDbl(_TotalDecimal)) + " con " + IIf(_TotalDecimal2.Equals("0"), "00", _TotalDecimal2) + "/100 Bolivianos"
        _DsDatos_Factura = L_Reporte_Factura_Cia("1")

        L_Modificar_Factura("fvanumi = " + CStr(numi),
                            "",
                            CStr(_NumFac),
                            CStr(_Autorizacion),
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            _Cod_Control,
                            _FechaAl.ToString("yyyy/MM/dd"),
                            "",
                            "",
                            CStr(numi))

        QrFactura.Text = _DsDatos_Factura.Tables(0).Rows(0).Item("scnit").ToString + "|" + Str(_NumFac).Trim + "|" + _Autorizacion + "|" + _Fecha + "|" + _Total + "|" + _TotalLi.ToString + "|" + _Cod_Control + "|" + TbNit.Text.Trim + "|" + ice.ToString + "|0|0|" + Str(_Desc).Trim
        _DsFactura = L_Reporte_Factura(numi, numi)

        Dim fechaLiteral = ObtenerFechaLiteral(_Fecha, _DsDatos_Factura.Tables(0).Rows(0).Item("scciu").ToString)

        For I = 0 To _DsFactura.Tables(0).Rows.Count - 1
            _DsFactura.Tables(0).Rows(I).Item("fvaimgqr") = P_fnImageToByteArray(QrFactura.Image)
        Next
        If (impFactura) Then
            For imp = 1 To 2
                _DsRutaImpresora = L_ObtenerRutaImpresora("1") ' Datos de Impresion de Facturación
                If (_DsRutaImpresora.Tables(0).Rows(0).Item("cbvp")) Then 'Vista Previa de la Ventana de Vizualización 1 = True 0 = False
                    P_Global.Visualizador = New Visualizador 'Comentar
                End If
                Dim objrep As Object = Nothing
                If (gi_FacturaTipo = 1) Then
                    'objrep = New R_FacturaG
                ElseIf (gi_FacturaTipo = 2) Then
                    objrep = New R_FacturaCarta
                End If

                objrep.SetDataSource(_DsFactura.Tables(0))
                objrep.SetParameterValue("Hora", _Hora)
                objrep.SetParameterValue("Fecliteral", fechaLiteral)
                objrep.SetParameterValue("ENombre", _DsDatos_Factura.Tables(0).Rows(0).Item("scneg").ToString)
                objrep.SetParameterValue("ECasaMatriz", _DsDatos_Factura.Tables(0).Rows(0).Item("scsuc").ToString)
                objrep.SetParameterValue("Direccionpr", _DsDatos_Factura.Tables(0).Rows(0).Item("scdir").ToString)
                objrep.SetParameterValue("Telefonopr", _DsDatos_Factura.Tables(0).Rows(0).Item("sctelf").ToString)
                objrep.SetParameterValue("ECiudadPais", _DsDatos_Factura.Tables(0).Rows(0).Item("scpai").ToString)
                objrep.SetParameterValue("ESFC", _DsDosificacion.Tables(0).Rows(0).Item("sbsfc").ToString)
                objrep.SetParameterValue("Literal1", _Literal)
                objrep.SetParameterValue("NroFactura", _NumFac)
                objrep.SetParameterValue("NroAutoriz", _Autorizacion)
                objrep.SetParameterValue("ENit", _DsDatos_Factura.Tables(0).Rows(0).Item("scnit").ToString)
                objrep.SetParameterValue("EActividad", _DsDatos_Factura.Tables(0).Rows(0).Item("scact").ToString)
                objrep.SetParameterValue("ENota", "''" + _DsDosificacion.Tables(0).Rows(0).Item("sbnota").ToString + "''")
                objrep.SetParameterValue("ELey", "''" + _DsDosificacion.Tables(0).Rows(0).Item("sbnota2").ToString + "''")
                ' objrep.SetParameterValue("EDuenho", _DsDatos_Factura.Tables(0).Rows(0).Item("scnom").ToString) 
                'objrep.SetParameterValue("URLImageLogo", gs_CarpetaRaiz + "\LogoFactura.jpg")
                'objrep.SetParameterValue("URLImageMarcaAgua", gs_CarpetaRaiz + "\MarcaAguaFactura.jpg")

                If imp = 1 Then
                    objrep.SetParameterValue("Tipo", "ORIGINAL")
                Else
                    objrep.SetParameterValue("Tipo", "COPIA")
                End If

                'Ruta de impresion, visualizador o Directa
                If (_DsRutaImpresora.Tables(0).Rows(0).Item("cbvp")) Then 'Vista Previa de la Ventana de Vizualización 1 = True 0 = False
                    P_Global.Visualizador.CrGeneral.ReportSource = objrep 'Comentar
                    P_Global.Visualizador.ShowDialog() 'Comentar
                    P_Global.Visualizador.BringToFront() 'Comentar
                Else
                    Dim pd As New PrintDocument()
                    pd.PrinterSettings.PrinterName = _DsRutaImpresora.Tables(0).Rows(0).Item("cbrut").ToString
                    If (Not pd.PrinterSettings.IsValid) Then
                        ToastNotification.Show(Me, "La Impresora ".ToUpper + _DsRutaImpresora.Tables(0).Rows(0).Item("cbrut").ToString + Chr(13) + "No Existe".ToUpper,
                                           My.Resources.WARNING, 5 * 1000,
                                           eToastGlowColor.Blue, eToastPosition.BottomRight)
                    Else
                        objrep.PrintOptions.PrinterName = _DsRutaImpresora.Tables(0).Rows(0).Item("cbrut").ToString
                        objrep.PrintToPrinter(1, False, 1, 1)
                    End If
                End If

                'If reimprimir = False Then
                '    'Copia la factura en PDF
                '    If (grabarPDF) Then
                '        If (Not Directory.Exists(gs_CarpetaRaiz + "\Facturas")) Then
                '            Directory.CreateDirectory(gs_CarpetaRaiz + "\Facturas")
                '        End If
                '        objrep.ExportToDisk(ExportFormatType.PortableDocFormat, gs_CarpetaRaiz + "\Facturas\" + CStr(_NumFac) + "_" + CStr(_Autorizacion) + ".pdf")
                '    End If
                'End If
            Next
        End If
        If reimprimir = False Then
            L_Actualiza_Dosificacion(_numidosif, _NumFac, numi)
        End If
    End Sub
    Private Function ObtenerFechaLiteral(Fecliteral As String, ciudad As String) As String
        Dim dia, mes, ano As Integer
        Dim mesl As String
        dia = Microsoft.VisualBasic.Left(Fecliteral, 2)
        mes = Microsoft.VisualBasic.Mid(Fecliteral, 4, 2)
        ano = Microsoft.VisualBasic.Mid(Fecliteral, 7, 4)
        If mes = 1 Then
            mesl = "Enero"
        End If
        If mes = 2 Then
            mesl = "Febrero"
        End If
        If mes = 3 Then
            mesl = "Marzo"
        End If
        If mes = 4 Then
            mesl = "Abril"
        End If
        If mes = 5 Then
            mesl = "Mayo"
        End If
        If mes = 6 Then
            mesl = "Junio"
        End If
        If mes = 7 Then
            mesl = "Julio"
        End If
        If mes = 8 Then
            mesl = "Agosto"
        End If
        If mes = 9 Then
            mesl = "Septiembre"
        End If
        If mes = 10 Then
            mesl = "Octubre"
        End If
        If mes = 11 Then
            mesl = "Noviembre"
        End If
        If mes = 12 Then
            mesl = "Diciembre"
        End If
        Fecliteral = ciudad + ", " + dia.ToString + " de " + mesl + " del " + ano.ToString
        Return Fecliteral
    End Function
    Public Function _prValidar() As Boolean
        'If (txtAcuenta.Value = 0) Then
        '    Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
        '    ToastNotification.Show(Me, "Por Favor debe especificar el campo A Cuenta".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        '    Return False
        'End If
        'If (txtAcuenta.Value < txtTotalNeto.Value) Then
        '    Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
        '    ToastNotification.Show(Me, "Por Favor debe cambiar el Tipo Venta a 'CRÉDITO' ".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        '    Return False
        'End If

        'Return True
    End Function


    ''*****MODDIFICA EL REGISTRO*****''
    Public Overrides Function _PMOModificarRegistro() As Boolean
        '_prUnirTabla(
        Dim res As Boolean = False
        If cbTipoVenta.Value = 0 Then 'Quiere decir si es al Crédito
            If L_fnVerificarCantidadPagoCredito(txtIdVenta.Text, txtAcuenta.Value, txtTotalNeto.Value) Then
                Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                ToastNotification.Show(Me, "La Venta no puede ser Modificada, el A cuenta supera al Total Neto, modifíquelo".ToUpper, img, 4000, eToastGlowColor.Red, eToastPosition.TopCenter)

                Exit Function
            End If
        End If

        res = L_fnModificarVenta(txtIdVenta.Text, IIf(swServicio.Value, txtIdReciboV.Text, 0), IIf(swCirugia.Value, txtIdReciboV.Text, 0), IIf(swInternacion.Value, txtIdReciboV.Text, 0), _CodPaciente, _CodCliente, _CodEmpleado, cbTipoVenta.Value, dtpFVenta.Value.ToString("yyyy/MM/dd"),
                                            dtpFCredito.Value.ToString("yyyy/MM/dd"), txtObservacion.Text, txtMdesc.Value, txtTotalNeto.Value,
                                            CType(JGdetalleVenta.DataSource, DataTable), cbSucursal.Value, IIf(cbTipoVenta.Value = 0, txtAcuenta.Value, 0), cbEmision.Value, IIf(cbTipoVenta.Value = 2, txtTotalNeto.Value, 0), IIf(cbTipoVenta.Value = 3, txtTotalNeto.Value, 0))
        If res Then
            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Código de Venta ".ToUpper + txtIdVenta.Text + " Modificado con Exito.".ToUpper,
                                      img, 2000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )
            _prImiprimirNotaVenta(txtIdVenta.Text)
            _prInhabiliitar()
            _prFiltrar(2)
        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "La Venta no pudo ser Modificada".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        End If

    End Function
    ''*****ELIMINAR EL REGISTRO*****''
    Public Overrides Sub _PMOEliminarRegistro()
        'If (gb_FacturaEmite) Then
        '    If (P_fnValidarFacturaVigente()) Then
        '        Dim img As Bitmap = New Bitmap(My.Resources.WARNING, 50, 50)

        '        ToastNotification.Show(Me, "No se puede eliminar la venta con codigo: ".ToUpper + txtIdVenta.Text + ", su factura está vigente, por favor primero anule la factura".ToUpper,
        '                                      img, 2000,
        '                                      eToastGlowColor.Green,
        '                                      eToastPosition.TopCenter)
        '        Exit Sub
        '    End If
        'End If
        'If (cbTipoVenta.Value = 0) Then
        '    Dim res1 As Boolean = L_fnVerificarPagosVentas(txtIdVenta.Text)
        '    If res1 Then
        '        Dim img As Bitmap = New Bitmap(My.Resources.WARNING, 50, 50)
        '        ToastNotification.Show(Me, "No se puede eliminar la venta con código ".ToUpper + txtIdVenta.Text + ", porque tiene pagos realizados, por favor primero elimine los pagos correspondientes a esta venta".ToUpper,
        '                                      img, 5000,
        '                                      eToastGlowColor.Green,
        '                                      eToastPosition.TopCenter)
        '        Exit Sub
        '    End If
        'End If


        Dim ef = New Efecto
        ef.tipo = 2
        ef.Context = "¿esta seguro de eliminar el registro?".ToUpper
        ef.Header = "mensaje principal".ToUpper
        ef.ShowDialog()
        Dim bandera As Boolean = False
        bandera = ef.band
        If (bandera = True) Then
            Dim mensajeError As String = ""
            Dim res As Boolean = L_fnEliminarProforma(txtIdVenta.Text, IIf(swServicio.Value, txtIdReciboV.Text, "0"), IIf(swCirugia.Value, txtIdReciboV.Text, "0"), IIf(swInternacion.Value, txtIdReciboV.Text, "0"), mensajeError)
            If res Then
                Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)

                ToastNotification.Show(Me, "Código de la venta ".ToUpper + txtIdVenta.Text + " eliminado con Exito.".ToUpper,
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
    Private Function P_fnValidarFacturaVigente() As Boolean
        Dim est As String = L_fnObtenerDatoTabla("TFV001", "fvaest", "fvanumi=" + txtIdVenta.Text.Trim)
        Return (est.Equals("True"))
    End Function
    'Public Function _ValidarCampos() As Boolean
    '    If (_CodCliente <= 0) Then
    '        Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
    '        ToastNotification.Show(Me, "Por Favor Seleccione un Cliente con Ctrl+Enter".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
    '        txtIdCliente.Focus()
    '        Return False

    '    End If
    '    If (_CodEmpleado <= 0) Then
    '        Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
    '        ToastNotification.Show(Me, "Por Favor Seleccione un Vendedor con Ctrl+Enter".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
    '        txtIdVendedor.Focus()
    '        Return False
    '    End If
    '    If (JGdetalleVenta.RowCount = 1) Then
    '        JGdetalleVenta.Row = JGdetalleVenta.RowCount - 1
    '        If (JGdetalleVenta.GetValue("vb_tyfnumi") = 0) Then
    '            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
    '            ToastNotification.Show(Me, "Por Favor Seleccione  un detalle de producto".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
    '            Return False
    '        End If
    '    End If
    '    Return True
    'End Function
    Public Overrides Function _PMOValidarCampos() As Boolean
        Try
            Dim fecha As String = Now.Date
            Dim dtDosificacion As DataSet = L_Dosificacion("1", "1", fecha)

            If (_CodCliente <= 0) Then
                Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                ToastNotification.Show(Me, "Por Favor Seleccione un Cliente con Ctrl+Enter".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
                txtIdCliente.Focus()
                Return False
            End If
            If (_CodPaciente <= 0) Then
                Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                ToastNotification.Show(Me, "Por Favor Seleccione un Paciente con Ctrl+Enter".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
                txtIdPaciente.Focus()
                Return False
            End If
            If (_CodEmpleado <= 0) Then
                Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                ToastNotification.Show(Me, "Por Favor Seleccione un Vendedor con Ctrl+Enter".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
                txtIdVendedor.Focus()
                Return False
            End If

            'Valida que al Credito solo vayan las ventas de atencion y no ventas normales
            If cbTipoVenta.Value = 0 Then
                If (swServicio.Value = False And swInternacion.Value = False And swCirugia.Value = False) Then
                    Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                    ToastNotification.Show(Me, "Esta venta no puede ser grabada al Crédito, elija otro tipo de venta".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
                    TbNit.Focus()
                    Return False
                End If
            End If

            'Validar datos de factura
            If cbEmision.Value = 1 Then
                If (TbNit.Text = String.Empty) Then
                    Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                    ToastNotification.Show(Me, "Por Favor ponga el nit del cliente.".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
                    TbNit.Focus()
                    Return False
                End If

                If (TbNombre1.Text = String.Empty) Then
                    Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                    ToastNotification.Show(Me, "Por Favor ponga la razón social del cliente.".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
                    TbNombre1.Focus()
                    Return False
                End If

                If dtDosificacion.Tables(0).Rows.Count = 0 Then
                    'dtDosificacion.Tables.Cast(Of DataTable)().Any(Function(x) x.DefaultView.Count = 0)
                    Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                    ToastNotification.Show(Me, "La Dosificación para las facturas ya caducó, ingrese nueva dosificación".ToUpper, img, 3500, eToastGlowColor.Red, eToastPosition.TopCenter)
                    Return False
                End If
            End If


            If (JGdetalleVenta.RowCount = 1) Then
                JGdetalleVenta.Row = JGdetalleVenta.RowCount - 1
                If (JGdetalleVenta.GetValue("vb_tyfnumi") = 0) Then
                    Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                    ToastNotification.Show(Me, "Por Favor Seleccione  un detalle para la Venta".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
                    Return False
                End If
            End If


            Return True
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
            Return False
        End Try
    End Function
    Private Sub MostrarMensajeError(mensaje As String)
        ToastNotification.Show(Me,
                               mensaje.ToUpper,
                               My.Resources.WARNING,
                               5000,
                               eToastGlowColor.Red,
                               eToastPosition.TopCenter)

    End Sub
    Public Overrides Sub _PMONuevo()
        'JGBusqRecibos.Enabled = False 'Deshabilita el buscador de la Grilla
        _prLimpiar()
        _prhabilitar()

    End Sub
    Public Overrides Sub _PMOModificar()
        'JGBusqRecibos.Enabled = False 'Deshabilita el buscador de la Grilla
        _prhabilitar()

        'Deshabilito Emision y Tipo Venta 
        cbEmision.ReadOnly = True
        cbTipoVenta.ReadOnly = True
        txtIdVendedor.Enabled = False
    End Sub
    Public Overrides Sub _PMOSalir()
        _prInhabiliitar()
        _prFiltrar(1)
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If cbEmision.Value = 1 Then
            MP_ImprimirFactura(txtIdVenta.Text, True, True, True)
        End If
        P_GenerarReporte(txtIdVenta.Text)
    End Sub

    Private Sub txtAcuenta_ValueChanged(sender As Object, e As EventArgs) Handles txtAcuenta.ValueChanged
        txtSaldo.Text = txtTotalNeto.Value - txtAcuenta.Value
    End Sub

    'Seleccion de Tipo de venta
    Private Sub cbTipoVenta_ValueChanged(sender As Object, e As EventArgs) Handles cbTipoVenta.ValueChanged
        'cbTipoVenta.Value=0 Credito, cbTipoVenta.Value=1 Contado, cbTipoVenta.Value=2 Tarjeta, cbTipoVenta.Value=3 Transferencia   
        If (cbTipoVenta.Value = 0) Then
            lbVencCredito.Visible = True
            dtpFCredito.Visible = True
            dtpFCredito.Value = DateAdd(DateInterval.Day, _dias, Now.Date)

            lbAcuenta.Visible = True
            txtAcuenta.Visible = True
            lbSaldo.Visible = True
            txtSaldo.Visible = True
        Else
            lbVencCredito.Visible = False
            dtpFCredito.Visible = False

            lbAcuenta.Visible = False
            txtAcuenta.Visible = False
            lbSaldo.Visible = False
            txtSaldo.Visible = False
        End If

    End Sub

    Private Sub cbEmision_ValueChanged(sender As Object, e As EventArgs) Handles cbEmision.ValueChanged
        If cbEmision.Value = 1 Then
            GroupPanelFactura2.Visible = True
        Else
            GroupPanelFactura2.Visible = False
        End If
    End Sub

    Private Sub TbNit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TbNit.Validating
        Dim nom1, nom2 As String
        nom1 = ""
        nom2 = ""
        If (TbNit.Text.Trim = String.Empty) Then
            TbNit.Text = "0"
        End If
        L_Validar_Nit(TbNit.Text.Trim, nom1, nom2)
        TbNombre1.Text = nom1
    End Sub


    Private Sub TbNit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbNit.KeyPress
        g_prValidarTextBox(1, e)
    End Sub

    Private Sub grVentas_DoubleClick(sender As Object, e As EventArgs) Handles grVentas.DoubleClick
        superTabControl1.SelectedTabIndex = 0
    End Sub

    Private Sub F1_Ven_Venta_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        _prCambiarColorPlomoOscuro(Presentacion.Principal.btnVenta)
    End Sub

    Private Sub swMostrar_ValueChanged(sender As Object, e As EventArgs) Handles swMostrar.ValueChanged
        _prCargarVenta()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

    End Sub










#End Region
End Class