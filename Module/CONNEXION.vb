Imports System.Data.SqlClient



Module CONNEXION

    Public sqlcon As New SqlConnection
    Public Sub Open_connexion()
        If sqlcon.State = 1 Then sqlcon.Close() 'Si una conexión está abierta, ciérrela
        Try
            sqlcon = New SqlConnection(My.Settings.Sqlcon1)
            sqlcon.Open()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    ' num auto








End Module
