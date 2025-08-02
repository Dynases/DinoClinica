
Imports DevComponents.DotNetBar
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports Logica.AccesoLogica
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar.Metro


Public Class Login
    ' Dim main As New Principal

#Region "METODOS PRIVADOS"
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

    Private Sub _PCargarPrivilegios()
        Dim listaTabs As New List(Of DevComponents.DotNetBar.Metro.MetroTilePanel)
        listaTabs.Add(Principal.mtp1Configuracion)
        listaTabs.Add(Principal.mtpRegistros)
        listaTabs.Add(Principal.mtpFichas)
        listaTabs.Add(Principal.mtpCompras)
        listaTabs.Add(Principal.mtpInventario)
        listaTabs.Add(Principal.mtpVentas)
        listaTabs.Add(Principal.mtpCreditos)

        Dim idRolUsu As String = gi_userRol

        Dim dtModulos As DataTable = L_prLibreriaDetalleGeneral(gi_LibSistema, gi_LibSISModulo)
        Dim listFormsModulo As New List(Of String)

        For i = 0 To dtModulos.Rows.Count - 1
            Dim dtDetRol As DataTable = L_RolDetalle_General(-1, idRolUsu, dtModulos.Rows(i).Item("cnnum"))
            listFormsModulo = New List(Of String)

            If dtDetRol.Rows.Count > 0 Then
                'cargo los nombres de los programas(botones) del modulo
                For Each fila As DataRow In dtDetRol.Rows
                    listFormsModulo.Add(fila.Item("yaprog").ToString.ToUpper)
                Next
                'recorro el modulo(tab) que corresponde
                For Each _item As DevComponents.DotNetBar.BaseItem In listaTabs.Item(i).Items
                    If TypeOf (_item) Is DevComponents.DotNetBar.Metro.MetroTileItem Then 'es un boton del modulo
                        Dim btn As DevComponents.DotNetBar.Metro.MetroTileItem = CType(_item, DevComponents.DotNetBar.Metro.MetroTileItem)
                        If listFormsModulo.Contains(btn.Name.ToUpper) Then 'si el nombre del boton pertenece a la lista de formularios del modulo
                            Dim Texto As String = btn.Text
                            Dim TTexto As String = btn.TitleText
                            Dim f As Integer = listFormsModulo.IndexOf(btn.Name.ToUpper)
                            If Texto = "" Then 'esta usando el Title Text
                                btn.TitleText = dtDetRol.Rows(f).Item("yatit").ToString.ToUpper
                            Else 'esta usando el Text
                                btn.Text = dtDetRol.Rows(f).Item("yatit").ToString.ToUpper
                            End If

                            If dtDetRol.Rows(f).Item("ycshow") = True Or dtDetRol.Rows(f).Item("ycadd") = True Or dtDetRol.Rows(f).Item("ycmod") = True Or dtDetRol.Rows(f).Item("ycdel") = True Then
                                btn.Visible = True
                            Else
                                btn.Visible = False
                            End If
                        Else 'si no pertenece lo oculto
                            btn.Visible = False
                        End If
                    Else 'seria un sub grupo en el modulo
                        'recorro todos los elementos del sub grupo
                        If TypeOf _item Is ItemContainer Then
                            For Each _subItem In _item.SubItems
                                Dim _subBtn As MetroTileItem = CType(_subItem, MetroTileItem)
                                If listFormsModulo.Contains(_subBtn.Name.ToUpper) Then
                                    Dim Texto As String = _subBtn.Text
                                    Dim TTexto As String = _subBtn.TitleText
                                    Dim f As Integer = listFormsModulo.IndexOf(_subBtn.Name.ToUpper)
                                    If Texto = "" Then 'esta usando el Title Text
                                        _subBtn.TitleText = dtDetRol.Rows(f).Item("yatit").ToString.ToUpper
                                    Else 'esta usando el Text
                                        _subBtn.Text = dtDetRol.Rows(f).Item("yatit").ToString.ToUpper
                                    End If

                                    If dtDetRol.Rows(f).Item("ycshow") = True Or dtDetRol.Rows(f).Item("ycadd") = True Or dtDetRol.Rows(f).Item("ycmod") = True Or dtDetRol.Rows(f).Item("ycdel") = True Then
                                        _subBtn.Visible = True
                                    Else
                                        _subBtn.Visible = False
                                    End If
                                Else
                                    _subBtn.Visible = False
                                End If
                            Next
                        End If

                    End If
                Next
            Else ' no exiten formulario registrados en el modulo pero igual hay que ocultar los botones y los subbotones que tenga
                For Each _item As DevComponents.DotNetBar.BaseItem In listaTabs.Item(i).Items
                    If TypeOf (_item) Is DevComponents.DotNetBar.Metro.MetroTileItem Then 'es un boton del modulo
                        Dim btn As DevComponents.DotNetBar.Metro.MetroTileItem = CType(_item, DevComponents.DotNetBar.Metro.MetroTileItem)
                        btn.Visible = False
                    Else 'seria un sub grupo en el modulo
                        'recorro todos los elementos del sub grupo
                        If TypeOf _item Is ItemContainer Then
                            For Each _subItem In _item.SubItems
                                Dim _subBtn As MetroTileItem = CType(_subItem, MetroTileItem)
                                _subBtn.Visible = False
                            Next
                        End If

                    End If
                Next

            End If

        Next

        'refrescar el formulario
        Me.Refresh()
    End Sub

