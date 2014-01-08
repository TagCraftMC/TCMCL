Imports System.Net
Imports System.IO
Imports Ionic.Zip

Public Class UpdatesandMods
    Dim timeLeftAverage As Double
    Dim timeLeft As TimeSpan
    Dim WithEvents WC As New WebClient
    Dim client As WebClient = New WebClient()
    Dim reader As StreamReader
    Dim newtext As String

    Dim oFiley As System.IO.File
    Dim oWritey As System.IO.StreamWriter
    Dim oReady As System.IO.StreamReader

    Public Sub populatebox()
        'cbversions.Items.Clear()

        Dim finfo As New IO.DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/Updatelist")
        For Each fi In finfo.GetFiles

            cbversions.Items.Add(Path.GetFileNameWithoutExtension(fi.Name))

        Next
    End Sub

    Public Sub readtxtfile()
        'cbversions.Items.Clear()
        Me.BackgroundWorker1.RunWorkerAsync()


    End Sub
    Private Sub cbversions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbversions.SelectedIndexChanged
        Try
            PictureBox1.ImageLocation = "http://tagcraftmc.net78.net/images/" + cbversions.SelectedItem.ToString + ".png"
            lblversion.Text = "Minecraft " + cbversions.SelectedItem.ToString

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbversions_MouseHover(sender As Object, e As EventArgs) Handles cbversions.MouseHover
        Try
            PictureBox1.ImageLocation = "http://tagcraftmc.net78.net/images/" + cbversions.SelectedItem.ToString + ".png"
            lblversion.Text = "Minecraft " + cbversions.SelectedItem.ToString

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


    Public Sub extractzipfile()
        'extract content of zip file
        Dim ZipToUnpack As String = "DownloadedFile.zip"
        'minecraft path comes here!
        Dim TargetDir As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/versions/"
        'this line will be changed to ./minecraft/
        Console.WriteLine("Extracting file {0} to {1}", ZipToUnpack, TargetDir)
        Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
            Dim e As ZipEntry
            ' here, we extract every entry, but we could extract    
            ' based on entry name, size, date, etc.   
            For Each e In zip1
                e.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)
            Next
        End Using
    End Sub

    Public Sub refreshform1()
        Form1.ComboBox1.Items.Clear()


        Dim di As New DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/versions")
        For Each subdi As DirectoryInfo In di.GetDirectories

            'MsgBox(subdi.Name)
            Form1.ComboBox1.Items.Add(subdi.Name)
        Next

        Try
            oReady = IO.File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/versionselect.txt")
            Form1.ComboBox1.Text = oReady.ReadLine
            oReady.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub WC_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles WC.DownloadFileCompleted
        If ProgressBar1.Value = 100 Then
            btnstart.Text = "Download and Install"
            btnstart.Enabled = True
            btncancel.Enabled = False
            lblstatus.Text = "Finished"
            lblspeed.Text = "0 KB/s"
            'MessageBox.Show("Debug: Download Complete")
            SW.Stop()

            extractzipfile()
            refreshform1()

        ElseIf lblstatus.Text = "Canceled" Then
            'nothing
        Else
            lblstatus.Text = "Failed"
            lblspeed.Text = "0 KB/s"
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
        btnstart.Text = "Download and Install"
        SW.Stop()
    End Sub
    Private Sub UpdatesandMods_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            readtxtfile()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        reader = New StreamReader(client.OpenRead("http://tagcraftmc.net78.net/file/filex?t=" + DateTime.Now.ToLocalTime()))
        'Dim client As WebClient = New WebClient()
        '        Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
        '  Dim newtext As String

    End Sub



    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        While (reader.Peek() > -1)
            cbversions.Enabled = True
            cbversions.Items.Add(reader.ReadLine)
            newtext = cbversions.Items.Item(0)
            cbversions.Text = newtext

        End While


        reader.Close()

    End Sub
End Class