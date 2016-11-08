Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'It's a Sort of Selection
        Me.WindowState = 2
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        question = 1
        If round = 1 Then
            Form10.Show()
            Form10.TextBox1.Text = "What is your name ?"
            Button1.Enabled = False
        End If
        If round = 2 Then
            Form4.Show()
            Form4.TextBox1.Text = "This is the 1 Question"
            Button1.Enabled = False
        End If
        If round = 3 Then
            Form5.Show()
            Form5.AxVLCPlugin21.playlist.add("file:///" & "C:\Heartwin\Videos\20 Second Countdown Timer.mp4" & "")
            Form5.AxVLCPlugin21.playlist.play()
            Button1.Enabled = False
        End If
        If round = 4 Then
            Form10.Show()
            If cat = 1 Then
                Form10.TextBox1.Text = "what is 1+1  ?" 'round4 q1
            End If
            If cat = 2 Then
                Form10.TextBox1.Text = "what is GK  ?" 'round4 q1
            End If
            If cat = 3 Then
                Form10.TextBox1.Text = "what is 1+1  ?" 'round4 q1
            End If
            If cat = 4 Then
                Form10.TextBox1.Text = "what is GK  ?" 'round4 q1
            End If
            If cat = 5 Then
                Form10.TextBox1.Text = "what is GK  ?" 'round4 q1
            End If
            Button1.Enabled = False
        End If
        ' close_action()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        question = 2
        If round = 1 Then
            Form10.Show()
            Form10.TextBox1.Text = "What is your hobby ?"
            Button2.Enabled = False
        End If
        If round = 2 Then
            Form4.Show()
            Form4.TextBox1.Text = "This is the 2 Question"
            Button2.Enabled = False
        End If
        If round = 3 Then
            Form5.Show()
            Form5.AxVLCPlugin21.playlist.add("file:///" & "C:\Heartwin\Videos\20 Second Countdown Timer.mp4" & "")
            Form5.AxVLCPlugin21.playlist.play()
            Button2.Enabled = False
        End If
        If round = 4 Then
            Form10.Show()
            If cat = 1 Then
                Form10.TextBox1.Text = "what is 1+1  ?" 'round4 q2
            End If
            If cat = 2 Then
                Form10.TextBox1.Text = "what is GK  ?" 'round4 q2
            End If
            If cat = 3 Then
                Form10.TextBox1.Text = "what is 1+1  ?" 'round4 q2
            End If
            If cat = 4 Then
                Form10.TextBox1.Text = "what is GK  ?" 'round4 q2
            End If
            If cat = 5 Then
                Form10.TextBox1.Text = "what is GK  ?" 'round4 q2
            End If
            Button1.Enabled = False
        End If
        'close_action()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        question = 3
        If round = 1 Then
            Form10.Show()
            Form10.TextBox1.Text = "What is your favourite flower ?"
            Button3.Enabled = False
        End If
        If round = 2 Then
            Form4.Show()
            Form4.TextBox1.Text = "This is the 3 Question"
            Button3.Enabled = False
        End If
        If round = 3 Then
            Form5.Show()
            Form5.AxVLCPlugin21.playlist.add("file:///" & "C:\Heartwin\Videos\20 Second Countdown Timer.mp4" & "")
            Form5.AxVLCPlugin21.playlist.play()
            Button3.Enabled = False
        End If
        If round = 4 Then
            Form10.Show()
            If cat = 1 Then
                Form10.TextBox1.Text = "what is 1+1  ?" 'round4 q3
            End If
            If cat = 2 Then
                Form10.TextBox1.Text = "what is GK  ?" 'round4 q3
            End If
            If cat = 3 Then
                Form10.TextBox1.Text = "what is 1+1  ?" 'round4 q3
            End If
            If cat = 4 Then
                Form10.TextBox1.Text = "what is GK  ?" 'round4 q3
            End If
            If cat = 5 Then
                Form10.TextBox1.Text = "what is GK  ?" 'round4 q3
            End If
            Button1.Enabled = False
        End If
        'close_action()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        question = 4
        If round = 1 Then
            Form10.Show()
            Form10.TextBox1.Text = "What is your favourite place ?"
            Button4.Enabled = False
        End If
        If round = 2 Then
            Form4.Show()
            Form4.TextBox1.Text = "This is the 4 Question"
            Button4.Enabled = False
        End If
        If round = 3 Then
            Form5.Show()
            Form5.AxVLCPlugin21.playlist.add("file:///" & "C:\Heartwin\Videos\20 Second Countdown Timer.mp4" & "")
            Form5.AxVLCPlugin21.playlist.play()
            Button4.Enabled = False
        End If
        If round = 4 Then
            Form10.Show()
            If cat = 1 Then
                Form10.TextBox1.Text = "what is 1+1  ?" 'round4 q4
            End If
            If cat = 2 Then
                Form10.TextBox1.Text = "what is GK  ?" 'round4 q4
            End If
            If cat = 3 Then
                Form10.TextBox1.Text = "what is 1+1  ?" 'round4 q4
            End If
            If cat = 4 Then
                Form10.TextBox1.Text = "what is GK  ?" 'round4 q4
            End If
            If cat = 5 Then
                Form10.TextBox1.Text = "what is GK  ?" 'round4 q4
            End If
            Button1.Enabled = False
        End If
        'close_action()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        question = 5
        If round = 1 Then
            Form10.Show()
            Form10.TextBox1.Text = "What is your eye power?"
            Button5.Enabled = False
        End If
        If round = 2 Then
            Form4.Show()
            Form4.TextBox1.Text = "This is the 5 Question"
            Button5.Enabled = False
        End If
        If round = 3 Then
            Form5.Show()
            Form5.AxVLCPlugin21.playlist.add("file:///" & "C:\Heartwin\Videos\20 Second Countdown Timer.mp4" & "")
            Form5.AxVLCPlugin21.playlist.play()
            Button5.Enabled = False
        End If
        If round = 4 Then
            Form10.Show()
            If cat = 1 Then
                Form10.TextBox1.Text = "what is 1+1  ?" 'round4 q5
            End If
            If cat = 2 Then
                Form10.TextBox1.Text = "what is GK  ?" 'round4 q5
            End If
            If cat = 3 Then
                Form10.TextBox1.Text = "what is 1+1  ?" 'round4 q5
            End If
            If cat = 4 Then
                Form10.TextBox1.Text = "what is GK  ?" 'round4 q5
            End If
            If cat = 5 Then
                Form10.TextBox1.Text = "what is GK  ?" 'round4 q5
            End If
            Button1.Enabled = False
        End If
        'close_action()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        question = 6
        If round = 1 Then
            Form10.Show()
            Form10.TextBox1.Text = "Whats your grade?"
            Button6.Enabled = False
        End If
        If round = 2 Then
            Form4.Show()
            Form4.TextBox1.Text = "This is the 6 Question"
            Button6.Enabled = False
        End If
        If round = 3 Then
            Form5.Show()
            Form5.AxVLCPlugin21.playlist.add("file:///" & "C:\Heartwin\Videos\20 Second Countdown Timer.mp4" & "")
            Form5.AxVLCPlugin21.playlist.play()
            Button6.Enabled = False
        End If
        If round = 4 Then
            Form10.Show()
            If cat = 1 Then
                Form10.TextBox1.Text = "what is 1+1  ?" 'round4 q6
            End If
            If cat = 2 Then
                Form10.TextBox1.Text = "what is GK  ?" 'round4 q6
            End If
            If cat = 3 Then
                Form10.TextBox1.Text = "what is 1+1  ?" 'round4 q6
            End If
            If cat = 4 Then
                Form10.TextBox1.Text = "what is GK  ?" 'round4 q6
            End If
            If cat = 5 Then
                Form10.TextBox1.Text = "what is GK  ?" 'round4 q6
            End If
            Button1.Enabled = False
        End If
        'close_action()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        question = 7
        If round = 1 Then
            Form10.Show()
            Form10.TextBox1.Text = "Whats your School?"
            Button7.Enabled = False
        End If
        If round = 2 Then
            Form4.Show()
            Form4.TextBox1.Text = "This is the 7 Question"
            Button7.Enabled = False
        End If
        If round = 3 Then
            Form5.Show()
            Form5.AxVLCPlugin21.playlist.add("file:///" & "C:\Heartwin\Videos\20 Second Countdown Timer.mp4" & "")
            Form5.AxVLCPlugin21.playlist.play()
            Button7.Enabled = False
        End If
        If round = 4 Then
            Form10.Show()
            If cat = 1 Then
                Form10.TextBox1.Text = "what is 1+1  ?" 'round4 q7
            End If
            If cat = 2 Then
                Form10.TextBox1.Text = "what is GK  ?" 'round4 q7
            End If
            If cat = 3 Then
                Form10.TextBox1.Text = "what is 1+1  ?" 'round4 q7
            End If
            If cat = 4 Then
                Form10.TextBox1.Text = "what is GK  ?" 'round4 q7
            End If
            If cat = 5 Then
                Form10.TextBox1.Text = "what is GK  ?" 'round4 q7
            End If
            Button1.Enabled = False
        End If
        'close_action()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        question = 8
        If round = 1 Then
            Form10.Show()
            Form10.TextBox1.Text = "had your breakfast?"
            Button8.Enabled = False
        End If
        If round = 2 Then
            Form4.Show()
            Form4.TextBox1.Text = "This is the 8 Question"
            Button8.Enabled = False
        End If
        If round = 3 Then
            Form5.Show()
            Form5.AxVLCPlugin21.playlist.add("file:///" & "C:\Heartwin\Videos\20 Second Countdown Timer.mp4" & "")
            Form5.AxVLCPlugin21.playlist.play()
            Button8.Enabled = False
        End If
        If round = 4 Then
            Form10.Show()
            If cat = 1 Then
                Form10.TextBox1.Text = "what is 1+1  ?" 'round4 q8
            End If
            If cat = 2 Then
                Form10.TextBox1.Text = "what is GK  ?" 'round4 q8
            End If
            If cat = 3 Then
                Form10.TextBox1.Text = "what is 1+1  ?" 'round4 q8
            End If
            If cat = 4 Then
                Form10.TextBox1.Text = "what is GK  ?" 'round4 q8
            End If
            If cat = 5 Then
                Form10.TextBox1.Text = "what is GK  ?" 'round4 q8
            End If
            Button1.Enabled = False
        End If
        'close_action()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        question = 9
        If round = 1 Then
            Form10.Show()
            Form10.TextBox1.Text = "Am i looking good?"
            Button9.Enabled = False
        End If
        If round = 2 Then
            Form4.Show()
            Form4.TextBox1.Text = "This is the 9 Question"
            Button9.Enabled = False
        End If
        If round = 3 Then
            Form5.Show()
            Form5.AxVLCPlugin21.playlist.add("file:///" & "C:\Heartwin\Videos\20 Second Countdown Timer.mp4" & "")
            Form5.AxVLCPlugin21.playlist.play()
            Button9.Enabled = False
        End If
        If round = 4 Then
            Form10.Show()
            If cat = 1 Then
                Form10.TextBox1.Text = "what is 1+1  ?" 'round4 q9
            End If
            If cat = 2 Then
                Form10.TextBox1.Text = "what is GK  ?" 'round4 q9
            End If
            If cat = 3 Then
                Form10.TextBox1.Text = "what is 1+1  ?" 'round4 q9
            End If
            If cat = 4 Then
                Form10.TextBox1.Text = "what is GK  ?" 'round4 q9
            End If
            If cat = 5 Then
                Form10.TextBox1.Text = "what is GK  ?" 'round4 q9
            End If
            Button1.Enabled = False
        End If
        'close_action()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        question = 10
        If round = 1 Then
            Form10.Show()
            Form10.TextBox1.Text = "Am i obedient?"
            Button10.Enabled = False
        End If
        If round = 2 Then
            Form4.Show()
            Form4.TextBox1.Text = "This is the 10 Question"
            Button10.Enabled = False
        End If
        If round = 3 Then
            Form5.Show()
            Form5.AxVLCPlugin21.playlist.add("file:///" & "C:\Heartwin\Videos\20 Second Countdown Timer.mp4" & "")
            Form5.AxVLCPlugin21.playlist.play()
            Button10.Enabled = False
        End If
        If round = 4 Then
            Form10.Show()
            If cat = 1 Then
                Form10.TextBox1.Text = "what is 1+1  ?" 'round4 q10
            End If
            If cat = 2 Then
                Form10.TextBox1.Text = "what is GK  ?" 'round4 q10
            End If
            If cat = 3 Then
                Form10.TextBox1.Text = "what is 1+1  ?" 'round4 q10
            End If
            If cat = 4 Then
                Form10.TextBox1.Text = "what is GK  ?" 'round4 q10
            End If
            If cat = 5 Then
                Form10.TextBox1.Text = "what is GK  ?" 'round4 q10
            End If
            Button1.Enabled = False
        End If
        'close_action()
    End Sub
End Class