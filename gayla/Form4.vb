Imports System.Reflection.Emit

Public Class btnReset
    Dim score As Integer = 0

    Dim strComputer() As String = {"Rock", "Paper", "Scissor"}

    Private Sub btnRock_Click(sender As Object, e As EventArgs) Handles btnRock.Click
        Dim rando As Integer = GetRandom(0, 3)
        Label2.Text = strComputer(rando)
        If rando = 0 Then
            MessageBox.Show("Tie")
            Label2.Text = ""
        ElseIf rando = 1 Then
            MessageBox.Show("You Lose!")
            Label2.Text = ""
        Else
            MessageBox.Show("You Won!")
            score += 1
            Label2.Text = ""
            Label1.Text = score
        End If
    End Sub

    Private Sub btnPaper_Click(sender As Object, e As EventArgs) Handles btnPaper.Click
        Dim rando As Integer = GetRandom(0, 3)
        Label2.Text = strComputer(rando)
        If rando = 0 Then
            MessageBox.Show("You Won!")
            score += 1
            Label2.Text = ""
            Label1.Text = score
        ElseIf rando = 1 Then
            MessageBox.Show("Tie")
            Label2.Text = ""
        Else
            MessageBox.Show("You Lose!")
            Label2.Text = ""

        End If
    End Sub
    Private Sub btnScissors_Click(sender As Object, e As EventArgs) Handles btnScissors.Click
        Dim rando As Integer = GetRandom(0, 3)
        Label2.Text = strComputer(rando)
        If rando = 0 Then
            MessageBox.Show("You Lose!")
            Label2.Text = ""
        ElseIf rando = 1 Then
            MessageBox.Show("You Won!")
            score += 1
            Label2.Text = ""
            Label1.Text = score
        Else
            MessageBox.Show("Tie")
            Label2.Text = ""
        End If
    End Sub
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class