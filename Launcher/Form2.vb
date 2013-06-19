Imports System.IO

Public Class Form2
    Dim locationx As String

    Dim computer_info As New Devices.ComputerInfo
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


            objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/tagoptions.txt")
            objReader.Write(ComboBox1.Text)
            objReader.Close()


            Dim lines As New List(Of String)(IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt"))
            'Remove the line to delete, e.g.

            lines.RemoveAt(5)
            IO.File.WriteAllLines((Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt"), lines.ToArray())

            Using sr As New StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")
                line = sr.ReadToEnd()
                '            MsgBox(line)
            End Using

            If ComboBox1.Text = "Enabled" Then
                objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")
                objReader.Write("gamma:" + "10" & Environment.NewLine & line)

                objReader.Close()


            ElseIf ComboBox1.Text = "Disabled" Then
                objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")
                objReader.Write("gamma:" + "1" & Environment.NewLine & line)

                objReader.Close()


            End If



        Catch ex As Exception

        End Try
        Me.Hide()
        ComboBox1.Enabled = False

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        ComboBox1.Text = "Disabled"
        ComboBox2.Text = "256M"
        Try
            oRead = IO.File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/tagoptions.txt")
            ComboBox1.Text = oRead.ReadLine


            oRead.Close()

        Catch ex As Exception

        End Try

        'MsgBox(computer_info.AvailablePhysicalMemory)

    End Sub

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button3.Enabled = False
        Me.PictureBox1.ImageLocation = "http://s3.amazonaws.com/MinecraftSkins/" + Me.TextBox1.Text + ".png"
        locationx = "http://s3.amazonaws.com/MinecraftSkins/" + Me.TextBox1.Text + ".png"
        Button3.Enabled = True

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start(locationx)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.Show()
    End Sub
End Class