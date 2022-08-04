<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormColores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnRojo = New System.Windows.Forms.Button()
        Me.btnblue = New System.Windows.Forms.Button()
        Me.btnyellow = New System.Windows.Forms.Button()
        Me.green = New System.Windows.Forms.Button()
        Me.btnpink = New System.Windows.Forms.Button()
        Me.txtColores = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnRojo
        '
        Me.btnRojo.AccessibleName = "Rojo"
        Me.btnRojo.ForeColor = System.Drawing.Color.Black
        Me.btnRojo.Location = New System.Drawing.Point(36, 33)
        Me.btnRojo.Name = "btnRojo"
        Me.btnRojo.Size = New System.Drawing.Size(84, 33)
        Me.btnRojo.TabIndex = 0
        Me.btnRojo.Text = "Rojo"
        Me.btnRojo.UseVisualStyleBackColor = True
        '
        'btnblue
        '
        Me.btnblue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnblue.Location = New System.Drawing.Point(36, 110)
        Me.btnblue.Name = "btnblue"
        Me.btnblue.Size = New System.Drawing.Size(84, 30)
        Me.btnblue.TabIndex = 1
        Me.btnblue.Text = "Azul"
        Me.btnblue.UseVisualStyleBackColor = True
        '
        'btnyellow
        '
        Me.btnyellow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnyellow.Location = New System.Drawing.Point(36, 194)
        Me.btnyellow.Name = "btnyellow"
        Me.btnyellow.Size = New System.Drawing.Size(84, 30)
        Me.btnyellow.TabIndex = 2
        Me.btnyellow.Text = "Amarrillo"
        Me.btnyellow.UseVisualStyleBackColor = True
        '
        'green
        '
        Me.green.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.green.Location = New System.Drawing.Point(36, 262)
        Me.green.Name = "green"
        Me.green.Size = New System.Drawing.Size(99, 33)
        Me.green.TabIndex = 3
        Me.green.Text = "Verde"
        Me.green.UseVisualStyleBackColor = True
        '
        'btnpink
        '
        Me.btnpink.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnpink.Location = New System.Drawing.Point(36, 343)
        Me.btnpink.Name = "btnpink"
        Me.btnpink.Size = New System.Drawing.Size(84, 31)
        Me.btnpink.TabIndex = 4
        Me.btnpink.Text = "Rosado"
        Me.btnpink.UseVisualStyleBackColor = True
        '
        'txtColores
        '
        Me.txtColores.Location = New System.Drawing.Point(194, 33)
        Me.txtColores.Multiline = True
        Me.txtColores.Name = "txtColores"
        Me.txtColores.Size = New System.Drawing.Size(516, 369)
        Me.txtColores.TabIndex = 5
        '
        'FormColores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtColores)
        Me.Controls.Add(Me.btnpink)
        Me.Controls.Add(Me.green)
        Me.Controls.Add(Me.btnyellow)
        Me.Controls.Add(Me.btnblue)
        Me.Controls.Add(Me.btnRojo)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Name = "FormColores"
        Me.Text = "Colores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRojo As Button
    Friend WithEvents btnblue As Button
    Friend WithEvents btnyellow As Button
    Friend WithEvents green As Button
    Friend WithEvents btnpink As Button
    Friend WithEvents txtColores As TextBox
End Class
