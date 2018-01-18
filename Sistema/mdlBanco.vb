Module mdlBanco

    Public oConexao As New SqlClient.SqlConnection
    Public oComando As New SqlClient.SqlCommand

    Public Function fnConectar() As Boolean

        Try

            oConexao.ConnectionString = fnObtemConfig("MainConnection")
            oConexao.Open()

            oComando.Connection = oConexao

            Return True

        Catch oErro As Exception

            MessageBox.Show(oErro.Source & vbNewLine & oErro.Message)
            Return False

        End Try

    End Function

    Public Function fnRetornaDados(ByVal cSQL As String) As SqlClient.SqlDataReader

        Dim oComando As New SqlClient.SqlCommand(cSQL, oConexao)
        Dim oDados As SqlClient.SqlDataReader

        Try

            If oConexao.State <> ConnectionState.Open Then
                fnConectar()
            End If
            oDados = oComando.ExecuteReader()

            Return oDados

        Catch oErro As Exception

            MessageBox.Show(oErro.Source & vbNewLine & oErro.Message)
            Return Nothing

        End Try

    End Function

End Module
