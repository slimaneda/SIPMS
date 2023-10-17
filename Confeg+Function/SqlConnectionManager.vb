Imports System.Data.SqlClient




Public Class SqlConnectionManager


    Public Shared Function ExecuteStoredProcedure(procedureName As String, args As Dictionary(Of String, Object)) As Integer
        sqlcon.Open()

        Using cmd As New SqlCommand(procedureName, sqlcon)
            cmd.CommandType = CommandType.StoredProcedure

            For Each param As KeyValuePair(Of String, Object) In args
                cmd.Parameters.AddWithValue(param.Key, param.Value)
            Next

            Return cmd.ExecuteNonQuery()
        End Using
        sqlcon.Close()

    End Function
End Class













