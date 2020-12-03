Public Class recetas
    Dim tbl_lotes As DataTable
    Dim tbl_recetas As DataTable
    Dim ver As Integer = 0
    Dim puede_borrar As Boolean = False
    Dim flag_doc As Boolean = False


    Private Sub recetas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.inv_sql_lotes' Puede moverla o quitarla según sea necesario.
        Me.Inv_sql_lotesTableAdapter.Fill(Me.ClinicaDataSet.inv_sql_lotes)

        Me.MedicosTableAdapter.FillByrecetan(Me.ClinicaDataSet.medicos)
        Me.RecetasTableAdapter.Fillbyperiodo(Me.ClinicaDataSet.recetas)

        Me.ProductosTableAdapter.FillByantibioticos(Me.ClinicaDataSet.Productos)

        tbl_lotes = ClinicaDataSet.inv_sql_lotes
        tbl_recetas = ClinicaDataSet.recetas
        calcular()

    End Sub

    Private Sub ProductosDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvp.CellClick
        calcular()
    End Sub

    Private Sub calcular()
        Dim ix As Integer, f As Integer
        ix = dgvp.CurrentRow.Cells(0).Value
        Dim cmd As String = "SELECT Sum(stocks.maximo) AS cant FROM stocks GROUP BY stocks.id_producto HAVING stocks.id_producto=[id]"
        cmd = cmd.Replace("[id]", ix.ToString)
        Try
            txtstock.Text = leer_tabla(cmd).Rows(0).Item(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Me.RecetasBindingSource.Filter = "id_producto = '" + ix.ToString + "' and id_lote=0"

        If ver = 0 Then
            Me.InvsqllotesBindingSource.Filter = "id_producto  = '" + ix.ToString + "' and libro=0"
        Else
            Me.InvsqllotesBindingSource.Filter = "id_producto  = '" + ix.ToString + "'"
        End If


        Try
            lc.Text = tbl_lotes.Compute("sum(cantidad)", "id_producto = '" + ix.ToString + "' and libro=0") ' cant lotes sists
        Catch ex As Exception
            lc.Text = ""
        End Try
        Try
            ls.Text = tbl_lotes.Compute("count(id_producto)", "id_producto = '" + ix.ToString + "' and libro=0")
        Catch ex As Exception
            ls.Text = ""
        End Try

        Try
            tr.Text = tbl_recetas.Compute("count(id)", "id_producto = '" + ix.ToString + "'")
            trc.Text = tbl_recetas.Compute("sum(cantidad)", "id_producto = '" + ix.ToString + "'")
        Catch ex As Exception
            tr.Text = ""
            trc.Text = ""
        End Try

        Try
            Dim te As Integer = lc.Text - trc.Text
            txtexistencia.Text = te
        Catch ex As Exception
            txtexistencia.Text = ""
        End Try

    End Sub

    Private Sub doc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles doc.SelectedIndexChanged
        Try
            Dim f As String
            f = "id_medico ='" + doc.SelectedValue.ToString + "'"
            Me.RecetasBindingSource.Filter = f
        Catch ex As Exception

        End Try


    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub EditarRecetasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarRecetasToolStripMenuItem.Click
        puede_borrar = True
    End Sub

    Private Sub RecetasDataGridView_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecetasDataGridView.DoubleClick
       
    End Sub

    Private Sub AsignarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignarToolStripMenuItem.Click
        My.Forms.recetas_Asignar.ShowDialog()
    End Sub

    Private Sub AsignarFacturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignarFacturaToolStripMenuItem.Click
        Dim id As Integer, r As String
        id = Me.dgvlotes.CurrentRow.Cells("id_doc").Value
        r = Me.dgvlotes.CurrentRow.Cells("lote").Value
        My.Forms.recetas_poner_factura.CARGAR(id)
        My.Forms.recetas_poner_factura.txtlote.Text = r
        My.Forms.recetas_poner_factura.ShowDialog()
        Me.Inv_sql_lotesTableAdapter.Fill(Me.ClinicaDataSet.inv_sql_lotes)
    End Sub

    Private Sub CambiarDeMedicoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarDeMedicoToolStripMenuItem.Click
        Dim id As Integer = Me.RecetasDataGridView.CurrentRow.Cells(0).Value
        My.Forms.recetas_modificar.cargar(id)
        My.Forms.recetas_modificar.ShowDialog()
        Me.RecetasTableAdapter.Fillbyperiodo(Me.ClinicaDataSet.recetas)
    End Sub

    Private Sub AsignarLoteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignarLoteToolStripMenuItem.Click
        Dim id_receta As Integer = Me.RecetasDataGridView.CurrentRow.Cells(0).Value
        Dim id_lote = Me.dgvlotes.CurrentRow.Cells("id_lote").Value
        Dim lote = Me.dgvlotes.CurrentRow.Cells("lote").Value
        Dim adap As New recetas_datasetTableAdapters.recetasTableAdapter
        adap.Actualiza_lote(id_lote, lote, id_receta)
        adap.Dispose()
        'si no existe documento lo crea
        If flag_doc = False Then crear_documento()

        Dim adap1 As New clinicaDataSetTableAdapters.inv_movimientosTableAdapter
        Dim id_producto As Integer = dgvlotes.CurrentRow.Cells(0).Value
        Dim cant As Integer = RecetasDataGridView.CurrentRow.Cells("dgvrecetacantidad").Value
        Dim descrip As String = dgvp.CurrentRow.Cells(1).Value
        adap1.Insert(lblfolio.Text, id_producto, 6, id_lote, user_id, 2, Now.Date, cant, 0, descrip)

        Try
            Me.Sql_inv_movimientosTableAdapter.Fillbyfolio(Me.ClinicaDataSet.sql_inv_movimientos, 2, lblfolio.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Me.RecetasTableAdapter.Fillbyperiodo(Me.ClinicaDataSet.recetas)
    End Sub 'asignar lote a la receta

    Private Sub dgvlotes_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvlotes.CellDoubleClick
        Dim lote As String = ""
        Try
            lote = dgvlotes.CurrentRow.Cells("id_lote").Value
            Me.RecetasBindingSource.Filter = "id_lote ='" + lote + "'"
        Catch ex As Exception

        End Try
        Dim cant_lote As Integer = dgvlotes.CurrentRow.Cells("dgvlotecantidad").Value
        Dim asignados, ct As Integer
        For j As Integer = 0 To Me.RecetasDataGridView.Rows.Count - 1
            ct = Me.RecetasDataGridView.Rows(j).Cells("dgvrecetacantidad").Value
            asignados += ct
        Next j
        MsgBox("Total de productos recetados de este lote " + asignados.ToString)
        If asignados = cant_lote Then
            Dim adap As New recetas_datasetTableAdapters.inv_lotesTableAdapter
            adap.cerrar(True, lote)
        End If
    End Sub 'filtra las recetas segun el lote seleccionado

    Private Sub dgvlotes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvlotes.CellContentClick

    End Sub

    Private Sub ModificarFechasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarFechasToolStripMenuItem.Click
        Dim id_lote = Me.dgvlotes.CurrentRow.Cells("id_lote").Value
        My.Forms.lotes_modificar_fechas.cargar(id_lote)
        My.Forms.lotes_modificar_fechas.ShowDialog()
        Me.Inv_sql_lotesTableAdapter.Fill(Me.ClinicaDataSet.inv_sql_lotes)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim ix As Integer, f As Integer
        ix = dgvp.CurrentRow.Cells(0).Value
        Me.RecetasBindingSource.Filter = "id_producto = '" + ix.ToString + "'"

    End Sub

    Private Sub CambiarCantidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarCantidadToolStripMenuItem.Click
        Dim id As Integer, cantidad As Integer
        id = RecetasDataGridView.CurrentRow.Cells("dgvrid").Value
        cantidad = InputBox("Teclee la nueva cantidad", "Cambiar cantidad", "")
        If cantidad = 0 Then Exit Sub
        Dim adap As New recetas_datasetTableAdapters.recetasTableAdapter()
        adap.Update_cantidad(cantidad, id)
        adap.Dispose()
        Me.RecetasTableAdapter.Fillbyperiodo(Me.ClinicaDataSet.recetas)
    End Sub

    Private Sub btn_borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_borrar.Click
        Dim ix As MsgBoxResult
        Dim msg As String = "Aquiere Eliminar la receta  " + Me.RecetasDataGridView.CurrentRow.Cells(0).Value.ToString
        ix = MsgBox(msg, MsgBoxStyle.DefaultButton2 + MsgBoxStyle.YesNo, "Eliminar Receta")
        If ix <> MsgBoxResult.Yes Then Exit Sub
        Dim id As Integer = Me.RecetasDataGridView.CurrentRow.Cells(0).Value
        Dim adap As New clinicaDataSetTableAdapters.recetasTableAdapter
        adap.borrar_receta(id)
        Me.RecetasBindingSource.RemoveCurrent()
        calcular()
        MsgBox("Receta eliminada")
    End Sub

   
    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        ficha.Visible = True
        barra.Enabled = False
        AsignarLoteToolStripMenuItem.Enabled = True

        ' define siguiente folio
        Dim adap As New clinicaDataSetTableAdapters.inv_documentosTableAdapter
        Try
            lblfolio.Text = adap.sig_folio(2) ' siguiente entrada 7 tipos salida de consultorio
        Catch ex As Exception
            lblfolio.Text = "1"
        End Try
        flag_doc = False


    End Sub

    Private Sub btn_salir_Click(sender As System.Object, e As System.EventArgs) Handles btn_salir.Click

        If flag_doc = True Then
            Dim frmimprime As New hojadeentrega
            frmimprime.cargar(lblfolio.Text, Now.Date.ToString)
            frmimprime.ShowDialog()
        End If


        barra.Enabled = True
        AsignarLoteToolStripMenuItem.Enabled = False
        ficha.Visible = False

    End Sub

    Private Sub crear_documento()

        'Gnera el documnto y prende bandera 
        Dim adap As New clinicaDataSetTableAdapters.inv_documentosTableAdapter
        adap.Insert(lblfolio.Text, 2, 6, Now, user_id, 0, "", Now, "Antibioticos", Now, False, 0, Now)
        flag_doc = True
        btn_salir.Text = "Terminar"


    End Sub

    Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click
        Dim frm As New surtido_antibioticos
        frm.Show()
    End Sub

    Private Sub FillbyfolioToolStripButton_Click(sender As System.Object, e As System.EventArgs)
       

    End Sub
End Class
