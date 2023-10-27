
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOverallReport
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
        txtGrandTotal = New TextBox()
        btnClose = New Button()
        btnSave = New Button()
        GroupBox1 = New GroupBox()
        txtCodCustomer = New TextBox()
        txtNameCustomer = New TextBox()
        btnShow = New Button()
        Label31 = New Label()
        txtCodeCustomers = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        txtBalance = New TextBox()
        GroupBox2 = New GroupBox()
        btnNew = New Button()
        btnUpdate = New Button()
        btnRemove = New Button()
        btnAdd = New Button()
        DGV = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column16 = New DataGridViewTextBoxColumn()
        Column15 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        dtpPaymentDate = New DateTimePicker()
        Label7 = New Label()
        Panel4 = New Panel()
        Label34 = New Label()
        Label35 = New Label()
        txtnewBalance = New TextBox()
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
        Panel1.Controls.Add(txtGrandTotal)
        Panel1.Controls.Add(btnClose)
        Panel1.Controls.Add(btnSave)
        Panel1.Controls.Add(GroupBox1)
        Panel1.Controls.Add(GroupBox2)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(8, 7)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(711, 562)
        Panel1.TabIndex = 2
        ' 
        ' txtGrandTotal
        ' 
        txtGrandTotal.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtGrandTotal.Location = New Point(567, 514)
        txtGrandTotal.Margin = New Padding(4, 3, 4, 3)
        txtGrandTotal.Name = "txtGrandTotal"
        txtGrandTotal.ReadOnly = True
        txtGrandTotal.Size = New Size(128, 29)
        txtGrandTotal.TabIndex = 91
        txtGrandTotal.Text = "00"
        txtGrandTotal.TextAlign = HorizontalAlignment.Center
        txtGrandTotal.Visible = False
        ' 
        ' btnClose
        ' 
        btnClose.FlatStyle = FlatStyle.Popup
        btnClose.Location = New Point(392, 500)
        btnClose.Margin = New Padding(4, 3, 4, 3)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(105, 43)
        btnClose.TabIndex = 7
        btnClose.Text = "&Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.Location = New Point(208, 500)
        btnSave.Margin = New Padding(4, 3, 4, 3)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(105, 43)
        btnSave.TabIndex = 6
        btnSave.Text = "&Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtCodCustomer)
        GroupBox1.Controls.Add(txtNameCustomer)
        GroupBox1.Controls.Add(btnShow)
        GroupBox1.Controls.Add(Label31)
        GroupBox1.Controls.Add(txtCodeCustomers)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtBalance)
        GroupBox1.Location = New Point(10, 91)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.Size = New Size(671, 110)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Detail Customet "
        ' 
        ' txtCodCustomer
        ' 
        txtCodCustomer.Location = New Point(251, 25)
        txtCodCustomer.Margin = New Padding(4, 3, 4, 3)
        txtCodCustomer.Name = "txtCodCustomer"
        txtCodCustomer.ReadOnly = True
        txtCodCustomer.Size = New Size(61, 23)
        txtCodCustomer.TabIndex = 90
        txtCodCustomer.TextAlign = HorizontalAlignment.Center
        txtCodCustomer.Visible = False
        ' 
        ' txtNameCustomer
        ' 
        txtNameCustomer.Location = New Point(103, 66)
        txtNameCustomer.Margin = New Padding(4, 3, 4, 3)
        txtNameCustomer.Name = "txtNameCustomer"
        txtNameCustomer.ReadOnly = True
        txtNameCustomer.Size = New Size(140, 23)
        txtNameCustomer.TabIndex = 89
        txtNameCustomer.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnShow
        ' 
        btnShow.BackgroundImageLayout = ImageLayout.None
        btnShow.FlatStyle = FlatStyle.System
        btnShow.Location = New Point(269, 50)
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
        Label31.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label31.Location = New Point(429, 27)
        Label31.Margin = New Padding(4, 0, 4, 0)
        Label31.Name = "Label31"
        Label31.Size = New Size(153, 15)
        Label31.TabIndex = 87
        Label31.Text = "Current balance Customer "
        ' 
        ' txtCodeCustomers
        ' 
        txtCodeCustomers.Location = New Point(103, 27)
        txtCodeCustomers.Margin = New Padding(4, 3, 4, 3)
        txtCodeCustomers.Name = "txtCodeCustomers"
        txtCodeCustomers.ReadOnly = True
        txtCodeCustomers.Size = New Size(140, 23)
        txtCodeCustomers.TabIndex = 3
        txtCodeCustomers.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(8, 30)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 15)
        Label3.TabIndex = 2
        Label3.Text = "Code Customer :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(8, 69)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 15)
        Label2.TabIndex = 1
        Label2.Text = "Name Customer :"
        ' 
        ' txtBalance
        ' 
        txtBalance.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtBalance.Location = New Point(404, 53)
        txtBalance.Margin = New Padding(4, 3, 4, 3)
        txtBalance.Name = "txtBalance"
        txtBalance.ReadOnly = True
        txtBalance.Size = New Size(184, 29)
        txtBalance.TabIndex = 0
        txtBalance.Text = "00"
        txtBalance.TextAlign = HorizontalAlignment.Center
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnNew)
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
        GroupBox2.Size = New Size(671, 286)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "Payment information"
        ' 
        ' btnNew
        ' 
        btnNew.FlatStyle = FlatStyle.Popup
        btnNew.Location = New Point(519, 143)
        btnNew.Margin = New Padding(4, 3, 4, 3)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(96, 24)
        btnNew.TabIndex = 90
        btnNew.Text = "&New"
        btnNew.UseVisualStyleBackColor = True
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
        btnUpdate.Text = "&Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnRemove
        ' 
        btnRemove.FlatStyle = FlatStyle.Popup
        btnRemove.Location = New Point(518, 202)
        btnRemove.Margin = New Padding(4, 3, 4, 3)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(96, 24)
        btnRemove.TabIndex = 88
        btnRemove.Text = "&Supp"
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
        btnAdd.Text = "&Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' DGV
        ' 
        DGV.AllowUserToAddRows = False
        DGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FloralWhite
        DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
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
        DGV.ColumnHeadersHeight = 35
        DGV.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column8, Column16, Column15, Column3, Column4})
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
        DGV.Location = New Point(7, 134)
        DGV.Margin = New Padding(4, 3, 4, 3)
        DGV.Name = "DGV"
        DGV.ReadOnly = True
        DGV.RightToLeft = RightToLeft.No
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
        ' Column1
        ' 
        Column1.HeaderText = "Code Customer"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Name Customer"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Payement Methode"
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        ' 
        ' Column16
        ' 
        DataGridViewCellStyle3.Format = "dd/MM/yyyy"
        Column16.DefaultCellStyle = DataGridViewCellStyle3
        Column16.HeaderText = "Date Payement"
        Column16.Name = "Column16"
        Column16.ReadOnly = True
        ' 
        ' Column15
        ' 
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopRight
        Column15.DefaultCellStyle = DataGridViewCellStyle4
        Column15.HeaderText = "The amount Paid"
        Column15.Name = "Column15"
        Column15.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Balance"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Code Cust"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Visible = False
        ' 
        ' dtpPaymentDate
        ' 
        dtpPaymentDate.CustomFormat = "dd/MM/yyyy"
        dtpPaymentDate.Format = DateTimePickerFormat.Custom
        dtpPaymentDate.Location = New Point(119, 97)
        dtpPaymentDate.Margin = New Padding(2)
        dtpPaymentDate.Name = "dtpPaymentDate"
        dtpPaymentDate.RightToLeft = RightToLeft.Yes
        dtpPaymentDate.Size = New Size(129, 23)
        dtpPaymentDate.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(8, 98)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(87, 15)
        Label7.TabIndex = 25
        Label7.Text = "Payment Date :"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Transparent
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(Label34)
        Panel4.Controls.Add(Label35)
        Panel4.Controls.Add(txtnewBalance)
        Panel4.Controls.Add(txtTotalPayment)
        Panel4.Location = New Point(283, 23)
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
        Label34.Size = New Size(140, 13)
        Label34.TabIndex = 86
        Label34.Text = "The new Customer balance:"
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label35.Location = New Point(190, 20)
        Label35.Margin = New Padding(4, 0, 4, 0)
        Label35.Name = "Label35"
        Label35.Size = New Size(70, 13)
        Label35.TabIndex = 85
        Label35.Text = "Total Amount"
        ' 
        ' txtnewBalance
        ' 
        txtnewBalance.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtnewBalance.Location = New Point(27, 66)
        txtnewBalance.Margin = New Padding(4, 3, 4, 3)
        txtnewBalance.Name = "txtnewBalance"
        txtnewBalance.ReadOnly = True
        txtnewBalance.Size = New Size(156, 20)
        txtnewBalance.TabIndex = 2
        txtnewBalance.Text = "00"
        txtnewBalance.TextAlign = HorizontalAlignment.Center
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
        txtPayment.Location = New Point(119, 72)
        txtPayment.Margin = New Padding(4, 3, 4, 3)
        txtPayment.Name = "txtPayment"
        txtPayment.Size = New Size(129, 20)
        txtPayment.TabIndex = 1
        txtPayment.Text = "0"
        txtPayment.TextAlign = HorizontalAlignment.Center
        ' 
        ' cmbPaymentMode
        ' 
        cmbPaymentMode.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPaymentMode.FormattingEnabled = True
        cmbPaymentMode.Items.AddRange(New Object() {"Cash", "Check", "Direct Deposit", "Credit Card"})
        cmbPaymentMode.Location = New Point(121, 43)
        cmbPaymentMode.Margin = New Padding(4, 3, 4, 3)
        cmbPaymentMode.Name = "cmbPaymentMode"
        cmbPaymentMode.Size = New Size(129, 23)
        cmbPaymentMode.TabIndex = 0
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(8, 46)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(105, 15)
        Label12.TabIndex = 11
        Label12.Text = "Payment method :"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(8, 74)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(103, 15)
        Label13.TabIndex = 22
        Label13.Text = "The amount paid :"
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
        Panel2.Size = New Size(709, 72)
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
        Label1.Size = New Size(176, 24)
        Label1.TabIndex = 0
        Label1.Text = "Customer Receipt"
        ' 
        ' frmOverallReport
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateGray
        ClientSize = New Size(729, 583)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmOverallReport"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
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
    Friend WithEvents btnNew As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents dtpPaymentDate As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label31 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents txtnewBalance As TextBox
    Friend WithEvents txtTotalPayment As TextBox
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents cmbPaymentMode As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodeCustomers As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents txtNameCustomer As TextBox
    Friend WithEvents txtCodCustomer As TextBox
    Friend WithEvents txtGrandTotal As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
