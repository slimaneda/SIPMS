<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSupplierShow
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
        Panel3 = New Panel()
        txt_searchId = New TextBox()
        Label3 = New Label()
        Panel2 = New Panel()
        txt_search = New TextBox()
        Label2 = New Label()
        lbl = New Label()
        CType(DGV, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' DGV
        ' 
        DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV.Location = New Point(22, 129)
        DGV.Name = "DGV"
        DGV.RowTemplate.Height = 25
        DGV.Size = New Size(923, 309)
        DGV.TabIndex = 12
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(txt_searchId)
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(160, 12)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(226, 61)
        Panel3.TabIndex = 14
        ' 
        ' txt_searchId
        ' 
        txt_searchId.Location = New Point(11, 24)
        txt_searchId.Name = "txt_searchId"
        txt_searchId.Size = New Size(196, 23)
        txt_searchId.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(58, 2)
        Label3.Name = "Label3"
        Label3.Size = New Size(116, 15)
        Label3.TabIndex = 1
        Label3.Text = "Search Supplier ID :"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(txt_search)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(543, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(226, 61)
        Panel2.TabIndex = 15
        ' 
        ' txt_search
        ' 
        txt_search.Location = New Point(11, 24)
        txt_search.Name = "txt_search"
        txt_search.Size = New Size(196, 23)
        txt_search.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(58, 3)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 15)
        Label2.TabIndex = 1
        Label2.Text = "Search Name :"
        ' 
        ' lbl
        ' 
        lbl.AutoSize = True
        lbl.Location = New Point(22, 15)
        lbl.Name = "lbl"
        lbl.Size = New Size(41, 15)
        lbl.TabIndex = 16
        lbl.Text = "Label1"
        ' 
        ' FormSupplierShow
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(966, 450)
        Controls.Add(lbl)
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        Controls.Add(DGV)
        Name = "FormSupplierShow"
        Text = "FormSupplierShow"
        CType(DGV, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DGV As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_searchId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl As Label
End Class
