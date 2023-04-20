Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class Form_Customer
    Dim isdata As Boolean = False
    Public ConnDB As ConnectDB
    Dim Dset As New DataSet
    Dim dt As DataTable
    Dim CurrentRecord As Integer = 0
    Dim tmpFilename As String = ""
    Dim picname As String = "nopic.png"
    Private Sub Form_Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB = New ConnectDB
        showCustomer()
        Bt_Add.Enabled = True
        Bt_Insert.Enabled = False
        Bt_Cancel.Enabled = False
        ' showDataIncontrol()
    End Sub
    Private Sub showCustomer()
        If isdata = True Then
            Dset.Tables("my_customer").Clear()
        End If
        Dim sql As String
        Try
            sql = "Select * From tb_customer"
            sql += " Order By cus_id ASC"
            Dim da As New OleDb.OleDbDataAdapter(sql, ConnDB.Conn)
            da.Fill(Dset, "my_customer")
            DGV_Customer.DataSource = Dset.Tables("my_customer")
            'dt = Dset.Tables("my_coffee")
            ' CurrentRecord = Me.BindingContext(Dset, "my_coffee").Position + 1
            isdata = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub showDataIncontrol()
        tb_cusid.DataBindings.Add("text", Dset, "my_customer.cus_id")
    End Sub
    Private Sub DGV_Customer_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Customer.CellMouseUp
        Try
            tb_cusid.Text = DGV_Customer.Rows.Item(e.RowIndex).Cells(0).Value()
            tb_cusname.Text = DGV_Customer.Rows.Item(e.RowIndex).Cells(1).Value()
            lb_picname.Text = DGV_Customer.Rows.Item(e.RowIndex).Cells(2).Value()
            Dim namename As String = lb_picname.Text
            ShowPicture(namename)
        Catch ex As Exception
            lb_picname.Text = "nopic.png"
            ShowPicture(lb_picname.Text)
        End Try
    End Sub
    Private Sub ShowPicture(ByVal namePic As String)
        Dim picPath As String = "Picture\customer\"
        Try
            Dim picShow As New Bitmap(picPath & namePic)
            PB_Customer.Image = picShow
            '  PB_Product.Image = picShow
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            Dim picNo As String = "Picture\customer\nopic.png"
            Dim picShow As New Bitmap(picNo)
            PB_Customer.Image = picShow
            '  PB_Product.Image = picShow
        End Try

    End Sub
    Private Sub Bt_Add_Click(sender As Object, e As EventArgs) Handles Bt_Add.Click
        ClearData()
        Bt_Cancel.Enabled = True
        Bt_Add.Enabled = False
        Bt_Insert.Enabled = True
        Bt_Del.Enabled = False
        Bt_Update.Enabled = False
        tb_cusid.Focus()
    End Sub
    Private Sub ClearData()
        tb_cusid.Text = ""
        tb_cusname.Text = ""
    End Sub
    Private Sub Bt_Cancel_Click(sender As Object, e As EventArgs) Handles Bt_Cancel.Click
        showCustomer()
        ClearData()
        Bt_Add.Enabled = True
        Bt_Cancel.Enabled = False
        Bt_Insert.Enabled = False
        Bt_Del.Enabled = True
        Bt_Update.Enabled = True
    End Sub

    Private Sub Bt_Insert_Click(sender As Object, e As EventArgs) Handles Bt_Insert.Click
        With ConnDB.Conn
            If .State = ConnectionState.Closed Then
                .Open()
            End If
        End With
        Try
            Dim sql As String = "Insert into tb_customer (cus_id,cus_fullname,cus_pic)"
            sql += " Values('" & tb_cusid.Text & "','" & tb_cusname.Text & "','" & picname & "')"
            Dim cmd As New OleDb.OleDbCommand(sql, ConnDB.Conn)
            Dim incmd As Integer = cmd.ExecuteNonQuery

            If incmd >= 1 Then
                MessageBox.Show("เพิ่มข้อมูลลูกค้าเรียบร้อยแล้ว", "แจ้งข่าวสาร", MessageBoxButtons.OK, MessageBoxIcon.Information)
                showCustomer()
            End If
            'Dim ins As New Class_insert()
            'If ins.insert(sql) = True Then
            ' showProduct()
            'Bt_Add.Enabled = True
            'Bt_Cancel.Enabled = False
            'Bt_Insert.Enabled = False
            ' End If
            'showProduct()
            ClearData()
            Bt_Add.Enabled = True
            Bt_Cancel.Enabled = False
            Bt_Insert.Enabled = False
            Bt_Del.Enabled = True
            Bt_Update.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        showCustomer()
    End Sub

    Private Sub Bt_Del_Click(sender As Object, e As EventArgs) Handles Bt_Del.Click
        With ConnDB.Conn
            If .State = ConnectionState.Closed Then
                .Open()
            End If
        End With
        Try
            If MessageBox.Show("คุณต้องการลบข้อมูลหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim sql As String = "Delete From tb_customer"
                sql += " where cus_id = '" & tb_cusid.Text & "'"
                ' MessageBox.Show(sql)
                Dim del As New Class_Delete
                If del.Delete(sql) = True Then
                    showCustomer()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Bt_Update_Click(sender As Object, e As EventArgs) Handles Bt_Update.Click
        Try
            If MessageBox.Show("คุณต้องการแก้ไขข้อมูลหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim sql As String = "Update tb_customer"
                sql += " Set cus_id = '" & tb_cusid.Text & "',"
                sql += " cus_fullname = '" & tb_cusname.Text & "',"
                sql += " cus_pic = '" & picname & "'"
                sql += " where cus_id = '" & tb_cusid.Text & "'"
                Dim up_date As New Class_update
                If up_date.update(sql) = True Then
                    showCustomer()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        showCustomer()
    End Sub

    Private Sub bt_browse_Click(sender As Object, e As EventArgs) Handles bt_browse.Click
        If (OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK) Then
            tmpFilename = OpenFileDialog1.FileName
            PB_Customer.Image = Image.FromFile(tmpFilename)
            Dim pic() As String
            'Dim picname As String
            pic = tmpFilename.Split("\")
            Dim i As Integer
            For i = 0 To pic.Length - 1
                picname = pic(i)

            Next

        End If
        ' MessageBox.Show(picname)
        copyFile(picname)
    End Sub
    Private Sub copyFile(ByVal pic As String)
        '  MessageBox.Show(pic)
        lb_picname.Text = picname
        Try
            If File.Exists(tmpFilename) = True Then
                File.Copy(tmpFilename, "Picture\customer\" & pic)

            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class