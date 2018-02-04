<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEncerrarPedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEncerrarPedido))
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdFechar = New System.Windows.Forms.Button()
        Me.lstItens = New System.Windows.Forms.ListView()
        Me.clnCodigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clnDescricao = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clnQtde = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clnValor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnIncluir = New System.Windows.Forms.Button()
        Me.grdItemPedido = New System.Windows.Forms.DataGridView()
        Me.clCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clQtde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clDescricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEncerrar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtVlrPago = New System.Windows.Forms.TextBox()
        Me.btnDec = New System.Windows.Forms.Button()
        Me.btnA20 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnA10 = New System.Windows.Forms.Button()
        Me.btnA60 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btnA30 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnA50 = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnApaga = New System.Windows.Forms.Button()
        Me.lblTroco = New System.Windows.Forms.Label()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.cmdReimprimir = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.txtVlrTroco = New System.Windows.Forms.TextBox()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtVlrPrato = New System.Windows.Forms.TextBox()
        Me.pnlMoedas = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnProximo = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnlInfo = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.pnlTitulo.SuspendLayout()
        CType(Me.grdItemPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlInfo.SuspendLayout()
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
        Me.pnlTitulo.Size = New System.Drawing.Size(1195, 35)
        Me.pnlTitulo.TabIndex = 35
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
        Me.cmdFechar.Location = New System.Drawing.Point(1166, 7)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(24, 21)
        Me.cmdFechar.TabIndex = 4
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'lstItens
        '
        Me.lstItens.AllowColumnReorder = True
        Me.lstItens.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstItens.BackColor = System.Drawing.Color.White
        Me.lstItens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstItens.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clnCodigo, Me.clnDescricao, Me.clnQtde, Me.clnValor})
        Me.lstItens.Font = New System.Drawing.Font("Candara", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstItens.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lstItens.FullRowSelect = True
        Me.lstItens.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstItens.Location = New System.Drawing.Point(16, 77)
        Me.lstItens.MultiSelect = False
        Me.lstItens.Name = "lstItens"
        Me.lstItens.Size = New System.Drawing.Size(449, 486)
        Me.lstItens.TabIndex = 41
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
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(1, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 23)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Resumo do pedido"
        '
        'btnIncluir
        '
        Me.btnIncluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIncluir.BackColor = System.Drawing.Color.Gainsboro
        Me.btnIncluir.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncluir.Location = New System.Drawing.Point(221, 577)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(234, 50)
        Me.btnIncluir.TabIndex = 29
        Me.btnIncluir.Text = "Incluir Itens"
        Me.btnIncluir.UseVisualStyleBackColor = False
        '
        'grdItemPedido
        '
        Me.grdItemPedido.AllowUserToAddRows = False
        Me.grdItemPedido.AllowUserToDeleteRows = False
        Me.grdItemPedido.BackgroundColor = System.Drawing.Color.White
        Me.grdItemPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdItemPedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clCodigo, Me.clQtde, Me.clDescricao, Me.clValor})
        Me.grdItemPedido.Location = New System.Drawing.Point(-1, 348)
        Me.grdItemPedido.Name = "grdItemPedido"
        Me.grdItemPedido.ReadOnly = True
        Me.grdItemPedido.RowHeadersVisible = False
        Me.grdItemPedido.Size = New System.Drawing.Size(158, 60)
        Me.grdItemPedido.TabIndex = 30
        Me.grdItemPedido.Visible = False
        '
        'clCodigo
        '
        Me.clCodigo.HeaderText = "Código"
        Me.clCodigo.Name = "clCodigo"
        Me.clCodigo.ReadOnly = True
        Me.clCodigo.Visible = False
        '
        'clQtde
        '
        Me.clQtde.HeaderText = "QUANTIDADE"
        Me.clQtde.Name = "clQtde"
        Me.clQtde.ReadOnly = True
        Me.clQtde.Width = 50
        '
        'clDescricao
        '
        Me.clDescricao.HeaderText = "DESCRIÇÃO"
        Me.clDescricao.Name = "clDescricao"
        Me.clDescricao.ReadOnly = True
        Me.clDescricao.Width = 260
        '
        'clValor
        '
        Me.clValor.HeaderText = "VALOR"
        Me.clValor.Name = "clValor"
        Me.clValor.ReadOnly = True
        Me.clValor.Width = 60
        '
        'btnEncerrar
        '
        Me.btnEncerrar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEncerrar.Location = New System.Drawing.Point(-1, 359)
        Me.btnEncerrar.Name = "btnEncerrar"
        Me.btnEncerrar.Size = New System.Drawing.Size(38, 60)
        Me.btnEncerrar.TabIndex = 31
        Me.btnEncerrar.Text = "ENCERRAR PEDIDO"
        Me.btnEncerrar.UseVisualStyleBackColor = True
        Me.btnEncerrar.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.btn3)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtVlrPago)
        Me.Panel2.Controls.Add(Me.btnDec)
        Me.Panel2.Controls.Add(Me.btnA20)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.btnA10)
        Me.Panel2.Controls.Add(Me.btnA60)
        Me.Panel2.Controls.Add(Me.btn7)
        Me.Panel2.Controls.Add(Me.btn8)
        Me.Panel2.Controls.Add(Me.btnA30)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.btnA50)
        Me.Panel2.Controls.Add(Me.txtEmail)
        Me.Panel2.Controls.Add(Me.btnApaga)
        Me.Panel2.Controls.Add(Me.lblTroco)
        Me.Panel2.Controls.Add(Me.btn6)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btn9)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.btn1)
        Me.Panel2.Controls.Add(Me.txtTotal)
        Me.Panel2.Controls.Add(Me.cmdReimprimir)
        Me.Panel2.Controls.Add(Me.btn5)
        Me.Panel2.Controls.Add(Me.txtVlrTroco)
        Me.Panel2.Controls.Add(Me.btn0)
        Me.Panel2.Controls.Add(Me.btn2)
        Me.Panel2.Controls.Add(Me.btn4)
        Me.Panel2.Location = New System.Drawing.Point(479, 45)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(704, 643)
        Me.Panel2.TabIndex = 46
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(15, 158)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 19)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Inserir valores"
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.Gainsboro
        Me.btn3.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(230, 180)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(100, 50)
        Me.btn3.TabIndex = 9
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(24, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 19)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Valor pago"
        '
        'txtVlrPago
        '
        Me.txtVlrPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVlrPago.BackColor = System.Drawing.Color.White
        Me.txtVlrPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVlrPago.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVlrPago.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtVlrPago.Location = New System.Drawing.Point(28, 107)
        Me.txtVlrPago.Name = "txtVlrPago"
        Me.txtVlrPago.Size = New System.Drawing.Size(196, 31)
        Me.txtVlrPago.TabIndex = 17
        Me.txtVlrPago.Text = "0,00"
        Me.txtVlrPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnDec
        '
        Me.btnDec.BackColor = System.Drawing.Color.Gainsboro
        Me.btnDec.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDec.Location = New System.Drawing.Point(124, 348)
        Me.btnDec.Name = "btnDec"
        Me.btnDec.Size = New System.Drawing.Size(100, 50)
        Me.btnDec.TabIndex = 30
        Me.btnDec.Text = ","
        Me.btnDec.UseVisualStyleBackColor = False
        '
        'btnA20
        '
        Me.btnA20.BackColor = System.Drawing.Color.Gainsboro
        Me.btnA20.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnA20.Location = New System.Drawing.Point(336, 236)
        Me.btnA20.Name = "btnA20"
        Me.btnA20.Size = New System.Drawing.Size(114, 50)
        Me.btnA20.TabIndex = 22
        Me.btnA20.Text = "R$20"
        Me.btnA20.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(19, 404)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(205, 50)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Totalizar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnA10
        '
        Me.btnA10.BackColor = System.Drawing.Color.Gainsboro
        Me.btnA10.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnA10.Location = New System.Drawing.Point(336, 180)
        Me.btnA10.Name = "btnA10"
        Me.btnA10.Size = New System.Drawing.Size(114, 50)
        Me.btnA10.TabIndex = 21
        Me.btnA10.Text = "R$10"
        Me.btnA10.UseVisualStyleBackColor = False
        '
        'btnA60
        '
        Me.btnA60.BackColor = System.Drawing.Color.Gainsboro
        Me.btnA60.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnA60.Location = New System.Drawing.Point(336, 404)
        Me.btnA60.Name = "btnA60"
        Me.btnA60.Size = New System.Drawing.Size(114, 50)
        Me.btnA60.TabIndex = 26
        Me.btnA60.Text = "R$100"
        Me.btnA60.UseVisualStyleBackColor = False
        '
        'btn7
        '
        Me.btn7.BackColor = System.Drawing.Color.Gainsboro
        Me.btn7.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(19, 292)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(100, 50)
        Me.btn7.TabIndex = 5
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = False
        '
        'btn8
        '
        Me.btn8.BackColor = System.Drawing.Color.Gainsboro
        Me.btn8.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(124, 292)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(100, 50)
        Me.btn8.TabIndex = 4
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = False
        '
        'btnA30
        '
        Me.btnA30.BackColor = System.Drawing.Color.Gainsboro
        Me.btnA30.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnA30.Location = New System.Drawing.Point(336, 292)
        Me.btnA30.Name = "btnA30"
        Me.btnA30.Size = New System.Drawing.Size(114, 50)
        Me.btnA30.TabIndex = 23
        Me.btnA30.Text = "R$30"
        Me.btnA30.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 515)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 19)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "E-mail do cliente"
        '
        'btnA50
        '
        Me.btnA50.BackColor = System.Drawing.Color.Gainsboro
        Me.btnA50.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnA50.Location = New System.Drawing.Point(336, 348)
        Me.btnA50.Name = "btnA50"
        Me.btnA50.Size = New System.Drawing.Size(114, 50)
        Me.btnA50.TabIndex = 25
        Me.btnA50.Text = "R$50"
        Me.btnA50.UseVisualStyleBackColor = False
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(18, 538)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(431, 27)
        Me.txtEmail.TabIndex = 43
        Me.txtEmail.Text = "user.system@scope.com.br"
        '
        'btnApaga
        '
        Me.btnApaga.BackColor = System.Drawing.Color.Gainsboro
        Me.btnApaga.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApaga.Location = New System.Drawing.Point(230, 348)
        Me.btnApaga.Name = "btnApaga"
        Me.btnApaga.Size = New System.Drawing.Size(100, 50)
        Me.btnApaga.TabIndex = 12
        Me.btnApaga.Text = "<"
        Me.btnApaga.UseVisualStyleBackColor = False
        '
        'lblTroco
        '
        Me.lblTroco.AutoSize = True
        Me.lblTroco.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTroco.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTroco.ForeColor = System.Drawing.Color.Salmon
        Me.lblTroco.Location = New System.Drawing.Point(247, 7)
        Me.lblTroco.Name = "lblTroco"
        Me.lblTroco.Size = New System.Drawing.Size(159, 29)
        Me.lblTroco.TabIndex = 39
        Me.lblTroco.Text = "Saldo devedor"
        '
        'btn6
        '
        Me.btn6.BackColor = System.Drawing.Color.Gainsboro
        Me.btn6.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(230, 236)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(100, 50)
        Me.btn6.TabIndex = 6
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(25, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 23)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Total geral do pedido"
        '
        'btn9
        '
        Me.btn9.BackColor = System.Drawing.Color.Gainsboro
        Me.btn9.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(230, 292)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(100, 50)
        Me.btn9.TabIndex = 3
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(463, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(225, 19)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Forma de pagamento (Moedas)"
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.Gainsboro
        Me.btn1.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(18, 180)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(100, 50)
        Me.btn1.TabIndex = 11
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotal.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTotal.Location = New System.Drawing.Point(28, 39)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(196, 36)
        Me.txtTotal.TabIndex = 14
        Me.txtTotal.Text = "0,00"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdReimprimir
        '
        Me.cmdReimprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdReimprimir.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdReimprimir.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReimprimir.Location = New System.Drawing.Point(467, 571)
        Me.cmdReimprimir.Name = "cmdReimprimir"
        Me.cmdReimprimir.Size = New System.Drawing.Size(221, 50)
        Me.cmdReimprimir.TabIndex = 34
        Me.cmdReimprimir.Text = "Reimprimir Cupom"
        Me.cmdReimprimir.UseVisualStyleBackColor = False
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.Color.Gainsboro
        Me.btn5.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(124, 236)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(100, 50)
        Me.btn5.TabIndex = 7
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = False
        '
        'txtVlrTroco
        '
        Me.txtVlrTroco.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtVlrTroco.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVlrTroco.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVlrTroco.ForeColor = System.Drawing.Color.LightCoral
        Me.txtVlrTroco.Location = New System.Drawing.Point(252, 37)
        Me.txtVlrTroco.Name = "txtVlrTroco"
        Me.txtVlrTroco.Size = New System.Drawing.Size(198, 40)
        Me.txtVlrTroco.TabIndex = 18
        Me.txtVlrTroco.Text = "1,20"
        Me.txtVlrTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn0
        '
        Me.btn0.BackColor = System.Drawing.Color.Gainsboro
        Me.btn0.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.Location = New System.Drawing.Point(19, 348)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(100, 50)
        Me.btn0.TabIndex = 13
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.Gainsboro
        Me.btn2.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(124, 180)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(100, 50)
        Me.btn2.TabIndex = 10
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.Gainsboro
        Me.btn4.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(19, 236)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(100, 50)
        Me.btn4.TabIndex = 8
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Silver
        Me.Label8.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.IndianRed
        Me.Label8.Location = New System.Drawing.Point(3, 521)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 26)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Total do prato"
        '
        'txtVlrPrato
        '
        Me.txtVlrPrato.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtVlrPrato.BackColor = System.Drawing.Color.Silver
        Me.txtVlrPrato.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVlrPrato.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVlrPrato.ForeColor = System.Drawing.Color.IndianRed
        Me.txtVlrPrato.Location = New System.Drawing.Point(12, 547)
        Me.txtVlrPrato.Name = "txtVlrPrato"
        Me.txtVlrPrato.Size = New System.Drawing.Size(151, 40)
        Me.txtVlrPrato.TabIndex = 48
        Me.txtVlrPrato.Text = "0,00"
        '
        'pnlMoedas
        '
        Me.pnlMoedas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMoedas.AutoScroll = True
        Me.pnlMoedas.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlMoedas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMoedas.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlMoedas.Location = New System.Drawing.Point(947, 79)
        Me.pnlMoedas.Name = "pnlMoedas"
        Me.pnlMoedas.Size = New System.Drawing.Size(221, 532)
        Me.pnlMoedas.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnAnterior)
        Me.Panel1.Controls.Add(Me.btnProximo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnIncluir)
        Me.Panel1.Controls.Add(Me.btnEncerrar)
        Me.Panel1.Controls.Add(Me.grdItemPedido)
        Me.Panel1.Controls.Add(Me.txtVlrPrato)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(9, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(464, 643)
        Me.Panel1.TabIndex = 42
        '
        'btnAnterior
        '
        Me.btnAnterior.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnterior.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAnterior.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.Location = New System.Drawing.Point(221, 523)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(114, 50)
        Me.btnAnterior.TabIndex = 49
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'btnProximo
        '
        Me.btnProximo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProximo.BackColor = System.Drawing.Color.Gainsboro
        Me.btnProximo.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProximo.Location = New System.Drawing.Point(341, 523)
        Me.btnProximo.Name = "btnProximo"
        Me.btnProximo.Size = New System.Drawing.Size(114, 50)
        Me.btnProximo.TabIndex = 49
        Me.btnProximo.Text = ">"
        Me.btnProximo.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(14, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(661, 18)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "- Para excluir itens basta clicar sobre o item desejado na lista (esta ação reque" & _
    "r senha de administrador)."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(14, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(494, 18)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "- O botão 'Totalizar' aplica o valor exato do pedido no campo 'Valor recebido'."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(14, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(604, 18)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "- A moeda 'Fidelidade' só ficará disponível quando o cliente possuir o direito ao" & _
    " uso do prêmio.."
        '
        'pnlInfo
        '
        Me.pnlInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlInfo.BackColor = System.Drawing.Color.LightSeaGreen
        Me.pnlInfo.Controls.Add(Me.Label9)
        Me.pnlInfo.Controls.Add(Me.Label10)
        Me.pnlInfo.Controls.Add(Me.Label11)
        Me.pnlInfo.Location = New System.Drawing.Point(12, 594)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.Size = New System.Drawing.Size(1171, 94)
        Me.pnlInfo.TabIndex = 47
        Me.pnlInfo.Visible = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Gainsboro
        Me.Button2.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(18, 571)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(221, 50)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "Confirmar Alteração"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmEncerrarPedido
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1195, 700)
        Me.Controls.Add(Me.lstItens)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Controls.Add(Me.pnlMoedas)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlInfo)
        Me.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmEncerrarPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPedido"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        CType(Me.grdItemPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlInfo.ResumeLayout(False)
        Me.pnlInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTitulo As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdFechar As System.Windows.Forms.Button
    Friend WithEvents lstItens As System.Windows.Forms.ListView
    Friend WithEvents clnCodigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnDescricao As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnQtde As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnValor As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnIncluir As System.Windows.Forms.Button
    Friend WithEvents grdItemPedido As System.Windows.Forms.DataGridView
    Friend WithEvents clCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clQtde As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clDescricao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clValor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnEncerrar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdReimprimir As System.Windows.Forms.Button
    Friend WithEvents pnlMoedas As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txtVlrTroco As System.Windows.Forms.TextBox
    Friend WithEvents txtVlrPago As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblTroco As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtVlrPrato As System.Windows.Forms.TextBox
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btnDec As System.Windows.Forms.Button
    Friend WithEvents btnA20 As System.Windows.Forms.Button
    Friend WithEvents btnA10 As System.Windows.Forms.Button
    Friend WithEvents btnA60 As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents btnA30 As System.Windows.Forms.Button
    Friend WithEvents btnA50 As System.Windows.Forms.Button
    Friend WithEvents btnApaga As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn0 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents btnProximo As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents pnlInfo As System.Windows.Forms.Panel
End Class
