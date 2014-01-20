Imports System.Net

Public Class Form3
    Dim changelogforupdates As String
    Dim timeLeftAverage As Double
    Dim timeLeft As TimeSpan
    Dim WithEvents WC As New WebClient
    Dim client As WebClient = New WebClient()

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label2.Text = Form1.result
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        updatetext()
    End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Try
            TextBox1.Text = changelogforupdates


        Catch ex As Exception
            '
        End Try
    End Sub
    Public Sub updatetext()
        Dim client As WebClient = New WebClient()
        Try
            Dim URL As String = "http://files.tagcraftmc.com/launcher/clientversioninfo.html?t=" + DateTime.Now.ToLocalTime()
            changelogforupdates = client.DownloadString(URL)

        Catch ex As Exception
            '
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            WC.DownloadFileAsync(New Uri("http://files.tagcraftmc.com/launcher/client/latest.zip"), "DownloadedFile.zip")
            ProgressBar1.Visible = True
            Label7.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            Button1.Enabled = False
            Button2.Enabled = False
            SW = Stopwatch.StartNew
        Catch ex As Exception

        End Try
    End Sub
    Dim SW As Stopwatch
    Private Sub WC_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles WC.DownloadProgressChanged
        Label7.Text = "Download Status: Downloading"
        ProgressBar1.Value = e.ProgressPercentage

        'lblpct.Text = e.ProgressPercentage.ToString + "%"
        'lblsize.Text = (Convert.ToDouble(e.BytesReceived) / 1048576).ToString("0.00") & " MB" & "  /  " & (Convert.ToDouble(e.TotalBytesToReceive) / 1048576).ToString("0.00") & " MB"
        Label5.Text = "Speed: " & (e.BytesReceived / SW.ElapsedMilliseconds).ToString("0.00") & " KB/s"

        timeLeftAverage = (SW.ElapsedMilliseconds / 1000 / e.BytesReceived)
        timeLeft = TimeSpan.FromSeconds(timeLeftAverage * (e.TotalBytesToReceive - e.BytesReceived))
        Label6.Text = String.Format("ETA: {0:00}:{1:00}:{2:00}", timeLeft.TotalHours, timeLeft.Minutes, timeLeft.Seconds)
    End Sub
    Private Sub WC_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles WC.DownloadFileCompleted
        If ProgressBar1.Value = 100 Then
            SW.Stop()
            'extractzipfile()
        Else

        End If

    End Sub
End Class