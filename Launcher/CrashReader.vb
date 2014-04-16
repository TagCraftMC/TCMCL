Imports System.IO

Public Class CrashReader
    Dim crashfolder As String
    'Dim stringReader As String
    Dim wheredoilive As DirectoryInfo
    Dim everybodytogether() As FileInfo
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

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

            TransparentRichTextBox1.Text = stringReader

            If stringReader.Contains("com.mojang.util.UUIDTypeAdapter.fromUUID") Then
                Label1.Text = "Tips: This error is thrown when an offline launcher such as this one trys to join a premuim server." + Environment.NewLine + "The only way to fix this is by purchasing Minecraft and using their launcher." + Environment.NewLine + "You can purchase Minecraft at www.minecraft.net/store"
            ElseIf stringReader.Contains("net.minecraftforge") Then
                Label1.Text = "Tips: This error is thrown when there is a problem with Forge Mod Loader or a Mod using Forge Mod Loader." + Environment.NewLine + "If you have multiple Mods in the .minecraft/mods folder try removing them one by one and starting up minecraft again, you might be able to find out what is causing it."
            ElseIf stringReader.Contains("tabbychat.core") Then
                Label1.Text = "Tips: This error is due to the Mod TabbyChat, if you're unable to start Minecraft just remove it."
            ElseIf stringReader.Contains("ResourceUtils.getResourcePackFile") Then
                Label1.Text = "Tips: This error is has to do with ResourcePacks, it has been known to happen when using a buggy or outdated optifine mod."

            Else
                Label1.Text = "Tips: No tips available."

            End If

        Catch ex As Exception

            TransparentRichTextBox1.Text = "Unable to get the latest logs, weird"

        End Try

        Try


        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Button4_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter

        Button1.BackgroundImage = My.Resources.CloseHover

    End Sub
    Private Sub Button4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave

        Button1.BackgroundImage = My.Resources.Close

    End Sub
End Class