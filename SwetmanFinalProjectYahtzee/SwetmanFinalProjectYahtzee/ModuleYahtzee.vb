Module ModuleYahtzee
    'Random function for dice rolls
    Function runRand(ByVal nums() As Integer) As Integer()

        Dim randoms As New Random
        Dim i As Integer = 0

        For i = 0 To nums.Length - 1
            nums(i) = randoms.Next(1, 7)
        Next

        Return nums
    End Function
    'Sorting function for dice array
    Function runSort(ByVal nums() As Integer) As Integer()
        Dim i As Integer = 0
        Dim temp As Integer = 0
        For k = 0 To nums.Length - 1
            For i = 0 To nums.Length - 1
                If nums(k) < nums(i) Then
                    temp = nums(i)
                    nums(i) = nums(k)
                    nums(k) = temp

                End If
            Next
        Next
        Return nums
    End Function


End Module
