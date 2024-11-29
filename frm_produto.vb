Public Class frm_produto
    Private Sub frm_produto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        limpar_frm_produto()
        carregar_produtos()
        campos_frm_produto()
    End Sub

    Private Sub btn_gravar_produto_Click(sender As Object, e As EventArgs) Handles btn_gravar_produto.Click
        Try
            sql = "select * from tb_produtos where produto= '" & txt_produto_produto.Text & "'"
            rs = db.Execute(UCase(sql))
            If rs.EOF = True Then
                sql = "insert into tb_produtos (usuario, produto, categoria, preco, qtde, fornecedor, imagem) " &
                      "values ('" & txt_usuario_produto.Text & "', " &
                      "'" & txt_produto_produto.Text & "', " &
                      "'" & cmb_categoria_produto.Text & "', " &
                      "" & txt_preco_produto.Text & ", " &
                      "" & txt_estoque_produto.Text & ", " &
                      "'" & cmb_fornecedor_produto.Text & "', '" & diretorio & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Produto: " & txt_produto_produto.Text & " cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "PRODUTO CADASTRADO!")
            Else
                sql = "update tb_produtos set usuario='" & txt_usuario_produto.Text & "', " &
                      "produto='" & txt_produto_produto.Text & "'," &
                      "categoria='" & cmb_categoria_produto.Text & "', " &
                      "preco = " & txt_preco_produto.Text & ", " &
                      "qtde = " & txt_estoque_produto.Text & ", " &
                      "fornecedor='" & cmb_fornecedor_produto.Text & "', " &
                      "imagem='" & diretorio & "' " &
                      "where produto= '" & txt_produto_produto.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Produto: " & txt_produto_produto.Text & " atualizado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "PRODUTO ATUALIZADO!")
            End If
            carregar_produtos()
            limpar_frm_produto()
        Catch ex As Exception
            MsgBox("Erro ao cadastrar produto!" + vbNewLine &
                   "Erro:", ex.Message + MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub img_produto_produto_Click(sender As Object, e As EventArgs) Handles img_produto_produto.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione a foto do produto"
                .InitialDirectory = Application.StartupPath & "\foto_produtos\"
                .ShowDialog()
                diretorio = .FileName
                img_produto_produto.Load(diretorio)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgv_produto_produto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_produto_produto.CellContentClick
        Try
            With dgv_produto_produto
                If .CurrentRow.Cells(4).Selected = True Then
                    aux_idproduto = .CurrentRow.Cells(0).Value
                    sql = "select * from tb_produtos where id_produto = " & aux_idproduto & ""
                    rs = db.Execute(sql)
                    diretorio = rs.Fields(7).Value
                    If rs.EOF = False Then
                        txt_usuario_produto.Text = rs.Fields(1).Value
                        txt_produto_produto.Text = rs.Fields(2).Value
                        cmb_categoria_produto.Text = rs.Fields(3).Value
                        txt_preco_produto.Text = rs.Fields(4).Value
                        txt_estoque_produto.Text = rs.Fields(5).Value
                        cmb_fornecedor_produto.Text = rs.Fields(6).Value
                        img_produto_produto.Load(rs.Fields(7).Value)
                    End If
                ElseIf .CurrentRow.Cells(5).Selected = True Then
                    aux_idproduto = .CurrentRow.Cells(0).Value
                    sql = "select * from tb_produtos where id_produto = " & aux_idproduto & ""
                    rs = db.Execute(sql)
                    aux_produto = .CurrentRow.Cells(1).Value
                    If rs.EOF = False Then
                        resp = MsgBox("Deseja remover o produto: " & aux_produto & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "REMOÇÃO DE PRODUTO")
                        If resp = MsgBoxResult.Yes Then
                            sql = "delete from tb_produtos where id_produto = " & aux_idproduto & ""
                            rs = db.Execute(sql)
                            MsgBox("Produto: " & aux_produto & " removido com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "PRODUTO REMOVIDO!")
                            carregar_produtos()
                            limpar_frm_produto()
                        End If
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("ERRO: ", ex.Message + MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO!")
        End Try
    End Sub

    Private Sub txt_pesquisa_produto_TextChanged(sender As Object, e As EventArgs) Handles txt_pesquisa_produto.TextChanged
        Try
            With dgv_produto_produto
                .Rows.Clear()
                sql = "select * from tb_produtos where " & cmb_parametro_produto.Text & " like '" & txt_pesquisa_produto.Text & "%'"
                rs = db.Execute(sql)
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(4).Value, rs.Fields(5).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class