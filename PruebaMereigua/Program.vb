Imports System

Module Program
	Sub Main(args As String())
		Dim NumberList = {1, 2, 8, 4, 5, -12}
		'ArrayNumbers(NumberList)

		revertirPalabra("hola")



		Console.WriteLine("Inicio proceso")
		EscribirMultiplos()
		Console.WriteLine("Fin proceso")


		'ArregloNumeros(numeros)
	End Sub

	Public Sub EscribirMultiplos()
		For i = 1 To 100
			If (i Mod 3 = 0 And i Mod 5 = 0) Then
				Console.WriteLine("mareigua")
			ElseIf i Mod 3 = 0 Then
				Console.WriteLine("mare")
			ElseIf i Mod 5 = 0 Then
				Console.WriteLine("igua")
			Else
				Console.WriteLine(i)
			End If

		Next
	End Sub
	Public Sub ArrayNumbers(NumberList)
		Dim i As Integer
		Dim maxindex As Integer

		maxindex = 0

		For i = 1 To UBound(NumberList)
			If NumberList(i) > NumberList(maxindex) Then
				maxindex = i
			End If
		Next

		Dim value = NumberList(maxindex)
		Console.WriteLine("El numero mayor es {0}", value)
	End Sub

	Public Sub revertirPalabra(cadena As String)


		Dim charArray = cadena.ToCharArray()
		Dim CadenaInvertida = ""

		For i = cadena.Length - 1 To 0 Step -1
			CadenaInvertida = CadenaInvertida & cadena(i)
			'Console.WriteLine("{0}", cadena(i))
		Next


		Console.WriteLine("{0}", CadenaInvertida)
	End Sub

End Module
