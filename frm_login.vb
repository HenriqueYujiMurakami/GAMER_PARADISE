Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frm_login
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        limpar_frm_login()
    End Sub

    Private Sub btn_acessar_login_Click(sender As Object, e As EventArgs) Handles btn_acessar_login.Click
        Try
            If (txt_usuario_login.Text = "adm" Or txt_usuario_login.Text = "adm@gmail.com") And txt_cpf_login.Text = "000.000.000-01" And txt_senha.Text = "1234" Then
                limpar_frm_login()
                frm_menu.ShowDialog()
                Exit Sub
            End If
            sql = "select * from tb_funcionarios where cpf='" & txt_cpf_login.Text & "' and senha = '" & txt_senha.Text & "' and nome= '" & txt_usuario_login.Text & "'"
            rs = db.Execute(UCase(sql))
            direcionar = rs.Fields(5).Value
            If rs.EOF = False Then
                If direcionar = "CAIXA" Then
                    limpar_frm_login()
                    frm_venda.ShowDialog()
                    Exit Sub
                ElseIf direcionar = "ESTOQUISTA" Then
                    limpar_frm_login()
                    frm_produto.ShowDialog()
                    Exit Sub
                Else
                    limpar_frm_login()
                    frm_menu.ShowDialog()
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox("Funcionário não encontrado!" + vbNewLine &
                   "Veirifique se preencheu os campos corretamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "FUNCIONÁRIO NÃO ENCONTRADO!")
            limpar_frm_login()
        End Try
    End Sub
End Class
