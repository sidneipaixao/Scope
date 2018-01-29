<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPedidos))
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdFechar = New System.Windows.Forms.Button()
        Me.lstPedidos = New System.Windows.Forms.ListView()
        Me.colNome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colContrato = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colEmail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstRecentes = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlInfo = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.objBuscaPedido = New System.Windows.Forms.Timer(Me.components)
        Me.pnlTitulo.SuspendLayout()
        Me.pnlInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.pnlTitulo.Controls.Add(Me.Label3)
        Me.pnlTitulo.Controls.Add(Me.cmdFechar)
        Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitulo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(1000, 35)
        Me.pnlTitulo.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(5, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 23)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Pedidos"
        '
        'cmdFechar
        '
        Me.cmdFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdFechar.BackgroundImage = CType(resources.GetObject("cmdFechar.BackgroundImage"), System.Drawing.Image)
        Me.cmdFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdFechar.FlatAppearance.BorderSize = 0
        Me.cmdFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFechar.Location = New System.Drawing.Point(970, 7)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(24, 21)
        Me.cmdFechar.TabIndex = 13
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'lstPedidos
        '
        Me.lstPedidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstPedidos.AutoArrange = False
        Me.lstPedidos.BackColor = System.Drawing.Color.White
        Me.lstPedidos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNome, Me.colContrato, Me.colEmail})
        Me.lstPedidos.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPedidos.ForeColor = System.Drawing.Color.Black
        Me.lstPedidos.FullRowSelect = True
        Me.lstPedidos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstPedidos.HoverSelection = True
        Me.lstPedidos.Location = New System.Drawing.Point(9, 69)
        Me.lstPedidos.Margin = New System.Windows.Forms.Padding(12)
        Me.lstPedidos.MultiSelect = False
        Me.lstPedidos.Name = "lstPedidos"
        Me.lstPedidos.Size = New System.Drawing.Size(985, 301)
        Me.lstPedidos.TabIndex = 3
        Me.lstPedidos.TileSize = New System.Drawing.Size(320, 100)
        Me.lstPedidos.UseCompatibleStateImageBehavior = False
        Me.lstPedidos.View = System.Windows.Forms.View.Tile
        '
        'colNome
        '
        Me.colNome.Text = "Nome do Cliente"
        Me.colNome.Width = 450
        '
        'colContrato
        '
        Me.colContrato.Text = "Contrato"
        Me.colContrato.Width = 159
        '
        'colEmail
        '
        Me.colEmail.Text = "E-mail do cliente"
        Me.colEmail.Width = 350
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 19)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Pedidos na fila"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 382)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 19)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Pedidos recentes (encerrados)"
        '
        'lstRecentes
        '
        Me.lstRecentes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstRecentes.BackColor = System.Drawing.Color.Silver
        Me.lstRecentes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstRecentes.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRecentes.ForeColor = System.Drawing.Color.Black
        Me.lstRecentes.FullRowSelect = True
        Me.lstRecentes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstRecentes.HoverSelection = True
        Me.lstRecentes.Location = New System.Drawing.Point(9, 404)
        Me.lstRecentes.Margin = New System.Windows.Forms.Padding(12)
        Me.lstRecentes.MultiSelect = False
        Me.lstRecentes.Name = "lstRecentes"
        Me.lstRecentes.Size = New System.Drawing.Size(985, 202)
        Me.lstRecentes.TabIndex = 39
        Me.lstRecentes.TileSize = New System.Drawing.Size(320, 100)
        Me.lstRecentes.UseCompatibleStateImageBehavior = False
        Me.lstRecentes.View = System.Windows.Forms.View.Tile
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nome do Cliente"
        Me.ColumnHeader1.Width = 450
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Contrato"
        Me.ColumnHeader2.Width = 180
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "E-mail do cliente"
        Me.ColumnHeader3.Width = 350
        '
        'pnlInfo
        '
        Me.pnlInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlInfo.BackColor = System.Drawing.Color.LightSeaGreen
        Me.pnlInfo.Controls.Add(Me.Label10)
        Me.pnlInfo.Controls.Add(Me.Label11)
        Me.pnlInfo.Location = New System.Drawing.Point(9, 612)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.Size = New System.Drawing.Size(985, 76)
        Me.pnlInfo.TabIndex = 48
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(14, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(976, 18)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "- Os itens do painel inferior representam os pedidos recentemente finalizados. Ao" & _
    " clicar em um pedido suas informações serão exibidas (somente leitura)."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(14, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(907, 18)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "- Os itens no painel superior representam os pedidos ainda não finalizados. Basta" & _
    " clicar na tile do pedido desejado para exibir suas informações."
        '
        'objBuscaPedido
        '
        Me.objBuscaPedido.Enabled = True
        Me.objBuscaPedido.Interval = 3000
        '
        'frmPedidos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me.pnlInfo)
        Me.Controls.Add(Me.lstRecentes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstPedidos)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedidos realizados"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        Me.pnlInfo.ResumeLayout(False)
        Me.pnlInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlTitulo As System.Windows.Forms.Panel
    Friend WithEvents lstPedidos As System.Windows.Forms.ListView
    Friend WithEvents colNome As System.Windows.Forms.ColumnHeader
    Friend WithEvents colEmail As System.Windows.Forms.ColumnHeader
    Friend WithEvents colContrato As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdFechar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstRecentes As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents pnlInfo As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents objBuscaPedido As System.Windows.Forms.Timer
End Class
