Imports System.IO
Imports System.Drawing.Text
Imports System.Net
Imports Ionic.Zip

Public Class Form2
    Dim v As String
    Dim w As String
    Dim x As String
    Dim y As String
    Dim z As String

    Public Shared check As Boolean
    Public Shared debuglog As String

    Dim locationx As String

    Dim computer_info As New Devices.ComputerInfo
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
    Dim WithEvents WC As New WebClient

    Public Sub gamma()
        Try

            Dim reader As New StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")

            Dim a As String
            Dim b As String = ""


            Do
                a = reader.ReadLine
                'MsgBox(a)
                Try
                    If a.Contains("gamma:") Then
                        b = a
                        'MsgBox(a)
                    End If
                Catch ex As Exception
                    'a is nothing now...
                End Try

            Loop Until a Is Nothing

            reader.Close()

            '
            Using sr As New StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")
                line = sr.ReadToEnd()
            End Using

            If ComboBox1.Text = "Enabled" Then

                Dim objReader As New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")

                'objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")
                objReader.Write(line.Replace(b, "gamma:10.0"))
                objReader.Close()

            ElseIf ComboBox1.Text = "Disabled" Then
                Dim objReader As New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")

                'objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")
                objReader.Write(line.Replace(b, "gamma:0.0"))
                objReader.Close()


            End If


        Catch ex As Exception

        End Try
    End Sub

    Public Sub tooltip()
        Try

            Dim reader As New StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")

            Dim a As String
            Dim b As String = ""


            Do
                a = reader.ReadLine
                'MsgBox(a)
                Try
                    If a.Contains("advancedItemTooltips:") Then
                        b = a
                        'MsgBox(a)
                    End If
                Catch ex As Exception
                    'a is nothing now...
                End Try

            Loop Until a Is Nothing

            reader.Close()

            '
            Using sr As New StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")
                line = sr.ReadToEnd()
            End Using

            If ComboBox3.Text = "Enabled" Then

                Dim objReader As New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")

                'objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")
                objReader.Write(line.Replace(b, "advancedItemTooltips:true"))
                objReader.Close()

            ElseIf ComboBox3.Text = "Disabled" Then
                Dim objReader As New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")

                'objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")
                objReader.Write(line.Replace(b, "advancedItemTooltips:false"))
                objReader.Close()


            End If

        Catch ex As Exception

        End Try


    End Sub

    Public Sub heldtooltip()
        Try

            Dim reader As New StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")

            Dim a As String
            Dim b As String = ""


            Do
                a = reader.ReadLine
                'MsgBox(a)
                Try
                    If a.Contains("heldItemTooltips:") Then
                        b = a
                        'MsgBox(a)
                    End If
                Catch ex As Exception
                    'a is nothing now...
                End Try

            Loop Until a Is Nothing

            reader.Close()

            '
            Using sr As New StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")
                line = sr.ReadToEnd()
            End Using

            If ComboBox4.Text = "Enabled" Then

                Dim objReader As New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")

                'objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")
                objReader.Write(line.Replace(b, "heldItemTooltips:true"))
                objReader.Close()

            ElseIf ComboBox4.Text = "Disabled" Then
                Dim objReader As New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")

                'objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")
                objReader.Write(line.Replace(b, "heldItemTooltips:false"))
                objReader.Close()


            End If

        Catch ex As Exception

        End Try

    End Sub

    Public Sub memorywriter()
        Dim reader As New StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/options.txt")

        Dim a As String
        Dim b As String = ""


        Do
            a = reader.ReadLine
            'MsgBox(a)
            Try
                If a.Contains("memory:") Then
                    b = a
                    'MsgBox(a)
                End If
            Catch ex As Exception
                'a is nothing now...
            End Try

        Loop Until a Is Nothing

        reader.Close()

        '
        Using sr As New StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/options.txt")
            line = sr.ReadToEnd()
        End Using

        Dim objReader As New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/options.txt")
        If check = True Then
            objReader.Write(line.Replace(b, "memory:512M"))
            Form1.memory = "512M"
            objReader.Close()
        ElseIf check = False Then
            objReader.Write(line.Replace(b, "memory:" + ComboBox2.Text))
            Form1.memory = ComboBox2.Text
            objReader.Close()

        End If

    End Sub

    Public Sub debugmodewriter()
        Dim reader As New StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/options.txt")

        Dim a As String
        Dim b As String = ""


        Do
            a = reader.ReadLine
            'MsgBox(a)
            Try
                If a.Contains("debugmode:") Then
                    b = a
                    'MsgBox(a)
                End If
            Catch ex As Exception
                'a is nothing now...
            End Try

        Loop Until a Is Nothing

        reader.Close()

        '
        Using sr As New StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/options.txt")
            line = sr.ReadToEnd()
        End Using
        If CheckBox1.Checked = True And b = "debugmode:false" Then

            Dim objReader As New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/options.txt")

            'objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")
            objReader.Write(line.Replace(b, "debugmode:true"))

            Form1.debugmode = "true"
            objReader.Close()
            check = True

        ElseIf CheckBox1.Checked = False And b = "debugmode:true" Then

            Dim objReader As New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/options.txt")

            'objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")
            objReader.Write(line.Replace(b, "debugmode:false"))

            Form1.debugmode = "false"
            objReader.Close()
            check = False

        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        gamma()
        tooltip()
        heldtooltip()

        debugmodewriter()

        memorywriter()


            Me.Hide()
            '    ComboBox1.Enabled = False
        x = ComboBox1.Text
        y = ComboBox2.Text
        w = ComboBox2.Text
        v = ComboBox4.Text

    End Sub

    Function centerForm(ByVal Form_to_Center As Form) As Point
        Dim pLocation As New Point
        pLocation.X = (Me.Left + (Me.Width - Form_to_Center.Width) / 2) '// set the X coordinates.
        pLocation.Y = (Me.Top + (Me.Height - Form_to_Center.Height) / 1) '// set the Y coordinates.
        Return pLocation '// return the Location to the Form it was called from.
    End Function

    'Private Sub Launch_Draw(sender As Object, e As System.Windows.Forms.DrawToolTipEventArgs) Handles OptionsToolTip.Draw
    '   e.DrawBackground()
    '   e.DrawText()
    'End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load


        If Environment.Is64BitOperatingSystem = True Then
            'nothing
        ElseIf Environment.Is64BitOperatingSystem = False Then
            ComboBox2.Enabled = False

        End If

        ComboBox1.Text = "Disabled"
        ComboBox3.Text = "Disabled"
        ComboBox4.Text = "Disabled"

        Try

            Dim reader As New StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")

            Dim a As String
            '        Dim b As String = ""

            '    ComboBox1.Text = "Disabled"

            Do
                a = reader.ReadLine
                'MsgBox(a)

                Try
                    If a = ("gamma:10.0") Then
                        ComboBox1.Text = "Enabled"
                    Else
                        ' do nothing!

                        '            b = a
                        'MsgBox(a)
                    End If
                    If a = ("advancedItemTooltips:true") Then
                        ComboBox3.Text = "Enabled"
                    Else
                        ' do nothing!
                    End If

                    If a = ("heldItemTooltips:true") Then
                        ComboBox4.Text = "Enabled"
                    Else
                        ' do nothing!
                    End If

                Catch ex As Exception
                    'a is nothing now...
                End Try

            Loop Until a Is Nothing

            reader.Close()


        Catch ex As Exception

        End Try

        x = ComboBox1.Text

        y = ComboBox2.Text

        w = ComboBox3.Text

        v = ComboBox4.Text

        'MsgBox(computer_info.AvailablePhysicalMemory)
        Me.Location = Form1.centerForm(Me) '// center Form of Main Form.

    End Sub

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            ComboBox1.Text = x
            ComboBox2.Text = y
            ComboBox3.Text = w
            ComboBox4.Text = v

            If check = True Then
                CheckBox1.Checked = True
            ElseIf check = False Then
                CheckBox1.Checked = False
            End If
            Me.Hide()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ComboBox1.Text = x
        ComboBox2.Text = y
        ComboBox3.Text = w
        ComboBox4.Text = v

        If check = True Then
            CheckBox1.Checked = True
        ElseIf check = False Then
            CheckBox1.Checked = False
        End If

        Me.Hide()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If Environment.Is64BitOperatingSystem = True Then
            'nothing
        ElseIf Environment.Is64BitOperatingSystem = False Then
            ComboBox2.Enabled = False
            debuglog = ComboBox2.Text
            ComboBox2.Text = "512M"
            Exit Sub

        End If

        If CheckBox1.Checked = True Then
            ComboBox2.Enabled = False
            debuglog = ComboBox2.Text
            ComboBox2.Text = "512M"
        ElseIf CheckBox1.Checked = False Then
            ComboBox2.Enabled = True
            ComboBox2.Text = debuglog

        End If
    End Sub
    Private Sub Button5_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.MouseEnter

        Button5.BackgroundImage = My.Resources.ExitHover

    End Sub
    Private Sub Button5_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.MouseLeave

        Button5.BackgroundImage = My.Resources.Exit_

    End Sub
    Private Sub Button1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter

        Button1.BackgroundImage = My.Resources.SaveOptionsHover

    End Sub
    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave

        Button1.BackgroundImage = My.Resources.SaveOptions

    End Sub
    Private Sub Button2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter

        Button2.BackgroundImage = My.Resources.InstallModsV2Mouse

    End Sub
    Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave

        Button2.BackgroundImage = My.Resources.InstallModsV2

    End Sub
    Private Sub Button3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseEnter

        Button3.BackgroundImage = My.Resources.CreditsHover

    End Sub
    Private Sub Button3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave

        Button3.BackgroundImage = My.Resources.Credits

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Help/")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Credit.Show()
    End Sub

End Class