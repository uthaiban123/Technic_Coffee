<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Login
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
        Me.bt_login = New System.Windows.Forms.Button()
        Me.tb_user = New System.Windows.Forms.TextBox()
        Me.tb_pass = New System.Windows.Forms.TextBox()
        Me.bt_exit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bt_login
        '
        Me.bt_login.BackColor = System.Drawing.Color.Transparent
        Me.bt_login.BackgroundImage = Global.Technic_Coffee.My.Resources.Resources.bt_login
        Me.bt_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_login.ForeColor = System.Drawing.Color.Transparent
        Me.bt_login.Location = New System.Drawing.Point(272, 236)
        Me.bt_login.Name = "bt_login"
        Me.bt_login.Size = New System.Drawing.Size(85, 28)
        Me.bt_login.TabIndex = 0
        Me.bt_login.UseVisualStyleBackColor = False
        '
        'tb_user
        '
        Me.tb_user.BackColor = System.Drawing.Color.Gainsboro
        Me.tb_user.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_user.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_user.Location = New System.Drawing.Point(253, 140)
        Me.tb_user.Name = "tb_user"
        Me.tb_user.Size = New System.Drawing.Size(195, 22)
        Me.tb_user.TabIndex = 1
        '
        'tb_pass
        '
        Me.tb_pass.BackColor = System.Drawing.Color.Gainsboro
        Me.tb_pass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_pass.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_pass.Location = New System.Drawing.Point(253, 189)
        Me.tb_pass.Name = "tb_pass"
        Me.tb_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_pass.Size = New System.Drawing.Size(195, 22)
        Me.tb_pass.TabIndex = 2
        '
        'bt_exit
        '
        Me.bt_exit.BackColor = System.Drawing.Color.Transparent
        Me.bt_exit.BackgroundImage = Global.Technic_Coffee.My.Resources.Resources.bt_exit
        Me.bt_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_exit.ForeColor = System.Drawing.Color.Transparent
        Me.bt_exit.Location = New System.Drawing.Point(363, 236)
        Me.bt_exit.Name = "bt_exit"
        Me.bt_exit.Size = New System.Drawing.Size(85, 28)
        Me.bt_exit.TabIndex = 3
        Me.bt_exit.UseVisualStyleBackColor = False
        '
        'Form_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Technic_Coffee.My.Resources.Resources.bg_login
        Me.ClientSize = New System.Drawing.Size(484, 299)
        Me.ControlBox = False
        Me.Controls.Add(Me.bt_exit)
        Me.Controls.Add(Me.tb_pass)
        Me.Controls.Add(Me.tb_user)
        Me.Controls.Add(Me.bt_login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form_Login"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Program Technic Coffee Service"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_login As System.Windows.Forms.Button
    Friend WithEvents tb_user As System.Windows.Forms.TextBox
    Friend WithEvents tb_pass As System.Windows.Forms.TextBox
    Friend WithEvents bt_exit As System.Windows.Forms.Button
End Class
