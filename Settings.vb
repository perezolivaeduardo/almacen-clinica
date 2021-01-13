
Namespace My
    
    'Esta clase le permite controlar eventos específicos en la clase de configuración:
    ' El evento SettingChanging se desencadena antes de cambiar un valor de configuración.
    ' El evento PropertyChanged se desencadena después de cambiar el valor de configuración.
    ' El evento SettingsLoaded se desencadena después de cargar los valores de configuración.
    ' El evento SettingsSaving se desencadena antes de guardar los valores de configuración.
    Partial Friend NotInheritable Class MySettings
        Private Sub MySettings_PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs) Handles Me.PropertyChanged
            If e.PropertyName.Equals("database") Then
                Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + My.Settings.database
                Me("clinicacs") = cs
                Me("clinicaConnectionString") = cs
                My.Settings.Save()
            End If

            If e.PropertyName.Equals("cadenaNube") Then
                Me("csnube") = cadenaNube
                My.Settings.Save()
            End If


        End Sub


    End Class
End Namespace
