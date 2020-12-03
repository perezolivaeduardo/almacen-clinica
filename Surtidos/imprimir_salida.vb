Public Class imprimir_salida

    Public Sub cargar(ByVal folio As Integer, ByVal tipo As Integer, ByVal encabezado As String, ByVal fecha As Date)
        

        'TODO: esta línea de código carga datos en la tabla 'clinicaDataSet.inv_sql_surtido' Puede moverla o quitarla según sea necesario.
        Me.inv_sql_surtidoTableAdapter.FillByfolio(Me.clinicaDataSet.inv_sql_surtido, folio, tipo)

        Me.ReportViewer1.RefreshReport()

        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("fecha", fecha.ToShortDateString.ToString, True)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", encabezado, True)
        ReportViewer1.LocalReport.SetParameters(rp)
       

        ReportViewer1.Refresh()
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
   
    End Sub

    Private Sub imprimir_salida_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class