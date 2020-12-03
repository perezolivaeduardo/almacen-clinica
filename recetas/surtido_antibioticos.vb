Public Class surtido_antibioticos

    Private Sub Inv_documentosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.Inv_documentosBindingSource.EndEdit()
        Me.Inv_documentosTableAdapter.Update(Me.ClinicaDataSet.inv_documentos)

    End Sub

    Private Sub surtido_antibioticos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.ClinicaDataSet.usuarios)

        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.inv_documentos' Puede moverla o quitarla según sea necesario.
        Me.Inv_documentosTableAdapter.FillByAntibioticos(Me.ClinicaDataSet.inv_documentos)
     

    End Sub

    Private Sub Inv_documentosDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Inv_documentosDataGridView.CellClick
        Dim folio As Integer = Inv_documentosDataGridView.CurrentRow.Cells(1).Value
        Me.Inv_movimientosTableAdapter.FillByfolio(Me.ClinicaDataSet.inv_movimientos, folio, 2)
        Try
            Me.Sql_inv_movimientosTableAdapter.Fillbyfolio(Me.ClinicaDataSet.sql_inv_movimientos, 2, folio)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("Fecha", Now.ToShortDateString.ToString, True)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("folio", folio.ToString, True)
        ReportViewer1.LocalReport.SetParameters(rp)

        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub Inv_documentosDataGridView_DataError(sender As System.Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Inv_documentosDataGridView.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Inv_documentosDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Inv_documentosDataGridView.CellContentClick

    End Sub
End Class