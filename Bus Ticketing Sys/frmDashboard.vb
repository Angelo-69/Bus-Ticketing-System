Imports System.Data.OleDb
Imports System.Security.Cryptography

Public Class frmDashboard
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lenovo\source\repos\Bus Ticketing Sys\Bus Ticketing Sys\bin\Debug\Database1.mdb")
        conn.Open()
        Dim cmd1 As New OleDbCommand("select count(*) from busOrdinary", conn)
        Dim count1 = Convert.ToString(cmd1.ExecuteScalar)
        btnOrdinary.Text = count1
        Dim cmd2 As New OleDbCommand("select count(*) from busAirconditioned", conn)
        Dim count2 = Convert.ToString(cmd2.ExecuteScalar)
        btnAirconditioned.Text = count2
        Dim cmd3 As New OleDbCommand("select count(*) from busDeluxe", conn)
        Dim count3 = Convert.ToString(cmd3.ExecuteScalar)
        btnDeluxe.Text = count3
        conn.Close()

        frmOrdinaryDGV.populate1()
        Label1.Text = (FormatCurrency(frmOrdinaryDGV.Income().ToString("0.00")))
        frmDeluxeDGV.populate3()
        Label3.Text = (FormatCurrency(frmDeluxeDGV.Income3().ToString("0.00")))
        frmAirconditionedDGV.populate2()
        Label2.Text = (FormatCurrency(frmAirconditionedDGV.Income2().ToString("0.00")))

    End Sub

    Private Sub btnOrdinary_Click(sender As Object, e As EventArgs) Handles btnOrdinary.Click
        Me.Hide()
        frmOrdinaryDGV.Show()
    End Sub

    Private Sub btnAirconditioned_Click(sender As Object, e As EventArgs) Handles btnAirconditioned.Click
        Me.Hide()
        frmAirconditionedDGV.Show()
    End Sub

    Private Sub btnDeluxe_Click(sender As Object, e As EventArgs) Handles btnDeluxe.Click
        Me.Hide()
        frmDeluxeDGV.Show()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Hide()
        frmAdminLogin.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub
End Class