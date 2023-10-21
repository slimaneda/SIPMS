Imports System.Data.SqlClient

Public Class FormStock
    REM Private fields
    Private stock As Stock
    Private tempStock As TempStock
    Private SupplierAcc As SupplierAcc
    Private stockProduct As StockProduct

    Private stockDAL As StockDAL
    Private tempStockDAL As TempStockDAL
    Private SupplierAccDAL As SupplierAccDAL
    Private stockProductDAL As StockProductDAl

    Private qty As Double
    Private price As Double
    Private total As Double

    REM Constructor
    Public Sub New()
        InitializeComponent()

        REM Initialize fields
        stock = New Stock()
        tempStock = New TempStock()
        Me.SupplierAcc = New SupplierAcc
        stockProduct = New StockProduct()

        stockDAL = New StockDAL()
        tempStockDAL = New TempStockDAL()
        SupplierAccDAL = New SupplierAccDAL
        stockProductDAL = New StockProductDAl()
    End Sub

    Private Sub FormPurchasProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stock.CodeStock = Val(txtCodestock.Text)
        txtCodestock.Text = CODE_GEN("Stock", "Code_fct") + 1
        btnShowSupp.Focus()
    End Sub

    Private Sub Clean()
        ClearTextboxes(GroupBox1)         ' Clears all TextBox controls on the form
        ClearTextboxes(GroupBox2)
        ClearTextboxes(Panel4)
        ReadOnlyTxtBox(GroupBox2, True) ' Sets all TextBox controls on the form to read-only
        ReadOnlyTxtBox(GroupBox1, True)
        txtRemarks.Text = ""
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click    ' button add sans save 

        Dim targetRow As DataGridViewRow = DGV.Rows.Cast(Of DataGridViewRow).FirstOrDefault(Function(r) r.Cells(0).Value.ToString() = txtCodestock.Text)
        If targetRow IsNot Nothing Then
            Updatrow(targetRow)
        Else
            addRow()
        End If
    End Sub

    Private Sub Button_SaveClick(sender As Object, e As EventArgs) Handles btnSave.Click   ' button Save 
        sqlcon_Open()
        If ValidateData() Then
            UpdateOrInsertTempStock()  REM  insert data in tempStock
            InsertIntoStock()          REM insert data in Stock
            InsertIntoSuppAcc()        REM insert in SuppAcc
            InsertIntoStockProduct()   REM insert in StockProduct
            sqlcon_Close()
            Try
                MsgBox("saved Successfully", MsgBoxStyle.Information)
            Catch ex As Exception

            End Try

            DGV.Rows.Clear()
            Clean()
            FormPurchasProduct_Load(sender, e)
            Show_DGV(FormMain.DGV2, "Select_SupplierSum")
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

    Private Sub UpdateOrInsertTempStock() ' crude  cree red de ipdate

        For Each row As DataGridViewRow In DGV.Rows
            tempStock.Code_Product = row.Cells(5).Value.ToString
            tempStock.Quantity_Pt = Val(row.Cells(7).Value)
        Next

        Dim exists = Convert.ToBoolean(tempStockDAL.Reed(Me.tempStock))
        If exists = True Then
            tempStockDAL.Update(Me.tempStock)
        End If
        If exists = False Then
            tempStockDAL.Create(Me.tempStock)
        End If
    End Sub

    Private Sub InsertIntoStock()

        For Each row As DataGridViewRow In DGV.Rows
            With stock
                .CodeStock = row.Cells(0).Value
                .CodeStockvisible = row.Cells(1).Value
                .InvoiceDate = row.Cells(2).Value
                .Code_Supplier = row.Cells(3).Value
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
                stockDAL.Create(Me.stock)
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

        SupplierAcc.SuppId = txtCodeSup.Text
        SupplierAcc.SuppName = txtNameSup.Text
        SupplierAcc.Detail = txtDate.Value.Date
        For i = 0 To DGV.Rows.Count - 1
            SupplierAcc.Inv = "Facture D'achat N° " + DGV.Rows(i).Cells(0).Value
        Next
        SupplierAcc.Debit = txtTotalPayment.Text
        SupplierAcc.Credit = txtGrandTotal.Text
        SupplierAccDAL.Create(Me.SupplierAcc)
    End Sub

    Private Sub InsertIntoStockProduct()
        stockProduct.StockID = txtCodestock.Text
        stockProduct.ProductID = Val(txtCodePt.Text)
        stockProduct.ProductName = txtNamePt.Text
        stockProduct.Qty = Val(txtQty.Text)
        stockProduct.Price = Val(txtPricePerQty.Text)
        stockProduct.TotalAmount = Val(txtTotalAmount.Text)
        stockProductDAL.Create(Me.stockProduct)
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
        FormProductShow.lbl.Text = "FormStock_Product"
        FormProductShow.ShowDialog()
    End Sub

    Private Sub ShowSupplier_Click(sender As Object, e As EventArgs) Handles btnShowSupp.Click
        FormProductShow.lbl.Text = "FormStock"
        FormProductShow.ShowDialog()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnGetData_Click(sender As Object, e As EventArgs) Handles btnGetData.Click
        FormStockShow.ShowDialog()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        For Each row As DataGridViewRow In DGV.SelectedRows
            DGV.Rows.Remove(row)
        Next
        Dim currentCode = Val(txtCodestock.Text)
        txtCodestock.Text = (currentCode - 1).ToString()
    End Sub


    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress, txtPricePerQty.KeyPress, txtGrandTotal.KeyPress, txtTotalPayment.KeyPress
        AllowOnlyNumbre(e)
    End Sub

    Private Sub GroupBox2_DoubleClick(sender As Object, e As EventArgs) Handles GroupBox2.DoubleClick
        ReadOnlyTxtBox(GroupBox2, False)
    End Sub
    Private Sub GroupBox1_DoubleClick(sender As Object, e As EventArgs) Handles GroupBox1.DoubleClick
        ReadOnlyTxtBox(GroupBox1, False)
    End Sub
End Class