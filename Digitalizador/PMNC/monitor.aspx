<%@ Page Title="" Language="C#" MasterPageFile="~/Painel.Master" AutoEventWireup="true" CodeBehind="monitor.aspx.cs" Inherits="PMNC.monitor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cambio" runat="server">
    <table id="cotacao" style="border-collapse:collapse" >
        <thead  style="background-color:#000; color:#fff;">
            <tr>
                <td>DIA</td>
                <td>USD</td>
                <td>CNM</td>
                <td>EUZ</td>
            </tr>
        </thead>
        <tbody id="tbodyCotacao">
    
        </tbody>
    
   </table>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="navio" runat="server">
    <table id="tbnavio" style="border-collapse:collapse">
    <thead class="bg_titulo">
        <tr>
            <td>NAVIO</td>
            <td>TERMINAL</td>
            <td>PREVISÃO</td>
            <td>CHEGADA</td>
        </tr>
    </thead>
    <tbody id="tbodyNavio">
    
    </tbody>
    
    </table>

</asp:Content>
