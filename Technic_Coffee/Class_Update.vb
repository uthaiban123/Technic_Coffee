Imports System.Data
Imports System.Data.OleDb
Public Class Class_update
    Public ConnDB As ConnectDB
    Public Function update(ByVal sql As String) As Boolean
        Dim re As Boolean = False
        ConnDB = New ConnectDB
        With ConnDB.Conn
            If .State = ConnectionState.Closed Then
                .Open()
            End If
        End With
        Try
            Dim updateCMD As New OleDb.OleDbCommand(sql, ConnDB.Conn)
            Dim recordsUpdate As Integer = updateCMD.ExecuteNonQuery()
            If recordsUpdate >= 1 Then
                MessageBox.Show("แก้ไขข้อมูลเรียบร้อยแล้ว", "แจ้งข่าวสาร", MessageBoxButtons.OK, MessageBoxIcon.Information)
                re = True
            Else
                MessageBox.Show("ไม่สามารถแก้ไขข้อมูลได้", "แจ้งข่าวสาร", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
        End Try
        Return re
    End Function
End Class