Public Class frmBusType
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmOrdinaryBus.lblTo.Text = frmBooking.cbxTo.Text
        frmOrdinaryBus.lblReturn.Text = frmBooking.cbxReturn.Text
        frmOrdinaryBus.lblSeats.Text = frmBooking.txtPassenger.Text
        frmOrdinaryBus.seats = frmBooking.txtPassenger.Text
        Me.Hide()
        frmOrdinaryBus.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmAirconditionedBus.lblTo.Text = frmBooking.cbxTo.Text
        frmAirconditionedBus.lblReturn.Text = frmBooking.cbxReturn.Text
        frmAirconditionedBus.lblSeats.Text = frmBooking.txtPassenger.Text
        frmAirconditionedBus.seats = frmBooking.txtPassenger.Text
        Me.Hide()
        frmAirconditionedBus.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmDeluxeBus.lblTo.Text = frmBooking.cbxTo.Text
        frmDeluxeBus.lblReturn.Text = frmBooking.cbxReturn.Text
        frmDeluxeBus.lblSeats.Text = frmBooking.txtPassenger.Text
        frmDeluxeBus.seats = frmBooking.txtPassenger.Text
        Me.Hide()
        frmDeluxeBus.Show()
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Me.Hide()
        frmBooking.Show()
    End Sub

End Class