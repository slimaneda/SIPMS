Public Class FormCustomers
    Dim cls As New ClassCustomer
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        FormCustomerListe.ShowDialog()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        cls.Save_Update()

    End Sub

    Private Sub FormCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Show_DGV(DGV, "Select_Customers")
    End Sub
End Class