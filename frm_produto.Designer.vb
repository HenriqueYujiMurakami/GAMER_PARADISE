<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_produto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_produto))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_preco_produto = New System.Windows.Forms.MaskedTextBox()
        Me.txt_estoque_produto = New Guna.UI.WinForms.GunaTextBox()
        Me.cmb_fornecedor_produto = New Guna.UI.WinForms.GunaComboBox()
        Me.cmb_categoria_produto = New Guna.UI.WinForms.GunaComboBox()
        Me.txt_produto_produto = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_usuario_produto = New Guna.UI.WinForms.GunaTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_produto_produto = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_pesquisa_produto = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_parametro_produto = New System.Windows.Forms.ToolStripComboBox()
        Me.img_produto_produto = New Guna.UI.WinForms.GunaPictureBox()
        Me.btn_gravar_produto = New Guna.UI.WinForms.GunaButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_produto_produto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.img_produto_produto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_preco_produto)
        Me.GroupBox1.Controls.Add(Me.txt_estoque_produto)
        Me.GroupBox1.Controls.Add(Me.cmb_fornecedor_produto)
        Me.GroupBox1.Controls.Add(Me.cmb_categoria_produto)
        Me.GroupBox1.Controls.Add(Me.txt_produto_produto)
        Me.GroupBox1.Controls.Add(Me.txt_usuario_produto)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(330, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(966, 315)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FORNEÇA AS INFORMAÇÕES DO PRODUTO"
        '
        'txt_preco_produto
        '
        Me.txt_preco_produto.Font = New System.Drawing.Font("Century", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_preco_produto.ForeColor = System.Drawing.Color.DarkCyan
        Me.txt_preco_produto.Location = New System.Drawing.Point(301, 193)
        Me.txt_preco_produto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_preco_produto.Name = "txt_preco_produto"
        Me.txt_preco_produto.Size = New System.Drawing.Size(244, 32)
        Me.txt_preco_produto.TabIndex = 4
        '
        'txt_estoque_produto
        '
        Me.txt_estoque_produto.BackColor = System.Drawing.Color.Transparent
        Me.txt_estoque_produto.BaseColor = System.Drawing.Color.White
        Me.txt_estoque_produto.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.txt_estoque_produto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_estoque_produto.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_estoque_produto.FocusedBorderColor = System.Drawing.Color.MidnightBlue
        Me.txt_estoque_produto.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_estoque_produto.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_estoque_produto.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txt_estoque_produto.Location = New System.Drawing.Point(34, 193)
        Me.txt_estoque_produto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_estoque_produto.Name = "txt_estoque_produto"
        Me.txt_estoque_produto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_estoque_produto.Radius = 15
        Me.txt_estoque_produto.SelectedText = ""
        Me.txt_estoque_produto.Size = New System.Drawing.Size(240, 32)
        Me.txt_estoque_produto.TabIndex = 3
        '
        'cmb_fornecedor_produto
        '
        Me.cmb_fornecedor_produto.BackColor = System.Drawing.Color.Transparent
        Me.cmb_fornecedor_produto.BaseColor = System.Drawing.Color.White
        Me.cmb_fornecedor_produto.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.cmb_fornecedor_produto.BorderSize = 3
        Me.cmb_fornecedor_produto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_fornecedor_produto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_fornecedor_produto.FocusedColor = System.Drawing.Color.Empty
        Me.cmb_fornecedor_produto.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_fornecedor_produto.ForeColor = System.Drawing.Color.DarkCyan
        Me.cmb_fornecedor_produto.FormattingEnabled = True
        Me.cmb_fornecedor_produto.Items.AddRange(New Object() {"Microsoft", "Sony ", "Nintendo", "Atari", "EA Games", "Ubisoft", "Rockstar Games", "Capcom", "Sega", "Naughty Dog", "Warner Bros "})
        Me.cmb_fornecedor_produto.Location = New System.Drawing.Point(302, 252)
        Me.cmb_fornecedor_produto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmb_fornecedor_produto.Name = "cmb_fornecedor_produto"
        Me.cmb_fornecedor_produto.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_fornecedor_produto.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmb_fornecedor_produto.Radius = 10
        Me.cmb_fornecedor_produto.Size = New System.Drawing.Size(245, 33)
        Me.cmb_fornecedor_produto.TabIndex = 6
        '
        'cmb_categoria_produto
        '
        Me.cmb_categoria_produto.BackColor = System.Drawing.Color.Transparent
        Me.cmb_categoria_produto.BaseColor = System.Drawing.Color.White
        Me.cmb_categoria_produto.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.cmb_categoria_produto.BorderSize = 3
        Me.cmb_categoria_produto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_categoria_produto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_categoria_produto.FocusedColor = System.Drawing.Color.Empty
        Me.cmb_categoria_produto.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_categoria_produto.ForeColor = System.Drawing.Color.DarkCyan
        Me.cmb_categoria_produto.FormattingEnabled = True
        Me.cmb_categoria_produto.Items.AddRange(New Object() {"JOGO", "CONSOLE", "CONTROLE"})
        Me.cmb_categoria_produto.Location = New System.Drawing.Point(37, 252)
        Me.cmb_categoria_produto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmb_categoria_produto.Name = "cmb_categoria_produto"
        Me.cmb_categoria_produto.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_categoria_produto.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmb_categoria_produto.Radius = 10
        Me.cmb_categoria_produto.Size = New System.Drawing.Size(245, 33)
        Me.cmb_categoria_produto.TabIndex = 5
        '
        'txt_produto_produto
        '
        Me.txt_produto_produto.BackColor = System.Drawing.Color.Transparent
        Me.txt_produto_produto.BaseColor = System.Drawing.Color.White
        Me.txt_produto_produto.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.txt_produto_produto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_produto_produto.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_produto_produto.FocusedBorderColor = System.Drawing.Color.MidnightBlue
        Me.txt_produto_produto.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_produto_produto.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_produto_produto.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txt_produto_produto.Location = New System.Drawing.Point(33, 130)
        Me.txt_produto_produto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_produto_produto.Name = "txt_produto_produto"
        Me.txt_produto_produto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_produto_produto.Radius = 15
        Me.txt_produto_produto.SelectedText = ""
        Me.txt_produto_produto.Size = New System.Drawing.Size(856, 32)
        Me.txt_produto_produto.TabIndex = 2
        '
        'txt_usuario_produto
        '
        Me.txt_usuario_produto.BackColor = System.Drawing.Color.Transparent
        Me.txt_usuario_produto.BaseColor = System.Drawing.Color.White
        Me.txt_usuario_produto.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.txt_usuario_produto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_usuario_produto.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_usuario_produto.FocusedBorderColor = System.Drawing.Color.MidnightBlue
        Me.txt_usuario_produto.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_usuario_produto.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario_produto.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txt_usuario_produto.Location = New System.Drawing.Point(33, 67)
        Me.txt_usuario_produto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_usuario_produto.Name = "txt_usuario_produto"
        Me.txt_usuario_produto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_usuario_produto.Radius = 15
        Me.txt_usuario_produto.SelectedText = ""
        Me.txt_usuario_produto.Size = New System.Drawing.Size(856, 32)
        Me.txt_usuario_produto.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "USUÁRIO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(298, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "FORNECEDOR:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "QTDE NO ESTOQUE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(297, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "PREÇO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(251, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "CATEGORIA DO PRODUTO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "NOME DO PRODUTO:"
        '
        'dgv_produto_produto
        '
        Me.dgv_produto_produto.AllowUserToAddRows = False
        Me.dgv_produto_produto.AllowUserToDeleteRows = False
        Me.dgv_produto_produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_produto_produto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgv_produto_produto.Location = New System.Drawing.Point(330, 382)
        Me.dgv_produto_produto.Name = "dgv_produto_produto"
        Me.dgv_produto_produto.ReadOnly = True
        Me.dgv_produto_produto.RowHeadersWidth = 62
        Me.dgv_produto_produto.RowTemplate.Height = 28
        Me.dgv_produto_produto.Size = New System.Drawing.Size(966, 283)
        Me.dgv_produto_produto.TabIndex = 15
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID PRODUTO"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "NOME "
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "PREÇO"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "QTDE NO ESTOQUE"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "EDITAR"
        Me.Column5.Image = CType(resources.GetObject("Column5.Image"), System.Drawing.Image)
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "REMOVER"
        Me.Column6.Image = CType(resources.GetObject("Column6.Image"), System.Drawing.Image)
        Me.Column6.MinimumWidth = 8
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 150
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.MidnightBlue
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txt_pesquisa_produto, Me.ToolStripSeparator1, Me.ToolStripSeparator2, Me.ToolStripLabel2, Me.cmb_parametro_produto})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1317, 30)
        Me.ToolStrip1.TabIndex = 17
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(340, 25)
        Me.ToolStripLabel1.Text = "DIGITE O TERMO A PESQUISAR: "
        '
        'txt_pesquisa_produto
        '
        Me.txt_pesquisa_produto.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pesquisa_produto.ForeColor = System.Drawing.Color.DarkCyan
        Me.txt_pesquisa_produto.Name = "txt_pesquisa_produto"
        Me.txt_pesquisa_produto.Size = New System.Drawing.Size(111, 30)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(443, 25)
        Me.ToolStripLabel2.Text = "SELECIONE O PARÂMETRO DE PESQUISA: "
        Me.ToolStripLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_parametro_produto
        '
        Me.cmb_parametro_produto.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_parametro_produto.ForeColor = System.Drawing.Color.DarkCyan
        Me.cmb_parametro_produto.Name = "cmb_parametro_produto"
        Me.cmb_parametro_produto.Size = New System.Drawing.Size(134, 30)
        '
        'img_produto_produto
        '
        Me.img_produto_produto.BackColor = System.Drawing.Color.AliceBlue
        Me.img_produto_produto.BaseColor = System.Drawing.Color.White
        Me.img_produto_produto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_produto_produto.Image = CType(resources.GetObject("img_produto_produto.Image"), System.Drawing.Image)
        Me.img_produto_produto.Location = New System.Drawing.Point(20, 49)
        Me.img_produto_produto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.img_produto_produto.Name = "img_produto_produto"
        Me.img_produto_produto.Size = New System.Drawing.Size(302, 273)
        Me.img_produto_produto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_produto_produto.TabIndex = 29
        Me.img_produto_produto.TabStop = False
        '
        'btn_gravar_produto
        '
        Me.btn_gravar_produto.AnimationHoverSpeed = 0.07!
        Me.btn_gravar_produto.AnimationSpeed = 0.03!
        Me.btn_gravar_produto.BackColor = System.Drawing.Color.Transparent
        Me.btn_gravar_produto.BaseColor = System.Drawing.Color.Azure
        Me.btn_gravar_produto.BorderColor = System.Drawing.Color.SkyBlue
        Me.btn_gravar_produto.BorderSize = 3
        Me.btn_gravar_produto.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_gravar_produto.FocusedColor = System.Drawing.Color.Empty
        Me.btn_gravar_produto.Font = New System.Drawing.Font("Centaur", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gravar_produto.ForeColor = System.Drawing.Color.DarkCyan
        Me.btn_gravar_produto.Image = Nothing
        Me.btn_gravar_produto.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_gravar_produto.Location = New System.Drawing.Point(13, 382)
        Me.btn_gravar_produto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_gravar_produto.Name = "btn_gravar_produto"
        Me.btn_gravar_produto.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_gravar_produto.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_gravar_produto.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_gravar_produto.OnHoverImage = Nothing
        Me.btn_gravar_produto.OnPressedColor = System.Drawing.Color.Black
        Me.btn_gravar_produto.Radius = 35
        Me.btn_gravar_produto.Size = New System.Drawing.Size(309, 106)
        Me.btn_gravar_produto.TabIndex = 7
        Me.btn_gravar_produto.Text = "CADASTRAR PRODUTO"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_produto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(1317, 679)
        Me.Controls.Add(Me.btn_gravar_produto)
        Me.Controls.Add(Me.img_produto_produto)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgv_produto_produto)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Century", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_produto"
        Me.Text = "CADASTRO DE PRODUTOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_produto_produto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.img_produto_produto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgv_produto_produto As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_pesquisa_produto As ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cmb_parametro_produto As ToolStripComboBox
    Friend WithEvents txt_produto_produto As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_usuario_produto As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents cmb_fornecedor_produto As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cmb_categoria_produto As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents img_produto_produto As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents txt_estoque_produto As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_preco_produto As MaskedTextBox
    Friend WithEvents btn_gravar_produto As Guna.UI.WinForms.GunaButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
