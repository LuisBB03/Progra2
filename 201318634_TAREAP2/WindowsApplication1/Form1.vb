Imports System.Math
Public Class Form1

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        Else
            Limpiar_entradas()
        End If

    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        Limpiar_entradas()
    End Sub

    Private Sub CheckEf_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEf.CheckedChanged
        If CheckEf.Checked = True Then
            TextBox4.Enabled = True
        Else
            TextBox4.Enabled = False
            TextBox4.Text = ""
        End If
    End Sub
    Private Sub CheckTar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckTar.CheckedChanged
        If CheckTar.Checked = True Then
            TextBox5.Enabled = True
        Else
            TextBox5.Enabled = False
            TextBox5.Text = ""
        End If
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        limpiar()

    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If indice < 6 Then

            placa(indice) = TextBox2.Text
            marca(indice) = ComboBox1.SelectedText
            dalquiler(indice) = Val(TextBox3.Text)
            pagoparcial(indice) = calcularparcial()
            descuento(indice) = calcularparcial() * calculardescuento()
            recargo(indice) = calcularparcial() * calcularercargo()
            total(indice) = pagoparcial(indice) + recargo(indice) - descuento(indice)

            If (CheckEf.Checked = True And CheckTar.Checked = True) And (Val(TextBox4.Text) + Val(TextBox5.Text) = "100") Then
                calculo_desc = 0
                calculo_recargo = 0
            ElseIf (Val(TextBox4.Text) + Val(TextBox5.Text) < "100") Then
                MsgBox("error en suma de porcentajes")

            End If
            mostrar()


            indice = indice + 1

        End If

        If (indice = 6) Then
            MsgBox("Límite de 6 clientes alcanzado")
        End If


    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub


    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
