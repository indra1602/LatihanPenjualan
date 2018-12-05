Public Class FrmUtama
#Region "Deskripsi"
    Sub Awal()
        BtnLogin.Enabled = True
        BtnLogout.Enabled = False
        BtnChange.Enabled = False
        BtnBarang.Enabled = True
        GrpTransaksi.Enabled = False
        BtnLapJual.Enabled = True
        BtnLapBeli.Enabled = True
        BtnLapStock.Enabled = True
    End Sub
#End Region

    Private Sub Waktu(sender As Object, e As EventArgs) Handles Timer.Tick
        LblHari.Text = Date.Now.ToString("dddd, dd MMMM yyyy")
        LblWaktu.Text = Date.Now.ToString("hh : mm : ss")
    End Sub

    Private Sub FrmUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Awal()
        Call Koneksi()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Call Awal()
        Call FrmLogin.awal()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        FrmLogin.ShowDialog()
    End Sub

    Private Sub BtnBarang_Click(sender As Object, e As EventArgs) Handles BtnBarang.Click
        FrmMasterBarang.ShowDialog()
    End Sub
End Class
