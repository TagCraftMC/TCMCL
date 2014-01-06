Imports System.Net
Imports System.IO

Public Class UpdatesandMods

    Public Sub populatebox()
        cbversions.Items.Clear()

        Dim finfo As New IO.DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/Updatelist")
        For Each fi In finfo.GetFiles

            cbversions.Items.Add(Path.GetFileNameWithoutExtension(fi.Name))

        Next
    End Sub

    Public Sub readtxtfile()
        cbversions.Items.Clear()

        Dim address As String = "http://tagcraftmc.net78.net/file/filex"
        Dim client As WebClient = New WebClient()
        Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
        '   Dim R As IO.StreamReader

        '        ComboBox3.Items.Add(pewpew)
        Dim newtext As String

        While (reader.Peek() > -1)

            cbversions.Items.Add(reader.ReadLine)
            newtext = cbversions.Items.Item(0)
            cbversions.Text = newtext

        End While


        reader.Close()

    End Sub
    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        'downloadzipfile()
        'extractzipfile()
        'populatebox()

        readtxtfile()
    End Sub

    Private Sub cbversions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbversions.SelectedIndexChanged
        Try
            PictureBox1.ImageLocation = "http://tagcraftmc.net78.net/images/" + cbversions.SelectedItem.ToString + ".png"

        Catch ex As Exception

        End Try
    End Sub
End Class