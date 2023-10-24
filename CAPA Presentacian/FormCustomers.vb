Imports System.IO

Public Class FormCustomers
    Private Comfunction As New ComFunction
    Private Customer As New Customer
    Private CustomerDAL As New CustomerDAL

    'Public Sub New(ByVal Customer As Customer)
    '    InitializeComponent()
    '    Me.Customer = Customer
    'End Sub

    Private Sub SetCustomerValue()
        With Customer
            .code = Val(txt_CustomerID.Text)
            .Name = txt__CustomerName.Text

            .Adress = txt_Adress.Text
            .City = txt_City.Text
            .Zip = txt_Zip.Text
            .contact = Val(txt_Contact.Text)
            .State = txt_State.Text
            .Email = txt_Email.Text
            .Notes = txt_Notes.Text
            If btn_female.Checked = True Then
                .Gender = "Femal"
            End If
            If btn_male.Checked = True Then
                .Gender = "Male"
            End If
        End With
    End Sub

    Private Sub RestForm()
        txt_CustomerID.Focus()
        Comfunction.ClearTextboxes(GroupBox1)
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        SetCustomerValue()
        If PictureBox1.Image IsNot Nothing Then
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            Customer.photo = ms.ToArray()
        End If
        CustomerDAL.Insertar(Me.Customer)
        txt_CustomerID.Text = Comfunction.CODE_GEN("Customer", "Customer_id") + 1
    End Sub

    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        SetCustomerValue()
        If PictureBox1.Image IsNot Nothing Then
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            Customer.photo = ms.ToArray()
        End If
        CustomerDAL.Update(Me.Customer)
        FormCustomers_Load(sender, e)
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        Customer.code = Val(txt_CustomerID.Text)
        CustomerDAL.delete(Me.Customer, "Delete_Customer")
        RestForm()
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Close()
    End Sub




    Private Sub FormCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_CustomerID.Text = Comfunction.CODE_GEN("Customer", "Customer_id") + 1

    End Sub


    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btn_New.Click
        Comfunction.ClearTextboxes(GroupBox1)
        txt_CustomerID.Text = Comfunction.CODE_GEN("Customer", "Customer_id") + 1
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
        ComFunction.AllowOnlyNumbre(e)
    End Sub


    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btn_Show.Click
        FormCustomerListe.lbl.Text = "FC"
        FormCustomerListe.ShowDialog()
    End Sub

End Class