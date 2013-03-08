<%@ Page Language="VB" Debug="true" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Data.OleDb" %>
<%@ Import Namespace="System.IO" %>
<%@ Import Namespace="System.Xml" %>

<script runat="server">

    Dim strConexao As String
    Dim strCaminho As String
    Dim strCaminhoAgenda As String
    Dim strConexaoAgenda As String
    Dim strCaminhoAniversariante As String
    Dim strConexaoAniversariante As String
    Dim strCaminhoInformativo As String
    Dim strConexaoInformativo As String
    Dim strSQL As String
    Dim strResultado As String
    Dim strResultadoAgenda As String
    Dim strResultadoAniversariante As String
    Dim strResultadoInformativo As String
    Dim titleAttribute As String
    Dim strResultadoDestCambio As String
   
    Sub Page_Load()
        If Not IsPostBack Then
            
            Dim m_xmld As XmlDocument
            Dim m_nodelist As XmlNodeList
            Dim m_node As XmlNode
            
            m_xmld = New XmlDocument()
            
            Try
            
                m_xmld.Load("http://www.desenvolvimento.gov.br/portalmdic/sitio/rss.php?area=5")
                m_nodelist = m_xmld.SelectNodes("rss/channel/item")
                
                
                'For i = 0 To m_nodelist.Count - 1
                For i = 0 To 5
                    titleAttribute += "<div class='box'><span>Informativo</span>"
                    titleAttribute += "<p>" + m_nodelist(i).ChildNodes(0).InnerText + "</p>"
                    
                    Dim data=Split(m_nodelist(i).ChildNodes(1).InnerText,"T")
                    Dim dataArray = Split(data(0),"-")
                    Dim dataFormatada = dataArray(2)+"/"+dataArray(1)+"/"+dataArray(0)
                    
                    titleAttribute += "<small>" + "Publicado em: " + dataFormatada + "</small>"
                    titleAttribute += "</div>"
                Next
        
            Catch ex As Exception
                
                titleAttribute += "<div class='box'><span>Informativo</span><p>Nenhuma informação. Detalhes do ERRO: " + ex.ToString()+ " </p></div>"
                
            End Try
            
            '=================================================================================================
            ' Conexão
            
            strCaminho = "C:\bd\BANCO_PAINEL.mdb"
            strConexao = "Provider=Microsoft.Jet.OLEDB.4.0;"
            strConexao = strConexao + "Data Source=" + strCaminho
            
            '=================================================================================================
            ' Tabela de Agenda
            
            Dim objConexaoAgenda As New OleDbConnection(strConexao)
            
            strSQL = "SELECT TXT_COMUNICADO, DAT_PUBLICACAO FROM TB_AGENDA"
            strSQL = strSQL + " WHERE IND_ATIVO = 'S' ORDER BY DAT_PUBLICACAO ASC"
    
            Dim objCommandAgenda As New OleDbCommand(strSQL, objConexaoAgenda)
            Dim drAgenda As OleDbDataReader
    
            objConexaoAgenda.Open()
            drAgenda = objCommandAgenda.ExecuteReader()
        
            
            Do While drAgenda.Read() = True
                strResultadoAgenda += "<div class='box'><span>Agenda:</span>"
                strResultadoAgenda += "<p>" + drAgenda("TXT_COMUNICADO") + "</p>"
                strResultadoAgenda += "<small>" + "Publicado em: " + drAgenda("DAT_PUBLICACAO") + "</small>"
                strResultadoAgenda += "</div>"
            Loop
            
    
            'resultadoAgenda.Text = strResultadoAgenda
            drAgenda.Close()
            objConexaoAgenda.Close()
    
            'liberando memória
            objConexaoAgenda = Nothing
            
            
            
            '========================================================================================================= 
            ' Tabela de Aniversariantes
                        
            Dim objConexaoAniversariante As New OleDbConnection(strConexao)
            
            strSQL = "SELECT ID,NOM_ANIVERSARIANTE, DAT_ANIVERSARIANTE, CPF_ANIVERSARIANTE"
            strSQL = strSQL + " FROM TB_ANIVERSARIANTE  "
    
            Dim objCommandAniversariante As New OleDbCommand(strSQL, objConexaoAniversariante)
            Dim drAniversariante As OleDbDataReader
    
            objConexaoAniversariante.Open()
            drAniversariante = objCommandAniversariante.ExecuteReader()
            
            
            Do While drAniversariante.Read() = True
                strResultadoAniversariante += "<div class='box'><span>Aniversariante:</span>"
                strResultadoAniversariante += "<p>" + drAniversariante("NOM_ANIVERSARIANTE") + "</p>"
                strResultadoAniversariante += "<p class='data'>" + drAniversariante("DAT_ANIVERSARIANTE") + "</p>"
                strResultadoAniversariante += "</div>"
            Loop
            
            resultadoAgenda.Text = titleAttribute + strResultadoAgenda + strResultadoAniversariante
            
            drAniversariante.Close()
            objConexaoAniversariante.Close()
    
            'liberando memória
            objConexaoAniversariante = Nothing
            
            
            
            
            
            '========================================================================================================= 
            ' Destaque Cambio
                        
            Dim objConexaoDestCambio As New OleDbConnection(strConexao)
            
            strSQL = "SELECT DIN_USD, ID, DIN_EUZ FROM TB_CAMBIO"
    
            Dim objCommandDestCambio As New OleDbCommand(strSQL, objConexaoDestCambio)
            Dim drDestaqueCambio As OleDbDataReader
    
            objConexaoDestCambio.Open()
            drDestaqueCambio = objCommandDestCambio.ExecuteReader()
            
            Dim x = 0 
            Do While drDestaqueCambio.Read() = True
                If x = 0 Then
                    strResultadoDestCambio += "<span class='box'>Dolar: " + drDestaqueCambio("DIN_USD").ToString + "</span>"
                    strResultadoDestCambio += "<span class='box'>Euro: " + drDestaqueCambio("DIN_EUZ").ToString + "</span>"
                    x = x + 1
                End If
            Loop
            
            resultadoDestCambio.Text = strResultadoDestCambio
            
            drDestaqueCambio.Close()
            objConexaoDestCambio.Close()
    
            'liberando memória
            objConexaoDestCambio = Nothing
                          
        End If
    End Sub
    
    'http://msdn.microsoft.com/pt-br/library/system.web.ui.webcontrols.datagrid.itemdatabound.aspx
    'http://www.devmedia.com.br/manipulando-o-gridview-atraves-do-evento-rowdatabound-parte-1/9281
    'http://www.macoratti.net/07/08/aspn_dlc.htm
    Sub Item_Bound(sender As Object, e As DataGridItemEventArgs)
    
        'Define uma variável do tipo DataRowView 
        Dim drv As DataRowView = CType(e.Item.DataItem, DataRowView)
        
        'define a variável datetime que irá receber da data
        Dim chegada As DateTime
        
        'se o item estiver em Item ou AlternatingItem então iremos verificar a condição
        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then
        
        'Verifica se a data de chegada possui valores nulos
        If Not drv.Row("ETA").ToString = DBNull.Value.ToString Then
            'obtem a data de chegada em um varivael do tipo datetime
            chegada = DateTime.Parse(drv.Row("ETA").ToString)
        End If
        
        'Se a data de chegada coincide com a data de hoje (dia/mes)
        'Muda a cor da linha do texto para azul e aplica negrito
        If chegada.ToString("MM/dd/YY") <= DateTime.Now.ToString("MM/dd/YY") Then
            e.Item.ForeColor = Drawing.Color.Green
            e.Item.Font.Bold = True
        End If
        
        End If
                
    End Sub
