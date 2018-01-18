Module mdlBanco

    Public oConexao As New SqlClient.SqlConnection
    Public oComando As New SqlClient.SqlCommand

  Public Function fnConectar() As Boolean

        oConexao.ConnectionString = "DATA SOURCE=.\KPMS; INITIAL CATALOG=SCOPE; UID=sa; PASSWORD=abc123@"
        oConexao.Open()

        oComando.Connection = oConexao

    Return True

  End Function

  Public Function fnRetornaDados(ByVal cSQL As String) As SqlClient.SqlDataReader

    Dim oComando As New SqlClient.SqlCommand(cSQL, oConexao)
    Dim oDados As SqlClient.SqlDataReader

    'fnConectar()
    oDados = oComando.ExecuteReader()

    Return oDados

  End Function

End Module
