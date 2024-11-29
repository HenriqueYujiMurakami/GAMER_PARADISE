<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.img_logo = New System.Windows.Forms.PictureBox()
        Me.btn_emitir_relatorio_menu = New Guna.UI.WinForms.GunaButton()
        Me.btn_contratar_demitir_menu = New Guna.UI.WinForms.GunaButton()
        CType(Me.img_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "O QUE VOCÊ DESEJA FAZER?"
        '
        'img_logo
        '
        Me.img_logo.Image = CType(resources.GetObject("img_logo.Image"), System.Drawing.Image)
        Me.img_logo.Location = New System.Drawing.Point(420, 30)
        Me.img_logo.Name = "img_logo"
        Me.img_logo.Size = New System.Drawing.Size(234, 211)
        Me.img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_logo.TabIndex = 4
        Me.img_logo.TabStop = False
        '
        'btn_emitir_relatorio_menu
        '
        Me.btn_emitir_relatorio_menu.AnimationHoverSpeed = 0.07!
        Me.btn_emitir_relatorio_menu.AnimationSpeed = 0.03!
        Me.btn_emitir_relatorio_menu.BackColor = System.Drawing.Color.Transparent
        Me.btn_emitir_relatorio_menu.BaseColor = System.Drawing.Color.White
        Me.btn_emitir_relatorio_menu.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.btn_emitir_relatorio_menu.BorderSize = 3
        Me.btn_emitir_relatorio_menu.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_emitir_relatorio_menu.FocusedColor = System.Drawing.Color.Empty
        Me.btn_emitir_relatorio_menu.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_emitir_relatorio_menu.ForeColor = System.Drawing.Color.DarkCyan
        Me.btn_emitir_relatorio_menu.Image = CType(resources.GetObject("btn_emitir_relatorio_menu.Image"), System.Drawing.Image)
        Me.btn_emitir_relatorio_menu.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_emitir_relatorio_menu.Location = New System.Drawing.Point(40, 68)
        Me.btn_emitir_relatorio_menu.Name = "btn_emitir_relatorio_menu"
        Me.btn_emitir_relatorio_menu.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_emitir_relatorio_menu.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_emitir_relatorio_menu.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_emitir_relatorio_menu.OnHoverImage = Nothing
        Me.btn_emitir_relatorio_menu.OnPressedColor = System.Drawing.Color.Teal
        Me.btn_emitir_relatorio_menu.Radius = 25
        Me.btn_emitir_relatorio_menu.Size = New System.Drawing.Size(244, 72)
        Me.btn_emitir_relatorio_menu.TabIndex = 5
        Me.btn_emitir_relatorio_menu.Text = "EMITIR RELATÓRIO"
        '
        'btn_contratar_demitir_menu
        '
        Me.btn_contratar_demitir_menu.AnimationHoverSpeed = 0.07!
        Me.btn_contratar_demitir_menu.AnimationSpeed = 0.03!
        Me.btn_contratar_demitir_menu.BackColor = System.Drawing.Color.Transparent
        Me.btn_contratar_demitir_menu.BaseColor = System.Drawing.Color.White
        Me.btn_contratar_demitir_menu.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.btn_contratar_demitir_menu.BorderSize = 3
        Me.btn_contratar_demitir_menu.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_contratar_demitir_menu.FocusedColor = System.Drawing.Color.Empty
        Me.btn_contratar_demitir_menu.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_contratar_demitir_menu.ForeColor = System.Drawing.Color.DarkCyan
        Me.btn_contratar_demitir_menu.Image = CType(resources.GetObject("btn_contratar_demitir_menu.Image"), System.Drawing.Image)
        Me.btn_contratar_demitir_menu.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_contratar_demitir_menu.Location = New System.Drawing.Point(40, 169)
        Me.btn_contratar_demitir_menu.Name = "btn_contratar_demitir_menu"
        Me.btn_contratar_demitir_menu.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_contratar_demitir_menu.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_contratar_demitir_menu.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_contratar_demitir_menu.OnHoverImage = Nothing
        Me.btn_contratar_demitir_menu.OnPressedColor = System.Drawing.Color.Teal
        Me.btn_contratar_demitir_menu.Radius = 25
        Me.btn_contratar_demitir_menu.Size = New System.Drawing.Size(244, 72)
        Me.btn_contratar_demitir_menu.TabIndex = 6
        Me.btn_contratar_demitir_menu.Text = "CONTRATAR/DEMITIR"
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(711, 264)
        Me.Controls.Add(Me.btn_contratar_demitir_menu)
        Me.Controls.Add(Me.btn_emitir_relatorio_menu)
        Me.Controls.Add(Me.img_logo)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_menu"
        Me.Text = "MENU DE NAVEGAÇÃO"
        CType(Me.img_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents img_logo As PictureBox
    Friend WithEvents btn_emitir_relatorio_menu As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_contratar_demitir_menu As Guna.UI.WinForms.GunaButton
End Class
