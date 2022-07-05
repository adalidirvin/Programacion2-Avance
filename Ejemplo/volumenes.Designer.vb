'
' Created by SharpDevelop.
' User: User
' Date: 15/06/2022
' Time: 9:57
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class volumenes
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
		Me.mnMenu = New System.Windows.Forms.MenuStrip()
		Me.inicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ayudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.gbxEsfera = New System.Windows.Forms.GroupBox()
		Me.gbxPiramide = New System.Windows.Forms.GroupBox()
		Me.trackBar1 = New System.Windows.Forms.TrackBar()
		Me.Ayuda = New System.Windows.Forms.ToolTip(Me.components)
		Me.mnMenu.SuspendLayout
		Me.gbxEsfera.SuspendLayout
		CType(Me.trackBar1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'mnMenu
		'
		Me.mnMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.inicioToolStripMenuItem, Me.ayudaToolStripMenuItem})
		Me.mnMenu.Location = New System.Drawing.Point(0, 0)
		Me.mnMenu.Name = "mnMenu"
		Me.mnMenu.Size = New System.Drawing.Size(566, 24)
		Me.mnMenu.TabIndex = 0
		Me.mnMenu.Text = "menuStrip1"
		'
		'inicioToolStripMenuItem
		'
		Me.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem"
		Me.inicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
		Me.inicioToolStripMenuItem.Text = "Inicio"
		'
		'ayudaToolStripMenuItem
		'
		Me.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem"
		Me.ayudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
		Me.ayudaToolStripMenuItem.Text = "Ayuda"
		'
		'gbxEsfera
		'
		Me.gbxEsfera.Controls.Add(Me.trackBar1)
		Me.gbxEsfera.Location = New System.Drawing.Point(8, 34)
		Me.gbxEsfera.Name = "gbxEsfera"
		Me.gbxEsfera.Size = New System.Drawing.Size(288, 385)
		Me.gbxEsfera.TabIndex = 1
		Me.gbxEsfera.TabStop = false
		Me.gbxEsfera.Text = "Esfera"
		'
		'gbxPiramide
		'
		Me.gbxPiramide.Location = New System.Drawing.Point(302, 32)
		Me.gbxPiramide.Name = "gbxPiramide"
		Me.gbxPiramide.Size = New System.Drawing.Size(246, 386)
		Me.gbxPiramide.TabIndex = 2
		Me.gbxPiramide.TabStop = false
		Me.gbxPiramide.Text = "Pirámide"
		'
		'trackBar1
		'
		Me.trackBar1.Location = New System.Drawing.Point(38, 310)
		Me.trackBar1.Name = "trackBar1"
		Me.trackBar1.Size = New System.Drawing.Size(218, 45)
		Me.trackBar1.TabIndex = 0
		'
		'volumenes
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(566, 438)
		Me.Controls.Add(Me.gbxPiramide)
		Me.Controls.Add(Me.gbxEsfera)
		Me.Controls.Add(Me.mnMenu)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.MainMenuStrip = Me.mnMenu
		Me.Name = "volumenes"
		Me.Text = "volumenes"
		Me.mnMenu.ResumeLayout(false)
		Me.mnMenu.PerformLayout
		Me.gbxEsfera.ResumeLayout(false)
		Me.gbxEsfera.PerformLayout
		CType(Me.trackBar1,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private Ayuda As System.Windows.Forms.ToolTip
	Private trackBar1 As System.Windows.Forms.TrackBar
	Private gbxPiramide As System.Windows.Forms.GroupBox
	Private gbxEsfera As System.Windows.Forms.GroupBox
	Private ayudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private inicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private mnMenu As System.Windows.Forms.MenuStrip
End Class
