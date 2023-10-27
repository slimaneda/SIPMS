Public Class formSetting
    Private user As New User
    Private userdal As New UserDal

    Sub parametre()
        user.Username = txt_productname.Text
        user.Password = txt_Productid.Text
        user.d1 = CheckBox1.Checked
        user.d2 = CheckBox2.Checked
        user.d3 = CheckBox3.Checked
        user.d4 = CheckBox4.Checked
        user.d5 = CheckBox5.Checked
        user.d6 = CheckBox6.Checked
        user.d7 = CheckBox7.Checked
        user.d8 = CheckBox8.Checked
        user.d9 = CheckBox9.Checked
        user.d10 = CheckBox10.Checked
        user.d11 = CheckBox11.Checked
        user.d12 = CheckBox12.Checked
        user.d13 = CheckBox13.Checked
        user.d14 = CheckBox14.Checked
        user.d15 = CheckBox15.Checked


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        parametre()

        userdal.insert(user)
        ComFunction.Show_DGV(DGV, "Select_User")
    End Sub

    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComFunction.Show_DGV(DGV, "Select_User")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        user.Username = txt_productname.Text
        userdal.Delete(user)
        ComFunction.Show_DGV(DGV, "Select_User")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class