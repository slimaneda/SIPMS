

Imports System.Data.SqlClient

Public Class SqlCon
    Inherits Conexion

    Public Shared Function ExecuteWrite(procedureName As String, args As Dictionary(Of String, Object)) As Integer
        Conexion.conecta()

        Using cmd As New SqlCommand(procedureName, Conexion.con)
            cmd.CommandType = CommandType.StoredProcedure

            For Each param As KeyValuePair(Of String, Object) In args
                cmd.Parameters.AddWithValue(param.Key, param.Value)
            Next

            Dim Result As Integer = cmd.ExecuteNonQuery()
            Return Result
        End Using
    End Function

End Class

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
        Return SqlCon.ExecuteWrite(procedureName, args)
    End Function

    Public Function Update(product As Product) As Integer
        Const procedureName As String = "Update_Product"
        Dim args As Dictionary(Of String, Object) = buildArgements(product)
        Return SqlConnectionManager.ExecuteWrite(procedureName, args)
    End Function

    Public Function Delete(product As Product) As Integer
        Const procedureName As String = "Deletedata"
        Dim args As New Dictionary(Of String, Object) From
       {
             {"@d1", product.Code},
           {"@type", "Product"}
             }
        Return SqlConnectionManager.ExecuteWrite(procedureName, args)
    End Function
End Class
