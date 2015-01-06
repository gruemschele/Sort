Imports System.Text
Module modAlgo
    Dim tmp

    ''' <summary>
    ''' Compares to items
    ''' </summary>
    ''' <param name="x">First Item</param>
    ''' <param name="y">Second Item</param>
    ''' <param name="boolSpecialCharacters">Is true if special characters should be checked</param>
    ''' <returns>Boolean if x is bigger than y</returns>
    ''' <remarks></remarks>
    Public Function isBigger(ByRef x, ByRef y, ByRef boolSpecialCharacters) As Boolean
        If boolSpecialCharacters Then
            Return String.Compare(x, y, Globalization.CultureInfo.CurrentCulture, Globalization.CompareOptions.IgnoreNonSpace) > 0
        Else
            Return String.Compare(x, y, Globalization.CultureInfo.CurrentCulture, Globalization.CompareOptions.Ordinal) > 0
        End If
    End Function

    ''' <summary>
    ''' Swap items in array
    ''' </summary>
    ''' <param name="array">array in which the items sould be swapped</param>
    ''' <param name="x">frist item</param>
    ''' <param name="y">second item</param>
    ''' <remarks></remarks>
    Public Sub swapItems(ByRef array, ByRef x, ByRef y)
        tmp = array(x)
        array(x) = array(y)
        array(y) = tmp
    End Sub

    ''' <summary>
    ''' Bubblesort with array
    ''' </summary>
    ''' <param name="inputArray">Array to be sorted</param>
    ''' <param name="boolSpecialCharacters">Is true if special characters should be checked</param>
    ''' <remarks></remarks>
    Public Sub array_bubblesort(ByRef inputArray, ByRef boolSpecialCharacters)
        Dim top As Integer = inputArray.Length - 2
        For j As Integer = 0 To inputArray.Length - 1
            For i As Integer = 0 To top
                If isBigger(inputArray(i), inputArray(i + 1), boolSpecialCharacters) Then
                    swapItems(inputArray, i, i + 1)
                    Application.DoEvents()
                End If
            Next
            top -= 1
        Next
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="inputArray">Array to be sorted</param>
    ''' <param name="boolSpecialCharacters">Is true if special characters should be checked</param>
    ''' <remarks></remarks>
    Public Sub array_quicksort(ByRef inputArray As Array, ByRef boolSpecialCharacters As Boolean)
        quicksort(inputArray, boolSpecialCharacters, 0, inputArray.Length - 1)
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="inputArray">Array to be sorted</param>
    ''' <param name="boolSpecialCharacters">Is true if special characters should be checked</param>
    ''' <param name="startPos">startposition in array</param>
    ''' <param name="endPos">endposition in array</param>
    ''' <remarks></remarks>
    Public Sub quicksort(ByRef inputArray, ByRef boolSpecialCharacters, ByVal startPos, ByVal endPos)
        Dim top = startPos
        Dim bottom = endPos
        Dim pivot = inputArray((startPos + endPos) \ 2)

        Do While top < bottom
            While isBigger(pivot, inputArray(top), boolSpecialCharacters)
                top = top + 1
                Application.DoEvents()
            End While

            While isBigger(inputArray(bottom), pivot, boolSpecialCharacters)
                bottom = bottom - 1
                Application.DoEvents()
            End While

            If top <= bottom Then
                swapItems(inputArray, top, bottom)
                top = top + 1
                bottom = bottom - 1
            End If

            Application.DoEvents()
        Loop

        If startPos < bottom Then
            quicksort(inputArray, boolSpecialCharacters, startPos, bottom)
        End If

        If endPos > top Then
            quicksort(inputArray, boolSpecialCharacters, top, endPos)
        End If
    End Sub


End Module
