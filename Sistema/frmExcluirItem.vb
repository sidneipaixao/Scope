Public Class frmExcluirItem

    Public cFuncao As String

  Private Sub frmExcluir_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    BackgroundImage = New Bitmap(Width - 1, Height - 1)
    Graphics.FromImage(BackgroundImage).DrawRectangle(New Pen(Color.FromArgb(55, 65, 80)), New Rectangle(New Point(0, 0), Size))

        Dim oCon As New MySql.Data.MySqlClient.MySqlConnection

        'ROTINA RESPONSAVEL POR CONECTAR NA BASE MYSQL, BUSCAR USUÁRIOS E POPULAR O COMBO
        oCon.ConnectionString = "Persist Security Info=False;datasource=admlojas.dyndns.org;port=3307;username=vb;password=vb;database=Lpc_production"
        oCon.Open()

        'CARREGA O COMBO UTILIZANDO DATASET AO INVES DO DATAREADER
        'COM ISSO, OUTROS CAMPOS (ALEM DOS EXIBIDOS) PODERAO SER MANIPULADOS
        'Dim oMySQLCmd As New MySql.Data.MySqlClient.MySqlCommand("SELECT users.USERNAME, users.NOME, users.ID FROM users INNER JOIN userroles ON userroles.USER_ID = users.ID WHERE userroles.ROLE_ID IN (1, 2, 3)", oCon)
        'Dim oTeste As New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM roles", oCon)
        'Dim oUsr As MySql.Data.MySqlClient.MySqlDataReader = oMySQLCmd.ExecuteReader
        Dim oUsrAux As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT users.USERNAME, users.ENCRYPTED_PASSWORD, users.ID FROM users INNER JOIN userroles ON userroles.USER_ID = users.ID WHERE userroles.ROLE_ID IN (1, 2, 3)", oCon)
        Dim oUsr As New DataSet

        'While oTstRD.Read

        'cbxUsuario.Items.Add(oTstRD("USERNAME"))
        'cbxUsuario.Items.Item(cbxUsuario.Items.Count - 1).Tag = 0

        'End While

        'CONFIGURA OS CAMPOS PARA EXIBICAO
        cbxUsuario.ValueMember = "ID"
        cbxUsuario.DisplayMember = "USERNAME"

        'TRAZ OS DADOS PARA A MEMORIA E CARREGA O COMBO
        oUsrAux.Fill(oUsr)
        cbxUsuario.DataSource = oUsr.Tables(0)

        'LIBERA A MEMORIA E FECHA A CONEXAO
        oUsrAux.Dispose()
        oCon.Close()

  End Sub

  Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click

        Close()
        cFuncao = "recusar"

  End Sub

    Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click

        'Verifica qual a função foi chamada analisando o valor passado na chamada do form na Tag deste
        If cFuncao = "incluir.qtde" Then

            cFuncao = "confirmar"
            Close()

        ElseIf cFuncao = "excluir.item" Then

            'Dim oDados As SqlClient.SqlDataReader = fnRetornaDados("SELECT 'admin' senha")
            '
            'oDados.Read()
            '
            'If txtSenha.Text = oDados("senha") Then
            '
            '    Tag = "confirmar"
            '    Close()
            '
            'Else
            '
            '    MessageBox.Show("Senha incorreta! Tente novamente.", "Dado incorreto!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Tag = "recusar"
            '
            'End If
            '
            'oDados.Close()

            Dim oSenha As New BCrypt.Net.BCrypt

            If oSenha.Verify(txtSenha.Text, cbxUsuario.SelectedItem(1)) Then
                cFuncao = "confirmar"
                Close()
            Else
                MessageBox.Show("Senha incorreta! Tente novamente.", "Dado incorreto!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cFuncao = "recusar"
            End If

        End If

  End Sub

    Private Sub cmdFechar_Click_1(sender As System.Object, e As System.EventArgs) Handles cmdFechar.Click

        Close()
        cFuncao = "recusar"

    End Sub
End Class