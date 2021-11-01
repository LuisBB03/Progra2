Module Module1
    Public Etapa(12) As Integer
    Public Equipo(12) As String
    Public Recorrido(12) As Integer
    Public Tiempo(12) As Integer
    Public Nacionalidad(12) As String
    Public pena(12) As Integer
    Public redu(12) As Integer
    Public total(12) As Integer

    Public penalizacion
    Public reduccion
    Public tiempo_total


    Public fila As Byte = 0
    Public I As Byte





    Sub Mostrar_vectores()

        Form1.DataGridView1.Rows.Clear()
        For I = 0 To 12
          
            If (Etapa(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Str(Etapa(I)), Equipo(I), Str(Recorrido(I)), Str(Tiempo(I)), Nacionalidad(I), pena(I), redu(I), total(I))

            Else

                Exit For
            End If
        Next I

    End Sub

    Sub limpiar_entradas()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.ComboBox1.Text = ""
        Form1.ComboBox2.Text = ""
        Form1.TextBox1.Focus()

    End Sub

    Sub limpiar_estadisticas()
        
        Form1.TextBox4.Clear()
        Form1.TextBox5.Clear()
        Form1.TextBox6.Clear()
       
    End Sub

    Sub limpiar_vectores()

        Form1.DataGridView1.Rows.Clear()
        fila = 0
        For I = 0 To 11
            Etapa(I) = Nothing
            Equipo(I) = Nothing
            Recorrido(I) = Nothing
            Tiempo(I) = Nothing
            Nacionalidad(I) = Nothing
            pena(I) = Nothing
            redu(I) = Nothing
            total(I) = Nothing
        Next I

    End Sub
End Module
