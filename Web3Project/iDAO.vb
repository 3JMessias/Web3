Imports Web3Project

Public Interface iDAO
    Function Adiciona(Obj As ProdutoTO) As String
    Function Altera(ByVal Obj As Table) As String
    Function Exclui(ByVal id As Integer) As String
    Function Adiciona(ByRef categorias As CategoriasTO) As String
    Function Lista(ByVal texto As String) As DataSet
    Function PreecheObj(ByRef Obj As Table, ByRef id As String)
    Function PreencheCombo() As DataSet

End Interface
