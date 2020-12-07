Public Class seleccionar_producto
    Public id, cantidad As Integer, unitario, piva As Single, descripcion, presentacion, empaque As String, norden As Integer = 0
  

    Private Sub seleccionar_producto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'OrdenesDS.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.OrdenesDS.Productos)


    End Sub

   
    Private Sub txtfiltro_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtfiltro.TextChanged
        Dim f As String = "descripcion like '%" + txtfiltro.Text + "%'"
        Try
            ProductosBindingSource.Filter = f
        Catch ex As Exception
            ProductosBindingSource.Filter = ""
        End Try

    End Sub

    

    Private Sub btn_cerrar_Click(sender As System.Object, e As System.EventArgs) Handles btn_cerrar.Click
        cantidad = 0
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        txtfiltro.Text = ""
    End Sub

    Private Sub ProductosDataGridView_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductosDataGridView.CellDoubleClick
        id = ProductosDataGridView.CurrentRow.Cells("dgvid").Value

        Try
            unitario = ProductosDataGridView.CurrentRow.Cells("dgvcosto").Value
        Catch ex As Exception
            unitario = 0
            MsgBox("Verifique Costo")
        End Try

        descripcion = ProductosDataGridView.CurrentRow.Cells("dgvdescripcion").Value
        Try
            empaque = ProductosDataGridView.CurrentRow.Cells("dgvempaque").Value
        Catch ex As Exception
            empaque = 0
        End Try
        Try
            presentacion = ProductosDataGridView.CurrentRow.Cells("dgvprecentacion").Value
        Catch ex As Exception
            presentacion = 0
        End Try
        
        piva = ProductosDataGridView.CurrentRow.Cells("dgviva").Value
        Try
            cantidad = InputBox("Teclee la cantidad", descripcion, "0")
        Catch ex As Exception
            cantidad = 0
        End Try
        If cantidad = 0 Then Exit Sub

        Dim importe As String
        importe = cantidad * unitario
        If cantidad > 0 And unitario > 0 Then
            'agregar renglon a la orden de compra
            Dim adap As New OrdenesDSTableAdapters.Ocompra_detalleTableAdapter
            adap.Insert(norden, id, descripcion, presentacion, empaque, cantidad, unitario, importe, piva)
            ProductosBindingSource.RemoveCurrent()
            Beep()
        End If



    End Sub

    Private Sub Btn_agregar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_agregar.Click
        If txtcantidad.TextLength = 0 Then MsgBox("Teclee cantidad ") : Exit Sub
        id = ProductosDataGridView.CurrentRow.Cells("dgvid").Value
        Try
            unitario = ProductosDataGridView.CurrentRow.Cells("dgvcosto").Value
        Catch ex As Exception
            unitario = 0
            MsgBox("Verifique Costo")
        End Try

        descripcion = ProductosDataGridView.CurrentRow.Cells("dgvdescripcion").Value
        Try
            empaque = ProductosDataGridView.CurrentRow.Cells("dgvempaque").Value
        Catch ex As Exception
            empaque = 0
        End Try
        Try
            presentacion = ProductosDataGridView.CurrentRow.Cells("dgvprecentacion").Value
        Catch ex As Exception
            presentacion = 0
        End Try
        descripcion = ProductosDataGridView.CurrentRow.Cells("dgvdescripcion").Value
        piva = ProductosDataGridView.CurrentRow.Cells("dgviva").Value
        cantidad = txtcantidad.Text

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
        MsgBox(norden)
    End Sub
End Class