Public Class CustomerDAL
    Public Function Insertar(Customer As Customer)
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
        Return SqlConnectionManager.ExecuteWrite(procedureName, args)
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
        Return SqlConnectionManager.ExecuteWrite(procedureName, args)
    End Function

    Public Function delete(Customer As Customer, procedureName As String)

        Dim args As New Dictionary(Of String, Object) From
      {
          {"@d1", Customer.code},
           {"@type", "Customer"}
        }
        Return SqlConnectionManager.ExecuteWrite(procedureName, args)
    End Function


End Class
