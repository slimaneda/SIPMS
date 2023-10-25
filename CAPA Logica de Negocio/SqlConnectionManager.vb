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


    Public Shared Function DataExists(procedureName As String, args As Dictionary(Of String, Object)) As Boolean
        Conexion.conecta()

        Using cmd As New SqlCommand(procedureName, Conexion.con)
            cmd.CommandType = CommandType.StoredProcedure

            For Each param As KeyValuePair(Of String, Object) In args
                cmd.Parameters.AddWithValue(param.Key, param.Value)
            Next

            Dim Result As Object = cmd.ExecuteScalar()
            Return (Result IsNot Nothing AndAlso Result IsNot DBNull.Value)
        End Using
    End Function

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
    Public Shared Function ExecuteStoredProcedureRead(args As Dictionary(Of String, Object)) As SqlDataReader
        Conexion.conecta()

        Dim da As SqlDataReader = Nothing ' Move the declaration outside the Using block

        Try
            Using cmd As New SqlCommand("sellect", Conexion.con)
                cmd.CommandType = CommandType.StoredProcedure

                For Each param As KeyValuePair(Of String, Object) In args
                    cmd.Parameters.AddWithValue(param.Key, param.Value)
                Next

                da = cmd.ExecuteReader()
            End Using
        Catch ex As Exception
            ' Handle your exception, for example:
            Throw New Exception("Error executing stored procedure.", ex)
        End Try

        Return da
    End Function


End Class













