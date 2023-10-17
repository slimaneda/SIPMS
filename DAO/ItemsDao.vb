Imports System.Data.SqlClient
Imports System.IO

Public Class ItemsDao
    Public procedure As String
    Public Code_item As Integer
    Public Name_item As String
    Public DGV As DataGridView
    Public PictureBox1 As Image

    Sub Save_Update()
        sqlcon.Open()

        Using cmd As New SqlClient.SqlCommand(procedure, sqlcon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Code_item", SqlDbType.Int).Value = Code_item
            cmd.Parameters.Add("@Name_item", SqlDbType.NVarChar, 100).Value = Name_item

            If PictureBox1 IsNot Nothing Then
                Using ms As New MemoryStream()
                    PictureBox1.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                    cmd.Parameters.Add("@image", SqlDbType.Image).Value = ms.ToArray()
                End Using
            Else
                cmd.Parameters.Add("@image", SqlDbType.Image).Value = DBNull.Value
            End If
            cmd.ExecuteNonQuery()
            sqlcon.Close()
        End Using


    End Sub


    Sub Deletedata(Proc As String)
        Using cmd As New SqlClient.SqlCommand(Proc, sqlcon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Code_item", SqlDbType.Int).Value = Code_item
            cmd.ExecuteNonQuery()

        End Using
    End Sub
    Sub Searchdata(Proc As String)
        Using cmd As New SqlClient.SqlCommand(Proc, sqlcon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Name_item", SqlDbType.NVarChar, 100).Value = Name_item
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable
            dt.Clear()
            Dim da As New SqlClient.SqlDataAdapter(cmd)
            da.Fill(dt)
            DGV.DataSource = dt


        End Using

    End Sub



End Class
