Public Class Catalogo_consulta_externa

  

    Private Sub Catalogo_consulta_externa_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
       
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.FillByconsultaexterna(Me.ClinicaDataSet.Productos)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        txtfiltro.Text = ""

    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.ProductosTableAdapter.Update(Me.ClinicaDataSet.Productos)
        Close()
    End Sub

    Private Sub txtfiltro_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtfiltro.TextChanged
        Try
            Dim f As String = "descripcion like '%" + txtfiltro.Text + "%'"
            ProductosBindingSource.Filter = f
        Catch ex As Exception

        End Try


    End Sub

    Private Sub ProductosDataGridView_DataBindingComplete(sender As System.Object, e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles ProductosDataGridView.DataBindingComplete
        lblstatus.Text = ProductosDataGridView.Rows.Count.ToString + " Productos en la Lista"
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click

    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        Dim frm As New catalogo_consulta_externa_agregar
        frm.ShowDialog()
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.FillByconsultaexterna(Me.ClinicaDataSet.Productos)
    End Sub
End Class