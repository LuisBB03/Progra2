Public Class Form1

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        
        End If
    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        
        If indice < 9 Then
            vfuncion(indice) = ComboBox2.SelectedItem
            vcine(indice) = ComboBox1.SelectedItem
            subtotal_a_pagar(indice) = calcularSubtotal(vfuncion(indice), vcine(indice))
            vdescuento1(indice) = subtotal_a_pagar(indice) * calculoDescuento1(vfuncion(indice), vcine(indice))
            vdescuento2(indice) = 0
            total(indice) = subtotal_a_pagar(indice) - vdescuento1(indice) - vdescuento2(indice)


            ListBox2.Items.Add(vfuncion(indice))
            ListBox1.Items.Add(vcine(indice))
            ListBox3.Items.Add(subtotal_a_pagar(indice))
            ListBox4.Items.Add(vdescuento1(indice))
            ListBox5.Items.Add(vdescuento2(indice))
            ListBox6.Items.Add(total(indice))

        End If

        If indice >= 9 Then
            MsgBox("Límite de 9 clientes alcanzado")
        End If

        limpiar_entradas()


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        limpiar()
    End Sub
End Class
