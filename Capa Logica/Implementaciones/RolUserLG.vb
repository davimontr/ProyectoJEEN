Imports Capa_Datos
Imports Capa_Logica

Public Class RolUserLG

    Implements Capa_Logica.RolUserInterfaceLG


    Private contexto As New JEENEntities
    Private rusut As RolUserInterface = New RolUserData(contexto)


    Public Sub Agregar(ByVal iTipousuarios As Tipos_Usuario) Implements RolUserInterfaceLG.Agregar
        rusut.Agregar(iTipousuarios)
        contexto.SaveChanges()

    End Sub

    Public Function buscar(ByVal id As Integer) As Tipos_Usuario Implements RolUserInterfaceLG.buscar
        rusut.buscar(id)

    End Function

    Public Sub Eliminar(ByVal iTipousuarios As Tipos_Usuario) Implements RolUserInterfaceLG.Eliminar
        rusut.Eliminar(iTipousuarios)

    End Sub

    Public Sub Modificar(ByVal iTipousuarios As Tipos_Usuario) Implements RolUserInterfaceLG.Modificar
        rusut.Modificar(iTipousuarios)
        contexto.SaveChanges()

    End Sub

    Public Function ObtenerDatos() As System.Collections.Generic.ICollection(Of Tipos_Usuario) Implements RolUserInterfaceLG.ObtenerDatos
        Try
            Return rusut.ObtenerDatos
        Catch ex As Exception

        End Try
    End Function

    'Public Function obte(ByVal iTipoususarios As Tipos_Usuario) As Tipos_Usuario Implements RolUserInterfaceLG.obte
    '    Return rusut.obte(iTipoususarios)
    'End Function

End Class
