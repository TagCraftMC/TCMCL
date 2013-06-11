Imports System.Net.Sockets

Public Class Form1
    Dim accessOP As String
    'Ammar can you read this?
    'crackhead
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If accessOP = "0" And Form2.CheckBox1.Checked = False Then
                Dim text As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/bin/"
                Dim process As New Process
                Dim info As New ProcessStartInfo
                info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe"
                info.CreateNoWindow = True
                info.Arguments = "-Dsun.java2d.noddraw=true -Dsun.awt.noerasebackground=true -Dsun.java2d.d3d=false -Dsun.java2d.opengl=false -Dsun.java2d.pmoffscreen=false -Djava.library.path=" + text + "natives -cp " + text + "minecraft.jar;" + text + "jinput.jar;" + text + "lwjgl.jar;" + text + "lwjgl_util.jar net.minecraft.client.Minecraft " + Me.TextBox1.Text
                process.StartInfo = info
                process.Start()
                End
            ElseIf accessOP = "1" And Form2.CheckBox1.Checked = False Then
                Dim appData As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/bin/"
                Dim process As New Process
                Dim info As New ProcessStartInfo
                info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe"
                info.CreateNoWindow = True
                info.Arguments = "-Xms" + "256m" + " -Xmx" + Form2.ComboBox2.Text + " -Dsun.java2d.noddraw=true" + " -Dsun.awt.noerasebackground=true" + " -Dsun.java2d.d3d=false" + " -Dsun.java2d.opengl=false" + " -Dsun.java2d.pmoffscreen=false" + " -Djava.library.path=" + appData + "natives -cp " + appData + "minecraft.jar;" + appData + "jinput.jar;" + appData + "lwjgl.jar;" + appData + "lwjgl_util.jar net.minecraft.client.Minecraft " + Me.TextBox1.Text
                process.StartInfo = info
                process.Start()
                End

            ElseIf Form2.CheckBox1.Checked = True Then

                Dim appData As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/bin/"
                Dim process As New Process
                Dim info As New ProcessStartInfo
                info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\java.exe"
                info.Arguments = "-Djava.library.path=" + appData + "natives -cp " + appData + "minecraft.jar;" + appData + "jinput.jar;" + appData + "lwjgl.jar;" + appData + "lwjgl_util.jar net.minecraft.client.Minecraft " + Me.TextBox1.Text
                process.StartInfo = info
                process.Start()
                End
            End If
        Catch ex As Exception
            If accessOP = "0" And Form2.CheckBox1.Checked = False Then
                Dim text As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/bin/"
                Dim process As New Process
                Dim info As New ProcessStartInfo
                info.FileName = "javaw"
                info.CreateNoWindow = True
                info.Arguments = "-Dsun.java2d.noddraw=true -Dsun.awt.noerasebackground=true -Dsun.java2d.d3d=false -Dsun.java2d.opengl=false -Dsun.java2d.pmoffscreen=false -Djava.library.path=" + text + "natives -cp " + text + "minecraft.jar;" + text + "jinput.jar;" + text + "lwjgl.jar;" + text + "lwjgl_util.jar net.minecraft.client.Minecraft " + Me.TextBox1.Text
                process.StartInfo = info
                process.Start()
                End
            ElseIf accessOP = "1" And Form2.CheckBox1.Checked = False Then
                Dim appData As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/bin/"
                Dim process As New Process
                Dim info As New ProcessStartInfo
                info.FileName = "javaw"
                info.CreateNoWindow = True
                info.Arguments = "-Xms" + "256m" + " -Xmx" + Form2.ComboBox2.Text + " -Dsun.java2d.noddraw=true" + " -Dsun.awt.noerasebackground=true" + " -Dsun.java2d.d3d=false" + " -Dsun.java2d.opengl=false" + " -Dsun.java2d.pmoffscreen=false" + " -Djava.library.path=" + appData + "natives -cp " + appData + "minecraft.jar;" + appData + "jinput.jar;" + appData + "lwjgl.jar;" + appData + "lwjgl_util.jar net.minecraft.client.Minecraft " + Me.TextBox1.Text
                process.StartInfo = info
                process.Start()
                End

            ElseIf Form2.CheckBox1.Checked = True Then

                Dim appData As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/bin/"
                Dim process As New Process
                Dim info As New ProcessStartInfo
                info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\java.exe"
                info.Arguments = "-Djava.library.path=" + appData + "natives -cp " + appData + "minecraft.jar;" + appData + "jinput.jar;" + appData + "lwjgl.jar;" + appData + "lwjgl_util.jar net.minecraft.client.Minecraft " + Me.TextBox1.Text
                process.StartInfo = info
                process.Start()
                End
            End If
        End Try

      
    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        If e.KeyCode = Keys.Enter Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        accessOP = "0"
        TextBox1.Select()
        x()
        y()
        z()
    End Sub



    Public Sub x()
        Dim tcpClient As TcpClient = New TcpClient()
        Try
            tcpClient.Connect("factions.tagcraftmc.com", 25565)

            ToolStripStatusLabel1.Visible = True

        Catch ex As Exception
            ToolStripStatusLabel3.Visible = True

        End Try
    End Sub

    Public Sub y()
        Dim tcpClient As TcpClient = New TcpClient()
        Try
            tcpClient.Connect("hungergames.tagcraftmc.com", 25566)

            ToolStripStatusLabel2.Visible = True

        Catch ex As Exception
            ToolStripStatusLabel4.Visible = True

        End Try
    End Sub

    Public Sub z()
        Dim tcpClient As TcpClient = New TcpClient()
        Try
            tcpClient.Connect("tsq.tagcraftmc.com", 10011)

            ToolStripStatusLabel5.Visible = True

        Catch ex As Exception
            ToolStripStatusLabel6.Visible = True

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        accessOP = "1"
        Form2.Show()
    End Sub
End Class
