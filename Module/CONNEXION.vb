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
    Public Function CODE_GEN(TbL_name, ID_) As Integer
        CODE_GEN = 0
        Dim dt As New DataTable
        Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM " & TbL_name & " ORDER BY " & ID_, sqlcon)
        da.Fill(dt)

        If dt.Rows.Count <> 0 Then
            Dim I = dt.Rows.Count - 1
            CODE_GEN = Val(dt.Rows(I).Item(ID_))
        End If
    End Function

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
