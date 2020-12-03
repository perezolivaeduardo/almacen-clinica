Public Class hojadeentrega

    Private Sub hojadeentrega_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub ReportViewer1_Load(sender As System.Object, e As System.EventArgs) Handles ReportViewer1.Load

    End Sub

    Public Sub cargar(ByVal folio As Integer, ByVal fecha As String)

        Try
            Me.sql_inv_movimientosTableAdapter.Fillbyfolio(Me.clinicaDataSet.sql_inv_movimientos, 2, folio)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("Fecha", fecha, True)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("folio", folio.ToString, True)
        ReportViewer1.LocalReport.SetParameters(rp)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class