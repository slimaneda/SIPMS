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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lbl = New Label()
        DGV = New DataGridView()
        CType(DGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        ' DGV
        ' 
        DGV.AllowUserToAddRows = False
        DGV.AllowUserToDeleteRows = False
        DGV.AllowUserToOrderColumns = True
        DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGV.BorderStyle = BorderStyle.Fixed3D
        DGV.ColumnHeadersHeight = 30
        DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGV.Dock = DockStyle.Fill
        DGV.Location = New Point(0, 0)
        DGV.Name = "DGV"
        DGV.ReadOnly = True
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        DGV.RowHeadersVisible = False
        DGV.RowTemplate.Height = 25
        DGV.Size = New Size(648, 282)
        DGV.TabIndex = 21
        ' 
        ' FormProductShow
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(648, 282)
        Controls.Add(DGV)
        Controls.Add(lbl)
        Name = "FormProductShow"
        CType(DGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lbl As Label
    Friend WithEvents DGV As DataGridView
End Class
