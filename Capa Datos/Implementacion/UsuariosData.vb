Public Class UsuariosData

    Implements UsuariosInterface


    Private context As JEENEntities

    Sub New(ByRef pcontext As JEENEntities)
        context = pcontext

    End Sub



    Public Sub Agregar(ByVal iusuarios As Usuarios) Implements UsuariosInterface.Agregar
        Try
            context.Usuarios.Add(iusuarios)


        Catch ex As Exception

        End Try


    End Sub

    Public Function buscar(ByVal id As Integer) As Usuarios Implements UsuariosInterface.buscar
        Try
            'Dim cliente As Usuarios = (From p In context.Usuarios Where p.ID = id Select p).FirstOrDefault
            'Return cliente
        Catch ex As Exception


        End Try


    End Function

    Public Sub Eliminar(ByVal iusuarios As Usuarios) Implements UsuariosInterface.Eliminar
        Try
            context.Usuarios.Remove(iusuarios)
        Catch ex As Exception

        End Try

    End Sub

    Public Sub Modificar(ByVal iusuarios As Usuarios) Implements UsuariosInterface.Modificar
        Try
            context.Entry(iusuarios).State = Entity.EntityState.Modified

        Catch ex As Exception

        End Try

    End Sub

    Public Function ObtenerDatos() As System.Collections.Generic.ICollection(Of Usuarios) Implements UsuariosInterface.ObtenerDatos
        Try

            Return (From cli In context.Usuarios Select cli).ToList
        Catch ex As Exception
            Return ex
        End Try

    End Function



    Public Function obte(ByVal iusuarios As Usuarios) As Usuarios Implements UsuariosInterface.obte

        Try
            'Dim cliente As Usuarios = (From p In context.Usuarios Where p.Usuario = Usuarios And p.contrasena = contrasena Select p).FirstOrDefault
            'Return cliente
        Catch ex As Exception

        End Try

    End Function

End Class
