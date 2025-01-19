Imports System.Data.OleDb
Imports System.Security.Cryptography.X509Certificates

Module Module1
    Public connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Database1.mdb"
    Public conn As New OleDbConnection(connStr)

    Function connect()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Return True
    End Function
End Module
