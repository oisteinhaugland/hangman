Public Class Form1
    Dim word = "FOTBALL"
    ' Dim corrects = New Boolean() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    Dim forsok As Integer = 10
    Dim dead As Boolean = False
    Dim ismylettertrue As Boolean = False



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        brukteBokstaver.Text = String.Empty
        Button30.Enabled = False
        Button31.Enabled = False
        Button32.Enabled = False

        ordet.Text = String.Empty
        streker.Text = String.Empty
        ordet.BackColor = Color.Transparent

        For i = 0 To word.length - 1
            ordet.Text += " "
            streker.Text += "-"
        Next


    End Sub


    Function testPress(check As String)


        For y = 1 To 1
            For i = 0 To word.length - 1
                If check = word.Substring(i, 1) Then
                    ' corrects(i) = 1
                    Me.ordet.Text = ordet.Text.Remove(i, 1)
                    Me.ordet.Text = ordet.Text.Insert(i, check)
                    ismylettertrue = True
                End If
            Next

            If ismylettertrue = False Then
                brukteBokstaver.Text += check & " "
                forsok -= 1
                If forsok = 0 Then
                    dead = True
                End If
            End If

            If brukteBokstaver.Text.Length = 20 Then
                brukteBokstaver.Text += vbCrLf
            End If

            ismylettertrue = False
        Next

    End Function



    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button30.Click, Button3.Click, Button29.Click, Button28.Click, Button27.Click, Button26.Click, Button25.Click, Button24.Click, Button23.Click, Button22.Click, Button21.Click, Button20.Click, Button2.Click, Button19.Click, Button18.Click, Button17.Click, Button16.Click, Button15.Click, Button14.Click, Button13.Click, Button12.Click, Button11.Click, Button10.Click, Button1.Click
        testPress((DirectCast(sender, Button).Text))
        DirectCast(sender, Button).Enabled = False
        If dead = True Then
            ' if worked wihu.
            MsgBox("He died, larry succeded.")
        End If
    End Sub











    ' Dim wordL = word.length
    ' Dim labels = New Label() {New Label, New Label, New Label, New Label}
    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    '    For i = 0 To 3

    '        labels(i).Location = New System.Drawing.Point(200 + i * 70, 100)
    '        labels(i).Text = "her " & i
    '        Me.Controls.Add(labels(i))
    '    Next

    'End Sub

End Class
