﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSupplier
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
        Label1 = New Label()
        Panel1 = New Panel()
        GroupBox1 = New GroupBox()
        txt_zip = New TextBox()
        txt_SupplierID = New TextBox()
        Panel5 = New Panel()
        btn_Close = New Button()
        btn_Show = New Button()
        btn_Delete = New Button()
        btn_Update = New Button()
        btn_Save = New Button()
        btn_New = New Button()
        btn_female = New RadioButton()
        btn_male = New RadioButton()
        txt_Notes = New TextBox()
        Label13 = New Label()
        txt_Email = New TextBox()
        Label14 = New Label()
        txt_Contact = New TextBox()
        Label15 = New Label()
        btn_Browse = New Button()
        PictureBox1 = New PictureBox()
        Label16 = New Label()
        txt_State = New TextBox()
        Label17 = New Label()
        txt_City = New TextBox()
        Label18 = New Label()
        txt_Adress = New TextBox()
        Label19 = New Label()
        Label20 = New Label()
        txt__SupplierName = New TextBox()
        Label21 = New Label()
        Label22 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        Panel5.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(205, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(177, 24)
        Label1.TabIndex = 0
        Label1.Text = "Add new Supplier"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SteelBlue
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(580, 63)
        Panel1.TabIndex = 5
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txt_zip)
        GroupBox1.Controls.Add(txt_SupplierID)
        GroupBox1.Controls.Add(Panel5)
        GroupBox1.Controls.Add(btn_female)
        GroupBox1.Controls.Add(btn_male)
        GroupBox1.Controls.Add(txt_Notes)
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(txt_Email)
        GroupBox1.Controls.Add(Label14)
        GroupBox1.Controls.Add(txt_Contact)
        GroupBox1.Controls.Add(Label15)
        GroupBox1.Controls.Add(btn_Browse)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(Label16)
        GroupBox1.Controls.Add(txt_State)
        GroupBox1.Controls.Add(Label17)
        GroupBox1.Controls.Add(txt_City)
        GroupBox1.Controls.Add(Label18)
        GroupBox1.Controls.Add(txt_Adress)
        GroupBox1.Controls.Add(Label19)
        GroupBox1.Controls.Add(Label20)
        GroupBox1.Controls.Add(txt__SupplierName)
        GroupBox1.Controls.Add(Label21)
        GroupBox1.Controls.Add(Label22)
        GroupBox1.Location = New Point(12, 69)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(551, 454)
        GroupBox1.TabIndex = 14
        GroupBox1.TabStop = False
        ' 
        ' txt_zip
        ' 
        txt_zip.Location = New Point(127, 221)
        txt_zip.Name = "txt_zip"
        txt_zip.Size = New Size(196, 23)
        txt_zip.TabIndex = 50
        ' 
        ' txt_SupplierID
        ' 
        txt_SupplierID.Location = New Point(127, 17)
        txt_SupplierID.Name = "txt_SupplierID"
        txt_SupplierID.Size = New Size(196, 23)
        txt_SupplierID.TabIndex = 49
        ' 
        ' Panel5
        ' 
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(btn_Close)
        Panel5.Controls.Add(btn_Show)
        Panel5.Controls.Add(btn_Delete)
        Panel5.Controls.Add(btn_Update)
        Panel5.Controls.Add(btn_Save)
        Panel5.Controls.Add(btn_New)
        Panel5.Location = New Point(401, 213)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(125, 225)
        Panel5.TabIndex = 30
        ' 
        ' btn_Close
        ' 
        btn_Close.Location = New Point(21, 191)
        btn_Close.Name = "btn_Close"
        btn_Close.Size = New Size(90, 23)
        btn_Close.TabIndex = 21
        btn_Close.Text = "&Close"
        btn_Close.UseVisualStyleBackColor = True
        ' 
        ' btn_Show
        ' 
        btn_Show.Location = New Point(21, 153)
        btn_Show.Name = "btn_Show"
        btn_Show.Size = New Size(90, 23)
        btn_Show.TabIndex = 20
        btn_Show.Text = "&Show"
        btn_Show.UseVisualStyleBackColor = True
        ' 
        ' btn_Delete
        ' 
        btn_Delete.Location = New Point(21, 119)
        btn_Delete.Name = "btn_Delete"
        btn_Delete.Size = New Size(90, 23)
        btn_Delete.TabIndex = 19
        btn_Delete.Text = "&Delete"
        btn_Delete.UseVisualStyleBackColor = True
        ' 
        ' btn_Update
        ' 
        btn_Update.Location = New Point(21, 86)
        btn_Update.Name = "btn_Update"
        btn_Update.Size = New Size(90, 23)
        btn_Update.TabIndex = 18
        btn_Update.Text = "&Update"
        btn_Update.UseVisualStyleBackColor = True
        ' 
        ' btn_Save
        ' 
        btn_Save.Location = New Point(21, 48)
        btn_Save.Name = "btn_Save"
        btn_Save.Size = New Size(90, 23)
        btn_Save.TabIndex = 17
        btn_Save.Text = "&Save"
        btn_Save.UseVisualStyleBackColor = True
        ' 
        ' btn_New
        ' 
        btn_New.Location = New Point(21, 14)
        btn_New.Name = "btn_New"
        btn_New.Size = New Size(90, 23)
        btn_New.TabIndex = 16
        btn_New.Text = "&New"
        btn_New.UseVisualStyleBackColor = True
        ' 
        ' btn_female
        ' 
        btn_female.AutoSize = True
        btn_female.Location = New Point(193, 88)
        btn_female.Name = "btn_female"
        btn_female.Size = New Size(63, 19)
        btn_female.TabIndex = 48
        btn_female.Text = "Female"
        btn_female.UseVisualStyleBackColor = True
        ' 
        ' btn_male
        ' 
        btn_male.AutoSize = True
        btn_male.Checked = True
        btn_male.Location = New Point(136, 88)
        btn_male.Name = "btn_male"
        btn_male.Size = New Size(51, 19)
        btn_male.TabIndex = 47
        btn_male.TabStop = True
        btn_male.Text = "Male"
        btn_male.UseVisualStyleBackColor = True
        ' 
        ' txt_Notes
        ' 
        txt_Notes.Location = New Point(127, 322)
        txt_Notes.Multiline = True
        txt_Notes.Name = "txt_Notes"
        txt_Notes.Size = New Size(196, 75)
        txt_Notes.TabIndex = 45
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(29, 349)
        Label13.Name = "Label13"
        Label13.Size = New Size(42, 15)
        Label13.TabIndex = 44
        Label13.Text = "Notes:"
        ' 
        ' txt_Email
        ' 
        txt_Email.Location = New Point(127, 289)
        txt_Email.Name = "txt_Email"
        txt_Email.Size = New Size(196, 23)
        txt_Email.TabIndex = 43
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(29, 292)
        Label14.Name = "Label14"
        Label14.Size = New Size(60, 15)
        Label14.TabIndex = 42
        Label14.Text = "Email ID :"
        ' 
        ' txt_Contact
        ' 
        txt_Contact.Location = New Point(127, 254)
        txt_Contact.Name = "txt_Contact"
        txt_Contact.Size = New Size(196, 23)
        txt_Contact.TabIndex = 41
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label15.Location = New Point(29, 257)
        Label15.Name = "Label15"
        Label15.Size = New Size(71, 15)
        Label15.TabIndex = 40
        Label15.Text = "Contact N° :"
        ' 
        ' btn_Browse
        ' 
        btn_Browse.Location = New Point(425, 180)
        btn_Browse.Name = "btn_Browse"
        btn_Browse.Size = New Size(72, 23)
        btn_Browse.TabIndex = 39
        btn_Browse.Text = "&Browse..."
        btn_Browse.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Image = My.Resources.Resources.photo
        PictureBox1.Location = New Point(388, 22)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(145, 148)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 38
        PictureBox1.TabStop = False
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label16.Location = New Point(29, 223)
        Label16.Name = "Label16"
        Label16.Size = New Size(62, 15)
        Label16.TabIndex = 37
        Label16.Text = "Zip Code :"
        ' 
        ' txt_State
        ' 
        txt_State.Location = New Point(127, 185)
        txt_State.Name = "txt_State"
        txt_State.Size = New Size(196, 23)
        txt_State.TabIndex = 36
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label17.Location = New Point(29, 188)
        Label17.Name = "Label17"
        Label17.Size = New Size(41, 15)
        Label17.TabIndex = 35
        Label17.Text = "State :"
        ' 
        ' txt_City
        ' 
        txt_City.Location = New Point(127, 152)
        txt_City.Name = "txt_City"
        txt_City.Size = New Size(196, 23)
        txt_City.TabIndex = 34
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label18.Location = New Point(29, 155)
        Label18.Name = "Label18"
        Label18.Size = New Size(32, 15)
        Label18.TabIndex = 33
        Label18.Text = "City :"
        ' 
        ' txt_Adress
        ' 
        txt_Adress.Location = New Point(127, 117)
        txt_Adress.Name = "txt_Adress"
        txt_Adress.Size = New Size(196, 23)
        txt_Adress.TabIndex = 32
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label19.Location = New Point(29, 120)
        Label19.Name = "Label19"
        Label19.Size = New Size(50, 15)
        Label19.TabIndex = 31
        Label19.Text = "Adress :"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label20.Location = New Point(29, 87)
        Label20.Name = "Label20"
        Label20.Size = New Size(54, 15)
        Label20.TabIndex = 29
        Label20.Text = "Gendre :"
        ' 
        ' txt__SupplierName
        ' 
        txt__SupplierName.Location = New Point(127, 49)
        txt__SupplierName.Name = "txt__SupplierName"
        txt__SupplierName.Size = New Size(196, 23)
        txt__SupplierName.TabIndex = 28
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label21.Location = New Point(29, 52)
        Label21.Name = "Label21"
        Label21.Size = New Size(96, 15)
        Label21.TabIndex = 27
        Label21.Text = "Supplier Name :"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label22.Location = New Point(29, 19)
        Label22.Name = "Label22"
        Label22.Size = New Size(74, 15)
        Label22.TabIndex = 25
        Label22.Text = "Supplier ID :"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Yellow
        Panel3.Location = New Point(0, 59)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(583, 4)
        Panel3.TabIndex = 21
        ' 
        ' FormSupplier
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(580, 531)
        Controls.Add(Panel3)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormSupplier"
        Text = "Supplier"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel5.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_SupplierID As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btn_Close As Button
    Friend WithEvents btn_Show As Button
    Friend WithEvents btn_Delete As Button
    Friend WithEvents btn_Update As Button
    Friend WithEvents btn_Save As Button
    Friend WithEvents btn_New As Button
    Friend WithEvents btn_female As RadioButton
    Friend WithEvents btn_male As RadioButton
    Friend WithEvents txt_Notes As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_Email As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_Contact As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btn_Browse As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_State As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_City As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_Adress As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txt__SupplierName As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txt_zip As TextBox
    Friend WithEvents Panel3 As Panel
End Class
