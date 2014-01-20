Imports System.Net

Public Class Form3

    Dim LauncherVersion As Boolean
    Dim updatenonet As Boolean
    Dim updatesinfo As String
    Dim updatesinforesult As String


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label2.Text = Form1.result
        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Function InternetConnection() As Boolean
        Dim req As System.Net.WebRequest = System.Net.WebRequest.Create("http://cp.tagcraftmc.com/status/LauncherVersion/Version.http")
        Dim resp As System.Net.WebResponse
        Try
            resp = req.GetResponse()
            resp.Close()
            req = Nothing
            Return True
        Catch ex As Exception
            req = Nothing
            Return False
        End Try
    End Function

    Public Sub getdetails()
        Dim client As WebClient = New WebClient()
        If InternetConnection() = False Then
            updatenonet = True

        Else
            Try
                Dim URL As String = "http://tagcraftmc.net78.net/info/test.html?t=" + DateTime.Now.ToLocalTime()
                updatesinforesult = client.DownloadString(URL)

                'updatesinforesult = updatesinfo

            Catch ex As Exception
                '
            End Try
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        getdetails()

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If updatenonet = True Then
            TransparentRichTextBox1.Text = "Unable to get the news, sorry"
        Else
            TransparentRichTextBox1.Rtf = updatesinforesult
        End If
    End Sub
End Class