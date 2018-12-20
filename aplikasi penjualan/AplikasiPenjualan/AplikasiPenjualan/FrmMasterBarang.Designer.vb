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
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtJual = New System.Windows.Forms.TextBox()
        Me.txtBeli = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.GrpData = New System.Windows.Forms.GroupBox()
        Me.cbCari = New System.Windows.Forms.ComboBox()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtBarang = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpDetil.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GrpData.SuspendLayout()
        CType(Me.dtBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpDetil
        '
        Me.GrpDetil.Controls.Add(Me.TextBox1)
        Me.GrpDetil.Controls.Add(Me.Label1)
        Me.GrpDetil.Controls.Add(Me.txtStock)
        Me.GrpDetil.Controls.Add(Me.txtNama)
        Me.GrpDetil.Controls.Add(Me.txtJual)
        Me.GrpDetil.Controls.Add(Me.txtBeli)
        Me.GrpDetil.Controls.Add(Me.Label5)
        Me.GrpDetil.Controls.Add(Me.Label4)
        Me.GrpDetil.Controls.Add(Me.Label3)
        Me.GrpDetil.Controls.Add(Me.Label2)
        Me.GrpDetil.Location = New System.Drawing.Point(12, 12)
        Me.GrpDetil.Name = "GrpDetil"
        Me.GrpDetil.Size = New System.Drawing.Size(434, 157)
        Me.GrpDetil.TabIndex = 0
        Me.GrpDetil.TabStop = False
        Me.GrpDetil.Text = "Detil Barang"
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(115, 127)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(70, 20)
        Me.txtStock.TabIndex = 10
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(115, 48)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(307, 20)
        Me.txtNama.TabIndex = 9
        '
        'txtJual
        '
        Me.txtJual.Location = New System.Drawing.Point(115, 101)
        Me.txtJual.Name = "txtJual"
        Me.txtJual.Size = New System.Drawing.Size(121, 20)
        Me.txtJual.TabIndex = 7
        '
        'txtBeli
        '
        Me.txtBeli.Location = New System.Drawing.Point(115, 75)
        Me.txtBeli.Name = "txtBeli"
        Me.txtBeli.Size = New System.Drawing.Size(121, 20)
        Me.txtBeli.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Stock Barang :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Harga Jual :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Harga Beli :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Barang :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.btnTutup)
        Me.GroupBox2.Controls.Add(Me.btnHapus)
        Me.GroupBox2.Controls.Add(Me.btnEdit)
        Me.GroupBox2.Controls.Add(Me.btnSimpan)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 461)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(434, 67)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'btnTutup
        '
        Me.btnTutup.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTutup.Location = New System.Drawing.Point(347, 19)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(81, 31)
        Me.btnTutup.TabIndex = 3
        Me.btnTutup.Text = "Batal"
        Me.btnTutup.UseVisualStyleBackColor = True
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
        'btnSimpan
        '
        Me.btnSimpan.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(104, 19)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(81, 31)
        Me.btnSimpan.TabIndex = 0
        Me.btnSimpan.Text = "Update"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'GrpData
        '
        Me.GrpData.Controls.Add(Me.cbCari)
        Me.GrpData.Controls.Add(Me.txtCari)
        Me.GrpData.Controls.Add(Me.Label6)
        Me.GrpData.Controls.Add(Me.dtBarang)
        Me.GrpData.Location = New System.Drawing.Point(12, 175)
        Me.GrpData.Name = "GrpData"
        Me.GrpData.Size = New System.Drawing.Size(434, 287)
        Me.GrpData.TabIndex = 0
        Me.GrpData.TabStop = False
        Me.GrpData.Text = "Data Barang"
        '
        'cbCari
        '
        Me.cbCari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCari.FormattingEnabled = True
        Me.cbCari.Items.AddRange(New Object() {"Nama Barang", "Stok Barang"})
        Me.cbCari.Location = New System.Drawing.Point(307, 259)
        Me.cbCari.Name = "cbCari"
        Me.cbCari.Size = New System.Drawing.Size(121, 21)
        Me.cbCari.TabIndex = 3
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(43, 259)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(258, 20)
        Me.txtCari.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Cari"
        '
        'dtBarang
        '
        Me.dtBarang.AllowUserToAddRows = False
        Me.dtBarang.AllowUserToDeleteRows = False
        Me.dtBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtBarang.Location = New System.Drawing.Point(6, 19)
        Me.dtBarang.Name = "dtBarang"
        Me.dtBarang.ReadOnly = True
        Me.dtBarang.Size = New System.Drawing.Size(422, 234)
        Me.dtBarang.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(23, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 31)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(115, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Kode Barang :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmMasterBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 534)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GrpData)
        Me.Controls.Add(Me.GrpDetil)
        Me.MaximizeBox = False
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
    Friend WithEvents txtJual As TextBox
    Friend WithEvents txtBeli As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GrpData As GroupBox
    Friend WithEvents btnTutup As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents dtBarang As DataGridView
    Friend WithEvents cbCari As ComboBox
    Friend WithEvents txtCari As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
