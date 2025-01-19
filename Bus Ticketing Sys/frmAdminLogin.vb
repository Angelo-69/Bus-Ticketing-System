Public Class frmAdminLogin
    Private Sub frmAdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (txtUsername.Text = "admin" And txtPassword.Text = "admin") Then
            txtUsername.Clear()
            txtPassword.Clear()
            Me.Hide()
            frmDashboard.Show()
        Else
            MsgBox("Wrong username or password!", MsgBoxStyle.OkOnly, "Invalid Input")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtUsername.Clear()
        txtPassword.Clear()
        Me.Hide()
        frmHome.Show()
    End Sub

End Class