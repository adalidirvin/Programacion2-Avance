'
' Created by SharpDevelop.
' User: User
' Date: 15/06/2022
' Time: 9:51
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class Areas
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Areas))
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		Me.pictureBox2 = New System.Windows.Forms.PictureBox()
		Me.pictureBox3 = New System.Windows.Forms.PictureBox()
		Me.label5 = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.lbPerimetroR = New System.Windows.Forms.Label()
		Me.lb001 = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.label7 = New System.Windows.Forms.Label()
		Me.tbxAltura = New System.Windows.Forms.TextBox()
		Me.tbxBase = New System.Windows.Forms.TextBox()
		Me.lbAreaCirculo = New System.Windows.Forms.Label()
		Me.label9 = New System.Windows.Forms.Label()
		Me.label11 = New System.Windows.Forms.Label()
		Me.tbxRadio = New System.Windows.Forms.TextBox()
		Me.label12 = New System.Windows.Forms.Label()
		Me.label13 = New System.Windows.Forms.Label()
		Me.tbxAlturaT = New System.Windows.Forms.TextBox()
		Me.tbxBaseT = New System.Windows.Forms.TextBox()
		Me.lbPerimetroC = New System.Windows.Forms.Label()
		Me.label15 = New System.Windows.Forms.Label()
		Me.lbAreaR = New System.Windows.Forms.Label()
		Me.label17 = New System.Windows.Forms.Label()
		Me.lbAreaT = New System.Windows.Forms.Label()
		Me.label19 = New System.Windows.Forms.Label()
		Me.pbxCorrecto = New System.Windows.Forms.PictureBox()
		Me.gbxRectangulo = New System.Windows.Forms.GroupBox()
		Me.gbxCirculo = New System.Windows.Forms.GroupBox()
		Me.gbxT = New System.Windows.Forms.GroupBox()
		Me.gbxTrapecio = New System.Windows.Forms.GroupBox()
		Me.tbxAlturaTrapecio = New System.Windows.Forms.TextBox()
		Me.label20 = New System.Windows.Forms.Label()
		Me.pictureBox5 = New System.Windows.Forms.PictureBox()
		Me.label8 = New System.Windows.Forms.Label()
		Me.tbxAt = New System.Windows.Forms.TextBox()
		Me.tbxBt = New System.Windows.Forms.TextBox()
		Me.lbAreaTrapecio = New System.Windows.Forms.Label()
		Me.label14 = New System.Windows.Forms.Label()
		Me.label16 = New System.Windows.Forms.Label()
		Me.label18 = New System.Windows.Forms.Label()
		Me.mnPrincipal = New System.Windows.Forms.MenuStrip()
		Me.inicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.áreasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.rectánguloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.círculoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.triánguloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.elipseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.trapecioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.pentágonoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.hexágonoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.volúmenesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.esferaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.cuboToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.pirámideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ayudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.acercaDeMiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.tbxPass = New System.Windows.Forms.TextBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.btnActivar = New System.Windows.Forms.Button()
		Me.pbxError = New System.Windows.Forms.PictureBox()
		Me.gbxRomboide = New System.Windows.Forms.GroupBox()
		Me.tbxAlturaRomboide = New System.Windows.Forms.TextBox()
		Me.label10 = New System.Windows.Forms.Label()
		Me.pictureBox4 = New System.Windows.Forms.PictureBox()
		Me.label21 = New System.Windows.Forms.Label()
		Me.tbxARomboide = New System.Windows.Forms.TextBox()
		Me.lbAreaRomboide = New System.Windows.Forms.Label()
		Me.label23 = New System.Windows.Forms.Label()
		Me.label24 = New System.Windows.Forms.Label()
		Me.gbxHexagono = New System.Windows.Forms.GroupBox()
		Me.tbxAlturaHexagno = New System.Windows.Forms.TextBox()
		Me.label26 = New System.Windows.Forms.Label()
		Me.pictureBox6 = New System.Windows.Forms.PictureBox()
		Me.label27 = New System.Windows.Forms.Label()
		Me.tbxAHexagono = New System.Windows.Forms.TextBox()
		Me.lbAreaHexagono = New System.Windows.Forms.Label()
		Me.label29 = New System.Windows.Forms.Label()
		Me.label30 = New System.Windows.Forms.Label()
		Me.gbxPentagono = New System.Windows.Forms.GroupBox()
		Me.tbxAlturaPentagono = New System.Windows.Forms.TextBox()
		Me.label32 = New System.Windows.Forms.Label()
		Me.pictureBox7 = New System.Windows.Forms.PictureBox()
		Me.label33 = New System.Windows.Forms.Label()
		Me.tbxAPentagono = New System.Windows.Forms.TextBox()
		Me.lbAreaPentagono = New System.Windows.Forms.Label()
		Me.label35 = New System.Windows.Forms.Label()
		Me.label36 = New System.Windows.Forms.Label()
		Me.ttayuda = New System.Windows.Forms.ToolTip(Me.components)
		Me.tmHora = New System.Windows.Forms.Timer(Me.components)
		Me.lbHora = New System.Windows.Forms.Label()
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pictureBox3,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pbxCorrecto,System.ComponentModel.ISupportInitialize).BeginInit
		Me.gbxRectangulo.SuspendLayout
		Me.gbxCirculo.SuspendLayout
		Me.gbxT.SuspendLayout
		Me.gbxTrapecio.SuspendLayout
		CType(Me.pictureBox5,System.ComponentModel.ISupportInitialize).BeginInit
		Me.mnPrincipal.SuspendLayout
		CType(Me.pbxError,System.ComponentModel.ISupportInitialize).BeginInit
		Me.gbxRomboide.SuspendLayout
		CType(Me.pictureBox4,System.ComponentModel.ISupportInitialize).BeginInit
		Me.gbxHexagono.SuspendLayout
		CType(Me.pictureBox6,System.ComponentModel.ISupportInitialize).BeginInit
		Me.gbxPentagono.SuspendLayout
		CType(Me.pictureBox7,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'pictureBox1
		'
		Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"),System.Drawing.Image)
		Me.pictureBox1.Location = New System.Drawing.Point(6, 19)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(150, 150)
		Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pictureBox1.TabIndex = 0
		Me.pictureBox1.TabStop = false
		'
		'pictureBox2
		'
		Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"),System.Drawing.Image)
		Me.pictureBox2.Location = New System.Drawing.Point(6, 19)
		Me.pictureBox2.Name = "pictureBox2"
		Me.pictureBox2.Size = New System.Drawing.Size(150, 150)
		Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pictureBox2.TabIndex = 1
		Me.pictureBox2.TabStop = false
		'
		'pictureBox3
		'
		Me.pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"),System.Drawing.Image)
		Me.pictureBox3.Location = New System.Drawing.Point(6, 19)
		Me.pictureBox3.Name = "pictureBox3"
		Me.pictureBox3.Size = New System.Drawing.Size(150, 150)
		Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pictureBox3.TabIndex = 2
		Me.pictureBox3.TabStop = false
		'
		'label5
		'
		Me.label5.BackColor = System.Drawing.Color.MediumSeaGreen
		Me.label5.Font = New System.Drawing.Font("Raleway Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		Me.label5.Location = New System.Drawing.Point(106, 33)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(361, 35)
		Me.label5.TabIndex = 10
		Me.label5.Text = "ÁREAS DE FIGURAS GEOMÉTRICAS"
		Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label1
		'
		Me.label1.BackColor = System.Drawing.Color.MediumSeaGreen
		Me.label1.Font = New System.Drawing.Font("Raleway Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		Me.label1.Location = New System.Drawing.Point(179, 19)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(324, 26)
		Me.label1.TabIndex = 11
		Me.label1.Text = "Rectángulo"
		'
		'label2
		'
		Me.label2.BackColor = System.Drawing.Color.MediumSeaGreen
		Me.label2.Font = New System.Drawing.Font("Raleway Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		Me.label2.Location = New System.Drawing.Point(179, 19)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(324, 26)
		Me.label2.TabIndex = 12
		Me.label2.Text = "Circunferencia"
		'
		'label3
		'
		Me.label3.BackColor = System.Drawing.Color.MediumSeaGreen
		Me.label3.Font = New System.Drawing.Font("Raleway Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		Me.label3.Location = New System.Drawing.Point(179, 19)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(324, 26)
		Me.label3.TabIndex = 13
		Me.label3.Text = "Triángulo"
		'
		'lbPerimetroR
		'
		Me.lbPerimetroR.Location = New System.Drawing.Point(293, 136)
		Me.lbPerimetroR.Name = "lbPerimetroR"
		Me.lbPerimetroR.Size = New System.Drawing.Size(210, 23)
		Me.lbPerimetroR.TabIndex = 19
		Me.lbPerimetroR.Text = "0"
		'
		'lb001
		'
		Me.lb001.Location = New System.Drawing.Point(179, 136)
		Me.lb001.Name = "lb001"
		Me.lb001.Size = New System.Drawing.Size(100, 23)
		Me.lb001.TabIndex = 18
		Me.lb001.Text = "Perímetro"
		'
		'label6
		'
		Me.label6.Location = New System.Drawing.Point(179, 82)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(100, 23)
		Me.label6.TabIndex = 17
		Me.label6.Text = "Altura"
		'
		'label7
		'
		Me.label7.Location = New System.Drawing.Point(179, 56)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(100, 23)
		Me.label7.TabIndex = 16
		Me.label7.Text = "Base"
		'
		'tbxAltura
		'
		Me.tbxAltura.Location = New System.Drawing.Point(293, 81)
		Me.tbxAltura.Name = "tbxAltura"
		Me.tbxAltura.Size = New System.Drawing.Size(210, 20)
		Me.tbxAltura.TabIndex = 15
		Me.tbxAltura.Text = "0"
		AddHandler Me.tbxAltura.TextChanged, AddressOf Me.TbxAlturaTextChanged
		'
		'tbxBase
		'
		Me.tbxBase.Location = New System.Drawing.Point(293, 56)
		Me.tbxBase.Name = "tbxBase"
		Me.tbxBase.Size = New System.Drawing.Size(210, 20)
		Me.tbxBase.TabIndex = 14
		Me.tbxBase.Text = "0"
		AddHandler Me.tbxBase.TextChanged, AddressOf Me.TbxBaseTextChanged
		'
		'lbAreaCirculo
		'
		Me.lbAreaCirculo.Location = New System.Drawing.Point(293, 114)
		Me.lbAreaCirculo.Name = "lbAreaCirculo"
		Me.lbAreaCirculo.Size = New System.Drawing.Size(210, 23)
		Me.lbAreaCirculo.TabIndex = 25
		Me.lbAreaCirculo.Text = "0"
		'
		'label9
		'
		Me.label9.Location = New System.Drawing.Point(179, 114)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(100, 23)
		Me.label9.TabIndex = 24
		Me.label9.Text = "Área"
		'
		'label11
		'
		Me.label11.Location = New System.Drawing.Point(179, 61)
		Me.label11.Name = "label11"
		Me.label11.Size = New System.Drawing.Size(100, 23)
		Me.label11.TabIndex = 22
		Me.label11.Text = "Radio"
		'
		'tbxRadio
		'
		Me.tbxRadio.Location = New System.Drawing.Point(293, 61)
		Me.tbxRadio.Name = "tbxRadio"
		Me.tbxRadio.Size = New System.Drawing.Size(210, 20)
		Me.tbxRadio.TabIndex = 20
		Me.tbxRadio.Text = "0"
		AddHandler Me.tbxRadio.TextChanged, AddressOf Me.TbxRadioTextChanged
		'
		'label12
		'
		Me.label12.Location = New System.Drawing.Point(179, 84)
		Me.label12.Name = "label12"
		Me.label12.Size = New System.Drawing.Size(100, 23)
		Me.label12.TabIndex = 29
		Me.label12.Text = "Altura"
		'
		'label13
		'
		Me.label13.Location = New System.Drawing.Point(179, 58)
		Me.label13.Name = "label13"
		Me.label13.Size = New System.Drawing.Size(100, 23)
		Me.label13.TabIndex = 28
		Me.label13.Text = "Base"
		'
		'tbxAlturaT
		'
		Me.tbxAlturaT.Enabled = false
		Me.tbxAlturaT.Location = New System.Drawing.Point(293, 83)
		Me.tbxAlturaT.Name = "tbxAlturaT"
		Me.tbxAlturaT.Size = New System.Drawing.Size(210, 20)
		Me.tbxAlturaT.TabIndex = 27
		Me.tbxAlturaT.Text = "0"
		'
		'tbxBaseT
		'
		Me.tbxBaseT.Enabled = false
		Me.tbxBaseT.Location = New System.Drawing.Point(293, 58)
		Me.tbxBaseT.Name = "tbxBaseT"
		Me.tbxBaseT.Size = New System.Drawing.Size(210, 20)
		Me.tbxBaseT.TabIndex = 26
		Me.tbxBaseT.Text = "0"
		'
		'lbPerimetroC
		'
		Me.lbPerimetroC.Location = New System.Drawing.Point(293, 137)
		Me.lbPerimetroC.Name = "lbPerimetroC"
		Me.lbPerimetroC.Size = New System.Drawing.Size(210, 23)
		Me.lbPerimetroC.TabIndex = 33
		Me.lbPerimetroC.Text = "0"
		'
		'label15
		'
		Me.label15.Location = New System.Drawing.Point(179, 137)
		Me.label15.Name = "label15"
		Me.label15.Size = New System.Drawing.Size(100, 23)
		Me.label15.TabIndex = 32
		Me.label15.Text = "Perímetro"
		'
		'lbAreaR
		'
		Me.lbAreaR.Location = New System.Drawing.Point(293, 110)
		Me.lbAreaR.Name = "lbAreaR"
		Me.lbAreaR.Size = New System.Drawing.Size(210, 23)
		Me.lbAreaR.TabIndex = 35
		Me.lbAreaR.Text = "0"
		'
		'label17
		'
		Me.label17.Location = New System.Drawing.Point(179, 110)
		Me.label17.Name = "label17"
		Me.label17.Size = New System.Drawing.Size(100, 23)
		Me.label17.TabIndex = 34
		Me.label17.Text = "Área"
		'
		'lbAreaT
		'
		Me.lbAreaT.Location = New System.Drawing.Point(293, 124)
		Me.lbAreaT.Name = "lbAreaT"
		Me.lbAreaT.Size = New System.Drawing.Size(210, 23)
		Me.lbAreaT.TabIndex = 37
		Me.lbAreaT.Text = "0"
		'
		'label19
		'
		Me.label19.Location = New System.Drawing.Point(179, 124)
		Me.label19.Name = "label19"
		Me.label19.Size = New System.Drawing.Size(100, 23)
		Me.label19.TabIndex = 36
		Me.label19.Text = "Área"
		'
		'pbxCorrecto
		'
		Me.pbxCorrecto.Image = CType(resources.GetObject("pbxCorrecto.Image"),System.Drawing.Image)
		Me.pbxCorrecto.Location = New System.Drawing.Point(459, 80)
		Me.pbxCorrecto.Name = "pbxCorrecto"
		Me.pbxCorrecto.Size = New System.Drawing.Size(30, 30)
		Me.pbxCorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pbxCorrecto.TabIndex = 38
		Me.pbxCorrecto.TabStop = false
		Me.pbxCorrecto.Visible = false
		'
		'gbxRectangulo
		'
		Me.gbxRectangulo.Controls.Add(Me.pictureBox1)
		Me.gbxRectangulo.Controls.Add(Me.label1)
		Me.gbxRectangulo.Controls.Add(Me.tbxBase)
		Me.gbxRectangulo.Controls.Add(Me.tbxAltura)
		Me.gbxRectangulo.Controls.Add(Me.lbAreaR)
		Me.gbxRectangulo.Controls.Add(Me.label7)
		Me.gbxRectangulo.Controls.Add(Me.label17)
		Me.gbxRectangulo.Controls.Add(Me.label6)
		Me.gbxRectangulo.Controls.Add(Me.lb001)
		Me.gbxRectangulo.Controls.Add(Me.lbPerimetroR)
		Me.gbxRectangulo.Enabled = false
		Me.gbxRectangulo.Location = New System.Drawing.Point(12, 116)
		Me.gbxRectangulo.Name = "gbxRectangulo"
		Me.gbxRectangulo.Size = New System.Drawing.Size(538, 180)
		Me.gbxRectangulo.TabIndex = 39
		Me.gbxRectangulo.TabStop = false
		Me.gbxRectangulo.Text = "Rectángulo"
		Me.gbxRectangulo.Visible = false
		'
		'gbxCirculo
		'
		Me.gbxCirculo.Controls.Add(Me.pictureBox2)
		Me.gbxCirculo.Controls.Add(Me.label2)
		Me.gbxCirculo.Controls.Add(Me.tbxRadio)
		Me.gbxCirculo.Controls.Add(Me.label11)
		Me.gbxCirculo.Controls.Add(Me.label9)
		Me.gbxCirculo.Controls.Add(Me.lbPerimetroC)
		Me.gbxCirculo.Controls.Add(Me.lbAreaCirculo)
		Me.gbxCirculo.Controls.Add(Me.label15)
		Me.gbxCirculo.Enabled = false
		Me.gbxCirculo.Location = New System.Drawing.Point(12, 116)
		Me.gbxCirculo.Name = "gbxCirculo"
		Me.gbxCirculo.Size = New System.Drawing.Size(538, 175)
		Me.gbxCirculo.TabIndex = 40
		Me.gbxCirculo.TabStop = false
		Me.gbxCirculo.Text = "Círculo"
		Me.gbxCirculo.Visible = false
		'
		'gbxT
		'
		Me.gbxT.Controls.Add(Me.pictureBox3)
		Me.gbxT.Controls.Add(Me.label3)
		Me.gbxT.Controls.Add(Me.tbxBaseT)
		Me.gbxT.Controls.Add(Me.tbxAlturaT)
		Me.gbxT.Controls.Add(Me.lbAreaT)
		Me.gbxT.Controls.Add(Me.label13)
		Me.gbxT.Controls.Add(Me.label19)
		Me.gbxT.Controls.Add(Me.label12)
		Me.gbxT.Enabled = false
		Me.gbxT.Location = New System.Drawing.Point(12, 116)
		Me.gbxT.Name = "gbxT"
		Me.gbxT.Size = New System.Drawing.Size(538, 174)
		Me.gbxT.TabIndex = 41
		Me.gbxT.TabStop = false
		Me.gbxT.Text = "Triángulo"
		Me.gbxT.Visible = false
		'
		'gbxTrapecio
		'
		Me.gbxTrapecio.Controls.Add(Me.tbxAlturaTrapecio)
		Me.gbxTrapecio.Controls.Add(Me.label20)
		Me.gbxTrapecio.Controls.Add(Me.pictureBox5)
		Me.gbxTrapecio.Controls.Add(Me.label8)
		Me.gbxTrapecio.Controls.Add(Me.tbxAt)
		Me.gbxTrapecio.Controls.Add(Me.tbxBt)
		Me.gbxTrapecio.Controls.Add(Me.lbAreaTrapecio)
		Me.gbxTrapecio.Controls.Add(Me.label14)
		Me.gbxTrapecio.Controls.Add(Me.label16)
		Me.gbxTrapecio.Controls.Add(Me.label18)
		Me.gbxTrapecio.Enabled = false
		Me.gbxTrapecio.Location = New System.Drawing.Point(12, 116)
		Me.gbxTrapecio.Name = "gbxTrapecio"
		Me.gbxTrapecio.Size = New System.Drawing.Size(538, 189)
		Me.gbxTrapecio.TabIndex = 44
		Me.gbxTrapecio.TabStop = false
		Me.gbxTrapecio.Text = "Trapecio"
		Me.gbxTrapecio.Visible = false
		'
		'tbxAlturaTrapecio
		'
		Me.tbxAlturaTrapecio.Location = New System.Drawing.Point(293, 110)
		Me.tbxAlturaTrapecio.Name = "tbxAlturaTrapecio"
		Me.tbxAlturaTrapecio.Size = New System.Drawing.Size(210, 20)
		Me.tbxAlturaTrapecio.TabIndex = 38
		Me.tbxAlturaTrapecio.Text = "0"
		AddHandler Me.tbxAlturaTrapecio.TextChanged, AddressOf Me.TbxAlturaTrapecioTextChanged
		'
		'label20
		'
		Me.label20.Location = New System.Drawing.Point(179, 111)
		Me.label20.Name = "label20"
		Me.label20.Size = New System.Drawing.Size(100, 23)
		Me.label20.TabIndex = 39
		Me.label20.Text = "Altura"
		'
		'pictureBox5
		'
		Me.pictureBox5.Image = CType(resources.GetObject("pictureBox5.Image"),System.Drawing.Image)
		Me.pictureBox5.Location = New System.Drawing.Point(6, 40)
		Me.pictureBox5.Name = "pictureBox5"
		Me.pictureBox5.Size = New System.Drawing.Size(150, 119)
		Me.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pictureBox5.TabIndex = 2
		Me.pictureBox5.TabStop = false
		'
		'label8
		'
		Me.label8.BackColor = System.Drawing.Color.MediumSeaGreen
		Me.label8.Font = New System.Drawing.Font("Raleway Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		Me.label8.Location = New System.Drawing.Point(179, 19)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(324, 26)
		Me.label8.TabIndex = 13
		Me.label8.Text = "Trapecio"
		'
		'tbxAt
		'
		Me.tbxAt.Location = New System.Drawing.Point(293, 58)
		Me.tbxAt.Name = "tbxAt"
		Me.tbxAt.Size = New System.Drawing.Size(210, 20)
		Me.tbxAt.TabIndex = 26
		Me.tbxAt.Text = "0"
		AddHandler Me.tbxAt.TextChanged, AddressOf Me.TbxAtTextChanged
		'
		'tbxBt
		'
		Me.tbxBt.Location = New System.Drawing.Point(293, 83)
		Me.tbxBt.Name = "tbxBt"
		Me.tbxBt.Size = New System.Drawing.Size(210, 20)
		Me.tbxBt.TabIndex = 27
		Me.tbxBt.Text = "0"
		AddHandler Me.tbxBt.TextChanged, AddressOf Me.TbxBtTextChanged
		'
		'lbAreaTrapecio
		'
		Me.lbAreaTrapecio.Location = New System.Drawing.Point(293, 146)
		Me.lbAreaTrapecio.Name = "lbAreaTrapecio"
		Me.lbAreaTrapecio.Size = New System.Drawing.Size(210, 23)
		Me.lbAreaTrapecio.TabIndex = 37
		Me.lbAreaTrapecio.Text = "0"
		'
		'label14
		'
		Me.label14.Location = New System.Drawing.Point(179, 58)
		Me.label14.Name = "label14"
		Me.label14.Size = New System.Drawing.Size(100, 23)
		Me.label14.TabIndex = 28
		Me.label14.Text = "Lado A"
		'
		'label16
		'
		Me.label16.Location = New System.Drawing.Point(179, 146)
		Me.label16.Name = "label16"
		Me.label16.Size = New System.Drawing.Size(100, 23)
		Me.label16.TabIndex = 36
		Me.label16.Text = "Área"
		'
		'label18
		'
		Me.label18.Location = New System.Drawing.Point(179, 84)
		Me.label18.Name = "label18"
		Me.label18.Size = New System.Drawing.Size(100, 23)
		Me.label18.TabIndex = 29
		Me.label18.Text = "Lado B"
		'
		'mnPrincipal
		'
		Me.mnPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.inicioToolStripMenuItem, Me.áreasToolStripMenuItem, Me.volúmenesToolStripMenuItem, Me.ayudaToolStripMenuItem})
		Me.mnPrincipal.Location = New System.Drawing.Point(0, 0)
		Me.mnPrincipal.Name = "mnPrincipal"
		Me.mnPrincipal.Size = New System.Drawing.Size(567, 24)
		Me.mnPrincipal.TabIndex = 42
		Me.mnPrincipal.Text = "menuStrip1"
		'
		'inicioToolStripMenuItem
		'
		Me.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem"
		Me.inicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
		Me.inicioToolStripMenuItem.Text = "Inicio"
		AddHandler Me.inicioToolStripMenuItem.Click, AddressOf Me.InicioToolStripMenuItemClick
		'
		'áreasToolStripMenuItem
		'
		Me.áreasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.rectánguloToolStripMenuItem, Me.círculoToolStripMenuItem, Me.triánguloToolStripMenuItem, Me.elipseToolStripMenuItem, Me.trapecioToolStripMenuItem, Me.pentágonoToolStripMenuItem, Me.hexágonoToolStripMenuItem})
		Me.áreasToolStripMenuItem.Name = "áreasToolStripMenuItem"
		Me.áreasToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
		Me.áreasToolStripMenuItem.Text = "Áreas"
		'
		'rectánguloToolStripMenuItem
		'
		Me.rectánguloToolStripMenuItem.Name = "rectánguloToolStripMenuItem"
		Me.rectánguloToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
		Me.rectánguloToolStripMenuItem.Text = "Rectángulo"
		AddHandler Me.rectánguloToolStripMenuItem.Click, AddressOf Me.RectánguloToolStripMenuItemClick
		'
		'círculoToolStripMenuItem
		'
		Me.círculoToolStripMenuItem.Name = "círculoToolStripMenuItem"
		Me.círculoToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
		Me.círculoToolStripMenuItem.Text = "Círculo"
		AddHandler Me.círculoToolStripMenuItem.Click, AddressOf Me.CírculoToolStripMenuItemClick
		'
		'triánguloToolStripMenuItem
		'
		Me.triánguloToolStripMenuItem.Name = "triánguloToolStripMenuItem"
		Me.triánguloToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
		Me.triánguloToolStripMenuItem.Text = "Triángulo"
		AddHandler Me.triánguloToolStripMenuItem.Click, AddressOf Me.TriánguloToolStripMenuItemClick
		'
		'elipseToolStripMenuItem
		'
		Me.elipseToolStripMenuItem.Name = "elipseToolStripMenuItem"
		Me.elipseToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
		Me.elipseToolStripMenuItem.Text = "Romboide"
		AddHandler Me.elipseToolStripMenuItem.Click, AddressOf Me.ElipseToolStripMenuItemClick
		'
		'trapecioToolStripMenuItem
		'
		Me.trapecioToolStripMenuItem.Name = "trapecioToolStripMenuItem"
		Me.trapecioToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
		Me.trapecioToolStripMenuItem.Text = "Trapecio"
		AddHandler Me.trapecioToolStripMenuItem.Click, AddressOf Me.TrapecioToolStripMenuItemClick
		'
		'pentágonoToolStripMenuItem
		'
		Me.pentágonoToolStripMenuItem.Name = "pentágonoToolStripMenuItem"
		Me.pentágonoToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
		Me.pentágonoToolStripMenuItem.Text = "Pentágono"
		AddHandler Me.pentágonoToolStripMenuItem.Click, AddressOf Me.PentágonoToolStripMenuItemClick
		'
		'hexágonoToolStripMenuItem
		'
		Me.hexágonoToolStripMenuItem.Name = "hexágonoToolStripMenuItem"
		Me.hexágonoToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
		Me.hexágonoToolStripMenuItem.Text = "Hexágono"
		AddHandler Me.hexágonoToolStripMenuItem.Click, AddressOf Me.HexágonoToolStripMenuItemClick
		'
		'volúmenesToolStripMenuItem
		'
		Me.volúmenesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.esferaToolStripMenuItem, Me.cuboToolStripMenuItem, Me.pirámideToolStripMenuItem})
		Me.volúmenesToolStripMenuItem.Name = "volúmenesToolStripMenuItem"
		Me.volúmenesToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
		Me.volúmenesToolStripMenuItem.Text = "Volúmenes"
		'
		'esferaToolStripMenuItem
		'
		Me.esferaToolStripMenuItem.Name = "esferaToolStripMenuItem"
		Me.esferaToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
		Me.esferaToolStripMenuItem.Text = "Esfera"
		'
		'cuboToolStripMenuItem
		'
		Me.cuboToolStripMenuItem.Name = "cuboToolStripMenuItem"
		Me.cuboToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
		Me.cuboToolStripMenuItem.Text = "Cubo"
		'
		'pirámideToolStripMenuItem
		'
		Me.pirámideToolStripMenuItem.Name = "pirámideToolStripMenuItem"
		Me.pirámideToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
		Me.pirámideToolStripMenuItem.Text = "Pirámide"
		'
		'ayudaToolStripMenuItem
		'
		Me.ayudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.acercaDeMiToolStripMenuItem})
		Me.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem"
		Me.ayudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
		Me.ayudaToolStripMenuItem.Text = "Ayuda"
		'
		'acercaDeMiToolStripMenuItem
		'
		Me.acercaDeMiToolStripMenuItem.Name = "acercaDeMiToolStripMenuItem"
		Me.acercaDeMiToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
		Me.acercaDeMiToolStripMenuItem.Text = "Acerca de mi"
		'
		'tbxPass
		'
		Me.tbxPass.Location = New System.Drawing.Point(215, 86)
		Me.tbxPass.Name = "tbxPass"
		Me.tbxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.tbxPass.Size = New System.Drawing.Size(131, 20)
		Me.tbxPass.TabIndex = 38
		Me.tbxPass.Text = "0"
		Me.ttayuda.SetToolTip(Me.tbxPass, "Aqui debe colocar el password correcto")
		'
		'label4
		'
		Me.label4.Location = New System.Drawing.Point(94, 83)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(100, 23)
		Me.label4.TabIndex = 38
		Me.label4.Text = "Contraseña"
		'
		'btnActivar
		'
		Me.btnActivar.Location = New System.Drawing.Point(361, 84)
		Me.btnActivar.Name = "btnActivar"
		Me.btnActivar.Size = New System.Drawing.Size(75, 23)
		Me.btnActivar.TabIndex = 43
		Me.btnActivar.Text = "Activar"
		Me.btnActivar.UseVisualStyleBackColor = true
		AddHandler Me.btnActivar.Click, AddressOf Me.BtnActivarClick
		'
		'pbxError
		'
		Me.pbxError.Image = CType(resources.GetObject("pbxError.Image"),System.Drawing.Image)
		Me.pbxError.Location = New System.Drawing.Point(459, 80)
		Me.pbxError.Name = "pbxError"
		Me.pbxError.Size = New System.Drawing.Size(30, 30)
		Me.pbxError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pbxError.TabIndex = 45
		Me.pbxError.TabStop = false
		Me.pbxError.Visible = false
		'
		'gbxRomboide
		'
		Me.gbxRomboide.Controls.Add(Me.tbxAlturaRomboide)
		Me.gbxRomboide.Controls.Add(Me.label10)
		Me.gbxRomboide.Controls.Add(Me.pictureBox4)
		Me.gbxRomboide.Controls.Add(Me.label21)
		Me.gbxRomboide.Controls.Add(Me.tbxARomboide)
		Me.gbxRomboide.Controls.Add(Me.lbAreaRomboide)
		Me.gbxRomboide.Controls.Add(Me.label23)
		Me.gbxRomboide.Controls.Add(Me.label24)
		Me.gbxRomboide.Enabled = false
		Me.gbxRomboide.Location = New System.Drawing.Point(12, 116)
		Me.gbxRomboide.Name = "gbxRomboide"
		Me.gbxRomboide.Size = New System.Drawing.Size(538, 189)
		Me.gbxRomboide.TabIndex = 46
		Me.gbxRomboide.TabStop = false
		Me.gbxRomboide.Text = "Romboide"
		Me.gbxRomboide.Visible = false
		'
		'tbxAlturaRomboide
		'
		Me.tbxAlturaRomboide.Location = New System.Drawing.Point(293, 87)
		Me.tbxAlturaRomboide.Name = "tbxAlturaRomboide"
		Me.tbxAlturaRomboide.Size = New System.Drawing.Size(210, 20)
		Me.tbxAlturaRomboide.TabIndex = 38
		Me.tbxAlturaRomboide.Text = "0"
		'
		'label10
		'
		Me.label10.Location = New System.Drawing.Point(179, 88)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(100, 23)
		Me.label10.TabIndex = 39
		Me.label10.Text = "Altura"
		'
		'pictureBox4
		'
		Me.pictureBox4.Image = CType(resources.GetObject("pictureBox4.Image"),System.Drawing.Image)
		Me.pictureBox4.Location = New System.Drawing.Point(6, 40)
		Me.pictureBox4.Name = "pictureBox4"
		Me.pictureBox4.Size = New System.Drawing.Size(150, 119)
		Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pictureBox4.TabIndex = 2
		Me.pictureBox4.TabStop = false
		'
		'label21
		'
		Me.label21.BackColor = System.Drawing.Color.MediumSeaGreen
		Me.label21.Font = New System.Drawing.Font("Raleway Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		Me.label21.Location = New System.Drawing.Point(179, 19)
		Me.label21.Name = "label21"
		Me.label21.Size = New System.Drawing.Size(324, 26)
		Me.label21.TabIndex = 13
		Me.label21.Text = "Romboide"
		'
		'tbxARomboide
		'
		Me.tbxARomboide.Location = New System.Drawing.Point(293, 58)
		Me.tbxARomboide.Name = "tbxARomboide"
		Me.tbxARomboide.Size = New System.Drawing.Size(210, 20)
		Me.tbxARomboide.TabIndex = 26
		Me.tbxARomboide.Text = "0"
		'
		'lbAreaRomboide
		'
		Me.lbAreaRomboide.Location = New System.Drawing.Point(293, 123)
		Me.lbAreaRomboide.Name = "lbAreaRomboide"
		Me.lbAreaRomboide.Size = New System.Drawing.Size(210, 23)
		Me.lbAreaRomboide.TabIndex = 37
		Me.lbAreaRomboide.Text = "0"
		'
		'label23
		'
		Me.label23.Location = New System.Drawing.Point(179, 58)
		Me.label23.Name = "label23"
		Me.label23.Size = New System.Drawing.Size(100, 23)
		Me.label23.TabIndex = 28
		Me.label23.Text = "Lado A"
		'
		'label24
		'
		Me.label24.Location = New System.Drawing.Point(179, 123)
		Me.label24.Name = "label24"
		Me.label24.Size = New System.Drawing.Size(100, 23)
		Me.label24.TabIndex = 36
		Me.label24.Text = "Área"
		'
		'gbxHexagono
		'
		Me.gbxHexagono.Controls.Add(Me.tbxAlturaHexagno)
		Me.gbxHexagono.Controls.Add(Me.label26)
		Me.gbxHexagono.Controls.Add(Me.pictureBox6)
		Me.gbxHexagono.Controls.Add(Me.label27)
		Me.gbxHexagono.Controls.Add(Me.tbxAHexagono)
		Me.gbxHexagono.Controls.Add(Me.lbAreaHexagono)
		Me.gbxHexagono.Controls.Add(Me.label29)
		Me.gbxHexagono.Controls.Add(Me.label30)
		Me.gbxHexagono.Enabled = false
		Me.gbxHexagono.Location = New System.Drawing.Point(12, 116)
		Me.gbxHexagono.Name = "gbxHexagono"
		Me.gbxHexagono.Size = New System.Drawing.Size(538, 189)
		Me.gbxHexagono.TabIndex = 45
		Me.gbxHexagono.TabStop = false
		Me.gbxHexagono.Text = "Hexágono"
		Me.gbxHexagono.Visible = false
		'
		'tbxAlturaHexagno
		'
		Me.tbxAlturaHexagno.Location = New System.Drawing.Point(293, 87)
		Me.tbxAlturaHexagno.Name = "tbxAlturaHexagno"
		Me.tbxAlturaHexagno.Size = New System.Drawing.Size(210, 20)
		Me.tbxAlturaHexagno.TabIndex = 38
		Me.tbxAlturaHexagno.Text = "0"
		'
		'label26
		'
		Me.label26.Location = New System.Drawing.Point(179, 88)
		Me.label26.Name = "label26"
		Me.label26.Size = New System.Drawing.Size(100, 23)
		Me.label26.TabIndex = 39
		Me.label26.Text = "Altura"
		'
		'pictureBox6
		'
		Me.pictureBox6.Image = CType(resources.GetObject("pictureBox6.Image"),System.Drawing.Image)
		Me.pictureBox6.Location = New System.Drawing.Point(6, 20)
		Me.pictureBox6.Name = "pictureBox6"
		Me.pictureBox6.Size = New System.Drawing.Size(150, 149)
		Me.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pictureBox6.TabIndex = 2
		Me.pictureBox6.TabStop = false
		'
		'label27
		'
		Me.label27.BackColor = System.Drawing.Color.MediumSeaGreen
		Me.label27.Font = New System.Drawing.Font("Raleway Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label27.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		Me.label27.Location = New System.Drawing.Point(179, 19)
		Me.label27.Name = "label27"
		Me.label27.Size = New System.Drawing.Size(324, 26)
		Me.label27.TabIndex = 13
		Me.label27.Text = "Hexágono"
		'
		'tbxAHexagono
		'
		Me.tbxAHexagono.Location = New System.Drawing.Point(293, 58)
		Me.tbxAHexagono.Name = "tbxAHexagono"
		Me.tbxAHexagono.Size = New System.Drawing.Size(210, 20)
		Me.tbxAHexagono.TabIndex = 26
		Me.tbxAHexagono.Text = "0"
		'
		'lbAreaHexagono
		'
		Me.lbAreaHexagono.Location = New System.Drawing.Point(293, 123)
		Me.lbAreaHexagono.Name = "lbAreaHexagono"
		Me.lbAreaHexagono.Size = New System.Drawing.Size(210, 23)
		Me.lbAreaHexagono.TabIndex = 37
		Me.lbAreaHexagono.Text = "0"
		'
		'label29
		'
		Me.label29.Location = New System.Drawing.Point(179, 58)
		Me.label29.Name = "label29"
		Me.label29.Size = New System.Drawing.Size(100, 23)
		Me.label29.TabIndex = 28
		Me.label29.Text = "Lado A"
		'
		'label30
		'
		Me.label30.Location = New System.Drawing.Point(179, 123)
		Me.label30.Name = "label30"
		Me.label30.Size = New System.Drawing.Size(100, 23)
		Me.label30.TabIndex = 36
		Me.label30.Text = "Área"
		'
		'gbxPentagono
		'
		Me.gbxPentagono.Controls.Add(Me.tbxAlturaPentagono)
		Me.gbxPentagono.Controls.Add(Me.label32)
		Me.gbxPentagono.Controls.Add(Me.pictureBox7)
		Me.gbxPentagono.Controls.Add(Me.label33)
		Me.gbxPentagono.Controls.Add(Me.tbxAPentagono)
		Me.gbxPentagono.Controls.Add(Me.lbAreaPentagono)
		Me.gbxPentagono.Controls.Add(Me.label35)
		Me.gbxPentagono.Controls.Add(Me.label36)
		Me.gbxPentagono.Enabled = false
		Me.gbxPentagono.Location = New System.Drawing.Point(12, 116)
		Me.gbxPentagono.Name = "gbxPentagono"
		Me.gbxPentagono.Size = New System.Drawing.Size(538, 189)
		Me.gbxPentagono.TabIndex = 46
		Me.gbxPentagono.TabStop = false
		Me.gbxPentagono.Text = "Pentágono"
		Me.gbxPentagono.Visible = false
		'
		'tbxAlturaPentagono
		'
		Me.tbxAlturaPentagono.Location = New System.Drawing.Point(293, 84)
		Me.tbxAlturaPentagono.Name = "tbxAlturaPentagono"
		Me.tbxAlturaPentagono.Size = New System.Drawing.Size(210, 20)
		Me.tbxAlturaPentagono.TabIndex = 38
		Me.tbxAlturaPentagono.Text = "0"
		'
		'label32
		'
		Me.label32.Location = New System.Drawing.Point(179, 85)
		Me.label32.Name = "label32"
		Me.label32.Size = New System.Drawing.Size(100, 23)
		Me.label32.TabIndex = 39
		Me.label32.Text = "Altura"
		'
		'pictureBox7
		'
		Me.pictureBox7.Image = CType(resources.GetObject("pictureBox7.Image"),System.Drawing.Image)
		Me.pictureBox7.Location = New System.Drawing.Point(6, 20)
		Me.pictureBox7.Name = "pictureBox7"
		Me.pictureBox7.Size = New System.Drawing.Size(150, 149)
		Me.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pictureBox7.TabIndex = 2
		Me.pictureBox7.TabStop = false
		AddHandler Me.pictureBox7.MouseHover, AddressOf Me.PictureBox7MouseHover
		'
		'label33
		'
		Me.label33.BackColor = System.Drawing.Color.MediumSeaGreen
		Me.label33.Font = New System.Drawing.Font("Raleway Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label33.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		Me.label33.Location = New System.Drawing.Point(179, 19)
		Me.label33.Name = "label33"
		Me.label33.Size = New System.Drawing.Size(324, 26)
		Me.label33.TabIndex = 13
		Me.label33.Text = "Pentágono"
		'
		'tbxAPentagono
		'
		Me.tbxAPentagono.Location = New System.Drawing.Point(293, 58)
		Me.tbxAPentagono.Name = "tbxAPentagono"
		Me.tbxAPentagono.Size = New System.Drawing.Size(210, 20)
		Me.tbxAPentagono.TabIndex = 26
		Me.tbxAPentagono.Text = "0"
		'
		'lbAreaPentagono
		'
		Me.lbAreaPentagono.Location = New System.Drawing.Point(293, 120)
		Me.lbAreaPentagono.Name = "lbAreaPentagono"
		Me.lbAreaPentagono.Size = New System.Drawing.Size(210, 23)
		Me.lbAreaPentagono.TabIndex = 37
		Me.lbAreaPentagono.Text = "0"
		'
		'label35
		'
		Me.label35.Location = New System.Drawing.Point(179, 58)
		Me.label35.Name = "label35"
		Me.label35.Size = New System.Drawing.Size(100, 23)
		Me.label35.TabIndex = 28
		Me.label35.Text = "Lado A"
		'
		'label36
		'
		Me.label36.Location = New System.Drawing.Point(179, 120)
		Me.label36.Name = "label36"
		Me.label36.Size = New System.Drawing.Size(100, 23)
		Me.label36.TabIndex = 36
		Me.label36.Text = "Área"
		'
		'ttayuda
		'
		Me.ttayuda.IsBalloon = true
		'
		'lbHora
		'
		Me.lbHora.Location = New System.Drawing.Point(410, 308)
		Me.lbHora.Name = "lbHora"
		Me.lbHora.Size = New System.Drawing.Size(145, 26)
		Me.lbHora.TabIndex = 47
		Me.lbHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Areas
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.WhiteSmoke
		Me.ClientSize = New System.Drawing.Size(567, 342)
		Me.Controls.Add(Me.lbHora)
		Me.Controls.Add(Me.gbxPentagono)
		Me.Controls.Add(Me.gbxHexagono)
		Me.Controls.Add(Me.gbxRomboide)
		Me.Controls.Add(Me.pbxError)
		Me.Controls.Add(Me.gbxTrapecio)
		Me.Controls.Add(Me.btnActivar)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.tbxPass)
		Me.Controls.Add(Me.gbxT)
		Me.Controls.Add(Me.gbxCirculo)
		Me.Controls.Add(Me.gbxRectangulo)
		Me.Controls.Add(Me.pbxCorrecto)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.mnPrincipal)
		Me.Cursor = System.Windows.Forms.Cursors.Hand
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.MainMenuStrip = Me.mnPrincipal
		Me.Name = "Areas"
		Me.Text = "Areas"
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pictureBox2,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pictureBox3,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pbxCorrecto,System.ComponentModel.ISupportInitialize).EndInit
		Me.gbxRectangulo.ResumeLayout(false)
		Me.gbxRectangulo.PerformLayout
		Me.gbxCirculo.ResumeLayout(false)
		Me.gbxCirculo.PerformLayout
		Me.gbxT.ResumeLayout(false)
		Me.gbxT.PerformLayout
		Me.gbxTrapecio.ResumeLayout(false)
		Me.gbxTrapecio.PerformLayout
		CType(Me.pictureBox5,System.ComponentModel.ISupportInitialize).EndInit
		Me.mnPrincipal.ResumeLayout(false)
		Me.mnPrincipal.PerformLayout
		CType(Me.pbxError,System.ComponentModel.ISupportInitialize).EndInit
		Me.gbxRomboide.ResumeLayout(false)
		Me.gbxRomboide.PerformLayout
		CType(Me.pictureBox4,System.ComponentModel.ISupportInitialize).EndInit
		Me.gbxHexagono.ResumeLayout(false)
		Me.gbxHexagono.PerformLayout
		CType(Me.pictureBox6,System.ComponentModel.ISupportInitialize).EndInit
		Me.gbxPentagono.ResumeLayout(false)
		Me.gbxPentagono.PerformLayout
		CType(Me.pictureBox7,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private lbHora As System.Windows.Forms.Label
	Private tmHora As System.Windows.Forms.Timer
	Private ttayuda As System.Windows.Forms.ToolTip
	Private label36 As System.Windows.Forms.Label
	Private label35 As System.Windows.Forms.Label
	Private lbAreaPentagono As System.Windows.Forms.Label
	Private tbxAPentagono As System.Windows.Forms.TextBox
	Private label33 As System.Windows.Forms.Label
	Private pictureBox7 As System.Windows.Forms.PictureBox
	Private label32 As System.Windows.Forms.Label
	Private tbxAlturaPentagono As System.Windows.Forms.TextBox
	Private gbxPentagono As System.Windows.Forms.GroupBox
	Private label24 As System.Windows.Forms.Label
	Private label23 As System.Windows.Forms.Label
	Private lbAreaRomboide As System.Windows.Forms.Label
	Private tbxARomboide As System.Windows.Forms.TextBox
	Private label21 As System.Windows.Forms.Label
	Private pictureBox4 As System.Windows.Forms.PictureBox
	Private label10 As System.Windows.Forms.Label
	Private label30 As System.Windows.Forms.Label
	Private label29 As System.Windows.Forms.Label
	Private lbAreaHexagono As System.Windows.Forms.Label
	Private tbxAHexagono As System.Windows.Forms.TextBox
	Private label27 As System.Windows.Forms.Label
	Private pictureBox6 As System.Windows.Forms.PictureBox
	Private label26 As System.Windows.Forms.Label
	Private tbxAlturaHexagno As System.Windows.Forms.TextBox
	Private gbxHexagono As System.Windows.Forms.GroupBox
	Private tbxAlturaRomboide As System.Windows.Forms.TextBox
	Private gbxRomboide As System.Windows.Forms.GroupBox
	Private pbxError As System.Windows.Forms.PictureBox
	Private pbxCorrecto As System.Windows.Forms.PictureBox
	Private acercaDeMiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private label18 As System.Windows.Forms.Label
	Private label16 As System.Windows.Forms.Label
	Private label14 As System.Windows.Forms.Label
	Private lbAreaTrapecio As System.Windows.Forms.Label
	Private tbxBt As System.Windows.Forms.TextBox
	Private tbxAt As System.Windows.Forms.TextBox
	Private label8 As System.Windows.Forms.Label
	Private pictureBox5 As System.Windows.Forms.PictureBox
	Private label20 As System.Windows.Forms.Label
	Private tbxAlturaTrapecio As System.Windows.Forms.TextBox
	Private gbxTrapecio As System.Windows.Forms.GroupBox
	Private btnActivar As System.Windows.Forms.Button
	Private label4 As System.Windows.Forms.Label
	Private tbxPass As System.Windows.Forms.TextBox
	Private ayudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private pirámideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private cuboToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private esferaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private volúmenesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private hexágonoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private pentágonoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private trapecioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private elipseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private triánguloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private círculoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private rectánguloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private áreasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private inicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private mnPrincipal As System.Windows.Forms.MenuStrip
	Private gbxT As System.Windows.Forms.GroupBox
	Private gbxCirculo As System.Windows.Forms.GroupBox
	Private gbxRectangulo As System.Windows.Forms.GroupBox
	Private label17 As System.Windows.Forms.Label
	Private label19 As System.Windows.Forms.Label
	Private lbAreaT As System.Windows.Forms.Label
	Private lbAreaR As System.Windows.Forms.Label
	Private label15 As System.Windows.Forms.Label
	Private lbPerimetroC As System.Windows.Forms.Label
	Private tbxBaseT As System.Windows.Forms.TextBox
	Private tbxAlturaT As System.Windows.Forms.TextBox
	Private label13 As System.Windows.Forms.Label
	Private label12 As System.Windows.Forms.Label
	Private tbxRadio As System.Windows.Forms.TextBox
	Private label11 As System.Windows.Forms.Label
	Private label9 As System.Windows.Forms.Label
	Private lbAreaCirculo As System.Windows.Forms.Label
	Private tbxBase As System.Windows.Forms.TextBox
	Private tbxAltura As System.Windows.Forms.TextBox
	Private label7 As System.Windows.Forms.Label
	Private label6 As System.Windows.Forms.Label
	Private lb001 As System.Windows.Forms.Label
	Private lbPerimetroR As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private pictureBox3 As System.Windows.Forms.PictureBox
	Private pictureBox2 As System.Windows.Forms.PictureBox
	Private pictureBox1 As System.Windows.Forms.PictureBox
End Class
