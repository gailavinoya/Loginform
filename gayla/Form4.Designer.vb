<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class btnReset
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        btnPaper = New Button()
        btnRock = New Button()
        btnScissors = New Button()
        picPlayer = New Button()
        picComputer = New Button()
        PictureBox = New Label()
        PictureBox1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(151, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(394, 33)
        Label1.TabIndex = 3
        Label1.Text = "Rock-Paper-Scissors Game"
        ' 
        ' btnPaper
        ' 
        btnPaper.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPaper.Location = New Point(309, 390)
        btnPaper.Name = "btnPaper"
        btnPaper.Size = New Size(75, 70)
        btnPaper.TabIndex = 4
        btnPaper.Text = "✋"
        btnPaper.UseVisualStyleBackColor = True
        ' 
        ' btnRock
        ' 
        btnRock.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRock.Location = New Point(134, 392)
        btnRock.Name = "btnRock"
        btnRock.Size = New Size(75, 70)
        btnRock.TabIndex = 5
        btnRock.Text = "👊"
        btnRock.UseVisualStyleBackColor = True
        ' 
        ' btnScissors
        ' 
        btnScissors.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnScissors.Location = New Point(487, 390)
        btnScissors.Name = "btnScissors"
        btnScissors.Size = New Size(75, 70)
        btnScissors.TabIndex = 6
        btnScissors.Text = "✌️"
        btnScissors.UseVisualStyleBackColor = True
        ' 
        ' picPlayer
        ' 
        picPlayer.Location = New Point(151, 148)
        picPlayer.Name = "picPlayer"
        picPlayer.Size = New Size(108, 98)
        picPlayer.TabIndex = 7
        picPlayer.UseVisualStyleBackColor = True
        ' 
        ' picComputer
        ' 
        picComputer.Location = New Point(425, 150)
        picComputer.Name = "picComputer"
        picComputer.Size = New Size(103, 94)
        picComputer.TabIndex = 8
        picComputer.UseVisualStyleBackColor = True
        ' 
        ' PictureBox
        ' 
        PictureBox.AutoSize = True
        PictureBox.Location = New Point(151, 130)
        PictureBox.Name = "PictureBox"
        PictureBox.Size = New Size(39, 15)
        PictureBox.TabIndex = 9
        PictureBox.Text = "Player"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.AutoSize = True
        PictureBox1.Location = New Point(428, 130)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(61, 15)
        PictureBox1.TabIndex = 10
        PictureBox1.Text = "Computer"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(79, 518)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 11
        Button1.Text = "Reset"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(556, 518)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 12
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(255, 297)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 13
        Button3.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSeaGreen
        ClientSize = New Size(748, 553)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox)
        Controls.Add(picComputer)
        Controls.Add(picPlayer)
        Controls.Add(btnScissors)
        Controls.Add(btnRock)
        Controls.Add(btnPaper)
        Controls.Add(Label1)
        Name = "btnReset"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPaper As Button
    Friend WithEvents btnRock As Button
    Friend WithEvents btnScissors As Button
    Friend WithEvents picPlayer As Button
    Friend WithEvents picComputer As Button
    Friend WithEvents PictureBox As Label
    Friend WithEvents PictureBox1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
