Imports System.Data
Imports System.Data.OleDb
Public Class ConnectDB
    Dim path As String = "db/coffee.mdb;Jet OLEDB:Database Password=singcoffee;"
    Public connString As String = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source=" & path
    Public Conn As New OleDb.OleDbConnection(connString)
End Class
