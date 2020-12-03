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

        Me.Id_productoLabel.Enabled = True
        Dim adap As New clinicaDataSetTableAdapters.ProductosTableAdapter

        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ClinicaDataSet.Productos)

        Me.ProductosBindingSource.AddNew()

        'Me.Id_productoTextBox.Text = adap.siguiente.Value.ToString
    End Sub

   
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.ProductosBindingSource.CancelEdit()
        Me.Close()
        Me.Dispose()

    End Sub
End Class