Public Class SpinerCircle
    Inherits Control
    Private increment As Integer = 1
    Private radius As Integer = 4
    Private n As Integer = 6
    Private nxt As Integer = 0
    Private timer As Timer

    Public Sub New()
        timer = New Timer()
        Me.Size = New Size(100, 100)
        AddHandler timer.Tick, Sub(s, e) Invalidate()
        If Not DesignMode Then timer.Enabled = True
        SetStyle(ControlStyles.AllPaintingInWmPaint Or
              ControlStyles.OptimizedDoubleBuffer Or
              ControlStyles.ResizeRedraw Or
              ControlStyles.UserPaint Or
              ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.Transparent
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)

        If Parent IsNot Nothing AndAlso Me.BackColor = Color.Transparent Then
            Using bmp = New Bitmap(Parent.Width, Parent.Height)
                Parent.Controls.Cast(Of Control)().
                Where(Function(c) Parent.Controls.GetChildIndex(c) > Parent.Controls.GetChildIndex(Me)).
                Where(Function(c) c.Bounds.IntersectsWith(Me.Bounds)).
                OrderByDescending(Function(c) Parent.Controls.GetChildIndex(c)).ToList().
                ForEach(Sub(c) c.DrawToBitmap(bmp, c.Bounds))

                e.Graphics.DrawImage(bmp, -Left, -Top)
            End Using
        End If

        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality

        Dim length As Integer = Math.Min(Width, Height)
        Dim center As PointF = New PointF(length / 2, length / 2)
        Dim bigradius As Integer = CInt(length / 2 - radius - (n - 1) * increment)
        Dim unitagle As Single = CSng(360 / n)
        If Not DesignMode Then nxt += 1
        Dim a As Integer
        For i As Integer = nxt To nxt + n - 1
            Dim factor As Integer = i Mod n
            Dim c1x As Single = center.X + CSng(bigradius * Math.Cos(unitagle * factor * Math.PI / 180))
            Dim c1y As Single = center.X + CSng(bigradius * Math.Sin(unitagle * factor * Math.PI / 180))
            Dim curr_rad As Integer = radius + a * increment
            Dim c1 As PointF = New PointF(c1x - curr_rad, c1y - curr_rad)
            e.Graphics.FillEllipse(Brushes.Yellow, c1.X, c1.Y, 2 * curr_rad, 2 * curr_rad)
            Using p As Pen = New Pen(Brushes.White, 2)
                e.Graphics.DrawEllipse(p, c1.X, c1.Y, 2 * curr_rad, 2 * curr_rad)
            End Using
            a += 1
        Next
        MyBase.OnPaint(e)
    End Sub

    Protected Overrides Sub OnVisibleChanged(e As EventArgs)
        MyBase.OnVisibleChanged(e)
        timer.Enabled = Visible

    End Sub


End Class
