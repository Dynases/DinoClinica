
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports Datos.AccesoDatos
Public Class AccesoLogica
    Public Shared L_Usuario As String = "DEFAULT"

#Region "CONFIGURACION DEL SISTEMA"

    Public Shared Function L_fnConfSistemaGeneral() As DataTable
        Dim _Tabla As DataTable
        Dim _Where, _campos As String
        Dim _dtConfSist As DataTable = D_Datos_Tabla("cnumi", "TC000", "1=1")

        _Where = "ccctc0=" + _dtConfSist.Rows(0).Item("cnumi").ToString
        _campos = "*"
        _Tabla = D_Datos_Tabla(_campos, "TC0001", _Where)
        Return _Tabla
    End Function
    Public Shared Function L_fnConfSistemaModificar(ByRef _numi As String) As Boolean
        Dim _Error As Boolean
        Dim Sql, _where As String

        Sql = "cnumi =" + _numi

        _where = "1=1"
        _Error = D_Modificar_Datos("TC000", Sql, _where)
        Return Not _Error
    End Function

#End Region

#Region "METODOS PRIVADOS"
    Public Shared Sub L_prAbrirConexion(Optional Ip As String = "", Optional UsuarioSql As String = "", Optional ClaveSql As String = "", Optional NombreBD As String = "")
        D_abrirConexion(Ip, UsuarioSql, ClaveSql, NombreBD)
    End Sub

    Public Shared Function _fnsAuditoria() As String
        Return "'" + Date.Now.Date.ToString("yyyy/MM/dd") + "', '" + Now.Hour.ToString("00") + ":" + Now.Minute.ToString("00") + "' ,'" + L_Usuario + "'"
    End Function
#End Region

#Region "VALIDAR ELIMINACION"
    Public Shared Function L_fnbValidarEliminacion(_numi As String, _tablaOri As String, _campoOri As String, ByRef _respuesta As String) As Boolean
        Dim _Tabla As DataTable
        Dim _Where, _campos As String
        _Where = "bbtori='" + _tablaOri + "' and bbtran=1"
        _campos = "bbnumi,bbtran,bbtori,bbcori,bbtdes,bbcdes,bbprog"
        _Tabla = D_Datos_Tabla(_campos, "TB002", _Where)
        _respuesta = "no se puede eliminar el registro: ".ToUpper + _numi + " por que esta siendo usado en los siguientes programas: ".ToUpper + vbCrLf

        Dim result As Boolean = True
        For Each fila As DataRow In _Tabla.Rows
            If L_fnbExisteRegEnTabla(_numi, fila.Item("bbtdes").ToString, fila.Item("bbcdes").ToString) = True Then
                _respuesta = _respuesta + fila.Item("bbprog").ToString + vbCrLf
                result = False
            End If
        Next
        Return result
    End Function

    Private Shared Function L_fnbExisteRegEnTabla(_numiOri As String, _tablaDest As String, _campoDest As String) As Boolean
        Dim _Tabla As DataTable
        Dim _Where, _campos As String
        _Where = _campoDest + "=" + _numiOri
        _campos = _campoDest
        _Tabla = D_Datos_Tabla(_campos, _tablaDest, _Where)
        If _Tabla.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function L_fnbValidarEliminacionProducto(_numi As String, _tablaOri As String, _campoOri As String, ByRef _respuesta As String) As Boolean
        Dim _Tabla As DataTable
        Dim _Where, _campos As String
        _Where = "bbtori='" + _tablaOri + "' and bbtran=1"
        _campos = "bbnumi,bbtran,bbtori,bbcori,bbtdes,bbcdes,bbprog"
        _Tabla = D_Datos_Tabla(_campos, "TB002", _Where)
        _respuesta = "no se puede eliminar el registro: ".ToUpper + _numi + " por que esta siendo usado en los siguientes programas: ".ToUpper + vbCrLf

        Dim result As Boolean = True
        For Each fila As DataRow In _Tabla.Rows
            If Trim(fila.Item("bbtdes")) = "VEN.VEN0011" Then
                If L_fnbExisteRegEnTablaProducto(_numi, fila.Item("bbtdes").ToString, fila.Item("bbcdes").ToString, 0) = True Then
                    _respuesta = _respuesta + fila.Item("bbprog").ToString + vbCrLf
                    result = False
                End If
            Else
                If L_fnbExisteRegEnTabla(_numi, fila.Item("bbtdes").ToString, fila.Item("bbcdes").ToString) = True Then
                    _respuesta = _respuesta + fila.Item("bbprog").ToString + vbCrLf
                    result = False
                End If
            End If

        Next
        Return result
    End Function
    Private Shared Function L_fnbExisteRegEnTablaProducto(_numiOri As String, _tablaDest As String, _campoDest As String, vbEst2 As String) As Boolean
        Dim _Tabla As DataTable
        Dim _Where, _campos As String
        _Where = _campoDest + "=" + _numiOri + " and vbEst2" + "=" + vbEst2
        _campos = _campoDest
        _Tabla = D_Datos_Tabla(_campos, _tablaDest, _Where)
        If _Tabla.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

#Region "SERVICIOS CON.SER002"
#Region "Transacciones"

    'Grabar --scId, scDesc, scPrecio, scEst, scFecha, scHora, scUsuario
    Public Shared Function L_fnGrabarServicio(ByRef _scId As String, _scDesc As String, _scPrecio As String, _scEst As String) As Boolean

        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@scId", _scId))
        _listParam.Add(New Datos.DParametro("@scDesc", _scDesc))
        _listParam.Add(New Datos.DParametro("@scPrecio", _scPrecio))
        _listParam.Add(New Datos.DParametro("@scEst", _scEst))
        _listParam.Add(New Datos.DParametro("@scUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("CON.sp_SER002", _listParam)
        If _Tabla.Rows.Count > 0 Then
            _scId = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function
    'Modificar 
    Public Shared Function L_fnModificarServicio(ByRef _scId As String, _scDesc As String, _scPrecio As String, _scEst As String) As Boolean

        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 2))
        _listParam.Add(New Datos.DParametro("@scId", _scId))
        _listParam.Add(New Datos.DParametro("@scDesc", _scDesc))
        _listParam.Add(New Datos.DParametro("@scPrecio", _scPrecio))
        _listParam.Add(New Datos.DParametro("@scEst", _scEst))
        _listParam.Add(New Datos.DParametro("@scUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("CON.sp_SER002", _listParam)
        If _Tabla.Rows.Count > 0 Then
            _scId = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
    'Eliminar 
    Public Shared Function L_fnEliminarServicio(ByRef _scId As String, ByRef mensaje As String) As Boolean
        Dim _resultado As Boolean
        If L_fnbValidarEliminacion(_scId, "CON.SER002", "scId", mensaje) = True Then
            Dim _Tabla As DataTable
            Dim _listParam As New List(Of Datos.DParametro)

            _listParam.Add(New Datos.DParametro("@tipo", 3))
            _listParam.Add(New Datos.DParametro("@scId", _scId))
            _listParam.Add(New Datos.DParametro("@scUsuario", L_Usuario))
            _Tabla = D_ProcedimientoConParam("CON.sp_SER002", _listParam)
            If _Tabla.Rows.Count > 0 Then
                _scId = _Tabla.Rows(0).Item(0)
                _resultado = True
            Else
                _resultado = False
            End If
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
#End Region
#Region "Consultas"
    'Mostrar 
    Public Shared Function L_fnMostrarServicio() As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 4))
        _listParam.Add(New Datos.DParametro("@scUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("CON.sp_SER002", _listParam)
        Return _Tabla
    End Function


    Public Shared Function L_fnListarServicio() As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 5))
        _listParam.Add(New Datos.DParametro("@scUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("CON.sp_SER002", _listParam)
        Return _Tabla
    End Function
#End Region
#Region "Verificaciones"
#End Region
#End Region

#Region "CON.LIBRERIA LIB0011"'lcidprog, lcidgrup, lcidlib, lcdesc, lcfecha, lchora, lcusuario
#Region "TRANSACCIONES"
    Public Shared Function L_fnGrabarLibreria(ByRef _id As String, _lcidprog As String, _lcidgrup As String, _desc As String) As Boolean
        Dim _Error As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@lbidprog", _lcidprog))
        _listParam.Add(New Datos.DParametro("@lbidgrup", _lcidgrup))
        _listParam.Add(New Datos.DParametro("@lbdesc", _desc))
        _listParam.Add(New Datos.DParametro("@lbusuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("CON.sp_LIB0011", _listParam)
        If _Tabla.Rows.Count > 0 Then
            _id = _Tabla.Rows(0).Item(0)
            _Error = False
        Else
            _Error = True
        End If
        Return Not _Error
    End Function
    Public Shared Function L_fnGrabarLibreriasPrograma(_Id As String, _dt As DataTable) As Boolean
        Dim _Tabla As DataTable
        Dim _resultado As Boolean
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 4))
        _listParam.Add(New Datos.DParametro("@LIB0011", "", _dt))
        _listParam.Add(New Datos.DParametro("@lbusuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("CON.sp_LIB0011", _listParam)
        If _Tabla.Rows.Count > 0 Then
            _Id = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
#End Region
#Region "CONSULTAS"
    '**********Muestra las librerias
    Public Shared Function L_fnMostrarLibreria(_lcidprog As String, _lcidgrup As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 2))
        _listParam.Add(New Datos.DParametro("@lbidprog", _lcidprog))
        _listParam.Add(New Datos.DParametro("@lbidgrup", _lcidgrup))
        _Tabla = D_ProcedimientoConParam("CON.sp_LIB0011", _listParam)
        Return _Tabla
    End Function
    'MUESTRA LOS PROGRAMAAS EN GENERAL
    Public Shared Function L_fnGeneralProgramas() As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 5))
        _listParam.Add(New Datos.DParametro("@lbUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("CON.sp_LIB0011", _listParam)
        Return _Tabla
    End Function
    'MUESTRA PROGRAMAS Y CATEGORIAS 
    Public Shared Function L_fnGeneralProgramasCategorias(_categoria As Integer) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 6))
        _listParam.Add(New Datos.DParametro("@lbUsuario", L_Usuario))
        _listParam.Add(New Datos.DParametro("@categoria", _categoria))
        _Tabla = D_ProcedimientoConParam("CON.sp_LIB0011", _listParam)
        Return _Tabla
    End Function
    'MUESTRA LISTA DE LIBRERIAS
    Public Shared Function L_fnGeneralDetalleLibrerias(cod1 As String, cod2 As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 7))
        _listParam.Add(New Datos.DParametro("@lbUsuario", L_Usuario))
        _listParam.Add(New Datos.DParametro("@cod1", cod1))
        _listParam.Add(New Datos.DParametro("@cod2", cod2))
        _Tabla = D_ProcedimientoConParam("CON.sp_LIB0011", _listParam)
        Return _Tabla
    End Function
#End Region
#Region "VERIFICACIONES"
    '**********VERIFICA SI EXISTE LA LIBRERIA
    Public Shared Function L_fnExisteLibreria(_lcidprog As String, _lcidgrup As String, _desc As String) As Boolean
        Dim _Tabla As DataTable
        Dim res As Boolean = False
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 3))
        _listParam.Add(New Datos.DParametro("@lbidprog", _lcidprog))
        _listParam.Add(New Datos.DParametro("@lbidgrup", _lcidgrup))
        _listParam.Add(New Datos.DParametro("@lbdesc", _desc))
        _Tabla = D_ProcedimientoConParam("CON.sp_LIB0011", _listParam)
        Return res = IIf(_Tabla.Rows(0).Item(0) <> 0, True, False)
    End Function
#End Region
#End Region

#Region " REG.CLIENTES CLI001"
#Region "Transacciones"
    'Eliminar clientes
    Public Shared Function L_fnEliminarClientes(ByRef _caid As String, ByRef mensaje As String) As Boolean
        Dim _resultado As Boolean
        If L_fnbValidarEliminacion(_caid, "REG.CLI001", "caid", mensaje) = True Then
            Dim _Tabla As DataTable
            Dim _listParam As New List(Of Datos.DParametro)

            _listParam.Add(New Datos.DParametro("@tipo", -1))
            _listParam.Add(New Datos.DParametro("@caid", _caid))
            _listParam.Add(New Datos.DParametro("@causuario", L_Usuario))
            _Tabla = D_ProcedimientoConParam("REG.sp_CLI001", _listParam)

            If _Tabla.Rows.Count > 0 Then
                '_caid = _Tabla.Rows(0).Item(0)
                _resultado = True
            Else
                _resultado = False
            End If
        Else
            _resultado = False
        End If
        Return _resultado
    End Function

    'Grabar Clientes
    Public Shared Function L_fnGrabarClientes(ByRef _caid As String, _caci As String, _canomb As String, _caapell As String,
                                              _cadir As String, _catelf As String, _camail As String, _cafecha As String, fechaNac As String) As Boolean

        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@caid", _caid))
        _listParam.Add(New Datos.DParametro("@caci", _caci))
        _listParam.Add(New Datos.DParametro("@canomb", _canomb))
        _listParam.Add(New Datos.DParametro("@caapell", _caapell))
        _listParam.Add(New Datos.DParametro("@cadir", _cadir))
        _listParam.Add(New Datos.DParametro("@catelf", _catelf))
        _listParam.Add(New Datos.DParametro("@camail", _camail))
        _listParam.Add(New Datos.DParametro("@cafecha", _cafecha))
        _listParam.Add(New Datos.DParametro("@cafechanac", fechaNac))
        _listParam.Add(New Datos.DParametro("@causuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("REG.sp_CLI001", _listParam)

        If _Tabla.Rows.Count > 0 Then
            _caid = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function
    'Modificar Clientes
    Public Shared Function L_fnModificarClientes(ByRef _caid As String, _caci As String, _canomb As String, _caapell As String,
                                              _cadir As String, _catelf As String, _camail As String, _cafecha As String, fechaNac As String) As Boolean

        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 2))
        _listParam.Add(New Datos.DParametro("@caid", _caid))
        _listParam.Add(New Datos.DParametro("@caci", _caci))
        _listParam.Add(New Datos.DParametro("@canomb", _canomb))
        _listParam.Add(New Datos.DParametro("@caapell", _caapell))
        _listParam.Add(New Datos.DParametro("@cadir", _cadir))
        _listParam.Add(New Datos.DParametro("@catelf", _catelf))
        _listParam.Add(New Datos.DParametro("@camail", _camail))
        _listParam.Add(New Datos.DParametro("@cafecha", _cafecha))
        _listParam.Add(New Datos.DParametro("@cafechanac", fechaNac))
        _listParam.Add(New Datos.DParametro("@causuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("REG.sp_CLI001", _listParam)

        If _Tabla.Rows.Count > 0 Then
            _caid = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function
    Public Shared Function L_fnModificarClientes(ByRef _ydnumi As String, _ydcod As String,
                                            _ydrazonSocial As String, _yddesc As String, _ydnumiVendedor As Integer, _ydzona As Integer,
                                             _yddct As Integer, _yddctnum As String,
                                             _yddirec As String, _ydtelf1 As String,
                                             _ydtelf2 As String, _ydcat As Integer, _ydest As Integer, _ydlat As Double, _ydlongi As Double, _ydobs As String,
                                             _ydfnac As String, _ydnomfac As String,
                                             _ydtip As Integer, _ydnit As String, _yddias As String, _ydlcred As String, _ydfecing As String, _ydultvent As String, _ydimg As String, _ydrut As String, _ydciudad As Integer, _ydprovincia As Integer, _ydalmacen As Integer) As Boolean
        Dim _resultado As Boolean

        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 2))
        _listParam.Add(New Datos.DParametro("@ydnumi", _ydnumi))
        '_listParam.Add(New Datos.DParametro("@ydcod", _ydcod))
        _listParam.Add(New Datos.DParametro("@ydrazonsocioal", _ydrazonSocial))
        _listParam.Add(New Datos.DParametro("@yddesc", _yddesc))
        _listParam.Add(New Datos.DParametro("@ydnumivend", _ydnumiVendedor))
        _listParam.Add(New Datos.DParametro("@ydzona", _ydzona))
        _listParam.Add(New Datos.DParametro("@yddct", _yddct))
        _listParam.Add(New Datos.DParametro("@yddctnum", _yddctnum))
        _listParam.Add(New Datos.DParametro("@yddirec", _yddirec))
        _listParam.Add(New Datos.DParametro("@ydtelf1", _ydtelf1))
        _listParam.Add(New Datos.DParametro("@ydtelf2", _ydtelf2))
        _listParam.Add(New Datos.DParametro("@ydcat", _ydcat))
        _listParam.Add(New Datos.DParametro("@ydest", _ydest))
        _listParam.Add(New Datos.DParametro("@ydlat", _ydlat))
        _listParam.Add(New Datos.DParametro("@ydlongi", _ydlongi))
        _listParam.Add(New Datos.DParametro("@ydprconsu", 0))
        _listParam.Add(New Datos.DParametro("@ydobs", _ydobs))
        _listParam.Add(New Datos.DParametro("@ydfnac", _ydfnac))
        _listParam.Add(New Datos.DParametro("@ydnomfac", _ydnomfac))
        _listParam.Add(New Datos.DParametro("@ydtip", _ydtip))
        _listParam.Add(New Datos.DParametro("@ydnit", _ydnit))
        _listParam.Add(New Datos.DParametro("@yddias", _yddias))
        _listParam.Add(New Datos.DParametro("@ydlcred", _ydlcred))
        _listParam.Add(New Datos.DParametro("@ydfecing", _ydfecing))
        _listParam.Add(New Datos.DParametro("@ydultvent", _ydultvent))
        _listParam.Add(New Datos.DParametro("@ydciudad", _ydciudad))
        _listParam.Add(New Datos.DParametro("@ydprovincia", _ydprovincia))
        _listParam.Add(New Datos.DParametro("@ydalmacen", _ydalmacen))
        _listParam.Add(New Datos.DParametro("@ydrut", _ydrut))
        _listParam.Add(New Datos.DParametro("@yduact", L_Usuario))

        _Tabla = D_ProcedimientoConParam("sp_Mam_TY004", _listParam)

        If _Tabla.Rows.Count > 0 Then
            _ydnumi = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function
    Public Shared Function L_fnGeneralClientes(tipo As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 3))
        _listParam.Add(New Datos.DParametro("@ydtip", tipo))
        _listParam.Add(New Datos.DParametro("@yduact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TY004", _listParam)

        Return _Tabla
    End Function

#End Region
#Region "Consultas"
    'Mostrar Todos los Clientes
    Public Shared Function L_fnMostrarClientes() As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 3))
        _listParam.Add(New Datos.DParametro("@causuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("REG.sp_CLI001", _listParam)
        '_Tabla = D_Procedimiento("sp_Mostrar")
        Return _Tabla
    End Function
    Public Shared Function L_fnMostrarClientesSiDebeOno() As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 7))
        _listParam.Add(New Datos.DParametro("@causuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("REG.sp_CLI001", _listParam)
        '_Tabla = D_Procedimiento("sp_Mostrar")
        Return _Tabla
    End Function
#End Region
#Region "Verificaciones"
    '****************Verifica si cliente tinee algun paciente relacionado
    Public Shared Function L_fnExistePaciente(_caid As String) As Boolean
        Dim _Tabla As DataTable
        Dim res As Boolean = False
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 6))
        _listParam.Add(New Datos.DParametro("@caid", _caid))
        _Tabla = D_ProcedimientoConParam("REG.sp_CLI001", _listParam)
        Return res = IIf(_Tabla.Rows(0).Item(0) = 0, False, True)
    End Function
#End Region
#End Region

#Region "REG.PACIENTE PAC0011"
#Region "Transacciones"
    'REGISTRA UN PACIENTE
    Public Shared Function L_fnGrabarPaciente(ByRef _pbid As String, _pb_caid As String, _pbnomb As String, _pbespec As String,
                                            _pbfnac As String, _pbraza As String, _pbsex As String, _pbcolor As String, _pbester As String, _pbdest As String, _pbseñas As String,
                                            _pbfingr As String) As Boolean
        'pbid, pb_caid, pbnomb, pbespec, pbfnac, pbraza, pbsex, pbcolor, pbester, pbdest, pbseñas, pbfingr, pbest, pbhora, pbusuario
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@pbid", _pbid))
        _listParam.Add(New Datos.DParametro("@pb_caid", _pb_caid))
        _listParam.Add(New Datos.DParametro("@pbnomb", _pbnomb))
        _listParam.Add(New Datos.DParametro("@pbespec", _pbespec))
        _listParam.Add(New Datos.DParametro("@pbfnac", _pbfnac))
        _listParam.Add(New Datos.DParametro("@pbraza", _pbraza))
        _listParam.Add(New Datos.DParametro("@pbsex", _pbsex))
        _listParam.Add(New Datos.DParametro("@pbcolor", _pbcolor))
        _listParam.Add(New Datos.DParametro("@pbester", _pbester))
        _listParam.Add(New Datos.DParametro("@pbdest", _pbdest))
        _listParam.Add(New Datos.DParametro("@pbseñas", _pbseñas))
        _listParam.Add(New Datos.DParametro("@pbfingr", _pbfingr))
        _listParam.Add(New Datos.DParametro("@pbest", 1))
        _listParam.Add(New Datos.DParametro("@pbusuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("REG.sp_PAC0011", _listParam)
        If _Tabla.Rows.Count > 0 Then
            _pbid = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
    'MODIFICA A UN PACIENTE
    Public Shared Function L_fnModificarPaciente(ByRef _pbid As String, _pb_caid As String, _pbnomb As String, _pbespec As String,
                                           _pbfnac As String, _pbraza As String, _pbsex As String, _pbcolor As String, _pbester As String, _pbdest As String, _pbseñas As String,
                                           _pbfingr As String) As Boolean
        'pbid, pb_caid, pbnomb, pbespec, pbfnac, pbraza, pbsex, pbcolor, pbester, pbdest, pbseñas, pbfingr, pbest, pbhora, pbusuario
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 2))
        _listParam.Add(New Datos.DParametro("@pbid", _pbid))
        _listParam.Add(New Datos.DParametro("@pb_caid", _pb_caid))
        _listParam.Add(New Datos.DParametro("@pbnomb", _pbnomb))
        _listParam.Add(New Datos.DParametro("@pbespec", _pbespec))
        _listParam.Add(New Datos.DParametro("@pbfnac", _pbfnac))
        _listParam.Add(New Datos.DParametro("@pbraza", _pbraza))
        _listParam.Add(New Datos.DParametro("@pbsex", _pbsex))
        _listParam.Add(New Datos.DParametro("@pbcolor", _pbcolor))
        _listParam.Add(New Datos.DParametro("@pbester", _pbester))
        _listParam.Add(New Datos.DParametro("@pbdest", _pbdest))
        _listParam.Add(New Datos.DParametro("@pbseñas", _pbseñas))
        _listParam.Add(New Datos.DParametro("@pbfingr", _pbfingr))
        _Tabla = D_ProcedimientoConParam("REG.sp_PAC0011", _listParam)

        If _Tabla.Rows.Count > 0 Then
            _pbid = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
    'Eliminar PACIENTE
    Public Shared Function L_fnEliminarPaciente(ByRef _pbid As String, ByRef mensaje As String) As Boolean
        Dim _resultado As Boolean
        If L_fnbValidarEliminacion(_pbid, "REG.PAC0011", "pbid", mensaje) = True Then
            Dim _Tabla As DataTable
            Dim _listParam As New List(Of Datos.DParametro)

            _listParam.Add(New Datos.DParametro("@tipo", -1))
            _listParam.Add(New Datos.DParametro("@pbid", _pbid))
            _listParam.Add(New Datos.DParametro("@pbusuario", L_Usuario))
            _Tabla = D_ProcedimientoConParam("REG.sp_PAC0011", _listParam)

            If _Tabla.Rows.Count > 0 Then
                '_caid = _Tabla.Rows(0).Item(0)
                _resultado = True
            Else
                _resultado = False
            End If
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
#End Region
#Region "COnsultas"
    'Mostrar Todos los PACIENTE
    Public Shared Function L_MostrarPacientes() As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 3))
        _listParam.Add(New Datos.DParametro("@pbusuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("REG.sp_PAC0011", _listParam)
        Return _Tabla
    End Function

    Public Shared Function L_MostrarPacientePorId(id As Integer) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 31))
        _listParam.Add(New Datos.DParametro("@pbusuario", L_Usuario))
        _listParam.Add(New Datos.DParametro("@pbid", id))
        _Tabla = D_ProcedimientoConParam("REG.sp_PAC0011", _listParam)
        Return _Tabla
    End Function

    'MUESTRA LOS PASCIENTES SEGUN UN CODIGO DE CLIENTE
    Public Shared Function L_fnMostrarPaciente(_caid As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 4))
        _listParam.Add(New Datos.DParametro("@pb_caid", _caid))
        _Tabla = D_ProcedimientoConParam("REG.sp_PAC0011", _listParam)
        Return _Tabla
    End Function
    '****Muestra pacientes con Seleccion
    Public Shared Function L_fnMostrarPacientesSeleccion(_caid As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 5))
        _listParam.Add(New Datos.DParametro("@pb_caid", _caid))
        _Tabla = D_ProcedimientoConParam("REG.sp_PAC0011", _listParam)
        Return _Tabla
    End Function

