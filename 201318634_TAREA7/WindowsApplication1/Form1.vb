Public Class Form1

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        limpiar_estadisticas()

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        limpiar_vectores()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        limpiar_entradas()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (FILA <= 6) Then
            EDAD(FILA) = Val(TextBox1.Text)
            GENERO(FILA) = ComboBox3.Text
            CODIGO(FILA) = ComboBox1.Text
            MONTO(FILA) = Val(TextBox3.Text)
            Taller(FILA) = ComboBox2.Text
            DEDUCIBLE(FILA) = Val(TextBox3.Text) * 0.06

            FILA = FILA + 1
        End If
        limpiar_entradas()
        If (FILA = 7) Then
            MsgBox("VECTORES LLENOS")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim X As Byte
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()

        For X = 0 To 6
            If EDAD(X) <> Nothing Then
                ListBox1.Items.Add(Str(EDAD(X)))
                ListBox2.Items.Add(GENERO(X))
                ListBox3.Items.Add(CODIGO(X))
                ListBox4.Items.Add(MONTO(X))
                ListBox5.Items.Add(Taller(X))
                ListBox6.Items.Add(DEDUCIBLE(X))

            Else
                Exit For
            End If
        Next X
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
       
    End Sub
End Class
