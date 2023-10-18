Public Class FormProductShow

    Private Sub FormProductShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If lbl.Text = "FPP" Or lbl.Text = "b" Then
            Show_DGV(DGV, "Select_Pt")
        End If

        If lbl.Text = "FB" Then
            Show_DGV(DGV, "Select_StockProductSum")
        End If
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        If (e.RowIndex >= 0) AndAlso lbl.Text = "FB" Then

            With FormQuotation
                .txtProductCode.Text = DGV.Rows(e.RowIndex).Cells(0).Value
                .txtProductName.Text = DGV.Rows(e.RowIndex).Cells(1).Value
                .txtQty.Text = DGV.Rows(e.RowIndex).Cells(2).Value
            End With
            lbl.Text = ""
        End If
        If (e.RowIndex >= 0) AndAlso lbl.Text = "FPP" Then

            FormPurchasProduct.txtCodePt.Text = DGV.Rows(e.RowIndex).Cells(0).Value
            FormPurchasProduct.txtNamePt.Text = DGV.Rows(e.RowIndex).Cells(1).Value
            FormPurchasProduct.txtQty.Text = DGV.Rows(e.RowIndex).Cells(4).Value
            lbl.Text = ""
        End If
        If (e.RowIndex >= 0) AndAlso lbl.Text = "b" Then

            FormProduct.txt_Productid.Text = DGV.Rows(e.RowIndex).Cells(0).Value
            FormProduct.txt_productname.Text = DGV.Rows(e.RowIndex).Cells(1).Value
            FormProduct.txt_qty.Text = DGV.Rows(e.RowIndex).Cells(4).Value
            lbl.Text = ""
        End If
        Me.Close()
    End Sub
End Class