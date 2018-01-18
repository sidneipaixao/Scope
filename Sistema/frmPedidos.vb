Public Class frmPedidos

    Private Sub frmPedidos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'DESENHA BORDA DO FORMULARIO
        'NAO PODE MAXIMIZAR, SENAO COBRE BARRA DE TAREFAS DO WINDOWS, POR ISSO NAO USA WINDOWSTATE
        Top = 0
        Left = 0
        Width = Screen.GetWorkingArea(Me).Width
        Height = Screen.GetWorkingArea(Me).Height

        BackgroundImage = New Bitmap(Width - 1, Height - 1)
        Graphics.FromImage(BackgroundImage).DrawRectangle(New Pen(Color.FromArgb(55, 65, 80)), New Rectangle(New Point(0, 0), Size))

        Dim oPedidos As SqlClient.SqlDataReader = fnRetornaDados("SELECT 1 CODPEDIDO, 'Luis de Camões' NOME, '...' CONTRATO, 'luis.camoes@art.com.br' EMAIL UNION " & _
                                                                 "SELECT 2 CODPEDIDO, 'Neil deGrasse Tyson' NOME, 'Renner' CONTRATO, '...' EMAIL UNION " & _
                                                                 "SELECT 3 CODPEDIDO, 'Phil Spencer' NOME, '...' CONTRATO, 'phil.spencer@microsoft.com' EMAIL UNION " & _
                                                                 "SELECT 3 CODPEDIDO, 'Verner Von Siemens' NOME, 'Fragrance' CONTRATO, '...' EMAIL UNION " & _
                                                                 "SELECT 4 CODPEDIDO, 'Charles Miller' NOME, 'Riachuelo' CONTRATO, 'cliente@riachuelo.com.br' EMAIL")

        lstPedidos.Items.Clear()

        'CARREGA PEDIDOS DA BASE DE DADOS
        While oPedidos.Read
            With lstPedidos.Items.Add("PDD" & oPedidos("CODPEDIDO"), oPedidos("NOME") & "", 0)
                .UseItemStyleForSubItems = False
                .SubItems.Add(oPedidos("CONTRATO") & " ", Color.IndianRed, lstPedidos.BackColor, New Font(lstPedidos.Font.Name, 12, FontStyle.Bold))
                .SubItems.Add(oPedidos("EMAIL") & " ", Color.Gray, lstPedidos.BackColor, New Font(lstPedidos.Font.Name, 12, FontStyle.Bold))
            End With
        End While

        oPedidos.Close()

        oPedidos = fnRetornaDados("SELECT 1 CODPEDIDO, 'Antonio Banderas' NOME, 'New México' CONTRATO, 'antonio.banderas@dmail.com' EMAIL UNION " & _
                                                                 "SELECT 2 CODPEDIDO, 'Alcebiades P. Vasconcelos' NOME, 'Renner' CONTRATO, 'alce@vascon.com.br' EMAIL UNION " & _
                                                                 "SELECT 3 CODPEDIDO, 'Alessandra Vieira Ramos' NOME, '...' CONTRATO, 'alessandraVR@dmail.com' EMAIL")

        lstRecentes.Items.Clear()

        'CARREGA PEDIDOS DA BASE DE DADOS
        While oPedidos.Read
            With lstRecentes.Items.Add("PDD" & oPedidos("CODPEDIDO"), oPedidos("NOME") & "", 0)
                .UseItemStyleForSubItems = False
                .SubItems.Add(oPedidos("CONTRATO") & " ", Color.IndianRed, lstPedidos.BackColor, New Font(lstPedidos.Font.Name, 12, FontStyle.Bold))
                .SubItems.Add(oPedidos("EMAIL") & " ", Color.Gray, lstPedidos.BackColor, New Font(lstPedidos.Font.Name, 12, FontStyle.Bold))
            End With
        End While

        oPedidos.Close()


    End Sub

    Private Sub cmdFechar_Click(sender As System.Object, e As System.EventArgs)
        Close()
    End Sub

  Private Sub lstPedidos_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles lstPedidos.MouseClick

    If lstPedidos.SelectedItems.Count > 0 Then
      frmEncerrarPedido.Show()
    End If

  End Sub

    Private Sub cmdFechar_Click_1(sender As System.Object, e As System.EventArgs) Handles cmdFechar.Click

        Close()

    End Sub

    Private Sub lstRecentes_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstRecentes.SelectedIndexChanged

    End Sub
End Class