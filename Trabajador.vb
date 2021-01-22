Public Class Trabajador
    Private dni As String
    Private nombre As String
    Private nombreUsuario As String
    Private fechaNacimineto As String
    Private clave As String

    Public Sub New(adni As String)
        dni = adni
    End Sub

    Public Sub New(adni As String, anombre As String)
        dni = adni
        nombre = anombre
    End Sub

    Public Sub New()

    End Sub

    Public Sub New(adni As String, anombre As String, afechaNacimineto As String)
        dni = adni
        nombre = anombre
        fechaNacimineto = afechaNacimineto
    End Sub
    Public Sub New(adni As String, anombre As String, anombreUsuario As String, afechaNacimineto As String, aclave As String)
        dni = adni
        nombre = anombre
        nombreUsuario = anombreUsuario
        fechaNacimineto = afechaNacimineto
        clave = aclave
    End Sub

    Public Function getDni() As String
        Return dni
    End Function

    Public Function getNombre() As String
        Return nombre
    End Function

    Public Function getNombreUsuario() As String
        Return nombreUsuario
    End Function

    Public Function getFechaNacimiento() As String
        Return fechaNacimineto
    End Function

    Public Function getClave() As String
        Return clave
    End Function
End Class
