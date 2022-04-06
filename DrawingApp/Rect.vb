Public Class Rect
    Public Property Pen As Pen
    Public Property fill As Boolean
    Dim m_image As Image
    Dim m_a As Point
    Dim m_b As Point

    Public Sub New(i As Image, a As Point, b As Point)
        Pen = Pens.Red
        m_image = i
        m_a = a
        m_b = b
    End Sub
    Public Sub Draw()
        Using g As Graphics = Graphics.FromImage(m_image)
            If fill Then
                Dim lingrBrush As Drawing.Drawing2D.LinearGradientBrush
                lingrBrush = New Drawing.Drawing2D.LinearGradientBrush(
                                New Point(0, 10),
                                New Point(200, 10),
                                Color.FromArgb(255, 255, 0, 0),
                                Color.FromArgb(255, 0, 0, 255))

                g.FillRectangle(New SolidBrush(Pen.Color), m_a.X, m_b.Y, 100, 75)
            Else
                g.DrawRectangle(Pen, m_a.X, m_b.Y, 100, 75)
            End If
            'g.DrawArc(Pen, m_a.X, m_b.Y, 100, 100, 0, 90)

        End Using

    End Sub

End Class
