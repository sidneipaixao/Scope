Public NotInheritable Class frmInicio

    Private Sub frmInicio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Application.DoEvents()
        If Not fnConectar() Then
            MessageBox.Show("Erro ao efetuar a conexão na base de dados. A aplicação não poderá continuar", "Conexão não estabelecida", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End
        End If

    End Sub

End Class
