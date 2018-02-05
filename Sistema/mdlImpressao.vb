Module mdlImpressao

    Public Function fnImprimeResumo(Optional ByVal dData As Date = Nothing, Optional ByVal nTurno As Byte = 0) As String

        Dim cRelatorio As New System.Text.StringBuilder

        With cRelatorio
            .Append("<ce>K FAST FOOD COM. DE ALIMENTOS LTDA EPP</ce>")
            .Append("<tc>*</tc>")
            .Append("<ce><e>FECHAMENTO CAIXA - TURNO MANHA</e></ce>")
            .Append("<l></l>")
            .Append("Data: 02/02/2018       Hora: 16:12:23")
            .Append("<l></l>")
            .Append("Supervisor: " & "NICE")
            .Append("Caixa:      " & "NICE")
            .Append("<l></l>")
            .Append("<l></l>")
            .Append("<tc>*</tc>")
            .Append("<ce><e>RESUMO DAS OPERACOES DO TURNO</e></ce>")
            .Append("<l></l>")

            'LER BASE DE DADOS
            .Append("<n>CAIXA</n>")
            .Append("<n><t></tb>TROCO INICIAL (+):<ad>400,00</ad></n>")
            .Append("<n><t></tb>VENDAS....... (+):<ad>5431,00</ad></n>")
            .Append("<n><t></tb>TROCO FINAL.. (-):<ad>400,00</ad></n>")
            .Append("<n><t></tb>TOTAL GERAL...(=):<ad>5431,00</ad></n>")
            .Append("<l></l>")
            .Append("<l></l>")

            'DETALHAMENTO, LER FORMAS DE PAGAMENTO
            .Append("<ce>DETALHAMENTO POR TIPO DE MOEDA</ce>")
            'LER DO BANCO TAMBEM
            .Append("<n>Dinheiro.......: <ad>0,80</ad></n>")
            .Append("<n>JegueCard......: <ad>30,00</ad></n>")
            .Append("<n>MortesCard.....: <ad>5400,20</ad></n>")
            .Append("<l></l>")
            .Append("<n>TOTAL DE VENDAS: <ad>5431,00</ad></n>")

            'ITENS EXCLUIDOS
            .Append("<c>CODIGO DESCRICAO ITEM                   PEDIDO</c>")
            .Append("<c>------ -------------------------------- ----------</c>")
            'LER DO BANCO TAMBEM
            .Append("<c>    20 ARROZ BRANCO                         597761</c>")
            .Append("<c>199876 ARROZ IRLANDES COM PARMESAO GRAT     597768</c>")
            .Append("<c>   501 AGUA SULFOROSA                       597768</c>")

            'FINALIZACAO RELATORIO
            .Append("<tc>*</tc>")
            .Append("<ce>CONFERENCIA DE CAIXA</ce>")
            .Append("<tc>*</tc>")
            .Append("<l></l>")
            .Append("<l></l>")
            .Append("<n>Caixa: <tc>_</tc></n>")
            .Append("<l></l>")
            .Append("<l></l>")
            .Append("<n>Caixa (troco): <tc>_</tc></n>")
            .Append("<l></l>")
            .Append("<l></l>")
            .Append("<n>Supervisor: <tc>_</tc></n>")

            .Append("<tc>=</tc>")
            .Append("<ce><c>Relatorio impresso em</c> <dt></dt> <hr></hr></ce>")
            .Append("<gui></gui>")

        End With

        Return cRelatorio.ToString

    End Function

    Public Function fnImprimeComissao(Optional ByVal dData As Date = Nothing, Optional ByVal nCodFunc As Integer = 0) As String

        Dim cRelatorio As New System.Text.StringBuilder

        With cRelatorio
            .Append("<ce>K FAST FOOD COM. DE ALIMENTOS LTDA EPP</ce>")
            .Append("<tc>*</tc>")
            .Append("<ce><e>FECHAMENTO CAIXA - TURNO MANHA</e></ce>")
            .Append("<l></l>")
            .Append("Data: 02/02/2018       Hora: 16:12:23")
            .Append("<l></l>")
            .Append("Supervisor: " & "NICE")
            .Append("Caixa:      " & "NICE")
            .Append("<l></l>")
            .Append("<l></l>")
            .Append("<tc>*</tc>")
            .Append("<ce><e>RESUMO DAS OPERACOES DO TURNO</e></ce>")
            .Append("<l></l>")

            'LER BASE DE DADOS
            .Append("<n>CAIXA</n>")
            .Append("<n><t></tb>TROCO INICIAL (+):<ad>400,00</ad></n>")
            .Append("<n><t></tb>VENDAS....... (+):<ad>5431,00</ad></n>")
            .Append("<n><t></tb>TROCO FINAL.. (-):<ad>400,00</ad></n>")
            .Append("<n><t></tb>TOTAL GERAL...(=):<ad>5431,00</ad></n>")
            .Append("<l></l>")
            .Append("<l></l>")

            'DETALHAMENTO, LER FORMAS DE PAGAMENTO
            .Append("<ce>DETALHAMENTO POR TIPO DE MOEDA</ce>")
            'LER DO BANCO TAMBEM
            .Append("<n>Dinheiro.......: <ad>0,80</ad></n>")
            .Append("<n>JegueCard......: <ad>30,00</ad></n>")
            .Append("<n>MortesCard.....: <ad>5400,20</ad></n>")
            .Append("<l></l>")
            .Append("<n>TOTAL DE VENDAS: <ad>5431,00</ad></n>")

            'ITENS EXCLUIDOS
            .Append("<c>CODIGO DESCRICAO ITEM                   PEDIDO</c>")
            .Append("<c>------ -------------------------------- ----------</c>")
            'LER DO BANCO TAMBEM
            .Append("<c>    20 ARROZ BRANCO                         597761</c>")
            .Append("<c>199876 ARROZ IRLANDES COM PARMESAO GRAT     597768</c>")
            .Append("<c>   501 AGUA SULFOROSA                       597768</c>")

            'FINALIZACAO RELATORIO
            .Append("<tc>*</tc>")
            .Append("<ce>CONFERENCIA DE CAIXA</ce>")
            .Append("<tc>*</tc>")
            .Append("<l></l>")
            .Append("<l></l>")
            .Append("<n>Caixa: <tc>_</tc></n>")
            .Append("<l></l>")
            .Append("<l></l>")
            .Append("<n>Supervisor: <tc>_</tc></n>")

            'RELACAO DAS COMISSOES
            .Append("<tc>*</tc>")
            .Append("<ce>COMISSIONAMENTO DE CANARIOS</ce>")
            .Append("<tc>*</tc>")
            .Append("<l></l>")
            'LER DO BANCO, DESCOBRIR REGRA
            .Append("<c>CODIGO FUNCIONARIO                    VLR COMISSAO</c>")
            .Append("<c>------ ------------------------------ ------------</c>")
            .Append("<c>     1 ANASTASIANA                           35,70</c>")
            .Append("<c>    76 WANDERGLEYDSOM                         8,68</c>")
            .Append("<l></l>")
            .Append("<l></l>")

            .Append("<tc>=</tc>")
            .Append("<ce><c>Relatorio impresso em</c> <dt></dt> <hr></hr></ce>")
            .Append("<gui></gui>")

        End With

        Return cRelatorio.ToString

    End Function

    Public Function fnImprimeFidelidade(ByVal nPedido As Integer) As String

        Dim cRelatorio As New System.Text.StringBuilder

        With cRelatorio
            .Append("<ce><e><da>FIDELIDADE</da></e></ce>")
            .Append("<l></l>")
            .Append("<ce>K FAST FOOD COM. DE ALIMENTOS LTDA EPP</ce>")
            .Append("<l></l>")
            .Append("<e><b>Valor resgatado: <ad>R$ 15,90</ad></b></e>")
            .Append("<e>Valor acumulado: <ad>R$ 16,90</ad></e>")
            .Append("<l></l>")
            .Append("<n>Email cadastrado: <b>cliente@servidor.com</b></n>")
            .Append("<l></l>")
            .Append("<l></l>")
            .Append("<tc>_</tc>")
            .Append("<n>Assinatura do cliente</n>")
            .Append("<l></l>")

            .Append("<tc>=</tc>")
            .Append("<ce><c>Relatorio impresso em</c> <dt></dt> <hr></hr></ce>")
            .Append("<gui></gui>")

        End With

        Return cRelatorio.ToString

    End Function

    Public Function fnImprimePedido(ByVal nPedido As Integer, Optional ByVal lCompleto As Boolean = False) As String

        Dim cRelatorio As New System.Text.StringBuilder

        With cRelatorio

            If lCompleto Then
                .Append("<ce><e>LPC Comercio de alimentos LTDA.</e></ce>")
                .Append("<ce>Av. Kennedy, 700 - Lj 335 - Jd. do Mar</ce>")
                .Append("<ce>Sao Bernardo do Campo - CEP 00000-000</ce>")
                .Append("<ce>CNPJ 00.000.000/0001-00    -    IE 000000000000</ce>")
                .Append("<l></l>")
            End If

            .Append("<tc>-</tc>")
            .Append("<ce><dt></dt> - <e><hr></hr></e></ce>")
            .Append("<tc>-</tc>")
            .Append("<ce><e> P E D I D O </e></ce>")
            .Append("<ce><i><c>NAO E DOCUMENTO FISCAL</c></i></ce>")
            .Append("<l></l>")

            If lCompleto Then
                .Append("<c>ITEM CODIGO DESCRICAO <ad>QTD x VLR.UND = VLR.ITEM</ad></c>")
            Else
                .Append("<c>ITEM    CODIGO    DESCRICAO</c>")
            End If

            .Append("<tc>-</tc>")

            'LER BANCO DE DADOS
            .Append("<c>0001     20 ESPETO FRANGO COM BACON E ESCAROLA ASSADA</c>")
            If lCompleto Then .Append("<tb></tb>1.000 x               14.96 =            14.96")
            .Append("<c>0002   1996 ARROZ BRANCO</c>")
            If lCompleto Then .Append("<tb></tb>1.000 x                0.01 =             0.01")
            .Append("<c>0003   1998 BATATA PALHA</c>")
            If lCompleto Then .Append("<tb></tb>1.000 x                0.01 =             0.01")
            .Append("<c>0004     20 MINI SALADA COM RUCULA DESFOLHADA E TOMATE CEREJA AO MOLHO MOSTARDA COM BATATA DESOSSADA</c>")
            If lCompleto Then .Append("<tb></tb>1.000 x                0.01 =             0.01")
            .Append("<tc>-</tc>")

            If lCompleto Then
                .Append("<b><e>TOTAL <ad>R$ 15,00</ad></e></b>")
                .Append("<n><e>Credito <ad>R$ 12,50</ad></e></n>")
                .Append("<n><e>Dinheiro <ad>R$ 2,50</ad></e></n>")
                .Append("<tc>-</tc>")
            End If

            .Append("<l></l>")
            .Append("<ce><e><n><da>Comanda: 72</da></n></e></ce>")
            .Append("<l></l>")

            .Append("<n>Operador: nomedooperador</n>")
            .Append("<n>Senha WIFI: picanha200</n>")
            .Append("<c>Controle interno: <dt></dt><hr></hr> Canario01</c>")
            .Append("<l></l>")
            .Append("<tc>-</tc>")
            .Append("<n><ce>Agradecemos a preferência! Volte sempre!</ce></n>")
            .Append("<l></l>")
            .Append("<gui></gui>")

        End With

        Return cRelatorio.ToString

    End Function

End Module
