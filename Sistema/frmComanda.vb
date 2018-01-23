Public Class frmComanda

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click

        Close()

    End Sub

    Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click

        If Me.Tag = "total" Then

            'REALIZA INSERT

            Close()
            frmEncerrarPedido.Close()

        Else

            'REALIZA INSERT

            Close()

        End If

    End Sub

    Private Sub frmComanda_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        BackgroundImage = New Bitmap(Width - 1, Height - 1)
        Graphics.FromImage(BackgroundImage).DrawRectangle(New Pen(Color.FromArgb(55, 65, 80)), New Rectangle(New Point(0, 0), Size))

        Panel1.Focus()

    End Sub

    Private Sub cmdFechar_Click(sender As System.Object, e As System.EventArgs) Handles cmdFechar.Click

        Close()

    End Sub
End Class