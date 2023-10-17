Public Class ProductDao
    Public code As Integer
    Public name As String
    Public notes As String
    Public item As String
    Public minrecord As Decimal
    Public qty As Decimal




    Sub deletedata(proc As String)
        Try
            Dim cmd As New SqlClient.SqlCommand(proc, sqlcon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Product_ID", SqlDbType.Int).Value = code

            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
    End Sub


    Sub Save_update(proc As String)
        Try
            Using cmd As New SqlClient.SqlCommand(proc, sqlcon)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.Add("@Product_ID", SqlDbType.Int).Value = code
                cmd.Parameters.Add("@Product_Name", SqlDbType.NVarChar, 50).Value = name
                cmd.Parameters.Add("@Item", SqlDbType.NVarChar, 50).Value = item
                cmd.Parameters.Add("@Min_record", SqlDbType.Decimal, 18, 2).Value = minrecord
                cmd.Parameters.Add("@Quantity", SqlDbType.Decimal, 18, 2).Value = qty

                cmd.ExecuteNonQuery()

            End Using
        Catch ex As Exception

        End Try
    End Sub
End Class
