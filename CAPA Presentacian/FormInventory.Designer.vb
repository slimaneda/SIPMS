<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInventory
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
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Panel5 = New Panel()
        btnAdd = New Button()
        btnRemove = New Button()
        Label10 = New Label()
        txtRemarks = New RichTextBox()
        Panel4 = New Panel()
        Label31 = New Label()
        Label34 = New Label()
        Label35 = New Label()
        txtGrandTotal = New TextBox()
        txtPaymentDue = New TextBox()
        txtTotalPayment = New TextBox()
        DGV = New DataGridView()
        PID = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column12 = New DataGridViewTextBoxColumn()
        GroupBox2 = New GroupBox()
        Label9 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        txtTotalAmount = New TextBox()
        txtPricePerQty = New TextBox()
        txtQty = New TextBox()
        btnShowPt = New Button()
        txtNamePt = New TextBox()
        txtCodePt = New TextBox()
        GroupBox1 = New GroupBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label5 = New Label()
        Label11 = New Label()
        btnShowSupp = New Button()
        txtNameSup = New TextBox()
        txtCodeSup = New TextBox()
        txtDate = New DateTimePicker()
        txtCodestock = New TextBox()
        Panel3 = New Panel()
        btnDelete = New Button()
        btnGetData = New Button()
        btnClose = New Button()
        btnUpdate = New Button()
        btnSave = New Button()
        btnNew = New Button()
        Panel2 = New Panel()
        Panel6 = New Panel()
        lbl = New Label()
        Label1 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        ErrorProvider1 = New ErrorProvider(components)
        Panel1.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        CType(DGV, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(txtRemarks)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(DGV)
        Panel1.Controls.Add(GroupBox2)
        Panel1.Controls.Add(GroupBox1)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(-4, 0)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(892, 674)
        Panel1.TabIndex = 2
        ' 
        ' Panel5
        ' 
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(btnAdd)
        Panel5.Controls.Add(btnRemove)
        Panel5.Controls.Add(btnNew)
        Panel5.Location = New Point(313, 343)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(268, 54)
        Panel5.TabIndex = 312
        ' 
        ' btnAdd
        ' 
        btnAdd.FlatStyle = FlatStyle.Popup
        btnAdd.Location = New Point(103, 12)
        btnAdd.Margin = New Padding(4, 5, 4, 5)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(63, 24)
        btnAdd.TabIndex = 6
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnRemove
        ' 
        btnRemove.FlatStyle = FlatStyle.Popup
        btnRemove.Location = New Point(196, 12)
        btnRemove.Margin = New Padding(4, 5, 4, 5)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(63, 24)
        btnRemove.TabIndex = 7
        btnRemove.Text = "Delete"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(659, 243)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.RightToLeft = RightToLeft.No
        Label10.Size = New Size(35, 13)
        Label10.TabIndex = 311
        Label10.Text = "Notes"
        ' 
        ' txtRemarks
        ' 
        txtRemarks.Location = New Point(480, 250)
        txtRemarks.Margin = New Padding(4, 5, 4, 5)
        txtRemarks.Name = "txtRemarks"
        txtRemarks.ScrollBars = RichTextBoxScrollBars.ForcedVertical
        txtRemarks.Size = New Size(374, 85)
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
        Panel4.Location = New Point(4, 248)
        Panel4.Margin = New Padding(4, 5, 4, 5)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(444, 87)
        Panel4.TabIndex = 4
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label31.Location = New Point(5, 21)
        Label31.Margin = New Padding(4, 0, 4, 0)
        Label31.Name = "Label31"
        Label31.RightToLeft = RightToLeft.No
        Label31.Size = New Size(69, 13)
        Label31.TabIndex = 87
        Label31.Text = "Grand Total :"
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label34.Location = New Point(247, 35)
        Label34.Margin = New Padding(4, 0, 4, 0)
        Label34.Name = "Label34"
        Label34.RightToLeft = RightToLeft.No
        Label34.Size = New Size(35, 13)
        Label34.TabIndex = 86
        Label34.Text = "Rest :"
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label35.Location = New Point(7, 53)
        Label35.Margin = New Padding(4, 0, 4, 0)
        Label35.Name = "Label35"
        Label35.RightToLeft = RightToLeft.No
        Label35.Size = New Size(87, 13)
        Label35.TabIndex = 85
        Label35.Text = "Total Peyement :"
        ' 
        ' txtGrandTotal
        ' 
        txtGrandTotal.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtGrandTotal.Location = New Point(100, 18)
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
        txtPaymentDue.Location = New Point(297, 31)
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
        txtTotalPayment.Location = New Point(102, 50)
        txtTotalPayment.Margin = New Padding(4, 5, 4, 5)
        txtTotalPayment.Name = "txtTotalPayment"
        txtTotalPayment.Size = New Size(72, 20)
        txtTotalPayment.TabIndex = 1
        txtTotalPayment.Text = "0"
        txtTotalPayment.TextAlign = HorizontalAlignment.Right
        ' 
        ' DGV
        ' 
        DGV.AllowUserToAddRows = False
        DGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.BackColor = Color.FloralWhite
        DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DGV.BackgroundColor = Color.White
        DGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = Color.CadetBlue
        DataGridViewCellStyle7.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = Color.Black
        DataGridViewCellStyle7.SelectionBackColor = Color.LightSteelBlue
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
        DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        DGV.ColumnHeadersHeight = 31
        DGV.Columns.AddRange(New DataGridViewColumn() {PID, Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12})
        DGV.Cursor = Cursors.Hand
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = SystemColors.Window
        DataGridViewCellStyle8.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle8.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.False
        DGV.DefaultCellStyle = DataGridViewCellStyle8
        DGV.Dock = DockStyle.Bottom
        DGV.EnableHeadersVisualStyles = False
        DGV.GridColor = Color.White
        DGV.Location = New Point(0, 405)
        DGV.Margin = New Padding(4, 5, 5, 5)
        DGV.Name = "DGV"
        DGV.ReadOnly = True
        DGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = Color.CadetBlue
        DataGridViewCellStyle9.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle9.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = Color.DarkSlateGray
        DataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.True
        DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        DGV.RowHeadersVisible = False
        DGV.RowHeadersWidth = 30
        DataGridViewCellStyle10.BackColor = Color.White
        DataGridViewCellStyle10.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle10.SelectionBackColor = Color.DarkSlateGray
        DataGridViewCellStyle10.SelectionForeColor = Color.White
        DGV.RowsDefaultCellStyle = DataGridViewCellStyle10
        DGV.RowTemplate.Height = 18
        DGV.RowTemplate.Resizable = DataGridViewTriState.False
        DGV.ScrollBars = ScrollBars.Vertical
        DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV.Size = New Size(890, 210)
        DGV.TabIndex = 5
        ' 
        ' PID
        ' 
        PID.HeaderText = "Code Facture"
        PID.Name = "PID"
        PID.ReadOnly = True
        PID.Visible = False
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Facture N°"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Date Purchas"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Code sup"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Name Supp"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Code Pt"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Name Pt"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Quantity"
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Price "
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "Total"
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "Total Payment"
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        ' 
        ' Column11
        ' 
        Column11.HeaderText = "Total Payment due"
        Column11.Name = "Column11"
        Column11.ReadOnly = True
        ' 
        ' Column12
        ' 
        Column12.HeaderText = "Notes"
        Column12.Name = "Column12"
        Column12.ReadOnly = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(txtTotalAmount)
        GroupBox2.Controls.Add(txtPricePerQty)
        GroupBox2.Controls.Add(txtQty)
        GroupBox2.Controls.Add(btnShowPt)
        GroupBox2.Controls.Add(txtNamePt)
        GroupBox2.Controls.Add(txtCodePt)
        GroupBox2.Location = New Point(4, 80)
        GroupBox2.Margin = New Padding(4, 5, 4, 5)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4, 5, 4, 5)
        GroupBox2.RightToLeft = RightToLeft.No
        GroupBox2.Size = New Size(444, 158)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Invoice Data"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(197, 114)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.RightToLeft = RightToLeft.No
        Label9.Size = New Size(85, 15)
        Label9.TabIndex = 34
        Label9.Text = "Total Amount :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(18, 123)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.RightToLeft = RightToLeft.No
        Label6.Size = New Size(39, 15)
        Label6.TabIndex = 33
        Label6.Text = "Price :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(14, 88)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.RightToLeft = RightToLeft.No
        Label4.Size = New Size(59, 15)
        Label4.TabIndex = 32
        Label4.Text = "Quantity :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(9, 30)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.RightToLeft = RightToLeft.No
        Label7.Size = New Size(86, 15)
        Label7.TabIndex = 30
        Label7.Text = "Code Product :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 64)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.RightToLeft = RightToLeft.No
        Label8.Size = New Size(90, 15)
        Label8.TabIndex = 31
        Label8.Text = "Name Product :"
        ' 
        ' txtTotalAmount
        ' 
        txtTotalAmount.BackColor = SystemColors.Control
        txtTotalAmount.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtTotalAmount.Location = New Point(294, 110)
        txtTotalAmount.Margin = New Padding(4, 5, 4, 5)
        txtTotalAmount.Name = "txtTotalAmount"
        txtTotalAmount.ReadOnly = True
        txtTotalAmount.Size = New Size(112, 21)
        txtTotalAmount.TabIndex = 4
        txtTotalAmount.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtPricePerQty
        ' 
        txtPricePerQty.BackColor = SystemColors.ButtonHighlight
        txtPricePerQty.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtPricePerQty.Location = New Point(102, 120)
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
        txtQty.Location = New Point(101, 92)
        txtQty.Margin = New Padding(4, 5, 4, 5)
        txtQty.Name = "txtQty"
        txtQty.Size = New Size(81, 21)
        txtQty.TabIndex = 2
        txtQty.TextAlign = HorizontalAlignment.Right
        ' 
        ' btnShowPt
        ' 
        btnShowPt.FlatStyle = FlatStyle.System
        btnShowPt.Location = New Point(197, 25)
        btnShowPt.Margin = New Padding(4, 5, 4, 5)
        btnShowPt.Name = "btnShowPt"
        btnShowPt.Size = New Size(34, 24)
        btnShowPt.TabIndex = 5
        btnShowPt.Text = "..."
        btnShowPt.UseVisualStyleBackColor = True
        ' 
        ' txtNamePt
        ' 
        txtNamePt.BackColor = SystemColors.Control
        txtNamePt.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtNamePt.Location = New Point(100, 62)
        txtNamePt.Margin = New Padding(4, 5, 4, 5)
        txtNamePt.Name = "txtNamePt"
        txtNamePt.ReadOnly = True
        txtNamePt.Size = New Size(270, 21)
        txtNamePt.TabIndex = 1
        ' 
        ' txtCodePt
        ' 
        txtCodePt.BackColor = SystemColors.Control
        txtCodePt.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtCodePt.Location = New Point(97, 29)
        txtCodePt.Margin = New Padding(4, 5, 4, 5)
        txtCodePt.Name = "txtCodePt"
        txtCodePt.ReadOnly = True
        txtCodePt.Size = New Size(81, 21)
        txtCodePt.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(btnShowSupp)
        GroupBox1.Controls.Add(txtNameSup)
        GroupBox1.Controls.Add(txtCodeSup)
        GroupBox1.Controls.Add(txtDate)
        GroupBox1.Controls.Add(txtCodestock)
        GroupBox1.Location = New Point(480, 80)
        GroupBox1.Margin = New Padding(4, 5, 4, 5)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 5, 4, 5)
        GroupBox1.Size = New Size(373, 158)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Supplier Data"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.Control
        TextBox1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(280, 19)
        TextBox1.Margin = New Padding(4, 5, 4, 5)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(55, 21)
        TextBox1.TabIndex = 27
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 25)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.RightToLeft = RightToLeft.No
        Label3.Size = New Size(73, 15)
        Label3.TabIndex = 23
        Label3.Text = "Code Stock :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(13, 61)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.RightToLeft = RightToLeft.No
        Label2.Size = New Size(81, 15)
        Label2.TabIndex = 24
        Label2.Text = "Invoice  Date :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(14, 88)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.RightToLeft = RightToLeft.No
        Label5.Size = New Size(87, 15)
        Label5.TabIndex = 25
        Label5.Text = "Code Supplier :"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(16, 118)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.RightToLeft = RightToLeft.No
        Label11.Size = New Size(91, 15)
        Label11.TabIndex = 26
        Label11.Text = "Name Supplier :"
        ' 
        ' btnShowSupp
        ' 
        btnShowSupp.BackColor = Color.White
        btnShowSupp.FlatStyle = FlatStyle.System
        btnShowSupp.ForeColor = Color.AliceBlue
        btnShowSupp.Location = New Point(203, 83)
        btnShowSupp.Margin = New Padding(4, 5, 4, 5)
        btnShowSupp.Name = "btnShowSupp"
        btnShowSupp.Size = New Size(47, 24)
        btnShowSupp.TabIndex = 4
        btnShowSupp.Text = " ... "
        btnShowSupp.UseVisualStyleBackColor = False
        ' 
        ' txtNameSup
        ' 
        txtNameSup.BackColor = SystemColors.Control
        txtNameSup.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtNameSup.Location = New Point(114, 114)
        txtNameSup.Margin = New Padding(4, 5, 4, 5)
        txtNameSup.Name = "txtNameSup"
        txtNameSup.ReadOnly = True
        txtNameSup.Size = New Size(221, 21)
        txtNameSup.TabIndex = 3
        ' 
        ' txtCodeSup
        ' 
        txtCodeSup.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtCodeSup.Location = New Point(114, 84)
        txtCodeSup.Margin = New Padding(4, 5, 4, 5)
        txtCodeSup.Name = "txtCodeSup"
        txtCodeSup.ReadOnly = True
        txtCodeSup.Size = New Size(81, 21)
        txtCodeSup.TabIndex = 2
        ' 
        ' txtDate
        ' 
        txtDate.CustomFormat = "dd/MM/yyyy"
        txtDate.Format = DateTimePickerFormat.Custom
        txtDate.Location = New Point(140, 55)
        txtDate.Margin = New Padding(4, 5, 4, 5)
        txtDate.Name = "txtDate"
        txtDate.RightToLeft = RightToLeft.No
        txtDate.Size = New Size(144, 23)
        txtDate.TabIndex = 1
        ' 
        ' txtCodestock
        ' 
        txtCodestock.BackColor = SystemColors.Control
        txtCodestock.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtCodestock.Location = New Point(114, 24)
        txtCodestock.Margin = New Padding(4, 5, 4, 5)
        txtCodestock.Name = "txtCodestock"
        txtCodestock.Size = New Size(55, 21)
        txtCodestock.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(btnDelete)
        Panel3.Controls.Add(btnGetData)
        Panel3.Controls.Add(btnClose)
        Panel3.Controls.Add(btnUpdate)
        Panel3.Controls.Add(btnSave)
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(0, 615)
        Panel3.Margin = New Padding(4, 5, 4, 5)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(890, 57)
        Panel3.TabIndex = 2
        ' 
        ' btnDelete
        ' 
        btnDelete.Cursor = Cursors.Hand
        btnDelete.FlatStyle = FlatStyle.Popup
        btnDelete.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnDelete.Location = New Point(450, 9)
        btnDelete.Margin = New Padding(4, 5, 4, 5)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(96, 32)
        btnDelete.TabIndex = 6
        btnDelete.Text = "&Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnGetData
        ' 
        btnGetData.Cursor = Cursors.Hand
        btnGetData.FlatStyle = FlatStyle.Popup
        btnGetData.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnGetData.Location = New Point(558, 9)
        btnGetData.Margin = New Padding(4, 5, 4, 5)
        btnGetData.Name = "btnGetData"
        btnGetData.Size = New Size(96, 32)
        btnGetData.TabIndex = 5
        btnGetData.Text = "&Show Data"
        btnGetData.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Cursor = Cursors.Hand
        btnClose.FlatStyle = FlatStyle.Popup
        btnClose.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnClose.Location = New Point(662, 9)
        btnClose.Margin = New Padding(4, 5, 4, 5)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(96, 32)
        btnClose.TabIndex = 4
        btnClose.Text = "&Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Silver
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.Enabled = False
        btnUpdate.FlatStyle = FlatStyle.Popup
        btnUpdate.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnUpdate.Location = New Point(346, 9)
        btnUpdate.Margin = New Padding(4, 5, 4, 5)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(96, 32)
        btnUpdate.TabIndex = 2
        btnUpdate.Text = "&Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.Cursor = Cursors.Hand
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnSave.Location = New Point(242, 9)
        btnSave.Margin = New Padding(4, 5, 4, 5)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(96, 32)
        btnSave.TabIndex = 1
        btnSave.Text = "&Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnNew
        ' 
        btnNew.Cursor = Cursors.Hand
        btnNew.FlatStyle = FlatStyle.Popup
        btnNew.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnNew.Location = New Point(14, 10)
        btnNew.Margin = New Padding(4, 5, 4, 5)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(66, 27)
        btnNew.TabIndex = 0
        btnNew.Text = "&New"
        btnNew.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.SteelBlue
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Controls.Add(Panel6)
        Panel2.Controls.Add(lbl)
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(4, 5, 4, 5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(890, 70)
        Panel2.TabIndex = 0
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Yellow
        Panel6.Location = New Point(3, 66)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(884, 4)
        Panel6.TabIndex = 21
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(354, 23)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(181, 24)
        Label1.TabIndex = 0
        Label1.Text = "Purchases Invoice"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' FormInventory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(883, 669)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormInventory"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(DGV, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCodestock As TextBox
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
    Friend WithEvents DGV As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents txtPricePerQty As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnShowPt As Button
    Friend WithEvents txtNamePt As TextBox
    Friend WithEvents txtCodePt As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnShowSupp As Button
    Friend WithEvents txtNameSup As TextBox
    Friend WithEvents txtCodeSup As TextBox
    Friend WithEvents txtDate As DateTimePicker
    Friend WithEvents txtRemarks As RichTextBox
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
    Friend WithEvents lbl As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents PID As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Panel6 As Panel
End Class
