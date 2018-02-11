Public NotInheritable Class frmInicio

    Private Sub frmInicio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Application.DoEvents()
        If Not fnConectar() Then
            MessageBox.Show("Erro ao efetuar a conexão na base de dados. A aplicação não poderá continuar", "Conexão não estabelecida", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End

        Else

            Dim cSQL As String
            Dim oDados As SqlClient.SqlDataReader

            cSQL = "SELECT * " & _
                      " FROM CAIXA" & _
                      " WHERE CAXDTFECHAMENTO IS NULL"

            oComando.CommandText = cSQL
            oDados = oComando.ExecuteReader

            If oDados.Read Then
                rCaixa.Situacao = True
            End If

            oDados.Close()

        End If



    End Sub
End Class
