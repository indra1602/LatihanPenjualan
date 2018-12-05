<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUtama))
        Me.GrpMaster = New System.Windows.Forms.GroupBox()
        Me.BtnBarang = New System.Windows.Forms.Button()
        Me.GrpTransaksi = New System.Windows.Forms.GroupBox()
        Me.BtnPembelian = New System.Windows.Forms.Button()
        Me.BtnPenjualan = New System.Windows.Forms.Button()
        Me.GrpLaporan = New System.Windows.Forms.GroupBox()
        Me.BtnLapBeli = New System.Windows.Forms.Button()
        Me.BtnLapJual = New System.Windows.Forms.Button()
        Me.BtnLapStock = New System.Windows.Forms.Button()
        Me.GrpFile = New System.Windows.Forms.GroupBox()
        Me.BtnChange = New System.Windows.Forms.Button()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.GrpDate = New System.Windows.Forms.GroupBox()
        Me.LblWaktu = New System.Windows.Forms.Label()
        Me.LblHari = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GrpMaster.SuspendLayout()
        Me.GrpTransaksi.SuspendLayout()
        Me.GrpLaporan.SuspendLayout()
        Me.GrpFile.SuspendLayout()
        Me.GrpDate.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpMaster
        '
        Me.GrpMaster.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GrpMaster.Controls.Add(Me.BtnBarang)
        Me.GrpMaster.Location = New System.Drawing.Point(12, 240)
        Me.GrpMaster.Name = "GrpMaster"
        Me.GrpMaster.Size = New System.Drawing.Size(167, 152)
        Me.GrpMaster.TabIndex = 2
        Me.GrpMaster.TabStop = False
        Me.GrpMaster.Text = "Master Data"
        '
        'BtnBarang
        '
        Me.BtnBarang.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnBarang.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBarang.Image = Global.AplikasiPenjualan.My.Resources.Resources.Box_icon_72
        Me.BtnBarang.Location = New System.Drawing.Point(8, 22)
        Me.BtnBarang.Name = "BtnBarang"
        Me.BtnBarang.Size = New System.Drawing.Size(148, 116)
        Me.BtnBarang.TabIndex = 1
        Me.BtnBarang.Text = "Barang"
        Me.BtnBarang.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBarang.UseVisualStyleBackColor = True
        '
        'GrpTransaksi
        '
        Me.GrpTransaksi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GrpTransaksi.Controls.Add(Me.BtnPembelian)
        Me.GrpTransaksi.Controls.Add(Me.BtnPenjualan)
        Me.GrpTransaksi.Location = New System.Drawing.Point(185, 240)
        Me.GrpTransaksi.Name = "GrpTransaksi"
        Me.GrpTransaksi.Size = New System.Drawing.Size(319, 152)
        Me.GrpTransaksi.TabIndex = 3
        Me.GrpTransaksi.TabStop = False
        Me.GrpTransaksi.Text = "Transaksi"
        '
        'BtnPembelian
        '
        Me.BtnPembelian.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnPembelian.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPembelian.Image = Global.AplikasiPenjualan.My.Resources.Resources.shop_cart_icon_72
        Me.BtnPembelian.Location = New System.Drawing.Point(162, 22)
        Me.BtnPembelian.Name = "BtnPembelian"
        Me.BtnPembelian.Size = New System.Drawing.Size(148, 116)
        Me.BtnPembelian.TabIndex = 1
        Me.BtnPembelian.Text = "Pembelian Barang"
        Me.BtnPembelian.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPembelian.UseVisualStyleBackColor = True
        '
        'BtnPenjualan
        '
        Me.BtnPenjualan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnPenjualan.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPenjualan.Image = Global.AplikasiPenjualan.My.Resources.Resources.shop_cart_icon_72
        Me.BtnPenjualan.Location = New System.Drawing.Point(10, 22)
        Me.BtnPenjualan.Name = "BtnPenjualan"
        Me.BtnPenjualan.Size = New System.Drawing.Size(148, 116)
        Me.BtnPenjualan.TabIndex = 0
        Me.BtnPenjualan.Text = "Penjualan Barang"
        Me.BtnPenjualan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPenjualan.UseVisualStyleBackColor = True
        '
        'GrpLaporan
        '
        Me.GrpLaporan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GrpLaporan.Controls.Add(Me.BtnLapBeli)
        Me.GrpLaporan.Controls.Add(Me.BtnLapJual)
        Me.GrpLaporan.Controls.Add(Me.BtnLapStock)
        Me.GrpLaporan.Location = New System.Drawing.Point(12, 398)
        Me.GrpLaporan.Name = "GrpLaporan"
        Me.GrpLaporan.Size = New System.Drawing.Size(492, 152)
        Me.GrpLaporan.TabIndex = 4
        Me.GrpLaporan.TabStop = False
        Me.GrpLaporan.Text = "Laporan"
        '
        'BtnLapBeli
        '
        Me.BtnLapBeli.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnLapBeli.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLapBeli.Image = Global.AplikasiPenjualan.My.Resources.Resources.report_icon_72
        Me.BtnLapBeli.Location = New System.Drawing.Point(171, 22)
        Me.BtnLapBeli.Name = "BtnLapBeli"
        Me.BtnLapBeli.Size = New System.Drawing.Size(148, 116)
        Me.BtnLapBeli.TabIndex = 6
        Me.BtnLapBeli.Text = "Laporan Pembelian"
        Me.BtnLapBeli.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnLapBeli.UseVisualStyleBackColor = True
        '
        'BtnLapJual
        '
        Me.BtnLapJual.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnLapJual.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLapJual.Image = Global.AplikasiPenjualan.My.Resources.Resources.report_icon_72
        Me.BtnLapJual.Location = New System.Drawing.Point(17, 22)
        Me.BtnLapJual.Name = "BtnLapJual"
        Me.BtnLapJual.Size = New System.Drawing.Size(148, 116)
        Me.BtnLapJual.TabIndex = 5
        Me.BtnLapJual.Text = "Laporan Penjualan"
        Me.BtnLapJual.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnLapJual.UseVisualStyleBackColor = True
        '
        'BtnLapStock
        '
        Me.BtnLapStock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnLapStock.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLapStock.Image = Global.AplikasiPenjualan.My.Resources.Resources.report_icon_72
        Me.BtnLapStock.Location = New System.Drawing.Point(325, 22)
        Me.BtnLapStock.Name = "BtnLapStock"
        Me.BtnLapStock.Size = New System.Drawing.Size(148, 116)
        Me.BtnLapStock.TabIndex = 7
        Me.BtnLapStock.Text = "Laporan Stok Barang"
        Me.BtnLapStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnLapStock.UseVisualStyleBackColor = True
        '
        'GrpFile
        '
        Me.GrpFile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GrpFile.Controls.Add(Me.BtnChange)
        Me.GrpFile.Controls.Add(Me.BtnLogout)
        Me.GrpFile.Controls.Add(Me.BtnLogin)
        Me.GrpFile.Location = New System.Drawing.Point(12, 82)
        Me.GrpFile.Name = "GrpFile"
        Me.GrpFile.Size = New System.Drawing.Size(492, 152)
        Me.GrpFile.TabIndex = 2
        Me.GrpFile.TabStop = False
        Me.GrpFile.Text = "File"
        '
        'BtnChange
        '
        Me.BtnChange.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnChange.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnChange.Image = Global.AplikasiPenjualan.My.Resources.Resources.Users_Change_User_icon_72
        Me.BtnChange.Location = New System.Drawing.Point(325, 23)
        Me.BtnChange.Name = "BtnChange"
        Me.BtnChange.Size = New System.Drawing.Size(148, 116)
        Me.BtnChange.TabIndex = 8
        Me.BtnChange.Text = "Ganti Password"
        Me.BtnChange.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnChange.UseVisualStyleBackColor = True
        '
        'BtnLogout
        '
        Me.BtnLogout.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnLogout.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.Image = Global.AplikasiPenjualan.My.Resources.Resources.Logout_icon_72
        Me.BtnLogout.Location = New System.Drawing.Point(171, 23)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(148, 116)
        Me.BtnLogout.TabIndex = 1
        Me.BtnLogout.Text = "LogOut"
        Me.BtnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'BtnLogin
        '
        Me.BtnLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnLogin.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.Image = Global.AplikasiPenjualan.My.Resources.Resources.Login_icon_72
        Me.BtnLogin.Location = New System.Drawing.Point(17, 23)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(148, 116)
        Me.BtnLogin.TabIndex = 0
        Me.BtnLogin.Text = "LogIn"
        Me.BtnLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1000
        '
        'GrpDate
        '
        Me.GrpDate.Controls.Add(Me.LblWaktu)
        Me.GrpDate.Controls.Add(Me.LblHari)
        Me.GrpDate.Location = New System.Drawing.Point(12, 12)
        Me.GrpDate.Name = "GrpDate"
        Me.GrpDate.Size = New System.Drawing.Size(492, 51)
        Me.GrpDate.TabIndex = 6
        Me.GrpDate.TabStop = False
        Me.GrpDate.Text = "Date"
        '
        'LblWaktu
        '
        Me.LblWaktu.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWaktu.Location = New System.Drawing.Point(325, 19)
        Me.LblWaktu.Name = "LblWaktu"
        Me.LblWaktu.Size = New System.Drawing.Size(134, 20)
        Me.LblWaktu.TabIndex = 3
        Me.LblWaktu.Text = "Label4"
        Me.LblWaktu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblHari
        '
        Me.LblHari.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHari.Location = New System.Drawing.Point(8, 19)
        Me.LblHari.Name = "LblHari"
        Me.LblHari.Size = New System.Drawing.Size(311, 23)
        Me.LblHari.TabIndex = 0
        Me.LblHari.Text = "Label1"
        Me.LblHari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.AplikasiPenjualan.My.Resources.Resources.shop4_icon1_512
        Me.PictureBox1.Location = New System.Drawing.Point(538, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(695, 543)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'FrmUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1245, 568)
        Me.Controls.Add(Me.GrpDate)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GrpLaporan)
        Me.Controls.Add(Me.GrpFile)
        Me.Controls.Add(Me.GrpTransaksi)
        Me.Controls.Add(Me.GrpMaster)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Aplikasi Penjualan :."
        Me.GrpMaster.ResumeLayout(False)
        Me.GrpTransaksi.ResumeLayout(False)
        Me.GrpLaporan.ResumeLayout(False)
        Me.GrpFile.ResumeLayout(False)
        Me.GrpDate.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpMaster As GroupBox
    Friend WithEvents BtnBarang As Button
    Friend WithEvents GrpTransaksi As GroupBox
    Friend WithEvents BtnPembelian As Button
    Friend WithEvents BtnPenjualan As Button
    Friend WithEvents GrpLaporan As GroupBox
    Friend WithEvents GrpFile As GroupBox
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnLogin As Button
    Friend WithEvents BtnLapJual As Button
    Friend WithEvents BtnLapBeli As Button
    Friend WithEvents BtnLapStock As Button
    Friend WithEvents BtnChange As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer As Timer
    Friend WithEvents GrpDate As GroupBox
    Friend WithEvents LblWaktu As Label
    Friend WithEvents LblHari As Label
End Class
