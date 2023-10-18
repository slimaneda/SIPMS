Public Class ItemsDAL


    Public Function Create(item As Item) As Integer
        Const procedureName As String = "Insert_Items"

        Dim args As New Dictionary(Of String, Object) From
        {
           {"@d1", item.Code_item},
           {"@d2", item.Name_item},
           {"@d3", item.photo}
        }

        Return SqlConnectionManager.ExecuteStoredProcedureWrite(procedureName, args)
    End Function

    Public Function Update(item As Item) As Integer
        Const procedureName As String = "Update_Items"

        Dim args As New Dictionary(Of String, Object) From
        {
           {"@d1", item.Code_item},
           {"@d2", item.Name_item}
        }

        Return SqlConnectionManager.ExecuteStoredProcedureWrite(procedureName, args)
    End Function

    Public Function Delete(item As Item) As Integer
        Const procedureName As String = "Delete_Items"

        Dim args As New Dictionary(Of String, Object) From
        {
           {"@d1", item.Code_item}
        }
        Return SqlConnectionManager.ExecuteStoredProcedureWrite(procedureName, args)
    End Function




    Public Function Search(item As Item) As Integer
        Const procedureName As String = "Search_item"

        Dim args As New Dictionary(Of String, Object) From
    {
        {"@d2", item.Name_item}
    }

        Dim resultTable As DataTable = SqlConnectionManager.ExecuteStoredProcedureRead(procedureName, args)

        If resultTable IsNot Nothing AndAlso resultTable.Rows.Count > 0 Then
            Dim resultRow As DataRow = resultTable.Rows(0)
            If resultRow(0) IsNot DBNull.Value Then
                Return CInt(resultRow(0))
            End If

        End If
        ' Return a default value or handle the case when no result is found
        Return 0
    End Function





End Class
