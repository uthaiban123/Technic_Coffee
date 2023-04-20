Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class Form_Report
    Dim isdata As Boolean = False
    Public ConnDB As ConnectDB
    Dim Dset As New DataSet
    Dim dt As DataTable
    Dim isdataReport As Boolean = False
    Dim CurrentRecord As Integer = 0
    Dim isdataCountAmount As Boolean = False
    Dim isdataNameProduct As Boolean = False
    Dim totalAmount As Integer
    Dim totalPrice As Integer
    Dim dmy_new As String = ""
    Dim text_dmy As String = ""
    Dim name_cus_new As String = ""
    Dim isdataNameCus As Boolean = False
    Dim serch_mem As Boolean = False
    Private Sub Form_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnDB = New ConnectDB
        'showReport()
        dt = New DataTable
        DGV_Report.AutoGenerateColumns = False
        'ComboBox1.SelectedIndex = 0
    End Sub
    Private Sub showReport()
        If isdata = True Then
            Dset.Tables("my_report").Clear()
        End If
        Dim sql As String
        Try
            sql = "Select * From tb_order_detail"
            sql += " Order By order_id ASC"
            Dim da As New OleDb.OleDbDataAdapter(sql, ConnDB.Conn)
            da.Fill(Dset, "my_report")
            'DGV_Report.DataSource = Dset.Tables("my_report")
            'dt = Dset.Tables("my_report")
            'CurrentRecord = Me.BindingContext(Dset, "my_report").Position + 1
            isdata = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub bt_report_Click(sender As Object, e As EventArgs) Handles bt_report.Click
        Dim dmy As String = DTM_report.Text

        Dim sql As String = ""
        Dim new_dmy() As String = Split(dmy, " ")
        If CB_day.Checked = True Then
            dmy_new = dmy
            text_dmy = "ประจำวันที่ "
            'sql = "Select tod.product_id,tod.product_amount,tod.product_price"
            sql = "Select DISTINCT(tod.product_id) "
            ' from tb_order od,tb_order_detail tod"
            sql += " from tb_order od,tb_order_detail tod"
            sql += " Where od.order_dmy='" & DTM_report.Text & "'"
            sql += " AND tod.order_id=od.order_id"
            clearda()
            reportService(sql)
            Label2.Text = "ขายได้ "
            Label8.Text = "ขายได้ "
            name_cus_new = ""

        ElseIf ((CB_month.Checked = True) And (CB_year.Checked = True)) = True Then
            text_dmy = "ประจำเดือน "
            'MessageBox.Show(new_dmy(1) + " " + new_dmy(2))
            dmy_new = new_dmy(1) & " " & new_dmy(2)
            sql = "Select DISTINCT(tod.product_id) "
            ' from tb_order od,tb_order_detail tod"
            sql += " from tb_order od,tb_order_detail tod,tb_product tpt"
            sql += " Where od.order_dmy like '%" & dmy_new & "'"
            sql += " AND tod.order_id=od.order_id"
            'sql += " AND tod.product_id = '" & new_testid(0) & "' "
            'MessageBox.Show(sql.ToString)
            clearda()
            reportService(sql)
            Label2.Text = "ขายได้ "
            Label8.Text = "ขายได้ "
            name_cus_new = ""
            ' Dim m_y As String = new_dmy(1) & " " & new_dmy(2)

            ' sql += " from tb_order od,tb_order_detail tod,tb_product tpt"
            ' sql += " Where od.order_dmy like '%" & m_y & "%'"


            'sql = "Select ts.stu_id,ts.deposit_d,ts.deposit_m,ts.deposit_y,ts.deposit_time_in,ts.deposit_time_out,st.stu_name"
            ' sql += " From Time_Service ts,student st"
            ' sql += " Where  ts.deposit_m='" & new_dmy(1) & "'"
            ' sql += " AND ts.deposit_y='" & new_dmy(2) & "'"
            ' sql += " AND ts.stu_id=st.stu_id"
            '  reportService(sql)

        ElseIf (CB_year.Checked = True) And (CB_day.Checked = False) And (CB_month.Checked = False) Then
            dmy_new = new_dmy(2)
            text_dmy = "ประจำปี "
            ' MessageBox.Show(new_dmy(2))
            'sql = "Select ts.stu_id,ts.deposit_d,ts.deposit_m,ts.deposit_y,ts.deposit_time_in,ts.deposit_time_out,st.stu_name From Time_Service ts,student st"
            'sql += " Where ts.deposit_y='" & new_dmy(2) & "'"
            'sql += " AND ts.stu_id=st.stu_id"

            sql = "Select DISTINCT(tod.product_id) "
            ' from tb_order od,tb_order_detail tod"
            sql += " from tb_order od,tb_order_detail tod,tb_product tpt"
            sql += " Where od.order_dmy like '%" & dmy_new & "'"
            sql += " AND tod.order_id=od.order_id"
            clearda()
            reportService(sql)
            Label2.Text = "ขายได้ "
            Label8.Text = "ขายได้ "
            name_cus_new = ""
            'End If
        ElseIf tb_cus_se.Text <> "" Then
            Dim nname As String = tb_cus_se.Text
            sql = "Select DISTINCT(tod.product_id) "
            ' from tb_order od,tb_order_detail tod"
            sql += " from tb_order od,tb_order_detail tod"
            sql += " Where od.cus_id ='" & Trim(tb_cus_se.Text) & "'"
            sql += " AND tod.order_id=od.order_id"
            clearda()
            reportService(sql)
            Label2.Text = "จำนวนเงิน"
            Label8.Text = "จำนวน "
            If CB_NoMemBer.Checked = True Then

            Else
                nameCus(nname)
            End If

        Else
        MessageBox.Show("ไม่มีระเบียนนักศึกษานี้ในฐานข้อมูล", "แจ้งข่าวสาร", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub reportService(ByVal sql As String)
        DGV_Report.Rows.Clear()
        With ConnDB.Conn
            If .State = ConnectionState.Closed Then
                .Open()
            End If
            If isdataReport = True Then
                Dset.Tables("my_service").Clear()
            End If
        End With
        Try
            'MessageBox.Show(sql)
            Dim da As New OleDb.OleDbDataAdapter(sql, ConnDB.Conn)
            da.Fill(Dset, "my_service")
            'DGV_Report.DataSource = Dset.Tables("my_service")
            Dim countRec As Integer = Dset.Tables("my_service").Rows.Count
            Dim i As Integer = 0
            For i = 0 To countRec - 1
                checkProduct(Dset.Tables("my_service").Rows(i)(0))
                'MessageBox.Show(Dset.Tables("my_service").Rows(i)(0).ToString)
            Next

            'lb_in2.Text = countRec
            isdataReport = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            'MessageBox.Show("ไม่พบข้อมูลที่ต้องการ", "แจ้งข่าวสาร", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try


    End Sub

    Private Sub checkProduct(ByVal pid As String)
        'MessageBox.Show(pid.ToString & vbCrLf)
        'MessageBox.Show(pid)
        'clear()
        coutAmountProduct(pid)
    End Sub

    Private Sub coutAmountProduct(ByVal pid As String)

        With ConnDB.Conn
            If .State = ConnectionState.Closed Then
                .Open()
            End If
            If isdataCountAmount = True Then
                Dset.Tables("my_Amount").Clear()
            End If
        End With
        ' Dim s As String = "มกราคม 2557"
        Dim sql As String = ""
        sql = "Select tod.product_id,tod.product_amount,tod.product_price"
        sql += " from tb_order od,tb_order_detail tod"
        sql += " Where tod.product_id='" & pid & "'"
        If serch_mem = False Then
            sql += " AND od.order_dmy like '%" & dmy_new & "'"
        Else
            sql += " AND od.cus_id='" & Trim(tb_cus_se.Text) & "'"
        End If
        sql += " AND tod.order_id=od.order_id"
        'MessageBox.Show(sql)
        Dim da As New OleDb.OleDbDataAdapter(sql, ConnDB.Conn)
        da.Fill(Dset, "my_Amount")
        Dim counRec As Integer = Dset.Tables("my_Amount").Rows.Count
        Dim i As Integer = 0
        Dim amount As Integer = 0
        Dim price As Double = 0.0
        Dim total As Double = 0.0
        For i = 0 To counRec - 1
            amount += Dset.Tables("my_Amount").Rows(i)(1)
            price = Dset.Tables("my_Amount").Rows(i)(1) * Dset.Tables("my_Amount").Rows(i)(2)
            total = total + price
            isdataCountAmount = True
        Next
        Dim Productname As String = nampProduct(pid)
        'MessageBox.Show(pid & " " & Productname & " จำนวน " & amount & " ราคา " & total)
        ' Dim new_amount As Integer
        totalAmount = totalAmount + amount
        lb_totalamount.Text = totalAmount
        totalPrice = totalPrice + total
        'Dim new_tp As String = FormatNumber(tp, 2, , , TriState.True)
        lb_totalPrice.Text = FormatNumber(totalPrice, 2, , , TriState.True) & " บาท"
        DGV_Report.Rows.Add()
        DGV_Report.Rows(DGV_Report.Rows.Count - 1).Cells(0).Value = pid
        DGV_Report.Rows(DGV_Report.Rows.Count - 1).Cells(1).Value = Productname
        DGV_Report.Rows(DGV_Report.Rows.Count - 1).Cells(2).Value = amount
        DGV_Report.Rows(DGV_Report.Rows.Count - 1).Cells(3).Value = total

    End Sub
    Private Sub nameCus(ByVal cid As String)
        'MessageBox.Show(cid)
        With ConnDB.Conn
            If .State = ConnectionState.Closed Then
                .Open()
            End If
            If isdataNameCus = True Then
                Dset.Tables("my_product").Clear()
            End If

            Try
                Dim sql As String = "Select * From tb_customer"
                sql += " Where cus_id='" & Trim(tb_cus_se.Text) & "'"
                Dim da As New OleDb.OleDbDataAdapter(sql, ConnDB.Conn)
                da.Fill(Dset, "my_product")
                Dim countRec As Integer = Dset.Tables("my_product").Rows.Count
                If countRec >= 1 Then
                    name_cus_new = Dset.Tables("my_product").Rows(0)(1)
                    Label3.Text = name_cus_new
                    'TB_productName.DataBindings.Add("text", Dset, "my_product.product_name")
                    ' MessageBox.Show(name_cus_new)
                    isdataNameCus = True
                    ' checkOrderID()

                Else
                    MessageBox.Show("ไม่มีรายการสินค้าตามรหัสนี้", "แจ้งข่าวสาร", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
            End Try
        End With
    End Sub
    Function nampProduct(ByVal pid As String) As String
        Dim nameP As String = ""
        With ConnDB.Conn
            If .State = ConnectionState.Closed Then
                .Open()
            End If
            If isdataNameProduct = True Then
                Dset.Tables("my_NameProduct").Clear()
            End If
        End With
        Try
            Dim sql As String = "Select product_name From tb_product Where product_id='" & pid & "'"
            Dim da As New OleDb.OleDbDataAdapter(sql, ConnDB.Conn)
            da.Fill(Dset, "my_NameProduct")
            Dim countRec As Integer = Dset.Tables("my_NameProduct").Rows.Count
            If countRec >= 1 Then
                isdataNameProduct = True
                nameP = Dset.Tables("my_NameProduct").Rows(0)(0)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return nameP
    End Function

    Private Sub CB_day_MouseClick(sender As Object, e As MouseEventArgs) Handles CB_day.MouseClick
        CB_day.Checked = True
        CB_month.Checked = True
        CB_year.Checked = True
        serch_mem = False
    End Sub
    Private Sub CB_month_MouseClick(sender As Object, e As MouseEventArgs) Handles CB_month.MouseClick
        CB_day.Checked = False
        CB_year.Checked = True
        CB_month.Checked = True
        serch_mem = False
    End Sub
    Private Sub CB_year_MouseClick(sender As Object, e As MouseEventArgs) Handles CB_year.MouseClick
        CB_day.Checked = False
        CB_month.Checked = False
        CB_year.Checked = True
        serch_mem = False
    End Sub

    Private Sub bt_report2_Click(sender As Object, e As EventArgs) Handles bt_report2.Click
        Dim dmy As String = DTM_report.Text
        Dim sql As String = ""
        Dim new_dmy() As String = Split(dmy, " ")
        Dim testid As String = ComboBox1.Text
        Dim new_testid() As String = Split(testid, " ")
        'MessageBox.Show(new_testid(0))
        If ComboBox1.SelectedIndex = 0 Then
                'sql = "Select tod.product_id,tod.product_amount,tod.product_price"
                sql = "Select DISTINCT(tod.product_id) "
                ' from tb_order od,tb_order_detail tod"
                sql += " from tb_order od,tb_order_detail tod"
                sql += " Where od.order_dmy='" & DTM_report.Text & "'"
                sql += " AND tod.order_id=od.order_id"
            clearda()
                reportService(sql)

            ElseIf CB_day.Checked = True Then
                'sql = "Select tod.product_id,tod.product_amount,tod.product_price"
                sql = "Select DISTINCT(tod.product_id) "
                ' from tb_order od,tb_order_detail tod"
                sql += " from tb_order od,tb_order_detail tod,tb_product tpt"
                sql += " Where od.order_dmy='" & DTM_report.Text & "'"
                sql += " AND tod.order_id=od.order_id"
                sql += " AND tod.product_id = '" & new_testid(0) & "' "
                'MessageBox.Show(new_testid(0) & sql)
                'reportService(sql)
            clearda()
                'checkProduct(new_testid(0))
                reportService(sql)


            ElseIf ((CB_month.Checked = True) And (CB_year.Checked = True)) = True Then

            Dim m_y As String = new_dmy(1) & " " & new_dmy(2)
            sql = "Select DISTINCT(tod.product_id) "
            ' from tb_order od,tb_order_detail tod"
            sql += " from tb_order od,tb_order_detail tod,tb_product tpt"
            sql += " Where od.order_dmy like '%" & m_y & "%'"
            sql += " AND tod.order_id=od.order_id"
            'sql += " AND tod.product_id = '" & new_testid(0) & "' "
            'MessageBox.Show(sql.ToString)
            clearda()
            reportService(sql)

            ElseIf (CB_year.Checked = True) And (CB_day.Checked = False) And (CB_month.Checked = False) Then

                ' MessageBox.Show(new_dmy(2))
                sql = "Select ts.stu_id,ts.deposit_d,ts.deposit_m,ts.deposit_y,ts.deposit_time_in,ts.deposit_time_out,st.stu_name From Time_Service ts,student st"
                sql += " Where ts.deposit_y='" & new_dmy(2) & "'"
                sql += " AND ts.stu_id=st.stu_id"
                reportService(sql)

            End If
    End Sub
    Private Sub clearda()
        DGV_Report.Rows.Clear()
        totalAmount = 0
        totalPrice = 0
        lb_totalamount.Text = ""
        lb_totalPrice.Text = ""


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'MessageBox.Show(dmy_new)
        Dim ta As String = lb_totalamount.Text
        Dim tp As String = lb_totalPrice.Text
        Dim BlackPen As New Pen(Color.Black, 2)
        Dim x1 As Single = 100.0F
        Dim y1 As Single = 80.0F
        Dim x2 As Single = 750.0F
        Dim y2 As Single = 80.0F
        e.Graphics.DrawLine(BlackPen, x1, y1, x2, y2)
        e.Graphics.DrawString("สรุปรายงานยอดการขาย  " & name_cus_new & text_dmy & " " & dmy_new, New Font("Angsana New", 18, FontStyle.Bold), Brushes.Black, New Rectangle(100, 30, 700, 200))

        Dim w As Integer = 150
        Dim h As Integer = 50
        Dim fh = New Font("Angsana New", 18, FontStyle.Bold)
        Dim f = New Font("Angsana New", 16)

        Dim SFM As New StringFormat
        SFM.Alignment = StringAlignment.Far







        e.Graphics.DrawString(DGV_Report.Columns(0).HeaderText.ToString, fh, Brushes.Black, New Rectangle(100, 90, w, h))
        e.Graphics.DrawString(DGV_Report.Columns(1).HeaderText.ToString, fh, Brushes.Black, New Rectangle(240, 90, w, h))
        e.Graphics.DrawString(DGV_Report.Columns(2).HeaderText.ToString, fh, Brushes.Black, New Rectangle(400, 90, w, h))
        e.Graphics.DrawString(DGV_Report.Columns(3).HeaderText.ToString, fh, Brushes.Black, New Rectangle(600, 90, w, h))
        Dim text As String = ""
        Dim i As Integer = 0
        Dim y As Integer = 130
        For i = 0 To DGV_Report.Rows.Count - 1
            Dim id As String = DGV_Report.Rows(i).Cells(0).Value
            Dim name As String = DGV_Report.Rows(i).Cells(1).Value
            Dim amount As String = DGV_Report.Rows(i).Cells(2).Value
            Dim price As String = DGV_Report.Rows(i).Cells(3).Value
            e.Graphics.DrawString(id, f, Brushes.Black, New Rectangle(120, y, w, h))
            e.Graphics.DrawString(name, f, Brushes.Black, New Rectangle(230, y, w, h))
            e.Graphics.DrawString(amount & " แก้ว", f, Brushes.Black, New Rectangle(320, y, w, h), SFM)
            Dim new_price As String = FormatNumber(price, 2, , , TriState.True)
            e.Graphics.DrawString(new_price & " บาท", f, Brushes.Black, New Rectangle(530, y, w, h), SFM)
            y += 30
        Next
        e.Graphics.DrawLine(BlackPen, x1, y + 10, x2, y + 10)
        e.Graphics.DrawLine(BlackPen, x1, y + 50, x2, y + 50)
        'Dim new_tp As Double = FormatNumber(tp, 2, , , TriState.True)
        e.Graphics.DrawString("ราคารวมทั้งหมด " & tp & " บาท", New Font("Angsana New", 18, FontStyle.Bold), Brushes.Black, New Rectangle(180, y + 13, 500, 50), SFM)
    End Sub

    Private Sub PrintPreviewDialog1_MouseClick(sender As Object, e As MouseEventArgs) Handles PrintPreviewDialog1.MouseClick
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub bt_print_Click(sender As Object, e As EventArgs) Handles bt_print.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub tb_cus_se_MouseClick(sender As Object, e As MouseEventArgs) Handles tb_cus_se.MouseClick
        CB_day.Checked = False
        CB_month.Checked = False
        CB_year.Checked = False
        serch_mem = True
    End Sub

    Private Sub tb_cus_se_TextChanged(sender As Object, e As EventArgs) Handles tb_cus_se.TextChanged

    End Sub

    Private Sub CB_NoMemBer_CheckedChanged(sender As Object, e As EventArgs) Handles CB_NoMemBer.CheckedChanged

    End Sub

    Private Sub CB_NoMemBer_MouseClick(sender As Object, e As MouseEventArgs) Handles CB_NoMemBer.MouseClick
        If CB_NoMemBer.Checked = True Then
            tb_cus_se.Text = "No Member"
        ElseIf CB_NoMemBer.Checked = False Then
            tb_cus_se.Text = ""

        End If

    End Sub
End Class