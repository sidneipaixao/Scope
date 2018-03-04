Public Class frmIncluirPedido

    Private Sub fnSubgrupo(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'BOTAO RETORNAR
        If sender.Tag = -1 Then
            fnExibeProdutos(0)
            Exit Sub
        End If

        fnExibeProdutos(sender.TAG)

    End Sub

    Private Sub fnExibeProdutos(Optional ByVal nGrupo As Integer = 0)

        Dim oDados As SqlClient.SqlDataReader

        'SE EXISTIREM GRUPOS SENDO EXIBIDOS, APAGA
        pnlProdutos.Controls.Clear()

        If nGrupo > 0 Then

            oDados = fnRetornaDados("SELECT PRDCODIGO, PRDNOME, * FROM PRODUTOS WHERE PRDSITUACAO = 1 AND PRDSUBRUPO IN (SELECT SGRCODIGO FROM SUBGRUPOS WHERE SGRGRUPO = " & nGrupo & ")")

            'CASO ESTEJA NO NIVEL SECUNDÁRIO, EXIBE BOTÃO RETORNAR 
            Dim oRetorno As New Button

            oRetorno.Text = "< RETORNAR"
            oRetorno.Size = New Size(170, 60)
            oRetorno.Font = New Font(btnRemover.Font, FontStyle.Regular)
            oRetorno.Tag = -1
            oRetorno.ForeColor = Color.White
            oRetorno.BackColor = Color.LightSeaGreen
            oRetorno.FlatStyle = FlatStyle.Flat

            AddHandler oRetorno.Click, AddressOf fnSubgrupo
            pnlProdutos.Controls.Add(oRetorno)

            'EXIBE OS ITENS DO PRODUTO SELECIONADO, OU PRODUTOS PRINCIPAIS SE NGRUPO = 0
            While oDados.Read

                Dim oProdutos As New Button

                oProdutos.Text = oDados("PRDNOME")
                oProdutos.Tag = oDados("PRDCODIGO")
                oProdutos.Size = New Size(170, 60)
                oProdutos.BackColor = btnPrato.BackColor
                oProdutos.Font = New Font(btnRemover.Font, FontStyle.Regular)
                'oProdutos.FlatStyle = FlatStyle.Flat
                AddHandler oProdutos.Click, AddressOf fnSubgrupo

                pnlProdutos.Controls.Add(oProdutos)

            End While

        Else

            oDados = fnRetornaDados("SELECT GRPCODIGO, GRPNOME FROM GRUPOS WHERE GRPSITUACAO = 1 AND GRPQTDEMAX IN (1, 99)")

            'EXIBE OS ITENS DO PRODUTO SELECIONADO, OU PRODUTOS PRINCIPAIS SE NGRUPO = 0
            While oDados.Read

                Dim oProdutos As New Button

                oProdutos.Text = oDados("GRPNOME")
                oProdutos.Tag = oDados("GRPCODIGO")
                oProdutos.Size = New Size(170, 60)
                oProdutos.BackColor = btnPrato.BackColor
                oProdutos.Font = New Font(btnRemover.Font, FontStyle.Regular)
                oProdutos.FlatStyle = FlatStyle.Flat
                AddHandler oProdutos.Click, AddressOf fnSubgrupo

                pnlProdutos.Controls.Add(oProdutos)

            End While

        End If
        
        oDados.Close()

    End Sub

    Private Sub frmIncluirPedido_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'NAO PODE MAXIMIZAR, SENAO COBRE BARRA DE TAREFAS DO WINDOWS, POR ISSO NAO USA WINDOWSTATE
        Top = 0
        Left = 0
        Width = Screen.GetWorkingArea(Me).Width
        Height = Screen.GetWorkingArea(Me).Height

        'DESENHA BORDA DO FORMULARIO
        BackgroundImage = New Bitmap(Width - 1, Height - 1)
        Graphics.FromImage(BackgroundImage).DrawRectangle(New Pen(Color.FromArgb(55, 65, 80)), New Rectangle(New Point(0, 0), Size))

        fnExibeProdutos()

        ''ROTINA PARA CARREGAR OS PRODUTOS (14/02/2018 - EXEMPLO, FALTA IMPLANTAR GRUPOS)
        'Dim oProdutos As SqlClient.SqlDataReader = fnRetornaDados("SELECT GRPCODIGO CODIGO, GRPNOME NOME FROM GRUPOS WHERE GRPSITUACAO = 1 AND GRPQTDEMAX IN (1, 99)")

        ''CARREGA PEDIDOS DA BASE DE DADOS
        'While oProdutos.Read
        '    With lstProdutos.Items.Add(oProdutos("CODIGO"), oProdutos("CODIGO"), 0)
        '        .UseItemStyleForSubItems = False
        '        .SubItems.Add(oProdutos("NOME") & " ", Color.LightSeaGreen, lstProdutos.BackColor, New Font(lstProdutos.Font.Name, 14, FontStyle.Bold))
        '    End With
        'End While

        'oProdutos.Close()

        ''Rotina responsável por ajustar a largura das colunas dos listviews
        'lstProdutos.Columns(0).Width = (lstProdutos.Width * 20) / 100
        'lstProdutos.Columns(1).Width = (lstProdutos.Width * 80) / 100

        'lstItens.Columns(0).Width = (lstItens.Width * 15) / 100
        'lstItens.Columns(1).Width = (lstItens.Width * 55) / 100
        'lstItens.Columns(2).Width = (lstItens.Width * 15) / 100
        'lstItens.Columns(3).Width = (lstItens.Width * 15) / 100

    End Sub

    Private Sub cmdFechar_Click(sender As System.Object, e As System.EventArgs) Handles cmdFechar.Click

        Close()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles Label6.Click

    End Sub
End Class