Imports System.Math


Public Class Form1

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub OrdenarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarToolStripMenuItem.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Close()
        End If

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        Mostrar_vectores()

    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        If (fila <= 11) Then
            Etapa(fila) = Val(TextBox1.Text)
            Equipo(fila) = ComboBox1.Text
            Recorrido(fila) = Val(TextBox2.Text)
            Tiempo(fila) = Val(TextBox3.Text)
            Nacionalidad(fila) = ComboBox2.Text


            Select Case Val(TextBox3.Text)
                Case 0 To 84.99
                    penalizacion = 0
                    Select Case ComboBox1.Text
                        Case "Movistar"
                            reduccion = 15
                        Case "Pro Team"
                            reduccion = 10
                    End Select
                Case 85 To 119.99
                    penalizacion = 0
                Case 121 To 139.99
                    penalizacion = 30
                Case 141 To 159.99
                    penalizacion = 40
                Case Is >= 161
                    penalizacion = 50
            End Select

            pena(fila) = Round(penalizacion, 2)

            redu(fila) = Round(reduccion, 2)

            tiempo_total = Val(TextBox3.Text) + penalizacion - reduccion

            total(fila) = Round(tiempo_total, 2)
            fila = fila + 1
            limpiar_entradas()
        End If
        If (fila = 12) Then
            MsgBox("vectores llenos")
        End If
    End Sub

    Private Sub LimpiarEstadísticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEstadísticasToolStripMenuItem.Click
        limpiar_estadisticas()

    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiar_vectores()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        Etapa(fila) = Val(TextBox1.Text)
        Equipo(fila) = ComboBox1.Text
        Recorrido(fila) = Val(TextBox2.Text)
        Tiempo(fila) = Val(TextBox3.Text)
        Nacionalidad(fila) = ComboBox2.Text

        MsgBox("Registro actualizado correctamente en los vectores")

        fila = 12
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim existe As Boolean = True
        I = 0

        While (I <= 11) And (existe)

            If (Etapa(I) = Val(TextBox7.Text)) Then
                existe = False
            Else
                I = I + 1
            End If
        End While

        If (existe) Then
            MsgBox("Etapa no encontrada")
            TextBox7.Focus()
        Else
            MsgBox("Registro Encontrado exitosamente")

            TextBox1.Text = Etapa(I)
            ComboBox1.Text = Equipo(I)
            TextBox2.Text = Recorrido(I)
            TextBox3.Text = Tiempo(I)
            ComboBox2.Text = Nacionalidad(I)

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Str(Etapa(I)), Equipo(I), Str(Recorrido(I)), Str(Tiempo(I)), Nacionalidad(I), pena(I), redu(I), total(I))

            fila = I
        End If

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        
        Etapa(fila) = Nothing
        Equipo(fila) = Nothing
        Recorrido(fila) = Nothing
        Tiempo(fila) = Nothing
        Nacionalidad(fila) = Nothing

        For I = fila To 10

            Etapa(I) = Etapa(I + 1)
            Equipo(I) = Equipo(I + 1)
            Recorrido(I) = Recorrido(I + 1)
            Tiempo(I) = Tiempo(I + 1)
            Nacionalidad(I) = Nacionalidad(I + 1)
          
        Next I
        MsgBox("Registro Eliminado exitosamente")

        Etapa(I) = Nothing
        Equipo(I) = Nothing
        Recorrido(I) = Nothing
        Tiempo(I) = Nothing
        Nacionalidad(I) = Nothing

        fila = I
        limpiar_entradas()
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub EstadísticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadísticasToolStripMenuItem.Click
      
        Dim EST1 As Integer = 0
        Dim EST2 As Integer = 0
        Dim EST3 As Integer = 0

        Dim cantidad1 As Byte = 0
        Dim cantidad2 As Byte = 0
        Dim cantidad3 As Byte = 0

        For I = 0 To 11
            If (Etapa(I) <> Nothing) Then

                If (Nacionalidad(I) = "guatemalteco") And (Recorrido(I) > 45) Then
                    cantidad1 = cantidad1 + 1
                End If
                EST1 = EST1 + Val(DataGridView1.Rows(I).Cells(5).Value)

            Else
                Exit For
            End If

        Next I

        TextBox4.Text = EST1
       
    End Sub
End Class
