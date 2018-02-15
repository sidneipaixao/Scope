<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncluirPedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIncluirPedido))
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdFechar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstProdutos = New System.Windows.Forms.ListView()
        Me.colCodigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDescricao = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.objDistanciaItens = New System.Windows.Forms.ImageList(Me.components)
        Me.lstAdicionais = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFinaliza = New System.Windows.Forms.Button()
        Me.btnPrato = New System.Windows.Forms.Button()
        Me.pnlItens = New System.Windows.Forms.Panel()
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lstItens = New System.Windows.Forms.ListView()
        Me.clnCodigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clnDescricao = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clnQtde = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clnValor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblQtde = New System.Windows.Forms.Label()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnProximo = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVlrPrato = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.pnlTitulo.SuspendLayout()
        Me.pnlItens.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.pnlTitulo.Controls.Add(Me.Label3)
        Me.pnlTitulo.Controls.Add(Me.cmdFechar)
        Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitulo.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitulo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(984, 35)
        Me.pnlTitulo.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(5, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 23)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Incluir Pedido"
        '
        'cmdFechar
        '
        Me.cmdFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdFechar.BackgroundImage = CType(resources.GetObject("cmdFechar.BackgroundImage"), System.Drawing.Image)
        Me.cmdFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdFechar.FlatAppearance.BorderSize = 0
        Me.cmdFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFechar.Location = New System.Drawing.Point(955, 7)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(24, 21)
        Me.cmdFechar.TabIndex = 6
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 19)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Produtos principais"
        '
        'lstProdutos
        '
        Me.lstProdutos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstProdutos.AutoArrange = False
        Me.lstProdutos.BackColor = System.Drawing.Color.White
        Me.lstProdutos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colCodigo, Me.colDescricao})
        Me.lstProdutos.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstProdutos.ForeColor = System.Drawing.Color.Black
        Me.lstProdutos.FullRowSelect = True
        Me.lstProdutos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstProdutos.HoverSelection = True
        Me.lstProdutos.Location = New System.Drawing.Point(-1, 71)
        Me.lstProdutos.Margin = New System.Windows.Forms.Padding(12)
        Me.lstProdutos.MultiSelect = False
        Me.lstProdutos.Name = "lstProdutos"
        Me.lstProdutos.Scrollable = False
        Me.lstProdutos.Size = New System.Drawing.Size(531, 292)
        Me.lstProdutos.SmallImageList = Me.objDistanciaItens
        Me.lstProdutos.TabIndex = 38
        Me.lstProdutos.TileSize = New System.Drawing.Size(200, 180)
        Me.lstProdutos.UseCompatibleStateImageBehavior = False
        Me.lstProdutos.View = System.Windows.Forms.View.Details
        '
        'colCodigo
        '
        Me.colCodigo.Text = "Código"
        '
        'colDescricao
        '
        Me.colDescricao.Text = "Descrição"
        '
        'objDistanciaItens
        '
        Me.objDistanciaItens.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.objDistanciaItens.ImageSize = New System.Drawing.Size(1, 50)
        Me.objDistanciaItens.TransparentColor = System.Drawing.Color.Transparent
        '
        'lstAdicionais
        '
        Me.lstAdicionais.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstAdicionais.AutoArrange = False
        Me.lstAdicionais.BackColor = System.Drawing.Color.White
        Me.lstAdicionais.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstAdicionais.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAdicionais.ForeColor = System.Drawing.Color.Black
        Me.lstAdicionais.FullRowSelect = True
        Me.lstAdicionais.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstAdicionais.HoverSelection = True
        Me.lstAdicionais.Location = New System.Drawing.Point(9, 397)
        Me.lstAdicionais.Margin = New System.Windows.Forms.Padding(12)
        Me.lstAdicionais.MultiSelect = False
        Me.lstAdicionais.Name = "lstAdicionais"
        Me.lstAdicionais.Size = New System.Drawing.Size(521, 197)
        Me.lstAdicionais.TabIndex = 40
        Me.lstAdicionais.TileSize = New System.Drawing.Size(80, 80)
        Me.lstAdicionais.UseCompatibleStateImageBehavior = False
        Me.lstAdicionais.View = System.Windows.Forms.View.Tile
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nome do Cliente"
        Me.ColumnHeader1.Width = 450
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Contrato"
        Me.ColumnHeader2.Width = 159
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "E-mail do cliente"
        Me.ColumnHeader3.Width = 350
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 375)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 19)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Itens adicionais"
        '
        'btnFinaliza
        '
        Me.btnFinaliza.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFinaliza.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnFinaliza.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinaliza.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinaliza.ForeColor = System.Drawing.Color.White
        Me.btnFinaliza.Location = New System.Drawing.Point(767, 600)
        Me.btnFinaliza.Name = "btnFinaliza"
        Me.btnFinaliza.Size = New System.Drawing.Size(205, 50)
        Me.btnFinaliza.TabIndex = 45
        Me.btnFinaliza.Text = "Finalizar"
        Me.btnFinaliza.UseVisualStyleBackColor = False
        '
        'btnPrato
        '
        Me.btnPrato.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrato.BackColor = System.Drawing.Color.Gainsboro
        Me.btnPrato.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrato.Location = New System.Drawing.Point(545, 600)
        Me.btnPrato.Name = "btnPrato"
        Me.btnPrato.Size = New System.Drawing.Size(216, 50)
        Me.btnPrato.TabIndex = 46
        Me.btnPrato.Text = "Adicionar Prato"
        Me.btnPrato.UseVisualStyleBackColor = False
        '
        'pnlItens
        '
        Me.pnlItens.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlItens.BackColor = System.Drawing.Color.Silver
        Me.pnlItens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlItens.Controls.Add(Me.btnRemover)
        Me.pnlItens.Controls.Add(Me.Label8)
        Me.pnlItens.Controls.Add(Me.lstItens)
        Me.pnlItens.Controls.Add(Me.lblQtde)
        Me.pnlItens.Controls.Add(Me.btnAnterior)
        Me.pnlItens.Controls.Add(Me.btnProximo)
        Me.pnlItens.Controls.Add(Me.Label4)
        Me.pnlItens.Controls.Add(Me.txtVlrPrato)
        Me.pnlItens.Location = New System.Drawing.Point(545, 47)
        Me.pnlItens.Name = "pnlItens"
        Me.pnlItens.Size = New System.Drawing.Size(427, 547)
        Me.pnlItens.TabIndex = 47
        '
        'btnRemover
        '
        Me.btnRemover.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemover.BackColor = System.Drawing.Color.Gainsboro
        Me.btnRemover.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemover.Location = New System.Drawing.Point(180, 484)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(234, 50)
        Me.btnRemover.TabIndex = 52
        Me.btnRemover.Text = "Remover Item"
        Me.btnRemover.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Silver
        Me.Label8.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.IndianRed
        Me.Label8.Location = New System.Drawing.Point(3, 430)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 26)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Total do prato"
        '
        'lstItens
        '
        Me.lstItens.AllowColumnReorder = True
        Me.lstItens.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstItens.BackColor = System.Drawing.Color.White
        Me.lstItens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstItens.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clnCodigo, Me.clnDescricao, Me.clnQtde, Me.clnValor})
        Me.lstItens.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstItens.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lstItens.FullRowSelect = True
        Me.lstItens.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstItens.Location = New System.Drawing.Point(8, 29)
        Me.lstItens.MultiSelect = False
        Me.lstItens.Name = "lstItens"
        Me.lstItens.Size = New System.Drawing.Size(406, 393)
        Me.lstItens.TabIndex = 51
        Me.lstItens.UseCompatibleStateImageBehavior = False
        Me.lstItens.View = System.Windows.Forms.View.Details
        '
        'clnCodigo
        '
        Me.clnCodigo.Text = "Código"
        Me.clnCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.clnCodigo.Width = 61
        '
        'clnDescricao
        '
        Me.clnDescricao.Text = "Descrição"
        Me.clnDescricao.Width = 400
        '
        'clnQtde
        '
        Me.clnQtde.Text = "Qtde"
        Me.clnQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clnQtde.Width = 61
        '
        'clnValor
        '
        Me.clnValor.Text = "Valor"
        Me.clnValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.clnValor.Width = 55
        '
        'lblQtde
        '
        Me.lblQtde.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQtde.Location = New System.Drawing.Point(281, 430)
        Me.lblQtde.Name = "lblQtde"
        Me.lblQtde.Size = New System.Drawing.Size(32, 40)
        Me.lblQtde.TabIndex = 50
        Me.lblQtde.Text = "1/1"
        Me.lblQtde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAnterior
        '
        Me.btnAnterior.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnterior.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAnterior.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.Location = New System.Drawing.Point(180, 428)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(95, 50)
        Me.btnAnterior.TabIndex = 49
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'btnProximo
        '
        Me.btnProximo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProximo.BackColor = System.Drawing.Color.Gainsboro
        Me.btnProximo.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProximo.Location = New System.Drawing.Point(319, 428)
        Me.btnProximo.Name = "btnProximo"
        Me.btnProximo.Size = New System.Drawing.Size(95, 50)
        Me.btnProximo.TabIndex = 49
        Me.btnProximo.Text = ">"
        Me.btnProximo.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(1, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 23)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Resumo do pedido"
        '
        'txtVlrPrato
        '
        Me.txtVlrPrato.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtVlrPrato.BackColor = System.Drawing.Color.Silver
        Me.txtVlrPrato.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVlrPrato.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVlrPrato.ForeColor = System.Drawing.Color.IndianRed
        Me.txtVlrPrato.Location = New System.Drawing.Point(12, 452)
        Me.txtVlrPrato.Name = "txtVlrPrato"
        Me.txtVlrPrato.Size = New System.Drawing.Size(151, 40)
        Me.txtVlrPrato.TabIndex = 48
        Me.txtVlrPrato.Text = "0,00"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(336, 600)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 50)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "<"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Gainsboro
        Me.Button2.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(437, 600)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 50)
        Me.Button2.TabIndex = 53
        Me.Button2.Text = ">"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmIncluirPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 658)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pnlItens)
        Me.Controls.Add(Me.btnPrato)
        Me.Controls.Add(Me.btnFinaliza)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstAdicionais)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstProdutos)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmIncluirPedido"
        Me.Text = "frmIncluirPedido"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        Me.pnlItens.ResumeLayout(False)
        Me.pnlItens.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlTitulo As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdFechar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstProdutos As System.Windows.Forms.ListView
    Friend WithEvents lstAdicionais As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnFinaliza As System.Windows.Forms.Button
    Friend WithEvents btnPrato As System.Windows.Forms.Button
    Friend WithEvents pnlItens As System.Windows.Forms.Panel
    Friend WithEvents lblQtde As System.Windows.Forms.Label
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents btnProximo As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtVlrPrato As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lstItens As System.Windows.Forms.ListView
    Friend WithEvents clnCodigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnDescricao As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnQtde As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnValor As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnRemover As System.Windows.Forms.Button
    Friend WithEvents objDistanciaItens As System.Windows.Forms.ImageList
    Friend WithEvents colCodigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDescricao As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
