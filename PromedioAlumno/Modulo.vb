Public Class Modulo

    Private Sub Modulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PuntoNETDataSet2.modulos' Puede moverla o quitarla según sea necesario.
        Me.ModulosTableAdapter1.Fill(Me.PuntoNETDataSet2.modulos)

    End Sub


    Private Sub TxtCodigoModulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodigoModulo.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Ingrese Numeros", MsgBoxStyle.Exclamation)
            TxtCodigoModulo.Focus()
        End If
    End Sub

    Private Sub PromedioAlumnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PromedioAlumnoToolStripMenuItem.Click
        PromedioDeNotas.Show()
        Me.Hide()
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles BtnInsert.Click

        If TxtCodigoModulo.Text = "" Then
            MsgBox("Ingresese Codigo Modulo que desea ingresar", MsgBoxStyle.Critical)
            TxtCodigoModulo.Focus()
        ElseIf TxtNombreModulo.Text = "" Then
            MsgBox("Ingresese Nombre Modulo que desea ingresar", MsgBoxStyle.Critical)
            TxtNombreModulo.Focus()
        Else

            Me.ModulosTableAdapter.InsertarRegistro(TxtCodigoModulo.Text, TxtNombreModulo.Text)
            MsgBox("Registro ingresado", MsgBoxStyle.Information)
            Me.ModulosTableAdapter1.Fill(Me.PuntoNETDataSet2.modulos)

        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If TxtCodigoModulo.Text = "" Then
            MsgBox("Ingresese Codigo Modulo que desea eliminar", MsgBoxStyle.Critical)
            TxtCodigoModulo.Focus()
        ElseIf TxtCodigoModulo.Text = (Me.ModulosTableAdapter1.BuscarModulo2(PuntoNETDataSet2.modulos, TxtCodigoModulo.Text) = False) Then
            MsgBox("Registro no encontrado", MsgBoxStyle.Critical)
            TxtCodigoModulo.Focus()
        Else
            Me.ModulosTableAdapter.BorrarModulo(TxtCodigoModulo.Text)
            MsgBox("Registro eliminado", MsgBoxStyle.Information)
            Me.ModulosTableAdapter1.Fill(Me.PuntoNETDataSet2.modulos)

        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If TxtCodigoModulo.Text = "" Then
            MsgBox("Ingresese Codigo Modulo que desea modificar", MsgBoxStyle.Critical)
            TxtCodigoModulo.Focus()
        ElseIf TxtCodigoModulo.Text = (Me.ModulosTableAdapter1.BuscarModulo2(PuntoNETDataSet2.modulos, TxtCodigoModulo.Text) = False) Then
            MsgBox("Registro no encontrado", MsgBoxStyle.Critical)
            TxtCodigoModulo.Focus()
        Else
            Me.ModulosTableAdapter.ModificarRegistro(TxtNombreModulo.Text, TxtCodigoModulo.Text)
            MsgBox("Registro Modificado", MsgBoxStyle.Information)
            Me.ModulosTableAdapter1.Fill(Me.PuntoNETDataSet2.modulos)
        End If
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If TxtCodigoModulo.Text = "" Then
            MsgBox("Ingresese Codigo Modulo que desea buscar", MsgBoxStyle.Critical)
            TxtCodigoModulo.Focus()

        ElseIf TxtCodigoModulo.Text = (Me.ModulosTableAdapter1.BuscarModulo2(PuntoNETDataSet2.modulos, TxtCodigoModulo.Text) = False) Then
            MsgBox("Registro no encontrado", MsgBoxStyle.Critical)
            TxtCodigoModulo.Focus()
        Else
            MsgBox("Registro encontrado", MsgBoxStyle.Information)
            Me.ModulosTableAdapter1.BuscarModulo2(PuntoNETDataSet2.modulos, TxtCodigoModulo.Text)

        End If
    End Sub

    Private Sub ToolStripBtnGuardar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnGuardar.Click
        If TxtCodigoModulo.Text = "" Then
            MsgBox("Ingresese Codigo Modulo que desea ingresar", MsgBoxStyle.Critical)
            TxtCodigoModulo.Focus()
        ElseIf TxtNombreModulo.Text = "" Then
            MsgBox("Ingresese Nombre Modulo que desea ingresar", MsgBoxStyle.Critical)
            TxtNombreModulo.Focus()
        Else

            Me.ModulosTableAdapter.InsertarRegistro(TxtCodigoModulo.Text, TxtNombreModulo.Text)
            MsgBox("Registro ingresado", MsgBoxStyle.Information)
            Me.ModulosTableAdapter1.Fill(Me.PuntoNETDataSet2.modulos)

        End If
    End Sub

    Private Sub ToolStripBtnBuscar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnBuscar.Click
        If TxtCodigoModulo.Text = "" Then
            MsgBox("Ingresese Codigo Modulo que desea buscar", MsgBoxStyle.Critical)
            TxtCodigoModulo.Focus()
        ElseIf TxtCodigoModulo.Text = (Me.ModulosTableAdapter1.BuscarModulo2(PuntoNETDataSet2.modulos, TxtCodigoModulo.Text) = False) Then
            MsgBox("Registro no encontrado", MsgBoxStyle.Critical)
            TxtCodigoModulo.Focus()

        Else
            MsgBox("Registro encontrado", MsgBoxStyle.Information)
            Me.ModulosTableAdapter1.BuscarModulo2(PuntoNETDataSet2.modulos, TxtCodigoModulo.Text)

        End If
    End Sub

    Private Sub ToolStripBtnModificar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnModificar.Click
        If TxtCodigoModulo.Text = "" Then
            MsgBox("Ingresese Codigo Modulo que desea modificar", MsgBoxStyle.Critical)
            TxtCodigoModulo.Focus()

        ElseIf TxtCodigoModulo.Text = (Me.ModulosTableAdapter1.BuscarModulo2(PuntoNETDataSet2.modulos, TxtCodigoModulo.Text) = False) Then
            MsgBox("Registro no encontrado", MsgBoxStyle.Critical)
            TxtCodigoModulo.Focus()

        Else
            Me.ModulosTableAdapter.ModificarRegistro(TxtNombreModulo.Text, TxtCodigoModulo.Text)
            MsgBox("Registro Modificado", MsgBoxStyle.Information)
            Me.ModulosTableAdapter1.Fill(Me.PuntoNETDataSet2.modulos)
        End If
    End Sub

    Private Sub ToolStripBtnEliminar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnEliminar.Click
        If TxtCodigoModulo.Text = "" Then
            MsgBox("Ingresese Codigo Modulo que desea eliminar", MsgBoxStyle.Critical)
            TxtCodigoModulo.Focus()
        ElseIf TxtCodigoModulo.Text = (Me.ModulosTableAdapter1.BuscarModulo2(PuntoNETDataSet2.modulos, TxtCodigoModulo.Text) = False) Then
            MsgBox("Registro no encontrado", MsgBoxStyle.Critical)
            TxtCodigoModulo.Focus()
        Else
            Me.ModulosTableAdapter.BorrarModulo(TxtCodigoModulo.Text)
            MsgBox("Registro eliminado", MsgBoxStyle.Information)
            Me.ModulosTableAdapter1.Fill(Me.PuntoNETDataSet2.modulos)
        End If
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("Realmente desea salir", "Salir del programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = (DialogResult.Yes) Then
            Me.Close()
        End If
    End Sub
End Class