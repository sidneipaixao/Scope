Module mdlBanco

    Public oConexao As New SqlClient.SqlConnection
    Public oConMySQL As New MySql.Data.MySqlClient.MySqlConnection
    Public oComando As New SqlClient.SqlCommand

    Public Function fnConectar() As Boolean

        Try

            oConexao.ConnectionString = fnObtemConfig("MainConnection")
            oConMySQL.ConnectionString = fnObtemConfig("LegacyConnection")
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

    Public Function fnRetornaDadosMySQL(ByVal cSQL As String) As MySql.Data.MySqlClient.MySqlDataReader

        Dim oComando As New MySql.Data.MySqlClient.MySqlCommand(cSQL, oConMySQL)
        Dim oDados As MySql.Data.MySqlClient.MySqlDataReader

        Try

            If oConexao.State <> ConnectionState.Open Then
                oConMySQL.Open()
            End If

            oDados = oComando.ExecuteReader()

            Return oDados

        Catch oErro As Exception

            MessageBox.Show(oErro.Source & vbNewLine & oErro.Message)
            Return Nothing

        End Try

    End Function

End Module
