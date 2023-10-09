Public Class FormPurchasProduct
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormProductShow.lbl.Text = "FPP"
        FormProductShow.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormSupplierShow.lbl.Text = "FPP"
        FormSupplierShow.ShowDialog()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If DGV.Rows.Count >= 0 AndAlso Not txtCodeFacture.Text = "" Then
            DGV.Rows.Add(txtCodeFacture.Text, txtDate.Text, txtCodeSup.Text, txtNameSup.Text, txtCodePt.Text, txtNamePt.Text, txtQty.Text, Val(txtPricePerQty.Text), Val(txtTotalAmount.Text), Val(txtTotalPayment.Text), Val(txtPaymentDue.Text), txtRemarks.Text)
        Else
            MsgBox("insert Code facture")
            Exit Sub
        End If
    End Sub


    Private Sub txtPricePerQty_TextChanged(sender As Object, e As EventArgs) Handles txtPricePerQty.TextChanged
        txtTotalAmount.Text = ""

        Try
            txtTotalAmount.Text = Val(txtPricePerQty.Text) * Val(txtQty.Text)
        Catch ex As Exception

        End Try
        txtGrandTotal.Text = txtTotalAmount.Text
    End Sub

    Private Sub txtPricePerQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPricePerQty.KeyPress
        If (Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ".") Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        If (Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ".") Then
            e.Handled = True
        End If
    End Sub
    Dim k As Double = 0


    Private Sub txtTotalPayment_TextChanged(sender As Object, e As EventArgs) Handles txtTotalPayment.TextChanged
        If Not txtGrandTotal.Text = "" Then

            '  txtPaymentDue.Text = Val(txtGrandTotal.Text - txtTotalPayment.Text)

        End If

    End Sub

    Private Sub btnGetData_Click(sender As Object, e As EventArgs) Handles btnGetData.Click
        FormStockShow.ShowDialog()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        For Each row As DataGridViewRow In DGV.SelectedRows
            DGV.Rows.Remove(row)
        Next
    End Sub
    Dim cls As New ClassStock
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            For i = 0 To DGV.Rows.Count - 1
                cls.Code_stockid = DGV.Rows(i).Cells(0).Value
                cls.Date_purchase = DGV.Rows(i).Cells(1).Value
                cls.Code_Sup = DGV.Rows(i).Cells(2).Value
                cls.Name_Sup = DGV.Rows(i).Cells(3).Value

                cls.Code_pt = DGV.Rows(i).Cells(4).Value
                cls.Name_pt = DGV.Rows(i).Cells(5).Value
                cls.Quantity_Pt = Val(DGV.Rows(i).Cells(6).Value)
                cls.Price_Pt = Val(DGV.Rows(i).Cells(7).Value)
                cls.TOTALamont = Val(DGV.Rows(i).Cells(8).Value)

                cls.TOTALPayement = Val(DGV.Rows(i).Cells(9).Value)
                cls.TOTALPayementdue = Val(DGV.Rows(i).Cells(10).Value)

                cls.NOTES = DGV.Rows(i).Cells(11).Value



                cls.save_Update("Insert_Stock")
                MsgBox(" save reussite")
            Next
        Catch ex As Exception

        End Try






    End Sub

    Private Sub Clean()
        For Each clt As Control In GroupBox1.Controls
            If TypeOf clt Is TextBox Then
                clt.Text = ""
            End If
        Next

        For Each clt As Control In GroupBox2.Controls
            If TypeOf clt Is TextBox Then
                clt.Text = ""
            End If
        Next
        txtGrandTotal.Text = ""
        txtTotalPayment.Text = ""
        txtPaymentDue.Text = ""
        txtRemarks.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cls.Code_stockid = txtCodeFacture.Text.Trim
        cls.deletdata("Delete_Stock")
        MsgBox("dellete effectuee")
        Clean()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Clean()
    End Sub
End Class