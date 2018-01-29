Public Class frmComanda

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click

        Close()

    End Sub

    Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click

        Dim cSQL As String

        If Me.Tag = "total" Then

            If txtSenha.Text <> "" Then

                'REALIZA INSERT
                'FUNÇÃO PARA GRAVAR PAGAMENTO PARCIAIS
                Try

                    cSQL = "INSERT INTO VENDAS_PAGAMENTOS(PGTVENDA, PGTSEQUENCIA, PGTMETODO, PGTSALDO, PGTVALOR, PGTDATA)" & _
                            " SELECT " & frmEncerrarPedido.lstItens.Tag & ", ISNULL(MAX(PGTSEQUENCIA) + 1, 0)," & txtMoeda.Text & ", " & frmEncerrarPedido.txtVlrTroco.Text.Replace(",", ".") & ", " & frmEncerrarPedido.txtVlrPago.Text.Replace(",", ".") & ", CONVERT(DATETIME, GETDATE(),103) FROM VENDAS_PAGAMENTOS WHERE PGTVENDA = " & frmEncerrarPedido.lstItens.Tag & _
                            "   UPDATE VENDAS SET VNDCOMANDA = " & txtSenha.Text & " WHERE VNDCODIGO = " & frmEncerrarPedido.lstItens.Tag

                    oComando.CommandText = cSQL
                    oComando.ExecuteNonQuery()
                    frmPedidos.Refresh()

                Catch

                    MessageBox.Show("Erro ao gravar a venda! Tente novamente e se o problema persistir entre em contato com o administrador do sistema." _
                                   & vbNewLine & Err.Number & " - " & Err.Description, "Erro ao gravar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End Try

                Close()

                'INICIA PROCESSO DE ENVIO DE DADOS PARA O SAT
                If Not fnImprimeCupom() Then
                    If MessageBox.Show("Ocorreu um erro na rotina de impressão do cupom fiscal. Deseja encerrar o pedido mesmo assim?", "Impressão cupom fiscal", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                        frmEncerrarPedido.Close()
                    End If
                Else
                    frmEncerrarPedido.Close()
                End If

            Else

                MessageBox.Show("O campo Comanda/Mesa não pode ser vazio.", "Ops! Campo vazio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtSenha.Focus()

            End If

        Else

            'FUNÇÃO PARA GRAVAR PAGAMENTO PARCIAIS
            Try

                cSQL = "INSERT INTO VENDAS_PAGAMENTOS(PGTVENDA, PGTSEQUENCIA, PGTMETODO, PGTSALDO, PGTVALOR, PGTDATA)" & _
                        " SELECT " & frmEncerrarPedido.lstItens.Tag & ", ISNULL(MAX(PGTSEQUENCIA) + 1, 0)," & txtMoeda.Text & ", " & frmEncerrarPedido.txtVlrTroco.Text.Replace(",", ".") & ", " & frmEncerrarPedido.txtVlrPago.Text.Replace(",", ".") & ", CONVERT(DATETIME, GETDATE(),103) FROM VENDAS_PAGAMENTOS WHERE PGTVENDA = " & frmEncerrarPedido.lstItens.Tag

                oComando.CommandText = cSQL
                oComando.ExecuteNonQuery()

            Catch

                MessageBox.Show("Erro ao gravar a venda! Tente novamente e se o problema persistir entre em contato com o administrador do sistema." _
                               & vbNewLine & Err.Number & " - " & Err.Description, "Erro ao gravar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End Try


            frmEncerrarPedido.nSaldo = frmEncerrarPedido.txtVlrTroco.Text
            frmEncerrarPedido.txtVlrPago.Text = "0,00"
            frmEncerrarPedido.nVlrPago = 0
            Close()

        End If

    End Sub

    Private Sub frmComanda_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        BackgroundImage = New Bitmap(Width - 1, Height - 1)
        Graphics.FromImage(BackgroundImage).DrawRectangle(New Pen(Color.FromArgb(55, 65, 80)), New Rectangle(New Point(0, 0), Size))
        txtSenha.Text = ""
        'Panel1.Focus()

    End Sub

    Private Sub cmdFechar_Click(sender As System.Object, e As System.EventArgs) Handles cmdFechar.Click
        Close()
    End Sub

    Private Function fnImprimeCupom() As Boolean

        Dim cVersao As New System.Text.StringBuilder(10)
        Dim nResult As Integer = 0

        Try

            'VERIFICA SE AS DLLs ESTAO ACESSIVEIS
            ComunicacaoSAT.Daruma.eVerificarVersaoDLL_Daruma(cVersao)
            'EFETUA A ABERTURA DO CUPOM FISCAL ELETRONICO
            '   DADOS: CPF, NOME , ENDERECO (CLIENTE)
            nResult = ComunicacaoSAT.Daruma.aCFAbrir_SAT_Daruma("11111111111", "SIDNEI", "(endereço não informado)")
            nResult = ComunicacaoSAT.Daruma.iCFAbrirPadrao_ECF_Daruma()
            If nResult <> 1 Then Error 2

            'EFETUA O ENVIO DOS ITENS PARA O CFE
            '   DADOS: ALIQ ICMS, QTDE, PRECO UNITARIO, TIPO DESC/ACRESC, VLR/PERC DESC/ACRESC, CODIGO, UNID MEDIDA, NOME (PRODUTO)
            For Each oGrupo As ListViewGroup In frmEncerrarPedido.lstItens.Groups
                For Each oItem As ListViewItem In oGrupo.Items
                    nResult = ComunicacaoSAT.Daruma.aCFVender_SAT_Daruma("12,00", "1", oItem.SubItems(3).Text, "D$", 0, oItem.Text, "UND", oItem.SubItems(1).Text)
                    If nResult <> 1 Then Error 2
                Next
            Next


            'INICIA ROTINA DE TOTALIZACAO DO CFE
            '   DADOS: TIPO DESC/ACRESC, VLR/PERC DESC/ACRESC (CUPOM)
            nResult = ComunicacaoSAT.Daruma.aCFTotalizar_SAT_Daruma("D$", "0,00")
            If nResult <> 1 Then Error 2

            'EFETIVAR PAGAMENTO
            '   DADOS: FORMA PGTO, VLR PAGO, COD OPERADORA CARTAO
            nResult = ComunicacaoSAT.Daruma.aCFEfetuarPagamento_SAT_Daruma("Dinheiro", frmEncerrarPedido.txtTotal.Text, "")
            If nResult <> 1 Then Error 2

            'FINALIZAR E EMITIR CFE *****ESTE PONTO GERA ERRO, POR ISSO ESTA COMENTADO*****
            '   DADOS: NRO. CUPOM ADICIONAL, INFORMACOES ADICIONAIS
            'nResult = ComunicacaoSAT.Daruma.tCFEncerrar_SAT_Daruma("", "COMANDA:" & 100)
            'If nResult <> 1 Then Error 2

            'A LINHA ABAIXO DEVE SER COMENTADA AO RETIRAR O COMENTARIO DA LINHA ACIMA
            'ESTOU UTILIZANDO APENAS PARA PERMITIR A CONTINUIDADE DOS TESTES NA APLICACAO,
            'POIS SE O CUPOM FICAR ABERTO, NAO E' POSSIVEL GERAR NOVOS CUPONS
            nResult = ComunicacaoSAT.Daruma.tCFeCancelar_SAT_Daruma()
            If nResult <> 1 Then Error 2


            '*************** ROTINAS IMPRESSAO *******************
            'NAO FISCAL -> OK
            nResult = ComunicacaoSAT.Daruma.regPortaComunicacao_DUAL_DarumaFramework("COM3")
            ComunicacaoSAT.Daruma.iImprimirTexto_DUAL_DarumaFramework("<tc>#</tc>", 0)
            ComunicacaoSAT.Daruma.iImprimirTexto_DUAL_DarumaFramework("<e><ce>Loucos por churrasco</ce></e>", 0)
            ComunicacaoSAT.Daruma.iImprimirTexto_DUAL_DarumaFramework("<tb><i><ce>Shopping Zona Leste</ce></i></tb>", 0)
            ComunicacaoSAT.Daruma.iImprimirTexto_DUAL_DarumaFramework("<tb><i>Itaquera</i></tb>", 0)
            ComunicacaoSAT.Daruma.iImprimirTexto_DUAL_DarumaFramework("<tb>CNPJ 06.227.709-0001/00</tb>", 0)
            ComunicacaoSAT.Daruma.iImprimirTexto_DUAL_DarumaFramework("<tc>#</tc><l></l>", 0)
            ComunicacaoSAT.Daruma.iImprimirTexto_DUAL_DarumaFramework("<i><dt></dt></i>", 0)
            ComunicacaoSAT.Daruma.iImprimirTexto_DUAL_DarumaFramework("<ad>Cupom não fiscal = 123456789</ad><l></l>", 0)
            ComunicacaoSAT.Daruma.iImprimirTexto_DUAL_DarumaFramework("<c>Cliente</c>", 0)
            ComunicacaoSAT.Daruma.iImprimirTexto_DUAL_DarumaFramework("<ce><e>Valor pago: 200,30</e></ce>", 0)
            ComunicacaoSAT.Daruma.iImprimirTexto_DUAL_DarumaFramework("<tc>_</tc><l></l>", 0)
            ComunicacaoSAT.Daruma.iImprimirTexto_DUAL_DarumaFramework("<sl></sl><sl></sl><sl></sl><sl></sl><sl></sl><sl></sl><sl></sl><sl></sl><sn></sn>", 0)

            'FISCAL
            nResult = ComunicacaoSAT.Daruma.iCFAbrirPadrao_ECF_Daruma()
            nResult = ComunicacaoSAT.Daruma.iCFVender_ECF_Daruma("I1", "1,00", "12,30", "D$", "0,00", "123", "UND", "Prato de comida")
            nResult = ComunicacaoSAT.Daruma.iCFTotalizarCupomPadrao_ECF_Daruma
            nResult = ComunicacaoSAT.Daruma.iCFEfetuarPagamentoPadrao_ECF_Daruma
            nResult = ComunicacaoSAT.Daruma.iCFEfetuarPagamentoFormatado_ECF_Daruma("Débito", "12,30")
            nResult = ComunicacaoSAT.Daruma.iCFEncerrarPadrao_ECF_Daruma
            nResult = ComunicacaoSAT.Daruma.iCFIdentificarConsumidor_ECF_Daruma("Sidnei", "Rua sem nome, 215", "213213218-00")

            Return True

        Catch oErro As Exception

            If oErro.Message = "Application-defined or object-defined error." Then
                Select Case nResult
                    Case 0
                        MessageBox.Show("[0] - Método não executado / Tag inválida / Não foi possível comunicar com impressora", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        'retorno 0, depende do método que foi chamado tem significado diferente.
                    Case -6
                        MessageBox.Show("[-6] - TimeOut, erro de comunicação com o SAT", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case -7
                        MessageBox.Show("[-7] - Erro ao abrir comunicação com o SAT", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case -40
                        MessageBox.Show("[-40] - Tag XML inválida", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case -50
                        MessageBox.Show("[-50] - Impressora off-Line", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case -51
                        MessageBox.Show("[-51] - Impressora sem papel", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case -99
                        MessageBox.Show("[-99] - Parâmetro inválido ou ponteiro nulo de parâmetro", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case -120
                        MessageBox.Show("[-120] - Encontrada tag inválida", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case -121
                        MessageBox.Show("[-121] - Estrutura Invalida", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case -122
                        MessageBox.Show("[-122] - Tag obrigatória não foi informada", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case -123
                        MessageBox.Show("[-123] - Tag obrigatória não tem valor preenchido", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case -130
                        MessageBox.Show("[-130] - CFe já aberto", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case -131
                        MessageBox.Show("[-131] - CFe não aberto", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case -132
                        MessageBox.Show("[-132] - CFe não em fase de venda", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case -133
                        MessageBox.Show("[-133] - CFe não em fase de totalização", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case -134
                        MessageBox.Show("[-134] - CFe não em fase de pagamento", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case -135
                        MessageBox.Show("[-135] - CFe não em fase de encerramento", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case -136
                        MessageBox.Show("[-136] - CFe em estado inválido para operação", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case -140
                        MessageBox.Show("[-140] - Biblioteca auxiliar SAT.dll não foi encontrada/carregada", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case -141
                        MessageBox.Show("[-141] - Impressora inválida (modelo deve ser DR700 ou versão incompativel)", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case -142
                        MessageBox.Show("[-142] - Resposta Incompleta do SAT", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        ''' Os códigos de erro abaixo são retornados pelo SAT  para verificar mais retornos consulte a Especificação de Requisitos do SAT vigente.
                    Case 1084
                        MessageBox.Show("[1084] - Formato do Certificado Inválido", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 1085
                        MessageBox.Show("[1085] - Assinatura do Aplicativo Comercial não confere", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 1218
                        MessageBox.Show("[1218] - CF-e-SAT Já está cancelado", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 1412
                        MessageBox.Show("[1412] - CFe de cancelamento não corresponde a um CFe emitido nos 30 minutos anteriores ao pedido de cancelamento", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 1999
                        MessageBox.Show("[1999] - Erro desconhecido", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 6001
                        MessageBox.Show("[6001] - Código de ativação inválido", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 6002
                        MessageBox.Show("[6002] - SAT ainda não ativado", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 6003
                        MessageBox.Show("[6003] - SAT não vinculado ao AC", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 6004
                        MessageBox.Show("[6004] - Vinculação do AC não confere", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 6005
                        MessageBox.Show("[6005] - Tamanho do CFe superior a 1500KB", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 6006
                        MessageBox.Show("[6006] - SAT bloqueado pelo contribuinte", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 6007
                        MessageBox.Show("[6007] - SAT bloqueado pela SEFAZ", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 6008
                        MessageBox.Show("[6008] - SAT bloqueado por falta de comunicação", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 6009
                        MessageBox.Show("[6009] - SAT bloqueado, código de ativação incorreto", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 6010
                        MessageBox.Show("[6010] - Erro de validação do conteúdo", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 6098
                        MessageBox.Show("[6098] - SAT em processamento. Tente novamente", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 6099
                        MessageBox.Show("[6099] - Erro desconhecido", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 7001
                        MessageBox.Show("[7001] - Código de ativação inválido", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 7002
                        MessageBox.Show("[7002] - Cupom Inválido", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 7003
                        MessageBox.Show("[7003] - SAT bloqueado pelo contribuinte", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 7004
                        MessageBox.Show("[7004] - SAT bloqueado pela SEFAZ", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 7005
                        MessageBox.Show("[7005] - SAT bloqueado por falta de comunicação", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 7006
                        MessageBox.Show("[7006] - SAT bloqueado, código de ativação incorreto", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 7007
                        MessageBox.Show("[7007] - Erro de validação do conteúdo", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 7098
                        MessageBox.Show("[7098] - SAT em processamento. Tente novamente", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 7099
                        MessageBox.Show("[7099] - Erro desconhecido", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 8098
                        MessageBox.Show("[8098] - SAT em processamento. Tente novamente", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 8099
                        MessageBox.Show("[8099] - Erro desconhecido", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 10001
                        MessageBox.Show("[10001] - Código de ativação inválido", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 10098
                        MessageBox.Show("[10098] - SAT em processamento. Tente novamente", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 10099
                        MessageBox.Show("[10099] - Erro desconhecido", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 13001
                        MessageBox.Show("[13001] - Código de ativação inválido", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 13002
                        MessageBox.Show("[13002] - Erro de comunicação com a SEFAZ", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 13003
                        MessageBox.Show("[13003] - Assinatura fora do padrão informado", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 13098
                        MessageBox.Show("[13098] - SAT em processamento. Tente novamente", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case 13099
                        MessageBox.Show("[13099] - Erro desconhecido", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case Else
                        MessageBox.Show("[" & nResult.ToString() & "] - Código de erro não identificado... Consulte a Especificação de Requisitos SAT vigente.", "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Select

            Else
                MessageBox.Show(oErro.Message, "Erro na impressão do cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            Return False

        End Try

    End Function

End Class