#End Region

#Region "EVENTOS"
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prLeerArchivoConfig()
        L_prAbrirConexion(gs_Ip, gs_UsuarioSql, gs_ClaveSql, gs_NombreBD)
        txtUsuario.CharacterCasing = CharacterCasing.Upper

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim usu As String = txtUsuario.Text
        Dim pass As String = txtPassword.Text

        'Dim login As New Login
        If txtUsuario.Text = "" Then
            ToastNotification.Show(Me, "No Puede Dejar Nombre en Blanco..!!!".ToUpper, My.Resources.WARNING, 1000, eToastGlowColor.Red, eToastPosition.BottomLeft)
            Exit Sub
        End If
        If txtPassword.Text = "" Then
            ToastNotification.Show(Me, "No Puede Dejar Password en Blanco..!!!".ToUpper, My.Resources.WARNING, 1000, eToastGlowColor.Red, eToastPosition.BottomLeft)
            Exit Sub
        End If

        Dim dtUsuario As DataTable = L_Validar_Usuario(usu, pass)

        If dtUsuario.Rows.Count > 0 Then

            If dtUsuario.Rows.Count > 0 Then

                gs_user = txtUsuario.Text
                gi_userNumi = dtUsuario.Rows(0).Item("uaId")
                gi_userRol = dtUsuario.Rows(0).Item("uaRol")
                gi_userSuc = dtUsuario.Rows(0).Item("uaSucursal")

                'Asignando el nombre de usuario y rol  a las variables 
                L_Usuario = gs_user
                Modelo.MGlobal.gs_usuario = gs_user
                Modelo.MGlobal.gi_userRol = gi_userRol
                Principal.lbUsuario.Text = gs_user

                Limpiar()
                Me.Hide()

                If gs_user = "DEFAULT" Then
                    Principal.sideNav1.Enabled = False
                Else
                    _PCargarPrivilegios()
                    Principal.sideNav1.Enabled = True


                    Principal.Show()
                    _prCambiarNombreBotones()
                    'txtUsuario.Clear()
                    'txtPassword.Clear()

                    'Me.Close()

                End If
            End If
        Else
            ToastNotification.Show(Me, "Codigo de Usuario y Password Incorrecto..!!!".ToUpper, My.Resources.WARNING, 3000, eToastGlowColor.Red, eToastPosition.TopCenter)
        End If


        '    If dtUsuario.Rows.Count = 0 Then
        '    ToastNotification.Show(Me, "Codigo de Usuario y Password Incorrecto..!!!".ToUpper, My.Resources.WARNING, 1000, eToastGlowColor.Red, eToastPosition.BottomLeft)
        'Else
        '    gs_user = txtUsuario.Text
        '    gi_userNumi = dtUsuario.Rows(0).Item("uaId")
        '    'Close()

        '    'login.Close()
        '     main.ShowDialog()

        'End If

    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        '_ok = False
        Me.Close()
    End Sub
    Public Sub _prCambiarNombreBotones()
        Principal.btnFichaAtencion.TitleText = "FICHA" + vbCrLf + "ATENCIÓN"
        Principal.btnFichaClinica.TitleText = "FICHA" + vbCrLf + "CLÍNICA"
        Principal.btnSegInternacion.TitleText = "SEGUIMIENTO" + vbCrLf + "INTERNACIÓN"
        Principal.btnReciboCirugia.TitleText = "RECIBO" + vbCrLf + "CIRUGÍA"
        Principal.btnRepVetMascAten.TitleText = "REP. HORAS" + vbCrLf + "ATENDIDAS" + vbCrLf + "VETERINARIO"
        Principal.btnPacientesAten.TitleText = "REP." + vbCrLf + "PACIENTES" + vbCrLf + "ATENDIDOS"
        Principal.btComPagosCredito.TitleText = "PAGOS" + vbCrLf + "COMPRA" + vbCrLf + "CRÉDITOS"
        Principal.btnKardex.TitleText = "KARDEX" + vbCrLf + "PRODUCTO"
        Principal.btnSaldoProducto.TitleText = "SALDO" + vbCrLf + "PRODUCTOS"
        Principal.btnKardexProducto.TitleText = "REPORTE" + vbCrLf + "KARDEX" + vbCrLf + "PRODUCTOS"
        Principal.btnSaldosValorados.TitleText = "SALDOS" + vbCrLf + "VALORADOS"
        Principal.btnInvSaldoLote.TitleText = "STOCK" + vbCrLf + "ACTUAL" + vbCrLf + "POR LOTES"
        Principal.btnVentasAtendidas.TitleText = "VENTAS" + vbCrLf + "ATENDIDAS"
        Principal.btnAnularFactura.TitleText = "ANULAR" + vbCrLf + "FACTURA"
        Principal.btnLibroVenta.TitleText = "LIBRO DE" + vbCrLf + "VENTAS"
        Principal.btnIngresoEgreso.TitleText = "INGRESO" + vbCrLf + "EGRESO"
        Principal.btnArqueoDiario.TitleText = "ARQUEO" + vbCrLf + "DIARIO"
        Principal.btnDetalleAtenciones.TitleText = "DETALLE DE" + vbCrLf + "ATENCIONES" + vbCrLf + "DIARIAS"
        Principal.btnPagosCliente.TitleText = "PAGOS POR" + vbCrLf + "CLIENTE"
        Principal.btnReporteNotasPorCobrar.TitleText = "NOTAS" + vbCrLf + "POR" + vbCrLf + "COBRAR"
        Principal.btnReportePagos.TitleText = "REPORTE" + vbCrLf + "PAGOS"
        Principal.btnRealizarPAgos.TitleText = "REALIZAR" + vbCrLf + "PAGOS"
        Principal.btnReporteKArdex.TitleText = "ESTADO DE" + vbCrLf + "CUENTAS"
        Principal.btnFichaAtencionC.TitleText = "FICHA" + vbCrLf + "ATENCIÓN" + vbCrLf + "CLIENTE"
    End Sub
    Private Sub ModeloHor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress, txtPassword.KeyPress, txtUsuario.KeyPress
        'e.KeyChar = e.KeyChar.ToString.ToUpper
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            e.Handled = True
            P_Moverenfoque()
        End If
    End Sub
    Private Sub P_Moverenfoque()
        SendKeys.Send("{TAB}")
    End Sub
    Private Sub Limpiar()
        txtUsuario.Text = ""
        txtPassword.Text = ""
        txtUsuario.Focus()
    End Sub


#End Region

End Class