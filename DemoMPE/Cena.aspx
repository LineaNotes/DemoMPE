<%@ Page Title="Cena" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cena.aspx.cs" Inherits="DemoMPE.Cena" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/2.2.0/jquery.min.js"></script>
    <script src="http://code.highcharts.com/stock/highstock.js"></script>
    <script src="http://code.highcharts.com/stock/modules/heatmap.js"></script> 
    <script src="http://code.highcharts.com/stock/modules/data.js"></script>
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1><%: Title %></h1>
    <h2>Cena</h2>
    <p class="lead">
        Stran za ceno
    </p>
    <div id="GasPriceTableTitle" runat="server" class="ContentHead">
        <h1>Tabela cene plina</h1>
        <p>Od - do</p>
    </div>
    <asp:GridView ID="GasPriceList" runat="server" AutoGenerateColumns="false" ShowFooter="true" GridLines="Vertical"
        ItemType="DemoMPE.Models.GasPrice" SelectMethod="GetGasPrices" CssClass="table table-striped table-bordered">
        <Columns>
            <asp:BoundField DataField="GasPriceId" HeaderText="ID" SortExpression="GasPriceId" />
            <asp:BoundField DataField="gasDate" HeaderText="Datum" />
            <asp:BoundField DataField="gasPrice" HeaderText="Cena plina" DataFormatString="&#8364; {0:N}" />
        </Columns>
    </asp:GridView>
    <div>
        <p></p>
        <strong>
            <asp:Label ID="LabelTotalText" runat="server" Text="Skupno število: "></asp:Label>
            <asp:Label ID="lblTotal" runat="server" EnableViewState="false"></asp:Label>
        </strong>
    </div>
    <asp:Literal runat="server" ID="ltrChartGasPrice" Text="" />
</asp:Content>
