Imports Capa_Datos
Imports Capa_Logica

Public Class UsuariosLG

    Implements Capa_Logica.UsuariosInterfaceLG

    Private contexto As New JEENEntities
    Private usu As UsuariosInterface = New UsuariosData(contexto)

    Public Sub Agregar(iusuarios As Usuarios) Implements UsuariosInterfaceLG.Agregar
        usu.Agregar(iusuarios)
        contexto.SaveChanges()
    End Sub

    Public Sub Eliminar(iusuarios As Usuarios) Implements UsuariosInterfaceLG.Eliminar
        usu.Eliminar(iusuarios)
    End Sub

    Public Sub Modificar(iusuarios As Usuarios) Implements UsuariosInterfaceLG.Modificar
        Throw New NotImplementedException()
    End Sub

    Public Function buscar(id As Integer) As Usuarios Implements UsuariosInterfaceLG.buscar
        usu.buscar(id)
    End Function

    Public Function obte(iusuarios As Usuarios) As Usuarios Implements UsuariosInterfaceLG.obte
        Return usu.obte(iusuarios)
    End Function

    Public Function ObtenerDatos() As ICollection(Of Usuarios) Implements UsuariosInterfaceLG.ObtenerDatos
        Try
            Return usu.ObtenerDatos
        Catch ex As Exception

        End Try
    End Function
End Class
