Imports Web3Project

Public Class CategoriasDAO
    Implements iDAO

    Function Adiciona(ByRef categorias As CategoriasTO) As String
        Dim cn As New Conexao
        Dim sql As String
        sql = "INSERT INTO Categorias(nomeCategoria,descricao)" &
            "VALUES('" & categorias.NomeCategoria & "','" &
                    categorias.Descricao & "')"
        Return cn.ExecutaSqlNew(sql)

    End Function

    Public Function Adiciona(Obj As ProdutoTO) As String Implements iDAO.Adiciona
        Throw New NotImplementedException()
    End Function

    Public Function ListarCategoria(texto As String) As DataSet Implements iDAO.Lista

        Dim cn As New Conexao
        Dim result As New DataSet
        Dim sql As String
        sql = "SELECT NomeCategoria, Descricao " &
            "FROM Categorias " &
            "WHERE NomeCategoria LIKE '%" & texto & "%'"
        result = cn.ExecutaSqlRetorno(sql)
        Return result

    End Function

    Public Function Altera(Obj As Table) As String Implements iDAO.Altera
        Throw New NotImplementedException()
    End Function

    Public Function Exclui(id As Integer) As String Implements iDAO.Exclui
        Throw New NotImplementedException()
    End Function

    Public Function PreecheObj(ByRef Obj As Table, ByRef id As String) As Object Implements iDAO.PreecheObj
        Throw New NotImplementedException()
    End Function

    Function PreencheCombo() As DataSet Implements iDAO.PreencheCombo
        Dim cn As New Conexao
        Dim sql As String
        sql = "select -1 as idCategoria, '--Selecione--' as nomeCategoria " &
              "union all " &
              "select idcategoria, nomecategoria " &
              "from Categorias"
        Return cn.ExecutaSqlRetorno(sql)
    End Function

    Private Function iDAO_Adiciona(ByRef categorias As CategoriasTO) As String Implements iDAO.Adiciona
        Throw New NotImplementedException()
    End Function
End Class
