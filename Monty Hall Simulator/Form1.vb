Public Class Form1
  Private randomGenerator As New Random()

  ''' <summary>
  ''' Starts the simulation.
  ''' The simulator will fill three doors with one winning prize and two losing prizes.
  ''' The player will choose one of three doors at random without knowing anything about the doors.
  ''' The host will choose one of the losing doors.
  ''' The player will then choose to stay with their original choice or switch to the remaining unopened door.
  ''' The game will be played for the number of iterations specified.
  ''' A win rate will be computed and returned.
  ''' </summary>
  ''' <param name="switchDoors">Determines whether the player will always switch to the remaining unopened door or stay with the original chosen door.</param>
  ''' <returns>A percentage win rate of the simulation</returns>
  ''' <remarks></remarks>
  Private Function Simulate(iterations As Int32, switchDoors As Boolean) As Decimal ' returns win rate

    Dim doors(2) As Int32 ' 0 = goat, 1 = car
    Dim winCount As Int32 = 0

    For test As Int32 = 1 To iterations
      PlacePrizes(doors)
      Dim chosenDoor As Int32 = GuessDoor()
      Dim hostGoatDoor As Int32 = HostDoor(doors, chosenDoor)
      Dim remainingUnopenedDoor As Int32 = RemainingDoor(chosenDoor, hostGoatDoor)
      Dim win As Boolean = ChooseDoor(doors, chosenDoor, remainingUnopenedDoor, switchDoors)

      If win Then winCount = winCount + 1

    Next

    Return winCount / iterations

  End Function

  ''' <summary>
  ''' This method will test to see if the chosenDoor is the winning door, unless the player
  ''' has chosen to switch doors, in which case it will test to see if the remainingUnopenedDoor is the winning door.
  ''' </summary>
  ''' <param name="doors">The array of doors</param>
  ''' <param name="chosenDoor">The door that the player has chosen</param>
  ''' <param name="remainingUnopenedDoor">The remaining unopened door</param>
  ''' <param name="switchDoors">Directs the logic to either stay with the chosenDoor or switch to the remainingUnopenedDoor</param>
  ''' <returns>TRUE if a winning door was chosen, FALSE if a losing door was chosen</returns>
  ''' <remarks>One of these two doors (chosenDoor or remainingUnopenedDoor) is a winner.
  ''' So, it would appear there would be just a 50% chance of getting it right.
  ''' But, the simulation proves otherwise.
  ''' </remarks>
  Private Function ChooseDoor(doors() As Int32, chosenDoor As Int32, remainingUnopenedDoor As Int32, switchDoors As Boolean) As Boolean

    If switchDoors Then
      Return doors(remainingUnopenedDoor) = 1
    Else
      Return doors(chosenDoor) = 1
    End If

  End Function

  ''' <summary>
  ''' Given the player's chosen door and the host's chosen losing door, this method returns the last remaining losing door.
  ''' </summary>
  ''' <param name="chosenDoor">The door the player has chosen</param>
  ''' <param name="hostLosingDoor">One of the two losing doors the host has chosen</param>
  ''' <returns>The remaining losing door</returns>
  ''' <remarks></remarks>
  Private Function RemainingDoor(chosenDoor As Int32, hostLosingDoor As Int32) As Int32
    For door As Int32 = 0 To 2
      If door <> chosenDoor And door <> hostLosingDoor Then Return door
    Next
  End Function

  ''' <summary>
  ''' This method fills an array of 3 doors, one of which has a winning prize (1) and the other two losing prizes (0).
  ''' It places the winning prize at random.
  ''' </summary>
  ''' <param name="doors">The array of doors.</param>
  ''' <remarks></remarks>
  Private Sub PlacePrizes(ByRef doors() As Int32)

    Dim carDoor As Int32 = randomGenerator.Next(0, 3)
    For doorNumber As Int32 = 0 To 2
      If doorNumber = carDoor Then
        doors(doorNumber) = 1
      Else
        doors(doorNumber) = 0
      End If
    Next

  End Sub

  ''' <summary>
  ''' This method simply chooses one of three doors at random, with no knowledge of what is behind any of  doors.
  ''' </summary>
  ''' <returns>A randomly-chosen door</returns>
  ''' <remarks></remarks>
  Private Function GuessDoor() As Int32
    Dim randomGenerator As New Random
    Dim chosenDoor As Int32 = randomGenerator.Next(0, 3)
    Return chosenDoor
  End Function

  ''' <summary>
  ''' Given that the player has chosen a door and that the host knows which door has the winning prize,
  ''' this method will return the last remaining losing door.  Or, if the player's chosen door is the winning door,
  ''' this method will return one of the two losing doors at random.
  ''' </summary>
  ''' <param name="doors">The array of doors</param>
  ''' <param name="chosenDoor">The door the player chose</param>
  ''' <returns>A losing door</returns>
  ''' <remarks></remarks>
  Private Function HostDoor(doors() As Int32, chosenDoor As Int32) As Int32
    ' will return one of the goat doors that is NOT the chosenDoor at random
    Dim goatDoor1 As Int32
    Dim goatDoor2 As Int32

    If doors(chosenDoor) = 1 Then
      ' the contestant has chosen the winning door
      If chosenDoor = 0 Then
        goatDoor1 = 1
        goatDoor2 = 2
      End If
      If chosenDoor = 1 Then
        goatDoor1 = 0
        goatDoor2 = 2
      End If
      If chosenDoor = 2 Then
        goatDoor1 = 0
        goatDoor2 = 1
      End If

      Select Case randomGenerator.Next(1, 3)
        Case 1
          Return goatDoor1
        Case 2
          Return goatDoor2
      End Select
    Else
      ' the contestant chose a goat door
      ' reveal the other goat door
      For door As Int32 = 0 To 2
        If doors(door) = 0 And door <> chosenDoor Then
          Return door
        End If
      Next
    End If

  End Function

  Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
    Me.Cursor = Cursors.WaitCursor
    stayingResult.Text = CInt(Simulate(CInt(iterations.Text), False) * 100).ToString & "%"
    switchingResult.Text = CInt(Simulate(CInt(iterations.Text), True) * 100).ToString & "%"
    Me.Cursor = Cursors.Default
  End Sub
End Class
