Imports System.Text
Imports System.Runtime.InteropServices

Namespace ComunicacaoSAT

    Public Class Daruma

        <DllImport("DarumaFramework.dll")> _
        Public Shared Function eVerificarVersaoDLL_Daruma(ByVal strRet As StringBuilder) As Integer
        End Function

        <DllImport("DarumaFrameWork.dll")> _
        Public Shared Function aCFAbrir_SAT_Daruma(ByVal strCPF As String, ByVal strNome As String, ByVal strEndereco As String) As Integer
        End Function

        <DllImport("DarumaFrameWork.dll")> _
        Public Shared Function aCFVender_SAT_Daruma(ByVal strCargaTributaria As String, ByVal strQuantidade As String, ByVal strPrecoUnitario As String, ByVal strTipoDescAcresc As String, ByVal strValorDescAcresc As String, ByVal strCodigoItem As String, ByVal strUnidadeMedida As String, ByVal strDescricaoItem As String) As Integer
        End Function

        <DllImport("DarumaFrameWork.dll")> _
        Public Shared Function aCFTotalizar_SAT_Daruma(ByVal strTipoDescAcresc As String, ByVal strValorDescAcresc As String) As Integer
        End Function

        <DllImport("DarumaFrameWork.dll")> _
        Public Shared Function aCFEfetuarPagamento_SAT_Daruma(ByVal strFormaPgto As String, ByVal strValor As String, ByVal strInfoAdicional As String) As Integer
        End Function

        <DllImport("DarumaFrameWork.dll")> _
        Public Shared Function tCFEncerrar_SAT_Daruma(ByVal strCupomAdicional As String, ByVal strInfoAdic As String) As Integer
        End Function

        <DllImport("DarumaFrameWork.dll")> _
        Public Shared Function tCFeCancelar_SAT_Daruma() As Integer
        End Function

    End Class

End Namespace

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
            Case "LegacyConnection"
                oDados = oArquivo.DocumentElement.SelectNodes("/Scope/LegacyDatabase")
                cAux = "Persist Security Info=False;DATA SOURCE=" & oDados(0).SelectSingleNode("Server").InnerText & ";"
                cAux += "PORT=" & oDados(0).SelectSingleNode("Port").InnerText & ";"
                cAux += "DATABASE=" & oDados(0).SelectSingleNode("Name").InnerText & ";"
                cAux += "USERNAME=" & oDados(0).SelectSingleNode("User").InnerText & ";"
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

    Public Function fnCPFValido(ByVal cCPF As String) As Boolean
        Dim cBase As String
        Dim cDigito As String
        Dim d As String
        Dim D_aux As Long
        Dim i As Long, J As Long, xx As Long, SOMA As Long

        '**** Rotina de verificação de validade do CPF
        cCPF = Trim(cCPF)
        If Len(cCPF) = 11 Then
            cBase = Left(cCPF, 9)
            cDigito = Right(cCPF, 2)
            For i = 1 To 2
                xx = 2
                SOMA = 0
                For J = Len(cBase) To 1 Step -1
                    SOMA = SOMA + Val(Mid(cBase, J, 1)) * xx
                    xx = xx + 1
                Next J

                D_aux = 11 - (SOMA Mod 11)
                d = Left(Trim(Str(IIf(D_aux >= 10, 0, D_aux))), 1)
                cBase = cBase + d
            Next i
            If Right(cBase, 2) = cDigito Then
                Return True
            Else

                MessageBox.Show("Este numero de CPF não é válido. Por favor tente novamente.", "CPF Inválido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False

            End If
        Else
            Return False
        End If
    End Function

End Module
