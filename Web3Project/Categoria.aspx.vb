Public Class CategoriasTO
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        'Captura os dados do formulário
        Dim categorias As New CategoriasTO
        categorias.NomeCategoria = txtNomeCategoria.Text
        categorias.Descricao = txtDescricao.Text


        'Enviar para o DAO
        Dim dao As New CategoriasDAO
        Dim msg As String
        msg = dao.Adiciona(categorias)

        'Validar campos vazios
        If (Not String.IsNullOrEmpty(txtNomeCategoria.Text) Or Not String.IsNullOrEmpty(txtDescricao.Text)) Then
            If msg = "OK" Then
                txtMensagem.Visible = True
                txtMensagem.Text = "Gravação com sucesso!"
            Else
                txtMensagem.Visible = True
                txtMensagem.Text = msg
            End If
        Else
            txtMensagem.Visible = True
            txtMensagem.Text = "Verifique se existe campo vazios"

        End If

    End Sub


    Protected Sub limparCampos(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtNomeCategoria.Text = ""
        txtDescricao.Text = ""
        txtNomeCategoria.Focus()
        txtMensagem.Visible = False
    End Sub
End Class