
Imports System.Data.SqlClient

Public Class Login
    Dim comando As New SqlCommand()
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

        Dim username As String = TBUsuario.Text
        Dim password As String = TBContraseña.Text


        If username = "admin" AndAlso password = "Alex24$" Then
            MessageBox.Show("Inicio de sesión exitoso")

            Dim FVehiculo As New Form1()
            FVehiculo.Show()

            Me.Hide()

        Else

            MessageBox.Show("Nombre de usuario o contraseña incorrectos")
        End If
    End Sub

End Class