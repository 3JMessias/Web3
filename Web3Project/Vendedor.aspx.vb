Public Class Vendedor
    Inherits System.Web.UI.Page
    Shared novoVendedor As Boolean = False
    Shared idVendedor As Long


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then 'Se for a primeira vez que carrega a pagina
            HabilitaTelaVendedor(False)
            txtPesquisarVendedor.Focus()
            HabilitaBotoesVendedor(True)

        End If
    End Sub

    Sub ExibeMsgVendedor(ByVal mensagem As String, ByVal cor As String, ByVal exibir As Boolean)
        txtMensagemVendedor.Visible = exibir
        txtMensagemVendedor.Text = mensagem
        If cor = "Red" Then
            txtMensagemVendedor.ForeColor = Drawing.Color.Red
        End If
        If cor = "Blue" Then
            txtMensagemVendedor.ForeColor = Drawing.Color.Blue
        End If
    End Sub
    Sub HabilitaTelaVendedor(ByVal habilita As Boolean)
        txtNomeVendedor.Enabled = habilita
        rdbMasculino.Enabled = habilita
        rdbFeminino.Enabled = habilita
        txtSalario.Enabled = habilita
        txtDataAdmissao.Enabled = habilita
        txtDataDemissao.Enabled = habilita
    End Sub


    Sub HabilitaBotoesVendedor(ByVal habilita As Boolean)
        btnNovoVendedor.Enabled = habilita
        btnEditarVendedor.Enabled = habilita
        btnExcluirVendedor.Enabled = habilita
        btnPesquisarVendedor.Enabled = habilita
        grdVendedores.Enabled = habilita

        btnSalvarVendedor.Enabled = Not habilita
        btnCancelarVend.Enabled = Not habilita




    End Sub


    Sub LimpaDadosVendedor()
        txtNomeVendedor.Text = ""
        rdbMasculino.Checked = False
        rdbFeminino.Checked = False
        txtSalario.Text = ""
        txtDataAdmissao.Text = ""
        txtDataDemissao.Text = ""
    End Sub

    Protected Sub btnPesquisarVendedor_Click(sender As Object, e As EventArgs) Handles btnPesquisarVendedor.Click
        RefreshGridVendedor()

    End Sub

    Sub RefreshGridVendedor()
        Dim dao As New VendedoresDAO
        grdVendedores.DataSource = dao.Lista(txtPesquisarVendedor.Text)
        grdVendedores.DataBind()
    End Sub

    Protected Sub btnSalvarVendedor_Click(sender As Object, e As EventArgs) Handles btnSalvarVendedor.Click
        Dim vendedor As New VendedoresTO
        'Preenche o objeto com os dados do formulário
        With vendedor
            .NomeVendedor = txtNomeVendedor.Text
            .Sexo = IIf(rdbMasculino.Checked = True, "M", "F")
            .Salario = txtSalario.Text
            .DataAdmissao = txtDataAdmissao.Text
            .DataDemissao = txtDataDemissao.Text
        End With
        'Gravação dos dados
        Dim msg As String
        Dim dao As New VendedoresDAO
        If novoVendedor = True Then
            msg = dao.Adiciona(vendedor)
        Else
            msg = dao.Altera(vendedor)
        End If
        If msg <> "OK" Then
            ExibeMsgVendedor("Registro salvo com sucesso", "Blue", True)
            'Disable botons
            HabilitaBotoesVendedor(False)
            HabilitaTelaVendedor(False)
        Else
            ExibeMsgVendedor(msg, "Red", True)
            txtMensagemVendedor.Visible = True
            txtMensagemVendedor.Text = msg
        End If
        LimpaDadosVendedor()
        HabilitaTelaVendedor(True)
        HabilitaBotoesVendedor(True)
        RefreshGridVendedor()
    End Sub

    Protected Sub btnNovoVendedor_Click(sender As Object, e As EventArgs) Handles btnNovoVendedor.Click
        ExibeMsgVendedor("", "", False)
        LimpaDadosVendedor()
        novoVendedor = True
        HabilitaTelaVendedor(True)
        HabilitaBotoesVendedor(False)
        novoVendedor = True
    End Sub

    Protected Sub btnEditarVendedor_Click(sender As Object, e As EventArgs) Handles btnEditarVendedor.Click
        novoVendedor = False
        HabilitaTelaVendedor(True)
        HabilitaBotoesVendedor(False)

    End Sub

    Protected Sub btnCancelarVend_Click(sender As Object, e As EventArgs) Handles btnCancelarVend.Click
        LimpaDadosVendedor()
        HabilitaTelaVendedor(False)
        HabilitaBotoesVendedor(True)
        ExibeMsgVendedor("", "", False)
    End Sub

    Protected Sub btnExcluirVendedor_Click(sender As Object, e As EventArgs) Handles btnExcluirVendedor.Click
        Dim idVendedor As Long
        idVendedor = grdVendedores.SelectedRow.Cells(0).Text
        Dim dao As New VendedoresDAO
        Dim msg As String
        msg = dao.Exclui(idVendedor)
        If msg = "OK" Then
            ExibeMsgVendedor("Registro excluido com sucesso", "Blue", True)
        Else
            ExibeMsgVendedor(msg, "Red", True)
            btnCancelarVend.Enabled = True

        End If
        RefreshGridVendedor()

    End Sub

    Protected Sub grdVendedores_SelectedIndexChanged1(sender As Object, e As EventArgs) Handles grdVendedores.SelectedIndexChanged
        idVendedor = grdVendedores.SelectedRow.Cells(0).Text
        Dim vendedor As New VendedoresTO
        Dim dao As New VendedoresDAO
        dao.PreencheObj(vendedor, idVendedor)

        'preencher formulario
        With vendedor
            txtNomeVendedor.Text = .NomeVendedor
            rdbMasculino.Checked = IIf(.Sexo = "M", True, False)
            txtSalario.Text = .Salario
            txtDataAdmissao.Text = .DataAdmissao
            txtDataDemissao.Text = .DataDemissao
        End With
    End Sub
End Class