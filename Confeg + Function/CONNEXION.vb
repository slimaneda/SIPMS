Imports System.Data.SqlClient



Module CONNEXION

    Public sqlcon As New SqlConnection
    Public Sub sqlcon_Open()
        If sqlcon.State = 1 Then sqlcon.Close()
        Try
            sqlcon = New SqlConnection(My.Settings.Sqlcon1)
            sqlcon.Open()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
    Public Sub sqlcon_Close()
        If sqlcon.State = 1 Then sqlcon.Close()
    End Sub
End Module
