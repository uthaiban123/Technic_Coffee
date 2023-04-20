<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Customer
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
        Me.bt_browse = New System.Windows.Forms.Button()
        Me.DGV_Customer = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_cusname = New System.Windows.Forms.TextBox()
        Me.tb_cusid = New System.Windows.Forms.TextBox()
        Me.lb_cusname = New System.Windows.Forms.Label()
        Me.lb_cusid = New System.Windows.Forms.Label()
        Me.lb_picname = New System.Windows.Forms.Label()
        Me.Bt_Update = New System.Windows.Forms.Button()
        Me.Bt_Del = New System.Windows.Forms.Button()
        Me.Bt_Insert = New System.Windows.Forms.Button()
        Me.Bt_Cancel = New System.Windows.Forms.Button()
        Me.Bt_Add = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PB_Customer = New System.Windows.Forms.PictureBox()
        CType(Me.DGV_Customer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_browse
        '
        Me.bt_browse.BackColor = System.Drawing.SystemColors.Window
        Me.bt_browse.BackgroundImage = Global.Technic_Coffee.My.Resources.Resources.bt_browse
        Me.bt_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_browse.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.bt_browse.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_browse.Location = New System.Drawing.Point(455, 281)
        Me.bt_browse.Name = "bt_browse"
        Me.bt_browse.Size = New System.Drawing.Size(85, 28)
        Me.bt_browse.TabIndex = 15
        Me.bt_browse.Text = "Browse"
        Me.bt_browse.UseVisualStyleBackColor = False
        '
        'DGV_Customer
        '
        Me.DGV_Customer.AllowUserToAddRows = False
        Me.DGV_Customer.AllowUserToDeleteRows = False
        Me.DGV_Customer.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Customer.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Customer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.DGV_Customer.Location = New System.Drawing.Point(68, 281)
        Me.DGV_Customer.Name = "DGV_Customer"
        Me.DGV_Customer.ReadOnly = True
        Me.DGV_Customer.Size = New System.Drawing.Size(350, 298)
        Me.DGV_Customer.TabIndex = 14
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "cus_id"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = "รหัสลูกค้า"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 115
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "cus_fullname"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cordia New", 15.75!)
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column2.HeaderText = "ชื่อลูกค้า"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 175
        '
        'tb_cusname
        '
        Me.tb_cusname.BackColor = System.Drawing.Color.Gainsboro
        Me.tb_cusname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_cusname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cusname.Location = New System.Drawing.Point(68, 225)
        Me.tb_cusname.Name = "tb_cusname"
        Me.tb_cusname.Size = New System.Drawing.Size(203, 22)
        Me.tb_cusname.TabIndex = 12
        '
        'tb_cusid
        '
        Me.tb_cusid.BackColor = System.Drawing.Color.Gainsboro
        Me.tb_cusid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_cusid.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cusid.Location = New System.Drawing.Point(68, 154)
        Me.tb_cusid.Name = "tb_cusid"
        Me.tb_cusid.Size = New System.Drawing.Size(203, 22)
        Me.tb_cusid.TabIndex = 11
        '
        'lb_cusname
        '
        Me.lb_cusname.AutoSize = True
        Me.lb_cusname.BackColor = System.Drawing.SystemColors.Window
        Me.lb_cusname.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_cusname.Location = New System.Drawing.Point(63, 193)
        Me.lb_cusname.Name = "lb_cusname"
        Me.lb_cusname.Size = New System.Drawing.Size(62, 29)
        Me.lb_cusname.TabIndex = 10
        Me.lb_cusname.Text = "ชื่อลูกค้า"
        '
        'lb_cusid
        '
        Me.lb_cusid.AutoSize = True
        Me.lb_cusid.BackColor = System.Drawing.SystemColors.Window
        Me.lb_cusid.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_cusid.Location = New System.Drawing.Point(63, 125)
        Me.lb_cusid.Name = "lb_cusid"
        Me.lb_cusid.Size = New System.Drawing.Size(70, 29)
        Me.lb_cusid.TabIndex = 9
        Me.lb_cusid.Text = "รหัสลูกค้า"
        '
        'lb_picname
        '
        Me.lb_picname.AutoSize = True
        Me.lb_picname.Location = New System.Drawing.Point(288, 187)
        Me.lb_picname.Name = "lb_picname"
        Me.lb_picname.Size = New System.Drawing.Size(0, 13)
        Me.lb_picname.TabIndex = 21
        Me.lb_picname.Visible = False
        '
        'Bt_Update
        '
        Me.Bt_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Update.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Bt_Update.ForeColor = System.Drawing.SystemColors.Window
        Me.Bt_Update.Image = Global.Technic_Coffee.My.Resources.Resources.bt_edit
        Me.Bt_Update.Location = New System.Drawing.Point(455, 459)
        Me.Bt_Update.Name = "Bt_Update"
        Me.Bt_Update.Size = New System.Drawing.Size(85, 28)
        Me.Bt_Update.TabIndex = 20
        Me.Bt_Update.Text = "แก้ไข"
        Me.Bt_Update.UseVisualStyleBackColor = True
        '
        'Bt_Del
        '
        Me.Bt_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Del.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Bt_Del.ForeColor = System.Drawing.SystemColors.Window
        Me.Bt_Del.Image = Global.Technic_Coffee.My.Resources.Resources.bt_delete
        Me.Bt_Del.Location = New System.Drawing.Point(455, 425)
        Me.Bt_Del.Name = "Bt_Del"
        Me.Bt_Del.Size = New System.Drawing.Size(85, 28)
        Me.Bt_Del.TabIndex = 19
        Me.Bt_Del.Text = "ลบ"
        Me.Bt_Del.UseVisualStyleBackColor = True
        '
        'Bt_Insert
        '
        Me.Bt_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Insert.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Bt_Insert.ForeColor = System.Drawing.SystemColors.Window
        Me.Bt_Insert.Image = Global.Technic_Coffee.My.Resources.Resources.bt_save
        Me.Bt_Insert.Location = New System.Drawing.Point(455, 385)
        Me.Bt_Insert.Name = "Bt_Insert"
        Me.Bt_Insert.Size = New System.Drawing.Size(85, 28)
        Me.Bt_Insert.TabIndex = 18
        Me.Bt_Insert.Text = "บันทึก"
        Me.Bt_Insert.UseVisualStyleBackColor = True
        '
        'Bt_Cancel
        '
        Me.Bt_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Cancel.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Bt_Cancel.ForeColor = System.Drawing.SystemColors.Window
        Me.Bt_Cancel.Image = Global.Technic_Coffee.My.Resources.Resources.bt_cancel
        Me.Bt_Cancel.Location = New System.Drawing.Point(455, 493)
        Me.Bt_Cancel.Name = "Bt_Cancel"
        Me.Bt_Cancel.Size = New System.Drawing.Size(85, 28)
        Me.Bt_Cancel.TabIndex = 17
        Me.Bt_Cancel.Text = "ยกเลิก"
        Me.Bt_Cancel.UseVisualStyleBackColor = True
        '
        'Bt_Add
        '
        Me.Bt_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Add.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Bt_Add.ForeColor = System.Drawing.SystemColors.Window
        Me.Bt_Add.Image = Global.Technic_Coffee.My.Resources.Resources.bt_add1
        Me.Bt_Add.Location = New System.Drawing.Point(455, 351)
        Me.Bt_Add.Name = "Bt_Add"
        Me.Bt_Add.Size = New System.Drawing.Size(85, 28)
        Me.Bt_Add.TabIndex = 16
        Me.Bt_Add.Text = "เพิ่ม"
        Me.Bt_Add.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PB_Customer
        '
        Me.PB_Customer.Location = New System.Drawing.Point(422, 125)
        Me.PB_Customer.Name = "PB_Customer"
        Me.PB_Customer.Size = New System.Drawing.Size(150, 150)
        Me.PB_Customer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Customer.TabIndex = 13
        Me.PB_Customer.TabStop = False
        '
        'Form_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.Technic_Coffee.My.Resources.Resources.bg_customer
        Me.ClientSize = New System.Drawing.Size(601, 599)
        Me.Controls.Add(Me.lb_picname)
        Me.Controls.Add(Me.Bt_Update)
        Me.Controls.Add(Me.Bt_Del)
        Me.Controls.Add(Me.Bt_Insert)
        Me.Controls.Add(Me.Bt_Cancel)
        Me.Controls.Add(Me.Bt_Add)
        Me.Controls.Add(Me.bt_browse)
        Me.Controls.Add(Me.DGV_Customer)
        Me.Controls.Add(Me.PB_Customer)
        Me.Controls.Add(Me.tb_cusname)
        Me.Controls.Add(Me.tb_cusid)
        Me.Controls.Add(Me.lb_cusname)
        Me.Controls.Add(Me.lb_cusid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Customer"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DGV_Customer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_browse As System.Windows.Forms.Button
    Friend WithEvents DGV_Customer As System.Windows.Forms.DataGridView
    Friend WithEvents PB_Customer As System.Windows.Forms.PictureBox
    Friend WithEvents tb_cusname As System.Windows.Forms.TextBox
    Friend WithEvents tb_cusid As System.Windows.Forms.TextBox
    Friend WithEvents lb_cusname As System.Windows.Forms.Label
    Friend WithEvents lb_cusid As System.Windows.Forms.Label
    Friend WithEvents lb_picname As System.Windows.Forms.Label
    Friend WithEvents Bt_Update As System.Windows.Forms.Button
    Friend WithEvents Bt_Del As System.Windows.Forms.Button
    Friend WithEvents Bt_Insert As System.Windows.Forms.Button
    Friend WithEvents Bt_Cancel As System.Windows.Forms.Button
    Friend WithEvents Bt_Add As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
