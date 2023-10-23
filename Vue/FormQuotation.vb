Public Class FormQuotation
    Private Comfunction As New ComFunction
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSelectionInv_Click(sender As Object, e As EventArgs) Handles btnSelectionInv.Click
        FormProductShow.lbl.Text = "FB"
        FormProductShow.ShowDialog()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        FormCustomerListe.lbl.Text = "FB"
        FormCustomerListe.ShowDialog()
    End Sub
    Public Function GrandTotal() As Double
        Dim sum As Double = 0
        Try
            For Each r As DataGridViewRow In Me.DataGridView1.Rows
                sum = sum + r.Cells(11).Value
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return sum
    End Function
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
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
            If DataGridView1.Rows.Count = 0 Then
                DataGridView1.Rows.Add(txtProductCode.Text, txtProductName.Text, txtCostPrice.Text, txtSellingPrice.Text, txtMargin.Text, txtQty.Text, txtAmount.Text, txtDiscountPer.Text, txtDiscountAmount.Text, txtVAT.Text, txtVATAmount.Text, txtTotalAmount.Text)


                Exit Sub
            End If
            For Each r As DataGridViewRow In Me.DataGridView1.Rows
                If r.Cells(0).Value = txtProductCode.Text Then
                    r.Cells(0).Value = txtProductCode.Text
                    r.Cells(1).Value = txtProductName.Text
                    r.Cells(2).Value = txtCostPrice.Text
                    r.Cells(3).Value = txtSellingPrice.Text
                    r.Cells(4).Value = txtMargin.Text
                    r.Cells(5).Value = Val(r.Cells(5).Value) + Val(txtQty.Text)
                    r.Cells(6).Value = Val(r.Cells(6).Value) + Val(txtAmount.Text)
                    r.Cells(7).Value = Val(txtDiscountPer.Text)
                    r.Cells(8).Value = Val(r.Cells(8).Value) + Val(txtDiscountAmount.Text)
                    r.Cells(9).Value = Val(txtVAT.Text)
                    r.Cells(10).Value = Val(r.Cells(10).Value) + Val(txtVATAmount.Text)
                    r.Cells(11).Value = Val(r.Cells(11).Value) + Val(txtTotalAmount.Text)
                    ' r.Cells(12).Value = txtProductID.Text



                    Exit Sub
                End If
            Next
            DataGridView1.Rows.Add(txtProductCode.Text, txtProductName.Text, txtCostPrice.Text, txtSellingPrice.Text, txtMargin.Text, txtQty.Text, txtAmount.Text, txtDiscountPer.Text, txtDiscountAmount.Text, txtVAT.Text, txtVATAmount.Text, txtTotalAmount.Text)



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Sub Compute()
        Dim num1, num2, num3, num4, num5 As Double
        num1 = CDbl(Val(txtQty.Text) * Val(txtSellingPrice.Text))
        num1 = Math.Round(num1, 2)
        txtAmount.Text = num1
        num2 = CDbl((Val(txtAmount.Text) * Val(txtDiscountPer.Text)) / 100)
        num2 = Math.Round(num2, 2)
        txtDiscountAmount.Text = num2
        num3 = Val(txtAmount.Text) - Val(txtDiscountAmount.Text)
        num4 = CDbl((Val(txtVAT.Text) * Val(num3)) / 100)
        num4 = Math.Round(num4, 2)
        txtVATAmount.Text = num4
        num5 = CDbl(Val(txtAmount.Text) + Val(txtVATAmount.Text) - Val(txtDiscountAmount.Text))
        num5 = Math.Round(num5, 2)
        txtTotalAmount.Text = num5
    End Sub


    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged, txtSellingPrice.TextChanged, txtDiscountPer.TextChanged
        Compute()
    End Sub

    Private Sub txtCostPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress, txtSellingPrice.KeyPress, txtDiscountPer.KeyPress
        ComFunction.AllowOnlyNumbre(e)
    End Sub


End Class