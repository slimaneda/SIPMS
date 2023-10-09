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
        txt_Productid.Focus()
    End Sub
    Sub Value_Class()
        cls.code = Val(txt_Productid.Text)
        cls.name = txt_productname.Text
        cls.item = txt_item.Text
        cls.minrecord = Val(txt_minrecord.Text)
        cls.qty = Val(txt_qty.Text)
        cls.notes = txt_notes.Text

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Value_Class()
        cls.Save_update("Insert_Product")
        MsgBox("insert done")
    End Sub



    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Value_Class()
        cls.Save_update("Update_Product")
        MsgBox("Update done")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        cls.code = Val(txt_Productid.Text)
        cls.deletedata("Delete_Product")
        MsgBox("Delete done")
    End Sub


    Private Sub FormProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cls.item_combobox("Select_Items_name", txt_item)
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        FormProductShow.lbl.Text = "b"
        FormProductShow.ShowDialog()

    End Sub
End Class