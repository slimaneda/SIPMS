Imports System.IO

Public Class FormCategories
    Private item As New Item
    Private ItemsDAL As New ItemsDAL

    Public Sub New(ByVal item As Item)
        InitializeComponent()
        Me.item = item
    End Sub

    Private Sub FormItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_Codeitem.Text = ComFunction.CODE_GEN("Items", "Code_item") + 1
        clean()
    End Sub

    Private Sub clean()
        txt_itemname.Text = ""
        PictureBox1.Image = My.Resources.Sans_titre
        txt_Codeitem.Focus()
        ComFunction.Show_DGV(DGV1, "select_items")
    End Sub

    Private Sub btnBrows_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            With OpenFileDialog1
                .Filter = "Images |*.png; *.bmp; *.jpg;*.jpeg; *.gif;*.ico;"
                .FilterIndex = 4
                .FileName = ""
            End With
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If txt_itemname.Text = String.Empty Then
                MessageBox.Show("Please add name item ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If PictureBox1.Image IsNot Nothing Then
                Dim ms As New MemoryStream
                PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                item.photo = ms.ToArray()
            End If

            item.Code_item = txt_Codeitem.Text
            item.Name_item = txt_itemname.Text

            ItemsDAL.Insertar(item)
        Catch ex As Exception
        End Try
        txt_Codeitem.Text = ComFunction.CODE_GEN("Items", "Code_item") + 1
        clean()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txt_Codeitem.Text = "" Then
            MessageBox.Show("Please enter Code item", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            item.photo = ms.ToArray()

        item.Code_item = txt_Codeitem.Text
        item.Name_item = txt_itemname.Text

        ItemsDAL.Update(Me.item)
        ComFunction.Show_DGV(DGV1, "select_items")
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txt_Codeitem.Text = "" Then
            MessageBox.Show("Please enter Code item", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        item.Code_item = Val(txt_Codeitem.Text)
        ItemsDAL.Delete(Me.item)
        ComFunction.Show_DGV(DGV1, "select_items")

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        clean()
        txt_Codeitem.Text = ComFunction.CODE_GEN("Items", "Code_item") + 1
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellClick
        If e.RowIndex >= 0 Then
            txt_Codeitem.Text = DGV1.Rows(e.RowIndex).Cells(0).Value
            txt_itemname.Text = DGV1.Rows(e.RowIndex).Cells(1).Value.ToString
            Dim data As Byte() = DirectCast(DGV1.Rows(e.RowIndex).Cells(2).Value, Byte())
            Dim ms As New MemoryStream(data)
            Me.PictureBox1.Image = Image.FromStream(ms)

        End If
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

End Class