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

    frmAbrirTurno.Show()

  End Sub

  Private Sub cmdPedidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPedidos.Click

    If fnCaixaAberto() Then
      frmPedidos.ShowDialog()
    End If

  End Sub

  Private Sub cmdFechar_Click(sender As System.Object, e As System.EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

    Private Sub cmdFuncoes_Click(sender As System.Object, e As System.EventArgs) Handles cmdFuncoes.Click

        frmMoeda.ShowDialog()

    End Sub
End Class
