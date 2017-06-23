<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class choisir_entre_les_trois_interfaces
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(choisir_entre_les_trois_interfaces))
        Me.btnformeB = New System.Windows.Forms.Button()
        Me.btnformeL = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnO = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnformeB
        '
        Me.btnformeB.BackgroundImage = CType(resources.GetObject("btnformeB.BackgroundImage"), System.Drawing.Image)
        Me.btnformeB.Font = New System.Drawing.Font("Monotype Corsiva", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnformeB.Location = New System.Drawing.Point(36, 139)
        Me.btnformeB.Name = "btnformeB"
        Me.btnformeB.Size = New System.Drawing.Size(234, 43)
        Me.btnformeB.TabIndex = 1
        Me.btnformeB.Text = "Forme Bouton"
        Me.btnformeB.UseVisualStyleBackColor = True
        '
        'btnformeL
        '
        Me.btnformeL.BackgroundImage = CType(resources.GetObject("btnformeL.BackgroundImage"), System.Drawing.Image)
        Me.btnformeL.Font = New System.Drawing.Font("Monotype Corsiva", 14.0!, System.Drawing.FontStyle.Italic)
        Me.btnformeL.Location = New System.Drawing.Point(36, 211)
        Me.btnformeL.Name = "btnformeL"
        Me.btnformeL.Size = New System.Drawing.Size(234, 38)
        Me.btnformeL.TabIndex = 2
        Me.btnformeL.Text = "Forme Label"
        Me.btnformeL.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 22.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 68)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " Bonjour !" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnO
        '
        Me.btnO.BackgroundImage = CType(resources.GetObject("btnO.BackgroundImage"), System.Drawing.Image)
        Me.btnO.Font = New System.Drawing.Font("Monotype Corsiva", 14.0!, System.Drawing.FontStyle.Italic)
        Me.btnO.Location = New System.Drawing.Point(36, 284)
        Me.btnO.Name = "btnO"
        Me.btnO.Size = New System.Drawing.Size(234, 38)
        Me.btnO.TabIndex = 3
        Me.btnO.Text = "Contre l'ordinateur"
        Me.btnO.UseVisualStyleBackColor = True
        '
        'choisir_entre_les_trois_interfaces
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(314, 422)
        Me.Controls.Add(Me.btnO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnformeL)
        Me.Controls.Add(Me.btnformeB)
        Me.Name = "choisir_entre_les_trois_interfaces"
        Me.Text = "Bienvenue !"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnformeB As System.Windows.Forms.Button
    Friend WithEvents btnformeL As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnO As Button
End Class
