Public Class Imprimir_documento

    Public Sub cargar(ByVal folio As Integer)
        'TODO: esta línea de código carga datos en la tabla 'clinicaDataSet.sql_entradas_detalle' Puede moverla o quitarla según sea necesario.
        Me.sql_entradas_detalleTableAdapter.FillByfolio(Me.clinicaDataSet.sql_entradas_detalle, folio)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Imprimir_documento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub imprimir(ByVal folio As Integer)

        'TODO: esta línea de código carga datos en la tabla 'clinicaDataSet.sql_entradas_detalle' Puede moverla o quitarla según sea necesario.
        Me.sql_entradas_detalleTableAdapter.FillByfolio(Me.clinicaDataSet.sql_entradas_detalle, folio)
        Me.ReportViewer1.RefreshReport()

        Dim pdffile = "c:\tmp\entrada" + folio.ToString + ".pdf"

        Dim warnings As Microsoft.Reporting.WinForms.Warning() = Nothing
        Dim streamids As String() = Nothing
        Dim mimeType As String = Nothing
        Dim encoding As String = Nothing
        Dim extension As String = Nothing
        Dim deviceInfo As String
        Dim bytes As Byte()
        Dim lr As New Microsoft.Reporting.WinForms.LocalReport
        lr.ReportPath = "entrada.rdlc"
        deviceInfo = "<DeviceInfo><SimplePageHeaders>True</SimplePageHeaders></DeviceInfo>"
        bytes = ReportViewer1.LocalReport.Render("pdf", deviceInfo, mimeType, encoding, extension, streamids, warnings)
        Dim fs As New System.IO.FileStream(pdffile, System.IO.FileMode.Create)
        fs.Write(bytes, 0, bytes.Length)
        fs.Close()
        Try
            '======================================================================================================================
            Dim MyProcess As New Process
            MyProcess.StartInfo.CreateNoWindow = False
            MyProcess.StartInfo.Verb = "print"
            MyProcess.StartInfo.FileName = pdffile
            MyProcess.Start()
            MyProcess.WaitForExit(10000)
            MyProcess.CloseMainWindow()
            MyProcess.Close()
        Catch ex As Exception

        End Try
        '  Me.Close()
    End Sub
End Class