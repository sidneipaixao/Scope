Public Class frmEncerrarPedido


    Public oItens As New ListView

    'VERIFICAR NECESSIDADE DESTAS VARIAVEIS
    Dim nVlrTotal As Double = 0
    Public nVlrPago As String = 0
    Dim lIncluir As Boolean = True
    Public nSaldo As Double
    Dim lPagamentoParcial As Boolean = False

    Public Function fnCarregaDados(ByVal nPedido As Integer) As Boolean

        Dim oComando As New SqlClient.SqlCommand("SELECT VDICODIGO, VDISEQUENCIA, VDIPRATO, VDIPRODUTO, PRDNOME, VDIQTDE, VDIVLRUNIT" & _
                                                 "  FROM VENDAS_ITENS" & _
                                                 "  LEFT OUTER JOIN PRODUTOS ON VDIPRODUTO = PRDCODIGO" & _
                                                 " WHERE VDICODIGO = " & nPedido, oConexao)
        Dim oDados As SqlClient.SqlDataReader
        Dim oItem As ListViewItem

        Try
            'FUNCAO MODIFICADA PARA INCLUIR OS ITENS NUM LISTVIEW EM MEMORIA
            oDados = oComando.ExecuteReader

            lstItens.Items.Clear()
            While oDados.Read

                'VERIFICA SE UM GRUPO JA EXISTE (CADA GRUPO REPRESENTA UM PRATO)
                With oItens

                    If .Groups("PRT" & oDados("VDIPRATO")) Is Nothing Then
                        .Groups.Add("PRT" & oDados("VDIPRATO"), "Prato " & oDados("VDIPRATO"))
                    End If

                    oItem = .Items.Add("SEQ" & oDados("VDISEQUENCIA") & oDados("VDIPRATO"), oDados("VDIPRODUTO"), 0)
                    oItem.Group = .Groups("PRT" & oDados("VDIPRATO"))
                    oItem.SubItems.Add(oDados("PRDNOME"))
                    oItem.SubItems.Add(oDados("VDIQTDE"))
                    oItem.SubItems.Add(oDados("VDIVLRUNIT"))
                    lstItens.Tag = oDados("VDICODIGO")

                    nVlrTotal += CDbl(oDados("VDIVLRUNIT"))

                End With

            End While

            oDados.Close()

            'CARREGA OS ITENS DO PRIMEIRO GRUPO NO LISTVIEW DA TELA; USAR O LISTVIEW EM MEMORIA PARA TODAS AS DEMAIS OPERACOES
            fnDestacar(0)

            'AGORA TENTA VERIFICAR SE O NOME NO PEDIDO E' UM EMAIL, SE FOR UTILIZA
            oComando.CommandText = "SELECT CASE WHEN VNDCLIENTEEMAIL = 'N' OR VNDCLIENTEEMAIL = 'NN'" & _
                                   "            THEN CASE WHEN VNDCLIENTENOME LIKE '%_@__%.%'" & _
                                   "                      THEN VNDCLIENTENOME" & _
                                   "                      ELSE ''" & _
                                   "                 END" & _
                                   "            ELSE VNDCLIENTEEMAIL" & _
                                   "       END EMAIL" & _
                                   "  FROM VENDAS" & _
                                   " WHERE VNDCODIGO = " & nPedido
            txtEmail.Text = oComando.ExecuteScalar & ""

            Return True

        Catch oErro As Exception

            MessageBox.Show(oErro.Message, "Erro ao carregar pedido " & nPedido, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False

        End Try


    End Function

    Private Sub fnDestacar(ByVal nDirecao As Integer)

        Static nPosicao As Integer
        Dim nTotal As Double = 0

        'ROTINA ANTIGA; NAO DESCARTAR AINDA, DEVIDO A ROTINA DE CALCULO DO VALOR TOTAL
        'For Each oGrupo As ListViewGroup In lstItens.Groups
        '    For Each oItem As ListViewItem In oGrupo.Items
        '        oItem.BackColor = lstItens.BackColor
        '        nTotal += CDbl(oItem.SubItems(3).Text)
        '    Next
        'Next
        '
        'If nDirecao = 0 Then
        '    nPosicao = 0
        'Else
        '
        '    nTotal = 0
        '
        '    If nDirecao > 0 AndAlso nPosicao >= lstItens.Groups.Count - 1 Then
        '        nPosicao = 0
        '    ElseIf nDirecao < 0 AndAlso nPosicao < 1 Then
        '        nPosicao = lstItens.Groups.Count - 1
        '    Else
        '        nPosicao += nDirecao
        '    End If
        '
        '    For Each oItem As ListViewItem In lstItens.Groups(nPosicao).Items
        '        oItem.BackColor = Color.SkyBlue
        '        nTotal += CDbl(oItem.SubItems(3).Text)
        '    Next
        '
        'End If
        '
        'txtVlrPrato.Text = FormatNumber(nTotal)

        Try
            If nDirecao > 0 AndAlso nPosicao >= oItens.Groups.Count - 1 Then
                nPosicao = 0
            ElseIf nDirecao < 0 AndAlso nPosicao < 1 Then
                nPosicao = oItens.Groups.Count - 1
            Else
                nPosicao += nDirecao
            End If

            'REMOVE OS ITENS (SE) QUE ESTIVEREM SENDO EXIBIDOS NO LISTVIEW, NA TELA
            lstItens.Items.Clear()

            'CARREGA OS ITENS DE UM PRATO ESPECIFICO
            For Each oItem As ListViewItem In oItens.Groups(nPosicao).Items
                With lstItens.Items.Add(oItem.Name, oItem.Text, 0)
                    .SubItems.Add(oItem.SubItems(1))
                    .SubItems.Add(oItem.SubItems(2))
                    .SubItems.Add(oItem.SubItems(3))
                End With
                nTotal += CDbl(oItem.SubItems(3).Text)
            Next

            'ATUALIZA O VALOR DO PRATO E A POSICAO NA TELA
            txtVlrPrato.Text = FormatNumber(nTotal, 2, TriState.True)
            lblQtde.Text = (nPosicao + 1) & "/" & oItens.Groups.Count

        Catch oErro As Exception
            MessageBox.Show(oErro.Message, "Erro ao trocar prato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub fnCalculaValores()

        If txtVlrPago.Text = "" Then

            txtVlrPago.Text = "0,00"

        End If

        If txtVlrTroco.Text = "" Then

            txtVlrTroco.Text = "0,00"

        End If

        If txtTotal.Text = "" Then

            txtTotal.Text = "0,00"

        End If

        Dim nVlrTotal As Double = CDbl(txtTotal.Text)
        Dim nVlrPago As Double = CDbl(txtVlrPago.Text)
        Dim nVlrSaldo As Double = CDbl(txtVlrTroco.Text)

        If lPagamentoParcial = False Then

            nVlrSaldo = nVlrPago - nVlrTotal

            If nVlrSaldo < 0 Then

                txtVlrTroco.ForeColor = Color.LightCoral
                lblTroco.ForeColor = Color.LightCoral
                lblTroco.Text = "Saldo devedor"

            Else

                txtVlrTroco.ForeColor = Color.LightSeaGreen
                lblTroco.ForeColor = Color.LightSeaGreen
                lblTroco.Text = "Troco"

            End If

            txtVlrTroco.Text = FormatNumber(nVlrSaldo)

        Else

            nVlrSaldo = nVlrPago - (nSaldo * (-1))

            If nVlrSaldo < 0 Then

                txtVlrTroco.ForeColor = Color.LightCoral
                lblTroco.ForeColor = Color.LightCoral
                lblTroco.Text = "Saldo devedor"

            Else

                txtVlrTroco.ForeColor = Color.LightSeaGreen
                lblTroco.ForeColor = Color.LightSeaGreen
                lblTroco.Text = "Troco"

            End If

            txtVlrTroco.Text = FormatNumber(nVlrSaldo)

        End If

    End Sub

    Public Sub fnFormComanda(cChamada As String, cMoeda As String, nMoeda As Integer)

        Select Case cChamada

            Case "parcial"

                frmComanda.lblResumo.Text = "Resumo da venda - Pagamento parcial"
                frmComanda.lblValorTotal.Text = Me.txtTotal.Text & " (pagamento atual: " & txtVlrPago.Text & ")"
                frmComanda.lblMoeda.Text = cMoeda.ToString.ToUpper
                frmComanda.lblEmail.Text = Me.txtEmail.Text
                frmComanda.txtSenha.Enabled = False
                frmComanda.btnOk.Text = "Novo pagamento"
                frmComanda.btnOk.Size = New Size(150, 50)
                frmComanda.btnOk.Location = New Point(317, 241)
                frmComanda.txtMoeda.Text = nMoeda
                frmComanda.Tag = cChamada
                frmComanda.ShowDialog()

            Case "total"

                frmComanda.lblResumo.Text = "Resumo da venda - Finalização"
                frmComanda.lblValorTotal.Text = Me.txtTotal.Text & " (troco: " & txtVlrTroco.Text & ")"
                frmComanda.lblMoeda.Text = cMoeda.ToString.ToUpper
                frmComanda.lblEmail.Text = Me.txtEmail.Text
                frmComanda.txtSenha.Enabled = True
                frmComanda.btnOk.Text = "Confirmar"
                frmComanda.btnOk.Size = New Size(105, 50)
                frmComanda.btnOk.Location = New Point(359, 241)
                frmComanda.txtMoeda.Text = nMoeda
                frmComanda.Tag = cChamada
                frmComanda.ShowDialog()

        End Select

    End Sub

    Private Sub frmEncerrarPedido_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

        If e.KeyCode = 27 Then
            Close()
        End If

        'RETIRAR - APENAS PARA FINALIDADE DE TESTES!!!!!!
        If e.Shift And e.KeyCode = Keys.F10 Then
            ComunicacaoSAT.Daruma.iImprimirTexto_DUAL_DarumaFramework(fnImprimeResumo, 0)
            MessageBox.Show("Impresso: RESUMO")
            ComunicacaoSAT.Daruma.iImprimirTexto_DUAL_DarumaFramework(fnImprimeComissao, 0)
            MessageBox.Show("Impresso: COMISSAO")
            ComunicacaoSAT.Daruma.iImprimirTexto_DUAL_DarumaFramework(fnImprimeFidelidade(0), 0)
            MessageBox.Show("Impresso: FIDELIDADE")
            ComunicacaoSAT.Daruma.iImprimirTexto_DUAL_DarumaFramework(fnImprimePedido(0, False), 0)
            MessageBox.Show("Impresso: PEDIDO COZINHA")
            ComunicacaoSAT.Daruma.iImprimirTexto_DUAL_DarumaFramework(fnImprimePedido(0, True), 0)
            MessageBox.Show("Impresso: PEDIDO COMPLETO")
        End If

    End Sub

    Private Sub frmPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'NAO PODE MAXIMIZAR, SENAO COBRE BARRA DE TAREFAS DO WINDOWS, POR ISSO NAO USA WINDOWSTATE
        Top = 0
        Left = 0
        Width = Screen.GetWorkingArea(Me).Width
        Height = Screen.GetWorkingArea(Me).Height

        'DESENHA BORDA DO FORMULARIO
        BackgroundImage = New Bitmap(Width - 1, Height - 1)
        Graphics.FromImage(BackgroundImage).DrawRectangle(New Pen(Color.FromArgb(55, 65, 80)), New Rectangle(New Point(0, 0), Size))

        'Rotina responsável por ajustar a largura das colunas do listview de pratos e o tamanho das linhas
        lstItens.Columns(0).Width = (lstItens.Width * 15) / 100
        lstItens.Columns(1).Width = (lstItens.Width * 50) / 100
        lstItens.Columns(2).Width = (lstItens.Width * 15) / 100
        lstItens.Columns(3).Width = (lstItens.Width * 15) / 100

        txtTotal.Text = FormatNumber(nVlrTotal, 2, TriState.True)


        'EXIBICAO DAS MOEDAS REALIZADA POR FUNCAO, PARA PERMITIR EXIBICAO DE MOEDAS DO GRUPO / SUBGRUPO CONFORME SELECAO
        fnExibeMoedas(0)

    End Sub

    Private Sub fnExibeMoedas(Optional ByVal nGrupo As Integer = 0)

        Dim oDados As SqlClient.SqlDataReader = fnRetornaDados("SELECT * FROM MOEDAS WHERE MDSRELACAO = 0" & nGrupo & " AND MDSEXIBICAO <> 0")

        'SE EXISTIREM MOEDAS SENDO EXIBIDAS, APAGA
        pnlMoedas.Controls.Clear()

        'EXIBE AS MOEDAS DO GRUPO SELECIONADO, OU MOEDAS PRINCIPAIS SE NGRUPO = 0
        While oDados.Read

            Dim oMoeda As New Button

            oMoeda.Text = oDados("MDSNOME")
            oMoeda.Tag = oDados("MDSCODIGO")
            oMoeda.Size = New Size(160, 50)
            oMoeda.BackColor = btn0.BackColor
            oMoeda.Font = New Font(btn0.Font, FontStyle.Bold)
            AddHandler oMoeda.Click, AddressOf fnEfetuarPgto

            pnlMoedas.Controls.Add(oMoeda)

        End While

        oDados.Close()


        'CASO ESTEJA NO NIVEL PRINCIPAL, VERIFICA SE CLIENTE POSSUI DIREITO A FIDELIDADE
        If nGrupo = 0 Then

            oDados = fnRetornaDados("SELECT ISNULL(MAX(CLIQTDFIDELIDADE), 0) FIDELIDADE" & _
                                    "  FROM CLIENTES" & _
                                    " WHERE CLIEMAIL IN (SELECT VNDCLIENTEEMAIL" & _
                                    "                      FROM VENDAS" & _
                                    "                     WHERE VNDCODIGO = " & lstItens.Tag & ")")

            If oDados.Read Then

                Dim oMoeda As New Button

                oMoeda.Text = "Fidelidade"
                oMoeda.Size = New Size(160, 50)
                oMoeda.BackColor = btn0.BackColor
                oMoeda.Font = New Font(btn0.Font, FontStyle.Bold)
                oMoeda.Tag = 99
                If oDados("FIDELIDADE") < 14 Then
                    oMoeda.Enabled = False
                Else
                    oMoeda.ForeColor = Color.White
                    oMoeda.BackColor = Color.LightSeaGreen
                    oMoeda.FlatStyle = FlatStyle.Flat
                End If

                AddHandler oMoeda.Click, AddressOf fnEfetuarPgto

                pnlMoedas.Controls.Add(oMoeda)

            End If

            oDados.Close()

        Else

            'CASO CONTRARIO, EXIBE BOTAO PARA VOLTAR PARA O GRUPO PRINCIPAL
            Dim oMoeda As New Button

            oMoeda.Text = "< RETORNAR"
            oMoeda.Size = New Size(160, 50)
            oMoeda.BackColor = btn0.BackColor
            oMoeda.Font = New Font(btn0.Font, FontStyle.Bold)
            oMoeda.Tag = -1
            oMoeda.ForeColor = Color.White
            oMoeda.BackColor = Color.LightSeaGreen
            oMoeda.FlatStyle = FlatStyle.Flat

            AddHandler oMoeda.Click, AddressOf fnEfetuarPgto
            pnlMoedas.Controls.Add(oMoeda)

        End If

    End Sub

    Private Sub fnEfetuarPgto(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim nQtdeMoedasGrupo As Integer = 0

        'BOTAO RETORNAR, APENAS RECARREGA AS MOEDAS DO GRUPO PRINCIPAL
        If sender.Tag = -1 Then
            fnExibeMoedas(0)
            Exit Sub
        End If

        If CDbl(txtVlrPago.Text) <> 0.0 Or CDbl(txtVlrPago.Text) <> 0 Then

            oComando.CommandText = "SELECT COUNT(0) QTDE FROM MOEDAS WHERE MDSEXIBICAO <> 0 AND MDSRELACAO = 0" & sender.Tag
            nQtdeMoedasGrupo = oComando.ExecuteScalar

            If nQtdeMoedasGrupo > 0 Then
                fnExibeMoedas(sender.Tag)
                Exit Sub
            End If

            If txtVlrTroco.Text <> "0,00" And lblTroco.Text = "Saldo devedor" Then

                'ROTINA QUE EXIIBE O RESUMO DO PAGAMENTO PARCIAL E REALIZA A GRAVAÇÃO DE PAGAMENTOS PARCIAIS
                fnFormComanda("parcial", sender.Text, sender.tag)
                lPagamentoParcial = True

            Else

                'ROTINA QUE EXIBE O RESUMO DO PAGAMENTO E GRAVA A VENDA E O PAGAMENTO NA BASE
                fnFormComanda("total", sender.Text, sender.tag)
                lPagamentoParcial = False

            End If

        Else

            MessageBox.Show("Por favor informar um valor para o campo Valor Pago. Não é possível realizar um pagamento sem informar este valor!" _
                                   , "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVlrPago.Focus()

        End If

    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click

        nVlrPago = nVlrPago & CDbl(sender.text)
        txtVlrPago.Text = FormatNumber(nVlrPago)

    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click

        nVlrPago = nVlrPago & CDbl(sender.text)
        txtVlrPago.Text = FormatNumber(nVlrPago)

    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click

        nVlrPago = nVlrPago & CDbl(sender.text)
        txtVlrPago.Text = FormatNumber(nVlrPago)

    End Sub

    Private Sub btnDec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDec.Click

        nVlrPago = nVlrPago & sender.text
        txtVlrPago.Text = nVlrPago

    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click

        nVlrPago = nVlrPago & CDbl(sender.text)
        txtVlrPago.Text = FormatNumber(nVlrPago)

    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click

        nVlrPago = nVlrPago & CDbl(sender.text)
        txtVlrPago.Text = FormatNumber(nVlrPago)

    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click

        nVlrPago = nVlrPago & CDbl(sender.text)
        txtVlrPago.Text = FormatNumber(nVlrPago)

    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click

        nVlrPago = nVlrPago & CDbl(sender.text)
        txtVlrPago.Text = FormatNumber(nVlrPago)

    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click

        nVlrPago = nVlrPago & CDbl(sender.text)
        txtVlrPago.Text = FormatNumber(nVlrPago)

    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click

        nVlrPago = nVlrPago & CDbl(sender.text)
        txtVlrPago.Text = FormatNumber(nVlrPago)

    End Sub

    Private Sub btnApaga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApaga.Click

        txtVlrPago.Text = "0,00"
        nVlrPago = 0

    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click

        nVlrPago = nVlrPago & CDbl(sender.text)
        txtVlrPago.Text = FormatNumber(nVlrPago)

    End Sub

    Private Sub txtVlrPago_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVlrPago.TextChanged

        If Not Application.OpenForms.OfType(Of frmComanda)().Count() > 0 Then

            fnCalculaValores()

        End If

        'If txtTotal.Text <> "" Then

        '    If CDbl(txtVlrPago.Text) > CDbl(txtTotal.Text) Then

        '        txtVlrTroco.Text = String.Format("{0:N2}", txtVlrPago.Text - txtTotal.Text)
        '        lblTroco.Text = "Valor troco"

        '    Else

        '        txtVlrTroco.Text = String.Format("{0:N2}", txtVlrPago.Text - txtTotal.Text)
        '        lblTroco.Text = "Saldo devedor"

        '    End If

        'End If

    End Sub

    Private Sub btnA10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA10.Click

        txtVlrPago.Text = "10,00"

    End Sub

    Private Sub btnA20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA20.Click

        txtVlrPago.Text = "20,00"

    End Sub

    Private Sub btnA30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA30.Click

        txtVlrPago.Text = "30,00"

    End Sub

    Private Sub btnA50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA50.Click

        txtVlrPago.Text = "50,00"

    End Sub

    Private Sub btnA60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA60.Click

        txtVlrPago.Text = "100,00"

    End Sub

    Private Sub txtTotal_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotal.Enter

        MessageBox.Show("Não é possível editar este campo.", "Ops, opção não editavel!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        grdItemPedido.Focus()

    End Sub

    Private Sub txtTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotal.TextChanged

        fnCalculaValores()

        'If txtTotal.Text <> "" Then

        '    If CDbl(txtVlrPago.Text) > CDbl(txtTotal.Text) Then

        '        txtVlrTroco.Text = txtVlrPago.Text - txtTotal.Text

        '    Else

        '        txtVlrTroco.Text = "0,00"

        '    End If

        'End If

    End Sub

    Private Sub btnIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncluir.Click


        If lIncluir Then
            frmIncluirItem.ShowDialog()
        End If

        lIncluir = True

    End Sub

    Private Sub btnEncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncerrar.Click

        frmComanda.ShowDialog()

    End Sub

    Private Sub grdItemPedido_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdItemPedido.MouseClick

        If lIncluir Then
            frmIncluirItem.ShowDialog()
        End If

        lIncluir = True

    End Sub

    Private Sub cmdFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFechar.Click

        Close()

    End Sub

    Private Sub txtVlrTroco_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVlrTroco.Enter

        MessageBox.Show("Não é possível editar este campo.", "Ops, opção não editavel!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        grdItemPedido.Focus()

    End Sub

    Private Sub lstItens_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstItens.Click

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

            frmExcluirItem.lblMensagem.Text = "Você deseja realmente remover o item ou o prato selecionado do pedido atual? " & vbNewLine & oItem.Selected

        Next
        frmExcluirItem.ShowDialog()

        If frmExcluirItem.cFuncao = "confirmar" Then

            For Each oItem As ListViewItem In lstItens.SelectedItems

                lstItens.Items.Remove(oItem)
                txtTotal.Text = CDbl(txtTotal.Text) - CDbl(oItem.Text)

            Next

        End If

    End Sub

    Private Sub cmdLevarTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLevarTotal.Click

        txtVlrPago.Text = FormatNumber(CDbl(txtVlrTroco.Text) * -1)

    End Sub

    Private Sub btnAnterior_Click(sender As System.Object, e As System.EventArgs) Handles btnAnterior.Click

        fnDestacar(-1)

    End Sub

    Private Sub btnProximo_Click(sender As System.Object, e As System.EventArgs) Handles btnProximo.Click

        fnDestacar(1)

    End Sub

    Private Sub cmdAlteraEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAlteraEmail.Click

        Dim cSQL As String

        Try

            cSQL = "UPDATE VENDAS SET VNDCLIENTEEMAIL ='" & txtEmail.Text & "' WHERE VNDCODIGO =" & lstItens.Tag

            oComando.CommandText = cSQL
            oComando.ExecuteNonQuery()

            MessageBox.Show("O e-mail do cliente foi alterado com sucesso para:" & vbNewLine & _
                                 txtEmail.Text, "E-mail alterado!" _
                                , MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            MessageBox.Show("Erro ao alterar o e-mail! Tente novamente e se o problema persistir entre em contato com o administrador do sistema." _
                                   & vbNewLine & Err.Number & " - " & Err.Description, "Erro ao alterar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try

    End Sub

    Private Sub pnlItens_DoubleClick(sender As Object, e As System.EventArgs) Handles pnlItens.DoubleClick

        frmDesconto.Show()

    End Sub
End Class