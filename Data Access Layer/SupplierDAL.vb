Imports System.IO

Public Class SupplierDAL

    Private Function PrepareParameters(supplier As Supplier) As Dictionary(Of String, Object)
        Return New Dictionary(Of String, Object) From {
            {"@Supplierid", supplier.code},
            {"@SupplierName", supplier.Name},
            {"@Gender", supplier.Gender},
            {"@Adress", supplier.Adress},
            {"@City", supplier.City},
            {"@Zip", supplier.Zip},
            {"@Contact", supplier.contact},
            {"@Email", supplier.Email},
            {"@Notes", supplier.Notes},
            {"@State", supplier.State},
            {"@Photo", supplier.photo}
        }
    End Function

    Public Function Create(supplier As Supplier) As Boolean
        Const procedureName As String = "Insert_Supplier"
        Dim parameters = PrepareParameters(supplier)
        Return SqlConnectionManager.ExecuteWrite(procedureName, parameters)
    End Function

    Public Function Update(supplier As Supplier) As Boolean
        Const procedureName As String = "Update_Supplier"
        Dim parameters = PrepareParameters(supplier)
        Return SqlConnectionManager.ExecuteWrite(procedureName, parameters)
    End Function
    Public Function Delete(Supplier As Supplier)
        Const procedureName As String = "Deletedata"

        Dim args As New Dictionary(Of String, Object) From
      {
         {"@d1", Supplier.code},
          {"@type", "Supplier"}
           }
        Return SqlConnectionManager.ExecuteWrite(procedureName, args)
    End Function



    'Sub Search_Name(Proc As String, DGV As DataGridView, Supplier As Supplier)
    '    Using cmd As New SqlClient.SqlCommand(Proc, sqlcon)
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.Parameters.Add("@SupplierName", SqlDbType.NVarChar, 50).Value = Supplier.Name
    '        cmd.ExecuteNonQuery()
    '        Dim dt As New DataTable
    '        dt.Clear()
    '        Dim da As New SqlClient.SqlDataAdapter(cmd)
    '        da.Fill(dt)
    '        DGV.DataSource = dt.DefaultView
    '    End Using
    'End Sub
End Class
