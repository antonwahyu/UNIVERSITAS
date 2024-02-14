Public Class Form1
    Private Sub cmbMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMenu.SelectedIndexChanged
        If cmbMenu.Text = "Nasi Kebuli" Then
            txtHarga.Text = 35000
        ElseIf cmbMenu.Text = "Sate Kambing" Then
            txtHarga.Text = 30000
        ElseIf cmbMenu.Text = "Sate Ayam" Then
            txtHarga.Text = 32000
        ElseIf cmbMenu.Text = "Nasi Goreng" Then
            txtHarga.Text = 25000
        End If
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        txtSubTotal.Text = txtHarga.Text * txtPorsi.Text
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        txtTotal.Text = txtSubTotal.Text - (txtSubTotal.Text * txtDiskon.Text) / 100
        txtdisplay.Text = txtTotal.Text
    End Sub

    Private Sub cmbVocher_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVocher.SelectedIndexChanged
        If cmbVocher.Text = "Diskon Akhir Bulan" Then
            txtDiskon.Text = 10
        ElseIf cmbVocher.Text = "Diskon Hari Raya" Then
            txtDiskon.Text = 30
        ElseIf cmbVocher.Text = "Tidak Ada Diskon" Then
            txtDiskon.Text = 0
        End If
    End Sub

    Private Sub txtPembayaran_Leave(sender As Object, e As EventArgs) Handles txtPembayaran.Leave
        txtKembaian.Text = txtPembayaran.Text - txtTotal.Text
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        cmbMenu.Text = ""
        txtHarga.Text = ""
        txtPorsi.Text = ""
        txtSubTotal.Text = ""
        txtDiskon.Text = ""
        txtTotal.Text = ""
        txtPembayaran.Text = ""
        txtKembaian.Text = ""
        txtdisplay.Text = ""
        cmbVocher.Text = ""
        cmbMenu.Focus()
    End Sub

    Private Sub txtkeluar_Click(sender As Object, e As EventArgs) Handles txtkeluar.Click
        Me.Close()
    End Sub
End Class
