Public Class TimerProductive

    Private Sub TimerProductive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnUbah.Visible = False
        btnSet.Visible = True
        mtbWaktu.Enabled = False
        nudJam.Enabled = False
        nudMenit.Enabled = False
    End Sub

    Private Sub tbLagu_MouseClick(sender As Object, e As MouseEventArgs) Handles tbLagu.MouseClick
        OpenFileDialog1.ShowDialog()
        tbLagu.Text = OpenFileDialog1.FileName
        AxWindowsMediaPlayer1.URL = tbLagu.Text
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        mtbWaktu.Enabled = True
        nudJam.Enabled = True
        nudMenit.Enabled = True
        btnUbah.Visible = False
        btnSet.Visible = True

    End Sub

    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click
        mtbWaktu.Enabled = False
        nudJam.Enabled = False
        nudMenit.Enabled = False
        btnUbah.Visible = True
        btnSet.Visible = False
        btnClose.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim jam As String = TimeOfDay.Hour
        If jam.Length = 1 Then
            jam = "0" + jam
        End If

        Dim menit As String = TimeOfDay.Minute
        If menit.Length = 1 Then
            menit = "0" + menit
        End If

        Dim detik As String = TimeOfDay.Second
        If detik.Length = 1 Then
            detik = "0" + detik
        End If

        clock.Text = jam + ":" + menit + ":" + detik
        mtbWaktu.Text = mtbWaktu.Text


        If nudJam.Value > 0 Or nudMenit.Value > 0 Then
            Dim jamStr As String = nudJam.Value
            Dim menitStr As String = nudMenit.Value

            If jamStr.Length = 1 Then
                jamStr = "0" + jamStr
            End If

            If menitStr.Length = 1 Then
                menitStr = "0" + menitStr
            End If

            Dim setWaktu As String
            setWaktu = jamStr + ":" + menitStr + ":00"
            mtbWaktu.Text = setWaktu
        End If

        If clock.Text = mtbWaktu.Text Then
            Dim yesNo As String
            noteSelesai.Text = ""
            Me.AxWindowsMediaPlayer1.URL = "D:\FILE VB .NET\ASSETS\Suara Tepuk Tangan.wav"
            noteSelesai.Visible = True
            noteSelesai.Text = "WAKTU SUDAH MENCAPAI BATAS"
            yesNo = MsgBox("Apakah kegiatan anda terselesaikan, Jika tidak apakah ingin menyelesaikannya lagi ?", MsgBoxStyle.YesNo, "Konfirmasi Kegiatan")
            If yesNo = DialogResult.No Then
                btnClose.Enabled = True
                AxWindowsMediaPlayer1.URL = ""
            Else
                noteSelesai.Visible = False
                AxWindowsMediaPlayer1.URL = tbLagu.Text
            End If

        End If
    End Sub

End Class