#End Region

#End Region
#Region " REG.EMPLEADOS EMP002"
#Region "Transacciones"

    'Grabar 
    Public Shared Function L_fnGrabarEnpleado(ByRef _ecId As String, _ec_lbIdLib As String, _ecCi As String, _ecNomb As String, _ecDir As String,
                                              _ecTelf As String, _ecMail As String, _ecFNac As String, _ecFIngr As String, _ecImg As String, _ecEst As String) As Boolean
        'ecId, ec_lbIdLib, ecCi, ecNomb, ecDir, ecTelf, ecMail, ecFNac, ecFIngr, ecEst, ecImg, ecFecha, ecHora, ecUsuario
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@ecId", _ecId))
        _listParam.Add(New Datos.DParametro("@ecNomb", _ecNomb))
        _listParam.Add(New Datos.DParametro("@ec_lbIdLib", _ec_lbIdLib))
        _listParam.Add(New Datos.DParametro("@ecCi", _ecCi))
        _listParam.Add(New Datos.DParametro("@ecDir", _ecDir))
        _listParam.Add(New Datos.DParametro("@ecTelf", _ecTelf))
        _listParam.Add(New Datos.DParametro("@ecMail", _ecMail))
        _listParam.Add(New Datos.DParametro("@ecFNac", _ecFNac))
        _listParam.Add(New Datos.DParametro("@ecFIngr", _ecFIngr))
        _listParam.Add(New Datos.DParametro("@ecImg", _ecImg))
        _listParam.Add(New Datos.DParametro("@ecEst", _ecEst))
        _listParam.Add(New Datos.DParametro("@ecUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("REG.sp_EMP002", _listParam)
        If _Tabla.Rows.Count > 0 Then
            _ecId = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function
    'Modificar 
    Public Shared Function L_fnModificarEnpleado(ByRef _ecId As String, _ec_lbIdLib As String, _ecCi As String, _ecNomb As String, _ecDir As String,
                                                _ecTelf As String, _ecMail As String, _ecFNac As String, _ecFIngr As String, _ecImg As String, _ecEst As String) As Boolean
        'ecId, ec_lbIdLib, ecCi, ecNomb, ecDir, ecTelf, ecMail, ecFNac, ecFIngr, ecEst, ecImg, ecFecha, ecHora, ecUsuario
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 2))
        _listParam.Add(New Datos.DParametro("@ecId", _ecId))
        _listParam.Add(New Datos.DParametro("@ecNomb", _ecNomb))
        _listParam.Add(New Datos.DParametro("@ec_lbIdLib", _ec_lbIdLib))
        _listParam.Add(New Datos.DParametro("@ecCi", _ecCi))
        _listParam.Add(New Datos.DParametro("@ecDir", _ecDir))
        _listParam.Add(New Datos.DParametro("@ecTelf", _ecTelf))
        _listParam.Add(New Datos.DParametro("@ecMail", _ecMail))
        _listParam.Add(New Datos.DParametro("@ecFNac", _ecFNac))
        _listParam.Add(New Datos.DParametro("@ecFIngr", _ecFIngr))
        _listParam.Add(New Datos.DParametro("@ecImg", _ecImg))
        _listParam.Add(New Datos.DParametro("@ecEst", _ecEst))
        _listParam.Add(New Datos.DParametro("@ecUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("REG.sp_EMP002", _listParam)
        If _Tabla.Rows.Count > 0 Then
            _ecId = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function
    'Eliminar 
    Public Shared Function L_fnEliminarEmpleado(ByRef _ecId As String, ByRef mensaje As String) As Boolean
        Dim _resultado As Boolean
        If L_fnbValidarEliminacion(_ecId, "REG.EMP002", "ecId", mensaje) = True Then
            Dim _Tabla As DataTable
            Dim _listParam As New List(Of Datos.DParametro)
            _listParam.Add(New Datos.DParametro("@tipo", 3))
            _listParam.Add(New Datos.DParametro("@ecId", _ecId))
            _listParam.Add(New Datos.DParametro("@ecUsuario", L_Usuario))
            _Tabla = D_ProcedimientoConParam("REG.sp_EMP002", _listParam)
            If _Tabla.Rows.Count > 0 Then
                _ecId = _Tabla.Rows(0).Item(0)
                _resultado = True
            Else
                _resultado = False
            End If
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
#End Region
#Region "Consultas"
    'Mostrar 
    Public Shared Function L_fnMostrarEmpleado() As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 4))
        _listParam.Add(New Datos.DParametro("@ecUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("REG.sp_EMP002", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_fnMostrarEmpleadoVeterinarios() As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 5))
        _listParam.Add(New Datos.DParametro("@ecUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("REG.sp_EMP002", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_fnMostrarEmpleadoVendedor() As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 6))
        _listParam.Add(New Datos.DParametro("@ecUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("REG.sp_EMP002", _listParam)
        Return _Tabla
    End Function

#End Region
#Region "Verificaciones"
#End Region
#End Region


#Region "FICHA DE ATENCION FIC.ATEN001"
#Region "Consultas"
    '****Muestra la ficha de atencion
    Public Shared Function L_fnMostrarFichaAtencion() As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 2))
        _Tabla = D_ProcedimientoConParam("FIC.sp_ATEN001", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_fnMostrarListaFichaAtencion() As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 3))
        _Tabla = D_ProcedimientoConParam("FIC.sp_ATEN001", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_fnActualizarEstadoFicha(_faid As String) As Boolean
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 6))
        _listParam.Add(New Datos.DParametro("@faId ", _faid))
        _Tabla = D_ProcedimientoConParam("FIC.sp_ATEN001", _listParam)
        If _Tabla.Rows.Count > 0 Then
            _faid = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function

#End Region
#Region "Transacciones"
    '*****Nueva ficha de atencion
    Public Shared Function L_fnGrabarFichaAtencion(_faId As String, ATEN001 As DataTable) As Boolean
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@faUsuario", L_Usuario))
        _listParam.Add(New Datos.DParametro("@ATEN001", "", ATEN001))
        _Tabla = D_ProcedimientoConParam("FIC.sp_ATEN001", _listParam)
        If _Tabla.Rows.Count > 0 Then
            _faId = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
    Public Shared Function L_fnModificarOrdenacionFichaAtencion(_faId As String, _faPriori As String, _tipoOrde As String) As Boolean
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 5))
        _listParam.Add(New Datos.DParametro("@tipoOrde", _tipoOrde))
        _listParam.Add(New Datos.DParametro("@faPriori", _faPriori))
        _listParam.Add(New Datos.DParametro("@faId", "", _faId))
        _Tabla = D_ProcedimientoConParam("FIC.sp_ATEN001", _listParam)
        If _Tabla.Rows.Count > 0 Then
            _faId = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
    Public Shared Sub L_fnOrdenarFichaAtencion(_faId As String, _faPriori As String)
        Dim _res As Boolean = False
        Dim _campos = String.Format("faPriori = {0}", _faPriori)
        Dim _where = String.Format(" faId = {0} ", _faId)
        D_Modificar_Datos("FIC.ATEN001", _campos, _where)
    End Sub
#End Region
#Region "Verificaciones"
    Public Shared Function L_fnFichaAtencionMaxPrioridad() As DataTable
        Dim _Tabla As DataTable
        Dim a As String = DateTime.Now.ToString("yyyy/MM/dd")
        Dim b As String = DateTime.Now
        Dim c As String = Date.Now
        Dim _where = String.Format(" faFechaAten = '{0}'", DateTime.Now.ToString("dd/MM/yyyy"))
        _Tabla = D_Datos_Tabla("ISNULL(MAX(faPriori),0) AS faPriori", "FIC.ATEN001", _where)
        Return _Tabla
    End Function
    Public Shared Function L_fnFichaAtencionMaxPrioridadEmergencia() As DataTable
        Dim _Tabla As DataTable
        Dim a As String = DateTime.Now.ToString("yyyy/MM/dd")
        Dim b As String = DateTime.Now
        Dim c As String = Date.Now
        Dim _where = String.Format(" faFechaAten = '{0}' AND faEstPac = 3", DateTime.Now.ToString("dd/MM/yyyy"))
        _Tabla = D_Datos_Tabla("ISNULL(MAX(faPriori),0) AS faPriori", "FIC.ATEN001", _where)
        Return _Tabla
    End Function
#End Region
#End Region
#Region "Ficha Clinica CLIN002 , CLIN0021 y CLIN0023"
#Region "Transacciones"
    '********Eliminar
    Public Shared Function L_fnEliminarFichaClinica(ByRef _fbId As String, ByRef mensaje As String) As Boolean
        Dim _resultado As Boolean
        If L_fnbValidarEliminacion(_fbId, "FIC.CLIN002", "fbId", mensaje) = True Then
            Dim _Tabla As DataTable
            Dim _listParam As New List(Of Datos.DParametro)

            _listParam.Add(New Datos.DParametro("@tipo", -1))
            _listParam.Add(New Datos.DParametro("@fbId", _fbId))
            _listParam.Add(New Datos.DParametro("@fbUsuario", L_Usuario))
            _Tabla = D_ProcedimientoConParam("FIC.sp_CLIN002", _listParam)

            If _Tabla.Rows.Count > 0 Then
                _fbId = _Tabla.Rows(0).Item(0)
                _resultado = True
            Else
                _resultado = False
            End If
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
    '*********Grabar
    Public Shared Function L_fnGrabarFichaClinica(ByRef _fbid As String, _fb_pbid As String, _fb_ecId As String, _fbFechaAten As String,
                                                            _fbFechaProx As String, _fbHoraIni As String, _fbHoraFin As String, _fbHist As String,
                                                            _fbExam As String, _fbTempe As String, _fbPeso As String, _fbFreCar As String,
                                                            _fbFreRes As String, _fbSCorp As String, _fbTiemCapi As String, _fbTiemRPlie As String,
                                                            _fbNotas As String, _fbValora As String, _fbProtMane As String, _CLIN0021 As DataTable,
                                                            _faId As Integer, _CLIN0023 As DataTable, _CLIN0024 As DataTable, _fbConsultorio As String) As Boolean
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@fbid", _fbid))
        _listParam.Add(New Datos.DParametro("@fb_ecId", _fb_ecId))
        _listParam.Add(New Datos.DParametro("@fb_pbid", _fb_pbid))
        _listParam.Add(New Datos.DParametro("@fbFechaAten", _fbFechaAten))
        _listParam.Add(New Datos.DParametro("@fbFechaProx", _fbFechaProx))
        _listParam.Add(New Datos.DParametro("@fbHoraIni", _fbHoraIni))
        _listParam.Add(New Datos.DParametro("@fbHoraFin", _fbHoraFin))
        _listParam.Add(New Datos.DParametro("@fbHist", _fbHist))
        _listParam.Add(New Datos.DParametro("@fbExam", _fbExam))
        _listParam.Add(New Datos.DParametro("@fbTempe", _fbTempe))
        _listParam.Add(New Datos.DParametro("@fbPeso", _fbPeso))
        _listParam.Add(New Datos.DParametro("@fbFreCar", _fbFreCar))
        _listParam.Add(New Datos.DParametro("@fbFreRes", _fbFreRes))
        _listParam.Add(New Datos.DParametro("@fbSCorp", _fbSCorp))
        _listParam.Add(New Datos.DParametro("@fbTiemCapi", _fbTiemCapi))
        _listParam.Add(New Datos.DParametro("@fbTiemRPlie", _fbTiemRPlie))
        _listParam.Add(New Datos.DParametro("@fbNotas", _fbNotas))
        _listParam.Add(New Datos.DParametro("@fbValora", _fbValora))
        _listParam.Add(New Datos.DParametro("@fbProtMane", _fbProtMane))
        _listParam.Add(New Datos.DParametro("@fbUsuario", L_Usuario))
        _listParam.Add(New Datos.DParametro("@faId", _faId))
        _listParam.Add(New Datos.DParametro("@CLIN0021", "", _CLIN0021))
        _listParam.Add(New Datos.DParametro("@CLIN0023", "", _CLIN0023))
        _listParam.Add(New Datos.DParametro("@CLIN0024", "", _CLIN0024))
        _listParam.Add(New Datos.DParametro("@fbConsultorio", _fbConsultorio))
        _Tabla = D_ProcedimientoConParam("FIC.sp_CLIN002", _listParam)
        If _Tabla.Rows.Count > 0 Then
            _fbid = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function
    '*********Modificar
    Public Shared Function L_fnModificarFichaClinica(ByRef _fbid As String, _fb_pbid As String, _fb_ecId As String, _fbFechaAten As String,
                                                            _fbFechaProx As String, _fbHoraIni As String, _fbHoraFin As String, _fbHist As String,
                                                            _fbExam As String, _fbTempe As String, _fbPeso As String, _fbFreCar As String,
                                                            _fbFreRes As String, _fbSCorp As String, _fbTiemCapi As String, _fbTiemRPlie As String, _fbNotas As String,
                                                            _fbValora As String, _fbProtMane As String, _CLIN0021 As DataTable, _faId As Integer, _CLIN0023 As DataTable, _CLIN0024 As DataTable) As Boolean
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 2))
        _listParam.Add(New Datos.DParametro("@fbid", _fbid))
        _listParam.Add(New Datos.DParametro("@fb_ecId", _fb_ecId))
        _listParam.Add(New Datos.DParametro("@fb_pbid", _fb_pbid))
        _listParam.Add(New Datos.DParametro("@fbFechaAten", _fbFechaAten))
        _listParam.Add(New Datos.DParametro("@fbFechaProx", _fbFechaProx))
        _listParam.Add(New Datos.DParametro("@fbHoraIni", _fbHoraIni))
        _listParam.Add(New Datos.DParametro("@fbHoraFin", _fbHoraFin))
        _listParam.Add(New Datos.DParametro("@fbHist", _fbHist))
        _listParam.Add(New Datos.DParametro("@fbExam", _fbExam))
        _listParam.Add(New Datos.DParametro("@fbTempe", _fbTempe))
        _listParam.Add(New Datos.DParametro("@fbPeso", _fbPeso))
        _listParam.Add(New Datos.DParametro("@fbFreCar", _fbFreCar))
        _listParam.Add(New Datos.DParametro("@fbFreRes", _fbFreRes))
        _listParam.Add(New Datos.DParametro("@fbSCorp", _fbSCorp))
        _listParam.Add(New Datos.DParametro("@fbTiemCapi", _fbTiemCapi))
        _listParam.Add(New Datos.DParametro("@fbTiemRPlie", _fbTiemRPlie))
        _listParam.Add(New Datos.DParametro("@fbNotas", _fbNotas))
        _listParam.Add(New Datos.DParametro("@fbValora", _fbValora))
        _listParam.Add(New Datos.DParametro("@fbProtMane", _fbProtMane))
        _listParam.Add(New Datos.DParametro("@fbUsuario", L_Usuario))
        _listParam.Add(New Datos.DParametro("@faId", _faId))
        _listParam.Add(New Datos.DParametro("@CLIN0021", "", _CLIN0021))
        _listParam.Add(New Datos.DParametro("@CLIN0023", "", _CLIN0023))
        _listParam.Add(New Datos.DParametro("@CLIN0024", "", _CLIN0024))
        _Tabla = D_ProcedimientoConParam("FIC.sp_CLIN002", _listParam)
        If _Tabla.Rows.Count > 0 Then
            _fbid = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function

    Public Shared Function L_fnModificarFichaClinicaAlta(ByRef _fbId As String) As Boolean
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 21))
        _listParam.Add(New Datos.DParametro("@fbId", _fbId))
        _listParam.Add(New Datos.DParametro("@fbUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("FIC.sp_CLIN002", _listParam)
        If _Tabla.Rows.Count > 0 Then
            _fbId = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
#End Region
#Region "Consultas"
    Public Shared Function L_fnMostrarFichaClinicaVacia() As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 3))
        _Tabla = D_ProcedimientoConParam("FIC.sp_CLIN002", _listParam)
        Return _Tabla
    End Function

    Public Shared Function L_fnMostrarFichaClinica() As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 4))
        _Tabla = D_ProcedimientoConParam("FIC.sp_CLIN002", _listParam)
        Return _Tabla
    End Function

    Public Shared Function L_fnListarIDFichasClinicas() As Integer
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 40))
        _Tabla = D_ProcedimientoConParam("FIC.sp_CLIN002", _listParam)
        Return _Tabla.Rows(0).Item("total")
    End Function

    Public Shared Function L_fnListarFichasClinicas(cant As Integer, Optional _limit As Integer = 50000, Optional _filtro As String = "",
                                                     Optional _filtro1 As String = "", Optional _filtro2 As String = "",
                                                     Optional _filtro3 As String = "", Optional _filtro4 As String = "") As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 41))
        _listParam.Add(New Datos.DParametro("@limite", _limit))
        _listParam.Add(New Datos.DParametro("@faId", cant))
        _listParam.Add(New Datos.DParametro("@filtro", _filtro))
        '_listParam.Add(New Datos.DParametro("@filtro1", _filtro1))
        '_listParam.Add(New Datos.DParametro("@filtro2", _filtro2))
        '_listParam.Add(New Datos.DParametro("@filtro3", _filtro3))
        '_listParam.Add(New Datos.DParametro("@filtro4", _filtro4))
        _Tabla = D_ProcedimientoConParam("FIC.sp_CLIN002", _listParam)
        Return _Tabla
    End Function

    Public Shared Function L_fnObtenerFichaClinicaPorID(_id As Integer) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 42))
        _listParam.Add(New Datos.DParametro("@fbid", _id))
        _Tabla = D_ProcedimientoConParam("FIC.sp_CLIN002", _listParam)
        Return _Tabla
    End Function

    Public Shared Function L_fnMostrarFichaClinicaUno(_fbId As Integer) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 8))
        _listParam.Add(New Datos.DParametro("@fbId", _fbId))
        _Tabla = D_ProcedimientoConParam("FIC.sp_CLIN002", _listParam)
        Return _Tabla
    End Function

    Public Shared Function L_fnMostrarFichaClinicaDetalle(_fbId As Integer) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 5))
        _listParam.Add(New Datos.DParametro("@fbId", _fbId))
        _Tabla = D_ProcedimientoConParam("FIC.sp_CLIN002", _listParam)
        Return _Tabla
    End Function
    '*******Muestra el ultimo registro y el codigo de  Ficha Clinica(FbId) segun un codigo de  Paciente
    Public Shared Function L_fnMostrarIdFichaClinica(ByRef _fbId As Integer, _fb_pbId As String) As Boolean
        Dim _Tabla As DataTable
        Dim _res As Boolean = False
        Dim _where = String.Format(" clin.fb_pbid= {0} AND  clin.fbFecha = (SELECT MAX(clin2.fbFecha) FROM FIC.CLIN002 clin2 WHERE clin2.fb_pbid = {0}) 
				                                    AND clin.fbHora = (SELECT MAX(clin2.fbHora) FROM FIC.CLIN002 clin2 WHERE clin2.fb_pbid = {0} 
									                AND clin2.fbFecha = (SELECT MAX(clin3.fbFecha) FROM FIC.CLIN002 clin3 WHERE clin3.fb_pbid = {0}))", _fb_pbId)
        _Tabla = D_Datos_Tabla(" fbid ", " FIC.CLIN002 clin ", _where)
        If _Tabla.Rows.Count = 0 Then
            _fbId = 0
        Else
            _fbId = _Tabla.Rows(0).Item(0)
        End If
        Return _res = IIf(_Tabla.Rows.Count <> 0, False, True)
    End Function
    Public Shared Function L_prMostrarImagenesFichaClinica(_fbId As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 6))
        _listParam.Add(New Datos.DParametro("@fbId", _fbId))
        _Tabla = D_ProcedimientoConParam("FIC.sp_CLIN002", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_prMostrarFichaClinicaSeguimiento(_fbId As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 7))
        _listParam.Add(New Datos.DParametro("@fbId", _fbId))
        _Tabla = D_ProcedimientoConParam("FIC.sp_CLIN002", _listParam)
        Return _Tabla
    End Function

#End Region
#Region "Verificaciones"
    Public Shared Function L_fnExisteFichaClinica(_fb_pbid As String) As Boolean
        Dim _Tabla As DataTable
        Dim _res As Boolean = False
        Dim _where = String.Format(" clin.fb_pbid = {0} ", _fb_pbid)
        _Tabla = D_Datos_Tabla(" COUNT(*) ", " FIC.CLIN002 clin ", _where)
        Return _res = IIf(_Tabla.Rows(0).Item(0) <> 0, True, False)
    End Function
    Public Shared Function L_fnExisteTransRelacionadasFichaClinica(_fb_pbid As String) As Boolean
        Dim _Tabla As DataTable
        Dim _res As Boolean = False
        Dim _where = String.Format(" clin.fb_pbid = {0} ", _fb_pbid)
        _Tabla = D_Datos_Tabla(" COUNT(*) ", " FIC.CLIN002 clin ", _where)
        Return _res = IIf(_Tabla.Rows(0).Item(0) <> 0, True, False)
    End Function
    Public Shared Function L_fnExisteFichaClinicaAlta(_fbId As String) As Boolean
        Dim _Tabla As DataTable
        Dim _res As Boolean = False
        Dim _where = String.Format(" clin.fbid = {0} AND fbAlta = 2 ", _fbId)
        _Tabla = D_Datos_Tabla(" COUNT(*) ", " FIC.CLIN002 clin ", _where)
        If _Tabla.Rows(0).Item(0) = 0 Then
            _res = True
        Else
            _res = False
        End If
        Return _res
    End Function
    Public Shared Function L_fnExisteEliminarCirugia(_cfId As String) As Boolean
        Dim _Tabla As DataTable
        Dim _res As Boolean = False
        Dim _where = String.Format(" a.cf_FbId =  {0} AND b.roEst <> -1 ", _cfId)
        _Tabla = D_Datos_Tabla(" COUNT(*) ", " FIC.CIR0024 a JOIN FIC.RECCIR005 b  ON a.cfId = b.ro_cfId JOIN FIC.CLIN002 c ON c.fbid = a.cf_FbId  ", _where)
        Return _res = IIf(_Tabla.Rows(0).Item(0) <> 0, True, False)
    End Function
#End Region
#End Region
#Region "Cirugia CIR0024"
#Region "Transacciones"
    '********Registrar
    Public Shared Function L_fnGrabarCirugia(ByRef cfId As String, cf_FbId As String, cfFechaAten As String, cfPeso As String, cfEdad As String,
                                                            cfRespon As String, cfTelef As String, cfImport As String, cfClasASA As String,
                                                            cfProc As String, cfObser As String) As Boolean
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@cfId", cfId))
        _listParam.Add(New Datos.DParametro("@cf_FbId", cf_FbId))
        _listParam.Add(New Datos.DParametro("@cfEst", 1))
        _listParam.Add(New Datos.DParametro("@cfFechaAten", cfFechaAten))
        _listParam.Add(New Datos.DParametro("@cfPeso", cfPeso))
        _listParam.Add(New Datos.DParametro("@cfRespon", cfRespon))
        _listParam.Add(New Datos.DParametro("@cfEdad", cfEdad))
        _listParam.Add(New Datos.DParametro("@cfTelef", cfTelef))
        _listParam.Add(New Datos.DParametro("@cfImport", cfImport))
        _listParam.Add(New Datos.DParametro("@cfClasASA", cfClasASA))
        _listParam.Add(New Datos.DParametro("@cfProc", cfProc))
        _listParam.Add(New Datos.DParametro("@cfObser", cfObser))
        _listParam.Add(New Datos.DParametro("@cfUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("FIC.sp_CIR0024", _listParam)
        If _Tabla.Rows.Count > 0 Then
            cfId = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
    '********Modificar
    Public Shared Function L_fnMoficicarCirugia(ByRef cfId As String, cf_FbId As String, cfFechaAten As String, cfPeso As String, cfEdad As String,
                                                            cfRespon As String, cfTelef As String, cfImport As String, cfClasASA As String,
                                                            cfProc As String, cfObser As String) As Boolean
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 2))
        _listParam.Add(New Datos.DParametro("@cfId", cfId))
        _listParam.Add(New Datos.DParametro("@cf_FbId", cf_FbId))
        _listParam.Add(New Datos.DParametro("@cfEst", 1))
        _listParam.Add(New Datos.DParametro("@cfFechaAten", cfFechaAten))
        _listParam.Add(New Datos.DParametro("@cfPeso", cfPeso))
        _listParam.Add(New Datos.DParametro("@cfEdad", cfEdad))
        _listParam.Add(New Datos.DParametro("@cfRespon", cfRespon))
        _listParam.Add(New Datos.DParametro("@cfTelef", cfTelef))
        _listParam.Add(New Datos.DParametro("@cfImport", cfImport))
        _listParam.Add(New Datos.DParametro("@cfClasASA", cfClasASA))
        _listParam.Add(New Datos.DParametro("@cfProc", cfProc))
        _listParam.Add(New Datos.DParametro("@cfObser", cfObser))
        _listParam.Add(New Datos.DParametro("@cfUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("FIC.sp_CIR0024", _listParam)
        If _Tabla.Rows.Count > 0 Then
            cfId = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
    '********Eliminar
    Public Shared Function L_fnEliminarCirugia(ByRef _cf_FbId As String, ByRef mensaje As String) As Boolean
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 3))
        _listParam.Add(New Datos.DParametro("@cf_FbId", _cf_FbId))
        _listParam.Add(New Datos.DParametro("@cfUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("FIC.sp_CIR0024", _listParam)

        If _Tabla.Rows.Count > 0 Then
            _cf_FbId = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
#End Region
#Region "Consultas"
    Public Shared Function L_fnMostrarCirugia() As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 4))
        _Tabla = D_ProcedimientoConParam("FIC.sp_CIR0024", _listParam)
        Return _Tabla
    End Function

    Public Shared Function L_fnMostrarCirugiaPorID(id As Integer) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 41))
        _listParam.Add(New Datos.DParametro("@cf_FbId", id))
        _Tabla = D_ProcedimientoConParam("FIC.sp_CIR0024", _listParam)
        Return _Tabla
    End Function

    Public Shared Function L_fnMostrarCirugiaRecibo() As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 5))
        _Tabla = D_ProcedimientoConParam("FIC.sp_CIR0024", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_fnMostrarFichaClinicaCirugiaRecibo() As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 6))
        _Tabla = D_ProcedimientoConParam("FIC.sp_CIR0024", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_prMostrarFechaCirugia(_fbId As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 7))
        _listParam.Add(New Datos.DParametro("@cf_FbId", _fbId))
        _Tabla = D_ProcedimientoConParam("FIC.sp_CIR0024", _listParam)
        Return _Tabla
    End Function
