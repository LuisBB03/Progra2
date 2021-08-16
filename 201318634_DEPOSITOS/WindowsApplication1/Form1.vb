Public Class Form1

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click

        If RadioButton3.Checked Then
            Select Case saldo_nuevo
                Case 1.01 To 1000.99
                    interes = 1.5 / 100
                Case 1001 To 5000.99
                    interes = 2.5 / 100
                Case 5001 To 15000.99
                    interes = 7.5 / 100
                Case Is >= 15001
                    interes = 10 / 100
            End Select

            saldo_nuevo = Val(montoCP.Text) + Val(montoCOB.Text) + Val(montoEF.Text) + Val(saldoAnterior.Text)
            saldo_nuevo = saldo_nuevo + saldo_nuevo * interes
            saldoNuevo.Text = Str(saldo_nuevo)

        End If


        If RadioButton2.Checked = True Then
            Select Case Val(saldoAnterior.Text)
                Case 1.01 To 10000.99
                    interes = 2.5 / 100
                Case 10001 To 15000.99
                    interes = 3 / 100
                Case Is >= 15001
                    interes = 4.5 / 100
            End Select

            saldo_nuevo = Val(montoCP.Text) + Val(montoCOB.Text) + Val(montoEF.Text) + Val(saldoAnterior.Text) * interes
            saldoNuevo.Text = Str(saldo_nuevo)
        End If

        If RadioButton1.Checked = True Then
            saldo_nuevo = Val(montoCP.Text) + Val(montoCOB.Text) + Val(montoEF.Text) + Val(saldoAnterior.Text)

            saldoNuevo.Text = Str(saldo_nuevo)
        End If

        txtinteres.Text = Str(interes * 100) + "%"

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If RadioButton1.Checked = True Then
            tipoSeleccionado = True

        ElseIf RadioButton2.Checked = True Then
            tipoSeleccionado = True

        ElseIf RadioButton3.Checked = True Then
            tipoSeleccionado = True

        End If

        If tipoSeleccionado = True Then
            If CheckBox1.Checked = True Then
                montoCP.Enabled = True
            End If

            If CheckBox1.Checked = False Then
                montoCP.Enabled = False


            End If
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If RadioButton1.Checked = True Then
            tipoSeleccionado = True

        ElseIf RadioButton2.Checked = True Then
            tipoSeleccionado = True

        ElseIf RadioButton3.Checked = True Then
            tipoSeleccionado = True

        End If

        If tipoSeleccionado = True Then
            If CheckBox2.Checked = True Then
                montoCOB.Enabled = True
            End If

            If CheckBox2.Checked = False Then
                montoCOB.Enabled = False


            End If
        End If

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If RadioButton1.Checked = True Then
            tipoSeleccionado = True

        ElseIf RadioButton2.Checked = True Then
            tipoSeleccionado = True

        ElseIf RadioButton3.Checked = True Then
            tipoSeleccionado = True

        End If

        If tipoSeleccionado = True Then
            If CheckBox3.Checked = True Then
                montoEF.Enabled = True
            End If

            If CheckBox3.Checked = False Then
                montoEF.Enabled = False
            End If
        End If

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        
        CheckBox2.Checked = False
        CheckBox1.Checked = False
        CheckBox3.Checked = False
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        montoCOB.Clear()
        montoCP.Clear()
        montoEF.Clear()
        saldoAnterior.Clear()
        txtinteres.Text = ""
        saldoNuevo.Text = ""








    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (MsgBox("¿Esta seguro de salir?", vbQuestion + vbYesNo) = vbYes) Then
            Me.Close()
        Else

        End If
    End Sub
End Class
