Class CustomerAccDAL
    Friend Property CustomerId As Integer
    Friend Property CustomerName As String
    Friend Property Detail As String
    Friend Property Inv As Date
    Friend Property Debit As Decimal
    Friend Property Credit As Decimal
    Friend Property Balance As Decimal



    Public Function insert(f As CustomerAccDAL)
        Const proc As String = "insert_custacc"
        Dim args As New Dictionary(Of String, Object) From
            {
            {"@d1", f.CustomerId},
            {"@d2", f.CustomerName},
            {"@d3", f.Inv},
            {"@d4", f.Detail},
             {"@d5", f.Debit},
            {"@d6", f.Credit},
            {"@d7", f.Balance}
        }
        Return SqlConnectionManager.ExecuteWrite(proc, args)
    End Function
End Class
