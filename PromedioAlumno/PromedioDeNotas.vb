Public Class PromedioDeNotas
    Private Sub TxtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombre.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
            MsgBox("Ingrese solo letras", MsgBoxStyle.Exclamation)
        End If


    End Sub

    Private Sub TxtNota1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNota1.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Ingrese Numeros", MsgBoxStyle.Exclamation)

        End If



    End Sub

    Private Sub TxtNota2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNota2.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Ingrese Numeros", MsgBoxStyle.Exclamation)

        End If
    End Sub

    Private Sub TxtNota3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNota3.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Ingrese Numeros", MsgBoxStyle.Exclamation)

        End If
    End Sub

    Private Sub BtnPromedio_Click(sender As Object, e As EventArgs) Handles BtnPromedio.Click
        If TxtNota1.Text = "" And TxtNota2.Text = "" And TxtNota3.Text = "" Then
            MsgBox("ingrese notas", MsgBoxStyle.Critical)
            TxtNota1.Focus()
        Else
            Dim nota1 As Double = TxtNota1.Text
            Dim nota2 As Double = TxtNota2.Text
            Dim nota3 As Double = TxtNota3.Text
            Dim suma As Double = nota1 + nota2 + nota3
            Dim promedio As Double = suma / 3


            TxtPromedio.Text = Math.Round(Convert.ToDouble(promedio), 1)
            MsgBox("El promedio de notas de: " + TxtNombre.Text + " es: " + TxtPromedio.Text, MsgBoxStyle.Information)

            If (promedio < 4) Then
                MsgBox("Alumno Reprobado :( " + vbCrLf +
                       "Debe realizar examen", MsgBoxStyle.Critical)

            Else
                MsgBox("Alumno Aprobado :) ", MsgBoxStyle.Exclamation)

            End If
        End If

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtNota1.Text = (" ")
        TxtNota2.Text = (" ")
        TxtNota3.Text = (" ")
        TxtNombre.Text = (" ")
        TxtPromedio.Text = (" ")
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("Realmente desea Salir",
                                 "Salir del Programa",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question)
        If (opcion = DialogResult.Yes) Then
            Me.Close()
        End If

    End Sub


    Private Sub TxtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelefono.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Ingresa solo numeros", MsgBoxStyle.Information)
        End If

        If TxtTelefono.TextLength = 9 Then
            MsgBox("Solo puede ingresar nueve numeros", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub MantenedorMosulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenedorMosulosToolStripMenuItem.Click
        Modulo.Show()
        Me.Hide()

    End Sub
End Class
