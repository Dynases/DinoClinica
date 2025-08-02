Imports System.Data
Imports System.Data.SqlClient   'Lib para conexion con SQL Server
Imports System.Windows.Forms

Public Class MetodoDatos
    Public Shared Function CrearComando(Optional Ip As String = "", Optional UsuarioSql As String = "", Optional ClaveSql As String = "", Optional NombreBD As String = "") As SqlCommand

        Dim _cadenaConexion = Configuracion.CadenaConexion(Ip, UsuarioSql, ClaveSql, NombreBD)
        Dim _conexion As New SqlConnection() 'SqlConnection()
        _conexion.ConnectionString = _cadenaConexion
        Dim _comando As New SqlCommand() 'SqlCommand()
        _comando = _conexion.CreateCommand()
        _comando.CommandType = CommandType.Text
        'abrir
        Try
            'Abrimos la conexión
            'Si se estableció conexión correctamente abrirá conexión
            _comando.Connection.Open()


        Catch ex As Exception
            'Si no se conecta nos mostrara el siguiente mensaje
            MessageBox.Show("No se pudo conectar a la Base de Datos")
            _comando.Connection.Close()


        End Try

        Return _comando



    End Function
    Public Shared Function CrearComandoProcedimiento(Optional Ip As String = "", Optional UsuarioSql As String = "", Optional ClaveSql As String = "", Optional NombreBD As String = "") As SqlCommand
        Dim _cadenaConexion = Configuracion.CadenaConexion(Ip, UsuarioSql, ClaveSql, NombreBD)
        Dim _conexion As New SqlConnection() 'SqlConnection()
        _conexion.ConnectionString = _cadenaConexion
        Dim _comando As New SqlCommand() 'SqlCommand()
        _comando = _conexion.CreateCommand()
        _comando.CommandType = CommandType.StoredProcedure
        'abrir
        Try
            'Abrimos la conexión
            _comando.Connection.Open()
            'Si se estableció conexión correctamente abrirá conexión
        Catch ex As Exception
            'Si no se conecta nos mostrara el siguiente mensaje
            'MsgBox("No se pudo conectar a la Base de Datos ")
            _comando.Connection.Close()
        End Try

        Return _comando
    End Function

    Public Shared Function EjecutarComandoSelect(Comando As SqlCommand) As DataTable
        Dim _tabla As New DataTable()
        Try
            'Comando.Connection.Open()
            Dim _adaptador As New SqlDataAdapter 'SqlDataAdapter()
            _adaptador.SelectCommand = Comando

            _adaptador.Fill(_tabla)
        Catch ex As Exception
            If Comando.Connection.State = False Then
                Comando.Connection.Open()
                EjecutarComandoSelect(Comando)
            Else
                MsgBox(ex.Message)
            End If
            'Finally
            '    Comando.Connection.Close()
        End Try
        Return _tabla
    End Function

    Public Shared Function EjecutarInsert(Comando As SqlCommand) As Boolean
        Dim _tabla As New DataTable()
        Dim _Err As Boolean = False

        Try
            'Comando.Connection.Open()
            Comando.ExecuteNonQuery()
        Catch ex As Exception
            If Comando.Connection.State = False Then
                Comando.Connection.Open()
                EjecutarInsert(Comando)
            Else
                MsgBox(ex.Message)
                _Err = True
            End If
            'Finally
            '    Comando.Connection.Close()
        End Try
        Return _Err
    End Function

    Public Shared Function EjecutarProcedimiento(Comando As SqlCommand) As DataTable
        Dim _tabla As New DataTable()
        Try
            'Comando.Connection.Open()
            Dim _adaptador As New SqlDataAdapter 'SqlDataAdapter()
            _adaptador.SelectCommand = Comando
            Comando.CommandTimeout = 0
            _adaptador.Fill(_tabla)
        Catch ex As Exception
            If Comando.Connection.State = False Then
                Comando.Connection.Open()
                EjecutarProcedimiento(Comando)
            Else
                MsgBox(ex.Message)

            End If
            'Finally
            '    Comando.Connection.Close()
        End Try
        Return _tabla
    End Function

End Class
