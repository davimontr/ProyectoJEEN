Public Interface RolUserInterface

    Sub Agregar(ByVal irol As Tipos_Usuario)

    Sub Modificar(ByVal irol As Tipos_Usuario)

    Sub Eliminar(ByVal irol As Tipos_Usuario)

    Function buscar(ByVal id As Integer) As Tipos_Usuario

    Function ObtenerDatos() As ICollection(Of Tipos_Usuario)

    Function obte(ByVal irol As Tipos_Usuario) As Tipos_Usuario

End Interface
