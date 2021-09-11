Module Module1
    Public vfuncion(8)
    Public vcine(8)
    Public subtotal_a_pagar(8)
    Public vdescuento1(8)
    Public vdescuento2(8)
    Public total(8)

    Public indice = 0

    Public calculo_subtotal As Double = 0
    Public calculo_desc1 As Double = 0
    Public calculo_desc2 As Double = 0


    Function calcularSubtotal(funcion As String, cine As String) As Double

        Select Case cine
            Case "A"
                Select Case funcion
                    Case "1"
                        calculo_subtotal = 30
                    Case "2"
                        calculo_subtotal = 35
                    Case Else
                        calculo_subtotal = 40
                End Select
            Case "B"
                Select Case funcion
                    Case "1"
                        calculo_subtotal = 24
                    Case "2"
                        calculo_subtotal = 34
                    Case Else
                        calculo_subtotal = 44
                End Select
            Case "C"
                Select Case funcion
                    Case "1"
                        calculo_subtotal = 35
                    Case "2"
                        calculo_subtotal = 40
                    Case Else
                        calculo_subtotal = 50
                End Select


        End Select
        Return calculo_subtotal

    End Function

    Function calculoDescuento1(funcion As String, cine As String) As Double
        If (funcion = "3" Or funcion = "4") And (cine = "C" Or cine = "B") Then
            calculoDescuento1 = 0.055

        ElseIf (funcion = "1") And (cine = "C" Or cine = "B") Then
            calculoDescuento1 = 0.03

        ElseIf (funcion = "2") And (cine = "A") Then
            calculoDescuento1 = 0.015
        End If
        Return calculoDescuento1

    End Function

    Sub limpiar_entradas()
        Form1.ComboBox1.Text = ""
        Form1.ComboBox2.Text = ""




    End Sub

    Sub limpiar()

        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
      

        indice = 0
    End Sub
End Module
