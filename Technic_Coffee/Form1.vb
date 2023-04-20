Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class Form1
    Public ConnDB As ConnectDB
    Dim Dset As New DataSet
    Dim dt As DataTable
    Dim Dset2 As New DataSet
    Dim dt2 As DataTable
    Dim CurrentRecord As Integer = 0
    Dim CurrentRecord2 As Integer = 0
    Private ins As Class_insert
    Private del As Class_Delete
    Private up_date As Class_update
    Dim isdata As Boolean = False
    Dim isdata2 As Boolean = False
    Dim isdataProduct As Boolean = False
    Dim tmpFilename As String = ""
    Dim picName As String = ""
    Public orId As String = ""
    Dim isdataMax As Boolean = False
    Dim isdataHave As Boolean = False
    Dim order_id As Integer
    Dim isdataCusName As Boolean = False
    Dim buyTime As String = ""
    Dim isdata_totalPrice As Boolean = False
    Dim proiddel As String = ""
    Private rowIndex As Integer = 0
    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Show()
        Form_Login.ShowDialog()
        ConnDB = New ConnectDB
        Lb_OrderID.Text = "Sale #ID"
        'MessageBox.Show(Now)
        ' ErrorProvider1.SetError(TB_ProductID, "Correct")
    End Sub
    Public Sub disaBleReport()
        รายางานToolStripMenuItem.Enabled = False
    End Sub
    Public Sub enaBleReport()
        รายางานToolStripMenuItem.Enabled = True
    End Sub
    Private Sub showBuyProduct()
        If isdata = True Then
            Dset.Tables("my_coffee").Clear()
        End If
        Dim sql As String
        Try
            sql = "Select od.product_id,pd.product_name,od.product_amount,od.product_price,(od.product_amount * od.product_price) AS NewTotal"
            sql += " From tb_order_detail od,tb_product pd"
            sql += " Where od.buy_time='" & buyTime & "'"
            sql += " AND od.product_id=pd.product_id"
            sql += " Order By od.buy_time DESC"
            Dim da As New OleDb.OleDbDataAdapter(sql, ConnDB.Conn)
            da.Fill(Dset, "my_coffee")
            DGV_Coffee.DataSource = Dset.Tables("my_coffee")
            'dt = Dset.Tables("my_coffee")
            'CurrentRecord = Me.BindingContext(Dset, "my_coffee").Position + 1
            isdata = True
        Catch ex As Exception

        End Try

        totalPrice()
    End Sub
    Private Sub totalPrice()
        Dim totalPrice As Double = 0.0
        If isdata_totalPrice = True Then
            Dset.Tables("my_totalPrice").Clear()
        End If
        Dim sql As String
        Try
            sql = "Select od.product_id,pd.product_name,od.product_amount,od.product_price,(od.product_amount * od.product_price) AS NewTotalNew"
            sql += " From tb_order_detail od,tb_product pd"
            sql += " Where od.buy_time='" & buyTime & "'"
            sql += " AND od.product_id=pd.product_id"
            sql += " Order By od.buy_time DESC"
            Dim da As New OleDb.OleDbDataAdapter(sql, ConnDB.Conn)
            da.Fill(Dset, "my_totalPrice")
            Dim recCount As Integer = Dset.Tables("my_totalPrice").Rows.Count
            Dim n As Integer = 0
            For n = 0 To recCount - 1
                totalPrice += CDbl(Dset.Tables("my_totalPrice").Rows(n)(4))
            Next
            'Dim new_tp As String = FormatNumber(tp, 2, , , TriState.True)
            LB_TotalPrice.Text = FormatNumber(totalPrice, 2, , , TriState.True)
            '    MessageBox.Show(totalPrice)
            isdata_totalPrice = True
            'DGV_Coffee.DataSource = Dset.Tables("my_coffee")
            'dt = Dset.Tables("my_coffee")
            'CurrentRecord = Me.BindingContext(Dset, "my_coffee").Position + 1
            'isdata = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub checkOrderID()

        If order_id.Equals(0) Then
            MessageBox.Show("กรุณาสร้าง Sale ID ก่อน", "แจ้งข่าวสาร", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'MessageBox.Show("มีอยู่แล้ว")
            buyProduct()
        End If

    End Sub
    Private Sub buyProduct()
        With ConnDB.Conn
            If .State = ConnectionState.Closed Then
                .Open()
            End If
            If isdataProduct = True Then
                Dset.Tables("my_product").Clear()
            End If

            Try
                Dim sql As String = "Select * From tb_Product"
                sql += " Where product_id='" & Trim(TB_ProductID.Text) & "'"
                Dim da As New OleDb.OleDbDataAdapter(sql, ConnDB.Conn)
                da.Fill(Dset, "my_product")
                Dim countRec As Integer = Dset.Tables("my_product").Rows.Count
                If countRec >= 1 Then
                    proiddel = Dset.Tables("my_product").Rows(0)(0)
                    ' MessageBox.Show(proiddel)
                    TB_productName.Text = Dset.Tables("my_product").Rows(0)(1)
                    TB_Price.Text = Dset.Tables("my_product").Rows(0)(2)
                    Dim namePic As String = Dset.Tables("my_product").Rows(0)(3)
                    ShowPicPro(namePic)
                    'TB_productName.DataBindings.Add("text", Dset, "my_product.product_name")
                    isdataProduct = True
                    ' checkOrderID()
                    insertOrderDetail()

                Else
                    MessageBox.Show("ไม่มีรายการสินค้าตามรหัสนี้", "แจ้งข่าวสาร", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
            End Try
            TB_ProductID.Clear()
            TB_ProductID.Focus()
        End With
    End Sub
    Private Sub ShowPicPro(ByVal namePic As String)
        Dim picPath As String = "Picture\Product\"
        Try
            Dim picShow As New Bitmap(picPath & namePic)
            PB_Product.Image = picShow
            '  PB_Product.Image = picShow
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            Dim picNo As String = "Picture\Product\nopic.png"
            Dim picShow As New Bitmap(picNo)
            PB_Product.Image = picShow
            '  PB_Product.Image = picShow
        End Try
    End Sub
    Private Sub ShowPicCus(ByVal namePic As String)
        Dim picPath As String = "Picture\Customer\"
        Try
            Dim picShow As New Bitmap(picPath & namePic)
            PB_Customer.Image = picShow
            '  PB_Product.Image = picShow
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            Dim picNo As String = "Picture\Customer\nopic.png"
            Dim picShow As New Bitmap(picNo)
            PB_Customer.Image = picShow
            '  PB_Product.Image = picShow
        End Try
    End Sub
    Private Sub insertOrderDetail()
        With ConnDB.Conn
            If .State = ConnectionState.Closed Then
                .Open()
            End If
        End With
        Try
            Dim oid As Integer = order_id
            Dim amount As Integer = CInt(TB_amount.Text)
            'Dim price As Integer = CDbl(TB_Price.Text)
            'Dim total_per_Price As Double = (amount * price)
            Dim sql As String = "Insert into tb_order_detail (product_id,product_amount,product_price,buy_time)"
            sql += " Values('" & Trim(TB_ProductID.Text) & "','" & amount & "','" & Trim(TB_Price.Text) & "','" & buyTime & "')"
            'MessageBox.Show(sql)
            Dim cmd As New OleDb.OleDbCommand(sql, ConnDB.Conn)
            Dim incmd As Integer = cmd.ExecuteNonQuery

            If incmd >= 1 Then
                showBuyProduct()
            End If
        Catch ex As Exception
            MessageBox.Show("มีสินค้าอยู่ในรายการ", "แจ้งข่าวสาร", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        TB_amount.Text = "1"

    End Sub
    Private Sub Bt_Order_Click(sender As Object, e As EventArgs) Handles Bt_Order.Click
        createOrderID()
        Lb_OrderID.Text = order_id
        TB_ProductID.ReadOnly = False
        TB_ProductID.Clear()
        TB_ProductID.Focus()
        buyTime = Now
        ErrorProvider1.Clear()
        ErrorProvider1.SetError(TB_ProductID, "รหัสสินค้า")
    End Sub
    Private Sub createOrderID()
        With ConnDB.Conn
            If .State = ConnectionState.Closed Then
                .Open()
            End If
        End With
        If isdataHave = True Then
            Dset.Tables("my_idHave").Clear()
        End If
        Try
            Dim sql As String = "Select order_id From tb_order Where order_id=1000"
            Dim da As New OleDb.OleDbDataAdapter(sql, ConnDB.Conn)
            da.Fill(Dset, "my_idHave")
            Dim recCount As Integer = Dset.Tables("my_idHave").Rows.Count
            If recCount >= 1 Then
                checkMax()
                'MessageBox.Show(order_id)
            Else
                'MessageBox.Show("ไม่มี " & recCount)
                order_id = 1000
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        isdataHave = True
    End Sub
    Private Sub checkMax()
        With ConnDB.Conn
            If .State = ConnectionState.Closed Then
                .Open()
            End If
        End With
        If isdataMax = True Then
            Dset.Tables("my_idmax").Clear()
        End If
        Try
            Dim sql As String = "select max(order_id) as newid From tb_order"
            Dim da As New OleDb.OleDbDataAdapter(sql, ConnDB.Conn)
            da.Fill(Dset, "my_idmax")
            order_id = (Dset.Tables("my_idmax").Rows(0)(0) + 1)
            isdataMax = True

        Catch ex As Exception

        End Try
    End Sub
    Private Sub TB_ProductID_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_ProductID.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                testCreatId()
                ErrorProvider1.SetError(TB_ProductID, "รหัสสินค้า")
        End Select
    End Sub
    Private Sub testCreatId()
        createOrderID()
        Lb_OrderID.Text = order_id
        TB_ProductID.ReadOnly = False
        TB_ProductID.Clear()
        TB_ProductID.Focus()
        buyTime = Now
    End Sub
    Private Sub TB_ProductID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_ProductID.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        Dim number As Integer = 0
        If Integer.TryParse(TB_ProductID.Text, number) Then
            TB_amount.Text = Trim(TB_ProductID.Text)
            TB_ProductID.Text = ""
        End If
        If KeyAscii = 13 Then
            checkOrderID()
        End If
        If KeyAscii = 32 Then
            If order_id.Equals(0) Then
                TB_ProductID.Clear()
                TB_ProductID.Focus()
            Else
                TB_CustomerID.ReadOnly = False
                TB_CustomerID.Clear()
                TB_CustomerID.Focus()
                ErrorProvider1.Clear()
                ErrorProvider1.SetError(TB_CustomerID, "รหัสลูกค้า")
            End If
        End If
    End Sub
    Private Sub TB_CustomerID_DoubleClick(sender As Object, e As EventArgs) Handles TB_CustomerID.DoubleClick
        CheckBox1.Checked = False
        TB_CustomerID.Text = ""
    End Sub
    Private Sub TB_CustomerID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_CustomerID.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If KeyAscii = 32 Then
            'TB_CustomerID.Clear()
            'TB_CustomerID.Focus()
            If TB_CustomerID.Text = "" Or TB_CustomerID.Text = " " Then
                TB_CustomerID.Text = ""
                TB_CustomerID.Clear()
                MessageBox.Show("กรุณากรอกรหัสลูกค้า", "แจ้งข่าวสาร", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TB_CustomerID.Clear()
            Else
                insertOrder()
                Bt_Order.Focus()
                CheckBox1.Checked = False
                TB_CustomerID.Text = ""
                ErrorProvider1.Clear()
                ErrorProvider1.SetError(Lb_OrderID, "สร้าง order id")
            End If
        End If
            If KeyAscii = 13 Then
            shownamecus()
            'insertOrder()
        End If
    End Sub
    Private Sub insertOrder()
        With ConnDB.Conn
            If .State = ConnectionState.Closed Then
                .Open()
            End If
        End With
        Try
            Dim sql As String = "insert into tb_order"
            sql += " Values('" & order_id & "','" & DTP_Now.Text & "','" & Trim(TB_CustomerID.Text) & "')"
            Dim cmd As New OleDb.OleDbCommand(sql, ConnDB.Conn)
            Dim inrec As Integer = cmd.ExecuteNonQuery
            If inrec >= 1 Then
                MessageBox.Show("จัดการข้อมูลการขายเรียบร้อยแล้ว", "แจ้งข่าวสาร", MessageBoxButtons.OK, MessageBoxIcon.Information)
                updateOrderDetail()
                order_id = 0
                buyTime = 0
                Lb_OrderID.Text = "Sale #ID"
                TB_CustomerID.Clear()
                showBuyProduct()
                TB_ProductID.Focus()
                'updateOrderDetail()
                clear_all()
            Else
                MessageBox.Show("ไม่สามารถจัดการข้อมูลการขายได้", "แจ้งข่าวสาร", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            TB_ProductID.Clear()
            TB_ProductID.Focus()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub updateOrderDetail()
        ' MessageBox.Show(order_id)
        ' MessageBox.Show(buyTime)
        With ConnDB.Conn
            If .State = ConnectionState.Closed Then
                .Open()
            End If
        End With
        Try
            Dim sql As String = "Update tb_order_detail set order_id='" & order_id & "'"
            sql += " Where buy_time='" & buyTime & "'"
            Dim cmd As New OleDb.OleDbCommand(sql, ConnDB.Conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub clear_all()
        TB_CustomerID.Text = ""
        TB_CustomerName.Text = ""
        TB_productName.Text = ""
        Dim picNocus As String = "Picture/customer/nopic.png"
        Dim picShowcus As New Bitmap(picNocus)
        PB_Customer.Image = picShowcus

        'Dim picNopro As String = "Picture/product/cf_nopic.png"
        'Dim picShowpro As New Bitmap(picNopro)
        ' PB_Product.Image = picShowpro
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TB_CustomerID.Text = "" Or TB_CustomerID.Text = " " Then
            TB_CustomerID.Text = ""
            TB_CustomerID.Clear()
            MessageBox.Show("กรุณากรอกรหัสลูกค้า", "แจ้งข่าวสาร", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TB_CustomerID.Clear()
        Else
            TB_ProductID.ReadOnly = True
            TB_CustomerID.ReadOnly = True
            insertOrder()
            clear_all()
            Bt_Order.Focus()
            CheckBox1.Checked = False
            TB_CustomerID.Text = ""
        End If
    End Sub
    Private Sub shownamecus()
        With ConnDB.Conn
            If .State = ConnectionState.Closed Then
                .Open()
            End If
            If isdataCusName = True Then
                Dset.Tables("my_customer").Clear()
            End If

            Try
                Dim sql As String = "Select * From tb_customer"
                sql += " Where cus_id='" & Trim(TB_CustomerID.Text) & "'"
                Dim da As New OleDb.OleDbDataAdapter(sql, ConnDB.Conn)
                da.Fill(Dset, "my_customer")
                Dim countRec As Integer = Dset.Tables("my_customer").Rows.Count
                If countRec >= 1 Then
                    TB_CustomerName.Text = Dset.Tables("my_customer").Rows(0)(1)
                    Dim cusid As String = Dset.Tables("my_customer").Rows(0)(2)
                    ShowPicture(cusid)
                    'TB_Price.Text = Dset.Tables("my_customer").Rows(0)(2)
                    'TB_productName.DataBindings.Add("text", Dset, "my_product.product_name")
                    isdataCusName = True
                    'checkOrderID()
                    '     insertOrderDetail()

                Else
                    MessageBox.Show("ไม่มีชื่อลูกค้าตามรหัสนี้", "แจ้งข่าวสาร", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
            End Try
            '    TB_ProductID.Clear()
            '  TB_ProductID.Focus()
        End With
    End Sub
    Private Sub ShowPicture(ByVal cusid As String)
        Dim picPath As String = "Picture/customer/"
        Try


            Dim picShow As New Bitmap(picPath & cusid)
            PB_Customer.Image = picShow
        Catch ex As Exception
            Dim picNo As String = "Picture/customer/nopic.png"
            Dim picShow As New Bitmap(picNo)
            PB_Customer.Image = picShow
        End Try


    End Sub
    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        'Dim MainMenu As New Form_Product
        'MainMenu.Show()
        Form_Product.ShowDialog()
    End Sub
    Private Sub DedeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DedeToolStripMenuItem.Click
        ' Dim MainMenu As New Form_Customer
        'MainMenu.Show()
        Form_Customer.ShowDialog()
    End Sub
    Private Sub นำเขาขอมลToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles นำเขาขอมลToolStripMenuItem.Click
        Try
            If (OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK) Then
                'MessageBox.Show(OpenFileDialog1.FileName)
                tmpFilename = OpenFileDialog1.FileName
                'MessageBox.Show(tmpFilename)
                Try
                    Dim line As String
                    Dim readFile As System.IO.TextReader = New StreamReader(tmpFilename)
                    '  MessageBox.Show(tmpFilename)
                    While True
                        line = readFile.ReadLine()  'อ่านไฟล์ทีละบรรทัด เริ่มต้นบรรทัดที่ 0 
                        Dim newline() As String = Split(line, ",")  'แบ่งแล้วใส่ใน a
                        If line Is Nothing Then
                            Exit While
                        Else
                            Dim stuid As String = newline(0)
                            Dim fname As String = newline(1) & newline(2) & " " & newline(3)
                            ' MessageBox.Show(stuid)
                            'MessageBox.Show(fname)
                            insertData(stuid, fname)
                        End If
                    End While
                    readFile.Close()
                    readFile = Nothing
                Catch ex As IOException
                    MessageBox.Show(ex.ToString)
                    ' MsgBox(ex.ToString)
                End Try

            Else
                MessageBox.Show("คุณไม่ได้เลือกไฟล์ กรุณาเลือกไฟล์", "แจ้งข่าวสาร", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("กรุณาเลือกไฟล์")
            ' tmpFilename
        End Try
    End Sub
    Private Sub insertData(ByVal id As String, ByVal fn As String)
        With ConnDB.Conn
            If .State = ConnectionState.Closed Then
                .Open()
            End If
        End With
        Dim np As String = id & ".jpg"
        Try
            Dim sql As String = "insert into tb_customer(cus_id,cus_fullname,cus_pic)"
            sql += " Values('" & id & "','" & fn & "','" & np & "')"
            Dim cmd As New OleDb.OleDbCommand(sql, ConnDB.Conn)
            cmd.ExecuteNonQuery()
            Form_Progress.Show()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ออกจากระบบToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ออกจากระบบToolStripMenuItem.Click
        Form_Login.ShowDialog()
    End Sub

    Private Sub รายางานToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รายางานToolStripMenuItem.Click
        Form_Report.ShowDialog()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TB_CustomerID.Focus()
        TB_CustomerID.Text = "No Member"

    End Sub

    Private Sub DGV_Coffee_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Coffee.CellMouseDoubleClick
        Dim id As String = DGV_Coffee.Rows.Item(e.RowIndex).Cells(0).Value().ToString
        'Dim d As String = DGV_Coffee.Rows.Item(e.RowIndex).Cells(1).Value().ToString
        ' Dim m As String = DGV_Coffee.Rows.Item(e.RowIndex).Cells(2).Value().ToString
        ' Dim y As String = DGV_Coffee.Rows.Item(e.RowIndex).Cells(3).Value().ToString
        ' Dim tin As String = DGV_Coffee.Rows.Item(e.RowIndex).Cells(4).Value().ToString
        If MessageBox.Show("คุณต้องการลบข้อมูลหรือไม่", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            With ConnDB.Conn
                If .State = ConnectionState.Closed Then
                    .Open()
                End If
            End With
            'Dim sql As String = "Delete From Time_Service"
            'sql += " Where deposit_d='" & d & "'"
            'sql += " AND deposit_m='" & m & "'"
            'sql += " AND deposit_y='" & y & "'"
            'sql += " AND deposit_time_in='" & tin & "'"
            'sql += " AND stu_id='" & id & "'"
            Dim sql As String = "Delete From tb_order_detail"
            sql += " where product_id = '" & id & "'"
            sql += " AND order_id IS NULL"
            Dim cmd As New OleDb.OleDbCommand(sql, ConnDB.Conn)
            Dim del As Integer = cmd.ExecuteNonQuery
            If del >= 1 Then
                showBuyProduct()
                TB_ProductID.Focus()
            End If
        Else

        End If
    End Sub
    Private Sub Bt_Order_KeyDown(sender As Object, e As KeyEventArgs) Handles Bt_Order.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                testCreatId()
                ErrorProvider1.Clear()
                ErrorProvider1.SetError(TB_ProductID, "รหัสสินค้า")
        End Select
    End Sub

    Private Sub เกยวกบToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles เกยวกบToolStripMenuItem.Click
        Form_About.ShowDialog()
    End Sub
End Class
