Public Class Produto
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

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
End Class