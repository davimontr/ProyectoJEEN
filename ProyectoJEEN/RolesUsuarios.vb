Imports Capa_Logica
Imports Capa_Datos
Public Class RolesUsuarios

    'Private Property rol As RolUserInterfaceLG = New RolUserLG

    Dim tipo As New Tipos_Usuario
    Dim utipo As New RolUserLG

    Private Sub RolesUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()



    End Sub


    Public Sub agregar()
        tipo.Nombre = txtRol.Text

        utipo.Agregar(tipo)

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        agregar()

    End Sub


    Public Sub mostrar()
        DgvRoles.DataSource = utipo.ObtenerDatos
        Me.DgvRoles.AutoResizeColumns()

    End Sub



    'asd.Columns.Item(5).Visibility = True


End Class