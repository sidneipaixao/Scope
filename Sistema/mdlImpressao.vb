Module mdlImpressao

    Public Function fnImprimeResumo(Optional ByVal dData As Date = Nothing, Optional ByVal nTurno As Byte = 0) As String

        Dim cRelatorio As New System.Text.StringBuilder

        With cRelatorio
            .AppendLine("<ce>K FAST FOOD COM. DE ALIMENTOS LTDA EPP</ce>")
            .AppendLine("<tc>*</tc>")
            .appendline("<ce><e>FECHAMENTO CAIXA - TURNO MANHA</e></ce>")
            .appendline("<l></l>")
            .appendline("Data: 02/02/2018       Hora: 16:12:23")
            .appendline("<l></l>")
            .AppendLine("Supervisor: " & "NICE")
            .appendline("Caixa:      " & "NICE")
            .appendline("<l></l>")
            .appendline("<l></l>")
            .appendline("<tc>*</tc>")
            .appendline("<ce><e>RESUMO DAS OPERACOES DO TURNO</e></ce>")
            .appendline("<l></l>")

            'LER BASE DE DADOS
            .appendline("<n>CAIXA</n>")
            .AppendLine("<n><tb></tb>TROCO INICIAL (+):<ad>400,00</ad></n>")
            .AppendLine("<n><tb></tb>VENDAS....... (+):<ad>5431,00</ad></n>")
            .AppendLine("<n><tb></tb>TROCO FINAL.. (-):<ad>400,00</ad></n>")
            .AppendLine("<n><tb></tb>TOTAL GERAL...(=):<ad>5431,00</ad></n>")
            .appendline("<l></l>")
            .appendline("<l></l>")

            'DETALHAMENTO, LER FORMAS DE PAGAMENTO
            .appendline("<ce>DETALHAMENTO POR TIPO DE MOEDA</ce>")
            'LER DO BANCO TAMBEM
            .appendline("<n>Dinheiro.......: <ad>0,80</ad></n>")
            .appendline("<n>JegueCard......: <ad>30,00</ad></n>")
            .appendline("<n>MortesCard.....: <ad>5400,20</ad></n>")
            .appendline("<l></l>")
            .appendline("<n>TOTAL DE VENDAS: <ad>5431,00</ad></n>")

            'ITENS EXCLUIDOS
            .appendline("<c>CODIGO DESCRICAO ITEM                   PEDIDO</c>")
            .appendline("<c>------ -------------------------------- ----------</c>")
            'LER DO BANCO TAMBEM
            .appendline("<c>    20 ARROZ BRANCO                         597761</c>")
            .appendline("<c>199876 ARROZ IRLANDES COM PARMESAO GRAT     597768</c>")
            .appendline("<c>   501 AGUA SULFOROSA                       597768</c>")

            'FINALIZACAO RELATORIO
            .appendline("<tc>*</tc>")
            .appendline("<ce>CONFERENCIA DE CAIXA</ce>")
            .appendline("<tc>*</tc>")
            .appendline("<l></l>")
            .appendline("<l></l>")
            .appendline("<n>Caixa: <tc>_</tc></n>")
            .appendline("<l></l>")
            .appendline("<l></l>")
            .appendline("<n>Caixa (troco): <tc>_</tc></n>")
            .appendline("<l></l>")
            .appendline("<l></l>")
            .appendline("<n>Supervisor: <tc>_</tc></n>")

            .appendline("<tc>=</tc>")
            .appendline("<ce><c>Relatorio impresso em</c> <dt></dt> <hr></hr></ce>")
            .appendline("<gui></gui>")

        End With

        Return cRelatorio.ToString

    End Function

    Public Function fnImprimeComissao(Optional ByVal dData As Date = Nothing, Optional ByVal nCodFunc As Integer = 0) As String

        Dim cRelatorio As New System.Text.StringBuilder

        With cRelatorio
            .appendline("<ce>K FAST FOOD COM. DE ALIMENTOS LTDA EPP</ce>")
            .appendline("<tc>*</tc>")
            .appendline("<ce><e>FECHAMENTO CAIXA - TURNO MANHA</e></ce>")
            .appendline("<l></l>")
            .appendline("Data: 02/02/2018       Hora: 16:12:23")
            .appendline("<l></l>")
            .appendline("Supervisor: " & "NICE")
            .appendline("Caixa:      " & "NICE")
            .appendline("<l></l>")
            .appendline("<l></l>")
            .appendline("<tc>*</tc>")
            .appendline("<ce><e>RESUMO DAS OPERACOES DO TURNO</e></ce>")
            .appendline("<l></l>")

            'LER BASE DE DADOS
            .appendline("<n>CAIXA</n>")
            .AppendLine("<n><tb></tb>TROCO INICIAL (+):<ad>400,00</ad></n>")
            .AppendLine("<n><tb></tb>VENDAS....... (+):<ad>5431,00</ad></n>")
            .AppendLine("<n><tb></tb>TROCO FINAL.. (-):<ad>400,00</ad></n>")
            .AppendLine("<n><tb></tb>TOTAL GERAL...(=):<ad>5431,00</ad></n>")
            .appendline("<l></l>")
            .appendline("<l></l>")

            'DETALHAMENTO, LER FORMAS DE PAGAMENTO
            .appendline("<ce>DETALHAMENTO POR TIPO DE MOEDA</ce>")
            'LER DO BANCO TAMBEM
            .appendline("<n>Dinheiro.......: <ad>0,80</ad></n>")
            .appendline("<n>JegueCard......: <ad>30,00</ad></n>")
            .appendline("<n>MortesCard.....: <ad>5400,20</ad></n>")
            .appendline("<l></l>")
            .appendline("<n>TOTAL DE VENDAS: <ad>5431,00</ad></n>")

            'ITENS EXCLUIDOS
            .appendline("<c>CODIGO DESCRICAO ITEM                   PEDIDO</c>")
            .appendline("<c>------ -------------------------------- ----------</c>")
            'LER DO BANCO TAMBEM
            .appendline("<c>    20 ARROZ BRANCO                         597761</c>")
            .appendline("<c>199876 ARROZ IRLANDES COM PARMESAO GRAT     597768</c>")
            .appendline("<c>   501 AGUA SULFOROSA                       597768</c>")

            'FINALIZACAO RELATORIO
            .appendline("<tc>*</tc>")
            .appendline("<ce>CONFERENCIA DE CAIXA</ce>")
            .appendline("<tc>*</tc>")
            .appendline("<l></l>")
            .appendline("<l></l>")
            .appendline("<n>Caixa: <tc>_</tc></n>")
            .appendline("<l></l>")
            .appendline("<l></l>")
            .appendline("<n>Supervisor: <tc>_</tc></n>")

            'RELACAO DAS COMISSOES
            .appendline("<tc>*</tc>")
            .appendline("<ce>COMISSIONAMENTO DE CANARIOS</ce>")
            .appendline("<tc>*</tc>")
            .appendline("<l></l>")
            'LER DO BANCO, DESCOBRIR REGRA
            .appendline("<c>CODIGO FUNCIONARIO                    VLR COMISSAO</c>")
            .appendline("<c>------ ------------------------------ ------------</c>")
            .appendline("<c>     1 ANASTASIANA                           35,70</c>")
            .appendline("<c>    76 WANDERGLEYDSOM                         8,68</c>")
            .appendline("<l></l>")
            .appendline("<l></l>")

            .appendline("<tc>=</tc>")
            .appendline("<ce><c>Relatorio impresso em</c> <dt></dt> <hr></hr></ce>")
            .appendline("<gui></gui>")

        End With

        Return cRelatorio.ToString

    End Function

    Public Function fnImprimeFidelidade(ByVal nPedido As Integer) As String

        Dim cRelatorio As New System.Text.StringBuilder

        With cRelatorio
            .appendline("<ce><e><da>FIDELIDADE</da></e></ce>")
            .appendline("<l></l>")
            .appendline("<ce>K FAST FOOD COM. DE ALIMENTOS LTDA EPP</ce>")
            .appendline("<l></l>")
            .appendline("<e><b>Valor resgatado: <ad>R$ 15,90</ad></b></e>")
            .appendline("<e>Valor acumulado: <ad>R$ 16,90</ad></e>")
            .appendline("<l></l>")
            .appendline("<n>Email cadastrado: <b>cliente@servidor.com</b></n>")
            .appendline("<l></l>")
            .appendline("<l></l>")
            .appendline("<tc>_</tc>")
            .appendline("<n>Assinatura do cliente</n>")
            .appendline("<l></l>")

            .appendline("<tc>=</tc>")
            .appendline("<ce><c>Relatorio impresso em</c> <dt></dt> <hr></hr></ce>")
            .appendline("<gui></gui>")

        End With

        Return cRelatorio.ToString

    End Function

    Public Function fnImprimePedido(ByVal nPedido As Integer, Optional ByVal lCompleto As Boolean = False) As String

        Dim cRelatorio As New System.Text.StringBuilder

        With cRelatorio

            If lCompleto Then
                .appendline("<ce><e>LPC Comercio de alimentos LTDA.</e></ce>")
                .appendline("<ce>Av. Kennedy, 700 - Lj 335 - Jd. do Mar</ce>")
                .appendline("<ce>Sao Bernardo do Campo - CEP 00000-000</ce>")
                .appendline("<ce>CNPJ 00.000.000/0001-00    -    IE 000000000000</ce>")
                .appendline("<l></l>")
            End If

            .appendline("<tc>-</tc>")
            .appendline("<ce><dt></dt> - <e><hr></hr></e></ce>")
            .appendline("<tc>-</tc>")
            .appendline("<ce><e> P E D I D O </e></ce>")
            .appendline("<ce><i><c>NAO E DOCUMENTO FISCAL</c></i></ce>")
            .appendline("<l></l>")

            If lCompleto Then
                .appendline("<c>ITEM CODIGO DESCRICAO <ad>QTD x VLR.UND = VLR.ITEM</ad></c>")
            Else
                .appendline("<c>ITEM    CODIGO    DESCRICAO</c>")
            End If

            .appendline("<tc>-</tc>")

            'LER BANCO DE DADOS
            .appendline("<c>0001     20 ESPETO FRANGO COM BACON E ESCAROLA ASSADA</c>")
            If lCompleto Then .appendline("<tb></tb>1.000 x               14.96 =            14.96")
            .appendline("<c>0002   1996 ARROZ BRANCO</c>")
            If lCompleto Then .appendline("<tb></tb>1.000 x                0.01 =             0.01")
            .appendline("<c>0003   1998 BATATA PALHA</c>")
            If lCompleto Then .appendline("<tb></tb>1.000 x                0.01 =             0.01")
            .appendline("<c>0004     20 MINI SALADA COM RUCULA DESFOLHADA E TOMATE CEREJA AO MOLHO MOSTARDA COM BATATA DESOSSADA</c>")
            If lCompleto Then .appendline("<tb></tb>1.000 x                0.01 =             0.01")
            .appendline("<tc>-</tc>")

            If lCompleto Then
                .appendline("<b><e>TOTAL <ad>R$ 15,00</ad></e></b>")
                .appendline("<n><e>Credito <ad>R$ 12,50</ad></e></n>")
                .appendline("<n><e>Dinheiro <ad>R$ 2,50</ad></e></n>")
                .appendline("<tc>-</tc>")
            End If

            .appendline("<l></l>")
            .appendline("<ce><e><n><da>Comanda: 72</da></n></e></ce>")
            .appendline("<l></l>")

            .appendline("<n>Operador: nomedooperador</n>")
            .appendline("<n>Senha WIFI: picanha200</n>")
            .appendline("<c>Controle interno: <dt></dt><hr></hr> Canario01</c>")
            .appendline("<l></l>")
            .appendline("<tc>-</tc>")
            .appendline("<n><ce>Agradecemos a preferência! Volte sempre!</ce></n>")
            .appendline("<l></l>")
            .appendline("<gui></gui>")

        End With

        Return cRelatorio.ToString

    End Function

End Module
