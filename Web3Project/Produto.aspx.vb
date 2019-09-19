Public Class Produto
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            PreencheCboCategoria()
        End If
    End Sub

    Sub PreencheCboCategoria()
        Dim dao As New CategoriasDAO
        cboCategoria.DataSource = dao.PreencheCombo
        cboCategoria.DataBind()
    End Sub

    Protected Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Dim dao As New ProdutoDAO
        grdProdutos.DataSource = dao.Lista(txtPesquisar.Text)
        grdProdutos.DataBind()
    End Sub

    Protected Sub btnBuscarCategoria_Click(sender As Object, e As EventArgs) Handles btnBuscarCategoria.Click
        Dim dao As New CategoriasDAO
        grdCategoria.DataSource = dao.ListarCategoria(txtPesquisarCategoria.Text)
        grdCategoria.DataBind()
    End Sub

    Protected Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim produto As New ProdutoTO
        produto.NomeProduto = txtNomeProduto.Text
        produto.idCategoria = cboCategoria.SelectedValue
        produto.Preco = txtPreco.Text
        produto.Estoque = txtEstoque.Text
        produto.ForaDeLinha = chkFaraDeLinha.Checked
        Dim msg As String
        Dim dao As New ProdutoDAO
        msg = dao.Adiciona(produto)
        txtMensagem.Visible = True
        txtMensagem.Text = msg
    End Sub
End Class