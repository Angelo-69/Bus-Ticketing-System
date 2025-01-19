Imports System.Linq.Expressions

Public Class frmOrdinaryBus
    Dim A, B, C, D, EE, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z As Integer
    Dim AA, BB, CC, DD, EEE, FF, GG, HH, II, JJ, KK, lL, MM, NN, OO, PP, QQ, RR, SS, TT, UU, VV, WW As Integer
    Public seats As Integer
    Private Sub frmOrdinaryBus_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If seats = 0 Then
            For Each control1 In Me.Controls.OfType(Of Button)
                If control1.BackColor = DefaultBackColor Then
                    control1.Enabled = False
                    Button50.Enabled = True
                End If
            Next
        ElseIf seats > 0 Then
            For Each control1 In Me.Controls.OfType(Of Button)
                If control1.BackColor = DefaultBackColor Then
                    control1.Enabled = True
                    Button50.Enabled = False
                End If
            Next
        End If
    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        If seats > 0 Then
            MsgBox("Please provide a valid information!", MsgBoxStyle.OkOnly, "Invalid Input")
        Else
            frmPassengerInfo.busType = lblBusType.Text
            Me.Hide()
            frmPassengerInfo.Show()
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If btn1.BackColor = DefaultBackColor Then
            If A = 0 Then
                btn1.BackColor = Color.Green
            End If
            frmPayment.seats += "R1 "
            seats -= 1
            A = 1
        ElseIf btn1.BackColor = Color.Green Then
            If A = 1 Then
                btn1.BackColor = DefaultBackColor
            End If
            seats += 1
            A = 0
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If btn2.BackColor = DefaultBackColor Then
            If B = 0 Then
                btn2.BackColor = Color.Green
            End If
            frmPayment.seats += "R2 "
            seats -= 1
            B = 1
        ElseIf btn2.BackColor = Color.Green Then
            If B = 1 Then
                btn2.BackColor = DefaultBackColor
            End If
            seats += 1
            B = 0
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If btn3.BackColor = DefaultBackColor Then
            If C = 0 Then
                btn3.BackColor = Color.Green
            End If
            frmPayment.seats += "R3 "
            seats -= 1
            C = 1
        ElseIf btn3.BackColor = Color.Green Then
            If C = 1 Then
                btn3.BackColor = DefaultBackColor
            End If
            seats += 1
            C = 0
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If btn4.BackColor = DefaultBackColor Then
            If D = 0 Then
                btn4.BackColor = Color.Green
            End If
            frmPayment.seats += "R4 "
            seats -= 1
            D = 1
        ElseIf btn4.BackColor = Color.Green Then
            If D = 1 Then
                btn4.BackColor = DefaultBackColor
            End If
            seats += 1
            D = 0
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If btn5.BackColor = DefaultBackColor Then
            If EE = 0 Then
                btn5.BackColor = Color.Green
            End If
            frmPayment.seats += "R5 "
            seats -= 1
            EE = 1
        ElseIf btn5.BackColor = Color.Green Then
            If EE = 1 Then
                btn5.BackColor = DefaultBackColor
            End If
            seats += 1
            EE = 0
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If btn6.BackColor = DefaultBackColor Then
            If F = 0 Then
                btn6.BackColor = Color.Green
            End If
            frmPayment.seats += "R4 "
            seats -= 1
            F = 1
        ElseIf btn6.BackColor = Color.Green Then
            If F = 1 Then
                btn6.BackColor = DefaultBackColor
            End If
            seats += 1
            F = 0
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If btn7.BackColor = DefaultBackColor Then
            If G = 0 Then
                btn7.BackColor = Color.Green
            End If
            frmPayment.seats += "R7 "
            seats -= 1
            G = 1
        ElseIf btn7.BackColor = Color.Green Then
            If G = 1 Then
                btn7.BackColor = DefaultBackColor
            End If
            seats += 1
            G = 0
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If btn8.BackColor = DefaultBackColor Then
            If H = 0 Then
                btn8.BackColor = Color.Green
            End If
            frmPayment.seats += "R8 "
            seats -= 1
            H = 1
        ElseIf btn8.BackColor = Color.Green Then
            If H = 1 Then
                btn8.BackColor = DefaultBackColor
            End If
            seats += 1
            H = 0
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If btn9.BackColor = DefaultBackColor Then
            If I = 0 Then
                btn9.BackColor = Color.Green
            End If
            frmPayment.seats += "R9 "
            seats -= 1
            I = 1
        ElseIf btn9.BackColor = Color.Green Then
            If I = 1 Then
                btn9.BackColor = DefaultBackColor
            End If
            seats += 1
            I = 0
        End If
    End Sub

    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        If btn10.BackColor = DefaultBackColor Then
            If J = 0 Then
                btn10.BackColor = Color.Green
            End If
            frmPayment.seats += "R10 "
            seats -= 1
            J = 1
        ElseIf btn10.BackColor = Color.Green Then
            If J = 1 Then
                btn10.BackColor = DefaultBackColor
            End If
            seats += 1
            J = 0
        End If
    End Sub

    Private Sub btn11_Click(sender As Object, e As EventArgs) Handles btn11.Click
        If btn11.BackColor = DefaultBackColor Then
            If K = 0 Then
                btn11.BackColor = Color.Green
            End If
            frmPayment.seats += "R11 "
            seats -= 1
            K = 1
        ElseIf btn11.BackColor = Color.Green Then
            If K = 1 Then
                btn11.BackColor = DefaultBackColor
            End If
            seats += 1
            K = 0
        End If
    End Sub

    Private Sub btn12_Click(sender As Object, e As EventArgs) Handles btn12.Click
        If btn12.BackColor = DefaultBackColor Then
            If L = 0 Then
                btn12.BackColor = Color.Green
            End If
            frmPayment.seats += "R12 "
            seats -= 1
            L = 1
        ElseIf btn12.BackColor = Color.Green Then
            If L = 1 Then
                btn12.BackColor = DefaultBackColor
            End If
            seats += 1
            L = 0
        End If
    End Sub

    Private Sub btn13_Click(sender As Object, e As EventArgs) Handles btn13.Click
        If btn13.BackColor = DefaultBackColor Then
            If M = 0 Then
                btn13.BackColor = Color.Green
            End If
            frmPayment.seats += "R13 "
            seats -= 1
            M = 1
        ElseIf btn13.BackColor = Color.Green Then
            If M = 1 Then
                btn13.BackColor = DefaultBackColor
            End If
            seats += 1
            M = 0
        End If
    End Sub

    Private Sub btn14_Click(sender As Object, e As EventArgs) Handles btn14.Click
        If btn14.BackColor = DefaultBackColor Then
            If N = 0 Then
                btn14.BackColor = Color.Green
            End If
            frmPayment.seats += "R14 "
            seats -= 1
            N = 1
        ElseIf btn14.BackColor = Color.Green Then
            If N = 1 Then
                btn14.BackColor = DefaultBackColor
            End If
            seats += 1
            N = 0
        End If
    End Sub

    Private Sub btn15_Click(sender As Object, e As EventArgs) Handles btn15.Click
        If btn15.BackColor = DefaultBackColor Then
            If O = 0 Then
                btn15.BackColor = Color.Green
            End If
            frmPayment.seats += "R15 "
            seats -= 1
            O = 1
        ElseIf btn15.BackColor = Color.Green Then
            If O = 1 Then
                btn15.BackColor = DefaultBackColor
            End If
            seats += 1
            O = 0
        End If
    End Sub

    Private Sub btn16_Click(sender As Object, e As EventArgs) Handles btn16.Click
        If btn16.BackColor = DefaultBackColor Then
            If P = 0 Then
                btn16.BackColor = Color.Green
            End If
            frmPayment.seats += "R16 "
            seats -= 1
            P = 1
        ElseIf btn16.BackColor = Color.Green Then
            If P = 1 Then
                btn16.BackColor = DefaultBackColor
            End If
            seats += 1
            P = 0
        End If
    End Sub

    Private Sub btn17_Click(sender As Object, e As EventArgs) Handles btn17.Click
        If btn17.BackColor = DefaultBackColor Then
            If Q = 0 Then
                btn17.BackColor = Color.Green
            End If
            frmPayment.seats += "R17 "
            seats -= 1
            Q = 1
        ElseIf btn17.BackColor = Color.Green Then
            If Q = 1 Then
                btn17.BackColor = DefaultBackColor
            End If
            seats += 1
            Q = 0
        End If
    End Sub

    Private Sub btn18_Click(sender As Object, e As EventArgs) Handles btn18.Click
        If btn18.BackColor = DefaultBackColor Then
            If R = 0 Then
                btn18.BackColor = Color.Green
            End If
            frmPayment.seats += "R18 "
            seats -= 1
            R = 1
        ElseIf btn18.BackColor = Color.Green Then
            If R = 1 Then
                btn18.BackColor = DefaultBackColor
            End If
            seats += 1
            R = 0
        End If
    End Sub

    Private Sub btn19_Click(sender As Object, e As EventArgs) Handles btn19.Click
        If btn19.BackColor = DefaultBackColor Then
            If S = 0 Then
                btn19.BackColor = Color.Green
            End If
            frmPayment.seats += "R19 "
            seats -= 1
            S = 1
        ElseIf btn19.BackColor = Color.Green Then
            If S = 1 Then
                btn19.BackColor = DefaultBackColor
            End If
            seats += 1
            S = 0
        End If
    End Sub

    Private Sub btn20_Click(sender As Object, e As EventArgs) Handles btn20.Click
        If btn20.BackColor = DefaultBackColor Then
            If T = 0 Then
                btn20.BackColor = Color.Green
            End If
            frmPayment.seats += "R20 "
            seats -= 1
            T = 1
        ElseIf btn20.BackColor = Color.Green Then
            If T = 1 Then
                btn20.BackColor = DefaultBackColor
            End If
            seats += 1
            T = 0
        End If
    End Sub

    Private Sub btn21_Click(sender As Object, e As EventArgs) Handles btn21.Click
        If btn21.BackColor = DefaultBackColor Then
            If U = 0 Then
                btn21.BackColor = Color.Green
            End If
            frmPayment.seats += "R21 "
            seats -= 1
            U = 1
        ElseIf btn21.BackColor = Color.Green Then
            If U = 1 Then
                btn21.BackColor = DefaultBackColor
            End If
            seats += 1
            U = 0
        End If
    End Sub

    Private Sub btn22_Click(sender As Object, e As EventArgs) Handles btn22.Click
        If btn22.BackColor = DefaultBackColor Then
            If V = 0 Then
                btn22.BackColor = Color.Green
            End If
            frmPayment.seats += "R22 "
            seats -= 1
            V = 1
        ElseIf btn22.BackColor = Color.Green Then
            If V = 1 Then
                btn22.BackColor = DefaultBackColor
            End If
            seats += 1
            V = 0
        End If
    End Sub

    Private Sub btn23_Click(sender As Object, e As EventArgs) Handles btn23.Click
        If btn23.BackColor = DefaultBackColor Then
            If W = 0 Then
                btn23.BackColor = Color.Green
            End If
            frmPayment.seats += "R23 "
            seats -= 1
            W = 1
        ElseIf btn23.BackColor = Color.Green Then
            If W = 1 Then
                btn23.BackColor = DefaultBackColor
            End If
            seats += 1
            W = 0
        End If
    End Sub

    Private Sub btn24_Click(sender As Object, e As EventArgs) Handles btn24.Click
        If btn24.BackColor = DefaultBackColor Then
            If X = 0 Then
                btn24.BackColor = Color.Green
            End If
            frmPayment.seats += "R24 "
            seats -= 1
            X = 1
        ElseIf btn24.BackColor = Color.Green Then
            If X = 1 Then
                btn24.BackColor = DefaultBackColor
            End If
            seats += 1
            X = 0
        End If
    End Sub

    Private Sub btn25_Click(sender As Object, e As EventArgs) Handles btn25.Click
        If btn25.BackColor = DefaultBackColor Then
            If Y = 0 Then
                btn25.BackColor = Color.Green
            End If
            frmPayment.seats += "R25 "
            seats -= 1
            Y = 1
        ElseIf btn25.BackColor = Color.Green Then
            If Y = 1 Then
                btn25.BackColor = DefaultBackColor
            End If
            seats += 1
            Y = 0
        End If
    End Sub

    Private Sub btn26_Click(sender As Object, e As EventArgs) Handles btn26.Click
        If btn26.BackColor = DefaultBackColor Then
            If Z = 0 Then
                btn26.BackColor = Color.Green
            End If
            frmPayment.seats += "R26 "
            seats -= 1
            Z = 1
        ElseIf btn26.BackColor = Color.Green Then
            If Z = 1 Then
                btn26.BackColor = DefaultBackColor
            End If
            seats += 1
            Z = 0
        End If
    End Sub

    Private Sub btn27_Click(sender As Object, e As EventArgs) Handles btn27.Click
        If btn27.BackColor = DefaultBackColor Then
            If AA = 0 Then
                btn27.BackColor = Color.Green
            End If
            frmPayment.seats += "R27 "
            seats -= 1
            AA = 1
        ElseIf btn27.BackColor = Color.Green Then
            If AA = 1 Then
                btn27.BackColor = DefaultBackColor
            End If
            seats += 1
            AA = 0
        End If
    End Sub

    Private Sub btn28_Click(sender As Object, e As EventArgs) Handles btn28.Click
        If btn28.BackColor = DefaultBackColor Then
            If BB = 0 Then
                btn28.BackColor = Color.Green
            End If
            frmPayment.seats += "R28 "
            seats -= 1
            BB = 1
        ElseIf btn28.BackColor = Color.Green Then
            If BB = 1 Then
                btn28.BackColor = DefaultBackColor
            End If
            seats += 1
            BB = 0
        End If
    End Sub

    Private Sub btn29_Click(sender As Object, e As EventArgs) Handles btn29.Click
        If btn29.BackColor = DefaultBackColor Then
            If CC = 0 Then
                btn29.BackColor = Color.Green
            End If
            frmPayment.seats += "R29 "
            seats -= 1
            CC = 1
        ElseIf btn29.BackColor = Color.Green Then
            If CC = 1 Then
                btn29.BackColor = DefaultBackColor
            End If
            seats += 1
            CC = 0
        End If
    End Sub

    Private Sub btn30_Click(sender As Object, e As EventArgs) Handles btn30.Click
        If btn30.BackColor = DefaultBackColor Then
            If DD = 0 Then
                btn30.BackColor = Color.Green
            End If
            frmPayment.seats += "R4 "
            seats -= 1
            DD = 1
        ElseIf btn30.BackColor = Color.Green Then
            If DD = 1 Then
                btn30.BackColor = DefaultBackColor
            End If
            seats += 1
            DD = 0
        End If
    End Sub

    Private Sub btn31_Click(sender As Object, e As EventArgs) Handles btn31.Click
        If btn31.BackColor = DefaultBackColor Then
            If EEE = 0 Then
                btn31.BackColor = Color.Green
            End If
            frmPayment.seats += "R31 "
            seats -= 1
            EEE = 1
        ElseIf btn31.BackColor = Color.Green Then
            If EEE = 1 Then
                btn31.BackColor = DefaultBackColor
            End If
            seats += 1
            EEE = 0
        End If
    End Sub

    Private Sub btn32_Click(sender As Object, e As EventArgs) Handles btn32.Click
        If btn32.BackColor = DefaultBackColor Then
            If FF = 0 Then
                btn32.BackColor = Color.Green
            End If
            frmPayment.seats += "R32 "
            seats -= 1
            FF = 1
        ElseIf btn32.BackColor = Color.Green Then
            If FF = 1 Then
                btn32.BackColor = DefaultBackColor
            End If
            seats += 1
            FF = 0
        End If
    End Sub

    Private Sub btn33_Click(sender As Object, e As EventArgs) Handles btn33.Click
        If btn33.BackColor = DefaultBackColor Then
            If GG = 0 Then
                btn33.BackColor = Color.Green
            End If
            frmPayment.seats += "R33 "
            seats -= 1
            GG = 1
        ElseIf btn33.BackColor = Color.Green Then
            If GG = 1 Then
                btn33.BackColor = DefaultBackColor
            End If
            seats += 1
            GG = 0
        End If
    End Sub

    Private Sub btn34_Click(sender As Object, e As EventArgs) Handles btn34.Click
        If btn34.BackColor = DefaultBackColor Then
            If HH = 0 Then
                btn34.BackColor = Color.Green
            End If
            frmPayment.seats += "R34 "
            seats -= 1
            HH = 1
        ElseIf btn34.BackColor = Color.Green Then
            If HH = 1 Then
                btn34.BackColor = DefaultBackColor
            End If
            seats += 1
            HH = 0
        End If
    End Sub

    Private Sub btn35_Click(sender As Object, e As EventArgs) Handles btn35.Click
        If btn35.BackColor = DefaultBackColor Then
            If II = 0 Then
                btn35.BackColor = Color.Green
            End If
            frmPayment.seats += "R35 "
            seats -= 1
            II = 1
        ElseIf btn35.BackColor = Color.Green Then
            If II = 1 Then
                btn35.BackColor = DefaultBackColor
            End If
            seats += 1
            II = 0
        End If
    End Sub

    Private Sub btn36_Click(sender As Object, e As EventArgs) Handles btn36.Click
        If btn36.BackColor = DefaultBackColor Then
            If JJ = 0 Then
                btn36.BackColor = Color.Green
            End If
            frmPayment.seats += "R36 "
            seats -= 1
            JJ = 1
        ElseIf btn36.BackColor = Color.Green Then
            If JJ = 1 Then
                btn36.BackColor = DefaultBackColor
            End If
            seats += 1
            JJ = 0
        End If
    End Sub

    Private Sub btn37_Click(sender As Object, e As EventArgs) Handles btn37.Click
        If btn37.BackColor = DefaultBackColor Then
            If KK = 0 Then
                btn37.BackColor = Color.Green
            End If
            frmPayment.seats += "R37 "
            seats -= 1
            KK = 1
        ElseIf btn37.BackColor = Color.Green Then
            If KK = 1 Then
                btn37.BackColor = DefaultBackColor
            End If
            seats += 1
            KK = 0
        End If
    End Sub

    Private Sub btn38_Click(sender As Object, e As EventArgs) Handles btn38.Click
        If btn38.BackColor = DefaultBackColor Then
            If lL = 0 Then
                btn38.BackColor = Color.Green
            End If
            frmPayment.seats += "R38 "
            seats -= 1
            lL = 1
        ElseIf btn38.BackColor = Color.Green Then
            If lL = 1 Then
                btn38.BackColor = DefaultBackColor
            End If
            seats += 1
            lL = 0
        End If
    End Sub

    Private Sub btn39_Click(sender As Object, e As EventArgs) Handles btn39.Click
        If btn39.BackColor = DefaultBackColor Then
            If MM = 0 Then
                btn39.BackColor = Color.Green
            End If
            frmPayment.seats += "R39 "
            seats -= 1
            MM = 1
        ElseIf btn39.BackColor = Color.Green Then
            If MM = 1 Then
                btn39.BackColor = DefaultBackColor
            End If
            seats += 1
            MM = 0
        End If
    End Sub

    Private Sub btn40_Click(sender As Object, e As EventArgs) Handles btn40.Click
        If btn40.BackColor = DefaultBackColor Then
            If NN = 0 Then
                btn40.BackColor = Color.Green
            End If
            frmPayment.seats += "R40 "
            seats -= 1
            NN = 1
        ElseIf btn40.BackColor = Color.Green Then
            If NN = 1 Then
                btn40.BackColor = DefaultBackColor
            End If
            seats += 1
            NN = 0
        End If
    End Sub

    Private Sub btn41_Click(sender As Object, e As EventArgs) Handles btn41.Click
        If btn41.BackColor = DefaultBackColor Then
            If OO = 0 Then
                btn41.BackColor = Color.Green
            End If
            frmPayment.seats += "R41 "
            seats -= 1
            OO = 1
        ElseIf btn41.BackColor = Color.Green Then
            If OO = 1 Then
                btn41.BackColor = DefaultBackColor
            End If
            seats += 1
            OO = 0
        End If
    End Sub

    Private Sub btn42_Click(sender As Object, e As EventArgs) Handles btn42.Click
        If btn42.BackColor = DefaultBackColor Then
            If PP = 0 Then
                btn42.BackColor = Color.Green
            End If
            frmPayment.seats += "R42 "
            seats -= 1
            PP = 1
        ElseIf btn42.BackColor = Color.Green Then
            If PP = 1 Then
                btn42.BackColor = DefaultBackColor
            End If
            seats += 1
            PP = 0
        End If
    End Sub

    Private Sub btn43_Click(sender As Object, e As EventArgs) Handles btn43.Click
        If btn43.BackColor = DefaultBackColor Then
            If QQ = 0 Then
                btn43.BackColor = Color.Green
            End If
            frmPayment.seats += "R43 "
            seats -= 1
            QQ = 1
        ElseIf btn43.BackColor = Color.Green Then
            If QQ = 1 Then
                btn43.BackColor = DefaultBackColor
            End If
            seats += 1
            QQ = 0
        End If
    End Sub

    Private Sub btn44_Click(sender As Object, e As EventArgs) Handles btn44.Click
        If btn44.BackColor = DefaultBackColor Then
            If RR = 0 Then
                btn44.BackColor = Color.Green
            End If
            frmPayment.seats += "R44 "
            seats -= 1
            RR = 1
        ElseIf btn44.BackColor = Color.Green Then
            If RR = 1 Then
                btn44.BackColor = DefaultBackColor
            End If
            seats += 1
            RR = 0
        End If
    End Sub

    Private Sub btn45_Click(sender As Object, e As EventArgs) Handles btn45.Click
        If btn45.BackColor = DefaultBackColor Then
            If SS = 0 Then
                btn45.BackColor = Color.Green
            End If
            frmPayment.seats += "R45 "
            seats -= 1
            SS = 1
        ElseIf btn45.BackColor = Color.Green Then
            If SS = 1 Then
                btn45.BackColor = DefaultBackColor
            End If
            seats += 1
            SS = 0
        End If
    End Sub

    Private Sub btn46_Click(sender As Object, e As EventArgs) Handles btn46.Click
        If btn46.BackColor = DefaultBackColor Then
            If TT = 0 Then
                btn46.BackColor = Color.Green
            End If
            frmPayment.seats += "R46 "
            seats -= 1
            TT = 1
        ElseIf btn46.BackColor = Color.Green Then
            If TT = 1 Then
                btn46.BackColor = DefaultBackColor
            End If
            seats += 1
            TT = 0
        End If
    End Sub

    Private Sub btn47_Click(sender As Object, e As EventArgs) Handles btn47.Click
        If btn47.BackColor = DefaultBackColor Then
            If UU = 0 Then
                btn47.BackColor = Color.Green
            End If
            frmPayment.seats += "R47 "
            seats -= 1
            UU = 1
        ElseIf btn47.BackColor = Color.Green Then
            If UU = 1 Then
                btn47.BackColor = DefaultBackColor
            End If
            seats += 1
            UU = 0
        End If
    End Sub

    Private Sub btn48_Click(sender As Object, e As EventArgs) Handles btn48.Click
        If btn48.BackColor = DefaultBackColor Then
            If VV = 0 Then
                btn48.BackColor = Color.Green
            End If
            frmPayment.seats += "R48 "
            seats -= 1
            VV = 1
        ElseIf btn48.BackColor = Color.Green Then
            If VV = 1 Then
                btn48.BackColor = DefaultBackColor
            End If
            seats += 1
            VV = 0
        End If
    End Sub

    Private Sub btn49_Click(sender As Object, e As EventArgs) Handles btn49.Click
        If btn49.BackColor = DefaultBackColor Then
            If WW = 0 Then
                btn49.BackColor = Color.Green
            End If
            frmPayment.seats += "R49 "
            seats -= 1
            WW = 1
        ElseIf btn49.BackColor = Color.Green Then
            If WW = 1 Then
                btn49.BackColor = DefaultBackColor
            End If
            seats += 1
            WW = 0
        End If
    End Sub
End Class