Imports System.Data.SqlClient

Module ModuleKoneksi
    Public conn As SqlConnection
    Public cmd As SqlCommand
    Public ds As New DataSet
    Public da As SqlDataAdapter
    Public dr As SqlDataReader
    Public dir As String

    Public Sub Koneksi()
        dir = "data source = SCADA-INDRA\SQLEXPRESS; initial catalog = dbPenjualan; integrated security=true"
        Try
            conn = New SqlConnection(dir)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                MessageBox.Show("koneksi terbuka")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
