<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExpiredMedicinesReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExpiredMedicinesReport))
        Me.DeleteButton = New Guna.UI2.WinForms.Guna2Button()
        Me.DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ShowDelButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ExitButton = New Guna.UI2.WinForms.Guna2Button()
        Me.BackButton = New Guna.UI2.WinForms.Guna2Button()
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'DeleteButton
        '
        Me.DeleteButton.CheckedState.Parent = Me.DeleteButton
        Me.DeleteButton.CustomImages.Parent = Me.DeleteButton
        Me.DeleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.DeleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.DeleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DeleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DeleteButton.DisabledState.Parent = Me.DeleteButton
        Me.DeleteButton.FillColor = System.Drawing.Color.Brown
        Me.DeleteButton.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.ForeColor = System.Drawing.Color.White
        Me.DeleteButton.HoverState.Parent = Me.DeleteButton
        Me.DeleteButton.Location = New System.Drawing.Point(126, 247)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.ShadowDecoration.Parent = Me.DeleteButton
        Me.DeleteButton.Size = New System.Drawing.Size(180, 45)
        Me.DeleteButton.TabIndex = 0
        Me.DeleteButton.Text = "DELETE"
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
        Me.DataGridView1.Location = New System.Drawing.Point(334, 130)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(841, 395)
        Me.DataGridView1.TabIndex = 11
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SpringGreen
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1187, 102)
        Me.Panel3.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label7.Location = New System.Drawing.Point(434, 61)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(319, 30)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "EXPIRED MEDICINES IN STOCK"
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
        'ShowDelButton
        '
        Me.ShowDelButton.CheckedState.Parent = Me.ShowDelButton
        Me.ShowDelButton.CustomImages.Parent = Me.ShowDelButton
        Me.ShowDelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ShowDelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ShowDelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ShowDelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ShowDelButton.DisabledState.Parent = Me.ShowDelButton
        Me.ShowDelButton.FillColor = System.Drawing.Color.Brown
        Me.ShowDelButton.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowDelButton.ForeColor = System.Drawing.Color.White
        Me.ShowDelButton.HoverState.Parent = Me.ShowDelButton
        Me.ShowDelButton.Location = New System.Drawing.Point(126, 573)
        Me.ShowDelButton.Name = "ShowDelButton"
        Me.ShowDelButton.ShadowDecoration.Parent = Me.ShowDelButton
        Me.ShowDelButton.Size = New System.Drawing.Size(227, 45)
        Me.ShowDelButton.TabIndex = 76
        Me.ShowDelButton.Text = "Show Deleted Medicines"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SpringGreen
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 719)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1187, 30)
        Me.Panel2.TabIndex = 77
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(134, 540)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 17)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "See All Deleted Expired Medicines"
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
        Me.ExitButton.Location = New System.Drawing.Point(1016, 606)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.ShadowDecoration.Parent = Me.ExitButton
        Me.ExitButton.Size = New System.Drawing.Size(131, 45)
        Me.ExitButton.TabIndex = 39
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
        Me.BackButton.Location = New System.Drawing.Point(848, 606)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.ShadowDecoration.Parent = Me.BackButton
        Me.BackButton.Size = New System.Drawing.Size(129, 45)
        Me.BackButton.TabIndex = 38
        Me.BackButton.Text = "BACK"
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
        Me.Panel5.Location = New System.Drawing.Point(0, 102)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(97, 617)
        Me.Panel5.TabIndex = 93
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
        'ExpiredMedicinesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1187, 749)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ShowDelButton)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DeleteButton)
        Me.Name = "ExpiredMedicinesReport"
        Me.Text = "Expired Medicines In Stock"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DeleteButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ShowDelButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ExitButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BackButton As Guna.UI2.WinForms.Guna2Button
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
