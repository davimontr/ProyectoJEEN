Public Interface UsuariosInterface

    Sub Agregar(ByVal iusuarios As Usuarios)

    Sub Modificar(ByVal iusuarios As Usuarios)

    Sub Eliminar(ByVal iusuarios As Usuarios)

    Function buscar(ByVal id As Integer) As Usuarios

    Function ObtenerDatos() As ICollection(Of Usuarios)

    Function obte(ByVal iusuarios As Usuarios) As Usuarios


End Interface
