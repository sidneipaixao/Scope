<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbrirTurno
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
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

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbrirTurno))
        Me.cmdEntrar = New System.Windows.Forms.Button()
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdFechar = New System.Windows.Forms.Button()
        Me.txtValorIni = New System.Windows.Forms.NumericUpDown()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtValorFim = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.imgNome = New System.Windows.Forms.PictureBox()
        Me.pnlTitulo.SuspendLayout()
        CType(Me.txtValorIni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorFim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgNome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdEntrar
        '
        Me.cmdEntrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdEntrar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.cmdEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEntrar.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEntrar.ForeColor = System.Drawing.Color.White
        Me.cmdEntrar.Location = New System.Drawing.Point(360, 414)
        Me.cmdEntrar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdEntrar.Name = "cmdEntrar"
        Me.cmdEntrar.Size = New System.Drawing.Size(310, 39)
        Me.cmdEntrar.TabIndex = 5
        Me.cmdEntrar.Text = "Iniciar turno"
        Me.cmdEntrar.UseVisualStyleBackColor = False
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.pnlTitulo.Controls.Add(Me.Label6)
        Me.pnlTitulo.Controls.Add(Me.cmdFechar)
        Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitulo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(1029, 35)
        Me.pnlTitulo.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(1, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 23)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Abrir Turno"
        '
        'cmdFechar
        '
        Me.cmdFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdFechar.BackgroundImage = CType(resources.GetObject("cmdFechar.BackgroundImage"), System.Drawing.Image)
        Me.cmdFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdFechar.FlatAppearance.BorderSize = 0
        Me.cmdFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFechar.Location = New System.Drawing.Point(1002, 7)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(24, 21)
        Me.cmdFechar.TabIndex = 6
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'txtValorIni
        '
        Me.txtValorIni.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtValorIni.DecimalPlaces = 2
        Me.txtValorIni.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorIni.Location = New System.Drawing.Point(360, 370)
        Me.txtValorIni.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txtValorIni.Name = "txtValorIni"
        Me.txtValorIni.Size = New System.Drawing.Size(152, 27)
        Me.txtValorIni.TabIndex = 3
        Me.txtValorIni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValorIni.Value = New Decimal(New Integer() {400, 0, 0, 0})
        '
        'txtUsuario
        '
        Me.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUsuario.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(360, 257)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(310, 27)
        Me.txtUsuario.TabIndex = 1
        '
        'txtSenha
        '
        Me.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSenha.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.Location = New System.Drawing.Point(360, 309)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(310, 27)
        Me.txtSenha.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(356, 235)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Usuário"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(356, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Senha de acesso"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(356, 348)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Valor fundo de caixa"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Location = New System.Drawing.Point(257, 254)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 113)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'txtValorFim
        '
        Me.txtValorFim.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtValorFim.DecimalPlaces = 2
        Me.txtValorFim.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorFim.Location = New System.Drawing.Point(518, 370)
        Me.txtValorFim.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txtValorFim.Name = "txtValorFim"
        Me.txtValorFim.Size = New System.Drawing.Size(152, 27)
        Me.txtValorFim.TabIndex = 4
        Me.txtValorFim.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValorFim.Value = New Decimal(New Integer() {400, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(514, 348)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Valor inicial em caixa"
        '
        'imgNome
        '
        Me.imgNome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.imgNome.Image = CType(resources.GetObject("imgNome.Image"), System.Drawing.Image)
        Me.imgNome.Location = New System.Drawing.Point(387, 153)
        Me.imgNome.Name = "imgNome"
        Me.imgNome.Size = New System.Drawing.Size(256, 75)
        Me.imgNome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgNome.TabIndex = 12
        Me.imgNome.TabStop = False
        '
        'frmAbrirTurno
        '
        Me.AcceptButton = Me.cmdEntrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1029, 663)
        Me.ControlBox = False
        Me.Controls.Add(Me.imgNome)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtValorFim)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtValorIni)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Controls.Add(Me.cmdEntrar)
        Me.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbrirTurno"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        CType(Me.txtValorIni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorFim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgNome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
  Friend WithEvents cmdEntrar As System.Windows.Forms.Button
  Friend WithEvents pnlTitulo As System.Windows.Forms.Panel
    Friend WithEvents txtValorIni As System.Windows.Forms.NumericUpDown
  Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
  Friend WithEvents txtSenha As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
  Friend WithEvents txtValorFim As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdFechar As System.Windows.Forms.Button
    Friend WithEvents imgNome As System.Windows.Forms.PictureBox
End Class
