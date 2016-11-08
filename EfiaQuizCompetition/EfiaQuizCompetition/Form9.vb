Public Class Form9

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = 2
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        team = 1
        r2qn_count = r2qn_count + 1
        qn_count = qn_count + 1
        qn_count1 = qn_count1 + 1
        If team = 1 And qn_count1 = 2 Then
            Button1.Enabled = False
        End If
        Form3.Show()

        If round = 4 Then
            Form6.Show()

        End If

        If round = 5 Then 'Rapid fire
            Form7.Show()
            Form3.Hide()

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        team = 2
        r2qn_count = r2qn_count + 1
        qn_count = qn_count + 1
        qn_count2 = qn_count2 + 1
        If team = 2 And qn_count2 = 2 Then
            Button2.Enabled = False
        End If
        Form3.Show()
        If round = 4 Then
            Form6.Show()

        End If
        If round = 5 Then 'Rapid fire
            Form7.Show()
            Form3.Hide()

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        team = 3
        r2qn_count = r2qn_count + 1
        qn_count = qn_count + 1
        qn_count3 = qn_count3 + 1
        If team = 3 And qn_count3 = 2 Then
            Button3.Enabled = False
        End If
        Form3.Show()
        If round = 4 Then
            Form6.Show()

        End If
        If round = 5 Then 'Rapid fire
            Form7.Show()
            Form3.Hide()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        team = 4
        r2qn_count = r2qn_count + 1
        qn_count = qn_count + 1
        qn_count4 = qn_count4 + 1
        If team = 4 And qn_count4 = 2 Then
            Button4.Enabled = False
        End If
        Form3.Show()
        If round = 4 Then
            Form6.Show()

        End If
        If round = 5 Then 'Rapid fire
            Form7.Show()
            Form3.Hide()
        End If
    End Sub
End Class