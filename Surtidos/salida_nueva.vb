Public Class salida_nueva
    Private Sub salida_nueva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       

        'Solo carga area de consultrio id=60
        Me.AreasTableAdapter.FillByconsultorio(Me.ClinicaDataSet.areas)
        Id_areaTextBox.Text = 60


        Me.ProductosTableAdapter.Fill(Me.ClinicaDataSet.Productos)

        Dim adap As New clinicaDataSetTableAdapters.inv_documentosTableAdapter
        Try
            txtfolio.Text = adap.sig_folio(7) ' siguiente entrada 7 tipos salida de consultorio
        Catch ex As Exception
            txtfolio.Text = "1"
        End Try

        'inicializa entrada
        Dim cmd As String
       
        cmd = "delete * from inv_movimientos where tipo =7 and folio = " + txtfolio.Text
        commando(cmd)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        agregar()
    End Sub

    Private Sub agregar()
        If txtid.TextLength = 0 Then MsgBox("Seleccione Un producto") : Exit Sub
        Inv_movimientosTableAdapter.Insert(txtfolio.Text, txtid.Text, Id_areaTextBox.Text, 0, user_id, 7, fecha_entrada.Value.ToShortDateString, txtcantidad.Text, 0, txtdescripcion.Text)
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.inv_movimientos' Puede moverla o quitarla según sea necesario.
        Me.Inv_movimientosTableAdapter.FillByfolio(Me.ClinicaDataSet.inv_movimientos, txtfolio.Text, 7)

        Me.txtid.Text = ""
        Me.txtdescripcion.Text = ""
        Me.txtcantidad.Text = ""
        Me.txtcosto.Text = ""
        Me.txtlote.Text = ""


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


        'guarda documento
        Dim doc_adp As New clinicaDataSetTableAdapters.inv_documentosTableAdapter
        doc_adp.Insert(folio, 7, Id_areaTextBox.Text, fecha_entrada.Value.ToShortDateString, user_id, 0, "", fecha_entrada.Value.ToShortDateString, ObservacionesTextBox.Text, fecha_entrada.Value, False, 0, fecha_entrada.Value)

        Me.Close()
        MsgBox("Guardado ")
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim miforma As New imprimir_salida
        miforma.cargar(folio, 7, "Salida de Almacen", Now.Date)
        '  miforma.ShowDialog()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub



    Private Sub Cap_lotesDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles inv_movimientosDataGridView.CellClick
        Me.btn_borrar_partido.Enabled = True
    End Sub


    Private Sub btn_borrar_partido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_borrar_partido.Click
        Dim ix As MsgBoxResult
        ix = MsgBox("Quiere borrar esta partida de la entrada (S/N)?", MsgBoxStyle.YesNo, "Borrar Partida")
        If ix = MsgBoxResult.Yes Then
            Dim id As Integer = Me.inv_movimientosDataGridView.CurrentRow.Cells("dgvnum").Value

        End If
    End Sub

    Private Sub FillByconsultorioToolStripButton_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.AreasTableAdapter.FillByconsultorio(Me.ClinicaDataSet.areas)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

   
    Private Sub txtcantidad_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtcantidad.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            agregar()
        End If
    End Sub
End Class