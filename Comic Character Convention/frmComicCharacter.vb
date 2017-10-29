' Program:      Comic  Character
' Author:       Tu Tong
' Date:         October 29, 2017
' Purpose:      This Windows Desktop application computes the registration
'               cost of attending a Comic Character Convention

' Prevent automatic conversion of values
Option Strict On

Public Class frmComicCharacter

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' This event handler execute when user taps or click on Calculate button
        ' It calculates and display the registration cost 
        ' based on Badge type selection

        ' Declare registration fee constants
        Const cdecSuperheroBadge As Decimal = 330D
        Const cdecAutographsBadge As Decimal = 255D
        Const cdecRegularBadge As Decimal = 199D
        Const cdecPreviewNightFee As Decimal = 49D

        ' Declare variables
        Dim intGroupSize As Integer
        Dim decRegistrationFee As Decimal
        Dim decRegistrationCost As Decimal

        ' set the Registration cost label to $0
        ' to clear previous calculation
        lblRegistrationCost.Text = 0.ToString("C")

        ' This satisfy the restriction #1
        ' Did user enter a non-numeric value?
        If Not IsNumeric(txtGroupSize.Text) Then
            ' Display an error message box because user did not enter a number
            ' clear the group size textbox, set focus on Group size textbox
            ' and exit the function execution

            MsgBox("Please enter a number of people in your group",
                   MsgBoxStyle.Information, "Input Error")
            txtGroupSize.Clear()
            txtGroupSize.Focus()
            Return
        End If

        ' convert entered Group Size to integer
        intGroupSize = Convert.ToInt32(txtGroupSize.Text)

        ' This satisfy the restriction #2
        ' Is the entered value negative
        If intGroupSize <= 0 Then
            ' Display error message because user entered a negative for group size
            ' clear the group size textbox, set focus on Group size textbox
            ' and exit the function execution

            MsgBox("You entered " & intGroupSize.ToString() &
                   ". Please enter a valid number of people in your group",
                   MsgBoxStyle.Exclamation, "Input Error")
            txtGroupSize.Clear()
            txtGroupSize.Focus()
            Return
        End If

        ' This satisfy the restriction #3
        ' Is the entered value greater than 20
        If intGroupSize > 20 Then
            ' Display error message because user entered a value greater than 20
            ' clear the Group Size textbox, set focus on Group Size textbox
            ' and exit the function execution

            MsgBox("You entered " & intGroupSize.ToString() &
                   ". The number of people in your group have exceeded the limit.",
                   MsgBoxStyle.Exclamation, "Input Error")
            txtGroupSize.Clear()
            txtGroupSize.Focus()
            Return
        End If

        ' Determine registration fee
        If radConventionSuperhero.Checked Then
            decRegistrationFee = cdecSuperheroBadge
            Console.WriteLine("DebugInfo: Convention+Superhero is selected, the fee is: " &
                              decRegistrationFee.ToString("C"))
        ElseIf radConventionAutographs.Checked Then
            decRegistrationFee = cdecAutographsBadge
            Console.WriteLine("DebugInfo: Convention+Autographs is selected, the fee is: " &
                              decRegistrationFee.ToString("C"))
        ElseIf radConvention.Checked Then
            decRegistrationFee = cdecRegularBadge
            Console.WriteLine("DebugInfo: Convention is selected, the fee is: " &
                              decRegistrationFee.ToString("C"))
        End If

        ' calculate the registration cost
        decRegistrationCost = decRegistrationFee * intGroupSize

        ' Did user want Preview Night option
        If chkOptionalPreviewNight.Checked Then
            decRegistrationCost += cdecPreviewNightFee
            Console.WriteLine("DebugInfo: Added $49 Preview Night fee to the total cost")
        End If

        ' Displays the registration cost total
        lblRegistrationCost.Text = decRegistrationCost.ToString("C")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler is executed when user click on Clear button
        ' It clears the Group Size textbox, set Registration Cost to $0
        ' set Convention Superhero radio button to checked,
        ' clear other 2 radio buttons, set Preview Night checkbox to 
        ' checked, and set focus on Group size textbox.

        txtGroupSize.Clear()
        lblRegistrationCost.Text = 0.ToString("C")

        radConventionSuperhero.Checked = True
        radConventionAutographs.Checked = False
        radConvention.Checked = False

        chkOptionalPreviewNight.Checked = True

        txtGroupSize.Focus()

    End Sub

    Private Sub frmComicCharacter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event handler is executed when the Form loads
        ' It clear the placeholder for GroupSize textbox,
        ' set Registration Cost label to $0
        ' set focus on Group Size textbox

        txtGroupSize.Clear()
        lblRegistrationCost.Text = 0.ToString("C")
        txtGroupSize.Focus()

    End Sub
End Class
