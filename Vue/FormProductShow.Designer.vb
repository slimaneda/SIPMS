<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProductShow
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
        DGV = New DataGridView()
        txt_productname = New TextBox()
        Label3 = New Label()
        txt_Productid = New TextBox()
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        lbl = New Label()
        DGV1 = New DataGridView()
        CType(DGV, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(DGV1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DGV
        ' 
        DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV.Location = New Point(12, 114)
        DGV.Name = "DGV"
        DGV.RowHeadersVisible = False
        DGV.RowTemplate.Height = 25
        DGV.Size = New Size(176, 176)
        DGV.TabIndex = 13
        ' 
        ' txt_productname
        ' 
        txt_productname.Location = New Point(6, 46)
        txt_productname.Name = "txt_productname"
        txt_productname.Size = New Size(196, 23)
        txt_productname.TabIndex = 17
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(51, 22)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 15)
        Label3.TabIndex = 16
        Label3.Text = "Product Name :"
        ' 
        ' txt_Productid
        ' 
        txt_Productid.Location = New Point(6, 48)
        txt_Productid.Name = "txt_Productid"
        txt_Productid.Size = New Size(196, 23)
        txt_Productid.TabIndex = 15
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(68, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 15)
        Label2.TabIndex = 14
        Label2.Text = "Product ID :"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txt_Productid)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(220, 86)
        GroupBox1.TabIndex = 18
        GroupBox1.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txt_productname)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Location = New Point(238, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(207, 86)
        GroupBox2.TabIndex = 19
        GroupBox2.TabStop = False
        ' 
        ' lbl
        ' 
        lbl.AutoSize = True
        lbl.Location = New Point(96, 293)
        lbl.Name = "lbl"
        lbl.Size = New Size(12, 15)
        lbl.TabIndex = 20
        lbl.Text = "s"
        ' 
        ' DGV1
        ' 
        DGV1.AllowUserToAddRows = False
        DGV1.AllowUserToDeleteRows = False
        DGV1.AllowUserToOrderColumns = True
        DGV1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV1.Location = New Point(205, 104)
        DGV1.Name = "DGV1"
        DGV1.ReadOnly = True
        DGV1.RowTemplate.Height = 25
        DGV1.Size = New Size(240, 186)
        DGV1.TabIndex = 21
        ' 
        ' FormProductShow
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(465, 318)
        Controls.Add(DGV1)
        Controls.Add(lbl)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(DGV)
        Name = "FormProductShow"
        CType(DGV, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(DGV1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DGV As DataGridView
    Friend WithEvents txt_productname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Productid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl As Label
    Friend WithEvents DGV1 As DataGridView
End Class
