Public Class Entrasdas_consulta

    Private Sub Inv_documentosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Entrasdas_consulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ClinicaDataSet.Productos)
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.ClinicaDataSet.proveedores)
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.inv_lotes' Puede moverla o quitarla según sea necesario.
        Me.Inv_lotesTableAdapter.Fill(Me.ClinicaDataSet.inv_lotes)
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.inv_documentos' Puede moverla o quitarla según sea necesario.
        Me.Inv_documentosTableAdapter.FillBytipo(Me.ClinicaDataSet.inv_documentos, 1) 'carga solo entradas

    End Sub

    Private Sub SplitContainer2_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer2.Panel1.Paint

    End Sub

    Private Sub dgv_doc_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_doc.CellClick
        Dim folio As Integer = Me.dgv_doc.CurrentRow.Cells("dgvfolio").Value
        Me.Inv_lotesBindingSource.Filter = "folio = " + folio.ToString
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Validate()
        Me.Inv_lotesBindingSource.EndEdit()
        Me.Inv_lotesTableAdapter.Update(Me.ClinicaDataSet.inv_lotes)

        Me.Inv_documentosBindingSource.EndEdit()
        Me.Inv_documentosTableAdapter.Update(Me.ClinicaDataSet.inv_documentos)

    End Sub

    Private Sub combopv_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combopv.SelectedIndexChanged
        Dim pv As Integer = Me.combopv.SelectedValue
        Me.Inv_documentosBindingSource.Filter = "id_proveedor =" + pv.ToString
    End Sub

    Private Sub dgv_doc_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv_doc.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgv_lote_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv_lote.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim folio As Integer = Me.dgv_doc.CurrentRow.Cells("dgvfolio").Value
        Dim miforma As New Imprimir_documento
        If imprimir.Checked = False Then
            miforma.cargar(folio)
            miforma.ShowDialog()
        Else
            miforma.imprimir(folio)
        End If


        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Inv_documentosBindingSource.Filter = ""
    End Sub
End Class