Module Module1
    Public resp, diretorio, sql, direcionar As String
    Public aux_cpf, aux_nome, aux_idproduto, aux_produto, aux_idvenda As String
    Public valor_unitario, quantidade, estoque, estoquefinal As Integer
    Public subtotal, res_subtotal, res_total, troco, receber, total As Integer
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset

    Sub conecta_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider = SQLOLEDB;Data Source=SALA07\SQLEXPRESS;Initial Catalog=gamer_paradise;trusted_connection=yes;")
            MsgBox("Conexão: OKAY!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO!")
        Catch ex As Exception
            MsgBox("Erro ao conectar com banco", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO!")
        End Try
    End Sub

    Sub limpar_frm_cadastro()
        Try
            With frm_cadastro
                .txt_nome_cadastro.Clear()
                .txt_email_cadastro.Clear()
                .txt_salario_cadastro.Clear()
                .txt_cpf_cadastro.Clear()
                .txt_senha.Clear()
                .cmb_cargo_cadastro.SelectedItem = Nothing
                .cmb_nascimento_cadastro.Value = Now
                .img_funcionario.Load(Application.StartupPath & "\fotos_funcionarios\adicionar_foto.png")
                .txt_nome_cadastro.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao limpar o formulário", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO!")
        End Try
    End Sub

    Sub limpar_frm_produto()
        Try
            With frm_produto
                .txt_usuario_produto.Clear()
                .txt_produto_produto.Clear()
                .txt_preco_produto.Clear()
                .txt_estoque_produto.Clear()
                .cmb_categoria_produto.SelectedItem = Nothing
                .cmb_fornecedor_produto.SelectedItem = Nothing
                .img_produto_produto.Load(Application.StartupPath & "\foto_produtos\adicionar_imagem.png")
                .txt_produto_produto.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao limpar o formulário", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO!")
        End Try
    End Sub

    Sub limpar_frm_venda()
        Try
            With frm_venda
                .txt_caixa_venda.Clear()
                .txt_cliente_venda.Clear()
                .txt_idproduto_venda.Clear()
                .txt_pesquisa_venda.Clear()
                .txt_produto_venda.Clear()
                .txt_qtde_venda.Clear()
                .txt_subtotal_venda.Clear()
                .txt_total_venda.Clear()
                .txt_valor_venda.Clear()
                .cmb_datacompra_venda.Value = Now
                .cmb_pagamento_venda.SelectedItem = Nothing
                .txt_receber_venda.Clear()
                .txt_troco_venda.Clear()
                .txt_cliente_venda.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao limpar o formulário" + vbNewLine &
                    "Erro: ", ex.Message + MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO!")
        End Try
    End Sub
    Sub limpar_frm_login()
        Try
            With frm_login
                .txt_usuario_login.Clear()
                .txt_cpf_login.Clear()
                .txt_senha.Clear()
                .txt_usuario_login.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao limpar o formulário", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO!")
        End Try
    End Sub
    Sub limpar_frm_relatorio()
        Try
            With frm_relatorio
                .cmb_tipo_relatorio.SelectedIndex = Nothing
                .cmb_tipo_relatorio.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao limpar o formulário", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO!")
        End Try
    End Sub

    Sub carregar_dados()
        Try
            With frm_cadastro.dgv_funcionario_cadastro
                .Rows.Clear()
                sql = "select * from tb_funcionarios order by cpf asc"
                rs = db.Execute(sql)
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(3).Value, rs.Fields(1).Value, rs.Fields(5).Value, rs.Fields(6).Value, Nothing)
                    rs.MoveNext()
                Loop
            End With

        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub carregar_produtos()
        Try
            With frm_produto.dgv_produto_produto
                .Rows.Clear()
                sql = "select * from tb_produtos order by id_produto asc"
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

    Sub carregar_venda()
        Try
            With frm_venda.dgv_vendas
                .Rows.Clear()
                sql = "select * from tb_vendas order by id_venda asc"
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

    Sub dados_produtos()
        Try
            With relat_produto.dgv_produto
                .Rows.Clear()
                sql = "select * from tb_produtos order by id_produto asc"
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

    Sub dados_funcionarios()
        Try
            With relat_funcionario.dgv_funcionario
                .Rows.Clear()
                sql = "select * from tb_funcionarios order by cpf asc"
                rs = db.Execute(sql)
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(3).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub dados_vendas()
        Try
            With relat_venda.dgv_vendas
                .Rows.Clear()
                sql = "select * from tb_vendas order by id_venda asc"
                rs = db.Execute(sql)
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, rs.Fields(8).Value, rs.Fields(9).Value, rs.Fields(10).Value, rs.Fields(11).Value, rs.Fields(12).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub campos_frm_cadastro()
        Try
            With frm_cadastro.cmb_parametro.Items
                .Add("NOME")
                .Add("CARGO")
            End With
            frm_cadastro.cmb_parametro.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao carregar campos!" + vbNewLine &
                   "ERRO: ", ex.Message + MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO!")
        End Try
    End Sub

    Sub campos_frm_produto()
        Try
            With frm_produto.cmb_parametro_produto.Items
                .Add("PRODUTO")
            End With
            frm_produto.cmb_parametro_produto.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao carregar campos!" + vbNewLine &
                   "ERRO: ", ex.Message + MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO!")
        End Try
    End Sub

    Sub campos_frm_venda()
        Try
            With frm_venda.cmb_parametro_venda.Items
                .Add("NOME_PRODUTO")
                .Add("CLIENTE")
            End With
            frm_venda.cmb_parametro_venda.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao carregar campos!" + vbNewLine &
                   "ERRO: ", ex.Message + MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO!")
        End Try
    End Sub

    Sub campos_relat_funcionarios()
        Try
            With relat_funcionario.cmb_parametro.Items
                .Add("NOME")
                .Add("CARGO")
                .Add("CPF")
            End With
            relat_funcionario.cmb_parametro.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao carregar campos!" + vbNewLine &
                   "ERRO: ", ex.Message + MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO!")
        End Try
    End Sub

    Sub campos_relat_produtos()
        Try
            With relat_produto.cmb_parametro.Items
                .Add("PRODUTO")
                .Add("USUARIO")
                .Add("CATEGORIA")
            End With
            relat_produto.cmb_parametro.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao carregar campos!" + vbNewLine &
                   "ERRO: ", ex.Message + MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO!")
        End Try
    End Sub

    Sub campos_relat_vendas()
        Try
            With relat_venda.cmb_parametro.Items
                .Add("CLIENTE")
                .Add("CAIXA")
                .Add("FORMA_PAGAMENTO")
                .Add("DATA_COMPRA")
            End With
            relat_venda.cmb_parametro.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao carregar campos!" + vbNewLine &
                   "ERRO: ", ex.Message + MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO!")
        End Try
    End Sub
End Module

