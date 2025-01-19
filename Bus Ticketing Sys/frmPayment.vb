Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class frmPayment
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim comm As OleDbCommand
    Public seats As String
    Private Sub Button50_MouseHover(sender As Object, e As EventArgs) Handles btnPay.MouseHover
        btnPay.BackColor = Color.DarkGreen
    End Sub

    Private Sub Button50_MouseLeave(sender As Object, e As EventArgs) Handles btnPay.MouseLeave
        btnPay.BackColor = Color.Navy
    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If GCash.Checked = True Or Maya.Checked = True Or OTC.Checked = True Then
            If lblBusType.Text = frmOrdinaryBus.lblBusType.Text Then

                For Each control1 In frmOrdinaryBus.Controls.OfType(Of Button)
                    If control1.BackColor = Color.Green Then
                        control1.Enabled = False
                        control1.BackColor = Color.Orange
                    End If
                Next

                PPD.Document = PD
                PPD.ShowDialog()

                connect()
                comm = New OleDbCommand
                comm.Connection = conn
                comm.CommandText = "Insert into busOrdinary values ('" & frmPassengerInfo.txtLastName.Text & "', '" & frmPassengerInfo.txtFirstName.Text & "', '" & frmPassengerInfo.txtContactNo.Text & "', '" & frmBooking.dtpDeparture.Text & "', '" & frmBooking.returnDate & "', '" & frmBooking.cbxTo.Text & "', '" & frmBooking.returnPlace & "', '" & seats & "', '" & lblSubtotal.Text & "')"
                comm.ExecuteNonQuery()
                frmOrdinaryDGV.populate1()

            ElseIf lblBusType.Text = frmAirconditionedBus.Label4.Text Then

                For Each control1 In frmAirconditionedBus.Controls.OfType(Of Button)
                    If control1.BackColor = Color.Green Then
                        control1.Enabled = False
                        control1.BackColor = Color.Orange
                    End If
                Next

                PPD.Document = PD
                PPD.ShowDialog()

                Dim comm As OleDbCommand
                connect()
                comm = New OleDbCommand
                comm.Connection = conn
                comm.CommandText = "Insert into busAirconditioned values ('" & frmPassengerInfo.txtLastName.Text & "', '" & frmPassengerInfo.txtFirstName.Text & "', '" & frmPassengerInfo.txtContactNo.Text & "', '" & frmBooking.dtpDeparture.Text & "', '" & frmBooking.returnDate & "', '" & frmBooking.cbxTo.Text & "', '" & frmBooking.returnPlace & "', '" & seats & "', '" & lblSubtotal.Text & "')"
                comm.ExecuteNonQuery()
                frmAirconditionedDGV.populate2()

            ElseIf lblBusType.Text = frmDeluxeBus.Label4.Text Then

                For Each control1 In frmDeluxeBus.Controls.OfType(Of Button)
                    If control1.BackColor = Color.Green Then
                        control1.Enabled = False
                        control1.BackColor = Color.Orange
                    End If
                Next

                PPD.Document = PD
                PPD.ShowDialog()

                Dim comm As OleDbCommand
                connect()
                comm = New OleDbCommand
                comm.Connection = conn
                comm.CommandText = "Insert into busDeluxe values ('" & frmPassengerInfo.txtLastName.Text & "', '" & frmPassengerInfo.txtFirstName.Text & "', '" & frmPassengerInfo.txtContactNo.Text & "', '" & frmBooking.dtpDeparture.Text & "', '" & frmBooking.returnDate & "', '" & frmBooking.cbxTo.Text & "', '" & frmBooking.returnPlace & "', '" & seats & "', '" & lblSubtotal.Text & "')"
                comm.ExecuteNonQuery()
                frmDeluxeDGV.populate3()

            End If

            frmPassengerInfo.txtFirstName.Clear()
            frmPassengerInfo.txtLastName.Clear()
            frmPassengerInfo.txtCity.Clear()
            frmPassengerInfo.txtContactNo.Clear()
            GCash.Checked = False
            Maya.Checked = False
            OTC.Checked = False
            frmBooking.rbOneWay.Checked = True
            frmBooking.cbxTo.SelectedIndex = -1
            frmBooking.dtpDeparture.ResetText()
            frmBooking.dtpReturn.ResetText()
            frmBooking.txtPassenger.Text = 0
            Me.Hide()
            frmHome.Show()

        Else
            MsgBox("Please provide a valid information!", MsgBoxStyle.OkOnly, "Invalid Input")
        End If
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        'Printed paper size
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, 265)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        'Fonts And Margin
        Dim f6 As New Font("Calibri", 6, FontStyle.Regular)
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        'Font allignment
        Dim right As New StringFormat
        Dim center As New StringFormat
        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center


        Dim line As String
        line = "---------------------------------------------------------------------------------"

        e.Graphics.DrawString("DDLV", f14, Brushes.Red, centermargin, 5, center)
        e.Graphics.DrawString("Avocado Street Pinalad Road Pasig City", f10, Brushes.Black, centermargin, 25, center)
        e.Graphics.DrawString("Cell No. +6380861453", f8, Brushes.Black, centermargin, 40, center)
        e.Graphics.DrawString("Date", f10, Brushes.Black, 0, 60)
        e.Graphics.DrawString(":", f10, Brushes.Black, 29, 60)
        e.Graphics.DrawString(DateAndTime.Now, f10, Brushes.Black, 35, 60)
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 75)

        e.Graphics.DrawString("Bus #:", f10, Brushes.Black, 0, 85)
        e.Graphics.DrawString(lblBusNo.Text, f10, Brushes.Black, 150, 85)
        e.Graphics.DrawString("Bus Type:", f10, Brushes.Black, 0, 100)
        e.Graphics.DrawString(lblBusType.Text, f10, Brushes.Black, 150, 100)

        e.Graphics.DrawString("Destination:", f10, Brushes.Black, 0, 115)
        e.Graphics.DrawString(lblTo.Text, f10, Brushes.Black, 150, 115)
        e.Graphics.DrawString("Return To:", f10, Brushes.Black, 0, 129)
        e.Graphics.DrawString(frmBooking.returnPlace, f10, Brushes.Black, 150, 129)
        e.Graphics.DrawString("Seats:", f10, Brushes.Black, 0, 142)
        e.Graphics.DrawString(seats, f10, Brushes.Black, 150, 142)

        e.Graphics.DrawString(line, f10, Brushes.Black, 0, 155)
        e.Graphics.DrawString("Name:", f10, Brushes.Black, 0, 169)
        e.Graphics.DrawString(frmPassengerInfo.txtLastName.Text, f10, Brushes.Black, 150, 169)
        e.Graphics.DrawString("Contact Number:", f10, Brushes.Black, 0, 185)
        e.Graphics.DrawString(frmPassengerInfo.txtContactNo.Text, f10, Brushes.Black, 150, 185)
        e.Graphics.DrawString("Total Payment:", f10, Brushes.Black, 0, 199)
        e.Graphics.DrawString(lblSubtotal.Text, f10, Brushes.Black, 150, 199)
    End Sub

    Private Sub GCash_CheckedChanged(sender As Object, e As EventArgs) Handles GCash.CheckedChanged
        If GCash.Checked Then
            TextBox1.Enabled = True
            TextBox1.Visible = True
            TextBox2.Visible = True
            Button1.Visible = True
            Label6.Visible = True
            Label10.Visible = True
            btnPay.Enabled = False
            Label5.Text = "---"
            lblSubtotal.Text = "---"
        Else
            TextBox1.Visible = False
            TextBox2.Visible = False
            Button1.Visible = False
            Label6.Visible = False
            Label10.Visible = False
            TextBox1.Clear()
            TextBox2.Clear()
        End If
    End Sub

    Private Sub Maya_CheckedChanged(sender As Object, e As EventArgs) Handles Maya.CheckedChanged
        If Maya.Checked Then
            TextBox1.Enabled = True
            TextBox1.Visible = True
            TextBox2.Visible = True
            Button1.Visible = True
            Label6.Visible = True
            Label10.Visible = True
            btnPay.Enabled = False
            Label5.Text = "---"
            lblSubtotal.Text = "---"
        Else
            TextBox1.Visible = False
            TextBox2.Visible = False
            Button1.Visible = False
            Label6.Visible = False
            Label10.Visible = False
            TextBox1.Clear()
            TextBox2.Clear()
        End If
    End Sub

    Private Sub OTC_CheckedChanged(sender As Object, e As EventArgs) Handles OTC.CheckedChanged
        If frmBooking.rbOneWay.Checked = True Then
            btnPay.Enabled = True
            Label5.Text = "---"
            lblSubtotal.Text = lblFareTotal1.Text
        ElseIf frmBooking.rbRoundTrip.Checked = True Then
            btnPay.Enabled = True
            lblSubtotal.Text = Val(lblFareTotal1.Text) + Val(lblReturnFareTotal2.Text)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Length = 11 And TextBox2.Text.Length = 11 Then
            Label5.Text = "15.00"
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            Button1.Enabled = False
            If frmBooking.rbOneWay.Checked = True Then
                If GCash.Checked = True Or Maya.Checked = True Then
                    lblSubtotal.Text = lblFareTotal1.Text + 15
                End If
            ElseIf frmBooking.rbRoundTrip.Checked = True Then
                If GCash.Checked = True Or Maya.Checked = True Then
                    lblSubtotal.Text = Val(lblFareTotal1.Text) + Val(lblReturnFareTotal2.Text) + 15
                End If
            End If
            btnPay.Enabled = True
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Numbers Only! Press 'Enter' to continue", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If TextBox1.Text.Length >= 11 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Maximum of 11 numbers only!")
            End If
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Numbers Only! Press 'Enter' to continue", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If TextBox2.Text.Length >= 11 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Maximum of 11 numbers only!")
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Length = 11 Then
            TextBox2.Enabled = True
        Else
            TextBox2.Enabled = False
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text.Length = 11 Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub
End Class