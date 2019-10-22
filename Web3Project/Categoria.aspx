<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Categoria.aspx.vb" Inherits="Web3Project.CategoriasTO" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 139px;
        }
        .auto-style2 {
            width: 139px;
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width: 65%;">
            <tr>
                <td class="auto-style2">Nome da Categoria:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtNomeCategoria" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Descrição:</td>
                <td>
                    <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" Width="68px" />
                </td>
                <td>
                    <asp:Button ID="btnLimpar" runat="server" Text="Limpar" />
                </td>
            </tr>
        </table>
    
    </div>
        
        <div>

            <asp:TextBox ID="TextMsg" runat="server" BackColor="#FFFF66" Font-Bold="True" ForeColor="#0000CC" Height="47px" TextMode="MultiLine" Visible="False" Width="100%"></asp:TextBox>

        </div>
        <hr />
        <div>

            Digite as Iniciais do nome da categoria:<asp:TextBox ID="txtPesquisar" runat="server"></asp:TextBox>
            <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar" />

        </div>
        <div>

            <asp:GridView ID="GridCategoria" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="idCategoria" HeaderText="Cód." />
                    <asp:BoundField DataField="nomeCategoria" HeaderText="Nome da Categoria" />
                    <asp:BoundField DataField="Descricao" HeaderText="Desc." />
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
