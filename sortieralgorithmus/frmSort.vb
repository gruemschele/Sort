Imports sortieralgorithmus.modAlgo
Imports System.Text.RegularExpressions
Imports System.IO

Public Class frmSort
    Dim watch As Stopwatch = Stopwatch.StartNew()
    Dim firstCursor = Me.Cursor
    Dim userInput As Array

    Private Sub btnSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSort.Click, mnuEdit_itmSort.Click, toolStrp_btnSort.Click
        startProcessing()

        If chkWords.Checked Then
            userInput = Regex.Replace(txtInput.Text, "\s+", " ").Trim.Split()
        Else
            userInput = txtInput.Text.ToCharArray
        End If

        If userInput.Length > 0 Then
            Dim startTime = Date.Now
            callMethod(userInput)

            If chkWords.Checked Then
                If TypeOf userInput Is String() Then
                    txtOutput.Text = String.Join(" ", DirectCast(userInput, String()))
                Else
                    txtOutput.Text = String.Join("", userInput)
                End If

            Else
                txtOutput.Text = New String(userInput)
            End If

            Dim stopTime = Date.Now
            txtTime.Text = (stopTime - startTime).ToString
            stopProcessing()
        Else
            MsgBox("Bitte Text eingeben")
            stopProcessing()
        End If

    End Sub

    Private Sub callMethod(ByRef inputArray)
        Select Case cboSort.SelectedItem
            Case "quicksort"
                Call array_quicksort(inputArray, chkSpecialCharacters.Checked)
            Case "bubblesort"
                Call array_bubblesort(inputArray, chkSpecialCharacters.Checked)
        End Select
    End Sub

    Private Sub startProcessing()
        btnSort.Enabled = False
        txtInput.Enabled = False
        PictureBox1.Visible = True
        PictureBox1.BringToFront()
        Me.Cursor = Windows.Forms.Cursors.WaitCursor
    End Sub

    Private Sub stopProcessing()
        PictureBox1.Visible = False
        Me.Cursor = firstCursor
        btnSort.Enabled = True
        txtOutput.Enabled = True
        txtInput.Enabled = True
    End Sub

    Private Sub frmSort_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboSort.SelectedItem = "quicksort"
    End Sub

    ''======================
    ''      MENU FILE
    ''======================
    ''' <summary>
    ''' Checks if the "File" menu items, sould be enabled
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub mnuFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFile.Click
        If txtOutput.Text = Nothing Then
            mnuFile_itmSave.Enabled = False
        Else
            mnuFile_itmSave.Enabled = True
        End If
    End Sub

    ''' <summary>
    ''' Reset all fields
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub mnuFile_itmNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFile_itmNew.Click, toolStrp_btnNewFile.Click
        txtInput.Text = ""
        txtOutput.Text = ""
        txtTime.Text = ""
    End Sub

    ''' <summary>
    ''' Load a textfile in txtInput
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub mnuFile_itmOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFile_itmOpen.Click, toolStrp_btnOpenFile.Click
        Dim inputFile = fileDlgOpen.ShowDialog()
        If inputFile = Windows.Forms.DialogResult.OK Then
            Me.Show()
            Dim path As String = fileDlgOpen.FileName
            Try
                ' Read in text.
                Dim text As String = File.ReadAllText(path)

                ' For debugging.
                txtInput.Text = text

            Catch ex As Exception

                ' Report an error.
                MsgBox("Datei ungültig: " & ex.Message)

            End Try
        End If
    End Sub

    ''' <summary>
    ''' Saves the txtOutput to a Textfile
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub mnuFile_itmSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFile_itmSave.Click, toolStrp_btnSaveFile.Click
        If fileDlgSave.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim outputFile = fileDlgSave.ShowDialog()
            If outputFile = Windows.Forms.DialogResult.OK Then
                If (txtOutput.Text IsNot Nothing) Then
                    Try
                        System.IO.File.WriteAllText(fileDlgSave.FileName, txtOutput.Text)
                    Catch ex As Exception
                        MsgBox("Speichern fehlgeschlagen: " & ex.Message)
                    End Try
                End If
            End If
        End If
    End Sub

    ''' <summary>
    ''' Quits the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub mnuFile_itmQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFile_itmQuit.Click
        Me.Close()
        End
    End Sub

    ''======================
    ''      MENU EDIT
    ''======================
    ''' <summary>
    ''' Checks if the "Edit" menu items, sould be enabled
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        If TypeOf Me.ActiveControl Is TextBox Then
            mnuEdit_itmCut.Enabled = CType(Me.ActiveControl, TextBox).SelectionLength > 0
            mnuEdit_itmCopy.Enabled = CType(Me.ActiveControl, TextBox).SelectionLength > 0
            mnuEdit_itmPaste.Enabled = Clipboard.ContainsText
            mnuEdit_itmSort.Enabled = txtInput.Text.Length > 0
        End If
    End Sub

    ''' <summary>
    ''' Cut action handler
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub mnuEdit_itmCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit_itmCut.Click, toolStrp_btnCut.Click
        If TypeOf Me.ActiveControl Is TextBox Then
            CType(Me.ActiveControl, TextBox).Cut()
        End If
    End Sub

    ''' <summary>
    ''' Copy action Handler
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub mnuEdit_itmCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit_itmCopy.Click, toolStrp_btnCopy.Click
        If TypeOf Me.ActiveControl Is TextBox Then
            CType(Me.ActiveControl, TextBox).Copy()
        End If
    End Sub

    ''' <summary>
    ''' Paste action handler
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub mnuEdit_itmPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit_itmPaste.Click, toolStrp_btnPaste.Click
        If TypeOf Me.ActiveControl Is TextBox Then
            CType(Me.ActiveControl, TextBox).Paste()
        End If
    End Sub

    ''======================
    ''     MENU OPTIONS
    ''======================
    ''' <summary>
    ''' Special Characters Menu Handler
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub mnuOptions_itmSpecialCharacters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOptions_itmSpecialCharacters.Click
        chkSpecialCharacters.Checked = mnuOptions_itmSpecialCharacters.Checked
    End Sub

    ''' <summary>
    ''' Special Characters Checkbox Handler
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub chkSpecialCharacters_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSpecialCharacters.CheckedChanged
        mnuOptions_itmSpecialCharacters.Checked = chkSpecialCharacters.Checked
    End Sub

    ''' <summary>
    ''' Menu Color Handler
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub mnuEdit_itmColor_itmForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit_itmColor_itmForm.Click, mnuEdit_itmColor_itmTextbox.Click
        Dim currentColor As Color
        Select Case sender.Tag
            Case "frm"
                currentColor = Me.BackColor
                Exit Select
            Case "txtBox"
                currentColor = txtInput.BackColor
                Exit Select
            Case Else
                currentColor = Color.AliceBlue
        End Select

        clrDlgChoose.Color = currentColor

        Dim result = clrDlgChoose.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            Select Case sender.Tag
                Case "frm"
                    Me.BackColor = clrDlgChoose.Color
                    Exit Select
                Case "txtBox"
                    txtInput.BackColor = clrDlgChoose.Color
            End Select
        End If

    End Sub


    ''' <summary>
    ''' Checks which Toolbar Strip Icons in the the current state, should be enabled.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtInput_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInput.TextChanged, txtOutput.TextChanged, txtInput.MouseClick, txtOutput.MouseClick, txtInput.MouseEnter, txtOutput.MouseEnter

        If txtInput.TextLength > 1 Then
            toolStrp_btnSort.Enabled = True
        Else
            toolStrp_btnSort.Enabled = False
        End If

        If txtOutput.TextLength > 0 Then
            toolStrp_btnSaveFile.Enabled = True
        Else
            toolStrp_btnSaveFile.Enabled = False
        End If

        If txtInput.SelectionLength > 0 Or txtOutput.SelectionLength > 0 Then
            toolStrp_btnCopy.Enabled = True
            toolStrp_btnCut.Enabled = True
        Else
            toolStrp_btnCopy.Enabled = False
            toolStrp_btnCut.Enabled = False
        End If
    End Sub

End Class