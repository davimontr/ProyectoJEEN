'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Clientes
    Public Property ID_Cliente As Integer
    Public Property Cliente As String

    Public Overridable Property Facturas_Prestamos As ICollection(Of Facturas_Prestamos) = New HashSet(Of Facturas_Prestamos)

End Class
