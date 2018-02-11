Public Class frmAbrirTurno

  Private Sub frmAbrirTurno_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    'ESCONDE BARRA DE PROGRESSO AO FECHAR FORMULARIO
    frmPrincipal.objProgresso.Visible = False

  End Sub

  Private Sub frmExemplo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    'DESENHA BORDA DO FORMULARIO
    BackgroundImage = New Bitmap(Width - 1, Height - 1)
        Graphics.FromImage(BackgroundImage).DrawRectangle(New Pen(Color.FromArgb(55, 65, 80)), New Rectangle(New Point(0, 0), Size))

    'EXIBE BARRA DE PROGRESSO TEMPORARIAMENTE
        frmPrincipal.objProgresso.Visible = True

        'ALTERA AS CARACTERISTICAS DO FORMULARIO PARA ABERTURA OU ENCERRAMENTO DE TRUNO
        If rCaixa.Situacao Then

            lblTitulo.Text = "Fechamento de Turno"
            cmdEntrar.Text = "Fechar Turno"
            cmdEntrar.BackColor = Color.IndianRed

        Else

            lblTitulo.Text = "Abertura de Turno"
            cmdEntrar.Text = "Abrir Turno"
            cmdEntrar.BackColor = Color.LightSeaGreen

        End If

  End Sub

  Private Sub cmdEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEntrar.Click

        'ROTINA RESPONSAVEL POR CONECTAR NA BASE MYSQL, BUSCAR USUÁRIOS E VERIFICAR SENHA
        Dim oCon As New MySql.Data.MySqlClient.MySqlConnection
        oCon.ConnectionString = "Persist Security Info=False;datasource=admlojas.dyndns.org;port=3307;username=vb;password=vb;database=Lpc_production"
        oCon.Open()

        Dim oMySQLCmd As New MySql.Data.MySqlClient.MySqlCommand("SELECT users.encrypted_password SENHA, users.ID ID FROM users INNER JOIN userroles ON userroles.USER_ID = users.ID WHERE users.USERNAME = '" & txtUsuario.Text & "'", oCon)
        Dim oUsr As MySql.Data.MySqlClient.MySqlDataReader = oMySQLCmd.ExecuteReader

        Dim oSenha As New BCrypt.Net.BCrypt

        If oUsr.Read Then

            If oSenha.Verify(txtSenha.Text, oUsr("SENHA")) Then

                'TRECHO RESPONSAVEL POR GRAVAR NA BASE AS INFORMAÇÕES DE ABERTURA DO CAIXA
                Dim cSQL As String

                'ESTE TRECHO VERIFICA SE A VARIAVEL rCaixa.Situacao E' TRUE, OU SEJA, SE JA' EXISTE TURNO ABERTO
                If rCaixa.Situacao Then

                    Try

                        cSQL = "UPDATE CAIXA " & _
                               " SET CAXDTFECHAMENTO = CONVERT(DATETIME, GETDATE(),103), " & _
                               "     CAXUSRFECHAMENTO = " & oUsr("ID") & ", " & _
                               "     CAXVLRFINAL = " & txtValorFim.Value.ToString.Replace(",", ".") & _
                               " WHERE CAXCODIGO = (SELECT CAXCODIGO FROM CAIXA WHERE CAXDTFECHAMENTO IS NULL)"

                        oComando.CommandText = cSQL
                        oComando.ExecuteNonQuery()

                        Close()
                        rCaixa.Situacao = False

                        MessageBox.Show("Turno encerrado com Sucesso. Obrigado!", "Turno encerrado!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Catch

                        MessageBox.Show("Problemas ao registrar o fechamento do turno! Tente novamente e se o problema persistir entre em contato com o administrador do sistema." _
                                        & vbNewLine & Err.Number & " - " & Err.Description, "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    End Try

                    oUsr.Close()

                Else

                    Try

                        cSQL = "INSERT INTO CAIXA(CAXUSRABERTURA, CAXVLRINICIAL, CAXDTABERTURA)" & _
                                " VALUES({0}, {1}, CONVERT(DATETIME, {2},103))"

                        cSQL = String.Format(cSQL, oUsr("ID"), txtValorIni.Value.ToString.Replace(",", "."), "GETDATE()")

                        oComando.CommandText = cSQL
                        oComando.ExecuteNonQuery()

                        oUsr.Close()
                        rCaixa.Situacao = True
                        Close()

                    Catch

                        MessageBox.Show("Problemas ao registrar a abertura do turno! Tente novamente e se o problema persistir entre em contato com o administrador do sistema." _
                                       & vbNewLine & Err.Number & " - " & Err.Description, "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    End Try

                End If

            Else

                MessageBox.Show("Usuário ou senha inválidos, tente novamente.", "Credencial inválida", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Else

            MessageBox.Show("Usuário ou senha inválidos, tente novamente.", "Credencial inválida", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        oUsr.Close()

        ''VALIDA USUARIO E SENHA INFORMADOS
        'If oDados.Read Then

        'Else
        '    oDados.Close()
        '    MessageBox.Show("Usuário ou senha inválidos, tente novamente.", "Credencial inválida", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If

        ''Dim oDados As SqlClient.SqlDataReader = fnRetornaDados("SELECT 1 USRCODIGO, 'Administrador' USRNOME WHERE 'ADMIN' = '" & txtUsuario.Text & "' AND '12345' = '" & txtSenha.Text & "'")

        ' ''VALIDA USUARIO E SENHA INFORMADOS
        ''If oDados.Read Then
        ''    rCaixa.Situacao = True
        ''    oDados.Close()
        ''    Close()
        ''Else
        ''    oDados.Close()
        ''    MessageBox.Show("Usuário ou senha inválidos, tente novamente.", "Credencial inválida", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ''End If

    End Sub

    Private Sub cmdFechar_Click(sender As System.Object, e As System.EventArgs) Handles cmdFechar.Click

        Close()

    End Sub
End Class