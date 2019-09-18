Imports Web3Project

Public Class ProdutoDAO
    Implements iDAO

    Public Function Adiciona(Obj As Table) As String Implements iDAO.Adiciona
        'Dim cn As New Conexao
        'Dim sql As String
        'sql = "INSERT INTO Produtos(nomeProduto,preco)" &
        '    "VALUES('" & Obj.NomeProduto & "','" &
        '            Obj.Preco & "')"
        'Return cn.ExecutaSqlNew(sql)
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
End Class
