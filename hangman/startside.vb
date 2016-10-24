Public Class startside
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        hovedSide.Show()


    End Sub

    Private Sub startside_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.FormBorderStyle = FormBorderStyle.None

        Me.WindowState = FormWindowState.Maximized


        Me.BackgroundImage = Image.FromFile("..\..\..\Pages\start\startside\Resources\larry.jpg")

    End Sub
End Class
