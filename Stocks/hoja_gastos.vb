Public Class hoja_gastos

    Private Sub hoja_gastos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub

    Public Sub cargar(ByVal id As Integer)
        'TODO: esta línea de código carga datos en la tabla 'clinicaDataSet.sql_alma_stocks' Puede moverla o quitarla según sea necesario.
        Me.sql_alma_stocksTableAdapter.FillByarea(Me.clinicaDataSet.sql_alma_stocks, id)

        Me.ReportViewer1.RefreshReport()
    End Sub

End Class