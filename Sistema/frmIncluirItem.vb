Public Class frmIncluirItem

    Dim nVlrTotal As Double = 0
    Private Sub frmIncluirItem_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'NAO PODE MAXIMIZAR, SENAO COBRE BARRA DE TAREFAS DO WINDOWS, POR ISSO NAO USA WINDOWSTATE
        Top = 0
        Left = 0
        Width = Screen.GetWorkingArea(Me).Width
        Height = Screen.GetWorkingArea(Me).Height

        'DESENHA AS BORDAS DA TELA
        BackgroundImage = New Bitmap(Width - 1, Height - 1)
        Graphics.FromImage(BackgroundImage).DrawRectangle(New Pen(Color.FromArgb(55, 65, 80)), New Rectangle(New Point(0, 0), Size))

        nVlrTotal = 0
        lstItens.Items.Clear()
        objGrupos.Controls.Clear()

        For Each oItem As ListViewItem In frmEncerrarPedido.lstItens.Items

            oItem = lstItens.Items.Add(oItem.Clone())
            nVlrTotal += oItem.Text

        Next

        txtTotal.Text = nVlrTotal

        Dim oDados As SqlClient.SqlDataReader = fnRetornaDados("SELECT 1 codigo, 'Grelhados' grupo UNION " & _
                                                                "SELECT 2 codigo, 'Executivos' grupo UNION " & _
                                                                "SELECT 3 codigo, 'Espetos' grupo UNION " & _
                                                                "SELECT 4 codigo, 'Especiais' grupo UNION " & _
                                                                "SELECT 5 codigo, 'Porções' grupo")

        While oDados.Read

            Dim oGrupo As New Button

            oGrupo.Text = oDados("grupo")
            oGrupo.Size = New Size(145, 40)
            oGrupo.Tag = oDados("codigo")
            AddHandler oGrupo.Click, AddressOf fnSelecionaGrupo

            objGrupos.Controls.Add(oGrupo)

        End While

        oDados.Close()

    End Sub

    Private Sub fnSelecionaGrupo(sender As System.Object, e As System.EventArgs)

        lstItensGrupo.Items.Clear()

        Dim oDados As SqlClient.SqlDataReader = fnRetornaDados("Select 51 codigo, 'Anéis de cebola 500g' descricao, 8.90 valor, 1 qtde where '" & sender.text & "'  = 'Porções' union " & _
                                                                "select 52 codigo, 'Batata Frita 600g' descricao, 9.9 valor, 1 qtde where '" & sender.text & "' = 'Porções' union " & _
                                                                "select 53 codigo, 'Calabresa 500g' descricao, 11.9 valor, 1 qtde where '" & sender.text & "' = 'Porções' union " & _
                                                                "select 54 codigo, 'Contrafilé fatiado' descricao, 11.9 valor, 1 qtde where '" & sender.text & "' = 'Porções' union " & _
                                                                "select 41 codigo, 'Bife a Cavalo' descricao, 16.9 valor, 1 qtde where '" & sender.text & "' = 'Especiais' union " & _
                                                                "select 42 codigo, 'Strogonoff de Carne' descricao, 16.9 valor, 1 qtde where '" & sender.text & "' = 'Especiais' union " & _
                                                                "select 43 codigo, 'Strogonoff de Frango' descricao, 16.9 valor, 1 qtde where '" & sender.text & "' = 'Especiais' union " & _
                                                                "select 44 codigo, 'Feijoada' descricao, 18.9 valor, 1 qtde where '" & sender.text & "' = 'Especiais' union " & _
                                                                "select 31 codigo, 'Carne (Fraldinha)' descricao, 9.9 valor, 1 qtde where '" & sender.text & "' = 'Espetos' union " & _
                                                                "select 32 codigo, 'Carne com Bacon (Fraldinha)' descricao, 10.9 valor, 1 qtde where '" & sender.text & "' = 'Espetos' union " & _
                                                                "select 33 codigo, 'Coração de Frango' descricao, 9.9 valor, 1 qtde where '" & sender.text & "' = 'Espetos' union " & _
                                                                "select 34 codigo, 'Frango' descricao, 7.9 valor, 1 qtde where '" & sender.text & "' = 'Espetos' union " & _
                                                                "select 21 codigo, 'Alcatra Fatiada 120g' descricao, 19.9 valor, 1 qtde where '" & sender.text & "' = 'Executivos' union " & _
                                                                "select 22 codigo, 'Frango Fatiado 120g' descricao, 16.9 valor, 1 qtde where '" & sender.text & "' = 'Executivos' union " & _
                                                                "select 23 codigo, 'Calabresa Fatiada 120g' descricao, 16.9 valor, 1 qtde where '" & sender.text & "' = 'Executivos' union " & _
                                                                "select 24 codigo, 'Filé de Frango 130g' descricao, 16.9 valor, 1 qtde where '" & sender.text & "' = 'Executivos' union " & _
                                                                "select 11 codigo, 'Baby Beef 200g' descricao, 22.9 valor, 1 qtde where '" & sender.text & "' = 'Grelhados' union " & _
                                                                "select 12 codigo, 'Contrafilé 200g' descricao, 22.9 valor, 1 qtde where '" & sender.text & "' = 'Grelhados' union " & _
                                                                "select 13 codigo, 'Filé Mignon 200g' descricao, 22.9 valor, 1 qtde where '" & sender.text & "' = 'Grelhados' union " & _
                                                                "select 14 codigo, 'Picanha 130g' descricao, 22.9 valor, 1 qtde where '" & sender.text & "' = 'Grelhados'")



        'POPULA O LISTVIEW
        While oDados.Read

            Dim oItem As ListViewItem

            oItem = lstItensGrupo.Items.Add(oDados("codigo"))
            oItem.SubItems.Add(oDados("codigo"))
            oItem.SubItems.Add(oDados("descricao"))
            oItem.SubItems.Add(oDados("qtde"))
            oItem.SubItems.Add(oDados("valor"))
            oItem.Name = oDados("qtde")
            oItem.Tag = oDados("codigo")
            oItem.Text = oDados("valor")
            oItem.ToolTipText = oDados("descricao")

        End While

        oDados.Close()


    End Sub

    Private Sub grdItemPedido_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

        'frmExcluirItem.ShowDialog()

        'If frmExcluirItem.Tag = True Then

        '    grdItemPedido.Rows.RemoveAt(grdItemPedido.CurrentRow.Index)

        'End If

        'txtTotal.Text = 0

        'For nCont = 0 To grdItemPedido.RowCount - 1

        '    txtTotal.Text = txtTotal.Text + grdItemPedido(3, nCont).Value

        'Next

    End Sub

    Private Sub grdItensGrupo_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

        '    fnAdicionaItens()

        '    txtTotal.Text = 0

        'For nCont = 0 To grdItemPedido.RowCount - 1

        '  txtTotal.Text = txtTotal.Text + grdItemPedido(3, nCont).Value

        'Next

    End Sub

    Private Sub fnAdicionaItens()

        'grdItemPedido.Rows.Add(grdItensGrupo(0, grdItensGrupo.CurrentRow.Index).Value, 1, _
        '                  grdItensGrupo(1, grdItensGrupo.CurrentRow.Index).Value, grdItensGrupo(2, grdItensGrupo.CurrentRow.Index).Value)

    End Sub

    Private Sub btnAtualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnAtualizar.Click

        frmEncerrarPedido.lstItens.Items.Clear()
        nVlrTotal = 0

        For Each oItem As ListViewItem In lstItens.Items

            oItem = frmEncerrarPedido.lstItens.Items.Add(oItem.Clone())
            nVlrTotal += oItem.Text

        Next

        frmEncerrarPedido.txtTotal.Text = "0,00"
        frmEncerrarPedido.txtTotal.Text = nVlrTotal
        Close()

    End Sub

    Private Sub cmdFechar_Click(sender As System.Object, e As System.EventArgs) Handles cmdFechar.Click

        Close()

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

    Private Sub lstItensGrupo_Click(sender As Object, e As System.EventArgs) Handles lstItensGrupo.Click

        'Aqui nós configuramos o fomr abaixo para confirma a quantidade do produto que o user deseja add
        frmExcluirItem.lblTitulo.Text = "Confirmar inclusão"
        frmExcluirItem.lblUsuario.Text = "Quantidade"
        frmExcluirItem.txtSenha.Visible = False
        frmExcluirItem.lblCxTexto.Visible = False
        frmExcluirItem.lblUsuario.Text = "Quantidade"
        frmExcluirItem.cbxUsuario.Visible = False
        frmExcluirItem.txtAux.Visible = True
        frmExcluirItem.cFuncao = "incluir.qtde"
        For Each oItem As ListViewItem In lstItensGrupo.SelectedItems

            frmExcluirItem.lblMensagem.Text = "Você quer realmente incluir o item abaixo ao pedido atual? " & vbNewLine & oItem.ToolTipText

        Next
        frmExcluirItem.ShowDialog()

        If frmExcluirItem.cFuncao = "confirmar" Then

            For Each oItem As ListViewItem In lstItensGrupo.SelectedItems
                Dim oDados As SqlClient.SqlDataReader = fnRetornaDados("Select 51 codigo, 'Anéis de cebola 500g' descricao, 8.90 valor where 51 = " & oItem.Tag & " union " & _
                                                                        "select 52 codigo, 'Batata Frita 600g' descricao, 9.9 valor where 52 = " & oItem.Tag & " union " & _
                                                                        "select 53 codigo, 'Calabresa 500g' descricao, 11.9 valor where 53 = " & oItem.Tag & " union " & _
                                                                        "select 54 codigo, 'Contrafilé fatiado' descricao, 11.9 valor where 54 = " & oItem.Tag & " union " & _
                                                                        "select 41 codigo, 'Bife a Cavalo' descricao, 16.9 valor where 41 = " & oItem.Tag & " union " & _
                                                                        "select 42 codigo, 'Strogonoff de Carne' descricao, 16.9 valor where 42 = " & oItem.Tag & " union " & _
                                                                        "select 43 codigo, 'Strogonoff de Frango' descricao, 16.9 valor where 43 = " & oItem.Tag & " union " & _
                                                                        "select 44 codigo, 'Feijoada' descricao, 18.9 valor where 44 = " & oItem.Tag & " union " & _
                                                                        "select 31 codigo, 'Carne (Fraldinha)' descricao, 9.9 valor where 31 = " & oItem.Tag & " union " & _
                                                                        "select 32 codigo, 'Carne com Bacon (Fraldinha)' descricao, 10.9 valor where 32 = " & oItem.Tag & " union " & _
                                                                        "select 33 codigo, 'Coração de Frango' descricao, 9.9 valor where 33 = " & oItem.Tag & " union " & _
                                                                        "select 34 codigo, 'Frango' descricao, 7.9 valor where 34 = " & oItem.Tag & " union " & _
                                                                        "select 21 codigo, 'Alcatra Fatiada 120g' descricao, 19.9 valor where 21 = " & oItem.Tag & " union " & _
                                                                        "select 22 codigo, 'Frango Fatiado 120g' descricao, 16.9 valor where 22 = " & oItem.Tag & " union " & _
                                                                        "select 23 codigo, 'Calabresa Fatiada 120g' descricao, 16.9 valor where 23 = " & oItem.Tag & " union " & _
                                                                        "select 24 codigo, 'Filé de Frango 130g' descricao, 16.9 valor where 24 = " & oItem.Tag & " union " & _
                                                                        "select 11 codigo, 'Baby Beef 200g' descricao, 22.9 valor where 11 = " & oItem.Tag & " union " & _
                                                                        "select 12 codigo, 'Contrafilé 200g' descricao, 22.9 valor where 12 = " & oItem.Tag & " union " & _
                                                                        "select 13 codigo, 'Filé Mignon 200g' descricao, 22.9 valor where 13 = " & oItem.Tag & " union " & _
                                                                        "select 14 codigo, 'Picanha 130g' descricao, 22.9 valor where 14 = " & oItem.Tag)

                'POPULA O LISTVIEW
                While oDados.Read

                    oItem = lstItens.Items.Add(oDados("codigo"))
                    oItem.SubItems.Add(oDados("codigo"))
                    oItem.SubItems.Add(oDados("descricao"))
                    oItem.SubItems.Add(frmExcluirItem.txtAux.Text)
                    oItem.SubItems.Add(oDados("valor") * frmExcluirItem.txtAux.Text)
                    oItem.Name = oDados("descricao")
                    oItem.Tag = oDados("codigo")
                    oItem.Text = String.Format("{0:N2}", CDbl((oDados("valor")) * CDbl(frmExcluirItem.txtAux.Text)))
                    oItem.ToolTipText = frmExcluirItem.txtAux.Text

                    nVlrTotal += String.Format("{0:N2}", (CDbl(oDados("valor")) * CDbl(frmExcluirItem.txtAux.Text)))

                End While

                txtTotal.Text = nVlrTotal
                oDados.Close()

            Next

        End If

    End Sub

End Class