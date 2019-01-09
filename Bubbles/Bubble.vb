Public Class Bubble

    Private PositionX As Integer
    Private PositionY As Integer
    Private Size As Integer

    Public Sub New(X As Integer, Y As Integer, S As Integer)
        PositionX = X
        PositionY = Y
        Size = S
    End Sub

    Public Sub Move()
        PositionY -= Size / 5
    End Sub

    Public Sub Draw(g As Graphics)
        Dim Pen As New Pen(Color.Red)
        g.DrawEllipse(Pen, PositionX, PositionY, Size, Size)
    End Sub

End Class
