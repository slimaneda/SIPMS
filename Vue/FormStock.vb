Imports System.Data.SqlClient

Public Class FormStock
    Dim stock As New Stock
    Dim Tempstock As New TempStock
    Dim StockDAL As New StockDAL
    Dim tempStockDAL As New TempStockDAL
    Dim SupplierAcc As New SupplierAcc
    Dim SupplierAccDal As New SupplierAccDAL
    Dim stockProduct As New StockProduct
    Dim stockProductDAL As New StockProductDAl
    Dim QTY As Double
    Dim PRIC As Double
    Dim TOTAL As Double
    Sub New()
        InitializeComponent()
        Me.stock = stock
        Me.Tempstock = Tempstock
        Me.SupplierAcc = SupplierAcc
    End Sub

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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        stock.CodeStock = txtCodeFacture.Text
        Dim exists = Convert.ToBoolean(StockDAL.Reed(Me.stock, "Srlrct_StockCF"))
        If exists Then
            MsgBox("code fct deja effectuee")
        End If

        If DGV.Rows.Count >= 0 And Not String.IsNullOrEmpty(txtCodeFacture.Text) And Not exists Then
            Dim targetRow As DataGridViewRow = DGV.Rows.Cast(Of DataGridViewRow).FirstOrDefault(Function(r) r.Cells(0).Value.ToString() = txtCodeFacture.Text)
            If targetRow IsNot Nothing Then
                Updatrow(targetRow)
            End If
            If targetRow Is Nothing Then
                addRow()
            End If

        End If
        sqlcon_Close()
    End Sub


    Private Sub Updatrow(ByRef _Row As DataGridViewRow)

        With _Row
            .Cells(1).Value = TextBox1.Text
            .Cells(2).Value = txtDate.Text
            .Cells(3).Value = txtCodeSup.Text
            .Cells(4).Value = txtNameSup.Text
            .Cells(5).Value = txtCodePt.Text
            .Cells(6).Value = txtNamePt.Text
            .Cells(7).Value = txtQty.Text
            .Cells(8).Value = Val(txtPricePerQty.Text)
            .Cells(9).Value = Val(txtTotalAmount.Text)
            .Cells(10).Value = Val(txtTotalPayment.Text)
            .Cells(11).Value = Val(txtPaymentDue.Text)
            .Cells(12).Value = txtRemarks.Text

        End With

    End Sub
    Private Sub addRow()

        DGV.Rows.Add(txtCodeFacture.Text, TextBox1.Text, txtDate.Text, txtCodeSup.Text, txtNameSup.Text, txtCodePt.Text, txtNamePt.Text, txtQty.Text, Val(txtPricePerQty.Text), Val(txtTotalAmount.Text), Val(txtTotalPayment.Text), Val(txtPaymentDue.Text), txtRemarks.Text)

    End Sub



    Private Sub CalculTotal()

        If Double.TryParse(txtPricePerQty.Text, PRIC) AndAlso Double.TryParse(txtQty.Text, QTY) Then
            TOTAL = QTY * PRIC
            txtTotalAmount.Text = TOTAL.ToString
            txtGrandTotal.Text = TOTAL.ToString

        End If

    End Sub
    Private Sub txtPricePerQty_TextChanged(sender As Object, e As EventArgs) Handles txtPricePerQty.TextChanged, txtQty.TextChanged
        CalculTotal()
    End Sub



    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress, txtPricePerQty.KeyPress, txtGrandTotal.KeyPress, txtTotalPayment.KeyPress
        AllowOnlyNumbre(e)
    End Sub



    Private Sub txtTotalPayment_TextChanged(sender As Object, e As EventArgs) Handles txtTotalPayment.TextChanged
        If Not txtGrandTotal.Text.Trim = "" Then
            txtPaymentDue.Text = Val(txtGrandTotal.Text) - Val(txtTotalPayment.Text)
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



    Private Sub Button_SaveClick(sender As Object, e As EventArgs) Handles btnSave.Click
        sqlcon_Open()
        If ValidateData() Then
            Try
                UpdateOrInsertTempStock()  ' save data in tempStock don
                InsertIntoStock()          ' save data in Stock
                InsertIntoSuppAcc()         ' save in SuppAcc
                InsertIntoStockProduct()    ' save in StockProduct
                sqlcon_Close()

                MsgBox("saved Successfully", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox("error: " & ex.Message, MsgBoxStyle.Critical)
            End Try
            DGV.Rows.Clear()
            Clean()
            FormPurchasProduct_Load(sender, e)
            Show_DGV(FormMain.DGV2, "Select_SupplierSum")

        End If
    End Sub

    Private Function ValidateData() As Boolean
        If DGV.Rows.Count = 0 Then
            MsgBox("click for button Add ", MsgBoxStyle.Exclamation)
            Return False
        End If
        If String.IsNullOrEmpty(txtCodePt.Text) Then
            MsgBox("code product n'est pas insert", MsgBoxStyle.Exclamation)
            Return False
        End If

        Return True
    End Function

    Private Sub UpdateOrInsertTempStock() ' crude  cree red de ipdate

        For Each row As DataGridViewRow In DGV.Rows
            Tempstock.Code_Product = row.Cells(5).Value
            Tempstock.Quantity_Pt = Val(row.Cells(7).Value)
        Next

        Dim exists = Convert.ToBoolean(tempStockDAL.Reed(Me.Tempstock))
        If exists = True Then
            tempStockDAL.Update(Me.Tempstock)
        End If
        If exists = False Then
            tempStockDAL.Create(Me.Tempstock)
        End If
    End Sub



    Private Sub InsertIntoStock()

        For Each row As DataGridViewRow In DGV.Rows
            With stock
                .CodeStock = row.Cells(0).Value
                .CodeStockvisible = row.Cells(1).Value
                .InvoiceDate = row.Cells(2).Value
                .Code_Supplier = row.Cells(3).Value
                .Name_Supplier = row.Cells(4).Value

                .Code_Product = row.Cells(5).Value
                .Name_Product = row.Cells(6).Value
                .Quantity_Pt = Val(row.Cells(7).Value)
                .Price_Pt = Val(row.Cells(8).Value)
                .TOTALamont = Val(row.Cells(9).Value)

                .TOTALPayement = Val(row.Cells(10).Value)
                .Rest_NonPayement = Val(row.Cells(11).Value)

                .NOTES = row.Cells(12).Value
            End With
            StockDAL.Create(Me.stock)
        Next
    End Sub

    Private Sub InsertIntoSuppAcc()


        SupplierAcc.SuppId = txtCodeSup.Text
        SupplierAcc.SuppName = txtNameSup.Text
        SupplierAcc.Detail = txtDate.Value.Date
        For i = 0 To DGV.Rows.Count - 1
            SupplierAcc.Inv = "Facture D'achat N° " + DGV.Rows(i).Cells(0).Value
        Next
        SupplierAcc.Debit = txtTotalPayment.Text
        SupplierAcc.Credit = txtGrandTotal.Text
        SupplierAccDal.Create(Me.SupplierAcc)


    End Sub
    ' methode crud
    ' class  stock pruduct variable
    ' class  stock pruduct dal   function ''/ cread update delete search selecte 
    'class  shared function   synthese  قوالب     writh   scaler 
    Private Sub InsertIntoStockProduct()
        Dim query As String = "INSERT INTO Stock_Product(StockID, ProductID, ProductName, Qty, Price, TotalAmount) VALUES (@d2, @d3, @d4, @d5,@d1,@d6)"
        Using cmd As New SqlCommand(query, sqlcon)


            For Each row As DataGridViewRow In DGV.Rows
                If Not row.IsNewRow Then


                    stockProduct.StockID = txtCodeFacture.Text
                    stockProduct.ProductID = Val(txtCodePt.Text)
                    stockProduct.ProductName = txtNamePt.Text
                    stockProduct.Qty = Val(txtQty.Text
                stockProduct.Price = Val(txtPricePerQty.Text)
                    stockProduct.TotalAmount = Val(txtTotalAmount.Text)

                    cmd.ExecuteNonQuery()
                End If
            Next
        End Using
    End Sub


    Private Sub Clean()
        ClearTextboxes(GroupBox1)
        ClearTextboxes(GroupBox2)
        ClearTextboxes(Panel4)

        txtRemarks.Text = ""

    End Sub



    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Clean()
        FormPurchasProduct_Load(sender, e)
    End Sub

    Private Sub FormPurchasProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCodeFacture.Text = CODE_GEN("Stock", "Code_fct") + 1
        TextBox1.Text = "F° " & txtCodeFacture.Text
        Button4.Focus()



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim nembreOnly As String = ""
        For Each ch As Char In TextBox1.Text
            If Char.IsDigit(ch) Then
                nembreOnly &= ch
            End If
        Next
        txtCodeFacture.Text = Val(nembreOnly)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        For i = 0 To DGV.Rows.Count - 1
            stock.CodeStock = DGV.Rows(i).Cells(0).Value
            StockDAL.Delete(Me.stock)
        Next
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class