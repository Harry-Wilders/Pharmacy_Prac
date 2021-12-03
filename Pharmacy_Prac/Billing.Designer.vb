<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BillingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BillingForm))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ExitButton = New Guna.UI2.WinForms.Guna2Button()
        Me.BackButton = New Guna.UI2.WinForms.Guna2Button()
        Me.PrintButton = New Guna.UI2.WinForms.Guna2Button()
        Me.AddButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MedicineComboBox = New System.Windows.Forms.ComboBox()
        Me.AvalilableStockLabel = New System.Windows.Forms.Label()
        Me.QuantityTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ConnectionLabel = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.RemoveButton = New Guna.UI2.WinForms.Guna2Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ValidityButton = New Guna.UI2.WinForms.Guna2Button()
        Me.SupplierButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.BillingButton = New Guna.UI2.WinForms.Guna2Button()
        Me.MedicineButton = New Guna.UI2.WinForms.Guna2Button()
        Me.AgentButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SpringGreen
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 719)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1144, 30)
        Me.Panel2.TabIndex = 77
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
        Me.ExitButton.Location = New System.Drawing.Point(977, 605)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.ShadowDecoration.Parent = Me.ExitButton
        Me.ExitButton.Size = New System.Drawing.Size(131, 45)
        Me.ExitButton.TabIndex = 76
        Me.ExitButton.Text = "EXIT"
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
        Me.BackButton.Location = New System.Drawing.Point(812, 608)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.ShadowDecoration.Parent = Me.BackButton
        Me.BackButton.Size = New System.Drawing.Size(129, 45)
        Me.BackButton.TabIndex = 75
        Me.BackButton.Text = "BACK"
        '
        'PrintButton
        '
        Me.PrintButton.BorderRadius = 10
        Me.PrintButton.CheckedState.Parent = Me.PrintButton
        Me.PrintButton.CustomImages.Parent = Me.PrintButton
        Me.PrintButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.PrintButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.PrintButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.PrintButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.PrintButton.DisabledState.Parent = Me.PrintButton
        Me.PrintButton.FillColor = System.Drawing.Color.DarkSlateGray
        Me.PrintButton.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.ForeColor = System.Drawing.Color.White
        Me.PrintButton.HoverState.Parent = Me.PrintButton
        Me.PrintButton.Location = New System.Drawing.Point(646, 606)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.ShadowDecoration.Parent = Me.PrintButton
        Me.PrintButton.Size = New System.Drawing.Size(104, 45)
        Me.PrintButton.TabIndex = 73
        Me.PrintButton.Text = "PRINT"
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
        Me.AddButton.Location = New System.Drawing.Point(172, 318)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.ShadowDecoration.Parent = Me.AddButton
        Me.AddButton.Size = New System.Drawing.Size(172, 45)
        Me.AddButton.TabIndex = 72
        Me.AddButton.Text = "ADD TO BILL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(167, 147)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 30)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "BILLING FORM"
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(464, 147)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(668, 402)
        Me.DataGridView1.TabIndex = 68
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
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "MedicineName"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Quantity"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Unit Price"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Total Price"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label7.Location = New System.Drawing.Point(518, 50)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 30)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "BILLING"
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SpringGreen
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1144, 96)
        Me.Panel3.TabIndex = 58
        '
        'MedicineComboBox
        '
        Me.MedicineComboBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedicineComboBox.FormattingEnabled = True
        Me.MedicineComboBox.Location = New System.Drawing.Point(172, 184)
        Me.MedicineComboBox.Name = "MedicineComboBox"
        Me.MedicineComboBox.Size = New System.Drawing.Size(172, 29)
        Me.MedicineComboBox.TabIndex = 81
        Me.MedicineComboBox.Text = "Select Medicine"
        '
        'AvalilableStockLabel
        '
        Me.AvalilableStockLabel.AutoSize = True
        Me.AvalilableStockLabel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvalilableStockLabel.ForeColor = System.Drawing.Color.DarkGreen
        Me.AvalilableStockLabel.Location = New System.Drawing.Point(170, 216)
        Me.AvalilableStockLabel.Name = "AvalilableStockLabel"
        Me.AvalilableStockLabel.Size = New System.Drawing.Size(111, 20)
        Me.AvalilableStockLabel.TabIndex = 85
        Me.AvalilableStockLabel.Text = "Available Stock"
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
        Me.QuantityTextBox.Location = New System.Drawing.Point(172, 250)
        Me.QuantityTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.QuantityTextBox.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.QuantityTextBox.PlaceholderText = "Quantity"
        Me.QuantityTextBox.SelectedText = ""
        Me.QuantityTextBox.ShadowDecoration.Parent = Me.QuantityTextBox
        Me.QuantityTextBox.Size = New System.Drawing.Size(260, 50)
        Me.QuantityTextBox.TabIndex = 82
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(898, 110)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 17)
        Me.Label13.TabIndex = 86
        Me.Label13.Text = "Connection Status"
        '
        'ConnectionLabel
        '
        Me.ConnectionLabel.AutoSize = True
        Me.ConnectionLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConnectionLabel.Location = New System.Drawing.Point(1016, 109)
        Me.ConnectionLabel.Name = "ConnectionLabel"
        Me.ConnectionLabel.Size = New System.Drawing.Size(0, 17)
        Me.ConnectionLabel.TabIndex = 87
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.ForeColor = System.Drawing.Color.DarkGreen
        Me.TotalLabel.Location = New System.Drawing.Point(688, 573)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(42, 20)
        Me.TotalLabel.TabIndex = 88
        Me.TotalLabel.Text = "Total"
        '
        'RemoveButton
        '
        Me.RemoveButton.BorderRadius = 10
        Me.RemoveButton.CheckedState.Parent = Me.RemoveButton
        Me.RemoveButton.CustomImages.Parent = Me.RemoveButton
        Me.RemoveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.RemoveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.RemoveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.RemoveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.RemoveButton.DisabledState.Parent = Me.RemoveButton
        Me.RemoveButton.FillColor = System.Drawing.Color.Brown
        Me.RemoveButton.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveButton.ForeColor = System.Drawing.Color.White
        Me.RemoveButton.HoverState.Parent = Me.RemoveButton
        Me.RemoveButton.Location = New System.Drawing.Point(172, 411)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.ShadowDecoration.Parent = Me.RemoveButton
        Me.RemoveButton.Size = New System.Drawing.Size(172, 45)
        Me.RemoveButton.TabIndex = 89
        Me.RemoveButton.Text = "REMOVE"
        '
        'PrintDocument1
        '
        Me.PrintDocument1.OriginAtMargins = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkMagenta
        Me.Panel5.Controls.Add(Me.Label1)
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
        Me.Panel5.Location = New System.Drawing.Point(0, 96)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(97, 623)
        Me.Panel5.TabIndex = 91
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(6, 466)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 21)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Validity"
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
        'BillingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1144, 749)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.ConnectionLabel)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.AvalilableStockLabel)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.MedicineComboBox)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "BillingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Billing"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ExitButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BackButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PrintButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AddButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MedicineComboBox As ComboBox
    Friend WithEvents AvalilableStockLabel As Label
    Friend WithEvents QuantityTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ConnectionLabel As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents TotalLabel As Label
    Friend WithEvents RemoveButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
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
