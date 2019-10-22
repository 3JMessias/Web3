Imports Web3Project

Public Class CategoriaDAO
    Implements iDAO(Of CategoriaTO)

    Public Sub PreencheObj(ByRef Obj As CategoriaTO, id As Integer) Implements iDAO(Of CategoriaTO).PreencheObj
        Throw New NotImplementedException()
    End Sub

    Public Function Adiciona(Obj As CategoriaTO) As String Implements iDAO(Of CategoriaTO).Adiciona
        Throw New NotImplementedException()
    End Function

    Public Function Altera(Obj As CategoriaTO) As String Implements iDAO(Of CategoriaTO).Altera
        Throw New NotImplementedException()
    End Function

    Public Function Exclui(id As Integer) As String Implements iDAO(Of CategoriaTO).Exclui
        Throw New NotImplementedException()
    End Function

    Public Function Lista(texto As String) As DataSet Implements iDAO(Of CategoriaTO
        ).Lista

        Dim cn As New Conexao
        Dim result As New DataSet

        Dim sql As String
        sql = "SELECT idCategoria, nomeCategoria, Descricao " &
              "FROM Categorias " &
              "WHERE nomeCategoria LIKE '%" & texto & "%'"
        result = cn.ExecutaSqlRetorno(sql)
        Return result



    End Function

    Public Function PreencheCombo() As DataSet Implements iDAO(Of CategoriaTO).PreencheCombo

        Dim cn As New Conexao
        Dim sql As String
        sql = "select -1 as idCategoria, " &
            "'--Selecione--' as nomeCategoria " &
            "union all " &
            "select idCategoria, nomeCategoria " &
            "from Categorias "
        Return cn.ExecutaSqlRetorno(sql)

    End Function
End Class

