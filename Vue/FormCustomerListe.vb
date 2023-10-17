Imports System.IO

Public Class FormCustomerListe


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub FormCustomerListe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Show_DGV(DGV, "Select_Customers")
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick


        If e.RowIndex >= 0 AndAlso lbl.Text = "FC" Then
            With FormCustomers


                Dim selectRow As DataGridViewRow = DGV.Rows(e.RowIndex)
                .txt_CustomerID.Text = selectRow.Cells(0).Value
                .txt__CustomerName.Text = DGV.Rows(e.RowIndex).Cells(1).Value.ToString



                setGender(selectRow.Cells(2).Value.ToString)
                .txt_Adress.Text = selectRow.Cells(3).Value.ToString
                .txt_City.Text = selectRow.Cells(4).Value.ToString
                .txt_State.Text = selectRow.Cells(5).Value
                .txt_Zip.Text = selectRow.Cells(6).Value.ToString
                .txt_Contact.Text = selectRow.Cells(7).Value
                .txt_Email.Text = selectRow.Cells(8).Value.ToString
                .txt_Notes.Text = selectRow.Cells(9).Value.ToString
                Dim data As Byte() = DirectCast(selectRow.Cells(10).Value, Byte())
                Dim ms As New MemoryStream(data)
                .PictureBox1.Image = Image.FromStream(ms)
            End With
            lbl.Text = ""

        End If
        Close()


        If e.RowIndex >= 0 AndAlso lbl.Text = "FB" Then
            With frmBilling


                .txtCustomerID.Text = DGV.Rows(e.RowIndex).Cells(0).Value
                .txtCustomerName.Text = DGV.Rows(e.RowIndex).Cells(1).Value.ToString
                .txtContactNo.Text = DGV.Rows(e.RowIndex).Cells(7).Value

            End With
        End If
        lbl.Text = ""
        Close()
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