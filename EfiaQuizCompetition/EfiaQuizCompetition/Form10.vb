Imports System.ComponentModel

Public Class Form10
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'correct
        If round = 1 And team = 1 Then
            correct = correct + 1
            score1 = score1 + 1
            tot_score1 = tot_score1 + 1
            Form11.Label12.Text = score1
            Form11.Label32.Text = tot_score1
        End If

        If round = 1 And team = 2 Then
            correct = correct + 1
            score2 = score2 + 1
            tot_score2 = tot_score2 + 1
            Form11.Label13.Text = score2
            Form11.Label33.Text = tot_score2
        End If

        If round = 1 And team = 3 Then
            correct = correct + 1
            score3 = score3 + 1
            tot_score3 = tot_score3 + 1
            Form11.Label14.Text = score3
            Form11.Label34.Text = tot_score3
        End If

        If round = 1 And team = 4 Then
            correct = correct + 1
            score4 = score4 + 1
            tot_score4 = tot_score4 + 1
            Form11.Label15.Text = score4
            Form11.Label35.Text = tot_score4
        End If
        Form3.Hide()

        Me.Close()
        If qn_count = 8 Then
            Form9.Hide()
            qn_count = 0
        Else
            Form9.Show()
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'incorrect
        incorrect = incorrect + 1
        Form3.Hide()

        Me.Close()
        If qn_count = 8 Then
            Form9.Hide()
        Else
            Form9.Show()
        End If

    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = 2
    End Sub

    Private Sub Form10_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub
End Class