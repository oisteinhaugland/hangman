Public Class hovedSide
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None

        Me.WindowState = FormWindowState.Maximized


        Me.BackgroundImage = Image.FromFile("..\..\..\pages\hoved\hovedside\Resources\larry.jpg")
        ComboBox1.Items.Add("Tilfeldig ord")
        ComboBox1.Items.Add("Filmer")
        ComboBox1.Items.Add("Land i Europa")
        ComboBox1.Items.Add("Stater i USA")
        ComboBox1.Items.Add("Dyr")
        ComboBox1.SelectedIndex = 0

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        hangman.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    spillet.show(ComboBox1.SelectedIndex)
    '    Me.Hide()
    'End Sub

    'Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
    '    spillet.show(ComboBox1.SelectedIndex)
    '    Me.Hide()
    'End Sub

    'Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    'End Sub
End Class
