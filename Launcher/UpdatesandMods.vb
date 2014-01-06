Imports System.Net
Imports System.IO

Public Class UpdatesandMods
    Dim timeLeftAverage As Double
    Dim timeLeft As TimeSpan
    Dim WithEvents WC As New WebClient
    Public Sub populatebox()
        cbversions.Items.Clear()

        Dim finfo As New IO.DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/Updatelist")
        For Each fi In finfo.GetFiles

            cbversions.Items.Add(Path.GetFileNameWithoutExtension(fi.Name))

        Next
    End Sub

    Public Sub readtxtfile()
        cbversions.Items.Clear()

        Dim address As String = "http://tagcraftmc.net78.net/file/filex?t=" + DateTime.Now.ToLocalTime() 'this now kinda clears the cache every time it's refreshed
        Dim client As WebClient = New WebClient()
        Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
        '   Dim R As IO.StreamReader

        '        ComboBox3.Items.Add(pewpew)
        Dim newtext As String

        While (reader.Peek() > -1)

            cbversions.Items.Add(reader.ReadLine)
            newtext = cbversions.Items.Item(0)
            cbversions.Text = newtext

        End While


        reader.Close()

    End Sub
    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        'downloadzipfile()
        'extractzipfile()
        'populatebox()

        readtxtfile()
        Try
            PictureBox1.ImageLocation = "http://tagcraftmc.net78.net/images/" + cbversions.SelectedItem.ToString + ".png"

        Catch ex As Exception
            'unable to load the image
        End Try
    End Sub

    Private Sub cbversions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbversions.SelectedIndexChanged
        Try
            PictureBox1.ImageLocation = "http://tagcraftmc.net78.net/images/" + cbversions.SelectedItem.ToString + ".png"

        Catch ex As Exception
            'unable to load the image
        End Try
    End Sub

    Private Sub cbversions_MouseHover(sender As Object, e As EventArgs) Handles cbversions.MouseHover
        Try
            PictureBox1.ImageLocation = "http://tagcraftmc.net78.net/images/" + cbversions.SelectedItem.ToString + ".png"

        Catch ex As Exception
            'unable to load the image
        End Try
    End Sub

    Private Sub btnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click
        Try
            WC.DownloadFileAsync(New Uri("http://tagcraftmc.net78.net/download/minecraft/" + cbversions.SelectedItem.ToString + ".zip"), "DownloadedFile.zip")
            btnstart.Text = "Downloading"
            btnstart.Enabled = False
            btncancel.Enabled = True
            lblstatus.Text = "Processing Request"
            SW = Stopwatch.StartNew
        Catch ex As Exception
            MessageBox.Show("Please choose a verions you wish to download", "Errror: Version not selected")
        End Try

    End Sub
    Dim SW As Stopwatch
    Private Sub WC_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles WC.DownloadProgressChanged
        lblstatus.Text = "Downloading"
        ProgressBar1.Value = e.ProgressPercentage

        lblpct.Text = e.ProgressPercentage.ToString + "%"
        lblsize.Text = (Convert.ToDouble(e.BytesReceived) / 1048576).ToString("0.00") & " MB" & "  /  " & (Convert.ToDouble(e.TotalBytesToReceive) / 1048576).ToString("0.00") & " MB"
        lblspeed.Text = (e.BytesReceived / SW.ElapsedMilliseconds).ToString("0.00") & " KB/s"

        timeLeftAverage = (SW.ElapsedMilliseconds / 1000 / e.BytesReceived)
        timeLeft = TimeSpan.FromSeconds(timeLeftAverage * (e.TotalBytesToReceive - e.BytesReceived))
        lbleta.Text = String.Format("{0:00}:{1:00}:{2:00}", timeLeft.TotalHours, timeLeft.Minutes, timeLeft.Seconds)
    End Sub
    Private Sub WC_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles WC.DownloadFileCompleted
        If ProgressBar1.Value = 100 Then
            btnstart.Text = "Start"
            btnstart.Enabled = True
            btncancel.Enabled = False
            lblstatus.Text = "Finished"
            MessageBox.Show("Debug: Download Complete")
            SW.Stop()
        ElseIf lblstatus.Text = "Canceled" Then
            'nothing
        Else
            lblstatus.Text = "Failed"
            btncancel.Enabled = False
            btnstart.Enabled = True
            SW.Stop()
        End If

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        WC.CancelAsync()
        ProgressBar1.Value = 0
        lblpct.Text = "0%"
        lblsize.Text = "0 MB / 0 MB"
        lblstatus.Text = "Canceled"
        lblspeed.Text = "0 KB/s"
        lbleta.Text = "00:00:00"
        btncancel.Enabled = False
        btnstart.Enabled = True
        btnstart.Text = "Start"
        SW.Stop()
    End Sub
End Class