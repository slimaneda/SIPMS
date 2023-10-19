Public Class TempStockDAL
    Dim tempStock As TempStock
    Public Function Create(tempStock As TempStock) As Integer
        Const procedureName As String = "TempStock"
        Dim args As New Dictionary(Of String, Object) From
        {
        {"TYPE", "INSERT"},
            {"Product_ID", tempStock.Code_Product},
            {"Quantity", tempStock.Quantity_Pt}
        }
        Return SqlConnectionManager.ExecuteStoredProcedureWrite(procedureName, args)
    End Function

    Public Function Update(tempStock As TempStock) As Integer
        Const procedureName As String = "TempStock"
        Dim args As New Dictionary(Of String, Object) From
            {
            {"TYPE", "UPDATE"},
            {"Product_ID", tempStock.Code_Product},
            {"Quantity", tempStock.Quantity_Pt}
        }
        Return SqlConnectionManager.ExecuteStoredProcedureWrite(procedureName, args)
    End Function

    Public Function Reed(tempStock As TempStock) As Integer
        Const procedureName As String = "TempStock"
        Dim args As New Dictionary(Of String, Object) From
       {
            {"TYPE", "SELECT"},
            {"Product_ID", tempStock.Code_Product}
             }
        Return SqlConnectionManager.ExecuteStoredProcedurescalar(procedureName, args)
    End Function

    Public Function Delete(tempStock As TempStock) As Integer
        Const procedureName As String = "Deletedata"
        Dim args As New Dictionary(Of String, Object) From
       {
             {"TYPE", "DELETE"},
            {"Product_ID", tempStock.Code_Product}
             }
        Return SqlConnectionManager.ExecuteStoredProcedureWrite(procedureName, args)
    End Function
End Class
