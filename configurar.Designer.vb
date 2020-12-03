<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class configurar
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
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.baserealcs = New System.Windows.Forms.TextBox
        Me.baselocalcs = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.boton_ok = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Almacen.My.MySettings.Default, "baseoriginal", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox3.Location = New System.Drawing.Point(179, 71)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(438, 20)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = Global.Almacen.My.MySettings.Default.baseoriginal
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cadena de conexion Base Local :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cadena de conexion Base Red :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Base de datos Original :"
        '
        'baserealcs
        '
        Me.baserealcs.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Almacen.My.MySettings.Default, "baserealcs", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.baserealcs.Location = New System.Drawing.Point(179, 45)
        Me.baserealcs.Name = "baserealcs"
        Me.baserealcs.Size = New System.Drawing.Size(438, 20)
        Me.baserealcs.TabIndex = 1
        Me.baserealcs.Text = Global.Almacen.My.MySettings.Default.baserealcs
        '
        'baselocalcs
        '
        Me.baselocalcs.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Almacen.My.MySettings.Default, "baselocalcs", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.baselocalcs.Location = New System.Drawing.Point(179, 19)
        Me.baselocalcs.Name = "baselocalcs"
        Me.baselocalcs.Size = New System.Drawing.Size(438, 20)
        Me.baselocalcs.TabIndex = 0
        Me.baselocalcs.Text = Global.Almacen.My.MySettings.Default.baselocalcs
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(461, 108)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'boton_ok
        '
        Me.boton_ok.Location = New System.Drawing.Point(542, 108)
        Me.boton_ok.Name = "boton_ok"
        Me.boton_ok.Size = New System.Drawing.Size(75, 23)
        Me.boton_ok.TabIndex = 7
        Me.boton_ok.Text = "Guardar"
        Me.boton_ok.UseVisualStyleBackColor = True
        '
        'configurar
        '
        Me.AcceptButton = Me.boton_ok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(643, 152)
        Me.Controls.Add(Me.boton_ok)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.baserealcs)
        Me.Controls.Add(Me.baselocalcs)
        Me.Name = "configurar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents baselocalcs As System.Windows.Forms.TextBox
    Friend WithEvents baserealcs As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents boton_ok As System.Windows.Forms.Button
End Class
