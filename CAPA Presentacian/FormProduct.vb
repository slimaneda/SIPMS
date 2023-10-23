Public Class FormProduct
    Private Comfunction As New ComFunction
    Private Product As New Product
    Private ProductDAL As New ProductDAL
    Private Sub GetProductValue()
        With Product
            .Code = Val(txt_Productid.Text)
            .Name = txt_productname.Text
            .items = txt_item.Text
            .minirecord = Val(txt_minrecord.Text)
            .Quantity = Val(txt_qty.Text)
        End With
    End Sub

    Private Sub FormProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_Productid.Text = Comfunction.CODE_GEN("Product", "Product_ID") + 1
        Comfunction.Show_COMBO("select_items", txt_item, "Name Item")
        txt_Productid.Focus()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Comfunction.ClearTextboxes(Panel2)
        txt_Productid.Text = Comfunction.CODE_GEN("Product", "Product_ID") + 1
        txt_Productid.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        GetProductValue()
        ProductDAL.create(Me.Product)
        MsgBox("insert done")
        btnNew_Click(sender, e)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        GetProductValue()
        ProductDAL.Update(Me.Product)
        MsgBox("Update done")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Product.Code = Val(txt_Productid.Text)
        ProductDAL.Delete(Me.Product)
        MsgBox("Delete done")
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        FormProductShow.lbl.Text = "b"
        FormProductShow.ShowDialog()

    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub txt_minrecord_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_minrecord.KeyPress, txt_qty.KeyPress
        ComFunction.AllowOnlyNumbre(e)
    End Sub
End Class