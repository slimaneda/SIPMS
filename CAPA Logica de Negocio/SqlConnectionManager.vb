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
            Dim Result As Integer = cmd.ExecuteNonQuery()   ' insert delete update search
            Return Result
        End Using
    End Function

    Public Shared Function GetUserByUsername(sql As String, args As Dictionary(Of String, Object)) As DataRow
        Conexion.conecta()

        Using cmd As New SqlCommand(sql, Conexion.con),
          Adp As New SqlDataAdapter(cmd),
          ds As New DataSet()

            For Each param As KeyValuePair(Of String, Object) In args
                cmd.Parameters.AddWithValue(param.Key, param.Value)
            Next
            Adp.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                Return ds.Tables(0).Rows(0)
            Else
                Return Nothing
            End If
        End Using
    End Function




    Public Shared Function DataExists(procedureName As String, args As Dictionary(Of String, Object)) As Boolean 'true 
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

    Public Shared Function ExecuteRead(procedureName As String, args As Dictionary(Of String, Object)) As String
        Conexion.conecta()

        Using cmd As New SqlCommand(procedureName, Conexion.con)
            cmd.CommandType = CommandType.StoredProcedure

            For Each param As KeyValuePair(Of String, Object) In args
                cmd.Parameters.AddWithValue(param.Key, param.Value)
            Next

            Using reader As SqlDataReader = cmd.ExecuteReader()
                Dim result As New StringBuilder()

                While reader.Read()
                    ' هنا نقوم بقراءة القيمة من العمود الأول فقط، يمكنك تعديله حسب الحاجة
                    result.AppendLine(reader(0).ToString())
                End While

                Return result.ToString()
            End Using
        End Using
    End Function



    'Public Shared Function ExecuteScalar(query As String, parameters As Dictionary(Of String, Object)) As Object
    '    Conexion.conecta()
    '    Using cmd As New SqlCommand(query, Conexion.con)
    '        cmd.CommandType = CommandType.StoredProcedure
    '        For Each param In parameters
    '            cmd.Parameters.AddWithValue(param.Key, param.Value)
    '        Next

    '        Return cmd.ExecuteScalar()
    '    End Using

    'End Function







End Class













