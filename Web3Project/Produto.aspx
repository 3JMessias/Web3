<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Produto.aspx.vb" Inherits="Web3Project.Produto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style4 {
            width: 39%;
        }
        .auto-style5 {
            width: 169px;
        }
        .auto-style6 {
            width: 102px;
        }
    </style>
</head>
<body>
    <form id="grid" runat="server">
        <div>

            <asp:TextBox ID="txtMensagem" runat="server" BackColor="#FFFF99" Font-Bold="True" Font-Size="Medium" ForeColor="Red" Height="44px" TextMode="MultiLine" Width="100%"></asp:TextBox>

        </div>
            <hr />
        <div>

            <table class="auto-style4">
                <tr>
                    <td class="auto-style5">Nome do Produto</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtNomeProduto" runat="server" Width="187px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Categoria</td>
                    <td class="auto-style6">
                        <asp:DropDownList ID="cboCategoria" runat="server" DataTextField="NomeCategoria" DataValueField="idCategoria" Height="20px" Width="195px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Preço Unitário</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtPreco" runat="server" Width="187px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Qtd. em Estoque</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtEstoque" runat="server" Width="187px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:CheckBox ID="chkFaraDeLinha" runat="server" Text="Produto Descontinuado" />
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                </tr>
            </table>

        </div>
            <hr />
        <div>
        
            <asp:Button ID="Button1" runat="server" Text="Button" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Button" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="Button" />
        
        </div>
            <hr />
        <div>
            Digite as iniciais do nome do Produto:<asp:TextBox ID="txtPesquisar" runat="server" Width="261px"></asp:TextBox>

            <asp:Button ID="btnPesquisar" runat="server" Height="24px" Text="Pesquisar" Width="90px" />

        </div>
            <hr />
        <div id="grdProdutos">
            <asp:GridView ID="grdProdutos" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="626px">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="idProduto" HeaderText="Cód." />
                    <asp:BoundField DataField="NomeProduto" HeaderText="Nome do Produto" />
                    <asp:BoundField DataField="Preco" HeaderText="Preço Unit." />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </div>

        <div>
            <hr />
        </div>
        <div>
            Buscar por nome da Categoria: 

            <asp:TextBox ID="txtPesquisarCategoria" runat="server" AutoCompleteType="FirstName" Height="19px" Width="242px"></asp:TextBox>
            <asp:Button ID="btnBuscarCategoria" runat="server" Text="Buscar" Width="90px" />

        </div>
        <div>
            <hr />
        </div>
        <div>
            Grid
        </div>
        <asp:GridView ID="grdCategoria" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Width="361px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="NomeCategoria" HeaderText="Nome" />
                <asp:BoundField DataField="Descricao" HeaderText="Descrição" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>
    </form>
</body>
</html>
