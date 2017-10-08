Imports Capa_Datos
Public Interface RolUserInterfaceLG

    Sub Agregar(ByVal iTipousuarios As Tipos_Usuario)

    Sub Modificar(ByVal iTipousuarios As Tipos_Usuario)

    Sub Eliminar(ByVal iTipousuarios As Tipos_Usuario)

    Function buscar(ByVal id As Integer) As Tipos_Usuario

    Function ObtenerDatos() As ICollection(Of Tipos_Usuario)

End Interface
