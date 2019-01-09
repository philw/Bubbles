Public Class MainForm

    Dim Bubble1 As Bubble
    Dim Bubble2 As Bubble

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Bubble1 = New Bubble(40, 330, 30)
        Bubble2 = New Bubble(100, 300, 10)

    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint

        Bubble1.Draw(e.Graphics)
        Bubble2.Draw(e.Graphics)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Bubble1.Move()
        Bubble2.Move()
        PictureBox1.Refresh()

    End Sub

End Class
