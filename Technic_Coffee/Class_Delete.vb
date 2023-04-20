Imports System.Data
Imports System.Data.OleDb
Public Class Class_Delete
    Public ConnDB As ConnectDB
    Public Function Delete(ByVal sql As String) As Boolean
        Dim re As Boolean = False
        ConnDB = New ConnectDB
        With ConnDB.Conn
            If .State = ConnectionState.Closed Then
                .Open()
            End If
        End With
        Try
            Dim deleteCMD As New OleDb.OleDbCommand(sql, ConnDB.Conn)
            Dim recordsDelete As Integer = deleteCMD.ExecuteNonQuery()
            If recordsDelete >= 1 Then
                MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว", "แจ้งข่าวสาร", MessageBoxButtons.OK, MessageBoxIcon.Information)
                re = True
            Else
                MessageBox.Show("ไม่สามารถลบข้อมูลได้", "แจ้งข่าวสาร", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
        End Try
        Return re
    End Function
End Class