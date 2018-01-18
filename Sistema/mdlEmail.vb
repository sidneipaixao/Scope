Imports System.Net

Module mdlEmail

    Public Function fnEnviarEmail(ByVal cAssunto As String, ByVal cTexto As String, Optional ByVal cTipo As Integer = 1) As Boolean

        Dim oMail As New Mail.MailMessage
        Dim oEnvio As New Mail.SmtpClient
        Dim cHTML As String

        Try

            For Each cEmail As String In fnRetornaEmailGrupo(1)
                oMail.To.Add(cEmail)
            Next

            oMail.From = New Mail.MailAddress("scope.kpms@gmail.com", "Alertas - Scope")
            oMail.Subject = cAssunto
            oMail.IsBodyHtml = True

            cHTML = "<table style=""width: 80%; min-width: 600px; margin: auto; font-face: sans-serif"">" & _
                    "  <tr><td><img alt=""logotipo"" src=""cid:logotipo"" style=""width: 100px; height: 29px""></td></tr>" & _
                    "  <tr><td valign=""bottom"" style=""background-color: #CCCC33; color: #FFFFFF; font-size: 20px"">" & _
                    "        <label style=""display: inline-block; padding: 30px 10px 10px 10px"">" & cAssunto & _
                    "        </label><img alt=""icone"" src=""cid:tipomsg"" style=""width: 64px; height: 64px; float: right""></td></tr>" & _
                    "  <tr><td style=""padding: 10px"">" & cTexto & "</td></tr>" & _
                    "  <tr><td style=""background-color: #CCCC33; color: #FFFFFF; text-align: center"">mensagem gerada em " & Now & "</td></tr>" & _
                    "</table>"
            oMail.Body = cHTML

            'C:\Users\Miner\Documents\Visual Studio 2010\Projects\Scope\Sistema\imgs
            Dim oCorpoMsg As Mail.AlternateView = Mail.AlternateView.CreateAlternateViewFromString(oMail.Body, Nothing, "text/html")
            Dim oImagem(1) As Mail.LinkedResource

            oImagem(0) = New Mail.LinkedResource("..\..\imgs\TITULO.PNG", "image/jpg")
            oImagem(1) = New Mail.LinkedResource("..\..\imgs\ICONE2.PNG", "image/jpg")
            oImagem(0).ContentId = "logotipo"
            oImagem(1).ContentId = "tipomsg"
            oImagem(0).TransferEncoding = System.Net.Mime.TransferEncoding.Base64
            oImagem(1).TransferEncoding = System.Net.Mime.TransferEncoding.Base64

            oCorpoMsg.LinkedResources.Add(oImagem(0))
            oCorpoMsg.LinkedResources.Add(oImagem(1))

            oMail.AlternateViews.Add(oCorpoMsg)

            oEnvio.Host = "smtp.gmail.com"
            oEnvio.Credentials = New NetworkCredential("scope.kpms@gmail.com", "admkpms18")
            oEnvio.EnableSsl = True

            oEnvio.Send(oMail)

        Catch oErro As Exception

            MessageBox.Show("Erro ao executar a rotina de envio de mensagens." & vbNewLine & _
                            oErro.Message, "Erro ao enviar email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False

        End Try

        Return True

    End Function

    Private Function fnRetornaEmailGrupo(ByVal nGrupo As Integer) As String()

        Dim oEnderecos() As String

        oEnderecos.Resize(oEnderecos, 2)
        oEnderecos(0) = "sidneipaixao@gmail.com"
        oEnderecos(1) = "feefagiolo@gmail.com"

        Return oEnderecos

    End Function

End Module
