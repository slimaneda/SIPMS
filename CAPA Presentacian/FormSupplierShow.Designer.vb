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
        lbl = New Label()
        CType(DGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DGV
        ' 
        DGV.AllowUserToAddRows = False
        DGV.AllowUserToDeleteRows = False
        DGV.AllowUserToOrderColumns = True
        DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV.Dock = DockStyle.Fill
        DGV.Location = New Point(0, 0)
        DGV.Name = "DGV"
        DGV.ReadOnly = True
        DGV.RowTemplate.Height = 25
        DGV.Size = New Size(661, 283)
        DGV.TabIndex = 12
        ' 
        ' lbl
        ' 
        lbl.AutoSize = True
        lbl.Location = New Point(22, 15)
        lbl.Name = "lbl"
        lbl.Size = New Size(41, 15)
        lbl.TabIndex = 16
        lbl.Text = "Label1"
        lbl.Visible = False
        ' 
        ' FormSupplierShow
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(661, 283)
        Controls.Add(lbl)
        Controls.Add(DGV)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormSupplierShow"
        CType(DGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DGV As DataGridView
    Friend WithEvents lbl As Label
End Class
