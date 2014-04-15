Imports System.IO

Public Class CrashReader
    Dim crashfolder As String
    Dim wheredoilive As DirectoryInfo
    Dim everybodytogether() As FileInfo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            wheredoilive = New DirectoryInfo((Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/crash-reports"))

            everybodytogether = wheredoilive.GetFiles("*.txt")
            Array.Sort(everybodytogether, New Form1)
            For Each flies As FileInfo In everybodytogether   
                flies.FullName.ToString()
                If Not flies.FullName.ToString() = vbNullString Then
                    crashfolder = flies.FullName.ToString()

                End If
            Next

            Dim fileReader As System.IO.StreamReader
            fileReader =
            My.Computer.FileSystem.OpenTextFileReader(crashfolder)
            Dim stringReader As String
            stringReader = fileReader.ReadToEnd()

            TextBox1.Text = stringReader

            If stringReader.ToLower.Contains("com.mojang.util.UUIDTypeAdapter.fromUUID") Then
                'non prem
            ElseIf stringReader.ToLower.Contains("net.minecraftforge") Then
                'forge error
            ElseIf stringReader.ToLower.Contains("tabbychat.core") Then
                'tabbychat error
            ElseIf stringReader.ToLower.Contains("ResourceUtils.getResourcePackFile") Then
                'resourcepack error, optifine
            End If


        Catch ex As Exception

            TextBox1.Text = "Unable to get the latest logs, weird"

        End Try
    End Sub
End Class