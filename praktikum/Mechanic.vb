Module Mechanic
    Public Sub MenentukanPemain()
        If Form3.pemain.Text = 1 Then
            Form3.PictureBox10.Image = Image.FromFile("image\karakter-1.png")
        ElseIf Form3.pemain.Text = 2 Then
            Form3.PictureBox10.Image = Image.FromFile("image\karakter-2.png")
        Else
            Form3.PictureBox10.Image = Image.FromFile("image\kosong.png")
        End If
    End Sub

    Public Sub MerubahGiliran()
        If Form3.pemain.Text = 1 Then
            MenentukanPemenang()
            Form3.pemain.Text = 2
        ElseIf Form3.pemain.Text = 2 Then
            Form3.pemain.Text = 1
            MenentukanPemenang()
        Else
            Form3.pemain.Text = 1
        End If

        MenentukanPemain()

    End Sub

    Public Sub reset()

        Form3.PictureBox1.Enabled = True
        Form3.PictureBox2.Enabled = True
        Form3.PictureBox3.Enabled = True
        Form3.PictureBox4.Enabled = True
        Form3.PictureBox5.Enabled = True
        Form3.PictureBox6.Enabled = True
        Form3.PictureBox7.Enabled = True
        Form3.PictureBox8.Enabled = True
        Form3.PictureBox9.Enabled = True

        MerubahGiliran()

        Form3.PictureBox1.Image = Image.FromFile("image\kosong.png")
        Form3.PictureBox2.Image = Image.FromFile("image\kosong.png")
        Form3.PictureBox3.Image = Image.FromFile("image\kosong.png")
        Form3.PictureBox4.Image = Image.FromFile("image\kosong.png")
        Form3.PictureBox5.Image = Image.FromFile("image\kosong.png")
        Form3.PictureBox6.Image = Image.FromFile("image\kosong.png")
        Form3.PictureBox7.Image = Image.FromFile("image\kosong.png")
        Form3.PictureBox8.Image = Image.FromFile("image\kosong.png")
        Form3.PictureBox9.Image = Image.FromFile("image\kosong.png")

        Form3.kotak1.Text = 0
        Form3.kotak2.Text = 0
        Form3.kotak3.Text = 0
        Form3.kotak4.Text = 0
        Form3.kotak5.Text = 0
        Form3.kotak6.Text = 0
        Form3.kotak7.Text = 0
        Form3.kotak8.Text = 0
        Form3.kotak9.Text = 0


    End Sub

    Public Sub MenentukanPemenang()
        If Form3.kotak1.Text = "1" And Form3.kotak2.Text = "1" And Form3.kotak3.Text = "1" Then
            menang()
        ElseIf Form3.kotak4.Text = "1" And Form3.kotak5.Text = "1" And Form3.kotak6.Text = "1" Then
            menang()
        ElseIf Form3.kotak7.Text = "1" And Form3.kotak8.Text = "1" And Form3.kotak9.Text = "1" Then
            menang()
        ElseIf Form3.kotak1.Text = "1" And Form3.kotak4.Text = "1" And Form3.kotak7.Text = "1" Then
            menang()
        ElseIf Form3.kotak2.Text = "1" And Form3.kotak5.Text = "1" And Form3.kotak8.Text = "1" Then
            menang()
        ElseIf Form3.kotak3.Text = "1" And Form3.kotak6.Text = "1" And Form3.kotak9.Text = "1" Then
            menang()
        ElseIf Form3.kotak1.Text = "1" And Form3.kotak5.Text = "1" And Form3.kotak9.Text = "1" Then
            menang()
        ElseIf Form3.kotak3.Text = "1" And Form3.kotak5.Text = "1" And Form3.kotak7.Text = "1" Then
            menang()
        End If

        If Form3.kotak1.Text = "2" And Form3.kotak2.Text = "2" And Form3.kotak3.Text = "2" Then
            menang()
        ElseIf Form3.kotak4.Text = "2" And Form3.kotak5.Text = "2" And Form3.kotak6.Text = "2" Then
            menang()
        ElseIf Form3.kotak7.Text = "2" And Form3.kotak8.Text = "2" And Form3.kotak9.Text = "2" Then
            menang()
        ElseIf Form3.kotak1.Text = "2" And Form3.kotak4.Text = "2" And Form3.kotak7.Text = "2" Then
            menang()
        ElseIf Form3.kotak2.Text = "2" And Form3.kotak5.Text = "2" And Form3.kotak8.Text = "2" Then
            menang()
        ElseIf Form3.kotak3.Text = "2" And Form3.kotak6.Text = "2" And Form3.kotak9.Text = "2" Then
            menang()
        ElseIf Form3.kotak1.Text = "2" And Form3.kotak5.Text = "2" And Form3.kotak9.Text = "2" Then
            menang()
        ElseIf Form3.kotak3.Text = "2" And Form3.kotak5.Text = "2" And Form3.kotak7.Text = "2" Then
            menang()

        End If
    End Sub

    Public Sub menang()
        MessageBox.Show("Selamat pemain " & Form3.pemain.Text & " Menang", "Menang")

    End Sub
End Module
