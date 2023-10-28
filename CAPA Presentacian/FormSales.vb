Public Class FormSales
    'logica 
    Private _sales As New Sales
    Private _Product As New Product
    Private _StockProduct As New StockProduct
    'Data Access Layer (DAL) DATOS
    Private _salesDAL As New SalesDAL
    Private _CustomerAccDAL As New CustomerAccDAL
    Private _StockProductDAl As New StockProductDAl

    Private Sub Updatrow(ByRef _Row As DataGridViewRow)
        With _Row
            .Cells(1).Value = dtpsales.Text
            .Cells(2).Value = txtCustomerID.Text
            .Cells(3).Value = txtCustomerName.Text
            .Cells(4).Value = txtContactNo.Text
            .Cells(5).Value = txtProductCode.Text
            .Cells(6).Value = txtProductName.Text
            .Cells(7).Value = txtSellingPrice.Text
            .Cells(8).Value = (txtQty.Text)
            .Cells(9).Value = CDbl(txtAmount.Text)
            .Cells(10).Value = CDbl(txtVATAmount.Text)
            .Cells(11).Value = CDbl(txtGrandtotal.Text)
            .Cells(12).Value = CDbl(txtTotalPaid.Text)
            .Cells(13).Value = CDbl(txttotalunpaid.Text)

            .Cells(14).Value = txtRemarks.Text
            .Cells(15).Value = TextBox1.Text
        End With
    End Sub

    Private Sub addRow()
        DGV.Rows.Add(txtCodesales.Text, dtpsales.Text, txtCustomerID.Text, txtCustomerName.Text, txtContactNo.Text, txtProductCode.Text, txtProductName.Text, txtSellingPrice.Text, TextBox2.Text, txtAmount.Text, txtVATAmount.Text, txtGrandtotal.Text, txtTotalPaid.Text, txttotalunpaid.Text, txtRemarks.Text, TextBox1.Text)
        Dim currentCode = Val(txtCodesales.Text)
        txtCodesales.Text = (currentCode + 1).ToString
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtProductCode.Text = "" Then
            MessageBox.Show("Please retrieve product code ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtProductCode.Focus()
            Exit Sub
        End If

        If txtCustomerID.Text = "" Then
            MessageBox.Show("Please retrieve Customer id ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtProductCode.Focus()
            Exit Sub
        End If
        If txtQty.Text = "" Then
            MessageBox.Show("Please enter quantity", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

        If ValidateData() Then

            Insertintosales()
            InsertIntoCustAcc()            REM insert in CustAcc
            InsertIntoInvontoryProduct()   REM insert in StockProduct



            DGV.Rows.Clear()
            ' Clean()

            FormMain.LoadLatestData()
            MsgBox("saved Successfully", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub InsertIntoCustAcc()
        For Each row As DataGridViewRow In DGV.Rows
            With _CustomerAccDAL

                .CustomerId = row.Cells(2).Value.ToString

                .CustomerName = row.Cells(3).Value.ToString
                .Inv = CDate(row.Cells(1).Value)
                .Detail = "Sales Invoice No." + row.Cells(0).Value
                .Debit = CDbl(row.Cells(11).Value)
                .Credit = CDbl(row.Cells(12).Value)
                .Balance = CDbl(row.Cells(11).Value - row.Cells(12).Value)
            End With

        Next
        _CustomerAccDAL.insert(_CustomerAccDAL)
    End Sub
    Private Sub InsertIntoInvontoryProduct()
        For Each row As DataGridViewRow In DGV.Rows

            With _StockProduct
                .ProductID = row.Cells(15).Value
                .ProductName = row.Cells(6).Value.ToString
                .Qty = -Val(row.Cells(8).Value)
            End With
        Next
        _StockProductDAl.Insertars(_StockProduct)
    End Sub


    Private Sub Insertintosales()
        For Each row As DataGridViewRow In DGV.Rows
            _sales.SaleCode = row.Cells(0).Value
        Next
        _salesDAL.insertSales(_sales)
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
        txtGrandtotal.Text = num3.ToString() ' 


        Dim num4 As Double
        num4 = Math.Round(num3, 2)
        num4 = CDbl(txtGrandtotal.Text) - CDbl(txtTotalPaid.Text)                  ' Calcul Total rest no paied TTC
        txttotalunpaid.Text = num4.ToString
    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged, txtSellingPrice.TextChanged, txtVAT.TextChanged
        Dim nembreOnly As String = ""
        For Each ch As Char In txtQty.Text
            If Char.IsDigit(ch) Or ch = "." Then
                nembreOnly &= ch
            End If
        Next
        TextBox2.Text = nembreOnly


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
        FormGetData.lbl.Text = "F_Sales"
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

    Private Sub txtProductCode_TextChanged(sender As Object, e As EventArgs) Handles txtProductCode.TextChanged
        Dim nembreOnly As String = ""
        For Each ch As Char In txtProductCode.Text
            If Char.IsDigit(ch) Then
                nembreOnly &= ch
            End If
        Next
        TextBox1.Text = nembreOnly
    End Sub

    
End Class