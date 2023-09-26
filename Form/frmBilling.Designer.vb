<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBilling
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label5 = New Label()
        Label25 = New Label()
        Label51 = New Label()
        Label49 = New Label()
        Label6 = New Label()
        Panel2 = New Panel()
        Label1 = New Label()
        GroupBox4 = New GroupBox()
        dtpInvoiceDate = New DateTimePicker()
        txtInvoiceNo = New TextBox()
        Label4 = New Label()
        DataGridView1 = New DataGridView()
        Column12 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column13 = New DataGridViewTextBoxColumn()
        Column14 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        txtGrandTotal = New TextBox()
        Label31 = New Label()
        txtPaymentDue = New TextBox()
        txtTotalPayment = New TextBox()
        Label34 = New Label()
        Label35 = New Label()
        DataGridView2 = New DataGridView()
        Column8 = New DataGridViewTextBoxColumn()
        Column15 = New DataGridViewTextBoxColumn()
        Column16 = New DataGridViewTextBoxColumn()
        GroupBox2 = New GroupBox()
        btnListReset1 = New Button()
        btnListUpdate1 = New Button()
        dtpPaymentDate = New DateTimePicker()
        Label7 = New Label()
        txtPayment = New TextBox()
        cmbPaymentMode = New ComboBox()
        btnRemove1 = New Button()
        btnAdd1 = New Button()
        Label12 = New Label()
        Label13 = New Label()
        GroupBox3 = New GroupBox()
        txtContactNo = New TextBox()
        Label9 = New Label()
        Label2 = New Label()
        btnSelect = New Button()
        Label3 = New Label()
        txtCustomerID = New TextBox()
        txtCustomerName = New TextBox()
        GroupBox5 = New GroupBox()
        btnListReset = New Button()
        btnListUpdate = New Button()
        btnRemove = New Button()
        btnSelectionInv = New Button()
        txtTotalAmount = New TextBox()
        Label24 = New Label()
        txtQty = New TextBox()
        txtProductName = New TextBox()
        btnAdd = New Button()
        Label23 = New Label()
        txtProductCode = New TextBox()
        txtDiscountPer = New TextBox()
        txtVATAmount = New TextBox()
        Label58 = New Label()
        Label10 = New Label()
        txtMargin = New TextBox()
        Label21 = New Label()
        Label56 = New Label()
        txtCostPrice = New TextBox()
        txtDiscountAmount = New TextBox()
        txtAmount = New TextBox()
        txtVAT = New TextBox()
        Label11 = New Label()
        txtSellingPrice = New TextBox()
        Panel3 = New Panel()
        btnPrint = New Button()
        btnGetData = New Button()
        btnDelete = New Button()
        btnClose = New Button()
        btnUpdate = New Button()
        btnSave = New Button()
        btnNew = New Button()
        Panel2.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox5.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(387, 20)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 15)
        Label5.TabIndex = 268
        Label5.Text = "رقم الفاتورة  :"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.ForeColor = Color.Black
        Label25.Location = New Point(363, 232)
        Label25.Margin = New Padding(2, 0, 2, 0)
        Label25.Name = "Label25"
        Label25.Size = New Size(75, 13)
        Label25.TabIndex = 326
        Label25.Text = "الاجمالى العام :"
        ' 
        ' Label51
        ' 
        Label51.AutoSize = True
        Label51.ForeColor = Color.Black
        Label51.Location = New Point(365, 136)
        Label51.Margin = New Padding(2, 0, 2, 0)
        Label51.Name = "Label51"
        Label51.Size = New Size(63, 13)
        Label51.TabIndex = 319
        Label51.Text = "عدد الوحدة :"
        ' 
        ' Label49
        ' 
        Label49.AutoSize = True
        Label49.ForeColor = Color.Black
        Label49.Location = New Point(372, 168)
        Label49.Margin = New Padding(2, 0, 2, 0)
        Label49.Name = "Label49"
        Label49.Size = New Size(46, 13)
        Label49.TabIndex = 314
        Label49.Text = "إجمالى :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(363, 202)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(71, 13)
        Label6.TabIndex = 312
        Label6.Text = "نسبة الضريبة :"
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
        Panel2.RightToLeft = RightToLeft.Yes
        Panel2.Size = New Size(955, 72)
        Panel2.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(418, 23)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 24)
        Label1.TabIndex = 0
        Label1.Text = "فاتورة المبيعات "
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(dtpInvoiceDate)
        GroupBox4.Controls.Add(txtInvoiceNo)
        GroupBox4.Controls.Add(Label4)
        GroupBox4.Controls.Add(Label5)
        GroupBox4.FlatStyle = FlatStyle.Flat
        GroupBox4.Location = New Point(273, 78)
        GroupBox4.Margin = New Padding(4, 3, 4, 3)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(4, 3, 4, 3)
        GroupBox4.RightToLeft = RightToLeft.Yes
        GroupBox4.Size = New Size(490, 57)
        GroupBox4.TabIndex = 4
        GroupBox4.TabStop = False
        GroupBox4.Text = "معلومات الفاتورة"
        ' 
        ' dtpInvoiceDate
        ' 
        dtpInvoiceDate.CustomFormat = "dd/MM/yyyy"
        dtpInvoiceDate.Format = DateTimePickerFormat.Custom
        dtpInvoiceDate.Location = New Point(16, 23)
        dtpInvoiceDate.Margin = New Padding(2)
        dtpInvoiceDate.Name = "dtpInvoiceDate"
        dtpInvoiceDate.Size = New Size(107, 23)
        dtpInvoiceDate.TabIndex = 1
        ' 
        ' txtInvoiceNo
        ' 
        txtInvoiceNo.Location = New Point(274, 20)
        txtInvoiceNo.Margin = New Padding(4, 3, 4, 3)
        txtInvoiceNo.Name = "txtInvoiceNo"
        txtInvoiceNo.ReadOnly = True
        txtInvoiceNo.Size = New Size(107, 23)
        txtInvoiceNo.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(160, 21)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 15)
        Label4.TabIndex = 335
        Label4.Text = "تاريخ الفاتورة :"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FloralWhite
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
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
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column12, Column1, Column2, Column13, Column14, Column3, Column4, Column5, Column6, Column9, Column10, Column11, Column7})
        DataGridView1.Cursor = Cursors.Hand
        DataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = SystemColors.Window
        DataGridViewCellStyle13.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle13.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle13
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.GridColor = Color.White
        DataGridView1.Location = New Point(5, 162)
        DataGridView1.Margin = New Padding(4, 3, 4, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RightToLeft = RightToLeft.Yes
        DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = Color.CadetBlue
        DataGridViewCellStyle14.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle14.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = Color.DarkSlateGray
        DataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        DataGridView1.RowHeadersWidth = 25
        DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle15.BackColor = Color.White
        DataGridViewCellStyle15.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle15.SelectionBackColor = Color.DarkSlateGray
        DataGridViewCellStyle15.SelectionForeColor = Color.White
        DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle15
        DataGridView1.RowTemplate.Height = 18
        DataGridView1.RowTemplate.Resizable = DataGridViewTriState.False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(933, 130)
        DataGridView1.TabIndex = 11
        ' 
        ' Column12
        ' 
        Column12.HeaderText = "رقم المنتج"
        Column12.Name = "Column12"
        Column12.ReadOnly = True
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "أسم المنتج"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopRight
        Column2.DefaultCellStyle = DataGridViewCellStyle3
        Column2.HeaderText = "سعر الشراء"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Visible = False
        ' 
        ' Column13
        ' 
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopRight
        Column13.DefaultCellStyle = DataGridViewCellStyle4
        Column13.HeaderText = "سعر البيع"
        Column13.Name = "Column13"
        Column13.ReadOnly = True
        ' 
        ' Column14
        ' 
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.TopRight
        Column14.DefaultCellStyle = DataGridViewCellStyle5
        Column14.HeaderText = "Margin"
        Column14.Name = "Column14"
        Column14.ReadOnly = True
        Column14.Visible = False
        ' 
        ' Column3
        ' 
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.TopRight
        Column3.DefaultCellStyle = DataGridViewCellStyle6
        Column3.HeaderText = "الكمية"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.TopRight
        Column4.DefaultCellStyle = DataGridViewCellStyle7
        Column4.HeaderText = "إجمالى"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.TopRight
        Column5.DefaultCellStyle = DataGridViewCellStyle8
        Column5.HeaderText = "الوحدة"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Column6
        ' 
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.TopRight
        Column6.DefaultCellStyle = DataGridViewCellStyle9
        Column6.HeaderText = "Discount"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Visible = False
        ' 
        ' Column9
        ' 
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.TopRight
        Column9.DefaultCellStyle = DataGridViewCellStyle10
        Column9.HeaderText = "VAT %"
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.Visible = False
        ' 
        ' Column10
        ' 
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.TopRight
        Column10.DefaultCellStyle = DataGridViewCellStyle11
        Column10.HeaderText = "VAT Amt"
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        ' 
        ' Column11
        ' 
        DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.TopRight
        Column11.DefaultCellStyle = DataGridViewCellStyle12
        Column11.HeaderText = "الاجمالى العام"
        Column11.Name = "Column11"
        Column11.ReadOnly = True
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "PID"
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Visible = False
        ' 
        ' txtGrandTotal
        ' 
        txtGrandTotal.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtGrandTotal.Location = New Point(0, 317)
        txtGrandTotal.Margin = New Padding(4, 3, 4, 3)
        txtGrandTotal.Name = "txtGrandTotal"
        txtGrandTotal.ReadOnly = True
        txtGrandTotal.Size = New Size(83, 20)
        txtGrandTotal.TabIndex = 98
        txtGrandTotal.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label31.Location = New Point(112, 317)
        Label31.Margin = New Padding(4, 0, 4, 0)
        Label31.Name = "Label31"
        Label31.RightToLeft = RightToLeft.Yes
        Label31.Size = New Size(85, 13)
        Label31.TabIndex = 103
        Label31.Text = "إجمالى الفاتورة :"
        ' 
        ' txtPaymentDue
        ' 
        txtPaymentDue.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtPaymentDue.Location = New Point(0, 373)
        txtPaymentDue.Margin = New Padding(4, 3, 4, 3)
        txtPaymentDue.Name = "txtPaymentDue"
        txtPaymentDue.ReadOnly = True
        txtPaymentDue.Size = New Size(83, 20)
        txtPaymentDue.TabIndex = 100
        txtPaymentDue.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtTotalPayment
        ' 
        txtTotalPayment.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtTotalPayment.Location = New Point(0, 344)
        txtTotalPayment.Margin = New Padding(4, 3, 4, 3)
        txtTotalPayment.Name = "txtTotalPayment"
        txtTotalPayment.ReadOnly = True
        txtTotalPayment.Size = New Size(83, 20)
        txtTotalPayment.TabIndex = 99
        txtTotalPayment.Text = "0"
        txtTotalPayment.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label34.Location = New Point(152, 373)
        Label34.Margin = New Padding(4, 0, 4, 0)
        Label34.Name = "Label34"
        Label34.RightToLeft = RightToLeft.Yes
        Label34.Size = New Size(47, 13)
        Label34.TabIndex = 102
        Label34.Text = "المتبقى :"
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label35.Location = New Point(112, 343)
        Label35.Margin = New Padding(4, 0, 4, 0)
        Label35.Name = "Label35"
        Label35.RightToLeft = RightToLeft.Yes
        Label35.Size = New Size(84, 13)
        Label35.TabIndex = 101
        Label35.Text = "إجمالى المدفوع :"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.AllowUserToDeleteRows = False
        DataGridViewCellStyle16.BackColor = Color.FloralWhite
        DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.BackgroundColor = Color.White
        DataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = Color.CadetBlue
        DataGridViewCellStyle17.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle17.ForeColor = Color.Black
        DataGridViewCellStyle17.SelectionBackColor = Color.LightSteelBlue
        DataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = DataGridViewTriState.True
        DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        DataGridView2.ColumnHeadersHeight = 24
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {Column8, Column15, Column16})
        DataGridView2.Cursor = Cursors.Hand
        DataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = SystemColors.Window
        DataGridViewCellStyle20.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle20.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle20.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = DataGridViewTriState.False
        DataGridView2.DefaultCellStyle = DataGridViewCellStyle20
        DataGridView2.EnableHeadersVisualStyles = False
        DataGridView2.GridColor = Color.White
        DataGridView2.Location = New Point(141, 393)
        DataGridView2.Margin = New Padding(4, 3, 4, 3)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.ReadOnly = True
        DataGridView2.RightToLeft = RightToLeft.Yes
        DataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = Color.CadetBlue
        DataGridViewCellStyle21.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle21.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle21.SelectionBackColor = Color.DarkSlateGray
        DataGridViewCellStyle21.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle21.WrapMode = DataGridViewTriState.True
        DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle21
        DataGridView2.RowHeadersWidth = 25
        DataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle22.BackColor = Color.White
        DataGridViewCellStyle22.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle22.SelectionBackColor = Color.DarkSlateGray
        DataGridViewCellStyle22.SelectionForeColor = Color.White
        DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle22
        DataGridView2.RowTemplate.Height = 18
        DataGridView2.RowTemplate.Resizable = DataGridViewTriState.False
        DataGridView2.ScrollBars = ScrollBars.Vertical
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.Size = New Size(301, 97)
        DataGridView2.TabIndex = 97
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "طريقة الدفع"
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        ' 
        ' Column15
        ' 
        DataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.TopRight
        Column15.DefaultCellStyle = DataGridViewCellStyle18
        Column15.HeaderText = "المبلغ"
        Column15.Name = "Column15"
        Column15.ReadOnly = True
        ' 
        ' Column16
        ' 
        DataGridViewCellStyle19.Format = "dd/MM/yyyy"
        Column16.DefaultCellStyle = DataGridViewCellStyle19
        Column16.HeaderText = "تاريخ الدفع"
        Column16.Name = "Column16"
        Column16.ReadOnly = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnListReset1)
        GroupBox2.Controls.Add(btnListUpdate1)
        GroupBox2.Controls.Add(dtpPaymentDate)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(txtPayment)
        GroupBox2.Controls.Add(cmbPaymentMode)
        GroupBox2.Controls.Add(btnRemove1)
        GroupBox2.Controls.Add(btnAdd1)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(Label13)
        GroupBox2.Location = New Point(52, 492)
        GroupBox2.Margin = New Padding(4, 3, 4, 3)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4, 3, 4, 3)
        GroupBox2.RightToLeft = RightToLeft.Yes
        GroupBox2.Size = New Size(421, 145)
        GroupBox2.TabIndex = 95
        GroupBox2.TabStop = False
        GroupBox2.Text = "معلومات الدفع"
        ' 
        ' btnListReset1
        ' 
        btnListReset1.FlatStyle = FlatStyle.Popup
        btnListReset1.Location = New Point(16, 23)
        btnListReset1.Margin = New Padding(4, 3, 4, 3)
        btnListReset1.Name = "btnListReset1"
        btnListReset1.Size = New Size(74, 24)
        btnListReset1.TabIndex = 27
        btnListReset1.Text = "مسح"
        btnListReset1.UseVisualStyleBackColor = True
        ' 
        ' btnListUpdate1
        ' 
        btnListUpdate1.Enabled = False
        btnListUpdate1.FlatStyle = FlatStyle.Popup
        btnListUpdate1.Location = New Point(15, 112)
        btnListUpdate1.Margin = New Padding(4, 3, 4, 3)
        btnListUpdate1.Name = "btnListUpdate1"
        btnListUpdate1.Size = New Size(74, 24)
        btnListUpdate1.TabIndex = 26
        btnListUpdate1.Text = "تحديث"
        btnListUpdate1.UseVisualStyleBackColor = True
        ' 
        ' dtpPaymentDate
        ' 
        dtpPaymentDate.CustomFormat = "dd/MM/yyyy"
        dtpPaymentDate.Format = DateTimePickerFormat.Custom
        dtpPaymentDate.Location = New Point(198, 93)
        dtpPaymentDate.Margin = New Padding(2)
        dtpPaymentDate.Name = "dtpPaymentDate"
        dtpPaymentDate.Size = New Size(107, 23)
        dtpPaymentDate.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(332, 95)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(44, 15)
        Label7.TabIndex = 25
        Label7.Text = "التاريخ :"
        ' 
        ' txtPayment
        ' 
        txtPayment.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtPayment.Location = New Point(225, 63)
        txtPayment.Margin = New Padding(4, 3, 4, 3)
        txtPayment.Name = "txtPayment"
        txtPayment.Size = New Size(80, 20)
        txtPayment.TabIndex = 1
        txtPayment.TextAlign = HorizontalAlignment.Right
        ' 
        ' cmbPaymentMode
        ' 
        cmbPaymentMode.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPaymentMode.FormattingEnabled = True
        cmbPaymentMode.Items.AddRange(New Object() {"By Cash", "By Cheque", "By DD", "By Debit Card", "By Credit Card"})
        cmbPaymentMode.Location = New Point(187, 33)
        cmbPaymentMode.Margin = New Padding(4, 3, 4, 3)
        cmbPaymentMode.Name = "cmbPaymentMode"
        cmbPaymentMode.Size = New Size(118, 23)
        cmbPaymentMode.TabIndex = 0
        ' 
        ' btnRemove1
        ' 
        btnRemove1.Enabled = False
        btnRemove1.FlatStyle = FlatStyle.Popup
        btnRemove1.Location = New Point(15, 82)
        btnRemove1.Margin = New Padding(4, 3, 4, 3)
        btnRemove1.Name = "btnRemove1"
        btnRemove1.Size = New Size(74, 24)
        btnRemove1.TabIndex = 4
        btnRemove1.Text = "حذف"
        btnRemove1.UseVisualStyleBackColor = True
        ' 
        ' btnAdd1
        ' 
        btnAdd1.FlatStyle = FlatStyle.Popup
        btnAdd1.Location = New Point(15, 53)
        btnAdd1.Margin = New Padding(4, 3, 4, 3)
        btnAdd1.Name = "btnAdd1"
        btnAdd1.Size = New Size(74, 24)
        btnAdd1.TabIndex = 3
        btnAdd1.Text = "إضافة"
        btnAdd1.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(332, 33)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(74, 15)
        Label12.TabIndex = 11
        Label12.Text = "طريقة الدفع :"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(332, 63)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(43, 15)
        Label13.TabIndex = 22
        Label13.Text = "القيمة :"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(txtContactNo)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(Label2)
        GroupBox3.Controls.Add(btnSelect)
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Controls.Add(txtCustomerID)
        GroupBox3.Controls.Add(txtCustomerName)
        GroupBox3.Location = New Point(289, 303)
        GroupBox3.Margin = New Padding(4, 3, 4, 3)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(4, 3, 4, 3)
        GroupBox3.RightToLeft = RightToLeft.Yes
        GroupBox3.Size = New Size(648, 66)
        GroupBox3.TabIndex = 93
        GroupBox3.TabStop = False
        GroupBox3.Text = "معلومات العميل"
        ' 
        ' txtContactNo
        ' 
        txtContactNo.Location = New Point(22, 30)
        txtContactNo.Margin = New Padding(4, 3, 4, 3)
        txtContactNo.Name = "txtContactNo"
        txtContactNo.Size = New Size(101, 23)
        txtContactNo.TabIndex = 2
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(144, 33)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(68, 15)
        Label9.TabIndex = 8
        Label9.Text = "رقم الهاتف. :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(388, 36)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 15)
        Label2.TabIndex = 7
        Label2.Text = "أسم العميل :"
        ' 
        ' btnSelect
        ' 
        btnSelect.Location = New Point(468, 29)
        btnSelect.Margin = New Padding(4, 3, 4, 3)
        btnSelect.Name = "btnSelect"
        btnSelect.Size = New Size(12, 24)
        btnSelect.TabIndex = 3
        btnSelect.Text = "..."
        btnSelect.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(568, 29)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 15)
        Label3.TabIndex = 0
        Label3.Text = "رقم العميل :"
        ' 
        ' txtCustomerID
        ' 
        txtCustomerID.BackColor = SystemColors.Control
        txtCustomerID.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtCustomerID.Location = New Point(507, 29)
        txtCustomerID.Margin = New Padding(4, 3, 4, 3)
        txtCustomerID.Name = "txtCustomerID"
        txtCustomerID.ReadOnly = True
        txtCustomerID.Size = New Size(34, 21)
        txtCustomerID.TabIndex = 0
        ' 
        ' txtCustomerName
        ' 
        txtCustomerName.Location = New Point(237, 33)
        txtCustomerName.Margin = New Padding(4, 3, 4, 3)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.Size = New Size(128, 23)
        txtCustomerName.TabIndex = 1
        ' 
        ' GroupBox5
        ' 
        GroupBox5.BackColor = Color.Transparent
        GroupBox5.Controls.Add(btnListReset)
        GroupBox5.Controls.Add(btnListUpdate)
        GroupBox5.Controls.Add(btnRemove)
        GroupBox5.Controls.Add(btnSelectionInv)
        GroupBox5.Controls.Add(Label25)
        GroupBox5.Controls.Add(txtTotalAmount)
        GroupBox5.Controls.Add(Label24)
        GroupBox5.Controls.Add(txtQty)
        GroupBox5.Controls.Add(txtProductName)
        GroupBox5.Controls.Add(btnAdd)
        GroupBox5.Controls.Add(Label23)
        GroupBox5.Controls.Add(txtProductCode)
        GroupBox5.Controls.Add(txtDiscountPer)
        GroupBox5.Controls.Add(Label51)
        GroupBox5.Controls.Add(txtVATAmount)
        GroupBox5.Controls.Add(Label58)
        GroupBox5.Controls.Add(Label10)
        GroupBox5.Controls.Add(txtMargin)
        GroupBox5.Controls.Add(Label21)
        GroupBox5.Controls.Add(Label56)
        GroupBox5.Controls.Add(txtCostPrice)
        GroupBox5.Controls.Add(txtDiscountAmount)
        GroupBox5.Controls.Add(txtAmount)
        GroupBox5.Controls.Add(Label49)
        GroupBox5.Controls.Add(txtVAT)
        GroupBox5.Controls.Add(Label6)
        GroupBox5.Controls.Add(Label11)
        GroupBox5.Controls.Add(txtSellingPrice)
        GroupBox5.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox5.Location = New Point(478, 378)
        GroupBox5.Margin = New Padding(4, 3, 4, 3)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Padding = New Padding(4, 3, 4, 3)
        GroupBox5.RightToLeft = RightToLeft.Yes
        GroupBox5.Size = New Size(462, 265)
        GroupBox5.TabIndex = 94
        GroupBox5.TabStop = False
        GroupBox5.Text = "تفاصيل المنتج"
        ' 
        ' btnListReset
        ' 
        btnListReset.Cursor = Cursors.Hand
        btnListReset.FlatStyle = FlatStyle.Popup
        btnListReset.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnListReset.Location = New Point(6, 17)
        btnListReset.Margin = New Padding(4, 3, 4, 3)
        btnListReset.Name = "btnListReset"
        btnListReset.Size = New Size(83, 22)
        btnListReset.TabIndex = 328
        btnListReset.Text = "مسح"
        btnListReset.UseVisualStyleBackColor = True
        ' 
        ' btnListUpdate
        ' 
        btnListUpdate.Enabled = False
        btnListUpdate.FlatStyle = FlatStyle.Popup
        btnListUpdate.Location = New Point(6, 113)
        btnListUpdate.Margin = New Padding(4, 3, 4, 3)
        btnListUpdate.Name = "btnListUpdate"
        btnListUpdate.Size = New Size(83, 24)
        btnListUpdate.TabIndex = 327
        btnListUpdate.Text = "تحديث"
        btnListUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnRemove
        ' 
        btnRemove.Cursor = Cursors.Hand
        btnRemove.Enabled = False
        btnRemove.FlatStyle = FlatStyle.Popup
        btnRemove.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnRemove.Location = New Point(5, 85)
        btnRemove.Margin = New Padding(4, 3, 4, 3)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(83, 22)
        btnRemove.TabIndex = 13
        btnRemove.Text = "حذف"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' btnSelectionInv
        ' 
        btnSelectionInv.BackColor = Color.WhiteSmoke
        btnSelectionInv.Location = New Point(208, 20)
        btnSelectionInv.Margin = New Padding(4, 3, 4, 3)
        btnSelectionInv.Name = "btnSelectionInv"
        btnSelectionInv.Size = New Size(12, 22)
        btnSelectionInv.TabIndex = 12
        btnSelectionInv.Text = "..."
        btnSelectionInv.UseVisualStyleBackColor = False
        ' 
        ' txtTotalAmount
        ' 
        txtTotalAmount.Location = New Point(261, 228)
        txtTotalAmount.Margin = New Padding(4, 3, 4, 3)
        txtTotalAmount.Name = "txtTotalAmount"
        txtTotalAmount.ReadOnly = True
        txtTotalAmount.Size = New Size(75, 20)
        txtTotalAmount.TabIndex = 9
        txtTotalAmount.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label24.Location = New Point(365, 112)
        Label24.Margin = New Padding(4, 0, 4, 0)
        Label24.Name = "Label24"
        Label24.Size = New Size(40, 13)
        Label24.TabIndex = 324
        Label24.Text = "الكمية :"
        ' 
        ' txtQty
        ' 
        txtQty.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtQty.Location = New Point(261, 108)
        txtQty.Margin = New Padding(4, 3, 4, 3)
        txtQty.Name = "txtQty"
        txtQty.Size = New Size(75, 20)
        txtQty.TabIndex = 3
        txtQty.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtProductName
        ' 
        txtProductName.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtProductName.Location = New Point(119, 50)
        txtProductName.Margin = New Padding(4, 3, 4, 3)
        txtProductName.Name = "txtProductName"
        txtProductName.ReadOnly = True
        txtProductName.Size = New Size(218, 20)
        txtProductName.TabIndex = 1
        ' 
        ' btnAdd
        ' 
        btnAdd.Cursor = Cursors.Hand
        btnAdd.FlatStyle = FlatStyle.Popup
        btnAdd.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnAdd.Location = New Point(5, 51)
        btnAdd.Margin = New Padding(4, 3, 4, 3)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(83, 22)
        btnAdd.TabIndex = 12
        btnAdd.Text = "&إضافة للقائمة"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label23.Location = New Point(365, 51)
        Label23.Margin = New Padding(4, 0, 4, 0)
        Label23.Name = "Label23"
        Label23.Size = New Size(60, 13)
        Label23.TabIndex = 321
        Label23.Text = "اسم المنتج :"
        ' 
        ' txtProductCode
        ' 
        txtProductCode.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtProductCode.Location = New Point(261, 21)
        txtProductCode.Margin = New Padding(4, 3, 4, 3)
        txtProductCode.Name = "txtProductCode"
        txtProductCode.ReadOnly = True
        txtProductCode.Size = New Size(75, 20)
        txtProductCode.TabIndex = 0
        ' 
        ' txtDiscountPer
        ' 
        txtDiscountPer.Location = New Point(262, 135)
        txtDiscountPer.Margin = New Padding(4, 3, 4, 3)
        txtDiscountPer.Name = "txtDiscountPer"
        txtDiscountPer.Size = New Size(75, 20)
        txtDiscountPer.TabIndex = 5
        txtDiscountPer.Text = "6"
        txtDiscountPer.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtVATAmount
        ' 
        txtVATAmount.Location = New Point(131, 202)
        txtVATAmount.Margin = New Padding(4, 3, 4, 3)
        txtVATAmount.Name = "txtVATAmount"
        txtVATAmount.ReadOnly = True
        txtVATAmount.Size = New Size(75, 20)
        txtVATAmount.TabIndex = 8
        txtVATAmount.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label58
        ' 
        Label58.AutoSize = True
        Label58.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label58.Location = New Point(234, 204)
        Label58.Margin = New Padding(4, 0, 4, 0)
        Label58.Name = "Label58"
        Label58.Size = New Size(19, 16)
        Label58.TabIndex = 317
        Label58.Text = "%"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(234, 113)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(20, 13)
        Label10.TabIndex = 96
        Label10.Text = "لفة"
        ' 
        ' txtMargin
        ' 
        txtMargin.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtMargin.Location = New Point(14, 208)
        txtMargin.Margin = New Padding(4, 3, 4, 3)
        txtMargin.Name = "txtMargin"
        txtMargin.ReadOnly = True
        txtMargin.Size = New Size(75, 20)
        txtMargin.TabIndex = 4
        txtMargin.TextAlign = HorizontalAlignment.Right
        txtMargin.Visible = False
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label21.Location = New Point(365, 81)
        Label21.Margin = New Padding(4, 0, 4, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(54, 13)
        Label21.TabIndex = 87
        Label21.Text = "سعر البيع:"
        ' 
        ' Label56
        ' 
        Label56.AutoSize = True
        Label56.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label56.Location = New Point(234, 171)
        Label56.Margin = New Padding(4, 0, 4, 0)
        Label56.Name = "Label56"
        Label56.Size = New Size(19, 16)
        Label56.TabIndex = 316
        Label56.Text = "%"
        ' 
        ' txtCostPrice
        ' 
        txtCostPrice.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtCostPrice.Location = New Point(14, 173)
        txtCostPrice.Margin = New Padding(4, 3, 4, 3)
        txtCostPrice.Name = "txtCostPrice"
        txtCostPrice.ReadOnly = True
        txtCostPrice.Size = New Size(75, 20)
        txtCostPrice.TabIndex = 2
        txtCostPrice.TextAlign = HorizontalAlignment.Right
        txtCostPrice.Visible = False
        ' 
        ' txtDiscountAmount
        ' 
        txtDiscountAmount.Location = New Point(131, 173)
        txtDiscountAmount.Margin = New Padding(4, 3, 4, 3)
        txtDiscountAmount.Name = "txtDiscountAmount"
        txtDiscountAmount.ReadOnly = True
        txtDiscountAmount.Size = New Size(75, 20)
        txtDiscountAmount.TabIndex = 6
        txtDiscountAmount.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(262, 165)
        txtAmount.Margin = New Padding(4, 3, 4, 3)
        txtAmount.Name = "txtAmount"
        txtAmount.ReadOnly = True
        txtAmount.Size = New Size(75, 20)
        txtAmount.TabIndex = 4
        txtAmount.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtVAT
        ' 
        txtVAT.Location = New Point(261, 198)
        txtVAT.Margin = New Padding(4, 3, 4, 3)
        txtVAT.Name = "txtVAT"
        txtVAT.ReadOnly = True
        txtVAT.Size = New Size(75, 20)
        txtVAT.TabIndex = 7
        txtVAT.Text = "0"
        txtVAT.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(365, 23)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(59, 13)
        Label11.TabIndex = 95
        Label11.Text = "رقم المنتج :"
        ' 
        ' txtSellingPrice
        ' 
        txtSellingPrice.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtSellingPrice.Location = New Point(261, 77)
        txtSellingPrice.Margin = New Padding(4, 3, 4, 3)
        txtSellingPrice.Name = "txtSellingPrice"
        txtSellingPrice.Size = New Size(75, 20)
        txtSellingPrice.TabIndex = 2
        txtSellingPrice.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(btnPrint)
        Panel3.Controls.Add(btnGetData)
        Panel3.Controls.Add(btnDelete)
        Panel3.Controls.Add(btnClose)
        Panel3.Controls.Add(btnUpdate)
        Panel3.Controls.Add(btnSave)
        Panel3.Controls.Add(btnNew)
        Panel3.Location = New Point(15, 651)
        Panel3.Margin = New Padding(4, 3, 4, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(918, 52)
        Panel3.TabIndex = 96
        ' 
        ' btnPrint
        ' 
        btnPrint.Cursor = Cursors.Hand
        btnPrint.Enabled = False
        btnPrint.FlatStyle = FlatStyle.Popup
        btnPrint.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnPrint.Location = New Point(105, 5)
        btnPrint.Margin = New Padding(4, 3, 4, 3)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(74, 32)
        btnPrint.TabIndex = 6
        btnPrint.Text = "&طباعة"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' btnGetData
        ' 
        btnGetData.Cursor = Cursors.Hand
        btnGetData.FlatStyle = FlatStyle.Popup
        btnGetData.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnGetData.Location = New Point(206, 5)
        btnGetData.Margin = New Padding(4, 3, 4, 3)
        btnGetData.Name = "btnGetData"
        btnGetData.Size = New Size(74, 32)
        btnGetData.TabIndex = 5
        btnGetData.Text = "&بيانات"
        btnGetData.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Cursor = Cursors.Hand
        btnDelete.FlatStyle = FlatStyle.Popup
        btnDelete.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnDelete.Location = New Point(507, 5)
        btnDelete.Margin = New Padding(4, 3, 4, 3)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(74, 32)
        btnDelete.TabIndex = 3
        btnDelete.Text = "&حذف"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Cursor = Cursors.Hand
        btnClose.FlatStyle = FlatStyle.Popup
        btnClose.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnClose.Location = New Point(4, 5)
        btnClose.Margin = New Padding(4, 3, 4, 3)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(74, 32)
        btnClose.TabIndex = 4
        btnClose.Text = "&خروج"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.FlatStyle = FlatStyle.Popup
        btnUpdate.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnUpdate.Location = New Point(610, 5)
        btnUpdate.Margin = New Padding(4, 3, 4, 3)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(74, 32)
        btnUpdate.TabIndex = 2
        btnUpdate.Text = "&تحديث"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Cursor = Cursors.Hand
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnSave.Location = New Point(712, 5)
        btnSave.Margin = New Padding(4, 3, 4, 3)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(74, 32)
        btnSave.TabIndex = 1
        btnSave.Text = "&حفظ"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnNew
        ' 
        btnNew.Cursor = Cursors.Hand
        btnNew.FlatStyle = FlatStyle.Popup
        btnNew.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnNew.Location = New Point(814, 3)
        btnNew.Margin = New Padding(4, 3, 4, 3)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(74, 32)
        btnNew.TabIndex = 0
        btnNew.Text = "&جديد"
        btnNew.UseVisualStyleBackColor = True
        ' 
        ' frmBilling
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(955, 703)
        Controls.Add(txtGrandTotal)
        Controls.Add(Label31)
        Controls.Add(txtPaymentDue)
        Controls.Add(txtTotalPayment)
        Controls.Add(Label34)
        Controls.Add(Label35)
        Controls.Add(DataGridView2)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox5)
        Controls.Add(Panel3)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox4)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(4, 3, 4, 3)
        Name = "frmBilling"
        Text = "frmBilling"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dtpInvoiceDate As DateTimePicker
    Friend WithEvents txtInvoiceNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents txtGrandTotal As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txtPaymentDue As TextBox
    Friend WithEvents txtTotalPayment As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnListReset1 As Button
    Friend WithEvents btnListUpdate1 As Button
    Friend WithEvents dtpPaymentDate As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents cmbPaymentMode As ComboBox
    Friend WithEvents btnRemove1 As Button
    Friend WithEvents btnAdd1 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSelect As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnListReset As Button
    Friend WithEvents btnListUpdate As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnSelectionInv As Button
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label23 As Label
    Friend WithEvents txtProductCode As TextBox
    Friend WithEvents txtDiscountPer As TextBox
    Friend WithEvents txtVATAmount As TextBox
    Friend WithEvents Label58 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtMargin As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents txtCostPrice As TextBox
    Friend WithEvents txtDiscountAmount As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtVAT As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtSellingPrice As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnGetData As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label6 As Label
End Class
