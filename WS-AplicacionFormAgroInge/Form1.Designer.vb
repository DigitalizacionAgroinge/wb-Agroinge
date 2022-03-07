<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnMetodoPOST = New System.Windows.Forms.Button()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.btnMetodoGET = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMetodoPOST
        '
        Me.btnMetodoPOST.Location = New System.Drawing.Point(182, 80)
        Me.btnMetodoPOST.Name = "btnMetodoPOST"
        Me.btnMetodoPOST.Size = New System.Drawing.Size(110, 40)
        Me.btnMetodoPOST.TabIndex = 5
        Me.btnMetodoPOST.Text = "Método POST"
        Me.btnMetodoPOST.UseVisualStyleBackColor = True
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(54, 41)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(238, 20)
        Me.txtNumero.TabIndex = 4
        '
        'btnMetodoGET
        '
        Me.btnMetodoGET.Location = New System.Drawing.Point(54, 80)
        Me.btnMetodoGET.Name = "btnMetodoGET"
        Me.btnMetodoGET.Size = New System.Drawing.Size(110, 40)
        Me.btnMetodoGET.TabIndex = 3
        Me.btnMetodoGET.Text = "Método GET"
        Me.btnMetodoGET.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 170)
        Me.Controls.Add(Me.btnMetodoPOST)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.btnMetodoGET)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnMetodoPOST As Button
    Private WithEvents txtNumero As TextBox
    Private WithEvents btnMetodoGET As Button
End Class
