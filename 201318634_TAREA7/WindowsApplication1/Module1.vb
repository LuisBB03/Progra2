Module Module1
    Public EDAD(7) As Integer
    Public GENERO(7) As String
    Public CODIGO(7) As String
    Public MONTO(7) As Integer
    Public Taller(7) As String
    Public DEDUCIBLE(7) As Integer
    Public FILA As Byte = 0


    Sub limpiar_entradas()

        Form1.TextBox1.Clear()
        Form1.TextBox3.Clear()
        Form1.ComboBox1.Text = ""
        Form1.ComboBox2.Text = ""
        Form1.ComboBox3.Text = ""

    End Sub

    Sub limpiar_vectores()

        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
    End Sub

    Sub limpiar_estadisticas()

        Form1.TextBox4.Clear()
        Form1.TextBox5.Clear()
        Form1.TextBox6.Clear()
        Form1.TextBox7.Clear()
        Form1.TextBox8.Clear()
        Form1.TextBox9.Clear()
    End Sub

End Module

