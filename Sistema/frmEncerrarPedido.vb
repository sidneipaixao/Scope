Public Class frmEncerrarPedido

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

        oDados = oComando.ExecuteReader

        lstItens.Items.Clear()
        While oDados.Read

            'VERIFICA SE UM GRUPO JA EXISTE (CADA GRUPO REPRESENTA UM PRATO)
            With lstItens

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

        Return True

    End Function

    Private Sub fnDestacar(ByVal nDirecao As Integer)

        Static nPosicao As Integer
        Dim nTotal As Double = 0

        For Each oGrupo As ListViewGroup In lstItens.Groups
            For Each oItem As ListViewItem In oGrupo.Items
                oItem.BackColor = lstItens.BackColor
                nTotal += CDbl(oItem.SubItems(3).Text)
            Next
        Next

        If nDirecao = 0 Then
            nPosicao = 0
        Else

            nTotal = 0

            If nDirecao > 0 AndAlso nPosicao >= lstItens.Groups.Count - 1 Then
                nPosicao = 0
            ElseIf nDirecao < 0 AndAlso nPosicao < 1 Then
                nPosicao = lstItens.Groups.Count - 1
            Else
                nPosicao += nDirecao
            End If

            For Each oItem As ListViewItem In lstItens.Groups(nPosicao).Items
                oItem.BackColor = Color.SkyBlue
                nTotal += CDbl(oItem.SubItems(3).Text)
            Next

        End If

        txtVlrPrato.Text = FormatNumber(nTotal)

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

    Private Sub frmPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'NAO PODE MAXIMIZAR, SENAO COBRE BARRA DE TAREFAS DO WINDOWS, POR ISSO NAO USA WINDOWSTATE
        Top = 0
        Left = 0
        Width = Screen.GetWorkingArea(Me).Width
        Height = Screen.GetWorkingArea(Me).Height

        'DESENHA BORDA DO FORMULARIO
        BackgroundImage = New Bitmap(Width - 1, Height - 1)
        Graphics.FromImage(BackgroundImage).DrawRectangle(New Pen(Color.FromArgb(55, 65, 80)), New Rectangle(New Point(0, 0), Size))

        Dim oDados As SqlClient.SqlDataReader = fnRetornaDados("SELECT * FROM MOEDAS WHERE MDSRELACAO = 0 AND MDSEXIBICAO <> 0")

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


        'VERIFICA SE CLIENTE POSSUI DIREITO A FIDELIDADE
        oDados = fnRetornaDados("SELECT 1 FIDELIDADE")

        If oDados.Read Then

            Dim oMoeda As New Button

            oMoeda.Text = "Fidelidade"
            oMoeda.Size = New Size(160, 50)
            oMoeda.BackColor = btn0.BackColor
            oMoeda.Font = New Font(btn0.Font, FontStyle.Bold)
            oMoeda.Tag = 99
            If oDados("FIDELIDADE") = 0 Then
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
        txtTotal.Text = FormatNumber(nVlrTotal)

        'Rotina responsável por ajustar a largura das colunas do listview de pratos e o tamanho das linhas
        lstItens.Columns(0).Width = (lstItens.Width * 15) / 100
        lstItens.Columns(1).Width = (lstItens.Width * 50) / 100
        lstItens.Columns(2).Width = (lstItens.Width * 15) / 100
        lstItens.Columns(3).Width = (lstItens.Width * 15) / 100

        'DADOS DO PEDIDO ATUAL
        'oDados = fnRetornaDados("SELECT 1 codigo, 'Baby Beef 120g' item, 1 qtde, 16.90 valor UNION " & _
        '                        "SELECT 21 codigo, 'Arroz Branco (Acomp.)' item, 1 qtde, 0.01 valor UNION " & _
        '                        "SELECT 22 codigo, 'Feijão Carioca (Acomp.).' item, 1 qtde, 0.01 valor UNION " & _
        '                        "SELECT 23 codigo, 'Batata Frita (Acomp.)' item, 1 qtde, 0.01 valor UNION " & _
        '                        "SELECT 195 codigo, 'Refrigerante Lata 350ml' item, 2 qtde, 11.80 valor")

        ''POPULA O LISTVIEW
        'While oDados.Read

        '    Dim oItem As ListViewItem

        '    oItem = lstItens.Items.Add(oDados("codigo"))
        '    oItem.SubItems.Add(oDados("codigo"))
        '    oItem.SubItems.Add(oDados("item"))
        '    oItem.SubItems.Add(oDados("qtde"))
        '    oItem.SubItems.Add(oDados("valor"))
        '    oItem.Name = oDados("qtde")
        '    oItem.Tag = oDados("codigo")
        '    oItem.Text = oDados("valor")
        '    oItem.ToolTipText = oDados("item")

        '    nVlrTotal += oDados("valor")

        'End While
        'oDados.Close()

    End Sub

    Private Sub fnEfetuarPgto(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

            oDados.Close()

            frmGrupoMoeda.lblMoedaPai.Text = sender.text.ToString.ToUpper

            frmGrupoMoeda.ShowDialog()

            If frmGrupoMoeda.Tag = True Then

                If txtVlrTroco.Text <> "0,00" And lblTroco.Text = "Saldo devedor" Then

                    'ROTINA QUE EXIIBE O RESUMO DO PAGAMENTO PARCIAL E REALIZA A GRAVAÇÃO DE PAGAMENTOS PARCIAIS

                    fnFormComanda("parcial", frmGrupoMoeda.cMoeda, sender.tag)
                    lPagamentoParcial = True

                Else

                    'ROTINA QUE EXIBE O RESUMO DO PAGAMENTO E GRAVA A VENDA E O PAGAMENTO NA BASE

                    fnFormComanda("total", frmGrupoMoeda.cMoeda, sender.tag)
                    lPagamentoParcial = False

                End If

            End If

        Else

            oDados.Close()

            If txtVlrTroco.Text <> "0,00" And lblTroco.Text = "Saldo devedor" Then

                'ROTINA QUE EXIIBE O RESUMO DO PAGAMENTO PARCIAL E REALIZA A GRAVAÇÃO DE PAGAMENTOS PARCIAIS

                fnFormComanda("parcial", sender.text, sender.tag)
                lPagamentoParcial = True

            Else

                'ROTINA QUE EXIBE O RESUMO DO PAGAMENTO E GRAVA A VENDA E O PAGAMENTO NA BASE

                fnFormComanda("total", sender.text, sender.tag)
                lPagamentoParcial = False

            End If

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

        For Each oItem As ListViewItem In lstItens.SelectedItems

            frmExcluirItem.lblMensagem.Text = "Você deseja realmente remover o item ou o prato abaixo do pedido atual? " & vbNewLine & "" & vbNewLine & _
                "ITEM SELECIONADO:" & vbNewLine & oItem.SubItems(1).Text
            frmExcluirItem.lblAux.Text = "ITENS DO PRATO SELECIONADO:" & vbNewLine

            'For Each oItens As ListViewItem In lstItens.Groups(lstItens.SelectedItems(0).Group.Name).Items
            For Each oItens As ListViewItem In lstItens.SelectedItems(0).Group.Items

                frmExcluirItem.lblAux.Text = frmExcluirItem.lblAux.Text & oItens.SubItems(1).Text & vbNewLine

            Next

        Next
        frmExcluirItem.ShowDialog()

        If frmExcluirItem.cFuncao = "excluir_prato" Then

            Dim oGrupo As ListViewGroup = lstItens.SelectedItems(0).Group
            For nCont As Integer = 0 To oGrupo.Items.Count - 1

                txtTotal.Text = FormatNumber(CDbl(txtTotal.Text) - CDbl(oGrupo.Items(0).SubItems(3).Text))
                oGrupo.Items(0).Remove()

            Next


        ElseIf frmExcluirItem.cFuncao = "excluir_item" Then

            For Each oItem As ListViewItem In lstItens.SelectedItems

                lstItens.Items.Remove(oItem)
                txtTotal.Text = FormatNumber(CDbl(txtTotal.Text) - CDbl(oItem.SubItems(3).Text))

            Next

        Else

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        txtVlrPago.Text = FormatNumber(CDbl(txtVlrTroco.Text) * -1)

    End Sub

    Private Sub btnAnterior_Click(sender As System.Object, e As System.EventArgs) Handles btnAnterior.Click

        fnDestacar(-1)

    End Sub

    Private Sub btnProximo_Click(sender As System.Object, e As System.EventArgs) Handles btnProximo.Click

        fnDestacar(1)

    End Sub
End Class