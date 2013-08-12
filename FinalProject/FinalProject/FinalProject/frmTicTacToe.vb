' Project:  TicTacToe / FinalProject
' Author:   Raphael Rouvinov
' Date:     5/22/2013
' Purpose:  Lets you play Tic tac toe with a friend

Option Strict On

Public Class frmTicTacToe

    ' Array of box labels (row, column)
    Private lblArray(2, 2) As Label

    ' Player Turn
    Private intTurn As Integer

    Private boolGameWon As Boolean = False
    Private boolCatsGame As Boolean = False
    Private boolAgainstComputer As Boolean = False

    ' This is the button a player clicks to do their turn
    ' Checks input for player, does computer turn if one player
    ' Checks whether game has finished and displays game finished message
    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

        Dim strRow As String
        Dim strCol As String
        Dim bytRow As Byte
        Dim bytCol As Byte
        strRow = mskRow.Text
        strCol = mskCol.Text

        ' Check for a numeric value
        If IsNumeric(strRow) AndAlso IsNumeric(strCol) Then

            ' row/column conversion
            bytRow = Convert.ToByte(strRow)
            bytCol = Convert.ToByte(strCol)

            ' Check for a valid number
            If bytRow >= 1 And bytRow <= 3 And bytCol >= 1 And bytCol <= 3 Then

                'Check if the spot is empty
                If lblArray(bytRow - 1, bytCol - 1).Text = "" Then

                    'Set the label to the appropriate text
                    If intTurn = 1 Then
                        lblArray(bytRow - 1, bytCol - 1).Text = "X"
                    Else
                        lblArray(bytRow - 1, bytCol - 1).Text = "O"
                    End If

                    ' Check whether the game has won 
                    boolGameWon = checkIfGameWon()

                    ' Play the computer if AI is on and check whether they won
                    If boolAgainstComputer And Not boolGameWon Then
                        computerAITurn()
                        boolGameWon = checkIfGameWon()
                        If boolGameWon Then
                            intTurn = 2
                        End If
                    End If

                    ' Check whether the game has tied
                    boolCatsGame = boxesFilled()

                    ' If the game hasn't won
                    If Not boolGameWon And Not boolCatsGame Then

                        ' Change the player
                        If intTurn = 1 Then
                            intTurn = 2
                            If boolAgainstComputer Then
                                intTurn = 1
                            End If
                        Else
                            intTurn = 1
                        End If

                        ' Set appropriate player label
                        lblPlayer.Text = "Player " & intTurn & "'s" & ControlChars.NewLine & "Turn"
                        mskRow.Focus()
                    Else
                        ' Else set win/tie screen
                        btnSubmit.Enabled = False
                        mnuSubmit.Enabled = False
                        If boolCatsGame And Not boolGameWon Then
                            lblPlayer.Text = "Cat's" & ControlChars.NewLine & "Game"
                        Else
                            lblPlayer.Text = "Player " & intTurn & ControlChars.NewLine & "WINS!"
                        End If
                        mskRow.Enabled = False
                        mskCol.Enabled = False
                    End If

                Else
                    MsgBox("Enter a value into a blank spot")
                End If
            Else
                MsgBox("Enter numbers between 1 and 3 please", , "Input Error")
            End If
        Else
            MsgBox("Invalid row or column entry", , "Input Error")
        End If

        mskRow.Focus()

        If Not boolGameWon Then
            mskRow.Clear()
            mskCol.Clear()
        End If

    End Sub

    ' This checks for a filled array by setting a bool to true and then
    ' Setting it to false if any spots are blank
    Private Function boxesFilled() As Boolean

        Dim boolBoxesFilled As Boolean = True
        For Each lbl In lblArray
            If lbl.Text = "" Then
                boolBoxesFilled = False
                Exit For
            End If
        Next

        If boolBoxesFilled Then
            Return True
        End If

        Return False
    End Function

    ' Starts a new game by clearing and reseting everything
    Private Sub btnNewGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewGame.Click

        For Each lblBox In lblArray
            lblBox.Text = ""
        Next
        intTurn = 1
        lblPlayer.Text = "Player 1's" & ControlChars.NewLine & "Turn"
        boolGameWon = False
        boolCatsGame = False
        btnSubmit.Enabled = True
        mnuSubmit.Enabled = True
        mskRow.Clear()
        mskCol.Clear()
        mskRow.Enabled = True
        mskCol.Enabled = True
        mskRow.Focus()

    End Sub

    ' The computer plays, changing a label to "O" if any are available
    Private Sub computerAITurn()

        If Not boxesFilled() Then

            ' Create an array of the blank labels
            Dim lblBlankArray(9) As Label
            Dim intArraySize As Integer = 0
            For Each lbl In lblArray
                If lbl.Text = "" Then
                    lblBlankArray(intArraySize) = lbl
                    intArraySize += 1
                End If
            Next

            ' Select a random value in the blank labels array and change its text
            Randomize()
            Dim intSelectedLabelIndex As Integer = CInt(Int(intArraySize * Rnd()))
            lblBlankArray(intSelectedLabelIndex).Text = "O"
        End If

    End Sub

    ' Initializes lblArray and starts a new game
    Private Sub frmTicTacToe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Initialize lblArray
        lblArray(0, 0) = lblTopLeft
        lblArray(0, 1) = lblTopCenter
        lblArray(0, 2) = lblTopRight
        lblArray(1, 0) = lblMiddleLeft
        lblArray(1, 1) = lblMiddleCenter
        lblArray(1, 2) = lblMiddleRight
        lblArray(2, 0) = lblBottomLeft
        lblArray(2, 1) = lblBottomCenter
        lblArray(2, 2) = lblBottomRight

        ' Start a new game
        btnNewGame_Click(sender, e)

    End Sub

    ' Determines whether a player has won the game
    ' By looking at the values of the lblArray
    Private Function checkIfGameWon() As Boolean

        For intPosition = 0 To 2
            'Check vertical bar
            Dim strTopOfBar As String = lblArray(0, intPosition).Text
            If strTopOfBar <> "" AndAlso strTopOfBar = lblArray(1, intPosition).Text AndAlso strTopOfBar = lblArray(2, intPosition).Text Then
                Return True
            End If

            'Check horizontal bar
            Dim strLeftOfBar As String = lblArray(intPosition, 0).Text
            If strLeftOfBar <> "" AndAlso strLeftOfBar = lblArray(intPosition, 1).Text AndAlso strLeftOfBar = lblArray(intPosition, 2).Text Then
                Return True
            End If
        Next

        'If the center isn't blank
        Dim strCenter As String = lblArray(1, 1).Text

        If strCenter <> "" Then
            'Check major diagonal
            If strCenter = lblArray(0, 0).Text AndAlso strCenter = lblArray(2, 2).Text Then
                Return True
            End If

            'Check minor diagonal
            If strCenter = lblArray(2, 0).Text AndAlso strCenter = lblArray(0, 2).Text Then
                Return True
            End If

        End If

        Return False

    End Function

    'New game button from the menu strip
    Private Sub mnuNewGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNewGame.Click
        btnNewGame_Click(sender, e)
    End Sub

    'Submit button from the menu strip
    Private Sub mnuSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSubmit.Click
        btnSubmit_Click(sender, e)
    End Sub

    ' Displays information about the program and the game
    Private Sub mnuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
        MsgBox("Developed by Raphael Rouvinov" & ControlChars.NewLine & _
               "Mr.Hoster's 4th Period, 4th term, 2013 at Mundelein High School" & ControlChars.NewLine & ControlChars.NewLine & _
               "Tic tac toe is played with two people or against a computer." & ControlChars.NewLine & _
               "The first player is ""X"" and the second player ""O""" & ControlChars.NewLine & _
               "Each player takes turns putting their mark on the board" & ControlChars.NewLine & _
               "Until one player gets 3 in a row diagonally, vertically, or horizontally" & ControlChars.NewLine & _
               "Or all the spaces are filled.", , "About")
    End Sub

    ' Lets player select a game mode: play against a computer or a person
    Private Sub mnuGameMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGameMode.Click
        Dim strPlayerCount As String
        Dim intPlayerCount As Integer

        strPlayerCount = InputBox("Enter 1 to play against the computer and 2 to play with two people", "Player Count", "2")

        ' Check input
        If IsNumeric(strPlayerCount) Then
            intPlayerCount = Convert.ToInt32(strPlayerCount)
            Dim boolCheckIfChanged As Boolean = boolAgainstComputer

            ' Change game mode and start new game if valid input and mode changed
            If intPlayerCount = 1 Then
                boolAgainstComputer = True
            ElseIf intPlayerCount = 2 Then
                boolAgainstComputer = False
            Else
                MsgBox("Enter 1 or 2", , "Input Error")
            End If
            If boolAgainstComputer <> boolCheckIfChanged Then
                btnNewGame_Click(sender, e)
            End If
        Else
            MsgBox("Enter 1 or 2", , "Input Error")
        End If

    End Sub

    ' Close the application
    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Close()
    End Sub

End Class
