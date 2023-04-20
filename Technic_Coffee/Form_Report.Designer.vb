<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Report
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Report))
        Me.DGV_Report = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bt_report = New System.Windows.Forms.Button()
        Me.CB_year = New System.Windows.Forms.CheckBox()
        Me.CB_month = New System.Windows.Forms.CheckBox()
        Me.CB_day = New System.Windows.Forms.CheckBox()
        Me.DTM_report = New System.Windows.Forms.DateTimePicker()
        Me.lb_totalamount = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lb_totalPrice = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.bt_report2 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.bt_print = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.tb_cus_se = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CB_NoMemBer = New System.Windows.Forms.CheckBox()
        CType(Me.DGV_Report, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Report
        '
        Me.DGV_Report.AllowUserToAddRows = False
        Me.DGV_Report.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Report.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Report.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column6, Me.Column3, Me.Column4})
        Me.DGV_Report.Location = New System.Drawing.Point(27, 232)
        Me.DGV_Report.Name = "DGV_Report"
        Me.DGV_Report.ReadOnly = True
        Me.DGV_Report.RowTemplate.Height = 30
        Me.DGV_Report.Size = New System.Drawing.Size(860, 404)
        Me.DGV_Report.TabIndex = 0
        '
        'Column1
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cordia New", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = "รหัสสินค้า"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 200
        '
        'Column6
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cordia New", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column6.HeaderText = "ชื่อสินค้า"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 200
        '
        'Column3
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Cordia New", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column3.HeaderText = "จำนวนสินค้า"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 200
        '
        'Column4
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Cordia New", 20.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column4.HeaderText = "ราคาสินค้า"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 200
        '
        'bt_report
        '
        Me.bt_report.BackColor = System.Drawing.Color.Transparent
        Me.bt_report.BackgroundImage = Global.Technic_Coffee.My.Resources.Resources.bt_report
        Me.bt_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_report.ForeColor = System.Drawing.Color.Transparent
        Me.bt_report.Location = New System.Drawing.Point(701, 159)
        Me.bt_report.Name = "bt_report"
        Me.bt_report.Size = New System.Drawing.Size(105, 34)
        Me.bt_report.TabIndex = 1
        Me.bt_report.UseVisualStyleBackColor = False
        '
        'CB_year
        '
        Me.CB_year.AutoSize = True
        Me.CB_year.BackColor = System.Drawing.Color.Transparent
        Me.CB_year.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CB_year.Location = New System.Drawing.Point(637, 160)
        Me.CB_year.Name = "CB_year"
        Me.CB_year.Size = New System.Drawing.Size(41, 33)
        Me.CB_year.TabIndex = 17
        Me.CB_year.Text = "ปี"
        Me.CB_year.UseVisualStyleBackColor = False
        '
        'CB_month
        '
        Me.CB_month.AutoSize = True
        Me.CB_month.BackColor = System.Drawing.Color.Transparent
        Me.CB_month.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CB_month.Location = New System.Drawing.Point(563, 160)
        Me.CB_month.Name = "CB_month"
        Me.CB_month.Size = New System.Drawing.Size(62, 33)
        Me.CB_month.TabIndex = 16
        Me.CB_month.Text = "เดือน"
        Me.CB_month.UseVisualStyleBackColor = False
        '
        'CB_day
        '
        Me.CB_day.AutoSize = True
        Me.CB_day.BackColor = System.Drawing.Color.Transparent
        Me.CB_day.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CB_day.Location = New System.Drawing.Point(503, 160)
        Me.CB_day.Name = "CB_day"
        Me.CB_day.Size = New System.Drawing.Size(48, 33)
        Me.CB_day.TabIndex = 15
        Me.CB_day.Text = "วัน"
        Me.CB_day.UseVisualStyleBackColor = False
        '
        'DTM_report
        '
        Me.DTM_report.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTM_report.Location = New System.Drawing.Point(299, 162)
        Me.DTM_report.Name = "DTM_report"
        Me.DTM_report.Size = New System.Drawing.Size(182, 29)
        Me.DTM_report.TabIndex = 14
        '
        'lb_totalamount
        '
        Me.lb_totalamount.BackColor = System.Drawing.Color.Transparent
        Me.lb_totalamount.Font = New System.Drawing.Font("Cordia New", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lb_totalamount.Location = New System.Drawing.Point(249, 88)
        Me.lb_totalamount.Name = "lb_totalamount"
        Me.lb_totalamount.Size = New System.Drawing.Size(113, 59)
        Me.lb_totalamount.TabIndex = 23
        Me.lb_totalamount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Cordia New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(365, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 33)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "แก้ว"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Cordia New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(184, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 33)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "จำนวน"
        '
        'lb_totalPrice
        '
        Me.lb_totalPrice.BackColor = System.Drawing.Color.Transparent
        Me.lb_totalPrice.Font = New System.Drawing.Font("Cordia New", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lb_totalPrice.Location = New System.Drawing.Point(531, 86)
        Me.lb_totalPrice.Name = "lb_totalPrice"
        Me.lb_totalPrice.Size = New System.Drawing.Size(342, 59)
        Me.lb_totalPrice.TabIndex = 25
        Me.lb_totalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cordia New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(467, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 33)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "รวมเงิน"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ALL ทั้งหมด", "CF001 เอสเพรสโซร้อน", "CF002 เอสเพรสโซเย็น", "CF003 เอสเพรสโซปั่น", "CF004 คาปูชิโนร้อน", "CF005 คาปูชิโนเย็น", "CF006 คาปูชิโนปั่น", "CF007 ลาเต้ร้อน", "CF008 ลาเต้เย็น", "CF009 ลาเต้ปั่น", "CF010 มอคค่าร้อน", "CF011 มอคค่าเย็น", "CF012 มอคค่าปั่น", "CF013 อเมริกาโนร้อน", "CF014 อเมริกาโนเย็น", "CF015 อเมริกาโนปั่น", "CF016 โกโก้ร้อน", "CF017 โกโก้เย็น", "CF018 โกโก้ปั่น", "CF019 โอวัลตินร้อน", "CF020 โอวัลคินเย็น", "CF021 โอวัลตินปั่น", "CF023 โอวัลตินภูเขาไฟเย็น", "CF024 โอวัลตินภูเขาไฟปั่น", "CF025 ชาเขียวร้อน", "CF026 ชาเขียวเย็น", "CF027 ชาเขียวปั่น", "CF028 ชาส้มร้อน", "CF029 ชาส้มเย็น", "CF030 ชาส้มปั่น"})
        Me.ComboBox1.Location = New System.Drawing.Point(27, 29)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(46, 21)
        Me.ComboBox1.TabIndex = 28
        Me.ComboBox1.Visible = False
        '
        'bt_report2
        '
        Me.bt_report2.Location = New System.Drawing.Point(27, 61)
        Me.bt_report2.Name = "bt_report2"
        Me.bt_report2.Size = New System.Drawing.Size(46, 23)
        Me.bt_report2.TabIndex = 29
        Me.bt_report2.Text = "Report (ไม่ใช้)"
        Me.bt_report2.UseVisualStyleBackColor = True
        Me.bt_report2.Visible = False
        '
        'PrintDocument1
        '
        '
        'bt_print
        '
        Me.bt_print.BackgroundImage = Global.Technic_Coffee.My.Resources.Resources.bt_print
        Me.bt_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_print.ForeColor = System.Drawing.Color.Transparent
        Me.bt_print.Location = New System.Drawing.Point(816, 151)
        Me.bt_print.Name = "bt_print"
        Me.bt_print.Size = New System.Drawing.Size(57, 50)
        Me.bt_print.TabIndex = 30
        Me.bt_print.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'tb_cus_se
        '
        Me.tb_cus_se.BackColor = System.Drawing.Color.Gainsboro
        Me.tb_cus_se.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_cus_se.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cus_se.Location = New System.Drawing.Point(119, 165)
        Me.tb_cus_se.Name = "tb_cus_se"
        Me.tb_cus_se.Size = New System.Drawing.Size(162, 22)
        Me.tb_cus_se.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(119, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(362, 33)
        Me.Label3.TabIndex = 32
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 29)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "รหัสลูกค้า"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(43, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 29)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "ชื่อลูกค้า"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CB_NoMemBer
        '
        Me.CB_NoMemBer.AutoSize = True
        Me.CB_NoMemBer.BackColor = System.Drawing.Color.Transparent
        Me.CB_NoMemBer.Location = New System.Drawing.Point(200, 142)
        Me.CB_NoMemBer.Name = "CB_NoMemBer"
        Me.CB_NoMemBer.Size = New System.Drawing.Size(81, 17)
        Me.CB_NoMemBer.TabIndex = 35
        Me.CB_NoMemBer.Text = "No Member"
        Me.CB_NoMemBer.UseVisualStyleBackColor = False
        '
        'Form_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.Technic_Coffee.My.Resources.Resources.bg_report
        Me.ClientSize = New System.Drawing.Size(914, 661)
        Me.Controls.Add(Me.CB_NoMemBer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_cus_se)
        Me.Controls.Add(Me.bt_print)
        Me.Controls.Add(Me.bt_report2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lb_totalPrice)
        Me.Controls.Add(Me.lb_totalamount)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CB_year)
        Me.Controls.Add(Me.CB_month)
        Me.Controls.Add(Me.CB_day)
        Me.Controls.Add(Me.DTM_report)
        Me.Controls.Add(Me.bt_report)
        Me.Controls.Add(Me.DGV_Report)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Report"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DGV_Report, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV_Report As System.Windows.Forms.DataGridView
    Friend WithEvents bt_report As System.Windows.Forms.Button
    Friend WithEvents CB_year As System.Windows.Forms.CheckBox
    Friend WithEvents CB_month As System.Windows.Forms.CheckBox
    Friend WithEvents CB_day As System.Windows.Forms.CheckBox
    Friend WithEvents DTM_report As System.Windows.Forms.DateTimePicker
    Friend WithEvents lb_totalamount As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lb_totalPrice As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents bt_report2 As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents bt_print As System.Windows.Forms.Button
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents tb_cus_se As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CB_NoMemBer As System.Windows.Forms.CheckBox
End Class
