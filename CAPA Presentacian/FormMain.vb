Public Class FormMain
    ' Dim ComFunction As New ComFunction
    Private Sub CompanyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles btncompany.Click
        FormCompany.ShowDialog()
    End Sub
    Sub refeash()
        ComFunction.Show_DGV(DGV2, "Select_SupplierSum")
        ComFunction.Show_DGV(DGV, "Select_Sales")
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

    End Sub

    Private Sub PurchasBillToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnQuatation.Click
        FormSales.ShowDialog()
    End Sub

    Private Sub CustomerReceiptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnreciept.Click
        frmOverallReport.ShowDialog()
    End Sub

    Private Sub SupplierPaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnsupplierpayement.Click
        FormSupplierPayement.ShowDialog()
    End Sub

    Private Sub PurchasBillsuplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnPurchas.Click
        FormInventory.ShowDialog()
    End Sub

    Private Sub btn_user_Click(sender As Object, e As EventArgs) Handles btn_user.Click
        FormUser.ShowDialog()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

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
End Class