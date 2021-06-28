Public Class Form23
    Private Sub BtnBuka_Click(sender As Object, e As EventArgs) Handles BtnBuka.Click
        If OfdBuka.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                PcbGambar.Image = Image.FromFile(OfdBuka.FileName)
                Me.Text = "Membuka File " + OfdBuka.FileName
            Catch ex As Exception
                MessageBox.Show("File Gagal dibuka", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim Tutup As String

        Tutup = MessageBox.Show("Yakin tutup form ini ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Tutup = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub
End Class