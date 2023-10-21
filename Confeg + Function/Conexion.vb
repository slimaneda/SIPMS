Imports System.Data.SqlClient

Public Class Conexion

    Protected con As New SqlConnection(My.Settings.Sqlcon1)

    Public Function conecta() As Boolean

        If con.State = 1 Then con.Close()
        Try
            con.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
        End
    End Function

    Public Sub desconectar()
        If con.State = 1 Then con.Close()
    End Sub
End Class
