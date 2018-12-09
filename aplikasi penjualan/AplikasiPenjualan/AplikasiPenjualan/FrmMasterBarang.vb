Imports System.Data.SqlClient
Public Class FrmMasterBarang
#Region "Deskripsi"
    Sub awal()
        Call Koneksi()
        da = New SqlDataAdapter("select * from tbBarang", conn)
        ds = New DataSet
        da.Fill(ds, "tbBarang")
        dtBarang.DataSource = ds.Tables("tbBarang")
        dtBarang.ReadOnly = True
        dtBarang.Columns(0).Width = 169
        dtBarang.Columns(1).Width = 65
        dtBarang.Columns(2).Width = 65
        dtBarang.Columns(3).Width = 80

        txtNama.Text = ""
        txtBeli.Text = ""
        txtJual.Text = ""
        txtStock.Text = ""
        GrpDetil.Enabled = False
        GrpData.Enabled = True
        btnSimpan.Enabled = False
        btnEdit.Enabled = True
        btnHapus.Enabled = True
        btnTutup.Enabled = True
    End Sub

    Sub tombolEdit()
        GrpDetil.Enabled = True
        GrpData.Enabled = False
        btnSimpan.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
        btnTutup.Enabled = True
        txtNama.Focus()
    End Sub

    Sub tombolHapus()
        Try
            If txtNama.Text = "" Then
                MsgBox("Pilih salah satu data yang ingin anda hapus", vbExclamation, "Pesan")
                Exit Sub
            Else
                Call Koneksi()
                Dim hapus As String = "delete from tbBarang where NamaBarang = '" & txtNama.Text & "'"
                If MsgBox("Apakah anda yakin ingin menghapus " + txtNama.Text + " ?", vbQuestion + vbYesNo, "Pesan") = MsgBoxResult.Yes Then
                    cmd = New SqlCommand(hapus, conn)
                    cmd.ExecuteNonQuery()
                    Call awal()
                Else
                    dtBarang.Refresh()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub tombolUpdate()
        If txtNama.Text = "" Or txtBeli.Text = "" Or txtJual.Text = "" Or txtStock.Text = "" Or txtBeli.Text = "0" Or txtJual.Text = "0" Or txtStock.Text = "0" Then
            MsgBox("Data yang anda masukan belum lengkap", vbInformation, "Pesan")
            txtNama.Focus()
        Else
            Try
                Call Koneksi()
                Dim perbarui As String = "update tbBarang set NamaBarang = '" & txtNama.Text & "', HargaBeli = '" & txtBeli.Text & "', HargaJual = '" & txtJual.Text & "', StockBarang = '" & txtStock.Text & "' where NamaBarang = '" & txtNama.Text & "'"
                cmd = New SqlCommand(perbarui, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil di perbarui", vbInformation, "Pesan")
                Call awal()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Sub BacaData()
        Try
            Call Koneksi()
            Dim i As Integer
            i = dtBarang.CurrentRow.Index
            cmd = New SqlCommand("select * from tbBarang where NamaBarang = '" & dtBarang.Item(0, i).Value & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                txtNama.Focus()
            Else
                txtNama.Text = dr.Item("NamaBarang")
                txtBeli.Text = dr.Item("HargaBeli")
                txtJual.Text = dr.Item("HargaJual")
                txtStock.Text = dr.Item("StockBarang")
                txtNama.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub FrmMasterBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call awal()
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call tombolUpdate()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Call tombolEdit()
        Call BacaData()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Call tombolHapus()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        dtBarang.Refresh()
        Call awal()
    End Sub

    Private Sub ReadData(sender As Object, e As EventArgs) Handles dtBarang.Click
        Call BacaData()
    End Sub
End Class