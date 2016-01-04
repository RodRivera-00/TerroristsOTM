Public Class Form1
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim labels1() As Label
    Dim labels2() As Label
    Dim labels3() As Label
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Menu.Hide()
        Play.Hide()
        Highscore.Hide()
        Options.Hide()
        showmenu()
        Form2.Show()
        labels1 = {OneOne, Label4, Label5, Label6, Label7}
        labels2 = {Label8, Label9, Label10, Label11, Label12}
        labels3 = {Label13, Label14, Label15, Label16, Label17}
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.WindowState = FormWindowState.Minimized
        Form2.RichTextBox1.Text = "Time: " & TimeOfDay & " Minimize Button: Activated" & vbNewLine & Form2.RichTextBox1.Text
    End Sub
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            drag = True
            mousex = Windows.Forms.Cursor.Position.X - Me.Left
            mousey = Windows.Forms.Cursor.Position.Y - Me.Top
        End If
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        drag = False
    End Sub
    Private Sub showmenu()
        Form2.RichTextBox1.Text = "Time: " & TimeOfDay & " Show Menu: Activated" & vbNewLine & Form2.RichTextBox1.Text
        Graphics1.Size = Me.Size
        Graphics1.Location = New Point(0, 0)
        PlayButton.Size = New Size(150, 50)
        PlayButton.Location = New Point(Me.Size.Width - (150 + 25), (50 + 25))
        HighscoreButton.Size = New Size(150, 50)
        HighscoreButton.Location = New Point(Me.Size.Width - (150 + 25), (110 + 25))
        OptionsButton.Size = New Size(150, 50)
        OptionsButton.Location = New Point(Me.Size.Width - (150 + 25), (170 + 25))
        QuitButton.Size = New Size(150, 50)
        QuitButton.Location = New Point(Me.Size.Width - (150 + 25), (230 + 25))
        Menu.Size = Me.Size
        Menu.Location = New Point(0, 0)
        Play.Hide()
        Highscore.Hide()
        Options.Hide()
        Menu.Show()
    End Sub
    Private Sub showplay()
        Form2.RichTextBox1.Text = "Time: " & TimeOfDay & " Show Play: Activated" & vbNewLine & Form2.RichTextBox1.Text
        Graphics2.Size = Me.Size
        Graphics2.Location = New Point(0, 0)
        Play.Size = Me.Size
        Play.Location = New Point(0, 0)
        TerroristButton.Size = New Size(150, 50)
        TerroristButton.Location = New Point(Me.Size.Width - (150 + 25), (50 + 25))
        MilitaryButton.Size = New Size(150, 50)
        MilitaryButton.Location = New Point(Me.Size.Width - (150 + 25), (110 + 25))
        BackPlay.Size = New Size(150, 50)
        BackPlay.Location = New Point(Me.Size.Width - (150 + 25), (170 + 25))
        Highscore.Hide()
        Options.Hide()
        Menu.Hide()
        Play.Show()
    End Sub
    Private Sub showhighscores()
        Dim a As Integer
        a = (Me.Size.Width - 450) / 3
        Form2.RichTextBox1.Text = "Time: " & TimeOfDay & " Show Highscores: Activated" & vbNewLine & Form2.RichTextBox1.Text
        Graphics3.Size = Me.Size
        Graphics3.Location = New Point(0, 0)
        Highscore.Size = Me.Size
        Highscore.Location = New Point(0, 0)
        Title1.Size = New Size(150, 75)
        Title1.Location = New Point(Me.Size.Width / 3 - (150), 25)
        Title2.Size = New Size(150, 75)
        Title2.Location = New Point((Me.Size.Width / 3) * 2 - (150 + a / 2), 25)
        Title3.Size = New Size(150, 75)
        Title3.Location = New Point((Me.Size.Width / 3) * 3 - (150 + a), 25)
        BackHS.Size = New Size(150, 50)
        BackHS.Location = New Point(25, Me.Size.Height - (25 + 50))

        For i As Integer = 0 To 4
            labels1(i).Font = New Font("Century Gothic", 20)
            labels2(i).Font = New Font("Century Gothic", 20)
            labels3(i).Font = New Font("Century Gothic", 20)
            labels1(i).Location = New Point(Title1.Location.X - 5, Title1.Location.Y + 80 + 50 * i)
            labels2(i).Location = New Point(Title2.Location.X - 5, Title1.Location.Y + 80 + 50 * i)
            labels3(i).Location = New Point(Title3.Location.X - 5, Title1.Location.Y + 80 + 50 * i)
        Next

        Highscore.Show()
        Options.Hide()
        Menu.Hide()
        Play.Hide()
    End Sub
    Private Sub showoptions()
        Form2.RichTextBox1.Text = "Time: " & TimeOfDay & " Show Options: Activated" & vbNewLine & Form2.RichTextBox1.Text
        Graphics4.Size = Me.Size
        Graphics4.Location = New Point(0, 0)
        Options.Size = Me.Size
        Options.Location = New Point(0, 0)
        Resolution.Size = New Size(Me.Size.Width / 2 - 10, (Me.Size.Height - 67) / 5)
        Resolution.Location = New Point(10, PictureBox1.Size.Height + 10)
        Quality.Size = New Size(Me.Size.Width / 2 - 10, (Me.Size.Height - 67) / 5)
        Quality.Location = New Point(10, Resolution.Location.Y + Resolution.Size.Height + 5)
        Sound.Size = New Size(Me.Size.Width / 2 - 10, (Me.Size.Height - 67) / 5)
        Sound.Location = New Point(10, Quality.Location.Y + Quality.Size.Height + 5)
        Difficulty.Size = New Size(Me.Size.Width / 2 - 10, (Me.Size.Height - 67) / 5)
        Difficulty.Location = New Point(10, Sound.Location.Y + Sound.Size.Height + 5)
        QualityOptions.Location = New Point(Quality.Location.X + Quality.Size.Width, Quality.Location.Y)
        QualityOptions.Size = New Size(Me.Size.Width / 2 - 10, (Me.Size.Height - 67) / 5)
        ResolutionOptions.Location = New Point(Resolution.Location.X + Resolution.Size.Width, Resolution.Location.Y)
        ResolutionOptions.Size = New Size(Me.Size.Width / 2 - 10, (Me.Size.Height - 67) / 5)
        SoundValue.Location = New Point(Sound.Location.X + Sound.Size.Width, Sound.Location.Y)
        SoundValue.Size = New Size(Me.Size.Width / 2 - 10, (Me.Size.Height - 67) / 5)
        DifficultyOptions.Location = New Point(Difficulty.Location.X + Difficulty.Size.Width, Difficulty.Location.Y)
        DifficultyOptions.Size = New Size(Me.Size.Width / 2 - 10, (Me.Size.Height - 67) / 5)

        Back.Location = New Point(Difficulty.Location.X, Difficulty.Location.Y + Difficulty.Height + 5)
        Back.Size = New Size(Me.Size.Width / 3 - 10, (Me.Size.Height - 67) / 5)
        Help.Location = New Point(Back.Location.X + Back.Size.Width + 5, Difficulty.Location.Y + Difficulty.Height + 5)
        Help.Size = New Size(Me.Size.Width / 3 - 10, (Me.Size.Height - 67) / 5)
        About.Location = New Point(Help.Location.X + Help.Size.Width + 5, Difficulty.Location.Y + Difficulty.Height + 5)
        About.Size = New Size(Me.Size.Width / 3 - 10, (Me.Size.Height - 67) / 5)

        Highscore.Hide()
        Options.Show()
        Menu.Hide()
        Play.Hide()
    End Sub
    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        showplay()
    End Sub

    Private Sub BackPlay_Click(sender As Object, e As EventArgs) Handles BackPlay.Click
        showmenu()
    End Sub

    Private Sub HighscoreButton_Click(sender As Object, e As EventArgs) Handles HighscoreButton.Click
        showhighscores()
    End Sub

    Private Sub BackHS_Click(sender As Object, e As EventArgs) Handles BackHS.Click
        showmenu()
    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub

    Private Sub OptionsButton_Click(sender As Object, e As EventArgs) Handles OptionsButton.Click
        showoptions()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        showmenu()
    End Sub
End Class
