Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmOverallReport

    Private _CustomerAccDAL As New CustomerAccDAL
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        FormGetData.lbl.Text = "Receipt"
        FormGetData.ShowDialog()
    End Sub

    Public Function TotalAmount() As Double
        Dim sum As Double = txtPayment.Text
        Try
            For Each r As DataGridViewRow In Me.DGV.Rows
                sum = sum + r.Cells(4).Value
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return sum
    End Function
    Sub compte()
        Dim num1 As Double = 0
        num1 = Math.Round(num1, 2)
        num1 = CDbl(txtBalance.Text) - CDbl(txtTotalPayment.Text)
        txtnewBalance.Text = num1.ToString


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim j As Double = 0
        j = TotalAmount()
        j = Math.Round(j, 2)
        txtTotalPayment.Text = j

        DGV.Rows.Add(txtCodeCustomers.Text, txtNameCustomer.Text, cmbPaymentMode.Text, dtpPaymentDate.Text, txtPayment.Text, Val(txtBalance.Text) - Val(txtTotalPayment.Text), txtGrandTotal.Text)
        compte()
    End Sub
    Private Sub clean()
        ComFunction.ClearTextboxes(GroupBox1)
        ComFunction.ClearTextboxes(GroupBox2)
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        clean()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        For Each row As DataGridViewRow In DGV.SelectedRows
            DGV.Rows.Remove(row)
        Next
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        InsertIntoCustAcc()
    End Sub
    Private Sub InsertIntoCustAcc()
        For Each row As DataGridViewRow In DGV.Rows
            With _CustomerAccDAL

                .CustomerId = Val(row.Cells(6).Value)

                .CustomerName = row.Cells(1).Value.ToString
                .Inv = CDate(row.Cells(3).Value)
                .Detail = "Receipt Invoice No." + row.Cells(0).Value
                .Debit = 0.0
                .Credit = CDbl(row.Cells(4).Value)
                .Balance = -CDbl(row.Cells(4).Value)
            End With

        Next
        _CustomerAccDAL.insert(_CustomerAccDAL)
        clean()
        FormMain.LoadLatestData()
    End Sub

    Private Sub txtCodeCustomers_TextChanged(sender As Object, e As EventArgs) Handles txtCodeCustomers.TextChanged
        Dim nembreOnly As String = ""
        For Each ch As Char In txtCodeCustomers.Text
            If Char.IsDigit(ch) Then
                nembreOnly &= ch
            End If
        Next
        txtCodCustomer.Text = nembreOnly
    End Sub
End Class