Public Class Pedido
    Private id As Integer
    Private dni As String
    Private fecha As String
    Private importe As Double

    Sub New(aid As Integer)
        id = aid
    End Sub
    Sub New(adni As String, aimporte As Double)
        dni = adni
        importe = aimporte
    End Sub

    Sub New(adni As String, afecha As String, aimporte As Double)
        dni = adni
        fecha = afecha
        importe = aimporte
    End Sub
    Sub New(aId As Integer, adni As String, afecha As String, aimporte As Double)
        id = aId
        dni = adni
        fecha = afecha
        importe = aimporte
    End Sub

    Public Function getId() As Integer
        Return id
    End Function

    Public Function getDni() As String
        Return dni
    End Function

    Public Function getFecha() As String
        Return fecha
    End Function

    Public Function getImporte() As Double
        Return importe
    End Function

End Class
