Imports System.Data.SqlClient

Public Class LoginForm1
    Private User As New User
    Private UserDal As New UserDal



    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Dim sds(10) As Boolean

        Dim currentUser As New User With
        {
            .Username = TXTUsername.Text.Trim(),
            .Password = TXTPassword.Text.Trim(),
            .d1 = sds(0),
            .d2 = sds(1),
            .d3 = sds(2),
            .d4 = sds(3),
            .d5 = sds(4),
            .d6 = sds(5),
            .d7 = sds(6),
            .d8 = sds(7),
            .d9 = sds(8),
            .d10 = sds(9),
            .d11 = sds(10)
            }
        '.d12 = sds(11),
        '.d13 = sds(12),
        '.d14 = sds(13),
        '.d15 = sds(14)
        '}

        Dim exists As Boolean = UserDal.Verify(currentUser)

        If exists Then

            Dim menuItems() As ToolStripMenuItem = {FormMain.btn_user, FormMain.btn_items, FormMain.btn_database, FormMain.btn_customer, FormMain.btn_supplier,
                                       FormMain.btn_Product, FormMain.btnPurchas, FormMain.btnsupplierpayement, FormMain.btnQuatation, FormMain.btnreciept,
                                       FormMain.btncompany}

            For i As Integer = 0 To 10
                menuItems(i).Enabled = sds(i)
            Next

            FormMain.ShowDialog()
            Me.Close()
        Else
            MsgBox("Username or Password is incorrect.")
        End If

    End Sub


    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub


End Class
