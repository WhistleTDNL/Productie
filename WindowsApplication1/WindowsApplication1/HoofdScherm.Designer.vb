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
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Relaties", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Artikelen", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Orders", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Klanten")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Leveranciers")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Artikelen")
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Grondstoffen")
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Order")
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
        Me.OptiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SimProdPlan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.OptiesToolStripMenuItem, Me.OverToolStripMenuItem})
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
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ListView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Size = New System.Drawing.Size(1407, 582)
        Me.SplitContainer1.SplitterDistance = 110
        Me.SplitContainer1.TabIndex = 1
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SimProdPlan})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        ListViewGroup1.Header = "Relaties"
        ListViewGroup1.Name = "ListViewGroupRelaties"
        ListViewGroup1.Tag = ""
        ListViewGroup2.Header = "Artikelen"
        ListViewGroup2.Name = "ListViewGroupArtikelen"
        ListViewGroup3.Header = "Orders"
        ListViewGroup3.Name = "ListViewGroupOrder"
        Me.ListView1.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3})
        ListViewItem1.Group = ListViewGroup1
        ListViewItem2.Group = ListViewGroup1
        ListViewItem2.StateImageIndex = 0
        ListViewItem3.Group = ListViewGroup2
        ListViewItem4.Group = ListViewGroup2
        ListViewItem5.Group = ListViewGroup3
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5})
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(110, 582)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'SimProdPlan
        '
        Me.SimProdPlan.Tag = ""
        Me.SimProdPlan.Text = "SimProdPlan"
        Me.SimProdPlan.Width = 79
        '
        'HoofdScherm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1407, 606)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "HoofdScherm"
        Me.Text = "SimProdPlan"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
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
    Friend WithEvents OptiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ListView1 As ListView
    Friend WithEvents SimProdPlan As ColumnHeader
End Class
