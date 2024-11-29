<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cadastro))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_salario_cadastro = New Guna.UI.WinForms.GunaTextBox()
        Me.cmb_nascimento_cadastro = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.txt_senha = New Guna.UI.WinForms.GunaTextBox()
        Me.cmb_cargo_cadastro = New Guna.UI.WinForms.GunaComboBox()
        Me.txt_email_cadastro = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_nome_cadastro = New Guna.UI.WinForms.GunaTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cpf_cadastro = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EMITIRRELATÓRIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgv_funcionario_cadastro = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.img_funcionario = New Guna.UI.WinForms.GunaPictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_pesquisa = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_parametro = New System.Windows.Forms.ToolStripComboBox()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgv_funcionario_cadastro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_funcionario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_salario_cadastro)
        Me.GroupBox1.Controls.Add(Me.cmb_nascimento_cadastro)
        Me.GroupBox1.Controls.Add(Me.txt_senha)
        Me.GroupBox1.Controls.Add(Me.cmb_cargo_cadastro)
        Me.GroupBox1.Controls.Add(Me.txt_email_cadastro)
        Me.GroupBox1.Controls.Add(Me.txt_nome_cadastro)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_cpf_cadastro)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(325, 87)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(1018, 424)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORME OS DADOS DO FUNCIONÁRIO"
        '
        'txt_salario_cadastro
        '
        Me.txt_salario_cadastro.BackColor = System.Drawing.Color.Transparent
        Me.txt_salario_cadastro.BaseColor = System.Drawing.Color.White
        Me.txt_salario_cadastro.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.txt_salario_cadastro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_salario_cadastro.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_salario_cadastro.FocusedBorderColor = System.Drawing.Color.MidnightBlue
        Me.txt_salario_cadastro.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_salario_cadastro.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_salario_cadastro.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txt_salario_cadastro.Location = New System.Drawing.Point(35, 295)
        Me.txt_salario_cadastro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_salario_cadastro.Name = "txt_salario_cadastro"
        Me.txt_salario_cadastro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_salario_cadastro.Radius = 15
        Me.txt_salario_cadastro.SelectedText = ""
        Me.txt_salario_cadastro.Size = New System.Drawing.Size(291, 32)
        Me.txt_salario_cadastro.TabIndex = 5
        '
        'cmb_nascimento_cadastro
        '
        Me.cmb_nascimento_cadastro.BackColor = System.Drawing.Color.Transparent
        Me.cmb_nascimento_cadastro.BaseColor = System.Drawing.Color.White
        Me.cmb_nascimento_cadastro.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.cmb_nascimento_cadastro.CustomFormat = Nothing
        Me.cmb_nascimento_cadastro.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.cmb_nascimento_cadastro.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_nascimento_cadastro.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_nascimento_cadastro.ForeColor = System.Drawing.Color.DarkCyan
        Me.cmb_nascimento_cadastro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_nascimento_cadastro.Location = New System.Drawing.Point(398, 220)
        Me.cmb_nascimento_cadastro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmb_nascimento_cadastro.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.cmb_nascimento_cadastro.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.cmb_nascimento_cadastro.Name = "cmb_nascimento_cadastro"
        Me.cmb_nascimento_cadastro.OnHoverBaseColor = System.Drawing.Color.White
        Me.cmb_nascimento_cadastro.OnHoverBorderColor = System.Drawing.Color.MidnightBlue
        Me.cmb_nascimento_cadastro.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_nascimento_cadastro.OnPressedColor = System.Drawing.Color.Black
        Me.cmb_nascimento_cadastro.Radius = 15
        Me.cmb_nascimento_cadastro.Size = New System.Drawing.Size(334, 30)
        Me.cmb_nascimento_cadastro.TabIndex = 4
        Me.cmb_nascimento_cadastro.Text = "17/11/2024"
        Me.cmb_nascimento_cadastro.Value = New Date(2024, 11, 17, 16, 49, 49, 940)
        '
        'txt_senha
        '
        Me.txt_senha.BackColor = System.Drawing.Color.Transparent
        Me.txt_senha.BaseColor = System.Drawing.Color.White
        Me.txt_senha.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.txt_senha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_senha.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_senha.FocusedBorderColor = System.Drawing.Color.MidnightBlue
        Me.txt_senha.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_senha.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txt_senha.Location = New System.Drawing.Point(31, 373)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Radius = 15
        Me.txt_senha.SelectedText = ""
        Me.txt_senha.Size = New System.Drawing.Size(281, 32)
        Me.txt_senha.TabIndex = 7
        '
        'cmb_cargo_cadastro
        '
        Me.cmb_cargo_cadastro.BackColor = System.Drawing.Color.Transparent
        Me.cmb_cargo_cadastro.BaseColor = System.Drawing.Color.White
        Me.cmb_cargo_cadastro.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.cmb_cargo_cadastro.BorderSize = 3
        Me.cmb_cargo_cadastro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_cargo_cadastro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cargo_cadastro.FocusedColor = System.Drawing.Color.Empty
        Me.cmb_cargo_cadastro.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_cargo_cadastro.ForeColor = System.Drawing.Color.DarkCyan
        Me.cmb_cargo_cadastro.FormattingEnabled = True
        Me.cmb_cargo_cadastro.Items.AddRange(New Object() {"CAIXA", "ESTOQUISTA", "GERENTE "})
        Me.cmb_cargo_cadastro.Location = New System.Drawing.Point(406, 294)
        Me.cmb_cargo_cadastro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmb_cargo_cadastro.Name = "cmb_cargo_cadastro"
        Me.cmb_cargo_cadastro.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_cargo_cadastro.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmb_cargo_cadastro.Radius = 10
        Me.cmb_cargo_cadastro.Size = New System.Drawing.Size(283, 29)
        Me.cmb_cargo_cadastro.TabIndex = 6
        '
        'txt_email_cadastro
        '
        Me.txt_email_cadastro.BackColor = System.Drawing.Color.Transparent
        Me.txt_email_cadastro.BaseColor = System.Drawing.Color.White
        Me.txt_email_cadastro.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.txt_email_cadastro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_email_cadastro.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_email_cadastro.FocusedBorderColor = System.Drawing.Color.MidnightBlue
        Me.txt_email_cadastro.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_email_cadastro.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email_cadastro.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txt_email_cadastro.Location = New System.Drawing.Point(32, 143)
        Me.txt_email_cadastro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_email_cadastro.Name = "txt_email_cadastro"
        Me.txt_email_cadastro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_email_cadastro.Radius = 15
        Me.txt_email_cadastro.SelectedText = ""
        Me.txt_email_cadastro.Size = New System.Drawing.Size(926, 32)
        Me.txt_email_cadastro.TabIndex = 2
        '
        'txt_nome_cadastro
        '
        Me.txt_nome_cadastro.BackColor = System.Drawing.Color.Transparent
        Me.txt_nome_cadastro.BaseColor = System.Drawing.Color.White
        Me.txt_nome_cadastro.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.txt_nome_cadastro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nome_cadastro.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_nome_cadastro.FocusedBorderColor = System.Drawing.Color.MidnightBlue
        Me.txt_nome_cadastro.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_nome_cadastro.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_cadastro.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txt_nome_cadastro.Location = New System.Drawing.Point(32, 66)
        Me.txt_nome_cadastro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_nome_cadastro.Name = "txt_nome_cadastro"
        Me.txt_nome_cadastro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nome_cadastro.Radius = 15
        Me.txt_nome_cadastro.SelectedText = ""
        Me.txt_nome_cadastro.Size = New System.Drawing.Size(926, 32)
        Me.txt_nome_cadastro.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 347)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(178, 21)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "DIGITE A SENHA:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 271)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 21)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "SALÁRIO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(401, 267)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "CARGO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(394, 195)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "NASCIMENTO:"
        '
        'txt_cpf_cadastro
        '
        Me.txt_cpf_cadastro.Font = New System.Drawing.Font("Century", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf_cadastro.ForeColor = System.Drawing.Color.DarkCyan
        Me.txt_cpf_cadastro.Location = New System.Drawing.Point(35, 220)
        Me.txt_cpf_cadastro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_cpf_cadastro.Mask = "999,999,999-99"
        Me.txt_cpf_cadastro.Name = "txt_cpf_cadastro"
        Me.txt_cpf_cadastro.Size = New System.Drawing.Size(283, 28)
        Me.txt_cpf_cadastro.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 195)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(199, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "CPF FUNCIONÁRIO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 117)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(253, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "EMAIL DO FUNCIONÁRIO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "NOME DO FUNCIONÁRIO"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.MidnightBlue
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EMITIRRELATÓRIOToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(11, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1375, 34)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EMITIRRELATÓRIOToolStripMenuItem
        '
        Me.EMITIRRELATÓRIOToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EMITIRRELATÓRIOToolStripMenuItem.Image = CType(resources.GetObject("EMITIRRELATÓRIOToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EMITIRRELATÓRIOToolStripMenuItem.Name = "EMITIRRELATÓRIOToolStripMenuItem"
        Me.EMITIRRELATÓRIOToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.EMITIRRELATÓRIOToolStripMenuItem.Size = New System.Drawing.Size(172, 28)
        Me.EMITIRRELATÓRIOToolStripMenuItem.Text = "EMITIR RELATÓRIO"
        '
        'dgv_funcionario_cadastro
        '
        Me.dgv_funcionario_cadastro.AllowUserToAddRows = False
        Me.dgv_funcionario_cadastro.AllowUserToDeleteRows = False
        Me.dgv_funcionario_cadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_funcionario_cadastro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgv_funcionario_cadastro.Location = New System.Drawing.Point(325, 519)
        Me.dgv_funcionario_cadastro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgv_funcionario_cadastro.Name = "dgv_funcionario_cadastro"
        Me.dgv_funcionario_cadastro.ReadOnly = True
        Me.dgv_funcionario_cadastro.RowHeadersWidth = 62
        Me.dgv_funcionario_cadastro.RowTemplate.Height = 28
        Me.dgv_funcionario_cadastro.Size = New System.Drawing.Size(1018, 162)
        Me.dgv_funcionario_cadastro.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.HeaderText = "CPF "
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "NOME"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "CARGO"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "SALÁRIO"
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
        Me.Column6.HeaderText = "DEMITIR"
        Me.Column6.Image = CType(resources.GetObject("Column6.Image"), System.Drawing.Image)
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column6.Width = 125
        '
        'img_funcionario
        '
        Me.img_funcionario.BackColor = System.Drawing.Color.AliceBlue
        Me.img_funcionario.BaseColor = System.Drawing.Color.White
        Me.img_funcionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_funcionario.Image = CType(resources.GetObject("img_funcionario.Image"), System.Drawing.Image)
        Me.img_funcionario.Location = New System.Drawing.Point(15, 96)
        Me.img_funcionario.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.img_funcionario.Name = "img_funcionario"
        Me.img_funcionario.Size = New System.Drawing.Size(302, 325)
        Me.img_funcionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_funcionario.TabIndex = 28
        Me.img_funcionario.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.MidnightBlue
        Me.ToolStrip1.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txt_pesquisa, Me.ToolStripSeparator1, Me.ToolStripSeparator2, Me.ToolStripLabel2, Me.cmb_parametro})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 34)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1375, 28)
        Me.ToolStrip1.TabIndex = 29
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(193, 25)
        Me.ToolStripLabel1.Text = "TERMO A PESQUISAR"
        '
        'txt_pesquisa
        '
        Me.txt_pesquisa.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_pesquisa.ForeColor = System.Drawing.Color.Black
        Me.txt_pesquisa.Name = "txt_pesquisa"
        Me.txt_pesquisa.Size = New System.Drawing.Size(100, 28)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.ForeColor = System.Drawing.Color.White
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 28)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.ForeColor = System.Drawing.Color.White
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 28)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(241, 25)
        Me.ToolStripLabel2.Text = "PARAMETRO DE PESQUISA"
        '
        'cmb_parametro
        '
        Me.cmb_parametro.ForeColor = System.Drawing.Color.Black
        Me.cmb_parametro.Name = "cmb_parametro"
        Me.cmb_parametro.Size = New System.Drawing.Size(121, 28)
        '
        'btn_salvar
        '
        Me.btn_salvar.Image = CType(resources.GetObject("btn_salvar.Image"), System.Drawing.Image)
        Me.btn_salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salvar.Location = New System.Drawing.Point(58, 429)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(217, 82)
        Me.btn_salvar.TabIndex = 30
        Me.btn_salvar.Text = "SALVAR"
        Me.btn_salvar.UseVisualStyleBackColor = True
        '
        'frm_cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(1375, 689)
        Me.Controls.Add(Me.btn_salvar)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.img_funcionario)
        Me.Controls.Add(Me.dgv_funcionario_cadastro)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Century", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frm_cadastro"
        Me.Text = "TELA DE CONTRATO/DEMISSÃO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgv_funcionario_cadastro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_funcionario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_cpf_cadastro As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EMITIRRELATÓRIOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgv_funcionario_cadastro As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_nome_cadastro As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_email_cadastro As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_senha As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents cmb_cargo_cadastro As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cmb_nascimento_cadastro As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents img_funcionario As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txt_salario_cadastro As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_pesquisa As ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cmb_parametro As ToolStripComboBox
    Friend WithEvents btn_salvar As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
    Friend WithEvents BindingSource1 As BindingSource
End Class
