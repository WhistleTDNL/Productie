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
        Dim ListViewGroup4 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Relaties", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup5 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Artikelen", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup6 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Orders", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Klanten")
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Leveranciers")
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Artikelen")
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Grondstoffen")
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Orders")
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtikelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AfsluitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SimProdPlan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StamgegevensToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.StartToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArtikelToolStripMenuItem, Me.ToolStripSeparator1, Me.AfsluitenToolStripMenuItem})
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'ArtikelToolStripMenuItem
        '
        Me.ArtikelToolStripMenuItem.Name = "ArtikelToolStripMenuItem"
        Me.ArtikelToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ArtikelToolStripMenuItem.Text = "Rapportages"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'AfsluitenToolStripMenuItem
        '
        Me.AfsluitenToolStripMenuItem.Name = "AfsluitenToolStripMenuItem"
        Me.AfsluitenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AfsluitenToolStripMenuItem.Text = "Afsluiten"
        '
        'OptiesToolStripMenuItem
        '
        Me.OptiesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatabaseToolStripMenuItem, Me.StamgegevensToolStripMenuItem})
        Me.OptiesToolStripMenuItem.Name = "OptiesToolStripMenuItem"
        Me.OptiesToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.OptiesToolStripMenuItem.Text = "Opties"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1407, 582)
        Me.SplitContainer1.SplitterDistance = 110
        Me.SplitContainer1.TabIndex = 1
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView1.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.ListView1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ListView1.CausesValidation = False
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SimProdPlan})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        ListViewGroup4.Header = "Relaties"
        ListViewGroup4.Name = "ListViewGroupRelaties"
        ListViewGroup4.Tag = ""
        ListViewGroup5.Header = "Artikelen"
        ListViewGroup5.Name = "ListViewGroupArtikelen"
        ListViewGroup6.Header = "Orders"
        ListViewGroup6.Name = "ListViewGroupOrder"
        Me.ListView1.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup4, ListViewGroup5, ListViewGroup6})
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListView1.HideSelection = False
        ListViewItem7.StateImageIndex = 0
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10})
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowGroups = False
        Me.ListView1.ShowItemToolTips = True
        Me.ListView1.Size = New System.Drawing.Size(110, 582)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Tile
        '
        'SimProdPlan
        '
        Me.SimProdPlan.Tag = ""
        Me.SimProdPlan.Text = "SimProdPlan"
        Me.SimProdPlan.Width = 79
        '
        'StamgegevensToolStripMenuItem
        '
        Me.StamgegevensToolStripMenuItem.Name = "StamgegevensToolStripMenuItem"
        Me.StamgegevensToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StamgegevensToolStripMenuItem.Text = "Stamgegevens"
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
    Friend WithEvents ArtikelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ListView1 As ListView
    Friend WithEvents SimProdPlan As ColumnHeader
    Friend WithEvents StamgegevensToolStripMenuItem As ToolStripMenuItem
End Class
