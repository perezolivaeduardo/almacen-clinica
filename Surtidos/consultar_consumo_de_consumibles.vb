Public Class consultar_consumo_de_consumibles

    Private Sub consultar_consumo_de_consumibles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        'TODO: esta línea de código carga datos en la tabla 'clinicaDataSet.inv_resumen_consumo_hojas_cerradas' Puede moverla o quitarla según sea necesario.
        Me.inv_resumen_consumo_hojas_cerradasTableAdapter.FillByconsumiblesxperiodo(Me.clinicaDataSet.inv_resumen_consumo_hojas_cerradas, del.Value.ToShortDateString, al.Value.ToShortDateString)

        Dim s As String = "Periodo del " + del.Value.ToShortDateString.ToString + " al " + al.Value.ToShortDateString.ToString

        Dim rp(0) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("subtitulo", S, True)
        Me.ReportViewer1.LocalReport.SetParameters(rp)
        Me.ReportViewer1.RefreshReport()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salir.Click
        Me.Close()
    End Sub
End Class