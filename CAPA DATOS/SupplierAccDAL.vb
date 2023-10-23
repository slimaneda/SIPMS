Public Class SupplierAccDAL


    Public Function Create(SupplierAcc As SupplierAcc, Query As String, Optional includeCredit As Boolean = True) As Integer
        Dim args As New Dictionary(Of String, Object) From
        {
            {"@Sup_id", SupplierAcc.SuppId},
            {"@Sup_Name", SupplierAcc.SuppName},
            {"@inv", SupplierAcc.Inv},
            {"@detail", SupplierAcc.Detail},
            {"@debit", SupplierAcc.Debit}
        }

        If includeCredit Then
            args.Add("@credit", SupplierAcc.Credit)
        End If

        Return SqlConnectionManager.ExecuteWrite(Query, args)
    End Function

End Class
