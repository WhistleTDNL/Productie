<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCStamgegevens
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.KnopNieuw = New System.Windows.Forms.Button()
        Me.KnopLeegmaken = New System.Windows.Forms.Button()
        Me.KnopZoek = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt2 = New System.Windows.Forms.TextBox()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt4 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KnopNieuw
        '
        Me.KnopNieuw.Location = New System.Drawing.Point(170, 56)
        Me.KnopNieuw.Name = "KnopNieuw"
        Me.KnopNieuw.Size = New System.Drawing.Size(75, 23)
        Me.KnopNieuw.TabIndex = 15
        Me.KnopNieuw.Text = "Nieuw"
        Me.KnopNieuw.UseVisualStyleBackColor = True
        '
        'KnopLeegmaken
        '
        Me.KnopLeegmaken.Location = New System.Drawing.Point(89, 56)
        Me.KnopLeegmaken.Name = "KnopLeegmaken"
        Me.KnopLeegmaken.Size = New System.Drawing.Size(75, 23)
        Me.KnopLeegmaken.TabIndex = 14
        Me.KnopLeegmaken.Text = "Leegmaken"
        Me.KnopLeegmaken.UseVisualStyleBackColor = True
        '
        'KnopZoek
        '
        Me.KnopZoek.Location = New System.Drawing.Point(8, 56)
        Me.KnopZoek.Name = "KnopZoek"
        Me.KnopZoek.Size = New System.Drawing.Size(75, 23)
        Me.KnopZoek.TabIndex = 13
        Me.KnopZoek.Text = "Zoek"
        Me.KnopZoek.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Veld1"
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(89, 3)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(156, 20)
        Me.Txt1.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Veld2"
        '
        'Txt2
        '
        Me.Txt2.Location = New System.Drawing.Point(89, 29)
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(156, 20)
        Me.Txt2.TabIndex = 9
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView.Location = New System.Drawing.Point(3, 85)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView.Size = New System.Drawing.Size(1144, 495)
        Me.DataGridView.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(251, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Veld3"
        '
        'Txt3
        '
        Me.Txt3.Location = New System.Drawing.Point(314, 3)
        Me.Txt3.Name = "Txt3"
        Me.Txt3.Size = New System.Drawing.Size(156, 20)
        Me.Txt3.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(251, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Veld4"
        '
        'Txt4
        '
        Me.Txt4.Location = New System.Drawing.Point(314, 29)
        Me.Txt4.Name = "Txt4"
        Me.Txt4.Size = New System.Drawing.Size(156, 20)
        Me.Txt4.TabIndex = 18
        '
        'UCStamgegevens
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txt4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txt3)
        Me.Controls.Add(Me.KnopNieuw)
        Me.Controls.Add(Me.KnopLeegmaken)
        Me.Controls.Add(Me.KnopZoek)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt2)
        Me.Controls.Add(Me.DataGridView)
        Me.Name = "UCStamgegevens"
        Me.Size = New System.Drawing.Size(1150, 583)
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KnopNieuw As Button
    Friend WithEvents KnopLeegmaken As Button
    Friend WithEvents KnopZoek As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt2 As TextBox
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt4 As TextBox
End Class
