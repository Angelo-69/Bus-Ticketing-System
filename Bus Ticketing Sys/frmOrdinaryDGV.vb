Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports System.Security.Permissions

Public Class frmOrdinaryDGV
    Dim comm As OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim dset As New DataSet

    Private Sub frmAdminDGV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        da = New OleDbDataAdapter("Select * from busOrdinary", conn)
        dset = New DataSet
        da.Fill(dset, "busOrdinary")
        dgv1.DataSource = dset.Tables("busOrdinary").DefaultView
    End Sub

    Function populate1()
        da = New OleDbDataAdapter("Select * from busOrdinary", conn)
        dset = New DataSet
        da.Fill(dset, "busOrdinary")
        dgv1.DataSource = dset.Tables("busOrdinary").DefaultView
        Return True
    End Function

    Function Income() As Double
        Dim sum As Double = 0
        Dim i As Integer = 0
        For i = 0 To dgv1.Rows.Count - 1
            sum = sum + Convert.ToDouble(dgv1.Rows(i).Cells(8).Value)
        Next i
        Return sum
    End Function

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 802, 1000)
        PrintDocument1.DefaultPageSettings = pagesetup
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private mrow As Integer = 0
    Private newPage As Boolean = True

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim format As New StringFormat
        format.Alignment = StringAlignment.Center
        e.Graphics.DrawString("Passenger List", New Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, New Point(425, 20), format)

        Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
        fmt.LineAlignment = StringAlignment.Center
        fmt.Trimming = StringTrimming.EllipsisCharacter
        fmt.Alignment = StringAlignment.Center

        Dim y As Integer = 100
        Dim x As Integer = 0
        Dim h As Integer = 0
        Dim rc As Rectangle
        Dim row As DataGridViewRow

        If newPage Then
            row = dgv1.Rows(mrow)
            x = 0
            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
                    e.Graphics.FillRectangle(Brushes.LightGray, rc)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    e.Graphics.DrawString(dgv1.Columns(cell.ColumnIndex).HeaderText, dgv1.Font, Brushes.Black, rc, fmt)

                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If
            Next
            y += h
        End If

        newPage = False
        Dim displayNow As Integer
        For displayNow = mrow To dgv1.RowCount - 1
            row = dgv1.Rows(displayNow)
            x = 0
            h = 0

            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
                    e.Graphics.DrawRectangle(Pens.Black, rc)
                    fmt.Alignment = StringAlignment.Near
                    rc.Offset(10, 0)

                    e.Graphics.DrawString(cell.FormattedValue.ToString(),
                                          dgv1.Font, Brushes.Black, rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)


                End If
            Next
            y += h
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frmAdminLogin.Show()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Hide()
        frmDashboard.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        da = New OleDbDataAdapter("Select * from busOrdinary where DepartureDate like '%" & TextBox1.Text & "%'", conn)
        dset = New DataSet
        da.Fill(dset, "busOrdinary")
        dgv1.DataSource = dset.Tables("busOrdinary").DefaultView
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub
End Class