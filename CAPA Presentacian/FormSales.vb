Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormSales

    Private sales As New Sales
    Private salesDAL As New SalesDAL
    Private Sub Updatrow(ByRef _Row As DataGridViewRow)
        With _Row
            .Cells(1).Value = dtpsales.Text
            .Cells(2).Value = txtCustomerID.Text
            .Cells(3).Value = txtCustomerName.Text
            .Cells(4).Value = txtContactNo.Text
            .Cells(5).Value = txtProductCode.Text
            .Cells(6).Value = txtProductName.Text
            .Cells(7).Value = txtSellingPrice.Text
            .Cells(8).Value = Val(txtQty.Text)
            .Cells(9).Value = Val(txtAmount.Text)
            .Cells(10).Value = Val(txtVATAmount.Text)
            .Cells(11).Value = Val(txtGrandtotal.Text)
            .Cells(12).Value = txtTotalPaid.Text
            .Cells(13).Value = txttotalunpaid.Text

            .Cells(14).Value = txtRemarks.Text
        End With
    End Sub

    Private Sub addRow()
        DGV.Rows.Add(txtCodesales.Text, dtpsales.Text, txtCustomerID.Text, txtCustomerName.Text, txtContactNo.Text, txtProductCode.Text, txtProductName.Text, txtSellingPrice.Text, txtQty.Text, txtAmount.Text, txtVATAmount.Text, txtGrandtotal.Text, txtTotalPaid.Text, txttotalunpaid.Text, txtRemarks.Text)
        Dim currentCode = Val(txtCodesales.Text)
        txtCodesales.Text = (currentCode + 1).ToString
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtProductCode.Text = "" Then
            MessageBox.Show("Please retrieve product code", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtProductCode.Focus()
            Exit Sub
        End If
        If txtQty.Text = "" Then
            MessageBox.Show("Please enter quantity", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtQty.Focus()
            Exit Sub
        End If
        If txtQty.Text = 0 Then
            MessageBox.Show("Quantity can not be zero", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtQty.Focus()
            Exit Sub
        End If

        Dim targetRow As DataGridViewRow = DGV.Rows.Cast(Of DataGridViewRow).FirstOrDefault(Function(r) r.Cells(0).Value.ToString() = txtCodesales.Text)
        If targetRow IsNot Nothing Then
            Updatrow(targetRow)
        Else
            addRow()
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        REM If ValidateData() Then
        REM    Try
        Insertintosales()
        ' InsertIntoInvontory()          REM insert data in Stock
        InsertIntoCustAcc()            REM insert in SuppAcc
        ' InsertIntoInvontoryProduct()   REM insert in StockProduct

        REM  Catch ex As Exception
        REM End Try
        ' UpdateOrInsertTempStock()  REM  insert data in tempStock
        DGV.Rows.Clear()
        ' Clean()
        ' FormPurchasProduct_Load(sender, e)
        FormMain.refeash()
        MsgBox("saved Successfully", MsgBoxStyle.Information)
        REM  End If
    End Sub
    Private Sub InsertIntoCustAcc()
        For Each row As DataGridViewRow In DGV.Rows
            With sales

                .customerid = row.Cells(2).Value

                .customername = row.Cells(3).Value
                .inv = row.Cells(1).Value
                .detail = "Sales Invoice No." + row.Cells(0).Value
                .debit = row.Cells(13).Value
                .credit = row.Cells(12).Value
                .balance = row.Cells(12).Value - row.Cells(13).Value
            End With

        Next
        salesDAL.insert(sales)
    End Sub



    Private Sub Insertintosales()
        For Each row As DataGridViewRow In DGV.Rows
            sales.SaleCode = row.Cells(0).Value
        Next
        salesDAL.insert(sales)
    End Sub
    Private Sub Compute()

        Dim num1, num2, num3 As Double

        num1 = CDbl(Val(txtQty.Text) * Val(txtSellingPrice.Text))             'Calcul Amount
        num1 = Math.Round(num1, 2)
        txtAmount.Text = num1.ToString() ' 

        num2 = CDbl((Val(txtVAT.Text) * Val(num1)) / 100)                      ' Calcul Tva Amount
        num2 = Math.Round(num2, 2)
        txtVATAmount.Text = num2.ToString()


        num3 = CDbl(Val(txtAmount.Text) + Val(txtVATAmount.Text))               ' Calcul Total amout TTC
        num3 = Math.Round(num3, 2)
        txtTotalAmount.Text = num3.ToString() ' 
        txtGrandTotal.Text = num3.ToString() ' 
    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged, txtSellingPrice.TextChanged, txtVAT.TextChanged
        Compute()
    End Sub

    Private Sub txtCostPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress, txtVAT.KeyPress
        ComFunction.AllowOnlyNumbre(e)
    End Sub


    Private Function ValidateData() As Boolean
        If DGV.Rows.Count = 0 Then
            MsgBox("click for button Add ", MsgBoxStyle.Exclamation)
            Return False
        End If
        If String.IsNullOrEmpty(txtProductCode.Text) Then
            MsgBox("code product n'est pas insert", MsgBoxStyle.Exclamation)
            Return False
        End If
        Return True
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSelectionInv_Click(sender As Object, e As EventArgs) Handles btnSelectionInv.Click
        FormGetData.lbl.Text = "FB"
        FormGetData.ShowDialog()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        FormGetData.lbl.Text = "QUATATION"
        FormGetData.ShowDialog()
    End Sub
    Public Function GrandTotal() As Double
        Dim sum As Double = 0
        Try
            For Each r As DataGridViewRow In Me.DGV.Rows
                sum = sum + r.Cells(11).Value
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return sum
    End Function

    Private Sub FormSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCodesales.Text = ComFunction.CODE_GEN("Sales", "Sales_Code") + 1
    End Sub
End Class