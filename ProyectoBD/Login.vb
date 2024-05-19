

Imports System.Data.SqlClient

Public Class Login
    Dim comando As New SqlCommand()
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

        Dim username As String = TBUsuario.Text
        Dim password As String = TBContraseña.Text

        ' Aquí deberías tener código para verificar las credenciales.
        ' Esto podría involucrar la comparación con una base de datos, un archivo de texto, etc.
        ' Aquí tienes un ejemplo muy básico:

        If username = "admin" AndAlso password = "Alex24$" Then
            MessageBox.Show("Inicio de sesión exitoso")

            Dim ReviewsJuegos As New Form1()
            ReviewsJuegos.Show()

            Me.Hide() ' Cierra el formulario de inicio de sesión

        Else

            MessageBox.Show("Nombre de usuario o contraseña incorrectos")
        End If
    End Sub

End Class