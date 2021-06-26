Public Class praktikum4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nilai As Integer
        nilai = TextBox1.Text
        Dim grade As String

        If nilai < 50 Then
            grade = "E"
        ElseIf nilai <= 66 Then
            grade = "D"
        ElseIf nilai <= 76 Then
            grade = "C"
        ElseIf nilai <= 86 Then
            grade = "B"
        ElseIf nilai <= 100 Then
            grade = "A"
        Else
            MessageBox.Show("Anda Salah Input", "Konfirmasi")
        End If

        If nilai >= 65 And nilai <= 100 Then
            MessageBox.Show(" Selamat anda lulus dengan grade :" & grade, "konfirmasi")

        ElseIf nilai < 65 Then
            MessageBox.Show("Maaf Anda Remidy dengan grade : " & grade, "Konfirmasi")
        End If
    End Sub
End Class