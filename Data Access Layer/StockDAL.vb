Imports System.Text.Json

Public Class StockDAL



    Public Function buildArgements(stock As Stock) As Dictionary(Of String, Object)
        Return New Dictionary(Of String, Object) From
       {
             {"@d1", stock.CodeStock},
             {"@Code_Stocktble", stock.CodeStockvisible},
             {"@InvoiceDate", stock.InvoiceDate},
             {"@Code_Supplier", stock.Code_Supplier},
             {"@Name_Supplier", stock.Name_Supplier},
             {"@Code_Product", stock.Code_Product},
             {"@Name_Product", stock.Name_Product},
             {"@Quantity_Pt", stock.Quantity_Pt},
             {"@Price_Pt", stock.Price_Pt},
              {"@TOTALPayement", stock.TOTALPayement},
               {"@TOTALPayementdue", stock.TOTALPayementdue},
                {"@NOTES", stock.NOTES},
                {"@Totalmount", stock.Totalamont}
                }
    End Function
    Public Function Create(stock As Stock) As Integer
        Const procedureName As String = "Temp_Stock"
        Dim args As Dictionary(Of String, Object) = buildArgements(stock)
        Return SqlConnectionManager.ExecuteStoredProcedureWrite(procedureName, args)
    End Function

    Public Function Update(stock As Stock) As Integer
        Const procedureName As String = "update"
        Dim args As Dictionary(Of String, Object) = buildArgements(stock)
        Return SqlConnectionManager.ExecuteStoredProcedureWrite(procedureName, args)
    End Function

    Public Function Reed(stock As Stock, NumSelect_Procedure As String) As Integer

        Dim args As New Dictionary(Of String, Object) From
       {
             {"@d1", stock.CodeStock}
             }
        Return SqlConnectionManager.ExecuteStoredProcedurescalar(NumSelect_Procedure, args)
    End Function

    Public Function Delete(stock As Stock) As Integer
        Const procedureName As String = "Deletedata"
        Dim args As New Dictionary(Of String, Object) From
       {
             {"@d1", stock.CodeStock},
           {"@type", "STOCK"}
             }
        Return SqlConnectionManager.ExecuteStoredProcedureWrite(procedureName, args)
    End Function
End Class
