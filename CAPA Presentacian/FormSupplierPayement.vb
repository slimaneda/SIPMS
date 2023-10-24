Public Class FormSupplierPayement
    ' Private Comfunction As New ComFunction
    Private SupplierAcc As New SupplierAcc
    Private SupplierAccDAL As New SupplierAccDAL

    Public Sub clean()

        Comfunction.ClearTextboxes(GroupBox1)
        Comfunction.ClearTextboxes(GroupBox2)


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
                sum = sum + r.Cells(5).Value
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return sum
    End Function
    Private Sub txtPaymentDue_KeyDown(sender As Object, e As KeyPressEventArgs) Handles txtPayment.KeyPress, txtPaymentDue.KeyPress, txtGrandTotaln.KeyPress
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

        For Each r As DataGridViewRow In Me.DGV.Rows
            With SupplierAcc
                .SuppId = Val(r.Cells(0).Value)
                .SuppName = r.Cells(2).Value
                .Inv = r.Cells(3).Value
                .Detail = r.Cells(4).Value
                .Debit = Val(txtTotalPayment.Text) = r.Cells(5).Value
            End With
        Next
        SupplierAccDAL.Insertar(Me.SupplierAcc, "Insert_SuppAccp", False)
        FormMain.refeash()
        clean()
        MsgBox("save don")
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



    Private Sub txtGrandTotal_TextChanged(sender As Object, e As EventArgs) Handles txtGrandTotaln.TextChanged
        Dim numberOnly As String = ""
        For Each ch As Char In txtGrandTotaln.Text
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