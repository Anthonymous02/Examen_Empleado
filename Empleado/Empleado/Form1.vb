Imports System.Data.SqlClient
Public Class form1


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvista.CellContentClick

    End Sub

    Private Sub cmdinsertar_Click(sender As Object, e As EventArgs) Handles cmdinsertar.Click
        Try
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandText = " insert into empleado( nif_empleado, nombre, direccion, ciudad, edad  ) values ( @nif_empleado, @nombre, @direccion, @ciudad, @edad)"
            cmd.CommandText = " insert into empleado (nif_empleado, nombre, direccion, ciudad, edad) values ('" & txtnif.Text & "','" & txtnombre.Text & "','" & txtdireccion.Text & "','" & txtciudad.Text & "','" & txtedad.Text & "') "
            cmd.Parameters.AddWithValue("@nif_empleado", txtnif.Text)
            cmd.Parameters.AddWithValue("@nombre", txtnombre.Text)
            cmd.Parameters.AddWithValue("@direccion", txtdireccion.Text)
            cmd.Parameters.AddWithValue("@ciudad", txtciudad.Text)
            cmd.Parameters.AddWithValue("@edad", txtedad.Text)
            cmd.ExecuteNonQuery()
            Dim fila As Integer
            If fila > 0 Then
                MessageBox.Show("Sus Datos han sido guardados correctamente", "Guardar datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            mostrardatos()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar()
        mostrardatos()
    End Sub
    Sub mostrardatos()
        Dim Dt As New DataTable
        Dim Da As New SqlDataAdapter("select * from empleado", con)
        Dim d As New DataSet
        Da.Fill(d)
        dgvista.DataSource = d.Tables(0)
        dgvista.Columns("nif_empleado").HeaderText = "Nif"
        dgvista.Columns("nombre").HeaderText = "Nombre"
        dgvista.Columns("direccion").HeaderText = "Dirección"
        dgvista.Columns("ciudad").HeaderText = "Ciudad"
        dgvista.Columns("edad").HeaderText = "Edad"
    End Sub

    Private Sub cmdactualizar_Click(sender As Object, e As EventArgs) Handles cmdactualizar.Click
        Try
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandText = " update empleado set nombre='" & txtnombre.Text & "',direccion='" & txtdireccion.Text & "',ciudad='" & txtciudad.Text & "',edad=" & txtedad.Text & "where  nif_empleado='" & txtnif.Text & "'"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Datos guardados")
            mostrardatos()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdeliminar_Click(sender As Object, e As EventArgs) Handles cmdeliminar.Click
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "delete from empleado where nif_empleado= '" & txtnif.Text & "'"
        cmd.ExecuteNonQuery()
        MessageBox.Show("Datos eliminados")
        mostrardatos()
    End Sub

    Private Sub cmdlimpiar_Click(sender As Object, e As EventArgs) Handles cmdlimpiar.Click
        txtnif.Clear()
        txtnombre.Clear()
        txtciudad.Clear()
        txtdireccion.Clear()
        txtedad.Clear()


    End Sub

    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        Me.Close()
    End Sub

    Private Sub dgvista_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvista.RowHeaderMouseClick
        If dgvista.Rows.Count > 0 Then


            If dgvista.SelectedRows.Count > 0 Then
                txtnif.Text = dgvista.SelectedRows(0).Cells("nif_empleado").Value
                txtnombre.Text = dgvista.SelectedRows(0).Cells("nombre").Value
                txtciudad.Text = dgvista.SelectedRows(0).Cells("ciudad").Value
                txtdireccion.Text = dgvista.SelectedRows(0).Cells("direccion").Value
                txtedad.Text = dgvista.SelectedRows(0).Cells("edad").Value

            End If
        End If
    End Sub
End Class
