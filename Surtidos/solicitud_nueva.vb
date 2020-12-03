Public Class solicitud_nueva
    Dim ds As New DataSet
    Dim bs As New BindingSource
    Dim bsc As New BindingSource
    Dim tbldetalle As DataTable
    Dim tblconsulta As DataTable

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        status.Text = "Inicia Proceso.. " : Me.Refresh()
        Try
            Dim mascara As New clinicaDataSetTableAdapters.hs_productosTableAdapter
            mascara.actualiza_mascarilla()
            mascara.Dispose()
        Catch ex As Exception
            StatusStrip1.Refresh()
        End Try
        status.Text = "Borra Hoja si ya existe.. " : Me.Refresh()
        StatusStrip1.Refresh()

        'Borra surtidos si ya existen
        '===============================================    
        '  Dim sql As String
        '   sql = "delete * from inv_documentos where tipo = 2 and fecha =" + sqlfecha(DateTimePicker1.Value.ToShortDateString)
        '   commando(sql)
        '   sql = "delete * from inv_movimientos where tipo = 2  and fecha =" + sqlfecha(DateTimePicker1.Value.ToShortDateString)
        '   commando(sql)
        '   status.Text = "Hoja Borrada.. " : Me.Refresh()
        '   StatusStrip1.Refresh()

        Windows.Forms.Cursor.Current = Cursors.WaitCursor

        cargar_consumos_new(Me.DateTimePicker1.Value.ToShortDateString)

        Windows.Forms.Cursor.Current = Cursors.Default
        status.Text = "Inicia generar Hojas.. " : Me.Refresh()

        Dim idarea As Integer, sql As String
        sql = "select * from inv_documentos where id_area=" + idarea.ToString + " and tipo = 2 and fecha =" + sqlfecha(Me.DateTimePicker1.Value)
        If leer_tabla(sql).Rows.Count > 1 Then
            MsgBox("Ya se generaron las hojas para esta fecha.")
        Else
            Windows.Forms.Cursor.Current = Cursors.WaitCursor

            genera(Me.DateTimePicker1.Value.ToShortDateString)

            Windows.Forms.Cursor.Current = Cursors.Default
        End If


        'si es sabado o 24 de diciembre no sube el surtido a la nube
        If Me.DateTimePicker1.Value.DayOfWeek <> DayOfWeek.Saturday Then
            status.Text = "Cargando Tabletas...." : Me.Refresh()
            StatusStrip1.Refresh() : Me.Refresh()
            surtido_subir_nube.subir_surtido_nube(DateTimePicker1.Value.ToShortDateString)
            status.Text = "Tabletas cargadas, Trabajo Termindao ...." : Me.Refresh()
            StatusStrip1.Refresh() : Me.Refresh()
        End If


    End Sub

    'Private Sub cargar_consumos(ByVal fecha As Date)
    '    ' aun que la tabla se llama cuentas cerradas no son las cuentas cerradas
    '    status.Text = "Calculando consumos ..."
    '    StatusStrip1.Refresh()
    '    Dim tbl As New DataTable, sql As String
    '    Dim f1, f2 As String
    '    f1 = "#" + Format(fecha, "MM/dd/yyyy") + " 0:0:1#"
    '    f2 = "#" + Format(fecha, "MM/dd/yyyy") + " 23:59:59#"

    '    sql = "SELECT areas.area, hs_productos.Id_producto AS id, Productos.Descripcion, Sum(hs_productos.Cantidad) AS Cantidad, areas.id_area AS IDA, stocks.consumible " _
    '    & " FROM stocks INNER JOIN ((hs_productos INNER JOIN Productos ON hs_productos.Id_producto = Productos.id_producto) INNER JOIN areas ON hs_productos.area = areas.id_area) ON (stocks.id_producto = hs_productos.Id_producto) AND (stocks.id_area = hs_productos.area)" _
    '    & " WHERE hs_productos.fecha Between [del] And [al] AND ((Productos.tipo=1) or (productos.tipo=2 and (productos.id_categoria<4 or productos.id_categoria=7))) and hs_productos.tipo<>9 GROUP BY areas.area, hs_productos.Id_producto, Productos.Descripcion, areas.id_area, stocks.consumible"
    '    sql = sql.Replace("[del]", f1)
    '    sql = sql.Replace("[al]", f2)

    '    Clipboard.SetText(sql)
    '    tbldetalle = leer_tabla(sql)


    '    If tbldetalle.Rows.Count = 0 Then
    '        MsgBox("No se encontraron productos en esta fecha")
    '        '  Stop
    '    End If


    '    Try
    '        ds.Tables.Clear()
    '    Catch ex As Exception

    '    End Try
    '    status.Text = "Calculando consumos consulta externa ..."
    '    ' lee consumo  de consulta externa

    '    sql = "SELECT * " _
    '    & " FROM inv_resumen_consumo_consulta_externa WHERE inv_resumen_consumo_consulta_externa.[fecha]=[fechar] "
    '    sql = sql.Replace("[fechar]", sqlfecha(fecha))
    '    tblconsulta = leer_tabla(sql)


    '    ds.Tables.Add(tbldetalle)
    '    ds.Tables.Add(tblconsulta)
    '    dgvdetalle.DataSource = ds.Tables(0)
    '    dgvce.DataSource = ds.Tables(1)

    '    bs.DataSource = ds.Tables(0)
    '    bsc.DataSource = ds.Tables(1)

    '    dgvdetalle.Columns("area").Visible = False
    '    dgvdetalle.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

    '    'dgvarea.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    '    dgvce.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    '    dgvce.Columns(0).Visible = False
    '    dgvce.Columns(1).Visible = False
    '    dgvce.Columns(5).Visible = False
    '    dgvce.Columns(6).Visible = False
    '    dgvce.Columns(7).Visible = False
    '    Me.Refresh()
    'End Sub

    Private Sub cargar_consumos_new(ByVal fecha As Date)
        ' aun que la tabla se llama cuentas cerradas no son las cuentas cerradas
        status.Text = "Calculando consumos ..."
        StatusStrip1.Refresh()
        Dim tbl As New DataTable, sql As String
        Dim f1, f2 As String
        f1 = "#" + Format(fecha, "MM/dd/yyyy") + " 0:0:1#"
        f2 = "#" + Format(fecha, "MM/dd/yyyy") + " 23:59:59#"

        'hs_productos.tipo<>9 Excluye Consulta externa
        'Que no este marcado como consumible en la tabla de tock
        'que en el catalogo de productosn o este categora 4(Servicios) ni 6 (consumibles)
        'Excluye ANTIBIOTICOS grupo 4

        sql = "SELECT areas.area, hs_productos.Id_producto AS id, Productos.Descripcion, Sum(hs_productos.Cantidad) AS Cantidad, areas.id_area AS IDA, stocks.consumible " _
        & " FROM stocks INNER JOIN ((hs_productos INNER JOIN Productos ON hs_productos.Id_producto = Productos.id_producto) INNER JOIN areas ON hs_productos.area = areas.id_area) ON (stocks.id_producto = hs_productos.Id_producto) AND (stocks.id_area = hs_productos.area)" _
        & " WHERE hs_productos.fecha Between [del] And [al] AND hs_productos.tipo<>9 and stocks.consumible=False and " _
        & " productos.grupo<>4 and productos.id_categoria <>4 and productos.id_categoria <>6  " _
        & "GROUP BY areas.area, hs_productos.Id_producto, Productos.Descripcion, areas.id_area, stocks.consumible"
        sql = sql.Replace("[del]", f1)
        sql = sql.Replace("[al]", f2)

        Clipboard.SetText(sql)
        tbldetalle = leer_tabla(sql)

        If tbldetalle.Rows.Count = 0 Then
            MsgBox("No se encontraron productos en esta fecha")
            '  Stop
        End If

        Try
            ds.Tables.Clear()
        Catch ex As Exception

        End Try
        status.Text = "Calculando consumos consulta externa ..."
        ' lee consumo  de consulta externa

        sql = "SELECT * " _
        & " FROM inv_resumen_consumo_consulta_externa WHERE inv_resumen_consumo_consulta_externa.[fecha]=[fechar] "
        sql = sql.Replace("[fechar]", sqlfecha(fecha))
        tblconsulta = leer_tabla(sql)


        ds.Tables.Add(tbldetalle)
        ds.Tables.Add(tblconsulta)
        dgvdetalle.DataSource = ds.Tables(0)
        dgvce.DataSource = ds.Tables(1)

        bs.DataSource = ds.Tables(0)
        bsc.DataSource = ds.Tables(1)

        dgvdetalle.Columns("area").Visible = False
        dgvdetalle.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        'dgvarea.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvce.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvce.Columns(0).Visible = False
        dgvce.Columns(1).Visible = False
        dgvce.Columns(5).Visible = False
        dgvce.Columns(6).Visible = False
        dgvce.Columns(7).Visible = False
        Me.Refresh()
    End Sub


    Private Sub genera(ByVal fecha As Date)
        status.Text = "Generando Surtidos ..." : Me.Refresh()
        StatusStrip1.Refresh()
        Dim idarea As Integer
        Dim sql As String
        Dim folio As Integer = 0
        Dim rsdoc As New clinicaDataSetTableAdapters.inv_documentosTableAdapter
        ds.EnforceConstraints = False

        idarea = tbldetalle.Rows(0).Item("IDA")
        idarea = 0

        Dim cant, idp As Integer
        idarea = 0
        'inserta detalle de cuentas 
        For j As Integer = 0 To tbldetalle.Rows.Count - 1
            Dim rsm As New clinicaDataSetTableAdapters.inv_movimientosTableAdapter
            status.Text = "Generando Surtidos ... " + j.ToString + "/" + tbldetalle.Rows.Count.ToString : Me.Refresh()
            StatusStrip1.Refresh()
            With (tbldetalle.Rows(j))
                If .Item("IDA") = idarea Then
                    cant = .Item("cantidad") : idp = .Item("id")
                    rsm.Insert(folio, idp, idarea, 0, 0, 2, fecha.ToShortDateString, cant, 0, "")
                Else
                    idarea = .Item("IDA") : folio = rsdoc.sig_folio(2) ' solicitud
                    rsdoc.Insert(folio, 2, idarea, fecha, 0, 0, 0, fecha, "", fecha, False, 0, fecha)
                    cant = .Item("cantidad") : idp = .Item("id")
                    rsm.Insert(folio, idp, idarea, 0, 0, 2, fecha.ToShortDateString, cant, 0, "")
                End If
            End With
            rsm.Dispose()
        Next

        'inserta detalle de consulta externa
        For j As Integer = 0 To tblconsulta.Rows.Count - 1
            Dim rsm As New clinicaDataSetTableAdapters.inv_movimientosTableAdapter
            status.Text = "Generando Surtidos consulta Externa " + j.ToString + "/" + Str$(tblconsulta.Rows.Count - 1) : Me.Refresh()
            StatusStrip1.Refresh()
            With (tblconsulta.Rows(j))
                If .Item("IDA") = idarea Then
                    cant = .Item("cantidad") : idp = .Item("id")
                    rsm.Insert(folio, idp, idarea, 0, 0, 2, fecha.ToShortDateString, cant, 0, "")
                Else
                    idarea = .Item("IDA") : folio = rsdoc.sig_folio(2) ' solicitud
                    rsdoc.Insert(folio, 2, idarea, fecha, 0, 0, 0, fecha, "", fecha, False, 0, fecha)
                    cant = .Item("cantidad") : idp = .Item("id")
                    rsm.Insert(folio, idp, idarea, 0, 0, 2, fecha.ToShortDateString, cant, 0, "")
                End If
            End With
            rsm.Dispose()
        Next



    End Sub

    Private Sub btn_reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reporte.Click
        My.Forms.solicitud_reporte.Show()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Try
            tbldetalle.Clear()
            tblconsulta.Clear()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        cargar_consumos_new(Me.DateTimePicker1.Value.ToShortDateString)
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim ix As MsgBoxResult
        Dim sql As String
        ix = MsgBox("Seguro que quiere borrar las hojas de surtido ?", MsgBoxStyle.YesNo, "Borrar Surtido")
        If ix = MsgBoxResult.Yes Then
            sql = "delete * from inv_documentos where tipo = 2 and fecha =" + sqlfecha(DateTimePicker1.Value.ToShortDateString)
            commando(sql)
            sql = "delete * from inv_movimientos where tipo = 2  and fecha =" + sqlfecha(DateTimePicker1.Value.ToShortDateString)
            commando(sql)
            MsgBox("Se borraron surtidos del " + DateTimePicker1.Value.ToShortDateString + ", ya puede generar de nuevo las hojas")
        End If
    End Sub

    Private Sub btn_consulta_externa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_consulta_externa.Click

        My.Forms.reporte_Consulta_Externa.cargar(Me.DateTimePicker1.Value.Date)
        My.Forms.reporte_Consulta_Externa.Show()
    End Sub

    Private Sub status_Click(sender As System.Object, e As System.EventArgs) Handles status.Click, status.DoubleClick
        ' aun que la tabla se llama cuentas cerradas no son las cuentas cerradas
        status.Text = "Calculando consumos ..."
        Dim tbl As New DataTable, sql As String
        Dim f1, f2 As String
        f1 = "#" + Format(DateTimePicker1.Value, "MM/dd/yyyy") + " 0:0:1#"
        f2 = "#" + Format(DateTimePicker1.Value, "MM/dd/yyyy") + " 23:59:59#"

        sql = "SELECT areas.area, hs_productos.Id_producto AS id, Productos.Descripcion, Sum(hs_productos.Cantidad) AS Cantidad, areas.id_area AS IDA, stocks.consumible " _
        & " FROM stocks INNER JOIN ((hs_productos INNER JOIN Productos ON hs_productos.Id_producto = Productos.id_producto) INNER JOIN areas ON hs_productos.area = areas.id_area) ON (stocks.id_producto = hs_productos.Id_producto) AND (stocks.id_area = hs_productos.area)" _
        & " WHERE hs_productos.fecha Between [del] And [al] AND ((Productos.tipo=1) or (productos.tipo=2 and productos.id_categoria<4) or (productos.tipo=2 and productos.id_categoria=7) ) and hs_productos.tipo<>9 GROUP BY areas.area, hs_productos.Id_producto, Productos.Descripcion, areas.id_area, stocks.consumible"
        sql = sql.Replace("[del]", f1)
        sql = sql.Replace("[al]", f2)

        Clipboard.SetText(sql)
        Stop
    End Sub
End Class




