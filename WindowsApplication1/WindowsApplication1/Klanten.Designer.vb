<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Klanten
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.KlantenDataGridView = New System.Windows.Forms.DataGridView()
        Me.KlantnrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KlantnaamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KlantlandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KlantadresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KlantpcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KlantwoonplaatsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KlantenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductieLMDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductieLMDataSet = New WindowsApplication1.ProductieLMDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtKlantenKlantNr = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtKlantenKlantLand = New System.Windows.Forms.TextBox()
        Me.TxtKlantenKlantPlaats = New System.Windows.Forms.TextBox()
        Me.TxtKlantenKlantPc = New System.Windows.Forms.TextBox()
        Me.TxtKlantenKlantAdres = New System.Windows.Forms.TextBox()
        Me.TxtKlantenKlantNaam = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KnopNieuweKlant = New System.Windows.Forms.Button()
        Me.KnopZoekKlant = New System.Windows.Forms.Button()
        Me.KlantenTableAdapter = New WindowsApplication1.ProductieLMDataSetTableAdapters.KlantenTableAdapter()
        Me.KnopKlantenSluiten = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KnopKlantenLeegmaken = New System.Windows.Forms.Button()
        CType(Me.KlantenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KlantenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductieLMDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductieLMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KlantenDataGridView
        '
        Me.KlantenDataGridView.AllowUserToAddRows = False
        Me.KlantenDataGridView.AllowUserToDeleteRows = False
        Me.KlantenDataGridView.AutoGenerateColumns = False
        Me.KlantenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.KlantenDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KlantnrDataGridViewTextBoxColumn, Me.KlantnaamDataGridViewTextBoxColumn, Me.KlantlandDataGridViewTextBoxColumn, Me.KlantadresDataGridViewTextBoxColumn, Me.KlantpcDataGridViewTextBoxColumn, Me.KlantwoonplaatsDataGridViewTextBoxColumn})
        Me.KlantenDataGridView.DataSource = Me.KlantenBindingSource
        Me.KlantenDataGridView.Location = New System.Drawing.Point(330, 12)
        Me.KlantenDataGridView.Name = "KlantenDataGridView"
        Me.KlantenDataGridView.ReadOnly = True
        Me.KlantenDataGridView.Size = New System.Drawing.Size(645, 435)
        Me.KlantenDataGridView.TabIndex = 0
        '
        'KlantnrDataGridViewTextBoxColumn
        '
        Me.KlantnrDataGridViewTextBoxColumn.DataPropertyName = "klantnr"
        Me.KlantnrDataGridViewTextBoxColumn.HeaderText = "klantnr"
        Me.KlantnrDataGridViewTextBoxColumn.Name = "KlantnrDataGridViewTextBoxColumn"
        Me.KlantnrDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KlantnaamDataGridViewTextBoxColumn
        '
        Me.KlantnaamDataGridViewTextBoxColumn.DataPropertyName = "klantnaam"
        Me.KlantnaamDataGridViewTextBoxColumn.HeaderText = "klantnaam"
        Me.KlantnaamDataGridViewTextBoxColumn.Name = "KlantnaamDataGridViewTextBoxColumn"
        Me.KlantnaamDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KlantlandDataGridViewTextBoxColumn
        '
        Me.KlantlandDataGridViewTextBoxColumn.DataPropertyName = "klantland"
        Me.KlantlandDataGridViewTextBoxColumn.HeaderText = "klantland"
        Me.KlantlandDataGridViewTextBoxColumn.Name = "KlantlandDataGridViewTextBoxColumn"
        Me.KlantlandDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KlantadresDataGridViewTextBoxColumn
        '
        Me.KlantadresDataGridViewTextBoxColumn.DataPropertyName = "klantadres"
        Me.KlantadresDataGridViewTextBoxColumn.HeaderText = "klantadres"
        Me.KlantadresDataGridViewTextBoxColumn.Name = "KlantadresDataGridViewTextBoxColumn"
        Me.KlantadresDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KlantpcDataGridViewTextBoxColumn
        '
        Me.KlantpcDataGridViewTextBoxColumn.DataPropertyName = "klantpc"
        Me.KlantpcDataGridViewTextBoxColumn.HeaderText = "klantpc"
        Me.KlantpcDataGridViewTextBoxColumn.Name = "KlantpcDataGridViewTextBoxColumn"
        Me.KlantpcDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KlantwoonplaatsDataGridViewTextBoxColumn
        '
        Me.KlantwoonplaatsDataGridViewTextBoxColumn.DataPropertyName = "klantwoonplaats"
        Me.KlantwoonplaatsDataGridViewTextBoxColumn.HeaderText = "klantwoonplaats"
        Me.KlantwoonplaatsDataGridViewTextBoxColumn.Name = "KlantwoonplaatsDataGridViewTextBoxColumn"
        Me.KlantwoonplaatsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KlantenBindingSource
        '
        Me.KlantenBindingSource.DataMember = "Klanten"
        Me.KlantenBindingSource.DataSource = Me.ProductieLMDataSetBindingSource
        '
        'ProductieLMDataSetBindingSource
        '
        Me.ProductieLMDataSetBindingSource.DataSource = Me.ProductieLMDataSet
        Me.ProductieLMDataSetBindingSource.Position = 0
        '
        'ProductieLMDataSet
        '
        Me.ProductieLMDataSet.DataSetName = "ProductieLMDataSet"
        Me.ProductieLMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.KnopKlantenLeegmaken)
        Me.GroupBox1.Controls.Add(Me.TxtKlantenKlantNr)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtKlantenKlantLand)
        Me.GroupBox1.Controls.Add(Me.TxtKlantenKlantPlaats)
        Me.GroupBox1.Controls.Add(Me.TxtKlantenKlantPc)
        Me.GroupBox1.Controls.Add(Me.TxtKlantenKlantAdres)
        Me.GroupBox1.Controls.Add(Me.TxtKlantenKlantNaam)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.KnopNieuweKlant)
        Me.GroupBox1.Controls.Add(Me.KnopZoekKlant)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 199)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'TxtKlantenKlantNr
        '
        Me.TxtKlantenKlantNr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KlantenBindingSource, "klantnr", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
        Me.TxtKlantenKlantNr.Location = New System.Drawing.Point(73, 13)
        Me.TxtKlantenKlantNr.Name = "TxtKlantenKlantNr"
        Me.TxtKlantenKlantNr.Size = New System.Drawing.Size(232, 20)
        Me.TxtKlantenKlantNr.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Klantnummer"
        '
        'TxtKlantenKlantLand
        '
        Me.TxtKlantenKlantLand.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KlantenBindingSource, "klantland", True))
        Me.TxtKlantenKlantLand.Location = New System.Drawing.Point(73, 144)
        Me.TxtKlantenKlantLand.Name = "TxtKlantenKlantLand"
        Me.TxtKlantenKlantLand.Size = New System.Drawing.Size(232, 20)
        Me.TxtKlantenKlantLand.TabIndex = 11
        '
        'TxtKlantenKlantPlaats
        '
        Me.TxtKlantenKlantPlaats.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KlantenBindingSource, "klantwoonplaats", True))
        Me.TxtKlantenKlantPlaats.Location = New System.Drawing.Point(73, 118)
        Me.TxtKlantenKlantPlaats.Name = "TxtKlantenKlantPlaats"
        Me.TxtKlantenKlantPlaats.Size = New System.Drawing.Size(232, 20)
        Me.TxtKlantenKlantPlaats.TabIndex = 10
        '
        'TxtKlantenKlantPc
        '
        Me.TxtKlantenKlantPc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KlantenBindingSource, "klantpc", True))
        Me.TxtKlantenKlantPc.Location = New System.Drawing.Point(73, 92)
        Me.TxtKlantenKlantPc.Name = "TxtKlantenKlantPc"
        Me.TxtKlantenKlantPc.Size = New System.Drawing.Size(232, 20)
        Me.TxtKlantenKlantPc.TabIndex = 9
        '
        'TxtKlantenKlantAdres
        '
        Me.TxtKlantenKlantAdres.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KlantenBindingSource, "klantadres", True))
        Me.TxtKlantenKlantAdres.Location = New System.Drawing.Point(73, 66)
        Me.TxtKlantenKlantAdres.Name = "TxtKlantenKlantAdres"
        Me.TxtKlantenKlantAdres.Size = New System.Drawing.Size(232, 20)
        Me.TxtKlantenKlantAdres.TabIndex = 8
        '
        'TxtKlantenKlantNaam
        '
        Me.TxtKlantenKlantNaam.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KlantenBindingSource, "klantnaam", True))
        Me.TxtKlantenKlantNaam.Location = New System.Drawing.Point(73, 39)
        Me.TxtKlantenKlantNaam.Name = "TxtKlantenKlantNaam"
        Me.TxtKlantenKlantNaam.Size = New System.Drawing.Size(232, 20)
        Me.TxtKlantenKlantNaam.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Land"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Woonplaats"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Postcode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Adres"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Naam"
        '
        'KnopNieuweKlant
        '
        Me.KnopNieuweKlant.Location = New System.Drawing.Point(9, 170)
        Me.KnopNieuweKlant.Name = "KnopNieuweKlant"
        Me.KnopNieuweKlant.Size = New System.Drawing.Size(75, 23)
        Me.KnopNieuweKlant.TabIndex = 1
        Me.KnopNieuweKlant.Text = "Nieuw"
        Me.KnopNieuweKlant.UseVisualStyleBackColor = True
        '
        'KnopZoekKlant
        '
        Me.KnopZoekKlant.Location = New System.Drawing.Point(230, 170)
        Me.KnopZoekKlant.Name = "KnopZoekKlant"
        Me.KnopZoekKlant.Size = New System.Drawing.Size(75, 23)
        Me.KnopZoekKlant.TabIndex = 0
        Me.KnopZoekKlant.Text = "Zoeken"
        Me.KnopZoekKlant.UseVisualStyleBackColor = True
        '
        'KlantenTableAdapter
        '
        Me.KlantenTableAdapter.ClearBeforeFill = True
        '
        'KnopKlantenSluiten
        '
        Me.KnopKlantenSluiten.Location = New System.Drawing.Point(243, 424)
        Me.KnopKlantenSluiten.Name = "KnopKlantenSluiten"
        Me.KnopKlantenSluiten.Size = New System.Drawing.Size(75, 23)
        Me.KnopKlantenSluiten.TabIndex = 14
        Me.KnopKlantenSluiten.Text = "Sluiten"
        Me.KnopKlantenSluiten.UseVisualStyleBackColor = True
        '
        'KnopKlantenLeegmaken
        '
        Me.KnopKlantenLeegmaken.Location = New System.Drawing.Point(126, 170)
        Me.KnopKlantenLeegmaken.Name = "KnopKlantenLeegmaken"
        Me.KnopKlantenLeegmaken.Size = New System.Drawing.Size(75, 23)
        Me.KnopKlantenLeegmaken.TabIndex = 14
        Me.KnopKlantenLeegmaken.Text = "Leegmaken"
        Me.KnopKlantenLeegmaken.UseVisualStyleBackColor = True
        '
        'Klanten
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 467)
        Me.Controls.Add(Me.KnopKlantenSluiten)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.KlantenDataGridView)
        Me.Name = "Klanten"
        Me.Text = "Klanten"
        CType(Me.KlantenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KlantenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductieLMDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductieLMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents KlantenDataGridView As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents KnopNieuweKlant As Button
    Friend WithEvents KnopZoekKlant As Button
    Friend WithEvents TxtKlantenKlantLand As TextBox
    Friend WithEvents TxtKlantenKlantPlaats As TextBox
    Friend WithEvents TxtKlantenKlantPc As TextBox
    Friend WithEvents TxtKlantenKlantAdres As TextBox
    Friend WithEvents TxtKlantenKlantNaam As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ProductieLMDataSetBindingSource As BindingSource
    Friend WithEvents ProductieLMDataSet As ProductieLMDataSet
    Friend WithEvents KlantenBindingSource As BindingSource
    Friend WithEvents KlantenTableAdapter As ProductieLMDataSetTableAdapters.KlantenTableAdapter
    Friend WithEvents TxtKlantenKlantNr As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents KlantnrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KlantnaamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KlantlandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KlantadresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KlantpcDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KlantwoonplaatsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KnopKlantenSluiten As Button
    Friend WithEvents KnopKlantenLeegmaken As Button
End Class
