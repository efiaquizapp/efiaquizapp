﻿Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Scategories
        Me.WindowState = 2
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Maths
        Me.Hide()
        Form3.Show()
        cat = 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'GK
        Me.Hide()
        Form3.Show()
        cat = 2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Science
        Me.Hide()
        Form3.Show()
        cat = 3
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'computer
        Me.Hide()
        Form3.Show()
        cat = 4
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'History
        Me.Hide()
        Form3.Show()
        cat = 5
    End Sub
End Class