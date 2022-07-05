'
' Created by SharpDevelop.
' User: User
' Date: 25/05/2022
' Time: 8:53
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub Label2Click(sender As Object, e As EventArgs)
		
	End Sub
	
	Sub BtnSaludarClick(sender As Object, e As EventArgs)
		lbRespuesta.Text="Hola estimado "+ tbxEntrada.Text	
		MsgBox("Hola "+tbxEntrada.Text)
	End Sub
	
	Sub BtnOperacionesClick(sender As Object, e As EventArgs)
		frmOperaciones.show()
	End Sub
	
	Sub BtnAreaClick(sender As Object, e As EventArgs)
		Areas.Show()		
	End Sub
End Class
