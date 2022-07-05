'
' Created by SharpDevelop.
' User: User
' Date: 25/05/2022
' Time: 10:43
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class frmOperaciones
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.label1 = New System.Windows.Forms.Label()
		Me.tbxN1 = New System.Windows.Forms.TextBox()
		Me.tbxN2 = New System.Windows.Forms.TextBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.btnResolver = New System.Windows.Forms.Button()
		Me.label4 = New System.Windows.Forms.Label()
		Me.lbResultado = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.label7 = New System.Windows.Forms.Label()
		Me.label8 = New System.Windows.Forms.Label()
		Me.btnDivision = New System.Windows.Forms.Button()
		Me.lbDivision = New System.Windows.Forms.Label()
		Me.label10 = New System.Windows.Forms.Label()
		Me.label11 = New System.Windows.Forms.Label()
		Me.label12 = New System.Windows.Forms.Label()
		Me.tbxN4 = New System.Windows.Forms.TextBox()
		Me.tbxN3 = New System.Windows.Forms.TextBox()
		Me.lbPotencia = New System.Windows.Forms.Label()
		Me.label14 = New System.Windows.Forms.Label()
		Me.btnPotencia = New System.Windows.Forms.Button()
		Me.label15 = New System.Windows.Forms.Label()
		Me.label16 = New System.Windows.Forms.Label()
		Me.tbxExponente = New System.Windows.Forms.TextBox()
		Me.tbxBase = New System.Windows.Forms.TextBox()
		Me.lbRaiz = New System.Windows.Forms.Label()
		Me.label18 = New System.Windows.Forms.Label()
		Me.btnRaiz = New System.Windows.Forms.Button()
		Me.label20 = New System.Windows.Forms.Label()
		Me.tbxRaiz = New System.Windows.Forms.TextBox()
		Me.lbFactores = New System.Windows.Forms.Label()
		Me.label22 = New System.Windows.Forms.Label()
		Me.btnFactores = New System.Windows.Forms.Button()
		Me.label24 = New System.Windows.Forms.Label()
		Me.tbxFactor = New System.Windows.Forms.TextBox()
		Me.lbPrimo = New System.Windows.Forms.Label()
		Me.label13 = New System.Windows.Forms.Label()
		Me.btnPrimo = New System.Windows.Forms.Button()
		Me.label21 = New System.Windows.Forms.Label()
		Me.tbxPrimo = New System.Windows.Forms.TextBox()
		Me.label23 = New System.Windows.Forms.Label()
		Me.SuspendLayout
		'
		'label1
		'
		Me.label1.BackColor = System.Drawing.SystemColors.GrayText
		Me.label1.Font = New System.Drawing.Font("Raleway Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		Me.label1.Location = New System.Drawing.Point(34, 32)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(324, 26)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Multiplicación"
		'
		'tbxN1
		'
		Me.tbxN1.Location = New System.Drawing.Point(148, 72)
		Me.tbxN1.Name = "tbxN1"
		Me.tbxN1.Size = New System.Drawing.Size(210, 20)
		Me.tbxN1.TabIndex = 1
		'
		'tbxN2
		'
		Me.tbxN2.Location = New System.Drawing.Point(148, 111)
		Me.tbxN2.Name = "tbxN2"
		Me.tbxN2.Size = New System.Drawing.Size(210, 20)
		Me.tbxN2.TabIndex = 2
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(34, 72)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(100, 23)
		Me.label2.TabIndex = 3
		Me.label2.Text = "Número 1"
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(34, 108)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(100, 23)
		Me.label3.TabIndex = 4
		Me.label3.Text = "Número 2"
		'
		'btnResolver
		'
		Me.btnResolver.Location = New System.Drawing.Point(148, 193)
		Me.btnResolver.Name = "btnResolver"
		Me.btnResolver.Size = New System.Drawing.Size(80, 23)
		Me.btnResolver.TabIndex = 5
		Me.btnResolver.Text = "Obtener"
		Me.btnResolver.UseVisualStyleBackColor = true
		AddHandler Me.btnResolver.Click, AddressOf Me.BtnResolverClick
		'
		'label4
		'
		Me.label4.Location = New System.Drawing.Point(34, 152)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(100, 23)
		Me.label4.TabIndex = 7
		Me.label4.Text = "Resultado"
		'
		'lbResultado
		'
		Me.lbResultado.Location = New System.Drawing.Point(148, 152)
		Me.lbResultado.Name = "lbResultado"
		Me.lbResultado.Size = New System.Drawing.Size(100, 23)
		Me.lbResultado.TabIndex = 8
		Me.lbResultado.Text = "0"
		'
		'label5
		'
		Me.label5.BackColor = System.Drawing.SystemColors.GrayText
		Me.label5.Font = New System.Drawing.Font("Raleway Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		Me.label5.Location = New System.Drawing.Point(401, 32)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(324, 26)
		Me.label5.TabIndex = 9
		Me.label5.Text = "Potenciación"
		'
		'label6
		'
		Me.label6.BackColor = System.Drawing.SystemColors.GrayText
		Me.label6.Font = New System.Drawing.Font("Raleway Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		Me.label6.Location = New System.Drawing.Point(401, 238)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(324, 26)
		Me.label6.TabIndex = 10
		Me.label6.Text = "Raíz cuadrada"
		'
		'label7
		'
		Me.label7.BackColor = System.Drawing.SystemColors.GrayText
		Me.label7.Font = New System.Drawing.Font("Raleway Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		Me.label7.Location = New System.Drawing.Point(777, 32)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(324, 26)
		Me.label7.TabIndex = 11
		Me.label7.Text = "Factores"
		'
		'label8
		'
		Me.label8.BackColor = System.Drawing.SystemColors.GrayText
		Me.label8.Font = New System.Drawing.Font("Raleway Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		Me.label8.Location = New System.Drawing.Point(34, 238)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(324, 26)
		Me.label8.TabIndex = 12
		Me.label8.Text = "División"
		'
		'btnDivision
		'
		Me.btnDivision.Location = New System.Drawing.Point(148, 400)
		Me.btnDivision.Name = "btnDivision"
		Me.btnDivision.Size = New System.Drawing.Size(80, 23)
		Me.btnDivision.TabIndex = 14
		Me.btnDivision.Text = "Obtener"
		Me.btnDivision.UseVisualStyleBackColor = true
		AddHandler Me.btnDivision.Click, AddressOf Me.BtnDivisionClick
		'
		'lbDivision
		'
		Me.lbDivision.Location = New System.Drawing.Point(148, 364)
		Me.lbDivision.Name = "lbDivision"
		Me.lbDivision.Size = New System.Drawing.Size(210, 23)
		Me.lbDivision.TabIndex = 22
		Me.lbDivision.Text = "0"
		'
		'label10
		'
		Me.label10.Location = New System.Drawing.Point(34, 364)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(100, 23)
		Me.label10.TabIndex = 21
		Me.label10.Text = "Resultado"
		'
		'label11
		'
		Me.label11.Location = New System.Drawing.Point(34, 320)
		Me.label11.Name = "label11"
		Me.label11.Size = New System.Drawing.Size(100, 23)
		Me.label11.TabIndex = 20
		Me.label11.Text = "Número 2"
		'
		'label12
		'
		Me.label12.Location = New System.Drawing.Point(34, 284)
		Me.label12.Name = "label12"
		Me.label12.Size = New System.Drawing.Size(100, 23)
		Me.label12.TabIndex = 19
		Me.label12.Text = "Número 1"
		'
		'tbxN4
		'
		Me.tbxN4.Location = New System.Drawing.Point(148, 323)
		Me.tbxN4.Name = "tbxN4"
		Me.tbxN4.Size = New System.Drawing.Size(210, 20)
		Me.tbxN4.TabIndex = 18
		'
		'tbxN3
		'
		Me.tbxN3.Location = New System.Drawing.Point(148, 284)
		Me.tbxN3.Name = "tbxN3"
		Me.tbxN3.Size = New System.Drawing.Size(210, 20)
		Me.tbxN3.TabIndex = 17
		'
		'lbPotencia
		'
		Me.lbPotencia.Location = New System.Drawing.Point(515, 149)
		Me.lbPotencia.Name = "lbPotencia"
		Me.lbPotencia.Size = New System.Drawing.Size(210, 23)
		Me.lbPotencia.TabIndex = 29
		Me.lbPotencia.Text = "0"
		'
		'label14
		'
		Me.label14.Location = New System.Drawing.Point(401, 149)
		Me.label14.Name = "label14"
		Me.label14.Size = New System.Drawing.Size(100, 23)
		Me.label14.TabIndex = 28
		Me.label14.Text = "Resultado"
		'
		'btnPotencia
		'
		Me.btnPotencia.Location = New System.Drawing.Point(515, 187)
		Me.btnPotencia.Name = "btnPotencia"
		Me.btnPotencia.Size = New System.Drawing.Size(80, 23)
		Me.btnPotencia.TabIndex = 27
		Me.btnPotencia.Text = "Obtener"
		Me.btnPotencia.UseVisualStyleBackColor = true
		AddHandler Me.btnPotencia.Click, AddressOf Me.BtnPotenciaClick
		'
		'label15
		'
		Me.label15.Location = New System.Drawing.Point(401, 105)
		Me.label15.Name = "label15"
		Me.label15.Size = New System.Drawing.Size(100, 23)
		Me.label15.TabIndex = 26
		Me.label15.Text = "Exponente"
		'
		'label16
		'
		Me.label16.Location = New System.Drawing.Point(401, 69)
		Me.label16.Name = "label16"
		Me.label16.Size = New System.Drawing.Size(100, 23)
		Me.label16.TabIndex = 25
		Me.label16.Text = "Base"
		'
		'tbxExponente
		'
		Me.tbxExponente.Location = New System.Drawing.Point(515, 108)
		Me.tbxExponente.Name = "tbxExponente"
		Me.tbxExponente.Size = New System.Drawing.Size(210, 20)
		Me.tbxExponente.TabIndex = 24
		'
		'tbxBase
		'
		Me.tbxBase.Location = New System.Drawing.Point(515, 69)
		Me.tbxBase.Name = "tbxBase"
		Me.tbxBase.Size = New System.Drawing.Size(210, 20)
		Me.tbxBase.TabIndex = 23
		'
		'lbRaiz
		'
		Me.lbRaiz.Location = New System.Drawing.Point(515, 361)
		Me.lbRaiz.Name = "lbRaiz"
		Me.lbRaiz.Size = New System.Drawing.Size(210, 23)
		Me.lbRaiz.TabIndex = 36
		Me.lbRaiz.Text = "0"
		'
		'label18
		'
		Me.label18.Location = New System.Drawing.Point(401, 361)
		Me.label18.Name = "label18"
		Me.label18.Size = New System.Drawing.Size(100, 23)
		Me.label18.TabIndex = 35
		Me.label18.Text = "Resultado"
		'
		'btnRaiz
		'
		Me.btnRaiz.Location = New System.Drawing.Point(515, 400)
		Me.btnRaiz.Name = "btnRaiz"
		Me.btnRaiz.Size = New System.Drawing.Size(80, 23)
		Me.btnRaiz.TabIndex = 34
		Me.btnRaiz.Text = "Obtener"
		Me.btnRaiz.UseVisualStyleBackColor = true
		AddHandler Me.btnRaiz.Click, AddressOf Me.BtnRaizClick
		'
		'label20
		'
		Me.label20.Location = New System.Drawing.Point(401, 281)
		Me.label20.Name = "label20"
		Me.label20.Size = New System.Drawing.Size(100, 23)
		Me.label20.TabIndex = 32
		Me.label20.Text = "Numero"
		'
		'tbxRaiz
		'
		Me.tbxRaiz.Location = New System.Drawing.Point(515, 281)
		Me.tbxRaiz.Name = "tbxRaiz"
		Me.tbxRaiz.Size = New System.Drawing.Size(210, 20)
		Me.tbxRaiz.TabIndex = 30
		'
		'lbFactores
		'
		Me.lbFactores.Location = New System.Drawing.Point(891, 111)
		Me.lbFactores.Name = "lbFactores"
		Me.lbFactores.Size = New System.Drawing.Size(210, 23)
		Me.lbFactores.TabIndex = 43
		Me.lbFactores.Text = "0"
		'
		'label22
		'
		Me.label22.Location = New System.Drawing.Point(777, 111)
		Me.label22.Name = "label22"
		Me.label22.Size = New System.Drawing.Size(100, 23)
		Me.label22.TabIndex = 42
		Me.label22.Text = "Factores"
		'
		'btnFactores
		'
		Me.btnFactores.Location = New System.Drawing.Point(891, 187)
		Me.btnFactores.Name = "btnFactores"
		Me.btnFactores.Size = New System.Drawing.Size(80, 23)
		Me.btnFactores.TabIndex = 41
		Me.btnFactores.Text = "Obtener"
		Me.btnFactores.UseVisualStyleBackColor = true
		AddHandler Me.btnFactores.Click, AddressOf Me.BtnFactoresClick
		'
		'label24
		'
		Me.label24.Location = New System.Drawing.Point(777, 66)
		Me.label24.Name = "label24"
		Me.label24.Size = New System.Drawing.Size(100, 23)
		Me.label24.TabIndex = 39
		Me.label24.Text = "Valor"
		'
		'tbxFactor
		'
		Me.tbxFactor.Location = New System.Drawing.Point(891, 66)
		Me.tbxFactor.Name = "tbxFactor"
		Me.tbxFactor.Size = New System.Drawing.Size(210, 20)
		Me.tbxFactor.TabIndex = 37
		'
		'lbPrimo
		'
		Me.lbPrimo.Location = New System.Drawing.Point(891, 317)
		Me.lbPrimo.Name = "lbPrimo"
		Me.lbPrimo.Size = New System.Drawing.Size(210, 23)
		Me.lbPrimo.TabIndex = 49
		Me.lbPrimo.Text = "0"
		'
		'label13
		'
		Me.label13.Location = New System.Drawing.Point(777, 317)
		Me.label13.Name = "label13"
		Me.label13.Size = New System.Drawing.Size(100, 23)
		Me.label13.TabIndex = 48
		Me.label13.Text = "Resultado"
		'
		'btnPrimo
		'
		Me.btnPrimo.Location = New System.Drawing.Point(891, 400)
		Me.btnPrimo.Name = "btnPrimo"
		Me.btnPrimo.Size = New System.Drawing.Size(80, 23)
		Me.btnPrimo.TabIndex = 47
		Me.btnPrimo.Text = "Obtener"
		Me.btnPrimo.UseVisualStyleBackColor = true
		AddHandler Me.btnPrimo.Click, AddressOf Me.BtnPrimoClick
		'
		'label21
		'
		Me.label21.Location = New System.Drawing.Point(777, 272)
		Me.label21.Name = "label21"
		Me.label21.Size = New System.Drawing.Size(100, 23)
		Me.label21.TabIndex = 46
		Me.label21.Text = "Valor"
		'
		'tbxPrimo
		'
		Me.tbxPrimo.Location = New System.Drawing.Point(891, 272)
		Me.tbxPrimo.Name = "tbxPrimo"
		Me.tbxPrimo.Size = New System.Drawing.Size(210, 20)
		Me.tbxPrimo.TabIndex = 45
		'
		'label23
		'
		Me.label23.BackColor = System.Drawing.SystemColors.GrayText
		Me.label23.Font = New System.Drawing.Font("Raleway Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label23.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		Me.label23.Location = New System.Drawing.Point(777, 238)
		Me.label23.Name = "label23"
		Me.label23.Size = New System.Drawing.Size(324, 26)
		Me.label23.TabIndex = 44
		Me.label23.Text = "Es primo?"
		'
		'frmOperaciones
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1114, 487)
		Me.Controls.Add(Me.lbPrimo)
		Me.Controls.Add(Me.label13)
		Me.Controls.Add(Me.btnPrimo)
		Me.Controls.Add(Me.label21)
		Me.Controls.Add(Me.tbxPrimo)
		Me.Controls.Add(Me.label23)
		Me.Controls.Add(Me.lbFactores)
		Me.Controls.Add(Me.label22)
		Me.Controls.Add(Me.btnFactores)
		Me.Controls.Add(Me.label24)
		Me.Controls.Add(Me.tbxFactor)
		Me.Controls.Add(Me.lbRaiz)
		Me.Controls.Add(Me.label18)
		Me.Controls.Add(Me.btnRaiz)
		Me.Controls.Add(Me.label20)
		Me.Controls.Add(Me.tbxRaiz)
		Me.Controls.Add(Me.lbPotencia)
		Me.Controls.Add(Me.label14)
		Me.Controls.Add(Me.btnPotencia)
		Me.Controls.Add(Me.label15)
		Me.Controls.Add(Me.label16)
		Me.Controls.Add(Me.tbxExponente)
		Me.Controls.Add(Me.tbxBase)
		Me.Controls.Add(Me.lbDivision)
		Me.Controls.Add(Me.label10)
		Me.Controls.Add(Me.label11)
		Me.Controls.Add(Me.label12)
		Me.Controls.Add(Me.tbxN4)
		Me.Controls.Add(Me.tbxN3)
		Me.Controls.Add(Me.btnDivision)
		Me.Controls.Add(Me.label8)
		Me.Controls.Add(Me.label7)
		Me.Controls.Add(Me.label6)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.lbResultado)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.btnResolver)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.tbxN2)
		Me.Controls.Add(Me.tbxN1)
		Me.Controls.Add(Me.label1)
		Me.Name = "frmOperaciones"
		Me.Text = "frmOperaciones"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private label23 As System.Windows.Forms.Label
	Private tbxPrimo As System.Windows.Forms.TextBox
	Private label21 As System.Windows.Forms.Label
	Private btnPrimo As System.Windows.Forms.Button
	Private label13 As System.Windows.Forms.Label
	Private lbPrimo As System.Windows.Forms.Label
	Private tbxFactor As System.Windows.Forms.TextBox
	Private label24 As System.Windows.Forms.Label
	Private btnFactores As System.Windows.Forms.Button
	Private label22 As System.Windows.Forms.Label
	Private lbFactores As System.Windows.Forms.Label
	Private tbxRaiz As System.Windows.Forms.TextBox
	Private label20 As System.Windows.Forms.Label
	Private btnRaiz As System.Windows.Forms.Button
	Private label18 As System.Windows.Forms.Label
	Private lbRaiz As System.Windows.Forms.Label
	Private tbxBase As System.Windows.Forms.TextBox
	Private tbxExponente As System.Windows.Forms.TextBox
	Private label16 As System.Windows.Forms.Label
	Private label15 As System.Windows.Forms.Label
	Private btnPotencia As System.Windows.Forms.Button
	Private label14 As System.Windows.Forms.Label
	Private lbPotencia As System.Windows.Forms.Label
	Private tbxN3 As System.Windows.Forms.TextBox
	Private tbxN4 As System.Windows.Forms.TextBox
	Private label12 As System.Windows.Forms.Label
	Private label11 As System.Windows.Forms.Label
	Private label10 As System.Windows.Forms.Label
	Private lbDivision As System.Windows.Forms.Label
	Private btnDivision As System.Windows.Forms.Button
	Private label8 As System.Windows.Forms.Label
	Private label7 As System.Windows.Forms.Label
	Private label6 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private lbResultado As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private btnResolver As System.Windows.Forms.Button
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private tbxN2 As System.Windows.Forms.TextBox
	Private tbxN1 As System.Windows.Forms.TextBox
	Private label1 As System.Windows.Forms.Label
End Class
