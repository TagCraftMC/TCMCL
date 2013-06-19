Imports System.IO
Imports System.ComponentModel

Public Class Form3
    Dim Path As String
    Dim Pathx As String
    Dim xFilesCount = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/").Length
    Dim xFilesTransferred As Integer = 0

  

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'for naming save file add + 1 for each backup number.
        'notes in the backup folder of each file.
        Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/bin/"
        Pathx = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.backupmanager"

        If Not Directory.Exists(Path) Then
            MsgBox("You do not have minecraft installed.")
            Exit Sub
        ElseIf Directory.Exists(Path) Then
            ' createbackup()
            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName = "javaw" Then
                    prog.Kill()
                End If
            Next

            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName = "java" Then
                    prog.Kill()
                End If
            Next
            Timer1.Start()

            BackgroundWorker2.RunWorkerAsync()
            Timer1.Stop()

        Else
            Directory.CreateDirectory(Pathx)
            'createbackup()

            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName = "javaw" Then
                    prog.Kill()
                End If
            Next

            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName = "java" Then
                    prog.Kill()
                End If
            Next
            Timer1.Start()

            BackgroundWorker2.RunWorkerAsync()
            Timer1.Stop()

        End If

    End Sub



  

    Public Sub createbackup()
        'close java


        Dim xNewLocataion = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.backupmanager"

    

        For Each xFiles In Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/")
            My.Computer.FileSystem.CopyDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.backupmanager", True)

            xFilesTransferred += 1

            ' ProgressBar1.Value = xFilesTransferred * 100 / xFilesCount
            'ProgressBar1.Update()


        Next

        
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        createbackup()
        For i As Integer = 0 To 100
            BackgroundWorker2.ReportProgress(i)
        Next
    End Sub

    Private Sub BackgroundWorker2_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker2.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
        
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = xFilesTransferred * 100 / xFilesCount
        ProgressBar1.Update()
    End Sub
End Class