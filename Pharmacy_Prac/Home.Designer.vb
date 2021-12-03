<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ExitButton = New Guna.UI2.WinForms.Guna2Button()
        Me.SupplierButton = New Guna.UI2.WinForms.Guna2Button()
        Me.MedicineButton = New Guna.UI2.WinForms.Guna2Button()
        Me.AgentButton = New Guna.UI2.WinForms.Guna2Button()
        Me.BillingButton = New Guna.UI2.WinForms.Guna2Button()
        Me.ValidityButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SpringGreen
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(627, 102)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(247, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "HOME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(127, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 41)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "EQUATOR PHARMACY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(129, 121)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 30)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Medicine"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label4.Location = New System.Drawing.Point(375, 121)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 30)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Agent"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label5.Location = New System.Drawing.Point(129, 249)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 30)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Supplier"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label6.Location = New System.Drawing.Point(129, 379)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 30)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Billing"
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
        Me.ExitButton.Location = New System.Drawing.Point(273, 506)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.ShadowDecoration.Parent = Me.ExitButton
        Me.ExitButton.Size = New System.Drawing.Size(131, 45)
        Me.ExitButton.TabIndex = 15
        Me.ExitButton.Text = "EXIT"
        '
        'SupplierButton
        '
        Me.SupplierButton.BackgroundImage = CType(resources.GetObject("SupplierButton.BackgroundImage"), System.Drawing.Image)
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
        Me.SupplierButton.ImageSize = New System.Drawing.Size(100, 100)
        Me.SupplierButton.Location = New System.Drawing.Point(132, 292)
        Me.SupplierButton.Name = "SupplierButton"
        Me.SupplierButton.ShadowDecoration.Parent = Me.SupplierButton
        Me.SupplierButton.Size = New System.Drawing.Size(95, 71)
        Me.SupplierButton.TabIndex = 24
        '
        'MedicineButton
        '
        Me.MedicineButton.BackgroundImage = CType(resources.GetObject("MedicineButton.BackgroundImage"), System.Drawing.Image)
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
        Me.MedicineButton.Location = New System.Drawing.Point(134, 164)
        Me.MedicineButton.Name = "MedicineButton"
        Me.MedicineButton.ShadowDecoration.Parent = Me.MedicineButton
        Me.MedicineButton.Size = New System.Drawing.Size(95, 71)
        Me.MedicineButton.TabIndex = 23
        '
        'AgentButton
        '
        Me.AgentButton.BackgroundImage = CType(resources.GetObject("AgentButton.BackgroundImage"), System.Drawing.Image)
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
        Me.AgentButton.Location = New System.Drawing.Point(378, 164)
        Me.AgentButton.Name = "AgentButton"
        Me.AgentButton.ShadowDecoration.Parent = Me.AgentButton
        Me.AgentButton.Size = New System.Drawing.Size(95, 71)
        Me.AgentButton.TabIndex = 22
        '
        'BillingButton
        '
        Me.BillingButton.BackgroundImage = CType(resources.GetObject("BillingButton.BackgroundImage"), System.Drawing.Image)
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
        Me.BillingButton.ImageSize = New System.Drawing.Size(100, 100)
        Me.BillingButton.Location = New System.Drawing.Point(132, 421)
        Me.BillingButton.Name = "BillingButton"
        Me.BillingButton.ShadowDecoration.Parent = Me.BillingButton
        Me.BillingButton.Size = New System.Drawing.Size(95, 71)
        Me.BillingButton.TabIndex = 21
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
        Me.ValidityButton.ImageSize = New System.Drawing.Size(100, 100)
        Me.ValidityButton.Location = New System.Drawing.Point(378, 292)
        Me.ValidityButton.Name = "ValidityButton"
        Me.ValidityButton.ShadowDecoration.Parent = Me.ValidityButton
        Me.ValidityButton.Size = New System.Drawing.Size(95, 71)
        Me.ValidityButton.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label7.Location = New System.Drawing.Point(373, 249)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 30)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Validity Check"
        '
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 578)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ValidityButton)
        Me.Controls.Add(Me.SupplierButton)
        Me.Controls.Add(Me.MedicineButton)
        Me.Controls.Add(Me.AgentButton)
        Me.Controls.Add(Me.BillingButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "HomeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ExitButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BillingButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AgentButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents MedicineButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SupplierButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ValidityButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label7 As Label
End Class
