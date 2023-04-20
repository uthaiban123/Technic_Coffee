Imports System.Data
Imports System.Data.OleDb
Public Class Class_insert
    Public ConnDB As ConnectDB
    Public Function insert(ByVal sql As String) As Boolean
        Dim re As Boolean = False
        ConnDB = New ConnectDB
        With ConnDB.Conn
            If .State = ConnectionState.Closed Then
                .Open()
            End If
        End With
        Try
            Dim insertCMD As New OleDb.OleDbCommand(sql, ConnDB.Conn)
            Dim recordsInsert As Integer = insertCMD.ExecuteNonQuery()
            If recordsInsert >= 1 Then
                MessageBox.Show("เพิ่มข้อมูลเรียบร้อยแล้ว", "แจ้งข่าวสาร", MessageBoxButtons.OK, MessageBoxIcon.Information)
                re = True
            Else
                MessageBox.Show("ไม่สามารถเพิ่มข้อมูลได้", "แจ้งข่าวสาร", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
        End Try
        Return re
    End Function
End Class