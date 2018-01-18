Public Class frmAbrirTurno

  Private Sub frmAbrirTurno_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    'ESCONDE BARRA DE PROGRESSO AO FECHAR FORMULARIO
    frmPrincipal.objProgresso.Visible = False

  End Sub

  Private Sub frmExemplo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    'DESENHA BORDA DO FORMULARIO
    BackgroundImage = New Bitmap(Width - 1, Height - 1)
    Graphics.FromImage(BackgroundImage).DrawRectangle(New Pen(Color.FromArgb(55, 65, 80)), New Rectangle(New Point(0, 0), Size))

    'EXIBE BARRA DE PROGRESSO TEMPORARIAMENTE
    frmPrincipal.objProgresso.Visible = True

  End Sub

  Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
    Close()
  End Sub

  Private Sub cmdEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEntrar.Click

    Dim oDados As SqlClient.SqlDataReader = fnRetornaDados("SELECT 1 USRCODIGO, 'Administrador' USRNOME WHERE 'ADMIN' = '" & txtUsuario.Text & "' AND '12345' = '" & txtSenha.Text & "'")

    'VALIDA USUARIO E SENHA INFORMADOS
    If oDados.Read Then
      rCaixa.Situacao = True
      oDados.Close()
      Close()
    Else
      oDados.Close()
      MessageBox.Show("Usuário ou senha inválidos, tente novamente.", "Credencial inválida", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If

  End Sub

End Class