<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HoofdScherm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KlantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeverancierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtikelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrondstofToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtikelToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AfsluitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RapportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.RapportToolStripMenuItem, Me.OptiesToolStripMenuItem, Me.OverToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1407, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrderToolStripMenuItem, Me.RelatieToolStripMenuItem, Me.ArtikelToolStripMenuItem, Me.ToolStripSeparator1, Me.AfsluitenToolStripMenuItem})
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'OrderToolStripMenuItem
        '
        Me.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem"
        Me.OrderToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.OrderToolStripMenuItem.Text = "Order"
        '
        'RelatieToolStripMenuItem
        '
        Me.RelatieToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KlantToolStripMenuItem, Me.LeverancierToolStripMenuItem})
        Me.RelatieToolStripMenuItem.Name = "RelatieToolStripMenuItem"
        Me.RelatieToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.RelatieToolStripMenuItem.Text = "Relatie"
        '
        'KlantToolStripMenuItem
        '
        Me.KlantToolStripMenuItem.Name = "KlantToolStripMenuItem"
        Me.KlantToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.KlantToolStripMenuItem.Text = "Klant"
        '
        'LeverancierToolStripMenuItem
        '
        Me.LeverancierToolStripMenuItem.Name = "LeverancierToolStripMenuItem"
        Me.LeverancierToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.LeverancierToolStripMenuItem.Text = "Leverancier"
        '
        'ArtikelToolStripMenuItem
        '
        Me.ArtikelToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GrondstofToolStripMenuItem, Me.ArtikelToolStripMenuItem1})
        Me.ArtikelToolStripMenuItem.Name = "ArtikelToolStripMenuItem"
        Me.ArtikelToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.ArtikelToolStripMenuItem.Text = "Artikel"
        '
        'GrondstofToolStripMenuItem
        '
        Me.GrondstofToolStripMenuItem.Name = "GrondstofToolStripMenuItem"
        Me.GrondstofToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.GrondstofToolStripMenuItem.Text = "Grondstof"
        '
        'ArtikelToolStripMenuItem1
        '
        Me.ArtikelToolStripMenuItem1.Name = "ArtikelToolStripMenuItem1"
        Me.ArtikelToolStripMenuItem1.Size = New System.Drawing.Size(127, 22)
        Me.ArtikelToolStripMenuItem1.Text = "Artikel"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(118, 6)
        '
        'AfsluitenToolStripMenuItem
        '
        Me.AfsluitenToolStripMenuItem.Name = "AfsluitenToolStripMenuItem"
        Me.AfsluitenToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.AfsluitenToolStripMenuItem.Text = "Afsluiten"
        '
        'RapportToolStripMenuItem
        '
        Me.RapportToolStripMenuItem.Name = "RapportToolStripMenuItem"
        Me.RapportToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.RapportToolStripMenuItem.Text = "Rapport"
        '
        'OptiesToolStripMenuItem
        '
        Me.OptiesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatabaseToolStripMenuItem})
        Me.OptiesToolStripMenuItem.Name = "OptiesToolStripMenuItem"
        Me.OptiesToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.OptiesToolStripMenuItem.Text = "Opties"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.DatabaseToolStripMenuItem.Text = "Database"
        '
        'OverToolStripMenuItem
        '
        Me.OverToolStripMenuItem.Name = "OverToolStripMenuItem"
        Me.OverToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.OverToolStripMenuItem.Text = "Over"
        '
        'HoofdScherm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1407, 606)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "HoofdScherm"
        Me.Text = "SimProdPlan"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AfsluitenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KlantToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeverancierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArtikelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GrondstofToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArtikelToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RapportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OverToolStripMenuItem As ToolStripMenuItem
End Class
