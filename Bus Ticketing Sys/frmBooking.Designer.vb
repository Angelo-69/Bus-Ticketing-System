<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBooking
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rbOneWay = New System.Windows.Forms.RadioButton()
        Me.rbRoundTrip = New System.Windows.Forms.RadioButton()
        Me.cbxTo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDeparture = New System.Windows.Forms.DateTimePicker()
        Me.dtpReturn = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPassenger = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxReturn = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'rbOneWay
        '
        Me.rbOneWay.AutoSize = True
        Me.rbOneWay.Font = New System.Drawing.Font("SansSerif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.rbOneWay.Location = New System.Drawing.Point(50, 50)
        Me.rbOneWay.Name = "rbOneWay"
        Me.rbOneWay.Size = New System.Drawing.Size(103, 25)
        Me.rbOneWay.TabIndex = 0
        Me.rbOneWay.TabStop = True
        Me.rbOneWay.Text = "One-way"
        Me.rbOneWay.UseVisualStyleBackColor = True
        '
        'rbRoundTrip
        '
        Me.rbRoundTrip.AutoSize = True
        Me.rbRoundTrip.Font = New System.Drawing.Font("SansSerif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.rbRoundTrip.Location = New System.Drawing.Point(175, 50)
        Me.rbRoundTrip.Name = "rbRoundTrip"
        Me.rbRoundTrip.Size = New System.Drawing.Size(115, 25)
        Me.rbRoundTrip.TabIndex = 1
        Me.rbRoundTrip.TabStop = True
        Me.rbRoundTrip.Text = "Round-trip"
        Me.rbRoundTrip.UseVisualStyleBackColor = True
        '
        'cbxTo
        '
        Me.cbxTo.AutoCompleteCustomSource.AddRange(New String() {"Turbina", "Daet", "Naga", "Tabaco", "Legazpi", "Sorsogon", "Tacloban", "Ormoc"})
        Me.cbxTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTo.FormattingEnabled = True
        Me.cbxTo.Items.AddRange(New Object() {"Daet", "Naga", "Legazpi", "Sorsogon", "Tacloban", "Ormoc"})
        Me.cbxTo.Location = New System.Drawing.Point(50, 127)
        Me.cbxTo.Name = "cbxTo"
        Me.cbxTo.Size = New System.Drawing.Size(240, 24)
        Me.cbxTo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SansSerif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 243)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Departure:"
        '
        'dtpDeparture
        '
        Me.dtpDeparture.Location = New System.Drawing.Point(50, 279)
        Me.dtpDeparture.Name = "dtpDeparture"
        Me.dtpDeparture.Size = New System.Drawing.Size(240, 22)
        Me.dtpDeparture.TabIndex = 5
        '
        'dtpReturn
        '
        Me.dtpReturn.Location = New System.Drawing.Point(50, 353)
        Me.dtpReturn.Name = "dtpReturn"
        Me.dtpReturn.Size = New System.Drawing.Size(240, 22)
        Me.dtpReturn.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("SansSerif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 317)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Return:"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Navy
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(190, 467)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 30)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("SansSerif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(47, 475)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "<< Back to HOME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("SansSerif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "To:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("SansSerif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Return:"
        '
        'txtPassenger
        '
        Me.txtPassenger.Location = New System.Drawing.Point(146, 426)
        Me.txtPassenger.Name = "txtPassenger"
        Me.txtPassenger.Size = New System.Drawing.Size(52, 22)
        Me.txtPassenger.TabIndex = 12
        Me.txtPassenger.Text = "0"
        Me.txtPassenger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("SansSerif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Button1.Location = New System.Drawing.Point(204, 425)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("SansSerif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Button2.Location = New System.Drawing.Point(97, 426)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(43, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "-"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("SansSerif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 390)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Passengers:"
        '
        'cbxReturn
        '
        Me.cbxReturn.AutoCompleteCustomSource.AddRange(New String() {"Ormoc", "Tacloban", "Sorsogon", "Legazpi", "Tabaco", "Naga", "Daet", "Turbina", "Manila"})
        Me.cbxReturn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxReturn.FormattingEnabled = True
        Me.cbxReturn.Items.AddRange(New Object() {"Ormoc", "Tacloban", "Sorsogon", "Legazpi", "Naga", "Daet", "Manila"})
        Me.cbxReturn.Location = New System.Drawing.Point(50, 203)
        Me.cbxReturn.Name = "cbxReturn"
        Me.cbxReturn.Size = New System.Drawing.Size(240, 24)
        Me.cbxReturn.TabIndex = 3
        '
        'frmBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 515)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtPassenger)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.dtpReturn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpDeparture)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxReturn)
        Me.Controls.Add(Me.cbxTo)
        Me.Controls.Add(Me.rbRoundTrip)
        Me.Controls.Add(Me.rbOneWay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBooking"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbOneWay As RadioButton
    Friend WithEvents rbRoundTrip As RadioButton
    Friend WithEvents cbxTo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDeparture As DateTimePicker
    Friend WithEvents dtpReturn As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPassenger As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cbxReturn As ComboBox
End Class
