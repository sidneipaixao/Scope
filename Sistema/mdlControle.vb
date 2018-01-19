Module mdlControle

    Public Structure tCaixa
        Dim Situacao As Boolean
        Dim Horario As Date
        Dim Usuario As Integer
    End Structure

    Public rCaixa As tCaixa

    Public Function fnCaixaAberto() As Boolean

        Dim lAguardar As Boolean

        If Not rCaixa.Situacao Then
            If MessageBox.Show("A abertura de turno ainda não foi realizada." & vbNewLine & "Deseja efetuar a abertura agora?", "Turno não iniciado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                With frmAbrirTurno
                    '.MdiParent = frmPrincipal
                    .Show()
                    lAguardar = True
                    While lAguardar
                        lAguardar = False
                        For Each oFormulario In Application.OpenForms
                            If TypeOf oFormulario Is frmAbrirTurno Then
                                lAguardar = True
                            End If
                        Next
                        Application.DoEvents()
                    End While
                End With
            End If
        End If

        Return rCaixa.Situacao

    End Function

    Public Function fnObtemConfig(ByVal cItem As String) As String

        Dim oArquivo As New System.Xml.XmlDocument
        Dim oDados As System.Xml.XmlNodeList
        Dim cAux As String = ""

        oArquivo.Load("../../My Project/settings.xml")

        Select Case cItem
            Case "MainConnection"
                oDados = oArquivo.DocumentElement.SelectNodes("/Scope/MainDatabase")
                cAux = "DATA SOURCE=" & oDados(0).SelectSingleNode("Server").InnerText & ";"
                cAux += "INITIAL CATALOG=" & oDados(0).SelectSingleNode("Name").InnerText & ";"
                cAux += "USER ID=" & oDados(0).SelectSingleNode("User").InnerText & ";"
                cAux += "PASSWORD=" & fnDecriptaSenha(oDados(0).SelectSingleNode("CredentialType").InnerText, oDados(0).SelectSingleNode("Credential").InnerText)
            Case "MailAddress", "MailName", "MailRelay", "MailCredential"
                oDados = oArquivo.DocumentElement.SelectNodes("/Scope/EMail")
                If cItem = "MailCredential" Then
                    cAux = fnDecriptaSenha(oDados(0).SelectSingleNode("CredentialType").InnerText, oDados(0).SelectSingleNode("Credential").InnerText)
                Else
                    cAux = oDados(0).SelectSingleNode(cItem.Replace("Mail", "")).InnerText
                End If
            Case Else
                oDados = oArquivo.DocumentElement.SelectNodes("/Scope/General")
                cAux = oDados(0).SelectSingleNode(cItem).InnerText
        End Select

        Return cAux

    End Function

    Private Function fnDecriptaSenha(ByVal nModo As Integer, ByVal cSenha As String) As String

        Dim cAux As String = ""

        Select Case nModo
            Case 1
            Case Else
                cAux = cSenha
        End Select

        Return cAux

    End Function

End Module
