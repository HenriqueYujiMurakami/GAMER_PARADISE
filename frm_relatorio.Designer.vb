<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_relatorio
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_relatorio))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_tipo_relatorio = New Guna.UI.WinForms.GunaComboBox()
        Me.btn_emitir_relatorio = New Guna.UI.WinForms.GunaButton()
        Me.GunaContextMenuStrip1 = New Guna.UI.WinForms.GunaContextMenuStrip()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CONTRATARDEMITIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TIPO DO RELATÓRIO:"
        '
        'cmb_tipo_relatorio
        '
        Me.cmb_tipo_relatorio.BackColor = System.Drawing.Color.Transparent
        Me.cmb_tipo_relatorio.BaseColor = System.Drawing.Color.White
        Me.cmb_tipo_relatorio.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.cmb_tipo_relatorio.BorderSize = 3
        Me.cmb_tipo_relatorio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_tipo_relatorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_relatorio.FocusedColor = System.Drawing.Color.Empty
        Me.cmb_tipo_relatorio.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipo_relatorio.ForeColor = System.Drawing.Color.DarkCyan
        Me.cmb_tipo_relatorio.FormattingEnabled = True
        Me.cmb_tipo_relatorio.Items.AddRange(New Object() {"VENDA", "FUNCIONARIO", "PRODUTO"})
        Me.cmb_tipo_relatorio.Location = New System.Drawing.Point(38, 55)
        Me.cmb_tipo_relatorio.Name = "cmb_tipo_relatorio"
        Me.cmb_tipo_relatorio.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_tipo_relatorio.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmb_tipo_relatorio.Radius = 10
        Me.cmb_tipo_relatorio.Size = New System.Drawing.Size(734, 29)
        Me.cmb_tipo_relatorio.TabIndex = 28
        '
        'btn_emitir_relatorio
        '
        Me.btn_emitir_relatorio.AnimationHoverSpeed = 0.07!
        Me.btn_emitir_relatorio.AnimationSpeed = 0.03!
        Me.btn_emitir_relatorio.BackColor = System.Drawing.Color.Transparent
        Me.btn_emitir_relatorio.BaseColor = System.Drawing.Color.Azure
        Me.btn_emitir_relatorio.BorderColor = System.Drawing.Color.SkyBlue
        Me.btn_emitir_relatorio.BorderSize = 3
        Me.btn_emitir_relatorio.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_emitir_relatorio.FocusedColor = System.Drawing.Color.Empty
        Me.btn_emitir_relatorio.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_emitir_relatorio.ForeColor = System.Drawing.Color.DarkCyan
        Me.btn_emitir_relatorio.Image = Nothing
        Me.btn_emitir_relatorio.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_emitir_relatorio.Location = New System.Drawing.Point(479, 111)
        Me.btn_emitir_relatorio.Name = "btn_emitir_relatorio"
        Me.btn_emitir_relatorio.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_emitir_relatorio.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_emitir_relatorio.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_emitir_relatorio.OnHoverImage = Nothing
        Me.btn_emitir_relatorio.OnPressedColor = System.Drawing.Color.Black
        Me.btn_emitir_relatorio.Radius = 25
        Me.btn_emitir_relatorio.Size = New System.Drawing.Size(293, 53)
        Me.btn_emitir_relatorio.TabIndex = 32
        Me.btn_emitir_relatorio.Text = "EMITIR RELATÓRIO"
        '
        'GunaContextMenuStrip1
        '
        Me.GunaContextMenuStrip1.BackColor = System.Drawing.Color.MidnightBlue
        Me.GunaContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.GunaContextMenuStrip1.Name = "GunaContextMenuStrip1"
        Me.GunaContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.GunaContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.GunaContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.GunaContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.GunaContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.GunaContextMenuStrip1.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        Me.GunaContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        Me.GunaContextMenuStrip1.Text = "CONTRATAR/DEMITIR"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.MidnightBlue
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CONTRATARDEMITIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(794, 28)
        Me.MenuStrip1.TabIndex = 35
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CONTRATARDEMITIRToolStripMenuItem
        '
        Me.CONTRATARDEMITIRToolStripMenuItem.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CONTRATARDEMITIRToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CONTRATARDEMITIRToolStripMenuItem.Image = CType(resources.GetObject("CONTRATARDEMITIRToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CONTRATARDEMITIRToolStripMenuItem.Name = "CONTRATARDEMITIRToolStripMenuItem"
        Me.CONTRATARDEMITIRToolStripMenuItem.Size = New System.Drawing.Size(232, 24)
        Me.CONTRATARDEMITIRToolStripMenuItem.Text = "CONTRATAR/DEMITIR"
        '
        'frm_relatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(794, 181)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btn_emitir_relatorio)
        Me.Controls.Add(Me.cmb_tipo_relatorio)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_relatorio"
        Me.Text = "EMISSÃO DE RELATÓRIO - GAMER PARADISE"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_tipo_relatorio As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents btn_emitir_relatorio As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaContextMenuStrip1 As Guna.UI.WinForms.GunaContextMenuStrip
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CONTRATARDEMITIRToolStripMenuItem As ToolStripMenuItem
End Class
