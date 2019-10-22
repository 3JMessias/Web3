Public Class CategoriasTO
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        'Captura os dados do formulário
        Dim categorias As New CategoriaTO
        categorias.NomeCategoria = txtNomeCategoria.Text
        categorias.Descricao = txtDescricao.Text
        'Enviar para o DAO
        Dim dao As New CategoriaDAO
        Dim msg As String
        msg = dao.Adiciona(categorias)
        If msg = "OK" Then
            TextMsg.Visible = True
            TextMsg.Text = "Gravação com sucesso!"
        Else
            TextMsg.Visible = True
            TextMsg.Text = msg

        End If
    End Sub

    Protected Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Dim dao As New CategoriaDAO
        GridCategoria.DataSource = dao.Lista(txtPesquisar.Text)
        GridCategoria.DataBind()
    End Sub
End Class