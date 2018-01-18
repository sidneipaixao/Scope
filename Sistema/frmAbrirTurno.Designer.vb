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
        Me.cmdEntrar = New System.Windows.Forms.Button()
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.txtValorIni = New System.Windows.Forms.NumericUpDown()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtValorFim = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.txtValorIni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorFim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdEntrar
        '
        Me.cmdEntrar.Location = New System.Drawing.Point(282, 248)
        Me.cmdEntrar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdEntrar.Name = "cmdEntrar"
        Me.cmdEntrar.Size = New System.Drawing.Size(105, 31)
        Me.cmdEntrar.TabIndex = 5
        Me.cmdEntrar.Text = "Iniciar turno"
        Me.cmdEntrar.UseVisualStyleBackColor = True
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitulo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(400, 35)
        Me.pnlTitulo.TabIndex = 1
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(169, 248)
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(105, 31)
        Me.cmdCancelar.TabIndex = 4
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'txtValorIni
        '
        Me.txtValorIni.DecimalPlaces = 2
        Me.txtValorIni.Location = New System.Drawing.Point(114, 195)
        Me.txtValorIni.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txtValorIni.Name = "txtValorIni"
        Me.txtValorIni.Size = New System.Drawing.Size(132, 23)
        Me.txtValorIni.TabIndex = 2
        Me.txtValorIni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValorIni.Value = New Decimal(New Integer() {400, 0, 0, 0})
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(114, 85)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(273, 23)
        Me.txtUsuario.TabIndex = 0
        Me.txtUsuario.Text = "admin"
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(114, 140)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(273, 23)
        Me.txtSenha.TabIndex = 1
        Me.txtSenha.Text = "12345"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(111, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Usuário"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(111, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Senha de acesso"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(111, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Valor fundo de caixa"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 79)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 113)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'txtValorFim
        '
        Me.txtValorFim.DecimalPlaces = 2
        Me.txtValorFim.Location = New System.Drawing.Point(255, 195)
        Me.txtValorFim.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txtValorFim.Name = "txtValorFim"
        Me.txtValorFim.Size = New System.Drawing.Size(132, 23)
        Me.txtValorFim.TabIndex = 3
        Me.txtValorFim.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValorFim.Value = New Decimal(New Integer() {400, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(252, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Valor inicial em caixa"
        '
        'frmAbrirTurno
        '
        Me.AcceptButton = Me.cmdEntrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(400, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtValorFim)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtValorIni)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Controls.Add(Me.cmdEntrar)
        Me.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbrirTurno"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.txtValorIni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorFim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
  Friend WithEvents cmdEntrar As System.Windows.Forms.Button
  Friend WithEvents pnlTitulo As System.Windows.Forms.Panel
  Friend WithEvents cmdCancelar As System.Windows.Forms.Button
  Friend WithEvents txtValorIni As System.Windows.Forms.NumericUpDown
  Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
  Friend WithEvents txtSenha As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
  Friend WithEvents txtValorFim As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
