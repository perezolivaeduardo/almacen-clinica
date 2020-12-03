Public Class productos

    Private Sub ProductosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.ProductosTableAdapter.Update(Me.ClinicaDataSet.Productos)
        MsgBox("Guardado")

    End Sub

    Private Sub productos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.ClinicaDataSet.proveedores)
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.categorias' Puede moverla o quitarla según sea necesario.
        Me.CategoriasTableAdapter.Fill(Me.ClinicaDataSet.categorias)
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ClinicaDataSet.Productos)

    End Sub

    Private Sub Id_productoLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Id_productoLabel.Click
        If Me.Id_productoTextBox.TextLength = 0 Then
            Dim adap As New clinicaDataSetTableAdapters.ProductosTableAdapter
            Me.Id_productoTextBox.Text = adap.siguiente.Value.ToString
        End If

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.Id_productoLabel.Enabled = True
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()

    End Sub
End Class