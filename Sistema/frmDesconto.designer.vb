<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDesconto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDesconto))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdFechar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtValorTotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grdProdutos = New System.Windows.Forms.DataGridView()
        Me.colCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQtde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescPercent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVlrOriginal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdAplicar = New System.Windows.Forms.Button()
        Me.txtDescGeral = New System.Windows.Forms.TextBox()
        Me.optPercent = New System.Windows.Forms.RadioButton()
        Me.optMonetario = New System.Windows.Forms.RadioButton()
        Me.grpDescCupom = New System.Windows.Forms.GroupBox()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnlTitulo.SuspendLayout()
        CType(Me.grdProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDescCupom.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.pnlTitulo.Controls.Add(Me.Label6)
        Me.pnlTitulo.Controls.Add(Me.cmdFechar)
        Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitulo.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitulo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(984, 35)
        Me.pnlTitulo.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(5, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 23)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Finalizar Pedido"
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
        Me.cmdFechar.TabIndex = 4
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 19)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Aplicar desconto nos produtos"
        '
        'txtValorTotal
        '
        Me.txtValorTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorTotal.BackColor = System.Drawing.SystemColors.Control
        Me.txtValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtValorTotal.Enabled = False
        Me.txtValorTotal.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorTotal.ForeColor = System.Drawing.Color.Black
        Me.txtValorTotal.Location = New System.Drawing.Point(808, 103)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.Size = New System.Drawing.Size(151, 40)
        Me.txtValorTotal.TabIndex = 56
        Me.txtValorTotal.Text = "0,00"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(799, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 26)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Total geral"
        '
        'grdProdutos
        '
        Me.grdProdutos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdProdutos.BackgroundColor = System.Drawing.Color.White
        Me.grdProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdProdutos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdProdutos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCodigo, Me.colDescricao, Me.colQtde, Me.colValor, Me.colDescPercent, Me.colDescValor, Me.colVlrOriginal})
        Me.grdProdutos.GridColor = System.Drawing.Color.WhiteSmoke
        Me.grdProdutos.Location = New System.Drawing.Point(12, 77)
        Me.grdProdutos.Name = "grdProdutos"
        Me.grdProdutos.RowHeadersVisible = False
        Me.grdProdutos.RowHeadersWidth = 4
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdProdutos.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.grdProdutos.RowTemplate.Height = 60
        Me.grdProdutos.Size = New System.Drawing.Size(781, 451)
        Me.grdProdutos.TabIndex = 37
        '
        'colCodigo
        '
        Me.colCodigo.Frozen = True
        Me.colCodigo.HeaderText = "Código"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.ReadOnly = True
        '
        'colDescricao
        '
        Me.colDescricao.Frozen = True
        Me.colDescricao.HeaderText = "Descrição"
        Me.colDescricao.Name = "colDescricao"
        Me.colDescricao.ReadOnly = True
        '
        'colQtde
        '
        Me.colQtde.Frozen = True
        Me.colQtde.HeaderText = "Qtde."
        Me.colQtde.Name = "colQtde"
        Me.colQtde.ReadOnly = True
        '
        'colValor
        '
        Me.colValor.Frozen = True
        Me.colValor.HeaderText = "Valor"
        Me.colValor.Name = "colValor"
        Me.colValor.ReadOnly = True
        '
        'colDescPercent
        '
        Me.colDescPercent.Frozen = True
        Me.colDescPercent.HeaderText = "Desconto (%) "
        Me.colDescPercent.Name = "colDescPercent"
        '
        'colDescValor
        '
        Me.colDescValor.Frozen = True
        Me.colDescValor.HeaderText = "Desconto (R$)"
        Me.colDescValor.Name = "colDescValor"
        '
        'colVlrOriginal
        '
        Me.colVlrOriginal.Frozen = True
        Me.colVlrOriginal.HeaderText = "VlrOriginal"
        Me.colVlrOriginal.Name = "colVlrOriginal"
        Me.colVlrOriginal.ReadOnly = True
        Me.colVlrOriginal.Visible = False
        '
        'cmdAplicar
        '
        Me.cmdAplicar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAplicar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.cmdAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAplicar.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAplicar.ForeColor = System.Drawing.Color.White
        Me.cmdAplicar.Location = New System.Drawing.Point(804, 561)
        Me.cmdAplicar.Name = "cmdAplicar"
        Me.cmdAplicar.Size = New System.Drawing.Size(168, 50)
        Me.cmdAplicar.TabIndex = 58
        Me.cmdAplicar.Text = "Aplicar"
        Me.cmdAplicar.UseVisualStyleBackColor = False
        '
        'txtDescGeral
        '
        Me.txtDescGeral.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDescGeral.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescGeral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDescGeral.Location = New System.Drawing.Point(18, 31)
        Me.txtDescGeral.Name = "txtDescGeral"
        Me.txtDescGeral.Size = New System.Drawing.Size(176, 33)
        Me.txtDescGeral.TabIndex = 45
        Me.txtDescGeral.Text = "0"
        Me.txtDescGeral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'optPercent
        '
        Me.optPercent.AutoSize = True
        Me.optPercent.Checked = True
        Me.optPercent.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optPercent.Location = New System.Drawing.Point(200, 32)
        Me.optPercent.Name = "optPercent"
        Me.optPercent.Size = New System.Drawing.Size(141, 30)
        Me.optPercent.TabIndex = 59
        Me.optPercent.TabStop = True
        Me.optPercent.Text = "Percentual %"
        Me.optPercent.UseVisualStyleBackColor = True
        '
        'optMonetario
        '
        Me.optMonetario.AutoSize = True
        Me.optMonetario.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMonetario.Location = New System.Drawing.Point(347, 32)
        Me.optMonetario.Name = "optMonetario"
        Me.optMonetario.Size = New System.Drawing.Size(151, 30)
        Me.optMonetario.TabIndex = 60
        Me.optMonetario.Text = "Monetário R$"
        Me.optMonetario.UseVisualStyleBackColor = True
        '
        'grpDescCupom
        '
        Me.grpDescCupom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpDescCupom.Controls.Add(Me.optMonetario)
        Me.grpDescCupom.Controls.Add(Me.optPercent)
        Me.grpDescCupom.Controls.Add(Me.txtDescGeral)
        Me.grpDescCupom.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDescCupom.Location = New System.Drawing.Point(12, 534)
        Me.grpDescCupom.Name = "grpDescCupom"
        Me.grpDescCupom.Size = New System.Drawing.Size(513, 77)
        Me.grpDescCupom.TabIndex = 61
        Me.grpDescCupom.TabStop = False
        Me.grpDescCupom.Text = "Aplicar desconto no cupom"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.Color.Black
        Me.cmdCancelar.Location = New System.Drawing.Point(646, 561)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(152, 50)
        Me.cmdCancelar.TabIndex = 62
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(488, 561)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 50)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "Limpar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmDesconto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 623)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.grpDescCupom)
        Me.Controls.Add(Me.cmdAplicar)
        Me.Controls.Add(Me.txtValorTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdProdutos)
        Me.Controls.Add(Me.pnlTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDesconto"
        Me.Text = "frmDesconto"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        CType(Me.grdProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDescCupom.ResumeLayout(False)
        Me.grpDescCupom.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlTitulo As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdFechar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtValorTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grdProdutos As System.Windows.Forms.DataGridView
    Friend WithEvents cmdAplicar As System.Windows.Forms.Button
    Friend WithEvents txtDescGeral As System.Windows.Forms.TextBox
    Friend WithEvents optPercent As System.Windows.Forms.RadioButton
    Friend WithEvents optMonetario As System.Windows.Forms.RadioButton
    Friend WithEvents grpDescCupom As System.Windows.Forms.GroupBox
    Friend WithEvents colCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescricao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQtde As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colValor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescPercent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescValor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colVlrOriginal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
