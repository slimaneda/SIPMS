Imports System.Data.SqlClient
Imports System.IO

Public Class ItemsDao
    Public procedure As String
    Public Code_item As Integer
    Public Name_item As String
    Public DGV As DataGridView
    Public PictureBox1 As Byte

    Public Function CreateItem(item As Item) As Integer
        Const procedureName As String = "Insert_Items"

        Dim args As New Dictionary(Of String, Object) From
        {
           {"@d1", item.Code_item},
           {"@d2", item.Name_item},
           {"@d3", item.photo}
        }

        Return SqlConnectionManager.ExecuteStoredProcedure(procedureName, args)
    End Function

    Public Function UpdateItem(item As Item) As Integer
        Const procedureName As String = "Update_Items"

        Dim args As New Dictionary(Of String, Object) From
        {
           {"@d1", item.Code_item},
           {"@d2", item.Name_item}
        }

        Return SqlConnectionManager.ExecuteStoredProcedure(procedureName, args)
    End Function

    Public Function DeleteItem(item As Item) As Integer
        Const procedureName As String = "Delete_Items"

        Dim args As New Dictionary(Of String, Object) From
        {
           {"@d1", item.Code_item}
        }
        Return SqlConnectionManager.ExecuteStoredProcedure(procedureName, args)
    End Function


    Public Function SearchItem(item As Item) As Integer
        Const procedureName As String = "Delete_Items"

        Dim args As New Dictionary(Of String, Object) From
        {
           {"@d2", item.Name_item}
        }
        Return SqlConnectionManager.ExecuteStoredProcedure(procedureName, args)
    End Function







End Class
