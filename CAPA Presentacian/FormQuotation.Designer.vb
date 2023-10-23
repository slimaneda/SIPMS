<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormQuotation
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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label5 = New Label()
        Label51 = New Label()
        Label49 = New Label()
        Label6 = New Label()
        Label25 = New Label()
        Panel1 = New Panel()
        GroupBox3 = New GroupBox()
        txtContactNo = New TextBox()
        Label9 = New Label()
        Label2 = New Label()
        btnSelect = New Button()
        Label3 = New Label()
        txtCustomerID = New TextBox()
        txtCustomerName = New TextBox()
        Label8 = New Label()
        txtRemarks = New TextBox()
        Panel4 = New Panel()
        txtGrandTotal = New TextBox()
        Label31 = New Label()
        DataGridView1 = New DataGridView()
        Column12 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        GroupBox5 = New GroupBox()
        txtMargin = New TextBox()
        txtCostPrice = New TextBox()
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
        Label56 = New Label()
        txtSellingPrice = New TextBox()
        txtDiscountAmount = New TextBox()
        txtAmount = New TextBox()
        txtVAT = New TextBox()
        Label11 = New Label()
        Label22 = New Label()
        GroupBox4 = New GroupBox()
        dtpQuotationDate = New DateTimePicker()
        txtQuotationNo = New TextBox()
        Label4 = New Label()
        Panel3 = New Panel()
        btnGetData = New Button()
        btnDelete = New Button()
        btnClose = New Button()
        btnUpdate = New Button()
        btnSave = New Button()
        btnNew = New Button()
        Panel2 = New Panel()
        Label1 = New Label()
        Timer1 = New Timer(components)
        ToolTip1 = New ToolTip(components)
        Panel1.SuspendLayout()
        GroupBox3.SuspendLayout()
        Panel4.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox5.SuspendLayout()
        GroupBox4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(30, 30)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 15)
        Label5.TabIndex = 268
        Label5.Text = "Quotation No. :"
        ' 
        ' Label51
        ' 
        Label51.AutoSize = True
        Label51.ForeColor = Color.Black
        Label51.Location = New Point(24, 178)
        Label51.Margin = New Padding(2, 0, 2, 0)
        Label51.Name = "Label51"
        Label51.Size = New Size(55, 13)
        Label51.TabIndex = 319
        Label51.Text = "Discount :"
        ' 
        ' Label49
        ' 
        Label49.AutoSize = True
        Label49.ForeColor = Color.Black
        Label49.Location = New Point(26, 148)
        Label49.Margin = New Padding(2, 0, 2, 0)
        Label49.Name = "Label49"
        Label49.Size = New Size(49, 13)
        Label49.TabIndex = 314
        Label49.Text = "Amount :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(24, 209)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(34, 13)
        Label6.TabIndex = 312
        Label6.Text = "VAT :"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.ForeColor = Color.Black
        Label25.Location = New Point(26, 239)
        Label25.Margin = New Padding(2, 0, 2, 0)
        Label25.Name = "Label25"
        Label25.Size = New Size(76, 13)
        Label25.TabIndex = 326
        Label25.Text = "Total Amount :"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(GroupBox3)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(txtRemarks)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(GroupBox5)
        Panel1.Controls.Add(GroupBox4)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(8, 8)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1019, 643)
        Panel1.TabIndex = 2
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
        GroupBox3.Location = New Point(4, 224)
        GroupBox3.Margin = New Padding(4, 3, 4, 3)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(4, 3, 4, 3)
        GroupBox3.Size = New Size(359, 139)
        GroupBox3.TabIndex = 1
        GroupBox3.TabStop = False
        GroupBox3.Text = "Customer Details"
        ' 
        ' txtContactNo
        ' 
        txtContactNo.Location = New Point(139, 85)
        txtContactNo.Margin = New Padding(4, 3, 4, 3)
        txtContactNo.Name = "txtContactNo"
        txtContactNo.Size = New Size(166, 23)
        txtContactNo.TabIndex = 2
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(30, 83)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(77, 15)
        Label9.TabIndex = 8
        Label9.Text = "Contact No. :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 55)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 15)
        Label2.TabIndex = 7
        Label2.Text = "Customer Name :"
        ' 
        ' btnSelect
        ' 
        btnSelect.Location = New Point(227, 24)
        btnSelect.Margin = New Padding(4, 3, 4, 3)
        btnSelect.Name = "btnSelect"
        btnSelect.Size = New Size(34, 24)
        btnSelect.TabIndex = 3
        btnSelect.Text = "..."
        btnSelect.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(30, 24)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 15)
        Label3.TabIndex = 0
        Label3.Text = "Customer ID :"
        ' 
        ' txtCustomerID
        ' 
        txtCustomerID.BackColor = SystemColors.Control
        txtCustomerID.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtCustomerID.Location = New Point(139, 24)
        txtCustomerID.Margin = New Padding(4, 3, 4, 3)
        txtCustomerID.Name = "txtCustomerID"
        txtCustomerID.ReadOnly = True
        txtCustomerID.Size = New Size(81, 21)
        txtCustomerID.TabIndex = 0
        ' 
        ' txtCustomerName
        ' 
        txtCustomerName.Location = New Point(139, 55)
        txtCustomerName.Margin = New Padding(4, 3, 4, 3)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.Size = New Size(206, 23)
        txtCustomerName.TabIndex = 1
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(10, 372)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(55, 13)
        Label8.TabIndex = 85
        Label8.Text = "Remarks :"
        ' 
        ' txtRemarks
        ' 
        txtRemarks.BackColor = Color.White
        txtRemarks.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtRemarks.Location = New Point(7, 375)
        txtRemarks.Margin = New Padding(4, 3, 4, 3)
        txtRemarks.Multiline = True
        txtRemarks.Name = "txtRemarks"
        txtRemarks.ScrollBars = ScrollBars.Both
        txtRemarks.Size = New Size(359, 50)
        txtRemarks.TabIndex = 6
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Transparent
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(txtGrandTotal)
        Panel4.Controls.Add(Label31)
        Panel4.Location = New Point(374, 372)
        Panel4.Margin = New Padding(4, 3, 4, 3)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(205, 56)
        Panel4.TabIndex = 5
        ' 
        ' txtGrandTotal
        ' 
        txtGrandTotal.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtGrandTotal.Location = New Point(99, 20)
        txtGrandTotal.Margin = New Padding(4, 3, 4, 3)
        txtGrandTotal.Name = "txtGrandTotal"
        txtGrandTotal.ReadOnly = True
        txtGrandTotal.Size = New Size(93, 20)
        txtGrandTotal.TabIndex = 0
        txtGrandTotal.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label31.Location = New Point(12, 20)
        Label31.Margin = New Padding(4, 0, 4, 0)
        Label31.Name = "Label31"
        Label31.Size = New Size(69, 13)
        Label31.TabIndex = 84
        Label31.Text = "Grand Total :"
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
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.ColumnHeadersHeight = 24
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column12, Column1, Column2, Column3, Column4, Column5, Column6, Column9, Column10, Column11, Column7})
        DataGridView1.Cursor = Cursors.Hand
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = SystemColors.Window
        DataGridViewCellStyle11.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle11.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle11
        DataGridView1.Dock = DockStyle.Bottom
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.GridColor = Color.White
        DataGridView1.Location = New Point(0, 518)
        DataGridView1.Margin = New Padding(4, 3, 4, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = Color.CadetBlue
        DataGridViewCellStyle12.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle12.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = Color.DarkSlateGray
        DataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        DataGridView1.RowHeadersWidth = 25
        DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle13.BackColor = Color.White
        DataGridViewCellStyle13.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle13.SelectionBackColor = Color.DarkSlateGray
        DataGridViewCellStyle13.SelectionForeColor = Color.White
        DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle13
        DataGridView1.RowTemplate.Height = 18
        DataGridView1.RowTemplate.Resizable = DataGridViewTriState.False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1017, 123)
        DataGridView1.TabIndex = 10
        ' 
        ' Column12
        ' 
        Column12.HeaderText = "Product Code"
        Column12.Name = "Column12"
        Column12.ReadOnly = True
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Product Name"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopRight
        Column2.DefaultCellStyle = DataGridViewCellStyle3
        Column2.HeaderText = "Price"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopRight
        Column3.DefaultCellStyle = DataGridViewCellStyle4
        Column3.HeaderText = "Quantity"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.TopRight
        Column4.DefaultCellStyle = DataGridViewCellStyle5
        Column4.HeaderText = "Amount"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.TopRight
        Column5.DefaultCellStyle = DataGridViewCellStyle6
        Column5.HeaderText = "Discount %"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Column6
        ' 
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.TopRight
        Column6.DefaultCellStyle = DataGridViewCellStyle7
        Column6.HeaderText = "Discount"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        ' 
        ' Column9
        ' 
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.TopRight
        Column9.DefaultCellStyle = DataGridViewCellStyle8
        Column9.HeaderText = "VAT %"
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        ' 
        ' Column10
        ' 
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.TopRight
        Column10.DefaultCellStyle = DataGridViewCellStyle9
        Column10.HeaderText = "VAT Amt"
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        ' 
        ' Column11
        ' 
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.TopRight
        Column11.DefaultCellStyle = DataGridViewCellStyle10
        Column11.HeaderText = "Total Amt."
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
        ' GroupBox5
        ' 
        GroupBox5.BackColor = Color.Transparent
        GroupBox5.Controls.Add(txtMargin)
        GroupBox5.Controls.Add(txtCostPrice)
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
        GroupBox5.Controls.Add(Label56)
        GroupBox5.Controls.Add(txtSellingPrice)
        GroupBox5.Controls.Add(txtDiscountAmount)
        GroupBox5.Controls.Add(txtAmount)
        GroupBox5.Controls.Add(Label49)
        GroupBox5.Controls.Add(txtVAT)
        GroupBox5.Controls.Add(Label6)
        GroupBox5.Controls.Add(Label11)
        GroupBox5.Controls.Add(Label22)
        GroupBox5.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox5.Location = New Point(374, 87)
        GroupBox5.Margin = New Padding(4, 3, 4, 3)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Padding = New Padding(4, 3, 4, 3)
        GroupBox5.Size = New Size(536, 279)
        GroupBox5.TabIndex = 2
        GroupBox5.TabStop = False
        GroupBox5.Text = "Product Details"
        ' 
        ' txtMargin
        ' 
        txtMargin.Location = New Point(383, 210)
        txtMargin.Margin = New Padding(4, 3, 4, 3)
        txtMargin.Name = "txtMargin"
        txtMargin.ReadOnly = True
        txtMargin.Size = New Size(97, 20)
        txtMargin.TabIndex = 328
        txtMargin.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtCostPrice
        ' 
        txtCostPrice.Location = New Point(383, 178)
        txtCostPrice.Margin = New Padding(4, 3, 4, 3)
        txtCostPrice.Name = "txtCostPrice"
        txtCostPrice.ReadOnly = True
        txtCostPrice.Size = New Size(97, 20)
        txtCostPrice.TabIndex = 327
        txtCostPrice.TextAlign = HorizontalAlignment.Right
        ' 
        ' btnListReset
        ' 
        btnListReset.Cursor = Cursors.Hand
        btnListReset.FlatStyle = FlatStyle.Popup
        btnListReset.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnListReset.Location = New Point(397, 27)
        btnListReset.Margin = New Padding(4, 3, 4, 3)
        btnListReset.Name = "btnListReset"
        btnListReset.Size = New Size(105, 22)
        btnListReset.TabIndex = 11
        btnListReset.Text = "Reset"
        btnListReset.UseVisualStyleBackColor = True
        ' 
        ' btnListUpdate
        ' 
        btnListUpdate.Enabled = False
        btnListUpdate.FlatStyle = FlatStyle.Popup
        btnListUpdate.Location = New Point(397, 107)
        btnListUpdate.Margin = New Padding(4, 3, 4, 3)
        btnListUpdate.Name = "btnListUpdate"
        btnListUpdate.Size = New Size(105, 24)
        btnListUpdate.TabIndex = 14
        btnListUpdate.Text = "Update"
        btnListUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnRemove
        ' 
        btnRemove.Cursor = Cursors.Hand
        btnRemove.Enabled = False
        btnRemove.FlatStyle = FlatStyle.Popup
        btnRemove.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnRemove.Location = New Point(397, 81)
        btnRemove.Margin = New Padding(4, 3, 4, 3)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(105, 22)
        btnRemove.TabIndex = 13
        btnRemove.Text = "Remove"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' btnSelectionInv
        ' 
        btnSelectionInv.FlatStyle = FlatStyle.Popup
        btnSelectionInv.Location = New Point(244, 30)
        btnSelectionInv.Margin = New Padding(4, 3, 4, 3)
        btnSelectionInv.Name = "btnSelectionInv"
        btnSelectionInv.Size = New Size(34, 22)
        btnSelectionInv.TabIndex = 10
        btnSelectionInv.Text = "..."
        btnSelectionInv.UseVisualStyleBackColor = True
        ' 
        ' txtTotalAmount
        ' 
        txtTotalAmount.Location = New Point(135, 239)
        txtTotalAmount.Margin = New Padding(4, 3, 4, 3)
        txtTotalAmount.Name = "txtTotalAmount"
        txtTotalAmount.ReadOnly = True
        txtTotalAmount.Size = New Size(97, 20)
        txtTotalAmount.TabIndex = 9
        txtTotalAmount.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label24.Location = New Point(26, 119)
        Label24.Margin = New Padding(4, 0, 4, 0)
        Label24.Name = "Label24"
        Label24.Size = New Size(52, 13)
        Label24.TabIndex = 324
        Label24.Text = "Quantity :"
        ' 
        ' txtQty
        ' 
        txtQty.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtQty.Location = New Point(135, 119)
        txtQty.Margin = New Padding(4, 3, 4, 3)
        txtQty.Name = "txtQty"
        txtQty.Size = New Size(97, 20)
        txtQty.TabIndex = 3
        txtQty.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtProductName
        ' 
        txtProductName.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtProductName.Location = New Point(135, 59)
        txtProductName.Margin = New Padding(4, 3, 4, 3)
        txtProductName.Name = "txtProductName"
        txtProductName.ReadOnly = True
        txtProductName.Size = New Size(240, 20)
        txtProductName.TabIndex = 1
        ' 
        ' btnAdd
        ' 
        btnAdd.Cursor = Cursors.Hand
        btnAdd.FlatStyle = FlatStyle.Popup
        btnAdd.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnAdd.Location = New Point(397, 53)
        btnAdd.Margin = New Padding(4, 3, 4, 3)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(105, 22)
        btnAdd.TabIndex = 12
        btnAdd.Text = "&Add To Cart"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label23.Location = New Point(26, 57)
        Label23.Margin = New Padding(4, 0, 4, 0)
        Label23.Name = "Label23"
        Label23.Size = New Size(81, 13)
        Label23.TabIndex = 321
        Label23.Text = "Product Name :"
        ' 
        ' txtProductCode
        ' 
        txtProductCode.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtProductCode.Location = New Point(135, 30)
        txtProductCode.Margin = New Padding(4, 3, 4, 3)
        txtProductCode.Name = "txtProductCode"
        txtProductCode.ReadOnly = True
        txtProductCode.Size = New Size(97, 20)
        txtProductCode.TabIndex = 0
        ' 
        ' txtDiscountPer
        ' 
        txtDiscountPer.Location = New Point(135, 178)
        txtDiscountPer.Margin = New Padding(4, 3, 4, 3)
        txtDiscountPer.Name = "txtDiscountPer"
        txtDiscountPer.ReadOnly = True
        txtDiscountPer.Size = New Size(97, 20)
        txtDiscountPer.TabIndex = 5
        txtDiscountPer.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtVATAmount
        ' 
        txtVATAmount.Location = New Point(278, 210)
        txtVATAmount.Margin = New Padding(4, 3, 4, 3)
        txtVATAmount.Name = "txtVATAmount"
        txtVATAmount.ReadOnly = True
        txtVATAmount.Size = New Size(97, 20)
        txtVATAmount.TabIndex = 8
        txtVATAmount.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label58
        ' 
        Label58.AutoSize = True
        Label58.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label58.Location = New Point(247, 210)
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
        Label10.Location = New Point(240, 122)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(26, 13)
        Label10.TabIndex = 96
        Label10.Text = "Unit"
        ' 
        ' Label56
        ' 
        Label56.AutoSize = True
        Label56.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label56.Location = New Point(247, 178)
        Label56.Margin = New Padding(4, 0, 4, 0)
        Label56.Name = "Label56"
        Label56.Size = New Size(19, 16)
        Label56.TabIndex = 316
        Label56.Text = "%"
        ' 
        ' txtSellingPrice
        ' 
        txtSellingPrice.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtSellingPrice.Location = New Point(135, 88)
        txtSellingPrice.Margin = New Padding(4, 3, 4, 3)
        txtSellingPrice.Name = "txtSellingPrice"
        txtSellingPrice.ReadOnly = True
        txtSellingPrice.Size = New Size(97, 20)
        txtSellingPrice.TabIndex = 2
        txtSellingPrice.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtDiscountAmount
        ' 
        txtDiscountAmount.Location = New Point(278, 178)
        txtDiscountAmount.Margin = New Padding(4, 3, 4, 3)
        txtDiscountAmount.Name = "txtDiscountAmount"
        txtDiscountAmount.ReadOnly = True
        txtDiscountAmount.Size = New Size(97, 20)
        txtDiscountAmount.TabIndex = 6
        txtDiscountAmount.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(135, 148)
        txtAmount.Margin = New Padding(4, 3, 4, 3)
        txtAmount.Name = "txtAmount"
        txtAmount.ReadOnly = True
        txtAmount.Size = New Size(97, 20)
        txtAmount.TabIndex = 4
        txtAmount.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtVAT
        ' 
        txtVAT.Location = New Point(135, 209)
        txtVAT.Margin = New Padding(4, 3, 4, 3)
        txtVAT.Name = "txtVAT"
        txtVAT.ReadOnly = True
        txtVAT.Size = New Size(97, 20)
        txtVAT.TabIndex = 7
        txtVAT.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(26, 30)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(78, 13)
        Label11.TabIndex = 95
        Label11.Text = "Product Code :"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label22.Location = New Point(26, 87)
        Label22.Margin = New Padding(4, 0, 4, 0)
        Label22.Name = "Label22"
        Label22.Size = New Size(37, 13)
        Label22.TabIndex = 76
        Label22.Text = "Price :"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(dtpQuotationDate)
        GroupBox4.Controls.Add(txtQuotationNo)
        GroupBox4.Controls.Add(Label4)
        GroupBox4.Controls.Add(Label5)
        GroupBox4.Location = New Point(10, 85)
        GroupBox4.Margin = New Padding(4, 3, 4, 3)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(4, 3, 4, 3)
        GroupBox4.Size = New Size(356, 130)
        GroupBox4.TabIndex = 0
        GroupBox4.TabStop = False
        GroupBox4.Text = "Quotation Info"
        ' 
        ' dtpQuotationDate
        ' 
        dtpQuotationDate.CustomFormat = "dd/MM/yyyy"
        dtpQuotationDate.Format = DateTimePickerFormat.Custom
        dtpQuotationDate.Location = New Point(139, 52)
        dtpQuotationDate.Margin = New Padding(2)
        dtpQuotationDate.Name = "dtpQuotationDate"
        dtpQuotationDate.Size = New Size(129, 23)
        dtpQuotationDate.TabIndex = 1
        ' 
        ' txtQuotationNo
        ' 
        txtQuotationNo.Location = New Point(139, 22)
        txtQuotationNo.Margin = New Padding(4, 3, 4, 3)
        txtQuotationNo.Name = "txtQuotationNo"
        txtQuotationNo.ReadOnly = True
        txtQuotationNo.Size = New Size(129, 23)
        txtQuotationNo.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(30, 59)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 15)
        Label4.TabIndex = 335
        Label4.Text = "Quotation Date :"
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(btnGetData)
        Panel3.Controls.Add(btnDelete)
        Panel3.Controls.Add(btnClose)
        Panel3.Controls.Add(btnUpdate)
        Panel3.Controls.Add(btnSave)
        Panel3.Controls.Add(btnNew)
        Panel3.Location = New Point(231, 457)
        Panel3.Margin = New Padding(4, 3, 4, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(645, 55)
        Panel3.TabIndex = 3
        ' 
        ' btnGetData
        ' 
        btnGetData.Cursor = Cursors.Hand
        btnGetData.FlatStyle = FlatStyle.Popup
        btnGetData.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnGetData.Location = New Point(335, 10)
        btnGetData.Margin = New Padding(4, 3, 4, 3)
        btnGetData.Name = "btnGetData"
        btnGetData.Size = New Size(96, 32)
        btnGetData.TabIndex = 5
        btnGetData.Text = "&Get Data"
        btnGetData.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Cursor = Cursors.Hand
        btnDelete.FlatStyle = FlatStyle.Popup
        btnDelete.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnDelete.Location = New Point(439, 10)
        btnDelete.Margin = New Padding(4, 3, 4, 3)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(96, 32)
        btnDelete.TabIndex = 3
        btnDelete.Text = "&Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Cursor = Cursors.Hand
        btnClose.FlatStyle = FlatStyle.Popup
        btnClose.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnClose.Location = New Point(543, 10)
        btnClose.Margin = New Padding(4, 3, 4, 3)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(96, 32)
        btnClose.TabIndex = 4
        btnClose.Text = "&Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.FlatStyle = FlatStyle.Popup
        btnUpdate.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnUpdate.Location = New Point(228, 10)
        btnUpdate.Margin = New Padding(4, 3, 4, 3)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(96, 32)
        btnUpdate.TabIndex = 2
        btnUpdate.Text = "&Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Cursor = Cursors.Hand
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnSave.Location = New Point(120, 10)
        btnSave.Margin = New Padding(4, 3, 4, 3)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(96, 32)
        btnSave.TabIndex = 1
        btnSave.Text = "&Save + Print"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnNew
        ' 
        btnNew.Cursor = Cursors.Hand
        btnNew.FlatStyle = FlatStyle.Popup
        btnNew.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnNew.Location = New Point(10, 9)
        btnNew.Margin = New Padding(4, 3, 4, 3)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(96, 32)
        btnNew.TabIndex = 0
        btnNew.Text = "&New"
        btnNew.UseVisualStyleBackColor = True
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
        Panel2.Size = New Size(1017, 72)
        Panel2.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(414, 25)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 24)
        Label1.TabIndex = 0
        Label1.Text = "Quotation"
        ' 
        ' FormQuotation
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateGray
        ClientSize = New Size(1027, 650)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormQuotation"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGetData As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dtpQuotationDate As DateTimePicker
    Friend WithEvents txtQuotationNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox5 As GroupBox
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
    Friend WithEvents Label56 As Label
    Friend WithEvents txtSellingPrice As TextBox
    Friend WithEvents txtDiscountAmount As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtVAT As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtGrandTotal As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnListUpdate As Button
    Friend WithEvents btnListReset As Button
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSelect As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtCostPrice As TextBox
    Friend WithEvents txtMargin As TextBox
End Class
