<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMasterBarang
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
        Me.GrpDetil = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GrpData = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSatuan = New System.Windows.Forms.ComboBox()
        Me.txtBeli = New System.Windows.Forms.TextBox()
        Me.txtJual = New System.Windows.Forms.TextBox()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.dtBarang = New System.Windows.Forms.DataGridView()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.GrpDetil.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GrpData.SuspendLayout()
        CType(Me.dtBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpDetil
        '
        Me.GrpDetil.Controls.Add(Me.txtNama)
        Me.GrpDetil.Controls.Add(Me.txtKode)
        Me.GrpDetil.Controls.Add(Me.txtJual)
        Me.GrpDetil.Controls.Add(Me.txtBeli)
        Me.GrpDetil.Controls.Add(Me.txtSatuan)
        Me.GrpDetil.Controls.Add(Me.Label5)
        Me.GrpDetil.Controls.Add(Me.Label4)
        Me.GrpDetil.Controls.Add(Me.Label3)
        Me.GrpDetil.Controls.Add(Me.Label2)
        Me.GrpDetil.Controls.Add(Me.Label1)
        Me.GrpDetil.Location = New System.Drawing.Point(12, 12)
        Me.GrpDetil.Name = "GrpDetil"
        Me.GrpDetil.Size = New System.Drawing.Size(434, 171)
        Me.GrpDetil.TabIndex = 0
        Me.GrpDetil.TabStop = False
        Me.GrpDetil.Text = "Detil Barang"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnInput)
        Me.GroupBox2.Controls.Add(Me.btnTutup)
        Me.GroupBox2.Controls.Add(Me.btnHapus)
        Me.GroupBox2.Controls.Add(Me.btnEdit)
        Me.GroupBox2.Controls.Add(Me.btnSimpan)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 431)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(434, 67)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'GrpData
        '
        Me.GrpData.Controls.Add(Me.ComboBox1)
        Me.GrpData.Controls.Add(Me.TextBox1)
        Me.GrpData.Controls.Add(Me.Label6)
        Me.GrpData.Controls.Add(Me.dtBarang)
        Me.GrpData.Location = New System.Drawing.Point(12, 189)
        Me.GrpData.Name = "GrpData"
        Me.GrpData.Size = New System.Drawing.Size(434, 236)
        Me.GrpData.TabIndex = 0
        Me.GrpData.TabStop = False
        Me.GrpData.Text = "Data Barang"
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Barang :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Barang :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Harga Beli :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Harga Jual :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Satuan :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSatuan
        '
        Me.txtSatuan.FormattingEnabled = True
        Me.txtSatuan.Items.AddRange(New Object() {"Pcs", "Bungkus", "Lusin", "Dus"})
        Me.txtSatuan.Location = New System.Drawing.Point(115, 137)
        Me.txtSatuan.Name = "txtSatuan"
        Me.txtSatuan.Size = New System.Drawing.Size(121, 21)
        Me.txtSatuan.TabIndex = 5
        '
        'txtBeli
        '
        Me.txtBeli.Location = New System.Drawing.Point(115, 85)
        Me.txtBeli.Name = "txtBeli"
        Me.txtBeli.Size = New System.Drawing.Size(121, 20)
        Me.txtBeli.TabIndex = 6
        '
        'txtJual
        '
        Me.txtJual.Location = New System.Drawing.Point(115, 111)
        Me.txtJual.Name = "txtJual"
        Me.txtJual.Size = New System.Drawing.Size(121, 20)
        Me.txtJual.TabIndex = 7
        '
        'txtKode
        '
        Me.txtKode.Location = New System.Drawing.Point(115, 33)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(121, 20)
        Me.txtKode.TabIndex = 8
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(115, 58)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(307, 20)
        Me.txtNama.TabIndex = 9
        '
        'dtBarang
        '
        Me.dtBarang.AllowUserToAddRows = False
        Me.dtBarang.AllowUserToDeleteRows = False
        Me.dtBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtBarang.Location = New System.Drawing.Point(6, 19)
        Me.dtBarang.Name = "dtBarang"
        Me.dtBarang.ReadOnly = True
        Me.dtBarang.Size = New System.Drawing.Size(416, 184)
        Me.dtBarang.TabIndex = 0
        '
        'btnSimpan
        '
        Me.btnSimpan.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(104, 19)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(81, 31)
        Me.btnSimpan.TabIndex = 0
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(185, 19)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(81, 31)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Ubah"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(266, 19)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(81, 31)
        Me.btnHapus.TabIndex = 2
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnTutup
        '
        Me.btnTutup.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTutup.Location = New System.Drawing.Point(347, 19)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(81, 31)
        Me.btnTutup.TabIndex = 3
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Cari"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(43, 209)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(258, 20)
        Me.TextBox1.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(307, 209)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'btnInput
        '
        Me.btnInput.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInput.Location = New System.Drawing.Point(23, 19)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(81, 31)
        Me.btnInput.TabIndex = 4
        Me.btnInput.Text = "Tambah"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'FrmMasterBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 507)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GrpData)
        Me.Controls.Add(Me.GrpDetil)
        Me.Name = "FrmMasterBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Master Barang"
        Me.GrpDetil.ResumeLayout(False)
        Me.GrpDetil.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GrpData.ResumeLayout(False)
        Me.GrpData.PerformLayout()
        CType(Me.dtBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrpDetil As GroupBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtKode As TextBox
    Friend WithEvents txtJual As TextBox
    Friend WithEvents txtBeli As TextBox
    Friend WithEvents txtSatuan As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GrpData As GroupBox
    Friend WithEvents btnTutup As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents dtBarang As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnInput As Button
End Class
