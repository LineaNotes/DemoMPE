<%@ Page Title="Poraba" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Poraba.aspx.cs" Inherits="DemoMPE.Poraba" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1><%: Title %></h1>
    <h2>Poraba</h2>
    <p class="lead">
        Stran za porabo
    </p>
    <div id="GasTableTitle" runat="server" class="ContentHead">
        <h1>Tabela porabe plina</h1>
        <p>Od - do</p>
    </div>
    <asp:GridView ID="GasList" runat="server" AutoGenerateColumns="false" ShowFooter="true" GridLines="Vertical"
        ItemType="DemoMPE.Models.Gas" SelectMethod="GetGases" CssClass="table table-striped table-bordered">
        <Columns>
            <asp:BoundField DataField="stevilka_vpisa" HeaderText="ID" SortExpression="stevilka_vpisa" />
            <asp:BoundField DataField="datum" HeaderText="Datum" />
            <asp:BoundField DataField="ura_zacetnega_vpisa" HeaderText="Začetek Vpisa" />
            <asp:BoundField DataField="ura_koncnega_vpisa" HeaderText="Konec Vpisa" />
            <asp:BoundField DataField="zacetno_stanje" HeaderText="Začetno Stanje" />
            <asp:BoundField DataField="koncno_stanje" HeaderText="Končno Stanje" />
            <asp:BoundField DataField="proizvedena_kolicina" HeaderText="Proizvedeno" />
            <asp:BoundField DataField="zacetno_stanje_cela" HeaderText="ZS Cela" />
            <asp:BoundField DataField="zacetno_stanje_cifra" HeaderText="ZS Cifra" />
            <asp:BoundField DataField="koncno_stanje_cela" HeaderText="KS Cela" />
            <asp:BoundField DataField="koncno_stanje_cifra" HeaderText="KS Cifra" />
        </Columns>
    </asp:GridView>
    <div>
        <p></p>
        <strong>
            <asp:Label ID="LabelTotalText" runat="server" Text="Skupno število: "></asp:Label>
            <asp:Label ID="lblTotal" runat="server" EnableViewState="false"></asp:Label>
        </strong>
    </div>

</asp:Content>