#End Region
#Region "Verificaciones"
    Public Shared Function L_fnExisteCirugia(_fbId As String) As Boolean
        Dim _Tabla As DataTable
        Dim _res As Boolean = False
        Dim _where = String.Format(" cf_FbId = {0} ", _fbId)
        _Tabla = D_Datos_Tabla(" COUNT(*) ", " FIC.CIR0024 ", _where)
        If _Tabla.Rows(0).Item(0) = 0 Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region
#End Region
#Region "Internacion INT0025"
#Region "Transacciones"
    '********Registrar
    Public Shared Function L_fnGrabarInternacion(ByRef igId As String, ig_fbId As String, igFechaIng As String,
                                                            igEdad As String, igTelf As String, igMotInter As String, igRequer As String,
                                                            igHoraInter As String) As Boolean
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@igId", igId))
        _listParam.Add(New Datos.DParametro("@ig_fbId", ig_fbId))
        _listParam.Add(New Datos.DParametro("@igEst", 1))
        _listParam.Add(New Datos.DParametro("@igFechaIng", igFechaIng))
        _listParam.Add(New Datos.DParametro("@igEdad", igEdad))
        _listParam.Add(New Datos.DParametro("@igTelf", igTelf))
        _listParam.Add(New Datos.DParametro("@igMotInter", igMotInter))
        _listParam.Add(New Datos.DParametro("@igRequer", igRequer))
        _listParam.Add(New Datos.DParametro("@igHoraInter", igHoraInter))
        _listParam.Add(New Datos.DParametro("@igUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("FIC.sp_INT0025", _listParam)
        If _Tabla.Rows.Count > 0 Then
            igId = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
    '********Modificar
    Public Shared Function L_fnModificarInternacion(ByRef igId As String, ig_fbId As String, igFechaIng As String,
                                                            igEdad As String, igTelf As String, igMotInter As String, igRequer As String,
                                                            igHoraInter As String) As Boolean
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 2))
        _listParam.Add(New Datos.DParametro("@igId", igId))
        _listParam.Add(New Datos.DParametro("@ig_fbId", ig_fbId))
        _listParam.Add(New Datos.DParametro("@igEst", 1))
        _listParam.Add(New Datos.DParametro("@igFechaIng", igFechaIng))
        _listParam.Add(New Datos.DParametro("@igEdad", igEdad))
        _listParam.Add(New Datos.DParametro("@igTelf", igTelf))
        _listParam.Add(New Datos.DParametro("@igMotInter", igMotInter))
        _listParam.Add(New Datos.DParametro("@igRequer", igRequer))
        _listParam.Add(New Datos.DParametro("@igHoraInter", igHoraInter))
        _listParam.Add(New Datos.DParametro("@igUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("FIC.sp_INT0025", _listParam)
        If _Tabla.Rows.Count > 0 Then
            igId = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
    '********Eliminar
    Public Shared Function L_fnEliminarInternacion(ByRef _ig_fbId As String, ByRef mensaje As String) As Boolean
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 3))
        _listParam.Add(New Datos.DParametro("@ig_fbId", _ig_fbId))
        _listParam.Add(New Datos.DParametro("@igUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("FIC.sp_INT0025", _listParam)
        If _Tabla.Rows.Count > 0 Then
            _ig_fbId = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
#End Region
#Region "Consultas"
    Public Shared Function L_fnMostrarInternacion() As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 4))
        _Tabla = D_ProcedimientoConParam("FIC.sp_INT0025", _listParam)
        Return _Tabla
    End Function

    Public Shared Function L_fnMostrarInternacionPorID(id As Integer) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 41))
        _listParam.Add(New Datos.DParametro("@ig_fbId", id))
        _Tabla = D_ProcedimientoConParam("FIC.sp_INT0025", _listParam)
        Return _Tabla
    End Function

    Public Shared Function L_fnMostrarFichaClinicaConInternacion() As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 5))
        _Tabla = D_ProcedimientoConParam("FIC.sp_INT0025", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_prMostrarInternación(_fbId As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 6))
        _listParam.Add(New Datos.DParametro("@ig_fbId", _fbId))
        _Tabla = D_ProcedimientoConParam("FIC.sp_INT0025", _listParam)
        Return _Tabla
    End Function
#End Region
#Region "Verificaciones"
    Public Shared Function L_fnExisteInternacion(_fbId As String) As Boolean
        Dim _Tabla As DataTable
        Dim _res As Boolean = False
        Dim _where = String.Format(" ig_FbId = {0} ", _fbId)
        _Tabla = D_Datos_Tabla(" COUNT(*) ", " FIC.INT0025 ", _where)
        Return _res = IIf(_Tabla.Rows(0).Item(0) <> 0, True, False)
    End Function
#End Region
#End Region
#Region "Seguimiento de Internacion INT00251"
#Region "Transacciones"
    'ihId, ih_fbId, ihEst, ihFechaIng, ihTurno, ihDiag, ihObser, ihPasoTur, ihFecha, ihHora, ihUsuario
    '********Registrar
    'iiId, ii_ihId, iiEst, iiHoraTurn, iiResp, iiFrec, iiMedPro, iiAlim, iiFecha, iiHora, iiusuario
    Public Shared Function L_fnGrabarInternacionSeg(ByRef ihId As String, ih_fbId As String, ih_pbId As String,
                                                    ihFechaIng As String, ihTurno As String, Tipo2 As String, _INT00252 As DataTable,
                                                    _INT00253 As DataTable, _INT00254 As DataTable, _INT00255 As DataTable,
                                                    _INT00256 As DataTable, _INT00257 As DataTable, _INT00258 As DataTable) As Boolean
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@ihId", ihId))
        _listParam.Add(New Datos.DParametro("@ih_fbId", ih_fbId))
        _listParam.Add(New Datos.DParametro("@ih_pbId", ih_pbId))
        _listParam.Add(New Datos.DParametro("@ihFechaIng", ihFechaIng))
        _listParam.Add(New Datos.DParametro("@ihTurno", ihTurno))
        _listParam.Add(New Datos.DParametro("@tipo2", Tipo2))
        _listParam.Add(New Datos.DParametro("@ihEst", 1))
        _listParam.Add(New Datos.DParametro("@ihUsuario", L_Usuario))
        'Detalles
        _listParam.Add(New Datos.DParametro("@INT00252", "", _INT00252))
        _listParam.Add(New Datos.DParametro("@INT00253", "", _INT00253))
        _listParam.Add(New Datos.DParametro("@INT00254", "", _INT00254))
        _listParam.Add(New Datos.DParametro("@INT00255", "", _INT00255))
        _listParam.Add(New Datos.DParametro("@INT00256", "", _INT00256))
        _listParam.Add(New Datos.DParametro("@INT00257", "", _INT00257))
        _listParam.Add(New Datos.DParametro("@INT00258", "", _INT00258))

        _Tabla = D_ProcedimientoConParam("FIC.sp_INT00251", _listParam)
        If _Tabla.Rows.Count > 0 Then
            ihId = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
    '********Modificar
    Public Shared Function L_fnModificarInternacionSeg(ByRef ihId As String, ih_fbId As String, ih_pbId As String,
                                                     ihFechaIng As String, ihTurno As String, Tipo2 As String, _INT00252 As DataTable,
                                                    _INT00253 As DataTable, _INT00254 As DataTable, _INT00255 As DataTable,
                                                    _INT00256 As DataTable, _INT00257 As DataTable, _INT00258 As DataTable) As Boolean
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 2))
        _listParam.Add(New Datos.DParametro("@ihId", ihId))
        _listParam.Add(New Datos.DParametro("@ih_fbId", ih_fbId))
        _listParam.Add(New Datos.DParametro("@ih_pbId", ih_pbId))
        _listParam.Add(New Datos.DParametro("@ihFechaIng", ihFechaIng))
        _listParam.Add(New Datos.DParametro("@ihTurno", ihTurno))
        _listParam.Add(New Datos.DParametro("@tipo2", Tipo2))
        _listParam.Add(New Datos.DParametro("@ihEst", 1))
        _listParam.Add(New Datos.DParametro("@ihUsuario", L_Usuario))
        'Detalles
        _listParam.Add(New Datos.DParametro("@INT00252", "", _INT00252))
        _listParam.Add(New Datos.DParametro("@INT00253", "", _INT00253))
        _listParam.Add(New Datos.DParametro("@INT00254", "", _INT00254))
        _listParam.Add(New Datos.DParametro("@INT00255", "", _INT00255))
        _listParam.Add(New Datos.DParametro("@INT00256", "", _INT00256))
        _listParam.Add(New Datos.DParametro("@INT00257", "", _INT00257))
        _listParam.Add(New Datos.DParametro("@INT00258", "", _INT00258))

        _Tabla = D_ProcedimientoConParam("FIC.sp_INT00251", _listParam)

        If _Tabla.Rows.Count > 0 Then
            ihId = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
    '********Eliminar
    Public Shared Function L_fnEliminarInternacionSeg(ByRef _ihId As String, ByRef mensaje As String) As Boolean
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        If L_fnbValidarEliminacion(_ihId, "FIC.INT00251", "ihId", mensaje) = True Then

            _listParam.Add(New Datos.DParametro("@tipo", 3))
            _listParam.Add(New Datos.DParametro("@ihId", _ihId))
            _listParam.Add(New Datos.DParametro("@ihUsuario", L_Usuario))
            _Tabla = D_ProcedimientoConParam("FIC.sp_INT00251", _listParam)
            If _Tabla.Rows.Count > 0 Then
                _ihId = _Tabla.Rows(0).Item(0)
                _resultado = True
            Else
                _resultado = False
            End If
            Return _resultado
        Else
            _resultado = False
        End If
        Return _resultado



    End Function
#End Region
#Region "Consultas"
    Public Shared Function L_fnMostrarInternacionSeg() As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 4))
        _Tabla = D_ProcedimientoConParam("FIC.sp_INT00251", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_fnMostrarExamenFisico(idInternacion As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 5))
        _listParam.Add(New Datos.DParametro("@ihId", idInternacion))
        _Tabla = D_ProcedimientoConParam("FIC.sp_INT00251", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_fnMostrarSignosVitales(idInternacion As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 6))
        _listParam.Add(New Datos.DParametro("@ihId", idInternacion))
        _Tabla = D_ProcedimientoConParam("FIC.sp_INT00251", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_fnMostrarMonitoreo(idInternacion As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 7))
        _listParam.Add(New Datos.DParametro("@ihId", idInternacion))
        _Tabla = D_ProcedimientoConParam("FIC.sp_INT00251", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_fnMostrarAlimentacion(idInternacion As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 8))
        _listParam.Add(New Datos.DParametro("@ihId", idInternacion))
        _Tabla = D_ProcedimientoConParam("FIC.sp_INT00251", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_fnMostrarFluidoterapia(idInternacion As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 9))
        _listParam.Add(New Datos.DParametro("@ihId", idInternacion))
        _Tabla = D_ProcedimientoConParam("FIC.sp_INT00251", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_fnMostrarEstudiosC(idInternacion As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 10))
        _listParam.Add(New Datos.DParametro("@ihId", idInternacion))
        _Tabla = D_ProcedimientoConParam("FIC.sp_INT00251", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_fnMostrarTratamiento(idInternacion As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 11))
        _listParam.Add(New Datos.DParametro("@ihId", idInternacion))
        _Tabla = D_ProcedimientoConParam("FIC.sp_INT00251", _listParam)
        Return _Tabla
    End Function
#End Region
#Region "Verificaciones"

#End Region
#End Region

