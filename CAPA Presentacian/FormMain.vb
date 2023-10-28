Public Class FormMain
    Private customer As New Customer
    Private _customerdal As New CustomerDAL
    Private Sub CompanyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles btncompany.Click
        FormCompany.ShowDialog()
    End Sub
    Sub LoadLatestData()
        ComFunction.Show_DGV(DGV, "GetCustomerSalesSummary")
        ComFunction.Show_DGV(DGV2, "GetSupplierSummary")
        ComFunction.Show_DGV(DGV3, "GetProductStockSummary")
    End Sub
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLatestData()
    End Sub

    Private Sub btn_items_Click(sender As Object, e As EventArgs) Handles btn_items.Click
        FormCategories.ShowDialog()
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



    Private Sub PurchasBillToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnQuatation.Click
        FormSales.ShowDialog()
    End Sub

    Private Sub CustomerReceiptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnreciept.Click
        formCustomerReceipt.ShowDialog()
    End Sub

    Private Sub SupplierPaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnsupplierpayement.Click
        FormSupplierPayement.ShowDialog()
    End Sub

    Private Sub PurchasBillsuplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnPurchas.Click
        FormInventory.ShowDialog()
    End Sub

    Private Sub btn_user_Click(sender As Object, e As EventArgs) Handles btn_user.Click
        formSetting.ShowDialog()
    End Sub

    Private Sub CalculToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("Calc.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub NotepadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotepadToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("Notepad.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub WordpadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordpadToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("wordpad.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MsWordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MsWordToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("winword.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TaslManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TaslManagerToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("TaskMgr.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ChangeTheAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeTheAccountToolStripMenuItem.Click
        Dim log As New FormLogin
        log.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub QuitTheProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitTheProgramToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        About.ShowDialog()
    End Sub

    Private Sub btnSearchcustomer_Click(sender As Object, e As EventArgs) Handles btnsearchcustomer.Click
        If txtnamecustomer.Text = String.Empty Then
            ComFunction.search(DGV, txtcodecustomer.Text, 0)
            Exit Sub
        End If
        If txtcodecustomer.Text = String.Empty Then
            ComFunction.search(DGV, txtnamecustomer.Text, 1)
            Exit Sub
        End If
    End Sub
    Private Sub btnSearchSupplier_Click(sender As Object, e As EventArgs)
        If txtnamesupplier.Text = String.Empty Then
            ComFunction.search(DGV, txtcodesupplier.Text, 0)
            Exit Sub
        End If
        If txtcodesupplier.Text = String.Empty Then
            ComFunction.search(DGV, txtnamesupplier.Text, 1)
            Exit Sub
        End If
    End Sub
    Private Sub btnSearchproduct_Click(sender As Object, e As EventArgs)
        If txtname.Text = String.Empty Then
            ComFunction.search(DGV, txtcode.Text, 0)
            Exit Sub
        End If
        If txtcode.Text = String.Empty Then
            ComFunction.search(DGV, txtname.Text, 1)
            Exit Sub
        End If
    End Sub

End Class