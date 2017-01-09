<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NWStamgegevens
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
        Me.KnopOpslaan = New System.Windows.Forms.Button()
        Me.KnopSluiten = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt1 = New System.Windows.Forms.TextBox()
        Me.Txt2 = New System.Windows.Forms.TextBox()
        Me.Txt3 = New System.Windows.Forms.TextBox()
        Me.Txt4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'KnopOpslaan
        '
        Me.KnopOpslaan.Location = New System.Drawing.Point(13, 130)
        Me.KnopOpslaan.Name = "KnopOpslaan"
        Me.KnopOpslaan.Size = New System.Drawing.Size(75, 23)
        Me.KnopOpslaan.TabIndex = 0
        Me.KnopOpslaan.Text = "Opslaan"
        Me.KnopOpslaan.UseVisualStyleBackColor = True
        '
        'KnopSluiten
        '
        Me.KnopSluiten.Location = New System.Drawing.Point(284, 129)
        Me.KnopSluiten.Name = "KnopSluiten"
        Me.KnopSluiten.Size = New System.Drawing.Size(75, 23)
        Me.KnopSluiten.TabIndex = 1
        Me.KnopSluiten.Text = "Sluiten"
        Me.KnopSluiten.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Label3"
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(164, 12)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(195, 20)
        Me.Txt1.TabIndex = 5
        '
        'Txt2
        '
        Me.Txt2.Location = New System.Drawing.Point(164, 39)
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(195, 20)
        Me.Txt2.TabIndex = 6
        '
        'Txt3
        '
        Me.Txt3.Location = New System.Drawing.Point(164, 66)
        Me.Txt3.Name = "Txt3"
        Me.Txt3.Size = New System.Drawing.Size(195, 20)
        Me.Txt3.TabIndex = 7
        '
        'Txt4
        '
        Me.Txt4.Location = New System.Drawing.Point(164, 92)
        Me.Txt4.Name = "Txt4"
        Me.Txt4.Size = New System.Drawing.Size(195, 20)
        Me.Txt4.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Label4"
        '
        'NWStamgegevens
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 165)
        Me.Controls.Add(Me.Txt4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txt3)
        Me.Controls.Add(Me.Txt2)
        Me.Controls.Add(Me.Txt1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.KnopSluiten)
        Me.Controls.Add(Me.KnopOpslaan)
        Me.Name = "NWStamgegevens"
        Me.Text = "NWStamgegevens"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KnopOpslaan As Button
    Friend WithEvents KnopSluiten As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt1 As TextBox
    Friend WithEvents Txt2 As TextBox
    Friend WithEvents Txt3 As TextBox
    Friend WithEvents Txt4 As TextBox
    Friend WithEvents Label4 As Label
End Class
