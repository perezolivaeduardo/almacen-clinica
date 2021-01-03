Imports System.Management

Public Class main
    Public modo_local As Boolean


    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        My.Forms.stocks_definir.Show()
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        My.Forms.Consumos.Show()
    End Sub



    Private Sub main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ini()


        modo_local = False
        Dim f As Integer = FreeFile(), ix As MsgBoxResult

        ''   My.Settings.cadenaNube = "Server=tcp:programacionintegral.database.windows.net,1433;Initial Catalog=android;Persist Security Info=False;User ID=eduardo;Password=Integral#2017;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=180;"

        If Command.Length > 0 Then
            ix = MsgBox("Entrar Modo local?", MsgBoxStyle.YesNo, "")
            If ix = MsgBoxResult.Yes Then
                fileini = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\clinica_local.ini"
                modo_local = True
            End If
        End If

        Try
            Dim dumy As String
            FileOpen(f, fileini, OpenMode.Input, OpenAccess.Read)
            dumy = LineInput(f)
            dumy = LineInput(f)
            My.Settings.database = LineInput(f)
            FileClose(f)
        Catch ex As Exception
            MsgBox(ex.Message)
            FileClose(f)
            End
        End Try
        Me.Text = "Modulo de Almacen V." + My.Application.Info.Version.ToString

        Dim frml As New LoginForm
        frml.ShowDialog()
        If frml.DialogResult = Windows.Forms.DialogResult.Cancel Then
            End
        End If
        'barra de estatus
        lbl_usuario.Text = user_nombre

    End Sub
    Private Sub boton_configurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_configurar.Click
        Dim pw As String = InputBox("Teclee la clave", "PW", "")
        If pw = "esperanza" Then My.Forms.configurar.ShowDialog()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Me.Close()
    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click

    End Sub

    Private Sub InventariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub ConsultarImprimirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Forms.solicitud_reporte.Show()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Forms.solicitud_nueva.Show()
    End Sub

    Private Sub ListaParaInventarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaParaInventarioToolStripMenuItem.Click
        My.Forms.inventarios_hojas.Show()
    End Sub



    Private Sub ConsultarConsumosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ConsultarConsumiblesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub KARDEXToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KARDEXToolStripMenuItem.Click
        Dim frm As New KardexGlobal
        frm.Show()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click

    End Sub

    Private Sub CapturaDeInventariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapturaDeInventariosToolStripMenuItem.Click
        My.Forms.capturar_inventarios.Show()
    End Sub

    Private Sub DefinirGrupoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefinirGrupoToolStripMenuItem.Click
        My.Forms.Agrupar_productos.ShowDialog()
    End Sub

    Private Sub CatalogoDeMedicosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatalogoDeMedicosToolStripMenuItem.Click
        My.Forms.Medicos.ShowDialog()
    End Sub


    Private Sub ConsultarImprimirToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarImprimirToolStripMenuItem.Click
        My.Forms.solicitud_reporte.Show()
    End Sub

    Private Sub ConsultarMovimientosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarMovimientosToolStripMenuItem.Click
        My.Forms.inventarios_movimientos.Show()
    End Sub


    Private Sub ConsultarConsumiblesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarConsumiblesToolStripMenuItem1.Click
        My.Forms.consultar_consumo_de_consumibles.ShowDialog()
    End Sub

    Private Sub InventariosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventariosToolStripMenuItem1.Click
        My.Forms.Registro_de__Inventarios_por__lotes.Show()
    End Sub

    Private Sub CrearHojaDeInventarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrearHojaDeInventarioToolStripMenuItem.Click
        My.Forms.Inv_crear_hoja.ShowDialog()
    End Sub

    Private Sub CalcularExistenciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcularExistenciaToolStripMenuItem.Click
        My.Forms.inv_calcula_Existencia.Show()

    End Sub

    Private Sub ProToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProToolStripMenuItem.Click
        My.Forms.productos_relacion.Show()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        My.Forms.recetas.Show()
    End Sub

    Private Sub NuevaEntradaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaEntradaToolStripMenuItem.Click
        My.Forms.entrada_nueva.Show()
    End Sub

    Private Sub ConsultarEntradasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarEntradasToolStripMenuItem.Click
        My.Forms.Entrasdas_consulta.Show()
    End Sub

  

    Private Sub NuevoToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        My.Forms.solicitud_nueva.Show()
    End Sub

    Private Sub AgregarNuevoProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarNuevoProductoToolStripMenuItem.Click
        My.Forms.productos_nuevo.Show()
    End Sub

    Private Sub FormatoHonorariosPediatricosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormatoHonorariosPediatricosToolStripMenuItem.Click
        My.Forms.hoja_honorarios_pediatricos.Show()
    End Sub

    Private Sub RegistroDeSalidasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegistroDeSalidasToolStripMenuItem.Click
        My.Forms.solicitud_solicitar.Show()
    End Sub

    Private Sub RegistrarSalidaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegistrarSalidaToolStripMenuItem.Click
        My.Forms.relacion_de_documentos.Show()
    End Sub

    Private Sub CatalogoConsultaExternaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CatalogoConsultaExternaToolStripMenuItem.Click
        My.Forms.Catalogo_consulta_externa.ShowDialog()
    End Sub

    Private Sub TestToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TestToolStripMenuItem.Click
        Dim fecha As Date
        fecha = Now.Date.AddDays(-1)
        surtido_subir_nube.Show()
    End Sub

    Private Sub PROVEEDORESToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PROVEEDORESToolStripMenuItem.Click
        My.Forms.catalogo_proveedores.ShowDialog()

    End Sub

    Private Sub ReporteDeEntradasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReporteDeEntradasToolStripMenuItem.Click
        My.Forms.Relacion_de_entradas.Show()

    End Sub

    Private Sub PreparaTomaDeInevntarioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Dim frm As New Inventario_Fisico
        frm.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim frm As New Recepcion_de_Mercancia
        frm.ShowDialog()
    End Sub

    Private Sub BitacoraToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BitacoraToolStripMenuItem.Click
        Dim frm As New Bitacora
        frm.Show()
    End Sub

   

    Private Sub prueba()
        ':::Obtenemos el serial del Disco Duro
        Dim serialDD As New ManagementObject("Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'")
        MsgBox("Serial Disco Duro: " + serialDD.Properties("SerialNumber").Value.ToString)

        ':::Obtenemos el serial de la Board
        Dim serial As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_BaseBoard")
        Dim serialBoard As String = ""
        For Each serialB As ManagementObject In serial.Get()
            serialBoard = (serialB.GetPropertyValue("SerialNumber").ToString)
        Next
        MsgBox("Serial Board: " + serialBoard)
        Process.Start("C:\Program Files (x86)\TeamViewer\TeamViewer.exe")

    End Sub

    Private Sub VerInfoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VerInfoToolStripMenuItem.Click
        prueba()
    End Sub

   
    Private Sub PreparaTomaDeInevntarioToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles PreparaTomaDeInevntarioToolStripMenuItem.Click

    End Sub

    Private Sub OnrdenesDeCompraToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OnrdenesDeCompraToolStripMenuItem.Click
        Dim frm As New frm_Ocompra_relacion
        frm.ShowDialog()
    End Sub

    Private Sub NuevaOrdenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevaOrdenToolStripMenuItem.Click
        Dim frm As New frm_Ocompra_nuevo
        frm.ShowDialog()
    End Sub
End Class
