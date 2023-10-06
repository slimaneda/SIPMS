Public Class FormProductShow

    Private Sub FormProductShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Show_DGV(DGV, "Select_Product")
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        If (e.RowIndex >= 0) AndAlso lbl.text = "a" Then

            FormPurchasProduct.txtProductCode.Text = DGV.Rows(e.RowIndex).Cells(0).Value
            FormPurchasProduct.txtProductName.Text = DGV.Rows(e.RowIndex).Cells(1).Value
            FormPurchasProduct.txt_si.Text = DGV.Rows(e.RowIndex).Cells(4).Value

        End If
        If (e.RowIndex >= 0) AndAlso lbl.Text = "b" Then

            FormPurchasProduct.txtProductCode.Text = DGV.Rows(e.RowIndex).Cells(0).Value
            FormPurchasProduct.txtProductName.Text = DGV.Rows(e.RowIndex).Cells(1).Value
            FormPurchasProduct.txt_si.Text = DGV.Rows(e.RowIndex).Cells(4).Value

        End If
        Me.Close()
    End Sub
End Class