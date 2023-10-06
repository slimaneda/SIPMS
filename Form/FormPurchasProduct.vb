Public Class FormPurchasProduct
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormProductShow.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormSupplierShow.ShowDialog()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class