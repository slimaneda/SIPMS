<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStockShow
    Inherits System.Windows.Forms.Form



    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        txtSup_ID = New TextBox()
        Panel4 = New Panel()
        dtpDateTo = New DateTimePicker()
        Label2 = New Label()
        Label4 = New Label()
        dtpDateFrom = New DateTimePicker()
        btnGetData = New Button()
        Panel5 = New Panel()
        btnClose = New Button()
        btnReset = New Button()
        Panel3 = New Panel()
        txtSupplierName = New TextBox()
        Label3 = New Label()
        DGV = New DataGridView()
        Panel2 = New Panel()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DGV, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(txtSup_ID)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(DGV)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(9, 8)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(991, 658)
        Panel1.TabIndex = 2
        ' 
        ' txtSup_ID
        ' 
        txtSup_ID.Location = New Point(968, 78)
        txtSup_ID.Margin = New Padding(4, 3, 4, 3)
        txtSup_ID.Name = "txtSup_ID"
        txtSup_ID.Size = New Size(10, 23)
        txtSup_ID.TabIndex = 1
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(dtpDateTo)
        Panel4.Controls.Add(Label2)
        Panel4.Controls.Add(Label4)
        Panel4.Controls.Add(dtpDateFrom)
        Panel4.Controls.Add(btnGetData)
        Panel4.Location = New Point(211, 87)
        Panel4.Margin = New Padding(4, 3, 4, 3)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(429, 80)
        Panel4.TabIndex = 47
        ' 
        ' dtpDateTo
        ' 
        dtpDateTo.CustomFormat = "dd/MM/yyyy"
        dtpDateTo.Format = DateTimePickerFormat.Custom
        dtpDateTo.Location = New Point(4, 30)
        dtpDateTo.Margin = New Padding(4, 3, 4, 3)
        dtpDateTo.Name = "dtpDateTo"
        dtpDateTo.Size = New Size(109, 23)
        dtpDateTo.TabIndex = 14
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(16, 8)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(25, 15)
        Label2.TabIndex = 13
        Label2.Text = "To :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(187, 8)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(30, 15)
        Label4.TabIndex = 12
        Label4.Text = "For :"
        ' 
        ' dtpDateFrom
        ' 
        dtpDateFrom.CustomFormat = "dd/MM/yyyy"
        dtpDateFrom.Format = DateTimePickerFormat.Short
        dtpDateFrom.Location = New Point(178, 30)
        dtpDateFrom.Margin = New Padding(4, 3, 4, 3)
        dtpDateFrom.MaxDate = New Date(2300, 12, 30, 0, 0, 0, 0)
        dtpDateFrom.Name = "dtpDateFrom"
        dtpDateFrom.Size = New Size(99, 23)
        dtpDateFrom.TabIndex = 11
        dtpDateFrom.Value = New Date(2023, 10, 9, 0, 0, 0, 0)
        ' 
        ' btnGetData
        ' 
        btnGetData.Cursor = Cursors.Hand
        btnGetData.FlatStyle = FlatStyle.Popup
        btnGetData.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnGetData.Location = New Point(318, 30)
        btnGetData.Margin = New Padding(4, 3, 4, 3)
        btnGetData.Name = "btnGetData"
        btnGetData.Size = New Size(89, 23)
        btnGetData.TabIndex = 1
        btnGetData.Text = "OK"
        btnGetData.UseVisualStyleBackColor = True
        ' 
        ' Panel5
        ' 
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(btnClose)
        Panel5.Controls.Add(btnReset)
        Panel5.Location = New Point(648, 87)
        Panel5.Margin = New Padding(4, 3, 4, 3)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(227, 80)
        Panel5.TabIndex = 46
        ' 
        ' btnClose
        ' 
        btnClose.Cursor = Cursors.Hand
        btnClose.FlatStyle = FlatStyle.Popup
        btnClose.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnClose.Location = New Point(119, 26)
        btnClose.Margin = New Padding(4, 3, 4, 3)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(96, 32)
        btnClose.TabIndex = 4
        btnClose.Text = "&Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Cursor = Cursors.Hand
        btnReset.FlatStyle = FlatStyle.Popup
        btnReset.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnReset.Location = New Point(15, 27)
        btnReset.Margin = New Padding(4, 3, 4, 3)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(96, 32)
        btnReset.TabIndex = 0
        btnReset.Text = "&Clean"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(txtSupplierName)
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(10, 87)
        Panel3.Margin = New Padding(4, 3, 4, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(196, 80)
        Panel3.TabIndex = 45
        ' 
        ' txtSupplierName
        ' 
        txtSupplierName.BackColor = Color.White
        txtSupplierName.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtSupplierName.Location = New Point(15, 35)
        txtSupplierName.Margin = New Padding(4, 3, 4, 3)
        txtSupplierName.Name = "txtSupplierName"
        txtSupplierName.Size = New Size(167, 21)
        txtSupplierName.TabIndex = 13
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(30, 17)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.RightToLeft = RightToLeft.Yes
        Label3.Size = New Size(123, 15)
        Label3.TabIndex = 12
        Label3.Text = "&Search Name Supplier"
        ' 
        ' DGV
        ' 
        DGV.AllowUserToAddRows = False
        DGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FloralWhite
        DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGV.BackgroundColor = Color.White
        DGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.CadetBlue
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DGV.ColumnHeadersHeight = 30
        DGV.Cursor = Cursors.Hand
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Window
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        DGV.DefaultCellStyle = DataGridViewCellStyle3
        DGV.EnableHeadersVisualStyles = False
        DGV.GridColor = Color.White
        DGV.Location = New Point(10, 209)
        DGV.Margin = New Padding(4, 3, 4, 3)
        DGV.MultiSelect = False
        DGV.Name = "DGV"
        DGV.ReadOnly = True
        DGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.CadetBlue
        DataGridViewCellStyle4.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = Color.DarkSlateGray
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DGV.RowHeadersWidth = 25
        DGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.BackColor = Color.White
        DataGridViewCellStyle5.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.SelectionBackColor = Color.DarkSlateGray
        DataGridViewCellStyle5.SelectionForeColor = Color.White
        DGV.RowsDefaultCellStyle = DataGridViewCellStyle5
        DGV.RowTemplate.Height = 15
        DGV.RowTemplate.Resizable = DataGridViewTriState.False
        DGV.ScrollBars = ScrollBars.Vertical
        DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV.Size = New Size(968, 428)
        DGV.TabIndex = 43
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkSlateGray
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(4, 3, 4, 3)
        Panel2.Name = "Panel2"
        Panel2.RightToLeft = RightToLeft.Yes
        Panel2.Size = New Size(989, 72)
        Panel2.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(368, 22)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(168, 24)
        Label1.TabIndex = 0
        Label1.Text = "قائمة فواتير المشتريات"
        ' 
        ' FormStockShow
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateGray
        ClientSize = New Size(1009, 675)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormStockShow"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(DGV, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtSupplierName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dtpDateTo As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpDateFrom As DateTimePicker
    Friend WithEvents btnGetData As Button
    Friend WithEvents txtSup_ID As TextBox
End Class
