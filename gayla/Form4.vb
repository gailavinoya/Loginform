Public Class btnReset
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles btnPaper.Click
        Dim randomGenerator As New Random()
        Dim computerChoice As Integer

        picPlayer.Image = btnPaper.Image
        computerChoice = randomGenerator.[Next](1, 4)
        Select Case computerChoice
            Case 1
                picComputer.Image = btnRock.Image
                PictureBox.Text = " Player won because paper covers rock "
                Exit Select
            Case 2
                picComputer.Image = btnPaper.Image
                PictureBox.Text = " TIE "
                Exit Select
            Case 3
                picComputer.Image = btnScissors.Image
                PictureBox.Text = " Computer won because scissors cut paper "
                Exit Select
        End Select
    End Sub


    Private Sub UserSelection_Click(sender As Object, e As EventArgs) Handles btnRock.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles picComputer.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles picPlayer.Click

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim randomGenerator As New Random()
        Dim computerChoice As Integer

        picPlayer.Image = btnPaper.Image
        computerChoice = randomGenerator.[Next](1, 4)
        Select Case computerChoice
            Case 1
                picComputer.Image = btnRock.Image
                PictureBox.Text = " Player won because paper covers rock "
                Exit Select
            Case 2
                picComputer.Image = btnPaper.Image
                PictureBox.Text = " TIE "
                Exit Select
            Case 3
                picComputer.Image = btnScissors.Image
                PictureBox.Text = " Computer won because scissors cut paper "
                Exit Select
        End Select
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles PictureBox.Click

    End Sub

    Private Sub btnScissors_Click(sender As Object, e As EventArgs) Handles btnScissors.Click
        Dim randomGenerator As New Random()
        Dim computerChoice As Integer

        picPlayer.Image = btnScissors.Image
        computerChoice = randomGenerator.[Next](1, 4)
        Select Case computerChoice
            Case 1
                picComputer.Image = btnRock.Image
                PictureBox.Text = " Computer won because rock breaks scissors "
                Exit Select
            Case 2
                picComputer.Image = btnPaper.Image
                PictureBox.Text = " Player won because scissors cut paper "
                Exit Select
            Case 3
                picComputer.Image = btnScissors.Image
                PictureBox.Text = " TIE "
                Exit Select
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        picComputer.Image = PictureBox.Image
        picPlayer.Image = PictureBox.Image
    End Sub
End Class