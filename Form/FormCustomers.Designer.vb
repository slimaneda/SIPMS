<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCustomers
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
        Panel1 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        btn_Female = New RadioButton()
        btn_Male = New RadioButton()
        Txt_Zip = New MaskedTextBox()
        Txt_Notes = New TextBox()
        Label10 = New Label()
        Txt_Email = New TextBox()
        Label11 = New Label()
        Txt_Contact = New TextBox()
        Label12 = New Label()
        btn_Browse = New Button()
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        txt_State = New TextBox()
        Label8 = New Label()
        txt__City = New TextBox()
        Label9 = New Label()
        txt_Adress = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        txt__CustomerName = New TextBox()
        Label3 = New Label()
        txt_CustomerID = New TextBox()
        Label2 = New Label()
        Panel3 = New Panel()
        btnClose = New Button()
        btnShow = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnSave = New Button()
        btnNew = New Button()
        DGV = New DataGridView()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(DGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SteelBlue
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1410, 63)
        Panel1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(293, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(188, 24)
        Label1.TabIndex = 0
        Label1.Text = "Add new Customer"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(btn_Female)
        Panel2.Controls.Add(btn_Male)
        Panel2.Controls.Add(Txt_Zip)
        Panel2.Controls.Add(Txt_Notes)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Txt_Email)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Txt_Contact)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(btn_Browse)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(txt_State)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(txt__City)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(txt_Adress)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(txt__CustomerName)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(txt_CustomerID)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(12, 69)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(589, 454)
        Panel2.TabIndex = 3
        ' 
        ' btn_Female
        ' 
        btn_Female.AutoSize = True
        btn_Female.Location = New Point(190, 99)
        btn_Female.Name = "btn_Female"
        btn_Female.Size = New Size(61, 19)
        btn_Female.TabIndex = 24
        btn_Female.TabStop = True
        btn_Female.Text = "female"
        btn_Female.UseVisualStyleBackColor = True
        ' 
        ' btn_Male
        ' 
        btn_Male.AutoSize = True
        btn_Male.Location = New Point(133, 99)
        btn_Male.Name = "btn_Male"
        btn_Male.Size = New Size(51, 19)
        btn_Male.TabIndex = 23
        btn_Male.TabStop = True
        btn_Male.Text = "male"
        btn_Male.UseVisualStyleBackColor = True
        ' 
        ' Txt_Zip
        ' 
        Txt_Zip.Location = New Point(124, 231)
        Txt_Zip.Mask = "00000"
        Txt_Zip.Name = "Txt_Zip"
        Txt_Zip.Size = New Size(196, 23)
        Txt_Zip.TabIndex = 22
        ' 
        ' Txt_Notes
        ' 
        Txt_Notes.Location = New Point(124, 333)
        Txt_Notes.Multiline = True
        Txt_Notes.Name = "Txt_Notes"
        Txt_Notes.Size = New Size(196, 75)
        Txt_Notes.TabIndex = 21
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
        ' Txt_Email
        ' 
        Txt_Email.Location = New Point(124, 300)
        Txt_Email.Name = "Txt_Email"
        Txt_Email.Size = New Size(196, 23)
        Txt_Email.TabIndex = 19
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
        ' Txt_Contact
        ' 
        Txt_Contact.Location = New Point(124, 265)
        Txt_Contact.Name = "Txt_Contact"
        Txt_Contact.Size = New Size(196, 23)
        Txt_Contact.TabIndex = 17
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
        ' btn_Browse
        ' 
        btn_Browse.Location = New Point(418, 191)
        btn_Browse.Name = "btn_Browse"
        btn_Browse.Size = New Size(72, 23)
        btn_Browse.TabIndex = 15
        btn_Browse.Text = "&Browse..."
        btn_Browse.UseVisualStyleBackColor = True
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
        ' txt_State
        ' 
        txt_State.Location = New Point(124, 196)
        txt_State.Name = "txt_State"
        txt_State.Size = New Size(196, 23)
        txt_State.TabIndex = 11
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
        ' txt__City
        ' 
        txt__City.Location = New Point(124, 163)
        txt__City.Name = "txt__City"
        txt__City.Size = New Size(196, 23)
        txt__City.TabIndex = 9
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
        ' txt_Adress
        ' 
        txt_Adress.Location = New Point(124, 128)
        txt_Adress.Name = "txt_Adress"
        txt_Adress.Size = New Size(196, 23)
        txt_Adress.TabIndex = 7
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
        ' txt__CustomerName
        ' 
        txt__CustomerName.Location = New Point(124, 60)
        txt__CustomerName.Name = "txt__CustomerName"
        txt__CustomerName.Size = New Size(196, 23)
        txt__CustomerName.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(26, 63)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 15)
        Label3.TabIndex = 2
        Label3.Text = "Customer Name :"
        ' 
        ' txt_CustomerID
        ' 
        txt_CustomerID.Location = New Point(124, 27)
        txt_CustomerID.Name = "txt_CustomerID"
        txt_CustomerID.Size = New Size(196, 23)
        txt_CustomerID.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(26, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 15)
        Label2.TabIndex = 0
        Label2.Text = "Custmer ID :"
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
        Panel3.Location = New Point(401, 224)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(125, 225)
        Panel3.TabIndex = 4
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
        ' DGV
        ' 
        DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV.Location = New Point(629, 173)
        DGV.Name = "DGV"
        DGV.RowTemplate.Height = 25
        DGV.Size = New Size(769, 346)
        DGV.TabIndex = 11
        ' 
        ' FormCustomers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1410, 535)
        Controls.Add(DGV)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "FormCustomers"
        Text = "FormCustomers"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        CType(DGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_Browse As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_State As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt__City As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_Adress As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt__CustomerName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_CustomerID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Notes As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Txt_Email As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Txt_Contact As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents Txt_Zip As MaskedTextBox
    Friend WithEvents btn_Female As RadioButton
    Friend WithEvents btn_Male As RadioButton
    Friend WithEvents DGV As DataGridView
End Class
