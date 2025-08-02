Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Rendering
Imports Logica.AccesoLogica
Imports Modelo.MGlobal

Public Class Principal
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.WindowState = FormWindowState.Maximized
        _prCambiarStyle()
        ' Add any initialization after the InitializeComponent() call.  
    End Sub
    Private Sub _prCambiarStyle()
        'tratar de cambiar estilo
        RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(Me, DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.VistaGlass)

        Dim table As Office2007ColorTable = CType(GlobalManager.Renderer, Office2007Renderer).ColorTable
        Dim ct As SideNavColorTable = table.SideNav
        'ct.TitleBackColor = Color.LightSeaGreen;
        'ct.SideNavItem.Default.BackColors = New Color[] { Color.LightSeaGreen};
        'ct.ItemsBackColor=  Color.LightSeaGreen ;
        Dim myColor As New Color
        myColor = ColorTranslator.FromHtml("#17754E")
        ct.SideNavItem.Selected.BackColors = New Color() {myColor}
    End Sub
    Public Sub _prCambiarColorVerde(boton As Metro.MetroTileItem)
        Dim myColor As New Color
        myColor = ColorTranslator.FromHtml("#17754E")
        boton.TileStyle.BackColor = myColor
        boton.TileStyle.BackColor2 = myColor
    End Sub
    Private Sub _prIniciarTodo()
        'Leer Archivo de Configuración
        '_prLeerArchivoConfig()
        'L_prAbrirConexion(gs_Ip, gs_UsuarioSql, gs_ClaveSql, gs_NombreBD)
        '_prLogin()
        Me.WindowState = FormWindowState.Maximized
        M_Configuracion.Select()
        'L_Usuario = gs_user
        'lbUsuario.Text = gs_user
        M_Informes.Visible = False
        M_Inventario.Visible = False
        P_prCargarParametros()
        _prValidarMayusculas()
        _prCambiarNombreBotones()
    End Sub
    Private Sub P_prCargarParametros()
        Dim dtConfSistema As DataTable = L_fnConfSistemaGeneral()

        gb_FacturaEmite = dtConfSistema.Rows(0).Item("cccefac")
        gi_FacturaTipo = dtConfSistema.Rows(0).Item("ccctfac")
        gi_FacturaCantidadItems = dtConfSistema.Rows(0).Item("ccccite")
        gb_FacturaIncluirICE = dtConfSistema.Rows(0).Item("ccciice")
        'gi_codeBar = dtConfSistema.Rows(0).Item("ccciice")
        gb_CodigoBarra = dtConfSistema.Rows(0).Item("ccccbar")
        'gb_DetalleProducto = dtConfSistema.Rows(0).Item("cccdetp")
    End Sub
    Public Sub _prValidarMayusculas()
        Dim dt As DataTable = L_fnPorcUtilidad()
        If (dt.Rows.Count > 0) Then
            Modelo.MGlobal.gs_mayusculas = dt.Rows(0).Item("mayusculas")
        End If
    End Sub
    Public Sub _prCambiarNombreBotones()
        btnFichaAtencion.TitleText = "FICHA" + vbCrLf + "ATENCIÓN"
        btnFichaClinica.TitleText = "FICHA" + vbCrLf + "CLÍNICA"
        btnSegInternacion.TitleText = "SEGUIMIENTO" + vbCrLf + "INTERNACIÓN"
        btnReciboCirugia.TitleText = "RECIBO" + vbCrLf + "CIRUGÍA"
        btnRepVetMascAten.TitleText = "REP. HORAS" + vbCrLf + "ATENDIDAS" + vbCrLf + "VETERINARIO"
        btnPacientesAten.TitleText = "REP." + vbCrLf + "PACIENTES" + vbCrLf + "ATENDIDOS"
        btComPagosCredito.TitleText = "PAGOS" + vbCrLf + "COMPRA" + vbCrLf + "CRÉDITOS"
        btnKardex.TitleText = "KARDEX" + vbCrLf + "PRODUCTO"
        btnSaldoProducto.TitleText = "SALDO" + vbCrLf + "PRODUCTOS"
        btnKardexProducto.TitleText = "REPORTE" + vbCrLf + "KARDEX" + vbCrLf + "PRODUCTOS"
        btnSaldosValorados.TitleText = "SALDOS" + vbCrLf + "VALORADOS"
        btnInvSaldoLote.TitleText = "STOCK" + vbCrLf + "ACTUAL" + vbCrLf + "POR LOTES"
        btnVentasAtendidas.TitleText = "VENTAS" + vbCrLf + "ATENDIDAS"
        btnAnularFactura.TitleText = "ANULAR" + vbCrLf + "FACTURA"
        btnLibroVenta.TitleText = "LIBRO DE" + vbCrLf + "VENTAS"
        btnIngresoEgreso.TitleText = "INGRESO" + vbCrLf + "EGRESO"
        btnArqueoDiario.TitleText = "ARQUEO" + vbCrLf + "DIARIO"
        btnDetalleAtenciones.TitleText = "DETALLE DE" + vbCrLf + "ATENCIONES" + vbCrLf + "DIARIAS"
        btnPagosCliente.TitleText = "PAGOS POR" + vbCrLf + "CLIENTE"
        btnReporteNotasPorCobrar.TitleText = "NOTAS" + vbCrLf + "POR" + vbCrLf + "COBRAR"
        btnReportePagos.TitleText = "REPORTE" + vbCrLf + "PAGOS"
        btnRealizarPAgos.TitleText = "REALIZAR" + vbCrLf + "PAGOS"
        btnReporteKArdex.TitleText = "ESTADO DE" + vbCrLf + "CUENTAS"
        btnFichaAtencionC.TitleText = "FICHA" + vbCrLf + "ATENCIÓN" + vbCrLf + "CLIENTE"
        btProforma.TitleText = "PROFORMA"
        btnVentasServicio.TitleText = "VENTAS POR" + vbCrLf + "SERVICIO"
    End Sub
    Private Sub _prLeerArchivoConfig()
        Try
            Dim Archivo() As String = IO.File.ReadAllLines(Application.StartupPath + "\CONFIG.TXT")
            gs_Ip = Archivo(0).Split("=")(1).Trim
            gs_UsuarioSql = Archivo(1).Split("=")(1).Trim
            gs_ClaveSql = Archivo(2).Split("=")(1).Trim
            gs_NombreBD = Archivo(3).Split("=")(1).Trim
            gs_CarpetaRaiz = Archivo(4).Split("=")(1).Trim

        Catch ex As Exception
            MessageBox.Show("No se encontró el archivo 'CONFIG.TXT' para la conexión a la base de datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Close()

        End Try

    End Sub

    Private Sub _prLogin()
        Dim ef = New Efecto
        ef.tipo = 4
        ef.ShowDialog()

        L_Usuario = gs_user
        Modelo.MGlobal.gs_usuario = gs_user

        lbUsuario.Text = gs_user
        lbUsuario.Font = New Font("Tahoma", 12, FontStyle.Bold)

        If gs_user = "DEFAULT" Then
            sideNav1.Enabled = False
        Else
            '_PCargarPrivilegios()
            '_prCargarConfiguracionSistema()
            sideNav1.Enabled = True
        End If

        'P_prCargarParametros()
        '_prValidarMayusculas()
    End Sub
    Private Sub btnCliente_Click(sender As Object, e As EventArgs)
        Dim frm As New F0_Reg_Clientes
        'frm._modulo = FP_Configuracion
        '_nameButton =
        frm.Show()

    End Sub

    Private Sub btnPrecio_Click(sender As Object, e As EventArgs)
        Dim frm As New F0_Precios
        frm.Show()
    End Sub



    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        _prCambiarColorVerde(btnClientes)
        Dim frm As New F0_Reg_Clientes
        'frm._modulo = FP_Configuracion
        Modelo.MGlobal._nameButton = btnClientes.Name
        frm.Show()
    End Sub

    Private Sub btnFichaAtencion_Click(sender As Object, e As EventArgs)
        Dim frm As New F_Fic_FichaAtencion
        'frm._modulo = FP_Configuracion
        frm.Show()
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
    End Sub

    Private Sub Principal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        '_Salir()
        'Me.Close()
        Application.Exit()
    End Sub
    Private Sub _Salir()
        ' Me.Close()
        Application.ExitThread()

    End Sub

    Private Sub btnPacientes_Click(sender As Object, e As EventArgs) Handles btnPacientes.Click
        _prCambiarColorVerde(btnPacientes)
        Dim frm As New F1_Reg_Pacientes
        frm._Iniciar = 3
        Modelo.MGlobal._nameButton = btnPacientes.Name
        'frm._modulo = FP_Configuracion
        frm.Show()
    End Sub



    Private Sub btnFichaAtencion_Click_1(sender As Object, e As EventArgs) Handles btnFichaAtencion.Click
        _prCambiarColorVerde(btnFichaAtencion)
        Dim frm As New F_Fic_FichaAtencion
        'frm._nameButton = btnFichaAtencion.Name
        frm.Show()
    End Sub

    Private Sub btnVenta_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        _prCambiarColorVerde(btnVenta)
        Dim frm As New F1_Ven_Venta
        Modelo.MGlobal._nameButton = btnVenta.Name
        frm.Show()
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        _prCambiarColorVerde(btnProductos)
        Dim frm As New F1_Productos
        Modelo.MGlobal._nameButton = btnProductos.Name
        frm.Show()
    End Sub

    Private Sub MetroTileItem14_Click(sender As Object, e As EventArgs)
        Dim frm As New Form1
        frm.Show()
    End Sub

    Private Sub btnRoles_Click(sender As Object, e As EventArgs) Handles btnRoles.Click
        _prCambiarColorVerde(btnRoles)
        Dim frm As New F1_Rol
        Modelo.MGlobal._nameButton = btnRoles.Name
        frm.Show()
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        _prCambiarColorVerde(btnUsuarios)
        Dim frm As New F1_Con_Usuarios
        Modelo.MGlobal._nameButton = btnUsuarios.Name
        frm.Show()
    End Sub

    Private Sub btnMovimientos_Click(sender As Object, e As EventArgs) Handles btnMovimientos.Click
        _prCambiarColorVerde(btnMovimientos)
        Dim frm As New F0_Movimiento
        Modelo.MGlobal._nameButton = btnMovimientos.Name
        frm.Show()
    End Sub

    Private Sub btnLibrerias_Click(sender As Object, e As EventArgs) Handles btnLibrerias.Click
        _prCambiarColorVerde(btnLibrerias)
        Dim frm As New F1_Con_Librerias
        Modelo.MGlobal._nameButton = btnLibrerias.Name
        frm.Show()
    End Sub

    Private Sub btnAlmacen_Click(sender As Object, e As EventArgs) Handles btnAlmacen.Click
        _prCambiarColorVerde(btnAlmacen)
        Dim frm As New F1_Almacen
        Modelo.MGlobal._nameButton = btnAlmacen.Name
        frm.Show()
    End Sub

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        _prCambiarColorVerde(btnEmpleados)
        Dim frm As New F1_Reg_Empleados
        Modelo.MGlobal._nameButton = btnEmpleados.Name
        frm.Show()
    End Sub



    Private Sub btnFichaClinica_Click(sender As Object, e As EventArgs) Handles btnFichaClinica.Click
        _prCambiarColorVerde(btnFichaClinica)
        Dim frm As New F1_Fic_FichaClinica
        Modelo.MGlobal._nameButton = btnFichaClinica.Name
        frm._Iniciar = 3
        frm.Show()
    End Sub

    Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
        _prCambiarColorVerde(btnProveedor)
        Dim frm As New F1_Proveedor
        Modelo.MGlobal._nameButton = btnProveedor.Name
        frm.Show()
    End Sub

    Private Sub btnCompras_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
        _prCambiarColorVerde(btnCompras)
        Dim frm As New F0_MCompras
        Modelo.MGlobal._nameButton = btnCompras.Name
        frm.Show()
    End Sub

    Private Sub btnRepVetMascAten_Click(sender As Object, e As EventArgs) Handles btnRepVetMascAten.Click
        _prCambiarColorVerde(btnRepVetMascAten)
        Dim frm As New Pr_MascotasAtendidas
        frm.Show()
    End Sub

    Private Sub btnSegInternacion_Click(sender As Object, e As EventArgs) Handles btnSegInternacion.Click
        _prCambiarColorVerde(btnSegInternacion)
        Dim frm As New F1_Fic_SegInternacion2
        Modelo.MGlobal._nameButton = btnSegInternacion.Name
        frm.Show()
    End Sub

    Private Sub btnServicios_Click(sender As Object, e As EventArgs) Handles btnServicios.Click
        _prCambiarColorVerde(btnServicios)
        Dim frm As New F1_Con_Servicios
        Modelo.MGlobal._nameButton = btnServicios.Name
        frm.Show()
    End Sub

    Private Sub btProducto_Click(sender As Object, e As EventArgs)
        Dim frm As New F1_Productos
        frm.Show()
    End Sub

    Private Sub btnKardex_Click(sender As Object, e As EventArgs) Handles btnKardex.Click
        _prCambiarColorVerde(btnKardex)
        Dim frm As New F0_KardexMovimiento
        Modelo.MGlobal._nameButton = btnKardex.Name
        frm.Show()
    End Sub

    Private Sub btnSaldoProducto_Click(sender As Object, e As EventArgs) Handles btnSaldoProducto.Click
        _prCambiarColorVerde(btnSaldoProducto)
        Dim frm As New Pr_SAldosPorAlmacenLinea
        Modelo.MGlobal._nameButton = btnSaldoProducto.Name
        frm.Show()
    End Sub

    Private Sub btnKardexProducto_Click(sender As Object, e As EventArgs) Handles btnKardexProducto.Click
        _prCambiarColorVerde(btnKardexProducto)
        Dim frm As New Pr_KardexProductos
        frm.Show()
    End Sub

    Private Sub btnSaldosValorados_Click(sender As Object, e As EventArgs) Handles btnSaldosValorados.Click
        _prCambiarColorVerde(btnSaldosValorados)
        Dim frm As New Pr_StockUtilidad
        frm.Show()
    End Sub

    Private Sub MetroTileItem3_Click(sender As Object, e As EventArgs)
        Dim frm As New Form1
        frm.Show()
    End Sub

    Private Sub M_Configuracion_Click(sender As Object, e As EventArgs) Handles M_Configuracion.Click

    End Sub

    Private Sub btnPrecios_Click(sender As Object, e As EventArgs) Handles btnPrecios.Click
        _prCambiarColorVerde(btnPrecios)
        Dim frm As New F0_Precios
        Modelo.MGlobal._nameButton = btnPrecios.Name
        frm.Show()
    End Sub

    Private Sub btnPacientesAten_Click(sender As Object, e As EventArgs) Handles btnPacientesAten.Click
        _prCambiarColorVerde(btnPacientesAten)
        Dim frm As New Pr_PacientesPorDia
        frm.Show()
    End Sub

    Private Sub CerrarSesion_Click(sender As Object, e As EventArgs) Handles CerrarSesion.Click
        rmSesion.IsOpen = True
        rmSesion.MenuLocation = New Point(Me.Width / 2, Me.Height / 3)
        'SideNav_Conf.Select()
    End Sub

    Private Sub rmSesion_ItemClick(sender As Object, e As EventArgs) Handles rmSesion.ItemClick
        Dim item As RadialMenuItem = TryCast(sender, RadialMenuItem)
        If item IsNot Nothing AndAlso (Not String.IsNullOrEmpty(item.Text)) Then
            Dim sesion As New Login
            Select Case item.Name
                Case "btnCerrarSesion"
                    Me.Hide()
                    'Me.Close()
                    'Application.ExitThread()
                    'Login.Visible = True
                    M_Configuracion.Select()
                    Login.Show()
                    Login.txtUsuario.BackColor = Color.Black
                    Login.txtUsuario.ForeColor = Color.White
                    Login.txtPassword.BackColor = Color.Black
                    Login.txtPassword.ForeColor = Color.White
                Case "btnSalir"
                    _Salir()
                Case "btnAbout"
                    'Dim frm As New P_Acerca
                    'frm.ShowDialog()
            End Select
        End If
    End Sub


    Private Sub btnReciboCirugia_Click(sender As Object, e As EventArgs) Handles btnReciboCirugia.Click
        _prCambiarColorVerde(btnReciboCirugia)
        Dim frm As New F1_Fic_ReciboCirugia
        Modelo.MGlobal._nameButton = btnReciboCirugia.Name
        frm.Show()
    End Sub

    Private Sub btnPagosCliente_Click(sender As Object, e As EventArgs) Handles btnPagosCliente.Click
        _prCambiarColorVerde(btnPagosCliente)
        Dim frm As New F0_Cobrar_Cliente
        Modelo.MGlobal._nameButton = btnPagosCliente.Name
        frm.Show()
    End Sub

    Private Sub btnReporteNotasPorCobrar_Click(sender As Object, e As EventArgs) Handles btnReporteNotasPorCobrar.Click
        _prCambiarColorVerde(btnReporteNotasPorCobrar)
        Dim frm As New Pr_ReporteMorosidadGeneral
        Modelo.MGlobal._nameButton = btnReporteNotasPorCobrar.Name
        frm.Show()
    End Sub

    Private Sub btnReportePagos_Click(sender As Object, e As EventArgs) Handles btnReportePagos.Click
        _prCambiarColorVerde(btnReportePagos)
        Dim frm As New PR_ResumenCaja
        Modelo.MGlobal._nameButton = btnReportePagos.Name
        frm.Show()
    End Sub

    Private Sub btVentVenta_Click(sender As Object, e As EventArgs) Handles btnVentasAtendidas.Click
        _prCambiarColorVerde(btnVentasAtendidas)
        Dim frm As New Pr_VentasAtendidas
        Modelo.MGlobal._nameButton = btnVentasAtendidas.Name
        frm.Show()
    End Sub

    Private Sub btInvSaldoLote_Click(sender As Object, e As EventArgs) Handles btnInvSaldoLote.Click
        _prCambiarColorVerde(btnInvSaldoLote)
        Dim frm As New PR_StockActualProductosLotes
        Modelo.MGlobal._nameButton = btnInvSaldoLote.Name
        frm.Show()
    End Sub

    Private Sub btnCobroInt_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRealizarPAgos_Click(sender As Object, e As EventArgs) Handles btnRealizarPAgos.Click
        _prCambiarColorVerde(btnRealizarPAgos)
        Dim frm As New F0_PagosCredito
        Modelo.MGlobal._nameButton = btnRealizarPAgos.Name
        frm.Show()
    End Sub

    Private Sub btnReporteKArdex_Click(sender As Object, e As EventArgs) Handles btnReporteKArdex.Click
        _prCambiarColorVerde(btnReporteKArdex)
        Dim frm As New Pr_KardexCredito
        Modelo.MGlobal._nameButton = btnReporteKArdex.Name
        frm.Show()
    End Sub

    Private Sub btComPagosCredito_Click(sender As Object, e As EventArgs) Handles btComPagosCredito.Click
        _prCambiarColorVerde(btComPagosCredito)
        Dim frm As New F0_PagosCreditoCompraUlt
        Modelo.MGlobal._nameButton = btComPagosCredito.Name
        frm.Show()
    End Sub

    Private Sub btnConsultorios_Click(sender As Object, e As EventArgs) Handles btnConsultorios.Click
        _prCambiarColorVerde(btnConsultorios)
        Dim frm As New F1_Con_Consultorios
        Modelo.MGlobal._nameButton = btnConsultorios.Name
        frm.Show()
    End Sub

    Private Sub btnDosificacion_Click(sender As Object, e As EventArgs) Handles btnDosificacion.Click
        _prCambiarColorVerde(btnDosificacion)
        Dim frm As New F1_Dosificacion
        Modelo.MGlobal._nameButton = btnDosificacion.Name
        frm.Show()
    End Sub

    Private Sub btnAnularFactura_Click(sender As Object, e As EventArgs) Handles btnAnularFactura.Click
        _prCambiarColorVerde(btnAnularFactura)
        Dim frm As New F0_AnularFactura
        Modelo.MGlobal._nameButton = btnAnularFactura.Name
        frm.Show()
    End Sub

    Private Sub btnLibroVenta_Click(sender As Object, e As EventArgs) Handles btnLibroVenta.Click
        _prCambiarColorVerde(btnLibroVenta)
        Dim frm As New F0_LibroVenta2
        Modelo.MGlobal._nameButton = btnLibroVenta.Name
        frm.Show()
    End Sub

    Private Sub btnIngresoEgreso_Click(sender As Object, e As EventArgs) Handles btnIngresoEgreso.Click
        _prCambiarColorVerde(btnIngresoEgreso)
        Dim frm As New F1_IngresosEgresos
        Modelo.MGlobal._nameButton = btnIngresoEgreso.Name
        frm.Show()
    End Sub

    Private Sub btnArqueoDiario_Click(sender As Object, e As EventArgs) Handles btnArqueoDiario.Click
        _prCambiarColorVerde(btnArqueoDiario)
        Dim frm As New Pr_ArqueoDiario
        Modelo.MGlobal._nameButton = btnArqueoDiario.Name
        frm.Show()
    End Sub

    Private Sub btnDetalleAtenciones_Click(sender As Object, e As EventArgs) Handles btnDetalleAtenciones.Click
        _prCambiarColorVerde(btnDetalleAtenciones)
        Dim frm As New Pr_DetalleAtencionesDiarias
        Modelo.MGlobal._nameButton = btnDetalleAtenciones.Name
        frm.Show()
    End Sub
    Private Sub btnInvStockMin_Click(sender As Object, e As EventArgs) Handles btnInvStockMin.Click
        _prCambiarColorVerde(btnInvStockMin)
        Dim frm As New Pr_StockMinimo
        Modelo.MGlobal._nameButton = btnInvStockMin.Name
        frm.Show()
    End Sub

    Private Sub btnRoles_MouseHover(sender As Object, e As EventArgs) Handles btnRoles.MouseHover
        _prCambiarColorVerde(btnRoles)
    End Sub

    Private Sub btnUsuarios_MouseHover(sender As Object, e As EventArgs) Handles btnUsuarios.MouseHover
        _prCambiarColorVerde(btnUsuarios)
    End Sub

    Private Sub btnLibrerias_MouseHover(sender As Object, e As EventArgs) Handles btnLibrerias.MouseHover
        _prCambiarColorVerde(btnLibrerias)
    End Sub

    Private Sub btnServicios_MouseHover(sender As Object, e As EventArgs) Handles btnServicios.MouseHover
        _prCambiarColorVerde(btnServicios)
    End Sub

    Private Sub btnConsultorios_MouseHover(sender As Object, e As EventArgs) Handles btnConsultorios.MouseHover
        _prCambiarColorVerde(btnConsultorios)
    End Sub

    Private Sub btnDosificacion_MouseHover(sender As Object, e As EventArgs) Handles btnDosificacion.MouseHover
        _prCambiarColorVerde(btnDosificacion)
    End Sub

    Private Sub btnClientes_MouseHover(sender As Object, e As EventArgs) Handles btnClientes.MouseHover
        _prCambiarColorVerde(btnClientes)
    End Sub

    Private Sub btnPacientes_MouseHover(sender As Object, e As EventArgs) Handles btnPacientes.MouseHover
        _prCambiarColorVerde(btnPacientes)
    End Sub

    Private Sub btnEmpleados_MouseHover(sender As Object, e As EventArgs) Handles btnEmpleados.MouseHover
        _prCambiarColorVerde(btnEmpleados)
    End Sub

    Private Sub btnProductos_MouseHover(sender As Object, e As EventArgs) Handles btnProductos.MouseHover
        _prCambiarColorVerde(btnProductos)
    End Sub

    Private Sub btnPrecios_MouseHover(sender As Object, e As EventArgs) Handles btnPrecios.MouseHover
        _prCambiarColorVerde(btnPrecios)
    End Sub

    Private Sub btnFichaAtencion_MouseHover(sender As Object, e As EventArgs) Handles btnFichaAtencion.MouseHover
        _prCambiarColorVerde(btnFichaAtencion)
    End Sub

    Private Sub btnFichaClinica_MouseHover(sender As Object, e As EventArgs) Handles btnFichaClinica.MouseHover
        _prCambiarColorVerde(btnFichaClinica)
    End Sub

    Private Sub btnSegInternacion_MouseHover(sender As Object, e As EventArgs) Handles btnSegInternacion.MouseHover
        _prCambiarColorVerde(btnSegInternacion)
    End Sub

    Private Sub btnReciboCirugia_MouseHover(sender As Object, e As EventArgs) Handles btnReciboCirugia.MouseHover
        _prCambiarColorVerde(btnReciboCirugia)
    End Sub

    Private Sub btnRepVetMascAten_MouseHover(sender As Object, e As EventArgs) Handles btnRepVetMascAten.MouseHover
        _prCambiarColorVerde(btnRepVetMascAten)
    End Sub

    Private Sub btnPacientesAten_MouseHover(sender As Object, e As EventArgs) Handles btnPacientesAten.MouseHover
        _prCambiarColorVerde(btnPacientesAten)
    End Sub

    Private Sub btnProveedor_MouseHover(sender As Object, e As EventArgs) Handles btnProveedor.MouseHover
        _prCambiarColorVerde(btnProveedor)
    End Sub

    Private Sub btnCompras_MouseHover(sender As Object, e As EventArgs) Handles btnCompras.MouseHover
        _prCambiarColorVerde(btnCompras)
    End Sub

    Private Sub btComPagosCredito_MouseHover(sender As Object, e As EventArgs) Handles btComPagosCredito.MouseHover
        _prCambiarColorVerde(btComPagosCredito)
    End Sub

    Private Sub btnAlmacen_MouseHover(sender As Object, e As EventArgs) Handles btnAlmacen.MouseHover
        _prCambiarColorVerde(btnAlmacen)
    End Sub

    Private Sub btnMovimientos_MouseHover(sender As Object, e As EventArgs) Handles btnMovimientos.MouseHover
        _prCambiarColorVerde(btnMovimientos)
    End Sub

    Private Sub btnKardex_MouseHover(sender As Object, e As EventArgs) Handles btnKardex.MouseHover
        _prCambiarColorVerde(btnKardex)
    End Sub

    Private Sub btnSaldoProducto_MouseHover(sender As Object, e As EventArgs) Handles btnSaldoProducto.MouseHover
        _prCambiarColorVerde(btnSaldoProducto)
    End Sub

    Private Sub btnKardexProducto_MouseHover(sender As Object, e As EventArgs) Handles btnKardexProducto.MouseHover
        _prCambiarColorVerde(btnKardexProducto)
    End Sub

    Private Sub btnSaldosValorados_MouseHover(sender As Object, e As EventArgs) Handles btnSaldosValorados.MouseHover
        _prCambiarColorVerde(btnSaldosValorados)
    End Sub

    Private Sub btnInvSaldoLote_MouseHover(sender As Object, e As EventArgs) Handles btnInvSaldoLote.MouseHover
        _prCambiarColorVerde(btnInvSaldoLote)
    End Sub

    Private Sub btnVenta_MouseHover(sender As Object, e As EventArgs) Handles btnVenta.MouseHover
        _prCambiarColorVerde(btnVenta)
    End Sub

    Private Sub btnVentasAtendidas_MouseHover(sender As Object, e As EventArgs) Handles btnVentasAtendidas.MouseHover
        _prCambiarColorVerde(btnVentasAtendidas)
    End Sub

    Private Sub btnAnularFactura_MouseHover(sender As Object, e As EventArgs) Handles btnAnularFactura.MouseHover
        _prCambiarColorVerde(btnAnularFactura)
    End Sub

    Private Sub btnLibroVenta_MouseHover(sender As Object, e As EventArgs) Handles btnLibroVenta.MouseHover
        _prCambiarColorVerde(btnLibroVenta)
    End Sub

    Private Sub btnIngresoEgreso_MouseHover(sender As Object, e As EventArgs) Handles btnIngresoEgreso.MouseHover
        _prCambiarColorVerde(btnIngresoEgreso)
    End Sub

    Private Sub btnArqueoDiario_MouseHover(sender As Object, e As EventArgs) Handles btnArqueoDiario.MouseHover
        _prCambiarColorVerde(btnArqueoDiario)
    End Sub

    Private Sub btnDetalleAtenciones_MouseHover(sender As Object, e As EventArgs) Handles btnDetalleAtenciones.MouseHover
        _prCambiarColorVerde(btnDetalleAtenciones)
    End Sub

    Private Sub btnPagosCliente_MouseHover(sender As Object, e As EventArgs) Handles btnPagosCliente.MouseHover
        _prCambiarColorVerde(btnPagosCliente)
    End Sub

    Private Sub btnReporteNotasPorCobrar_MouseHover(sender As Object, e As EventArgs) Handles btnReporteNotasPorCobrar.MouseHover
        _prCambiarColorVerde(btnReporteNotasPorCobrar)
    End Sub

    Private Sub btnReportePagos_MouseHover(sender As Object, e As EventArgs) Handles btnReportePagos.MouseHover
        _prCambiarColorVerde(btnReportePagos)
    End Sub

    Private Sub btnRealizarPAgos_MouseHover(sender As Object, e As EventArgs) Handles btnRealizarPAgos.MouseHover
        _prCambiarColorVerde(btnRealizarPAgos)
    End Sub

    Private Sub btnReporteKArdex_MouseHover(sender As Object, e As EventArgs) Handles btnReporteKArdex.MouseHover
        _prCambiarColorVerde(btnReporteKArdex)
    End Sub

    Private Sub btnInvStockMin_MouseHover(sender As Object, e As EventArgs) Handles btnInvStockMin.MouseHover
        _prCambiarColorVerde(btnInvStockMin)
    End Sub

    Private Sub btnFichaAtencionC_Click(sender As Object, e As EventArgs) Handles btnFichaAtencionC.Click
        _prCambiarColorVerde(btnFichaAtencion)
        Dim frm As New F_Fic_FichaAtencionCliente
        'frm._nameButton = btnFichaAtencion.Name
        frm.Show()
    End Sub

    Private Sub btnFichaAtencionC_MouseHover(sender As Object, e As EventArgs) Handles btnFichaAtencionC.MouseHover
        _prCambiarColorVerde(btnFichaAtencionC)
    End Sub

    Private Sub btProforma_Click(sender As Object, e As EventArgs) Handles btProforma.Click
        _prCambiarColorVerde(btProforma)
        Dim frm As New F1_Ven_Proforma
        Modelo.MGlobal._nameButton = btProforma.Name
        frm.Show()
    End Sub

    Private Sub btnVentasServicio_Click(sender As Object, e As EventArgs) Handles btnVentasServicio.Click
        _prCambiarColorVerde(btnVentasServicio)
        Dim frm As New Pr_VentasServicios
        Modelo.MGlobal._nameButton = btnVentasServicio.Name
        frm.Show()
    End Sub
End Class
