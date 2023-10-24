Imports System.IO

Public Class FormCustomerListe
    ' Private Comfunction As New Comfunction

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub FormCustomerListe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComFunction.Show_DGV(DGV, "Select_Customers")
    End Sub



    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        If e.RowIndex >= 0 AndAlso lbl.Text = "FC" Then
            Dim selectRow As DataGridViewRow = DGV.Rows(e.RowIndex)
            ' Populate FormCustomers fields
            With FormCustomers
                .txt_CustomerID.Text = selectRow.Cells(0).Value
                .txt__CustomerName.Text = selectRow.Cells(1).Value.ToString
                SetGender(selectRow.Cells(2).Value.ToString)
                .txt_Adress.Text = selectRow.Cells(3).Value.ToString
                .txt_City.Text = selectRow.Cells(4).Value.ToString
                .txt_State.Text = selectRow.Cells(5).Value.ToString
                .txt_Zip.Text = selectRow.Cells(6).Value
                .txt_Contact.Text = selectRow.Cells(7).Value
                .txt_Email.Text = selectRow.Cells(8).Value.ToString
                .txt_Notes.Text = selectRow.Cells(9).Value.ToString
                SetCustomerImage(selectRow.Cells(10))
            End With
            lbl.Text = ""
        End If
        Close()

        If e.RowIndex >= 0 AndAlso lbl.Text = "FB" Then
            With FormQuotation
                .txtCustomerID.Text = DGV.Rows(e.RowIndex).Cells(0).Value
                .txtCustomerName.Text = DGV.Rows(e.RowIndex).Cells(1).Value.ToString
                .txtContactNo.Text = DGV.Rows(e.RowIndex).Cells(7).Value
            End With
        End If
        lbl.Text = ""
        Close()
    End Sub
    Private Sub SetCustomerImage(cell As DataGridViewCell)
        Dim data As Byte() = DirectCast(cell.Value, Byte())
        Dim ms As New MemoryStream(data)
        FormCustomers.PictureBox1.Image = Image.FromStream(ms)
    End Sub


    Private Sub setGender(gender As String)
        Select Case gender
            Case "Male"
                FormCustomers.btn_male.Checked = True
            Case "Femal"
                FormCustomers.btn_female.Checked = True
        End Select
    End Sub
End Class