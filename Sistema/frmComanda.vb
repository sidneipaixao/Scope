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
                frmEncerrarPedido.Close()

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
        Panel1.Focus()

    End Sub

    Private Sub cmdFechar_Click(sender As System.Object, e As System.EventArgs) Handles cmdFechar.Click

        Close()

    End Sub
End Class