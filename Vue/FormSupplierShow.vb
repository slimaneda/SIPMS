Public Class FormSupplierShow



    Private Sub FormSupplierShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_searchId.Focus()

        If lbl.Text = "FSP" Then
            Show_DGV(DGV, "Select_Supplier_Vue")
        Else
            Show_DGV(DGV1, "Select_Supplier")
        End If
    End Sub


    Private Sub DGV1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellClick
        If e.RowIndex < 0 Then Return

        Dim row = DGV1.Rows(e.RowIndex)

        Select Case lbl.Text
            Case "FSP"
                UpdateFormSupplierPayment(row)
            Case "formStock"
                UpdateFormStock(e.RowIndex)
            Case "frmSupplier"
                UpdateFormSupplier(row)
            Case Else
                ' Handle other cases if necessary
        End Select

        lbl.Text = ""
        Close()
    End Sub

    Private Sub UpdateFormSupplierPayment(row As DataGridViewRow)
        With FormSupplierPayement
            .txtCodeSup.Text = row.Cells(0).Value
            .txtNameSup.Text = row.Cells(1).Value
            .txtGrandTotal.Text = row.Cells(4).Value
        End With
    End Sub

    Private Sub UpdateFormStock(rowIndex As Integer)

        FormStock.txtCodeSup.Text = DGV1.Rows(rowIndex).Cells(0).Value
        FormStock.txtNameSup.Text = DGV1.Rows(rowIndex).Cells(1).Value

    End Sub

    Private Sub UpdateFormSupplier(row As DataGridViewRow)
        With FormSupplier
            .txt_SupplierID.Text = row.Cells(0).Value
            .txt__SupplierName.Text = row.Cells(1).Value
            .txt_State.Text = row.Cells(3).Value
            .txt_Adress.Text = row.Cells(4).Value
            .txt_City.Text = row.Cells(5).Value
            .txt_zip.Text = row.Cells(6).Value
            .txt_Contact.Text = row.Cells(7).Value
            .txt_Email.Text = row.Cells(8).Value
            .txt_Notes.Text = row.Cells(9).Value
            ' .PictureBox1.Image = row.Cells(10).Value

            If row.Cells(2).Value = "Femal" Then .btn_female.Checked = True
            If row.Cells(2).Value = "Male" Then .btn_male.Checked = True
        End With
    End Sub

    Private Sub DGV1_Click(sender As Object, e As EventArgs) Handles DGV1.Click

    End Sub

End Class