Module Module1

    Sub outputChange(ByVal changeDue As Integer)

        'Dim cd As Integer = changeDue

        'Dim x, y, z As Integer

        'x = Int(cd / 50)

        'If x > 0 Then
        '    Console.WriteLine("Return " & x & " number of 50 cent coins")
        'End If


        'cd = cd - (x * 50)


        'y = Int(cd / 20)
        'If y > 0 Then
        '    Console.WriteLine("Return " & y & " number of 20 cent coins")
        'End If


        'cd = cd - (y * 20)

        'z = Int(cd / 10)
        'Console.WriteLine("Return " & z & " number of 10 cent coins")

        Dim coins() As Integer = {50, 20, 10}
        Dim i, t As Integer
        Dim cd As Integer = changeDue

        i = 0
        t = 0

        While cd > 0
            t = Int(cd / coins(i))

            If t > 0 Then
                Console.WriteLine(coins(i) & " cent coins required: " & t)
            End If

            cd = cd Mod coins(i)
            i = i + 1

        End While

    End Sub



    Sub Main()

        Dim snackType As String

        Dim coinValue As Integer

        Dim changeDue As Integer

        Dim Total As Integer
        Total = 0

        Dim price As Integer

        Console.WriteLine("Snack A - 20 Cent")
        Console.WriteLine("Snack B - 40 Cent")
        Console.WriteLine("Snack C - 50 Cent")
        Console.WriteLine("Snack D - 80 Cent")

        Console.WriteLine("")

        Console.Write("Chose a snack type: ")

        snackType = UCase(Console.ReadLine())

        Select Case snackType
            Case "A"
                price = 20
            Case "B"
                price = 40
            Case "C"
                price = 50
            Case "D"
                price = 80

        End Select


        Console.WriteLine("Enter your coins:")

        Do

            coinValue = Int(Console.ReadLine())
            Total = Total + coinValue


        Loop Until Total >= price

        changeDue = Total - price

        If changeDue > 0 Then
            outputChange(changeDue)
        Else
            Console.WriteLine("No change")
        End If


    End Sub

End Module
