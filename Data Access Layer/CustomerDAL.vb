Public Class CustomerDAL
    Public Function Create(Customer As Customer)
        Const procedureName As String = "Insert_Customer"

        Dim args As New Dictionary(Of String, Object) From
      {
         {"@Customerid", Customer.code},
         {"@CustomerName", Customer.Name},
         {"@Gender", Customer.Gender},
         {"@adress", Customer.Adress},
         {"@city", Customer.City},
         {"@zip", Customer.Zip},
         {"@contact", Customer.contact},
         {"@email", Customer.Email},
         {"@notes", Customer.Notes},
         {"@state", Customer.State},
          {"@photo", Customer.photo}
        }
        Return SqlConnectionManager.ExecuteStoredProcedureWrite(procedureName, args)
    End Function

    Public Function Update(Customer As Customer)
        Const procedureName As String = "Update_Customer"

        Dim args As New Dictionary(Of String, Object) From
      {
      {"@Customerid", Customer.code},
         {"@CustomerName", Customer.Name},
         {"@Gender", Customer.Gender},
         {"@adress", Customer.Adress},
         {"@city", Customer.City},
         {"@zip", Customer.Zip},
         {"@contact", Customer.contact},
         {"@email", Customer.Email},
         {"@notes", Customer.Notes},
         {"@state", Customer.State},
          {"@photo", Customer.photo}
        }
        Return SqlConnectionManager.ExecuteStoredProcedureWrite(procedureName, args)
    End Function

    Public Function delete(Customer As Customer, procedureName As String)
        '  Const procedureName As String = ""
        Dim args As New Dictionary(Of String, Object) From
      {
         {"@Customerid", Customer.code}
        }
        Return SqlConnectionManager.ExecuteStoredProcedureWrite(procedureName, args)
    End Function


    Sub Search_Name(Proc As String, DGV As DataGridView)
        Using cmd As New SqlClient.SqlCommand(Proc, sqlcon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CustomerName", SqlDbType.NVarChar, 50).Value = 'rrrrrrrrrrrrrrrr
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable
            dt.Clear()
            Dim da As New SqlClient.SqlDataAdapter(cmd)
            da.Fill(dt)
            DGV.DataSource = dt.DefaultView
        End Using
    End Sub
End Class
