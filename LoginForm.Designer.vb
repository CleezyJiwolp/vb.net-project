<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Me.txtUsername = New system.Windows.Forms.TextBox()
        Me.txtPassword = New system.Windows.Forms.TextBox()
        Me.cmbRole = New system.Windows.Forms.ComboBox()
        Me.btnLogin = New system.Windows.Forms.Button()
        Me.linkRegister = New system.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New system.Drawing.Font("Segoe UI", 16.0!, system.Drawing.FontStyle.Bold, system.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New system.Drawing.Point(120, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New system.Drawing.Size(123, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New system.Drawing.Point(30, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New system.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New system.Drawing.Point(30, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New system.Drawing.Size(60, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New system.Drawing.Point(30, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New system.Drawing.Size(66, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Select Role:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New system.Drawing.Point(120, 77)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New system.Drawing.Size(180, 23)
        Me.txtUsername.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.Location = New system.Drawing.Point(120, 117)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New system.Drawing.Size(180, 23)
        Me.txtPassword.TabIndex = 5
        '
        'cmbRole
        '
        Me.cmbRole.DropDownStyle = system.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRole.FormattingEnabled = True
        Me.cmbRole.Location = New system.Drawing.Point(120, 157)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New system.Drawing.Size(180, 23)
        Me.cmbRole.TabIndex = 6
        '
        'btnLogin
        '
        Me.btnLogin.Location = New system.Drawing.Point(120, 200)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New system.Drawing.Size(100, 30)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'linkRegister
        '
        Me.linkRegister.AutoSize = True
        Me.linkRegister.Location = New system.Drawing.Point(120, 245)
        Me.linkRegister.Name = "linkRegister"
        Me.linkRegister.Size = New system.Drawing.Size(163, 15)
        Me.linkRegister.TabIndex = 8
        Me.linkRegister.TabStop = True
        Me.linkRegister.Text = "Don't have an account? Register"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New system.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = system.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New system.Drawing.Size(380, 280)
        Me.Controls.Add(Me.linkRegister)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.cmbRole)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = system.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.StartPosition = system.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents linkRegister As LinkLabel
End Class
