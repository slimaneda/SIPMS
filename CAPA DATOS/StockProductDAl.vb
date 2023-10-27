Public Class StockProductDAl


    Public Function Insertar(StockProduct As StockProduct) As Integer
        Const proc As String = "StockProduct"
        Dim agrs As New Dictionary(Of String, Object) From
            {
            {"@d1", StockProduct.StockID},
             {"@d2", StockProduct.ProductID},
              {"d3", StockProduct.ProductName},
               {"@d4", StockProduct.Qty},
            {"@d5", StockProduct.Price},
            {"@d6", StockProduct.TotalAmount}
        }
        Return SqlConnectionManager.ExecuteWrite(proc, agrs)
    End Function
    Public Function Insertars(StockProduct As StockProduct) As Integer
        Const proc As String = "StockProducta"
        Dim agrs As New Dictionary(Of String, Object) From
            {
             {"@d1", StockProduct.ProductID},
              {"@d2", StockProduct.ProductName},
               {"@d3", StockProduct.Qty}
        }
        Return SqlConnectionManager.ExecuteWrite(proc, agrs)
    End Function

End Class
