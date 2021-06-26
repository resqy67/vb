Public Class Form5

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Computer.FileSystem.DirectoryExists("Pesan") Then
        Else
            MkDir("Pesan")
        End If

        SaveFileDialog1.FileName = "Pesan"
        SaveFileDialog1.Filter = " res File|*.res|Text File|*.txt|Semua File|*."
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            Dim isipesan As New System.IO.StreamWriter(SaveFileDialog1.FileName)
            isipesan.WriteLine(TextBox1.Text)
            isipesan.Close()

            MessageBox.Show("Pesan berhasil disimpan", "Konfirmasi")
            TextBox1.Text = Nothing

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Try
            Dim isipesan As New System.IO.StreamReader("pesan\surat.txt")
            TextBox1.Text = isipesan.ReadToEnd
            isipesan.Close()
        Catch ex As Exception
            MessageBox.Show("File gagal dibuka", "Konfirmasi")
        End Try


    End Sub
End Class