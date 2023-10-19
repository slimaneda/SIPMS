Imports System.Data.SqlClient




Public Class SqlConnectionManager


    Public Shared Function ExecuteStoredProcedureWrite(procedureName As String, args As Dictionary(Of String, Object)) As Integer

        sqlcon_Open()
        Using cmd As New SqlCommand(procedureName, sqlcon)
            cmd.CommandType = CommandType.StoredProcedure

            For Each param As KeyValuePair(Of String, Object) In args
                cmd.Parameters.AddWithValue(param.Key, param.Value)
            Next
            cmd.ExecuteScalar()
            Return cmd.ExecuteNonQuery()
        End Using
        sqlcon_Close()

    End Function

    Public Shared Function ExecuteStoredProcedurescalar(procedureName As String, args As Dictionary(Of String, Object)) As Integer
        Dim result As Object = Nothing

        sqlcon_Open()
        Using cmd As New SqlCommand(procedureName, sqlcon)
            cmd.CommandType = CommandType.StoredProcedure

            For Each param As KeyValuePair(Of String, Object) In args
                cmd.Parameters.AddWithValue(param.Key, param.Value)
            Next

            result = cmd.ExecuteNonQuery()

            Return Result

        End Using

        sqlcon_Close()
    End Function


    'Reed 
    Public Shared Function ExecuteStoredProcedureRead(procedureName As String, args As Dictionary(Of String, Object)) As DataTable
        Dim dt As New DataTable

        Try
            sqlcon_Open()
            Using cmd As New SqlCommand(procedureName, sqlcon)
                cmd.CommandType = CommandType.StoredProcedure

                For Each param As KeyValuePair(Of String, Object) In args
                    cmd.Parameters.AddWithValue(param.Key, param.Value)
                Next

                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        Catch ex As Exception
        Finally
            sqlcon_Close()
        End Try

        Return dt
    End Function

End Class













