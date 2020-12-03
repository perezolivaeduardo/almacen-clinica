Public Class reporte_Consulta_Externa

   
    Public Sub cargar(ByVal fecha As Date)
        'TODO: esta línea de código carga datos en la tabla 'clinicaDataSet.inv_resumen_consumo_consulta_externa' Puede moverla o quitarla según sea necesario.
        Me.inv_resumen_consumo_consulta_externaTableAdapter.FillByfecha(Me.clinicaDataSet.inv_resumen_consumo_consulta_externa, fecha)
        Dim rp(0) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("fecha", fecha.Date.ToString, True)
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub reporte_Consulta_Externa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub
End Class