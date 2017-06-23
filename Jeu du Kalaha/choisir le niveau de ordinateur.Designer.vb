<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class choisir_le_niveau_de_ordinateur
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(choisir_le_niveau_de_ordinateur))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btndifficile = New System.Windows.Forms.Button()
        Me.btnfacile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 22.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 84)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 44)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Choisissez le niveau"
        '
        'btndifficile
        '
        Me.btndifficile.BackgroundImage = CType(resources.GetObject("btndifficile.BackgroundImage"), System.Drawing.Image)
        Me.btndifficile.Font = New System.Drawing.Font("Monotype Corsiva", 14.0!, System.Drawing.FontStyle.Italic)
        Me.btndifficile.Location = New System.Drawing.Point(37, 274)
        Me.btndifficile.Name = "btndifficile"
        Me.btndifficile.Size = New System.Drawing.Size(234, 38)
        Me.btndifficile.TabIndex = 6
        Me.btndifficile.Text = "Difficile"
        Me.btndifficile.UseVisualStyleBackColor = True
        '
        'btnfacile
        '
        Me.btnfacile.BackgroundImage = CType(resources.GetObject("btnfacile.BackgroundImage"), System.Drawing.Image)
        Me.btnfacile.Font = New System.Drawing.Font("Monotype Corsiva", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfacile.Location = New System.Drawing.Point(37, 165)
        Me.btnfacile.Name = "btnfacile"
        Me.btnfacile.Size = New System.Drawing.Size(234, 43)
        Me.btnfacile.TabIndex = 5
        Me.btnfacile.Text = "Facile"
        Me.btnfacile.UseVisualStyleBackColor = True
        '
        'choisir_le_niveau_de_ordinateur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(311, 419)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btndifficile)
        Me.Controls.Add(Me.btnfacile)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "choisir_le_niveau_de_ordinateur"
        Me.Text = "Bivenue !"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btndifficile As Button
    Friend WithEvents btnfacile As Button
End Class
