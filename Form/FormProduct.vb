Public Class FormProduct
    Dim cls As New ClassProduct
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        For Each clt As Control In Panel2.Controls

            If TypeOf clt Is TextBox Then
                clt.Text = ""
            End If
        Next
        txt_Productid.Text = CODE_GEN("Product", "Product_ID") + 1

        txt_Productid.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        cls.code = Val(txt_Productid.Text)
        cls.name = txt_productname.Text
        cls.item = txt_item.Text
        cls.minrecord = Val(txt_minrecord.Text)
        cls.qty = Val(txt_qty.Text)


        cls.Save_update("Insert_Product")
        MsgBox("insert done")
        btnNew_Click(sender, e)
    End Sub



    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        cls.code = Val(txt_Productid.Text)
        cls.name = txt_productname.Text
        cls.item = txt_item.Text
        cls.minrecord = Val(txt_minrecord.Text)
        cls.qty = Val(txt_qty.Text)


        cls.Save_update("Update_Product")
        MsgBox("Update done")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        cls.code = Val(txt_Productid.Text)
        cls.deletedata("Delete_Product")
        MsgBox("Delete done")
    End Sub


    Private Sub FormProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_Productid.Text = CODE_GEN("Product", "Product_ID") + 1

        Show_COMBO("select_items", txt_item, "Name Item")
        txt_Productid.Focus()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        FormProductShow.lbl.Text = "b"
        FormProductShow.ShowDialog()

    End Sub
End Class