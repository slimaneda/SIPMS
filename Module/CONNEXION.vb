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


    Public Sub Show_DGV(DGV As DataGridView, num_Proc As String)
        Open_connexion()
        Try
            Using dt As New DataTable
                dt.Clear()
                Dim da As New SqlClient.SqlDataAdapter(num_Proc, sqlcon)
                da.Fill(dt)
                DGV.DataSource = dt.DefaultView
            End Using

        Catch ex As Exception
        End Try
    End Sub
End Module
