Imports MySql.Data.MySqlClient

Public Class LoginForm
    Private conn As MySqlConnection

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Connection string for XAMPP MySQL
        Dim connString As String = "server=localhost;userid=root;password=;database=shop_db"
        conn = New MySqlConnection(connString)

        ' Fill role options
        cmbRole.Items.Clear()
        cmbRole.Items.Add("admin")
        cmbRole.Items.Add("user")
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Or cmbRole.SelectedIndex = -1 Then
            MessageBox.Show("Please enter username, password, and select role.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            conn.Open()
            Dim sql As String = "SELECT * FROM users WHERE username=@username AND password=@password AND role=@role"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@password", txtPassword.Text)
            cmd.Parameters.AddWithValue("@role", cmbRole.SelectedItem.ToString().ToLower())

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                Dim role As String = reader("role").ToString().ToLower()

                If role = "admin" Then
                    MessageBox.Show("Welcome Admin!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    FormProducts.Show()
                ElseIf role = "user" Then
                    MessageBox.Show("Welcome User!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    FormShoppingCart.Show()
                End If
                Me.Hide()
            Else
                MessageBox.Show("Invalid login credentials!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Link to Register Form
    Private Sub linkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkRegister.LinkClicked
        RegisterForm.Show()
        Me.Hide()
    End Sub
End Class
