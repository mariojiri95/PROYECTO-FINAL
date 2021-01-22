Public Class Producto
    Private id As Integer
    Private nombre As String
    Private nombreMostrar As String
    Private unidad As String
    Private tipo As String
    Private subtipo As String
    Private precio As Double
    Private precioCoste As Double
    Private precioFinal As Double
    Private margen As Double
    Private beneficio As Double
    Private impuesto As Double
    Private impuesto2 As Double
    Private existencias As Integer
    Private favorito As Boolean
    Private imagen As String

    Public Sub New(aid As Integer)
        id = aid
    End Sub

    Public Sub New()

    End Sub
    Public Sub New(anombre As String, anombreMostrar As String, aunidad As String, atipo As String, asubtipo As String, aprecio As Double, aprecioCoste As Double, aprecioFinal As Double, amargen As Double, abeneficio As Double, aimpuesto As Double, aimpuesto2 As Double, aexistencias As Integer, afavorito As Boolean, aimagen As String)
        nombre = anombre
        nombreMostrar = anombreMostrar
        unidad = aunidad
        tipo = atipo
        subtipo = asubtipo
        precio = aprecio
        precioCoste = aprecioCoste
        precioFinal = aprecioFinal
        margen = amargen
        beneficio = abeneficio
        impuesto = aimpuesto
        impuesto2 = aimpuesto2
        existencias = aexistencias
        favorito = afavorito
        imagen = aimagen
    End Sub

    Public Sub New(aid As String, anombre As String, anombreMostrar As String, aunidad As String, atipo As String, asubtipo As String, aprecio As Double, aprecioCoste As Double, aprecioFinal As Double, amargen As Double, abeneficio As Double, aimpuesto As Double, aimpuesto2 As Double, aexistencias As Integer, afavorito As Boolean, aimagen As String)
        id = aid
        nombre = anombre
        nombreMostrar = anombreMostrar
        unidad = aunidad
        tipo = atipo
        subtipo = asubtipo
        precio = aprecio
        precioCoste = aprecioCoste
        precioFinal = aprecioFinal
        margen = amargen
        beneficio = abeneficio
        impuesto = aimpuesto
        impuesto2 = aimpuesto2
        existencias = aexistencias
        favorito = afavorito
        imagen = aimagen
    End Sub

    Public Function getId() As Integer
        Return id
    End Function

    Public Function getNombre() As String
        Return nombre
    End Function
    Public Function getNombreMostrar() As String
        Return nombreMostrar
    End Function
    Public Function getUnidad() As String
        Return unidad
    End Function
    Public Function getTipo() As String
        Return tipo
    End Function
    Public Function getSubtipo() As String
        Return subtipo
    End Function
    Public Function getPrecio() As Double
        Return precio
    End Function
    Public Function getPrecioCoste() As Double
        Return precioCoste
    End Function

    Public Function getPrecioFinal() As Double
        Return precioFinal
    End Function
    Public Function getMargen() As Double
        Return margen
    End Function
    Public Function getBeneficio() As Double
        Return beneficio
    End Function
    Public Function getImpuesto() As Double
        Return impuesto
    End Function
    Public Function getImpuesto2() As Double
        Return impuesto2
    End Function
    Public Function getExistencias() As Integer
        Return existencias
    End Function
    Public Function getFavorito() As Boolean
        Return favorito
    End Function

    Public Function getImagen() As String
        Return imagen
    End Function
End Class
