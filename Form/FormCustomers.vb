Imports System.IO

Public Class FormCustomers
    Dim cls As New ClassCustomer
    Private Sub SetCustomerValue()

        cls.code = Val(txt_CustomerID.Text)
        cls.Name = txt__CustomerName.Text

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
        txt_CustomerID.Focus()

        Show_DGV(DGV, "Select_Customers")

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
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btn_Show.Click
        FormCustomerListe.ShowDialog()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        SetCustomerValue()
        cls.Save_Update("Insert_Customer")
        FormCustomers_Load(sender, e)
    End Sub



    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        SetCustomerValue()
        cls.Save_Update("Update_Customer")
        FormCustomers_Load(sender, e)
    End Sub
    Private Sub FormCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rest()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btn_New.Click
        FormCustomers_Load(sender, e)
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        cls.code = Val(txt_CustomerID.Text)
        cls.DeleteData("Delete_Customer")
        rest()
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        If e.RowIndex < 0 Then Return
        Dim selectRow As DataGridViewRow = DGV.Rows(e.RowIndex)
        txt_CustomerID.Text = selectRow.Cells(0).Value.ToString
        txt__CustomerName.Text = DGV.Rows(e.RowIndex).Cells(1).Value.ToString



        setGender(selectRow.Cells(2).Value.ToString)
        txt_Adress.Text = selectRow.Cells(3).Value.ToString
            txt_City.Text = selectRow.Cells(4).Value.ToString
            txt_State.Text = selectRow.Cells(5).Value.ToString
            txt_Zip.Text = selectRow.Cells(6).Value.ToString
            txt_Contact.Text = selectRow.Cells(7).Value.ToString
            txt_Email.Text = selectRow.Cells(8).Value.ToString
            txt_Notes.Text = selectRow.Cells(9).Value.ToString
            Dim data As Byte() = DirectCast(selectRow.Cells(10).Value, Byte())
            Dim ms As New MemoryStream(data)
            Me.PictureBox1.Image = Image.FromStream(ms)

    End Sub
    Private Sub setGender(gender As String)
        Select Case gender
            Case "Male"
                btn_male.Checked = True
            Case "Femal"
                btn_female.Checked = True
        End Select

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



    Private Sub txt_search_TextChanged_1(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        cls.Name = txt_search.Text
        cls.Search_Name("Search_Customer", DGV)

    End Sub


End Class