<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncluirItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIncluirItem))
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdFechar = New System.Windows.Forms.Button()
        Me.objGrupos = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lstItens = New System.Windows.Forms.ListView()
        Me.clnVazio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clnCodigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clnDescricao = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clnQtde = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clnValor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lstItensGrupo = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlInfo = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.pnlTitulo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.pnlInfo.SuspendLayout()
        Me.SuspendLayout()
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
        Me.pnlTitulo.Size = New System.Drawing.Size(1024, 35)
        Me.pnlTitulo.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(5, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 23)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Incluir Itens"
        '
        'cmdFechar
        '
        Me.cmdFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdFechar.BackgroundImage = CType(resources.GetObject("cmdFechar.BackgroundImage"), System.Drawing.Image)
        Me.cmdFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdFechar.FlatAppearance.BorderSize = 0
        Me.cmdFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFechar.Location = New System.Drawing.Point(997, 7)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(24, 21)
        Me.cmdFechar.TabIndex = 6
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'objGrupos
        '
        Me.objGrupos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.objGrupos.AutoScroll = True
        Me.objGrupos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.objGrupos.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.objGrupos.Location = New System.Drawing.Point(483, 73)
        Me.objGrupos.Name = "objGrupos"
        Me.objGrupos.Size = New System.Drawing.Size(173, 468)
        Me.objGrupos.TabIndex = 32
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Black
        Me.txtTotal.Location = New System.Drawing.Point(312, 501)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(223, 33)
        Me.txtTotal.TabIndex = 34
        Me.txtTotal.Text = "0,00"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAtualizar.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtualizar.Location = New System.Drawing.Point(337, 501)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(119, 31)
        Me.btnAtualizar.TabIndex = 36
        Me.btnAtualizar.Text = "Atualizar pedido"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(9, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(464, 543)
        Me.Panel1.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(1, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 23)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Resumo do pedido"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lstItens)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnAtualizar)
        Me.Panel2.Location = New System.Drawing.Point(-1, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(464, 543)
        Me.Panel2.TabIndex = 45
        '
        'lstItens
        '
        Me.lstItens.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstItens.BackColor = System.Drawing.Color.White
        Me.lstItens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstItens.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clnVazio, Me.clnCodigo, Me.clnDescricao, Me.clnQtde, Me.clnValor})
        Me.lstItens.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstItens.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lstItens.FullRowSelect = True
        Me.lstItens.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstItens.Location = New System.Drawing.Point(7, 31)
        Me.lstItens.MultiSelect = False
        Me.lstItens.Name = "lstItens"
        Me.lstItens.Size = New System.Drawing.Size(449, 464)
        Me.lstItens.TabIndex = 44
        Me.lstItens.UseCompatibleStateImageBehavior = False
        Me.lstItens.View = System.Windows.Forms.View.Details
        '
        'clnVazio
        '
        Me.clnVazio.DisplayIndex = 4
        Me.clnVazio.Text = "Vazio"
        Me.clnVazio.Width = 0
        '
        'clnCodigo
        '
        Me.clnCodigo.DisplayIndex = 0
        Me.clnCodigo.Text = "Código"
        Me.clnCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.clnCodigo.Width = 61
        '
        'clnDescricao
        '
        Me.clnDescricao.DisplayIndex = 1
        Me.clnDescricao.Text = "Descrição"
        Me.clnDescricao.Width = 268
        '
        'clnQtde
        '
        Me.clnQtde.DisplayIndex = 2
        Me.clnQtde.Text = "Qtde"
        Me.clnQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clnQtde.Width = 61
        '
        'clnValor
        '
        Me.clnValor.DisplayIndex = 3
        Me.clnValor.Text = "Valor"
        Me.clnValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.clnValor.Width = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(1, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 23)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Resumo do pedido"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(482, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 19)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Grupos"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lstItensGrupo)
        Me.Panel3.Location = New System.Drawing.Point(662, 73)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(350, 468)
        Me.Panel3.TabIndex = 47
        '
        'lstItensGrupo
        '
        Me.lstItensGrupo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstItensGrupo.BackColor = System.Drawing.Color.White
        Me.lstItensGrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstItensGrupo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lstItensGrupo.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstItensGrupo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lstItensGrupo.FullRowSelect = True
        Me.lstItensGrupo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstItensGrupo.Location = New System.Drawing.Point(10, 3)
        Me.lstItensGrupo.MultiSelect = False
        Me.lstItensGrupo.Name = "lstItensGrupo"
        Me.lstItensGrupo.Size = New System.Drawing.Size(332, 460)
        Me.lstItensGrupo.TabIndex = 46
        Me.lstItensGrupo.UseCompatibleStateImageBehavior = False
        Me.lstItensGrupo.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.DisplayIndex = 4
        Me.ColumnHeader1.Text = "Vazio"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.DisplayIndex = 0
        Me.ColumnHeader2.Text = "Código"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 61
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.DisplayIndex = 1
        Me.ColumnHeader3.Text = "Descrição"
        Me.ColumnHeader3.Width = 500
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.DisplayIndex = 2
        Me.ColumnHeader4.Text = "Qtde"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 0
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.DisplayIndex = 3
        Me.ColumnHeader5.Text = "Valor"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(181, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 19)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Itens do grupo"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.txtTotal)
        Me.Panel4.Location = New System.Drawing.Point(476, 45)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(543, 543)
        Me.Panel4.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 501)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 19)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Total do pedido"
        '
        'pnlInfo
        '
        Me.pnlInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlInfo.BackColor = System.Drawing.Color.LightSeaGreen
        Me.pnlInfo.Controls.Add(Me.Label9)
        Me.pnlInfo.Controls.Add(Me.Label10)
        Me.pnlInfo.Controls.Add(Me.Label11)
        Me.pnlInfo.Location = New System.Drawing.Point(9, 594)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.Size = New System.Drawing.Size(1010, 94)
        Me.pnlInfo.TabIndex = 50
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(14, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(510, 18)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "- Escolha um grupo para exibir uma lista de produtos no painel ""Itens do grupo""."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(14, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(648, 18)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "- Para adicionar itens ao pedido selecione o item desejado na lista ""Itens do gru" & _
    "po"" clicando sobre ele."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(14, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(592, 18)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "- Você também pode excluir itens do pedido aqui. (esta ação requer senha de admin" & _
    "istrador)."
        '
        'frmIncluirItem
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1024, 700)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlInfo)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.objGrupos)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmIncluirItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmIncluirItem"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.pnlInfo.ResumeLayout(False)
        Me.pnlInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlTitulo As System.Windows.Forms.Panel
    Friend WithEvents objGrupos As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
    Friend WithEvents cmdFechar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstItens As System.Windows.Forms.ListView
    Friend WithEvents clnVazio As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnCodigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnDescricao As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnQtde As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnValor As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lstItensGrupo As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlInfo As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
