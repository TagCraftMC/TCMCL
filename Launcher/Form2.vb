﻿Imports System.IO
Imports System.Drawing.Text
Imports System.Net
Imports Ionic.Zip

Public Class Form2

    Public Shared check As Boolean
    Dim line As String


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

            If ComboBox1x.Text = "Enabled" Then

                Dim objReader As New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")

                'objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")
                objReader.Write(line.Replace(b, "gamma:10.0"))
                objReader.Close()

            ElseIf ComboBox1x.Text = "Disabled" Then
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

            If ComboBox2x.Text = "Enabled" Then

                Dim objReader As New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")

                'objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")
                objReader.Write(line.Replace(b, "advancedItemTooltips:true"))
                objReader.Close()

            ElseIf ComboBox2x.Text = "Disabled" Then
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

            If ComboBox3x.Text = "Enabled" Then

                Dim objReader As New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")

                'objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")
                objReader.Write(line.Replace(b, "heldItemTooltips:true"))
                objReader.Close()

            ElseIf ComboBox3x.Text = "Disabled" Then
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
    
        objReader.Write(line.Replace(b, "memory:" + ComboBox1.Text))
        Form1.memory = ComboBox1.Text
        objReader.Close()


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
        If ComboBox4x.Text = "Enabled" And b = "debugmode:false" Then

            Dim objReader As New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/options.txt")

            'objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")
            objReader.Write(line.Replace(b, "debugmode:true"))

            Form1.debugmode = "true"
            objReader.Close()
            check = True

        ElseIf ComboBox4x.Text = "Disabled" And b = "debugmode:true" Then

            Dim objReader As New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/options.txt")

            'objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")
            objReader.Write(line.Replace(b, "debugmode:false"))

            Form1.debugmode = "false"
            objReader.Close()
            check = False

        End If


    End Sub

    Public Sub loadoptions()
        Dim reader As New StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")

        Dim a As String

        Do
            a = reader.ReadLine

            Try
                If a = ("gamma:10.0") Then
                    ComboBox1x.Text = "Enabled"

                Else
                    ' do nothing!
                End If
                If a = ("advancedItemTooltips:true") Then
                    ComboBox2x.Text = "Enabled"

                Else
                    ' do nothing!
                End If

                If a = ("heldItemTooltips:true") Then
                    ComboBox3x.Text = "Enabled"

                Else
                    ' do nothing!
                End If


            Catch ex As Exception
                'a is nothing now...
            End Try

        Loop Until a Is Nothing

        reader.Close()


    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
      

        ComboBox1x.Text = "Disabled"
        ComboBox2x.Text = "Disabled"
        ComboBox3x.Text = "Disabled"

        If Environment.Is64BitOperatingSystem = True Then
            'dont do anything here plz.

        ElseIf Environment.Is64BitOperatingSystem = False Then
            ComboBox1.Items.Remove("1536M")
            ComboBox1.Items.Remove("2048M")
            ComboBox1.Items.Remove("3072M")
            ComboBox1.Items.Remove("4096M")
            ComboBox1.Items.Remove("6144M")
            ComboBox1.Items.Remove("5120M")
            ComboBox1.Items.Remove("7168M")
            ComboBox1.Items.Remove("8192M")
        End If

        Try
            loadoptions()
        Catch ex As Exception

        End Try

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
    Private Sub Button3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseEnter

        Button3.BackgroundImage = My.Resources.CreditsHover

    End Sub
    Private Sub Button3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave

        Button3.BackgroundImage = My.Resources.Credits

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Help/")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Credit.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Dispose()

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gamma()
        tooltip()
        heldtooltip()
        debugmodewriter()
        memorywriter()

        Me.Hide()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        ' rebuild options code comes here...
        Dim rebuildertext As String
        rebuildertext = "username:username" + vbNewLine + "versionnumber:" + vbNewLine + "rememberaccount:true" + vbNewLine + "debugmode:false" + vbNewLine + "memorypass:true" + vbNewLine + "memory:1024M" + vbNewLine + "tagoptions:true" + vbNewLine + "runtimecatch:true" + vbNewLine + "latestcrash:"
        MsgBox(rebuildertext)
        'stop all background tasks for this to work without causing issues...

    End Sub
End Class