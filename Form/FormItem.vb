﻿Imports System.IO

Public Class FormItem
    Dim cls As New ClassItems
    Private Sub FormItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rest()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        cls.procedure = "Insert_Items"
        cls.Code_item = Val(txt_Codeitem.Text)
        cls.Name_item = txt_itemname.Text
        cls.DGV = DGV1
        cls.PictureBox1 = PictureBox1.Image
        cls.Save_Update()
        rest()

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        rest()
    End Sub
    Sub rest()
        txt_Codeitem.Text = ""
        txt_itemname.Text = ""
        PictureBox1.Image = My.Resources.Sans_titre
        txt_Codeitem.Focus()
        Show_DGV(DGV1, "select_items")
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txt_Codeitem.Text = "" Then
            MessageBox.Show("Please enter Code item", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        cls.Code_item = Val(txt_Codeitem.Text)
        cls.Name_item = txt_itemname.Text
        cls.DGV = DGV1

        cls.procedure = "UPDATE_Items"

        cls.Save_Update()
        rest()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txt_Codeitem.Text = "" Then
            MessageBox.Show("Please enter Code item", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        cls.Deletedata("Delete_Items")
        rest()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        cls.Name_item = txt_search.Text
        cls.DGV = DGV1
        cls.Searchdata("Search_item")
    End Sub

    Private Sub DGV1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellClick
        If e.RowIndex >= 0 Then
            txt_Codeitem.Text = DGV1.Rows(e.RowIndex).Cells(0).Value
            txt_itemname.Text = DGV1.Rows(e.RowIndex).Cells(1).Value.ToString
            Dim data As Byte() = DirectCast(DGV1.Rows(e.RowIndex).Cells(2).Value, Byte())
            Dim ms As New MemoryStream(data)
            Me.PictureBox1.Image = Image.FromStream(ms)

        End If
    End Sub
End Class