Public Class FormSupplierPayement
    Public Sub clean()
        clearTextboxes(GroupBox1)
        clearTextboxes(GroupBox2)


    End Sub

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub FormSupplierPayement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtGrandTotal.Text = Val(txtPaymentDue.Text)

    End Sub

    Private Sub btnShow_click(sender As Object, e As EventArgs) Handles btnShow.Click
        FormProductShow.lbl.Text = "formSupplierPayement"
        FormProductShow.ShowDialog()
    End Sub

    Private Sub txtPayment_TextChanged(sender As Object, e As EventArgs) Handles txtPayment.TextChanged




    End Sub

    Sub Calcul()
        Dim i As Double = 0
        i = Val(txtGrandTotal.Text) - Val(txtTotalPayment.Text)
        i = Math.Round(i, 2)
        txtPaymentDue.Text = i
    End Sub
    Public Function TotalPayment() As Double
        Dim sum As Double = 0
        Try
            For Each r As DataGridViewRow In Me.DGV.Rows
                sum = sum + r.Cells(1).Value
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return sum
    End Function
    Private Sub txtPaymentDue_KeyDown(sender As Object, e As KeyPressEventArgs) Handles txtPayment.KeyPress, txtPaymentDue.KeyPress, txtGrandTotal.KeyPress
        AllowOnlyNumbre(e)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        DGV.Rows.Add(cmbPaymentMode.Text, txtPayment.Text, dtpPaymentDate.Value.Date)
        Dim j As Double = 0
        j = TotalPayment()
        j = Math.Round(j, 2)
        txtTotalPayment.Text = j
        Calcul()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        clean()
    End Sub


End Class