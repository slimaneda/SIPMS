<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPurchasProduct
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
        Label10 = New Label()
        txtRemarks = New RichTextBox()
        Panel4 = New Panel()
        Label31 = New Label()
        Label34 = New Label()
        Label35 = New Label()
        txtGrandTotal = New TextBox()
        txtPaymentDue = New TextBox()
        txtTotalPayment = New TextBox()
        DataGridView1 = New DataGridView()
        PID = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        GroupBox2 = New GroupBox()
        Label12 = New Label()
        txt_si = New TextBox()
        Label9 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        btnRemove = New Button()
        txtTotalAmount = New TextBox()
        txtPricePerQty = New TextBox()
        txtQty = New TextBox()
        btnAdd = New Button()
        Button1 = New Button()
        txtProductName = New TextBox()
        txtProductCode = New TextBox()
        GroupBox1 = New GroupBox()
        txtProductID = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label5 = New Label()
        Label11 = New Label()
        Button4 = New Button()
        txtSupplierName = New TextBox()
        txtSupplierID = New TextBox()
        dtpDate = New DateTimePicker()
        txtStockID = New TextBox()
        Panel3 = New Panel()
        btnGetData = New Button()
        btnClose = New Button()
        btnUpdate = New Button()
        btnSave = New Button()
        btnNew = New Button()
        Panel2 = New Panel()
        Label1 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        lbl = New Label()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(txtRemarks)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(GroupBox2)
        Panel1.Controls.Add(GroupBox1)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(9, 8)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(852, 676)
        Panel1.TabIndex = 2
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(400, 307)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.RightToLeft = RightToLeft.Yes
        Label10.Size = New Size(51, 13)
        Label10.TabIndex = 311
        Label10.Text = "ملاحظات :"
        ' 
        ' txtRemarks
        ' 
        txtRemarks.Location = New Point(13, 322)
        txtRemarks.Margin = New Padding(4, 5, 4, 5)
        txtRemarks.Name = "txtRemarks"
        txtRemarks.Size = New Size(444, 89)
        txtRemarks.TabIndex = 310
        txtRemarks.Text = ""
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Transparent
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(Label31)
        Panel4.Controls.Add(Label34)
        Panel4.Controls.Add(Label35)
        Panel4.Controls.Add(txtGrandTotal)
        Panel4.Controls.Add(txtPaymentDue)
        Panel4.Controls.Add(txtTotalPayment)
        Panel4.Location = New Point(562, 322)
        Panel4.Margin = New Padding(4, 5, 4, 5)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(205, 123)
        Panel4.TabIndex = 4
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label31.Location = New Point(105, 23)
        Label31.Margin = New Padding(4, 0, 4, 0)
        Label31.Name = "Label31"
        Label31.RightToLeft = RightToLeft.Yes
        Label31.Size = New Size(85, 13)
        Label31.TabIndex = 87
        Label31.Text = "إجمالى الفاتورة :"
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label34.Location = New Point(105, 81)
        Label34.Margin = New Padding(4, 0, 4, 0)
        Label34.Name = "Label34"
        Label34.RightToLeft = RightToLeft.Yes
        Label34.Size = New Size(47, 13)
        Label34.TabIndex = 86
        Label34.Text = "المتبقى :"
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label35.Location = New Point(105, 52)
        Label35.Margin = New Padding(4, 0, 4, 0)
        Label35.Name = "Label35"
        Label35.RightToLeft = RightToLeft.Yes
        Label35.Size = New Size(84, 13)
        Label35.TabIndex = 85
        Label35.Text = "إجمالى المدفوع :"
        ' 
        ' txtGrandTotal
        ' 
        txtGrandTotal.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtGrandTotal.Location = New Point(24, 23)
        txtGrandTotal.Margin = New Padding(4, 5, 4, 5)
        txtGrandTotal.Name = "txtGrandTotal"
        txtGrandTotal.ReadOnly = True
        txtGrandTotal.Size = New Size(72, 20)
        txtGrandTotal.TabIndex = 0
        txtGrandTotal.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtPaymentDue
        ' 
        txtPaymentDue.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtPaymentDue.Location = New Point(24, 81)
        txtPaymentDue.Margin = New Padding(4, 5, 4, 5)
        txtPaymentDue.Name = "txtPaymentDue"
        txtPaymentDue.ReadOnly = True
        txtPaymentDue.Size = New Size(72, 20)
        txtPaymentDue.TabIndex = 2
        txtPaymentDue.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtTotalPayment
        ' 
        txtTotalPayment.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtTotalPayment.Location = New Point(24, 52)
        txtTotalPayment.Margin = New Padding(4, 5, 4, 5)
        txtTotalPayment.Name = "txtTotalPayment"
        txtTotalPayment.Size = New Size(72, 20)
        txtTotalPayment.TabIndex = 1
        txtTotalPayment.Text = "0"
        txtTotalPayment.TextAlign = HorizontalAlignment.Right
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FloralWhite
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.CadetBlue
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.ColumnHeadersHeight = 24
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {PID, Column2, Column3, Column4, Column5, Column6, Column1})
        DataGridView1.Cursor = Cursors.Hand
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Window
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.GridColor = Color.White
        DataGridView1.Location = New Point(150, 85)
        DataGridView1.Margin = New Padding(4, 5, 4, 5)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RightToLeft = RightToLeft.Yes
        DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.CadetBlue
        DataGridViewCellStyle4.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = Color.DarkSlateGray
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridView1.RowHeadersWidth = 25
        DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.BackColor = Color.White
        DataGridViewCellStyle5.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.SelectionBackColor = Color.DarkSlateGray
        DataGridViewCellStyle5.SelectionForeColor = Color.White
        DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle5
        DataGridView1.RowTemplate.Height = 18
        DataGridView1.RowTemplate.Resizable = DataGridViewTriState.False
        DataGridView1.ScrollBars = ScrollBars.Vertical
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(617, 217)
        DataGridView1.TabIndex = 5
        ' 
        ' PID
        ' 
        PID.HeaderText = "رقم الفاتورة"
        PID.Name = "PID"
        PID.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "رقم المنتج"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "أسم المنتج"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "الكمية"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "سعر الوحدة"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "الاجمالى "
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "id"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(txt_si)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(btnRemove)
        GroupBox2.Controls.Add(txtTotalAmount)
        GroupBox2.Controls.Add(txtPricePerQty)
        GroupBox2.Controls.Add(txtQty)
        GroupBox2.Controls.Add(btnAdd)
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Controls.Add(txtProductName)
        GroupBox2.Controls.Add(txtProductCode)
        GroupBox2.Location = New Point(13, 420)
        GroupBox2.Margin = New Padding(4, 5, 4, 5)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4, 5, 4, 5)
        GroupBox2.RightToLeft = RightToLeft.Yes
        GroupBox2.Size = New Size(444, 190)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "بيانات الفاتورة"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(42, 100)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(83, 15)
        Label12.TabIndex = 36
        Label12.Text = "STOCK INITIAL"
        ' 
        ' txt_si
        ' 
        txt_si.Location = New Point(136, 97)
        txt_si.Margin = New Padding(4, 3, 4, 3)
        txt_si.Name = "txt_si"
        txt_si.Size = New Size(63, 23)
        txt_si.TabIndex = 35
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(360, 150)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(47, 15)
        Label9.TabIndex = 34
        Label9.Text = "إجمالى :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(360, 120)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(66, 15)
        Label6.TabIndex = 33
        Label6.Text = "سعر الشراء :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(360, 90)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 15)
        Label4.TabIndex = 32
        Label4.Text = "الكمية :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(362, 30)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(62, 15)
        Label7.TabIndex = 30
        Label7.Text = "رقم المنتج :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(362, 60)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(65, 15)
        Label8.TabIndex = 31
        Label8.Text = "أسم المنتج :"
        ' 
        ' btnRemove
        ' 
        btnRemove.Enabled = False
        btnRemove.FlatStyle = FlatStyle.Popup
        btnRemove.Location = New Point(85, 29)
        btnRemove.Margin = New Padding(4, 5, 4, 5)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(71, 24)
        btnRemove.TabIndex = 7
        btnRemove.Text = "حذف"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' txtTotalAmount
        ' 
        txtTotalAmount.BackColor = SystemColors.Control
        txtTotalAmount.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtTotalAmount.Location = New Point(272, 155)
        txtTotalAmount.Margin = New Padding(4, 5, 4, 5)
        txtTotalAmount.Name = "txtTotalAmount"
        txtTotalAmount.ReadOnly = True
        txtTotalAmount.Size = New Size(81, 21)
        txtTotalAmount.TabIndex = 4
        txtTotalAmount.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtPricePerQty
        ' 
        txtPricePerQty.BackColor = SystemColors.ButtonHighlight
        txtPricePerQty.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtPricePerQty.Location = New Point(272, 125)
        txtPricePerQty.Margin = New Padding(4, 5, 4, 5)
        txtPricePerQty.Name = "txtPricePerQty"
        txtPricePerQty.Size = New Size(81, 21)
        txtPricePerQty.TabIndex = 3
        txtPricePerQty.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtQty
        ' 
        txtQty.BackColor = SystemColors.ButtonHighlight
        txtQty.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtQty.Location = New Point(272, 95)
        txtQty.Margin = New Padding(4, 5, 4, 5)
        txtQty.Name = "txtQty"
        txtQty.Size = New Size(81, 21)
        txtQty.TabIndex = 2
        txtQty.TextAlign = HorizontalAlignment.Right
        ' 
        ' btnAdd
        ' 
        btnAdd.FlatStyle = FlatStyle.Popup
        btnAdd.Location = New Point(163, 29)
        btnAdd.Margin = New Padding(4, 5, 4, 5)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(63, 24)
        btnAdd.TabIndex = 6
        btnAdd.Text = "إضافة"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(233, 29)
        Button1.Margin = New Padding(4, 5, 4, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(34, 24)
        Button1.TabIndex = 5
        Button1.Text = "..."
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtProductName
        ' 
        txtProductName.BackColor = SystemColors.Control
        txtProductName.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtProductName.Location = New Point(85, 60)
        txtProductName.Margin = New Padding(4, 5, 4, 5)
        txtProductName.Name = "txtProductName"
        txtProductName.ReadOnly = True
        txtProductName.Size = New Size(270, 21)
        txtProductName.TabIndex = 1
        ' 
        ' txtProductCode
        ' 
        txtProductCode.BackColor = SystemColors.Control
        txtProductCode.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtProductCode.Location = New Point(274, 29)
        txtProductCode.Margin = New Padding(4, 5, 4, 5)
        txtProductCode.Name = "txtProductCode"
        txtProductCode.ReadOnly = True
        txtProductCode.Size = New Size(81, 21)
        txtProductCode.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtProductID)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(txtSupplierName)
        GroupBox1.Controls.Add(txtSupplierID)
        GroupBox1.Controls.Add(dtpDate)
        GroupBox1.Controls.Add(txtStockID)
        GroupBox1.Location = New Point(461, 452)
        GroupBox1.Margin = New Padding(4, 5, 4, 5)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 5, 4, 5)
        GroupBox1.RightToLeft = RightToLeft.Yes
        GroupBox1.Size = New Size(383, 158)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "بيانات المورد"
        ' 
        ' txtProductID
        ' 
        txtProductID.Location = New Point(126, 22)
        txtProductID.Margin = New Padding(4, 5, 4, 5)
        txtProductID.Name = "txtProductID"
        txtProductID.Size = New Size(58, 23)
        txtProductID.TabIndex = 311
        txtProductID.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(296, 32)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 15)
        Label3.TabIndex = 23
        Label3.Text = "رقم الفاتورة :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(298, 62)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 15)
        Label2.TabIndex = 24
        Label2.Text = "تاريخ الشراء :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(298, 90)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 15)
        Label5.TabIndex = 25
        Label5.Text = "رقم المورد :"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(296, 120)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(66, 15)
        Label11.TabIndex = 26
        Label11.Text = "اسم المورد :"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(152, 83)
        Button4.Margin = New Padding(4, 5, 4, 5)
        Button4.Name = "Button4"
        Button4.Size = New Size(34, 24)
        Button4.TabIndex = 4
        Button4.Text = " "
        Button4.UseVisualStyleBackColor = True
        ' 
        ' txtSupplierName
        ' 
        txtSupplierName.BackColor = SystemColors.Control
        txtSupplierName.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtSupplierName.Location = New Point(63, 114)
        txtSupplierName.Margin = New Padding(4, 5, 4, 5)
        txtSupplierName.Name = "txtSupplierName"
        txtSupplierName.ReadOnly = True
        txtSupplierName.Size = New Size(221, 21)
        txtSupplierName.TabIndex = 3
        ' 
        ' txtSupplierID
        ' 
        txtSupplierID.BackColor = SystemColors.Control
        txtSupplierID.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtSupplierID.Location = New Point(203, 83)
        txtSupplierID.Margin = New Padding(4, 5, 4, 5)
        txtSupplierID.Name = "txtSupplierID"
        txtSupplierID.ReadOnly = True
        txtSupplierID.Size = New Size(81, 21)
        txtSupplierID.TabIndex = 2
        ' 
        ' dtpDate
        ' 
        dtpDate.CustomFormat = "dd/MM/yyyy"
        dtpDate.Format = DateTimePickerFormat.Custom
        dtpDate.Location = New Point(140, 55)
        dtpDate.Margin = New Padding(4, 5, 4, 5)
        dtpDate.Name = "dtpDate"
        dtpDate.RightToLeft = RightToLeft.No
        dtpDate.Size = New Size(144, 23)
        dtpDate.TabIndex = 1
        ' 
        ' txtStockID
        ' 
        txtStockID.BackColor = SystemColors.Control
        txtStockID.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtStockID.Location = New Point(203, 25)
        txtStockID.Margin = New Padding(4, 5, 4, 5)
        txtStockID.Name = "txtStockID"
        txtStockID.ReadOnly = True
        txtStockID.Size = New Size(81, 21)
        txtStockID.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(btnGetData)
        Panel3.Controls.Add(btnClose)
        Panel3.Controls.Add(btnUpdate)
        Panel3.Controls.Add(btnSave)
        Panel3.Controls.Add(btnNew)
        Panel3.Location = New Point(10, 85)
        Panel3.Margin = New Padding(4, 5, 4, 5)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(129, 205)
        Panel3.TabIndex = 2
        ' 
        ' btnGetData
        ' 
        btnGetData.Cursor = Cursors.Hand
        btnGetData.FlatStyle = FlatStyle.Popup
        btnGetData.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnGetData.Location = New Point(15, 120)
        btnGetData.Margin = New Padding(4, 5, 4, 5)
        btnGetData.Name = "btnGetData"
        btnGetData.Size = New Size(96, 32)
        btnGetData.TabIndex = 5
        btnGetData.Text = "&قائمة الفواتير"
        btnGetData.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Cursor = Cursors.Hand
        btnClose.FlatStyle = FlatStyle.Popup
        btnClose.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnClose.Location = New Point(15, 156)
        btnClose.Margin = New Padding(4, 5, 4, 5)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(96, 32)
        btnClose.TabIndex = 4
        btnClose.Text = "&إغلاق"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.FlatStyle = FlatStyle.Popup
        btnUpdate.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnUpdate.Location = New Point(15, 83)
        btnUpdate.Margin = New Padding(4, 5, 4, 5)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(96, 32)
        btnUpdate.TabIndex = 2
        btnUpdate.Text = "&تحديث"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Cursor = Cursors.Hand
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnSave.Location = New Point(15, 47)
        btnSave.Margin = New Padding(4, 5, 4, 5)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(96, 32)
        btnSave.TabIndex = 1
        btnSave.Text = "&حفظ"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnNew
        ' 
        btnNew.Cursor = Cursors.Hand
        btnNew.FlatStyle = FlatStyle.Popup
        btnNew.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnNew.Location = New Point(15, 10)
        btnNew.Margin = New Padding(4, 5, 4, 5)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(96, 32)
        btnNew.TabIndex = 0
        btnNew.Text = "&جديد"
        btnNew.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkSlateGray
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Controls.Add(lbl)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(10, 8)
        Panel2.Margin = New Padding(4, 5, 4, 5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(841, 70)
        Panel2.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(381, 23)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 24)
        Label1.TabIndex = 0
        Label1.Text = "فاتورة مشتريات"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' lbl
        ' 
        lbl.AutoSize = True
        lbl.BackColor = Color.Transparent
        lbl.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl.ForeColor = Color.White
        lbl.Location = New Point(16, 23)
        lbl.Margin = New Padding(4, 0, 4, 0)
        lbl.Name = "lbl"
        lbl.Size = New Size(0, 24)
        lbl.TabIndex = 1
        ' 
        ' FormPurchasProduct
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateGray
        ClientSize = New Size(872, 692)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormPurchasProduct"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtStockID As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnGetData As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtGrandTotal As TextBox
    Friend WithEvents txtPaymentDue As TextBox
    Friend WithEvents txtTotalPayment As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents txtPricePerQty As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtProductCode As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents txtSupplierName As TextBox
    Friend WithEvents txtSupplierID As TextBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents txtRemarks As RichTextBox
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents PID As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_si As TextBox
    Friend WithEvents lbl As Label
End Class
