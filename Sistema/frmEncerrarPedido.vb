Public Class frmEncerrarPedido

  Dim nVlrTotal As Double = 0
    Dim nVlrPago As String = 0
  Dim lIncluir As Boolean = True


  Private Sub frmPedido_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'NAO PODE MAXIMIZAR, SENAO COBRE BARRA DE TAREFAS DO WINDOWS, POR ISSO NAO USA WINDOWSTATE
        Top = 0
        Left = 0
        Width = Screen.GetWorkingArea(Me).Width
        Height = Screen.GetWorkingArea(Me).Height

        'DESENHA BORDA DO FORMULARIO
        BackgroundImage = New Bitmap(Width - 1, Height - 1)
        Graphics.FromImage(BackgroundImage).DrawRectangle(New Pen(Color.FromArgb(55, 65, 80)), New Rectangle(New Point(0, 0), Size))
    
        nVlrPago = ""

        Dim oDados As SqlClient.SqlDataReader = fnRetornaDados("SELECT * FROM MOEDAS WHERE MDSRELACAO = 0 AND MDSEXIBICAO <> 0")

        While oDados.Read

            Dim oMoeda As New Button

            oMoeda.Text = oDados("MDSNOME")
            oMoeda.Tag = oDados("MDSCODIGO")
            oMoeda.Size = New Size(150, 40)
            oMoeda.BackColor = btnIncluir.BackColor
            AddHandler oMoeda.Click, AddressOf fnEfetuarPgto

            pnlMoedas.Controls.Add(oMoeda)

        End While

        oDados.Close()


        'VERIFICA SE CLIENTE POSSUI DIREITO A FIDELIDADE
        oDados = fnRetornaDados("SELECT 0 FIDELIDADE")

        If oDados.Read Then

            Dim oMoeda As New Button

            oMoeda.Text = "FIDELIDADE"
            oMoeda.Size = New Size(150, 40)
            oMoeda.BackColor = btnIncluir.BackColor
            oMoeda.Tag = 99
            If oDados("FIDELIDADE") = 0 Then
                oMoeda.Enabled = False
            Else
                oMoeda.ForeColor = Color.Red
            End If

            AddHandler oMoeda.Click, AddressOf fnEfetuarPgto

            pnlMoedas.Controls.Add(oMoeda)

        End If

        oDados.Close()

        'DADOS DO PEDIDO ATUAL
        oDados = fnRetornaDados("SELECT 1 codigo, 'Baby Beef 120g' item, 1 qtde, 16.90 valor UNION " & _
                                "SELECT 21 codigo, 'Arroz Branco (Acomp.)' item, 1 qtde, 0.01 valor UNION " & _
                                "SELECT 22 codigo, 'Feijão Carioca (Acomp.).' item, 1 qtde, 0.01 valor UNION " & _
                                "SELECT 23 codigo, 'Batata Frita (Acomp.)' item, 1 qtde, 0.01 valor UNION " & _
                                "SELECT 195 codigo, 'Refrigerante Lata 350ml' item, 2 qtde, 11.80 valor")

        'POPULA O LISTVIEW
        While oDados.Read

            Dim oItem As ListViewItem

            oItem = lstItens.Items.Add(oDados("codigo"))
            oItem.SubItems.Add(oDados("codigo"))
            oItem.SubItems.Add(oDados("item"))
            oItem.SubItems.Add(oDados("qtde"))
            oItem.SubItems.Add(oDados("valor"))
            oItem.Name = oDados("qtde")
            oItem.Tag = oDados("codigo")
            oItem.Text = oDados("valor")
            oItem.ToolTipText = oDados("item")

            nVlrTotal += oDados("valor")

        End While

        txtTotal.Text = nVlrTotal
        oDados.Close()

        txtVlrTroco.Text = "0,00"

  End Sub

  Private Sub fnEfetuarPgto(sender As System.Object, e As System.EventArgs)

        Dim oDados As SqlClient.SqlDataReader = fnRetornaDados("SELECT * FROM MOEDAS WHERE MDSEXIBICAO <> 0 AND MDSRELACAO = " & sender.tag)

        If oDados.HasRows Then

            frmGrupoMoeda.pnlMoedas.Controls.Clear()

            While oDados.Read

                Dim oMoeda As New Button

                oMoeda.Text = oDados("MDSNOME")
                oMoeda.Tag = oDados("MDSCODIGO")
                oMoeda.Size = New Size(150, 40)
                oMoeda.BackColor = btnIncluir.BackColor
                AddHandler oMoeda.Click, AddressOf frmGrupoMoeda.fnEfetuarPgtoGrupo

                frmGrupoMoeda.pnlMoedas.Controls.Add(oMoeda)

            End While

            frmGrupoMoeda.lblMoedaPai.Text = sender.text.ToString.ToUpper

            frmGrupoMoeda.ShowDialog()

            If frmGrupoMoeda.Tag = True Then

                frmComanda.lblValorTotal.Text = Me.txtTotal.Text
                frmComanda.lblMoeda.Text = frmGrupoMoeda.cMoeda
                frmComanda.lblEmail.Text = Me.txtEmail.Text
                frmComanda.ShowDialog()

            End If

        Else

            frmComanda.lblValorTotal.Text = Me.txtTotal.Text
            frmComanda.lblMoeda.Text = sender.text.ToString.ToUpper
            frmComanda.lblEmail.Text = Me.txtEmail.Text
            frmComanda.ShowDialog()

        End If

        oDados.Close()

    End Sub

    Private Sub btn9_Click(sender As System.Object, e As System.EventArgs) Handles btn9.Click

        nVlrPago = nVlrPago & sender.text
        txtVlrPago.Text = nVlrPago

    End Sub

    Private Sub btn8_Click(sender As System.Object, e As System.EventArgs) Handles btn8.Click

        nVlrPago = nVlrPago & sender.text
        txtVlrPago.Text = nVlrPago

    End Sub

    Private Sub btn3_Click(sender As System.Object, e As System.EventArgs) Handles btn3.Click

        nVlrPago = nVlrPago & sender.text
        txtVlrPago.Text = nVlrPago

    End Sub

    Private Sub btnDec_Click(sender As System.Object, e As System.EventArgs) Handles btnDec.Click

        nVlrPago = nVlrPago & sender.text
        txtVlrPago.Text = nVlrPago

    End Sub

    Private Sub btn2_Click(sender As System.Object, e As System.EventArgs) Handles btn2.Click

        nVlrPago = nVlrPago & sender.text
        txtVlrPago.Text = nVlrPago

    End Sub

    Private Sub btn1_Click(sender As System.Object, e As System.EventArgs) Handles btn1.Click

        nVlrPago = nVlrPago & sender.text
        txtVlrPago.Text = nVlrPago

    End Sub

    Private Sub btn6_Click(sender As System.Object, e As System.EventArgs) Handles btn6.Click

        nVlrPago = nVlrPago & sender.text
        txtVlrPago.Text = nVlrPago

    End Sub

    Private Sub btn5_Click(sender As System.Object, e As System.EventArgs) Handles btn5.Click

        nVlrPago = nVlrPago & sender.text
        txtVlrPago.Text = nVlrPago

    End Sub

    Private Sub btn4_Click(sender As System.Object, e As System.EventArgs) Handles btn4.Click

        nVlrPago = nVlrPago & sender.text
        txtVlrPago.Text = nVlrPago

    End Sub

    Private Sub btn7_Click(sender As System.Object, e As System.EventArgs) Handles btn7.Click

        nVlrPago = nVlrPago & sender.text
        txtVlrPago.Text = nVlrPago

    End Sub

    Private Sub btnApaga_Click(sender As System.Object, e As System.EventArgs) Handles btnApaga.Click

        txtVlrPago.Text = "0,00"
        nVlrPago = ""

    End Sub

    Private Sub btn0_Click(sender As System.Object, e As System.EventArgs) Handles btn0.Click

        nVlrPago = nVlrPago & sender.text
        txtVlrPago.Text = nVlrPago

    End Sub

    Private Sub txtVlrPago_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtVlrPago.TextChanged

        If txtTotal.Text <> "" Then

            If CDbl(txtVlrPago.Text) > CDbl(txtTotal.Text) Then

                txtVlrTroco.Text = String.Format("{0:N2}", txtVlrPago.Text - txtTotal.Text)

            Else

                txtVlrTroco.Text = "0,00"

            End If

        End If

    End Sub

    Private Sub btnA10_Click(sender As System.Object, e As System.EventArgs) Handles btnA10.Click

        txtVlrPago.Text = "10,00"

    End Sub

    Private Sub btnA20_Click(sender As System.Object, e As System.EventArgs) Handles btnA20.Click

        txtVlrPago.Text = "20,00"

    End Sub

    Private Sub btnA30_Click(sender As System.Object, e As System.EventArgs) Handles btnA30.Click

        txtVlrPago.Text = "30,00"

    End Sub

    Private Sub btnA40_Click(sender As System.Object, e As System.EventArgs) Handles btnA40.Click

        txtVlrPago.Text = "40,00"

    End Sub

    Private Sub btnA50_Click(sender As System.Object, e As System.EventArgs) Handles btnA50.Click

        txtVlrPago.Text = "50,00"

    End Sub

    Private Sub btnA60_Click(sender As System.Object, e As System.EventArgs) Handles btnA60.Click

        txtVlrPago.Text = "100,00"

    End Sub

    Private Sub txtTotal_Enter(sender As Object, e As System.EventArgs) Handles txtTotal.Enter

        MessageBox.Show("Não é possível editar este campo.", "Ops, opção não editavel!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        grdItemPedido.Focus()

    End Sub

    Private Sub txtTotal_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTotal.TextChanged

        If txtTotal.Text <> "" Then

            If CDbl(txtVlrPago.Text) > CDbl(txtTotal.Text) Then

                txtVlrTroco.Text = txtVlrPago.Text - txtTotal.Text

            Else

                txtVlrTroco.Text = "0,00"

            End If

        End If

    End Sub

    Private Sub btnIncluir_Click(sender As System.Object, e As System.EventArgs) Handles btnIncluir.Click


        If lIncluir Then
            frmIncluirItem.ShowDialog()
        End If

        lIncluir = True

    End Sub

    Private Sub btnEncerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnEncerrar.Click

        frmComanda.ShowDialog()

    End Sub

  Private Sub grdItemPedido_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles grdItemPedido.MouseClick

    If lIncluir Then
      frmIncluirItem.ShowDialog()
    End If

    lIncluir = True

  End Sub

    Private Sub cmdFechar_Click(sender As System.Object, e As System.EventArgs) Handles cmdFechar.Click

        Close()

    End Sub

    Private Sub txtVlrTroco_Enter(sender As Object, e As System.EventArgs) Handles txtVlrTroco.Enter

        MessageBox.Show("Não é possível editar este campo.", "Ops, opção não editavel!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        grdItemPedido.Focus()

    End Sub

    Private Sub lstItens_Click(sender As Object, e As System.EventArgs) Handles lstItens.Click

        'Aqui nós configuramos o fomr abaixo para confirmar a exclusão do produto
        frmExcluirItem.lblTitulo.Text = "Confirmar exclusão"
        frmExcluirItem.lblCxTexto.Text = "Senha"
        frmExcluirItem.lblUsuario.Text = "Usuário"
        frmExcluirItem.txtSenha.PasswordChar = "*"
        frmExcluirItem.txtSenha.Text = ""
        frmExcluirItem.txtAux.Visible = False
        frmExcluirItem.lblUsuario.Visible = True
        frmExcluirItem.cbxUsuario.Visible = True
        frmExcluirItem.cFuncao = "excluir.item"

        For Each oItem As ListViewItem In lstItens.SelectedItems

            frmExcluirItem.lblMensagem.Text = "Você deseja realmente remover o item abaixo do pedido atual? " & vbNewLine & oItem.ToolTipText

        Next
        frmExcluirItem.ShowDialog()

        If frmExcluirItem.cFuncao = "confirmar" Then

            For Each oItem As ListViewItem In lstItens.SelectedItems

                lstItens.Items.Remove(oItem)
                txtTotal.Text = CDbl(txtTotal.Text) - CDbl(oItem.Text)

            Next

        End If

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        txtVlrPago.Text = txtTotal.Text

    End Sub
End Class