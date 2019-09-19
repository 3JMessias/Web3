Imports Web3Project

Public Class ProdutoDAO
    Implements iDAO

    Public Function Adiciona(Obj As ProdutoTO) As String
        Dim sql As New StringBuilder
        sql.Append("insert into Produtos")
        sql.Append("(")
        sql.Append("NomeProduto,")
        sql.Append("idCategoria,")
        sql.Append("Preco,")
        sql.Append("Estoque,")
        sql.Append("ForaDeLinha")
        sql.Append(")")
        sql.Append("values")
        sql.Append("(")
        sql.Append("'" & Obj.NomeProduto & "',")
        sql.Append(Obj.idCategoria & ",")
        sql.Append(Obj.Preco & ",")
        sql.Append(Obj.Estoque & ",")
        sql.Append(IIf(Obj.ForaDeLinha, 1, 0))
        sql.Append(")")
        Dim cn As New Conexao
        Return cn.ExecutaSqlNew(sql.ToString)
    End Function

    Public Function Adiciona(ByRef categorias As CategoriasTO) As String Implements iDAO.Adiciona
        Throw New NotImplementedException()
    End Function

    Public Function Altera(Obj As Table) As String Implements iDAO.Altera
        Throw New NotImplementedException()
    End Function

    Public Function Exclui(id As Integer) As String Implements iDAO.Exclui
        Throw New NotImplementedException()
    End Function

    Public Function Lista(texto As String) As DataSet Implements iDAO.Lista

        Dim cn As New Conexao
        Dim result As New DataSet
        Dim sql As String
        sql = "SELECT idProduto, NomeProduto, Preco " &
            "FROM Produtos " &
            "WHERE NomeProduto LIKE '%" & texto & "%'"
        result = cn.ExecutaSqlRetorno(sql)
        Return result

    End Function

    Public Function PreecheObj(ByRef Obj As Table, ByRef id As String) As Object Implements iDAO.PreecheObj
        Throw New NotImplementedException()
    End Function

    Public Function PreencheCombo() As DataSet Implements iDAO.PreencheCombo
        Throw New NotImplementedException()
    End Function

    Private Function iDAO_Adiciona(Obj As ProdutoTO) As String Implements iDAO.Adiciona
        Throw New NotImplementedException()
    End Function
End Class
