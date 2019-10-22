Public Class ProdutoDAO
    Implements iDAO(Of ProdutoTO)

    Public Sub PreencheObj(ByRef Obj As ProdutoTO, id As Integer) Implements iDAO(Of ProdutoTO).PreencheObj

        Dim sql As String
        sql = "select * from Produtos where idProduto = " & id

        Dim rs As New DataSet
        Dim reg As DataRow
        Dim cn As New Conexao
        rs = cn.ExecutaSqlRetorno(sql)
        reg = rs.Tables(0).Rows(0) 'um unico registro

        Obj.idProduto = reg(0)
        Obj.NomeProduto = reg(1)
        Obj.idCategoria = reg(2)
        Obj.Preco = reg(3)
        Obj.Estoque = reg(4)
        Obj.ForaDeLinha = reg(5)



    End Sub


    Public Function Adiciona(Obj As ProdutoTO) As String Implements iDAO(Of ProdutoTO).Adiciona

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

    Public Function Altera(Obj As ProdutoTO) As String Implements iDAO(Of ProdutoTO).Altera
        Dim sql As New StringBuilder
        sql.Append("update Produtos set ")
        sql.Append("NomeProduto='" & Obj.NomeProduto & "',")
        sql.Append("idCategoria = " & Obj.idCategoria & ",")
        sql.Append("Preco = " & Obj.Preco & ",")
        sql.Append("Estoque =" & Obj.Estoque & ",")
        sql.Append("ForaDeLinha =" & IIf(Obj.ForaDeLinha, 1, 0))
        sql.Append(" where idProduto = " & Obj.idProduto)

        Dim cn As New Conexao
        Return cn.ExecutaSqlNew(sql.ToString)

    End Function

    Public Function Exclui(id As Integer) As String Implements iDAO(Of ProdutoTO).Exclui
        Dim sql As String
        sql = "DELETE FROM Produtos WHERE idProduto = " & id
        Dim cn As New Conexao
        Return cn.ExecutaSqlNew(sql)
    End Function

    Public Function Lista(texto As String) As DataSet Implements iDAO(Of ProdutoTO).Lista

        Dim cn As New Conexao
        Dim result As New DataSet

        Dim sql As String
        sql = "SELECT idProduto, NomeProduto, Preco " &
              "FROM Produtos " &
              "WHERE NomeProduto LIKE '%" & texto & "%'"
        result = cn.ExecutaSqlRetorno(sql)
        Return result
    End Function

    Public Function PreencheCombo() As DataSet Implements iDAO(Of ProdutoTO).PreencheCombo
        Throw New NotImplementedException()
    End Function
End Class
