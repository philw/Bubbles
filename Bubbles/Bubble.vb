Public Class Bubble

    Private PositionX As Integer
    Private PositionY As Integer
    Private Radius As Integer

    Public Sub New(X As Integer, Y As Integer, R As Integer)
        PositionX = X
        PositionY = Y
        Radius = R
    End Sub

    Public Sub Move()
        PositionY -= Radius / 5
    End Sub

    Public Sub Paint(g As Graphics)
        Dim Pen As New Pen(Color.Red, 3)
        g.DrawEllipse(Pen, PositionX, PositionY, Radius, Radius)
    End Sub

End Class
