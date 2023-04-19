Public Class frmInterface
    Public numTurns = 13 'total number of turns allowed per game
    Public randNum1 As Integer = 0 'Random number placeholders
    Public randNum2 As Integer = 0
    Public randNum3 As Integer = 0
    Public randNum4 As Integer = 0
    Public randNum5 As Integer = 0
    Public randArr = New Integer() {0, 0, 0, 0, 0} 'Random array for later use
    Public rollsLeft = 3
    Public boolVar As Integer = 0
    Public playerTurn As Boolean = True 'Player turn boolean

    Private Sub frmInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim theDate As Date = Today
        lblDate.Text = theDate.ToString("D") 'Output current date
        lblUserName.Text = frmYahtzee.userName

        picDieOne.Visible = False
        picDieTwo.Visible = False       'hide kept dice'
        picDieThree.Visible = False
        picDieFour.Visible = False
        picDieFive.Visible = False

        picDie1.Enabled = False
        picDie2.Enabled = False
        picDie3.Enabled = False
        picDie4.Enabled = False
        picDie5.Enabled = False



        MessageBox.Show("Attention, click on dice to keep and roll the rest!", "HELP",
                          MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmYahtzee.Close()
        Me.Close()
    End Sub

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        If (playerTurn = True) Then


            Dim nums = New Integer() {0, 0, 0, 0, 0}
            Dim grandTotal = 0
            Dim bonus As Integer = 0
            If rollsLeft = 3 Then
                boolVar = 0
                randArr = nums
                nums = runRand(nums)


                randNum1 = nums(0)
                randNum2 = nums(1)
                randNum3 = nums(2)
                randNum4 = nums(3)
                randNum5 = nums(4)

                'seperate select case statements for seperate dice in us with random nunber placeholders

                Select Case randNum1
                    Case 1
                        picDie1.Image = My.Resources._1a
                    Case 2
                        picDie1.Image = My.Resources._2a
                    Case 3
                        picDie1.Image = My.Resources._3a
                    Case 4
                        picDie1.Image = My.Resources._4a
                    Case 5
                        picDie1.Image = My.Resources._5a
                    Case 6
                        picDie1.Image = My.Resources.six
                End Select



                Select Case randNum2
                    Case 1
                        picDie2.Image = My.Resources._1a
                    Case 2
                        picDie2.Image = My.Resources._2a
                    Case 3
                        picDie2.Image = My.Resources._3a
                    Case 4
                        picDie2.Image = My.Resources._4a
                    Case 5
                        picDie2.Image = My.Resources._5a
                    Case 6
                        picDie2.Image = My.Resources.six
                End Select


                Select Case randNum3
                    Case 1
                        picDie3.Image = My.Resources._1a
                    Case 2
                        picDie3.Image = My.Resources._2a
                    Case 3
                        picDie3.Image = My.Resources._3a
                    Case 4
                        picDie3.Image = My.Resources._4a
                    Case 5
                        picDie3.Image = My.Resources._5a
                    Case 6
                        picDie3.Image = My.Resources.six
                End Select


                Select Case randNum4
                    Case 1
                        picDie4.Image = My.Resources._1a
                    Case 2
                        picDie4.Image = My.Resources._2a
                    Case 3
                        picDie4.Image = My.Resources._3a
                    Case 4
                        picDie4.Image = My.Resources._4a
                    Case 5
                        picDie4.Image = My.Resources._5a
                    Case 6
                        picDie4.Image = My.Resources.six
                End Select


                Select Case randNum5
                    Case 1
                        picDie5.Image = My.Resources._1a
                    Case 2
                        picDie5.Image = My.Resources._2a
                    Case 3
                        picDie5.Image = My.Resources._3a
                    Case 4
                        picDie5.Image = My.Resources._4a
                    Case 5
                        picDie5.Image = My.Resources._5a
                    Case 6
                        picDie5.Image = My.Resources.six
                End Select


                picDie1.Enabled = True
                picDie2.Enabled = True
                picDie3.Enabled = True  'enable clickable dice after first roll is executed
                picDie4.Enabled = True
                picDie5.Enabled = True





                rollsLeft -= 1
                lblNumRollsActual.Text = rollsLeft.ToString










            ElseIf (rollsLeft > 0) And (rollsLeft < 3) Then


                rollsLeft -= 1
                lblNumRollsActual.Text = rollsLeft.ToString

                'kept dice will be excluded from new roll and random function with updated pictures using select case statements
                If picDie1.Enabled = True Then
                    'Run random function again with nums array then update the global array randArray
                    nums = runRand(nums)
                    randNum1 = nums(0)
                    randArr(0) = nums(0)

                    Select Case randNum1
                        Case 1
                            picDie1.Image = My.Resources._1a
                        Case 2
                            picDie1.Image = My.Resources._2a
                        Case 3
                            picDie1.Image = My.Resources._3a
                        Case 4
                            picDie1.Image = My.Resources._4a
                        Case 5
                            picDie1.Image = My.Resources._5a
                        Case 6
                            picDie1.Image = My.Resources.six
                    End Select
                End If

                If picDie2.Enabled = True Then
                    nums = runRand(nums)
                    randNum2 = nums(1)
                    randArr(1) = nums(1)

                    Select Case randNum2
                        Case 1
                            picDie2.Image = My.Resources._1a
                        Case 2
                            picDie2.Image = My.Resources._2a
                        Case 3
                            picDie2.Image = My.Resources._3a
                        Case 4
                            picDie2.Image = My.Resources._4a
                        Case 5
                            picDie2.Image = My.Resources._5a
                        Case 6
                            picDie2.Image = My.Resources.six
                    End Select
                End If


                If picDie3.Enabled = True Then
                    nums = runRand(nums)
                    randNum3 = nums(2)
                    randArr(2) = nums(2)


                    Select Case randNum3
                        Case 1
                            picDie3.Image = My.Resources._1a
                        Case 2
                            picDie3.Image = My.Resources._2a
                        Case 3
                            picDie3.Image = My.Resources._3a
                        Case 4
                            picDie3.Image = My.Resources._4a
                        Case 5
                            picDie3.Image = My.Resources._5a
                        Case 6
                            picDie3.Image = My.Resources.six
                    End Select
                End If

                If picDie4.Enabled = True Then
                    nums = runRand(nums)
                    randNum4 = nums(3)
                    randArr(3) = nums(3)


                    Select Case randNum4
                        Case 1
                            picDie4.Image = My.Resources._1a
                        Case 2
                            picDie4.Image = My.Resources._2a
                        Case 3
                            picDie4.Image = My.Resources._3a
                        Case 4
                            picDie4.Image = My.Resources._4a
                        Case 5
                            picDie4.Image = My.Resources._5a
                        Case 6
                            picDie4.Image = My.Resources.six
                    End Select
                End If

                If picDie5.Enabled = True Then
                    nums = runRand(nums)
                    randNum5 = nums(4)
                    randArr(4) = nums(4)


                    Select Case randNum5
                        Case 1
                            picDie5.Image = My.Resources._1a
                        Case 2
                            picDie5.Image = My.Resources._2a
                        Case 3
                            picDie5.Image = My.Resources._3a
                        Case 4
                            picDie5.Image = My.Resources._4a
                        Case 5
                            picDie5.Image = My.Resources._5a
                        Case 6
                            picDie5.Image = My.Resources.six
                    End Select
                End If

                'Check for selected score box
                If boolVar = 1 Then
                        rollsLeft = 0
                        lblNumRollsActual.Text = rollsLeft.ToString
                    MessageBox.Show("Attention, Entry move executed! Click ROLL to END Current Turn", "Turn " & numTurns.ToString & " completed",
                               MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If




                'end of rolls for turn
            ElseIf rollsLeft = 0 Then

                picDie1.Enabled = True
                picDie1.Visible = True
                picDieOne.Visible = False

                picDie2.Enabled = True
                picDie2.Visible = True
                picDieTwo.Visible = False

                picDie3.Enabled = True
                picDie3.Visible = True
                picDieThree.Visible = False

                picDie4.Enabled = True
                picDie4.Visible = True
                picDieFour.Visible = False

                picDie5.Enabled = True
                picDie5.Visible = True
                picDieFive.Visible = False

                If boolVar <> 1 Then
                    MessageBox.Show("Error, Please select a box and make a move to advance to next turn", "Selection Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                Else

                    MessageBox.Show("Dice Reset, Please click roll to start next turn!", "Roll Reset",
                     MessageBoxButtons.OK, MessageBoxIcon.Information)

                    numTurns -= 1
                    lblNumTurnsLeft.Text = numTurns.ToString

                    picDie1.Enabled = False
                    picDie2.Enabled = False
                    picDie3.Enabled = False
                    picDie4.Enabled = False
                    picDie5.Enabled = False

                    'if turns left is not 0
                    If numTurns > 0 Then
                        rollsLeft = 3

                        lblNumRollsActual.Text = rollsLeft.ToString

                        'turns left is 0 
                    ElseIf numTurns = 0 Then
                        Dim preTotal As Integer = 0
                        'Add pretotal for upper score card
                        preTotal += CInt(lblAcesBox.Text)
                        preTotal += CInt(lblTwosBox.Text)
                        preTotal += CInt(lblThreesBox.Text)
                        preTotal += CInt(lblFoursBox.Text)
                        preTotal += CInt(lblFivesBox.Text)
                        preTotal += CInt(lblSixesBox.Text)

                        lblTotalScoreUpperBox.Text = preTotal.ToString
                        'Add bonus if applicable
                        If preTotal >= 65 Then
                            bonus = 65
                        End If

                        lblBonusBox.Text = bonus.ToString
                        'output total upper score
                        Dim totalUpper As Integer = 0
                        totalUpper = preTotal + bonus
                        lblUpperTotalActualBox.Text = totalUpper.ToString
                        'output total lower score
                        Dim totalLower As Integer = 0
                        totalLower += CInt(lblThreeOfAKindBox.Text)
                        totalLower += CInt(lblFourOfAKindBox.Text)
                        totalLower += CInt(lblFullHouseBox.Text)
                        totalLower += CInt(lblSmallStraightBox.Text)
                        totalLower += CInt(lblLargeStraightBox.Text)
                        totalLower += CInt(lblYahtzeeBox.Text)
                        totalLower += CInt(lblChanceBox.Text)

                        lblTotalScoreLowerBox.Text = totalLower.ToString
                        'output total
                        grandTotal = totalLower + totalUpper
                        lblGrandTotal.Visible = True
                        lblGrandActual.Text = grandTotal.ToString
                        lblGrandActual.Visible = True
                        lblGameOver.Visible = True
                        playerTurn = False
                    End If
                End If
            End If

        Else
            MessageBox.Show("Game over, thank you for playing", "Game Over",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub lblAcesBox_Click(sender As Object, e As EventArgs) Handles lblAcesBox.Click
        'Aces scorebox

        If lblAcesBox.Text = String.Empty Then
            boolVar += 1
            'Check if boolean is more than one to make only one box per turn clickable and reset boolean
            If boolVar > 1 Then
                MessageBox.Show("Error, only one box can be used per turn", "Selection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                boolVar -= 1
                Return
            End If
            'Loop to add score if value at each index is equal to one
            Dim labelScore As Integer = 0
            Dim i As Integer = 0
            For i = 0 To randArr.length - 1
                If (randArr(i) = 1) Then
                    labelScore += 1
                End If
            Next
            lblAcesBox.Text = labelScore.ToString
            'output Aces total
        End If
    End Sub

    Private Sub lblTwosBox_Click(sender As Object, e As EventArgs) Handles lblTwosBox.Click
        If lblTwosBox.Text = String.Empty Then
            boolVar += 1
            'Check if boolean is more than one to make only one box per turn clickable and reset boolean
            If boolVar > 1 Then
                MessageBox.Show("Error, only one box can be used per turn", "Selection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                boolVar -= 1
                Return
            End If

            Dim labelScore As Integer = 0
            Dim i As Integer = 0
            For i = 0 To randArr.length - 1
                If (randArr(i) = 2) Then
                    labelScore += 2
                End If
            Next
            lblTwosBox.Text = labelScore.ToString
            'output Twos total
        End If
    End Sub

    Private Sub lblThreesBox_Click(sender As Object, e As EventArgs) Handles lblThreesBox.Click
        If lblThreesBox.Text = String.Empty Then
            boolVar += 1
            'Check boolean to make sure only one box is clicked per turn
            If boolVar > 1 Then
                MessageBox.Show("Error, only one box can be used per turn", "Selection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                boolVar -= 1
                Return
            End If

            Dim labelScore As Integer = 0
            Dim i As Integer = 0
            For i = 0 To randArr.length - 1
                If (randArr(i) = 3) Then
                    labelScore += 3
                End If
            Next
            lblThreesBox.Text = labelScore.ToString
            'Output Threes total
        End If
    End Sub

    Private Sub lblFoursBox_Click(sender As Object, e As EventArgs) Handles lblFoursBox.Click
        If lblFoursBox.Text = String.Empty Then
            boolVar += 1
            If boolVar > 1 Then
                MessageBox.Show("Error, only one box can be used per turn", "Selection Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
                boolVar -= 1
                Return
            End If

            Dim labelScore As Integer = 0
            Dim i As Integer = 0
            For i = 0 To randArr.length - 1
                If (randArr(i) = 4) Then
                    labelScore += 4
                End If
            Next
            lblFoursBox.Text = labelScore.ToString

        End If
    End Sub

    Private Sub lblFivesBox_Click(sender As Object, e As EventArgs) Handles lblFivesBox.Click
        If lblFivesBox.Text = String.Empty Then
            boolVar += 1
            If boolVar > 1 Then
                MessageBox.Show("Error, only one box can be used per turn", "Selection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                boolVar -= 1
                Return
            End If

            Dim labelScore As Integer = 0
            Dim i As Integer = 0
            For i = 0 To randArr.length - 1
                If (randArr(i) = 5) Then
                    labelScore += 5
                End If
            Next
            lblFivesBox.Text = labelScore.ToString

        End If
    End Sub
    'Dice click subs to change dice image visible and enabled properties during gameplay
    Private Sub picDie1_Click(sender As Object, e As EventArgs) Handles picDie1.Click
        picDie1.Enabled = False
        picDie1.Visible = False
        picDieOne.Image = picDie1.Image
        picDieOne.Visible = True
    End Sub

    Private Sub picDie2_Click(sender As Object, e As EventArgs) Handles picDie2.Click
        picDie2.Enabled = False
        picDie2.Visible = False
        picDieTwo.Visible = True
        picDieTwo.Image = picDie2.Image
    End Sub

    Private Sub picDie3_Click(sender As Object, e As EventArgs) Handles picDie3.Click
        picDie3.Enabled = False
        picDie3.Visible = False
        picDieThree.Visible = True
        picDieThree.Image = picDie3.Image
    End Sub


    Private Sub picDie4_Click(sender As Object, e As EventArgs) Handles picDie4.Click
        picDie4.Enabled = False
        picDie4.Visible = False
        picDieFour.Visible = True
        picDieFour.Image = picDie4.Image
    End Sub

    Private Sub picDie5_Click(sender As Object, e As EventArgs) Handles picDie5.Click
        picDie5.Enabled = False
        picDie5.Visible = False
        picDieFive.Visible = True
        picDieFive.Image = picDie5.Image
    End Sub



    Private Sub lblThreeOfAKindBox_Click(sender As Object, e As EventArgs) Handles lblThreeOfAKindBox.Click
        If lblThreeOfAKindBox.Text = String.Empty Then
            boolVar += 1
            'Check boolean
            If boolVar > 1 Then
                MessageBox.Show("Error, only one box can be used per turn", "Selection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                boolVar -= 1
                Return
            End If
            'Nested loops to check for three of a kind dice when clicked
            Dim labelScore As Integer = 0
            Dim i As Integer = 0
            Dim j As Integer = 0
            Dim count As Integer = 0
            Dim boolX As Boolean = False
            For i = 0 To randArr.length - 1
                count = 0
                For j = 0 To randArr.length - 1
                    If randArr(i) = randArr(j) Then
                        count += 1
                        If (count = 3) Then
                            boolX = True
                        End If
                    End If
                Next
            Next

            If boolX = True Then
                For i = 0 To randArr.length - 1
                    labelScore += randArr(i)
                Next
                boolX = False

            End If

            lblThreeOfAKindBox.Text = labelScore.ToString
            'Output label score
        End If
    End Sub

    Private Sub lblFourOfAKindBox_Click(sender As Object, e As EventArgs) Handles lblFourOfAKindBox.Click
        If lblFourOfAKindBox.Text = String.Empty Then
            boolVar += 1
            If boolVar > 1 Then
                MessageBox.Show("Error, only one box can be used per turn", "Selection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                boolVar -= 1
                Return
            End If
            'Nested loops to check for four of a kind dice when clicked
            Dim labelScore As Integer = 0
            Dim i As Integer = 0
            Dim j As Integer = 0
            Dim count As Integer = 0
            Dim boolX As Boolean = False
            For i = 0 To randArr.length - 1
                count = 0
                For j = 0 To randArr.length - 1
                    If randArr(i) = randArr(j) Then
                        count += 1
                        If (count = 4) Then
                            boolX = True
                        End If
                    End If
                Next
            Next

            If boolX = True Then
                For i = 0 To randArr.length - 1
                    labelScore += randArr(i)
                Next
                boolX = False

            End If

            lblFourOfAKindBox.Text = labelScore.ToString
            'Output labelscore to four a kind box
        End If
    End Sub

    Private Sub lblYahtzeeBox_Click(sender As Object, e As EventArgs) Handles lblYahtzeeBox.Click
        If lblYahtzeeBox.Text = String.Empty Then
            boolVar += 1
            If boolVar > 1 Then
                MessageBox.Show("Error, only one box can be used per turn", "Selection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                boolVar -= 1
                Return
            End If

            Dim labelScore = 0
            If (lblYahtzeeBox.Text <> String.Empty) Then
                labelScore = Integer.Parse(lblYahtzeeBox.Text)
            End If

            Dim i As Integer = 0
                Dim j As Integer = 0
                Dim count As Integer = 0
                Dim boolX As Boolean = False
                For i = 0 To randArr.length - 1
                    count = 0
                    For j = 0 To randArr.length - 1
                        If randArr(i) = randArr(j) Then
                            count += 1
                            If (count = 5) Then
                                boolX = True
                            End If
                        End If
                    Next
                Next

                If boolX = True Then
                    labelScore += 50
                    boolX = False

                End If

                lblYahtzeeBox.Text = labelScore.ToString

            End If
    End Sub

    Private Sub lblSmallStraightBox_Click(sender As Object, e As EventArgs) Handles lblSmallStraightBox.Click
        If lblSmallStraightBox.Text = String.Empty Then
            boolVar += 1
            If boolVar > 1 Then
                MessageBox.Show("Error, only one box can be used per turn", "Selection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                boolVar -= 1
                Return
            End If

            Dim i As Integer = 0
            Dim k As Integer = 0
            Dim temp As Integer = 0
            Dim consecs As Integer = 0
            Dim labelScore As Integer = 0
            Dim temp2 As Integer = 0


            randArr = runSort(randArr)

            For i = 0 To randArr.length - 1
                temp = randArr(i)
                consecs = 0
                For k = 0 To randArr.length - 1
                    temp2 = randArr(k)
                    If temp2 = temp Then
                        consecs += 1
                        temp += 1
                    End If
                Next
                If consecs = 4 Then
                    labelScore = 30
                    lblSmallStraightBox.Text = labelScore.ToString
                    Return
                Else
                    lblSmallStraightBox.Text = labelScore.ToString
                End If
            Next

        End If
    End Sub

    Private Sub lblLargeStraightBox_Click(sender As Object, e As EventArgs) Handles lblLargeStraightBox.Click
        If lblLargeStraightBox.Text = String.Empty Then
            boolVar += 1
            If boolVar > 1 Then
                MessageBox.Show("Error, only one box can be used per turn", "Selection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                boolVar -= 1
                Return
            End If

            Dim i As Integer = 0
            Dim k As Integer = 0
            Dim temp As Integer = 0
            Dim consecs As Integer = 0
            Dim labelScore As Integer = 0
            Dim temp2 As Integer = 0

            'Call sorting function
            randArr = runSort(randArr)

            'Create a temp value to hold first index of sorted array then increment through each iteration 
            'Check if the second  for matching values
            For i = 0 To randArr.length - 1
                temp = randArr(i)
                consecs = 0
                For k = 0 To randArr.length - 1
                    temp2 = randArr(k)
                    If temp2 = temp Then
                        consecs += 1
                        temp += 1
                    End If
                Next
                If consecs = 5 Then
                    labelScore = 40
                    lblLargeStraightBox.Text = labelScore.ToString
                    Return
                Else
                    lblLargeStraightBox.Text = labelScore.ToString
                End If
            Next

        End If
    End Sub

    Private Sub lblChanceBox_Click(sender As Object, e As EventArgs) Handles lblChanceBox.Click
        If lblChanceBox.Text = String.Empty Then
            boolVar += 1
            If boolVar > 1 Then
                MessageBox.Show("Error, only one box can be used per turn", "Selection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                boolVar -= 1
                Return
            End If



            'Add all dice values and output result
            Dim labelScore = 0
            For i = 0 To randArr.length - 1
                labelScore += randArr(i)
            Next

            lblChanceBox.Text = labelScore.ToString
        End If

    End Sub

    Private Sub lblFullHouseBox_Click(sender As Object, e As EventArgs) Handles lblFullHouseBox.Click
        If lblFullHouseBox.Text = String.Empty Then
            boolVar += 1
            If boolVar > 1 Then
                MessageBox.Show("Error, only one box can be used per turn", "Selection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                boolVar -= 1
                Return
            End If

            Dim labelScore As Integer = 0
            Dim thisCount As Integer = 0
            Dim i As Integer = 0
            Dim k As Integer = 0
            Dim boolX = False
            Dim boolY = False
            'Create two booleans and check them to be true through each iteration of the nested loops


            For i = 0 To randArr.length - 1
                thisCount = 0
                For k = 0 To randArr.length - 1
                    If randArr(i) = randArr(k) Then
                        thisCount += 1
                        If thisCount = 2 Then
                            boolX = True

                        ElseIf thisCount = 3 Then
                            boolY = True
                            End If

                        End If
                Next
            Next
            If (boolX = True) And (boolY = True) Then
                labelScore = 25
            End If
            lblFullHouseBox.Text = labelScore.ToString
        End If
    End Sub

    Private Sub lblSixesBox_Click(sender As Object, e As EventArgs) Handles lblSixesBox.Click
        If lblSixesBox.Text = String.Empty Then
            boolVar += 1
            If boolVar > 1 Then
                MessageBox.Show("Error, only one box can be used per turn", "Selection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                boolVar -= 1
                Return
            End If

            Dim labelScore As Integer = 0
            Dim i As Integer = 0
            For i = 0 To randArr.length - 1
                If (randArr(i) = 6) Then
                    labelScore += 6
                End If
            Next
            lblSixesBox.Text = labelScore.ToString

        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Reset button click sub
        'Reset num turns and random number placeholders and random array
        'Reset player turn and boolean
        numTurns = 13
        randNum1 = 0
        randNum2 = 0
        randNum3 = 0
        randNum4 = 0
        randNum5 = 0
        randArr = New Integer() {0, 0, 0, 0, 0}
        rollsLeft = 3
        boolVar = 0
        playerTurn = True

        'Reset all labels

        lblAcesBox.Text = String.Empty
        lblTwosBox.Text = String.Empty
        lblThreesBox.Text = String.Empty
        lblFoursBox.Text = String.Empty
        lblFivesBox.Text = String.Empty
        lblSixesBox.Text = String.Empty
        lblBonusBox.Text = String.Empty
        lblTotalScoreUpperBox.Text = String.Empty

        lblNumRollsActual.Text = "3"
        lblNumTurnsLeft.Text = "13"

        lblUpperTotalActualBox.Text = String.Empty
        lblGameOver.Visible = False


        lblThreeOfAKindBox.Text = String.Empty
        lblFourOfAKindBox.Text = String.Empty
        lblFullHouseBox.Text = String.Empty
        lblSmallStraightBox.Text = String.Empty
        lblLargeStraightBox.Text = String.Empty
        lblYahtzeeBox.Text = String.Empty
        lblChanceBox.Text = String.Empty

        lblTotalScoreLowerBox.Text = String.Empty


        lblGrandTotal.Visible = False
        lblGrandActual.Text = String.Empty
        lblGrandActual.Visible = False

        'Reset focus to roll btn when loaded
        btnRoll.Focus()
        'Reset pic boxes
        picDie1.Visible = True
        picDie2.Visible = True
        picDie3.Visible = True
        picDie4.Visible = True
        picDie5.Visible = True




    End Sub
    'Kept dice reset on click subs
    Private Sub picDieOne_Click(sender As Object, e As EventArgs) Handles picDieOne.Click
        picDieOne.Visible = False
        picDie1.Visible = True
        picDie1.Enabled = True

    End Sub

    Private Sub picDieTwo_Click(sender As Object, e As EventArgs) Handles picDieTwo.Click
        picDieTwo.Visible = False
        picDie2.Visible = True
        picDie2.Enabled = True
    End Sub

    Private Sub picDieThree_Click(sender As Object, e As EventArgs) Handles picDieThree.Click
        picDieThree.Visible = False
        picDie3.Visible = True
        picDie3.Enabled = True
    End Sub

    Private Sub picDieFour_Click(sender As Object, e As EventArgs) Handles picDieFour.Click
        picDieFour.Visible = False
        picDie4.Visible = True
        picDie4.Enabled = True
    End Sub

    Private Sub picDieFive_Click(sender As Object, e As EventArgs) Handles picDieFive.Click
        picDieFive.Visible = False
        picDie5.Visible = True
        picDie5.Enabled = True
    End Sub


End Class