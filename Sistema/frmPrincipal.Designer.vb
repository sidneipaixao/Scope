<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.objAvisos = New System.Windows.Forms.StatusStrip()
        Me.objMensagens = New System.Windows.Forms.ToolStripStatusLabel()
        Me.objProgresso = New System.Windows.Forms.ToolStripProgressBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdFechar = New System.Windows.Forms.Button()
        Me.imgTitulo = New System.Windows.Forms.PictureBox()
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.objMenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdAbrir = New System.Windows.Forms.Button()
        Me.objImagens = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdPedidos = New System.Windows.Forms.Button()
        Me.cmdRecibos = New System.Windows.Forms.Button()
        Me.cmdFuncoes = New System.Windows.Forms.Button()
        Me.cmdSincronizar = New System.Windows.Forms.Button()
        Me.cmdReiniciar = New System.Windows.Forms.Button()
        Me.cmdComissoes = New System.Windows.Forms.Button()
        Me.cmdRelatorios = New System.Windows.Forms.Button()
        Me.cmdEncerrar = New System.Windows.Forms.Button()
        Me.objAvisos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.imgTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.objMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'objAvisos
        '
        Me.objAvisos.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.objAvisos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.objMensagens, Me.objProgresso})
        Me.objAvisos.Location = New System.Drawing.Point(0, 578)
        Me.objAvisos.Name = "objAvisos"
        Me.objAvisos.Size = New System.Drawing.Size(900, 22)
        Me.objAvisos.TabIndex = 2
        Me.objAvisos.Text = "StatusStrip1"
        '
        'objMensagens
        '
        Me.objMensagens.ForeColor = System.Drawing.Color.White
        Me.objMensagens.Name = "objMensagens"
        Me.objMensagens.Size = New System.Drawing.Size(885, 17)
        Me.objMensagens.Spring = True
        Me.objMensagens.Text = "Caixa fechado. Sistema pronto."
        Me.objMensagens.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'objProgresso
        '
        Me.objProgresso.Name = "objProgresso"
        Me.objProgresso.Size = New System.Drawing.Size(100, 16)
        Me.objProgresso.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.objProgresso.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cmdFechar)
        Me.Panel1.Controls.Add(Me.imgTitulo)
        Me.Panel1.Controls.Add(Me.imgLogo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 50)
        Me.Panel1.TabIndex = 3
        '
        'cmdFechar
        '
        Me.cmdFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdFechar.BackgroundImage = CType(resources.GetObject("cmdFechar.BackgroundImage"), System.Drawing.Image)
        Me.cmdFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdFechar.FlatAppearance.BorderSize = 0
        Me.cmdFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFechar.Location = New System.Drawing.Point(862, 12)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(35, 21)
        Me.cmdFechar.TabIndex = 2
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'imgTitulo
        '
        Me.imgTitulo.Image = CType(resources.GetObject("imgTitulo.Image"), System.Drawing.Image)
        Me.imgTitulo.Location = New System.Drawing.Point(60, 12)
        Me.imgTitulo.Name = "imgTitulo"
        Me.imgTitulo.Size = New System.Drawing.Size(140, 38)
        Me.imgTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgTitulo.TabIndex = 1
        Me.imgTitulo.TabStop = False
        '
        'imgLogo
        '
        Me.imgLogo.BackgroundImage = CType(resources.GetObject("imgLogo.BackgroundImage"), System.Drawing.Image)
        Me.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgLogo.Location = New System.Drawing.Point(0, 0)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(57, 50)
        Me.imgLogo.TabIndex = 0
        Me.imgLogo.TabStop = False
        '
        'objMenu
        '
        Me.objMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.objMenu.Controls.Add(Me.cmdAbrir)
        Me.objMenu.Controls.Add(Me.cmdPedidos)
        Me.objMenu.Controls.Add(Me.cmdRecibos)
        Me.objMenu.Controls.Add(Me.cmdFuncoes)
        Me.objMenu.Controls.Add(Me.cmdSincronizar)
        Me.objMenu.Controls.Add(Me.cmdReiniciar)
        Me.objMenu.Controls.Add(Me.cmdComissoes)
        Me.objMenu.Controls.Add(Me.cmdRelatorios)
        Me.objMenu.Controls.Add(Me.cmdEncerrar)
        Me.objMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.objMenu.Location = New System.Drawing.Point(0, 50)
        Me.objMenu.Name = "objMenu"
        Me.objMenu.Padding = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.objMenu.Size = New System.Drawing.Size(200, 528)
        Me.objMenu.TabIndex = 4
        '
        'cmdAbrir
        '
        Me.cmdAbrir.FlatAppearance.BorderSize = 0
        Me.cmdAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAbrir.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAbrir.ForeColor = System.Drawing.Color.White
        Me.cmdAbrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAbrir.ImageIndex = 0
        Me.cmdAbrir.ImageList = Me.objImagens
        Me.cmdAbrir.Location = New System.Drawing.Point(0, 20)
        Me.cmdAbrir.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdAbrir.Name = "cmdAbrir"
        Me.cmdAbrir.Size = New System.Drawing.Size(200, 44)
        Me.cmdAbrir.TabIndex = 6
        Me.cmdAbrir.Text = "Abertura de turno"
        Me.cmdAbrir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAbrir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAbrir.UseVisualStyleBackColor = True
        '
        'objImagens
        '
        Me.objImagens.ImageStream = CType(resources.GetObject("objImagens.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.objImagens.TransparentColor = System.Drawing.Color.Transparent
        Me.objImagens.Images.SetKeyName(0, "ABRIR.ICO")
        Me.objImagens.Images.SetKeyName(1, "PEDIDO.ICO")
        Me.objImagens.Images.SetKeyName(2, "RECIBO.ICO")
        Me.objImagens.Images.SetKeyName(3, "ECF.ICO")
        Me.objImagens.Images.SetKeyName(4, "SINCRONIA.ICO")
        Me.objImagens.Images.SetKeyName(5, "TERMINAL.ICO")
        Me.objImagens.Images.SetKeyName(6, "COMISSAO.ICO")
        Me.objImagens.Images.SetKeyName(7, "RELATORIO.ICO")
        Me.objImagens.Images.SetKeyName(8, "FECHAR.ICO")
        '
        'cmdPedidos
        '
        Me.cmdPedidos.FlatAppearance.BorderSize = 0
        Me.cmdPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPedidos.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPedidos.ForeColor = System.Drawing.Color.White
        Me.cmdPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPedidos.ImageIndex = 1
        Me.cmdPedidos.ImageList = Me.objImagens
        Me.cmdPedidos.Location = New System.Drawing.Point(0, 64)
        Me.cmdPedidos.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdPedidos.Name = "cmdPedidos"
        Me.cmdPedidos.Size = New System.Drawing.Size(200, 44)
        Me.cmdPedidos.TabIndex = 8
        Me.cmdPedidos.Text = "Gerenciar pedidos"
        Me.cmdPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdPedidos.UseVisualStyleBackColor = True
        '
        'cmdRecibos
        '
        Me.cmdRecibos.FlatAppearance.BorderSize = 0
        Me.cmdRecibos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRecibos.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRecibos.ForeColor = System.Drawing.Color.White
        Me.cmdRecibos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdRecibos.ImageIndex = 2
        Me.cmdRecibos.ImageList = Me.objImagens
        Me.cmdRecibos.Location = New System.Drawing.Point(0, 108)
        Me.cmdRecibos.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdRecibos.Name = "cmdRecibos"
        Me.cmdRecibos.Size = New System.Drawing.Size(200, 44)
        Me.cmdRecibos.TabIndex = 9
        Me.cmdRecibos.Text = "Emissão de recibo"
        Me.cmdRecibos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdRecibos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdRecibos.UseVisualStyleBackColor = True
        '
        'cmdFuncoes
        '
        Me.cmdFuncoes.FlatAppearance.BorderSize = 0
        Me.cmdFuncoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFuncoes.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFuncoes.ForeColor = System.Drawing.Color.White
        Me.cmdFuncoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFuncoes.ImageIndex = 3
        Me.cmdFuncoes.ImageList = Me.objImagens
        Me.cmdFuncoes.Location = New System.Drawing.Point(0, 152)
        Me.cmdFuncoes.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdFuncoes.Name = "cmdFuncoes"
        Me.cmdFuncoes.Size = New System.Drawing.Size(200, 44)
        Me.cmdFuncoes.TabIndex = 10
        Me.cmdFuncoes.Text = "Funções ECF"
        Me.cmdFuncoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFuncoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdFuncoes.UseVisualStyleBackColor = True
        '
        'cmdSincronizar
        '
        Me.cmdSincronizar.FlatAppearance.BorderSize = 0
        Me.cmdSincronizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSincronizar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSincronizar.ForeColor = System.Drawing.Color.White
        Me.cmdSincronizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSincronizar.ImageIndex = 4
        Me.cmdSincronizar.ImageList = Me.objImagens
        Me.cmdSincronizar.Location = New System.Drawing.Point(0, 196)
        Me.cmdSincronizar.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdSincronizar.Name = "cmdSincronizar"
        Me.cmdSincronizar.Size = New System.Drawing.Size(200, 44)
        Me.cmdSincronizar.TabIndex = 11
        Me.cmdSincronizar.Text = "Sincronização"
        Me.cmdSincronizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSincronizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdSincronizar.UseVisualStyleBackColor = True
        '
        'cmdReiniciar
        '
        Me.cmdReiniciar.FlatAppearance.BorderSize = 0
        Me.cmdReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReiniciar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReiniciar.ForeColor = System.Drawing.Color.White
        Me.cmdReiniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdReiniciar.ImageIndex = 5
        Me.cmdReiniciar.ImageList = Me.objImagens
        Me.cmdReiniciar.Location = New System.Drawing.Point(0, 240)
        Me.cmdReiniciar.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdReiniciar.Name = "cmdReiniciar"
        Me.cmdReiniciar.Size = New System.Drawing.Size(200, 44)
        Me.cmdReiniciar.TabIndex = 12
        Me.cmdReiniciar.Text = "Reiniciar serviços"
        Me.cmdReiniciar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdReiniciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdReiniciar.UseVisualStyleBackColor = True
        '
        'cmdComissoes
        '
        Me.cmdComissoes.FlatAppearance.BorderSize = 0
        Me.cmdComissoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdComissoes.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdComissoes.ForeColor = System.Drawing.Color.White
        Me.cmdComissoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdComissoes.ImageIndex = 6
        Me.cmdComissoes.ImageList = Me.objImagens
        Me.cmdComissoes.Location = New System.Drawing.Point(0, 284)
        Me.cmdComissoes.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdComissoes.Name = "cmdComissoes"
        Me.cmdComissoes.Size = New System.Drawing.Size(200, 44)
        Me.cmdComissoes.TabIndex = 13
        Me.cmdComissoes.Text = "Gerenciar comissões"
        Me.cmdComissoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdComissoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdComissoes.UseVisualStyleBackColor = True
        '
        'cmdRelatorios
        '
        Me.cmdRelatorios.FlatAppearance.BorderSize = 0
        Me.cmdRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRelatorios.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRelatorios.ForeColor = System.Drawing.Color.White
        Me.cmdRelatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdRelatorios.ImageIndex = 7
        Me.cmdRelatorios.ImageList = Me.objImagens
        Me.cmdRelatorios.Location = New System.Drawing.Point(0, 328)
        Me.cmdRelatorios.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdRelatorios.Name = "cmdRelatorios"
        Me.cmdRelatorios.Size = New System.Drawing.Size(200, 44)
        Me.cmdRelatorios.TabIndex = 14
        Me.cmdRelatorios.Text = "Relatórios"
        Me.cmdRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdRelatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdRelatorios.UseVisualStyleBackColor = True
        '
        'cmdEncerrar
        '
        Me.cmdEncerrar.FlatAppearance.BorderSize = 0
        Me.cmdEncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEncerrar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEncerrar.ForeColor = System.Drawing.Color.White
        Me.cmdEncerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEncerrar.ImageIndex = 8
        Me.cmdEncerrar.ImageList = Me.objImagens
        Me.cmdEncerrar.Location = New System.Drawing.Point(0, 372)
        Me.cmdEncerrar.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdEncerrar.Name = "cmdEncerrar"
        Me.cmdEncerrar.Size = New System.Drawing.Size(200, 44)
        Me.cmdEncerrar.TabIndex = 15
        Me.cmdEncerrar.Text = "Fechamento de turno"
        Me.cmdEncerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEncerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdEncerrar.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(900, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.objMenu)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.objAvisos)
        Me.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPrincipal"
        Me.Text = "s co p e"
        Me.objAvisos.ResumeLayout(False)
        Me.objAvisos.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.imgTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.objMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
  Friend WithEvents objAvisos As System.Windows.Forms.StatusStrip
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents objMenu As System.Windows.Forms.FlowLayoutPanel
  Friend WithEvents cmdAbrir As System.Windows.Forms.Button
  Friend WithEvents objMensagens As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents objProgresso As System.Windows.Forms.ToolStripProgressBar
  Friend WithEvents objImagens As System.Windows.Forms.ImageList
  Friend WithEvents cmdPedidos As System.Windows.Forms.Button
  Friend WithEvents cmdRecibos As System.Windows.Forms.Button
  Friend WithEvents cmdFuncoes As System.Windows.Forms.Button
  Friend WithEvents cmdSincronizar As System.Windows.Forms.Button
  Friend WithEvents cmdReiniciar As System.Windows.Forms.Button
  Friend WithEvents cmdComissoes As System.Windows.Forms.Button
  Friend WithEvents cmdRelatorios As System.Windows.Forms.Button
  Friend WithEvents cmdEncerrar As System.Windows.Forms.Button
  Friend WithEvents imgTitulo As System.Windows.Forms.PictureBox
  Friend WithEvents imgLogo As System.Windows.Forms.PictureBox
  Friend WithEvents cmdFechar As System.Windows.Forms.Button

End Class
