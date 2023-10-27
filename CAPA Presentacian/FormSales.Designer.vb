<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSales
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
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label5 = New Label()
        Label49 = New Label()
        Label6 = New Label()
        Label25 = New Label()
        Panel1 = New Panel()
        TextBox2 = New TextBox()
        Panel5 = New Panel()
        Label12 = New Label()
        Label34 = New Label()
        Label35 = New Label()
        txtGrandtotal = New TextBox()
        txttotalunpaid = New TextBox()
        txtTotalPaid = New TextBox()
        GroupBox3 = New GroupBox()
        txtContactNo = New TextBox()
        Label9 = New Label()
        Label2 = New Label()
        btnSelect = New Button()
        Label3 = New Label()
        txtCustomerID = New TextBox()
        txtCustomerName = New TextBox()
        txtRemarks = New TextBox()
        DGV = New DataGridView()
        Column8 = New DataGridViewTextBoxColumn()
        Column13 = New DataGridViewTextBoxColumn()
        Column14 = New DataGridViewTextBoxColumn()
        Column15 = New DataGridViewTextBoxColumn()
        Column16 = New DataGridViewTextBoxColumn()
        Column12 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Label8 = New Label()
        GroupBox5 = New GroupBox()
        TextBox1 = New TextBox()
        Label7 = New Label()
        txtAmount = New TextBox()
        txtVAT = New TextBox()
        txtSellingPrice = New TextBox()
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
        txtVATAmount = New TextBox()
        Label58 = New Label()
        Label11 = New Label()
        Label22 = New Label()
        GroupBox4 = New GroupBox()
        dtpsales = New DateTimePicker()
        txtCodesales = New TextBox()
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
        Panel5.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(DGV, ComponentModel.ISupportInitialize).BeginInit()
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
        Label5.Size = New Size(70, 15)
        Label5.TabIndex = 268
        Label5.Text = "Sales Code :"
        ' 
        ' Label49
        ' 
        Label49.AutoSize = True
        Label49.ForeColor = Color.Black
        Label49.Location = New Point(28, 123)
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
        Label6.Location = New Point(28, 144)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(30, 13)
        Label6.TabIndex = 312
        Label6.Text = "IVA :"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.ForeColor = Color.Black
        Label25.Location = New Point(29, 182)
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
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(GroupBox3)
        Panel1.Controls.Add(txtRemarks)
        Panel1.Controls.Add(DGV)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(GroupBox5)
        Panel1.Controls.Add(GroupBox4)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(11, 8)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1019, 643)
        Panel1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(292, 113)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 20)
        TextBox2.TabIndex = 87
        TextBox2.Visible = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Transparent
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(Label12)
        Panel5.Controls.Add(Label34)
        Panel5.Controls.Add(Label35)
        Panel5.Controls.Add(txtGrandtotal)
        Panel5.Controls.Add(txttotalunpaid)
        Panel5.Controls.Add(txtTotalPaid)
        Panel5.Location = New Point(374, 309)
        Panel5.Margin = New Padding(4, 5, 4, 5)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(578, 87)
        Panel5.TabIndex = 86
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(39, 21)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.RightToLeft = RightToLeft.No
        Label12.Size = New Size(69, 13)
        Label12.TabIndex = 87
        Label12.Text = "Grand Total :"
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label34.Location = New Point(247, 35)
        Label34.Margin = New Padding(4, 0, 4, 0)
        Label34.Name = "Label34"
        Label34.RightToLeft = RightToLeft.No
        Label34.Size = New Size(74, 13)
        Label34.TabIndex = 86
        Label34.Text = "Total Unpaid :"
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label35.Location = New Point(41, 53)
        Label35.Margin = New Padding(4, 0, 4, 0)
        Label35.Name = "Label35"
        Label35.RightToLeft = RightToLeft.No
        Label35.Size = New Size(61, 13)
        Label35.TabIndex = 85
        Label35.Text = "Total Paid :"
        ' 
        ' txtGrandtotal
        ' 
        txtGrandtotal.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtGrandtotal.Location = New Point(134, 18)
        txtGrandtotal.Margin = New Padding(4, 5, 4, 5)
        txtGrandtotal.Name = "txtGrandtotal"
        txtGrandtotal.ReadOnly = True
        txtGrandtotal.Size = New Size(72, 20)
        txtGrandtotal.TabIndex = 0
        txtGrandtotal.TextAlign = HorizontalAlignment.Right
        ' 
        ' txttotalunpaid
        ' 
        txttotalunpaid.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txttotalunpaid.Location = New Point(331, 31)
        txttotalunpaid.Margin = New Padding(4, 5, 4, 5)
        txttotalunpaid.Name = "txttotalunpaid"
        txttotalunpaid.ReadOnly = True
        txttotalunpaid.Size = New Size(72, 20)
        txttotalunpaid.TabIndex = 2
        txttotalunpaid.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtTotalPaid
        ' 
        txtTotalPaid.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtTotalPaid.Location = New Point(136, 50)
        txtTotalPaid.Margin = New Padding(4, 5, 4, 5)
        txtTotalPaid.Name = "txtTotalPaid"
        txtTotalPaid.Size = New Size(72, 20)
        txtTotalPaid.TabIndex = 1
        txtTotalPaid.Text = "0"
        txtTotalPaid.TextAlign = HorizontalAlignment.Right
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
        GroupBox3.Location = New Point(4, 178)
        GroupBox3.Margin = New Padding(4, 3, 4, 3)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(4, 3, 4, 3)
        GroupBox3.Size = New Size(359, 125)
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
        ' txtRemarks
        ' 
        txtRemarks.BackColor = Color.White
        txtRemarks.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtRemarks.Location = New Point(150, 309)
        txtRemarks.Margin = New Padding(4, 3, 4, 3)
        txtRemarks.Multiline = True
        txtRemarks.Name = "txtRemarks"
        txtRemarks.ScrollBars = ScrollBars.Both
        txtRemarks.Size = New Size(211, 93)
        txtRemarks.TabIndex = 6
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
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DGV.ColumnHeadersHeight = 40
        DGV.Columns.AddRange(New DataGridViewColumn() {Column8, Column13, Column14, Column15, Column16, Column12, Column1, Column2, Column3, Column4, Column10, Column7, Column6, Column9, Column5, Column11})
        DGV.Cursor = Cursors.Hand
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = SystemColors.Window
        DataGridViewCellStyle7.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.False
        DGV.DefaultCellStyle = DataGridViewCellStyle7
        DGV.Dock = DockStyle.Bottom
        DGV.EnableHeadersVisualStyles = False
        DGV.GridColor = Color.White
        DGV.Location = New Point(0, 498)
        DGV.Margin = New Padding(4, 3, 4, 3)
        DGV.Name = "DGV"
        DGV.ReadOnly = True
        DGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.CadetBlue
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle8.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = Color.DarkSlateGray
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        DGV.RowHeadersWidth = 25
        DGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle9.BackColor = Color.White
        DataGridViewCellStyle9.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle9.SelectionBackColor = Color.DarkSlateGray
        DataGridViewCellStyle9.SelectionForeColor = Color.White
        DGV.RowsDefaultCellStyle = DataGridViewCellStyle9
        DGV.RowTemplate.Height = 18
        DGV.RowTemplate.Resizable = DataGridViewTriState.False
        DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV.Size = New Size(1017, 143)
        DGV.TabIndex = 10
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Sales Code"
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        ' 
        ' Column13
        ' 
        Column13.HeaderText = "Sales Date"
        Column13.Name = "Column13"
        Column13.ReadOnly = True
        ' 
        ' Column14
        ' 
        Column14.HeaderText = "Customer ID"
        Column14.Name = "Column14"
        Column14.ReadOnly = True
        ' 
        ' Column15
        ' 
        Column15.HeaderText = "Customer Names"
        Column15.Name = "Column15"
        Column15.ReadOnly = True
        ' 
        ' Column16
        ' 
        Column16.HeaderText = "Contact"
        Column16.Name = "Column16"
        Column16.ReadOnly = True
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
        ' Column10
        ' 
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.TopRight
        Column10.DefaultCellStyle = DataGridViewCellStyle6
        Column10.HeaderText = "VAT Amt"
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Grand Total"
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Visible = False
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Total Paid"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "Total Unpaid"
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Remarks"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Column11
        ' 
        Column11.HeaderText = "textbox1"
        Column11.Name = "Column11"
        Column11.ReadOnly = True
        Column11.Visible = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(44, 349)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(55, 13)
        Label8.TabIndex = 85
        Label8.Text = "Remarks :"
        ' 
        ' GroupBox5
        ' 
        GroupBox5.BackColor = Color.Transparent
        GroupBox5.Controls.Add(TextBox2)
        GroupBox5.Controls.Add(TextBox1)
        GroupBox5.Controls.Add(Label7)
        GroupBox5.Controls.Add(txtAmount)
        GroupBox5.Controls.Add(txtVAT)
        GroupBox5.Controls.Add(txtSellingPrice)
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
        GroupBox5.Controls.Add(txtVATAmount)
        GroupBox5.Controls.Add(Label58)
        GroupBox5.Controls.Add(Label49)
        GroupBox5.Controls.Add(Label6)
        GroupBox5.Controls.Add(Label11)
        GroupBox5.Controls.Add(Label22)
        GroupBox5.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox5.Location = New Point(374, 87)
        GroupBox5.Margin = New Padding(4, 3, 4, 3)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Padding = New Padding(4, 3, 4, 3)
        GroupBox5.Size = New Size(578, 216)
        GroupBox5.TabIndex = 2
        GroupBox5.TabStop = False
        GroupBox5.Text = "Product Details"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(286, 30)
        TextBox1.Margin = New Padding(4, 3, 4, 3)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(89, 20)
        TextBox1.TabIndex = 339
        TextBox1.Visible = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(242, 148)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 13)
        Label7.TabIndex = 338
        Label7.Text = "Taxe Iva :"
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(135, 119)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(100, 20)
        txtAmount.TabIndex = 330
        ' 
        ' txtVAT
        ' 
        txtVAT.Location = New Point(297, 144)
        txtVAT.Name = "txtVAT"
        txtVAT.Size = New Size(25, 20)
        txtVAT.TabIndex = 337
        txtVAT.Text = "21"
        ' 
        ' txtSellingPrice
        ' 
        txtSellingPrice.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtSellingPrice.Location = New Point(135, 90)
        txtSellingPrice.Margin = New Padding(4, 3, 4, 3)
        txtSellingPrice.Name = "txtSellingPrice"
        txtSellingPrice.Size = New Size(97, 20)
        txtSellingPrice.TabIndex = 329
        txtSellingPrice.TextAlign = HorizontalAlignment.Right
        ' 
        ' btnListReset
        ' 
        btnListReset.Cursor = Cursors.Hand
        btnListReset.FlatStyle = FlatStyle.Popup
        btnListReset.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnListReset.Location = New Point(431, 26)
        btnListReset.Margin = New Padding(4, 3, 4, 3)
        btnListReset.Name = "btnListReset"
        btnListReset.Size = New Size(105, 24)
        btnListReset.TabIndex = 11
        btnListReset.Text = "Clean"
        btnListReset.UseVisualStyleBackColor = True
        ' 
        ' btnListUpdate
        ' 
        btnListUpdate.Enabled = False
        btnListUpdate.FlatStyle = FlatStyle.Popup
        btnListUpdate.Location = New Point(431, 106)
        btnListUpdate.Margin = New Padding(4, 3, 4, 3)
        btnListUpdate.Name = "btnListUpdate"
        btnListUpdate.Size = New Size(105, 26)
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
        btnRemove.Location = New Point(431, 80)
        btnRemove.Margin = New Padding(4, 3, 4, 3)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(105, 24)
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
        txtTotalAmount.Location = New Point(137, 182)
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
        Label24.Location = New Point(237, 93)
        Label24.Margin = New Padding(4, 0, 4, 0)
        Label24.Name = "Label24"
        Label24.Size = New Size(52, 13)
        Label24.TabIndex = 324
        Label24.Text = "Quantity :"
        ' 
        ' txtQty
        ' 
        txtQty.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtQty.Location = New Point(293, 90)
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
        txtProductName.Size = New Size(255, 20)
        txtProductName.TabIndex = 1
        ' 
        ' btnAdd
        ' 
        btnAdd.Cursor = Cursors.Hand
        btnAdd.FlatStyle = FlatStyle.Popup
        btnAdd.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnAdd.Location = New Point(431, 52)
        btnAdd.Margin = New Padding(4, 3, 4, 3)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(105, 24)
        btnAdd.TabIndex = 12
        btnAdd.Text = "&Add "
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
        txtProductCode.Size = New Size(89, 20)
        txtProductCode.TabIndex = 0
        ' 
        ' txtVATAmount
        ' 
        txtVATAmount.Location = New Point(137, 145)
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
        Label58.Location = New Point(329, 146)
        Label58.Margin = New Padding(4, 0, 4, 0)
        Label58.Name = "Label58"
        Label58.Size = New Size(19, 16)
        Label58.TabIndex = 317
        Label58.Text = "%"
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
        GroupBox4.Controls.Add(dtpsales)
        GroupBox4.Controls.Add(txtCodesales)
        GroupBox4.Controls.Add(Label4)
        GroupBox4.Controls.Add(Label5)
        GroupBox4.Location = New Point(10, 85)
        GroupBox4.Margin = New Padding(4, 3, 4, 3)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(4, 3, 4, 3)
        GroupBox4.Size = New Size(356, 93)
        GroupBox4.TabIndex = 0
        GroupBox4.TabStop = False
        GroupBox4.Text = "Quotation Info"
        ' 
        ' dtpsales
        ' 
        dtpsales.CustomFormat = "dd/MM/yyyy"
        dtpsales.Format = DateTimePickerFormat.Custom
        dtpsales.Location = New Point(139, 52)
        dtpsales.Margin = New Padding(2)
        dtpsales.Name = "dtpsales"
        dtpsales.Size = New Size(129, 23)
        dtpsales.TabIndex = 1
        ' 
        ' txtCodesales
        ' 
        txtCodesales.BackColor = SystemColors.ButtonHighlight
        txtCodesales.Enabled = False
        txtCodesales.Location = New Point(139, 22)
        txtCodesales.Margin = New Padding(4, 3, 4, 3)
        txtCodesales.Name = "txtCodesales"
        txtCodesales.Size = New Size(129, 23)
        txtCodesales.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(34, 59)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 15)
        Label4.TabIndex = 335
        Label4.Text = "Sales Date :"
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
        Panel3.Location = New Point(179, 425)
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
        btnSave.Text = "&Save "
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
        Label1.Size = New Size(139, 24)
        Label1.TabIndex = 0
        Label1.Text = "Product Sales"
        ' 
        ' FormSales
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
        Name = "FormSales"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(DGV, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dtpsales As DateTimePicker
    Friend WithEvents txtCodesales As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DGV As DataGridView
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
    Friend WithEvents txtVATAmount As TextBox
    Friend WithEvents Label58 As Label
    Friend WithEvents txtVAT As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnListUpdate As Button
    Friend WithEvents btnListReset As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSelect As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtSellingPrice As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents txtGrandtotal As TextBox
    Friend WithEvents txttotalunpaid As TextBox
    Friend WithEvents txtTotalPaid As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents TextBox2 As TextBox
End Class
