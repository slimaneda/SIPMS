Public Class CompanyDAL


    Public Function Insertar(company As Company) As Integer
        Const proc As String = "Insert_Company"
        Dim args As New Dictionary(Of String, Object) From
                    {
                    {"@Name_Company", company.Name_Company},
                    {"@Adress", company.adress},
                    {"@Contact", company.Contact},
                    {"@Email", company.EMail},
                    {"@TIN", company.TIN},
                    {"@ST", company.ST},
                    {"@CIN", company.CIN},
                    {"@photo", company.photo}
        }
        Return SqlConnectionManager.ExecuteWrite(proc, args)
    End Function




End Class
