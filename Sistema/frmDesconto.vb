Public Class frmDesconto

    Dim nTotal As Double

    Private Sub fnCarregarPedido()

        nTotal = 0

        grdProdutos.Rows.Clear()

        For Each oGrupo As ListViewGroup In frmEncerrarPedido.oItens.Groups
            For Each oItem As ListViewItem In oGrupo.Items
                grdProdutos.Rows.Add(oItem.SubItems(0).Text, oItem.SubItems(1).Text, oItem.SubItems(2).Text, oItem.SubItems(3).Text, 0, FormatNumber(0), oItem.SubItems(3).Text)
                nTotal += CDbl(oItem.SubItems(3).Text)
            Next
        Next

        txtValorTotal.Text = FormatNumber(nTotal)

    End Sub

    Private Sub cmdFechar_Click(sender As System.Object, e As System.EventArgs) Handles cmdFechar.Click

        If MessageBox.Show("Tem certeza que deseja sair sem aplicar os descontos?", "Não aplicar descontos?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then

            txtValorTotal.Text = 0
            txtDescGeral.Text = FormatNumber(0)
            For nCont = 0 To grdProdutos.RowCount - 1

                grdProdutos(4, nCont).Value = 0
                grdProdutos(5, nCont).Value = FormatNumber(0)
                txtValorTotal.Text += FormatNumber(CDbl(grdProdutos(6, nCont).Value))

            Next
            Close()

        End If

    End Sub

    Private Sub frmDesconto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'NAO PODE MAXIMIZAR, SENAO COBRE BARRA DE TAREFAS DO WINDOWS, POR ISSO NAO USA WINDOWSTATE
        Top = 0
        Left = 0
        Width = Screen.GetWorkingArea(Me).Width
        Height = Screen.GetWorkingArea(Me).Height

        'DESENHA BORDA DO FORMULARIO
        BackgroundImage = New Bitmap(Width - 1, Height - 1)
        Graphics.FromImage(BackgroundImage).DrawRectangle(New Pen(Color.FromArgb(55, 65, 80)), New Rectangle(New Point(0, 0), Size))

        'CONFIGURANDO O LAYOUT DO GRID
        With grdProdutos

            .Columns(0).Width = (grdProdutos.Width * 10) / 100
            .Columns(1).Width = (grdProdutos.Width * 36) / 100
            .Columns(2).Width = (grdProdutos.Width * 10) / 100
            .Columns(3).Width = (grdProdutos.Width * 10) / 100
            .Columns(4).Width = (grdProdutos.Width * 16.5) / 100
            .Columns(5).Width = (grdProdutos.Width * 17) / 100
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(4).DefaultCellStyle.BackColor = Color.MediumAquamarine
            .Columns(5).DefaultCellStyle.BackColor = Color.MediumAquamarine
            .Columns(4).DefaultCellStyle.ForeColor = Color.White
            .Columns(5).DefaultCellStyle.ForeColor = Color.White

        End With

        fnCarregarPedido()

    End Sub

    Private Sub grdProdutos_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdProdutos.CellEndEdit

        'ROTINA QUE VERIFICA SE A COLUNA OPOSTA (PERCENT/MONETARIO) ESTA PREENCHIDO E APAGA O VALOR
        If e.ColumnIndex = 4 Then

            If IsNumeric(grdProdutos(4, grdProdutos.CurrentRow.Index).Value) = True Then

                Dim nDesconto As Double = CDbl(grdProdutos(4, grdProdutos.CurrentRow.Index).Value)
                grdProdutos(5, grdProdutos.CurrentRow.Index).Value = FormatNumber(0)
                grdProdutos(3, grdProdutos.CurrentRow.Index).Value = FormatNumber(grdProdutos(6, grdProdutos.CurrentRow.Index).Value - ((grdProdutos(6, grdProdutos.CurrentRow.Index).Value * nDesconto) / 100))

                txtValorTotal.Text = FormatNumber(0)
                For nCont = 0 To grdProdutos.RowCount - 1

                    txtValorTotal.Text = FormatNumber(CDbl(grdProdutos(3, nCont).Value) + CDbl(txtValorTotal.Text))

                Next

            ElseIf grdProdutos(4, grdProdutos.CurrentRow.Index).Value = "" Then

                grdProdutos(4, grdProdutos.CurrentRow.Index).Value = 0

            Else

                MessageBox.Show("Por favor digitar apenas valores númericos.", "Valor digitado inválido!.", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If


        Else

            If IsNumeric(grdProdutos(5, grdProdutos.CurrentRow.Index).Value) = True Then

                Dim nDesconto As Double = grdProdutos(5, grdProdutos.CurrentRow.Index).Value
                grdProdutos(4, grdProdutos.CurrentRow.Index).Value = 0
                grdProdutos(3, grdProdutos.CurrentRow.Index).Value = FormatNumber(grdProdutos(6, grdProdutos.CurrentRow.Index).Value - nDesconto)
                grdProdutos(5, grdProdutos.CurrentRow.Index).Value = FormatNumber(nDesconto)

                txtValorTotal.Text = FormatNumber(0)
                For nCont = 0 To grdProdutos.RowCount - 1

                    txtValorTotal.Text = FormatNumber(CDbl(grdProdutos(3, nCont).Value) + CDbl(txtValorTotal.Text))

                Next

            ElseIf grdProdutos(5, grdProdutos.CurrentRow.Index).Value = "" Then

                grdProdutos(5, grdProdutos.CurrentRow.Index).Value = FormatNumber(0)

            Else

                MessageBox.Show("Por favor digitar apenas valores númericos.", "Valor digitado inválido!.", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        End If

    End Sub

    Private Sub cmdCancelar_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancelar.Click

        If MessageBox.Show("Tem certeza que deseja sair sem aplicar os descontos?", "Não aplicar descontos?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then

            txtValorTotal.Text = 0
            txtDescGeral.Text = FormatNumber(0)
            For nCont = 0 To grdProdutos.RowCount - 1

                grdProdutos(4, nCont).Value = 0
                grdProdutos(5, nCont).Value = FormatNumber(0)
                txtValorTotal.Text += FormatNumber(grdProdutos(6, nCont).Value)

            Next
            Close()

        End If
    End Sub

    Private Sub txtDescGeral_Enter(sender As Object, e As System.EventArgs) Handles txtDescGeral.Enter

        If txtDescGeral.Text = 0 Then

            txtDescGeral.Text = ""

        End If

    End Sub

    Private Sub txtDescGeral_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDescGeral.TextChanged

        If IsNumeric(txtDescGeral.Text) = True Then

            Dim nValor As Double = 0

            For nCont = 0 To grdProdutos.RowCount - 1

                nValor += CDbl(grdProdutos(6, nCont).Value)

            Next

            Dim nDesconto As Double = CDbl(txtDescGeral.Text)
            Dim nTotal As Double = 0

            If optPercent.Checked Then

                nTotal = FormatNumber(nValor - ((nValor * nDesconto) / 100))

            Else

                nTotal = FormatNumber(nValor - nDesconto)
                txtDescGeral.Text = FormatNumber(txtDescGeral.Text)

            End If

            txtValorTotal.Text = FormatNumber(nTotal)

            For nCont = 0 To grdProdutos.RowCount - 1

                grdProdutos(4, nCont).Value = 0
                grdProdutos(5, nCont).Value = FormatNumber(0)

            Next

        ElseIf txtDescGeral.Text = "" Then

        Else

            MessageBox.Show("Por favor digitar apenas valores númericos.", "Valor digitado inválido!.", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If optPercent.Checked Then

                txtDescGeral.Text = 0

            Else

                txtDescGeral.Text = FormatNumber(0)

            End If

        End If

    End Sub

    Private Sub optMonetario_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optMonetario.CheckedChanged

        txtDescGeral.Text = FormatNumber(txtDescGeral.Text)

    End Sub

    Private Sub optPercent_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optPercent.CheckedChanged

        txtDescGeral.Text = CDbl(txtDescGeral.Text)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        txtValorTotal.Text = 0
        'APENAS FORCANDO ENTRAR NO EVENTO
        txtDescGeral.Text = ""
        txtDescGeral.Text = FormatNumber(0)
        For nCont = 0 To grdProdutos.RowCount - 1

            grdProdutos(4, nCont).Value = 0
            grdProdutos(5, nCont).Value = FormatNumber(0)
            grdProdutos(3, nCont).Value = grdProdutos(6, nCont).Value
            'txtValorTotal.Text += FormatNumber(grdProdutos(6, nCont).Value)

        Next

    End Sub

    Private Sub cmdAplicar_Click(sender As System.Object, e As System.EventArgs) Handles cmdAplicar.Click

        Dim lNegativo As Boolean = False

        For nCont = 0 To grdProdutos.RowCount - 1

            If grdProdutos(3, nCont).Value < 0 Then

                lNegativo = True

            End If

        Next

        If txtValorTotal.Text < 0 Then

            lNegativo = True

        End If

        If lNegativo Then

            MessageBox.Show("Por favor verifique os descontos aplicados, pois, não podem existir valores negativos.", "Valores negativos!.", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            MessageBox.Show("Descontos aplicados com sucesso!", "Descontos aplicados!.", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub
End Class