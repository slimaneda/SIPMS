Public Class FormStockShow
    Private Sub FormStockShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Show_DGV(DGV, "Selecte_Stock")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()

    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        If e.RowIndex >= 0 Then
            FormPurchasProduct.txtCodeFacture.Text = DGV.Rows(e.RowIndex).Cells(0).Value
            FormPurchasProduct.txtDate.Text = DGV.Rows(e.RowIndex).Cells(1).Value
            FormPurchasProduct.txtCodeSup.Text = DGV.Rows(e.RowIndex).Cells(2).Value
            FormPurchasProduct.txtNameSup.Text = DGV.Rows(e.RowIndex).Cells(3).Value
            FormPurchasProduct.txtCodePt.Text = DGV.Rows(e.RowIndex).Cells(4).Value
            FormPurchasProduct.txtNamePt.Text = DGV.Rows(e.RowIndex).Cells(5).Value
            FormPurchasProduct.txtQty.Text = DGV.Rows(e.RowIndex).Cells(6).Value
            FormPurchasProduct.txtPricePerQty.Text = DGV.Rows(e.RowIndex).Cells(7).Value
            FormPurchasProduct.txtTotalAmount.Text = DGV.Rows(e.RowIndex).Cells(8).Value
            FormPurchasProduct.txtTotalPayment.Text = DGV.Rows(e.RowIndex).Cells(9).Value
            FormPurchasProduct.txtPaymentDue.Text = DGV.Rows(e.RowIndex).Cells(10).Value
            FormPurchasProduct.txtRemarks.Text = DGV.Rows(e.RowIndex).Cells(11).Value

        End If
        Close()
    End Sub
End Class