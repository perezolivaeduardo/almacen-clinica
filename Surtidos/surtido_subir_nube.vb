Public Class surtido_subir_nube

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        subir_surtido_nube(fecha.Value)
    End Sub


    Public Sub subir_surtido_nube(ByVal fecha As Date)
        Dim adap As New nubedatasetTableAdapters.alm_surtidosTableAdapter

        Dim fecha1 As Date = fecha
        If fecha.DayOfWeek = DayOfWeek.Sunday Or Me.fecha.Value.ToShortDateString = CDate("25/12/2019") Then
            fecha = fecha.AddDays(-1)
        End If

        adap.Eliminar_surtidosXFecha(fecha1.ToShortDateString) 'borra surtido del dia si es que hay , si es de sabado pone periodo y todo lo pone con fecha de domingo, de igual forma si borre se borra desde domingo
        adap.Eliminar_surtidosXFecha(fecha.ToShortDateString) 'borra surtido del dia si es que hay , si es de sabado pone periodo y todo lo pone con fecha de domingo, de igual forma si borre se borra desde domingo

        Dim sql As String

        sql = "SELECT Max(inv_documentos.folio) AS folio, #[fecha1]# AS fecha, areas.area, inv_movimientos.id_producto, Productos.Descripcion, Sum(inv_movimientos.cantidad) AS SumaDecantidad " _
        & "FROM (((inv_documentos INNER JOIN inv_movimientos ON (inv_documentos.tipo = inv_movimientos.tipo) AND (inv_documentos.folio = inv_movimientos.folio)) INNER JOIN areas ON inv_documentos.id_area = areas.id_area) LEFT JOIN stocks ON (inv_movimientos.id_producto = stocks.id_producto) AND (inv_movimientos.id_Area = stocks.id_area)) LEFT JOIN Productos ON inv_movimientos.id_producto = Productos.id_producto " _
        & " WHERE(((inv_documentos.fecha) = #[fecha]# Or (inv_documentos.fecha) = #[fecha1]#) And ((inv_documentos.tipo) = 2) And ((stocks.consumible) = False)) " _
        & "GROUP BY #[fecha1]#, areas.area, inv_movimientos.id_producto, Productos.Descripcion " _
        & "ORDER BY Productos.Descripcion"



        sql = sql.Replace("[fecha]", Format(fecha, "MM/dd/yyyy"))
        sql = sql.Replace("[fecha1]", Format(fecha1, "MM/dd/yyyy"))

        Dim tbl As DataTable

        tbl = leer_tabla(sql)
        ProgresBar.Maximum = tbl.Rows.Count

        For j As Integer = 0 To tbl.Rows.Count - 1
            With tbl.Rows(j)
                adap.Insert(.Item(0), .Item(1), .Item(2), .Item(3), .Item(4), CSng(.Item(5)), False, "", False, False)
            End With
            ProgresBar.Value = j
            Me.Refresh()
        Next

        MsgBox("Terminado")
    End Sub

    Private Sub Alm_surtidosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles Alm_surtidosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Alm_surtidosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Nubedataset)
    End Sub

    Private Sub surtido_subir_nube_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Nubedataset.alm_surtidos' Puede moverla o quitarla según sea necesario.
        Me.Alm_surtidosTableAdapter.Fill(Me.Nubedataset.alm_surtidos)

    End Sub
End Class