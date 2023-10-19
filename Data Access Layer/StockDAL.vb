Imports System.Text.Json

Public Class StockDAL
    '       @Code_fct int,
    '@Code_Stocktble nvarchar(50),
    '@InvoiceDate nvarchar(50),
    '@Code_Supplier int,
    '@Name_Supplier nvarchar(50),
    '@Code_Product int,
    '@Name_Product nvarchar(50),
    '@Quantity_Pt decimal(18, 2),
    '@Price_Pt decimal(18,2),
    '@Total decimal(18,2),  '''''''' total amont
    '@Notes nvarchar(max),
    '@Total_Payement decimal(18,2), 'don
    '@Rest_NonPayement decimal(18,2)


    Public Function buildArgements(stock As Stock) As Dictionary(Of String, Object)
        Return New Dictionary(Of String, Object) From
   {
             {"@code_fct", stock.CodeStock}, 'do
             {"@Code_Stocktble", stock.CodeStockvisible}, 'don
             {"@InvoiceDate", stock.InvoiceDate}, 'don
             {"@Code_Supplier", stock.Code_Supplier}, 'don
             {"@Name_Supplier", stock.Name_Supplier}, 'don
             {"@Code_Product", stock.Code_Product}, 'don
             {"@Name_Product", stock.Name_Product},   'don              
             {"@Quantity_Pt", stock.Quantity_Pt}, 'don
             {"@Price_Pt", stock.Price_Pt}, 'don
              {"@TOTALPayement", stock.TOTALPayement}, 'don
               {"@Rest_NonPayement", stock.Rest_NonPayement},
                {"@NOTES", stock.NOTES},  'don
                {"@Totalmount", stock.Totalamont}
                }
    End Function
    Public Function Create(stock As Stock) As Integer
        Const procedureName As String = "_STOCK"
        Dim args As Dictionary(Of String, Object) = buildArgements(stock)
        args.Add("@Type", "insert")
        Return SqlConnectionManager.ExecuteStoredProcedureWrite(procedureName, args)
    End Function

    Public Function Update(stock As Stock) As Integer
        Const procedureName As String = "-Stock"
        Dim args As Dictionary(Of String, Object) = buildArgements(stock)
        args.Add("@Type", "update")
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
