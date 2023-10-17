
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSupplierPayement
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
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        btnClose = New Button()
        Button1 = New Button()
        GroupBox1 = New GroupBox()
        txtNameSup = New TextBox()
        btnShow = New Button()
        Label31 = New Label()
        txtCodeSup = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        txtGrandTotal = New TextBox()
        GroupBox2 = New GroupBox()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnRemove = New Button()
        btnAdd = New Button()
        DGV = New DataGridView()
        Column8 = New DataGridViewTextBoxColumn()
        Column15 = New DataGridViewTextBoxColumn()
        Column16 = New DataGridViewTextBoxColumn()
        dtpPaymentDate = New DateTimePicker()
        Label7 = New Label()
        Panel4 = New Panel()
        Label34 = New Label()
        Label35 = New Label()
        txtPaymentDue = New TextBox()
        txtTotalPayment = New TextBox()
        txtPayment = New TextBox()
        cmbPaymentMode = New ComboBox()
        Label12 = New Label()
        Label13 = New Label()
        Panel2 = New Panel()
        Label1 = New Label()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(DGV, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(btnClose)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(GroupBox1)
        Panel1.Controls.Add(GroupBox2)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(8, 7)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(711, 562)
        Panel1.TabIndex = 2
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(234, 500)
        btnClose.Margin = New Padding(4, 3, 4, 3)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(105, 43)
        btnClose.TabIndex = 7
        btnClose.Text = "إغلاق"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(410, 500)
        Button1.Margin = New Padding(4, 3, 4, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(105, 43)
        Button1.TabIndex = 6
        Button1.Text = "حفظ"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtNameSup)
        GroupBox1.Controls.Add(btnShow)
        GroupBox1.Controls.Add(Label31)
        GroupBox1.Controls.Add(txtCodeSup)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtGrandTotal)
        GroupBox1.Location = New Point(10, 91)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.RightToLeft = RightToLeft.Yes
        GroupBox1.Size = New Size(671, 110)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "بيانات المورد"
        ' 
        ' txtNameSup
        ' 
        txtNameSup.Location = New Point(376, 36)
        txtNameSup.Margin = New Padding(4, 3, 4, 3)
        txtNameSup.Name = "txtNameSup"
        txtNameSup.ReadOnly = True
        txtNameSup.Size = New Size(140, 23)
        txtNameSup.TabIndex = 89
        txtNameSup.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnShow
        ' 
        btnShow.BackgroundImageLayout = ImageLayout.None
        btnShow.FlatStyle = FlatStyle.System
        btnShow.Location = New Point(334, 35)
        btnShow.Margin = New Padding(4, 5, 4, 5)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(34, 24)
        btnShow.TabIndex = 88
        btnShow.Text = " ..."
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label31.Location = New Point(198, 42)
        Label31.Margin = New Padding(4, 0, 4, 0)
        Label31.Name = "Label31"
        Label31.Size = New Size(105, 13)
        Label31.TabIndex = 87
        Label31.Text = "الرصيد الحالى للمورد :"
        ' 
        ' txtCodeSup
        ' 
        txtCodeSup.Location = New Point(376, 70)
        txtCodeSup.Margin = New Padding(4, 3, 4, 3)
        txtCodeSup.Name = "txtCodeSup"
        txtCodeSup.ReadOnly = True
        txtCodeSup.Size = New Size(140, 23)
        txtCodeSup.TabIndex = 3
        txtCodeSup.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(524, 74)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 15)
        Label3.TabIndex = 2
        Label3.Text = "رقم المورد :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(523, 36)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 15)
        Label2.TabIndex = 1
        Label2.Text = "أسم المورد :"
        ' 
        ' txtGrandTotal
        ' 
        txtGrandTotal.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtGrandTotal.Location = New Point(7, 36)
        txtGrandTotal.Margin = New Padding(4, 3, 4, 3)
        txtGrandTotal.Name = "txtGrandTotal"
        txtGrandTotal.ReadOnly = True
        txtGrandTotal.Size = New Size(184, 29)
        txtGrandTotal.TabIndex = 0
        txtGrandTotal.Text = "00"
        txtGrandTotal.TextAlign = HorizontalAlignment.Center
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnDelete)
        GroupBox2.Controls.Add(btnUpdate)
        GroupBox2.Controls.Add(btnRemove)
        GroupBox2.Controls.Add(btnAdd)
        GroupBox2.Controls.Add(DGV)
        GroupBox2.Controls.Add(dtpPaymentDate)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Panel4)
        GroupBox2.Controls.Add(txtPayment)
        GroupBox2.Controls.Add(cmbPaymentMode)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(Label13)
        GroupBox2.Location = New Point(10, 208)
        GroupBox2.Margin = New Padding(4, 3, 4, 3)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4, 3, 4, 3)
        GroupBox2.RightToLeft = RightToLeft.Yes
        GroupBox2.Size = New Size(671, 286)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "معلومات الدفع"
        ' 
        ' btnDelete
        ' 
        btnDelete.FlatStyle = FlatStyle.Popup
        btnDelete.Location = New Point(519, 143)
        btnDelete.Margin = New Padding(4, 3, 4, 3)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(96, 24)
        btnDelete.TabIndex = 90
        btnDelete.Text = "مسح"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Enabled = False
        btnUpdate.FlatStyle = FlatStyle.Popup
        btnUpdate.Location = New Point(518, 232)
        btnUpdate.Margin = New Padding(4, 3, 4, 3)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(96, 24)
        btnUpdate.TabIndex = 89
        btnUpdate.Text = "تحديث"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnRemove
        ' 
        btnRemove.Enabled = False
        btnRemove.FlatStyle = FlatStyle.Popup
        btnRemove.Location = New Point(518, 202)
        btnRemove.Margin = New Padding(4, 3, 4, 3)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(96, 24)
        btnRemove.TabIndex = 88
        btnRemove.Text = "حذف"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.FlatStyle = FlatStyle.Popup
        btnAdd.Location = New Point(518, 173)
        btnAdd.Margin = New Padding(4, 3, 4, 3)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(96, 24)
        btnAdd.TabIndex = 87
        btnAdd.Text = "إضافة"
        btnAdd.UseVisualStyleBackColor = True
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
        DataGridViewCellStyle2.Font = New Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DGV.ColumnHeadersHeight = 24
        DGV.Columns.AddRange(New DataGridViewColumn() {Column8, Column15, Column16})
        DGV.Cursor = Cursors.Hand
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        DGV.DefaultCellStyle = DataGridViewCellStyle5
        DGV.EnableHeadersVisualStyles = False
        DGV.GridColor = Color.White
        DGV.Location = New Point(7, 129)
        DGV.Margin = New Padding(4, 3, 4, 3)
        DGV.Name = "DGV"
        DGV.ReadOnly = True
        DGV.RightToLeft = RightToLeft.Yes
        DGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.CadetBlue
        DataGridViewCellStyle6.Font = New Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = Color.DarkSlateGray
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        DGV.RowHeadersVisible = False
        DGV.RowHeadersWidth = 30
        DGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle7.BackColor = Color.White
        DataGridViewCellStyle7.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle7.SelectionBackColor = Color.DarkSlateGray
        DataGridViewCellStyle7.SelectionForeColor = Color.White
        DGV.RowsDefaultCellStyle = DataGridViewCellStyle7
        DGV.RowTemplate.Height = 18
        DGV.RowTemplate.Resizable = DataGridViewTriState.False
        DGV.ScrollBars = ScrollBars.Vertical
        DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV.Size = New Size(504, 127)
        DGV.TabIndex = 86
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "طريقة الدفع"
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        ' 
        ' Column15
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopRight
        Column15.DefaultCellStyle = DataGridViewCellStyle3
        Column15.HeaderText = "الملبغ المدفوع"
        Column15.Name = "Column15"
        Column15.ReadOnly = True
        ' 
        ' Column16
        ' 
        DataGridViewCellStyle4.Format = "dd/MM/yyyy"
        Column16.DefaultCellStyle = DataGridViewCellStyle4
        Column16.HeaderText = "تاريخ الدفع"
        Column16.Name = "Column16"
        Column16.ReadOnly = True
        ' 
        ' dtpPaymentDate
        ' 
        dtpPaymentDate.CustomFormat = "dd/MM/yyyy"
        dtpPaymentDate.Format = DateTimePickerFormat.Custom
        dtpPaymentDate.Location = New Point(387, 98)
        dtpPaymentDate.Margin = New Padding(2)
        dtpPaymentDate.Name = "dtpPaymentDate"
        dtpPaymentDate.RightToLeft = RightToLeft.Yes
        dtpPaymentDate.Size = New Size(129, 23)
        dtpPaymentDate.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(523, 97)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(66, 15)
        Label7.TabIndex = 25
        Label7.Text = "تاريخ الدفع :"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Transparent
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(Label34)
        Panel4.Controls.Add(Label35)
        Panel4.Controls.Add(txtPaymentDue)
        Panel4.Controls.Add(txtTotalPayment)
        Panel4.Location = New Point(7, 22)
        Panel4.Margin = New Padding(4, 3, 4, 3)
        Panel4.Name = "Panel4"
        Panel4.RightToLeft = RightToLeft.Yes
        Panel4.Size = New Size(356, 100)
        Panel4.TabIndex = 5
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label34.Location = New Point(190, 69)
        Label34.Margin = New Padding(4, 0, 4, 0)
        Label34.Name = "Label34"
        Label34.Size = New Size(105, 13)
        Label34.TabIndex = 86
        Label34.Text = "الرصيد الجديد للمورد  :"
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label35.Location = New Point(190, 20)
        Label35.Margin = New Padding(4, 0, 4, 0)
        Label35.Name = "Label35"
        Label35.Size = New Size(84, 13)
        Label35.TabIndex = 85
        Label35.Text = "إجمالى الدفعات :"
        ' 
        ' txtPaymentDue
        ' 
        txtPaymentDue.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtPaymentDue.Location = New Point(27, 66)
        txtPaymentDue.Margin = New Padding(4, 3, 4, 3)
        txtPaymentDue.Name = "txtPaymentDue"
        txtPaymentDue.ReadOnly = True
        txtPaymentDue.Size = New Size(156, 20)
        txtPaymentDue.TabIndex = 2
        txtPaymentDue.Text = "00"
        txtPaymentDue.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtTotalPayment
        ' 
        txtTotalPayment.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtTotalPayment.Location = New Point(27, 16)
        txtTotalPayment.Margin = New Padding(4, 3, 4, 3)
        txtTotalPayment.Name = "txtTotalPayment"
        txtTotalPayment.ReadOnly = True
        txtTotalPayment.Size = New Size(156, 20)
        txtTotalPayment.TabIndex = 1
        txtTotalPayment.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPayment
        ' 
        txtPayment.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtPayment.Location = New Point(387, 69)
        txtPayment.Margin = New Padding(4, 3, 4, 3)
        txtPayment.Name = "txtPayment"
        txtPayment.Size = New Size(128, 20)
        txtPayment.TabIndex = 1
        txtPayment.Text = "0"
        txtPayment.TextAlign = HorizontalAlignment.Center
        ' 
        ' cmbPaymentMode
        ' 
        cmbPaymentMode.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPaymentMode.FormattingEnabled = True
        cmbPaymentMode.Items.AddRange(New Object() {"كاش", "شيك"})
        cmbPaymentMode.Location = New Point(387, 38)
        cmbPaymentMode.Margin = New Padding(4, 3, 4, 3)
        cmbPaymentMode.Name = "cmbPaymentMode"
        cmbPaymentMode.Size = New Size(129, 23)
        cmbPaymentMode.TabIndex = 0
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(523, 38)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(74, 15)
        Label12.TabIndex = 11
        Label12.Text = "طريقة الدفع :"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(523, 67)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(84, 15)
        Label13.TabIndex = 22
        Label13.Text = "المبلغ المدفوع :"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkSlateGray
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(10, 8)
        Panel2.Margin = New Padding(4, 3, 4, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(687, 72)
        Panel2.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(251, 18)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(165, 24)
        Label1.TabIndex = 0
        Label1.Text = "إضافة دفعات الموردين"
        ' 
        ' FormSupplierPayement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateGray
        ClientSize = New Size(729, 583)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormSupplierPayement"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(DGV, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents dtpPaymentDate As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label31 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents txtGrandTotal As TextBox
    Friend WithEvents txtPaymentDue As TextBox
    Friend WithEvents txtTotalPayment As TextBox
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents cmbPaymentMode As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodeSup As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents txtNameSup As TextBox
End Class
