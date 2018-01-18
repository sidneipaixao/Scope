Public Class frmGrupoMoeda

    Public cMoeda As String

    Public Function fnEfetuarPgtoGrupo(sender As System.Object, e As System.EventArgs)

        Tag = True
        cMoeda = sender.text.ToString.ToUpper
        Close()

    End Function

    Private Sub frmGrupoMoeda_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'DESENHA BORDA DO FORMULARIO
        BackgroundImage = New Bitmap(Width - 1, Height - 1)
        Graphics.FromImage(BackgroundImage).DrawRectangle(New Pen(Color.FromArgb(55, 65, 80)), New Rectangle(New Point(0, 0), Size))

    End Sub

    Private Sub cmdFechar_Click(sender As System.Object, e As System.EventArgs) Handles cmdFechar.Click

        Close()
        Tag = False

    End Sub
End Class