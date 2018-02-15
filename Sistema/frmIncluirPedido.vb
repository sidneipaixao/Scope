Public Class frmIncluirPedido

    Private Sub frmIncluirPedido_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'NAO PODE MAXIMIZAR, SENAO COBRE BARRA DE TAREFAS DO WINDOWS, POR ISSO NAO USA WINDOWSTATE
        Top = 0
        Left = 0
        Width = Screen.GetWorkingArea(Me).Width
        Height = Screen.GetWorkingArea(Me).Height

        'DESENHA BORDA DO FORMULARIO
        BackgroundImage = New Bitmap(Width - 1, Height - 1)
        Graphics.FromImage(BackgroundImage).DrawRectangle(New Pen(Color.FromArgb(55, 65, 80)), New Rectangle(New Point(0, 0), Size))

        'ROTINA PARA CARREGAR OS PRODUTOS (14/02/2018 - EXEMPLO, FALTA IMPLANTAR GRUPOS)
        Dim oProdutos As SqlClient.SqlDataReader = fnRetornaDados("SELECT GRPCODIGO CODIGO, GRPNOME NOME FROM GRUPOS WHERE GRPSITUACAO = 1 AND GRPQTDEMAX IN (1, 99)")

        lstProdutos.Items.Clear()

        'CARREGA PEDIDOS DA BASE DE DADOS
        While oProdutos.Read
            With lstProdutos.Items.Add(oProdutos("CODIGO"), oProdutos("CODIGO"), 0)
                .UseItemStyleForSubItems = False
                .SubItems.Add(oProdutos("NOME") & " ", Color.LightSeaGreen, lstProdutos.BackColor, New Font(lstProdutos.Font.Name, 14, FontStyle.Bold))
            End With
        End While

        oProdutos.Close()

        'Rotina responsável por ajustar a largura das colunas dos listviews
        lstProdutos.Columns(0).Width = (lstProdutos.Width * 20) / 100
        lstProdutos.Columns(1).Width = (lstProdutos.Width * 80) / 100

        lstItens.Columns(0).Width = (lstItens.Width * 15) / 100
        lstItens.Columns(1).Width = (lstItens.Width * 55) / 100
        lstItens.Columns(2).Width = (lstItens.Width * 15) / 100
        lstItens.Columns(3).Width = (lstItens.Width * 15) / 100

    End Sub

    Private Sub cmdFechar_Click(sender As System.Object, e As System.EventArgs) Handles cmdFechar.Click

        Close()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

    End Sub
End Class