Public Class FormMain
    Dim ComFunction As New ComFunction
    Private Sub CompanyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CompanyToolStripMenuItem1.Click
        FormCompany.ShowDialog()
    End Sub
    Sub refeash()
        ComFunction.Show_DGV(DGV, "Select_SupplierSum")
        ComFunction.Show_DGV(DGV2, "Select_Supplier_Vue")
        ' ComFunction.Show_DGV(DGV3, "SelectViewProduct")
        ComFunction.Show_DGV(DGV3, "Selectstock_Qt")
    End Sub
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refeash()

    End Sub

    Private Sub btn_items_Click(sender As Object, e As EventArgs) Handles btn_items.Click
        FormItem.ShowDialog()

    End Sub

    Private Sub ItemsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ItemsToolStripMenuItem1.Click
        btn_items_Click(sender, e)
    End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        FormCustomers.ShowDialog()


    End Sub

    Private Sub btn_supplier_Click(sender As Object, e As EventArgs) Handles btn_supplier.Click
        FormSupplier.ShowDialog()

    End Sub

    Private Sub btn_Product_Click(sender As Object, e As EventArgs) Handles btn_Product.Click
        FormProduct.ShowDialog()

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        End
    End Sub

    Private Sub PurchasBillToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchasBillToolStripMenuItem.Click
        FormQuotation.ShowDialog()
    End Sub

    Private Sub CustomerReceiptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerReceiptToolStripMenuItem.Click
        frmOverallReport.ShowDialog()
    End Sub

    Private Sub SupplierPaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierPaymentToolStripMenuItem.Click
        FormSupplierPayement.ShowDialog()
    End Sub

    Private Sub PurchasBillsuplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchasBillsuplierToolStripMenuItem.Click
        FormStock.ShowDialog()
    End Sub

    Private Sub btn_user_Click(sender As Object, e As EventArgs) Handles btn_user.Click
        FormCompany.ShowDialog()
    End Sub
End Class