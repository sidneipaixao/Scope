Public Class frmPrincipal

  Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    'SOMENTE E' POSSIVEL ALTERAR A COR DO ELEMENTO MDICLIENT EM TEMPO DE EXECUCAO
    For Each oTela In Controls
      If TypeOf oTela Is MdiClient Then
        oTela.BackColor = Color.White
      End If
    Next

    'NAO PODE MAXIMIZAR, SENAO COBRE BARRA DE TAREFAS DO WINDOWS, POR ISSO NAO USA WINDOWSTATE
    Top = 0
    Left = 0
    Width = Screen.GetWorkingArea(Me).Width
        Height = Screen.GetWorkingArea(Me).Height

    End Sub

  Private Sub cmdAbrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAbrir.Click

        If rCaixa.Situacao Then

            If MessageBox.Show("Já existe um turno aberto!" & vbNewLine & "Deseja encerrar este turno agora?", "Turno aberto!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then

                frmAbrirTurno.ShowDialog()

            End If

        Else

            frmAbrirTurno.ShowDialog()

        End If

    End Sub

  Private Sub cmdPedidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPedidos.Click

    If fnCaixaAberto() Then
      frmPedidos.ShowDialog()
    End If

  End Sub

  Private Sub cmdFechar_Click(sender As System.Object, e As System.EventArgs) Handles cmdFechar.Click
        'fnEnviarEmail("Fechando a aplicação", "A aplicação foi fechada pelo botão de fechar")
        Close()
  End Sub

    Private Sub cmdFuncoes_Click(sender As System.Object, e As System.EventArgs) Handles cmdFuncoes.Click
        frmMoeda.ShowDialog()
    End Sub

    Private Sub cmdEncerrar_Click(sender As System.Object, e As System.EventArgs) Handles cmdEncerrar.Click

        If Not rCaixa.Situacao Then

            If MessageBox.Show("Não existe um turno aberto neste momento para ser fechado." & vbNewLine & "Deseja realizar a abertura de um turno agora?", "Turno fechado!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then

                frmAbrirTurno.ShowDialog()

            End If

        Else

            frmAbrirTurno.ShowDialog()

        End If

    End Sub

    Private Sub frmPrincipal_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated

        If rCaixa.Situacao Then
            objMensagens.Text = "Caixa Aberto | Sistema Pronto"
        Else
            objMensagens.Text = "Caixa Fechado | Sistema Pronto"
        End If

    End Sub

End Class
