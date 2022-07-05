'
' Created by SharpDevelop.
' User: User
' Date: 15/06/2022
' Time: 9:51
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class Areas
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		lbHora.Text=Now
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub TbxBaseTextChanged(sender As Object, e As EventArgs)
		If IsNumeric(tbxBase.Text) And IsNumeric(tbxAltura.Text) Then
			lbAreaR.Text=tbxBase.Text*tbxAltura.Text
			lbPerimetroR.Text=(2*tbxBase.Text)+(2*tbxAltura.Text)
		Else
			MsgBox("Por favor introduzca un numero valido")
		End If
	End Sub
	
	Sub TbxAlturaTextChanged(sender As Object, e As EventArgs)
		If IsNumeric(tbxBase.Text) And IsNumeric(tbxAltura.Text) Then
			lbAreaR.Text=tbxBase.Text*tbxAltura.Text
			lbPerimetroR.Text=(2*tbxBase.Text)+(2*tbxAltura.Text)
		Else
			MsgBox("Por favor introduzca un numero valido")
		End If
	End Sub
	
	Sub TbxRadioTextChanged(sender As Object, e As EventArgs)
		If IsNumeric(tbxRadio.Text) Then
			lbAreaCirculo.Text=Math.PI*Math.Pow(tbxRadio.Text,2)
		Else
			MsgBox("Por favor introduzca un numero valido")
		End If
	End Sub
	
	Sub RectánguloToolStripMenuItemClick(sender As Object, e As EventArgs)
		gbxCirculo.Visible=False
		gbxRectangulo.Visible=True
		gbxT.Visible=False
		gbxTrapecio.Visible=False
		gbxRomboide.Visible=False
		gbxHexagono.Visible=False
		gbxPentagono.Visible=False
		
	End Sub
	
	Sub CírculoToolStripMenuItemClick(sender As Object, e As EventArgs)
		gbxCirculo.Visible=True
		gbxRectangulo.Visible=False
		gbxT.Visible=False
		gbxTrapecio.Visible=False
		gbxRomboide.Visible=False
		gbxHexagono.Visible=False
		gbxPentagono.Visible=False
	End Sub
	
	Sub TriánguloToolStripMenuItemClick(sender As Object, e As EventArgs)
		gbxCirculo.Visible=False
		gbxRectangulo.Visible=False
		gbxT.Visible=True
		gbxTrapecio.Visible=False
		gbxRomboide.Visible=False
		gbxHexagono.Visible=False
		gbxPentagono.Visible=False
		
	End Sub
	
	Sub InicioToolStripMenuItemClick(sender As Object, e As EventArgs)
		Me.Close()
	End Sub
	
	Sub BtnActivarClick(sender As Object, e As EventArgs)
		If tbxPass.Text="12345" Then
			pbxError.Visible=False
			pbxCorrecto.Visible=True
			gbxCirculo.Enabled=True
			gbxHexagono.Enabled=True
			gbxPentagono.Enabled=True
			gbxRectangulo.Enabled=True
			gbxRomboide.Enabled=True
			gbxT.Enabled=True
			gbxTrapecio.Enabled=True
		Else
			MsgBox("Ingrese la contraseña correcta")
			pbxError.Visible=True
			pbxCorrecto.Visible=False
			gbxCirculo.Enabled=False
			gbxHexagono.Enabled=False
			gbxPentagono.Enabled=False
			gbxRectangulo.Enabled=False
			gbxRomboide.Enabled=False
			gbxT.Enabled=False
			gbxTrapecio.Enabled=False
		End If
	End Sub
	
	Sub TbxAtTextChanged(sender As Object, e As EventArgs)
		'lbAreaTrapecio.Text=((tbxAt.Text+tbxBt.Text)*tbxAlturaTrapecio.Text)/2
		lbAreaTrapecio.Text=(CDec(tbxAt.Text)+CDec(tbxBt.Text))*CDec(tbxAlturaTrapecio.Text)/2
	End Sub
	
	Sub TbxBtTextChanged(sender As Object, e As EventArgs)
		'lbAreaTrapecio.Text=((tbxAt.Text+tbxBt.Text)*tbxAlturaTrapecio.Text)/2
		lbAreaTrapecio.Text=(CDec(tbxAt.Text)+CDec(tbxBt.Text))*CDec(tbxAlturaTrapecio.Text)/2
	End Sub
	
	Sub TbxAlturaTrapecioTextChanged(sender As Object, e As EventArgs)
		'lbAreaTrapecio.Text=((tbxAt.Text+tbxBt.Text)*tbxAlturaTrapecio.Text)/2
		lbAreaTrapecio.Text=(CDec(tbxAt.Text)+CDec(tbxBt.Text))*CDec(tbxAlturaTrapecio.Text)/2
	End Sub
	
	Sub TrapecioToolStripMenuItemClick(sender As Object, e As EventArgs)
		gbxCirculo.Visible=False
		gbxRectangulo.Visible=False
		gbxT.Visible=False
		gbxTrapecio.Visible=True
		gbxRomboide.Visible=False
		gbxHexagono.Visible=False
		gbxPentagono.Visible=False
	End Sub
	
	Sub ElipseToolStripMenuItemClick(sender As Object, e As EventArgs)
		gbxCirculo.Visible=False
		gbxRectangulo.Visible=False
		gbxT.Visible=False
		gbxTrapecio.Visible=False
		gbxRomboide.Visible=True
		gbxHexagono.Visible=False
		gbxPentagono.Visible=False
	End Sub
	
	Sub PentágonoToolStripMenuItemClick(sender As Object, e As EventArgs)
		gbxCirculo.Visible=False
		gbxRectangulo.Visible=False
		gbxT.Visible=False
		gbxTrapecio.Visible=False
		gbxRomboide.Visible=False
		gbxHexagono.Visible=False
		gbxPentagono.Visible=True		
	End Sub
	
	Sub HexágonoToolStripMenuItemClick(sender As Object, e As EventArgs)
		gbxCirculo.Visible=False
		gbxRectangulo.Visible=False
		gbxT.Visible=False
		gbxTrapecio.Visible=False
		gbxRomboide.Visible=False
		gbxHexagono.Visible=True
		gbxPentagono.Visible=False
	End Sub
	
	Sub PictureBox7MouseHover(sender As Object, e As EventArgs)
		
	End Sub
End Class
