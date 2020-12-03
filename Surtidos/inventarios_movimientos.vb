Public Class inventarios_movimientos

    Private Sub reporte(ByVal id As Integer, ByVal fecha As Date, ByVal tipo As String, ByVal folio As Integer)
        Me.inv_sql_surtidoTableAdapter.FillByid(Me.ClinicaDataSet.inv_sql_surtido, id)
        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter
        Dim reporte As String
        reporte = tipo + " No." + folio.ToString
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("fecha", fecha, True)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", reporte, True)
        ReportViewer1.LocalReport.SetParameters(rp)
        Me.ReportViewer1.RefreshReport()
    End Sub

   
    Private Sub inventarios_movimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.areas' Puede moverla o quitarla según sea necesario.
        Me.AreasTableAdapter.Fill(Me.ClinicaDataSet.areas)
        Me.Inv_sql_documentosTableAdapter.Fill(Me.ClinicaDataSet.inv_sql_documentos)
    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Dim id As Integer, fecha As Date, tipo As String, folio As Integer
        id = dgv.CurrentRow.Cells(0).Value
        fecha = dgv.CurrentRow.Cells(4).Value
        tipo = dgv.CurrentRow.Cells(1).Value
        folio = dgv.CurrentRow.Cells(2).Value
        reporte(id, fecha, tipo, folio)


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim area As String
        area = Me.ComboBox1.SelectedValue
        Me.InvsqldocumentosBindingSource.Filter = "area = '" + area + "'"
    End Sub
End Class