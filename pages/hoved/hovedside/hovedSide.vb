Public Class hovedSide
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = Image.FromFile("..\..\Resources\bilde2.jpg")
        ComboBox1.Items.Add("Spill alle")
        ComboBox1.Items.Add("Filmer")
        ComboBox1.Items.Add("Land i Europa")
        ComboBox1.Items.Add("Stater i USA")
        ComboBox1.Items.Add("Filmstjerner")
        ComboBox1.Items.Add("Dyr")
        ComboBox1.SelectedIndex = 0



        Dim filmer(10) As String
            filmer(0) = "Harry Potte"
            filmer(1) = "Ringenes Herre"
            filmer(2) = "Løvenes Konge"
            filmer(3) = "Den Lille Havfruen"
            filmer(4) = "Batman"
            filmer(5) = "Titanic"
            filmer(6) = "Star Wars"
            filmer(7) = "Ironman"
            filmer(8) = "Superman"
            filmer(9) = "Fight Club"

            Dim landieuropa(10) As String
            landieuropa(0) = "Belgia"
            landieuropa(1) = "Frankriket"
            landieuropa(2) = "Hellas"
            landieuropa(3) = "Island"
            landieuropa(4) = "Italia"
            landieuropa(5) = "Polen"
            landieuropa(6) = "Spania"
            landieuropa(7) = "Slovakia"
            landieuropa(8) = "Tyskland"
            landieuropa(9) = "Norge"

            Dim stateriusa(10) As String
            stateriusa(0) = "Alaska"
            stateriusa(1) = "California"
            stateriusa(2) = "Florida"
            stateriusa(3) = "Illionis"
            stateriusa(4) = "Montana"
            stateriusa(5) = "New York"
            stateriusa(6) = "Virginia"
            stateriusa(7) = "Washington"
            stateriusa(8) = "Oregon"
            stateriusa(9) = "Colorado"

            Dim filmstjerner(10) As String
            filmstjerner(0) = "Aksel Hennie"
            filmstjerner(1) = "Al Pacino"
            filmstjerner(2) = "Leonardo DiCaprio"
            filmstjerner(3) = "Angelina Jolie"
            filmstjerner(4) = "Jennifer Aniston"
            filmstjerner(5) = "Brad Pitt"
            filmstjerner(6) = "Jonny Depp"
            filmstjerner(7) = "Tom Hanks"
            filmstjerner(8) = "Emma Watson"
            filmstjerner(9) = "Ane Dahl Torp"

            Dim dyr(10) As String
            dyr(0) = "Gaupe"
            dyr(1) = "Elg"
            dyr(2) = "Ulv"
            dyr(3) = "Katt"
            dyr(4) = "Hund"
            dyr(5) = "Sel"
            dyr(6) = "Sibirsk Tiger"
            dyr(7) = "Piggsvin"
            dyr(8) = "Spekkhugger"
            dyr(9) = "Isbjørn"

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim form3 As New 
        'spillet.show()
        'Me.Hide()







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
