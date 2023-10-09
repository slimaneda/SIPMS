Public Class FormProductShow

    Private Sub FormProductShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Show_DGV(DGV, "Select_Product")
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        If (e.RowIndex >= 0) AndAlso lbl.Text = "FPP" Then

            FormPurchasProduct.txtCodePt.Text = DGV.Rows(e.RowIndex).Cells(0).Value
            FormPurchasProduct.txtNamePt.Text = DGV.Rows(e.RowIndex).Cells(1).Value
            FormPurchasProduct.txtQty.Text = DGV.Rows(e.RowIndex).Cells(4).Value

        End If
        If (e.RowIndex >= 0) AndAlso lbl.Text = "b" Then

            FormProduct.txt_Productid.Text = DGV.Rows(e.RowIndex).Cells(0).Value
            FormProduct.txt_productname.Text = DGV.Rows(e.RowIndex).Cells(1).Value
            FormProduct.txt_qty.Text = DGV.Rows(e.RowIndex).Cells(4).Value

        End If
        Me.Close()
    End Sub


End Class