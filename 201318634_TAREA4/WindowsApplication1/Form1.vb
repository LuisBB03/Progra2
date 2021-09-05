Imports System.Math
Public Class Form1

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        If (MsgBox("¿Esta seguro de salir?", vbQuestion + vbYesNo) = vbYes) Then
            Me.Close()
        Else

        End If
    End Sub


    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        Else
            Limpiar_entradas()
        End If

    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (TextBox1.Text = "") Then
            MsgBox("Ingrese un nombre", vbQuestion)

            Limpiar_entradas()

            Exit Sub

            TextBox1.Focus()
        End If

        If (TextBox2.Text = "") Then
            MsgBox("Ingrese un NIT", vbQuestion)

            Limpiar_entradas()

            Exit Sub

            TextBox1.Focus()
        End If

        If (TextBox3.Text = "") Then
            MsgBox("Ingrese un Saldo anterior", vbQuestion)

            Limpiar_entradas()

            Exit Sub

            TextBox1.Focus()
        End If

        If (TextBox4.Text = "") Then
            MsgBox("Ingrese Consumo en Kilowatts", vbQuestion)

            Limpiar_entradas()

            Exit Sub

            TextBox1.Focus()
        End If

        If (Indice < 11) Then

            Cliente(Indice) = TextBox1.Text
            Servicio(Indice) = ComServicio.Text
            tarifa(Indice) = ComTarifa.Text
            saldoanterior(Indice) = TextBox3.Text

            If Str(ComServicio.Text = "Residencial") Then

                Select Case Val(TextBox4.Text)
                    Case 1 To 100
                        total_pagoini = Val(TextBox4.Text) * Residencial1

                    Case 101 To 300
                        total_pagoini = Val(TextBox4.Text) * Residencial2

                    Case Is >= 301
                        total_pagoini = Val(TextBox4.Text) * Residencial3

                End Select

                Pagoinicial(Indice) = Round(total_pagoini, 2)


            End If

            If Str(ComServicio.Text = "Industrial") Then

                Select Case Val(TextBox4.Text)
                    Case 1 To 100
                        total_pagoini = Val(TextBox4.Text) * Industrial1

                    Case 101 To 300
                        total_pagoini = Val(TextBox4.Text) * Industrial2

                    Case Is >= 301
                        total_pagoini = Val(TextBox4.Text) * Industrial3

                End Select

                Pagoinicial(Indice) = Round(total_pagoini, 2)


            End If

            If Val(TextBox3.Text) > 0 Then
                total_recargo = (Val(TextBox3.Text) * pagomora)
                mora(Indice) = (pagomora * 100)

            ElseIf Val(TextBox3.Text) <= 0 Then
                mora(Indice) = "no aplica mora"

            End If

            total_conmora = Val(TextBox3.Text) + total_recargo
            mora(Indice) = Round(total_conmora, 2)



            Select Case ComTarifa.Text
                Case "Social"

                    total_pagopar = (Val(TextBox3.Text) + total_pagoini) + total_recargo
                    pagoparcial(Indice) = total_pagopar

                    total_tarifa = total_pagopar * descuento_social
                    descuento(Indice) = (descuento_social * 100)

                    total_pagofin = total_pagopar - total_tarifa
                    Pagototal(Indice) = Round(total_pagofin, 2)

                Case "No Social"

                    total_tarifa = total_pagoini - (total_pagoini * descuento_nosocial)
                    descuento(Indice) = (descuento_nosocial * 100)

                    Pagoinicial(Indice) = Round(total_tarifa, 2)

                    total_pagopar = total_tarifa + total_conmora
                    pagoparcial(Indice) = Round(total_pagopar, 2)

                    total_pagofin = total_pagopar

                    Pagototal(Indice) = Round(total_pagofin, 2)



            End Select

            mostrar()

            Indice = Indice + 1

        End If

        If (Indice = 11) Then
            MsgBox("Límite de 11 clientes alcanzado")
        End If

        Limpiar_entradas()
    End Sub


    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        Limpiar()
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        Limpiar_entradas()
    End Sub
End Class
