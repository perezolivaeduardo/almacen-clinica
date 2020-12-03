Public Class solicitud_reporte

    Public Sub cargar_productos(ByVal fecha As Date)


        '==============================================
        '       Imprime resumen del surtido            |
        '==============================================
        clinicaDataSet.EnforceConstraints = False
        Me.ReportViewer1.Visible = True
        Me.ReportViewer2.Visible = False
        'Genera reporte
        Dim frdel, fral As String

        frdel = fecha.ToShortDateString.ToString + " 00:00:00"
        fral = fecha.ToShortDateString.ToString + " 23:59:00"
        If fecha.DayOfWeek = DayOfWeek.Saturday Then
            fral = fecha.AddDays(1).ToShortDateString.ToString + " 23:59:00"

        End If

        Me.inv_sql_surtidoTableAdapter.FillByhoja_surtido(Me.clinicaDataSet.inv_sql_surtido, frdel, fral, False)

        Me.ReportViewer1.RefreshReport()
        Dim rp(0) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("fecha", fecha.ToShortDateString.ToString, True)
        Try
            Me.ReportViewer1.LocalReport.SetParameters(rp)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Me.ReportViewer1.Refresh()
        Me.ReportViewer1.RefreshReport()

    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cargar_productos(freporte.Value.ToShortDateString)
    End Sub

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.ReportViewer1.Visible = False
        Me.ReportViewer2.Visible = True
        'Genera reporte3
        Dim frdel, fral As String
        frdel = Format(freporte.Value, "MM/dd/yyyy")
        fral = Format(freporte.Value, "MM/dd/yyyy")

        If freporte.Value.DayOfWeek = DayOfWeek.Saturday Then
            fral = Format(freporte.Value.AddDays(1), "MM/dd/yyyy")
        End If

        Dim tbareas As DataTable, sql As String
        sql = "SELECT area FROM inv_sql_surtido WHERE fecha = [f1] OR fecha =[f2] GROUP BY area"
        sql = sql.Replace("[f1]", "#" + frdel + "#")
        sql = sql.Replace("[f2]", "#" + fral + "#")
        tbareas = leer_tabla(sql)
        Me.Text = sql
        Me.clinicaDataSet.EnforceConstraints = False
        Dim kareas As String
        For j As Integer = 0 To tbareas.Rows.Count - 1
            kareas = tbareas.Rows(j).Item(0)
            'TODO: esta línea de código carga datos en la tabla 'clinicaDataSet.inv_sql_surtido' Puede moverla o quitarla según sea necesario.
            Me.inv_sql_surtidoTableAdapter.FillByarea(Me.clinicaDataSet.inv_sql_surtido, CDate(freporte.Value).ToShortDateString, kareas, False)
            Dim rp(0) As Microsoft.Reporting.WinForms.ReportParameter
            rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("fecha", freporte.Value.ToShortDateString.ToString, True)
            Try
                Me.ReportViewer2.LocalReport.SetParameters(rp)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Me.ReportViewer2.Refresh()
            Me.ReportViewer2.RefreshReport()
            Dim ix As MsgBoxResult
            ix = MsgBox("Continuar", MsgBoxStyle.OkCancel, "Cancelar reporte")
            If ix = MsgBoxResult.Cancel Then Exit For
            Me.ReportViewer2.PrintDialog()
        Next
    End Sub

    Private Sub solicitud_reporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'clinicaDataSet.inv_sql_surtido' Puede moverla o quitarla según sea necesario.
        ' Me.inv_sql_surtidoTableAdapter.Fill(Me.clinicaDataSet.inv_sql_surtido)

    End Sub

    Private Sub ReportViewer2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer2.Load

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.ReportViewer1.Visible = False
        Me.ReportViewer2.Visible = True
        'Genera reporte3
        Dim frdel, fral As Date
        frdel = freporte.Value.ToShortDateString.ToString + " 00:00:00"
        fral = freporte.Value.ToShortDateString.ToString + " 23:59:59"
        Dim tbareas As DataTable, sql As String
        
        Me.inv_sql_surtidoTableAdapter.FillBysurtido_fecha(Me.clinicaDataSet.inv_sql_surtido, frdel, fral, 2)
        Dim rp(0) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("fecha", freporte.Value.ToShortDateString.ToString, True)
        Try
            Me.ReportViewer2.LocalReport.SetParameters(rp)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.ReportViewer2.Refresh()
        Me.ReportViewer2.RefreshReport()

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.ReportViewer1.Visible = False
        Me.ReportViewer2.Visible = True
        Dim titulo As String
        'Genera reporte3
        Dim frdel, fral As String
        Dim f1, f2 As Date
        f1 = freporte.Value.ToShortDateString
        f2 = f1
        frdel = Format(freporte.Value, "MM/dd/yyyy")
        fral = Format(freporte.Value, "MM/dd/yyyy")
        titulo = freporte.Value.ToShortDateString

        If freporte.Value.DayOfWeek = DayOfWeek.Saturday Then
            fral = Format(freporte.Value.AddDays(1), "MM/dd/yyyy")
            f2 = f1.AddDays(1)
            titulo = "del : " + freporte.Value.ToShortDateString + " al " + f2.ToShortDateString

        End If

        Dim tbareas As DataTable, sql As String
        sql = "SELECT area FROM inv_sql_surtido WHERE fecha = [f1] OR fecha =[f2] GROUP BY area"
        sql = sql.Replace("[f1]", "#" + frdel + "#")
        sql = sql.Replace("[f2]", "#" + fral + "#")
        tbareas = leer_tabla(sql)
        Me.Text = sql
        Me.clinicaDataSet.EnforceConstraints = False
        Dim kareas As String
        For j As Integer = 0 To tbareas.Rows.Count - 1
            kareas = tbareas.Rows(j).Item(0)
            'TODO: esta línea de código carga datos en la tabla 'clinicaDataSet.inv_sql_surtido' Puede moverla o quitarla según sea necesario.
            Me.inv_sql_surtidoTableAdapter.FillBysabado(Me.clinicaDataSet.inv_sql_surtido, f1, f2, kareas, False)
            Dim rp(0) As Microsoft.Reporting.WinForms.ReportParameter
            rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("fecha", titulo, True)
            Try
                Me.ReportViewer2.LocalReport.SetParameters(rp)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Me.ReportViewer2.Refresh()
            Me.ReportViewer2.RefreshReport()
            Dim ix As MsgBoxResult
            ix = MsgBox("Continuar", MsgBoxStyle.OkCancel, "Cancelar reporte")
            If ix = MsgBoxResult.Cancel Then Exit For
            Me.ReportViewer2.PrintDialog()
        Next
    End Sub
End Class