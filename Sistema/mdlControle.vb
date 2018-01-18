Module mdlControle

  Public Structure tCaixa
    Dim Situacao As Boolean
    Dim Horario As Date
    Dim Usuario As Integer
  End Structure

  Public rCaixa As tCaixa

  Public Function fnCaixaAberto() As Boolean

    Dim lAguardar As Boolean

    If Not rCaixa.Situacao Then
      If MessageBox.Show("A abertura de turno ainda não foi realizada." & vbNewLine & "Deseja efetuar a abertura agora?", "Turno não iniciado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        With frmAbrirTurno
          '.MdiParent = frmPrincipal
          .Show()
          lAguardar = True
          While lAguardar
            lAguardar = False
            For Each oFormulario In Application.OpenForms
              If TypeOf oFormulario Is frmAbrirTurno Then
                lAguardar = True
              End If
            Next
            Application.DoEvents()
          End While
        End With
      End If
    End If

    Return rCaixa.Situacao

  End Function

End Module
