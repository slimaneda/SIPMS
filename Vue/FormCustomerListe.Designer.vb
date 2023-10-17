<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCustomerListe
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
        Panel4 = New Panel()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Panel2 = New Panel()
        TextBox2 = New TextBox()
        Label2 = New Label()
        btnClose = New Button()
        DGV = New DataGridView()
        lbl = New Label()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel2.SuspendLayout()
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
        Panel1.Size = New Size(996, 63)
        Panel1.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(415, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 24)
        Label1.TabIndex = 0
        Label1.Text = "List of  Customers"
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(TextBox1)
        Panel4.Controls.Add(Label4)
        Panel4.Location = New Point(12, 69)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(226, 61)
        Panel4.TabIndex = 6
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(11, 24)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(196, 23)
        TextBox1.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(58, 3)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 15)
        Label4.TabIndex = 1
        Label4.Text = "Search Name :"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(282, 69)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(226, 61)
        Panel2.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(11, 24)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(196, 23)
        TextBox2.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(58, 3)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 15)
        Label2.TabIndex = 1
        Label2.Text = "Search Contact :"
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(874, 84)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(90, 23)
        btnClose.TabIndex = 22
        btnClose.Text = "&Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' DGV
        ' 
        DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV.Location = New Point(12, 194)
        DGV.Name = "DGV"
        DGV.RowTemplate.Height = 25
        DGV.Size = New Size(972, 280)
        DGV.TabIndex = 23
        ' 
        ' lbl
        ' 
        lbl.AutoSize = True
        lbl.Location = New Point(14, 151)
        lbl.Name = "lbl"
        lbl.Size = New Size(0, 15)
        lbl.TabIndex = 24
        ' 
        ' FormCustomerListe
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(996, 502)
        Controls.Add(lbl)
        Controls.Add(DGV)
        Controls.Add(btnClose)
        Controls.Add(Panel2)
        Controls.Add(Panel4)
        Controls.Add(Panel1)
        Name = "FormCustomerListe"
        Text = "FormCustomerListe"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents lbl As Label
End Class
