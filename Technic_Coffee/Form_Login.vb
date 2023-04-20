Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class Form_Login
    Public ConnDB As ConnectDB
    Dim Dset As New DataSet
    Dim isDatalogin As Boolean = False
    Public user_status As String = ""
    Private Sub Form_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB = New ConnectDB
        ' tb_user.TabStop = True
        tb_user.TabIndex = 0
        bt_login.TabIndex = 2
        'Form1.Show()
    End Sub
    Private Sub bt_exit_Click(sender As Object, e As EventArgs) Handles bt_exit.Click
        If MessageBox.Show("YES เพื่อออกจากโปรแกรม", "แจ้งข่าวสาร", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            Me.Dispose()
            Form1.Dispose()
            Application.Exit()
        End If
    End Sub

    Private Sub bt_login_Click(sender As Object, e As EventArgs) Handles bt_login.Click
        login_password()
    End Sub
    Private Sub login_password()
        Try
            If isDatalogin = True Then
                Dset.Tables("my_login").Clear()
            End If
            Dim sql As String = ""
            sql = "Select * From tb_login Where user_login = '" & tb_user.Text & "'"
            sql += " AND pass_login = '" & tb_pass.Text & "'"
            Dim da As New OleDb.OleDbDataAdapter(sql, ConnDB.Conn)
            da.Fill(Dset, "my_login")
            Dim n As Integer = Dset.Tables("my_login").Rows.Count

            'MessageBox.Show(user_status)
            If n > 0 Then
                user_status = Dset.Tables("my_login").Rows(0)(1)

                If user_status.Equals("Admin") Then
                    Form1.enaBleReport()
                Else
                    Form1.disaBleReport()
                End If

                Form1.Show()


                Me.Dispose()
            Else
                MessageBox.Show("ชื่อผู้ใช้ หรือ รหัสผ่านไม่ถูกต้อง กรุณาป้อนใหม่", "กรุณาตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            tb_user.Clear()
            tb_pass.Clear()
            isDatalogin = True
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            MessageBox.Show("รหัสผ่านฐานข้อมูลไม่ถูกต้อง", "กรุณาตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub tb_pass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_pass.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)
        If keyAscii = 13 Then
            login_password()
        End If
    End Sub
End Class