Public Class StockDAL


    Public Function buildArgements(stock As Iventory) As Dictionary(Of String, Object)
        Return New Dictionary(Of String, Object) From
   {
             {"@code_fct", stock.CodeStock},
             {"@Code_Stocktble", stock.CodeStockvisible},
             {"@InvoiceDate", stock.InvoiceDate},
             {"@Code_Supplier", stock.Code_Supplier},
             {"@Name_Supplier", stock.Name_Supplier},
             {"@Code_Product", stock.Code_Product},
             {"@Name_Product", stock.Name_Product},
             {"@Quantity_Pt", stock.Quantity_Pt},
             {"@Price_Pt", stock.Price_Pt},
              {"@Total_Payement", stock.TOTALPayement},
               {"@Rest_NonPayement", stock.Rest_NonPayement},
                {"@NOTES", stock.NOTES},
                {"@Totalmount", stock.Totalamont}
                }
    End Function


    Public Function Insertar(stock As Iventory) As Integer
        Const procedureName As String = "_STOCK"
        Dim args As Dictionary(Of String, Object) = buildArgements(stock)
        args.Add("@Type", "insert")
        Return SqlConnectionManager.ExecuteWrite(procedureName, args)
    End Function

    Public Function Update(stock As Iventory) As Integer
        Const procedureName As String = "-Stock"
        Dim args As Dictionary(Of String, Object) = buildArgements(stock)
        args.Add("@Type", "update")
        Return SqlConnectionManager.ExecuteWrite(procedureName, args)
    End Function

    Public Function Reed(stock As Iventory) As Integer
        Const procedureName As String = "_Stock_Product"
        Dim args As New Dictionary(Of String, Object) From
       {
             {"@d1", stock.CodeStock},
              {"@type", "Select_d1"}
             }
        Return SqlConnectionManager.ExecuteWrite(procedureName, args)
    End Function

    Public Function Delete(stock As Iventory) As Integer
        Const procedureName As String = "Deletedata"
        Dim args As New Dictionary(Of String, Object) From
       {
             {"@d1", stock.CodeStock},
           {"@type", "STOCK"}
             }
        Return SqlConnectionManager.ExecuteWrite(procedureName, args)
    End Function



    Public Function ColumnExists(columnName As String, stock As Iventory) As Boolean
        If String.IsNullOrEmpty(columnName) OrElse String.IsNullOrEmpty(stock.CodeStock) Then
            Return False
        End If

        Dim query As String = $"SELECT COUNT(*) FROM Stock WHERE {columnName} = @valueToCheck"

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@valueToCheck", stock.CodeStock}
        }

        Dim count As Integer = Convert.ToInt32(SqlConnectionManager.ExecuteScalar(query, parameters))
        Return count > 0
    End Function





End Class
