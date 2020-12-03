Public Class LoginForm

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim adap As New clinicaDataSetTableAdapters.usuariosTableAdapter
        Dim tbl As DataTable
        Try
            tbl = adap.GetDataBynik(UsernameTextBox.Text, PasswordTextBox.Text)
            If tbl.Rows.Count = 0 Then
                MsgBox("Verificar Usuario y contraseña")
                Exit Sub
            End If
        Catch ex As Exception

        End Try
        user_id = tbl.Rows(0).Item(0)
        user_nick = UsernameTextBox.Text
        user_nombre = tbl.Rows(0).Item("Nombre")
        DialogResult = Windows.Forms.DialogResult.OK

        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
