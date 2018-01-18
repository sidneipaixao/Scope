<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrupoMoeda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGrupoMoeda))
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdFechar = New System.Windows.Forms.Button()
        Me.pnlMoedas = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblMoedaPai = New System.Windows.Forms.Label()
        Me.pnlTitulo.SuspendLayout()
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
        Me.pnlTitulo.Size = New System.Drawing.Size(598, 35)
        Me.pnlTitulo.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(5, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 23)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Moedas do Grupo"
        '
        'cmdFechar
        '
        Me.cmdFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdFechar.BackgroundImage = CType(resources.GetObject("cmdFechar.BackgroundImage"), System.Drawing.Image)
        Me.cmdFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdFechar.FlatAppearance.BorderSize = 0
        Me.cmdFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFechar.Location = New System.Drawing.Point(571, 7)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(24, 21)
        Me.cmdFechar.TabIndex = 6
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'pnlMoedas
        '
        Me.pnlMoedas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMoedas.AutoScroll = True
        Me.pnlMoedas.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlMoedas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMoedas.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlMoedas.Location = New System.Drawing.Point(12, 71)
        Me.pnlMoedas.Name = "pnlMoedas"
        Me.pnlMoedas.Size = New System.Drawing.Size(574, 232)
        Me.pnlMoedas.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(222, 19)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Selecione uma moeda do grupo"
        '
        'lblMoedaPai
        '
        Me.lblMoedaPai.AutoSize = True
        Me.lblMoedaPai.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoedaPai.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblMoedaPai.Location = New System.Drawing.Point(228, 44)
        Me.lblMoedaPai.Name = "lblMoedaPai"
        Me.lblMoedaPai.Size = New System.Drawing.Size(91, 26)
        Me.lblMoedaPai.TabIndex = 48
        Me.lblMoedaPai.Text = "Exemplo"
        '
        'frmGrupoMoeda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 315)
        Me.Controls.Add(Me.lblMoedaPai)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pnlMoedas)
        Me.Controls.Add(Me.pnlTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGrupoMoeda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGrupoMoeda"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlTitulo As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdFechar As System.Windows.Forms.Button
    Friend WithEvents pnlMoedas As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblMoedaPai As System.Windows.Forms.Label
End Class
