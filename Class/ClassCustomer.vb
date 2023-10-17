Imports System.Data.SqlClient

Imports System.IO
Public Class ClassCustomer

    Public code As Integer
    Public Name As String
    Public Gender As String
    Public Adress As String
    Public City As String
    Public Zip As String
    Public state As String
    Public Contact As String

    Public Email As String
    Public Notes As String
    Public PictureBox1 As Image


    Sub Save_Update(proc As String)
        sqlcon.Open()

        Using cmd As New SqlCommand(proc, sqlcon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Customerid", SqlDbType.Int).Value = code
            cmd.Parameters.Add("@CustomerName", SqlDbType.NVarChar, 50).Value = Name
            cmd.Parameters.Add("@Gender", SqlDbType.NVarChar, 50).Value = Gender
            cmd.Parameters.Add("@adress", SqlDbType.NVarChar, 50).Value = Adress
            cmd.Parameters.Add("@city", SqlDbType.NVarChar, 50).Value = City
            cmd.Parameters.Add("@zip", SqlDbType.NVarChar, 50).Value = Zip
            cmd.Parameters.Add("@contact", SqlDbType.NVarChar, 50).Value = Contact
            cmd.Parameters.Add("@email", SqlDbType.NVarChar, 50).Value = Email
            cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 200).Value = Notes
            cmd.Parameters.Add("@state", SqlDbType.NVarChar, 50).Value = state

            If PictureBox1 IsNot Nothing Then
                Using ms As New MemoryStream()
                    PictureBox1.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                    cmd.Parameters.Add("@photo", SqlDbType.Image).Value = ms.ToArray()
                End Using
            Else
                cmd.Parameters.Add("@photo", SqlDbType.Image).Value = DBNull.Value
            End If
            cmd.ExecuteNonQuery()
            sqlcon.Close()
        End Using


        sqlcon.close

    End Sub

    Sub DeleteData(Proc)
        sqlcon.Open()
        Using cmd As New SqlClient.SqlCommand(Proc, sqlcon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Customerid", SqlDbType.Int).Value = code
            cmd.ExecuteNonQuery()
            MsgBox("delete terminee")
        End Using
        sqlcon.Close()
    End Sub
    Sub Search_Name(Proc As String, DGV As DataGridView)
        Using cmd As New SqlClient.SqlCommand(Proc, sqlcon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CustomerName", SqlDbType.NVarChar, 50).Value = Name
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable
            dt.Clear()
            Dim da As New SqlClient.SqlDataAdapter(cmd)
            da.Fill(dt)
            DGV.DataSource = dt.DefaultView
        End Using
    End Sub
End Class
