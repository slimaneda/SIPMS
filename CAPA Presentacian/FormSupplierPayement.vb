Public Class FormSupplierPayement
    ' Private Comfunction As New ComFunction
    Private SupplierAcc As New SupplierAcc
    Private SupplierAccDAL As New SupplierAccDAL

    Public Sub clean()
        ComFunction.ClearTextboxes(GroupBox1)
        ComFunction.ClearTextboxes(GroupBox2)
    End Sub

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub FormSupplierPayement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtGrandTotal.Text = Val(txtPaymentDue.Text)
    End Sub

    Private Sub btnShow_click(sender As Object, e As EventArgs) Handles btnShow.Click
        FormGetData.lbl.Text = "formSupplierPayement"
        FormGetData.ShowDialog()
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
            For Each r As DataGridViewRow In Me.DGV.Rows 'Add whenever the Add button is pressed
                sum = sum + r.Cells(5).Value
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return sum
    End Function
    Private Sub txtPaymentDue_KeyDown(sender As Object, e As KeyPressEventArgs) Handles txtPayment.KeyPress, txtPaymentDue.KeyPress, txtbalance.KeyPress
        ' Comfunction.AllowOnlyNumbre(e)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        DGV.Rows.Add(txtCodSupplier.Text, txtCodeSup.Text, txtNameSup.Text, cmbPaymentMode.Text, dtpPaymentDate.Text, txtPayment.Text, txtPaymentDue.Text)
        Dim j As Double = 0
        j = TotalPayment()
        j = Math.Round(j, 2)
        txtTotalPayment.Text = j
        Calcul()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        clean()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If DGV.Rows.Count = 0 Then
            MessageBox.Show("Please click the save button before proceeding.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        InsertIntoSuppAcc()
        FormMain.LoadLatestData()
        clean()
        MsgBox("Registration successful")
    End Sub
    Private Sub InsertIntoSuppAcc()

        For Each row As DataGridViewRow In DGV.Rows



            With SupplierAcc
                .SuppId = Val(row.Cells(0).Value)
                .SuppName = row.Cells(2).Value
                .Detail = row.Cells(4).Value
                .Inv = "Payement Invoice No. " + row.Cells(0).Value + " Par " + row.Cells(3).Value
                .Debit = Val(row.Cells(5).Value)
                .Credit = 0

            End With
        Next
        SupplierAccDAL.Insertar(Me.SupplierAcc, "Insert_SuppAcc")
    End Sub

    Private Sub txtCodeSup_TextChanged(sender As Object, e As EventArgs) Handles txtCodeSup.TextChanged
        Dim nembreOnly As String = ""
        For Each ch As Char In txtCodeSup.Text
            If Char.IsDigit(ch) Then
                nembreOnly &= ch
            End If
        Next
        txtCodSupplier.Text = nembreOnly
    End Sub



    Private Sub txtGrandTotal_TextChanged(sender As Object, e As EventArgs) Handles txtbalance.TextChanged
        Dim numberOnly As String = ""
        For Each ch As Char In txtbalance.Text
            If Char.IsDigit(ch) Or ch = "."c Then
                numberOnly &= ch
            End If
        Next
        txtGrandTotal.Text = numberOnly
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        For Each row As DataGridViewRow In DGV.SelectedRows
            DGV.Rows.Remove(row)
        Next
    End Sub
End Class