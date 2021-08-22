<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.king = New System.Windows.Forms.RadioButton()
        Me.queen = New System.Windows.Forms.RadioButton()
        Me.matrimonial = New System.Windows.Forms.RadioButton()
        Me.imperial = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txthilo = New System.Windows.Forms.TextBox()
        Me.txtseda = New System.Windows.Forms.TextBox()
        Me.txtalgodon = New System.Windows.Forms.TextBox()
        Me.txtlino = New System.Windows.Forms.TextBox()
        Me.hilocrudo = New System.Windows.Forms.CheckBox()
        Me.seda = New System.Windows.Forms.CheckBox()
        Me.algodon = New System.Windows.Forms.CheckBox()
        Me.lino = New System.Windows.Forms.CheckBox()
        Me.calcular = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblpreciocosto = New System.Windows.Forms.Label()
        Me.salir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblpreciototal = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.king)
        Me.GroupBox1.Controls.Add(Me.queen)
        Me.GroupBox1.Controls.Add(Me.matrimonial)
        Me.GroupBox1.Controls.Add(Me.imperial)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(103, 126)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TAMAÑO"
        '
        'king
        '
        Me.king.AutoSize = True
        Me.king.Location = New System.Drawing.Point(7, 91)
        Me.king.Name = "king"
        Me.king.Size = New System.Drawing.Size(46, 17)
        Me.king.TabIndex = 3
        Me.king.TabStop = True
        Me.king.Text = "King"
        Me.king.UseVisualStyleBackColor = True
        '
        'queen
        '
        Me.queen.AutoSize = True
        Me.queen.Location = New System.Drawing.Point(7, 68)
        Me.queen.Name = "queen"
        Me.queen.Size = New System.Drawing.Size(57, 17)
        Me.queen.TabIndex = 2
        Me.queen.TabStop = True
        Me.queen.Text = "Queen"
        Me.queen.UseVisualStyleBackColor = True
        '
        'matrimonial
        '
        Me.matrimonial.AutoSize = True
        Me.matrimonial.Location = New System.Drawing.Point(7, 43)
        Me.matrimonial.Name = "matrimonial"
        Me.matrimonial.Size = New System.Drawing.Size(78, 17)
        Me.matrimonial.TabIndex = 1
        Me.matrimonial.TabStop = True
        Me.matrimonial.Text = "Matrimonial"
        Me.matrimonial.UseVisualStyleBackColor = True
        '
        'imperial
        '
        Me.imperial.AutoSize = True
        Me.imperial.Location = New System.Drawing.Point(7, 20)
        Me.imperial.Name = "imperial"
        Me.imperial.Size = New System.Drawing.Size(61, 17)
        Me.imperial.TabIndex = 0
        Me.imperial.TabStop = True
        Me.imperial.Text = "Imperial"
        Me.imperial.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txthilo)
        Me.GroupBox2.Controls.Add(Me.txtseda)
        Me.GroupBox2.Controls.Add(Me.txtalgodon)
        Me.GroupBox2.Controls.Add(Me.txtlino)
        Me.GroupBox2.Controls.Add(Me.hilocrudo)
        Me.GroupBox2.Controls.Add(Me.seda)
        Me.GroupBox2.Controls.Add(Me.algodon)
        Me.GroupBox2.Controls.Add(Me.lino)
        Me.GroupBox2.Location = New System.Drawing.Point(150, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 126)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MATERIALES"
        '
        'txthilo
        '
        Me.txthilo.Enabled = False
        Me.txthilo.Location = New System.Drawing.Point(94, 89)
        Me.txthilo.Name = "txthilo"
        Me.txthilo.Size = New System.Drawing.Size(75, 20)
        Me.txthilo.TabIndex = 7
        Me.txthilo.Text = "0"
        '
        'txtseda
        '
        Me.txtseda.Enabled = False
        Me.txtseda.Location = New System.Drawing.Point(94, 65)
        Me.txtseda.Name = "txtseda"
        Me.txtseda.Size = New System.Drawing.Size(75, 20)
        Me.txtseda.TabIndex = 6
        Me.txtseda.Text = "0"
        '
        'txtalgodon
        '
        Me.txtalgodon.Enabled = False
        Me.txtalgodon.Location = New System.Drawing.Point(94, 41)
        Me.txtalgodon.Name = "txtalgodon"
        Me.txtalgodon.Size = New System.Drawing.Size(75, 20)
        Me.txtalgodon.TabIndex = 5
        Me.txtalgodon.Text = "0"
        '
        'txtlino
        '
        Me.txtlino.Enabled = False
        Me.txtlino.Location = New System.Drawing.Point(94, 15)
        Me.txtlino.Name = "txtlino"
        Me.txtlino.Size = New System.Drawing.Size(75, 20)
        Me.txtlino.TabIndex = 4
        Me.txtlino.Text = "0"
        '
        'hilocrudo
        '
        Me.hilocrudo.AutoSize = True
        Me.hilocrudo.Location = New System.Drawing.Point(6, 91)
        Me.hilocrudo.Name = "hilocrudo"
        Me.hilocrudo.Size = New System.Drawing.Size(75, 17)
        Me.hilocrudo.TabIndex = 3
        Me.hilocrudo.Text = "Hilo Crudo"
        Me.hilocrudo.UseVisualStyleBackColor = True
        '
        'seda
        '
        Me.seda.AutoSize = True
        Me.seda.Location = New System.Drawing.Point(7, 68)
        Me.seda.Name = "seda"
        Me.seda.Size = New System.Drawing.Size(51, 17)
        Me.seda.TabIndex = 2
        Me.seda.Text = "Seda"
        Me.seda.UseVisualStyleBackColor = True
        '
        'algodon
        '
        Me.algodon.AutoSize = True
        Me.algodon.Location = New System.Drawing.Point(7, 44)
        Me.algodon.Name = "algodon"
        Me.algodon.Size = New System.Drawing.Size(65, 17)
        Me.algodon.TabIndex = 1
        Me.algodon.Text = "Algodón"
        Me.algodon.UseVisualStyleBackColor = True
        '
        'lino
        '
        Me.lino.AutoSize = True
        Me.lino.Location = New System.Drawing.Point(7, 20)
        Me.lino.Name = "lino"
        Me.lino.Size = New System.Drawing.Size(46, 17)
        Me.lino.TabIndex = 0
        Me.lino.Text = "Lino"
        Me.lino.UseVisualStyleBackColor = True
        '
        'calcular
        '
        Me.calcular.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.calcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calcular.ForeColor = System.Drawing.SystemColors.ControlText
        Me.calcular.Location = New System.Drawing.Point(39, 256)
        Me.calcular.Name = "calcular"
        Me.calcular.Size = New System.Drawing.Size(85, 34)
        Me.calcular.TabIndex = 2
        Me.calcular.Text = "Calcular"
        Me.calcular.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Precio de Costo Q:"
        '
        'lblpreciocosto
        '
        Me.lblpreciocosto.AutoSize = True
        Me.lblpreciocosto.Font = New System.Drawing.Font("Impact", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpreciocosto.Location = New System.Drawing.Point(178, 155)
        Me.lblpreciocosto.Name = "lblpreciocosto"
        Me.lblpreciocosto.Size = New System.Drawing.Size(36, 19)
        Me.lblpreciocosto.TabIndex = 4
        Me.lblpreciocosto.Text = "0.00"
        '
        'salir
        '
        Me.salir.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salir.Location = New System.Drawing.Point(256, 256)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(85, 34)
        Me.salir.TabIndex = 5
        Me.salir.Text = "Salir"
        Me.salir.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Precio Total Q:"
        '
        'lblpreciototal
        '
        Me.lblpreciototal.AutoSize = True
        Me.lblpreciototal.Font = New System.Drawing.Font("Impact", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpreciototal.Location = New System.Drawing.Point(178, 182)
        Me.lblpreciototal.Name = "lblpreciototal"
        Me.lblpreciototal.Size = New System.Drawing.Size(36, 19)
        Me.lblpreciototal.TabIndex = 7
        Me.lblpreciototal.Text = "0.00"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(146, 256)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 34)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(382, 318)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblpreciototal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.lblpreciocosto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.calcular)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "CUBRECAMAS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents king As System.Windows.Forms.RadioButton
    Friend WithEvents queen As System.Windows.Forms.RadioButton
    Friend WithEvents matrimonial As System.Windows.Forms.RadioButton
    Friend WithEvents imperial As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents hilocrudo As System.Windows.Forms.CheckBox
    Friend WithEvents seda As System.Windows.Forms.CheckBox
    Friend WithEvents algodon As System.Windows.Forms.CheckBox
    Friend WithEvents lino As System.Windows.Forms.CheckBox
    Friend WithEvents txthilo As System.Windows.Forms.TextBox
    Friend WithEvents txtseda As System.Windows.Forms.TextBox
    Friend WithEvents txtalgodon As System.Windows.Forms.TextBox
    Friend WithEvents txtlino As System.Windows.Forms.TextBox
    Friend WithEvents calcular As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblpreciocosto As System.Windows.Forms.Label
    Friend WithEvents salir As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblpreciototal As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
