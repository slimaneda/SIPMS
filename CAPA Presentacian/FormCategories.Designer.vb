<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCategories
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
        Panel3 = New Panel()
        btnClose = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnSave = New Button()
        btnNew = New Button()
        DGV1 = New DataGridView()
        Panel2 = New Panel()
        btnBrowse = New Button()
        PictureBox1 = New PictureBox()
        txt_itemname = New TextBox()
        Label3 = New Label()
        txt_Codeitem = New TextBox()
        Label2 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        Label1 = New Label()
        Panel1 = New Panel()
        Panel4 = New Panel()
        Panel3.SuspendLayout()
        CType(DGV1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(btnClose)
        Panel3.Controls.Add(btnDelete)
        Panel3.Controls.Add(btnUpdate)
        Panel3.Controls.Add(btnSave)
        Panel3.Controls.Add(btnNew)
        Panel3.Location = New Point(371, 236)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(109, 161)
        Panel3.TabIndex = 4
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(7, 127)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(89, 23)
        btnClose.TabIndex = 21
        btnClose.Text = "&Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(6, 98)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(90, 23)
        btnDelete.TabIndex = 19
        btnDelete.Text = "&Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(6, 72)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(90, 23)
        btnUpdate.TabIndex = 18
        btnUpdate.Text = "&Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(6, 43)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(90, 23)
        btnSave.TabIndex = 17
        btnSave.Text = "&Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnNew
        ' 
        btnNew.Location = New Point(6, 14)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(90, 23)
        btnNew.TabIndex = 16
        btnNew.Text = "&New"
        btnNew.UseVisualStyleBackColor = True
        ' 
        ' DGV1
        ' 
        DGV1.AllowUserToAddRows = False
        DGV1.AllowUserToDeleteRows = False
        DGV1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGV1.BackgroundColor = SystemColors.Control
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = SystemColors.GradientInactiveCaption
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DGV1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DGV1.EnableHeadersVisualStyles = False
        DGV1.Location = New Point(12, 236)
        DGV1.Name = "DGV1"
        DGV1.ReadOnly = True
        DGV1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DGV1.RowHeadersVisible = False
        DGV1.RowTemplate.Height = 25
        DGV1.ScrollBars = ScrollBars.Vertical
        DGV1.Size = New Size(344, 161)
        DGV1.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(btnBrowse)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(txt_itemname)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(txt_Codeitem)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(12, 69)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(468, 161)
        Panel2.TabIndex = 3
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(344, 113)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(72, 23)
        btnBrowse.TabIndex = 15
        btnBrowse.Text = "&Browse..."
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Image = My.Resources.Resources.Sans_titre
        PictureBox1.Location = New Point(328, 6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(106, 98)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' txt_itemname
        ' 
        txt_itemname.Location = New Point(126, 73)
        txt_itemname.Name = "txt_itemname"
        txt_itemname.Size = New Size(151, 23)
        txt_itemname.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(25, 76)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 15)
        Label3.TabIndex = 2
        Label3.Text = "Name Item:"
        ' 
        ' txt_Codeitem
        ' 
        txt_Codeitem.Location = New Point(125, 40)
        txt_Codeitem.Name = "txt_Codeitem"
        txt_Codeitem.Size = New Size(152, 23)
        txt_Codeitem.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(25, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 15)
        Label2.TabIndex = 0
        Label2.Text = "Code item :"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(143, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(232, 24)
        Label1.TabIndex = 0
        Label1.Text = "Add Product Categories"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SteelBlue
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(489, 63)
        Panel1.TabIndex = 1
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Yellow
        Panel4.Location = New Point(-43, 62)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(535, 4)
        Panel4.TabIndex = 19
        ' 
        ' FormCategories
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(489, 404)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(DGV1)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormCategories"
        Panel3.ResumeLayout(False)
        CType(DGV1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnBrowse As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_itemname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Codeitem As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
End Class
