Imports System.Data.SqlClient

Public Class FrmLogin
#Region "Deskripsi"
    Sub SuksesLogin()
        With FrmUtama
            .BtnLogin.Enabled = False
            .BtnLogout.Enabled = True
            .BtnChange.Enabled = True
            .BtnBarang.Enabled = True
            .GrpTransaksi.Enabled = True
            .BtnLapJual.Enabled = True
            .BtnLapBeli.Enabled = True
            .BtnLapStock.Enabled = True
        End With
    End Sub

    Sub awal()
        txtPass.Text = ""
        txtUser.Text = ""
        txtUser.Focus()
    End Sub
#End Region

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUser.Text = "" Or txtPass.Text = "" Then
            MsgBox("Data yang anda masukan belum lengkap")
            Exit Sub
        Else
            Try
                Call Koneksi()
                cmd = New SqlCommand("select * from tbAdmin where kodeAdmin = '" & txtUser.Text & "' and PassAdmin = '" & txtPass.Text & "'", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    Me.Close()
                    Call SuksesLogin()
                Else
                    MsgBox("Data yang anda masukan salah")
                End If
            Catch err As Exception
                MsgBox(err.Message)
            End Try
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub username_enter(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress
        If e.KeyChar = Chr(13) Then txtPass.Focus()
    End Sub

    Private Sub password_enter(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If e.KeyChar = Chr(13) Then btnLogin.Focus()
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call awal()
    End Sub
End Class