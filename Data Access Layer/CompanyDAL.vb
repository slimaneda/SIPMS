Imports System.Data.SqlClient
Imports System.IO

Public Class CompanyDAL
    Inherits Conexion
    Private cmd As New SqlCommand



    Public Property Name_company As String
    Public Property Adress As String
    Public Property Contact As String
    Public Property Email As String
    Public Property TIN As String
    Public Property ST As String
    Public Property CIN As String
    Sub Save(Num_Procedure As String)
        Conexion.conecta()

        Try
            Using cmd As New SqlClient.SqlCommand(Num_Procedure, Conexion.con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Name_Company", SqlDbType.NVarChar, 50).Value = Name_company
                cmd.Parameters.Add("@Adress", SqlDbType.NVarChar, 50).Value = Adress
                cmd.Parameters.Add("@Contact", SqlDbType.Int).Value = Contact
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = Email
                cmd.Parameters.Add("@TIN", SqlDbType.NVarChar, 50).Value = TIN
                cmd.Parameters.Add("@ST", SqlDbType.NVarChar, 50).Value = ST
                cmd.Parameters.Add("@CIN", SqlDbType.NVarChar, 50).Value = CIN


                If FormCompany.PictureBox1.Image IsNot Nothing Then
                    Using ms As New MemoryStream()
                        FormCompany.PictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) ' افترض أن الصورة هي JPEG
                        cmd.Parameters.Add("@photo", SqlDbType.Image).Value = ms.ToArray()
                    End Using
                Else
                    cmd.Parameters.Add("@photo", SqlDbType.Image).Value = DBNull.Value
                End If

                cmd.ExecuteNonQuery()
            End Using


            Using dt As New DataTable
                Dim da As New SqlClient.SqlDataAdapter("Select_Company", Conexion.con)
                da.Fill(dt)
                FormCompany.DGV1.DataSource = dt.DefaultView
            End Using



        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub
    Public Sub DeleteCompany(proc As String)
        Conexion.conecta()

        Try

            cmd = New SqlCommand(proc, Conexion.con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Name_Company", SqlDbType.NVarChar, 50).Value = FormCompany.txt_Companyname.Text


            cmd.ExecuteNonQuery()




            MsgBox("delete Company .", MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error)

        End Try
    End Sub



End Class
