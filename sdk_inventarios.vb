
Module sdk_inventarios

    Enum Periodos
        hoy
        esta_semana
        este_mes
        mes_anterior
        lo_que_va_del_año
    End Enum

    Structure tperiodo
        Dim del As Date
        Dim al As Date
    End Structure
    Structure tinvent
        Dim cant As Integer
        Dim fecha As Date
    End Structure


    Public Function existencia_al(ByVal id As Integer, ByVal fecha_corte As Date) As DataRow
        Dim sql As String = "SELECT sql_movimientos_al_inventario.id_producto, Productos.Descripcion, Productos.Empaque, Min(inventario_inicial.fisico) AS inicial, Sum(sql_movimientos_al_inventario.entradas) AS ENT, Sum(sql_movimientos_al_inventario.surtido) AS salidas, Min(inventario_inicial.fisico)+Sum([entradas]+[dea_a_alma]+sql_movimientos_al_inventario.surtido) AS final, [costo]/[empaque] AS CU, (Min([inventario_inicial].[fisico])+Sum([entradas]+[dea_a_alma]+[sql_movimientos_al_inventario].[surtido]))*([costo]/[empaque]) AS importe, sql_movimientos_al_inventario.id_producto " _
& "FROM (categorias INNER JOIN (sql_movimientos_al_inventario RIGHT JOIN Productos ON sql_movimientos_al_inventario.id_producto = Productos.id_producto) ON categorias.Id_categoria = Productos.id_categoria) LEFT JOIN inventario_inicial ON Productos.id_producto = inventario_inicial.Id " _
& " WHERE(((sql_movimientos_al_inventario.fecha) <= [fecha]) And ((categorias.inventario) = True)) " _
& "GROUP BY sql_movimientos_al_inventario.id_producto, Productos.Descripcion, Productos.Empaque, [costo]/[empaque], sql_movimientos_al_inventario.id_producto " _
& "HAVING (((sql_movimientos_al_inventario.id_producto)=[ID])) "


        sql = sql.Replace("[fecha]", sqlfecha(fecha_corte.ToShortDateString))
        sql = sql.Replace("[ID]", id.ToString)

        Try
            existencia_al = leer_tabla(sql).Rows(0)
        Catch ex As Exception
            existencia_al = Nothing
        End Try

    End Function


    Public Function existencias(ByVal fecha_corte As Date) As DataTable
        Dim sql As String = "SELECT sql_movimientos_al_inventario.id_producto as ID, Productos.Descripcion, Productos.Empaque, Min(inventario_inicial.fisico) AS inicial, Sum(sql_movimientos_al_inventario.entradas) AS ENT, Sum(sql_movimientos_al_inventario.surtido) AS salidas, Min(inventario_inicial.fisico)+Sum([entradas]+[dea_a_alma]+sql_movimientos_al_inventario.surtido) AS final, [costo]/[empaque] AS CU, (Min([inventario_inicial].[fisico])+Sum([entradas]+[dea_a_alma]+[sql_movimientos_al_inventario].[surtido]))*([costo]/[empaque]) AS importe " _
    & "FROM (categorias INNER JOIN (sql_movimientos_al_inventario RIGHT JOIN Productos ON sql_movimientos_al_inventario.id_producto = Productos.id_producto) ON categorias.Id_categoria = Productos.id_categoria) LEFT JOIN inventario_inicial ON Productos.id_producto = inventario_inicial.Id " _
    & " WHERE(((sql_movimientos_al_inventario.fecha) <= [fecha]) And ((categorias.inventario) = True)) " _
    & "GROUP BY sql_movimientos_al_inventario.id_producto, Productos.Descripcion, Productos.Empaque, [costo]/[empaque], sql_movimientos_al_inventario.id_producto "


        sql = sql.Replace("[fecha]", sqlfecha(fecha_corte.ToShortDateString))

        Try
            existencias = leer_tabla(sql)
        Catch ex As Exception
            existencias = Nothing
        End Try
    End Function


    Function periodo_hoy() As tperiodo
        periodo_hoy.del = Date.Now.ToShortDateString + " 00:00:00"
        periodo_hoy.al = Date.Now.ToShortDateString + " 23:59:01"
    End Function

    Function periodo_esta_semana() As tperiodo
        Dim dia As Integer = Weekday(Now.Date) - 1
        Dim inicia As Date = Date.Now.AddDays(dia * -1).ToShortDateString + " 00:00:01"
        periodo_esta_semana.del = inicia
        periodo_esta_semana.al = inicia.AddDays(6).ToShortDateString + " 23:59:01"
    End Function

    Function periodo_este_mes() As tperiodo
        Dim dia As Integer = (Now.Date.Day)
        Dim inicia As Date = DateSerial(Now.Year, Now.Month, 1).ToShortDateString + " 00:00:00"
        Dim fin As Date = DateSerial(Now.Year, Now.Month, Now.Day).ToShortDateString + " 23:59:00"
        periodo_este_mes.del = inicia
        periodo_este_mes.al = fin
    End Function

    Function periodo_mes_anterior() As tperiodo
        Dim dia As Integer = (Now.Date.Day)
        Dim mmes As Integer = Now.Date.Month
        Dim inicia As Date
        If mmes = 1 Then
            inicia = DateSerial(Now.AddYears(-1).Year, 12, 1).ToShortDateString + " 00:00:00"
        Else
            inicia = DateSerial(Now.Year, Now.AddMonths(-1).Month, 1).ToShortDateString + " 00:00:00"
        End If
        Dim fin As Date = DateSerial(Now.Year, Now.Month, 1).AddDays(-1).ToShortDateString + " 23:59:00"

        periodo_mes_anterior.del = inicia
        periodo_mes_anterior.al = fin
    End Function

    Function periodo_lo_que_va_año() As tperiodo
        periodo_lo_que_va_año.del = DateSerial(Now.Year, 1, 1).ToShortDateString + " 00:00:00"
        periodo_lo_que_va_año.al = Now.Date.ToShortDateString + " 23:59:59"
    End Function

    Function fn_periodo(ByVal periodo As Integer) As tperiodo
        If periodo = Periodos.hoy Then fn_periodo = periodo_hoy()
        If periodo = Periodos.esta_semana Then fn_periodo = periodo_esta_semana()
        If periodo = Periodos.este_mes Then fn_periodo = periodo_este_mes()
        If periodo = Periodos.lo_que_va_del_año Then fn_periodo = periodo_lo_que_va_año()
        If periodo = Periodos.mes_anterior Then fn_periodo = periodo_mes_anterior()
    End Function

    Function cobalsky(ByVal msg As String) As Boolean
        Dim adap_bitacora As New clinicaDataSetTableAdapters.bitacoraTableAdapter
        Try
            'bitacora
            adap_bitacora.Insert(Now, user_id, "Almacen", Left(msg, 254), 0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return True
    End Function

    Public Function nombre_proveedor(ByVal id As Integer)
        Dim adap As New clinicaDataSetTableAdapters.proveedoresTableAdapter
        Return adap.Nombre(id)
    End Function

    Public Function fnExistencia_inicial(ByVal id As Integer) As tinvent
        Dim sql As String = "Select * from inventario_inicial where id=" + id.ToString
        Dim tbl As New DataTable
        tbl = leer_tabla(sql)
        Try
            fnExistencia_inicial.cant = tbl.Rows(0).Item("fisico")
            fnExistencia_inicial.fecha = tbl.Rows(0).Item("fecha")
        Catch ex As Exception
            fnExistencia_inicial.cant = 0
            fnExistencia_inicial.fecha = CDate("01/01/1900")
        End Try

    End Function

    Public Function tbl_movimientos(ByVal id As Integer) As DataTable
        Dim sql = "select tipo,cant from sql_movimientos_resumen where id=" + id.ToString
        tbl_movimientos = leer_tabla(sql)
    End Function

    Public Sub cursor_wait()
        Windows.Forms.Cursor.Current = Cursors.AppStarting
    End Sub

    Public Sub cursor_normal()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub
End Module
