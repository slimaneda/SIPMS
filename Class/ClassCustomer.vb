Imports System.Data.SqlClient

Imports System.IO
Public Class ClassCustomer
    Public Proc As String
    Public code As Integer
    Public Name As String
    Public Gender As String
    Public Adress As String
    Public City As String
    Public Zip As String
    Public Contact As String

    Public Email As String
    Public Notes As String
    Public Photofrst As Image

    Sub Save_Update()
        Using cmd As New SqlClient.SqlCommand(Proc, sqlcon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@[Customer ID ]", SqlDbType.Int).Value = code
            cmd.Parameters.Add("@[Customer Name ]", SqlDbType.NVarChar, 50).Value = Name
            cmd.Parameters.Add("@[Gender]", SqlDbType.NVarChar, 50).Value = Gender
            cmd.Parameters.Add("@[Adress]", SqlDbType.NVarChar, 50).Value = Adress
            cmd.Parameters.Add("@[City]", SqlDbType.NVarChar, 50).Value = CIty
            cmd.Parameters.Add("@[Zip Code]", SqlDbType.Int).Value = ZIp
            cmd.Parameters.Add("@[Contacte N°]", SqlDbType.Int).Value = COntact
            cmd.Parameters.Add("@[Email ID]", SqlDbType.NVarChar, 50).Value = Email
            cmd.Parameters.Add("@[Notes]", SqlDbType.NVarChar, 1000).Value = Notes

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
    End Sub

End Class
