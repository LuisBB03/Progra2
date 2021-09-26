Imports System.Math
Module Module1
    Public indice = 0

    Public placa(6) As String
    Public marca(6) As String
    Public dalquiler(6) As Double
    Public pagoparcial(6) As Double
    Public descuento(6) As Double
    Public recargo(6) As Double
    Public total(6) As Double

    Public calculo_parcial As Double = 0
    Public calculo_desc As Double = 0
    Public calculo_recargo As Double = 0
    Public calculo_total As Double = 0



    Function calcularparcial() As Double

        If Str(Form1.ComboBox1.Text = "Honda") Then
            calculo_parcial = Round(Val(Form1.TextBox3.Text) * 250, 2)
        ElseIf Str(Form1.ComboBox1.Text = "Mercedes Benz") Then
            calculo_parcial = Round(Val(Form1.TextBox3.Text) * 450, 2)
        ElseIf Str(Form1.ComboBox1.Text = "Toyota") Then
            calculo_parcial = Round(Val(Form1.TextBox3.Text) * 325, 2)
        ElseIf Str(Form1.ComboBox1.Text = "Mazda") Then
            calculo_parcial = Round(Val(Form1.TextBox3.Text) * 300, 2)

            End If

            Return calculo_parcial

    End Function
    Function calculardescuento() As Double

        If Form1.CheckEf.Checked = True And Val(Form1.TextBox4.Text < "100") Then
            'calculo_desc = 0
            MsgBox("Error en el pocentaje ingresado")
        ElseIf Val(Form1.TextBox4.Text = "100") Then
            calculo_desc = 0.05
            'MsgBox("Error en el pocentaje ingresado")

        End If
        Return calculo_desc
    End Function
    Function calcularercargo() As Double

        If Form1.CheckTar.Checked = True And Val(Form1.TextBox5.Text < "100") Then
            ' calculo_recargo = 2.5
            MsgBox("Error en el pocentaje ingresado")
        ElseIf Val(Form1.TextBox5.Text = "100") Then
            'MsgBox("Error en el pocentaje ingresado")
            calculo_recargo = 2.5
        End If
        Return calculo_recargo
    End Function


    Sub Limpiar_entradas()
        Form1.TextBox1.Clear() 
        Form1.TextBox3.Clear()
        Form1.CheckEf.Checked = False
        Form1.CheckTar.Checked = False
        Form1.ComboBox1.Text = ""
        Form1.TextBox4.Enabled = False
        Form1.TextBox5.Enabled = False

    End Sub
    Sub mostrar()


        Form1.ListBox1.Items.Add(placa(indice))
        Form1.ListBox2.Items.Add(marca(indice))
        Form1.ListBox3.Items.Add(dalquiler(indice))
        Form1.ListBox4.Items.Add(pagoparcial(indice))
        Form1.ListBox5.Items.Add(descuento(indice))
        Form1.ListBox6.Items.Add(recargo(indice))
        Form1.ListBox7.Items.Add(total(indice))




    End Sub
    Sub limpiar()

        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        Form1.ListBox7.Items.Clear()


        indice = 0
    End Sub
End Module
