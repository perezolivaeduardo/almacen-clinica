Public Class Productos_modificar

    Private Sub ProductosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Productos_modificar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.FillByid(Me.ClinicaDataSet.Productos, global_producto)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.ProductosTableAdapter.Update(Me.ClinicaDataSet.Productos)
        Me.Close()

    End Sub
End Class