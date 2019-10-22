<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Produto.aspx.vb" Inherits="Web3Project.Produto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            width: 173px;
        }
        .auto-style3 {
            height: 23px;
            width: 173px;
        }
        .auto-style4 {
            width: 209px;
        }
        .auto-style5 {
            height: 23px;
            width: 209px;
        }
    </style>

    <script type=" text/javascript">
        function ConfirmaExclusao() {
        return confirm("Registro selecionado na grid será excluido!");
        }
    </script>

</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:TextBox ID="txtMensagem" runat="server" BackColor="#FFFF99" Font-Bold="True" Font-Size="Medium" Font-Strikeout="False" ForeColor="Red" Height="44px" TextMode="MultiLine" Visible="False" Width="100%"></asp:TextBox>

        </div>
        <hr />
        <div>

            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">Nome do Produto</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtNomeProduto" runat="server" Width="194px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Categoria</td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="cboCategoria" runat="server" DataTextField="NomeCategoria" DataValueField="idCategoria" Width="201px">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Preço Unitario</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtPreco" runat="server" Width="195px"></asp:TextBox>
                    </td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style2">Qtd. em Estoque</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtEstoque" runat="server" Width="190px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:CheckBox ID="chkForaDeLinha" runat="server" Text="Produto descontinuado" />
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>

        </div>
        <hr />
        <div>

            <asp:Button ID="btnNovo" runat="server" Text="Novo" />
&nbsp;
            <asp:Button ID="btnEditar" runat="server" Text="Editar" />
&nbsp;
            <asp:Button ID="btnExcluir" runat="server" Text="Excluir" OnClientClick =" return ConfirmaExclusao()" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" />
&nbsp;&nbsp;
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />

        </div>
        <hr />
        <div>

            Digite as iniciais do nome do produto:<asp:TextBox ID="txtPesquisar" runat="server"></asp:TextBox>
            <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar" />

        </div>
        <hr />
        <div>

            <asp:GridView ID="grdProdutos" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="idProduto" HeaderText="Cód." />
                    <asp:BoundField DataField="NomeProduto" HeaderText="Nome do Produto" />
                    <asp:BoundField DataField="Preco" HeaderText="Preço Unit." />
                    <asp:CommandField ShowSelectButton="True" />
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
    </form>
</body>
</html>
