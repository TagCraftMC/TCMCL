﻿Imports System.Net.Sockets
Imports System.IO
Imports System.Drawing.Drawing2D
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Security.Permissions
Imports System.Reflection
Imports System.Drawing.Text
Imports TagAPIx
Imports Newtonsoft.Json


Public Class Form1

    Public Shared mem As String
    Public Shared ver As String

    '-----------------------

    Public Shared version As String
    Public Shared replacedir As String
    Public Shared replacename As String

    '-----------------------

    Dim progresshere As Integer

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
            If TextBox1.Text = "" Then
                MessageBox.Show("Please choose an Account Name. This is needed even if you're just playing Single Player", "Are you my mommy?")
            ElseIf ComboBox1.Text = "" Then
                MessageBox.Show("Please choose a Version. This is needed even if you're just playing Single Player", "Are you my mommy?")
            Else
                Button1.Enabled = False
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






                    If mem = vbNullString Then
                        mempass = "0"

                    Else
                        mempass = "1"

                    End If

                Catch ex As Exception

                End Try


                BackgroundWorker3.RunWorkerAsync()

            End If
        Catch ex As Exception

        End Try

        'progresshere = 100
        'While (progresshere < 100)
        'do nothing!
        'End While


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
    Dim pfc As New PrivateFontCollection()
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        Dim i As Integer
        i = Rnd() * 15 + 1

        Select Case i

            Case 1
                Me.BackgroundImage = My.Resources.Version130
            Case 2
                Me.BackgroundImage = My.Resources.UpdateHover
            Case 3
                Me.BackgroundImage = My.Resources.Visit
            Case 4
                Me.BackgroundImage = My.Resources.VisitHover
            Case 5
                Me.BackgroundImage = My.Resources.VisitHover1
            Case 6
                Me.BackgroundImage = My.Resources.Warning
            Case 7
                Me.BackgroundImage = My.Resources.UnableToLoadNews
            Case 8
                Me.BackgroundImage = My.Resources.Thanks2
            Case 9
                Me.BackgroundImage = My.Resources.TextBG2
            Case 10
                Me.BackgroundImage = My.Resources.Promise
            Case 11
                Me.BackgroundImage = My.Resources.OutOfDate
            Case 12
                Me.BackgroundImage = My.Resources.OptionsHover
            Case 13
                Me.BackgroundImage = My.Resources.Options1
            Case 14
                Me.BackgroundImage = My.Resources.online
            Case 15
                Me.BackgroundImage = My.Resources.ModsHover


        End Select

    End Sub
    'Dim Timer2 As Timer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Timer2.Enabled = True
        'Timer2.Interval = 1000
        lvLBL.Parent = PictureBox4
        PictureBox3.Parent = PictureBox4

        'lvLBL.BackColor = Color.Transparent
        'Dim minecraftfont As PrivateFontCollection = New PrivateFontCollection
        'minecraftfont.AddFontFile("C:\minecraft_font.ttf")
        'lvLBL.Font = New Font(minecraftfont.Families(0), 6.25)
        'LinkLabel1.Font = New Font(minecraftfont.Families(0), 6.25)
        'Label1.Font = New Font(minecraftfont.Families(0), 9.75)
        'Label2.Font = New Font(minecraftfont.Families(0), 9.75)
        'CheckBox1.Font = New Font(minecraftfont.Families(0), 9.75)
        'Label5.Font = New Font(minecraftfont.Families(0), 9.75)
        'Label6.Font = New Font(minecraftfont.Families(0), 8.25)
        'Label4.Font = New Font(minecraftfont.Families(0), 9.75)
        'Label3.Font = New Font(minecraftfont.Families(0), 9.75)
        'TextBox1.Font = New Font(minecraftfont.Families(0), 12)
        'ComboBox1.Font = New Font(minecraftfont.Families(0), 8.25)


        Dim di As New DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/versions")
        For Each subdi As DirectoryInfo In di.GetDirectories

            'MsgBox(subdi.Name)
            ComboBox1.Items.Add(subdi.Name)
        Next


        Try
            oReady = IO.File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/versionselect.txt")
            ComboBox1.Text = oReady.ReadLine
            oReady.Close()
        Catch ex As Exception

        End Try
        accessOP = "0"

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
        ElseIf nomx = "firsttime" Then
            WebBrowser1.Navigate(New Uri("http://www.tagcraftmc.com/launcherads"))

        End If


        Try

            Dim objReaderx As StreamWriter


            objReaderx = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/runtimecatch.txt")
            objReaderx.Write("firsttime")
            objReaderx.Close()

        Catch ex As Exception

        End Try

        Try
            Dim checkusernametick As String

            ''Super dodgy work around since I could not work out how to convert the string to boolen correctly for the checkbox
            'never do that again D:
            oReadc = IO.File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/rememberme.txt")
            checkusernametick = Convert.ToBoolean(oReadc.ReadLine)
            oReadc.Close()
            If checkusernametick = "True" Then
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
    Public Sub lv()
        Dim client As WebClient = New WebClient()
        If InternetConnection() = False Then
            LauncherVersion = True

        Else
            Try
                Dim URL As String = "http://cp.tagcraftmc.com/status/LauncherVersion/Version.http"
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


        Else
            lvLBL.Visible = True

        End If


    End Sub
    Private Sub lvLBL_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvLBL.MouseDown
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
    Private Sub Button5_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.MouseEnter

        Button5.BackgroundImage = My.Resources.UpdateHover

    End Sub
    Private Sub Button5_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.MouseLeave

        Button5.BackgroundImage = My.Resources.Update

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        System.Diagnostics.Process.Start("http://www.tagcraftmc.com")
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "HelloChalkie" Or TextBox1.Text = "HelloAmmar" Then
            MessageBox.Show("Hello " + Environment.UserName + " how is it going? Congrats on finding an Easter Egg/Secret." + Environment.NewLine + "We hope you're enjoying Minecraft and have a great day." + Environment.NewLine + "- TagCraftMC", "Hi Five, you found an Easter Egg/Secret", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BackgroundWorker3_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker3.DoWork
        progresshere = 0
        TagAPIx.Class1.main()
        TagAPIx.Class1.extractfile()
        oReadp = IO.File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/versions/" + ver + ".txt")
        version = oReadp.ReadLine


        oReadp.Close()
        aftereverything()



    End Sub

    Public Sub aftereverything()
        mainx()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        accessOP = "1"
        UpdatesandMods.Show()
    End Sub
End Class
