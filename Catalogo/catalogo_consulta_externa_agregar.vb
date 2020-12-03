Public Class catalogo_consulta_externa_agregar

    Private Sub ProductosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub catalogo_consulta_externa_agregar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ClinicaDataSet.Productos)

    End Sub

    Private Sub btn_salir_Click(sender As System.Object, e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_ok_Click(sender As System.Object, e As System.EventArgs) Handles btn_ok.Click
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.ProductosTableAdapter.Update(Me.ClinicaDataSet.Productos)
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            Dim f As String = "descripcion like '%" + TextBox1.Text + "%'"
            ProductosBindingSource.Filter = f
        Catch ex As Exception

        End Try
    End Sub
End Class