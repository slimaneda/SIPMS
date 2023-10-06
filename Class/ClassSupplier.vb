Imports System.IO

Public Class ClassSupplier
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
    Public Photofrst As Image


    Sub Save_Update(proc As String)
        Try
            Using cmd As New SqlClient.SqlCommand(proc, sqlcon)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Supplierid", SqlDbType.Int).Value = code
                cmd.Parameters.Add("@SupplierName", SqlDbType.NVarChar, 50).Value = Name
                cmd.Parameters.Add("@Gender", SqlDbType.NVarChar, 50).Value = Gender
                cmd.Parameters.Add("@adress", SqlDbType.NVarChar, 50).Value = Adress
                cmd.Parameters.Add("@city", SqlDbType.NVarChar, 50).Value = City
                cmd.Parameters.Add("@zip", SqlDbType.Int).Value = Zip
                cmd.Parameters.Add("@contact", SqlDbType.Int).Value = Contact
                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 50).Value = Email
                cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 1000).Value = Notes
                cmd.Parameters.Add("@state", SqlDbType.NVarChar, 1000).Value = state
                If FormCompany.PictureBox1.Image IsNot Nothing Then
                    Using ms As New MemoryStream()
                        FormCompany.PictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) ' افترض أن الصورة هي JPEG
                        cmd.Parameters.Add("@photo", SqlDbType.Image).Value = ms.ToArray()
                    End Using
                Else
                    cmd.Parameters.Add("@photo", SqlDbType.Image).Value = Photofrst
                End If


                cmd.ExecuteNonQuery()

            End Using
        Catch ex As Exception

        End Try



    End Sub

    Sub DeleteData(Proc)
        Using cmd As New SqlClient.SqlCommand(Proc, sqlcon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Customerid", SqlDbType.Int).Value = code
            cmd.ExecuteNonQuery()
        End Using
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
