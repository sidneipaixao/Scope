Public Class frmExemplo

  Private Sub frmExemplo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    BackgroundImage = New Bitmap(Width - 1, Height - 1)
    Graphics.FromImage(BackgroundImage).DrawRectangle(New Pen(Color.FromArgb(55, 65, 80)), New Rectangle(New Point(0, 0), Size))

  End Sub

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    'CreateGraphics().DrawRectangle(New Pen(Color.FromArgb(55, 65, 80)), New Rectangle(Location, Size))
    'BackgroundImage = Bitmap.FromHbitmap(CreateGraphics().DrawRectangle(Pens.AliceBlue, New Rectangle(0, 0, 0, 0)))
  End Sub
End Class