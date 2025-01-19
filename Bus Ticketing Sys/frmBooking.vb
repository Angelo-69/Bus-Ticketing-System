Public Class frmBooking
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim result As DialogResult = MessageBox.Show("All of the user input will be cleared", "Confirm", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            rbOneWay.Checked = True
            cbxTo.SelectedIndex = -1
            dtpDeparture.ResetText()
            dtpReturn.ResetText()
            txtPassenger.Text = 0
            Me.Hide()
            frmHome.Show()
            For Each control1 In frmOrdinaryBus.Controls.OfType(Of Button)
                If control1.BackColor = Color.Green Then
                    control1.Enabled = False
                    control1.BackColor = Color.Orange
                End If
            Next
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If cbxTo.Text.Length = 0 Or dtpDeparture.Value < DateTime.Now.ToShortDateString Or txtPassenger.Text.Length = 0 Or txtPassenger.Text < 1 Then
            MsgBox("Please provide a valid information!", MsgBoxStyle.OkOnly, "Invalid Input")
        Else
            If cbxTo.SelectedIndex = 0 Then
                frmBusType.lblOrdinaryRate.Text = 712.89
                frmBusType.lblAirconRate.Text = 791.31
                frmBusType.lblDeluxeRate.Text = 917.92
            ElseIf cbxTo.SelectedIndex = 1 Then
                frmBusType.lblOrdinaryRate.Text = 578.59
                frmBusType.lblAirconRate.Text = 642.14
                frmBusType.lblDeluxeRate.Text = 744.88
            ElseIf cbxTo.SelectedIndex = 2 Then
                frmBusType.lblOrdinaryRate.Text = 720.99
                frmBusType.lblAirconRate.Text = 800.29
                frmBusType.lblDeluxeRate.Text = 928.33
            ElseIf cbxTo.SelectedIndex = 3 Then
                frmBusType.lblOrdinaryRate.Text = 801.99
                frmBusType.lblAirconRate.Text = 890.21
                frmBusType.lblDeluxeRate.Text = 1032.64
            ElseIf cbxTo.SelectedIndex = 4 Then
                frmBusType.lblOrdinaryRate.Text = 1705.24
                frmBusType.lblAirconRate.Text = 1892.82
                frmBusType.lblDeluxeRate.Text = 2195.67
            ElseIf cbxTo.SelectedIndex = 5 Then
                frmBusType.lblOrdinaryRate.Text = 2613.04
                frmBusType.lblAirconRate.Text = 2900.47
                frmBusType.lblDeluxeRate.Text = 3364.55
            End If
            Me.Hide()
            frmBusType.Show()
        End If
    End Sub

    Private Sub rbOneWay_CheckedChanged(sender As Object, e As EventArgs) Handles rbOneWay.CheckedChanged
        If rbOneWay.Checked = True Then
            cbxReturn.Enabled = False
            cbxReturn.SelectedIndex = -1
            dtpReturn.Enabled = False
        End If
    End Sub

    Private Sub rbRoundTrip_CheckedChanged(sender As Object, e As EventArgs) Handles rbRoundTrip.CheckedChanged
        If rbRoundTrip.Checked = True Then
            cbxReturn.Enabled = True
            dtpReturn.Enabled = True
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassenger.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Numbers Only! Press 'Enter' to continue", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        'If txtPassenger.Text > 49 Then
        '    If e.KeyChar <> ControlChars.Back Then
        '        e.Handled = True
        '        MessageBox.Show("Maximum of 49 passengers only!")
        '    End If
        'End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        txtPassenger.Text += 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtPassenger.Text -= 1
    End Sub

    Public Function returnDate()
        Dim rturn As String = ""
        If rbRoundTrip.Checked Then
            rturn = dtpReturn.Text
        Else
            rturn = "---"
        End If
        Return rturn
    End Function

    Public Function returnPlace()
        Dim rturn As String = ""
        If rbRoundTrip.Checked Then
            rturn = cbxReturn.Text
        Else
            rturn = "---"
        End If
        Return rturn
    End Function

    Private Sub dtpReturn_ValueChanged(sender As Object, e As EventArgs) Handles dtpReturn.ValueChanged
        If dtpReturn.Value < dtpDeparture.Value Then
            btnSearch.Enabled = False
        Else
            btnSearch.Enabled = True
        End If
    End Sub

    Private Sub txtPassenger_TextChanged(sender As Object, e As EventArgs) Handles txtPassenger.TextChanged

    End Sub
End Class