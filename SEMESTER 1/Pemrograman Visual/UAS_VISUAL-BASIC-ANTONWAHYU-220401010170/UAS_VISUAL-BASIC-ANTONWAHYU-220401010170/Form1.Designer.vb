<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdisplay = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbMenu = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbVocher = New System.Windows.Forms.ComboBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtPorsi = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.txtDiskon = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtPembayaran = New System.Windows.Forms.TextBox()
        Me.txtKembaian = New System.Windows.Forms.TextBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtkeluar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(983, 100)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Controls.Add(Me.txtdisplay)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(649, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(281, 44)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "RP."
        '
        'txtdisplay
        '
        Me.txtdisplay.AutoSize = True
        Me.txtdisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdisplay.Location = New System.Drawing.Point(64, 7)
        Me.txtdisplay.Name = "txtdisplay"
        Me.txtdisplay.Size = New System.Drawing.Size(27, 29)
        Me.txtdisplay.TabIndex = 1
        Me.txtdisplay.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(233, 31)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "KASIR MADURA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(313, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "hati-hati dalam menghitung kembalian"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Menu Makanan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 18)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Harga"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 345)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 18)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Jumlah Porsi"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 414)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 18)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "SubTotal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(488, 327)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 18)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Total Pembayaran"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(571, 274)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 18)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Diskon"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(531, 415)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 18)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Pembayaran"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(546, 479)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 18)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Kembalian"
        '
        'cmbMenu
        '
        Me.cmbMenu.FormattingEnabled = True
        Me.cmbMenu.Items.AddRange(New Object() {"Nasi Kebuli", "Sate Kambing", "Sate Ayam", "Nasi Goreng"})
        Me.cmbMenu.Location = New System.Drawing.Point(204, 212)
        Me.cmbMenu.Name = "cmbMenu"
        Me.cmbMenu.Size = New System.Drawing.Size(230, 21)
        Me.cmbMenu.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(502, 216)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(130, 18)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "KODE VOCHER"
        '
        'cmbVocher
        '
        Me.cmbVocher.FormattingEnabled = True
        Me.cmbVocher.Items.AddRange(New Object() {"Diskon Akhir Bulan", "Diskon Hari Raya", "Tidak Ada Diskon"})
        Me.cmbVocher.Location = New System.Drawing.Point(689, 216)
        Me.cmbVocher.Name = "cmbVocher"
        Me.cmbVocher.Size = New System.Drawing.Size(230, 21)
        Me.cmbVocher.TabIndex = 11
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(204, 261)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(230, 20)
        Me.txtHarga.TabIndex = 12
        '
        'txtPorsi
        '
        Me.txtPorsi.Location = New System.Drawing.Point(204, 343)
        Me.txtPorsi.Name = "txtPorsi"
        Me.txtPorsi.Size = New System.Drawing.Size(230, 20)
        Me.txtPorsi.TabIndex = 13
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(204, 412)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(230, 20)
        Me.txtSubTotal.TabIndex = 14
        '
        'txtDiskon
        '
        Me.txtDiskon.Location = New System.Drawing.Point(689, 275)
        Me.txtDiskon.Name = "txtDiskon"
        Me.txtDiskon.Size = New System.Drawing.Size(230, 20)
        Me.txtDiskon.TabIndex = 15
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(689, 325)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(230, 20)
        Me.txtTotal.TabIndex = 16
        '
        'txtPembayaran
        '
        Me.txtPembayaran.Location = New System.Drawing.Point(689, 416)
        Me.txtPembayaran.Name = "txtPembayaran"
        Me.txtPembayaran.Size = New System.Drawing.Size(168, 20)
        Me.txtPembayaran.TabIndex = 17
        '
        'txtKembaian
        '
        Me.txtKembaian.Location = New System.Drawing.Point(689, 477)
        Me.txtKembaian.Name = "txtKembaian"
        Me.txtKembaian.Size = New System.Drawing.Size(168, 20)
        Me.txtKembaian.TabIndex = 18
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(204, 473)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(230, 48)
        Me.btnHitung.TabIndex = 19
        Me.btnHitung.Text = "HITUNG"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(896, 361)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(75, 103)
        Me.btnTotal.TabIndex = 20
        Me.btnTotal.Text = "TOTAL"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(896, 127)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 47)
        Me.btnReset.TabIndex = 21
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'txtkeluar
        '
        Me.txtkeluar.Location = New System.Drawing.Point(896, 477)
        Me.txtkeluar.Name = "txtkeluar"
        Me.txtkeluar.Size = New System.Drawing.Size(75, 44)
        Me.txtkeluar.TabIndex = 22
        Me.txtkeluar.Text = "KELUAR"
        Me.txtkeluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(983, 546)
        Me.Controls.Add(Me.txtkeluar)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtKembaian)
        Me.Controls.Add(Me.txtPembayaran)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtDiskon)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.txtPorsi)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.cmbVocher)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cmbMenu)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "KASIR RESTAURAN"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtdisplay As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbMenu As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cmbVocher As ComboBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtPorsi As TextBox
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents txtDiskon As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtPembayaran As TextBox
    Friend WithEvents txtKembaian As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnTotal As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtkeluar As Button
End Class
