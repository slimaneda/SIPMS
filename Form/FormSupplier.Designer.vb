<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        btnNew = New Button()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        MaskedTextBox1 = New MaskedTextBox()
        TextBox2 = New TextBox()
        Label10 = New Label()
        TextBox3 = New TextBox()
        Label11 = New Label()
        TextBox4 = New TextBox()
        Label12 = New Label()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        txt_STN = New TextBox()
        Label8 = New Label()
        txt_TIN = New TextBox()
        Label9 = New Label()
        txt_Email = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        txt_Adress = New TextBox()
        Label3 = New Label()
        txt_Companyname = New TextBox()
        Label2 = New Label()
        btnClose = New Button()
        btnShow = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        Panel3 = New Panel()
        btnSave = New Button()
        Panel2 = New Panel()
        Label1 = New Label()
        Panel1 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
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
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(190, 99)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(61, 19)
        RadioButton2.TabIndex = 24
        RadioButton2.TabStop = True
        RadioButton2.Text = "female"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(133, 99)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(51, 19)
        RadioButton1.TabIndex = 23
        RadioButton1.TabStop = True
        RadioButton1.Text = "male"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Location = New Point(124, 231)
        MaskedTextBox1.Mask = "00000"
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(196, 23)
        MaskedTextBox1.TabIndex = 22
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(124, 333)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(196, 75)
        TextBox2.TabIndex = 21
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(26, 360)
        Label10.Name = "Label10"
        Label10.Size = New Size(42, 15)
        Label10.TabIndex = 20
        Label10.Text = "Notes:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(124, 300)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(196, 23)
        TextBox3.TabIndex = 19
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(26, 303)
        Label11.Name = "Label11"
        Label11.Size = New Size(60, 15)
        Label11.TabIndex = 18
        Label11.Text = "Email ID :"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(124, 265)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(196, 23)
        TextBox4.TabIndex = 17
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(26, 268)
        Label12.Name = "Label12"
        Label12.Size = New Size(71, 15)
        Label12.TabIndex = 16
        Label12.Text = "Contact N° :"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(418, 191)
        Button1.Name = "Button1"
        Button1.Size = New Size(72, 23)
        Button1.TabIndex = 15
        Button1.Text = "&Browse..."
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Image = My.Resources.Resources.photo
        PictureBox1.Location = New Point(385, 33)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(145, 148)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(26, 234)
        Label7.Name = "Label7"
        Label7.Size = New Size(62, 15)
        Label7.TabIndex = 12
        Label7.Text = "Zip Code :"
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
        Label8.Size = New Size(41, 15)
        Label8.TabIndex = 10
        Label8.Text = "State :"
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
        Label9.Text = "City :"
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
        Label4.Size = New Size(50, 15)
        Label4.TabIndex = 6
        Label4.Text = "Adress :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(26, 98)
        Label5.Name = "Label5"
        Label5.Size = New Size(54, 15)
        Label5.TabIndex = 4
        Label5.Text = "Gendre :"
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
        Label3.Size = New Size(96, 15)
        Label3.TabIndex = 2
        Label3.Text = "Supplier Name :"
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
        Label2.Size = New Size(74, 15)
        Label2.TabIndex = 0
        Label2.Text = "Supplier ID :"
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
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(btnClose)
        Panel3.Controls.Add(btnShow)
        Panel3.Controls.Add(btnDelete)
        Panel3.Controls.Add(btnUpdate)
        Panel3.Controls.Add(btnSave)
        Panel3.Controls.Add(btnNew)
        Panel3.Location = New Point(641, 151)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(125, 225)
        Panel3.TabIndex = 7
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
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(RadioButton2)
        Panel2.Controls.Add(RadioButton1)
        Panel2.Controls.Add(MaskedTextBox1)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(TextBox3)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(TextBox4)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(txt_STN)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(txt_TIN)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(txt_Email)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(txt_Adress)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(txt_Companyname)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(12, 69)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(589, 454)
        Panel2.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(355, 21)
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
        Panel1.Size = New Size(800, 63)
        Panel1.TabIndex = 5
        ' 
        ' FormSupplier
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 531)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "FormSupplier"
        Text = "FormSupplier"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnNew As Button
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_STN As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_TIN As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_Email As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_Adress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Companyname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