#Region "Recibo FIC.REC003"
#Region "Transacciones"
    '********Registrar
    'rkId, rk_fbId, rkEst, rkFechaIng, rkObser, rkDesc, rkTotal, rkFecha, rkHora, rkusuario
    Public Shared Function L_fnGrabarRecibo(ByRef rkId As String, rk_fbId As String, rkFechaIng As String,
                                            rkDesc As String, rkTotal As Decimal, _REC0031 As DataTable, pagado As String)
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@rkId", rkId))
        _listParam.Add(New Datos.DParametro("@rk_fbId", rk_fbId))
        _listParam.Add(New Datos.DParametro("@rkEst", 1))

        _listParam.Add(New Datos.DParametro("@rkFechaIng", rkFechaIng))
        _listParam.Add(New Datos.DParametro("@rkDesc", rkDesc))
        _listParam.Add(New Datos.DParametro("@pagado", pagado))
        _listParam.Add(New Datos.DParametro("@rkTotal", rkTotal))
        _listParam.Add(New Datos.DParametro("@REC0031", "", _REC0031))
        _listParam.Add(New Datos.DParametro("@rkusuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("FIC.sp_REC003", _listParam)
        If _Tabla.Rows.Count > 0 Then
            rkId = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
    '********Modificar
    Public Shared Function L_fnModificarRecibo(ByRef rkId As String, rk_fbId As String, rkFechaIng As String,
                                            rkDesc As String, rkTotal As Decimal, _REC0031 As DataTable, pagado As String)
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 2))
        _listParam.Add(New Datos.DParametro("@rkId", rkId))
        _listParam.Add(New Datos.DParametro("@rk_fbId", rk_fbId))
        _listParam.Add(New Datos.DParametro("@rkEst", 1))
        _listParam.Add(New Datos.DParametro("@pagado", pagado))
        _listParam.Add(New Datos.DParametro("@rkFechaIng", rkFechaIng))
        _listParam.Add(New Datos.DParametro("@rkDesc", rkDesc))
        _listParam.Add(New Datos.DParametro("@rkTotal", rkTotal))
        _listParam.Add(New Datos.DParametro("@REC0031", "", _REC0031))
        _listParam.Add(New Datos.DParametro("@rkusuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("FIC.sp_REC003", _listParam)
        If _Tabla.Rows.Count > 0 Then
            rkId = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
    '********Eliminar
    Public Shared Function L_fnEliminarRecibo(ByRef _rkId As String, ByRef mensaje As String) As Boolean
        Dim _resultado As Boolean
        If L_fnbValidarEliminacion(_rkId, "FIC.REC003", "rkId", mensaje) = True Then
            Dim _Tabla As DataTable
            Dim _listParam As New List(Of Datos.DParametro)
            _listParam.Add(New Datos.DParametro("@tipo", 3))
            _listParam.Add(New Datos.DParametro("@rkId", _rkId))
            _listParam.Add(New Datos.DParametro("@rkusuario", L_Usuario))
            _Tabla = D_ProcedimientoConParam("FIC.sp_REC003", _listParam)
            If _Tabla.Rows.Count > 0 Then
                _rkId = _Tabla.Rows(0).Item(0)
                _resultado = True
            Else
                _resultado = False
            End If
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
#End Region
#Region "Consultas"
    Public Shared Function L_fnMostrarRecibo() As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 4))
        _listParam.Add(New Datos.DParametro("@rkusuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("FIC.sp_REC003", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_fnMostrarReciboDetalle(rkId As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 5))
        _listParam.Add(New Datos.DParametro("@rkId", rkId))
        _listParam.Add(New Datos.DParametro("@rkusuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("FIC.sp_REC003", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_fnMostrarReciboDetalleServicio(_REC0031 As DataTable) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 6))
        _listParam.Add(New Datos.DParametro("@REC0031", "", _REC0031))
        _listParam.Add(New Datos.DParametro("@rkusuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("FIC.sp_REC003", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_fnMostrarReciboReporte(IdRecibo As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 7))
        _listParam.Add(New Datos.DParametro("@rkId", IdRecibo))
        _listParam.Add(New Datos.DParametro("@rkusuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("FIC.sp_REC003", _listParam)
        Return _Tabla
    End Function
#End Region
#Region "Verificaciones"
    'Public Shared Function L_fnExisteRecibo(_fbId As String) As Boolean
    '    Dim _Tabla As DataTable
    '    Dim _res As Boolean = False
    '    Dim _where = String.Format(" ig_FbId = {0} ", _fbId)
    '    _Tabla = D_Datos_Tabla(" COUNT(*) ", " FIC.INT0025 ", _where)
    '    Return _res = IIf(_Tabla.Rows(0).Item(0) <> 0, True, False)
    'End Function
#End Region
#End Region

#Region "Recibo Internacion FIC.RECINT004"
#Region "Transacciones"
    '********Registrar
    'rmId, rm_IhID, rmEst, rmFechaIng, rmTratam, rmTotal, rmFecha, rmHora, rmusuario
    Public Shared Function L_fnGrabarReciboInt(ByRef rmId As String, rm_IhID As String, rm_PbId As String, rmFechaIng As String,
                                            rmTratam As String, rmTotal As Decimal, _RECINT0041 As DataTable)
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@rmId", rmId))
        _listParam.Add(New Datos.DParametro("@rm_PbId", rm_PbId))
        _listParam.Add(New Datos.DParametro("@rm_IhID", rm_IhID))
        _listParam.Add(New Datos.DParametro("@rmEst", 1))
        _listParam.Add(New Datos.DParametro("@rmFechaIng", rmFechaIng))
        _listParam.Add(New Datos.DParametro("@rmTratam", rmTratam))
        _listParam.Add(New Datos.DParametro("@rmTotal", rmTotal))
        _listParam.Add(New Datos.DParametro("@RECINT0041", "", _RECINT0041))
        _listParam.Add(New Datos.DParametro("@rmUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("FIC.sp_RECINT004", _listParam)
        If _Tabla.Rows.Count > 0 Then
            rmId = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
    '********Modificar
    Public Shared Function L_fnModificarReciboInt(ByRef rmId As String, rm_IhID As String, rm_PbId As String, rmFechaIng As String,
                                            rmTratam As String, rmTotal As Decimal, _RECINT0041 As DataTable)
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 2))
        _listParam.Add(New Datos.DParametro("@rmId", rmId))
        _listParam.Add(New Datos.DParametro("@rm_IhID", rm_IhID))
        _listParam.Add(New Datos.DParametro("@rm_PbId", rm_PbId))
        _listParam.Add(New Datos.DParametro("@rmEst", 1))
        _listParam.Add(New Datos.DParametro("@rmFechaIng", rmFechaIng))
        _listParam.Add(New Datos.DParametro("@rmTratam", rmTratam))
        _listParam.Add(New Datos.DParametro("@rmTotal", rmTotal))
        _listParam.Add(New Datos.DParametro("@RECINT0041", "", _RECINT0041))
        _listParam.Add(New Datos.DParametro("@rmUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("FIC.sp_RECINT004", _listParam)
        If _Tabla.Rows.Count > 0 Then
            rmId = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
    '********Eliminar
    Public Shared Function L_fnEliminarReciboInt(ByRef rmId As String, ByRef mensaje As String) As Boolean
        Dim _resultado As Boolean
        If L_fnbValidarEliminacion(rmId, "FIC.RECINT004", "rmId", mensaje) = True Then
            Dim _Tabla As DataTable
            Dim _listParam As New List(Of Datos.DParametro)
            _listParam.Add(New Datos.DParametro("@tipo", 3))
            _listParam.Add(New Datos.DParametro("@rmId", rmId))
            _listParam.Add(New Datos.DParametro("@rmusuario", L_Usuario))
            _Tabla = D_ProcedimientoConParam("FIC.sp_RECINT004", _listParam)
            If _Tabla.Rows.Count > 0 Then
                rmId = _Tabla.Rows(0).Item(0)
                _resultado = True
            Else
                _resultado = False
            End If
            Return _resultado
        Else
            _resultado = False
        End If
        Return _resultado

    End Function
#End Region
#Region "Consultas"
    Public Shared Function L_fnMostrarReciboInt(Estado As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 4))
        _listParam.Add(New Datos.DParametro("@rmEst", Estado))
        _listParam.Add(New Datos.DParametro("@rmusuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("FIC.sp_RECINT004", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_fnMostrarReciboIntDetalle(rmId As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 5))
        _listParam.Add(New Datos.DParametro("@rmId", rmId))
        _listParam.Add(New Datos.DParametro("@rmusuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("FIC.sp_RECINT004", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_fnMostrarReciboIntXPaciente(Estado As String, _idPaciente As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 6))
        _listParam.Add(New Datos.DParametro("@rmEst", Estado))
        _listParam.Add(New Datos.DParametro("@rm_PbId", _idPaciente))
        _listParam.Add(New Datos.DParametro("@rmusuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("FIC.sp_RECINT004", _listParam)
        Return _Tabla
    End Function
#End Region
#Region "Verificaciones"

#End Region
#End Region

#Region "Recibo Cirugia FIC.RECCIR005"
#Region "Transacciones"
    '********Registrar
    'roId, ro_cfId, ro_PbId, ro_rmId, roEst, roFechaIng, roTotal, roFecha, roHora, rousuario
    Public Shared Function L_fnGrabarReciboCir(ByRef roId As String, ro_cfId As String, ro_PbId As String, ro_rmId As String, roFechaIng As String,
                                           roTotal As Decimal, _RECCIR0051 As DataTable)
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@roId", roId))
        _listParam.Add(New Datos.DParametro("@ro_cfId", ro_cfId))
        _listParam.Add(New Datos.DParametro("@ro_PbId", ro_PbId))
        _listParam.Add(New Datos.DParametro("@ro_rmId", ro_rmId))
        _listParam.Add(New Datos.DParametro("@roEst", 1))
        _listParam.Add(New Datos.DParametro("@roFechaIng", roFechaIng))
        _listParam.Add(New Datos.DParametro("@roTotal", roTotal))
        _listParam.Add(New Datos.DParametro("@RECCIR0051", "", _RECCIR0051))
        _listParam.Add(New Datos.DParametro("@roUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("FIC.sp_RECCIR005", _listParam)
        If _Tabla.Rows.Count > 0 Then
            roId = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
    '********Modificar
    Public Shared Function L_fnModificarReciboCir(ByRef roId As String, ro_cfId As String, ro_PbId As String, ro_rmId As String, roFechaIng As String,
                                           roTotal As Decimal, _RECCIR0051 As DataTable)
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 2))
        _listParam.Add(New Datos.DParametro("@roId", roId))
        _listParam.Add(New Datos.DParametro("@ro_cfId", ro_cfId))
        _listParam.Add(New Datos.DParametro("@ro_PbId", ro_PbId))
        _listParam.Add(New Datos.DParametro("@ro_rmId", ro_rmId))
        _listParam.Add(New Datos.DParametro("@roEst", 1))
        _listParam.Add(New Datos.DParametro("@roFechaIng", roFechaIng))
        _listParam.Add(New Datos.DParametro("@roTotal", roTotal))
        _listParam.Add(New Datos.DParametro("@RECCIR0051", "", _RECCIR0051))
        _listParam.Add(New Datos.DParametro("@roUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("FIC.sp_RECCIR005", _listParam)
        If _Tabla.Rows.Count > 0 Then
            roId = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
    '********Eliminar
    Public Shared Function L_fnEliminarReciboCir(ByRef roId As String, ByRef mensaje As String, ro_rmId As String) As Boolean
        Dim _resultado As Boolean
        If L_fnbValidarEliminacion(roId, "FIC.RECCIR005", "roId", mensaje) = True Then
            Dim _Tabla As DataTable
            Dim _listParam As New List(Of Datos.DParametro)
            _listParam.Add(New Datos.DParametro("@tipo", 3))
            _listParam.Add(New Datos.DParametro("@roId", roId))
            _listParam.Add(New Datos.DParametro("@ro_rmId", ro_rmId))
            _listParam.Add(New Datos.DParametro("@rousuario", L_Usuario))
            _Tabla = D_ProcedimientoConParam("FIC.sp_RECCIR005", _listParam)
            If _Tabla.Rows.Count > 0 Then
                roId = _Tabla.Rows(0).Item(0)
                _resultado = True
            Else
                _resultado = False
            End If
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
#End Region
#Region "Consultas"
    Public Shared Function L_fnMostrarReciboCir() As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 4))
        _listParam.Add(New Datos.DParametro("@rousuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("FIC.sp_RECCIR005", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_fnMostrarReciboCirDetalle(roId As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 5))
        _listParam.Add(New Datos.DParametro("@roId", roId))
        _listParam.Add(New Datos.DParametro("@rousuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("FIC.sp_RECCIR005", _listParam)
        Return _Tabla
    End Function
#End Region
#Region "Verificaciones"
    'Verifica existencia de algun det. Recibo de Internacion (Validacion para eliminar)
    Public Shared Function L_fnExisteReciboCir_DetalleRecInt(_rnId As String) As Boolean
        Dim _Tabla As DataTable
        Dim _res As Boolean = False
        Dim _where = String.Format(" rnId = {0} ", _rnId)
        _Tabla = D_Datos_Tabla(" COUNT(*) ", " FIC.RECINT0041 ", _where)
        Return _res = IIf(_Tabla.Rows(0).Item(0) <> 0, True, False)
    End Function
#End Region
#End Region

#Region "VENTA VEN.VEN0001"
#Region "Transacciones"
    '********Registrar
    'vaId, va_rkId, va_caId, va_ecId, vaTipoVe, vaFechaDoc, vaFechaVenCre, vaObser, vaEst, vaDesc, vaTotal, vaFecha, vaHora, vausuario
    Public Shared Function L_fnGrabarVenta(ByRef vaId As String, va_rkId As String, va_roId As String, va_rmId As String,
                                           va_pbId As String, va_caId As String, va_ecId As String, vaTipoVe As String,
                                           vaFechaDoc As String, vaFechaVenCre As String, vaObser As String, vaDesc As String,
                                           vaTotal As String, _VEN001 As DataTable, vaAlm As String, vaCuenta As String,
                                           vaEmision As String, vaTarjeta As String, vaTransferencia As String, vaTurno As Integer)
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@vaId", vaId))
        _listParam.Add(New Datos.DParametro("@va_rkId", va_rkId))
        _listParam.Add(New Datos.DParametro("@va_roId", va_roId))
        _listParam.Add(New Datos.DParametro("@va_rmId", va_rmId))
        _listParam.Add(New Datos.DParametro("@va_pbId", va_pbId))
        _listParam.Add(New Datos.DParametro("@va_caId", va_caId))
        _listParam.Add(New Datos.DParametro("@va_ecId", va_ecId))
        _listParam.Add(New Datos.DParametro("@vaAlm", vaAlm))
        _listParam.Add(New Datos.DParametro("@vaTipoVe", vaTipoVe))
        _listParam.Add(New Datos.DParametro("@vaFechaDoc", vaFechaDoc))
        _listParam.Add(New Datos.DParametro("@vaFechaVenCre", vaFechaVenCre))
        _listParam.Add(New Datos.DParametro("@vaObser", vaObser))
        _listParam.Add(New Datos.DParametro("@vaEst", 1))
        _listParam.Add(New Datos.DParametro("@vaDesc", vaDesc))
        _listParam.Add(New Datos.DParametro("@vaTotal", vaTotal))
        _listParam.Add(New Datos.DParametro("@vaCuenta", vaCuenta))
        _listParam.Add(New Datos.DParametro("@vaEmision", vaEmision))
        _listParam.Add(New Datos.DParametro("@vaTarjeta", vaTarjeta))
        _listParam.Add(New Datos.DParametro("@vaTransferencia", vaTransferencia))
        _listParam.Add(New Datos.DParametro("@vaTurno", vaTurno))
        _listParam.Add(New Datos.DParametro("@VEN0011", "", _VEN001))
        _listParam.Add(New Datos.DParametro("@vausuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("VEN.sp_VEN001", _listParam)
        If _Tabla.Rows.Count > 0 Then
            vaId = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function


    '********Modificar
    Public Shared Function L_fnModificarVenta(ByRef vaId As String, va_rkId As String, va_roId As String, va_rmId As String,
                                              va_pbId As String, va_caId As String, va_ecId As String, vaTipoVe As String,
                                              vaFechaDoc As String, vaFechaVenCre As String, vaObser As String, vaDesc As String,
                                              vaTotal As String, _VEN001 As DataTable, vaAlm As String, vaCuenta As String,
                                              vaEmision As String, vaTarjeta As String, vaTransferencia As String)
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 2))
        _listParam.Add(New Datos.DParametro("@vaId", vaId))
        _listParam.Add(New Datos.DParametro("@va_rkId", va_rkId))
        _listParam.Add(New Datos.DParametro("@va_roId", va_roId))
        _listParam.Add(New Datos.DParametro("@va_rmId", va_rmId))
        _listParam.Add(New Datos.DParametro("@va_pbId", va_pbId))
        _listParam.Add(New Datos.DParametro("@va_caId", va_caId))
        _listParam.Add(New Datos.DParametro("@va_ecId", va_ecId))
        _listParam.Add(New Datos.DParametro("@vaAlm", vaAlm))
        _listParam.Add(New Datos.DParametro("@vaTipoVe", vaTipoVe))
        _listParam.Add(New Datos.DParametro("@vaFechaDoc", vaFechaDoc))
        _listParam.Add(New Datos.DParametro("@vaFechaVenCre", vaFechaVenCre))
        _listParam.Add(New Datos.DParametro("@vaObser", vaObser))
        _listParam.Add(New Datos.DParametro("@vaEst", 1))
        _listParam.Add(New Datos.DParametro("@vaDesc", vaDesc))
        _listParam.Add(New Datos.DParametro("@vaTotal", vaTotal))
        _listParam.Add(New Datos.DParametro("@vaCuenta", vaCuenta))
        _listParam.Add(New Datos.DParametro("@vaEmision", vaEmision))
        _listParam.Add(New Datos.DParametro("@vaTarjeta", vaTarjeta))
        _listParam.Add(New Datos.DParametro("@vaTransferencia", vaTransferencia))
        _listParam.Add(New Datos.DParametro("@VEN0011", "", _VEN001))
        _listParam.Add(New Datos.DParametro("@vausuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("VEN.sp_VEN001", _listParam)
        If _Tabla.Rows.Count > 0 Then
            vaId = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
    '********Eliminar
    Public Shared Function L_fnEliminarVenta(ByRef vaId As String, va_rkId As String, va_roId As String, va_rmId As String, ByRef mensaje As String) As Boolean
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 3))
        _listParam.Add(New Datos.DParametro("@va_rkId", va_rkId))
        _listParam.Add(New Datos.DParametro("@va_roId", va_roId))
        _listParam.Add(New Datos.DParametro("@va_rmId", va_rmId))
        _listParam.Add(New Datos.DParametro("@vaId", vaId))
        _listParam.Add(New Datos.DParametro("@vaUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("VEN.sp_VEN001", _listParam)
        If _Tabla.Rows.Count > 0 Then
            vaId = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
#End Region

#Region "Proforma"

    Public Shared Function L_fnMostrarProforma(mostrar As Integer) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 4))
        _listParam.Add(New Datos.DParametro("@mostrar", mostrar))
        _listParam.Add(New Datos.DParametro("@vausuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("VEN.sp_PROF001", _listParam)
        Return _Tabla
    End Function

    Public Shared Function L_fnMostrarProformaDetalle(vaId As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 5))
        _listParam.Add(New Datos.DParametro("@vaId", vaId))
        _listParam.Add(New Datos.DParametro("@vausuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("VEN.sp_PROF001", _listParam)
        Return _Tabla
    End Function

    Public Shared Function L_fnGrabarProforma(ByRef vaId As String, va_rkId As String, va_roId As String, va_rmId As String,
                                           va_pbId As String, va_caId As String, va_ecId As String, vaTipoVe As String,
                                           vaFechaDoc As String, vaFechaVenCre As String, vaObser As String, vaDesc As String,
                                           vaTotal As String, _VEN001 As DataTable, vaAlm As String, vaCuenta As String,
                                           vaEmision As String, vaTarjeta As String, vaTransferencia As String, vaTurno As Integer)
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@vaId", vaId))
        _listParam.Add(New Datos.DParametro("@va_rkId", va_rkId))
        _listParam.Add(New Datos.DParametro("@va_roId", va_roId))
        _listParam.Add(New Datos.DParametro("@va_rmId", va_rmId))
        _listParam.Add(New Datos.DParametro("@va_pbId", va_pbId))
        _listParam.Add(New Datos.DParametro("@va_caId", va_caId))
        _listParam.Add(New Datos.DParametro("@va_ecId", va_ecId))
        _listParam.Add(New Datos.DParametro("@vaAlm", vaAlm))
        _listParam.Add(New Datos.DParametro("@vaTipoVe", vaTipoVe))
        _listParam.Add(New Datos.DParametro("@vaFechaDoc", vaFechaDoc))
        _listParam.Add(New Datos.DParametro("@vaFechaVenCre", vaFechaVenCre))
        _listParam.Add(New Datos.DParametro("@vaObser", vaObser))
        _listParam.Add(New Datos.DParametro("@vaEst", 1))
        _listParam.Add(New Datos.DParametro("@vaDesc", vaDesc))
        _listParam.Add(New Datos.DParametro("@vaTotal", vaTotal))
        _listParam.Add(New Datos.DParametro("@vaCuenta", vaCuenta))
        _listParam.Add(New Datos.DParametro("@vaEmision", vaEmision))
        _listParam.Add(New Datos.DParametro("@vaTarjeta", vaTarjeta))
        _listParam.Add(New Datos.DParametro("@vaTransferencia", vaTransferencia))
        _listParam.Add(New Datos.DParametro("@vaTurno", vaTurno))
        _listParam.Add(New Datos.DParametro("@VEN0011", "", _VEN001))
        _listParam.Add(New Datos.DParametro("@vausuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("VEN.sp_PROF001", _listParam)
        If _Tabla.Rows.Count > 0 Then
            vaId = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function

    Public Shared Function L_fnModificarProforma(ByRef vaId As String, va_rkId As String, va_roId As String, va_rmId As String,
                                              va_pbId As String, va_caId As String, va_ecId As String, vaTipoVe As String,
                                              vaFechaDoc As String, vaFechaVenCre As String, vaObser As String, vaDesc As String,
                                              vaTotal As String, _VEN001 As DataTable, vaAlm As String, vaCuenta As String,
                                              vaEmision As String, vaTarjeta As String, vaTransferencia As String)
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 2))
        _listParam.Add(New Datos.DParametro("@vaId", vaId))
        _listParam.Add(New Datos.DParametro("@va_rkId", va_rkId))
        _listParam.Add(New Datos.DParametro("@va_roId", va_roId))
        _listParam.Add(New Datos.DParametro("@va_rmId", va_rmId))
        _listParam.Add(New Datos.DParametro("@va_pbId", va_pbId))
        _listParam.Add(New Datos.DParametro("@va_caId", va_caId))
        _listParam.Add(New Datos.DParametro("@va_ecId", va_ecId))
        _listParam.Add(New Datos.DParametro("@vaAlm", vaAlm))
        _listParam.Add(New Datos.DParametro("@vaTipoVe", vaTipoVe))
        _listParam.Add(New Datos.DParametro("@vaFechaDoc", vaFechaDoc))
        _listParam.Add(New Datos.DParametro("@vaFechaVenCre", vaFechaVenCre))
        _listParam.Add(New Datos.DParametro("@vaObser", vaObser))
        _listParam.Add(New Datos.DParametro("@vaEst", 1))
        _listParam.Add(New Datos.DParametro("@vaDesc", vaDesc))
        _listParam.Add(New Datos.DParametro("@vaTotal", vaTotal))
        _listParam.Add(New Datos.DParametro("@vaCuenta", vaCuenta))
        _listParam.Add(New Datos.DParametro("@vaEmision", vaEmision))
        _listParam.Add(New Datos.DParametro("@vaTarjeta", vaTarjeta))
        _listParam.Add(New Datos.DParametro("@vaTransferencia", vaTransferencia))
        _listParam.Add(New Datos.DParametro("@VEN0011", "", _VEN001))
        _listParam.Add(New Datos.DParametro("@vausuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("VEN.sp_PROF001", _listParam)
        If _Tabla.Rows.Count > 0 Then
            vaId = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function

    Public Shared Function L_fnEliminarProforma(ByRef vaId As String, va_rkId As String, va_roId As String, va_rmId As String, ByRef mensaje As String) As Boolean
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 3))
        _listParam.Add(New Datos.DParametro("@va_rkId", va_rkId))
        _listParam.Add(New Datos.DParametro("@va_roId", va_roId))
        _listParam.Add(New Datos.DParametro("@va_rmId", va_rmId))
        _listParam.Add(New Datos.DParametro("@vaId", vaId))
        _listParam.Add(New Datos.DParametro("@vaUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("VEN.sp_PROF001", _listParam)
        If _Tabla.Rows.Count > 0 Then
            vaId = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function

    Public Shared Function L_fnMostrarProformaReporte(vaId As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 9))
        _listParam.Add(New Datos.DParametro("@vaId", vaId))
        _listParam.Add(New Datos.DParametro("@vausuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("VEN.sp_PROF001", _listParam)
        Return _Tabla
    End Function
#End Region

#Region "Consultas"
    Public Shared Function L_fnMostrarVenta(mostrar As Integer) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 4))
        _listParam.Add(New Datos.DParametro("@mostrar", mostrar))
        _listParam.Add(New Datos.DParametro("@vausuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("VEN.sp_VEN001", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_fnMostrarVentaDetalle(vaId As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 5))
        _listParam.Add(New Datos.DParametro("@vaId", vaId))
        _listParam.Add(New Datos.DParametro("@vausuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("VEN.sp_VEN001", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_fnMostrarVentaProducto(_vaAlm As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 6))
        _listParam.Add(New Datos.DParametro("@vaAlm", _vaAlm))
        '_listParam.Add(New Datos.DParametro("@IdProducto", IdPro))
        _listParam.Add(New Datos.DParametro("@vausuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("VEN.sp_VEN001", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_fnMostrarVentaProductoLote(IdPro As String, Suc As Integer) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 7))
        _listParam.Add(New Datos.DParametro("@IdProducto", IdPro))
        _listParam.Add(New Datos.DParametro("@vaAlm", Suc))
        _listParam.Add(New Datos.DParametro("@vausuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("VEN.sp_VEN001", _listParam)
        Return _Tabla
    End Function

    Public Shared Function L_fnMostrarVentaProductoLoteProforma(IdPro As String, Suc As Integer) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 71))
        _listParam.Add(New Datos.DParametro("@IdProducto", IdPro))
        _listParam.Add(New Datos.DParametro("@vaAlm", Suc))
        _listParam.Add(New Datos.DParametro("@vausuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("VEN.sp_VEN001", _listParam)
        Return _Tabla
    End Function

    Public Shared Function L_fnMostrarVentaRecibo() As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 8))
        _listParam.Add(New Datos.DParametro("@vausuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("VEN.sp_VEN001", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_fnMostrarVentaReporte(vaId As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 9))
        _listParam.Add(New Datos.DParametro("@vaId", vaId))
        _listParam.Add(New Datos.DParametro("@vausuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("VEN.sp_VEN001", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_fnMostrarVentaReciboInternacion() As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 10))
        _listParam.Add(New Datos.DParametro("@vausuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("VEN.sp_VEN001", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_fnMostrarVentaReciboCirugia() As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 11))
        _listParam.Add(New Datos.DParametro("@vausuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("VEN.sp_VEN001", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_fnMostrarVentaReciboDet(va_rkId As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 12))
        _listParam.Add(New Datos.DParametro("@va_rkId", va_rkId))
        _listParam.Add(New Datos.DParametro("@vausuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("VEN.sp_VEN001", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_fnMostrarVentaReciboCirugianDet(va_roId As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 13))
        _listParam.Add(New Datos.DParametro("@va_roId", va_roId))
        _listParam.Add(New Datos.DParametro("@vausuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("VEN.sp_VEN001", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_fnMostrarVentaReciboInternacionDet(va_rmId As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 14))
        _listParam.Add(New Datos.DParametro("@va_rmId", va_rmId))
        _listParam.Add(New Datos.DParametro("@vausuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("VEN.sp_VEN001", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_prVentasAtendidas(fechaI As String, fechaF As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@fechaI", fechaI))
        _listParam.Add(New Datos.DParametro("@fechaF", fechaF))
        _listParam.Add(New Datos.DParametro("@uact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_ReporteVentas", _listParam)
        Return _Tabla

    End Function
    Public Shared Function L_prTipoRecibo() As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 11))
        _listParam.Add(New Datos.DParametro("@uact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_ReporteVentas", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_prVentasAtendidasRecibo(fechaI As String, fechaF As String, tipoRecibo As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 2))
        _listParam.Add(New Datos.DParametro("@fechaI", fechaI))
        _listParam.Add(New Datos.DParametro("@fechaF", fechaF))
        _listParam.Add(New Datos.DParametro("@tipoRecibo", tipoRecibo))
        _listParam.Add(New Datos.DParametro("@uact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_ReporteVentas", _listParam)
        Return _Tabla
    End Function

    Public Shared Function L_prVentasAtendidasServicio(fechaI As String, fechaF As String, tipoRecibo As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 5))
        _listParam.Add(New Datos.DParametro("@fechaI", fechaI))
        _listParam.Add(New Datos.DParametro("@fechaF", fechaF))
        _listParam.Add(New Datos.DParametro("@tipoRecibo", tipoRecibo))
        _listParam.Add(New Datos.DParametro("@uact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_ReporteVentas", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_prVentasAtendidasReciboCliente(fechaI As String, fechaF As String, tipoRecibo As String, cliente As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 3))
        _listParam.Add(New Datos.DParametro("@fechaI", fechaI))
        _listParam.Add(New Datos.DParametro("@fechaF", fechaF))
        _listParam.Add(New Datos.DParametro("@tipoRecibo", tipoRecibo))
        _listParam.Add(New Datos.DParametro("@cliente", cliente))
        _listParam.Add(New Datos.DParametro("@uact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_ReporteVentas", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_prVentasAtendidasCliente(fechaI As String, fechaF As String, cliente As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 4))
        _listParam.Add(New Datos.DParametro("@fechaI", fechaI))
        _listParam.Add(New Datos.DParametro("@fechaF", fechaF))
        _listParam.Add(New Datos.DParametro("@cliente", cliente))
        _listParam.Add(New Datos.DParametro("@uact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_ReporteVentas", _listParam)
        Return _Tabla
    End Function
#End Region
#Region "Verificaciones"
    Public Shared Function L_fnExisteEliminarVenta(_fbId As String) As Boolean
        Dim _Tabla As DataTable
        Dim _res As Boolean = False
        Dim _where = String.Format(" ig_FbId = {0} ", _fbId)
        _Tabla = D_Datos_Tabla(" COUNT(*) ", " FIC.INT0025 ", _where)
        Return _res = IIf(_Tabla.Rows(0).Item(0) <> 0, True, False)
    End Function
    Public Shared Function L_fnVerificarCantidadPagoCredito(_vaid As String, _vaCuenta As Decimal, _vaTotal As Decimal) As Boolean
        Dim _Tabla As DataTable
        Dim _res As Boolean = False
        Dim _where = String.Format(" b.tdnumi = (SELECT top 1 (b.tdnumi)  FROM  TV0012 a JOIN TV00121 b on a.tcnumi = b.tdtv12numi WHERE A.tctv1numi = {0}) AND A.tctv1numi = {0} ", _vaid)
        _Tabla = D_Datos_Tabla(" Isnull(Sum(b.tdmonto ),0) ", " TV0012 a JOIN TV00121 b on a.tcnumi = b.tdtv12numi ", _where)
        If _Tabla.Rows(0).Item(0) <> 0 Then
            If _vaTotal <= _vaCuenta Then
                _res = True
                'Dim saldo As Decimal = _vaTotal - _vaCuenta
                'If _vaCuenta > _vaTotal Then
                '    _res = True
                'End If
            End If
        ElseIf _vaCuenta = 0 Then
            _res = False
        End If
        Return _res
    End Function
#End Region
#End Region
#Region "TA001 Almacen"
    Public Shared Function L_fnEliminarAlmacen(numi As String, ByRef mensaje As String) As Boolean
        Dim _resultado As Boolean
        If L_fnbValidarEliminacion(numi, "TA001", "aanumi", mensaje) = True Then
            Dim _Tabla As DataTable
            Dim _listParam As New List(Of Datos.DParametro)

            _listParam.Add(New Datos.DParametro("@tipo", -1))
            _listParam.Add(New Datos.DParametro("@aanumi", numi))
            _listParam.Add(New Datos.DParametro("@aauact", L_Usuario))

            _Tabla = D_ProcedimientoConParam("sp_Mam_TA001", _listParam)

            If _Tabla.Rows.Count > 0 Then
                _resultado = True
            Else
                _resultado = False
            End If
        Else
            _resultado = False
        End If
        Return _resultado
    End Function



    Public Shared Function L_fnGrabarAlmacen(ByRef _abnumi As String, _abdesc As String, _abdir As String, _abtelf As String, _ablat As Double, _ablong As Double, _abimg As String) As Boolean
        Dim _resultado As Boolean

        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        '@aanumi ,@aata2dep,@aadesc ,@aadir ,@aatelf ,@aalat ,@aalong,@aaimg ,@newFecha,@newHora,@aauact

        'a.aanumi ,a.aabdes ,a.aadir ,a.aatel ,a.aalat ,a.aalong ,a.aaimg,aata2dep ,a.aafact ,a.aahact ,a.aauact
        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@aanumi", _abnumi))
        _listParam.Add(New Datos.DParametro("@aadesc", _abdesc))
        _listParam.Add(New Datos.DParametro("@aadir", _abdir))
        _listParam.Add(New Datos.DParametro("@aatelf", _abtelf))
        _listParam.Add(New Datos.DParametro("@aalat", _ablat))
        _listParam.Add(New Datos.DParametro("@aalong", _ablong))
        _listParam.Add(New Datos.DParametro("@aaimg", _abimg))



        _listParam.Add(New Datos.DParametro("@aauact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TA001", _listParam)

        If _Tabla.Rows.Count > 0 Then
            _abnumi = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function

    Public Shared Function L_fnModificarAlmacen(ByRef _abnumi As String, _abdesc As String, _abdir As String, _abtelf As String, _ablat As Double, _ablong As Double, _abimg As String) As Boolean
        Dim _resultado As Boolean

        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 2))
        _listParam.Add(New Datos.DParametro("@aanumi", _abnumi))
        _listParam.Add(New Datos.DParametro("@aadesc", _abdesc))
        _listParam.Add(New Datos.DParametro("@aadir", _abdir))
        _listParam.Add(New Datos.DParametro("@aatelf", _abtelf))
        _listParam.Add(New Datos.DParametro("@aalat", _ablat))
        _listParam.Add(New Datos.DParametro("@aalong", _ablong))
        _listParam.Add(New Datos.DParametro("@aaimg", _abimg))

        _listParam.Add(New Datos.DParametro("@aauact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TA001", _listParam)

        If _Tabla.Rows.Count > 0 Then
            _abnumi = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function

    Public Shared Function L_fnGeneralAlmacen() As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 3))
        _listParam.Add(New Datos.DParametro("@aauact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TA001", _listParam)

        Return _Tabla
    End Function



#End Region

#Region "TY005 PRODUCTOS"
    Public Shared Function L_prLibreriaGrabar(ByRef _numi As String, _cod1 As String, _cod2 As String, _desc1 As String, _desc2 As String) As Boolean
        Dim _Error As Boolean

        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 5))
        _listParam.Add(New Datos.DParametro("@ylcod1", _cod1))
        _listParam.Add(New Datos.DParametro("@ylcod2", _cod2))
        _listParam.Add(New Datos.DParametro("@desc", _desc1))
        _listParam.Add(New Datos.DParametro("@yfuact", L_Usuario))

        _Tabla = D_ProcedimientoConParam("sp_Mam_TY005", _listParam)

        If _Tabla.Rows.Count > 0 Then
            _numi = _Tabla.Rows(0).Item(0)
            _Error = False
        Else
            _Error = True
        End If
        Return Not _Error
    End Function

    Public Shared Function L_fnEliminarProducto(numi As String, ByRef mensaje As String) As Boolean
        Dim _resultado As Boolean
        If L_fnbValidarEliminacionProducto(numi, "TY005", "yfnumi", mensaje) = True Then
            Dim _Tabla As DataTable
            Dim _listParam As New List(Of Datos.DParametro)
            _listParam.Add(New Datos.DParametro("@tipo", -1))
            _listParam.Add(New Datos.DParametro("@yfnumi", numi))
            _listParam.Add(New Datos.DParametro("@yfuact", L_Usuario))
            _Tabla = D_ProcedimientoConParam("sp_Mam_TY005", _listParam)
            If _Tabla.Rows.Count > 0 Then
                _resultado = True
            Else
                _resultado = False
            End If
        Else
            _resultado = False
        End If
        Return _resultado
    End Function

    Public Shared Function L_fnGrabarProducto(ByRef _yfnumi As String, _yfcprod As String,
                                              _yfcbarra As String, _yfcdprod1 As String,
                                              _yfcdprod2 As String, _yfgr1 As Integer, _yfgr2 As Integer,
                                              _yfgr3 As Integer, _yfgr4 As Integer, _yfMed As Integer, _yfumin As Integer, _yfusup As Integer, _yfvsup As Double, _yfsmin As Integer, _yfap As Integer, _yfimg As String
                                              ) As Boolean
        Dim _resultado As Boolean
        '@yfnumi ,@yfcprod ,@yfcbarra ,@yfcdprod1 ,@yfcdprod2 ,
        '			@yfgr1 ,@yfgr2 ,@yfgr3 ,@yfgr4 ,@yfMed ,@yfumin ,@yfusup ,@yfvsup ,
        '			@yfmstk ,@yfclot ,@yfsmin ,@yfap ,@yfimg ,@newFecha,@newHora,@yfuact
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@yfnumi", _yfnumi))
        _listParam.Add(New Datos.DParametro("@yfcprod", _yfcprod))
        _listParam.Add(New Datos.DParametro("@yfcbarra", _yfcbarra))
        _listParam.Add(New Datos.DParametro("@yfcdprod1", _yfcdprod1))
        _listParam.Add(New Datos.DParametro("@yfcdprod2", _yfcdprod2))
        _listParam.Add(New Datos.DParametro("@yfgr1", _yfgr1))
        _listParam.Add(New Datos.DParametro("@yfgr2", _yfgr2))
        _listParam.Add(New Datos.DParametro("@yfgr3", _yfgr3))
        _listParam.Add(New Datos.DParametro("@yfgr4", _yfgr4))
        _listParam.Add(New Datos.DParametro("@yfMed", _yfMed))
        _listParam.Add(New Datos.DParametro("@yfumin", _yfumin))
        _listParam.Add(New Datos.DParametro("@yfusup", _yfusup))
        _listParam.Add(New Datos.DParametro("@yfvsup", _yfvsup))
        _listParam.Add(New Datos.DParametro("@yfmstk", 0))
        _listParam.Add(New Datos.DParametro("@yfclot", 0))

        _listParam.Add(New Datos.DParametro("@yfsmin", _yfsmin))
        _listParam.Add(New Datos.DParametro("@yfap", _yfap))
        _listParam.Add(New Datos.DParametro("@yfimg", _yfimg))
        _listParam.Add(New Datos.DParametro("@yfuact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TY005", _listParam)

        If _Tabla.Rows.Count > 0 Then
            _yfnumi = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function

    Public Shared Function L_fnModificarProducto(ByRef _yfnumi As String, _yfcprod As String,
                                              _yfcbarra As String, _yfcdprod1 As String,
                                              _yfcdprod2 As String, _yfgr1 As Integer, _yfgr2 As Integer,
                                              _yfgr3 As Integer, _yfgr4 As Integer, _yfMed As Integer, _yfumin As Integer, _yfusup As Integer, _yfvsup As Double, _yfsmin As Integer, _yfap As Integer, _yfimg As String
                                              ) As Boolean
        Dim _resultado As Boolean

        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 2))
        _listParam.Add(New Datos.DParametro("@yfnumi", _yfnumi))
        _listParam.Add(New Datos.DParametro("@yfcprod", _yfcprod))

        _listParam.Add(New Datos.DParametro("@yfcbarra", _yfcbarra))
        _listParam.Add(New Datos.DParametro("@yfcdprod1", _yfcdprod1))
        _listParam.Add(New Datos.DParametro("@yfcdprod2", _yfcdprod2))
        _listParam.Add(New Datos.DParametro("@yfgr1", _yfgr1))
        _listParam.Add(New Datos.DParametro("@yfgr2", _yfgr2))
        _listParam.Add(New Datos.DParametro("@yfgr3", _yfgr3))
        _listParam.Add(New Datos.DParametro("@yfgr4", _yfgr4))
        _listParam.Add(New Datos.DParametro("@yfMed", _yfMed))
        _listParam.Add(New Datos.DParametro("@yfumin", _yfumin))
        _listParam.Add(New Datos.DParametro("@yfusup", _yfusup))
        _listParam.Add(New Datos.DParametro("@yfvsup", _yfvsup))
        _listParam.Add(New Datos.DParametro("@yfmstk", 0))
        _listParam.Add(New Datos.DParametro("@yfclot", 0))

        _listParam.Add(New Datos.DParametro("@yfsmin", _yfsmin))
        _listParam.Add(New Datos.DParametro("@yfap", _yfap))
        _listParam.Add(New Datos.DParametro("@yfimg", _yfimg))
        _listParam.Add(New Datos.DParametro("@yfuact", L_Usuario))

        _Tabla = D_ProcedimientoConParam("sp_Mam_TY005", _listParam)

        If _Tabla.Rows.Count > 0 Then
            _yfnumi = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function

    Public Shared Function L_fnGeneralProductos() As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 3))
        _listParam.Add(New Datos.DParametro("@yfuact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TY005", _listParam)

        Return _Tabla
    End Function

    Public Shared Function L_fnCodigoBarra() As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 12))
        _listParam.Add(New Datos.DParametro("@yfuact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TY005", _listParam)

        Return _Tabla
    End Function

    Public Shared Function L_fnNameLabel() As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 6))
        _listParam.Add(New Datos.DParametro("@yfuact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TY005", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnNameReporte() As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 61))
        _listParam.Add(New Datos.DParametro("@yfuact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TY005", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_prLibreriaClienteLGeneral(cod1 As Integer, cod2 As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 4))
        _listParam.Add(New Datos.DParametro("@ylcod1", cod1))
        _listParam.Add(New Datos.DParametro("@ylcod2", cod2))
        _listParam.Add(New Datos.DParametro("@yfuact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TY005", _listParam)

        Return _Tabla
    End Function





#End Region

#Region "Precio"

    Public Shared Function L_fnListarProductosConPrecios(_almacen As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 5))
        _listParam.Add(New Datos.DParametro("@almacen", _almacen))
        _listParam.Add(New Datos.DParametro("@yguact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TY006", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnListarProductos() As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 6))
        _listParam.Add(New Datos.DParametro("@yguact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TY006", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnListarCategorias() As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 7))
        _listParam.Add(New Datos.DParametro("@yguact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TY006", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnGeneralCategorias() As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 3))
        _listParam.Add(New Datos.DParametro("@yguact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TY006", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnGrabarCategorias(_ygnumi As String, cod As String, desc As String, tipo As Integer, margen As Decimal) As Boolean
        Dim _Tabla As DataTable
        Dim _resultado As Boolean
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@ygcod", cod))
        _listParam.Add(New Datos.DParametro("@ygdesc", desc))
        _listParam.Add(New Datos.DParametro("@ygpcv", tipo))
        _listParam.Add(New Datos.DParametro("@ygmer", margen))
        _listParam.Add(New Datos.DParametro("@yguact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TY006", _listParam)


        If _Tabla.Rows.Count > 0 Then
            _ygnumi = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function

    Public Shared Function L_fnGrabarPrecios(_ygnumi As String, _almacen As Integer, _precio As DataTable) As Boolean
        Dim _Tabla As DataTable
        Dim _resultado As Boolean
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 2))
        _listParam.Add(New Datos.DParametro("@almacen", _almacen))
        _listParam.Add(New Datos.DParametro("@TY007", "", _precio))
        _listParam.Add(New Datos.DParametro("@yguact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TY006", _listParam)


        If _Tabla.Rows.Count > 0 Then
            _ygnumi = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function

    Public Shared Function L_fnGeneralSucursales() As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 4))
        _listParam.Add(New Datos.DParametro("@yguact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TY006", _listParam)

        Return _Tabla
    End Function
#End Region

#Region "Movimientos"

    Public Shared Function L_prMovimientoEliminar(numi As String) As Boolean
        Dim _resultado As Boolean

        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", -1))
        _listParam.Add(New Datos.DParametro("@ibid", numi))
        _listParam.Add(New Datos.DParametro("@ibuact", L_Usuario))

        _Tabla = D_ProcedimientoConParam("sp_Mam_TI002", _listParam)

        If _Tabla.Rows.Count > 0 Then
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function
    Public Shared Function L_prMovimientoModificar(ByRef _ibid As String, _ibfdoc As String, _ibconcep As Integer, _ibobs As String, _almacen As Integer) As Boolean
        Dim _resultado As Boolean

        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 2))
        _listParam.Add(New Datos.DParametro("@ibid", _ibid))
        _listParam.Add(New Datos.DParametro("@ibfdoc", _ibfdoc))
        _listParam.Add(New Datos.DParametro("@ibconcep", _ibconcep))
        _listParam.Add(New Datos.DParametro("@ibobs", _ibobs))
        _listParam.Add(New Datos.DParametro("@ibest", 1))
        _listParam.Add(New Datos.DParametro("@ibalm", _almacen))
        _listParam.Add(New Datos.DParametro("@ibiddc", 0))

        _listParam.Add(New Datos.DParametro("@ibuact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TI002", _listParam)

        If _Tabla.Rows.Count > 0 Then
            _ibid = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function
    Public Shared Function L_prMovimientoChoferGrabar(ByRef _ibid As String, _ibfdoc As String, _ibconcep As Integer, _ibobs As String, _almacen As Integer, _depositoDestino As Integer, _ibidOrigen As Integer) As Boolean
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@ibid", _ibid))
        _listParam.Add(New Datos.DParametro("@ibfdoc", _ibfdoc))
        _listParam.Add(New Datos.DParametro("@ibconcep", _ibconcep))
        _listParam.Add(New Datos.DParametro("@ibobs", _ibobs))
        _listParam.Add(New Datos.DParametro("@ibest", 1))
        _listParam.Add(New Datos.DParametro("@ibalm", _almacen))
        _listParam.Add(New Datos.DParametro("@ibdepdest", _depositoDestino))
        _listParam.Add(New Datos.DParametro("@ibiddc", 0))
        _listParam.Add(New Datos.DParametro("@ibidOrigen", _ibidOrigen))
        _listParam.Add(New Datos.DParametro("@ibuact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TI002", _listParam)
        If _Tabla.Rows.Count > 0 Then
            _ibid = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function
    Public Shared Function L_prMovimientoChoferABMDetalle(numi As String, Type As Integer, detalle As DataTable) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", Type))
        _listParam.Add(New Datos.DParametro("@ibid", numi))
        _listParam.Add(New Datos.DParametro("@ibuact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@TI0021", "", detalle))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TI002", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnListarProductosKardex(_almacen As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 8))
        _listParam.Add(New Datos.DParametro("@ibuact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@almacen", _almacen))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TI002", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnListarLotesProductos(codproducto As Integer, _almacen As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 28))
        _listParam.Add(New Datos.DParametro("@ibuact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@producto", codproducto))
        _listParam.Add(New Datos.DParametro("@almacen", _almacen))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TI002", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnObtenerSaldoProducto(_almacen As Integer, _codProducto As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 23))
        _listParam.Add(New Datos.DParametro("@ibuact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@almacen", _almacen))
        _listParam.Add(New Datos.DParametro("@producto", _codProducto))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TI002", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnActualizarSaldo(_Almacen As Integer, _CodProducto As String, _Cantidad As Double) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 21))
        _listParam.Add(New Datos.DParametro("@ibuact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@producto", _CodProducto))
        _listParam.Add(New Datos.DParametro("@almacen", _Almacen))
        _listParam.Add(New Datos.DParametro("@cantidad", _Cantidad))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TI002", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnObtenerHistorialProductoporLote(_codProducto As Integer, FechaI As String, FechaF As String, _almacen As Integer, _Lote As String, _FechaVenc As String) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 30))
        _listParam.Add(New Datos.DParametro("@ibuact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@producto", _codProducto))
        _listParam.Add(New Datos.DParametro("@fechaI", FechaI))
        _listParam.Add(New Datos.DParametro("@fechaF", FechaF))
        _listParam.Add(New Datos.DParametro("@almacen", _almacen))
        _listParam.Add(New Datos.DParametro("@lote", _Lote))
        _listParam.Add(New Datos.DParametro("@fechaVenc", _FechaVenc))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TI002", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnObtenerHistorialProductoGeneralPorLote(_codProducto As Integer, FechaI As String, _almacen As Integer, _Lote As String, FechaVenc As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 29))
        _listParam.Add(New Datos.DParametro("@ibuact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@producto", _codProducto))
        _listParam.Add(New Datos.DParametro("@fechaI", FechaI))
        _listParam.Add(New Datos.DParametro("@almacen", _almacen))
        _listParam.Add(New Datos.DParametro("@lote", _Lote))
        _listParam.Add(New Datos.DParametro("@fechaVenc", FechaVenc))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TI002", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnObtenerHistorialProducto(_codProducto As Integer, FechaI As String, FechaF As String, _almacen As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 9))
        _listParam.Add(New Datos.DParametro("@ibuact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@producto", _codProducto))
        _listParam.Add(New Datos.DParametro("@fechaI", FechaI))
        _listParam.Add(New Datos.DParametro("@fechaF", FechaF))
        _listParam.Add(New Datos.DParametro("@almacen", _almacen))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TI002", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnObtenerHistorialProductoGeneral(_codProducto As Integer, FechaI As String, _almacen As Integer) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 20))
        _listParam.Add(New Datos.DParametro("@ibuact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@producto", _codProducto))
        _listParam.Add(New Datos.DParametro("@fechaI", FechaI))
        _listParam.Add(New Datos.DParametro("@almacen", _almacen))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TI002", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnListarLotesPorProductoMovimiento(_almacen As Integer, _codproducto As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 32))
        _listParam.Add(New Datos.DParametro("@almacen", _almacen))
        _listParam.Add(New Datos.DParametro("@producto", _codproducto))
        _listParam.Add(New Datos.DParametro("ibuact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TI002", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_prMovimientoListarProductos(dt As DataTable, _deposito As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 5))
        _listParam.Add(New Datos.DParametro("@ibuact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@almacen", _deposito))
        _listParam.Add(New Datos.DParametro("@TI0021", "", dt))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TI002", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_prMovimientoListarProductosConLote(_deposito As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 31))
        _listParam.Add(New Datos.DParametro("@ibuact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@almacen", _deposito))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TI002", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnGeneralMovimiento() As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 3))
        _listParam.Add(New Datos.DParametro("@ibuact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TI002", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnDetalleMovimiento(_ibid As String) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 4))
        _listParam.Add(New Datos.DParametro("@ibid", _ibid))
        _listParam.Add(New Datos.DParametro("@ibuact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TI002", _listParam)

        Return _Tabla
    End Function

    Public Shared Function L_prMovimientoConcepto() As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 7))
        _listParam.Add(New Datos.DParametro("@ibuact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TI002", _listParam)

        Return _Tabla
    End Function


#End Region

#Region "Reporte Movimientoss"

    Public Shared Function L_fnUnaAlmacenUnaLineasMayorCero(numiLinea As Integer, CodAlmacen As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 8))
        _listParam.Add(New Datos.DParametro("@yduact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@linea", numiLinea))
        _listParam.Add(New Datos.DParametro("@almacen", CodAlmacen))
        _Tabla = D_ProcedimientoConParam("sp_Mam_SaldosProducto", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnObtenerGruposLibreria() As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@yduact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_SaldosProducto", _listParam)

        Return _Tabla
    End Function


    Public Shared Function L_fnUnaAlmacenUnaLineas(numiLinea As Integer, CodAlmacen As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 5))
        _listParam.Add(New Datos.DParametro("@yduact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@linea", numiLinea))
        _listParam.Add(New Datos.DParametro("@almacen", CodAlmacen))
        _Tabla = D_ProcedimientoConParam("sp_Mam_SaldosProducto", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnTodosAlmacenUnaLineas(numiLinea As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 4))
        _listParam.Add(New Datos.DParametro("@yduact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@linea", numiLinea))
        _Tabla = D_ProcedimientoConParam("sp_Mam_SaldosProducto", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnUnaAlmacenTodosLineasMayorCero(numialmacen As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 7))
        _listParam.Add(New Datos.DParametro("@yduact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@almacen", numialmacen))
        _Tabla = D_ProcedimientoConParam("sp_Mam_SaldosProducto", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_prReporteUtilidad(_codAlmacen As Integer, _codCat As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 9))
        _listParam.Add(New Datos.DParametro("@yduact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@almacen", _codAlmacen))
        _listParam.Add(New Datos.DParametro("@catPrecio", _codCat))
        _Tabla = D_ProcedimientoConParam("sp_Mam_VentasCredito", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_prListarPrecioVenta() As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 7))
        _listParam.Add(New Datos.DParametro("@yduact", L_Usuario))

        _Tabla = D_ProcedimientoConParam("sp_Mam_VentasCredito", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_prReporteUtilidadStockMayorCero(_codAlmacen As Integer, _codCat As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 13))
        _listParam.Add(New Datos.DParametro("@yduact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@almacen", _codAlmacen))
        _listParam.Add(New Datos.DParametro("@catPrecio", _codCat))
        _Tabla = D_ProcedimientoConParam("sp_Mam_VentasCredito", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnObtenerKardexPorProducto(_codProducto As Integer, FechaI As String, FechaF As String, _almacen As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 25))
        _listParam.Add(New Datos.DParametro("@ibuact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@producto", _codProducto))
        _listParam.Add(New Datos.DParametro("@fechaI", FechaI))
        _listParam.Add(New Datos.DParametro("@fechaF", FechaF))
        _listParam.Add(New Datos.DParametro("@almacen", _almacen))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TI002", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnObtenerProductoConMovimiento(FechaI As String, FechaF As String, _almacen As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 26))
        _listParam.Add(New Datos.DParametro("@ibuact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@fechaI", FechaI))
        _listParam.Add(New Datos.DParametro("@fechaF", FechaF))
        _listParam.Add(New Datos.DParametro("@almacen", _almacen))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TI002", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnObtenerKardexGeneralProductosporLote(FechaI As String, FechaF As String, _almacen As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 33))
        _listParam.Add(New Datos.DParametro("@ibuact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@fechaI", FechaI))
        _listParam.Add(New Datos.DParametro("@fechaF", FechaF))
        _listParam.Add(New Datos.DParametro("@almacen", _almacen))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TI002", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnObtenerKardexGeneralProductos(FechaI As String, FechaF As String, _almacen As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 27))
        _listParam.Add(New Datos.DParametro("@ibuact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@fechaI", FechaI))
        _listParam.Add(New Datos.DParametro("@fechaF", FechaF))
        _listParam.Add(New Datos.DParametro("@almacen", _almacen))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TI002", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_prListarPrecioCosto() As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 12))
        _listParam.Add(New Datos.DParametro("@yduact", L_Usuario))

        _Tabla = D_ProcedimientoConParam("sp_Mam_SaldosProducto", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnUnaAlmacenTodosLineas(numialmacen As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 3))
        _listParam.Add(New Datos.DParametro("@yduact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@almacen", numialmacen))
        _Tabla = D_ProcedimientoConParam("sp_Mam_SaldosProducto", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnTodosAlmacenTodosLineas() As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 2))
        _listParam.Add(New Datos.DParametro("@yduact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_SaldosProducto", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnTodosAlmacenTodosLineasMayorCero() As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 6))
        _listParam.Add(New Datos.DParametro("@yduact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_SaldosProducto", _listParam)

        Return _Tabla
    End Function

    'Buscar Stock por lote segun un criterio de busqueda
    Public Shared Function L_fnBuscarStockLote(_valor1 As String, _laboratorio As Boolean, _valor2 As String, _fechaVenc As Boolean) As DataTable
        Dim _Tabla As DataTable
        Dim sb As New StringBuilder
        sb.Append("DECLARE @FechaActual datetime = GETDATE()
			           SELECT
				            alm.aanumi,
							alm.aabdes,
				            a.yfnumi,
				            a.yfcprod,
				            a.yfcdprod1,
				            a.yfMed,
				            a.yfap,
				            c.iccprod,
				            c.iclot,
				            FORMAT(c.icfven, 'yyyy-MM-dd')as icfven,
				            c.iccven as iccven,
				            b.yccod3,
				            b.ycdes3,
				            Presentacion.ycdes3 as presentacion
			            FROM
				            dbo.TY005  AS a 
				            INNER JOIN dbo.TI001 AS c ON a.yfnumi  = c.iccprod 
				            INNER JOIN dbo.TY0031 AS b ON a.yfMed  = b.yccod3 		
							INNER JOIN TA001 alm ON alm.aanumi = c.icalm	          
				            inner join TY0031 AS Presentacion ON Presentacion.yccod1 = 1 
				            AND Presentacion.yccod2 = 4 
				            AND Presentacion.yccod3 = a.yfgr4 
				            AND c.iccven >0
			            WHERE        
				            (b.yccod1  = 1) AND (b.yccod2  = 5) AND   ")
        If _laboratorio = False Then
            sb.Append(String.Format(" Presentacion.yccod3 = {0} AND   ", _valor1))
        End If
        If _fechaVenc = False Then
            sb.Append(String.Format(" c.icfven BETWEEN @FechaActual AND DATEADD(day, {0}, @FechaActual) AND   ", _valor2))
        End If
        sb.Length = sb.Length - 7
        sb.Append(" GROUP BY alm.aanumi, alm.aabdes, a.yfnumi , a.yfcprod  , a.yfcdprod1 , a.yfMed, a.yfap , c.iccprod ,b.yccod3 ,
					b.ycdes3 ,c.iclot ,c.icfven ,c.iccven ,Presentacion .ycdes3 
                    ORDER BY alm.aabdes ASC")
        _Tabla = D_Datos_EjecutarConulta(sb.ToString())
        Return _Tabla
    End Function
#End Region

#Region "Proveedor"
    Public Shared Function L_fnGrabarCLiente(ByRef _ydnumi As String,
                                             _ydcod As String, _ydrazonsocial As String, _yddesc As String,
                                             _ydnumiVendedor As Integer, _ydzona As Integer, _yddct As Integer,
                                             _yddctnum As String, _yddirec As String, _ydtelf1 As String,
                                             _ydtelf2 As String, _ydcat As Integer, _ydest As Integer,
                                             _ydlat As Double, _ydlongi As Double, _ydobs As String,
                                             _ydfnac As String, _ydnomfac As String, _ydtip As Integer,
                                             _ydnit As String, _yddias As String, _ydlcred As String,
                                             _ydfecing As String, _ydultvent As String, _ydimg As String, _ydrut As String, _ydciudad As Integer, _ydprovincia As Integer, _ydalmacen As Integer) As Boolean
        Dim _resultado As Boolean

        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        ' @ydnumi ,@ydcod  ,@yddesc  ,@ydzona  ,@yddct  ,
        '@yddctnum  ,@yddirec  ,@ydtelf1  ,@ydtelf2  ,@ydcat  ,@ydest  ,@ydlat  ,@ydlongi  ,
        '@ydprconsu  ,@ydobs  ,@ydfnac  ,@ydnomfac  ,@ydtip,@ydnit ,@ydfecing ,@ydultvent,@ydimg ,@newFecha,@newHora,@yduact
        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@ydnumi", _ydnumi))
        '_listParam.Add(New Datos.DParametro("@ydcod", _ydcod))
        _listParam.Add(New Datos.DParametro("@ydrazonsocioal", _ydrazonsocial))
        _listParam.Add(New Datos.DParametro("@yddesc", _yddesc))
        _listParam.Add(New Datos.DParametro("@ydnumivend", _ydnumiVendedor))
        _listParam.Add(New Datos.DParametro("@ydzona", _ydzona))
        _listParam.Add(New Datos.DParametro("@yddct", _yddct))
        _listParam.Add(New Datos.DParametro("@yddctnum", _yddctnum))
        _listParam.Add(New Datos.DParametro("@yddirec", _yddirec))
        _listParam.Add(New Datos.DParametro("@ydtelf1", _ydtelf1))
        _listParam.Add(New Datos.DParametro("@ydtelf2", _ydtelf2))
        _listParam.Add(New Datos.DParametro("@ydcat", _ydcat))
        _listParam.Add(New Datos.DParametro("@ydest", _ydest))
        _listParam.Add(New Datos.DParametro("@ydlat", _ydlat))
        _listParam.Add(New Datos.DParametro("@ydlongi", _ydlongi))
        _listParam.Add(New Datos.DParametro("@ydprconsu", 0))
        _listParam.Add(New Datos.DParametro("@ydobs", _ydobs))
        _listParam.Add(New Datos.DParametro("@ydfnac", _ydfnac))
        _listParam.Add(New Datos.DParametro("@ydnomfac", _ydnomfac))
        _listParam.Add(New Datos.DParametro("@ydtip", _ydtip))
        _listParam.Add(New Datos.DParametro("@ydnit", _ydnit))
        _listParam.Add(New Datos.DParametro("@yddias", _yddias))
        _listParam.Add(New Datos.DParametro("@ydlcred", _ydlcred))
        _listParam.Add(New Datos.DParametro("@ydfecing", _ydfecing))
        _listParam.Add(New Datos.DParametro("@ydultvent", _ydultvent))
        _listParam.Add(New Datos.DParametro("@ydprovincia", _ydprovincia))
        _listParam.Add(New Datos.DParametro("@ydciudad", _ydciudad))
        _listParam.Add(New Datos.DParametro("@ydalmacen", _ydalmacen))
        _listParam.Add(New Datos.DParametro("@ydrut", _ydrut))
        _listParam.Add(New Datos.DParametro("@yduact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TY004", _listParam)

        If _Tabla.Rows.Count > 0 Then
            _ydnumi = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function
    Public Shared Function L_fnEliminarProveedor(numi As String, ByRef mensaje As String) As Boolean
        Dim _resultado As Boolean
        If L_fnbValidarEliminacion(numi, "TY004", "ydnumi", mensaje) = True Then
            Dim _Tabla As DataTable
            Dim _listParam As New List(Of Datos.DParametro)

            _listParam.Add(New Datos.DParametro("@tipo", -1))
            _listParam.Add(New Datos.DParametro("@ydnumi", numi))
            _listParam.Add(New Datos.DParametro("@yduact", L_Usuario))

            _Tabla = D_ProcedimientoConParam("sp_Mam_TY004", _listParam)

            If _Tabla.Rows.Count > 0 Then
                _resultado = True
            Else
                _resultado = False
            End If
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
#End Region

#Region "TC001 Compras"

    Public Shared Function L_fnGeneralCompras() As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 3))
        _listParam.Add(New Datos.DParametro("@cauact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TC001", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnDetalleCompra(_numi As String) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 4))
        _listParam.Add(New Datos.DParametro("@canumi", _numi))
        _listParam.Add(New Datos.DParametro("@cauact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TC001", _listParam)

        Return _Tabla
    End Function

    Public Shared Function L_fnListarProductosCompra(_almacen As String, _catCosto As String, detalle As DataTable) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 5))
        _listParam.Add(New Datos.DParametro("@almacen", _almacen))
        _listParam.Add(New Datos.DParametro("@CatCosto", _catCosto))
        _listParam.Add(New Datos.DParametro("@cauact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@TC0011", "", detalle))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TC001", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnListarProveedores() As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 6))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TC001", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnListarSucursales() As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 7))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TC001", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnListarDepositos() As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 24))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TI002", _listParam)

        Return _Tabla
    End Function

    Public Shared Function L_fnPorcUtilidad() As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 8))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TC001", _listParam)

        Return _Tabla
    End Function

    Public Shared Function L_fnGrabarCompra(_canumi As String, _caalm As Integer, _cafdoc As String, _caTy4prov As Integer, _catven As Integer, _cafvcr As String,
                                           _camon As Integer, _caobs As String,
                                           _cadesc As Double, _catotal As Double, detalle As DataTable) As Boolean
        Dim _Tabla As DataTable
        Dim _resultado As Boolean
        Dim _listParam As New List(Of Datos.DParametro)
        '   @canumi ,@caalm,@cafdoc ,@caty4prov  ,@catven,
        '@cafvcr,@camon ,@caest  ,@caobs ,@cadesc ,@newFecha,@newHora,@cauact
        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@canumi", _canumi))
        _listParam.Add(New Datos.DParametro("@caalm", _caalm))
        _listParam.Add(New Datos.DParametro("@cafdoc", _cafdoc))
        _listParam.Add(New Datos.DParametro("@caty4prov", _caTy4prov))
        _listParam.Add(New Datos.DParametro("@catven", _catven))
        _listParam.Add(New Datos.DParametro("@cafvcr", _cafvcr))
        _listParam.Add(New Datos.DParametro("@camon", _camon))
        _listParam.Add(New Datos.DParametro("@caest", 1))
        _listParam.Add(New Datos.DParametro("@caobs", _caobs))
        _listParam.Add(New Datos.DParametro("@cadesc", _cadesc))
        _listParam.Add(New Datos.DParametro("@catotal", _catotal))
        _listParam.Add(New Datos.DParametro("@cauact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@TC0011", "", detalle))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TC001", _listParam)


        If _Tabla.Rows.Count > 0 Then
            _canumi = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function

    Public Shared Function L_fnModificarCompra(_canumi As String, _caalm As Integer, _cafdoc As String, _caTy4prov As Integer, _catven As Integer, _cafvcr As String,
                                           _camon As Integer, _caobs As String,
                                           _cadesc As Double, _catotal As Double, detalle As DataTable) As Boolean
        Dim _Tabla As DataTable
        Dim _resultado As Boolean
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 2))
        _listParam.Add(New Datos.DParametro("@canumi", _canumi))
        _listParam.Add(New Datos.DParametro("@caalm", _caalm))
        _listParam.Add(New Datos.DParametro("@cafdoc", _cafdoc))
        _listParam.Add(New Datos.DParametro("@caty4prov", _caTy4prov))
        _listParam.Add(New Datos.DParametro("@catven", _catven))
        _listParam.Add(New Datos.DParametro("@cafvcr", _cafvcr))
        _listParam.Add(New Datos.DParametro("@camon", _camon))
        _listParam.Add(New Datos.DParametro("@caest", 1))
        _listParam.Add(New Datos.DParametro("@caobs", _caobs))
        _listParam.Add(New Datos.DParametro("@cadesc", _cadesc))
        _listParam.Add(New Datos.DParametro("@catotal", _catotal))
        _listParam.Add(New Datos.DParametro("@cauact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@TC0011", "", detalle))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TC001", _listParam)

        If _Tabla.Rows.Count > 0 Then
            _canumi = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function

    Public Shared Function L_fnEliminarCompra(numi As String, ByRef mensaje As String) As Boolean

        Dim _resultado As Boolean

        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", -1))
        _listParam.Add(New Datos.DParametro("@canumi", numi))
        _listParam.Add(New Datos.DParametro("@cauact", L_Usuario))

        _Tabla = D_ProcedimientoConParam("sp_Mam_TC001", _listParam)

        If _Tabla.Rows.Count > 0 Then
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function
    Public Shared Function L_fnVerificarPagosCompras(numi As String) As Boolean
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 9))
        _listParam.Add(New Datos.DParametro("@canumi", numi))
        _listParam.Add(New Datos.DParametro("@cauact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TC001", _listParam)

        If _Tabla.Rows.Count > 0 Then
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function

    Public Shared Function L_fnEliminarCategoria(numi As String, ByRef mensaje As String) As Boolean
        Dim _resultado As Boolean

        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", -1))
        _listParam.Add(New Datos.DParametro("@ygnumi", numi))
        _listParam.Add(New Datos.DParametro("@yguact", L_Usuario))

        _Tabla = D_ProcedimientoConParam("sp_Mam_TY006", _listParam)

        If _Tabla.Rows.Count > 0 Then
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function
#End Region

#Region "Credito"
    Public Shared Function L_fnListarClientesUno(_cliente As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 5))
        _listParam.Add(New Datos.DParametro("@causuario", L_Usuario))
        _listParam.Add(New Datos.DParametro("@caid", _cliente))
        _Tabla = D_ProcedimientoConParam("REG.sp_CLI001", _listParam)
        '_Tabla = D_Procedimiento("sp_Mostrar")
        Return _Tabla
    End Function
    Public Shared Function L_fnGrabarCobranza2(_tenumi As String, _tefdoc As String, _tety4vend As Integer, _teobs As String, detalle As DataTable, teturno As Integer,
                                               _Sucursal As Integer) As Boolean
        Dim _Tabla As DataTable
        Dim _resultado As Boolean
        Dim _listParam As New List(Of Datos.DParametro)
        '   @canumi ,@caalm,@cafdoc ,@caty4prov  ,@catven,
        '@cafvcr,@camon ,@caest  ,@caobs ,@cadesc ,@newFecha,@newHora,@cauact
        _listParam.Add(New Datos.DParametro("@tipo", 10))
        _listParam.Add(New Datos.DParametro("@tenumi", _tenumi))
        _listParam.Add(New Datos.DParametro("@tefdoc", _tefdoc))
        _listParam.Add(New Datos.DParametro("@tety4vend", _tety4vend))
        _listParam.Add(New Datos.DParametro("@teobs", _teobs))
        _listParam.Add(New Datos.DParametro("@teTurno", teturno))
        _listParam.Add(New Datos.DParametro("@teSucursal", _Sucursal))
        _listParam.Add(New Datos.DParametro("@teuact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@TV00121", "", detalle))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TV00121Cheque", _listParam)
        If _Tabla.Rows.Count > 0 Then
            _tenumi = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
    Public Shared Function L_fnCobranzasObtenerLosPagos(_numi As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 7))
        _listParam.Add(New Datos.DParametro("@teuact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@tdnumi", _numi))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TV00121Cheque", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnObtenerLasVentasCreditoPorCliente(_numi As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 9))
        '_listParam.Add(New Datos.DParametro("@tduact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@tenumi", _numi))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TV00121Cheque", _listParam)

        Return _Tabla
    End Function

    Public Shared Function L_fnReporteMorosidadTodosAlmacenVendedor(_fechai As String, _fechaf As String) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 10))
        _listParam.Add(New Datos.DParametro("@fechaI", _fechai))
        _listParam.Add(New Datos.DParametro("@fechaF", _fechaf))
        _Tabla = D_ProcedimientoConParam("sp_Mam_VentasCredito", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnCobranzaRecibo(_numi As Integer, IdVenta As DataTable) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 11))
        _listParam.Add(New Datos.DParametro("@teuact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@tenumi", _numi))
        _listParam.Add(New Datos.DParametro("@TV0012", "", IdVenta))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TV00121Cheque", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_fnObtenerEncabezadoPago(_numi As Integer) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 12))
        _listParam.Add(New Datos.DParametro("@teuact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@tenumi", _numi))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TV00121Cheque", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_fnVerificarPagosVentas(numi As String) As Boolean
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 13))
        _listParam.Add(New Datos.DParametro("@tenumi", numi))
        _listParam.Add(New Datos.DParametro("@teuact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TV00121Cheque", _listParam)

        If _Tabla.Rows.Count > 0 Then
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function

    Public Shared Function L_fnObtenerLosPagos(_numi As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 4))
        _listParam.Add(New Datos.DParametro("@tduact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@credito", _numi))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TV00121", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnCobranzasObtenerLasVentasACredito(_Sucursal As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 6))
        _listParam.Add(New Datos.DParametro("@teSucursal", _Sucursal))
        _listParam.Add(New Datos.DParametro("@teuact", L_Usuario))

        _Tabla = D_ProcedimientoConParam("sp_Mam_TV00121Cheque", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnCobranzasDetalle(_numi As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 4))
        _listParam.Add(New Datos.DParametro("@teuact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@tenumi", _numi))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TV00121Cheque", _listParam)

        Return _Tabla
    End Function

    Public Shared Function L_prReporteCreditoClienteTodosCuentas(fechaI As String, fechaF As String, _numiCliente As String) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 3))
        _listParam.Add(New Datos.DParametro("@fechaI", fechaI))
        _listParam.Add(New Datos.DParametro("@fechaF", fechaF))
        _listParam.Add(New Datos.DParametro("@yduact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@cliente", _numiCliente))
        _Tabla = D_ProcedimientoConParam("sp_Mam_VentasCredito", _listParam)

        Return _Tabla
    End Function

    Public Shared Function L_prReporteCreditoListarCuentasPorCliente(_numiCliente As String) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 4))
        _listParam.Add(New Datos.DParametro("@yduact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@cliente", _numiCliente))
        _Tabla = D_ProcedimientoConParam("sp_Mam_VentasCredito", _listParam)

        Return _Tabla
    End Function

    Public Shared Function L_fnCobranzasGeneralCompra() As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 3))
        _listParam.Add(New Datos.DParametro("@teuact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TC00121Cheque", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnListarPagosCompras(_credito As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 5))
        _listParam.Add(New Datos.DParametro("@credito", _credito))
        _listParam.Add(New Datos.DParametro("@teuact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TC00121Cheque", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnCobranzasObtenerLosPagosCompra(_numi As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 7))
        _listParam.Add(New Datos.DParametro("@teuact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@tdnumi", _numi))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TC00121Cheque", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnCobranzasObtenerLasVentasACreditoCompras() As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 6))
        _listParam.Add(New Datos.DParametro("@teuact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TC00121Cheque", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnCobranzasDetalleCompras(_numi As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 4))
        _listParam.Add(New Datos.DParametro("@teuact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@tenumi", _numi))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TC00121Cheque", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnCobranzasReporteCompras(_numi As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 8))
        _listParam.Add(New Datos.DParametro("@teuact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@tenumi", _numi))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TC00121Cheque", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnEliminarCobranzaCompras(numi As String, ByRef mensaje As String) As Boolean
        Dim _resultado As Boolean
        If L_fnbValidarEliminacion(numi, "TC0013", "tenumi", mensaje) = True Then
            Dim _Tabla As DataTable
            Dim _listParam As New List(Of Datos.DParametro)

            _listParam.Add(New Datos.DParametro("@tipo", -1))
            _listParam.Add(New Datos.DParametro("@tenumi", numi))
            _listParam.Add(New Datos.DParametro("@teuact", L_Usuario))

            _Tabla = D_ProcedimientoConParam("sp_Mam_TC00121Cheque", _listParam)

            If _Tabla.Rows.Count > 0 Then
                _resultado = True
            Else
                _resultado = False
            End If
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
    '@tenumi ,@tefdoc,@tety4vend ,@teobs ,@newFecha ,@newHora ,@teuact 
    Public Shared Function L_fnGrabarCobranzaCompras(_tenumi As String, _tefdoc As String, _tety4vend As Integer, _teobs As String, detalle As DataTable) As Boolean
        Dim _Tabla As DataTable
        Dim _resultado As Boolean
        Dim _listParam As New List(Of Datos.DParametro)
        '   @canumi ,@caalm,@cafdoc ,@caty4prov  ,@catven,
        '@cafvcr,@camon ,@caest  ,@caobs ,@cadesc ,@newFecha,@newHora,@cauact
        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@tenumi", _tenumi))
        _listParam.Add(New Datos.DParametro("@tefdoc", _tefdoc))
        _listParam.Add(New Datos.DParametro("@tety4vend", _tety4vend))
        _listParam.Add(New Datos.DParametro("@teobs", _teobs))
        _listParam.Add(New Datos.DParametro("@teuact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@TC00121", "", detalle))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TC00121Cheque", _listParam)


        If _Tabla.Rows.Count > 0 Then
            _tenumi = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function

    Public Shared Function L_fnModificarCobranzaCompras(_tenumi As String, _tefdoc As String, _tety4vend As Integer, _teobs As String, detalle As DataTable) As Boolean
        Dim _Tabla As DataTable
        Dim _resultado As Boolean
        Dim _listParam As New List(Of Datos.DParametro)
        '   @canumi ,@caalm,@cafdoc ,@caty4prov  ,@catven,
        '@cafvcr,@camon ,@caest  ,@caobs ,@cadesc ,@newFecha,@newHora,@cauact
        _listParam.Add(New Datos.DParametro("@tipo", 2))
        _listParam.Add(New Datos.DParametro("@tenumi", _tenumi))
        _listParam.Add(New Datos.DParametro("@tefdoc", _tefdoc))
        _listParam.Add(New Datos.DParametro("@tety4vend", _tety4vend))
        _listParam.Add(New Datos.DParametro("@teobs", _teobs))
        _listParam.Add(New Datos.DParametro("@teuact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@TC00121", "", detalle))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TC00121Cheque", _listParam)


        If _Tabla.Rows.Count > 0 Then
            _tenumi = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function

    Public Shared Function L_prReporteCreditoClienteUnaCuentas(_numiCredito As String) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 5))
        _listParam.Add(New Datos.DParametro("@yduact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@codCredito", _numiCredito))
        _Tabla = D_ProcedimientoConParam("sp_Mam_VentasCredito", _listParam)

        Return _Tabla
    End Function

    Public Shared Function L_prReporteCreditoGeneral(fechaI As String, fechaF As String) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@fechaI", fechaI))
        _listParam.Add(New Datos.DParametro("@fechaF", fechaF))
        _listParam.Add(New Datos.DParametro("@yduact", L_Usuario))

        _Tabla = D_ProcedimientoConParam("sp_Mam_VentasCredito", _listParam)

        Return _Tabla
    End Function

    Public Shared Function L_fnCobranzasReporte(_numi As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 8))
        _listParam.Add(New Datos.DParametro("@teuact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@tenumi", _numi))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TV00121Cheque", _listParam)

        Return _Tabla
    End Function

    Public Shared Function L_fnGrabarCobranza(_tenumi As String, _tefdoc As String, _tety4vend As Integer, _teobs As String, detalle As DataTable,
                                              _teturno As Integer, _Sucursal As Integer) As Boolean
        Dim _Tabla As DataTable
        Dim _resultado As Boolean
        Dim _listParam As New List(Of Datos.DParametro)
        '   @canumi ,@caalm,@cafdoc ,@caty4prov  ,@catven,
        '@cafvcr,@camon ,@caest  ,@caobs ,@cadesc ,@newFecha,@newHora,@cauact
        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@tenumi", _tenumi))
        _listParam.Add(New Datos.DParametro("@tefdoc", _tefdoc))
        _listParam.Add(New Datos.DParametro("@tety4vend", _tety4vend))
        _listParam.Add(New Datos.DParametro("@teobs", _teobs))
        _listParam.Add(New Datos.DParametro("@teTurno", _teturno))
        _listParam.Add(New Datos.DParametro("@teSucursal", _Sucursal))
        _listParam.Add(New Datos.DParametro("@teuact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@TV00121", "", detalle))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TV00121Cheque", _listParam)


        If _Tabla.Rows.Count > 0 Then
            _tenumi = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function
    Public Shared Function L_fnModificarCobranza(_tenumi As String, _tefdoc As String, _tety4vend As Integer, _teobs As String, detalle As DataTable) As Boolean
        Dim _Tabla As DataTable
        Dim _resultado As Boolean
        Dim _listParam As New List(Of Datos.DParametro)
        '   @canumi ,@caalm,@cafdoc ,@caty4prov  ,@catven,
        '@cafvcr,@camon ,@caest  ,@caobs ,@cadesc ,@newFecha,@newHora,@cauact
        _listParam.Add(New Datos.DParametro("@tipo", 2))
        _listParam.Add(New Datos.DParametro("@tenumi", _tenumi))
        _listParam.Add(New Datos.DParametro("@tefdoc", _tefdoc))
        _listParam.Add(New Datos.DParametro("@tety4vend", _tety4vend))
        _listParam.Add(New Datos.DParametro("@teobs", _teobs))
        _listParam.Add(New Datos.DParametro("@teuact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@TV00121", "", detalle))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TV00121Cheque", _listParam)


        If _Tabla.Rows.Count > 0 Then
            _tenumi = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function
    Public Shared Function L_fnEliminarCobranza(numi As String, ByRef mensaje As String) As Boolean
        Dim _resultado As Boolean

        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", -1))
        _listParam.Add(New Datos.DParametro("@tenumi", numi))
        _listParam.Add(New Datos.DParametro("@teuact", L_Usuario))

        _Tabla = D_ProcedimientoConParam("sp_Mam_TV00121Cheque", _listParam)

        If _Tabla.Rows.Count > 0 Then
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function
    Public Shared Function L_fnGrabarPagos(_numi As String, dt As DataTable) As Boolean
        Dim _Tabla As DataTable
        Dim _resultado As Boolean
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@tduact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@tdnumi", _numi))
        _listParam.Add(New Datos.DParametro("@TV00121", "", dt))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TV00121", _listParam)


        If _Tabla.Rows.Count > 0 Then
            _numi = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function
    Public Shared Function L_fnCobranzasGeneral() As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 3))
        _listParam.Add(New Datos.DParametro("@teuact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TV00121Cheque", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnReporteMorosidadTodosAlmacenUnVendedor(numiVendedor As Integer, _fechai As String, _fechaf As String) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 11))
        _listParam.Add(New Datos.DParametro("@vendedor", numiVendedor))
        _listParam.Add(New Datos.DParametro("@fechaI", _fechai))
        _listParam.Add(New Datos.DParametro("@fechaF", _fechaf))
        _Tabla = D_ProcedimientoConParam("sp_Mam_VentasCredito", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnReporteMorosidadUnAlmacenUnVendedor(numiVendedor As Integer, numiCliente As Integer, _fechai As String, _fechaf As String) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 12))
        _listParam.Add(New Datos.DParametro("@vendedor", numiVendedor))
        _listParam.Add(New Datos.DParametro("@cliente", numiCliente))
        _listParam.Add(New Datos.DParametro("@fechaI", _fechai))
        _listParam.Add(New Datos.DParametro("@fechaF", _fechaf))
        _Tabla = D_ProcedimientoConParam("sp_Mam_VentasCredito", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnReporteMorosidadTodosAlmacenUnCliente(numiCliente As Integer, _fechai As String, _fechaf As String) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 121))
        _listParam.Add(New Datos.DParametro("@Cliente", numiCliente))
        _listParam.Add(New Datos.DParametro("@fechaI", _fechai))
        _listParam.Add(New Datos.DParametro("@fechaF", _fechaf))
        _Tabla = D_ProcedimientoConParam("sp_Mam_VentasCredito", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_prResumenCobrosPorVendedorTodosAlmacen(fechaI As String, fechaF As String, _numiVendedor As String) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 22))
        _listParam.Add(New Datos.DParametro("@fechaI", fechaI))
        _listParam.Add(New Datos.DParametro("@fechaF", fechaF))
        _listParam.Add(New Datos.DParametro("@uact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@vendedor", _numiVendedor))
        _Tabla = D_ProcedimientoConParam("Sp_Mam_ReporteVentasVsCostos", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_prResumenCobrosUnaVendedorUnaAlmacen(fechaI As String, fechaF As String, _numiCliente As String, _numiVendedor As String) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 44))
        _listParam.Add(New Datos.DParametro("@fechaI", fechaI))
        _listParam.Add(New Datos.DParametro("@fechaF", fechaF))
        _listParam.Add(New Datos.DParametro("@uact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@cliente", _numiCliente))
        _listParam.Add(New Datos.DParametro("@vendedor", _numiVendedor))
        _Tabla = D_ProcedimientoConParam("Sp_Mam_ReporteVentasVsCostos", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_prResumenCobrosTodosVendedorUnaAlmacen(fechaI As String, fechaF As String, _numiCliente As String) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 33))
        _listParam.Add(New Datos.DParametro("@fechaI", fechaI))
        _listParam.Add(New Datos.DParametro("@fechaF", fechaF))
        _listParam.Add(New Datos.DParametro("@uact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@cliente", _numiCliente))
        _Tabla = D_ProcedimientoConParam("Sp_Mam_ReporteVentasVsCostos", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_prResumenCobrosGeneralAlmacenVendedor(fechaI As String, fechaF As String) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 11))
        _listParam.Add(New Datos.DParametro("@fechaI", fechaI))
        _listParam.Add(New Datos.DParametro("@fechaF", fechaF))
        _listParam.Add(New Datos.DParametro("@uact", L_Usuario))

        _Tabla = D_ProcedimientoConParam("Sp_Mam_ReporteVentasVsCostos", _listParam)

        Return _Tabla
    End Function
#End Region









































































































































































#Region "LIBRERIAS"
    Public Shared Function L_prLibreriaDetalleGeneral(_cod1 As String, _cod2 As String) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 3))
        _listParam.Add(New Datos.DParametro("@cncod1", _cod1))
        _listParam.Add(New Datos.DParametro("@cncod2", _cod2))
        _listParam.Add(New Datos.DParametro("@cnuact", L_Usuario))

        _Tabla = D_ProcedimientoConParam("sp_dg_TC0051", _listParam)

        Return _Tabla
    End Function
#End Region

#Region "ROLES CORRECTO"

    Public Shared Function L_prRolGeneral() As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 3))
        _listParam.Add(New Datos.DParametro("@uact", L_Usuario))

        _Tabla = D_ProcedimientoConParam("sp_dg_ZY002", _listParam)

        Return _Tabla
    End Function

    Public Shared Function L_prRolDetalleGeneral(_numi As String) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 4))
        _listParam.Add(New Datos.DParametro("@ybnumi", _numi))
        _listParam.Add(New Datos.DParametro("@uact", L_Usuario))

        _Tabla = D_ProcedimientoConParam("sp_dg_ZY002", _listParam)

        Return _Tabla
    End Function


    Public Shared Function L_prRolGrabar(ByRef _numi As String, _rol As String, _detalle As DataTable) As Boolean
        Dim _resultado As Boolean

        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@ybnumi", _numi))
        _listParam.Add(New Datos.DParametro("@ybrol", _rol))
        _listParam.Add(New Datos.DParametro("@ZY0021", "", _detalle))
        _listParam.Add(New Datos.DParametro("@uact", L_Usuario))

        _Tabla = D_ProcedimientoConParam("sp_dg_ZY002", _listParam)

        If _Tabla.Rows.Count > 0 Then
            _numi = _Tabla.Rows(0).Item(0)
            _resultado = True
            'L_prTipoCambioGrabarHistorial(_numi, _fecha, _dolar, _ufv, "TIPO DE CAMBIO", 1)
        Else
            _resultado = False
        End If

        Return _resultado
    End Function

    Public Shared Function L_prRolModificar(_numi As String, _rol As String, _detalle As DataTable) As Boolean
        Dim _resultado As Boolean

        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 2))
        _listParam.Add(New Datos.DParametro("@ybnumi", _numi))
        _listParam.Add(New Datos.DParametro("@ybrol", _rol))
        _listParam.Add(New Datos.DParametro("@ZY0021", "", _detalle))
        _listParam.Add(New Datos.DParametro("@uact", L_Usuario))

        _Tabla = D_ProcedimientoConParam("sp_dg_ZY002", _listParam)

        If _Tabla.Rows.Count > 0 Then
            _resultado = True
            'L_prTipoCambioGrabarHistorial(_numi, _fecha, _dolar, _ufv, "TIPO DE CAMBIO", 2)
        Else
            _resultado = False
        End If

        Return _resultado
    End Function



    Public Shared Function L_prRolBorrar(_numi As String, ByRef _mensaje As String) As Boolean

        Dim _resultado As Boolean
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", -1))
        _listParam.Add(New Datos.DParametro("@ybnumi", _numi))
        _listParam.Add(New Datos.DParametro("@uact", L_Usuario))

        _Tabla = D_ProcedimientoConParam("sp_dg_ZY002", _listParam)

        If _Tabla.Rows.Count > 0 Then
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function



