<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UserNameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PasswordTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LoginButton = New Guna.UI2.WinForms.Guna2Button()
        Me.CancelButton = New Guna.UI2.WinForms.Guna2Button()
        Me.ClearButton = New Guna.UI2.WinForms.Guna2Button()
        Me.CheckBoxShowPassword = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(187, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 41)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Login"
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UserNameTextBox.BorderRadius = 3
        Me.UserNameTextBox.BorderThickness = 2
        Me.UserNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UserNameTextBox.DefaultText = ""
        Me.UserNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UserNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UserNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserNameTextBox.DisabledState.Parent = Me.UserNameTextBox
        Me.UserNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserNameTextBox.FocusedState.Parent = Me.UserNameTextBox
        Me.UserNameTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UserNameTextBox.HoverState.Parent = Me.UserNameTextBox
        Me.UserNameTextBox.Location = New System.Drawing.Point(82, 66)
        Me.UserNameTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UserNameTextBox.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.UserNameTextBox.PlaceholderText = "Username"
        Me.UserNameTextBox.SelectedText = ""
        Me.UserNameTextBox.ShadowDecoration.Parent = Me.UserNameTextBox
        Me.UserNameTextBox.Size = New System.Drawing.Size(308, 50)
        Me.UserNameTextBox.TabIndex = 2
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PasswordTextBox.BorderRadius = 3
        Me.PasswordTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.PasswordTextBox.BorderThickness = 2
        Me.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordTextBox.DefaultText = ""
        Me.PasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTextBox.DisabledState.Parent = Me.PasswordTextBox
        Me.PasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTextBox.FocusedState.Parent = Me.PasswordTextBox
        Me.PasswordTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PasswordTextBox.HoverState.Parent = Me.PasswordTextBox
        Me.PasswordTextBox.Location = New System.Drawing.Point(82, 136)
        Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.PasswordTextBox.PlaceholderText = "Password"
        Me.PasswordTextBox.SelectedText = ""
        Me.PasswordTextBox.ShadowDecoration.Parent = Me.PasswordTextBox
        Me.PasswordTextBox.Size = New System.Drawing.Size(308, 50)
        Me.PasswordTextBox.TabIndex = 3
        '
        'LoginButton
        '
        Me.LoginButton.BorderRadius = 10
        Me.LoginButton.CheckedState.Parent = Me.LoginButton
        Me.LoginButton.CustomImages.Parent = Me.LoginButton
        Me.LoginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.LoginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.LoginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.LoginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.LoginButton.DisabledState.Parent = Me.LoginButton
        Me.LoginButton.FillColor = System.Drawing.Color.DarkSlateGray
        Me.LoginButton.Font = New System.Drawing.Font("Segoe UI Semibold", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.ForeColor = System.Drawing.Color.White
        Me.LoginButton.HoverState.Parent = Me.LoginButton
        Me.LoginButton.Location = New System.Drawing.Point(82, 234)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.ShadowDecoration.Parent = Me.LoginButton
        Me.LoginButton.Size = New System.Drawing.Size(308, 51)
        Me.LoginButton.TabIndex = 5
        Me.LoginButton.Text = "Login"
        '
        'CancelButton
        '
        Me.CancelButton.BorderRadius = 10
        Me.CancelButton.CheckedState.Parent = Me.CancelButton
        Me.CancelButton.CustomImages.Parent = Me.CancelButton
        Me.CancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.CancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.CancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.CancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.CancelButton.DisabledState.Parent = Me.CancelButton
        Me.CancelButton.FillColor = System.Drawing.Color.Brown
        Me.CancelButton.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.ForeColor = System.Drawing.Color.White
        Me.CancelButton.HoverState.Parent = Me.CancelButton
        Me.CancelButton.Location = New System.Drawing.Point(256, 307)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.ShadowDecoration.Parent = Me.CancelButton
        Me.CancelButton.Size = New System.Drawing.Size(134, 45)
        Me.CancelButton.TabIndex = 7
        Me.CancelButton.Text = "Cancel"
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
        Me.ClearButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.ClearButton.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.ForeColor = System.Drawing.Color.White
        Me.ClearButton.HoverState.Parent = Me.ClearButton
        Me.ClearButton.Location = New System.Drawing.Point(82, 307)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.ShadowDecoration.Parent = Me.ClearButton
        Me.ClearButton.Size = New System.Drawing.Size(134, 45)
        Me.ClearButton.TabIndex = 8
        Me.ClearButton.Text = "Clear"
        '
        'CheckBoxShowPassword
        '
        Me.CheckBoxShowPassword.AutoSize = True
        Me.CheckBoxShowPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckBoxShowPassword.CheckedState.BorderRadius = 0
        Me.CheckBoxShowPassword.CheckedState.BorderThickness = 0
        Me.CheckBoxShowPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckBoxShowPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxShowPassword.Location = New System.Drawing.Point(252, 193)
        Me.CheckBoxShowPassword.Name = "CheckBoxShowPassword"
        Me.CheckBoxShowPassword.Size = New System.Drawing.Size(138, 25)
        Me.CheckBoxShowPassword.TabIndex = 9
        Me.CheckBoxShowPassword.Text = "Show Password"
        Me.CheckBoxShowPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CheckBoxShowPassword.UncheckedState.BorderRadius = 0
        Me.CheckBoxShowPassword.UncheckedState.BorderThickness = 0
        Me.CheckBoxShowPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SpringGreen
        Me.ClientSize = New System.Drawing.Size(505, 364)
        Me.Controls.Add(Me.CheckBoxShowPassword)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UserNameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents UserNameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PasswordTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LoginButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CancelButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ClearButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CheckBoxShowPassword As Guna.UI2.WinForms.Guna2CheckBox
End Class
