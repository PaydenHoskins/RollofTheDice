'Payden Hoskins
'RCET2265
'Spring 2026
'RollofTheDice
'https://github.com/PaydenHoskins/RollofTheDice.git

Option Compare Text
Option Explicit On
Option Strict On

Public Class RollofTheDice
    Sub DiceCounter()
        'Test the randomness of the dice rolls
        Dim RollCounter(12) As Integer
        Dim headerRow
        Dim dataRow
        For i = 1 To 1000
            RollCounter(RandomNumber(1, 12)) += 1
        Next
        DiceListBox.Items.Add("Roll of the Dice".PadLeft(49))
        DiceListBox.Items.Add(StrDup(86, "-"))
        For i = 2 To UBound(RollCounter)
            headerRow &= ($"{CStr(i).PadLeft(4)}  |")
        Next
        DiceListBox.Items.Add(vbNewLine)
        For i = 2 To UBound(RollCounter)
            dataRow &= ($"{CStr(RollCounter(i)).PadLeft(4)}  |")
        Next
        DiceListBox.Items.Add($"   {headerRow}")
        DiceListBox.Items.Add(StrDup(86, "-"))
        DiceListBox.Items.Add($"   {dataRow}")
        DiceListBox.Items.Add(StrDup(86, "-"))
        DiceListBox.Items.Add(vbNewLine)
    End Sub

    Function RandomNumber(Min As Integer, Max As Integer) As Integer
        'Math.
        Dim Dice As Single
        Randomize()
        Dice = Rnd()
        Dice *= Max - Min
        Dice += Min
        Return CInt(Math.Ceiling(Dice))
    End Function
    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        'Call the sub to display the count of the dice
        DiceCounter()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DiceListBox.Items.Clear()
    End Sub
    Private Sub EndButton_Click(sender As Object, e As EventArgs) Handles EndButton.Click
        End
    End Sub
End Class
