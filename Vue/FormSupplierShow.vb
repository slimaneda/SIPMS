Public Class FormSupplierShow
    Dim cls As New SupplierDao
    Private Sub FormSupplierShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_searchId.Focus()


        If lbl.Text = "FSP" Then
            Show_DGV(DGV, "Select_Supplier_Vue")
        Else
            Show_DGV(DGV, "Select_Supplier")
        End If
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        If e.RowIndex >= 0 AndAlso lbl.Text = "FSP" Then
            Dim row = DGV.Rows(e.RowIndex)
            With FormSupplierPayement
                .txtCodeSup.Text = row.Cells(0).Value
                .txtNameSup.Text = row.Cells(1).Value
                .txtGrandTotal.Text = row.Cells(4).Value
            End With
        End If
        lbl.Text = ""
        For i = 0 To DGV.Rows.Count - 1
            If i >= 0 AndAlso lbl.Text = "FPP" Then
                FormPurchasProduct.txtCodeSup.Text = DGV.Rows(i).Cells(0).Value
                FormPurchasProduct.txtNameSup.Text = DGV.Rows(i).Cells(1).Value
            End If
        Next


        If e.RowIndex >= 0 AndAlso lbl.Text = "frmSupplier" Then
            FormSupplier.txt_SupplierID.Text = DGV.Rows(e.RowIndex).Cells(0).Value
            FormSupplier.txt__SupplierName.Text = DGV.Rows(e.RowIndex).Cells(1).Value


            FormSupplier.txt_State.Text = DGV.Rows(e.RowIndex).Cells(3).Value
            FormSupplier.txt_Adress.Text = DGV.Rows(e.RowIndex).Cells(4).Value
            FormSupplier.txt_City.Text = DGV.Rows(e.RowIndex).Cells(5).Value
            FormSupplier.txt_Zip.Text = DGV.Rows(e.RowIndex).Cells(6).Value
            FormSupplier.txt_Contact.Text = DGV.Rows(e.RowIndex).Cells(7).Value
            FormSupplier.txt_Email.Text = DGV.Rows(e.RowIndex).Cells(8).Value
            FormSupplier.txt_Notes.Text = DGV.Rows(e.RowIndex).Cells(9).Value
            ' FormSupplier.PictureBox1.Image = DGV.Rows(e.RowIndex).Cells(10).Value



            If DGV.Rows(e.RowIndex).Cells(2).Value = "Femal" Then
                FormSupplier.btn_female.Checked = True
            End If

            If DGV.Rows(e.RowIndex).Cells(2).Value = "Male" Then
                FormSupplier.btn_male.Checked = True
            End If

            If e.RowIndex >= 0 AndAlso lbl.Text = "b" Then
            End If
        End If


        Close()


    End Sub

End Class