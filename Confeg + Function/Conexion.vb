Imports System.Data.SqlClient

Public Class Conexion

    Public Shared con As New SqlConnection(My.Settings.Sqlcon1)

    Public Shared Function conecta() As Boolean
        If con.State = ConnectionState.Open Then con.Close()
        Try
            con.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Public Shared Sub desconectar()
        If con.State = ConnectionState.Open Then con.Close()
    End Sub
End Class
