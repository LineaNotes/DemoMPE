<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dostopi.aspx.cs" Inherits="DemoMPE.Admin.Dostopi" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1><%: Title %></h1>
    <h2>Dostopi</h2>
    <p class="lead">
        Stran za dostope
    </p>
    <div id="LogTableTitle" runat="server" class="ContentHead">
        <h1>Tabela dostopov</h1>
        <p>Od - do</p>
    </div>
    <asp:GridView ID="LogList" runat="server" AutoGenerateColumns="false" ShowFooter="true" GridLines="Vertical"
        ItemType="DemoMPE.Models.Log" SelectMethod="GetLogs" CssClass="table table-striped table-bordered">
        <Columns>
            <asp:BoundField DataField="LogId" HeaderText="ID" SortExpression="LogId" />
            <asp:BoundField DataField="date" HeaderText="Datum" />
            <asp:BoundField DataField="User" HeaderText="Uporabnik" />
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
