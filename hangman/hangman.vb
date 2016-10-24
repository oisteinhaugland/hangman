Public Class hangman

    Public filmer() As String = {"BATMAN", "TITANIC", "IRONMAN", "SUPERMAN", "ARQ", "godfather"}
    Public landieuropa() As String = {"Belgia", "Frankrike", "Hellas", "Island", "Italia", "tyskland", "polen", "spania", "slovakia", "norge", "danmark", "sverige"}
    Public stateriusa() As String = {"Alaska", "california", "florida", "illinois", "montana", "virginia", "colorado", "washington"}
    Public dyr() As String = {"Gaupe", "Elg", "Ulv", "katt", "hund", "sel", "piggsvin", "spekkhogger", "isbjørn"}


    'Dim tilfeldig()() = {filmer, landieuropa, stateriusa, dyr} forsøk på tilfeldig kategori


    Public word = landieuropa(Rnd() * landieuropa.Length)
    Dim forsok As Integer = 10
    'integer for antall forsøk, denne reduserer vi med 1 når noen får feil lengre nede i koden.

    Dim riktig As Integer = word.length
    'brukes for å definere hvor mange riktige det er i ordet.

    Dim antallriktige As Integer = 0
    'brukes for å definere win lengre nede.

    Dim dead As Boolean = False
    'settes som true ved tap. antall forsøk lik 0.

    Dim ismylettertrue As Boolean = False
    'brukes får å vite når de har riktig.

    Dim bildeCounter As Integer = 2


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized



        'grafiske elemnter i form av buttons blir deaktivert. Labels blir tømt.

        Me.BackgroundImage = Image.FromFile("..\..\Resources\bilde1.jpg")

        brukteBokstaver.Text = String.Empty
        fyllBoks.Enabled = False
        brukteBoks.Enabled = False
        alfabetBoks.Enabled = False

        ordet.Text = String.Empty
        streker.Text = String.Empty
        'ordet.BackColor = Color.Transparent


        ' Her lages det streker i en label for antall bokstaver i ordet, og spaces for antall bokstaver i samme ord.
        For i = 0 To word.length - 1
            ordet.Text += " "
            streker.Text += "-"
        Next
    End Sub


    Sub testPress(check As String)   'check blir ka den de trykker på. dette kunne bli kalt hva som helst, bob eller noe.
        'her er hele prosedyren for å sette bokstaver på riktig plass.

        For y = 1 To 1  'denne loopen skal bare kjøres en gang, formålet er at når de får feil, skal knappen de trykte på vises i "brukte bokstaver" feltet
            For i = 0 To word.length - 1
                If check = word.Substring(i, 1).toUpper Then
                    'substring skjekker 0,1 - 1,1  2,1  3,1  4,1osv. altså en bokstav av gangen. i er start og 1 er slutt.

                    Me.ordet.Text = ordet.Text.Remove(i, 1)      '
                    Me.ordet.Text = ordet.Text.Insert(i, check)  '

                    ismylettertrue = True
                    antallriktige += 1
                End If

            Next


            'Hvis de har feil bokstav, skal bruktebostaver stringen bli lik seg selv (altså ingenting ved første) + check (den bokstaven de trykte på) og et mellomrom
            'for hver feil, sett antall forsøk 1 mindre. når forsøk har nådd 0, settes dead til true.
            If ismylettertrue = False Then
                brukteBokstaver.Text += check & " "
                forsok -= 1
                If forsok = 0 Then
                    dead = True
                End If

                PictureBox1.Image = Image.FromFile("..\..\Resources\" & bildeCounter & ".png")
                If forsok <> 0 Then
                    bildeCounter += 1

                End If

            End If

            'If brukteBokstaver.Text.Length = 20 Then
            '    brukteBokstaver.Text += vbCrLf
            'End If

            ismylettertrue = False
            If antallriktige = riktig Then
                Timer1.Enabled = True
                Timer1.Interval = 1500
            End If
        Next

    End Sub


    'Når hvilken som helst knapp trykkes, altså alle alfabetknappene
    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, fyllBoks.Click, Button3.Click, Button29.Click, Button28.Click, Button27.Click, Button26.Click, Button25.Click, Button24.Click, Button23.Click, Button22.Click, Button21.Click, Button20.Click, Button2.Click, Button19.Click, Button18.Click, Button17.Click, Button16.Click, Button15.Click, Button14.Click, Button13.Click, Button12.Click, Button11.Click, Button10.Click, Button1.Click
        testPress((DirectCast(sender, Button).Text))    'DirectCast(sender, Button) er koden for å finne ut hvilken knapp som ble trykt på, slik at det bare skjer med den respektive knappen og ikke alle.
        DirectCast(sender, Button).Enabled = False      'skrur av knappen som ble trykt på.

        If dead = True Then 'antall forsøk er lik 0
            ' if worked wihu.
            Timer2.Enabled = True
            Timer2.Interval = 1500
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Close()
        theEnd.Show()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Close()
        loss.Show()
    End Sub
End Class
