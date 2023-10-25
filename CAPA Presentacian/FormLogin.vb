Imports System.Data.SqlClient

Public Class FormLogin

    Private User As New User
    Private UserDal As New UserDal




    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim currentUser As New User With {
            .Username = ComboUser.Text.Trim(),
            .Password = TXTPassword.Text.Trim()
        }
        Dim exists As Boolean = UserDal.Verify(currentUser)
        If exists Then
            User.Username = ComboUser.Text.Trim()
            User.Password = TXTPassword.Text.Trim()
            Dim dr As DataRow = UserDal.getser(User)

            If dr IsNot Nothing Then

                With FormMain
                    .btn_user.Enabled = dr!d1
                    .btn_database.Enabled = dr!d2
                    .btncompany.Enabled = dr!d3
                    .btn_items.Enabled = dr!d4
                    .btn_supplier.Enabled = dr!d5
                    .btnreciept.Enabled = dr!d6
                    .btn_Product.Enabled = dr!d7
                    .btn_customer.Enabled = dr!d8
                    .btnPurchas.Enabled = dr!d9
                    .btnsupplierpayement.Enabled = dr!d10
                    .btnQuatation.Enabled = dr!d11
                End With
                With FormUser
                    .btnNew.Enabled = dr!d12
                    .btnSave.Enabled = dr!d13
                    .btnUpdate.Enabled = dr!d14
                    .btnClose.Enabled = dr!d15
                End With

                FormMain.ShowDialog()
                FormMain.Close()
            Else
                MsgBox("Username or Password is incorrect.")
            End If
        End If
    End Sub



    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComFunction.Show_COMBO("Select_User", ComboUser, "Username")
    End Sub


End Class