#End Region

#Region "Roles"
    Public Shared Function L_Rol_General(_Modo As Integer, Optional _Cadena As String = "") As DataSet
        Dim _Tabla As DataTable
        Dim _Ds As New DataSet
        Dim _Where As String
        If _Modo = 0 Then
            _Where = "ZY002.ybnumi=ZY002.ybnumi "
        Else
            _Where = "ZY002.ybnumi=ZY002.ybnumi " + _Cadena
        End If
        _Tabla = D_Datos_Tabla("ZY002.ybnumi,ZY002.ybrol", "ZY002", _Where + " order by ybnumi")
        _Ds.Tables.Add(_Tabla)
        Return _Ds
    End Function
    Public Shared Function L_RolDetalle_General(_Modo As Integer, Optional _idCabecera As String = "", Optional _idModulo As String = "") As DataTable
        Dim _Tabla As DataTable
        Dim _Where As String
        If _Modo = 0 Then
            _Where = " ycnumi = ycnumi"
        Else
            _Where = " ycnumi=" + _idCabecera + " and ZY001.yamod=" + _idModulo + " and ZY0021.ycyanumi=ZY001.yanumi"
        End If
        _Tabla = D_Datos_Tabla("ZY0021.ycnumi,ZY0021.ycyanumi,ZY0021.ycshow,ZY0021.ycadd,ZY0021.ycmod,ZY0021.ycdel,ZY001.yaprog,ZY001.yatit", "ZY0021,ZY001", _Where)
        Return _Tabla
    End Function

    Public Shared Function L_RolDetalle_General2(_Modo As Integer, Optional _idCabecera As String = "", Optional _where1 As String = "") As DataTable
        Dim _Tabla As DataTable
        Dim _Where As String
        If _Modo = 0 Then
            _Where = " ycnumi = ycnumi"
        Else
            _Where = " ycnumi=" + _idCabecera + " and " + _where1
        End If
        _Tabla = D_Datos_Tabla("ycnumi,ycyanumi,ycshow,ycadd,ycmod,ycdel", "ZY0021", _Where)
        Return _Tabla
    End Function

    Public Shared Function L_prRolDetalleGeneral(_numiRol As String, _idNombreButton As String) As DataTable
        Dim _Tabla As DataTable
        Dim _Where As String

        _Where = "ZY0021.ycnumi=" + _numiRol + " and ZY0021.ycyanumi=ZY001.yanumi and ZY001.yaprog='" + _idNombreButton + "'"

        _Tabla = D_Datos_Tabla("ycnumi,ycyanumi,ycshow,ycadd,ycmod,ycdel", "ZY0021,ZY001", _Where)
        Return _Tabla
    End Function

    Public Shared Sub L_Rol_Grabar(ByRef _numi As String, _rol As String)
        Dim _Actualizacion As String
        Dim _Err As Boolean
        Dim _Tabla As DataTable
        _Tabla = D_Maximo("ZY002", "ybnumi", "ybnumi=ybnumi")
        If Not IsDBNull(_Tabla.Rows(0).Item(0)) Then
            _numi = _Tabla.Rows(0).Item(0) + 1
        Else
            _numi = "1"
        End If

        _Actualizacion = "'" + Date.Now.Date.ToString("yyyy/MM/dd") + "', '" + Now.Hour.ToString + ":" + Now.Minute.ToString + "' ,'" + L_Usuario + "'"

        Dim Sql As String
        Sql = _numi + ",'" + _rol + "'," + _Actualizacion
        _Err = D_Insertar_Datos("ZY002", Sql)
    End Sub
    Public Shared Sub L_RolDetalle_Grabar(_idCabecera As String, _numi1 As Integer, _show As Boolean, _add As Boolean, _mod As Boolean, _del As Boolean)
        Dim _Err As Boolean
        Dim Sql As String
        Sql = _idCabecera & "," & _numi1 & ",'" & _show & "','" & _add & "','" & _mod & "','" & _del & "'"
        _Err = D_Insertar_Datos("ZY0021", Sql)
    End Sub
    Public Shared Sub L_Rol_Modificar(_numi As String, _desc As String)
        Dim _Err As Boolean
        Dim Sql, _where As String

        Sql = "ybrol = '" + _desc + "' "

        _where = "ybnumi = " + _numi
        _Err = D_Modificar_Datos("ZY002", Sql, _where)
    End Sub
    Public Shared Sub L_Rol_Borrar(_Id As String)
        Dim _Where As String
        Dim _Err As Boolean
        _Where = "ybnumi = " + _Id
        _Err = D_Eliminar_Datos("ZY002", _Where)
    End Sub
    Public Shared Sub L_RolDetalle_Modificar(_idCabecera As String, _numi1 As Integer, _show As Boolean, _add As Boolean, _mod As Boolean, _del As Boolean)
        Dim _Err As Boolean
        Dim Sql, _where As String

        Sql = "ycshow = '" & _show & "' , " & "ycadd = '" & _add & "' , " & "ycmod = '" & _mod & "' , " & "ycdel = '" & _del & "' "

        _where = "ycnumi = " & _idCabecera & " and ycyanumi = " & _numi1
        _Err = D_Modificar_Datos("ZY0021", Sql, _where)
    End Sub
    Public Shared Sub L_RolDetalle_Borrar(_Id As String, _Id1 As String)
        Dim _Where As String
        Dim _Err As Boolean

        _Where = "ycnumi = " + _Id + " and ycyanumi = " + _Id1
        _Err = D_Eliminar_Datos("ZY0021", _Where)
    End Sub
    Public Shared Sub L_RolDetalle_Borrar(_Id As String)
        Dim _Where As String
        Dim _Err As Boolean

        _Where = "ycnumi = " + _Id
        _Err = D_Eliminar_Datos("ZY0021", _Where)
    End Sub

