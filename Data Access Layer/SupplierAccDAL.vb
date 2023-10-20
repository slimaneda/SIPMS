Public Class SupplierAccDAL


    Public Function Create(SupplierAcc As SupplierAcc) As Integer
        Const Precedurename As String = "Insert_SuppAcc"
        Dim args As New Dictionary(Of String, Object) From
            {
            {"@Sup_id", SupplierAcc.SuppId},
            {"@Sup_Name", SupplierAcc.SuppName},
            {"@inv", SupplierAcc.Inv},
            {"@debit", SupplierAcc.Detail},
            {"@credit", SupplierAcc.Credit}
            }
        Return SqlConnectionManager.ExecuteStoredProcedureWrite(Precedurename, args)
    End Function
End Class
