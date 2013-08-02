Imports System.Net.Sockets
Imports System.IO
Imports System.Drawing.Drawing2D
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Security.Permissions
Imports System.Reflection

Public Class Form1

    Public Shared mem As String
    Public Shared ver As String

    '-----------------------

    Public Shared version As String
    Public Shared replacedir As String
    Public Shared replacename As String

    '-----------------------


    Dim nom As String
    Dim nomx As String

    'Dim mem As String
    Public Shared mempass As String


    Dim server As Boolean

    Dim HG As Boolean

    Dim TS As Boolean

    Dim LauncherVersion As Boolean


    Public Shared accessOP As String
    Dim oFile As System.IO.File
    Dim oWrite As System.IO.StreamWriter
    Dim oRead As System.IO.StreamReader
    Dim line As String

    Dim oFilex As System.IO.File
    Dim oWritex As System.IO.StreamWriter
    Dim oReadx As System.IO.StreamReader

    Dim oFiley As System.IO.File
    Dim oWritey As System.IO.StreamWriter
    Dim oReady As System.IO.StreamReader

    Dim oFilep As System.IO.File
    Dim oWritep As System.IO.StreamWriter
    Dim oReadp As System.IO.StreamReader




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim q As String
        q = Chr(34)


        Try
            Dim objReader As StreamWriter


            objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/taguser.txt")
            objReader.Write(TextBox1.Text)
            objReader.Close()

        Catch ex As Exception

        End Try



        Try

            oReadx = IO.File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/memory.txt")
            mem = oReadx.ReadLine


            oReadx.Close()

            oReady = IO.File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/versionselect.txt")
            ver = oReady.ReadLine


            oReady.Close()




            If ver = vbNullString Then
                ver = "1.6.2"
            Else
                'nothing!
            End If


            oReadp = IO.File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/versions/" + ver + ".txt")
            version = oReadp.ReadLine


            oReadp.Close()



            If mem = vbNullString Then
                mempass = "0"

            Else
                mempass = "1"

            End If

        Catch ex As Exception

        End Try



        mainx()

    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        If e.KeyCode = Keys.Enter Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
    Private Sub Launch_Draw(sender As Object, e As System.Windows.Forms.DrawToolTipEventArgs) Handles LauncherToolTip.Draw
        e.DrawBackground()
        e.DrawText()
    End Sub
    'Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs) Handles LauncherToolTip.Popup
    'e.ToolTipSize = New Size(300, 300)
    'End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        accessOP = "0"

        BackgroundWorker1.RunWorkerAsync()
        'SavedTooltilForeColor = GetSysColor(COLOR_INFOTEXT) 'save fore color

        'Try
        'Dim toolTip1 As New ToolTip()
        'toolTip1.AutoPopDelay = 5000
        'toolTip1.InitialDelay = 1000
        'toolTip1.ReshowDelay = 500
        'toolTip1.ShowAlways = True
        'toolTip1.SetToolTip(Me.Button1, "My button1")
        'toolTip1.SetToolTip(Me.Button2, "My Button1")
        'toolTip1.ToolTipTitle("help")
        'Catch ex As Exception

        'End Try
        Try
            oReadx = IO.File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/runtimecatch.txt")
            '            ComboBox2.Text = oReadx.ReadLine

            nomx = oReadx.ReadLine


            oReadx.Close()



        Catch ex As Exception

        End Try

        If nomx = "" Then
            WebBrowser1.Navigate(New Uri("http://www.tagcraftmc.com/launcherhits"))
        ElseIf nomx = "open" Then
            'do nothing

        End If


        Try

            Dim objReaderx As StreamWriter


            objReaderx = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/runtimecatch.txt")
            objReaderx.Write("open")
            objReaderx.Close()

        Catch ex As Exception

        End Try

        Try
            oRead = IO.File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/taguser.txt")
            TextBox1.Text = oRead.ReadLine


            oRead.Close()


            oReadx = IO.File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/memory.txt")
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
    Public Sub lv()
        Dim client As WebClient = New WebClient()
        Try
            Dim URL As String = "http://files.enjin.com/256377/CamelLauncher/version.http"
            Dim result As String = client.DownloadString(URL)
            'Debug.Print("DEBUG CHECK STRING DOWNLOAD: {0}", result)
            If (LCase(Label4.Text) = result) Then 'lower case it all incase I am drunk and do VeRsIoN 9001

                LauncherVersion = True
            Else

                LauncherVersion = False
            End If

        Catch ex As Exception

            LauncherVersion = False

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
        lv()

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Try
            a.Visible = False
            b.Visible = False
            c.Visible = False
            lvLBL.Visible = False

        Catch ex As Exception

        End Try

        If LauncherVersion = True Then
            lvLBL.Visible = False
            LinkLabel1.Visible = False


        Else
            lvLBL.Visible = True
            LinkLabel1.Visible = True

        End If

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

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://www.tagcraftmc.com/launcherupdate")
    End Sub


End Class
