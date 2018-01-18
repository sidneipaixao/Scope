<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMoeda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMoeda))
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdFechar = New System.Windows.Forms.Button()
        Me.txtMoeda = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbGrupo = New System.Windows.Forms.ComboBox()
        Me.optExibir = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optNaoFiscal = New System.Windows.Forms.CheckBox()
        Me.optCozinha = New System.Windows.Forms.CheckBox()
        Me.optNaoDisp1 = New System.Windows.Forms.CheckBox()
        Me.optNaoDisp2 = New System.Windows.Forms.CheckBox()
        Me.optFiscal = New System.Windows.Forms.CheckBox()
        Me.optTotaliza = New System.Windows.Forms.CheckBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.trvMoeda = New System.Windows.Forms.TreeView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.pnlInfo = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlTitulo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnlInfo.SuspendLayout()
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
        Me.pnlTitulo.Size = New System.Drawing.Size(1000, 35)
        Me.pnlTitulo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(5, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 23)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Cadastrar Moedas"
        '
        'cmdFechar
        '
        Me.cmdFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdFechar.BackgroundImage = CType(resources.GetObject("cmdFechar.BackgroundImage"), System.Drawing.Image)
        Me.cmdFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdFechar.FlatAppearance.BorderSize = 0
        Me.cmdFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFechar.Location = New System.Drawing.Point(971, 7)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(24, 21)
        Me.cmdFechar.TabIndex = 4
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'txtMoeda
        '
        Me.txtMoeda.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMoeda.Location = New System.Drawing.Point(478, 78)
        Me.txtMoeda.MaxLength = 30
        Me.txtMoeda.Name = "txtMoeda"
        Me.txtMoeda.Size = New System.Drawing.Size(379, 26)
        Me.txtMoeda.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(478, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nome moeda"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(478, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Grupo ao qual faz parte"
        '
        'cmbGrupo
        '
        Me.cmbGrupo.DisplayMember = "MDSNOME"
        Me.cmbGrupo.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGrupo.FormattingEnabled = True
        Me.cmbGrupo.Location = New System.Drawing.Point(478, 130)
        Me.cmbGrupo.Name = "cmbGrupo"
        Me.cmbGrupo.Size = New System.Drawing.Size(379, 26)
        Me.cmbGrupo.TabIndex = 2
        Me.cmbGrupo.ValueMember = "MDSCODIGO"
        '
        'optExibir
        '
        Me.optExibir.AutoSize = True
        Me.optExibir.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optExibir.Location = New System.Drawing.Point(478, 168)
        Me.optExibir.Name = "optExibir"
        Me.optExibir.Size = New System.Drawing.Size(245, 22)
        Me.optExibir.TabIndex = 3
        Me.optExibir.Text = "Exibir moeda na tela de pagamento"
        Me.optExibir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optNaoFiscal)
        Me.GroupBox1.Controls.Add(Me.optCozinha)
        Me.GroupBox1.Controls.Add(Me.optNaoDisp1)
        Me.GroupBox1.Controls.Add(Me.optNaoDisp2)
        Me.GroupBox1.Controls.Add(Me.optFiscal)
        Me.GroupBox1.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(478, 235)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 189)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Impressão"
        '
        'optNaoFiscal
        '
        Me.optNaoFiscal.AutoSize = True
        Me.optNaoFiscal.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optNaoFiscal.Location = New System.Drawing.Point(6, 57)
        Me.optNaoFiscal.Name = "optNaoFiscal"
        Me.optNaoFiscal.Size = New System.Drawing.Size(88, 22)
        Me.optNaoFiscal.TabIndex = 7
        Me.optNaoFiscal.Tag = "2"
        Me.optNaoFiscal.Text = "Não Fiscal"
        Me.optNaoFiscal.UseVisualStyleBackColor = True
        '
        'optCozinha
        '
        Me.optCozinha.AutoSize = True
        Me.optCozinha.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCozinha.Location = New System.Drawing.Point(6, 85)
        Me.optCozinha.Name = "optCozinha"
        Me.optCozinha.Size = New System.Drawing.Size(76, 22)
        Me.optCozinha.TabIndex = 8
        Me.optCozinha.Tag = "4"
        Me.optCozinha.Text = "Cozinha"
        Me.optCozinha.UseVisualStyleBackColor = True
        '
        'optNaoDisp1
        '
        Me.optNaoDisp1.AutoSize = True
        Me.optNaoDisp1.Enabled = False
        Me.optNaoDisp1.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optNaoDisp1.Location = New System.Drawing.Point(6, 113)
        Me.optNaoDisp1.Name = "optNaoDisp1"
        Me.optNaoDisp1.Size = New System.Drawing.Size(117, 22)
        Me.optNaoDisp1.TabIndex = 9
        Me.optNaoDisp1.Tag = "8"
        Me.optNaoDisp1.Text = "Não disponível"
        Me.optNaoDisp1.UseVisualStyleBackColor = True
        '
        'optNaoDisp2
        '
        Me.optNaoDisp2.AutoSize = True
        Me.optNaoDisp2.Enabled = False
        Me.optNaoDisp2.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optNaoDisp2.Location = New System.Drawing.Point(6, 141)
        Me.optNaoDisp2.Name = "optNaoDisp2"
        Me.optNaoDisp2.Size = New System.Drawing.Size(117, 22)
        Me.optNaoDisp2.TabIndex = 10
        Me.optNaoDisp2.Tag = "16"
        Me.optNaoDisp2.Text = "Não disponível"
        Me.optNaoDisp2.UseVisualStyleBackColor = True
        '
        'optFiscal
        '
        Me.optFiscal.AutoSize = True
        Me.optFiscal.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optFiscal.Location = New System.Drawing.Point(6, 29)
        Me.optFiscal.Name = "optFiscal"
        Me.optFiscal.Size = New System.Drawing.Size(60, 22)
        Me.optFiscal.TabIndex = 6
        Me.optFiscal.Tag = "1"
        Me.optFiscal.Text = "Fiscal"
        Me.optFiscal.UseVisualStyleBackColor = True
        '
        'optTotaliza
        '
        Me.optTotaliza.AutoSize = True
        Me.optTotaliza.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optTotaliza.Location = New System.Drawing.Point(478, 196)
        Me.optTotaliza.Name = "optTotaliza"
        Me.optTotaliza.Size = New System.Drawing.Size(168, 22)
        Me.optTotaliza.TabIndex = 4
        Me.optTotaliza.Text = "Totalização automática"
        Me.optTotaliza.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.Location = New System.Drawing.Point(641, 430)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(105, 31)
        Me.btnSalvar.TabIndex = 11
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 18)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Moedas cadastradas"
        '
        'trvMoeda
        '
        Me.trvMoeda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvMoeda.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trvMoeda.Location = New System.Drawing.Point(12, 78)
        Me.trvMoeda.Name = "trvMoeda"
        Me.trvMoeda.Size = New System.Drawing.Size(444, 474)
        Me.trvMoeda.TabIndex = 14
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(752, 430)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(105, 31)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(429, 49)
        Me.txtCodigo.MaxLength = 30
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(27, 26)
        Me.txtCodigo.TabIndex = 17
        Me.txtCodigo.Visible = False
        '
        'pnlInfo
        '
        Me.pnlInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlInfo.BackColor = System.Drawing.Color.LightSeaGreen
        Me.pnlInfo.Controls.Add(Me.Label9)
        Me.pnlInfo.Controls.Add(Me.Label7)
        Me.pnlInfo.Controls.Add(Me.Label6)
        Me.pnlInfo.Controls.Add(Me.Label5)
        Me.pnlInfo.Location = New System.Drawing.Point(12, 573)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.Size = New System.Drawing.Size(976, 115)
        Me.pnlInfo.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(14, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(750, 18)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "- Ao iniciar a criação de uma moeda e selecionar um grupo, inicialmente, esta ter" & _
    "á as mesmas características do grupo."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(14, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(358, 18)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "- Clique sobre uma moeda para editar suas informações."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(14, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(304, 18)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "- Grupos também serão exibidos como moedas."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(14, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(508, 18)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "- Para criar um grupo deixe a seleção do combo ""Grupo ao qual faz parte"" vazio."
        '
        'frmMoeda
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me.pnlInfo)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.trvMoeda)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.optTotaliza)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.optExibir)
        Me.Controls.Add(Me.cmbGrupo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMoeda)
        Me.Controls.Add(Me.pnlTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMoeda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Moedas"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlInfo.ResumeLayout(False)
        Me.pnlInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlTitulo As System.Windows.Forms.Panel
    Friend WithEvents cmdFechar As System.Windows.Forms.Button
    Friend WithEvents txtMoeda As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents optExibir As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optNaoFiscal As System.Windows.Forms.CheckBox
    Friend WithEvents optCozinha As System.Windows.Forms.CheckBox
    Friend WithEvents optNaoDisp1 As System.Windows.Forms.CheckBox
    Friend WithEvents optNaoDisp2 As System.Windows.Forms.CheckBox
    Friend WithEvents optFiscal As System.Windows.Forms.CheckBox
    Friend WithEvents optTotaliza As System.Windows.Forms.CheckBox
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents trvMoeda As System.Windows.Forms.TreeView
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents pnlInfo As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
