Public Class productos_nuevo

    Private Sub ProductosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.ProductosTableAdapter.Update(Me.ClinicaDataSet.Productos)

    End Sub

    Private Sub productos_nuevo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.ClinicaDataSet.proveedores)
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.categorias' Puede moverla o quitarla según sea necesario.
        Me.CategoriasTableAdapter.Fill(Me.ClinicaDataSet.categorias)
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ClinicaDataSet.Productos)
       
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.ProductosTableAdapter.Update(Me.ClinicaDataSet.Productos)
        Me.Close()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.ProductosBindingSource.CancelEdit()
        Me.ProductosBindingNavigator.Enabled = True
        Panel1.Visible = False
        Me.Close()
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.ProductosTableAdapter.Update(Me.ClinicaDataSet.Productos)
        MsgBox("Guardado")
        Me.ProductosBindingNavigator.Enabled = True
        Panel1.Visible = False
        Me.Close()
    End Sub


    Private Sub Id_productoLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim adap As New clinicaDataSetTableAdapters.ProductosTableAdapter
        Me.Id_productoTextBox.Text = adap.siguiente.Value.ToString
    End Sub

    Private Sub idc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles idc.TextChanged
        Me.Id_categoriaTextBox.Text = idc.Text
    End Sub

    Private Sub IdTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdTextBox.TextChanged
        Me.Id_provTextBox.Text = IdTextBox.Text
    End Sub

   
   

    Private Sub Id_categoriaTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Id_categoriaTextBox.TextChanged
        Try
            Dim adap As New clinicaDataSetTableAdapters.ProductosTableAdapter
            Me.Id_productoTextBox.Text = adap.siguiente.Value.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Panel1.Visible = True
        Me.ProductosBindingNavigator.Enabled = False
    End Sub
End Class