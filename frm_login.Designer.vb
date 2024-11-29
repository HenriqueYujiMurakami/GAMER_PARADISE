<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_usuario_login = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_senha = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_cpf_login = New System.Windows.Forms.MaskedTextBox()
        Me.btn_acessar_login = New Guna.UI.WinForms.GunaButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(33, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DIGITE SEU NOME:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(33, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DIGITE SEU CPF:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(36, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "DIGITE A SENHA:"
        '
        'txt_usuario_login
        '
        Me.txt_usuario_login.BackColor = System.Drawing.Color.Transparent
        Me.txt_usuario_login.BaseColor = System.Drawing.Color.White
        Me.txt_usuario_login.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.txt_usuario_login.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_usuario_login.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_usuario_login.FocusedBorderColor = System.Drawing.Color.MidnightBlue
        Me.txt_usuario_login.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_usuario_login.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario_login.ForeColor = System.Drawing.Color.DarkCyan
        Me.txt_usuario_login.Location = New System.Drawing.Point(40, 47)
        Me.txt_usuario_login.Name = "txt_usuario_login"
        Me.txt_usuario_login.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_usuario_login.Radius = 15
        Me.txt_usuario_login.SelectedText = ""
        Me.txt_usuario_login.Size = New System.Drawing.Size(402, 32)
        Me.txt_usuario_login.TabIndex = 1
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
        Me.txt_senha.ForeColor = System.Drawing.Color.DarkCyan
        Me.txt_senha.Location = New System.Drawing.Point(37, 159)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Radius = 15
        Me.txt_senha.SelectedText = ""
        Me.txt_senha.Size = New System.Drawing.Size(205, 32)
        Me.txt_senha.TabIndex = 3
        '
        'txt_cpf_login
        '
        Me.txt_cpf_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cpf_login.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf_login.ForeColor = System.Drawing.Color.DarkCyan
        Me.txt_cpf_login.Location = New System.Drawing.Point(36, 99)
        Me.txt_cpf_login.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_cpf_login.Mask = "999,999,999-99"
        Me.txt_cpf_login.Name = "txt_cpf_login"
        Me.txt_cpf_login.Size = New System.Drawing.Size(206, 28)
        Me.txt_cpf_login.TabIndex = 2
        '
        'btn_acessar_login
        '
        Me.btn_acessar_login.AnimationHoverSpeed = 0.07!
        Me.btn_acessar_login.AnimationSpeed = 0.03!
        Me.btn_acessar_login.BackColor = System.Drawing.Color.Transparent
        Me.btn_acessar_login.BaseColor = System.Drawing.Color.White
        Me.btn_acessar_login.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.btn_acessar_login.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_acessar_login.FocusedColor = System.Drawing.Color.Empty
        Me.btn_acessar_login.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_acessar_login.ForeColor = System.Drawing.Color.DarkCyan
        Me.btn_acessar_login.Image = CType(resources.GetObject("btn_acessar_login.Image"), System.Drawing.Image)
        Me.btn_acessar_login.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_acessar_login.Location = New System.Drawing.Point(265, 204)
        Me.btn_acessar_login.Name = "btn_acessar_login"
        Me.btn_acessar_login.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_acessar_login.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_acessar_login.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_acessar_login.OnHoverImage = Nothing
        Me.btn_acessar_login.OnPressedColor = System.Drawing.Color.DarkSlateGray
        Me.btn_acessar_login.Radius = 25
        Me.btn_acessar_login.Size = New System.Drawing.Size(177, 63)
        Me.btn_acessar_login.TabIndex = 4
        Me.btn_acessar_login.Text = "ACESSAR"
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(493, 279)
        Me.Controls.Add(Me.txt_cpf_login)
        Me.Controls.Add(Me.btn_acessar_login)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_usuario_login)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_login"
        Me.Text = "TELA DE LOGIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_usuario_login As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_senha As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_cpf_login As MaskedTextBox
    Friend WithEvents btn_acessar_login As Guna.UI.WinForms.GunaButton
End Class
