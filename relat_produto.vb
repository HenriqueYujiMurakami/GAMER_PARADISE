Public Class relat_produto
    Private Sub relat_produto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dados_produtos()
        campos_relat_produtos()
    End Sub

    Private Sub txt_pesquisa_TextChanged(sender As Object, e As EventArgs) Handles txt_pesquisa.TextChanged
        Try
            With dgv_produto
                .Rows.Clear()
                sql = "select * from tb_produtos where " & cmb_parametro.Text & " like '" & txt_pesquisa.Text & "%'"
                rs = db.Execute(sql)
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(6).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(1).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class