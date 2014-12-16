Imports System.Text
Module modAlgo
    Dim tmp

    Public Function isBigger(ByRef x, ByRef y, ByRef boolSpecialCharacters) As Boolean
        If boolSpecialCharacters Then
            Return String.Compare(x, y, Globalization.CultureInfo.CurrentCulture, Globalization.CompareOptions.IgnoreNonSpace) > 0
        Else
            Return String.Compare(x, y, Globalization.CultureInfo.CurrentCulture, Globalization.CompareOptions.Ordinal) > 0
        End If
    End Function

    Public Sub swapItems(ByRef array, ByRef x, ByRef y)
        tmp = array(x)
        array(x) = array(y)
        array(y) = tmp
    End Sub

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

    Public Sub array_quicksort(ByRef inputArray As Array, ByRef boolSpecialCharacters As Boolean)
        quicksort(inputArray, boolSpecialCharacters, 0, inputArray.Length - 1)
    End Sub

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
