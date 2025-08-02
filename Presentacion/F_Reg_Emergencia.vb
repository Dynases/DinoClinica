Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX
Imports System.IO
Imports DevComponents.DotNetBar.Controls
Public Class F_Reg_Emergencia
#Region "Variables"
    Public _Tabla As DataTable
    Public _resultado As Boolean = False
#End Region
#Region "Eventos"
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        _resultado = False
        Me.Close()
    End Sub
    Private Sub btnAsignarEmergencia_Click(sender As Object, e As EventArgs) Handles btnAsignarEmergencia.Click
        'Verificar si el usuario tiene permisos de Emergencia.
        If L_fnExisteUsuarioEmergencia(txtUsuario.Text, txtContraseña.Text) Then
            Dim _faId As String = "" 'Codigo de ficha
            L_fnGrabarFichaAtencion(_faId, _Tabla)
            _resultado = True
            Me.Close()
            _prOrdenarEmergencia()
        Else
            Dim img2 As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "El usuario no tiene permisos de emergencia.".ToUpper, img2, 2000, eToastGlowColor.Red, eToastPosition.TopCenter)
        End If

    End Sub
#End Region
#Region "Metodos Privados"
    Private Sub _prOrdenarEmergencia()
        Dim _tabla As DataTable = L_fnMostrarListaFichaAtencion()
        Dim prioridad As Integer = 0
        For Each fila As DataRow In _tabla.Rows
            prioridad = prioridad + 1
            L_fnOrdenarFichaAtencion(fila.Item("faid"), prioridad)
        Next
    End Sub

    Private Sub txtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress, txtContraseña.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
#End Region
End Class