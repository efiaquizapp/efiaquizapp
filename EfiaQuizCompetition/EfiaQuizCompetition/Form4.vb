Public Class Form4
    Dim h As Integer = 0
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clueless
        Me.WindowState = 2

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        'Hint Box
    End Sub

    Private Sub TextBox1_TextChanged(sendzaer As Object, e As EventArgs) Handles TextBox1.TextChanged
        'Qestion Box
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Hint 1
        h = 1
        If question = 1 Then
            TextBox2.Text = "Q1 Hint1"
        End If
        If question = 2 Then
            TextBox2.Text = "Q2 Hint1"
        End If
        If question = 3 Then
            TextBox2.Text = "Q3 Hint1"
        End If
        If question = 4 Then
            TextBox2.Text = "Q4 Hint1"
        End If
        If question = 5 Then
            TextBox2.Text = "Q5 Hint1"
        End If
        If question = 6 Then
            TextBox2.Text = "Q6 Hint1"
        End If
        If question = 7 Then
            TextBox2.Text = "Q7 Hint1"
        End If
        If question = 8 Then
            TextBox2.Text = "Q8 Hint1"
        End If
        If question = 9 Then
            TextBox2.Text = "Q9 Hint1"
        End If
        If question = 10 Then
            TextBox2.Text = "Q10 Hint1"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Hint 2
        h = 2
        If question = 1 Then
            TextBox2.Text = "Q1 Hint2"
        End If
        If question = 2 Then
            TextBox2.Text = "Q2 Hint2"
        End If
        If question = 3 Then
            TextBox2.Text = "Q3 Hint2"
        End If
        If question = 4 Then
            TextBox2.Text = "Q4 Hint2"
        End If
        If question = 5 Then
            TextBox2.Text = "Q5 Hint2"
        End If
        If question = 6 Then
            TextBox2.Text = "Q6 Hint2"
        End If
        If question = 7 Then
            TextBox2.Text = "Q7 Hint2"
        End If
        If question = 8 Then
            TextBox2.Text = "Q8 Hint2"
        End If
        If question = 9 Then
            TextBox2.Text = "Q9 Hint2"
        End If
        If question = 10 Then
            TextBox2.Text = "Q10 Hint2"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Hint 3
        h = 3
        If question = 1 Then
            TextBox2.Text = "Q1 Hint3"
        End If
        If question = 2 Then
            TextBox2.Text = "Q2 Hint3"
        End If
        If question = 3 Then
            TextBox2.Text = "Q3 Hint3"
        End If
        If question = 4 Then
            TextBox2.Text = "Q4 Hint3"
        End If
        If question = 5 Then
            TextBox2.Text = "Q5 Hint3"
        End If
        If question = 6 Then
            TextBox2.Text = "Q6 Hint3"
        End If
        If question = 7 Then
            TextBox2.Text = "Q7 Hint3"
        End If
        If question = 8 Then
            TextBox2.Text = "Q8 Hint3"
        End If
        If question = 9 Then
            TextBox2.Text = "Q9 Hint3"
        End If
        If question = 10 Then
            TextBox2.Text = "Q10 Hint3"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Correct
        If h = 0 Then
            If round = 2 And team = 1 Then
                correct = correct + 1
                r2score1 = r2score1 + 20
                r2tot_score1 = r2tot_score1 + 20
                Form11.Label16.Text = r2score1
                'tot_score1 = tot_score1 + r2tot_score1
                'Form11.Label32.Text = r2tot_score1
            End If

            If round = 2 And team = 2 Then
                correct = correct + 1
                r2score2 = r2score2 + 20
                r2tot_score2 = r2tot_score2 + 20
                Form11.Label17.Text = r2score2
                'tot_score2 = tot_score2 + r2tot_score2
                'Form11.Label33.Text = r2tot_score2
            End If

            If round = 2 And team = 3 Then
                correct = correct + 1
                r2score3 = r2score3 + 20
                r2tot_score3 = r2tot_score3 + 20
                Form11.Label18.Text = r2score3
                'tot_score3 = tot_score3 + r2tot_score3
                'Form11.Label34.Text = r2tot_score3
            End If

            If round = 2 And team = 4 Then
                correct = correct + 1
                r2score4 = r2score4 + 20
                r2tot_score4 = r2tot_score4 + 20
                Form11.Label19.Text = r2score4
                'tot_score4 = tot_score4 + r2tot_score4
                'Form11.Label35.Text = r2tot_score4
            End If
        End If
        If h = 1 Then
            If round = 2 And team = 1 Then
                correct = correct + 1
                r2score1 = r2score1 + 15
                r2tot_score1 = r2tot_score1 + 15
                Form11.Label16.Text = r2score1
                'tot_score1 = tot_score1 + r2tot_score1
                'Form11.Label32.Text = r2tot_score1
            End If

            If round = 2 And team = 2 Then
                correct = correct + 1
                r2score2 = r2score2 + 15
                r2tot_score2 = r2tot_score2 + 15
                Form11.Label17.Text = r2score2
                'tot_score2 = tot_score2 + r2tot_score2
                'Form11.Label33.Text = r2tot_score2
            End If

            If round = 2 And team = 3 Then
                correct = correct + 1
                r2score3 = r2score3 + 15
                r2tot_score3 = r2tot_score3 + 15
                Form11.Label18.Text = r2score3
                'tot_score3 = tot_score3 + r2tot_score3
                'Form11.Label34.Text = r2tot_score3
            End If

            If round = 2 And team = 4 Then
                correct = correct + 1
                r2score4 = r2score4 + 15
                r2tot_score4 = r2tot_score4 + 15
                Form11.Label19.Text = r2score4
                'tot_score4 = tot_score4 + r2tot_score4
                'Form11.Label35.Text = r2tot_score4
            End If
        End If
        If h = 2 Then
            If round = 2 And team = 1 Then
                correct = correct + 1
                r2score1 = r2score1 + 10
                r2tot_score1 = r2tot_score1 + 10
                Form11.Label16.Text = r2score1
                'tot_score1 = tot_score1 + r2tot_score1
                'Form11.Label32.Text = r2tot_score1
            End If

            If round = 2 And team = 2 Then
                correct = correct + 1
                r2score2 = r2score2 + 10
                r2tot_score2 = r2tot_score2 + 10
                Form11.Label17.Text = r2score2
                'tot_score2 = tot_score2 + r2tot_score2
                'Form11.Label33.Text = r2tot_score2
            End If

            If round = 2 And team = 3 Then
                correct = correct + 1
                r2score3 = r2score3 + 10
                r2tot_score3 = r2tot_score3 + 10
                Form11.Label18.Text = r2score3
                'tot_score3 = tot_score3 + r2tot_score3
                'Form11.Label34.Text = r2tot_score3
            End If

            If round = 2 And team = 4 Then
                correct = correct + 1
                r2score4 = r2score4 + 10
                r2tot_score4 = r2tot_score4 + 10
                Form11.Label19.Text = r2score4
                'tot_score4 = tot_score4 + r2tot_score4
                'Form11.Label35.Text = r2tot_score4
            End If
        End If
        If h = 3 Then
            If round = 2 And team = 1 Then
                correct = correct + 1
                r2score1 = r2score1 + 5
                r2tot_score1 = r2tot_score1 + 5
                Form11.Label16.Text = r2score1
                'tot_score1 = tot_score1 + r2tot_score1
                'Form11.Label32.Text = r2tot_score1
            End If

            If round = 2 And team = 2 Then
                correct = correct + 1
                r2score2 = r2score2 + 5
                r2tot_score2 = r2tot_score2 + 5
                Form11.Label17.Text = r2score2
                'tot_score2 = tot_score2 + r2tot_score2
                'Form11.Label33.Text = r2tot_score2
            End If

            If round = 2 And team = 3 Then
                correct = correct + 1
                r2score3 = r2score3 + 5
                r2tot_score3 = r2tot_score3 + 5
                Form11.Label18.Text = r2score3
                'tot_score3 = tot_score3 + r2tot_score3
                'Form11.Label34.Text = r2tot_score3
            End If

            If round = 2 And team = 4 Then
                correct = correct + 1
                r2score4 = r2score4 + 5
                r2tot_score4 = r2tot_score4 + 5
                Form11.Label19.Text = r2score4
                'tot_score4 = tot_score4 + r2tot_score4
                'Form11.Label35.Text = r2tot_score4
            End If
        End If

        Form3.Hide()

        Me.Close()
        If r2qn_count = 8 Then
            Form9.Hide()
        Else
            Form9.Show()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Wrong
        incorrect = incorrect + 1
        Form3.Hide()

        Me.Close()
        If r2qn_count = 8 Then
            Form9.Hide()
        Else
            Form9.Show()
        End If
    End Sub
End Class