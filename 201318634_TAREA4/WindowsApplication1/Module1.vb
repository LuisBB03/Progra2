
Module Module1
    Public Const Residencial1 As Double = 0.99
    Public Const Residencial2 As Double = 1.2
    Public Const Residencial3 As Double = 3.0

    Public Const Industrial1 As Double = 1.99
    Public Const Industrial2 As Double = 2.2
    Public Const Industrial3 As Double = 4.0

    Public Indice As Byte = 0

    Public total_pagoini As Double
    Public total_pagopar As Double
    Public total_pagopar1 As Double
    Public total_pagofin As Double
    Public total_pagofin1 As Double
    Public total_conmora As Double
    Public total_recargo As Double
    Public total_tarifa As Double

    Public pagomora As Double = 0.02

    Public descuento_social = 0.2
    Public descuento_nosocial = 0.1

    Public Cliente(11) As String
    Public Servicio(11) As String
    Public tarifa(11) As String
    Public saldoanterior(11) As Double
    Public Pagoinicial(11) As Double
    Public mora(11) As String
    Public PagoM(11) As Double
    Public pagoparcial(11) As Double
    Public descuento(11) As String
    Public Pagototal(11) As Double


    Sub Limpiar_entradas()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()
        Form1.TextBox1.Focus()

    End Sub

    Sub mostrar()
        Form1.ListBox1.Items.Add(Cliente(Indice))
        Form1.ListBox2.Items.Add(Servicio(Indice))
        Form1.ListBox3.Items.Add(tarifa(Indice))
        Form1.ListBox4.Items.Add(saldoanterior(Indice))
        Form1.ListBox5.Items.Add(Pagoinicial(Indice))
        Form1.ListBox6.Items.Add(mora(Indice))
        Form1.ListBox7.Items.Add(PagoM(Indice))
        Form1.ListBox8.Items.Add(pagoparcial(Indice))
        Form1.ListBox9.Items.Add(descuento(Indice))
        Form1.ListBox10.Items.Add(Pagototal(Indice))

    End Sub

    Sub Limpiar()
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        Form1.ListBox7.Items.Clear()
        Form1.ListBox8.Items.Clear()
        Form1.ListBox9.Items.Clear()
        Form1.ListBox10.Items.Clear()

        Indice = 0


    End Sub
End Module
