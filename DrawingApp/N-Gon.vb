Public Class N_Gon
    Public Property Pen As Pen
    Public Property sides As Integer
    Public Property radius As Integer
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
        Dim Points(sides - 1) As Point

        For index = 0 To sides - 1
            Dim x As Integer
            Dim y As Integer

            x = Math.Cos(index * 2 * Math.PI / sides) * radius
            y = Math.Sin(index * 2 * Math.PI / sides) * radius
            Points(index) = New Point(m_a.X + x, m_a.Y + y)
        Next
        Using g As Graphics = Graphics.FromImage(m_image)
            g.DrawPolygon(Pen, Points)
        End Using

    End Sub
End Class
