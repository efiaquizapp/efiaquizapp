Public Class Form4
    Dim qn(9) As String
    Dim hint1(9) As String
    Dim hint2(9) As String
    Dim hint3(9) As String
    Dim i As Integer
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clueless
        Me.WindowState = 2
        i = 0

        'question assignment
        qn(i) = "This is a Question!!"

        'hint 1 assignment
        hint1(i) = "This is the First Hint!"

        'hint 2 assignment
        hint2(i) = "This is the second Hint!"

        'hint 3 assignment
        hint3(i) = "This is the third Hint!"
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        'Hint Box
    End Sub

    Private Sub TextBox1_TextChanged(sendzaer As Object, e As EventArgs) Handles TextBox1.TextChanged
        'Qestion Box
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Hint 1
        TextBox2.Text = hint1(i)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Hint 2
        TextBox2.Text = hint2(i)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Hint 3
        TextBox2.Text = hint3(i)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Correct

        For i = 0 To 3

        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Wrong
    End Sub
End Class