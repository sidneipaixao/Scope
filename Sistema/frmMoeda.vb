Public Class frmMoeda

    Private Sub fnLimparTela()

        btnCancelar.Enabled = False
        txtMoeda.Text = ""
        txtCodigo.Text = ""
        cmbGrupo.SelectedIndex = -1
        optExibir.Checked = False
        optTotaliza.Checked = False
        optCozinha.Checked = False
        optFiscal.Checked = False
        optNaoFiscal.Checked = False
        optNaoDisp1.Checked = False
        optNaoDisp2.Checked = False
        optExibir.Tag = ""

    End Sub

    Private Sub fnMoedasAtivas()

        'MOEDAS ATIVAS
        'DEFINE AS CONSULTAS PARA NÓS PAI E NÓS FILHO
        Dim cSQL As String = "SELECT * FROM MOEDAS WHERE MDSRELACAO = 0 AND MDSEXIBICAO = 1"
        Dim oNodePai As New SqlClient.SqlDataAdapter(cSQL, oConexao)
        cSQL = "SELECT * FROM MOEDAS WHERE MDSRELACAO <> 0 AND MDSEXIBICAO = 1"
        Dim oNodeFilho As New SqlClient.SqlDataAdapter(cSQL, oConexao)

        'CRIA O DATASET
        Dim oTabela As New DataSet

        'PREENCHE O DATASET COM AS INFORMAÇOES DO QUE É NÓ PAI E DO QUE É NÓ FILHO
        oNodePai.Fill(oTabela, "GRUPOS")
        oNodeFilho.Fill(oTabela, "FILHOS")

        'DEFINE O DATAVIEW
        Dim oFilhos As New DataView
        oFilhos = oTabela.Tables("FILHOS").DefaultView

        'AQUI DEFINIMOS O NÓ RAIZ
        trvMoeda.Nodes.Add("MOEDAS ATIVAS").NodeFont = New Font(txtMoeda.Font, FontStyle.Bold)
        'trvMoeda.Nodes.Add("MOEDAS INATIVAS").NodeFont = New Font(txtMoeda.Font, FontStyle.Bold)

        'AGORA VAMOS PREENCHER O TREEVIEW
        Dim dr As DataRow
        Dim nodo As TreeNode

        ''AQUI PERCORREREMOS CADA LINHA DE NÓS PAI
        For Each dr In oTabela.Tables("GRUPOS").Rows

            ''AQUI INSERIMOS O CODIGO (OCULTO, PODE SER EXIBIDO NA PROPRIEDADE NAME E O TEXTO EXIBIDO NOS NÓS PAI
            nodo = trvMoeda.Nodes(0).Nodes.Add(dr("MDSCODIGO"), dr("MDSNOME"))
            nodo.NodeFont = New Font(txtMoeda.Font, FontStyle.Bold)

            ''AQUI PREENCHEMOS OS FILHOS PARA CADA NÓ PAI
            oFilhos.RowFilter = "MDSRELACAO = " & dr("MDSCODIGO")

            ''PREENCHE OS NÓS FILHO COM O CODIGO (OCULTO, PODE SER EXIBIDO NA PROPRIEDADE NAME) E TEXTO A SER EXIBIDO

            For i = 0 To oFilhos.Count - 1
                nodo.Nodes.Add(oFilhos.Item(i).Row("MDSCODIGO"), oFilhos.Item(i).Row("MDSNOME"))
            Next

        Next

        trvMoeda.ExpandAll()

    End Sub

    Private Sub fnMoedasInativas()

        Dim cSQL As String = "SELECT * FROM MOEDAS WHERE MDSEXIBICAO = 0"
        Dim oNodePai As New SqlClient.SqlDataAdapter(cSQL, oConexao)
        'cSQL = "SELECT * FROM MOEDAS WHERE MDSRELACAO <> 0 AND MDSEXIBICAO = 0"
        'Dim oNodeFilho As New SqlClient.SqlDataAdapter(cSQL, oConexao)

        'CRIA O DATASET
        Dim oTabela As New DataSet

        'PREENCHE O DATASET COM AS INFORMAÇOES DO QUE É NÓ PAI E DO QUE É NÓ FILHO
        oNodePai.Fill(oTabela, "GRUPOS")
        'oNodeFilho.Fill(oTabela, "FILHOS")

        'DEFINE O DATAVIEW
        'Dim oFilhos As New DataView
        'oFilhos = oTabela.Tables("FILHOS").DefaultView

        'AQUI DEFINIMOS O NÓ RAIZ
        'trvMoeda.Nodes.Add("MOEDAS ATIVAS").NodeFont = New Font(txtMoeda.Font, FontStyle.Bold)
        trvMoeda.Nodes.Add("MOEDAS INATIVAS").NodeFont = New Font(txtMoeda.Font, FontStyle.Bold)

        'AGORA VAMOS PREENCHER O TREEVIEW
        Dim dr As DataRow
        Dim nodo As TreeNode

        ''AQUI PERCORREREMOS CADA LINHA DE NÓS PAI
        For Each dr In oTabela.Tables("GRUPOS").Rows

            ''AQUI INSERIMOS O CODIGO (OCULTO, PODE SER EXIBIDO NA PROPRIEDADE NAME E O TEXTO EXIBIDO NOS NÓS PAI
            nodo = trvMoeda.Nodes(1).Nodes.Add(dr("MDSCODIGO"), dr("MDSNOME"))
            nodo.ForeColor = Color.LightCoral

            ''AQUI PREENCHEMOS OS FILHOS PARA CADA NÓ PAI
            'oFilhos.RowFilter = "MDSRELACAO = " & dr("MDSCODIGO")

            ''PREENCHE OS NÓS FILHO COM O CODIGO (OCULTO, PODE SER EXIBIDO NA PROPRIEDADE NAME) E TEXTO A SER EXIBIDO

            ''For i = 0 To oFilhos.Count - 1
            'nodo.Nodes.Add(oFilhos.Item(i).Row("MDSCODIGO"), oFilhos.Item(i).Row("MDSNOME"))
            'Next

        Next

        trvMoeda.ExpandAll()

    End Sub

    Private Sub fnPreenheGrupo()

        'NESTE TRECHO O COMBO Grupo ao qual faz parte É PREENCHIDO
        Dim cSQL As String = "SELECT * FROM MOEDAS WHERE MDSRELACAO = 0"

        Dim oConsulta As New SqlClient.SqlDataAdapter(cSQL, oConexao)
        Dim oTabela As New DataTable

        oConsulta.Fill(oTabela)
        cmbGrupo.DataSource = oTabela
        cmbGrupo.SelectedIndex = -1

    End Sub

    Private Sub frmGrupoMoeda_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'NAO PODE MAXIMIZAR, SENAO COBRE BARRA DE TAREFAS DO WINDOWS, POR ISSO NAO USA WINDOWSTATE
        Top = 0
        Left = 0
        Width = Screen.GetWorkingArea(Me).Width
        Height = Screen.GetWorkingArea(Me).Height

        'DESENHA BORDA DO FORMULARIO
        BackgroundImage = New Bitmap(Width - 1, Height - 1)
        Graphics.FromImage(BackgroundImage).DrawRectangle(New Pen(Color.FromArgb(55, 65, 80)), New Rectangle(New Point(0, 0), Size))

        'ATRIBUO ESTE VALOR A TAG PARA UTILIZAR O MESMO NA FUNCAO SELECTEDINDEXCHANGE DO COMBO GRUPO
        cmbGrupo.Tag = 0

        'ATRIBUO ESTE VALOR A TAG PARA UTILIZAR NO UPDATE DE REGISTROS
        optExibir.Tag = ""

        fnLimparTela()
        trvMoeda.Nodes.Clear()
        fnMoedasAtivas()
        fnMoedasInativas()
        fnPreenheGrupo()
        
        cmbGrupo.Tag = 1

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvar.Click

        Dim nImpressao As Integer = 0
        Dim nGrupo As Integer

        'IF QUE VERIFICA SE ALGUMA OPÇÃO DO GRUPO IMPRESSÃO ESTÁ SELECIONADA
        If optFiscal.Checked = True Then 'Or optNaoFiscal.Checked = True Or optCozinha.Checked = True Or optNaoDisp1.Checked = True Or optNaoDisp2.Checked = True Then

            nImpressao += optFiscal.Tag

        End If

        If optNaoFiscal.Checked = True Then

            nImpressao += optNaoFiscal.Tag

        End If

        If optCozinha.Checked = True Then

            nImpressao += optCozinha.Tag

        End If

        If optNaoDisp1.Checked = True Then

            nImpressao += optNaoDisp1.Tag

        End If

        If optNaoDisp2.Checked = True Then

            nImpressao += optNaoDisp2.Tag

        End If

        'CASO A SELEÇÃO DO COMBO GRUPO ESTEJA VAZIA O VALOR PASSADO NA BASE DEVE SER 0

        If cmbGrupo.SelectedValue < 1 Then

            nGrupo = 0

        Else

            nGrupo = cmbGrupo.SelectedValue

        End If

        If btnCancelar.Enabled = False Then

            'ROTINA PARA GRAVAR O REGISTRO DOS DADOS DIGITADOS NA TELA

            cmbGrupo.Tag = 0

            Dim cSQL As String

            Try

                cSQL = "INSERT INTO MOEDAS(MDSNOME, MDSRELACAO, MDSEXIBICAO, MDSTOTALIZA, MDSIMPRESSAO)" & _
                    " VALUES('{0}', {1}, {2}, {3}, {4})"

                cSQL = String.Format(cSQL, txtMoeda.Text.Replace("'", "´"), nGrupo, CInt(optExibir.Checked), _
                                     CInt(optTotaliza.Checked), nImpressao)

                oComando.CommandText = cSQL
                oComando.ExecuteNonQuery()

                MessageBox.Show("A moeda " + txtMoeda.Text + " foi adicionada com sucesso!" & vbNewLine & _
                                "Ela já está disponível para seleção na tela de pedidos.", "Registro salvo!" _
                                , MessageBoxButtons.OK, MessageBoxIcon.Information)

                fnLimparTela()
                trvMoeda.Nodes.Clear()
                fnMoedasAtivas()
                fnMoedasInativas()
                fnPreenheGrupo()

            Catch

                MessageBox.Show("Erro ao gravar a moeda! Tente novamente e se o problema persistir entre em contato com o administrador do sistema." _
                                & vbNewLine & Err.Number & " - " & Err.Description, "Erro ao salvar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End Try

            cmbGrupo.Tag = 1

        Else

            'ROTINA PARA ALTERAR O REGISTRO
            If MessageBox.Show("Deseja realmente alterar as informações da moeda " & txtMoeda.Text & "?", "Alterar Moeda!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then

                cmbGrupo.Tag = 0

                Try

                    Dim cSQL As String
                    Dim nRetorno As Integer

                    If optExibir.Tag = "grupo" Then

                        cSQL = "UPDATE MOEDAS" & _
                               "  SET MDSNOME = '" & txtMoeda.Text.Replace("'", "´") & "'," & _
                               "      MDSRELACAO = " & nGrupo & "," & _
                               "      MDSEXIBICAO = " & CInt(optExibir.Checked) & "," & _
                               "      MDSTOTALIZA = " & CInt(optTotaliza.Checked) & "," & _
                               "      MDSIMPRESSAO = " & nImpressao & _
                               "  WHERE MDSCODIGO = " & txtCodigo.Text & _
                               "UPDATE MOEDAS" & _
                               "  SET MDSEXIBICAO = 0 " & _
                               "  WHERE MDSRELACAO = " & txtCodigo.Text

                        oComando.CommandText = cSQL
                        nRetorno = oComando.ExecuteNonQuery

                        Select Case nRetorno
                            Case 0

                                MessageBox.Show("Não foi possível alterar a moeda " + txtMoeda.Text + ". Por favor tente novamente." & vbNewLine & "Caso o problema persista contate o administrador do sistema.", "Falha na Alteração!", MessageBoxButtons.OK, MessageBoxIcon.Error)

                            Case -1

                                MessageBox.Show("Não foi possível alterar a moeda " + txtMoeda.Text + ". Operação cancelada." & vbNewLine & "Caso o problema persista contate o administrador do sistema.", "Erro na Alteração!", MessageBoxButtons.OK, MessageBoxIcon.Error)

                            Case Else

                                MessageBox.Show("A moeda " + txtMoeda.Text + " foi alterada com sucesso!", "Moeda Alterada!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                trvMoeda.Nodes.Clear()
                                fnLimparTela()
                                fnMoedasAtivas()
                                fnMoedasInativas()
                                fnPreenheGrupo()

                        End Select

                    Else

                        Dim cSQLAux As String
                        Dim oDados As SqlClient.SqlDataReader

                        cSQLAux = "SELECT * " & _
                                  " FROM MOEDAS" & _
                                  " WHERE MDSCODIGO = (SELECT MDSRELACAO FROM MOEDAS WHERE MDSCODIGO = " & txtCodigo.Text & ")" & _
                                  " AND MDSEXIBICAO = 0"
                        oComando.CommandText = cSQLAux
                        oDados = oComando.ExecuteReader

                        If oDados.Read Then

                            MessageBox.Show("Ative primeiramente o grupo " & oDados("MDSNOME") & " antes de editar esta moeda.", "Grupo inativo!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            oDados.Close()

                        Else

                            oDados.Close()

                            cSQL = "UPDATE MOEDAS" & _
                                   "  SET MDSNOME = '" & txtMoeda.Text.Replace("'", "´") & "'," & _
                                   "      MDSRELACAO = " & nGrupo & "," & _
                                   "      MDSEXIBICAO = " & CInt(optExibir.Checked) & "," & _
                                   "      MDSTOTALIZA = " & CInt(optTotaliza.Checked) & "," & _
                                   "      MDSIMPRESSAO = " & nImpressao & _
                                   "  WHERE MDSCODIGO = " & txtCodigo.Text

                            oComando.CommandText = cSQL
                            nRetorno = oComando.ExecuteNonQuery

                            Select Case nRetorno
                                Case 0

                                    MessageBox.Show("Não foi possível alterar a moeda " + txtMoeda.Text + ". Por favor tente novamente." & vbNewLine & "Caso o problema persista contate o administrador do sistema.", "Falha na Alteração!", MessageBoxButtons.OK, MessageBoxIcon.Error)

                                Case -1

                                    MessageBox.Show("Não foi possível alterar a moeda " + txtMoeda.Text + ". Operação cancelada." & vbNewLine & "Caso o problema persista contate o administrador do sistema.", "Erro na Alteração!", MessageBoxButtons.OK, MessageBoxIcon.Error)

                                Case Else

                                    MessageBox.Show("A moeda " + txtMoeda.Text + " foi alterada com sucesso!", "Moeda Alterada!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    trvMoeda.Nodes.Clear()
                                    fnLimparTela()
                                    fnMoedasAtivas()
                                    fnMoedasInativas()
                                    fnPreenheGrupo()

                            End Select

                        End If

                        oDados.Close()

                    End If

                Catch

                    MessageBox.Show("Erro ao alterar moeda! Tente novamente e se o problema persistir entre em contato com o administrador do sistema." & vbNewLine & Err.Number & " - " & Err.Description, "Erro ao Alterar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End Try

                cmbGrupo.Tag = 1

            End If

        End If

    End Sub

    Private Sub cmbGrupo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbGrupo.SelectedIndexChanged

        'ESTA ROTINA PREENCHE AUTOMATICAMENTE OS VALORES DOS CHECKBOX DE ACORDO COM O GRUPO SELECIONADO.

        If cmbGrupo.Tag <> 0 Then

            Dim cSQL As String
            Dim oDados As SqlClient.SqlDataReader

            cSQL = "SELECT * " & _
                   " FROM MOEDAS" & _
                   " WHERE MDSCODIGO = " & cmbGrupo.SelectedValue & ""
            oComando.CommandText = cSQL
            oDados = oComando.ExecuteReader

            If oDados.Read Then

                optExibir.Checked = True
                optTotaliza.Checked = True
                optFiscal.Checked = True
                optNaoFiscal.Checked = True
                optCozinha.Checked = True
                optExibir.Checked = oDados("MDSEXIBICAO")
                optTotaliza.Checked = oDados("MDSTOTALIZA")

                'CASE QUE CONFIGURA OS CHECKS DO GRUPO IMPRESSÃO
                Select Case oDados("MDSIMPRESSAO")

                    Case 1

                        optFiscal.Checked = True
                        optNaoFiscal.Checked = False
                        optCozinha.Checked = False

                    Case 2

                        optFiscal.Checked = False
                        optNaoFiscal.Checked = True
                        optCozinha.Checked = False

                    Case 4

                        optFiscal.Checked = False
                        optNaoFiscal.Checked = False
                        optCozinha.Checked = True

                    Case 3

                        optFiscal.Checked = True
                        optNaoFiscal.Checked = True
                        optCozinha.Checked = False

                    Case 5

                        optFiscal.Checked = True
                        optNaoFiscal.Checked = False
                        optCozinha.Checked = True

                    Case 6

                        optFiscal.Checked = False
                        optNaoFiscal.Checked = True
                        optCozinha.Checked = True

                    Case 7

                        optFiscal.Checked = True
                        optNaoFiscal.Checked = True
                        optCozinha.Checked = True

                End Select

            End If

            oDados.Close()

        End If

    End Sub

    Private Sub cmdFechar_Click(sender As System.Object, e As System.EventArgs) Handles cmdFechar.Click

        Close()

    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click

        cmbGrupo.Tag = 0
        fnLimparTela()
        cmbGrupo.Tag = 1

    End Sub

    Private Sub optExibir_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optExibir.CheckedChanged

        'UTILIZO ESTE IF PARA VERIFICAR SE A TELA ESTÁ EM MODO DE EDIÇÃO, POIS SÓ ASSIM SERÁ APLICADA A REGRA DE INATIVAÇÃO DE GRUPO (UMA VEZ O GRUPO INATIVADO, TODOS OS FILHOS TAMBÉM SERÃO)
        If btnCancelar.Enabled = True Then

            If optExibir.Checked = False Then

                Dim cSQL As String
                Dim oDados As SqlClient.SqlDataReader

                cSQL = "SELECT * " & _
                       " FROM MOEDAS" & _
                       " WHERE MDSCODIGO = " & txtCodigo.Text & _
                       " AND MDSRELACAO = 0"
                oComando.CommandText = cSQL
                oDados = oComando.ExecuteReader

                If oDados.Read Then

                    MessageBox.Show("Ao decidir não exibir uma moeda agrupadora todas as moedas pertencentes a este grupo deixarão de ser exibidas!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    optExibir.Tag = "grupo"

                End If

                oDados.Close()

            End If

        End If

    End Sub

    Private Sub trvMoeda_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles trvMoeda.AfterSelect

        If trvMoeda.SelectedNode.Name <> "" Then

            Dim cSQL As String
            Dim oDados As SqlClient.SqlDataReader
            cmbGrupo.Tag = 0
            btnCancelar.Enabled = False

            cSQL = "SELECT * " & _
                   " FROM MOEDAS" & _
                   " WHERE MDSCODIGO = " & trvMoeda.SelectedNode.Name & ""
            oComando.CommandText = cSQL
            oDados = oComando.ExecuteReader

            If oDados.Read Then

                txtCodigo.Text = oDados("MDSCODIGO")
                txtMoeda.Text = oDados("MDSNOME")
                cmbGrupo.SelectedValue = oDados("MDSRELACAO")
                optExibir.Checked = True
                optTotaliza.Checked = True
                optFiscal.Checked = True
                optNaoFiscal.Checked = True
                optCozinha.Checked = True
                optExibir.Checked = oDados("MDSEXIBICAO")
                optTotaliza.Checked = oDados("MDSTOTALIZA")

                'CASE QUE CONFIGURA OS CHECKS DO GRUPO IMPRESSÃO
                Select Case oDados("MDSIMPRESSAO")

                    Case 1

                        optFiscal.Checked = True
                        optNaoFiscal.Checked = False
                        optCozinha.Checked = False

                    Case 2

                        optFiscal.Checked = False
                        optNaoFiscal.Checked = True
                        optCozinha.Checked = False

                    Case 4

                        optFiscal.Checked = False
                        optNaoFiscal.Checked = False
                        optCozinha.Checked = True

                    Case 3

                        optFiscal.Checked = True
                        optNaoFiscal.Checked = True
                        optCozinha.Checked = False

                    Case 5

                        optFiscal.Checked = True
                        optNaoFiscal.Checked = False
                        optCozinha.Checked = True

                    Case 6

                        optFiscal.Checked = False
                        optNaoFiscal.Checked = True
                        optCozinha.Checked = True

                    Case 7

                        optFiscal.Checked = True
                        optNaoFiscal.Checked = True
                        optCozinha.Checked = True

                End Select

                cmbGrupo.Tag = 1

            End If

            oDados.Close()
            btnCancelar.Enabled = True


        Else

            MessageBox.Show("Não é possível editar este item!", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


        End If

    End Sub
End Class



