Public Class FormInventory
    REM Private fields


    Private stock As Stock

    Private SupplierAcc As SupplierAcc
    Private stockProduct As StockProduct

    Private stockDAL As StockDAL

    Private SupplierAccDAL As SupplierAccDAL
    Private stockProductDAL As StockProductDAl

    Private qty As Double
    Private price As Double
    Private total As Double


    Public Sub New()
        InitializeComponent()

        REM Initialize fields

        stock = New Stock()

        Me.SupplierAcc = New SupplierAcc
        stockProduct = New StockProduct()

        stockDAL = New StockDAL()

        SupplierAccDAL = New SupplierAccDAL
        stockProductDAL = New StockProductDAl()
    End Sub

    Private Sub FormPurchasProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stock.CodeStock = Val(txtCodestock.Text)
        txtCodestock.Text = Comfunction.CODE_GEN("Stock", "Code_fct") + 1
        btnShowSupp.Focus()
    End Sub

    Private Sub Clean()

        ComFunction.ClearTextboxes(GroupBox1)         ' Clears all TextBox controls on the form
        ComFunction.ClearTextboxes(GroupBox2)
        ComFunction.ClearTextboxes(Panel4)
        txtRemarks.Text = ""
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If Len(Trim(txtTotalPayment.Text)) = 0 Then
            MessageBox.Show("Please enter the payment amount.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTotalPayment.Focus()
            Exit Sub
        End If

        If Val(txtTotalPayment.Text) > Val(txtGrandTotal.Text) Then
            MessageBox.Show("Sorry, the payment amount cannot be greater than the invoice value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTotalPayment.Focus()
            Exit Sub
        End If

        Dim targetRow As DataGridViewRow = DGV.Rows.Cast(Of DataGridViewRow).FirstOrDefault(Function(r) r.Cells(0).Value.ToString() = txtCodestock.Text)
        If targetRow IsNot Nothing Then
            Updatrow(targetRow)
        Else
            addRow()
        End If
    End Sub

    Private Sub Button_SaveClick(sender As Object, e As EventArgs) Handles btnSave.Click   ' button Save 

        If ValidateData() Then
            Try
                InsertIntoiventory()          REM insert data in Stock
                InsertIntoSuppAcc()        REM insert in SuppAcc
                InsertIntoStockProduct()   REM insert in StockProduct
            Catch ex As Exception

            End Try
            ' UpdateOrInsertTempStock()  REM  insert data in tempStock
            DGV.Rows.Clear()
            Clean()
            FormPurchasProduct_Load(sender, e)
            FormMain.refeash()
            MsgBox("saved Successfully", MsgBoxStyle.Information)
        End If
    End Sub



    Private Sub Updatrow(ByRef _Row As DataGridViewRow)
        With _Row
            .Cells(1).Value = TextBox1.Text
            .Cells(2).Value = txtDate.Text
            .Cells(3).Value = txtCodeSup.Text
            .Cells(4).Value = txtNameSup.Text
            .Cells(5).Value = txtCodePt.Text
            .Cells(6).Value = txtNamePt.Text
            .Cells(7).Value = txtQty.Text
            .Cells(8).Value = Val(txtPricePerQty.Text)
            .Cells(9).Value = Val(txtTotalAmount.Text)
            .Cells(10).Value = Val(txtTotalPayment.Text)
            .Cells(11).Value = Val(txtPaymentDue.Text)
            .Cells(12).Value = txtRemarks.Text
        End With
    End Sub

    Private Sub addRow()
        DGV.Rows.Add(txtCodestock.Text, TextBox1.Text, txtDate.Text, txtCodeSup.Text, txtNameSup.Text, txtCodePt.Text, txtNamePt.Text, txtQty.Text, Val(txtPricePerQty.Text), Val(txtTotalAmount.Text), Val(txtTotalPayment.Text), Val(txtPaymentDue.Text), txtRemarks.Text)
        Dim currentCode = Val(txtCodestock.Text)
        txtCodestock.Text = (currentCode + 1).ToString

    End Sub

    Private Sub txtTotalPayment_TextChanged(sender As Object, e As EventArgs) Handles txtTotalPayment.TextChanged
        If Not txtGrandTotal.Text.Trim = "" Then
            txtPaymentDue.Text = Val(txtGrandTotal.Text) - Val(txtTotalPayment.Text)
        End If

    End Sub
    Private Function ValidateData() As Boolean
        If DGV.Rows.Count = 0 Then
            MsgBox("click for button Add ", MsgBoxStyle.Exclamation)
            Return False
        End If
        If String.IsNullOrEmpty(txtCodePt.Text) Then
            MsgBox("code product n'est pas insert", MsgBoxStyle.Exclamation)
            Return False
        End If
        Return True
    End Function



    Private Sub InsertIntoiventory()

        For Each row As DataGridViewRow In DGV.Rows
            With stock
                .CodeStock = row.Cells(0).Value
                .CodeStockvisible = row.Cells(1).Value
                .InvoiceDate = row.Cells(2).Value
                .Code_Supplier = Val(row.Cells(3).Value)
                .Name_Supplier = row.Cells(4).Value

                .Code_Product = row.Cells(5).Value
                .Name_Product = row.Cells(6).Value
                .Quantity_Pt = Val(row.Cells(7).Value)
                .Price_Pt = Val(row.Cells(8).Value)
                .Totalamont = Val(row.Cells(9).Value)

                .TOTALPayement = Val(row.Cells(10).Value)
                .Rest_NonPayement = Val(row.Cells(11).Value)

                .NOTES = row.Cells(12).Value
            End With
            Try
                stockDAL.Insertar(Me.stock)
            Catch ex As Exception

            End Try

        Next

    End Sub
    Private Sub txtPricePerQty_TextChanged(sender As Object, e As EventArgs) Handles txtPricePerQty.TextChanged, txtQty.TextChanged
        CalculTotal()
    End Sub

    Private Sub CalculTotal()

        If Double.TryParse(txtPricePerQty.Text, price) AndAlso Double.TryParse(txtQty.Text, qty) Then
            total = qty * price
            txtTotalAmount.Text = total.ToString
            txtGrandTotal.Text = total

        End If

    End Sub

    Private Sub InsertIntoSuppAcc()

        For Each row As DataGridViewRow In DGV.Rows



            With SupplierAcc
                .SuppId = Val(row.Cells(3).Value)
                .SuppName = row.Cells(4).Value
                .Detail = row.Cells(2).Value
                .Inv = "Purchase Invoice No. " + row.Cells(0).Value
                .Debit = Val(row.Cells(10).Value)
                .Credit = Val(row.Cells(9).Value)

            End With
        Next
        SupplierAccDAL.Insertar(Me.SupplierAcc, "Insert_SuppAcc")


    End Sub



    Private Sub InsertIntoStockProduct()
        For Each row As DataGridViewRow In DGV.Rows
            With stockProduct
                .StockID = Val(row.Cells(0).Value)
                .ProductID = row.Cells(5).Value
                .ProductName = row.Cells(6).Value
                .Qty = Val(row.Cells(7).Value)
                .Price = Val(txtPricePerQty.Text)
                .TotalAmount = Val(row.Cells(9).Value)

            End With
        Next
        stockProductDAL.Insertar(Me.stockProduct)
    End Sub



    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Clean()
        FormPurchasProduct_Load(sender, e)
    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim nembreOnly As String = ""
        For Each ch As Char In TextBox1.Text
            If Char.IsDigit(ch) Then
                nembreOnly &= ch
            End If
        Next
        txtCodestock.Text = nembreOnly
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        For i = 0 To DGV.Rows.Count - 1
            stock.CodeStock = DGV.Rows(i).Cells(0).Value
            stockDAL.Delete(Me.stock)
        Next
    End Sub
    Private Sub txtCodestock_TextChanged(sender As Object, e As EventArgs) Handles txtCodestock.TextChanged

        TextBox1.Text = "F°" & txtCodestock.Text
    End Sub

    Private Sub ShowProduct_Click(sender As Object, e As EventArgs) Handles btnShowPt.Click
        FormGetData.lbl.Text = "FormStock_Product"
        FormGetData.ShowDialog()
    End Sub

    Private Sub ShowSupplier_Click(sender As Object, e As EventArgs) Handles btnShowSupp.Click
        FormGetData.lbl.Text = "FormStock"
        FormGetData.ShowDialog()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnGetData_Click(sender As Object, e As EventArgs) Handles btnGetData.Click
        'FormStockShow.ShowDialog()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        For Each row As DataGridViewRow In DGV.SelectedRows
            DGV.Rows.Remove(row)
        Next
        Dim currentCode = Val(txtCodestock.Text)
        txtCodestock.Text = (currentCode - 1).ToString()
    End Sub


    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress, txtPricePerQty.KeyPress, txtGrandTotal.KeyPress, txtTotalPayment.KeyPress
        Comfunction.AllowOnlyNumbre(e)
    End Sub

    Private Sub GroupBox2_DoubleClick(sender As Object, e As EventArgs) Handles GroupBox2.DoubleClick
        Comfunction.ReadOnlyTxtBox(GroupBox2, False)
    End Sub
    Private Sub GroupBox1_DoubleClick(sender As Object, e As EventArgs) Handles GroupBox1.DoubleClick
        Comfunction.ReadOnlyTxtBox(GroupBox1, False)
    End Sub
End Class