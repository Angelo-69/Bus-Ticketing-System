Imports System.Data.OleDb

Public Class frmPassengerInfo
    Public busType As String
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Hide()
        frmBusType.Show()
        For Each control1 In frmOrdinaryBus.Controls.OfType(Of Button)
            If control1.BackColor = Color.Green Then
                control1.Enabled = False
                control1.BackColor = Color.Orange
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtFirstName.Text.Length = 0 Or txtLastName.Text.Length = 0 Or txtCity.Text.Length = 0 Or
        txtContactNo.Text.Length = 0 Then
            MsgBox("Please provide a valid information!", MsgBoxStyle.OkOnly, "Invalid Input")
        Else
            If busType = "Ordinary Bus" Then
                Me.Hide()
                frmPayment.Show()
                frmPayment.lblBusNo.Text = frmOrdinaryBus.lblBusNo.Text
                frmPayment.lblTo.Text = frmOrdinaryBus.lblTo.Text
                frmPayment.lblReturn.Text = frmOrdinaryBus.lblReturn.Text
                frmPayment.lblBusType.Text = frmOrdinaryBus.lblBusType.Text
                frmPayment.lblFare.Text = frmBusType.lblOrdinaryRate.Text
                frmPayment.lblFareSeat.Text = frmOrdinaryBus.lblSeats.Text
                frmPayment.lblFareTotal1.Text = frmBusType.lblOrdinaryRate.Text * frmOrdinaryBus.lblSeats.Text
                If frmBooking.rbRoundTrip.Checked = True Then
                    For Each control In {frmPayment.lbl14, frmPayment.lbl15, frmPayment.lbl16, frmPayment.lbl17,
                        frmPayment.lblReturnFare, frmPayment.lblReturnSeat, frmPayment.lblReturnFareTotal2}
                        control.Visible = True
                        frmPayment.lblReturnFare.Text = frmBusType.lblOrdinaryRate.Text
                        frmPayment.lblReturnSeat.Text = frmOrdinaryBus.lblSeats.Text
                        frmPayment.lblReturnFareTotal2.Text = frmBusType.lblOrdinaryRate.Text * frmOrdinaryBus.lblSeats.Text
                    Next
                    'frmPayment.lblSubtotal.Text = frmPayment.lblFareTotal1.Text + frmPayment.lblReturnFareTotal2.Text
                Else
                    For Each control In {frmPayment.lbl14, frmPayment.lbl15, frmPayment.lbl16, frmPayment.lbl17,
                        frmPayment.lblReturnFare, frmPayment.lblReturnSeat, frmPayment.lblReturnFareTotal2}
                        control.Visible = False
                    Next
                    'frmPayment.lblSubtotal.Text = frmPayment.lblFareTotal1.Text
                End If

            ElseIf busType = "Air-conditioned Bus" Then
                Me.Hide()
                frmPayment.Show()
                frmPayment.lblBusNo.Text = frmAirconditionedBus.lblBusNo.Text
                frmPayment.lblTo.Text = frmAirconditionedBus.lblTo.Text
                frmPayment.lblReturn.Text = frmAirconditionedBus.lblReturn.Text
                frmPayment.lblBusType.Text = frmAirconditionedBus.Label4.Text
                frmPayment.lblFare.Text = frmBusType.lblAirconRate.Text
                frmPayment.lblFareSeat.Text = frmAirconditionedBus.lblSeats.Text
                frmPayment.lblFareTotal1.Text = frmBusType.lblAirconRate.Text * frmAirconditionedBus.lblSeats.Text
                If frmBooking.rbRoundTrip.Checked = True Then
                    For Each control In {frmPayment.lbl14, frmPayment.lbl15, frmPayment.lbl16, frmPayment.lbl17,
                        frmPayment.lblReturnFare, frmPayment.lblReturnSeat, frmPayment.lblReturnFareTotal2}
                        control.Visible = True
                        frmPayment.lblReturnFare.Text = frmBusType.lblAirconRate.Text
                        frmPayment.lblReturnSeat.Text = frmAirconditionedBus.lblSeats.Text
                        frmPayment.lblReturnFareTotal2.Text = frmBusType.lblAirconRate.Text * frmAirconditionedBus.lblSeats.Text
                    Next
                    'frmPayment.lblSubtotal.Text = frmPayment.lblFareTotal1.Text + frmPayment.lblReturnFareTotal2.Text
                Else
                    For Each control In {frmPayment.lbl14, frmPayment.lbl15, frmPayment.lbl16, frmPayment.lbl17,
                        frmPayment.lblReturnFare, frmPayment.lblReturnSeat, frmPayment.lblReturnFareTotal2}
                        control.Visible = False
                    Next
                    'frmPayment.lblSubtotal.Text = frmPayment.lblFareTotal1.Text
                End If

            ElseIf busType = "First Class/Deluxe" Then
                Me.Hide()
                frmPayment.Show()
                frmPayment.lblBusNo.Text = frmDeluxeBus.lblBusNo.Text
                frmPayment.lblTo.Text = frmDeluxeBus.lblTo.Text
                frmPayment.lblReturn.Text = frmDeluxeBus.lblReturn.Text
                frmPayment.lblBusType.Text = frmDeluxeBus.Label4.Text
                frmPayment.lblFare.Text = frmBusType.lblDeluxeRate.Text
                frmPayment.lblFareSeat.Text = frmDeluxeBus.lblSeats.Text
                frmPayment.lblFareTotal1.Text = frmBusType.lblDeluxeRate.Text * frmDeluxeBus.lblSeats.Text
                If frmBooking.rbRoundTrip.Checked = True Then
                    For Each control In {frmPayment.lbl14, frmPayment.lbl15, frmPayment.lbl16, frmPayment.lbl17,
                        frmPayment.lblReturnFare, frmPayment.lblReturnSeat, frmPayment.lblReturnFareTotal2}
                        control.Visible = True
                        frmPayment.lblReturnFare.Text = frmBusType.lblDeluxeRate.Text
                        frmPayment.lblReturnSeat.Text = frmDeluxeBus.lblSeats.Text
                        frmPayment.lblReturnFareTotal2.Text = frmBusType.lblDeluxeRate.Text * frmDeluxeBus.lblSeats.Text
                    Next
                    'frmPayment.lblSubtotal.Text = frmPayment.lblFareTotal1.Text + frmPayment.lblReturnFareTotal2.Text
                Else
                    For Each control In {frmPayment.lbl14, frmPayment.lbl15, frmPayment.lbl16, frmPayment.lbl17,
                        frmPayment.lblReturnFare, frmPayment.lblReturnSeat, frmPayment.lblReturnFareTotal2}
                        control.Visible = False
                    Next
                    'frmPayment.lblSubtotal.Text = frmPayment.lblFareTotal1.Text
                End If
            End If
        End If
    End Sub

    Private Sub txtContactNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContactNo.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Numbers Only! Press 'Enter' to continue", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If txtContactNo.Text.Length >= 11 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Maximum of 11 numbers only!")
            End If
        End If
    End Sub
End Class