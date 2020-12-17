Public Class Form1
    Private Sub AdministradorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AdministradorBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AdministradorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Cdlc_pruebaDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Cdlc_pruebaDataSet.administrador' Puede moverla o quitarla según sea necesario.
        Me.AdministradorTableAdapter.Fill(Me.Cdlc_pruebaDataSet.administrador)

    End Sub

    'BOTON AGREGAR'
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'LLamamos a la consulta creada en el diseñador'
        'Seguidamente le colocamos como parametros los TextBox donde ingresaremos los datos'
        Me.AdministradorTableAdapter.AgregarEquipo(Id_administradorTextBox.Text, Nombre_clienteTextBox.Text, Correo_clienteTextBox.Text, Equipo_clienteTextBox.Text)
        'Se copia la linea de codigo 11 dentro del boton para que el datagridview se actualice automaticamente'
        Me.AdministradorTableAdapter.Fill(Me.Cdlc_pruebaDataSet.administrador)
    End Sub

    Private Sub AdministradorDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AdministradorDataGridView.CellContentClick

    End Sub

    Private Sub Id_administradorTextBox_TextChanged(sender As Object, e As EventArgs) Handles Id_administradorTextBox.TextChanged

    End Sub
End Class
