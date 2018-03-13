Public Class Form1
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Int32) As Integer

    Private Sub start_Click(sender As Object, e As EventArgs) Handles start.Click
        Timer1.Start()
    End Sub

    Private Sub done_Click(sender As Object, e As EventArgs) Handles done.Click
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim bmp As New System.Drawing.Bitmap(1, 1)
        Dim gfx As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(bmp)
        gfx.CopyFromScreen(New Drawing.Point(MousePosition.X, MousePosition.Y), New Drawing.Point(0, 0), bmp.Size)

        Dim pixel As Drawing.Color = bmp.GetPixel(0, 0)

        Panel1.BackColor = pixel

        redtxt.Text = pixel.R
        greentxt.Text = pixel.G
        bluetxt.Text = pixel.B

        hexbox.Text = System.Drawing.ColorTranslator.ToHtml(pixel)

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If (GetAsyncKeyState(117)) Then
            Timer1.Start()
        End If

        If (GetAsyncKeyState(118)) Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ColorDialog1.ShowDialog()
        Dim dcolor = ColorDialog1.Color
        Panel1.BackColor = dcolor
        redtxt.Text = dcolor.R
        greentxt.Text = dcolor.G
        bluetxt.Text = dcolor.B

        hexbox.Text = System.Drawing.ColorTranslator.ToHtml(dcolor)


    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover

    End Sub
End Class
