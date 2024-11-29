Public Class frm_relatorio
    Private Sub btn_emitir_relatorio_Click(sender As Object, e As EventArgs) Handles btn_emitir_relatorio.Click
        Try
            If cmb_tipo_relatorio.Text = "VENDA" Then
                relat_venda.ShowDialog()
            ElseIf cmb_tipo_relatorio.Text = "FUNCIONARIO" Then
                relat_funcionario.ShowDialog()
            ElseIf cmb_tipo_relatorio.Text = "PRODUTO" Then
                relat_produto.ShowDialog()
            End If
            limpar_frm_relatorio()
        Catch ex As Exception
            MsgBox("Erro ao chamar relatório" + vbNewLine &
                   "Erro: ", ex.Message + MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO!")
        End Try
    End Sub

    Private Sub CONTRATARDEMITIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONTRATARDEMITIRToolStripMenuItem.Click
        frm_cadastro.ShowDialog()
    End Sub
End Class