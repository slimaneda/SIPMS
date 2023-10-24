<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUser
    Inherits System.Windows.Forms.Form


    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        txt_productname = New TextBox()
        Label3 = New Label()
        txt_Productid = New TextBox()
        Label2 = New Label()
        Panel3 = New Panel()
        btnClose = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnSave = New Button()
        btnNew = New Button()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox8 = New CheckBox()
        CheckBox7 = New CheckBox()
        CheckBox11 = New CheckBox()
        CheckBox10 = New CheckBox()
        CheckBox9 = New CheckBox()
        DGV = New DataGridView()
        CheckBox3 = New CheckBox()
        CheckBox6 = New CheckBox()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        TabPage2 = New TabPage()
        CheckBox12 = New CheckBox()
        CheckBox13 = New CheckBox()
        CheckBox14 = New CheckBox()
        CheckBox15 = New CheckBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DGV, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SteelBlue
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1252, 63)
        Panel1.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(304, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 24)
        Label1.TabIndex = 0
        Label1.Text = "login"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(txt_productname)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(txt_Productid)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(12, 69)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(387, 83)
        Panel2.TabIndex = 4
        ' 
        ' txt_productname
        ' 
        txt_productname.Location = New Point(119, 14)
        txt_productname.Name = "txt_productname"
        txt_productname.Size = New Size(118, 23)
        txt_productname.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(26, 50)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 15)
        Label3.TabIndex = 2
        Label3.Text = "Password :"
        ' 
        ' txt_Productid
        ' 
        txt_Productid.Location = New Point(119, 47)
        txt_Productid.Name = "txt_Productid"
        txt_Productid.Size = New Size(118, 23)
        txt_Productid.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(26, 17)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 15)
        Label2.TabIndex = 0
        Label2.Text = "User Name :"
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(btnClose)
        Panel3.Controls.Add(btnDelete)
        Panel3.Controls.Add(btnUpdate)
        Panel3.Controls.Add(btnSave)
        Panel3.Controls.Add(btnNew)
        Panel3.Location = New Point(12, 308)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(689, 55)
        Panel3.TabIndex = 5
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(534, 14)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(90, 23)
        btnClose.TabIndex = 21
        btnClose.Text = "&Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(400, 14)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(90, 23)
        btnDelete.TabIndex = 19
        btnDelete.Text = "&Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(277, 14)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(90, 23)
        btnUpdate.TabIndex = 18
        btnUpdate.Text = "&Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(164, 14)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(90, 23)
        btnSave.TabIndex = 17
        btnSave.Text = "&Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnNew
        ' 
        btnNew.Location = New Point(47, 14)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(90, 23)
        btnNew.TabIndex = 16
        btnNew.Text = "&New"
        btnNew.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(10, 18)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(52, 19)
        CheckBox1.TabIndex = 4
        CheckBox1.Text = "User "
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(10, 49)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(74, 19)
        CheckBox2.TabIndex = 5
        CheckBox2.Text = "Database"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(86, 17)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(55, 19)
        CheckBox4.TabIndex = 6
        CheckBox4.Text = "Items"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(86, 49)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(74, 19)
        CheckBox5.TabIndex = 9
        CheckBox5.Text = "Suppliers"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Location = New Point(166, 49)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(83, 19)
        CheckBox8.TabIndex = 8
        CheckBox8.Text = "Customers"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(166, 18)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(68, 19)
        CheckBox7.TabIndex = 7
        CheckBox7.Text = "Product"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' CheckBox11
        ' 
        CheckBox11.AutoSize = True
        CheckBox11.Location = New Point(255, 74)
        CheckBox11.Name = "CheckBox11"
        CheckBox11.Size = New Size(79, 19)
        CheckBox11.TabIndex = 12
        CheckBox11.Text = "Quatation"
        CheckBox11.UseVisualStyleBackColor = True
        ' 
        ' CheckBox10
        ' 
        CheckBox10.AutoSize = True
        CheckBox10.Location = New Point(255, 48)
        CheckBox10.Name = "CheckBox10"
        CheckBox10.Size = New Size(125, 19)
        CheckBox10.TabIndex = 11
        CheckBox10.Text = "Supplier payement"
        CheckBox10.UseVisualStyleBackColor = True
        ' 
        ' CheckBox9
        ' 
        CheckBox9.AutoSize = True
        CheckBox9.Location = New Point(255, 17)
        CheckBox9.Name = "CheckBox9"
        CheckBox9.Size = New Size(87, 19)
        CheckBox9.TabIndex = 10
        CheckBox9.Text = "Purchas bill"
        CheckBox9.UseVisualStyleBackColor = True
        ' 
        ' DGV
        ' 
        DGV.AllowUserToAddRows = False
        DGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.BackColor = Color.FloralWhite
        DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DGV.BackgroundColor = Color.White
        DGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = Color.CadetBlue
        DataGridViewCellStyle7.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = Color.Black
        DataGridViewCellStyle7.SelectionBackColor = Color.LightSteelBlue
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
        DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        DGV.ColumnHeadersHeight = 31
        DGV.Cursor = Cursors.Hand
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = SystemColors.Window
        DataGridViewCellStyle8.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle8.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.False
        DGV.DefaultCellStyle = DataGridViewCellStyle8
        DGV.EnableHeadersVisualStyles = False
        DGV.GridColor = Color.White
        DGV.Location = New Point(16, 371)
        DGV.Margin = New Padding(4, 5, 5, 5)
        DGV.Name = "DGV"
        DGV.ReadOnly = True
        DGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = Color.CadetBlue
        DataGridViewCellStyle9.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle9.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = Color.DarkSlateGray
        DataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.True
        DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        DGV.RowHeadersVisible = False
        DGV.RowHeadersWidth = 30
        DataGridViewCellStyle10.BackColor = Color.White
        DataGridViewCellStyle10.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle10.SelectionBackColor = Color.DarkSlateGray
        DataGridViewCellStyle10.SelectionForeColor = Color.White
        DGV.RowsDefaultCellStyle = DataGridViewCellStyle10
        DGV.RowTemplate.Height = 18
        DGV.RowTemplate.Resizable = DataGridViewTriState.False
        DGV.ScrollBars = ScrollBars.Vertical
        DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV.Size = New Size(1139, 89)
        DGV.TabIndex = 6
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(10, 74)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(78, 19)
        CheckBox3.TabIndex = 13
        CheckBox3.Text = "Company"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(86, 74)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(120, 19)
        CheckBox6.TabIndex = 14
        CheckBox6.Text = "Customer Receipt"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(12, 158)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(391, 132)
        TabControl1.TabIndex = 15
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(CheckBox6)
        TabPage1.Controls.Add(CheckBox1)
        TabPage1.Controls.Add(CheckBox3)
        TabPage1.Controls.Add(CheckBox2)
        TabPage1.Controls.Add(CheckBox11)
        TabPage1.Controls.Add(CheckBox4)
        TabPage1.Controls.Add(CheckBox10)
        TabPage1.Controls.Add(CheckBox7)
        TabPage1.Controls.Add(CheckBox9)
        TabPage1.Controls.Add(CheckBox8)
        TabPage1.Controls.Add(CheckBox5)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(383, 104)
        TabPage1.TabIndex = 0
        TabPage1.Text = "General permissions"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(CheckBox12)
        TabPage2.Controls.Add(CheckBox13)
        TabPage2.Controls.Add(CheckBox14)
        TabPage2.Controls.Add(CheckBox15)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(383, 104)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Privale permissions"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox12
        ' 
        CheckBox12.AutoSize = True
        CheckBox12.Location = New Point(6, 15)
        CheckBox12.Name = "CheckBox12"
        CheckBox12.Size = New Size(50, 19)
        CheckBox12.TabIndex = 15
        CheckBox12.Text = "New"
        CheckBox12.UseVisualStyleBackColor = True
        ' 
        ' CheckBox13
        ' 
        CheckBox13.AutoSize = True
        CheckBox13.Location = New Point(82, 14)
        CheckBox13.Name = "CheckBox13"
        CheckBox13.Size = New Size(50, 19)
        CheckBox13.TabIndex = 17
        CheckBox13.Text = "Save"
        CheckBox13.UseVisualStyleBackColor = True
        ' 
        ' CheckBox14
        ' 
        CheckBox14.AutoSize = True
        CheckBox14.Location = New Point(162, 15)
        CheckBox14.Name = "CheckBox14"
        CheckBox14.Size = New Size(64, 19)
        CheckBox14.TabIndex = 18
        CheckBox14.Text = "Update"
        CheckBox14.UseVisualStyleBackColor = True
        ' 
        ' CheckBox15
        ' 
        CheckBox15.AutoSize = True
        CheckBox15.Location = New Point(251, 14)
        CheckBox15.Name = "CheckBox15"
        CheckBox15.Size = New Size(59, 19)
        CheckBox15.TabIndex = 21
        CheckBox15.Text = "Delete"
        CheckBox15.UseVisualStyleBackColor = True
        ' 
        ' FormUser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1252, 576)
        Controls.Add(TabControl1)
        Controls.Add(DGV)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "FormUser"
        Text = "Form User"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        CType(DGV, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_productname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Productid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents CheckBox11 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents DGV As DataGridView
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents CheckBox12 As CheckBox
    Friend WithEvents CheckBox13 As CheckBox
    Friend WithEvents CheckBox14 As CheckBox
    Friend WithEvents CheckBox15 As CheckBox
End Class

