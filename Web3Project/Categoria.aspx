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
                    <asp:TextBox ID="txtNomeCategoria" runat="server" style="height: 22px"></asp:TextBox>
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
            <asp:TextBox ID="txtMensagem" runat="server" BackColor="#FFFF66" Font-Bold="True" ForeColor="Blue" Height="44px" TextMode="MultiLine" Visible="False" Width="100%"></asp:TextBox>
        </div>
    </form>
</body>
</html>
