<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCompany
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Label1 = New Label()
        DGV1 = New DataGridView()
        Panel2 = New Panel()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        txt_CIN = New TextBox()
        Label7 = New Label()
        txt_STN = New TextBox()
        Label8 = New Label()
        txt_TIN = New TextBox()
        Label9 = New Label()
        txt_Email = New TextBox()
        Label4 = New Label()
        txt_Contact = New TextBox()
        Label5 = New Label()
        txt_Adress = New TextBox()
        Label3 = New Label()
        txt_Companyname = New TextBox()
        Label2 = New Label()
        Panel3 = New Panel()
        btnClose = New Button()
        btnShow = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnSave = New Button()
        btnNew = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        Panel1.SuspendLayout()
        CType(DGV1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SteelBlue
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(815, 63)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(304, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(207, 24)
        Label1.TabIndex = 0
        Label1.Text = "Company Information"
        ' 
        ' DGV1
        ' 
        DGV1.AllowUserToAddRows = False
        DGV1.AllowUserToDeleteRows = False
        DGV1.BackgroundColor = SystemColors.Control
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = SystemColors.GradientInactiveCaption
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DGV1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DGV1.Dock = DockStyle.Bottom
        DGV1.EnableHeadersVisualStyles = False
        DGV1.Location = New Point(0, 396)
        DGV1.Name = "DGV1"
        DGV1.ReadOnly = True
        DGV1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DGV1.RowHeadersVisible = False
        DGV1.RowTemplate.Height = 25
        DGV1.Size = New Size(815, 281)
        DGV1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(txt_CIN)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(txt_STN)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(txt_TIN)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(txt_Email)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(txt_Contact)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(txt_Adress)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(txt_Companyname)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(12, 92)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(589, 281)
        Panel2.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(433, 191)
        Button1.Name = "Button1"
        Button1.Size = New Size(72, 23)
        Button1.TabIndex = 15
        Button1.Text = "&Browse..."
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Image = My.Resources.Resources.Sans_titre
        PictureBox1.Location = New Point(385, 33)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(145, 148)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' txt_CIN
        ' 
        txt_CIN.Location = New Point(124, 231)
        txt_CIN.Name = "txt_CIN"
        txt_CIN.Size = New Size(196, 23)
        txt_CIN.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(26, 234)
        Label7.Name = "Label7"
        Label7.Size = New Size(33, 15)
        Label7.TabIndex = 12
        Label7.Text = "CIN :"
        ' 
        ' txt_STN
        ' 
        txt_STN.Location = New Point(124, 196)
        txt_STN.Name = "txt_STN"
        txt_STN.Size = New Size(196, 23)
        txt_STN.TabIndex = 11
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(26, 199)
        Label8.Name = "Label8"
        Label8.Size = New Size(45, 15)
        Label8.TabIndex = 10
        Label8.Text = "ST N° :"
        ' 
        ' txt_TIN
        ' 
        txt_TIN.Location = New Point(124, 163)
        txt_TIN.Name = "txt_TIN"
        txt_TIN.Size = New Size(196, 23)
        txt_TIN.TabIndex = 9
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(26, 166)
        Label9.Name = "Label9"
        Label9.Size = New Size(32, 15)
        Label9.TabIndex = 8
        Label9.Text = "TIN :"
        ' 
        ' txt_Email
        ' 
        txt_Email.Location = New Point(124, 128)
        txt_Email.Name = "txt_Email"
        txt_Email.Size = New Size(196, 23)
        txt_Email.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(26, 131)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 15)
        Label4.TabIndex = 6
        Label4.Text = "Email  ID :"
        ' 
        ' txt_Contact
        ' 
        txt_Contact.Location = New Point(124, 95)
        txt_Contact.Name = "txt_Contact"
        txt_Contact.Size = New Size(196, 23)
        txt_Contact.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(26, 98)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 15)
        Label5.TabIndex = 4
        Label5.Text = "Contact N° :"
        ' 
        ' txt_Adress
        ' 
        txt_Adress.Location = New Point(124, 60)
        txt_Adress.Name = "txt_Adress"
        txt_Adress.Size = New Size(196, 23)
        txt_Adress.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(26, 63)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 15)
        Label3.TabIndex = 2
        Label3.Text = "Adress :"
        ' 
        ' txt_Companyname
        ' 
        txt_Companyname.Location = New Point(124, 27)
        txt_Companyname.Name = "txt_Companyname"
        txt_Companyname.Size = New Size(196, 23)
        txt_Companyname.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(26, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 15)
        Label2.TabIndex = 0
        Label2.Text = "Company Name :"
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(btnClose)
        Panel3.Controls.Add(btnShow)
        Panel3.Controls.Add(btnDelete)
        Panel3.Controls.Add(btnUpdate)
        Panel3.Controls.Add(btnSave)
        Panel3.Controls.Add(btnNew)
        Panel3.Location = New Point(643, 117)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(125, 225)
        Panel3.TabIndex = 3
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(21, 191)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(90, 23)
        btnClose.TabIndex = 21
        btnClose.Text = "&Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnShow
        ' 
        btnShow.Location = New Point(21, 153)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(90, 23)
        btnShow.TabIndex = 20
        btnShow.Text = "&Show"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(21, 119)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(90, 23)
        btnDelete.TabIndex = 19
        btnDelete.Text = "&Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(21, 86)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(90, 23)
        btnUpdate.TabIndex = 18
        btnUpdate.Text = "&Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(21, 48)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(90, 23)
        btnSave.TabIndex = 17
        btnSave.Text = "&Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnNew
        ' 
        btnNew.Location = New Point(21, 14)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(90, 23)
        btnNew.TabIndex = 16
        btnNew.Text = "&New"
        btnNew.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' FormCompany
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(815, 677)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(DGV1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormCompany"
        Text = "FormCompany"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DGV1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_Companyname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_CIN As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_STN As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_TIN As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_Email As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Contact As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_Adress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
