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

        txtKode.Text = ""
        txtNama.Text = ""
        txtBeli.Text = ""
        txtJual.Text = ""
        txtSatuan.Text = ""
        GrpDetil.Enabled = False
        btnInput.Enabled = True
        btnSimpan.Enabled = False
        btnEdit.Enabled = True
        btnHapus.Enabled = True
        btnTutup.Enabled = True
    End Sub

    Sub tombolInput()
        GrpDetil.Enabled = True
        btnInput.Enabled = False
        btnSimpan.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
        btnTutup.Enabled = True
    End Sub
#End Region

    Private Sub FrmMasterBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call awal()
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtKode.Text = "" Or txtNama.Text = "" Or txtBeli.Text = "" Or txtJual.Text = "" Or txtSatuan.Text = "" Then
            MsgBox("Data yang anda masukan belum lengkap", vbInformation, "Pesan")
            txtKode.Focus()
        Else
            Try
                Call Koneksi()
                Dim simpan As String = "insert into tbBarang value('" & txtKode.Text & "','" & txtKode.Text & "','" & txtKode.Text & "','" & txtKode.Text & "','" & txtKode.Text & "')"
                cmd = New SqlCommand(simpan, conn)
                cmd.ExecuteNonQuery()
                Call awal()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click

    End Sub
End Class