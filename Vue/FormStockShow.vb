Imports System.Data.SqlClient
Public Class FormStockShow
    Private Sub FormStockShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Show_DGV(DGV, "Selecte_Stock")

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()

    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        For Each row As DataGridViewRow In DGV.Rows


            With FormPurchasProduct

                .txtCodeFacture.Text = row.Cells(0).Value
                .txtDate.Text = row.Cells(1).Value
                .txtCodeSup.Text = row.Cells(2).Value
                .txtNameSup.Text = row.Cells(3).Value.ToString
                .txtCodePt.Text = row.Cells(4).Value
                .txtNamePt.Text = row.Cells(5).Value.ToString
                .txtQty.Text = row.Cells(6).Value
                .txtPricePerQty.Text = row.Cells(7).Value
                .txtTotalAmount.Text = row.Cells(8).Value
                .txtTotalPayment.Text = row.Cells(9).Value
                .txtPaymentDue.Text = row.Cells(10).Value
                .txtRemarks.Text = row.Cells(11).Value.ToString
            End With
        Next


        Close()
    End Sub




    Private Sub DGV_CellEnte()
        Using cmd As New SqlCommand(" Select dbo.SuppAcc.* From dbo.SuppAcc", sqlcon)
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            DGV.DataSource = dt
        End Using
    End Sub
End Class