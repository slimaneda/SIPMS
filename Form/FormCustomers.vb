Imports System.IO
Public Class FormCustomers
    Dim cls As New ClassCustomer
    Private Sub SetCustomerValue()

        cls.code = Val(txt_CustomerID.Text)
        cls.Name = txt__CustomerName.Text

        cls.Adress = txt_Adress.Text
        cls.City = txt_City.Text
        cls.Zip = txt_Zip.Text
        cls.Contact = Val(txt_Contact.Text)
        cls.state = txt_State.Text
        cls.Email = txt_Email.Text
        cls.Notes = txt_Notes.Text
        cls.PictureBox1 = PictureBox1.Image
        If btn_female.Checked = True Then
            cls.Gender = "Femal"
        End If
        If btn_male.Checked = True Then
            cls.Gender = "Male"
        End If
    End Sub
    Private Sub rest()
        txt_CustomerID.Focus()



        ' clean textbox & maskedtextbox


    End Sub
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btn_Show.Click
        FormCustomerListe.lbl.Text = "FC"
        FormCustomerListe.ShowDialog()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Close()
    End Sub




    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        SetCustomerValue()
        cls.Save_Update("Update_Customer")
        FormCustomers_Load(sender, e)
    End Sub
    Private Sub FormCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_CustomerID.Text = CODE_GEN("Customer", "Customer_id") + 1

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btn_New.Click
        ClearTextboxes(GroupBox1)
        txt_CustomerID.Text = CODE_GEN("Customer", "Customer_id") + 1


    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        cls.code = Val(txt_CustomerID.Text)
        cls.DeleteData("Delete_Customer")
        rest()
    End Sub




    Private Sub btn_Browse_Click(sender As Object, e As EventArgs) Handles btn_Browse.Click
        Try
            With OpenFileDialog1
                .Filter = ("Images |*.png; *.bmp; *.jpg;*.jpeg; *.gif;*.ico;")
                .FilterIndex = 4
            End With
            'Clear the file name
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub txt_CustomerID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Zip.KeyPress, txt_CustomerID.KeyPress, txt_Contact.KeyPress
        AllowOnlyNumbre(e)
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        SetCustomerValue()
        cls.Save_Update("Insert_Customer")
        txt_CustomerID.Text = CODE_GEN("Customer", "Customer_id") + 1

    End Sub







    'Private Sub txt_search_TextChanged_1(sender As Object, e As EventArgs) Handles txt_search.TextChanged
    '    'cls.Name = FormCustomerListe.txt_search.Text
    '    cls.Search_Name("Search_Customer", FormCustomerListe.DGV)

    'End Sub


End Class