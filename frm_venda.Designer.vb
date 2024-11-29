<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_venda
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_venda))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_pesquisa_venda = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_parametro_venda = New System.Windows.Forms.ToolStripComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_valor_venda = New System.Windows.Forms.MaskedTextBox()
        Me.txt_subtotal_venda = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_total_venda = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_caixa_venda = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_cliente_venda = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_idproduto_venda = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_produto_venda = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_qtde_venda = New Guna.UI.WinForms.GunaTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_datacompra_venda = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.txt_troco_venda = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_receber_venda = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmb_pagamento_venda = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaContextMenuStrip1 = New Guna.UI.WinForms.GunaContextMenuStrip()
        Me.GunaContextMenuStrip2 = New Guna.UI.WinForms.GunaContextMenuStrip()
        Me.btn_adicionar_venda = New Guna.UI.WinForms.GunaButton()
        Me.btn_finalizar_venda = New Guna.UI.WinForms.GunaButton()
        Me.dgv_vendas = New System.Windows.Forms.DataGridView()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_vendas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.MidnightBlue
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txt_pesquisa_venda, Me.ToolStripSeparator1, Me.ToolStripSeparator2, Me.ToolStripLabel2, Me.cmb_parametro_venda})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(1298, 25)
        Me.ToolStrip1.TabIndex = 21
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(365, 22)
        Me.ToolStripLabel1.Text = "DIGITE O PRODUTO A SER PESQUISADO: "
        '
        'txt_pesquisa_venda
        '
        Me.txt_pesquisa_venda.Font = New System.Drawing.Font("Century", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pesquisa_venda.ForeColor = System.Drawing.Color.DarkCyan
        Me.txt_pesquisa_venda.Name = "txt_pesquisa_venda"
        Me.txt_pesquisa_venda.Size = New System.Drawing.Size(111, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(373, 22)
        Me.ToolStripLabel2.Text = "ESCOLHA UM PARAMETRO DE PESQUISA: "
        '
        'cmb_parametro_venda
        '
        Me.cmb_parametro_venda.Font = New System.Drawing.Font("Century", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_parametro_venda.ForeColor = System.Drawing.Color.DarkCyan
        Me.cmb_parametro_venda.Name = "cmb_parametro_venda"
        Me.cmb_parametro_venda.Size = New System.Drawing.Size(134, 25)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID PRODUTO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(177, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NOME DO PRODUTO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "NOME DO CLIENTE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "QUANTIDADE:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(212, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "PREÇO UNITÁRIO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(474, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "SUBTOTAL:"
        '
        'txt_valor_venda
        '
        Me.txt_valor_venda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_valor_venda.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_valor_venda.ForeColor = System.Drawing.Color.DarkCyan
        Me.txt_valor_venda.Location = New System.Drawing.Point(216, 249)
        Me.txt_valor_venda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_valor_venda.Name = "txt_valor_venda"
        Me.txt_valor_venda.Size = New System.Drawing.Size(212, 28)
        Me.txt_valor_venda.TabIndex = 6
        '
        'txt_subtotal_venda
        '
        Me.txt_subtotal_venda.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subtotal_venda.ForeColor = System.Drawing.Color.DarkCyan
        Me.txt_subtotal_venda.Location = New System.Drawing.Point(477, 249)
        Me.txt_subtotal_venda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_subtotal_venda.Name = "txt_subtotal_venda"
        Me.txt_subtotal_venda.Size = New System.Drawing.Size(192, 28)
        Me.txt_subtotal_venda.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(717, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "DATA DA COMPRA:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(276, 370)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(168, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "TOTAL DA COMPRA:"
        '
        'txt_total_venda
        '
        Me.txt_total_venda.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_venda.ForeColor = System.Drawing.Color.DarkCyan
        Me.txt_total_venda.Location = New System.Drawing.Point(280, 393)
        Me.txt_total_venda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_total_venda.Name = "txt_total_venda"
        Me.txt_total_venda.Size = New System.Drawing.Size(188, 28)
        Me.txt_total_venda.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 17)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "NOME DO CAIXA:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(483, 373)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(207, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "FORMA DE PAGAMENTO:"
        '
        'txt_caixa_venda
        '
        Me.txt_caixa_venda.BackColor = System.Drawing.Color.Transparent
        Me.txt_caixa_venda.BaseColor = System.Drawing.Color.White
        Me.txt_caixa_venda.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.txt_caixa_venda.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_caixa_venda.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_caixa_venda.FocusedBorderColor = System.Drawing.Color.MidnightBlue
        Me.txt_caixa_venda.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_caixa_venda.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_caixa_venda.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txt_caixa_venda.Location = New System.Drawing.Point(26, 49)
        Me.txt_caixa_venda.Name = "txt_caixa_venda"
        Me.txt_caixa_venda.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_caixa_venda.Radius = 15
        Me.txt_caixa_venda.SelectedText = ""
        Me.txt_caixa_venda.Size = New System.Drawing.Size(967, 32)
        Me.txt_caixa_venda.TabIndex = 1
        '
        'txt_cliente_venda
        '
        Me.txt_cliente_venda.BackColor = System.Drawing.Color.Transparent
        Me.txt_cliente_venda.BaseColor = System.Drawing.Color.White
        Me.txt_cliente_venda.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.txt_cliente_venda.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cliente_venda.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_cliente_venda.FocusedBorderColor = System.Drawing.Color.MidnightBlue
        Me.txt_cliente_venda.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_cliente_venda.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cliente_venda.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txt_cliente_venda.Location = New System.Drawing.Point(26, 112)
        Me.txt_cliente_venda.Name = "txt_cliente_venda"
        Me.txt_cliente_venda.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cliente_venda.Radius = 15
        Me.txt_cliente_venda.SelectedText = ""
        Me.txt_cliente_venda.Size = New System.Drawing.Size(967, 32)
        Me.txt_cliente_venda.TabIndex = 2
        '
        'txt_idproduto_venda
        '
        Me.txt_idproduto_venda.BackColor = System.Drawing.Color.Transparent
        Me.txt_idproduto_venda.BaseColor = System.Drawing.Color.White
        Me.txt_idproduto_venda.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.txt_idproduto_venda.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_idproduto_venda.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_idproduto_venda.FocusedBorderColor = System.Drawing.Color.MidnightBlue
        Me.txt_idproduto_venda.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_idproduto_venda.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idproduto_venda.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txt_idproduto_venda.Location = New System.Drawing.Point(26, 172)
        Me.txt_idproduto_venda.Name = "txt_idproduto_venda"
        Me.txt_idproduto_venda.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_idproduto_venda.Radius = 15
        Me.txt_idproduto_venda.SelectedText = ""
        Me.txt_idproduto_venda.Size = New System.Drawing.Size(126, 32)
        Me.txt_idproduto_venda.TabIndex = 3
        '
        'txt_produto_venda
        '
        Me.txt_produto_venda.BackColor = System.Drawing.Color.Transparent
        Me.txt_produto_venda.BaseColor = System.Drawing.Color.White
        Me.txt_produto_venda.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.txt_produto_venda.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_produto_venda.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_produto_venda.FocusedBorderColor = System.Drawing.Color.MidnightBlue
        Me.txt_produto_venda.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_produto_venda.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_produto_venda.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txt_produto_venda.Location = New System.Drawing.Point(180, 172)
        Me.txt_produto_venda.Name = "txt_produto_venda"
        Me.txt_produto_venda.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_produto_venda.Radius = 15
        Me.txt_produto_venda.SelectedText = ""
        Me.txt_produto_venda.Size = New System.Drawing.Size(813, 32)
        Me.txt_produto_venda.TabIndex = 4
        '
        'txt_qtde_venda
        '
        Me.txt_qtde_venda.BackColor = System.Drawing.Color.Transparent
        Me.txt_qtde_venda.BaseColor = System.Drawing.Color.White
        Me.txt_qtde_venda.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.txt_qtde_venda.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_qtde_venda.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_qtde_venda.FocusedBorderColor = System.Drawing.Color.MidnightBlue
        Me.txt_qtde_venda.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_qtde_venda.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qtde_venda.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txt_qtde_venda.Location = New System.Drawing.Point(31, 248)
        Me.txt_qtde_venda.Name = "txt_qtde_venda"
        Me.txt_qtde_venda.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_qtde_venda.Radius = 15
        Me.txt_qtde_venda.SelectedText = ""
        Me.txt_qtde_venda.Size = New System.Drawing.Size(157, 32)
        Me.txt_qtde_venda.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmb_datacompra_venda)
        Me.GroupBox1.Controls.Add(Me.txt_qtde_venda)
        Me.GroupBox1.Controls.Add(Me.txt_produto_venda)
        Me.GroupBox1.Controls.Add(Me.txt_idproduto_venda)
        Me.GroupBox1.Controls.Add(Me.txt_cliente_venda)
        Me.GroupBox1.Controls.Add(Me.txt_caixa_venda)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_subtotal_venda)
        Me.GroupBox1.Controls.Add(Me.txt_valor_venda)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Azure
        Me.GroupBox1.Location = New System.Drawing.Point(254, 52)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1032, 307)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMAÇÕES DA COMPRA"
        '
        'cmb_datacompra_venda
        '
        Me.cmb_datacompra_venda.BackColor = System.Drawing.Color.Transparent
        Me.cmb_datacompra_venda.BaseColor = System.Drawing.Color.White
        Me.cmb_datacompra_venda.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.cmb_datacompra_venda.CustomFormat = Nothing
        Me.cmb_datacompra_venda.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.cmb_datacompra_venda.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_datacompra_venda.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_datacompra_venda.ForeColor = System.Drawing.Color.DarkCyan
        Me.cmb_datacompra_venda.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_datacompra_venda.Location = New System.Drawing.Point(720, 248)
        Me.cmb_datacompra_venda.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.cmb_datacompra_venda.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.cmb_datacompra_venda.Name = "cmb_datacompra_venda"
        Me.cmb_datacompra_venda.OnHoverBaseColor = System.Drawing.Color.White
        Me.cmb_datacompra_venda.OnHoverBorderColor = System.Drawing.Color.MidnightBlue
        Me.cmb_datacompra_venda.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_datacompra_venda.OnPressedColor = System.Drawing.Color.Black
        Me.cmb_datacompra_venda.Radius = 15
        Me.cmb_datacompra_venda.Size = New System.Drawing.Size(273, 30)
        Me.cmb_datacompra_venda.TabIndex = 8
        Me.cmb_datacompra_venda.Text = "17/11/2024"
        Me.cmb_datacompra_venda.Value = New Date(2024, 11, 17, 16, 49, 49, 940)
        '
        'txt_troco_venda
        '
        Me.txt_troco_venda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_troco_venda.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_troco_venda.ForeColor = System.Drawing.Color.DarkCyan
        Me.txt_troco_venda.Location = New System.Drawing.Point(975, 393)
        Me.txt_troco_venda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_troco_venda.Name = "txt_troco_venda"
        Me.txt_troco_venda.Size = New System.Drawing.Size(272, 28)
        Me.txt_troco_venda.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(971, 371)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 17)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "TROCO:"
        '
        'txt_receber_venda
        '
        Me.txt_receber_venda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_receber_venda.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_receber_venda.ForeColor = System.Drawing.Color.DarkCyan
        Me.txt_receber_venda.Location = New System.Drawing.Point(752, 393)
        Me.txt_receber_venda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_receber_venda.Name = "txt_receber_venda"
        Me.txt_receber_venda.Size = New System.Drawing.Size(195, 28)
        Me.txt_receber_venda.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(748, 371)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(166, 17)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "VALOR A RECEBER:"
        '
        'cmb_pagamento_venda
        '
        Me.cmb_pagamento_venda.BackColor = System.Drawing.Color.Transparent
        Me.cmb_pagamento_venda.BaseColor = System.Drawing.Color.White
        Me.cmb_pagamento_venda.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.cmb_pagamento_venda.BorderSize = 3
        Me.cmb_pagamento_venda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_pagamento_venda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_pagamento_venda.FocusedColor = System.Drawing.Color.Empty
        Me.cmb_pagamento_venda.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_pagamento_venda.ForeColor = System.Drawing.Color.DarkCyan
        Me.cmb_pagamento_venda.FormattingEnabled = True
        Me.cmb_pagamento_venda.Items.AddRange(New Object() {"DINHEIRO", "PIX", "DEBITO", "CREDITO - À VISTA"})
        Me.cmb_pagamento_venda.Location = New System.Drawing.Point(486, 393)
        Me.cmb_pagamento_venda.Name = "cmb_pagamento_venda"
        Me.cmb_pagamento_venda.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_pagamento_venda.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmb_pagamento_venda.Radius = 10
        Me.cmb_pagamento_venda.Size = New System.Drawing.Size(240, 29)
        Me.cmb_pagamento_venda.TabIndex = 10
        '
        'GunaContextMenuStrip1
        '
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
        '
        'GunaContextMenuStrip2
        '
        Me.GunaContextMenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.GunaContextMenuStrip2.Name = "GunaContextMenuStrip2"
        Me.GunaContextMenuStrip2.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaContextMenuStrip2.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaContextMenuStrip2.RenderStyle.ColorTable = Nothing
        Me.GunaContextMenuStrip2.RenderStyle.RoundedEdges = True
        Me.GunaContextMenuStrip2.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.GunaContextMenuStrip2.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaContextMenuStrip2.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.GunaContextMenuStrip2.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.GunaContextMenuStrip2.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        Me.GunaContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'btn_adicionar_venda
        '
        Me.btn_adicionar_venda.AnimationHoverSpeed = 0.07!
        Me.btn_adicionar_venda.AnimationSpeed = 0.03!
        Me.btn_adicionar_venda.BackColor = System.Drawing.Color.Transparent
        Me.btn_adicionar_venda.BaseColor = System.Drawing.Color.Azure
        Me.btn_adicionar_venda.BorderColor = System.Drawing.Color.SkyBlue
        Me.btn_adicionar_venda.BorderSize = 3
        Me.btn_adicionar_venda.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_adicionar_venda.FocusedColor = System.Drawing.Color.Empty
        Me.btn_adicionar_venda.Font = New System.Drawing.Font("Centaur", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_adicionar_venda.ForeColor = System.Drawing.Color.DarkCyan
        Me.btn_adicionar_venda.Image = Nothing
        Me.btn_adicionar_venda.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_adicionar_venda.Location = New System.Drawing.Point(14, 60)
        Me.btn_adicionar_venda.Name = "btn_adicionar_venda"
        Me.btn_adicionar_venda.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_adicionar_venda.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_adicionar_venda.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_adicionar_venda.OnHoverImage = Nothing
        Me.btn_adicionar_venda.OnPressedColor = System.Drawing.Color.Black
        Me.btn_adicionar_venda.Radius = 25
        Me.btn_adicionar_venda.Size = New System.Drawing.Size(234, 73)
        Me.btn_adicionar_venda.TabIndex = 25
        Me.btn_adicionar_venda.Text = "ADIOCIONAR PRODUTO"
        '
        'btn_finalizar_venda
        '
        Me.btn_finalizar_venda.AnimationHoverSpeed = 0.07!
        Me.btn_finalizar_venda.AnimationSpeed = 0.03!
        Me.btn_finalizar_venda.BackColor = System.Drawing.Color.Transparent
        Me.btn_finalizar_venda.BaseColor = System.Drawing.Color.Azure
        Me.btn_finalizar_venda.BorderColor = System.Drawing.Color.SkyBlue
        Me.btn_finalizar_venda.BorderSize = 3
        Me.btn_finalizar_venda.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_finalizar_venda.FocusedColor = System.Drawing.Color.Empty
        Me.btn_finalizar_venda.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_finalizar_venda.ForeColor = System.Drawing.Color.DarkCyan
        Me.btn_finalizar_venda.Image = Nothing
        Me.btn_finalizar_venda.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_finalizar_venda.Location = New System.Drawing.Point(12, 164)
        Me.btn_finalizar_venda.Name = "btn_finalizar_venda"
        Me.btn_finalizar_venda.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_finalizar_venda.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_finalizar_venda.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_finalizar_venda.OnHoverImage = Nothing
        Me.btn_finalizar_venda.OnPressedColor = System.Drawing.Color.Black
        Me.btn_finalizar_venda.Radius = 25
        Me.btn_finalizar_venda.Size = New System.Drawing.Size(234, 73)
        Me.btn_finalizar_venda.TabIndex = 26
        Me.btn_finalizar_venda.Text = "FINALIZAR COMPRA"
        '
        'dgv_vendas
        '
        Me.dgv_vendas.AllowUserToAddRows = False
        Me.dgv_vendas.AllowUserToDeleteRows = False
        Me.dgv_vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_vendas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column7})
        Me.dgv_vendas.Location = New System.Drawing.Point(254, 448)
        Me.dgv_vendas.Name = "dgv_vendas"
        Me.dgv_vendas.ReadOnly = True
        Me.dgv_vendas.RowHeadersWidth = 51
        Me.dgv_vendas.RowTemplate.Height = 24
        Me.dgv_vendas.Size = New System.Drawing.Size(1032, 338)
        Me.dgv_vendas.TabIndex = 27
        '
        'Column8
        '
        Me.Column8.HeaderText = "ID VENDA"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 125
        '
        'Column1
        '
        Me.Column1.HeaderText = "CLIENTE"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "PRODUTO"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "QTDE"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "PREÇO"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "SUBTOTAL"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 125
        '
        'Column7
        '
        Me.Column7.HeaderText = "REMOVER"
        Me.Column7.Image = CType(resources.GetObject("Column7.Image"), System.Drawing.Image)
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 125
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'frm_venda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(1298, 801)
        Me.Controls.Add(Me.txt_troco_venda)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_receber_venda)
        Me.Controls.Add(Me.dgv_vendas)
        Me.Controls.Add(Me.btn_finalizar_venda)
        Me.Controls.Add(Me.cmb_pagamento_venda)
        Me.Controls.Add(Me.btn_adicionar_venda)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_total_venda)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Font = New System.Drawing.Font("Century", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_venda"
        Me.Text = "TELA DE VENDA"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_vendas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_pesquisa_venda As ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cmb_parametro_venda As ToolStripComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_valor_venda As MaskedTextBox
    Friend WithEvents txt_subtotal_venda As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_total_venda As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_caixa_venda As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_cliente_venda As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_idproduto_venda As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_produto_venda As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_qtde_venda As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GunaContextMenuStrip1 As Guna.UI.WinForms.GunaContextMenuStrip
    Friend WithEvents GunaContextMenuStrip2 As Guna.UI.WinForms.GunaContextMenuStrip
    Friend WithEvents btn_adicionar_venda As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_finalizar_venda As Guna.UI.WinForms.GunaButton
    Friend WithEvents cmb_pagamento_venda As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cmb_datacompra_venda As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents dgv_vendas As DataGridView
    Friend WithEvents txt_troco_venda As MaskedTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_receber_venda As MaskedTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewImageColumn
End Class
