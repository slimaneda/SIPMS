<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormMain))
        MenuStrip1 = New MenuStrip()
        btn_user = New ToolStripMenuItem()
        btn_items = New ToolStripMenuItem()
        btn_database = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        btn_customer = New ToolStripMenuItem()
        btn_supplier = New ToolStripMenuItem()
        btn_Product = New ToolStripMenuItem()
        btnPurchas = New ToolStripMenuItem()
        btnsupplierpayement = New ToolStripMenuItem()
        btnQuatation = New ToolStripMenuItem()
        btnreciept = New ToolStripMenuItem()
        ExitToolStripMenuItem1 = New ToolStripMenuItem()
        ChangeTheAccountToolStripMenuItem = New ToolStripMenuItem()
        QuitTheProgramToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip2 = New MenuStrip()
        PppppppppToolStripMenuItem = New ToolStripMenuItem()
        btncompany = New ToolStripMenuItem()
        ItemsToolStripMenuItem1 = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        ToolsToolStripMenuItem1 = New ToolStripMenuItem()
        CalculToolStripMenuItem = New ToolStripMenuItem()
        NotepadToolStripMenuItem = New ToolStripMenuItem()
        WordpadToolStripMenuItem = New ToolStripMenuItem()
        MsWordToolStripMenuItem = New ToolStripMenuItem()
        TaslManagerToolStripMenuItem = New ToolStripMenuItem()
        SystemInfoToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem1 = New ToolStripMenuItem()
        AideToolStripMenuItem = New ToolStripMenuItem()
        ContenuToolStripMenuItem = New ToolStripMenuItem()
        IndexToolStripMenuItem = New ToolStripMenuItem()
        RechercherToolStripMenuItem = New ToolStripMenuItem()
        toolStripSeparator6 = New ToolStripSeparator()
        ÀproposdeToolStripMenuItem = New ToolStripMenuItem()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        DGV = New DataGridView()
        GroupBox1 = New GroupBox()
        Panel1 = New Panel()
        Label1 = New Label()
        txtnamecustomer = New TextBox()
        Panel5 = New Panel()
        Label3 = New Label()
        txtcodecustomer = New TextBox()
        btnsearchcustomer = New Button()
        TabPage2 = New TabPage()
        GroupBox2 = New GroupBox()
        Panel2 = New Panel()
        Label2 = New Label()
        txtnamesupplier = New TextBox()
        Panel6 = New Panel()
        Label4 = New Label()
        txtcodesupplier = New TextBox()
        btnsearchsupplier = New Button()
        DGV2 = New DataGridView()
        TabPage3 = New TabPage()
        GroupBox3 = New GroupBox()
        Panel3 = New Panel()
        Label5 = New Label()
        txtname = New TextBox()
        Panel7 = New Panel()
        Label6 = New Label()
        txtcode = New TextBox()
        btnsearch = New Button()
        DGV3 = New DataGridView()
        Panel4 = New Panel()
        Label16 = New Label()
        MenuStrip1.SuspendLayout()
        MenuStrip2.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(DGV, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel5.SuspendLayout()
        TabPage2.SuspendLayout()
        GroupBox2.SuspendLayout()
        Panel2.SuspendLayout()
        Panel6.SuspendLayout()
        CType(DGV2, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        GroupBox3.SuspendLayout()
        Panel3.SuspendLayout()
        Panel7.SuspendLayout()
        CType(DGV3, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {btn_user, btn_items, btn_database, btn_customer, btn_supplier, btn_Product, btnPurchas, btnsupplierpayement, btnQuatation, btnreciept, ExitToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 24)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1106, 73)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' btn_user
        ' 
        btn_user.Checked = True
        btn_user.CheckState = CheckState.Checked
        btn_user.Image = CType(resources.GetObject("btn_user.Image"), Image)
        btn_user.ImageAlign = ContentAlignment.TopCenter
        btn_user.ImageScaling = ToolStripItemImageScaling.None
        btn_user.Name = "btn_user"
        btn_user.Size = New Size(62, 69)
        btn_user.Text = "User"
        btn_user.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' btn_items
        ' 
        btn_items.Checked = True
        btn_items.CheckState = CheckState.Checked
        btn_items.Image = CType(resources.GetObject("btn_items.Image"), Image)
        btn_items.ImageScaling = ToolStripItemImageScaling.None
        btn_items.Name = "btn_items"
        btn_items.Size = New Size(75, 69)
        btn_items.Text = "Categories"
        btn_items.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' btn_database
        ' 
        btn_database.DropDownItems.AddRange(New ToolStripItem() {ToolStripSeparator1})
        btn_database.Enabled = False
        btn_database.Image = CType(resources.GetObject("btn_database.Image"), Image)
        btn_database.ImageScaling = ToolStripItemImageScaling.None
        btn_database.Name = "btn_database"
        btn_database.Size = New Size(70, 69)
        btn_database.Text = "Database "
        btn_database.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(57, 6)
        ' 
        ' btn_customer
        ' 
        btn_customer.Checked = True
        btn_customer.CheckState = CheckState.Checked
        btn_customer.Image = CType(resources.GetObject("btn_customer.Image"), Image)
        btn_customer.ImageScaling = ToolStripItemImageScaling.None
        btn_customer.Name = "btn_customer"
        btn_customer.Size = New Size(76, 69)
        btn_customer.Text = "Customers"
        btn_customer.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' btn_supplier
        ' 
        btn_supplier.Checked = True
        btn_supplier.CheckState = CheckState.Checked
        btn_supplier.Image = CType(resources.GetObject("btn_supplier.Image"), Image)
        btn_supplier.ImageScaling = ToolStripItemImageScaling.None
        btn_supplier.Name = "btn_supplier"
        btn_supplier.Size = New Size(91, 69)
        btn_supplier.Text = "Suppliers (frs)"
        btn_supplier.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' btn_Product
        ' 
        btn_Product.Checked = True
        btn_Product.CheckState = CheckState.Checked
        btn_Product.Image = CType(resources.GetObject("btn_Product.Image"), Image)
        btn_Product.ImageScaling = ToolStripItemImageScaling.None
        btn_Product.Name = "btn_Product"
        btn_Product.Size = New Size(66, 69)
        btn_Product.Text = "Products"
        btn_Product.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' btnPurchas
        ' 
        btnPurchas.Checked = True
        btnPurchas.CheckState = CheckState.Checked
        btnPurchas.Image = CType(resources.GetObject("btnPurchas.Image"), Image)
        btnPurchas.ImageScaling = ToolStripItemImageScaling.None
        btnPurchas.Name = "btnPurchas"
        btnPurchas.Size = New Size(62, 69)
        btnPurchas.Text = "Iventory"
        btnPurchas.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' btnsupplierpayement
        ' 
        btnsupplierpayement.Checked = True
        btnsupplierpayement.CheckState = CheckState.Checked
        btnsupplierpayement.Image = CType(resources.GetObject("btnsupplierpayement.Image"), Image)
        btnsupplierpayement.ImageScaling = ToolStripItemImageScaling.None
        btnsupplierpayement.Name = "btnsupplierpayement"
        btnsupplierpayement.Size = New Size(112, 69)
        btnsupplierpayement.Text = "Supplier Payment"
        btnsupplierpayement.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' btnQuatation
        ' 
        btnQuatation.Checked = True
        btnQuatation.CheckState = CheckState.Checked
        btnQuatation.Image = CType(resources.GetObject("btnQuatation.Image"), Image)
        btnQuatation.ImageScaling = ToolStripItemImageScaling.None
        btnQuatation.Name = "btnQuatation"
        btnQuatation.Size = New Size(62, 69)
        btnQuatation.Text = "Sales"
        btnQuatation.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' btnreciept
        ' 
        btnreciept.Checked = True
        btnreciept.CheckState = CheckState.Checked
        btnreciept.Image = CType(resources.GetObject("btnreciept.Image"), Image)
        btnreciept.ImageScaling = ToolStripItemImageScaling.None
        btnreciept.Name = "btnreciept"
        btnreciept.Size = New Size(113, 69)
        btnreciept.Text = "Customer Receipt"
        btnreciept.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' ExitToolStripMenuItem1
        ' 
        ExitToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {ChangeTheAccountToolStripMenuItem, QuitTheProgramToolStripMenuItem})
        ExitToolStripMenuItem1.Image = CType(resources.GetObject("ExitToolStripMenuItem1.Image"), Image)
        ExitToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None
        ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        ExitToolStripMenuItem1.Size = New Size(62, 69)
        ExitToolStripMenuItem1.Text = "Exit"
        ExitToolStripMenuItem1.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' ChangeTheAccountToolStripMenuItem
        ' 
        ChangeTheAccountToolStripMenuItem.Name = "ChangeTheAccountToolStripMenuItem"
        ChangeTheAccountToolStripMenuItem.Size = New Size(183, 22)
        ChangeTheAccountToolStripMenuItem.Text = "Change the Account"
        ' 
        ' QuitTheProgramToolStripMenuItem
        ' 
        QuitTheProgramToolStripMenuItem.Name = "QuitTheProgramToolStripMenuItem"
        QuitTheProgramToolStripMenuItem.Size = New Size(183, 22)
        QuitTheProgramToolStripMenuItem.Text = "Quit the Program"
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.Items.AddRange(New ToolStripItem() {PppppppppToolStripMenuItem, ToolsToolStripMenuItem1, AboutToolStripMenuItem1, AideToolStripMenuItem})
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.ShowItemToolTips = True
        MenuStrip2.Size = New Size(1106, 24)
        MenuStrip2.TabIndex = 2
        MenuStrip2.Text = "MenuStrip2"
        ' 
        ' PppppppppToolStripMenuItem
        ' 
        PppppppppToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {btncompany, ItemsToolStripMenuItem1, ExitToolStripMenuItem})
        PppppppppToolStripMenuItem.Name = "PppppppppToolStripMenuItem"
        PppppppppToolStripMenuItem.Size = New Size(34, 20)
        PppppppppToolStripMenuItem.Text = "Fill"
        ' 
        ' btncompany
        ' 
        btncompany.Enabled = False
        btncompany.Name = "btncompany"
        btncompany.Size = New Size(126, 22)
        btncompany.Text = "Company"
        ' 
        ' ItemsToolStripMenuItem1
        ' 
        ItemsToolStripMenuItem1.Name = "ItemsToolStripMenuItem1"
        ItemsToolStripMenuItem1.Size = New Size(126, 22)
        ItemsToolStripMenuItem1.Text = "Items"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(126, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' ToolsToolStripMenuItem1
        ' 
        ToolsToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {CalculToolStripMenuItem, NotepadToolStripMenuItem, WordpadToolStripMenuItem, MsWordToolStripMenuItem, TaslManagerToolStripMenuItem, SystemInfoToolStripMenuItem})
        ToolsToolStripMenuItem1.Name = "ToolsToolStripMenuItem1"
        ToolsToolStripMenuItem1.Size = New Size(41, 20)
        ToolsToolStripMenuItem1.Text = "Tool"
        ' 
        ' CalculToolStripMenuItem
        ' 
        CalculToolStripMenuItem.Name = "CalculToolStripMenuItem"
        CalculToolStripMenuItem.Size = New Size(143, 22)
        CalculToolStripMenuItem.Text = "Calculator"
        ' 
        ' NotepadToolStripMenuItem
        ' 
        NotepadToolStripMenuItem.Name = "NotepadToolStripMenuItem"
        NotepadToolStripMenuItem.Size = New Size(143, 22)
        NotepadToolStripMenuItem.Text = "Notepad"
        ' 
        ' WordpadToolStripMenuItem
        ' 
        WordpadToolStripMenuItem.Name = "WordpadToolStripMenuItem"
        WordpadToolStripMenuItem.Size = New Size(143, 22)
        WordpadToolStripMenuItem.Text = "Wordpad"
        ' 
        ' MsWordToolStripMenuItem
        ' 
        MsWordToolStripMenuItem.Name = "MsWordToolStripMenuItem"
        MsWordToolStripMenuItem.Size = New Size(143, 22)
        MsWordToolStripMenuItem.Text = "Ms Word"
        ' 
        ' TaslManagerToolStripMenuItem
        ' 
        TaslManagerToolStripMenuItem.Name = "TaslManagerToolStripMenuItem"
        TaslManagerToolStripMenuItem.Size = New Size(143, 22)
        TaslManagerToolStripMenuItem.Text = "Tasl Manager"
        ' 
        ' SystemInfoToolStripMenuItem
        ' 
        SystemInfoToolStripMenuItem.Name = "SystemInfoToolStripMenuItem"
        SystemInfoToolStripMenuItem.Size = New Size(143, 22)
        SystemInfoToolStripMenuItem.Text = "System Info"
        ' 
        ' AboutToolStripMenuItem1
        ' 
        AboutToolStripMenuItem1.AutoToolTip = True
        AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        AboutToolStripMenuItem1.Size = New Size(52, 20)
        AboutToolStripMenuItem1.Text = "About"
        ' 
        ' AideToolStripMenuItem
        ' 
        AideToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ContenuToolStripMenuItem, IndexToolStripMenuItem, RechercherToolStripMenuItem, toolStripSeparator6, ÀproposdeToolStripMenuItem})
        AideToolStripMenuItem.Name = "AideToolStripMenuItem"
        AideToolStripMenuItem.Size = New Size(43, 20)
        AideToolStripMenuItem.Text = "A&ide"
        ' 
        ' ContenuToolStripMenuItem
        ' 
        ContenuToolStripMenuItem.Name = "ContenuToolStripMenuItem"
        ContenuToolStripMenuItem.Size = New Size(147, 22)
        ContenuToolStripMenuItem.Text = "Conten&u"
        ' 
        ' IndexToolStripMenuItem
        ' 
        IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        IndexToolStripMenuItem.Size = New Size(147, 22)
        IndexToolStripMenuItem.Text = "&Index"
        ' 
        ' RechercherToolStripMenuItem
        ' 
        RechercherToolStripMenuItem.Name = "RechercherToolStripMenuItem"
        RechercherToolStripMenuItem.Size = New Size(147, 22)
        RechercherToolStripMenuItem.Text = "&Rechercher"
        ' 
        ' toolStripSeparator6
        ' 
        toolStripSeparator6.Name = "toolStripSeparator6"
        toolStripSeparator6.Size = New Size(144, 6)
        ' 
        ' ÀproposdeToolStripMenuItem
        ' 
        ÀproposdeToolStripMenuItem.Name = "ÀproposdeToolStripMenuItem"
        ÀproposdeToolStripMenuItem.Size = New Size(147, 22)
        ÀproposdeToolStripMenuItem.Text = "À pr&opos de..."
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Dock = DockStyle.Top
        TabControl1.Location = New Point(0, 97)
        TabControl1.Multiline = True
        TabControl1.Name = "TabControl1"
        TabControl1.RightToLeft = RightToLeft.Yes
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1106, 506)
        TabControl1.TabIndex = 3
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.LightGray
        TabPage1.Controls.Add(DGV)
        TabPage1.Controls.Add(GroupBox1)
        TabPage1.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1098, 478)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Customers Account"
        ' 
        ' DGV
        ' 
        DGV.AllowUserToAddRows = False
        DGV.AllowUserToDeleteRows = False
        DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV.Location = New Point(16, 74)
        DGV.Name = "DGV"
        DGV.ReadOnly = True
        DGV.RightToLeft = RightToLeft.No
        DGV.RowTemplate.Height = 25
        DGV.Size = New Size(1055, 387)
        DGV.TabIndex = 10
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.LightGray
        GroupBox1.Controls.Add(Panel1)
        GroupBox1.Controls.Add(Panel5)
        GroupBox1.Controls.Add(btnsearchcustomer)
        GroupBox1.Dock = DockStyle.Top
        GroupBox1.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.Location = New Point(3, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.RightToLeft = RightToLeft.No
        GroupBox1.Size = New Size(1092, 65)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtnamecustomer)
        Panel1.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Panel1.Location = New Point(444, 18)
        Panel1.Name = "Panel1"
        Panel1.RightToLeft = RightToLeft.No
        Panel1.Size = New Size(286, 34)
        Panel1.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 16)
        Label1.TabIndex = 2
        Label1.Text = "Search Name  Customer :"
        ' 
        ' txtnamecustomer
        ' 
        txtnamecustomer.Location = New Point(183, 6)
        txtnamecustomer.Name = "txtnamecustomer"
        txtnamecustomer.Size = New Size(86, 23)
        txtnamecustomer.TabIndex = 1
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(Label3)
        Panel5.Controls.Add(txtcodecustomer)
        Panel5.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Panel5.Location = New Point(113, 18)
        Panel5.Name = "Panel5"
        Panel5.RightToLeft = RightToLeft.No
        Panel5.Size = New Size(286, 34)
        Panel5.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(152, 16)
        Label3.TabIndex = 2
        Label3.Text = "Search Code  Customer :"
        ' 
        ' txtcodecustomer
        ' 
        txtcodecustomer.Location = New Point(183, 6)
        txtcodecustomer.Name = "txtcodecustomer"
        txtcodecustomer.Size = New Size(86, 23)
        txtcodecustomer.TabIndex = 1
        ' 
        ' btnsearchcustomer
        ' 
        btnsearchcustomer.Location = New Point(863, 16)
        btnsearchcustomer.Name = "btnsearchcustomer"
        btnsearchcustomer.Size = New Size(75, 36)
        btnsearchcustomer.TabIndex = 8
        btnsearchcustomer.Text = "Search"
        btnsearchcustomer.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.Gainsboro
        TabPage2.Controls.Add(GroupBox2)
        TabPage2.Controls.Add(DGV2)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1098, 478)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Supplier Accuount"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.LightGray
        GroupBox2.Controls.Add(Panel2)
        GroupBox2.Controls.Add(Panel6)
        GroupBox2.Controls.Add(btnsearchsupplier)
        GroupBox2.Dock = DockStyle.Top
        GroupBox2.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox2.Location = New Point(3, 3)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.RightToLeft = RightToLeft.No
        GroupBox2.Size = New Size(1092, 65)
        GroupBox2.TabIndex = 12
        GroupBox2.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(txtnamesupplier)
        Panel2.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Panel2.Location = New Point(444, 18)
        Panel2.Name = "Panel2"
        Panel2.RightToLeft = RightToLeft.No
        Panel2.Size = New Size(286, 34)
        Panel2.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 16)
        Label2.TabIndex = 2
        Label2.Text = "Search Name Supplier :"
        ' 
        ' txtnamesupplier
        ' 
        txtnamesupplier.Location = New Point(183, 6)
        txtnamesupplier.Name = "txtnamesupplier"
        txtnamesupplier.Size = New Size(86, 23)
        txtnamesupplier.TabIndex = 1
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(Label4)
        Panel6.Controls.Add(txtcodesupplier)
        Panel6.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Panel6.Location = New Point(113, 18)
        Panel6.Name = "Panel6"
        Panel6.RightToLeft = RightToLeft.No
        Panel6.Size = New Size(286, 34)
        Panel6.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(13, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(144, 16)
        Label4.TabIndex = 2
        Label4.Text = "Search Code  Supplier :"
        ' 
        ' txtcodesupplier
        ' 
        txtcodesupplier.Location = New Point(183, 6)
        txtcodesupplier.Name = "txtcodesupplier"
        txtcodesupplier.Size = New Size(86, 23)
        txtcodesupplier.TabIndex = 1
        ' 
        ' btnsearchsupplier
        ' 
        btnsearchsupplier.Location = New Point(863, 16)
        btnsearchsupplier.Name = "btnsearchsupplier"
        btnsearchsupplier.Size = New Size(75, 36)
        btnsearchsupplier.TabIndex = 8
        btnsearchsupplier.Text = "Search"
        btnsearchsupplier.UseVisualStyleBackColor = True
        ' 
        ' DGV2
        ' 
        DGV2.AllowUserToAddRows = False
        DGV2.AllowUserToDeleteRows = False
        DGV2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGV2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV2.Location = New Point(16, 74)
        DGV2.Name = "DGV2"
        DGV2.ReadOnly = True
        DGV2.RightToLeft = RightToLeft.No
        DGV2.RowTemplate.Height = 25
        DGV2.Size = New Size(1055, 387)
        DGV2.TabIndex = 11
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.LightGray
        TabPage3.Controls.Add(GroupBox3)
        TabPage3.Controls.Add(DGV3)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(1098, 478)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Inventory Data"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.LightGray
        GroupBox3.Controls.Add(Panel3)
        GroupBox3.Controls.Add(Panel7)
        GroupBox3.Controls.Add(btnsearch)
        GroupBox3.Dock = DockStyle.Top
        GroupBox3.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox3.Location = New Point(3, 3)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.RightToLeft = RightToLeft.No
        GroupBox3.Size = New Size(1092, 65)
        GroupBox3.TabIndex = 13
        GroupBox3.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(txtname)
        Panel3.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Panel3.Location = New Point(444, 18)
        Panel3.Name = "Panel3"
        Panel3.RightToLeft = RightToLeft.No
        Panel3.Size = New Size(286, 34)
        Panel3.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(15, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(144, 16)
        Label5.TabIndex = 2
        Label5.Text = "Search Name  Product :"
        ' 
        ' txtname
        ' 
        txtname.Location = New Point(183, 6)
        txtname.Name = "txtname"
        txtname.Size = New Size(86, 23)
        txtname.TabIndex = 1
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(Label6)
        Panel7.Controls.Add(txtcode)
        Panel7.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Panel7.Location = New Point(113, 18)
        Panel7.Name = "Panel7"
        Panel7.RightToLeft = RightToLeft.No
        Panel7.Size = New Size(286, 34)
        Panel7.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(13, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(140, 16)
        Label6.TabIndex = 2
        Label6.Text = "Search Code  Product :"
        ' 
        ' txtcode
        ' 
        txtcode.Location = New Point(183, 6)
        txtcode.Name = "txtcode"
        txtcode.Size = New Size(86, 23)
        txtcode.TabIndex = 1
        ' 
        ' btnsearch
        ' 
        btnsearch.Location = New Point(863, 16)
        btnsearch.Name = "btnsearch"
        btnsearch.Size = New Size(75, 36)
        btnsearch.TabIndex = 8
        btnsearch.Text = "Search"
        btnsearch.UseVisualStyleBackColor = True
        ' 
        ' DGV3
        ' 
        DGV3.AllowUserToAddRows = False
        DGV3.AllowUserToDeleteRows = False
        DGV3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGV3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV3.EnableHeadersVisualStyles = False
        DGV3.Location = New Point(16, 74)
        DGV3.Name = "DGV3"
        DGV3.ReadOnly = True
        DGV3.RightToLeft = RightToLeft.No
        DGV3.Size = New Size(1055, 387)
        DGV3.TabIndex = 12
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Label16)
        Panel4.Dock = DockStyle.Bottom
        Panel4.Location = New Point(0, 602)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1106, 46)
        Panel4.TabIndex = 4
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(33, 20)
        Label16.Name = "Label16"
        Label16.Size = New Size(1022, 15)
        Label16.TabIndex = 0
        Label16.Text = """All rights reserved for the 'SIPMS' application. Designed and developed by SLIMANE DANY. Any use or copying without prior permission is considered a violation of intellectual property rights."""
        ' 
        ' FormMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1106, 648)
        Controls.Add(Panel4)
        Controls.Add(TabControl1)
        Controls.Add(MenuStrip1)
        Controls.Add(MenuStrip2)
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "FormMain"
        Text = "Sales Invontory and Purchase Management System (SIPMS)"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        CType(DGV, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        TabPage2.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(DGV2, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        CType(DGV3, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btn_user As ToolStripMenuItem
    Friend WithEvents btn_items As ToolStripMenuItem
    Friend WithEvents btn_database As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents PppppppppToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btncompany As ToolStripMenuItem
    Friend WithEvents ItemsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CalculToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotepadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WordpadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MsWordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TaslManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SystemInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_customer As ToolStripMenuItem
    Friend WithEvents btn_supplier As ToolStripMenuItem
    Friend WithEvents btn_Product As ToolStripMenuItem
    Friend WithEvents btnQuatation As ToolStripMenuItem
    Friend WithEvents btnsupplierpayement As ToolStripMenuItem
    Friend WithEvents btnreciept As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGV As DataGridView
    Friend WithEvents btnsearchcustomer As Button
    Friend WithEvents DGV2 As DataGridView
    Friend WithEvents DGV3 As DataGridView
    Friend WithEvents btnPurchas As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RechercherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ÀproposdeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeTheAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitTheProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcodecustomer As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnamecustomer As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnamesupplier As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcodesupplier As TextBox
    Friend WithEvents btnsearchsupplier As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcode As TextBox
    Friend WithEvents btnsearch As Button
End Class
