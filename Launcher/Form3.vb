﻿Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label2.Text = Form1.result
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class