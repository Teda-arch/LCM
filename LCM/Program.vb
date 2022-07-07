Imports System

Module Program
    Sub Main()
        'Define variables
        Dim num_1 As Integer = 0
        Dim num_2 As Integer = 0
        Dim x As Integer = 0
        Dim y As Integer = 0
        Dim init As Integer = 0

        'Collect input from the user
        Console.Write("Enter the First number: ")
        num_1 = Integer.Parse(Console.ReadLine())
        Console.Write("Enter the second number: ")
        num_2 = Integer.Parse(Console.ReadLine())
        x = num_1
        y = num_2

        'finding the hcf
        While Not (num_2 = 0)
            init = num_1 Mod num_2 'The modulus of mum_1 & num_2 is assigned to init
            num_1 = num_2
            num_2 = init
        End While

        'Defining a variable 'lmc' that calculates the L.C.M of the two numbers
        Dim lmc As Double
        lmc = (x * y) / num_1

        'Prints the value of lmc
        Console.Write("The Lowest Common Multiple is: " & lmc)

    End Sub
End Module
