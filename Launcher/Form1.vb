Imports System.Net.Sockets
Imports System.IO

Public Class Form1
    Dim mem As String
    Dim mempass As String


    Dim server As Boolean

    Dim HG As Boolean

    Dim TS As Boolean


    Dim accessOP As String
    Dim oFile As System.IO.File
    Dim oWrite As System.IO.StreamWriter
    Dim oRead As System.IO.StreamReader
    Dim line As String

    Dim oFilex As System.IO.File
    Dim oWritex As System.IO.StreamWriter
    Dim oReadx As System.IO.StreamReader


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim objReader As StreamWriter


            objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/taguser.txt")
            objReader.Write(TextBox1.Text)
            objReader.Close()

        Catch ex As Exception

        End Try



        Try

            oReadx = IO.File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/memory.txt")
            mem = oReadx.ReadLine


            oReadx.Close()


            If mem = vbNullString Then
                mempass = "0"

            Else
                mempass = "1"

            End If

         Catch ex As Exception

        End Try



        Try
            If mempass = "0" Then
                '  info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\java.exe"
                'programfiles for 64 bit
                'x86 for 32
                If accessOP = "0" And Form2.CheckBox1.Checked = False Then
                    Dim text As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/bin/"
                    Dim process As New Process
                    Dim info As New ProcessStartInfo
                    'info.FileName = "javaw"
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
                    'info.FileName = "javaw"
                    info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe"
                    info.CreateNoWindow = True
                    info.Arguments = "-Xms" + "256m" + " -Xmx" + "256M" + " -Dsun.java2d.noddraw=true" + " -Dsun.awt.noerasebackground=true" + " -Dsun.java2d.d3d=false" + " -Dsun.java2d.opengl=false" + " -Dsun.java2d.pmoffscreen=false" + " -Djava.library.path=" + appData + "natives -cp " + appData + "minecraft.jar;" + appData + "jinput.jar;" + appData + "lwjgl.jar;" + appData + "lwjgl_util.jar net.minecraft.client.Minecraft " + Me.TextBox1.Text
                    '-Xms" + MiniRam[MiniRamCMBO.SelectedIndex] + " -Xmx" + MaxRam[MaxiRamCMBO.SelectedIndex] + " "
                    process.StartInfo = info
                    process.Start()
                    End

                ElseIf Form2.CheckBox1.Checked = True Then

                    Dim appData As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/bin/"
                    Dim process As New Process
                    Dim info As New ProcessStartInfo
                    info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\java.exe"
                    ' info.FileName = "java"
                    '  info.CreateNoWindow = True
                    info.Arguments = "-Djava.library.path=" + appData + "natives -cp " + appData + "minecraft.jar;" + appData + "jinput.jar;" + appData + "lwjgl.jar;" + appData + "lwjgl_util.jar net.minecraft.client.Minecraft " + Me.TextBox1.Text
                    process.StartInfo = info
                    process.Start()
                    End
                End If











            ElseIf mempass = "1" Then



                If accessOP = "0" And Form2.CheckBox1.Checked = False Then
                    Dim text As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/bin/"
                    Dim process As New Process
                    Dim info As New ProcessStartInfo
                    'info.FileName = "javaw"
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
                    'info.FileName = "javaw"
                    info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe"
                    info.CreateNoWindow = True
                    info.Arguments = "-Xms" + "256m" + " -Xmx" + mem + " -Dsun.java2d.noddraw=true" + " -Dsun.awt.noerasebackground=true" + " -Dsun.java2d.d3d=false" + " -Dsun.java2d.opengl=false" + " -Dsun.java2d.pmoffscreen=false" + " -Djava.library.path=" + appData + "natives -cp " + appData + "minecraft.jar;" + appData + "jinput.jar;" + appData + "lwjgl.jar;" + appData + "lwjgl_util.jar net.minecraft.client.Minecraft " + Me.TextBox1.Text
                    '-Xms" + MiniRam[MiniRamCMBO.SelectedIndex] + " -Xmx" + MaxRam[MaxiRamCMBO.SelectedIndex] + " "
                    process.StartInfo = info
                    process.Start()
                    End

                ElseIf Form2.CheckBox1.Checked = True Then

                    Dim appData As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/bin/"
                    Dim process As New Process
                    Dim info As New ProcessStartInfo
                    info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\java.exe"
                    ' info.FileName = "java"
                    '  info.CreateNoWindow = True
                    info.Arguments = "-Djava.library.path=" + appData + "natives -cp " + appData + "minecraft.jar;" + appData + "jinput.jar;" + appData + "lwjgl.jar;" + appData + "lwjgl_util.jar net.minecraft.client.Minecraft " + Me.TextBox1.Text
                    process.StartInfo = info
                    process.Start()
                    End
                End If



            End If





        Catch ex As Exception

            If mempass = "0" Then

                If accessOP = "0" And Form2.CheckBox1.Checked = False Then
                    Dim text As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/bin/"
                    Dim process As New Process
                    Dim info As New ProcessStartInfo
                    '         info.FileName = "javaw"
                    info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe"
                    info.CreateNoWindow = True
                    info.Arguments = "-Dsun.java2d.noddraw=true -Dsun.awt.noerasebackground=true -Dsun.java2d.d3d=false -Dsun.java2d.opengl=false -Dsun.java2d.pmoffscreen=false -Djava.library.path=" + text + "natives -cp " + text + "minecraft.jar;" + text + "jinput.jar;" + text + "lwjgl.jar;" + text + "lwjgl_util.jar net.minecraft.client.Minecraft " + Me.TextBox1.Text
                    process.StartInfo = info
                    process.Start()
                    End
                ElseIf accessOP = "1" And Form2.CheckBox1.Checked = False Then
                    Dim appData As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/bin/"
                    Dim process As New Process
                    Dim info As New ProcessStartInfo
                    '                info.FileName = "javaw"
                    info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe"
                    info.CreateNoWindow = True
                    info.Arguments = "-Xms" + "256m" + " -Xmx" + "256M" + " -Dsun.java2d.noddraw=true" + " -Dsun.awt.noerasebackground=true" + " -Dsun.java2d.d3d=false" + " -Dsun.java2d.opengl=false" + " -Dsun.java2d.pmoffscreen=false" + " -Djava.library.path=" + appData + "natives -cp " + appData + "minecraft.jar;" + appData + "jinput.jar;" + appData + "lwjgl.jar;" + appData + "lwjgl_util.jar net.minecraft.client.Minecraft " + Me.TextBox1.Text
                    '-Xms" + MiniRam[MiniRamCMBO.SelectedIndex] + " -Xmx" + MaxRam[MaxiRamCMBO.SelectedIndex] + " "
                    process.StartInfo = info
                    process.Start()
                    End

                ElseIf Form2.CheckBox1.Checked = True Then

                    Dim appData As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/bin/"
                    Dim process As New Process
                    Dim info As New ProcessStartInfo
                    info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\java.exe"
                    '                info.FileName = "java"
                    '  info.CreateNoWindow = True
                    info.Arguments = "-Djava.library.path=" + appData + "natives -cp " + appData + "minecraft.jar;" + appData + "jinput.jar;" + appData + "lwjgl.jar;" + appData + "lwjgl_util.jar net.minecraft.client.Minecraft " + Me.TextBox1.Text
                    process.StartInfo = info
                    process.Start()
                    End
                End If

            ElseIf mempass = "1" Then


                If accessOP = "0" And Form2.CheckBox1.Checked = False Then
                    Dim text As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/bin/"
                    Dim process As New Process
                    Dim info As New ProcessStartInfo
                    '         info.FileName = "javaw"
                    info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe"
                    info.CreateNoWindow = True
                    info.Arguments = "-Dsun.java2d.noddraw=true -Dsun.awt.noerasebackground=true -Dsun.java2d.d3d=false -Dsun.java2d.opengl=false -Dsun.java2d.pmoffscreen=false -Djava.library.path=" + text + "natives -cp " + text + "minecraft.jar;" + text + "jinput.jar;" + text + "lwjgl.jar;" + text + "lwjgl_util.jar net.minecraft.client.Minecraft " + Me.TextBox1.Text
                    process.StartInfo = info
                    process.Start()
                    End
                ElseIf accessOP = "1" And Form2.CheckBox1.Checked = False Then
                    Dim appData As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/bin/"
                    Dim process As New Process
                    Dim info As New ProcessStartInfo
                    '                info.FileName = "javaw"
                    info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe"
                    info.CreateNoWindow = True
                    info.Arguments = "-Xms" + "256m" + " -Xmx" + mem + " -Dsun.java2d.noddraw=true" + " -Dsun.awt.noerasebackground=true" + " -Dsun.java2d.d3d=false" + " -Dsun.java2d.opengl=false" + " -Dsun.java2d.pmoffscreen=false" + " -Djava.library.path=" + appData + "natives -cp " + appData + "minecraft.jar;" + appData + "jinput.jar;" + appData + "lwjgl.jar;" + appData + "lwjgl_util.jar net.minecraft.client.Minecraft " + Me.TextBox1.Text
                    '-Xms" + MiniRam[MiniRamCMBO.SelectedIndex] + " -Xmx" + MaxRam[MaxiRamCMBO.SelectedIndex] + " "
                    process.StartInfo = info
                    process.Start()
                    End

                ElseIf Form2.CheckBox1.Checked = True Then

                    Dim appData As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/bin/"
                    Dim process As New Process
                    Dim info As New ProcessStartInfo
                    info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\java.exe"
                    '                info.FileName = "java"
                    '  info.CreateNoWindow = True
                    info.Arguments = "-Djava.library.path=" + appData + "natives -cp " + appData + "minecraft.jar;" + appData + "jinput.jar;" + appData + "lwjgl.jar;" + appData + "lwjgl_util.jar net.minecraft.client.Minecraft " + Me.TextBox1.Text
                    process.StartInfo = info
                    process.Start()
                    End

                End If

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

        BackgroundWorker1.RunWorkerAsync()


        Try
            oRead = IO.File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/taguser.txt")
            TextBox1.Text = oRead.ReadLine


            oRead.Close()


            oReadx = IO.File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/memory.txt")
            mem = oReadx.ReadLine


            oReadx.Close()


        Catch ex As Exception

        End Try

        If TextBox1.Text = "" Then
            TextBox1.Select()
        Else
            'nothing
        End If

        If mem = vbNullString Then
            mempass = "0"

        Else
            mempass = "1"

        End If

      '        x()
        '       y()
        '      z()
    End Sub




    Public Sub x()
        Dim tcpClient As TcpClient = New TcpClient()
        Try
            '     tcpClient.Connect("192.95.29.101", 25565)
            tcpClient.Connect("factions.tagcraftmc.com", 25565)

            'main   
            '            ToolStripStatusLabel1.Visible = True
            server = True

        Catch ex As Exception
            'ToolStripStatusLabel3.Visible = True
            server = False


        End Try
    End Sub

    Public Sub y()
        Dim tcpClient As TcpClient = New TcpClient()
        Try
            ' tcpClient.Connect("192.95.29.101", 25566)
            tcpClient.Connect("hungergames.tagcraftmc.com", 25566)

            'HG
            ' ToolStripStatusLabel2.Visible = True
            HG = True

        Catch ex As Exception
            'ToolStripStatusLabel4.Visible = True
            HG = False


        End Try
    End Sub

    Public Sub z()
        Dim tcpClient As TcpClient = New TcpClient()
        Try
            ' tcpClient.Connect("192.95.29.101", 25566)
            tcpClient.Connect("tsq.tagcraftmc.com", 10011)

            'TS
            '       ToolStripStatusLabel5.Visible = True
            TS = True

        Catch ex As Exception
            'ToolStripStatusLabel6.Visible = True
            TS = False

        End Try
    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        accessOP = "1"
        Form2.Show()
    End Sub

    Private Sub HelpBTN_Click(sender As Object, e As EventArgs) Handles HelpBTN.Click
        HelpBrowser.Show()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        TextBox1.Cut()

    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        TextBox1.Copy()

    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        TextBox1.Paste()

    End Sub



    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        '       System.Threading.Thread.Sleep(10)
        x()
        y()
        z()

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Try
            a.Visible = False
            b.Visible = False
            c.Visible = False

        Catch ex As Exception

        End Try

        If server = True Then
            ToolStripStatusLabel1.Visible = True
            ToolStripStatusLabel3.Visible = False


        Else
            ToolStripStatusLabel3.Visible = True
            ToolStripStatusLabel1.Visible = False


        End If

        If HG = True Then
            ToolStripStatusLabel2.Visible = True
            ToolStripStatusLabel4.Visible = False


        Else
            ToolStripStatusLabel4.Visible = True
            ToolStripStatusLabel2.Visible = False


        End If

        If TS = True Then
            ToolStripStatusLabel5.Visible = True
            ToolStripStatusLabel6.Visible = False


        Else
            ToolStripStatusLabel6.Visible = True
            ToolStripStatusLabel5.Visible = False

        End If

        BackgroundWorker1.RunWorkerAsync()


    End Sub






End Class
