Public Class Form7
    Dim i As Integer
    Dim Qn1(9) As String
    Dim Qn2(9) As String
    Dim Qn3(9) As String
    Dim Qn4(9) As String
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Rapid Fire
        Me.WindowState = 2
        i = 1

        'Questions part
        Qn1(0) = "Which unit is an indication for the sound quality of MP3?" 'set 1
        Qn1(1) = "In computing what is Ram short for?"
        Qn1(2) = "In what year was Google launched on the web?"
        Qn1(3) = "Which device do we use to look at the stars?"

        Qn2(0) = "Which unit is an indication for the sound quality of MP3?" 'set 2
        Qn2(1) = "In computing what is Ram short for?"
        Qn2(2) = "In what year was Google launched on the web?"
        Qn2(3) = "Which device do we use to look at the stars?"

        Qn3(0) = "Which unit is an indication for the sound quality of MP3?" 'set 3
        Qn3(1) = "In computing what is Ram short for?"
        Qn3(2) = "In what year was Google launched on the web?"
        Qn3(3) = "Which device do we use to look at the stars?"

        Qn4(0) = "Which unit is an indication for the sound quality of MP3?" 'set 4
        Qn4(1) = "In computing what is Ram short for?"
        Qn4(2) = "In what year was Google launched on the web?"
        Qn4(3) = "Which device do we use to look at the stars?"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'SKIP

        If team = 1 Then
            TextBox1.Text = Qn1(i)
            i = i + 1
        End If

        If team = 2 Then
            TextBox1.Text = Qn2(i)
            i = i + 1
        End If

        If team = 3 Then
            TextBox1.Text = Qn3(i)
            i = i + 1
        End If

        If team = 4 Then
            TextBox1.Text = Qn4(i)
            i = i + 1
        End If

    End Sub

    Private Sub AxVLCPlugin21_Enter(sender As Object, e As EventArgs) Handles AxVLCPlugin21.Enter
        AxVLCPlugin21.playlist.add("file:///" & "C:\Heartwin\Works\90 seconds countdown timer1.mp4" & "")

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_GotFocus(sender As Object, e As EventArgs) Handles Button2.GotFocus

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'Start
        'only first question
        'remaining questions are in form 7
        AxVLCPlugin21.playlist.play()
        Button3.Visible = False

        If team = 1 Then
            TextBox1.Text = Qn1(0)
        End If
        If team = 2 Then
            TextBox1.Text = Qn2(0)
        End If
        If team = 3 Then
            TextBox1.Text = Qn3(0)
        End If
        If team = 4 Then
            TextBox1.Text = Qn4(0)
        End If
    End Sub
End Class