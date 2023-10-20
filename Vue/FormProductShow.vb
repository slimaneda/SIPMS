Public Class FormProductShow
    Private Const FPS As String = "FormStock_Product"
    Private Const FB As String = "FB"
    Private Const B As String = "b"


    Private Sub FormProductShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case lbl.Text
            Case FPS, B
                Show_DGV(DGV1, "Select_Pt")
            Case FB
                Show_DGV(DGV, "Select_StockProductSum")
        End Select
    End Sub

    Private Sub DGV1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellClick

        Select Case lbl.Text
            Case FB
                SetFormQuotationValues(e.RowIndex)
            Case FPS
                SetFormStockValues(e.RowIndex)
            Case B
                SetFormProductValues(e.RowIndex)
        End Select

        lbl.Text = ""
        Me.Close()
    End Sub


    Private Sub SetFormQuotationValues(rowIndex As Integer)
        With FormQuotation
            .txtProductCode.Text = DGV.Rows(rowIndex).Cells(0).Value
            .txtProductName.Text = DGV.Rows(rowIndex).Cells(1).Value
            .txtQty.Text = DGV.Rows(rowIndex).Cells(2).Value
        End With
    End Sub

    Private Sub SetFormStockValues(rowIndex As Integer)
        With formStock
            .txtCodePt.Text = DGV1.Rows(rowIndex).Cells(0).Value
            .txtNamePt.Text = DGV1.Rows(rowIndex).Cells(1).Value
            .txtQty.Text = DGV1.Rows(rowIndex).Cells(4).Value
        End With
    End Sub

    Private Sub SetFormProductValues(rowIndex As Integer)
        With FormProduct
            .txt_Productid.Text = DGV.Rows(rowIndex).Cells(0).Value
            .txt_productname.Text = DGV.Rows(rowIndex).Cells(1).Value
            .txt_qty.Text = DGV.Rows(rowIndex).Cells(4).Value
        End With
    End Sub


End Class