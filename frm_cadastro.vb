Public Class frm_cadastro
    Private nascimento As DateTime
    Private idade As Integer = 0

    Private Sub frm_cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        limpar_frm_cadastro()
        carregar_dados()
        campos_frm_cadastro()
    End Sub

    Private Sub img_funcionario_Click(sender As Object, e As EventArgs) Handles img_funcionario.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma foto"
                .InitialDirectory = Application.StartupPath & "\fotos_funcionarios\"
                .ShowDialog()
                diretorio = .FileName
                img_funcionario.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            DateTime.TryParse(cmb_nascimento_cadastro.Text, nascimento)
            idade = DateTime.Now.Year - nascimento.Year
            If idade >= 18 Then
                sql = "SELECT * FROM tb_funcionarios WHERE cpf ='" & txt_cpf_cadastro.Text & "'"
                rs = db.Execute(sql)
                'diretorio = rs.Fields(8).Value
                If rs.EOF = True Then
                    sql = "INSERT INTO tb_funcionarios (nome,email,cpf,data_nascimento,cargo,salario,senha,foto) " &
                      "VALUES ('" & txt_nome_cadastro.Text & "', " &
                      "'" & txt_email_cadastro.Text & "', " &
                      "'" & txt_cpf_cadastro.Text & "', " &
                      "'" & cmb_nascimento_cadastro.Value.Date & "', " &
                      "'" & cmb_cargo_cadastro.Text & "', " &
                      "" & txt_salario_cadastro.Text & ", " &
                      "'" & txt_senha.Text & "', '" & diretorio & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Funcionário: " & txt_nome_cadastro.Text & " contratado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "FUNCIONÁRIO CONTRATADO!")
                Else
                    sql = "UPDATE tb_funcionarios SET nome='" & txt_nome_cadastro.Text & "', " &
                      "email='" & txt_email_cadastro.Text & "', " &
                      "cpf='" & txt_cpf_cadastro.Text & "', " &
                      "data_nascimento='" & cmb_nascimento_cadastro.Value.Date & "', " &
                      "cargo ='" & cmb_cargo_cadastro.Text & "', " &
                      "salario = " & txt_salario_cadastro.Text & ", " &
                      "senha='" & txt_senha.Text & "', " &
                      "foto='" & diretorio & "' " &
                      "WHERE cpf = '" & txt_cpf_cadastro.Text & "'"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Dados do funcionário: " & txt_cpf_cadastro.Text & " alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "DADOS ATUALIZADOS!")
                    limpar_frm_cadastro()
                    cmb_cargo_cadastro.SelectedItem = Nothing
                End If
                limpar_frm_cadastro()
                carregar_dados()
            Else
                limpar_frm_cadastro()
                MsgBox("Só é permitido a contratação de funcionários maiores que 18 anos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "FUNCONÁRIO MENOR DE 18")
            End If
            limpar_frm_cadastro()
            carregar_dados()
        Catch ex As Exception
            MsgBox("Erro ao contratar funcionário: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO!")
        End Try
    End Sub

    Private Sub dgv_funcionario_cadastro_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_funcionario_cadastro.CellContentClick
        Try
            With dgv_funcionario_cadastro
                If .CurrentRow.Cells(4).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(0).Value
                    sql = "select * from tb_funcionarios where cpf='" & aux_cpf & "'"
                    rs = db.Execute(sql)
                    diretorio = rs.Fields(8).Value
                    If rs.EOF = False Then
                        txt_cpf_cadastro.Text = rs.Fields(3).Value
                        txt_nome_cadastro.Text = rs.Fields(1).Value
                        txt_email_cadastro.Text = rs.Fields(2).Value
                        cmb_nascimento_cadastro.Value = rs.Fields(4).Value
                        cmb_cargo_cadastro.Text = rs.Fields(5).Value
                        txt_salario_cadastro.Text = rs.Fields(6).Value
                        txt_senha.Text = rs.Fields(7).Value
                        img_funcionario.Load(rs.Fields(8).Value)
                    End If
                ElseIf .CurrentRow.Cells(5).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(0).Value
                    sql = "select * from tb_funcionarios where cpf = '" & aux_cpf & "'"
                    rs = db.Execute(sql)
                    aux_nome = .CurrentRow.Cells(1).Value
                    If rs.EOF = False Then
                        resp = MsgBox("Funcionário a ser demitido: " & aux_nome & "" + vbNewLine &
                                      "Deseja realmente demitir funcionário?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "DEMISSÃO DE FUNCIONÁRIO")
                        If resp = MsgBoxResult.Yes Then
                            sql = "delete from tb_funcionarios where cpf = '" & aux_cpf & "'"
                            rs = db.Execute(sql)
                            MsgBox("Funcionário foi demitido!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "DEMISSÃO CONCLUÍDA!")
                            limpar_frm_cadastro()
                            carregar_dados()
                        End If
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados!", ex.Message + MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO!")
        End Try
    End Sub


    Private Sub txt_pesquisa_TextChanged(sender As Object, e As EventArgs) Handles txt_pesquisa.TextChanged
        Try
            With dgv_funcionario_cadastro
                .Rows.Clear()
                sql = "select * from tb_funcionarios where " & cmb_parametro.Text & " like '" & txt_pesquisa.Text & "%'"
                rs = db.Execute(sql)
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(3).Value, rs.Fields(1).Value, rs.Fields(5).Value, rs.Fields(6).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub EMITIRRELATÓRIOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EMITIRRELATÓRIOToolStripMenuItem.Click
        frm_relatorio.ShowDialog()
    End Sub
End Class