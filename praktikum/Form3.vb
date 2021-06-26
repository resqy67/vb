Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        PictureBox1.Image = PictureBox10.Image
        kotak1.Text = pemain.Text
        PictureBox1.Enabled = False
        MerubahGiliran()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox2.Image = PictureBox10.Image
        kotak2.Text = pemain.Text
        PictureBox2.Enabled = False
        MerubahGiliran()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PictureBox3.Image = PictureBox10.Image
        kotak3.Text = pemain.Text
        PictureBox3.Enabled = False
        MerubahGiliran()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        PictureBox4.Image = PictureBox10.Image
        kotak4.Text = pemain.Text
        PictureBox4.Enabled = False
        MerubahGiliran()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        PictureBox5.Image = PictureBox10.Image
        kotak5.Text = pemain.Text
        MerubahGiliran()
        PictureBox5.Enabled = False
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        PictureBox6.Image = PictureBox10.Image
        kotak6.Text = pemain.Text
        MerubahGiliran()
        PictureBox6.Enabled = False
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        PictureBox7.Image = PictureBox10.Image
        kotak7.Text = pemain.Text
        MerubahGiliran()
        PictureBox7.Enabled = False
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        PictureBox8.Image = PictureBox10.Image
        kotak8.Text = pemain.Text
        MerubahGiliran()
        PictureBox8.Enabled = False
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        PictureBox9.Image = PictureBox10.Image
        kotak9.Text = pemain.Text
        MerubahGiliran()
        PictureBox9.Enabled = False
    End Sub

    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        Dim pesan = MessageBox.Show("Yakin ingin mengulang?", "Konfirmasi", MessageBoxButtons.YesNo)
        If pesan = DialogResult.Yes Then
            reset()

        End If

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class