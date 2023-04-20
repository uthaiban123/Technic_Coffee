<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Product
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
        Me.lb_productid = New System.Windows.Forms.Label()
        Me.lb_name = New System.Windows.Forms.Label()
        Me.tb_productid = New System.Windows.Forms.TextBox()
        Me.tb_productname = New System.Windows.Forms.TextBox()
        Me.DGV_Product = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bt_browse = New System.Windows.Forms.Button()
        Me.lb_price = New System.Windows.Forms.Label()
        Me.tb_price = New System.Windows.Forms.TextBox()
        Me.PB_Product = New System.Windows.Forms.PictureBox()
        Me.Bt_Add = New System.Windows.Forms.Button()
        Me.Bt_Cancel = New System.Windows.Forms.Button()
        Me.Bt_Insert = New System.Windows.Forms.Button()
        Me.Bt_Del = New System.Windows.Forms.Button()
        Me.Bt_Update = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lb_picname = New System.Windows.Forms.Label()
        CType(Me.DGV_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lb_productid
        '
        Me.lb_productid.AutoSize = True
        Me.lb_productid.BackColor = System.Drawing.SystemColors.Window
        Me.lb_productid.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_productid.Location = New System.Drawing.Point(62, 125)
        Me.lb_productid.Name = "lb_productid"
        Me.lb_productid.Size = New System.Drawing.Size(71, 29)
        Me.lb_productid.TabIndex = 0
        Me.lb_productid.Text = "รหัสสินค้า"
        '
        'lb_name
        '
        Me.lb_name.AutoSize = True
        Me.lb_name.BackColor = System.Drawing.SystemColors.Window
        Me.lb_name.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_name.Location = New System.Drawing.Point(62, 191)
        Me.lb_name.Name = "lb_name"
        Me.lb_name.Size = New System.Drawing.Size(63, 29)
        Me.lb_name.TabIndex = 1
        Me.lb_name.Text = "ชื่อสินค้า"
        '
        'tb_productid
        '
        Me.tb_productid.BackColor = System.Drawing.Color.Gainsboro
        Me.tb_productid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_productid.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_productid.Location = New System.Drawing.Point(67, 154)
        Me.tb_productid.Name = "tb_productid"
        Me.tb_productid.Size = New System.Drawing.Size(203, 22)
        Me.tb_productid.TabIndex = 2
        '
        'tb_productname
        '
        Me.tb_productname.BackColor = System.Drawing.Color.Gainsboro
        Me.tb_productname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_productname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_productname.Location = New System.Drawing.Point(67, 217)
        Me.tb_productname.Name = "tb_productname"
        Me.tb_productname.Size = New System.Drawing.Size(203, 22)
        Me.tb_productname.TabIndex = 3
        '
        'DGV_Product
        '
        Me.DGV_Product.AllowUserToAddRows = False
        Me.DGV_Product.AllowUserToDeleteRows = False
        Me.DGV_Product.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Product.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Product.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DGV_Product.Location = New System.Drawing.Point(67, 329)
        Me.DGV_Product.Name = "DGV_Product"
        Me.DGV_Product.ReadOnly = True
        Me.DGV_Product.Size = New System.Drawing.Size(386, 258)
        Me.DGV_Product.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "product_id"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cordia New", 15.75!)
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = "รหัสสินค้า"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 97
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "product_name"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cordia New", 15.75!)
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column2.HeaderText = "ชื่อสินค้า"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "product_price"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Cordia New", 15.75!)
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column3.HeaderText = "ราคาสินค้า"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 101
        '
        'bt_browse
        '
        Me.bt_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_browse.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.bt_browse.ForeColor = System.Drawing.SystemColors.Window
        Me.bt_browse.Image = Global.Technic_Coffee.My.Resources.Resources.bt_browse
        Me.bt_browse.Location = New System.Drawing.Point(469, 286)
        Me.bt_browse.Name = "bt_browse"
        Me.bt_browse.Size = New System.Drawing.Size(85, 28)
        Me.bt_browse.TabIndex = 6
        Me.bt_browse.Text = "Browse"
        Me.bt_browse.UseVisualStyleBackColor = True
        '
        'lb_price
        '
        Me.lb_price.AutoSize = True
        Me.lb_price.BackColor = System.Drawing.SystemColors.Window
        Me.lb_price.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_price.Location = New System.Drawing.Point(62, 251)
        Me.lb_price.Name = "lb_price"
        Me.lb_price.Size = New System.Drawing.Size(42, 29)
        Me.lb_price.TabIndex = 7
        Me.lb_price.Text = "ราคา"
        '
        'tb_price
        '
        Me.tb_price.BackColor = System.Drawing.Color.Gainsboro
        Me.tb_price.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_price.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_price.Location = New System.Drawing.Point(67, 276)
        Me.tb_price.Name = "tb_price"
        Me.tb_price.Size = New System.Drawing.Size(203, 22)
        Me.tb_price.TabIndex = 8
        '
        'PB_Product
        '
        Me.PB_Product.Location = New System.Drawing.Point(433, 125)
        Me.PB_Product.Name = "PB_Product"
        Me.PB_Product.Size = New System.Drawing.Size(150, 150)
        Me.PB_Product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Product.TabIndex = 4
        Me.PB_Product.TabStop = False
        '
        'Bt_Add
        '
        Me.Bt_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Add.Font = New System.Drawing.Font("Cordia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Bt_Add.ForeColor = System.Drawing.SystemColors.Window
        Me.Bt_Add.Image = Global.Technic_Coffee.My.Resources.Resources.bt_add1
        Me.Bt_Add.Location = New System.Drawing.Point(469, 380)
        Me.Bt_Add.Name = "Bt_Add"
        Me.Bt_Add.Size = New System.Drawing.Size(85, 28)
        Me.Bt_Add.TabIndex = 9
        Me.Bt_Add.Text = "เพิ่ม"
        Me.Bt_Add.UseVisualStyleBackColor = True
        '
        'Bt_Cancel
        '
        Me.Bt_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Cancel.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Bt_Cancel.ForeColor = System.Drawing.SystemColors.Window
        Me.Bt_Cancel.Image = Global.Technic_Coffee.My.Resources.Resources.bt_cancel
        Me.Bt_Cancel.Location = New System.Drawing.Point(469, 516)
        Me.Bt_Cancel.Name = "Bt_Cancel"
        Me.Bt_Cancel.Size = New System.Drawing.Size(85, 28)
        Me.Bt_Cancel.TabIndex = 10
        Me.Bt_Cancel.Text = "ยกเลิก"
        Me.Bt_Cancel.UseVisualStyleBackColor = True
        '
        'Bt_Insert
        '
        Me.Bt_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Insert.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Bt_Insert.ForeColor = System.Drawing.SystemColors.Window
        Me.Bt_Insert.Image = Global.Technic_Coffee.My.Resources.Resources.bt_save
        Me.Bt_Insert.Location = New System.Drawing.Point(469, 414)
        Me.Bt_Insert.Name = "Bt_Insert"
        Me.Bt_Insert.Size = New System.Drawing.Size(85, 28)
        Me.Bt_Insert.TabIndex = 11
        Me.Bt_Insert.Text = "บันทึก"
        Me.Bt_Insert.UseVisualStyleBackColor = True
        '
        'Bt_Del
        '
        Me.Bt_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Del.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Bt_Del.ForeColor = System.Drawing.SystemColors.Window
        Me.Bt_Del.Image = Global.Technic_Coffee.My.Resources.Resources.bt_delete
        Me.Bt_Del.Location = New System.Drawing.Point(469, 448)
        Me.Bt_Del.Name = "Bt_Del"
        Me.Bt_Del.Size = New System.Drawing.Size(85, 28)
        Me.Bt_Del.TabIndex = 12
        Me.Bt_Del.Text = "ลบ"
        Me.Bt_Del.UseVisualStyleBackColor = True
        '
        'Bt_Update
        '
        Me.Bt_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Update.Font = New System.Drawing.Font("Cordia New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Bt_Update.ForeColor = System.Drawing.SystemColors.Window
        Me.Bt_Update.Image = Global.Technic_Coffee.My.Resources.Resources.bt_edit
        Me.Bt_Update.Location = New System.Drawing.Point(469, 482)
        Me.Bt_Update.Name = "Bt_Update"
        Me.Bt_Update.Size = New System.Drawing.Size(85, 28)
        Me.Bt_Update.TabIndex = 13
        Me.Bt_Update.Text = "แก้ไข"
        Me.Bt_Update.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lb_picname
        '
        Me.lb_picname.AutoSize = True
        Me.lb_picname.Location = New System.Drawing.Point(299, 259)
        Me.lb_picname.Name = "lb_picname"
        Me.lb_picname.Size = New System.Drawing.Size(0, 13)
        Me.lb_picname.TabIndex = 14
        Me.lb_picname.Visible = False
        '
        'Form_Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.Technic_Coffee.My.Resources.Resources.bg_product2
        Me.ClientSize = New System.Drawing.Size(601, 599)
        Me.Controls.Add(Me.lb_picname)
        Me.Controls.Add(Me.Bt_Update)
        Me.Controls.Add(Me.Bt_Del)
        Me.Controls.Add(Me.Bt_Insert)
        Me.Controls.Add(Me.Bt_Cancel)
        Me.Controls.Add(Me.Bt_Add)
        Me.Controls.Add(Me.tb_price)
        Me.Controls.Add(Me.lb_price)
        Me.Controls.Add(Me.bt_browse)
        Me.Controls.Add(Me.DGV_Product)
        Me.Controls.Add(Me.PB_Product)
        Me.Controls.Add(Me.tb_productname)
        Me.Controls.Add(Me.tb_productid)
        Me.Controls.Add(Me.lb_name)
        Me.Controls.Add(Me.lb_productid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Product"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DGV_Product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_productid As System.Windows.Forms.Label
    Friend WithEvents lb_name As System.Windows.Forms.Label
    Friend WithEvents tb_productid As System.Windows.Forms.TextBox
    Friend WithEvents tb_productname As System.Windows.Forms.TextBox
    Friend WithEvents PB_Product As System.Windows.Forms.PictureBox
    Friend WithEvents DGV_Product As System.Windows.Forms.DataGridView
    Friend WithEvents bt_browse As System.Windows.Forms.Button
    Friend WithEvents lb_price As System.Windows.Forms.Label
    Friend WithEvents tb_price As System.Windows.Forms.TextBox
    Friend WithEvents Bt_Add As System.Windows.Forms.Button
    Friend WithEvents Bt_Cancel As System.Windows.Forms.Button
    Friend WithEvents Bt_Insert As System.Windows.Forms.Button
    Friend WithEvents Bt_Del As System.Windows.Forms.Button
    Friend WithEvents Bt_Update As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lb_picname As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
