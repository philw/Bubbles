Public Class MainForm

    Dim Bubble1 As Bubble
    Dim Bubble2 As Bubble

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Bubble1 = New Bubble(40, 330, 30)
        Bubble2 = New Bubble(100, 300, 10)

    End Sub

    Private Sub PictureBox_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox.Paint

        Bubble1.Paint(e.Graphics)
        Bubble2.Paint(e.Graphics)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Bubble1.Move()
        Bubble2.Move()
        PictureBox.Refresh()

    End Sub

End Class
