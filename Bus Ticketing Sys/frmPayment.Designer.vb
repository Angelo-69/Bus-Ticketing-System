<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayment))
        Me.lblBusType = New System.Windows.Forms.Label()
        Me.lblReturn = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblBusNo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFare = New System.Windows.Forms.Label()
        Me.lblFareSeat = New System.Windows.Forms.Label()
        Me.lblFareTotal1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl17 = New System.Windows.Forms.Label()
        Me.lblReturnFareTotal2 = New System.Windows.Forms.Label()
        Me.lblReturnSeat = New System.Windows.Forms.Label()
        Me.lbl15 = New System.Windows.Forms.Label()
        Me.lblReturnFare = New System.Windows.Forms.Label()
        Me.lbl16 = New System.Windows.Forms.Label()
        Me.lbl14 = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GCash = New System.Windows.Forms.RadioButton()
        Me.Maya = New System.Windows.Forms.RadioButton()
        Me.OTC = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBusType
        '
        Me.lblBusType.Font = New System.Drawing.Font("SansSerif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblBusType.Location = New System.Drawing.Point(12, 93)
        Me.lblBusType.Name = "lblBusType"
        Me.lblBusType.Size = New System.Drawing.Size(551, 25)
        Me.lblBusType.TabIndex = 117
        Me.lblBusType.Text = "---"
        Me.lblBusType.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblReturn
        '
        Me.lblReturn.Font = New System.Drawing.Font("SansSerif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblReturn.Location = New System.Drawing.Point(312, 50)
        Me.lblReturn.Name = "lblReturn"
        Me.lblReturn.Size = New System.Drawing.Size(200, 25)
        Me.lblReturn.TabIndex = 116
        Me.lblReturn.Text = "Return"
        Me.lblReturn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("SansSerif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label2.Location = New System.Drawing.Point(256, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 25)
        Me.Label2.TabIndex = 115
        Me.Label2.Text = ">>>"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTo
        '
        Me.lblTo.Font = New System.Drawing.Font("SansSerif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblTo.Location = New System.Drawing.Point(50, 50)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(200, 25)
        Me.lblTo.TabIndex = 114
        Me.lblTo.Text = "To"
        Me.lblTo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Navy
        Me.Label8.Font = New System.Drawing.Font("SansSerif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(575, 50)
        Me.Label8.TabIndex = 120
        Me.Label8.Text = "Step 3: Summary of Charges"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("SansSerif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(11, 303)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(551, 30)
        Me.Label7.TabIndex = 121
        Me.Label7.Text = "FARE AMOUNT"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("SansSerif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(201, 355)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 25)
        Me.Label9.TabIndex = 122
        Me.Label9.Text = "x"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblBusNo
        '
        Me.lblBusNo.Font = New System.Drawing.Font("SansSerif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblBusNo.Location = New System.Drawing.Point(12, 15)
        Me.lblBusNo.Name = "lblBusNo"
        Me.lblBusNo.Size = New System.Drawing.Size(551, 25)
        Me.lblBusNo.TabIndex = 123
        Me.lblBusNo.Text = "---"
        Me.lblBusNo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("SansSerif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(117, 353)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 25)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "pesos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFare
        '
        Me.lblFare.Font = New System.Drawing.Font("SansSerif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblFare.ForeColor = System.Drawing.Color.Navy
        Me.lblFare.Location = New System.Drawing.Point(11, 351)
        Me.lblFare.Name = "lblFare"
        Me.lblFare.Size = New System.Drawing.Size(100, 25)
        Me.lblFare.TabIndex = 124
        Me.lblFare.Text = "---"
        Me.lblFare.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFareSeat
        '
        Me.lblFareSeat.Font = New System.Drawing.Font("SansSerif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblFareSeat.ForeColor = System.Drawing.Color.Navy
        Me.lblFareSeat.Location = New System.Drawing.Point(257, 353)
        Me.lblFareSeat.Name = "lblFareSeat"
        Me.lblFareSeat.Size = New System.Drawing.Size(35, 25)
        Me.lblFareSeat.TabIndex = 126
        Me.lblFareSeat.Text = "---"
        Me.lblFareSeat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFareTotal1
        '
        Me.lblFareTotal1.Font = New System.Drawing.Font("SansSerif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblFareTotal1.ForeColor = System.Drawing.Color.Navy
        Me.lblFareTotal1.Location = New System.Drawing.Point(428, 353)
        Me.lblFareTotal1.Name = "lblFareTotal1"
        Me.lblFareTotal1.Size = New System.Drawing.Size(135, 25)
        Me.lblFareTotal1.TabIndex = 127
        Me.lblFareTotal1.Text = "---"
        Me.lblFareTotal1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("SansSerif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(298, 353)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 25)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "Passenger"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl17
        '
        Me.lbl17.Font = New System.Drawing.Font("SansSerif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lbl17.ForeColor = System.Drawing.Color.Navy
        Me.lbl17.Location = New System.Drawing.Point(297, 448)
        Me.lbl17.Name = "lbl17"
        Me.lbl17.Size = New System.Drawing.Size(125, 25)
        Me.lbl17.TabIndex = 135
        Me.lbl17.Text = "Passenger"
        Me.lbl17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl17.Visible = False
        '
        'lblReturnFareTotal2
        '
        Me.lblReturnFareTotal2.Font = New System.Drawing.Font("SansSerif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblReturnFareTotal2.ForeColor = System.Drawing.Color.Navy
        Me.lblReturnFareTotal2.Location = New System.Drawing.Point(428, 448)
        Me.lblReturnFareTotal2.Name = "lblReturnFareTotal2"
        Me.lblReturnFareTotal2.Size = New System.Drawing.Size(135, 25)
        Me.lblReturnFareTotal2.TabIndex = 134
        Me.lblReturnFareTotal2.Text = "---"
        Me.lblReturnFareTotal2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblReturnFareTotal2.Visible = False
        '
        'lblReturnSeat
        '
        Me.lblReturnSeat.Font = New System.Drawing.Font("SansSerif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblReturnSeat.ForeColor = System.Drawing.Color.Navy
        Me.lblReturnSeat.Location = New System.Drawing.Point(256, 448)
        Me.lblReturnSeat.Name = "lblReturnSeat"
        Me.lblReturnSeat.Size = New System.Drawing.Size(35, 25)
        Me.lblReturnSeat.TabIndex = 133
        Me.lblReturnSeat.Text = "---"
        Me.lblReturnSeat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblReturnSeat.Visible = False
        '
        'lbl15
        '
        Me.lbl15.Font = New System.Drawing.Font("SansSerif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lbl15.ForeColor = System.Drawing.Color.Navy
        Me.lbl15.Location = New System.Drawing.Point(116, 448)
        Me.lbl15.Name = "lbl15"
        Me.lbl15.Size = New System.Drawing.Size(78, 25)
        Me.lbl15.TabIndex = 132
        Me.lbl15.Text = "pesos"
        Me.lbl15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl15.Visible = False
        '
        'lblReturnFare
        '
        Me.lblReturnFare.Font = New System.Drawing.Font("SansSerif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblReturnFare.ForeColor = System.Drawing.Color.Navy
        Me.lblReturnFare.Location = New System.Drawing.Point(10, 446)
        Me.lblReturnFare.Name = "lblReturnFare"
        Me.lblReturnFare.Size = New System.Drawing.Size(100, 25)
        Me.lblReturnFare.TabIndex = 131
        Me.lblReturnFare.Text = "---"
        Me.lblReturnFare.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblReturnFare.Visible = False
        '
        'lbl16
        '
        Me.lbl16.Font = New System.Drawing.Font("SansSerif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lbl16.ForeColor = System.Drawing.Color.Navy
        Me.lbl16.Location = New System.Drawing.Point(200, 450)
        Me.lbl16.Name = "lbl16"
        Me.lbl16.Size = New System.Drawing.Size(50, 25)
        Me.lbl16.TabIndex = 130
        Me.lbl16.Text = "x"
        Me.lbl16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbl16.Visible = False
        '
        'lbl14
        '
        Me.lbl14.BackColor = System.Drawing.Color.Transparent
        Me.lbl14.Font = New System.Drawing.Font("SansSerif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lbl14.ForeColor = System.Drawing.Color.Navy
        Me.lbl14.Location = New System.Drawing.Point(10, 398)
        Me.lbl14.Name = "lbl14"
        Me.lbl14.Size = New System.Drawing.Size(551, 30)
        Me.lbl14.TabIndex = 129
        Me.lbl14.Text = "RETURN AMOUNT"
        Me.lbl14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbl14.Visible = False
        '
        'lblSubtotal
        '
        Me.lblSubtotal.Font = New System.Drawing.Font("SansSerif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblSubtotal.ForeColor = System.Drawing.Color.Navy
        Me.lblSubtotal.Location = New System.Drawing.Point(431, 536)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(129, 25)
        Me.lblSubtotal.TabIndex = 136
        Me.lblSubtotal.Text = "---"
        Me.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("SansSerif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(15, 536)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(424, 25)
        Me.Label16.TabIndex = 137
        Me.Label16.Text = "Subtotal:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnPay
        '
        Me.btnPay.BackColor = System.Drawing.Color.Navy
        Me.btnPay.Enabled = False
        Me.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.ForeColor = System.Drawing.Color.White
        Me.btnPay.Location = New System.Drawing.Point(336, 575)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(225, 40)
        Me.btnPay.TabIndex = 138
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(74, 204)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 139
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(225, 204)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(125, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 140
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(380, 204)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(125, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 141
        Me.PictureBox3.TabStop = False
        '
        'GCash
        '
        Me.GCash.AutoSize = True
        Me.GCash.Font = New System.Drawing.Font("SansSerif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.GCash.Location = New System.Drawing.Point(100, 260)
        Me.GCash.Name = "GCash"
        Me.GCash.Size = New System.Drawing.Size(79, 24)
        Me.GCash.TabIndex = 142
        Me.GCash.TabStop = True
        Me.GCash.Text = "Gcash"
        Me.GCash.UseVisualStyleBackColor = True
        '
        'Maya
        '
        Me.Maya.AutoSize = True
        Me.Maya.Font = New System.Drawing.Font("SansSerif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Maya.Location = New System.Drawing.Point(240, 260)
        Me.Maya.Name = "Maya"
        Me.Maya.Size = New System.Drawing.Size(100, 24)
        Me.Maya.TabIndex = 143
        Me.Maya.TabStop = True
        Me.Maya.Text = "Paymaya"
        Me.Maya.UseVisualStyleBackColor = True
        '
        'OTC
        '
        Me.OTC.AutoSize = True
        Me.OTC.Font = New System.Drawing.Font("SansSerif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.OTC.Location = New System.Drawing.Point(370, 260)
        Me.OTC.Name = "OTC"
        Me.OTC.Size = New System.Drawing.Size(156, 24)
        Me.OTC.TabIndex = 144
        Me.OTC.TabStop = True
        Me.OTC.Text = "Over the counter"
        Me.OTC.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 504)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(224, 22)
        Me.TextBox1.TabIndex = 145
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox1.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("SansSerif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(15, 499)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(424, 25)
        Me.Label4.TabIndex = 148
        Me.Label4.Text = "Service Fee:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("SansSerif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(431, 499)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 25)
        Me.Label5.TabIndex = 147
        Me.Label5.Text = "---"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(17, 547)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(224, 22)
        Me.TextBox2.TabIndex = 149
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox2.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(16, 575)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(225, 40)
        Me.Button1.TabIndex = 150
        Me.Button1.Text = "Verify"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 485)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 16)
        Me.Label6.TabIndex = 151
        Me.Label6.Text = "Cellphone Number:"
        Me.Label6.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 529)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 16)
        Me.Label10.TabIndex = 152
        Me.Label10.Text = "Reference Code:"
        Me.Label10.Visible = False
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 630)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.OTC)
        Me.Controls.Add(Me.Maya)
        Me.Controls.Add(Me.GCash)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.lbl17)
        Me.Controls.Add(Me.lblReturnFareTotal2)
        Me.Controls.Add(Me.lblReturnSeat)
        Me.Controls.Add(Me.lbl15)
        Me.Controls.Add(Me.lblReturnFare)
        Me.Controls.Add(Me.lbl16)
        Me.Controls.Add(Me.lbl14)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblFareTotal1)
        Me.Controls.Add(Me.lblFareSeat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblFare)
        Me.Controls.Add(Me.lblBusNo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblBusType)
        Me.Controls.Add(Me.lblReturn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPayment"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBusType As Label
    Friend WithEvents lblReturn As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblBusNo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFare As Label
    Friend WithEvents lblFareSeat As Label
    Friend WithEvents lblFareTotal1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl17 As Label
    Friend WithEvents lblReturnFareTotal2 As Label
    Friend WithEvents lblReturnSeat As Label
    Friend WithEvents lbl15 As Label
    Friend WithEvents lblReturnFare As Label
    Friend WithEvents lbl16 As Label
    Friend WithEvents lbl14 As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnPay As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    'Friend WithEvents PerformanceCounter1 As PerformanceCounter
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents GCash As RadioButton
    Friend WithEvents Maya As RadioButton
    Friend WithEvents OTC As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
End Class
