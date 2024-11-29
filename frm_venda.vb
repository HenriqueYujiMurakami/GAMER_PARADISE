Public Class frm_venda
    Private total_geral As Integer = 0
    Private Sub frm_venda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        limpar_frm_venda()
        campos_frm_venda()
        carregar_venda()
    End Sub

    Private Sub txt_idproduto_venda_TextChanged(sender As Object, e As EventArgs) Handles txt_idproduto_venda.TextChanged
        Try
            sql = "select * from tb_produtos where id_produto= " & txt_idproduto_venda.Text & ""
            rs = db.Execute(sql)
            estoque = rs.Fields(5).Value
            If rs.EOF = False Then
                txt_produto_venda.Text = rs.Fields(2).Value
                txt_valor_venda.Text = rs.Fields(4).Value
            End If
            If estoque = 0 Then
                MsgBox("Produto em falta no estoque!" + vbNewLine &
                       "Por favor, informe um novo produto!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "PRODUTO EM FALTA!")
                txt_idproduto_venda.Clear()
                txt_produto_venda.Clear()
                txt_valor_venda.Clear()
                txt_idproduto_venda.Focus()
            ElseIf estoque > 0 Then
                MsgBox("Quantidade do produto disponível no estoque: " & estoque & "", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_subtotal_venda_LostFocus(sender As Object, e As EventArgs) Handles txt_subtotal_venda.LostFocus
        valor_unitario = 0 : quantidade = 0 : res_subtotal = 0 : res_total = 0
        valor_unitario = txt_valor_venda.Text
        quantidade = txt_qtde_venda.Text
        res_subtotal = valor_unitario * quantidade
        txt_subtotal_venda.Text = res_subtotal
        res_total = res_subtotal + res_total
        txt_total_venda.Text = res_total

        total_geral += res_subtotal
        txt_total_venda.Text = total_geral
    End Sub
    Private Sub btn_adicionar_venda_Click(sender As Object, e As EventArgs) Handles btn_adicionar_venda.Click
        Try
            sql = "insert into tb_vendas (caixa, cliente, id_produto, nome_produto, qtde_produto, valor_unitario, subtotal, data_compra) " &
                  "values ('" & txt_caixa_venda.Text & "', " &
                  "'" & txt_cliente_venda.Text & "', " &
                  "" & txt_idproduto_venda.Text & ", " &
                  "'" & txt_produto_venda.Text & "', " &
                  "" & txt_qtde_venda.Text & ", " &
                  "" & txt_valor_venda.Text & ", " &
                  "" & txt_subtotal_venda.Text & ", '" & cmb_datacompra_venda.Value.Date & "')"
            rs = db.Execute(UCase(sql))
            sql = "select * from tb_produtos where id_produto = " & txt_idproduto_venda.Text & ""
            rs = db.Execute(sql)
            estoque = rs.Fields(5).Value
            txt_qtde_venda.Text = quantidade
            estoquefinal = estoque - quantidade
            sql = "update tb_produtos set qtde =" & estoquefinal & "" &
                  "where id_produto=" & txt_idproduto_venda.Text & ""
            rs = db.Execute(UCase(sql))
            txt_idproduto_venda.Clear()
            txt_produto_venda.Clear()
            txt_qtde_venda.Clear()
            txt_valor_venda.Clear()
            txt_subtotal_venda.Clear()
            txt_idproduto_venda.Focus()
            carregar_venda()
        Catch ex As Exception
            MsgBox("Erro ao adiconar compra" + vbNewLine &
                   "Erro: ", ex.Message + MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO!")
        End Try
    End Sub

    Private Sub btn_finalizar_venda_Click(sender As Object, e As EventArgs) Handles btn_finalizar_venda.Click
        Try
            resp = MsgBox("Deseja finalizar compra?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "FINALIZAR COMPRA!")
            If resp = MsgBoxResult.Yes Then
                sql = "insert into tb_vendas (caixa, cliente, total_compra, forma_pagamento, valor_receber, troco) " &
                      "values('" & txt_caixa_venda.Text & "', " &
                      "'" & txt_cliente_venda.Text & "', " &
                      "" & txt_total_venda.Text & ", " &
                      "'" & cmb_pagamento_venda.Text & "', " &
                      "" & txt_receber_venda.Text & ", " & txt_troco_venda.Text & ")"
                rs = db.Execute(UCase(sql))
                total_geral = 0
                MsgBox("Compra cadastrada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "COMPRA FINALZADA")
            Else
                txt_idproduto_venda.Focus()
            End If
            limpar_frm_venda()
            carregar_venda()
        Catch ex As Exception
            MsgBox("Erro ao finalizar compra" + vbNewLine &
                   "Erro: ", ex.Message + MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO!")
        End Try
    End Sub

    Private Sub dgv_vendas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_vendas.CellContentClick
        Try
            With dgv_vendas
                If .CurrentRow.Cells(6).Selected = True Then
                    aux_idvenda = .CurrentRow.Cells(0).Value
                    sql = "select * from tb_vendas where id_venda = " & aux_idvenda & ""
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        resp = MsgBox("Deseja a venda de ID: " & aux_idvenda & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "REMOVER VENDA!")
                        If resp = MsgBoxResult.Yes Then
                            sql = "delete from tb_vendas where id_venda = " & aux_idvenda & ""
                            rs = db.Execute(sql)
                            MsgBox("Venda removida com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "VENDA REMOVIDA!")
                            carregar_venda()
                        End If
                    End If
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_pesquisa_venda_TextChanged(sender As Object, e As EventArgs) Handles txt_pesquisa_venda.TextChanged
        Try
            With dgv_vendas
                .Rows.Clear()
                sql = "select * from tb_vendas where " & cmb_parametro_venda.Text & " like '" & txt_pesquisa_venda.Text & "%'"
                rs = db.Execute(sql)
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Private Sub txt_receber_venda_LostFocus(sender As Object, e As EventArgs) Handles txt_receber_venda.LostFocus
        total = 0 : receber = 0 : troco = 0
        receber = txt_receber_venda.Text
        total = txt_total_venda.Text
        troco = receber - total
        If troco >= 0 Then
            txt_troco_venda.Text = troco
            Exit Sub
        Else
            MsgBox("Valor recebido não paga o total da compra!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO!")
        End If
    End Sub

End Class