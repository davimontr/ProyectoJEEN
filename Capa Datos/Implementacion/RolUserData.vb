
Public Class RolUserData

    Implements RolUserInterface


    Private context As JEENEntities

    Sub New(ByRef pcontext As JEENEntities)
        context = pcontext

    End Sub



    Public Sub Agregar(ByVal irolusu As Tipos_Usuario) Implements RolUserInterface.Agregar
        Try
            context.Tipos_Usuario.Add(irolusu)


        Catch ex As Exception

        End Try


    End Sub

    Public Function buscar(ByVal id As Integer) As Tipos_Usuario Implements RolUserInterface.buscar
        Try
            'Dim cliente As Usuarios = (From p In context.Usuarios Where p.ID = id Select p).FirstOrDefault
            'Return cliente
        Catch ex As Exception


        End Try


    End Function

    Public Sub Eliminar(ByVal irolusu As Tipos_Usuario) Implements RolUserInterface.Eliminar
        Try
            context.Tipos_Usuario.Remove(irolusu)
        Catch ex As Exception

        End Try

    End Sub

    Public Sub Modificar(ByVal irolusu As Tipos_Usuario) Implements RolUserInterface.Modificar
        Try
            context.Entry(irolusu).State = Entity.EntityState.Modified

        Catch ex As Exception

        End Try

    End Sub

    Public Function ObtenerDatos() As System.Collections.Generic.ICollection(Of Tipos_Usuario) Implements RolUserInterface.ObtenerDatos
        Try

            Return (From cli In context.Tipos_Usuario Select cli).ToList
        Catch ex As Exception
            Return ex
        End Try

    End Function



    Public Function obte(ByVal irolusu As Tipos_Usuario) As Tipos_Usuario Implements RolUserInterface.obte

        Try
            'Dim cliente As Usuarios = (From p In context.Usuarios Where p.Usuario = Usuarios And p.contrasena = contrasena Select p).FirstOrDefault
            'Return cliente
        Catch ex As Exception

        End Try

    End Function

End Class
