Imports System.IO

Public Class FormCompany
    Private CompanyDAL As New CompanyDAL
    Private COMPANY As New Company

    Sub clear()
        ComFunction.ClearTextboxes(Panel2)
        PictureBox1.Image = My.Resources.Sans_titre
        txt_Companyname.Focus()
        ' Comfunction.Show_DGV(DGV1, "Select_Company")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        clear()
        btnSave.Enabled = True
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub FormCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear()

    End Sub
    Private Cls As New CompanyDAL


    Private Sub btn_browse_click(sender As Object, e As EventArgs) Handles btn_browse.Click
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


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        'Cls.DeleteCompany("Delete_Company")
        clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txt_Companyname.Text = "" Then
            MessageBox.Show("Please enter company name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_Companyname.Focus()
            Return
        End If
        ' Cls.Save("UPDATE_Company")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


        With COMPANY

            .Name_Company = txt_Companyname.Text
            .adress = txt_Adress.Text
            .Contact = txt_Contact.Text
            .EMail = txt_Email.Text
            .TIN = txt_TIN.Text
            .ST = txt_STN.Text
            .CIN = txt_CIN.Text
        End With
        If PictureBox1.Image IsNot Nothing Then
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            COMPANY.photo = ms.ToArray()
        End If

        CompanyDAL.Insertar(COMPANY)

        MsgBox("save don ")

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        FormGetData.lbl.Text = "F_Company"
        FormGetData.ShowDialog()
    End Sub

End Class