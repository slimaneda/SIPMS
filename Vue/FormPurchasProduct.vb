Imports System.Data.SqlClient
Imports System.Runtime.Intrinsics.Arm

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

        sqlcon.Open()
        Dim cmd As New SqlClient.SqlCommand("Srlrct_StockCF", sqlcon)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@d1", SqlDbType.Int).Value = Val(txtCodeFacture.Text)
        Dim exists = Convert.ToBoolean(cmd.ExecuteScalar())


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
        sqlcon.Close()
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

    Dim QTY As Double
    Dim PRIC As Double
    Dim TOTAL As Double
    Private Sub CalculTotal()
        If Double.TryParse(txtPricePerQty.Text, PRIC) AndAlso Double.TryParse(txtQty.Text, QTY) Then
            TOTAL = QTY * PRIC
            txtTotalAmount.Text = TOTAL
            txtGrandTotal.Text = TOTAL

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
    Dim cls As New StockDao



    Private Sub btnsave1_Click(sender As Object, e As EventArgs) Handles btnsave1.Click
        sqlcon.Open()

        If ValidateData() Then
            Try
                UpdateOrInsertTempStock() 'bien effectue
                InsertIntoStock()
                InsertIntoSuppAcc()
                InsertIntoStockProduct()
                sqlcon.Close()
                MsgBox("الحفظ تم بنجاح", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox("حدث خطأ: " & ex.Message, MsgBoxStyle.Critical)
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

    Private Sub UpdateOrInsertTempStock()
        ' ici possible de supprimer selectProc & insertProc 
        Dim selectProc As String = "Select_Temp_StockID"
        Dim updateProc As String = "Update_Tempstock"
        Dim insertProc As String = "Insert_TempPt"

        For Each row As DataGridViewRow In DGV.Rows
            If Not row.IsNewRow Then
                Using cmd As New SqlCommand(selectProc, sqlcon) ' (1) selecte
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@d1", SqlDbType.Int).Value = txtCodePt.Text

                    Dim exists = Convert.ToBoolean(cmd.ExecuteScalar())
                    If exists Then
                        cmd.CommandText = updateProc                '(2) Update
                    Else
                        cmd.CommandText = insertProc                 '(3) Inseret 
                    End If

                    cmd.Parameters.Clear()
                    cmd.Parameters.Add("@Product_ID", SqlDbType.Int).Value = row.Cells(5).Value
                    cmd.Parameters.Add("@Quantity", SqlDbType.Decimal, 18, 2).Value = Val(row.Cells(7).Value)
                    cmd.ExecuteNonQuery()
                End Using
            End If
        Next
    End Sub      ' save in tempStock

    Private Sub InsertIntoStock()

        For Each row As DataGridViewRow In DGV.Rows


            cls.Code_stockid = row.Cells(0).Value    'cls =classStock
            cls.code_facture = row.Cells(1).Value
            cls.Date_purchase = row.Cells(2).Value
            cls.Code_Sup = row.Cells(3).Value
            cls.Name_Sup = row.Cells(4).Value

            cls.Code_pt = row.Cells(5).Value
            cls.Name_pt = row.Cells(6).Value
            cls.Quantity_Pt = Val(row.Cells(7).Value)
            cls.Price_Pt = Val(row.Cells(8).Value)
            cls.TOTALamont = Val(row.Cells(9).Value)

            cls.TOTALPayement = Val(row.Cells(10).Value)
            cls.TOTALPayementdue = Val(row.Cells(11).Value)

            cls.NOTES = row.Cells(12).Value

            cls.save_Update("Insert_Stock")

        Next
    End Sub

    Private Sub InsertIntoSuppAcc()

        Using cmd As New SqlCommand("Insert_SuppAcc", sqlcon)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add("@Sup_id", SqlDbType.Int).Value = txtCodeSup.Text

            cmd.Parameters.AddWithValue("@Sup_Name", txtNameSup.Text)

            cmd.Parameters.AddWithValue("@Detail", txtDate.Value.Date)
            For i = 0 To DGV.Rows.Count - 1
                cmd.Parameters.AddWithValue("@inv", "Facture D'achat N° " + DGV.Rows(i).Cells(0).Value)
            Next
            cmd.Parameters.AddWithValue("@debit", Val(txtTotalPayment.Text))
            cmd.Parameters.AddWithValue("@credit", Val(txtGrandTotal.Text))

            cmd.ExecuteNonQuery()

        End Using
    End Sub

    Private Sub InsertIntoStockProduct()
        Dim query As String = "INSERT INTO Stock_Product(StockID, ProductID, ProductName, Qty, Price, TotalAmount) VALUES (@d2, @d3, @d4, @d5,@d1,@d6)"
        Using cmd As New SqlCommand(query, sqlcon)


            For Each row As DataGridViewRow In DGV.Rows
                If Not row.IsNewRow Then


                    cmd.Parameters.AddWithValue("@d2", Val(txtCodeFacture.Text))
                    cmd.Parameters.AddWithValue("@d3", Val(txtCodePt.Text))
                    cmd.Parameters.AddWithValue("@d4", txtNamePt.Text)
                    cmd.Parameters.AddWithValue("@d5", Val(txtQty.Text))
                    cmd.Parameters.AddWithValue("@d1", Val(txtPricePerQty.Text))
                    cmd.Parameters.AddWithValue("@d6", Val(txtTotalAmount.Text))

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

End Class