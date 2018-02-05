Public Class frmPedidos

    Private Sub frmPedidos_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

        'ESC -> FECHAR TELA
        If e.KeyCode = 27 Then
            Close()
        End If

        'ENTER -> SE TIVER PEDIDO SELECIONADO, EXIBE TELA ENCERRAMENTO
        If e.KeyCode = 13 Then
            If lstPedidos.SelectedItems.Count > 0 Then
                lstPedidos_MouseClick(lstPedidos, Nothing)
            End If
        End If

        'F5 -> RECARREGA PEDIDOS NA TELA
        If e.KeyCode = Keys.F5 Then
            objBuscaPedido_Tick(objBuscaPedido, Nothing)
        End If

    End Sub

    Private Sub frmPedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'DESENHA BORDA DO FORMULARIO
        'NAO PODE MAXIMIZAR, SENAO COBRE BARRA DE TAREFAS DO WINDOWS, POR ISSO NAO USA WINDOWSTATE
        Top = 0
        Left = 0
        Width = Screen.GetWorkingArea(Me).Width
        Height = Screen.GetWorkingArea(Me).Height

        BackgroundImage = New Bitmap(Width - 1, Height - 1)
        Graphics.FromImage(BackgroundImage).DrawRectangle(New Pen(Color.FromArgb(55, 65, 80)), New Rectangle(New Point(0, 0), Size))

        objBuscaPedido_Tick(objBuscaPedido, Nothing)

    End Sub

    Private Sub cmdFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub lstPedidos_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstPedidos.MouseClick

        If lstPedidos.SelectedItems.Count > 0 Then
            'frmEncerrarPedido.txtEmail.Text = lstPedidos.SelectedItems(0).SubItems(2).Text
            frmComanda.txtNome.Text = lstPedidos.SelectedItems(0).Text
            frmEncerrarPedido.fnCarregaDados(lstPedidos.SelectedItems(0).Name.ToString.Remove(0, 3))
            frmEncerrarPedido.Show()
        End If

    End Sub

    Private Sub cmdFechar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFechar.Click

        Close()

    End Sub

    Private Sub objBuscaPedido_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles objBuscaPedido.Tick

        ''EXECUTA A CHAMADA DA ROTINA NA BASE DE DADOS
        'oComando.CommandText = "SP_BUSCAPEDIDO"
        'oComando.CommandTimeout = 600
        'oComando.ExecuteNonQuery()

        Dim oPedidos As SqlClient.SqlDataReader = fnRetornaDados("SELECT VNDCODIGO CODPEDIDO, VNDCLIENTENOME NOME, '' CONTRATO, VNDCLIENTEEMAIL EMAIL FROM vendas WHERE VNDCOMANDA IS NULL")

        lstPedidos.Items.Clear()

        'CARREGA PEDIDOS DA BASE DE DADOS
        While oPedidos.Read
            With lstPedidos.Items.Add("PDD" & oPedidos("CODPEDIDO"), oPedidos("NOME") & "", 0)
                .UseItemStyleForSubItems = False
                .SubItems.Add(oPedidos("CONTRATO") & " ", Color.IndianRed, lstPedidos.BackColor, New Font(lstPedidos.Font.Name, 12, FontStyle.Bold))
                .SubItems.Add(oPedidos("EMAIL") & " ", Color.IndianRed, lstPedidos.BackColor, New Font(lstPedidos.Font.Name, 12, FontStyle.Bold))
            End With
        End While

        oPedidos.Close()

    End Sub

End Class