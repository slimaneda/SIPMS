Imports System.IO

Public Class FormCompany

    Sub rest()






        For Each clt As Control In Panel2.Controls
            If TypeOf clt Is TextBox Then
                clt.Text = ""
            End If
        Next


        PictureBox1.Image = My.Resources.Sans_titre
        txt_Companyname.Focus()
        Show_DGV(DGV1, "Select_Company")
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        rest()
    End Sub

    Private Sub FormCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rest()

    End Sub
    Private Cls As New ClassCompany
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Cls.Name_company = txt_Companyname.Text
        Cls.Adress = txt_Adress.Text
        Cls.Contact = txt_Contact.Text
        Cls.Email = txt_Email.Text
        Cls.TIN = txt_TIN.Text
        Cls.ST = txt_STN.Text
        Cls.CIN = txt_CIN.Text

        Cls.Save("Insert_Company")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
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

        Cls.DeleteCompany("Delete_Company")
        rest()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txt_Companyname.Text = "" Then
            MessageBox.Show("Please enter company name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_Companyname.Focus()
            Return
        End If
        Cls.Save("UPDATE_Company")
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellClick
        If e.RowIndex >= 0 Then


            txt_Companyname.Text = DGV1.Rows(e.RowIndex).Cells(0).Value.ToString()
            txt_Adress.Text = DGV1.Rows(e.RowIndex).Cells(1).Value.ToString()
            txt_Contact.Text = DGV1.Rows(e.RowIndex).Cells(2).Value.ToString()
            txt_Email.Text = DGV1.Rows(e.RowIndex).Cells(3).Value.ToString()
            txt_TIN.Text = DGV1.Rows(e.RowIndex).Cells(4).Value.ToString()
            txt_STN.Text = DGV1.Rows(e.RowIndex).Cells(5).Value.ToString()
            txt_CIN.Text = DGV1.Rows(e.RowIndex).Cells(6).Value.ToString()

            Dim data As Byte() = DirectCast(DGV1.Rows(e.RowIndex).Cells(7).Value, Byte())
            Dim ms As New MemoryStream(data)
            Me.PictureBox1.Image = Image.FromStream(ms)

        End If
    End Sub


End Class