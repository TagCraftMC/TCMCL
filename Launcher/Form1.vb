Imports System.Net.Sockets
Imports System.IO
Imports System.Drawing.Drawing2D
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Security.Permissions
Imports System.Reflection
Imports System.Drawing.Text


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

    Dim oFilec As System.IO.File
    Dim oWritec As System.IO.StreamWriter
    Dim oReadc As System.IO.StreamReader

    Dim oFiley As System.IO.File
    Dim oWritey As System.IO.StreamWriter
    Dim oReady As System.IO.StreamReader

    Dim oFilep As System.IO.File
    Dim oWritep As System.IO.StreamWriter
    Dim oReadp As System.IO.StreamReader



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim objReaderz As StreamWriter
            objReaderz = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/versionselect.txt")
            objReaderz.Write(ComboBox1.Text)
            objReaderz.Close()
        Catch ex As Exception
            MessageBox.Show("Please report this error this to www.tagcraftmc.com", "Error: Unable to save Version")
        End Try

        Dim q As String
        q = Chr(34)
        Dim objReader As StreamWriter
        Try
            If CheckBox1.Checked = True Then
                objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/rememberme.txt")
                objReader.Write("True")
                objReader.Close()
            Else
                objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/rememberme.txt")
                objReader.Write("False")
                objReader.Close()
            End If
            objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/taguser.txt")
            objReader.Write(TextBox1.Text)
            objReader.Close()

        Catch ex As Exception
            MessageBox.Show("")

        End Try



        Try

            oReadx = IO.File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/memory.txt")
            mem = oReadx.ReadLine


            oReadx.Close()

            oReady = IO.File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/versionselect.txt")
            ver = oReady.ReadLine


            oReady.Close()



            'removed so that it is easy to set version number without editing the program.
            '    If ver = vbNullString Then
            ' ver = "1.6.2"
            ' Else
            ' End If


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
    Function centerForm(ByVal Form_to_Center As Form) As Point
        Dim pLocation As New Point
        pLocation.X = (Me.Left + (Me.Width - Form_to_Center.Width) / 2) '// set the X coordinates.
        pLocation.Y = (Me.Top + (Me.Height - Form_to_Center.Height) / 2) '// set the Y coordinates.
        Return pLocation '// return the Location to the Form it was called from.
    End Function

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


        Dim finfo As New IO.DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/versions")
        For Each fi In finfo.GetFiles

            ComboBox1.Items.Add(Path.GetFileNameWithoutExtension(fi.Name))

        Next
        Try
            oReady = IO.File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/versionselect.txt")
            ComboBox1.Text = oReady.ReadLine
            oReady.Close()
        Catch ex As Exception

        End Try

        Try
            Label1.Font = MinecraftFont.GetInstance(9.75, FontStyle.Regular)
            Label2.Font = MinecraftFont.GetInstance(9.75, FontStyle.Regular)
            Label3.Font = MinecraftFont.GetInstance(9.75, FontStyle.Regular)
            Label4.Font = MinecraftFont.GetInstance(9.75, FontStyle.Regular)
            Label5.Font = MinecraftFont.GetInstance(9.75, FontStyle.Regular)
            Label6.Font = MinecraftFont.GetInstance(8.25, FontStyle.Regular)
            CheckBox1.Font = MinecraftFont.GetInstance(9.75, FontStyle.Regular)
            TextBox1.Font = MinecraftFont.GetInstance(12, FontStyle.Regular)
            ToolStripStatusLabel1.Font = MinecraftFont.GetInstance(9.75, FontStyle.Regular)
            ToolStripStatusLabel2.Font = MinecraftFont.GetInstance(9.75, FontStyle.Regular)
            ToolStripStatusLabel3.Font = MinecraftFont.GetInstance(9.75, FontStyle.Regular)
            ToolStripStatusLabel4.Font = MinecraftFont.GetInstance(9.75, FontStyle.Regular)
            ToolStripStatusLabel5.Font = MinecraftFont.GetInstance(9.75, FontStyle.Regular)
            ToolStripStatusLabel6.Font = MinecraftFont.GetInstance(9.75, FontStyle.Regular)
            ToolStripStatusLabel7.Font = MinecraftFont.GetInstance(9.75, FontStyle.Regular)
            ToolStripStatusLabel8.Font = MinecraftFont.GetInstance(9.75, FontStyle.Regular)
            lvLBL.Font = MinecraftFont.GetInstance(6.75, FontStyle.Regular)
            StatusStrip1.Font = MinecraftFont.GetInstance(9.75, FontStyle.Regular)
            LinkLabel1.Font = MinecraftFont.GetInstance(6.75, FontStyle.Regular)
        Catch ex As Exception
            MessageBox.Show("Warning, Could not load the font minecraft_font.ttf", "Unable to load the font file", _
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        End Try
        accessOP = "0"

        BackgroundWorker1.RunWorkerAsync()
        BackgroundWorker2.RunWorkerAsync()

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
            'Super dodgy work around since I could not work out how to convert the string to boolen correctly for the checkbox
            oReadc = IO.File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/rememberme.txt")
            TextBox2.Text = Convert.ToBoolean(oReadc.ReadLine)
            oReadc.Close()
            If TextBox2.Text = "True" Then
                CheckBox1.Checked = True
            End If

            If CheckBox1.Checked = True Then

                oRead = IO.File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/taguser.txt")
                TextBox1.Text = oRead.ReadLine


                oRead.Close()


                oReadx = IO.File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/memory.txt")
                mem = oReadx.ReadLine


                oReadx.Close()

            End If



        Catch ex As Exception
            MessageBox.Show("nope")
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
            tcpClient.Connect("play.tagcraftmc.com", 25565)

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
            tcpClient.Connect("play.tagcraftmc.com", 25565)

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
        If InternetConnection() = False Then
            LauncherVersion = True

        Else
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
        End If


    End Sub


    Private Function InternetConnection() As Boolean
        Dim req As System.Net.WebRequest = System.Net.WebRequest.Create("http://files.enjin.com/256377/CamelLauncher/version.http")
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

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork

         InternetConnection()
        lv()

    End Sub
    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        Try
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


    End Sub


    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        '       System.Threading.Thread.Sleep(10)
        x()
        y()
        z()
        '    InternetConnection()
        '   lv()

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

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://www.tagcraftmc.com/launcherupdate")
    End Sub

    Private Sub Button4_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.MouseEnter

        Button4.BackgroundImage = My.Resources.VisitHover

    End Sub
    Private Sub Button4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.MouseLeave

        Button4.BackgroundImage = My.Resources.Visit

    End Sub
    Private Sub Button2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter

        Button2.BackgroundImage = My.Resources.OptionsHover

    End Sub
    Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave

        Button2.BackgroundImage = My.Resources.Options

    End Sub
    Private Sub HelpBTN_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpBTN.MouseEnter

        HelpBTN.BackgroundImage = My.Resources.HelpandInfoHover

    End Sub
    Private Sub HelpBTN_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpBTN.MouseLeave

        HelpBTN.BackgroundImage = My.Resources.HelpandInfo

    End Sub
    Private Sub Button3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseEnter

        Button3.BackgroundImage = My.Resources.ExitHover

    End Sub
    Private Sub Button3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave

        Button3.BackgroundImage = My.Resources.Exit_

    End Sub
    Private Sub Button1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter

        Button1.BackgroundImage = My.Resources.LaunchHover

    End Sub
    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave

        Button1.BackgroundImage = My.Resources.Launch

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        System.Diagnostics.Process.Start("http://www.tagcraftmc.com")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "HelloChalkie" Or TextBox1.Text = "HelloAmmar" Then
            MessageBox.Show("Hello " + Environment.UserName + " how is it going? Congrats on finding an Easter Egg/Secret." + Environment.NewLine + "We hope you're enjoying Minecraft and have a great day." + Environment.NewLine + "- TagCraftMC", "Hi Five, you found an Easter Egg/Secret", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
