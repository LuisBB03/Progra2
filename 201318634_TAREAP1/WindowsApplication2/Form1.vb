Imports System.Math
Public Class Form1



    Private Sub lino_CheckedChanged(sender As Object, e As EventArgs) Handles lino.CheckedChanged
        If lino.Checked = True Then
            txtlino.Enabled = True
        Else
            txtlino.Enabled = False
            txthilo.Text = "0"
        End If



    End Sub

    Private Sub algodon_CheckedChanged(sender As Object, e As EventArgs) Handles algodon.CheckedChanged
        If algodon.Checked = True Then
            txtalgodon.Enabled = True
        Else
            txtalgodon.Enabled = False
            txtalgodon.Text = "0"
        End If
    End Sub

    Private Sub seda_CheckedChanged(sender As Object, e As EventArgs) Handles seda.CheckedChanged
        If seda.Checked = True Then
            txtseda.Enabled = True
        Else
            txtseda.Enabled = False
            txtseda.Text = "0"
        End If
    End Sub

    Private Sub hilocrudo_CheckedChanged(sender As Object, e As EventArgs) Handles hilocrudo.CheckedChanged
        If hilocrudo.Checked = True Then
            txthilo.Enabled = True
        Else
            txthilo.Enabled = False
            txthilo.Text = "0"
        End If
    End Sub

    Private Sub calcular_Click(sender As Object, e As EventArgs) Handles calcular.Click

        sumaYardas = Val(txtlino.Text) + Val(txtalgodon.Text) + Val(txtseda.Text) + Val(txthilo.Text)

        If seda.Checked = False And
            hilocrudo.Checked = False And
            lino.Checked = False And
            algodon.Checked = False Then
            MsgBox("No ha seleccionado tipo de material", vbCritical)





        ElseIf imperial.Checked = True Then
            If sumaYardas = matimperial Then
                preciocosto = precioImperial + Val(txtlino.Text) * plino + Val(txtalgodon.Text) * palgodon + Val(txtseda.Text) * pseda + Val(txthilo.Text) * philocrudo
                preciototal = preciocosto + preciocosto * 0.65
            Else
                MsgBox("Error en la cantidad de Yardas", vbCritical)
            End If

        ElseIf matrimonial.Checked = True Then
            If sumaYardas = matmatrinomial Then
                preciocosto = precioMatrimonial + Val(txtlino.Text) * plino + Val(txtalgodon.Text) * palgodon + Val(txtseda.Text) * pseda + Val(txthilo.Text) * philocrudo
                preciototal = preciocosto + preciocosto * 0.65

            Else
                MsgBox("Error en la cantidad de Yardas", vbCritical)
            End If

        ElseIf queen.Checked = True Then
            If sumaYardas = matqueen Then
                preciocosto = precioQueen + Val(txtlino.Text) * plino + Val(txtalgodon.Text) * palgodon + Val(txtseda.Text) * pseda + Val(txthilo.Text) * philocrudo
                preciototal = preciocosto + preciocosto * 0.65

            Else
                MsgBox("Error en la cantidad de Yardas", vbCritical)
            End If

        ElseIf king.Checked = True Then
            If sumaYardas = matking Then
                preciocosto = precioKing + Val(txtlino.Text) * plino + Val(txtalgodon.Text) * palgodon + Val(txtseda.Text) * pseda + Val(txthilo.Text) * philocrudo
                preciototal = preciocosto + preciocosto * 0.65

            Else
                MsgBox("Error en la cantidad de Yardas", vbCritical)
            End If

        End If

        lblpreciocosto.Text = Str(Round(preciocosto, 2))

        lblpreciototal.Text = Str(Round(preciototal, 2))



    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        If (MsgBox("¿Esta seguro de salir?", vbQuestion + vbYesNo) = vbYes) Then
            Me.Close()

        End If

    End Sub



    Private Sub lblpreciototal_Click(sender As Object, e As EventArgs) Handles lblpreciototal.Click

    End Sub

    Private Sub lblpreciocosto_Click(sender As Object, e As EventArgs) Handles lblpreciocosto.Click

    End Sub

    Private Sub imperial_CheckedChanged(sender As Object, e As EventArgs) Handles imperial.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        imperial.Checked = False
        matrimonial.Checked = False
        queen.Checked = False
        king.Checked = False
        lino.Checked = False
        algodon.Checked = False
        seda.Checked = False
        hilocrudo.Checked = False
        lblpreciocosto.Text = "0.00"
        lblpreciototal.Text = "0.00"




    End Sub
End Class
