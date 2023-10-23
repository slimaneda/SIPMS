Imports System.Data.SqlClient


Public Class SqlConnectionManager
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

    'End Class

    Public Shared Function ExecuteScalar(query As String, parameters As Dictionary(Of String, Object)) As Object
        Conexion.conecta()
        Using cmd As New SqlCommand(query, Conexion.con)
            cmd.CommandType = CommandType.StoredProcedure
            For Each param In parameters
                cmd.Parameters.AddWithValue(param.Key, param.Value)
            Next

            Return cmd.ExecuteScalar()
        End Using

    End Function

    'Reed 
    Public Shared Function ExecuteStoredProcedureRead(procedureName As String, args As Dictionary(Of String, Object)) As DataTable
        Dim dt As New DataTable
        Conexion.conecta()
        Try

            Using cmd As New SqlCommand(procedureName, Conexion.con)
                cmd.CommandType = CommandType.StoredProcedure

                For Each param As KeyValuePair(Of String, Object) In args
                    cmd.Parameters.AddWithValue(param.Key, param.Value)
                Next
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        Catch ex As Exception
        Finally

        End Try

        Return dt
    End Function

End Class













