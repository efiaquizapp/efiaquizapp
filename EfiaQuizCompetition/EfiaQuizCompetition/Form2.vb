Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = 2
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Its a Sort of Selection
        round = 1
        r2qn_count = 0
        r3qn_count = 0
        qn_count1 = 0
        qn_count2 = 0
        qn_count3 = 0
        qn_count4 = 0
        Form9.Button1.Enabled = True
        Form9.Button2.Enabled = True
        Form9.Button3.Enabled = True
        Form9.Button4.Enabled = True

        Form3.Button1.Enabled = True
        Form3.Button2.Enabled = True
        Form3.Button3.Enabled = True
        Form3.Button4.Enabled = True
        Form3.Button5.Enabled = True
        Form3.Button6.Enabled = True
        Form3.Button7.Enabled = True
        Form3.Button8.Enabled = True
        Form3.Button9.Enabled = True
        Form3.Button10.Enabled = True
        Form9.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Clueless
        round = 2
        r2qn_count = 0
        r3qn_count = 0
        qn_count1 = 0
        qn_count2 = 0
        qn_count3 = 0
        qn_count4 = 0
        Form9.Button1.Enabled = True
        Form9.Button2.Enabled = True
        Form9.Button3.Enabled = True
        Form9.Button4.Enabled = True

        Form3.Button1.Enabled = True
        Form3.Button2.Enabled = True
        Form3.Button3.Enabled = True
        Form3.Button4.Enabled = True
        Form3.Button5.Enabled = True
        Form3.Button6.Enabled = True
        Form3.Button7.Enabled = True
        Form3.Button8.Enabled = True
        Form3.Button9.Enabled = True
        Form3.Button10.Enabled = True

        Form9.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Audio/Visual
        round = 3
        r2qn_count = 0
        r3qn_count = 0
        qn_count1 = 0
        qn_count2 = 0
        qn_count3 = 0
        qn_count4 = 0
        Form9.Button1.Enabled = True
        Form9.Button2.Enabled = True
        Form9.Button3.Enabled = True
        Form9.Button4.Enabled = True

        Form3.Button1.Enabled = True
        Form3.Button2.Enabled = True
        Form3.Button3.Enabled = True
        Form3.Button4.Enabled = True
        Form3.Button5.Enabled = True
        Form3.Button6.Enabled = True
        Form3.Button7.Enabled = True
        Form3.Button8.Enabled = True
        Form3.Button9.Enabled = True
        Form3.Button10.Enabled = True

        Form9.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Scategories
        round = 4
        r2qn_count = 0
        r3qn_count = 0
        qn_count1 = 0
        qn_count2 = 0
        qn_count3 = 0
        qn_count4 = 0
        Form9.Button1.Enabled = True
        Form9.Button2.Enabled = True
        Form9.Button3.Enabled = True
        Form9.Button4.Enabled = True

        Form3.Button1.Enabled = True
        Form3.Button2.Enabled = True
        Form3.Button3.Enabled = True
        Form3.Button4.Enabled = True
        Form3.Button5.Enabled = True
        Form3.Button6.Enabled = True
        Form3.Button7.Enabled = True
        Form3.Button8.Enabled = True
        Form3.Button9.Enabled = True
        Form3.Button10.Enabled = True

        Form9.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Rapid Fire
        round = 5
        r2qn_count = 0
        r3qn_count = 0
        qn_count1 = 0
        qn_count2 = 0
        qn_count3 = 0
        qn_count4 = 0
        Form9.Button1.Enabled = True
        Form9.Button2.Enabled = True
        Form9.Button3.Enabled = True
        Form9.Button4.Enabled = True

        Form3.Button1.Enabled = True
        Form3.Button2.Enabled = True
        Form3.Button3.Enabled = True
        Form3.Button4.Enabled = True
        Form3.Button5.Enabled = True
        Form3.Button6.Enabled = True
        Form3.Button7.Enabled = True
        Form3.Button8.Enabled = True
        Form3.Button9.Enabled = True
        Form3.Button10.Enabled = True

        Form9.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'scoreboard

        Form11.Label12.Text = score1
        Form11.Label20.Text = r3score1
        Form11.Label16.Text = r2score1
        tot_score1 = tot_score1 + r2tot_score1 + score1 + r3score1
        Form11.Label32.Text = tot_score1

        Form11.Label13.Text = score2
        tot_score2 = tot_score2 + r2tot_score2
        Form11.Label33.Text = tot_score2
        Form11.Label21.Text = r3score2
        Form11.Label17.Text = r2score2

        Form11.Label14.Text = score3
        tot_score3 = tot_score3 + r2tot_score3
        Form11.Label34.Text = tot_score3
        Form11.Label22.Text = r3score3
        Form11.Label18.Text = r2score3

        Form11.Label15.Text = score4
        tot_score4 = tot_score4 + r2tot_score4
        Form11.Label35.Text = tot_score4
        Form11.Label23.Text = r3score4
        Form11.Label19.Text = r2score4
        Form11.Show()

        tot_score1 = 0
    End Sub

End Class