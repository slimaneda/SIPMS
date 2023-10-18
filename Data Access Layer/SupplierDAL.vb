Imports System.IO

Public Class SupplierDAL


    Public Function Create(Supplier As Supplier)
        Const procedureName As String = "Insert_Supplier"

        Dim args As New Dictionary(Of String, Object) From
      {
         {"@Supplierid", Supplier.code},
         {"@SupplierName", Supplier.Name},
         {"@Gender", Supplier.Gender},
         {"@adress", Supplier.Adress},
         {"@city", Supplier.City},
         {"@zip", Supplier.Zip},
         {"@contact", Supplier.contact},
         {"@email", Supplier.Email},
         {"@notes", Supplier.Notes},
         {"@state", Supplier.State},
          {"@photo", Supplier.photo}
        }
        Return SqlConnectionManager.ExecuteStoredProcedureWrite(procedureName, args)
    End Function

    Public Function update(Supplier As Supplier)
        Const procedureName As String = "Update_Supplier"

        Dim args As New Dictionary(Of String, Object) From
      {
         {"@Supplierid", Supplier.code},
         {"@SupplierName", Supplier.Name},
         {"@Gender", Supplier.Gender},
         {"@adress", Supplier.Adress},
         {"@city", Supplier.City},
         {"@zip", Supplier.Zip},
         {"@contact", Supplier.contact},
         {"@email", Supplier.Email},
         {"@notes", Supplier.Notes},
         {"@state", Supplier.State},
          {"@photo", Supplier.photo}
        }
        Return SqlConnectionManager.ExecuteStoredProcedureWrite(procedureName, args)
    End Function

    Public Function Delete(Supplier As Supplier)
        Const procedureName As String = "Deletedata"

        Dim args As New Dictionary(Of String, Object) From
      {
         {"@d1", Supplier.code},
          {"@type", "Supplier"}
           }
        Return SqlConnectionManager.ExecuteStoredProcedureWrite(procedureName, args)
    End Function



    Sub Search_Name(Proc As String, DGV As DataGridView, Supplier As Supplier)
        Using cmd As New SqlClient.SqlCommand(Proc, sqlcon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@SupplierName", SqlDbType.NVarChar, 50).Value = Supplier.Name
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable
            dt.Clear()
            Dim da As New SqlClient.SqlDataAdapter(cmd)
            da.Fill(dt)
            DGV.DataSource = dt.DefaultView
        End Using
    End Sub
End Class
