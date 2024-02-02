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
        rps1 = New Label()
        btnPaper = New Button()
        btnRock = New Button()
        btnScissors = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' rps1
        ' 
        rps1.AutoSize = True
        rps1.Font = New Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rps1.Location = New Point(160, 100)
        rps1.Name = "rps1"
        rps1.Size = New Size(394, 33)
        rps1.TabIndex = 3
        rps1.Text = "Rock-Paper-Scissors Game"
        ' 
        ' btnPaper
        ' 
        btnPaper.Font = New Font("Microsoft Sans Serif", 36F)
        btnPaper.Location = New Point(275, 189)
        btnPaper.Name = "btnPaper"
        btnPaper.Size = New Size(152, 125)
        btnPaper.TabIndex = 4
        btnPaper.Text = "✋"
        btnPaper.UseVisualStyleBackColor = True
        ' 
        ' btnRock
        ' 
        btnRock.Font = New Font("Microsoft Sans Serif", 36F)
        btnRock.Location = New Point(85, 189)
        btnRock.Name = "btnRock"
        btnRock.Size = New Size(148, 125)
        btnRock.TabIndex = 5
        btnRock.Text = "👊"
        btnRock.UseVisualStyleBackColor = True
        ' 
        ' btnScissors
        ' 
        btnScissors.Font = New Font("Microsoft Sans Serif", 36F)
        btnScissors.Location = New Point(472, 189)
        btnScissors.Name = "btnScissors"
        btnScissors.Size = New Size(158, 125)
        btnScissors.TabIndex = 6
        btnScissors.Text = "✌️"
        btnScissors.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(611, 513)
        Button2.Name = "Button2"
        Button2.Size = New Size(109, 28)
        Button2.TabIndex = 12
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Ravie", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(545, 327)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 22)
        Label1.TabIndex = 14
        Label1.Text = "Score"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Vineta BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(85, 327)
        Label2.Name = "Label2"
        Label2.Size = New Size(164, 26)
        Label2.TabIndex = 15
        Label2.Text = "Computer:"
        ' 
        ' btnReset
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSeaGreen
        ClientSize = New Size(748, 553)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(btnScissors)
        Controls.Add(btnRock)
        Controls.Add(btnPaper)
        Controls.Add(rps1)
        Name = "btnReset"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents rps1 As Label
    Friend WithEvents btnPaper As Button
    Friend WithEvents btnRock As Button
    Friend WithEvents btnScissors As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
