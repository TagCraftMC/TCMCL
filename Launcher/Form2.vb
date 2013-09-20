Imports System.IO

Public Class Form2
    Dim x As String
    Dim y As String
    Dim z As String

    Dim check As Boolean
    Dim debuglog As String

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim objReader As StreamWriter


            objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/tagoptions.txt")
            objReader.Write(ComboBox1.Text)
            objReader.Close()


            Dim lines As New List(Of String)(IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt"))
            'Remove the line to delete, e.g.

            '            lines.RemoveAt(5)
            IO.File.WriteAllLines((Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt"), lines.ToArray())

            Using sr As New StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")
                line = sr.ReadToEnd()
                '            MsgBox(line)
            End Using

            If ComboBox1.Text = "Enabled" Then
                '                objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")
                '               objReader.Write("gamma:" + "10" & Environment.NewLine & line)

                'objReader.Close()

                Try
                    objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")
                    objReader.Write(line.Replace("gamma:0.0", "gamma:10.0"))
                    objReader.Close()

                Catch ex As Exception
                    'MsgBox("Please change your brightness settings in minecraft to moody")
                End Try



            ElseIf ComboBox1.Text = "Disabled" Then
                '                objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")
                '               objReader.Write("gamma:" + "1" & Environment.NewLine & line)

                'objReader.Close()

                Try

                    objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")
                    objReader.Write(line.Replace("gamma:10.0", "gamma:0.0"))
                    objReader.Close()


                Catch ex As Exception
                    'MsgBox("Please change your brightness settings in minecraft to moody")
                End Try



            End If

        Catch ex As Exception

        End Try

        Dim objReaderx As StreamWriter


        objReaderx = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/memory.txt")
        objReaderx.Write(ComboBox2.Text)
        objReaderx.Close()



        Me.Hide()
        '    ComboBox1.Enabled = False
        x = ComboBox1.Text
        y = ComboBox2.Text


        If CheckBox1.Checked = True Then
            check = True
        ElseIf CheckBox1.Checked = False Then
            check = False
        End If

    End Sub
    Private Sub Launch_Draw(sender As Object, e As System.Windows.Forms.DrawToolTipEventArgs) Handles OptionsToolTip.Draw
        e.DrawBackground()
        e.DrawText()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Environment.Is64BitOperatingSystem = True Then
            'nothing
        ElseIf Environment.Is64BitOperatingSystem = False Then
            ComboBox2.Enabled = False

        End If

        ComboBox1.Text = "Disabled"
        ComboBox2.Text = "512M"

        Try
            oRead = IO.File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/tagoptions.txt")
            ComboBox1.Text = oRead.ReadLine


            oRead.Close()

            oReadx = IO.File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/memory.txt")
            ComboBox2.Text = oReadx.ReadLine


            oReadx.Close()


        Catch ex As Exception

        End Try

        x = ComboBox1.Text

        y = ComboBox2.Text


        'MsgBox(computer_info.AvailablePhysicalMemory)

    End Sub

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            ComboBox1.Text = x
            ComboBox2.Text = y

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

End Class