#Region "Verificaciones"
    '****************Verifica si el Rol esta relacionado con otros programas
    Public Shared Function L_fnValidarEliminacion(_ybnumi As String) As Boolean
        Dim _Tabla As DataTable
        Dim res As Boolean = False
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 5))
        _listParam.Add(New Datos.DParametro("@ybnumi", _ybnumi))
        _listParam.Add(New Datos.DParametro("@uact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_dg_ZY002", _listParam)
        Return res = IIf(_Tabla.Rows(0).Item(0) = 0, False, True)
    End Function
#End Region
#End Region

#Region "CON.USUARIOS USU002"
    Public Shared Function L_fnMostrarUsuario() As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 4))
        _listParam.Add(New Datos.DParametro("@uaUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("CON.sp_USU002", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_fnGrabarUsuario(ByRef _uaId As String, _ua_ecId As String, _uaUser As String, _uaPass As String,
                                             _uaRol As String, _uaFIngreso As String, _uaEst As String, _uaEmer As String,
                                             _uaSuc As Integer) As Boolean

        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@uaId", _uaId))
        _listParam.Add(New Datos.DParametro("@ua_ecId", _ua_ecId))
        _listParam.Add(New Datos.DParametro("@uaUser", _uaUser))
        _listParam.Add(New Datos.DParametro("@uaPass", _uaPass))
        _listParam.Add(New Datos.DParametro("@uaRol", _uaRol))
        _listParam.Add(New Datos.DParametro("@uaFIngreso", _uaFIngreso))
        _listParam.Add(New Datos.DParametro("@uaEst", _uaEst))
        _listParam.Add(New Datos.DParametro("@uaEmer", _uaEmer))
        _listParam.Add(New Datos.DParametro("@uaSucursal", _uaSuc))
        _listParam.Add(New Datos.DParametro("@uaUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("CON.sp_USU002", _listParam)
        If _Tabla.Rows.Count > 0 Then
            _uaId = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function
    Public Shared Function L_fnModificarUsuario(ByRef _uaId As String, _ua_ecId As String, _uaUser As String, _uaPass As String,
                                             _uaRol As String, _uaFIngreso As String, _uaEst As String, _uaEmer As String,
                                             _uaSuc As Integer) As Boolean
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 2))
        _listParam.Add(New Datos.DParametro("@uaId", _uaId))
        _listParam.Add(New Datos.DParametro("@ua_ecId", _ua_ecId))
        _listParam.Add(New Datos.DParametro("@uaUser", _uaUser))
        _listParam.Add(New Datos.DParametro("@uaPass", _uaPass))
        _listParam.Add(New Datos.DParametro("@uaRol", _uaRol))
        _listParam.Add(New Datos.DParametro("@uaFIngreso", _uaFIngreso))
        _listParam.Add(New Datos.DParametro("@uaEst", _uaEst))
        _listParam.Add(New Datos.DParametro("@uaEmer", _uaEmer))
        _listParam.Add(New Datos.DParametro("@uaSucursal", _uaSuc))
        _listParam.Add(New Datos.DParametro("@uaUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("CON.sp_USU002", _listParam)
        If _Tabla.Rows.Count > 0 Then
            _uaId = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function

    Public Shared Function L_fnEliminarUsuario(ByRef _uaId As String, ByRef mensaje As String) As Boolean
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 3))
        _listParam.Add(New Datos.DParametro("@uaId", _uaId))
        _listParam.Add(New Datos.DParametro("@uaUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("CON.sp_USU002", _listParam)
        If _Tabla.Rows.Count > 0 Then
            _uaId = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function

#Region "Verificaciones"
    Public Shared Function L_fnExisteUsuarioEmergencia(_uaUser As String, _uaPass As String) As Boolean
        Dim _Tabla As DataTable
        Dim _res As Boolean = False
        Dim _where = String.Format(" uaUser= '{0}' AND uaPass = '{1}'AND uaEmer = 1 ", _uaUser, _uaPass)
        _Tabla = D_Datos_Tabla(" COUNT(*) ", " CON.USU002 ", _where)
        If _Tabla.Rows(0).Item(0) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function L_Validar_Usuario(_Nom As String, _Pass As String) As DataTable
        'Dim _Tabla As DataTable
        '_Tabla = D_Datos_Tabla("uaUser,uaPpass", "CON.USU002", "uaUser = '" + _Nom + "' AND uaPpass = '" + _Pass + "'")
        'Return _Tabla

        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 5))
        _listParam.Add(New Datos.DParametro("@uaUser", _Nom))
        _listParam.Add(New Datos.DParametro("@uaPass", _Pass))
        _listParam.Add(New Datos.DParametro("@uaUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("CON.sp_USU002", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_Validar_Usuario2(_Nom As String, _Pass As String) As Boolean

        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 5))
        _listParam.Add(New Datos.DParametro("@uaUser", _Nom))
        _listParam.Add(New Datos.DParametro("@uaPass", _Pass))
        _listParam.Add(New Datos.DParametro("@uaUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("CON.sp_USU002", _listParam)
        If _Tabla.Rows.Count > 0 Then
            _resultado = True
        Else
            _resultado = False
        End If
        Return _resultado
    End Function
    Public Shared Function L_ObtenerVeterinario(_Usuario As String) As DataTable

        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 6))
        _listParam.Add(New Datos.DParametro("@uaUser", _Usuario))
        _listParam.Add(New Datos.DParametro("@uaUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("CON.sp_USU002", _listParam)

        Return _Tabla
    End Function
#End Region

#End Region

#Region "CON.CONSULTORIOS CONS001"
    Public Shared Function L_fnMostrarConsultorio() As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 4))
        _listParam.Add(New Datos.DParametro("@ccUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("CON.sp_CONS001", _listParam)
        Return _Tabla
    End Function
    Public Shared Function L_fnGrabarConsultorio(ByRef _Id As String, _Fecha As String, _Nro As String, _Est As String) As Boolean

        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@ccId", _Id))
        _listParam.Add(New Datos.DParametro("@ccFecha", _Fecha))
        _listParam.Add(New Datos.DParametro("@ccNro", _Nro))
        _listParam.Add(New Datos.DParametro("@ccEst", _Est))
        _listParam.Add(New Datos.DParametro("@ccUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("CON.sp_CONS001", _listParam)
        If _Tabla.Rows.Count > 0 Then
            _Id = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function
    Public Shared Function L_fnModificarConsultorio(ByRef _Id As String, _Fecha As String, _Nro As String, _Est As String) As Boolean
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 2))
        _listParam.Add(New Datos.DParametro("@ccId", _Id))
        _listParam.Add(New Datos.DParametro("@ccFecha", _Fecha))
        _listParam.Add(New Datos.DParametro("@ccNro", _Nro))
        _listParam.Add(New Datos.DParametro("@ccEst", _Est))
        _listParam.Add(New Datos.DParametro("@ccUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("CON.sp_CONS001", _listParam)
        If _Tabla.Rows.Count > 0 Then
            _Id = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function

    Public Shared Function L_fnEliminarConsultorio(ByRef _Id As String, ByRef mensaje As String) As Boolean
        Dim _resultado As Boolean
        If L_fnbValidarEliminacion(_Id, "CON.CONS001", "ccId", mensaje) = True Then

            Dim _Tabla As DataTable
            Dim _listParam As New List(Of Datos.DParametro)

            _listParam.Add(New Datos.DParametro("@tipo", 3))
            _listParam.Add(New Datos.DParametro("@ccId", _Id))
            _listParam.Add(New Datos.DParametro("@ccUsuario", L_Usuario))
            _Tabla = D_ProcedimientoConParam("CON.sp_CONS001", _listParam)
            If _Tabla.Rows.Count > 0 Then
                _Id = _Tabla.Rows(0).Item(0)
                _resultado = True
            Else
                _resultado = False
            End If
        Else
            _resultado = False
        End If
        Return _resultado

    End Function

    Public Shared Function L_fnValidarSiExisteConsultorio(ByRef _Nro As String) As Boolean

        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 5))
        _listParam.Add(New Datos.DParametro("@ccNro", _Nro))
        _listParam.Add(New Datos.DParametro("@ccUsuario", L_Usuario))
        _Tabla = D_ProcedimientoConParam("CON.sp_CONS001", _listParam)
        If _Tabla.Rows.Count > 0 Then
            _Nro = _Tabla.Rows(0).Item(2)
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function

#End Region

#Region "TS002 Dosificacion"

    Public Shared Function L_fnEliminarDosificacion(numi As String, ByRef mensaje As String, autorizacion As String) As Boolean
        Dim _resultado As Boolean
        If L_fnbValidarEliminacion(autorizacion, "TS002", "sbautoriz", mensaje) = True Then
            Dim _Tabla As DataTable
            Dim _listParam As New List(Of Datos.DParametro)

            _listParam.Add(New Datos.DParametro("@tipo", -1))
            _listParam.Add(New Datos.DParametro("@numi", numi))
            _listParam.Add(New Datos.DParametro("@uact", L_Usuario))

            _Tabla = D_ProcedimientoConParam("sp_go_TS002", _listParam)

            If _Tabla.Rows.Count > 0 Then
                _resultado = True
            Else
                _resultado = False
            End If
        Else
            _resultado = False
        End If
        Return _resultado
    End Function



    Public Shared Function L_fnGrabarDosificacion(ByRef numi As String, cia As Integer, alm As String, sfc As String,
                                                  autoriz As String, nfac As Double, key As String, fdel As String,
                                                  fal As String, nota As String, nota2 As String, est As String) As Boolean
        Dim _resultado As Boolean

        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@numi", numi))
        _listParam.Add(New Datos.DParametro("@cia", cia))
        _listParam.Add(New Datos.DParametro("@alm", alm))
        _listParam.Add(New Datos.DParametro("@sfc", sfc))
        _listParam.Add(New Datos.DParametro("@autoriz", autoriz))
        _listParam.Add(New Datos.DParametro("@nfac", nfac))
        _listParam.Add(New Datos.DParametro("@key", key))
        _listParam.Add(New Datos.DParametro("@fdel", fdel))
        _listParam.Add(New Datos.DParametro("@fal", fal))
        _listParam.Add(New Datos.DParametro("@nota", nota))
        _listParam.Add(New Datos.DParametro("@nota2", nota2))
        _listParam.Add(New Datos.DParametro("@est", est))

        _listParam.Add(New Datos.DParametro("@uact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_go_TS002", _listParam)

        If _Tabla.Rows.Count > 0 Then
            numi = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function

    Public Shared Function L_fnModificarDosificacion(ByRef numi As String, cia As Integer, alm As String, sfc As String,
                                                     autoriz As String, nfac As Double, key As String, fdel As String,
                                                     fal As String, nota As String, nota2 As String, est As String) As Boolean
        Dim _resultado As Boolean

        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 2))
        _listParam.Add(New Datos.DParametro("@numi", numi))
        _listParam.Add(New Datos.DParametro("@cia", cia))
        _listParam.Add(New Datos.DParametro("@alm", alm))
        _listParam.Add(New Datos.DParametro("@sfc", sfc))
        _listParam.Add(New Datos.DParametro("@autoriz", autoriz))
        _listParam.Add(New Datos.DParametro("@nfac", nfac))
        _listParam.Add(New Datos.DParametro("@key", key))
        _listParam.Add(New Datos.DParametro("@fdel", fdel))
        _listParam.Add(New Datos.DParametro("@fal", fal))
        _listParam.Add(New Datos.DParametro("@nota", nota))
        _listParam.Add(New Datos.DParametro("@nota2", nota2))
        _listParam.Add(New Datos.DParametro("@est", est))

        _listParam.Add(New Datos.DParametro("@uact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_go_TS002", _listParam)

        If _Tabla.Rows.Count > 0 Then
            numi = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function

    Public Shared Function L_fnGeneralDosificacion() As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 3))
        _listParam.Add(New Datos.DParametro("@uact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_go_TS002", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnListarCompaniaDosificacion() As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 4))
        _listParam.Add(New Datos.DParametro("@uact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_go_TS002", _listParam)

        Return _Tabla
    End Function

    Public Shared Function L_fnListarAlmacenDosificacion() As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 5))
        _listParam.Add(New Datos.DParametro("@uact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_go_TS002", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_Dosificacion(_cia As String, _alm As String, _fecha As String) As DataSet
        Dim _Tabla As DataTable
        Dim _Ds As New DataSet
        Dim _Where As String
        '_fecha = Now.Date.ToString("yyyy/MM/dd")
        _Where = "sbcia = " + _cia + " AND sbalm = " + _alm + " AND sbfdel <= '" + _fecha + "' AND sbfal >= '" + _fecha + "' AND sbest = 1"

        _Tabla = D_Datos_Tabla("*", "TS002", _Where)
        _Ds.Tables.Add(_Tabla)
        Return _Ds
    End Function
    Public Shared Sub L_Actualiza_Dosificacion(_Numi As String, _NumFac As String, _Numi2 As String)
        Dim _Err As Boolean
        Dim Sql, _where As String
        Sql = "sbnfac = " + _NumFac
        _where = "sbnumi = " + _Numi

        _Err = D_Modificar_Datos("TS002", Sql, _where)
    End Sub
#End Region

#Region "Facturar"

    Public Shared Sub L_Grabar_Factura(_Numi As String, _Fecha As String, _Nfac As String, _NAutoriz As String, _Est As String,
                                       _NitCli As String, _CodCli As String, _DesCli1 As String, _DesCli2 As String,
                                       _A As String, _B As String, _C As String, _D As String, _E As String, _F As String,
                                       _G As String, _H As String, _CodCon As String, _FecLim As String,
                                       _Imgqr As String, _Alm As String, _Numi2 As String, _hora As String)
        Dim Sql As String
        Try
            Sql = "" + _Numi + ", " _
                + "'" + _Fecha + "', " _
                + "" + _Nfac + ", " _
                + "" + _NAutoriz + ", " _
                + "" + _Est + ", " _
                + "'" + _NitCli + "', " _
                + "" + _CodCli + ", " _
                + "'" + _DesCli1 + "', " _
                + "'" + _DesCli2 + "', " _
                + "" + _A + ", " _
                + "" + _B + ", " _
                + "" + _C + ", " _
                + "" + _D + ", " _
                + "" + _E + ", " _
                + "" + _F + ", " _
                + "" + _G + ", " _
                + "" + _H + ", " _
                + "'" + _CodCon + "', " _
                + "'" + _FecLim + "', " _
                + "" + _Imgqr + ", " _
                + "" + _Alm + ", " _
                + "" + _Numi2 + ", " _
                + "'" + _hora + "'"
            D_Insertar_Datos("TFV001", Sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared Sub L_Modificar_Factura(Where As String, Optional _Fecha As String = "",
                                          Optional _Nfact As String = "", Optional _NAutoriz As String = "",
                                          Optional _Est As String = "", Optional _NitCli As String = "",
                                          Optional _CodCli As String = "", Optional _DesCli1 As String = "",
                                          Optional _DesCli2 As String = "", Optional _A As String = "",
                                          Optional _B As String = "", Optional _C As String = "",
                                          Optional _D As String = "", Optional _E As String = "",
                                          Optional _F As String = "", Optional _G As String = "",
                                          Optional _H As String = "", Optional _CodCon As String = "",
                                          Optional _FecLim As String = "", Optional _Imgqr As String = "",
                                          Optional _Alm As String = "", Optional _Numi2 As String = "")
        Dim Sql As String
        Try
            Sql = IIf(_Fecha.Equals(""), "", "fvafec = '" + _Fecha + "', ") +
              IIf(_Nfact.Equals(""), "", "fvanfac = " + _Nfact + ", ") +
              IIf(_NAutoriz.Equals(""), "", "fvaautoriz = " + _NAutoriz + ", ") +
              IIf(_Est.Equals(""), "", "fvaest = " + _Est) +
              IIf(_NitCli.Equals(""), "", "fvanitcli = '" + _NitCli + "', ") +
              IIf(_CodCli.Equals(""), "", "fvacodcli = " + _CodCli + ", ") +
              IIf(_DesCli1.Equals(""), "", "fvadescli1 = '" + _DesCli1 + "', ") +
              IIf(_DesCli2.Equals(""), "", "fvadescli2 = '" + _DesCli2 + "', ") +
              IIf(_A.Equals(""), "", "fvastot = " + _A + ", ") +
              IIf(_B.Equals(""), "", "fvaimpsi = " + _B + ", ") +
              IIf(_C.Equals(""), "", "fvaimpeo = " + _C + ", ") +
              IIf(_D.Equals(""), "", "fvaimptc = " + _D + ", ") +
              IIf(_E.Equals(""), "", "fvasubtotal = " + _E + ", ") +
              IIf(_F.Equals(""), "", "fvadesc = " + _F + ", ") +
              IIf(_G.Equals(""), "", "fvatotal = " + _G + ", ") +
              IIf(_H.Equals(""), "", "fvadebfis = " + _H + ", ") +
              IIf(_CodCon.Equals(""), "", "fvaccont = '" + _CodCon + "', ") +
              IIf(_FecLim.Equals(""), "", "fvaflim = '" + _FecLim + "', ") +
              IIf(_Imgqr.Equals(""), "", "fvaimgqr = '" + _Imgqr + "', ") +
              IIf(_Alm.Equals(""), "", "fvaalm = " + _Alm + ", ") +
              IIf(_Numi2.Equals(""), "", "fvanumi2 = " + _Numi2 + ", ")
            Sql = Sql.Trim
            If (Sql.Substring(Sql.Length - 1, 1).Equals(",")) Then
                Sql = Sql.Substring(0, Sql.Length - 1)
            End If

            D_Modificar_Datos("TFV001", Sql, Where)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Shared Sub L_Grabar_Factura_Detalle(_Numi As String, _CodProd As String, _DescProd As String, _Cant As String, _Precio As String, _Numi2 As String)
        Dim Sql As String
        Try
            Sql = _Numi + ", '" + _CodProd + "', '" + _DescProd + "', " + _Cant + ", " + _Precio + ", " + _Numi2

            D_Insertar_Datos("TFV0011", Sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared Function L_Reporte_Factura(_Numi As String, _Numi2 As String) As DataSet
        Dim _Tabla As DataTable
        Dim _Ds As New DataSet
        Dim _Where As String
        _Where = " fvanumi = " + _Numi + " and fvanumi2 = " + _Numi2

        _Tabla = D_Datos_Tabla("*", "VR_GO_Factura", _Where)
        _Ds.Tables.Add(_Tabla)
        Return _Ds
    End Function

    Public Shared Function L_Reporte_Factura_Cia(_Cia As String) As DataSet
        Dim _Tabla As DataTable
        Dim _Ds As New DataSet
        Dim _Where As String
        _Where = " scnumi = " + _Cia

        _Tabla = D_Datos_Tabla("*", "TS003", _Where)
        _Ds.Tables.Add(_Tabla)
        Return _Ds
    End Function

    Public Shared Function L_ObtenerRutaImpresora(_NroImp As String, Optional tImp As String = "") As DataSet
        Dim _Tabla As DataTable
        Dim _Ds As New DataSet
        Dim _Where As String
        If (Not _NroImp.Trim.Equals("")) Then
            _Where = " cbnumi = " + _NroImp + " and cbest = 1 order by cbnumi"
        Else
            _Where = " cbtimp = " + tImp + " and cbest = 1 order by cbnumi"
        End If
        _Tabla = D_Datos_Tabla("*", "TC002", _Where)
        _Ds.Tables.Add(_Tabla)
        Return _Ds
    End Function

    Public Shared Function L_fnGetIVA() As DataTable
        Dim _Tabla As DataTable
        Dim _Where As String
        _Where = "1 = 1"
        _Tabla = D_Datos_Tabla("scdebfis", "TS003", _Where)
        Return _Tabla
    End Function

    Public Shared Function L_fnGetICE() As DataTable
        Dim _Tabla As DataTable
        Dim _Where As String
        _Where = "1 = 1"
        _Tabla = D_Datos_Tabla("scice", "TS003", _Where)
        Return _Tabla
    End Function

    Public Shared Sub L_Grabar_Nit(_Nit As String, _Nom1 As String, _Nom2 As String)
        Dim _Err As Boolean
        Dim _Nom01, _Nom02 As String
        Dim Sql As String
        _Nom01 = ""
        _Nom02 = ""
        L_Validar_Nit(_Nit, _Nom01, _Nom02)

        If _Nom01 = "" Then
            Sql = _Nit + ", '" + _Nom1 + "', '" + _Nom2 + "'"
            _Err = D_Insertar_Datos("TS001", Sql)
        Else
            If (_Nom1 <> _Nom01) Or (_Nom2 <> _Nom02) Then
                Sql = "sanom1 = '" + _Nom1 + "' " +
                      IIf(_Nom02.ToString.Trim.Equals(""), "", ", sanom2 = '" + _Nom2 + "', ")
                _Err = D_Modificar_Datos("TS001", Sql, "sanit = " + _Nit)
            End If
        End If

    End Sub

    Public Shared Sub L_Validar_Nit(_Nit As String, ByRef _Nom1 As String, ByRef _Nom2 As String)
        Dim _Tabla As DataTable

        _Tabla = D_Datos_Tabla("*", "TS001", "sanit = '" + _Nit + "'")

        If _Tabla.Rows.Count > 0 Then
            _Nom1 = _Tabla.Rows(0).Item(2)
            _Nom2 = IIf(_Tabla.Rows(0).Item(3).ToString.Trim.Equals(""), "", _Tabla.Rows(0).Item(3))
        End If
    End Sub

    Public Shared Function L_Eliminar_Nit(_Nit As String) As Boolean
        Dim res As Boolean = False
        Try
            res = D_Eliminar_Datos("TS001", "sanit = " + _Nit)
        Catch ex As Exception
            res = False
        End Try
        Return res
    End Function


    Public Shared Function L_fnObtenerMaxIdTabla(tabla As String, campo As String, where As String) As Long
        Dim Dt As DataTable = New DataTable
        Dt = D_Maximo(tabla, campo, where)

        If (Dt.Rows.Count > 0) Then
            If (Dt.Rows(0).Item(0).ToString.Equals("")) Then
                Return 0
            Else
                Return CLng(Dt.Rows(0).Item(0).ToString)
            End If
        Else
            Return 0
        End If
    End Function

    Public Shared Function L_fnObtenerTabla(tabla As String, campo As String, where As String) As DataTable
        Dim Dt As DataTable = D_Datos_Tabla(campo, tabla, where)
        Return Dt
    End Function

    Public Shared Function L_fnObtenerDatoTabla(tabla As String, campo As String, where As String) As String
        Dim Dt As DataTable = D_Datos_Tabla(campo, tabla, where)
        If (Dt.Rows.Count > 0) Then
            Return Dt.Rows(0).Item(campo).ToString
        Else
            Return ""
        End If
    End Function

    Public Shared Function L_fnEliminarDatos(Tabla As String, Where As String) As Boolean
        Return D_Eliminar_Datos(Tabla, Where)
    End Function

#End Region


#Region "Anular Factura"

    Public Shared Function L_Obtener_Facturas() As DataSet
        Dim _Tabla1 As New DataTable
        Dim _Tabla2 As New DataTable
        Dim _Ds As New DataSet
        Dim _Where As String
        _Where = " 1 = 1"
        'Cambiar la logica para visualizar las facturas esto en el programa de facturas
        _Tabla1 = D_Datos_Tabla("concat(fvanfac, '_', fvaautoriz) as Archivo, fvanumi as Codigo, fvanfac as [Nro Factura], " _
                                + "fvafec as Fecha, fvacodcli as [Cod Cliente], " _
                                + " fvadescli1 as [Nombre 1], fvadescli2 as [Nombre 2], fvanitcli as Nit, " _
                                + " fvastot as Subtotal, fvadesc as Descuento, fvatotal as Total, " _
                                + " fvaccont as [Cod Control], fvaflim as [Fec Limite], fvaest as Estado",
                                "TFV001", _Where)
        '_Tabla1.Columns(0).ColumnMapping = MappingType.Hidden
        _Ds.Tables.Add(_Tabla1)

        _Tabla2 = D_Datos_Tabla("concat(fvanfac, '_', fvaautoriz) as Archivo, fvbnumi as Codigo, fvbcprod as [Cod Producto], fvbdesprod as Descripcion, " _
                                + " fvbcant as Cantidad, fvbprecio as [Precio Unitario], (fvbcant * fvbprecio) as Precio",
                                "TFV001, TFV0011", "fvanumi = fvbnumi and fvanumi2 = fvbnumi2")
        _Ds.Tables.Add(_Tabla2)
        _Ds.Relations.Add("1", _Tabla1.Columns("Archivo"), _Tabla2.Columns("Archivo"), False)
        Return _Ds
    End Function

    Public Shared Function L_ObtenerDetalleFactura(_CodFact As String) As DataSet 'Modifcar para que solo Traiga los productos Con Stock
        Dim _Tabla As DataTable
        Dim _Ds As New DataSet
        Dim _Where As String
        _Where = "fvbnumi = " + _CodFact
        _Tabla = D_Datos_Tabla("fvbcprod as codP, fvbcant as can, '1' as sto", "TFV0011", _Where)
        _Ds.Tables.Add(_Tabla)
        Return _Ds
    End Function

#End Region


#Region "Libro de ventas"
    Public Shared Function L_fnObtenerLibroVentaAmbosTipoFactura(_CodAlm As String, _fechai As String, _FechaF As String, TipoFactura As Integer) As DataTable
        Dim _Tabla As DataTable
        Dim _Where As String = ""

        If _CodAlm > 0 Then
            If (TipoFactura = 1) Then
                _Where = "sbcia=1 and fvaalm = " + _CodAlm + " and fvafec >= '" + _fechai + "' and fvafec <= '" + _FechaF + "' " + " ORDER BY fvanfac"

            End If
            If (TipoFactura = 2) Then
                _Where = "sbcia=2 and fvaalm = " + _CodAlm + " and fvafec >= '" + _fechai + "' and fvafec <= '" + _FechaF + "' " + " ORDER BY fvanfac"

            End If
            If (TipoFactura = 3) Then
                _Where = " fvaalm = " + _CodAlm + " and fvafec >= '" + _fechai + "' and fvafec <= '" + _FechaF + "' " + " ORDER BY fvanfac"

            End If
        End If
        If _CodAlm = 0 Then 'todas las sucursales
            If (TipoFactura = 1) Then
                _Where = "sbcia=1 and  fvafec >= '" + _fechai + "' and fvafec <= '" + _FechaF + "' " + " ORDER BY fvanfac"

            End If
            If (TipoFactura = 2) Then
                _Where = "sbcia=2 and  fvafec >= '" + _fechai + "' and fvafec <= '" + _FechaF + "' " + " ORDER BY fvanfac"

            End If
            If (TipoFactura = 3) Then
                _Where = " fvafec >= '" + _fechai + "' and fvafec <= '" + _FechaF + "' " + " ORDER BY fvanfac"

            End If


        End If
        If _CodAlm = -1 Then 'todas las sucursales menos la principal
            If (TipoFactura = 1) Then

                _Where = "sbcia=1 and fvaalm <>1 " + " and fvafec >= '" + _fechai + "' and fvafec <= '" + _FechaF + "' " + " ORDER BY fvanfac"

            End If
            If (TipoFactura = 2) Then
                _Where = "sbcia=2 and fvaalm <>1 " + " and fvafec >= '" + _fechai + "' and fvafec <= '" + _FechaF + "' " + " ORDER BY fvanfac"

            End If
            If (TipoFactura = 3) Then
                _Where = "fvaalm <>1 " + " and fvafec >= '" + _fechai + "' and fvafec <= '" + _FechaF + "' " + " ORDER BY fvanfac"

            End If


        End If

        Dim _select As String = "fvanumi, FORMAT(fvafec,'dd/MM/yyyy') as fvafec, fvanfac, fvaautoriz,fvaest, fvanitcli, fvadescli, fvastot, fvaimpsi, fvaimpeo, fvaimptc, fvasubtotal, fvadesc, fvatotal, fvadebfis, fvaccont,fvaflim,fvaalm,scneg, factura"

        _Tabla = D_Datos_Tabla(_select,
                               "VR_GO_LibroVenta2", _Where)
        Return _Tabla
    End Function
    Public Shared Function L_fnObtenerLibroVenta(_CodAlm As String, _Mes As String, _Anho As String) As DataTable
        Dim _Tabla As DataTable
        Dim _Where As String = "fvaalm = " + _CodAlm + "and Month(fvafec) = " + _Mes + " and Year(fvafec) = " + _Anho + " ORDER BY fvanfac"
        _Tabla = D_Datos_Tabla("*",
                               "VR_GO_LibroVenta", _Where)
        Return _Tabla
    End Function
    Public Shared Function L_fnObtenerLibroVenta2(_CodAlm As String, _fechai As String, _FechaF As String, factura As Integer, TipoFactura As Integer) As DataTable
        Dim _Tabla As DataTable
        Dim _Where As String = ""
        If _CodAlm > 0 Then
            If (TipoFactura = 1) Then

                _Where = "sbcia=1 and fvaalm = " + _CodAlm + " and fvafec >= '" + _fechai + "' and fvafec <= '" + _FechaF + "' and factura=" + Str(factura) + " ORDER BY fvanfac"

            End If
            If (TipoFactura = 2) Then
                _Where = "sbcia=2 and fvaalm = " + _CodAlm + " and fvafec >= '" + _fechai + "' and fvafec <= '" + _FechaF + "' and factura=" + Str(factura) + " ORDER BY fvanfac"

            End If
            If (TipoFactura = 3) Then
                _Where = " fvaalm = " + _CodAlm + " and fvafec >= '" + _fechai + "' and fvafec <= '" + _FechaF + "' and factura=" + Str(factura) + " ORDER BY fvanfac"

            End If



        End If
        If _CodAlm = 0 Then 'todas las sucursales

            If (TipoFactura = 1) Then


                _Where = "sbcia=1 and fvafec >= '" + _fechai + "' and fvafec <= '" + _FechaF + "' and factura=" + Str(factura) + " ORDER BY fvanfac"

            End If
            If (TipoFactura = 2) Then
                _Where = "sbcia=2 and fvafec >= '" + _fechai + "' and fvafec <= '" + _FechaF + "' and factura=" + Str(factura) + " ORDER BY fvanfac"

            End If
            If (TipoFactura = 3) Then
                _Where = "fvafec >= '" + _fechai + "' and fvafec <= '" + _FechaF + "' and factura=" + Str(factura) + " ORDER BY fvanfac"

            End If

        End If
        If _CodAlm = -1 Then 'todas las sucursales menos la principal
            If (TipoFactura = 1) Then


                _Where = "sbcia=1 and fvaalm <>1 " + " and fvafec >= '" + _fechai + "' and fvafec <= '" + _FechaF + "' and factura=" + Str(factura) + " ORDER BY fvanfac"
            End If
            If (TipoFactura = 2) Then
                _Where = "sbcia=2 and fvaalm <>1 " + " and fvafec >= '" + _fechai + "' and fvafec <= '" + _FechaF + "' and factura=" + Str(factura) + " ORDER BY fvanfac"

            End If
            If (TipoFactura = 3) Then
                _Where = "fvaalm <>1 " + " and fvafec >= '" + _fechai + "' and fvafec <= '" + _FechaF + "' and factura=" + Str(factura) + " ORDER BY fvanfac"

            End If


        End If
        Dim _select As String = "fvanumi, FORMAT(fvafec,'dd/MM/yyyy') as fvafec, fvanfac, fvaautoriz,fvaest, fvanitcli, fvadescli, fvastot, fvaimpsi, fvaimpeo, fvaimptc, fvasubtotal, fvadesc, fvatotal, fvadebfis, fvaccont,fvaflim,fvaalm,scneg, factura"

        _Tabla = D_Datos_Tabla(_select,
                               "VR_GO_LibroVenta2", _Where)
        Return _Tabla
    End Function

    Public Shared Function L_ObtenerAnhoFactura() As DataTable
        Dim _Tabla As DataTable
        Dim _Where As String = "1 = 1 ORDER BY year(fvafec)"
        _Tabla = D_Datos_Tabla("Distinct(year(fvafec)) AS anho",
                               "VR_GO_LibroVenta", _Where)
        Return _Tabla
    End Function

    Public Shared Function L_ObtenerSucursalesFactura() As DataTable
        Dim _Tabla As DataTable
        Dim _Where As String = "1 = 1 ORDER BY a.scneg"
        _Tabla = D_Datos_Tabla("a.scnumi, a.scneg, a.scnit",
                               "TS003 a", _Where)
        Return _Tabla
    End Function

#End Region


#Region "INGRESOS/EGRESOS"

    Public Shared Function L_prIngresoEgresoGeneral() As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 3))
        _listParam.Add(New Datos.DParametro("@ieuact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TIE001", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_prIngresoEgresoGrabar(ByRef _ienumi As String, _ieFecha As String, _ieTipo As String,
                                           _ieDescripcion As String, _ieConcepto As String, _ieMonto As Decimal,
                                           _ieObs As String, _ieTurno As Integer, _ieSucursal As Integer) As Boolean
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@ienumi", _ienumi))
        _listParam.Add(New Datos.DParametro("@ieFecha", _ieFecha))
        _listParam.Add(New Datos.DParametro("@ieTipo", _ieTipo))
        _listParam.Add(New Datos.DParametro("@ieDescripcion", _ieDescripcion))
        _listParam.Add(New Datos.DParametro("@ieConcepto", _ieConcepto))
        _listParam.Add(New Datos.DParametro("@ieMonto", _ieMonto))
        _listParam.Add(New Datos.DParametro("@ieObs", _ieObs))
        _listParam.Add(New Datos.DParametro("@ieEstado", 1))
        _listParam.Add(New Datos.DParametro("@ieTurno", _ieTurno))
        _listParam.Add(New Datos.DParametro("@ieSucursal", _ieSucursal))
        _listParam.Add(New Datos.DParametro("@ieuact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TIE001", _listParam)

        If _Tabla.Rows.Count > 0 Then
            _ienumi = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function

    Public Shared Function L_prIngresoEgresoBorrar(_numi As String, ByRef _mensaje As String) As Boolean

        Dim _resultado As Boolean

        If L_fnbValidarEliminacion(_numi, "TIE001", "ienumi", _mensaje) = True Then
            Dim _Tabla As DataTable

            Dim _listParam As New List(Of Datos.DParametro)

            _listParam.Add(New Datos.DParametro("@tipo", -1))
            _listParam.Add(New Datos.DParametro("@ienumi", _numi))
            _listParam.Add(New Datos.DParametro("@ieuact", L_Usuario))
            _Tabla = D_ProcedimientoConParam("sp_Mam_TIE001", _listParam)

            If _Tabla.Rows.Count > 0 Then
                _numi = _Tabla.Rows(0).Item(0)
                _resultado = True
            Else
                _resultado = False
            End If
        Else
            _resultado = False
        End If

        Return _resultado
    End Function

    Public Shared Function L_prIngresoEgresoModificar(ByRef _ienumi As String, _ieFecha As String, _ieTipo As String,
                                           _ieDescripcion As String, _ieConcepto As String, _ieMonto As Decimal,
                                           _ieObs As String) As Boolean
        Dim _resultado As Boolean
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 2))
        _listParam.Add(New Datos.DParametro("@ienumi", _ienumi))
        _listParam.Add(New Datos.DParametro("@ieFecha", _ieFecha))
        _listParam.Add(New Datos.DParametro("@ieTipo", _ieTipo))
        _listParam.Add(New Datos.DParametro("@ieDescripcion", _ieDescripcion))
        _listParam.Add(New Datos.DParametro("@ieConcepto", _ieConcepto))
        _listParam.Add(New Datos.DParametro("@ieMonto", _ieMonto))
        _listParam.Add(New Datos.DParametro("@ieObs", _ieObs))
        _listParam.Add(New Datos.DParametro("@ieEstado", 2))
        _listParam.Add(New Datos.DParametro("@ieuact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TIE001", _listParam)

        If _Tabla.Rows.Count > 0 Then
            _ienumi = _Tabla.Rows(0).Item(0)
            _resultado = True
        Else
            _resultado = False
        End If

        Return _resultado
    End Function
    Public Shared Function L_prIngresoEgresoPorFecha(fecha As String) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 4))
        _listParam.Add(New Datos.DParametro("@ieFecha", fecha))
        _listParam.Add(New Datos.DParametro("@ieuact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TIE001", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_prIngresoEgresoPorId(id As String) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 5))
        _listParam.Add(New Datos.DParametro("@ienumi", id))
        _listParam.Add(New Datos.DParametro("@ieuact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_TIE001", _listParam)

        Return _Tabla
    End Function
#End Region

#Region "ARQUEO DIARIO"
    Public Shared Function L_ArqueoDiarioTurno(fechaI As String, fechaF As String, turno As String, Sucursal As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 1))
        _listParam.Add(New Datos.DParametro("@fechaI", fechaI))
        _listParam.Add(New Datos.DParametro("@fechaF", fechaF))
        _listParam.Add(New Datos.DParametro("@turno", turno))
        _listParam.Add(New Datos.DParametro("@sucursal", Sucursal))
        _listParam.Add(New Datos.DParametro("@uact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_ArqueoDiario", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_DeterminarTurno() As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 2))
        _listParam.Add(New Datos.DParametro("@uact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_ArqueoDiario", _listParam)

        Return _Tabla
    End Function

    Public Shared Function L_DetalleAtencionDiarioTurno(fechaI As String, fechaF As String, turno As String, sucursal As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 3))
        _listParam.Add(New Datos.DParametro("@fechaI", fechaI))
        _listParam.Add(New Datos.DParametro("@fechaF", fechaF))
        _listParam.Add(New Datos.DParametro("@turno", turno))
        _listParam.Add(New Datos.DParametro("@sucursal", sucursal))
        _listParam.Add(New Datos.DParametro("@uact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_ArqueoDiario", _listParam)

        Return _Tabla
    End Function
#End Region
#Region "REPORTE STOCK MINIMO"
    Public Shared Function L_fnTodosAlmacenTodosLineasMenoresStock() As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 22))
        _listParam.Add(New Datos.DParametro("@yduact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("sp_Mam_SaldosProducto", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnUnaAlmacenTodosLineasMenoresStock(numialmacen As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 33))
        _listParam.Add(New Datos.DParametro("@yduact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@almacen", numialmacen))
        _Tabla = D_ProcedimientoConParam("sp_Mam_SaldosProducto", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnTodosAlmacenUnaLineasMenoresStock(numiLinea As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 44))
        _listParam.Add(New Datos.DParametro("@yduact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@linea", numiLinea))
        _Tabla = D_ProcedimientoConParam("sp_Mam_SaldosProducto", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnUnaAlmacenUnaLineasMenoresStock(numiLinea As Integer, CodAlmacen As Integer) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 55))
        _listParam.Add(New Datos.DParametro("@yduact", L_Usuario))
        _listParam.Add(New Datos.DParametro("@linea", numiLinea))
        _listParam.Add(New Datos.DParametro("@almacen", CodAlmacen))
        _Tabla = D_ProcedimientoConParam("sp_Mam_SaldosProducto", _listParam)

        Return _Tabla
    End Function
#End Region
















#Region "REPORTES"
    Public Shared Function L_fnMascotasAtendidas(fechaI As String, fechaF As String) As DataTable
        Dim _Tabla As DataTable

        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 20))
        _listParam.Add(New Datos.DParametro("@fechaI", fechaI))
        _listParam.Add(New Datos.DParametro("@fechaF", fechaF))
        _Tabla = D_ProcedimientoConParam("REG.sp_EMP002", _listParam)

        Return _Tabla
    End Function
    Public Shared Function L_fnUnVeterinario(fechaI As String, fechaF As String, Veterinario As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 26))
        _listParam.Add(New Datos.DParametro("@fechaI", fechaI))
        _listParam.Add(New Datos.DParametro("@fechaF", fechaF))
        _listParam.Add(New Datos.DParametro("@Veterinario", Veterinario))
        _Tabla = D_ProcedimientoConParam("REG.sp_EMP002", _listParam)
        Return _Tabla

    End Function

    Public Shared Function L_fnObtenerVeterinario() As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)

        _listParam.Add(New Datos.DParametro("@tipo", 21))
        '_listParam.Add(New Datos.DParametro("@yduact", L_Usuario))
        _Tabla = D_ProcedimientoConParam("REG.sp_EMP002", _listParam)

        Return _Tabla
    End Function

    Public Shared Function L_fnTodosPacientesPorDia(fechaI As String, fechaF As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 22))
        _listParam.Add(New Datos.DParametro("@fechaI", fechaI))
        _listParam.Add(New Datos.DParametro("@fechaF", fechaF))
        _Tabla = D_ProcedimientoConParam("REG.sp_EMP002", _listParam)
        Return _Tabla

    End Function

    Public Shared Function L_fnUnVeterinarioTodosGenero(fechaI As String, fechaF As String, Veterinario As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 23))
        _listParam.Add(New Datos.DParametro("@fechaI", fechaI))
        _listParam.Add(New Datos.DParametro("@fechaF", fechaF))
        _listParam.Add(New Datos.DParametro("@Veterinario", Veterinario))
        _Tabla = D_ProcedimientoConParam("REG.sp_EMP002", _listParam)
        Return _Tabla

    End Function

    Public Shared Function L_fnUnVeterinarioUnGenero(fechaI As String, fechaF As String, Veterinario As String, Genero As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 24))
        _listParam.Add(New Datos.DParametro("@fechaI", fechaI))
        _listParam.Add(New Datos.DParametro("@fechaF", fechaF))
        _listParam.Add(New Datos.DParametro("@Veterinario", Veterinario))
        _listParam.Add(New Datos.DParametro("@Genero", Genero))
        _Tabla = D_ProcedimientoConParam("REG.sp_EMP002", _listParam)
        Return _Tabla

    End Function

    Public Shared Function L_fnTodosVeterinarioUnGenero(fechaI As String, fechaF As String, Genero As String) As DataTable
        Dim _Tabla As DataTable
        Dim _listParam As New List(Of Datos.DParametro)
        _listParam.Add(New Datos.DParametro("@tipo", 25))
        _listParam.Add(New Datos.DParametro("@fechaI", fechaI))
        _listParam.Add(New Datos.DParametro("@fechaF", fechaF))
        _listParam.Add(New Datos.DParametro("@Genero", Genero))
        _Tabla = D_ProcedimientoConParam("REG.sp_EMP002", _listParam)
        Return _Tabla

    End Function
#End Region




















































End Class
