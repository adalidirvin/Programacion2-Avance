'
' Created by SharpDevelop.
' User: User
' Date: 25/05/2022
' Time: 8:53
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.lbEntrada = New System.Windows.Forms.Label()
		Me.tbxEntrada = New System.Windows.Forms.TextBox()
		Me.lbRespuesta = New System.Windows.Forms.Label()
		Me.pbxFoto = New System.Windows.Forms.PictureBox()
		Me.btnOperaciones = New System.Windows.Forms.Button()
		Me.btnArea = New System.Windows.Forms.Button()
		Me.btnSaludar = New System.Windows.Forms.Button()
		CType(Me.pbxFoto,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'lbEntrada
		'
		Me.lbEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbEntrada.Location = New System.Drawing.Point(329, 47)
		Me.lbEntrada.Name = "lbEntrada"
		Me.lbEntrada.Size = New System.Drawing.Size(187, 23)
		Me.lbEntrada.TabIndex = 0
		Me.lbEntrada.Text = "Mi nombre es: "
		'
		'tbxEntrada
		'
		Me.tbxEntrada.Location = New System.Drawing.Point(329, 94)
		Me.tbxEntrada.Name = "tbxEntrada"
		Me.tbxEntrada.Size = New System.Drawing.Size(212, 20)
		Me.tbxEntrada.TabIndex = 1
		'
		'lbRespuesta
		'
		Me.lbRespuesta.Location = New System.Drawing.Point(12, 325)
		Me.lbRespuesta.Name = "lbRespuesta"
		Me.lbRespuesta.Size = New System.Drawing.Size(529, 23)
		Me.lbRespuesta.TabIndex = 2
		'
		'pbxFoto
		'
		Me.pbxFoto.Image = CType(resources.GetObject("pbxFoto.Image"),System.Drawing.Image)
		Me.pbxFoto.Location = New System.Drawing.Point(12, 12)
		Me.pbxFoto.Name = "pbxFoto"
		Me.pbxFoto.Size = New System.Drawing.Size(300, 300)
		Me.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pbxFoto.TabIndex = 3
		Me.pbxFoto.TabStop = false
		'
		'btnOperaciones
		'
		Me.btnOperaciones.Location = New System.Drawing.Point(409, 199)
		Me.btnOperaciones.Name = "btnOperaciones"
		Me.btnOperaciones.Size = New System.Drawing.Size(75, 23)
		Me.btnOperaciones.TabIndex = 5
		Me.btnOperaciones.Text = "Operaciones"
		Me.btnOperaciones.UseVisualStyleBackColor = true
		AddHandler Me.btnOperaciones.Click, AddressOf Me.BtnOperacionesClick
		'
		'btnArea
		'
		Me.btnArea.Location = New System.Drawing.Point(409, 252)
		Me.btnArea.Name = "btnArea"
		Me.btnArea.Size = New System.Drawing.Size(75, 23)
		Me.btnArea.TabIndex = 6
		Me.btnArea.Text = "Areas"
		Me.btnArea.UseVisualStyleBackColor = true
		AddHandler Me.btnArea.Click, AddressOf Me.BtnAreaClick
		'
		'btnSaludar
		'
		Me.btnSaludar.Location = New System.Drawing.Point(409, 146)
		Me.btnSaludar.Name = "btnSaludar"
		Me.btnSaludar.Size = New System.Drawing.Size(75, 23)
		Me.btnSaludar.TabIndex = 4
		Me.btnSaludar.Text = "Saludar"
		Me.btnSaludar.UseVisualStyleBackColor = true
		AddHandler Me.btnSaludar.Click, AddressOf Me.BtnSaludarClick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(555, 359)
		Me.Controls.Add(Me.btnArea)
		Me.Controls.Add(Me.btnOperaciones)
		Me.Controls.Add(Me.btnSaludar)
		Me.Controls.Add(Me.pbxFoto)
		Me.Controls.Add(Me.lbRespuesta)
		Me.Controls.Add(Me.tbxEntrada)
		Me.Controls.Add(Me.lbEntrada)
		Me.Name = "MainForm"
		Me.Text = "EJERCICIOS EN VISUAL BASIC"
		CType(Me.pbxFoto,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private btnArea As System.Windows.Forms.Button
	Private btnOperaciones As System.Windows.Forms.Button
	Private btnSaludar As System.Windows.Forms.Button
	Private pbxFoto As System.Windows.Forms.PictureBox
	Private tbxEntrada As System.Windows.Forms.TextBox
	Private lbRespuesta As System.Windows.Forms.Label
	Private lbEntrada As System.Windows.Forms.Label
End Class
