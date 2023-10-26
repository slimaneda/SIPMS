Public Class SalesDAL



    Public Function insert(sales As Sales) As Integer
        Const proc As String = "insert_Sales"
        Dim args As New Dictionary(Of String, Object) From
            {
            {"@type", "insert"},
            {"@saleCode", sales.SaleCode}
            }
        Return SqlConnectionManager.ExecuteWrite(proc, args)
    End Function
End Class
