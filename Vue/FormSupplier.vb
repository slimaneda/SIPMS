Imports System.IO

Public Class FormSupplier
    Private Supplier As New Supplier
    Private SupplierDAL As New SupplierDAL
    Sub New()
        InitializeComponent()
        Me.Supplier = Supplier
    End Sub
    Private Sub SetCustomerValue()
        With Supplier
            .code = txt_SupplierID.Text
            .Name = txt__SupplierName.Text
            .Adress = txt_Adress.Text
            .City = txt_City.Text
            .Zip = txt_State.Text
            .contact = txt_Contact.Text
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
        txt__SupplierName.Focus()
        ClearTextboxes(GroupBox1)
        For Each clm As Control In GroupBox1.Controls
            If TypeOf clm Is MaskedTextBox Then
                clm.Text = ""
            End If
        Next
        txt_SupplierID.Text = CODE_GEN("Supplier", "SupplierId") + 1
    End Sub

    Private Sub FormSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RestForm()
    End Sub

    Private Sub btn_New_Click(sender As Object, e As EventArgs) Handles btn_New.Click
        RestForm()
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If PictureBox1.Image IsNot Nothing Then
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            Supplier.photo = ms.ToArray()
        End If
        SetCustomerValue()
        SupplierDAL.Create(Me.Supplier)
        RestForm()
    End Sub

    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        If PictureBox1.Image IsNot Nothing Then
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            Supplier.photo = ms.ToArray()
        End If
        SetCustomerValue()
        SupplierDAL.update(Me.Supplier)
        RestForm()
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
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btn_Show.Click
        FormSupplierShow.lbl.Text = "frmSupplier"
        FormSupplierShow.ShowDialog()
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        Supplier.code = txt_SupplierID.Text
        SupplierDAL.Delete(Me.Supplier)
        RestForm()
    End Sub

    Private Sub text_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_State.KeyPress, txt_Contact.KeyPress, txt_SupplierID.KeyPress
        AllowOnlyNumbre(e)
    End Sub
End Class