Public Class entrada_nueva
    Public idRelacion As Integer = 0
    Private Sub entradas_nueva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      
        Me.Cap_lotesTableAdapter.Inicializa()
        Me.Cap_lotesTableAdapter.Fill(Me.ClinicaDataSet.cap_lotes)
        Me.ProductosTableAdapter.Fill(Me.ClinicaDataSet.Productos)
        Me.ProveedoresTableAdapter.Fill(Me.ClinicaDataSet.proveedores)
        Dim adap As New clinicaDataSetTableAdapters.inv_documentosTableAdapter
        Try
            txtfolio.Text = adap.sig_folio(1) ' siguiente entrada
        Catch ex As Exception
            txtfolio.Text = "1"
        End Try

        'inicializa entrada
        Dim cmd As String
        cmd = "delete * from inv_lotes where tipo_entrada =1 and folio = " + txtfolio.Text
        commando(cmd)
        cmd = "delete * from inv_movimientos where tipo =1 and folio = " + txtfolio.Text
        commando(cmd)

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtid.TextLength = 0 Then MsgBox("Seleccione Un producto") : Exit Sub

        Cap_lotesTableAdapter.Insert(txtid.Text, txtdescripcion.Text, txtcantidad.Text, txtcosto.Text, Me.caduca.Value, txtlote.Text)

        Me.Cap_lotesTableAdapter.Fill(Me.ClinicaDataSet.cap_lotes)
        Me.txtid.Text = ""
        Me.txtdescripcion.Text = ""
        Me.txtcantidad.Text = ""
        Me.txtcosto.Text = ""
        Me.txtlote.Text = ""

        totaliza()
    End Sub ' Agregar producto

    Private Sub totaliza()
        Dim total As Single
        For j As Integer = 0 To Cap_lotesDataGridView.Rows.Count - 1
            With Cap_lotesDataGridView.Rows(j)
                Dim cant As Integer, costo As Single, im As Single
                cant = .Cells("dgvcantidad").Value
                costo = .Cells("dgvcosto").Value
                im = cant * costo
                total += im
            End With
        Next
        txttotal.Text = Format(total, "N2")
    End Sub

    Private Sub ProductosDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductosDataGridView.CellClick
        txtid.Text = Me.ProductosDataGridView.CurrentRow.Cells(0).Value
        txtdescripcion.Text = Me.ProductosDataGridView.CurrentRow.Cells(1).Value
        Try
            txtcosto.Text = Me.ProductosDataGridView.CurrentRow.Cells("pcosto").Value

        Catch ex As Exception

        End Try
        txtcantidad.Focus()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim f As String
        f = "Descripcion like '%" + Me.TextBox1.Text + "%'"
        Me.ProductosBindingSource.Filter = f
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim folio As Integer = txtfolio.Text

        ' valida informacion
        If TXTIDPROV.TextLength < 1 Then MsgBox("Definir Proveedor") : Exit Sub
        If TXTFACTURA.TextLength < 1 Then MsgBox("Definir factura") : Exit Sub

        'guarda documento
        Dim doc_adp As New clinicaDataSetTableAdapters.inv_documentosTableAdapter
        doc_adp.Insert(folio, 1, 0, fecha_entrada.Value.ToShortDateString, user_id, TXTIDPROV.Text, TXTFACTURA.Text, fecha_factura.Value.ToShortDateString, "", Fecha_vencimiento.Value, ContrareciboCheckBox.CheckState, user_id, Fecha_pago.Value)

        'guarda lote
        Dim lote_adp As New clinicaDataSetTableAdapters.inv_lotesTableAdapter
        Dim mov_adp As New clinicaDataSetTableAdapters.inv_movimientosTableAdapter
        Dim prod_adap As New recetas_datasetTableAdapters.ProductosTableAdapter
        Dim tbl As New DataTable
        tbl = Cap_lotesTableAdapter.GetData
        For j As Integer = 0 To tbl.Rows.Count - 1
            With tbl.Rows(j)
                Dim id As Integer = .Item("id")
                Dim cantidad As Integer = .Item("cantidad")
                Dim costo As Single = .Item("costo")
                Dim caduca As Date = .Item("caducidad")
                Dim lote As String = .Item("lote")
                Dim descripcion As String = .Item("descripcion")
                If cantidad > 0 Then
                    lote_adp.Insert(id, fecha_entrada.Value.ToShortDateString, caduca, 1, cantidad, "", 0, 0, folio, costo, False, lote, False)
                    mov_adp.Insert(folio, id, 0, id, 0, 1, fecha_entrada.Value.ToShortDateString, cantidad, 0, Mid(descripcion, 35))

                    If Actualizar_costo.CheckState = CheckState.Unchecked Then
                        prod_adap.actualiza_costo(costo, id) ' Actualiza Costo del producto
                        lblstatus.Text = "Se actualizo costo del producto en catalogo"
                    End If
                End If
            End With
        Next
        doc_adp.Dispose()
        lote_adp.Dispose()
        mov_adp.Dispose()

        ' actuliaza relacion de entradas
        If idRelacion > 0 Then
            Dim adapr As New clinicaDataSetTableAdapters.inv_recepcion_mercanciaTableAdapter
            adapr.Actualiza_entrada(txtfolio.Text, idRelacion)
            lblstatus.Text = "Se actualizo relacion de Entradas ok."
        End If



        Me.Close()
        MsgBox("Guardado ")
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim miforma As New Imprimir_documento
        miforma.imprimir(folio)
        '  miforma.ShowDialog()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub ' guardar entrada

    Private Sub NombreComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreComboBox.SelectedIndexChanged
        Me.TXTIDPROV.Text = NombreComboBox.SelectedValue
    End Sub 'selecciona proveedor

    Private Sub Cap_lotesDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Cap_lotesDataGridView.CellClick
        Me.btn_borrar_partido.Enabled = True
    End Sub

    Private Sub btn_borrar_partido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_borrar_partido.Click
        Dim ix As MsgBoxResult
        ix = MsgBox("Quiere borrar esta partida de la entrada (S/N)?", MsgBoxStyle.YesNo, "Borrar Partida")
        If ix = MsgBoxResult.Yes Then
            Dim id As Integer = Me.Cap_lotesDataGridView.CurrentRow.Cells("dgvnum").Value
            Me.Cap_lotesTableAdapter.borrar(id)
            Me.Cap_lotesTableAdapter.Fill(Me.ClinicaDataSet.cap_lotes)
            totaliza()
        End If
    End Sub

End Class