Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Audio Visual
        Me.WindowState = 2
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'correct
        If round = 3 And team = 1 Then
            correct = correct + 1
            r3score1 = r3score1 + 1
            tot_score1 = tot_score1 + 1 '+ r2score1
            ' Form11.Label20.Text = r3score1
            'Form11.Label32.Text = tot_score1
        End If

        If round = 3 And team = 2 Then
            correct = correct + 1
            r3score2 = r3score2 + 1
            tot_score2 = tot_score2 + 1 '+ r2score2
            'Form11.Label21.Text = r3score2
            'Form11.Label33.Text = tot_score2
        End If

        If round = 3 And team = 3 Then
            correct = correct + 1
            r3score3 = r3score3 + 1
            tot_score3 = tot_score3 + 1 '+ r2score3
            'Form11.Label22.Text = r3score3
            'Form11.Label34.Text = tot_score3
        End If

        If round = 3 And team = 4 Then
            correct = correct + 1
            r3score4 = r3score4 + 1
            tot_score4 = tot_score4 + 1 '+ r2score4
            'Form11.Label23.Text = r3score4
            'Form11.Label35.Text = tot_score4
        End If
        Form3.Hide()

        Me.Close()
        If r3qn_count = 8 Then
            Form9.Hide()
            'qn_count = 0
        Else
            Form9.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'incorrect
        incorrect = incorrect + 1
        Form3.Hide()

        Me.Close()
        If r3qn_count = 8 Then
            Form9.Hide()
        Else
            Form9.Show()
        End If
    End Sub
End Class