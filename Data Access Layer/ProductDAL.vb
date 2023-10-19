Public Class ProductDAL
    Public Function buildArgements(product As Product) As Dictionary(Of String, Object)
        Return New Dictionary(Of String, Object) From
       {
             {"@Product_ID", product.Code},
             {"@Product_Name", product.Name},
             {"@Item", product.items},
             {"@Min_record", product.minirecord},
             {"@Quantity", product.Quantity}
        }
    End Function

    Public Function create(product As Product) As Integer
        Const procedureName As String = "Insert_Product"
        Dim args As Dictionary(Of String, Object) = buildArgements(product)
        Return SqlConnectionManager.ExecuteStoredProcedureWrite(procedureName, args)
    End Function

    Public Function Update(product As Product) As Integer
        Const procedureName As String = "Update_Product"
        Dim args As Dictionary(Of String, Object) = buildArgements(product)
        Return SqlConnectionManager.ExecuteStoredProcedureWrite(procedureName, args)
    End Function

    Public Function Delete(product As Product) As Integer
        Const procedureName As String = "Deletedata"
        Dim args As New Dictionary(Of String, Object) From
       {
             {"@d1", product.Code},
           {"@type", "Product"}
             }
        Return SqlConnectionManager.ExecuteStoredProcedureWrite(procedureName, args)
    End Function
End Class
