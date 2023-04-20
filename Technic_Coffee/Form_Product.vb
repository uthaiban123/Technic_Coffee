Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class Form_Product
    Dim isdata As Boolean = False
    Public ConnDB As ConnectDB
    Dim Dset As New DataSet
    Dim dt As DataTable
    Dim CurrentRecord As Integer = 0
    Dim tmpFilename As String = ""
    Dim picname As String = "nopic.png"
    Private Sub Form_Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB = New ConnectDB
        showProduct()
        Bt_Add.Enabled = True
        Bt_Insert.Enabled = False
        Bt_Cancel.Enabled = False
    End Sub
    Private Sub showProduct()
        If isdata = True Then
            Dset.Tables("my_product").Clear()
        End If
        Dim sql As String
        Try
            sql = "Select product_id,product_name,product_price,product_pic From tb_product"
            sql += " Order By product_id ASC"
            Dim da As New OleDb.OleDbDataAdapter(sql, ConnDB.Conn)
            da.Fill(Dset, "my_product")
            DGV_Product.DataSource = Dset.Tables("my_product")
            'dt = Dset.Tables("my_coffee")
            ' CurrentRecord = Me.BindingContext(Dset, "my_coffee").Position + 1
            isdata = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub DGV_Product_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Product.CellMouseUp
        Try
            tb_productid.Text = DGV_Product.Rows.Item(e.RowIndex).Cells(0).Value()
            tb_productname.Text = DGV_Product.Rows.Item(e.RowIndex).Cells(1).Value()
            tb_price.Text = DGV_Product.Rows.Item(e.RowIndex).Cells(2).Value()
            lb_picname.Text = DGV_Product.Rows.Item(e.RowIndex).Cells(3).Value()
      
            Dim namename As String = lb_picname.Text
            ShowPicture(namename)
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            lb_picname.Text = "nopic.png"
            ShowPicture(lb_picname.Text)
        End Try


    End Sub
    Private Sub ShowPicture(ByVal namePic As String)
        Dim picPath As String = "Picture\product\"
        Try
            Dim picShow As New Bitmap(picPath & namePic)
            PB_Product.Image = picShow
            '  PB_Product.Image = picShow
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            Dim picNo As String = "Picture\product\nopic.png"
            Dim picShow As New Bitmap(picNo)
            PB_Product.Image = picShow
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
        tb_productid.Focus()
    End Sub
    Private Sub ClearData()
        tb_price.Text = ""
        tb_productid.Text = ""
        tb_productname.Text = ""
    End Sub

    Private Sub Bt_Cancel_Click(sender As Object, e As EventArgs) Handles Bt_Cancel.Click
        showProduct()
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
            Dim sql As String = "Insert into tb_product (product_id,product_name,product_price,product_pic)"
            sql += " Values('" & tb_productid.Text & "','" & tb_productname.Text & "','" & tb_price.Text & "','" & picname & "')"
            Dim cmd As New OleDb.OleDbCommand(sql, ConnDB.Conn)
            Dim incmd As Integer = cmd.ExecuteNonQuery

            If incmd >= 1 Then
                MessageBox.Show("เพิ่มข้อมูลสินค้าเรียบร้อยแล้ว", "แจ้งข่าวสาร", MessageBoxButtons.OK, MessageBoxIcon.Information)
                showProduct()
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
        showProduct()
    End Sub

    Private Sub Bt_Del_Click(sender As Object, e As EventArgs) Handles Bt_Del.Click
        With ConnDB.Conn
            If .State = ConnectionState.Closed Then
                .Open()
            End If
        End With
        Try
            If MessageBox.Show("คุณต้องการลบข้อมูลหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim sql As String = "Delete From tb_product"
                sql += " where product_id = '" & tb_productid.Text & "'"
                Dim del As New Class_Delete
                If del.Delete(sql) = True Then
                    showProduct()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Bt_Update_Click(sender As Object, e As EventArgs) Handles Bt_Update.Click
        Try
            If MessageBox.Show("คุณต้องการแก้ไขข้อมูลหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim sql As String = "Update tb_product"
                sql += " Set product_id = '" & tb_productid.Text & "',"
                sql += " product_name = '" & tb_productname.Text & "',"
                sql += " product_price = '" & tb_price.Text & "',"
                sql += " product_pic = '" & lb_picname.Text & "'"
                sql += " where product_id = '" & tb_productid.Text & "'"
                Dim up_date As New Class_update
                If up_date.update(sql) = True Then
                    showProduct()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        showProduct()
    End Sub

    Private Sub bt_browse_Click(sender As Object, e As EventArgs) Handles bt_browse.Click
        If (OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK) Then
            tmpFilename = OpenFileDialog1.FileName
            PB_Product.Image = Image.FromFile(tmpFilename)
            Dim pic() As String
            'Dim picname As String
            pic = tmpFilename.Split("\")
            Dim i As Integer
            For i = 0 To pic.Length - 1
                picname = pic(i)

            Next

        End If
        Dim picc() As String
        picc = tmpFilename.Split(".")
        MessageBox.Show(picc(1))
        picname = tb_productid.Text
        MessageBox.Show(picname)
        Dim newfinal As String = picname & "." & picc(1)
        MessageBox.Show(newfinal)
        copyFile(newfinal)
    End Sub
    Private Sub copyFile(ByVal pic As String)
        MessageBox.Show(pic)
        lb_picname.Text = pic
        Try
            If File.Exists(tmpFilename) = True Then
                File.Copy(tmpFilename, "Picture\product\" & pic)

            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class