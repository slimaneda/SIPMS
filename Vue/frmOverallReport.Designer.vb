<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOverallReport
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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Timer1 = New Timer(components)
        Panel2 = New Panel()
        Label1 = New Label()
        txtPayment = New TextBox()
        cmbPaymentMode = New ComboBox()
        Label12 = New Label()
        Label13 = New Label()
        Label34 = New Label()
        Label35 = New Label()
        txtPaymentDue = New TextBox()
        txtTotalPayment = New TextBox()
        dtpPaymentDate = New DateTimePicker()
        Label7 = New Label()
        Panel4 = New Panel()
        Column16 = New DataGridViewTextBoxColumn()
        Column15 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        btnListReset1 = New Button()
        btnListUpdate1 = New Button()
        btnRemove1 = New Button()
        btnAdd1 = New Button()
        GroupBox2 = New GroupBox()
        DataGridView2 = New DataGridView()
        Label31 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        txtGrandTotal = New TextBox()
        ComboBox1 = New ComboBox()
        Button2 = New Button()
        Button1 = New Button()
        GroupBox1 = New GroupBox()
        Panel1 = New Panel()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.SteelBlue
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(4, 3, 4, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(726, 72)
        Panel2.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(253, 20)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(149, 24)
        Label1.TabIndex = 0
        Label1.Text = "إدخال دفعات العملاء"
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
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label34.Location = New Point(190, 69)
        Label34.Margin = New Padding(4, 0, 4, 0)
        Label34.Name = "Label34"
        Label34.Size = New Size(106, 13)
        Label34.TabIndex = 86
        Label34.Text = "الرصيد الجديد للعميل  :"
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
        ' Column16
        ' 
        DataGridViewCellStyle1.Format = "dd/MM/yyyy"
        Column16.DefaultCellStyle = DataGridViewCellStyle1
        Column16.HeaderText = "تاريخ الدفع"
        Column16.Name = "Column16"
        Column16.ReadOnly = True
        ' 
        ' Column15
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopRight
        Column15.DefaultCellStyle = DataGridViewCellStyle2
        Column15.HeaderText = "الملبغ المدفوع"
        Column15.Name = "Column15"
        Column15.ReadOnly = True
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "طريقة الدفع"
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        ' 
        ' btnListReset1
        ' 
        btnListReset1.FlatStyle = FlatStyle.Popup
        btnListReset1.Location = New Point(519, 143)
        btnListReset1.Margin = New Padding(4, 3, 4, 3)
        btnListReset1.Name = "btnListReset1"
        btnListReset1.Size = New Size(96, 24)
        btnListReset1.TabIndex = 90
        btnListReset1.Text = "مسح"
        btnListReset1.UseVisualStyleBackColor = True
        ' 
        ' btnListUpdate1
        ' 
        btnListUpdate1.Enabled = False
        btnListUpdate1.FlatStyle = FlatStyle.Popup
        btnListUpdate1.Location = New Point(518, 232)
        btnListUpdate1.Margin = New Padding(4, 3, 4, 3)
        btnListUpdate1.Name = "btnListUpdate1"
        btnListUpdate1.Size = New Size(96, 24)
        btnListUpdate1.TabIndex = 89
        btnListUpdate1.Text = "تحديث"
        btnListUpdate1.UseVisualStyleBackColor = True
        ' 
        ' btnRemove1
        ' 
        btnRemove1.Enabled = False
        btnRemove1.FlatStyle = FlatStyle.Popup
        btnRemove1.Location = New Point(518, 202)
        btnRemove1.Margin = New Padding(4, 3, 4, 3)
        btnRemove1.Name = "btnRemove1"
        btnRemove1.Size = New Size(96, 24)
        btnRemove1.TabIndex = 88
        btnRemove1.Text = "حذف"
        btnRemove1.UseVisualStyleBackColor = True
        ' 
        ' btnAdd1
        ' 
        btnAdd1.FlatStyle = FlatStyle.Popup
        btnAdd1.Location = New Point(518, 173)
        btnAdd1.Margin = New Padding(4, 3, 4, 3)
        btnAdd1.Name = "btnAdd1"
        btnAdd1.Size = New Size(96, 24)
        btnAdd1.TabIndex = 87
        btnAdd1.Text = "إضافة"
        btnAdd1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnListReset1)
        GroupBox2.Controls.Add(btnListUpdate1)
        GroupBox2.Controls.Add(btnRemove1)
        GroupBox2.Controls.Add(btnAdd1)
        GroupBox2.Controls.Add(DataGridView2)
        GroupBox2.Controls.Add(dtpPaymentDate)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Panel4)
        GroupBox2.Controls.Add(txtPayment)
        GroupBox2.Controls.Add(cmbPaymentMode)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(Label13)
        GroupBox2.Location = New Point(10, 213)
        GroupBox2.Margin = New Padding(4, 3, 4, 3)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4, 3, 4, 3)
        GroupBox2.RightToLeft = RightToLeft.Yes
        GroupBox2.Size = New Size(671, 286)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        GroupBox2.Text = "معلومات الدفع"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = Color.FloralWhite
        DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        DataGridView2.BackgroundColor = Color.White
        DataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = Color.CadetBlue
        DataGridViewCellStyle4.Font = New Font("Tahoma", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = Color.Black
        DataGridViewCellStyle4.SelectionBackColor = Color.LightSteelBlue
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridView2.ColumnHeadersHeight = 24
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {Column8, Column15, Column16})
        DataGridView2.Cursor = Cursors.Hand
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Tahoma", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        DataGridView2.DefaultCellStyle = DataGridViewCellStyle5
        DataGridView2.EnableHeadersVisualStyles = False
        DataGridView2.GridColor = Color.White
        DataGridView2.Location = New Point(7, 129)
        DataGridView2.Margin = New Padding(4, 3, 4, 3)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.ReadOnly = True
        DataGridView2.RightToLeft = RightToLeft.Yes
        DataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.CadetBlue
        DataGridViewCellStyle6.Font = New Font("Tahoma", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = Color.DarkSlateGray
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        DataGridView2.RowHeadersWidth = 25
        DataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle7.BackColor = Color.White
        DataGridViewCellStyle7.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle7.SelectionBackColor = Color.DarkSlateGray
        DataGridViewCellStyle7.SelectionForeColor = Color.White
        DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle7
        DataGridView2.RowTemplate.Height = 18
        DataGridView2.RowTemplate.Resizable = DataGridViewTriState.False
        DataGridView2.ScrollBars = ScrollBars.Vertical
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.Size = New Size(504, 127)
        DataGridView2.TabIndex = 86
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label31.Location = New Point(198, 42)
        Label31.Margin = New Padding(4, 0, 4, 0)
        Label31.Name = "Label31"
        Label31.Size = New Size(106, 13)
        Label31.TabIndex = 87
        Label31.Text = "الرصيد الحالى للعميل :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(376, 70)
        TextBox1.Margin = New Padding(4, 3, 4, 3)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(140, 23)
        TextBox1.TabIndex = 3
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(524, 74)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 15)
        Label3.TabIndex = 2
        Label3.Text = "رقم العميل :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(523, 36)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 15)
        Label2.TabIndex = 1
        Label2.Text = "أسم العميل :"
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
        txtGrandTotal.TextAlign = HorizontalAlignment.Center
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(376, 32)
        ComboBox1.Margin = New Padding(4, 3, 4, 3)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(140, 23)
        ComboBox1.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(234, 505)
        Button2.Margin = New Padding(4, 3, 4, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(105, 43)
        Button2.TabIndex = 11
        Button2.Text = "إغلاق"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(410, 505)
        Button1.Margin = New Padding(4, 3, 4, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(105, 43)
        Button1.TabIndex = 10
        Button1.Text = "حفظ"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label31)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtGrandTotal)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Location = New Point(10, 97)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.RightToLeft = RightToLeft.Yes
        GroupBox1.Size = New Size(671, 110)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "بيانات العميل"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(GroupBox1)
        Panel1.Controls.Add(GroupBox2)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(728, 567)
        Panel1.TabIndex = 3
        ' 
        ' frmOverallReport
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(728, 567)
        Controls.Add(Panel1)
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmOverallReport"
        ShowIcon = False
        Text = "form  Overall Report"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents cmbPaymentMode As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents txtPaymentDue As TextBox
    Friend WithEvents txtTotalPayment As TextBox
    Friend WithEvents dtpPaymentDate As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents btnListReset1 As Button
    Friend WithEvents btnListUpdate1 As Button
    Friend WithEvents btnRemove1 As Button
    Friend WithEvents btnAdd1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label31 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGrandTotal As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
End Class
