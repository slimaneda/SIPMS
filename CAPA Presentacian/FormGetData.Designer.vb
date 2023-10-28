<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGetData
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
        Panel5 = New Panel()
        Label3 = New Label()
        txtseach = New TextBox()
        btnsearch = New Button()
        CType(DGV, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
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
        DGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DGV.ColumnHeadersHeight = 40
        DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGV.Location = New Point(0, 53)
        DGV.MultiSelect = False
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
        DGV.RowTemplate.Height = 25
        DGV.Size = New Size(648, 229)
        DGV.TabIndex = 21
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(Label3)
        Panel5.Controls.Add(txtseach)
        Panel5.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Panel5.Location = New Point(201, 10)
        Panel5.Name = "Panel5"
        Panel5.RightToLeft = RightToLeft.No
        Panel5.Size = New Size(197, 37)
        Panel5.TabIndex = 23
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 11)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 16)
        Label3.TabIndex = 2
        Label3.Text = "Search :"
        ' 
        ' txtseach
        ' 
        txtseach.Location = New Point(75, 7)
        txtseach.Name = "txtseach"
        txtseach.Size = New Size(110, 23)
        txtseach.TabIndex = 1
        ' 
        ' btnsearch
        ' 
        btnsearch.Location = New Point(478, 12)
        btnsearch.Name = "btnsearch"
        btnsearch.Size = New Size(75, 36)
        btnsearch.TabIndex = 22
        btnsearch.Text = "Search"
        btnsearch.UseVisualStyleBackColor = True
        ' 
        ' FormGetData
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(648, 282)
        Controls.Add(Panel5)
        Controls.Add(btnsearch)
        Controls.Add(DGV)
        Controls.Add(lbl)
        Name = "FormGetData"
        CType(DGV, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lbl As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtseach As TextBox
    Friend WithEvents btnsearch As Button
End Class
