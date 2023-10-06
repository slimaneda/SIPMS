Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class FormSupplier
    Private cls As New ClassSupplier
    Private Sub SetCustomerValue()

        cls.code = Val(txt_SupplierID.Text)
        cls.Name = txt__SupplierName.Text

        cls.Adress = txt_Adress.Text
        cls.City = txt_City.Text
        cls.Zip = Val(txt_State.Text)
        cls.Contact = Val(txt_Contact.Text)
        cls.state = txt_State.Text
        cls.Email = txt_Email.Text
        cls.Notes = txt_Notes.Text
        cls.Photofrst = PictureBox1.Image
        If btn_female.Checked = True Then
            cls.Gender = "Femal"
        End If
        If btn_male.Checked = True Then
            cls.Gender = "Male"
        End If
    End Sub
    Private Sub rest()
        txt_SupplierID.Focus()


        ' clean textbox & maskedtextbox
        For Each clt As Control In GroupBox1.Controls
            If TypeOf clt Is TextBox Then
                clt.Text = ""
            End If
        Next
        For Each clm As Control In GroupBox1.Controls
            If TypeOf clm Is MaskedTextBox Then

                clm.Text = ""
            End If
        Next

    End Sub
    Private Sub FormSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rest()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btn_Show.Click
        FormSupplierShow.ShowDialog()
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

    Private Sub btn_New_Click(sender As Object, e As EventArgs) Handles btn_New.Click
        rest()
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        SetCustomerValue()
        cls.Save_Update("Insert_Supplier")

    End Sub

    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        SetCustomerValue()
        cls.Save_Update("Update_Supplier")

    End Sub


End Class