Imports Web3Project

Public Class VendedoresDAO
    Implements iDAO(Of VendedoresTO)

    Public Sub PreencheObj(ByRef Obj As VendedoresTO, id As Integer) Implements iDAO(Of VendedoresTO).PreencheObj
        Dim sql As String
        sql = "select * from Vendedores where idVendedor = " & id

        Dim rs As New DataSet
        Dim reg As DataRow
        Dim cn As New Conexao
        rs = cn.ExecutaSqlRetorno(sql)
        reg = rs.Tables(0).Rows(0) 'um unico registro

        With Obj
            .IdVendedor = reg(0)
            .NomeVendedor = reg(1)
            .DataAdmissao = reg(2)
            .Sexo = reg(3)
            .Salario = reg(4)
            If reg(5) Is DBNull.Value Then
                .DataDemissao = ""

            Else
                .DataDemissao = reg(5)

            End If
        End With
    End Sub

    Public Function Adiciona(Obj As VendedoresTO) As String Implements iDAO(Of VendedoresTO).Adiciona
        Dim cn As New Conexao
        Dim sql As New StringBuilder
        With sql
            .Append("INSERT INTO Vendedores")
            .Append("(")
            .Append("NomeVendedor,")
            .Append("Sexo,")
            .Append("Salario,")
            .Append("DataAdmissao,")
            .Append("DataDemissao")
            .Append(")")
            .Append("VALUES")
            .Append("(")
            .Append("'" & Obj.NomeVendedor & "',")
            .Append("'" & Obj.Sexo & "',")
            .Append(Obj.Salario & ",")
            .Append("'" & Obj.DataAdmissao & "',")
            .Append("null")
            .Append(")")
        End With
        Return cn.ExecutaSqlNew(sql.ToString)
    End Function

    Public Function Altera(Obj As VendedoresTO) As String Implements iDAO(Of VendedoresTO).Altera
        Throw New NotImplementedException()
    End Function

    Public Function Exclui(id As Integer) As String Implements iDAO(Of VendedoresTO).Exclui
        Dim sql As String
        sql = "DELETE FROM Vendedores WHERE idVendedor = " & id
        Dim cn As New Conexao
        Return cn.ExecutaSqlNew(sql)
    End Function

    Public Function Lista(texto As String) As DataSet Implements iDAO(Of VendedoresTO).Lista
        Dim cn As New Conexao
        Dim result As New DataSet

        Dim sql As String
        sql = "SELECT idVendedor, NomeVendedor, Sexo, Salario, DataAdmissao " &
              "FROM Vendedores " &
              "WHERE NomeVendedor LIKE '%" & texto & "%'"
        result = cn.ExecutaSqlRetorno(sql)
        Return result
    End Function

    Public Function PreencheCombo() As DataSet Implements iDAO(Of VendedoresTO).PreencheCombo
        Throw New NotImplementedException()
    End Function
End Class
