Public Class Relacion_de_entradas

    Private Sub Relacion_de_entradas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        date_del.Value = fn_periodo(Periodos.mes_anterior).del
        date_al.Value = fn_periodo(Periodos.mes_anterior).al
        cargar_reporte()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        cargar_reporte()
    End Sub

    Private Sub cargar_reporte()
        'TODO: esta línea de código carga datos en la tabla 'recetas_dataset.relacion_de_entradas' Puede moverla o quitarla según sea necesario.
        Me.relacion_de_entradasTableAdapter.FillByperiodo(Me.recetas_dataset.relacion_de_entradas, date_del.Value, date_al.Value)
        Dim rp(0 To 0) As Microsoft.Reporting.WinForms.ReportParameter

        Dim reporte As String = "Relacion de entradas del periodo " + date_del.Value.ToShortDateString + " al " + date_al.Value.ToShortDateString

        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("reporte", reporte, False)
        Me.ReportViewer1.LocalReport.SetParameters(rp)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class