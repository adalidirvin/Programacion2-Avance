'
' Created by SharpDevelop.
' User: User
' Date: 25/05/2022
' Time: 10:43
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'

Public Partial Class frmOperaciones
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub BtnResolverClick(sender As Object, e As EventArgs)
		lbResultado.Text= tbxN1.Text*tbxN2.Text
	End Sub
	
	Sub BtnDivisionClick(sender As Object, e As EventArgs)
		Dim resultado As Decimal 'Declaramos la variable de tipo Decimal
		If tbxN4.Text=0 Then
			MsgBox("La division entre 0 no esta definida, por favor coloque otro valor")
		Else					
			lbDivision.Text=tbxN3.Text/tbxN4.Text
			resultado=tbxN3.Text/tbxN4.Text 'Asignamos a la variable RESULTADO la division de TbxN3  entre TbxN4
		lbDivision.Text=resultado 'En la etiqueta lbDivision escribimos la variable RESULTADO
		End If	
	End Sub
	
	Sub BtnPotenciaClick(sender As Object, e As EventArgs)
		Dim resultado As Decimal=1
		'resultado=Math.Pow(tbxBase.Text,tbxExponente.Text)
		'lbPotencia.Text=resultado
		Dim x=tbxBase.Text		
		Dim y=tbxExponente.Text
'		Dim i=0
'		While i<exponente
'			resultado=resultado*base
'			i=i+1
'		End While
		resultado=Math.Pow(x,y)'Devuelve el resultado de elevar x a y
		'resultado=Math.Sqrt(base)'Devuelve la raiz cuadrada de un numero
		lbPotencia.Text=resultado
	End Sub
	
	Sub BtnFactoresClick(sender As Object, e As EventArgs)
		Dim numero As Integer
		numero=tbxFactor.Text
		Dim i=2
		Dim resultado As String=""
		While i<numero
			If numero Mod i=0 Then
				resultado=resultado+ CStr(i) +","
			End If
			i=i+1
		End While
		lbFactores.Text=resultado
	End Sub
	
	Sub BtnPrimoClick(sender As Object, e As EventArgs)
		Dim numero As Integer
		numero=tbxPrimo.Text
		Dim i=2
		Dim resultado As Boolean=True
		While i<numero And resultado=True
			If numero Mod i=0  Then				
				resultado=False
			End If
			i=i+1
		End While
		If resultado=True Then
			lbPrimo.Text="Es primo"
		Else
			lbPrimo.Text="No es primo"
		End If
	End Sub
	
	Sub BtnRaizClick(sender As Object, e As EventArgs)
		Dim raiz=tbxRaiz.Text
		lbRaiz.Text=Math.Sqrt(raiz)
	End Sub
End Class
