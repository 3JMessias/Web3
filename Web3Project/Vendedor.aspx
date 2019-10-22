<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Vendedor.aspx.vb" Inherits="Web3Project.Vendedor" %>

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
            width: 254px;
        }
        .auto-style5 {
            height: 23px;
            width: 254px;
        }
        .auto-style6 {
            width: 100%;
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

            <asp:TextBox ID="txtMensagemVendedor" runat="server" BackColor="#FFFF99" Font-Bold="True" Font-Size="Medium" Font-Strikeout="False" ForeColor="Red" Height="44px" TextMode="MultiLine" Visible="False" Width="100%"></asp:TextBox>

        </div>
        <hr />
        <div>

            <table class="auto-style6">
                <tr>
                    <td class="auto-style2">Nome do Vendedor</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtNomeVendedor" runat="server" Width="241px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Sexo</td>
                    <td class="auto-style4">
                        <asp:RadioButton ID="rdbMasculino" runat="server" Text="Masculino" GroupName="Sexo" />
&nbsp;&nbsp;
                        <asp:RadioButton ID="rdbFeminino" runat="server" Text="Feminino" GroupName="Sexo" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Salário Base</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtSalario" runat="server" Width="238px"></asp:TextBox>
                    </td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style3">Data de Admissão</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtDataAdmissao" runat="server" Width="237px" TextMode="Date"></asp:TextBox>
                    </td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style2">Data de Demissão</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtDataDemissao" runat="server" Width="237px" TextMode="Date"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>

        </div>
        <hr />
        <div>

            <asp:Button ID="btnNovoVendedor" runat="server" Text="Novo" />
&nbsp;
            <asp:Button ID="btnEditarVendedor" runat="server" Text="Editar" />
&nbsp;
            <asp:Button ID="btnExcluirVendedor" runat="server" Text="Excluir" OnClientClick =" return ConfirmaExclusao()" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSalvarVendedor" runat="server" Text="Salvar" />
&nbsp;&nbsp;
            <asp:Button ID="btnCancelarVend" runat="server" Text="Cancelar" />

        </div>
        <hr />
        <div>

            Digite as iniciais do nome do produto:<asp:TextBox ID="txtPesquisarVendedor" runat="server" Width="274px"></asp:TextBox>
            <asp:Button ID="btnPesquisarVendedor" runat="server" Text="Pesquisar" />

        </div>
        <hr />
        <div>

            <asp:GridView ID="grdVendedores" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="IdVendedor" HeaderText="Cód" />
                    <asp:BoundField DataField="NomeVendedor" HeaderText="Nome do Vendedor" />
                    <asp:BoundField DataField="Salario" HeaderText="Salário" />
                    <asp:BoundField DataField="DataAdmissao" HeaderText="Admissao" />
                    <asp:BoundField DataField="Sexo" HeaderText="Sexo" />
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
