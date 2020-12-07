Public Class frm_Ocompra_nuevo
    Dim numero As Integer
   
    Private Sub frm_Ocompra_nuevo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'OrdenesDS.Ocompra_detalle' Puede moverla o quitarla según sea necesario.
        Me.Ocompra_detalleTableAdapter.Fill(Me.OrdenesDS.Ocompra_detalle)

        Me.OcompraTableAdapter.Fill(Me.OrdenesDS.Ocompra)
        Try
            numero = OcompraTableAdapter.siguiente
        Catch ex As Exception
            numero = 1
        End Try

        OcompraBindingSource.AddNew()

        FechaDateTimePicker.Value = Now
        Fecha_limite_entregaDateTimePicker.Value = Now
        Id_usuario_capturaTextBox.Text = user_id
        Id_usuario_modificaTextBox.Text = "0"
        FechaCapturaTextBox.Text = Now.ToString
        Me.Ocompra_detalleTableAdapter.FillByid(Me.OrdenesDS.Ocompra_detalle, numero)

        IdTextBox.Text = numero
        txtdescuento.Text = "0.00"
        totaliza()

    End Sub

    Private Sub btn_agregar_Click(sender As System.Object, e As System.EventArgs) Handles btn_agregar.Click
        Dim frm As New seleccionar_producto
        frm.norden = numero
        frm.ShowDialog()

        If frm.cantidad = 0 Then
            totaliza()
            Me.Ocompra_detalleTableAdapter.FillByid(Me.OrdenesDS.Ocompra_detalle, numero)
            valida()
        End If
        Exit Sub

        Dim importe As String
        importe = frm.cantidad * frm.unitario

        'agregar renglon a la orden de compra
        Dim adap As New OrdenesDSTableAdapters.Ocompra_detalleTableAdapter
        adap.Insert(numero, frm.id, frm.descripcion, frm.presentacion, frm.empaque, frm.cantidad, frm.unitario, importe, frm.piva)

        'totalizar
        totaliza()
        'carga la tabla de nuevo
        Me.Ocompra_detalleTableAdapter.FillByid(Me.OrdenesDS.Ocompra_detalle, numero)

        valida()

    End Sub

    Private Sub totaliza()
        Dim subtotal, gravado, iva, total, descuento As Single
        If txtdescuento.TextLength = 0 Then txtdescuento.Text = "0.00"
        Dim adap As New OrdenesDSTableAdapters.Ocompra_detalleTableAdapter

        Try
            subtotal = adap.Subtotal(numero)
            gravado = adap.gravado(numero)
            iva = gravado * 0.16
            descuento = txtdescuento.Text
            total = subtotal - descuento + iva
        Catch ex As Exception

        End Try

        txtsubtotal.Text = Format(subtotal, "N2")
        txtdescuento.Text = Format(descuento, "N2")
        txtiva.Text = Format(iva, "N2")
        txttotal.Text = Format(total, "N2")


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        'Inicializa orden de compra
        Me.Ocompra_detalleTableAdapter.FillByid(Me.OrdenesDS.Ocompra_detalle, numero)

        Dim adap As New OrdenesDSTableAdapters.Ocompra_detalleTableAdapter
        adap.Eliminar(numero)

        'Carga la tabla de nuevo
        Me.Ocompra_detalleTableAdapter.FillByid(Me.OrdenesDS.Ocompra_detalle, numero)
    End Sub

    Private Sub txtdescuento_LostFocus(sender As Object, e As System.EventArgs)
        txtdescuento.Text = Format(Val(txtdescuento.Text), "N2")
    End Sub

    Private Sub txtdescuento_TextChanged(sender As System.Object, e As System.EventArgs)
        Try
            'agregar renglon a la orden de compra
            Dim adap As New OrdenesDSTableAdapters.Ocompra_detalleTableAdapter
            Dim subtotal, gravado, iva, total, descuento As Single

            subtotal = adap.Subtotal(numero)
            gravado = adap.gravado(numero)
            iva = gravado * 0.16
            descuento = txtdescuento.Text
            total = subtotal - descuento + iva

            txtsubtotal.Text = Format(subtotal, "N2")

            txtiva.Text = Format(iva, "N2")
            txttotal.Text = Format(total, "N2")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_guardar_Click(sender As System.Object, e As System.EventArgs) Handles btn_guardar.Click
        Me.Validate()
        Me.OcompraBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OrdenesDS)
        Me.Close()
    End Sub

    Private Sub valida()
        Dim er As Integer = 0
        If Id_provedorTextBox.TextLength = 0 Then er = 1
        If Val(txttotal.Text) = 0 Then er = 1
        If er = 1 Then btn_guardar.Enabled = False
        If er = 0 Then btn_guardar.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim frm As New frm_sel_proveedor
        frm.ShowDialog()
        Id_provedorTextBox.Text = frm.id
        nombre_proveedor.Text = frm.nombre
    End Sub

    Private Sub Id_provedorTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles Id_provedorTextBox.TextChanged
        valida()
    End Sub
End Class