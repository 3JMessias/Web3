Public Class Produto
    Inherits System.Web.UI.Page
    Shared novoProduto As Boolean
    Shared idProduto As Long

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then 'Se for a primeira vez que carrega a pagina
            PreencheCboCategoria()
            HabilitaTela(False)
            txtPesquisar.Focus()
            HabilitaBotoes(True)

        End If
    End Sub

    Sub ExibeMsg(ByVal mensagem As String, ByVal cor As String, ByVal exibir As Boolean)
        txtMensagem.Visible = exibir
        txtMensagem.Text = mensagem
        If cor = "Red" Then
            txtMensagem.ForeColor = Drawing.Color.Red
        End If
        If cor = "Blue" Then
            txtMensagem.ForeColor = Drawing.Color.Blue
        End If
    End Sub
    Sub HabilitaTela(ByVal habilita As Boolean)
        txtNomeProduto.Enabled = habilita
        cboCategoria.Enabled = habilita
        txtPreco.Enabled = habilita
        txtEstoque.Enabled = habilita
        chkForaDeLinha.Enabled = habilita
    End Sub


    Sub HabilitaBotoes(ByVal habilita As Boolean)
        btnNovo.Enabled = habilita
        btnEditar.Enabled = habilita
        btnExcluir.Enabled = habilita
        btnPesquisar.Enabled = habilita
        grdProdutos.Enabled = habilita

        btnSalvar.Enabled = Not habilita
        btnCancelar.Enabled = Not habilita




    End Sub


    Sub LimpaDados()
        txtNomeProduto.Text = ""
        cboCategoria.SelectedValue = -1
        txtPreco.Text = ""
        txtEstoque.Text = ""
        chkForaDeLinha.Checked = False
    End Sub


    Sub PreencheCboCategoria()
        Dim dao As New CategoriaDAO
        cboCategoria.DataSource = dao.PreencheCombo
        cboCategoria.DataBind()
    End Sub

    Protected Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        RefreshGrid()

    End Sub

    Sub RefreshGrid()
        Dim dao As New ProdutoDAO
        grdProdutos.DataSource = dao.Lista(txtPesquisar.Text)
        grdProdutos.DataBind()
    End Sub

    Protected Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim produto As New ProdutoTO
        'Preenche o objeto com os dados do formulário
        With produto
            .idProduto = idProduto
            .NomeProduto = txtNomeProduto.Text
            .idCategoria = cboCategoria.SelectedValue
            .Preco = txtPreco.Text
            .Estoque = txtEstoque.Text
            .ForaDeLinha = chkForaDeLinha.Checked
        End With
        'Gravação do dados
        Dim msg As String
        Dim dao As New ProdutoDAO

        If (idProduto <= 0) Then
            msg = dao.Adiciona(produto)
        Else
            msg = dao.Altera(produto)
        End If

        'Exibe mensagem de retorno da gravação
        If msg = "OK" Then
            ExibeMsg("Registro salvo com sucesso", "Blue", True)
            'Disable botons
            HabilitaBotoes(False)
            'Disabilita Tela
            HabilitaTela(False)

        Else
            ExibeMsg(msg, "Red", True)
            txtMensagem.Visible = True
            txtMensagem.Text = msg

        End If
        RefreshGrid()
        LimpaDados()
        HabilitaTela(True)
        HabilitaBotoes(True)

    End Sub

    Protected Sub grdProdutos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles grdProdutos.SelectedIndexChanged
        Dim idProduto As Integer
        idProduto = grdProdutos.SelectedRow.Cells(0).Text
        Dim produto As New ProdutoTO
        Dim dao As New ProdutoDAO
        dao.PreencheObj(produto, idProduto)

        'preencher formulario

        txtNomeProduto.Text = produto.NomeProduto
        cboCategoria.SelectedValue = produto.idCategoria
        txtPreco.Text = produto.Preco
        txtEstoque.Text = produto.Estoque
        chkForaDeLinha.Checked = produto.ForaDeLinha
    End Sub

    Protected Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        ExibeMsg("", "", False)
        LimpaDados()
        HabilitaBotoes(False)
        HabilitaTela(True)
        novoProduto = True
        idProduto = -1 'sinaliza para o botão Salvar
    End Sub

    Protected Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        novoProduto = False
        HabilitaTela(True)
        HabilitaBotoes(False)

    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpaDados()
        HabilitaTela(False)
        HabilitaBotoes(True)
        ExibeMsg("", "", False)
    End Sub

    Protected Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim idProduto As Long
        idProduto = grdProdutos.SelectedRow.Cells(0).Text
        Dim dao As New ProdutoDAO
        Dim msg As String
        msg = dao.Exclui(idProduto)
        If msg = "OK" Then
            ExibeMsg("Registro excluido com sucesso", "Blue", True)
        Else
            ExibeMsg(msg, "Red", True)
            btnCancelar.Enabled = True

        End If
        RefreshGrid()
        LimpaDados()
        HabilitaBotoes(False)
        HabilitaTela(True)

    End Sub
End Class