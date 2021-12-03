<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MedicineForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MedicineForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MedicineNameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BuyingPriceTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SellingPriceTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.QuantityTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BackButton = New Guna.UI2.WinForms.Guna2Button()
        Me.ExitButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SearchTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ClearButton = New Guna.UI2.WinForms.Guna2Button()
        Me.DeleteButton = New Guna.UI2.WinForms.Guna2Button()
        Me.EditButton = New Guna.UI2.WinForms.Guna2Button()
        Me.AddButton = New Guna.UI2.WinForms.Guna2Button()
        Me.MedDateTimePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ConnectionLabel = New System.Windows.Forms.Label()
        Me.MedIDTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CompanyComboBox = New System.Windows.Forms.ComboBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ValidityButton = New Guna.UI2.WinForms.Guna2Button()
        Me.SupplierButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.BillingButton = New Guna.UI2.WinForms.Guna2Button()
        Me.MedicineButton = New Guna.UI2.WinForms.Guna2Button()
        Me.AgentButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SpringGreen
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1187, 102)
        Me.Panel1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SpringGreen
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1187, 102)
        Me.Panel3.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label7.Location = New System.Drawing.Point(518, 50)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 30)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "MEDICINE"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label12.Location = New System.Drawing.Point(432, 9)
        Me.Label12.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(334, 41)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "EQUATOR PHARMACY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(434, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "MEDICINE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(336, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 41)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "EQUATOR PHARMACY"
        '
        'MedicineNameTextBox
        '
        Me.MedicineNameTextBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MedicineNameTextBox.BorderRadius = 3
        Me.MedicineNameTextBox.BorderThickness = 2
        Me.MedicineNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MedicineNameTextBox.DefaultText = ""
        Me.MedicineNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.MedicineNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.MedicineNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.MedicineNameTextBox.DisabledState.Parent = Me.MedicineNameTextBox
        Me.MedicineNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.MedicineNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MedicineNameTextBox.FocusedState.Parent = Me.MedicineNameTextBox
        Me.MedicineNameTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedicineNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MedicineNameTextBox.HoverState.Parent = Me.MedicineNameTextBox
        Me.MedicineNameTextBox.Location = New System.Drawing.Point(111, 213)
        Me.MedicineNameTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MedicineNameTextBox.Name = "MedicineNameTextBox"
        Me.MedicineNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MedicineNameTextBox.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.MedicineNameTextBox.PlaceholderText = "Medicine Name"
        Me.MedicineNameTextBox.SelectedText = ""
        Me.MedicineNameTextBox.ShadowDecoration.Parent = Me.MedicineNameTextBox
        Me.MedicineNameTextBox.Size = New System.Drawing.Size(260, 50)
        Me.MedicineNameTextBox.TabIndex = 3
        '
        'BuyingPriceTextBox
        '
        Me.BuyingPriceTextBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BuyingPriceTextBox.BorderRadius = 3
        Me.BuyingPriceTextBox.BorderThickness = 2
        Me.BuyingPriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BuyingPriceTextBox.DefaultText = ""
        Me.BuyingPriceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.BuyingPriceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BuyingPriceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BuyingPriceTextBox.DisabledState.Parent = Me.BuyingPriceTextBox
        Me.BuyingPriceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BuyingPriceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BuyingPriceTextBox.FocusedState.Parent = Me.BuyingPriceTextBox
        Me.BuyingPriceTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuyingPriceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BuyingPriceTextBox.HoverState.Parent = Me.BuyingPriceTextBox
        Me.BuyingPriceTextBox.Location = New System.Drawing.Point(111, 298)
        Me.BuyingPriceTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BuyingPriceTextBox.Name = "BuyingPriceTextBox"
        Me.BuyingPriceTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BuyingPriceTextBox.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.BuyingPriceTextBox.PlaceholderText = "Buying Price"
        Me.BuyingPriceTextBox.SelectedText = ""
        Me.BuyingPriceTextBox.ShadowDecoration.Parent = Me.BuyingPriceTextBox
        Me.BuyingPriceTextBox.Size = New System.Drawing.Size(260, 50)
        Me.BuyingPriceTextBox.TabIndex = 4
        '
        'SellingPriceTextBox
        '
        Me.SellingPriceTextBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SellingPriceTextBox.BorderRadius = 3
        Me.SellingPriceTextBox.BorderThickness = 2
        Me.SellingPriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SellingPriceTextBox.DefaultText = ""
        Me.SellingPriceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SellingPriceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SellingPriceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SellingPriceTextBox.DisabledState.Parent = Me.SellingPriceTextBox
        Me.SellingPriceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SellingPriceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SellingPriceTextBox.FocusedState.Parent = Me.SellingPriceTextBox
        Me.SellingPriceTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SellingPriceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SellingPriceTextBox.HoverState.Parent = Me.SellingPriceTextBox
        Me.SellingPriceTextBox.Location = New System.Drawing.Point(111, 379)
        Me.SellingPriceTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SellingPriceTextBox.Name = "SellingPriceTextBox"
        Me.SellingPriceTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SellingPriceTextBox.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.SellingPriceTextBox.PlaceholderText = "Selling Price"
        Me.SellingPriceTextBox.SelectedText = ""
        Me.SellingPriceTextBox.ShadowDecoration.Parent = Me.SellingPriceTextBox
        Me.SellingPriceTextBox.Size = New System.Drawing.Size(260, 50)
        Me.SellingPriceTextBox.TabIndex = 5
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.QuantityTextBox.BorderRadius = 3
        Me.QuantityTextBox.BorderThickness = 2
        Me.QuantityTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.QuantityTextBox.DefaultText = ""
        Me.QuantityTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.QuantityTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.QuantityTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.QuantityTextBox.DisabledState.Parent = Me.QuantityTextBox
        Me.QuantityTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.QuantityTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QuantityTextBox.FocusedState.Parent = Me.QuantityTextBox
        Me.QuantityTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.QuantityTextBox.HoverState.Parent = Me.QuantityTextBox
        Me.QuantityTextBox.Location = New System.Drawing.Point(113, 458)
        Me.QuantityTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.QuantityTextBox.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.QuantityTextBox.PlaceholderText = "Quantity"
        Me.QuantityTextBox.SelectedText = ""
        Me.QuantityTextBox.ShadowDecoration.Parent = Me.QuantityTextBox
        Me.QuantityTextBox.Size = New System.Drawing.Size(260, 50)
        Me.QuantityTextBox.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(391, 204)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(784, 395)
        Me.DataGridView1.TabIndex = 9
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView1.ThemeStyle.HeaderStyle.Height = 30
        Me.DataGridView1.ThemeStyle.ReadOnly = True
        Me.DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "MedicineID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 101
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "MedicineName"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Buying Price"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 107
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Selling Price"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 104
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Quantity"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 86
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Expiry Date"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 101
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "Company"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 91
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(526, 129)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 30)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "MEDICINE LIST"
        '
        'BackButton
        '
        Me.BackButton.BorderRadius = 10
        Me.BackButton.CheckedState.Parent = Me.BackButton
        Me.BackButton.CustomImages.Parent = Me.BackButton
        Me.BackButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BackButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BackButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BackButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BackButton.DisabledState.Parent = Me.BackButton
        Me.BackButton.FillColor = System.Drawing.Color.DarkSlateGray
        Me.BackButton.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.ForeColor = System.Drawing.Color.White
        Me.BackButton.HoverState.Parent = Me.BackButton
        Me.BackButton.Location = New System.Drawing.Point(815, 621)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.ShadowDecoration.Parent = Me.BackButton
        Me.BackButton.Size = New System.Drawing.Size(129, 45)
        Me.BackButton.TabIndex = 13
        Me.BackButton.Text = "BACK"
        '
        'ExitButton
        '
        Me.ExitButton.BorderRadius = 10
        Me.ExitButton.CheckedState.Parent = Me.ExitButton
        Me.ExitButton.CustomImages.Parent = Me.ExitButton
        Me.ExitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ExitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ExitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ExitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ExitButton.DisabledState.Parent = Me.ExitButton
        Me.ExitButton.FillColor = System.Drawing.Color.Brown
        Me.ExitButton.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.ForeColor = System.Drawing.Color.White
        Me.ExitButton.HoverState.Parent = Me.ExitButton
        Me.ExitButton.Location = New System.Drawing.Point(983, 621)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.ShadowDecoration.Parent = Me.ExitButton
        Me.ExitButton.Size = New System.Drawing.Size(131, 45)
        Me.ExitButton.TabIndex = 14
        Me.ExitButton.Text = "EXIT"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SpringGreen
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 719)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1187, 30)
        Me.Panel2.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label4.Location = New System.Drawing.Point(420, 9)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(361, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "EQUATOR PHARMACY MANAGEMENT SYSTEM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(114, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Medicine Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(116, 545)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 20)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Medicine Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(116, 433)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 20)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Quantity"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(114, 355)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 20)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Selling Price"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(114, 273)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 20)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Buying Price"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SearchTextBox.BorderRadius = 3
        Me.SearchTextBox.BorderThickness = 2
        Me.SearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchTextBox.DefaultText = ""
        Me.SearchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SearchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SearchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SearchTextBox.DisabledState.Parent = Me.SearchTextBox
        Me.SearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchTextBox.FocusedState.Parent = Me.SearchTextBox
        Me.SearchTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SearchTextBox.HoverState.Parent = Me.SearchTextBox
        Me.SearchTextBox.Location = New System.Drawing.Point(858, 147)
        Me.SearchTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchTextBox.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.SearchTextBox.PlaceholderText = "Search"
        Me.SearchTextBox.SelectedText = ""
        Me.SearchTextBox.ShadowDecoration.Parent = Me.SearchTextBox
        Me.SearchTextBox.Size = New System.Drawing.Size(275, 50)
        Me.SearchTextBox.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(773, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 25)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Search"
        '
        'ClearButton
        '
        Me.ClearButton.BorderRadius = 10
        Me.ClearButton.CheckedState.Parent = Me.ClearButton
        Me.ClearButton.CustomImages.Parent = Me.ClearButton
        Me.ClearButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ClearButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ClearButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ClearButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ClearButton.DisabledState.Parent = Me.ClearButton
        Me.ClearButton.FillColor = System.Drawing.Color.Tomato
        Me.ClearButton.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.ForeColor = System.Drawing.Color.White
        Me.ClearButton.HoverState.Parent = Me.ClearButton
        Me.ClearButton.Location = New System.Drawing.Point(290, 659)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.ShadowDecoration.Parent = Me.ClearButton
        Me.ClearButton.Size = New System.Drawing.Size(104, 45)
        Me.ClearButton.TabIndex = 61
        Me.ClearButton.Text = "CLEAR"
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.SystemColors.Control
        Me.DeleteButton.BorderRadius = 10
        Me.DeleteButton.CheckedState.Parent = Me.DeleteButton
        Me.DeleteButton.CustomImages.Parent = Me.DeleteButton
        Me.DeleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.DeleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.DeleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DeleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DeleteButton.DisabledState.Parent = Me.DeleteButton
        Me.DeleteButton.FillColor = System.Drawing.Color.Brown
        Me.DeleteButton.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.ForeColor = System.Drawing.Color.White
        Me.DeleteButton.HoverState.Parent = Me.DeleteButton
        Me.DeleteButton.Location = New System.Drawing.Point(402, 659)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.ShadowDecoration.Parent = Me.DeleteButton
        Me.DeleteButton.Size = New System.Drawing.Size(112, 45)
        Me.DeleteButton.TabIndex = 60
        Me.DeleteButton.Text = "DELETE"
        '
        'EditButton
        '
        Me.EditButton.BorderRadius = 10
        Me.EditButton.CheckedState.Parent = Me.EditButton
        Me.EditButton.CustomImages.Parent = Me.EditButton
        Me.EditButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.EditButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.EditButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.EditButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.EditButton.DisabledState.Parent = Me.EditButton
        Me.EditButton.FillColor = System.Drawing.Color.OrangeRed
        Me.EditButton.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditButton.ForeColor = System.Drawing.Color.White
        Me.EditButton.HoverState.Parent = Me.EditButton
        Me.EditButton.Location = New System.Drawing.Point(199, 659)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.ShadowDecoration.Parent = Me.EditButton
        Me.EditButton.Size = New System.Drawing.Size(81, 45)
        Me.EditButton.TabIndex = 59
        Me.EditButton.Text = "EDIT"
        '
        'AddButton
        '
        Me.AddButton.BorderRadius = 10
        Me.AddButton.CheckedState.Parent = Me.AddButton
        Me.AddButton.CustomImages.Parent = Me.AddButton
        Me.AddButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddButton.DisabledState.Parent = Me.AddButton
        Me.AddButton.FillColor = System.Drawing.Color.DarkSlateGray
        Me.AddButton.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.ForeColor = System.Drawing.Color.White
        Me.AddButton.HoverState.Parent = Me.AddButton
        Me.AddButton.Location = New System.Drawing.Point(111, 659)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.ShadowDecoration.Parent = Me.AddButton
        Me.AddButton.Size = New System.Drawing.Size(81, 45)
        Me.AddButton.TabIndex = 58
        Me.AddButton.Text = "ADD"
        '
        'MedDateTimePicker
        '
        Me.MedDateTimePicker.Checked = True
        Me.MedDateTimePicker.CheckedState.Parent = Me.MedDateTimePicker
        Me.MedDateTimePicker.FillColor = System.Drawing.Color.SpringGreen
        Me.MedDateTimePicker.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.MedDateTimePicker.HoverState.Parent = Me.MedDateTimePicker
        Me.MedDateTimePicker.Location = New System.Drawing.Point(113, 543)
        Me.MedDateTimePicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.MedDateTimePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.MedDateTimePicker.Name = "MedDateTimePicker"
        Me.MedDateTimePicker.ShadowDecoration.Parent = Me.MedDateTimePicker
        Me.MedDateTimePicker.Size = New System.Drawing.Size(260, 36)
        Me.MedDateTimePicker.TabIndex = 63
        Me.MedDateTimePicker.Value = New Date(2021, 11, 19, 18, 5, 32, 2)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(869, 114)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 17)
        Me.Label13.TabIndex = 64
        Me.Label13.Text = "Connection Status"
        '
        'ConnectionLabel
        '
        Me.ConnectionLabel.AutoSize = True
        Me.ConnectionLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConnectionLabel.Location = New System.Drawing.Point(1002, 114)
        Me.ConnectionLabel.Name = "ConnectionLabel"
        Me.ConnectionLabel.Size = New System.Drawing.Size(0, 17)
        Me.ConnectionLabel.TabIndex = 65
        '
        'MedIDTextBox
        '
        Me.MedIDTextBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MedIDTextBox.BorderRadius = 3
        Me.MedIDTextBox.BorderThickness = 2
        Me.MedIDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MedIDTextBox.DefaultText = ""
        Me.MedIDTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.MedIDTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.MedIDTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.MedIDTextBox.DisabledState.Parent = Me.MedIDTextBox
        Me.MedIDTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.MedIDTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MedIDTextBox.FocusedState.Parent = Me.MedIDTextBox
        Me.MedIDTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedIDTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MedIDTextBox.HoverState.Parent = Me.MedIDTextBox
        Me.MedIDTextBox.Location = New System.Drawing.Point(111, 141)
        Me.MedIDTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MedIDTextBox.Name = "MedIDTextBox"
        Me.MedIDTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MedIDTextBox.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.MedIDTextBox.PlaceholderText = "Medicine ID"
        Me.MedIDTextBox.SelectedText = ""
        Me.MedIDTextBox.ShadowDecoration.Parent = Me.MedIDTextBox
        Me.MedIDTextBox.Size = New System.Drawing.Size(260, 42)
        Me.MedIDTextBox.TabIndex = 66
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(114, 114)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 20)
        Me.Label14.TabIndex = 67
        Me.Label14.Text = "Medicine ID"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(116, 519)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 20)
        Me.Label15.TabIndex = 68
        Me.Label15.Text = "Expiry Date"
        '
        'CompanyComboBox
        '
        Me.CompanyComboBox.AutoCompleteCustomSource.AddRange(New String() {"GlaxoSmith Klin", "Cosmos", "Beta Health Care"})
        Me.CompanyComboBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompanyComboBox.FormattingEnabled = True
        Me.CompanyComboBox.Location = New System.Drawing.Point(113, 599)
        Me.CompanyComboBox.Name = "CompanyComboBox"
        Me.CompanyComboBox.Size = New System.Drawing.Size(260, 29)
        Me.CompanyComboBox.TabIndex = 70
        Me.CompanyComboBox.Text = "Select Company"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkMagenta
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Controls.Add(Me.ValidityButton)
        Me.Panel5.Controls.Add(Me.SupplierButton)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.BillingButton)
        Me.Panel5.Controls.Add(Me.MedicineButton)
        Me.Panel5.Controls.Add(Me.AgentButton)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Controls.Add(Me.Label19)
        Me.Panel5.Controls.Add(Me.Label20)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 102)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(97, 617)
        Me.Panel5.TabIndex = 93
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.Window
        Me.Label16.Location = New System.Drawing.Point(6, 466)
        Me.Label16.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 21)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Validity"
        '
        'ValidityButton
        '
        Me.ValidityButton.BackgroundImage = CType(resources.GetObject("ValidityButton.BackgroundImage"), System.Drawing.Image)
        Me.ValidityButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ValidityButton.CheckedState.Parent = Me.ValidityButton
        Me.ValidityButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ValidityButton.CustomImages.Parent = Me.ValidityButton
        Me.ValidityButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ValidityButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ValidityButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ValidityButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ValidityButton.DisabledState.Parent = Me.ValidityButton
        Me.ValidityButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ValidityButton.ForeColor = System.Drawing.Color.White
        Me.ValidityButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ValidityButton.HoverState.Parent = Me.ValidityButton
        Me.ValidityButton.Image = CType(resources.GetObject("ValidityButton.Image"), System.Drawing.Image)
        Me.ValidityButton.ImageSize = New System.Drawing.Size(70, 70)
        Me.ValidityButton.Location = New System.Drawing.Point(9, 504)
        Me.ValidityButton.Name = "ValidityButton"
        Me.ValidityButton.ShadowDecoration.Parent = Me.ValidityButton
        Me.ValidityButton.Size = New System.Drawing.Size(70, 70)
        Me.ValidityButton.TabIndex = 26
        '
        'SupplierButton
        '
        Me.SupplierButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SupplierButton.CheckedState.Parent = Me.SupplierButton
        Me.SupplierButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SupplierButton.CustomImages.Parent = Me.SupplierButton
        Me.SupplierButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.SupplierButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.SupplierButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.SupplierButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SupplierButton.DisabledState.Parent = Me.SupplierButton
        Me.SupplierButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SupplierButton.ForeColor = System.Drawing.Color.White
        Me.SupplierButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SupplierButton.HoverState.Parent = Me.SupplierButton
        Me.SupplierButton.Image = CType(resources.GetObject("SupplierButton.Image"), System.Drawing.Image)
        Me.SupplierButton.ImageSize = New System.Drawing.Size(80, 80)
        Me.SupplierButton.Location = New System.Drawing.Point(9, 262)
        Me.SupplierButton.Name = "SupplierButton"
        Me.SupplierButton.ShadowDecoration.Parent = Me.SupplierButton
        Me.SupplierButton.Size = New System.Drawing.Size(70, 70)
        Me.SupplierButton.TabIndex = 36
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.Window
        Me.Label17.Location = New System.Drawing.Point(6, -1)
        Me.Label17.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 21)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Medicine"
        '
        'BillingButton
        '
        Me.BillingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BillingButton.CheckedState.Parent = Me.BillingButton
        Me.BillingButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BillingButton.CustomImages.Parent = Me.BillingButton
        Me.BillingButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BillingButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BillingButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BillingButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BillingButton.DisabledState.Parent = Me.BillingButton
        Me.BillingButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BillingButton.ForeColor = System.Drawing.Color.White
        Me.BillingButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BillingButton.HoverState.Parent = Me.BillingButton
        Me.BillingButton.Image = CType(resources.GetObject("BillingButton.Image"), System.Drawing.Image)
        Me.BillingButton.ImageSize = New System.Drawing.Size(70, 70)
        Me.BillingButton.Location = New System.Drawing.Point(9, 383)
        Me.BillingButton.Name = "BillingButton"
        Me.BillingButton.ShadowDecoration.Parent = Me.BillingButton
        Me.BillingButton.Size = New System.Drawing.Size(70, 70)
        Me.BillingButton.TabIndex = 33
        '
        'MedicineButton
        '
        Me.MedicineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MedicineButton.CheckedState.Parent = Me.MedicineButton
        Me.MedicineButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MedicineButton.CustomImages.Parent = Me.MedicineButton
        Me.MedicineButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.MedicineButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.MedicineButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.MedicineButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.MedicineButton.DisabledState.Parent = Me.MedicineButton
        Me.MedicineButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedicineButton.ForeColor = System.Drawing.Color.White
        Me.MedicineButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MedicineButton.HoverState.Parent = Me.MedicineButton
        Me.MedicineButton.Image = CType(resources.GetObject("MedicineButton.Image"), System.Drawing.Image)
        Me.MedicineButton.ImageSize = New System.Drawing.Size(70, 70)
        Me.MedicineButton.Location = New System.Drawing.Point(10, 27)
        Me.MedicineButton.Name = "MedicineButton"
        Me.MedicineButton.ShadowDecoration.Parent = Me.MedicineButton
        Me.MedicineButton.Size = New System.Drawing.Size(70, 70)
        Me.MedicineButton.TabIndex = 35
        '
        'AgentButton
        '
        Me.AgentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AgentButton.CheckedState.Parent = Me.AgentButton
        Me.AgentButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AgentButton.CustomImages.Parent = Me.AgentButton
        Me.AgentButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AgentButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AgentButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AgentButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AgentButton.DisabledState.Parent = Me.AgentButton
        Me.AgentButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AgentButton.ForeColor = System.Drawing.Color.White
        Me.AgentButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AgentButton.HoverState.Parent = Me.AgentButton
        Me.AgentButton.Image = CType(resources.GetObject("AgentButton.Image"), System.Drawing.Image)
        Me.AgentButton.ImageSize = New System.Drawing.Size(70, 70)
        Me.AgentButton.Location = New System.Drawing.Point(10, 146)
        Me.AgentButton.Name = "AgentButton"
        Me.AgentButton.ShadowDecoration.Parent = Me.AgentButton
        Me.AgentButton.Size = New System.Drawing.Size(70, 70)
        Me.AgentButton.TabIndex = 34
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.Window
        Me.Label18.Location = New System.Drawing.Point(8, 348)
        Me.Label18.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 21)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Billing"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.Window
        Me.Label19.Location = New System.Drawing.Point(8, 111)
        Me.Label19.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 21)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Agent"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.Window
        Me.Label20.Location = New System.Drawing.Point(8, 229)
        Me.Label20.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 21)
        Me.Label20.TabIndex = 23
        Me.Label20.Text = "Supplier"
        '
        'MedicineForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1187, 749)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.CompanyComboBox)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.MedIDTextBox)
        Me.Controls.Add(Me.ConnectionLabel)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.MedDateTimePicker)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.SellingPriceTextBox)
        Me.Controls.Add(Me.BuyingPriceTextBox)
        Me.Controls.Add(Me.MedicineNameTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MedicineForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medicine"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents MedicineNameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BuyingPriceTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SellingPriceTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents QuantityTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents BackButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ExitButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents SearchTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ClearButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DeleteButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents EditButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AddButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents MedDateTimePicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents ConnectionLabel As Label
    Friend WithEvents MedIDTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Label15 As Label
    Friend WithEvents CompanyComboBox As ComboBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents ValidityButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SupplierButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label17 As Label
    Friend WithEvents BillingButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents MedicineButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AgentButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
End Class
