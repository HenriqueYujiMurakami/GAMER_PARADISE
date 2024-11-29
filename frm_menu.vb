Public Class frm_menu
    Private Sub btn_emitir_relatorio_menu_Click(sender As Object, e As EventArgs) Handles btn_emitir_relatorio_menu.Click
        Try
            frm_relatorio.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro ao chamar formulário", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO AO CHAMAR!")
        End Try
    End Sub

    Private Sub btn_contratar_demitir_menu_Click(sender As Object, e As EventArgs) Handles btn_contratar_demitir_menu.Click
        Try
            frm_cadastro.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro ao chamar formulário", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO AO CHAMAR!")
        End Try
    End Sub
End Class