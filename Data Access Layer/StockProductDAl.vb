Public Class StockProductDAl


    ' add 
    Public Function Create(StockProduct As StockProduct) As Integer
        Const proc As String = "StockProduct"
        Dim agrs As New Dictionary(Of String, Object) From
            {
            {"@type", "INSERT"},
            {"d1", StockProduct.StockID},
             {"@d2", StockProduct.ProductID},
              {"d3", StockProduct.ProductName},
               {"d4", StockProduct.Qty},
            {"d5", StockProduct.Price},
            {"d6", StockProduct.TotalAmount}
        }
        Return SqlConnectionManager.ExecuteWrite(proc, agrs)
    End Function

End Class
