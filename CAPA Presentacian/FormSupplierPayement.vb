Public Class FormSupplierPayement
    ' Private Comfunction As New ComFunction
    Private SupplierAcc As New SupplierAcc
    Private SupplierAccDAL As New SupplierAccDAL
    Private btnclick As Integer = 0
    Public Sub clean()
        ComFunction.ClearTextboxes(GroupBox1)
        ComFunction.ClearTextboxes(GroupBox2)
    End Sub

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub FormSupplierPayement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtGrandTotal.Text = Val(txtPaymentDue.Text)
        TextBox1.Text = DGV.Rows.Count.ToString
    End Sub

    Private Sub btnShow_click(sender As Object, e As EventArgs) Handles btnShow.Click
        FormGetData.lbl.Text = "formSupplierPayement"
        FormGetData.ShowDialog()
    End Sub

    Sub Calcul()
        Dim i As Double = 0
        i = -Val(txtTotalPayment.Text) - Val(txtbalance.Text)
        i = Math.Round(i, 2)
        txtPaymentDue.Text = i
    End Sub

    Public Function TotalPayment() As Double
        Dim sum As Double = Val(txtPayment.Text)
        Try
            For Each r As DataGridViewRow In Me.DGV.Rows 'Add whenever the Add button is pressed
                sum += r.Cells(5).Value
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return sum
    End Function


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim j As Double = 0
        j = TotalPayment()
        j = Math.Round(j, 2)
        txtTotalPayment.Text = j
        Calcul()

        Dim rowExists As Boolean = False
        Try
            For Each row As DataGridViewRow In DGV.Rows
                If Not row.IsNewRow AndAlso row.Cells(0).Value.ToString() = txtCodSupplier.Text AndAlso row.Cells(3).Value.ToString() = cmbPaymentMode.Text Then
                    Update()
                    rowExists = True
                    Exit For
                End If
            Next
        Catch ex As Exception

        End Try



        If Not rowExists Then
            DGV.Rows.Add(txtCodSupplier.Text, txtCodeSup.Text, txtNameSup.Text, cmbPaymentMode.Text, dtpPaymentDate.Text, txtTotalPayment.Text, txtPaymentDue.Text)
        End If
    End Sub

    Private Sub btnnew_Click() Handles btnNew.Click
        DGV.DataSource = ""
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
    Private Sub Update()
        Dim codSupplier = Val(txtCodSupplier.Text)
        For Each row As DataGridViewRow In DGV.Rows
            row.Cells(5).Value = txtTotalPayment.Text
            row.Cells(6).Value = txtPaymentDue.Text
            Exit For

        Next
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

            SupplierAccDAL.Insertar(Me.SupplierAcc, "Insert_SuppAcc")
        Next
    End Sub

    Private Sub txtCodeSup_TextChanged(sender As Object, e As EventArgs) Handles txtCodeSup.TextChanged
        Dim nembreOnly As String = ""
        For Each ch As Char In txtCodeSup.Text
            If Char.IsDigit(ch) Then
                nembreOnly &= ch
            End If

            txtCodSupplier.Text = nembreOnly
        Next
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