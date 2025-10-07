<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterForm
    Inherits system.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <system.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As system.ComponentModel.IContainer

    <system.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New system.Windows.Forms.Label()
        Me.Label2 = New system.Windows.Forms.Label()
        Me.Label3 = New system.Windows.Forms.Label()
        Me.Label4 = New system.Windows.Forms.Label()
        Me.Label5 = New system.Windows.Forms.Label()
        Me.txtUsername = New system.Windows.Forms.TextBox()
        Me.txtPassword = New system.Windows.Forms.TextBox()
        Me.txtConfirm = New system.Windows.Forms.TextBox()
        Me.cmbRole = New system.Windows.Forms.ComboBox()
        Me.btnRegister = New system.Windows.Forms.Button()
        Me.linkBack = New system.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1 - Title
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New system.Drawing.Font("Segoe UI", 16.0!, system.Drawing.FontStyle.Bold, system.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New system.Drawing.Point(85, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New system.Drawing.Size(210, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Register New User"
        '
        'Label2 - Username
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New system.Drawing.Point(30, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New system.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username:"
        '
        'Label3 - Password
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New system.Drawing.Point(30, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New system.Drawing.Size(60, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password:"
        '
        'Label4 - Confirm Password
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New system.Drawing.Point(30, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New system.Drawing.Size(108, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Confirm Password:"
        '
        'Label5 - Role
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New system.Drawing.Point(30, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New system.Drawing.Size(34, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Role:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New system.Drawing.Point(150, 77)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New system.Drawing.Size(180, 23)
        Me.txtUsername.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.Location = New system.Drawing.Point(150, 117)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New system.Drawing.Size(180, 23)
        Me.txtPassword.TabIndex = 5
        '
        'txtConfirm
        '
        Me.txtConfirm.Location = New system.Drawing.Point(150, 157)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirm.Size = New system.Drawing.Size(180, 23)
        Me.txtConfirm.TabIndex = 6
        '
        'cmbRole
        '
        Me.cmbRole.DropDownStyle = system.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRole.FormattingEnabled = True
        Me.cmbRole.Location = New system.Drawing.Point(150, 197)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New system.Drawing.Size(180, 23)
        Me.cmbRole.TabIndex = 10
        '
        'btnRegister
        '
        Me.btnRegister.Location = New system.Drawing.Point(150, 240)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New system.Drawing.Size(100, 30)
        Me.btnRegister.TabIndex = 7
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'linkBack
        '
        Me.linkBack.AutoSize = True
        Me.linkBack.Location = New system.Drawing.Point(150, 280)
        Me.linkBack.Name = "linkBack"
        Me.linkBack.Size = New system.Drawing.Size(80, 15)
        Me.linkBack.TabIndex = 8
        Me.linkBack.TabStop = True
        Me.linkBack.Text = "Back to Login"
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New system.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = system.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New system.Drawing.Size(380, 320)
        Me.Controls.Add(Me.cmbRole)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.linkBack)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtConfirm)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = system.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RegisterForm"
        Me.StartPosition = system.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtConfirm As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents linkBack As LinkLabel
    Friend WithEvents cmbRole As ComboBox
End Class
