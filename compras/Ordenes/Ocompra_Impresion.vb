Public Class Ocompra_Impresion

    Private Sub Ocompra_Impresion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
      
    End Sub

    Public Sub cargar(ByVal orden As Integer, ByVal Proveedor As String, ByVal capturo As String)
        'TODO: esta línea de código carga datos en la tabla 'OrdenesDS.Ocompra' Puede moverla o quitarla según sea necesario.
        Me.OcompraTableAdapter.FillByid(Me.OrdenesDS.Ocompra, orden)
        'TODO: esta línea de código carga datos en la tabla 'OrdenesDS.Ocompra_detalle' Puede moverla o quitarla según sea necesario.
        Me.Ocompra_detalleTableAdapter.FillByid(Me.OrdenesDS.Ocompra_detalle, orden)


        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("Proveedor", Proveedor, False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("usuario", capturo, False)
        Me.ReportViewer1.LocalReport.SetParameters(rp)





        Me.ReportViewer1.RefreshReport()
    End Sub
End Class