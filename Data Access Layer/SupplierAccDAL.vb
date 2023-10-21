Public Class SupplierAccDAL


    Public Function Create(SupplierAcc As SupplierAcc) As Integer
        Const Precedurename As String = "Insert_SuppAcc"
        Dim args As New Dictionary(Of String, Object) From
            {
            {"@Sup_id", SupplierAcc.SuppId},
            {"@Sup_Name", SupplierAcc.SuppName},
            {"@inv", SupplierAcc.Inv},
            {"@detail", SupplierAcc.Detail},
            {"@debit", SupplierAcc.Debit},
            {"@credit", SupplierAcc.Credit}
            }
        Return SqlConnectionManager.ExecuteWrite(Precedurename, args)
    End Function
End Class