</script>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Opus - Comércio Exterior</title>
    
    <script type="text/javascript"  src="js/jquery-1.7.2.min.js"></script>
    <script type="text/javascript" src="js/jquery.royalslider.min.js"></script>
    
    <link href="css/royalslider.css" rel="stylesheet"/>
    <link rel="stylesheet" type="text/css" href="css/style.css" />
        
    <script type="text/javascript">
        function piscar() {
            $("#destaque .box").animate({opacity: 0}, 
            function() {
                $(this).animate({opacity: 1});
            });
        }
    
        window.setInterval( function() {
            piscar();
        }, 2000 );
    
    </script>

</head>
<body>
    
<div id="container">
	<div id="header"><div id="globo"><img src="img/globo1.gif" width="200" alt="Opus Comércio Exterior" /></div></div>
    <div id="right">
    	<div class="titulo"> Câmbio </div>
        <div id="cambio">
            <asp:DataGrid id="DataGrid2" runat="server" DataSourceID="dsCambio" AutoGenerateColumns="False">
                <AlternatingItemStyle backcolor="Black"></AlternatingItemStyle>
                <HeaderStyle backcolor="Black" ForeColor="White" />
                <Columns>
                    <asp:BoundColumn DataField="DATA" HeaderText="DIA"></asp:BoundColumn>
                    <asp:BoundColumn DataField="DIN_USD" HeaderText="USD" DataFormatString="{0:N3}">
                        <ItemStyle forecolor="yellow"></ItemStyle>
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="DIN_CNM" HeaderText="CNM" DataFormatString="{0:N3}">
                        <ItemStyle forecolor="red"></ItemStyle>
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="DIN_EUZ" DataFormatString="{0:N3}" HeaderText="EUZ">
                        <ItemStyle forecolor="orange"></ItemStyle>
                    </asp:BoundColumn>
                </Columns>
            </asp:DataGrid>
            <asp:AccessDataSource ID="dsCambio" runat="server" DataFile="c:/bd/BANCO_PAINEL.mdb" SelectCommand="SELECT [DIN_USD], [ID], [DATA], [DIN_EUZ], [DIN_CNM] FROM [TB_CAMBIO] WHERE ([IND_ATIVO] = ?)">
                <SelectParameters>
                    <asp:Parameter DefaultValue="S" Name="IND_ATIVO" Type="String" />
                </SelectParameters>
            </asp:AccessDataSource>
        </div>
    </div>
        <div id="left">
        <div id="destaque">
            <span>Taxa do dia:</span>
            <asp:Label id="resultadoDestCambio" runat="server"></asp:Label>
            <!--
            <span class="box"> Dolar: 2,00 </span>
            <span class="box">Euro: 2,58 </span>
            -->
        </div>
        <div id="navios">  
        <asp:DataGrid id="DataGrid1" runat="server" OnItemDataBound="Item_Bound"  DataSourceID="dsOpusce" AutoGenerateColumns="False">
            <AlternatingItemStyle backcolor="Black"></AlternatingItemStyle>
            <HeaderStyle cssclass="bg_titulo" ForeColor="White" />
            <Columns>
                <asp:BoundColumn DataField="NAVIO" HeaderText="NAVIO"></asp:BoundColumn>
                <asp:BoundColumn DataField="TERMINAL" HeaderText="TERMINAL" DataFormatString="{0:dd/MM/yyyy}"></asp:BoundColumn>
                <asp:BoundColumn DataField="ETD" DataFormatString="{0:dd/MM/yyyy}" HeaderText="PREVISÃO"></asp:BoundColumn>
                <asp:BoundColumn DataField="ETA" DataFormatString="{0:dd/MM/yyyy}" HeaderText="CHEGADA" ReadOnly="True"></asp:BoundColumn>
            </Columns>
        </asp:DataGrid>
        <asp:AccessDataSource ID="dsOpusce" runat="server" DataFile="c:/bd/BANCO_PAINEL.mdb" SelectCommand="SELECT [NOM_NAVIO] AS NAVIO, [LOC_TERMINAL] AS TERMINAL, [ETD] , [ETA] FROM [TB_CHEGADA_NAVIOS] WHERE ([IND_ATIVO] = ?)  ORDER BY [ETA] DESC">
            <SelectParameters>
                <asp:Parameter DefaultValue="S" Name="IND_ATIVO" Type="String" />
                <asp:Parameter DefaultValue="S" Name="CHEGOU" Type="String" />
            </SelectParameters>
        </asp:AccessDataSource>
        </div>
    </div>
    <div id="footer">
        
        
        <asp:Label id="resultadoAgenda" class="royalSlider rsDefaultInv col" runat="server"></asp:Label>
        
        <span style="display: none">
        <asp:Label id="resultadoInformativo" runat="server"></asp:Label>
        <asp:Label id="resultadoAniversariante" runat="server"></asp:Label>
        </span>
    	<div class="clear"></div>
    </div>
</div>
        
<asp:AccessDataSource ID="Gilmara" runat="server" DataFile="c:/bd/BANCO_PAINEL.mdb"
    SelectCommand="SELECT * FROM [TB_CHEGADA_NAVIOS] WHERE ([IND_ATIVO] = ?)">
    <SelectParameters>
        <asp:Parameter DefaultValue="S" Name="IND_ATIVO" Type="String" />
    </SelectParameters>
</asp:AccessDataSource>
    

<script type="text/javascript">
    jQuery(document).ready(function($) {
      var sliderJQ = $('#resultadoAgenda').royalSlider({
        hideArrowOnLastSlide: true,
        loop: true,
        autoPlay: {
          enabled: true,
          delay: 5000
        },
        keyboardNavEnabled: true
      });
    });
</script>

    
</body>
</html>
