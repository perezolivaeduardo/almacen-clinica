Public Class catalogo_proveedores

   

    Private Sub catalogo_proveedores_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.ClinicaDataSet.proveedores)

    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Validate()
        Me.ProveedoresBindingSource.EndEdit()
        Me.ProveedoresTableAdapter.Update(Me.ClinicaDataSet.proveedores)
        Me.Close()
    End Sub

    Private Sub txtfiltro_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtfiltro.TextChanged
        Dim f As String = "nombre like '%" + txtfiltro.Text + "%'"
        ProveedoresBindingSource.Filter = f

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ProveedoresBindingSource.Filter = ""
    End Sub
End Class