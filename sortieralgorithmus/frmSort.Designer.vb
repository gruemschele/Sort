<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSort
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSort))
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cboSort = New System.Windows.Forms.ComboBox()
        Me.chkSpecialCharacters = New System.Windows.Forms.CheckBox()
        Me.chkWords = New System.Windows.Forms.CheckBox()
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.grpOutput = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFile_itmNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFile_itmOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFile_itmSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFile_itmQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit_itmCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit_itmCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit_itmPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuEdit_itmSort = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptions_itmSpecialCharacters = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuOptions_itmColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit_itmColor_itmForm = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit_itmColor_itmTextbox = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp_itmInformations = New System.Windows.Forms.ToolStripMenuItem()
        Me.fileDlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.fileDlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.clrDlgChoose = New System.Windows.Forms.ColorDialog()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolStrp_btnNewFile = New System.Windows.Forms.ToolStripButton()
        Me.toolStrp_btnOpenFile = New System.Windows.Forms.ToolStripButton()
        Me.toolStrp_btnSaveFile = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStrp_btnCopy = New System.Windows.Forms.ToolStripButton()
        Me.toolStrp_btnCut = New System.Windows.Forms.ToolStripButton()
        Me.toolStrp_btnPaste = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStrp_btnSort = New System.Windows.Forms.ToolStripButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInput.SuspendLayout()
        Me.grpOutput.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.mnuStrip.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInput.Location = New System.Drawing.Point(7, 19)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(443, 180)
        Me.txtInput.TabIndex = 1
        '
        'txtOutput
        '
        Me.txtOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutput.Enabled = False
        Me.txtOutput.Location = New System.Drawing.Point(7, 19)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(443, 161)
        Me.txtOutput.TabIndex = 6
        '
        'btnSort
        '
        Me.btnSort.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSort.Location = New System.Drawing.Point(6, 334)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(97, 23)
        Me.btnSort.TabIndex = 5
        Me.btnSort.Text = "Sortieren"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 372)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Sortierzeit [hh:mm:ss.ticks]"
        '
        'txtTime
        '
        Me.txtTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTime.Location = New System.Drawing.Point(6, 393)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.ReadOnly = True
        Me.txtTime.Size = New System.Drawing.Size(136, 20)
        Me.txtTime.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(117, 334)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'cboSort
        '
        Me.cboSort.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSort.FormattingEnabled = True
        Me.cboSort.Items.AddRange(New Object() {"bubblesort", "quicksort"})
        Me.cboSort.Location = New System.Drawing.Point(6, 19)
        Me.cboSort.Name = "cboSort"
        Me.cboSort.Size = New System.Drawing.Size(136, 21)
        Me.cboSort.TabIndex = 2
        '
        'chkSpecialCharacters
        '
        Me.chkSpecialCharacters.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkSpecialCharacters.AutoSize = True
        Me.chkSpecialCharacters.Location = New System.Drawing.Point(6, 46)
        Me.chkSpecialCharacters.Name = "chkSpecialCharacters"
        Me.chkSpecialCharacters.Size = New System.Drawing.Size(65, 17)
        Me.chkSpecialCharacters.TabIndex = 3
        Me.chkSpecialCharacters.Text = "Umlaute"
        Me.chkSpecialCharacters.UseVisualStyleBackColor = True
        '
        'chkWords
        '
        Me.chkWords.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkWords.AutoSize = True
        Me.chkWords.Location = New System.Drawing.Point(6, 69)
        Me.chkWords.Name = "chkWords"
        Me.chkWords.Size = New System.Drawing.Size(57, 17)
        Me.chkWords.TabIndex = 4
        Me.chkWords.Text = "Words"
        Me.chkWords.UseVisualStyleBackColor = True
        '
        'grpInput
        '
        Me.grpInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpInput.Controls.Add(Me.txtInput)
        Me.grpInput.Location = New System.Drawing.Point(13, 52)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(455, 205)
        Me.grpInput.TabIndex = 0
        Me.grpInput.TabStop = False
        Me.grpInput.Text = "Unsortiert"
        '
        'grpOutput
        '
        Me.grpOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpOutput.Controls.Add(Me.txtOutput)
        Me.grpOutput.Location = New System.Drawing.Point(13, 285)
        Me.grpOutput.Name = "grpOutput"
        Me.grpOutput.Size = New System.Drawing.Size(455, 186)
        Me.grpOutput.TabIndex = 5
        Me.grpOutput.TabStop = False
        Me.grpOutput.Text = "Sortiert"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.chkWords)
        Me.Panel1.Controls.Add(Me.txtTime)
        Me.Panel1.Controls.Add(Me.chkSpecialCharacters)
        Me.Panel1.Controls.Add(Me.btnSort)
        Me.Panel1.Controls.Add(Me.cboSort)
        Me.Panel1.Location = New System.Drawing.Point(474, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(145, 419)
        Me.Panel1.TabIndex = 2
        '
        'mnuStrip
        '
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuOptions, Me.mnuHelp})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(631, 24)
        Me.mnuStrip.TabIndex = 7
        Me.mnuStrip.Text = "MenuStrip2"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile_itmNew, Me.mnuFile_itmOpen, Me.mnuFile_itmSave, Me.mnuFile_itmQuit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(46, 20)
        Me.mnuFile.Text = "&Datei"
        '
        'mnuFile_itmNew
        '
        Me.mnuFile_itmNew.Name = "mnuFile_itmNew"
        Me.mnuFile_itmNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuFile_itmNew.Size = New System.Drawing.Size(168, 22)
        Me.mnuFile_itmNew.Text = "&Neu"
        '
        'mnuFile_itmOpen
        '
        Me.mnuFile_itmOpen.Name = "mnuFile_itmOpen"
        Me.mnuFile_itmOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuFile_itmOpen.Size = New System.Drawing.Size(168, 22)
        Me.mnuFile_itmOpen.Text = "&Öffnen"
        '
        'mnuFile_itmSave
        '
        Me.mnuFile_itmSave.Name = "mnuFile_itmSave"
        Me.mnuFile_itmSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuFile_itmSave.Size = New System.Drawing.Size(168, 22)
        Me.mnuFile_itmSave.Text = "&Speichern"
        '
        'mnuFile_itmQuit
        '
        Me.mnuFile_itmQuit.Name = "mnuFile_itmQuit"
        Me.mnuFile_itmQuit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.mnuFile_itmQuit.Size = New System.Drawing.Size(168, 22)
        Me.mnuFile_itmQuit.Text = "&Beenden"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEdit_itmCut, Me.mnuEdit_itmCopy, Me.mnuEdit_itmPaste, Me.ToolStripMenuItem1, Me.mnuEdit_itmSort})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(75, 20)
        Me.mnuEdit.Text = "&Bearbeiten"
        '
        'mnuEdit_itmCut
        '
        Me.mnuEdit_itmCut.Name = "mnuEdit_itmCut"
        Me.mnuEdit_itmCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuEdit_itmCut.Size = New System.Drawing.Size(191, 22)
        Me.mnuEdit_itmCut.Text = "&Ausschneiden"
        '
        'mnuEdit_itmCopy
        '
        Me.mnuEdit_itmCopy.Name = "mnuEdit_itmCopy"
        Me.mnuEdit_itmCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuEdit_itmCopy.Size = New System.Drawing.Size(191, 22)
        Me.mnuEdit_itmCopy.Text = "&Kopieren"
        '
        'mnuEdit_itmPaste
        '
        Me.mnuEdit_itmPaste.Name = "mnuEdit_itmPaste"
        Me.mnuEdit_itmPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuEdit_itmPaste.Size = New System.Drawing.Size(191, 22)
        Me.mnuEdit_itmPaste.Text = "&Einfügen"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(188, 6)
        '
        'mnuEdit_itmSort
        '
        Me.mnuEdit_itmSort.Name = "mnuEdit_itmSort"
        Me.mnuEdit_itmSort.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.mnuEdit_itmSort.Size = New System.Drawing.Size(191, 22)
        Me.mnuEdit_itmSort.Text = "&Sortieren"
        '
        'mnuOptions
        '
        Me.mnuOptions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptions_itmSpecialCharacters, Me.ToolStripMenuItem2, Me.mnuOptions_itmColor})
        Me.mnuOptions.Name = "mnuOptions"
        Me.mnuOptions.Size = New System.Drawing.Size(69, 20)
        Me.mnuOptions.Text = "&Optionen"
        '
        'mnuOptions_itmSpecialCharacters
        '
        Me.mnuOptions_itmSpecialCharacters.CheckOnClick = True
        Me.mnuOptions_itmSpecialCharacters.Name = "mnuOptions_itmSpecialCharacters"
        Me.mnuOptions_itmSpecialCharacters.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.mnuOptions_itmSpecialCharacters.Size = New System.Drawing.Size(163, 22)
        Me.mnuOptions_itmSpecialCharacters.Text = "&Umlaute"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(160, 6)
        '
        'mnuOptions_itmColor
        '
        Me.mnuOptions_itmColor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEdit_itmColor_itmForm, Me.mnuEdit_itmColor_itmTextbox})
        Me.mnuOptions_itmColor.Name = "mnuOptions_itmColor"
        Me.mnuOptions_itmColor.Size = New System.Drawing.Size(163, 22)
        Me.mnuOptions_itmColor.Text = "&Farbe"
        '
        'mnuEdit_itmColor_itmForm
        '
        Me.mnuEdit_itmColor_itmForm.Name = "mnuEdit_itmColor_itmForm"
        Me.mnuEdit_itmColor_itmForm.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F2), System.Windows.Forms.Keys)
        Me.mnuEdit_itmColor_itmForm.Size = New System.Drawing.Size(164, 22)
        Me.mnuEdit_itmColor_itmForm.Tag = "frm"
        Me.mnuEdit_itmColor_itmForm.Text = "&Formular"
        '
        'mnuEdit_itmColor_itmTextbox
        '
        Me.mnuEdit_itmColor_itmTextbox.Name = "mnuEdit_itmColor_itmTextbox"
        Me.mnuEdit_itmColor_itmTextbox.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F2), System.Windows.Forms.Keys)
        Me.mnuEdit_itmColor_itmTextbox.Size = New System.Drawing.Size(164, 22)
        Me.mnuEdit_itmColor_itmTextbox.Tag = "txtBox"
        Me.mnuEdit_itmColor_itmTextbox.Text = "&Textbox"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelp_itmInformations})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Hilfe"
        '
        'mnuHelp_itmInformations
        '
        Me.mnuHelp_itmInformations.Name = "mnuHelp_itmInformations"
        Me.mnuHelp_itmInformations.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.mnuHelp_itmInformations.Size = New System.Drawing.Size(189, 22)
        Me.mnuHelp_itmInformations.Text = "&Informationen"
        '
        'fileDlgOpen
        '
        Me.fileDlgOpen.Filter = "Textdateien (*.txt)|*.txt|Alle Dateien (*.*)|*.*"
        Me.fileDlgOpen.RestoreDirectory = True
        Me.fileDlgOpen.Title = "Textdatei öffnen"
        '
        'fileDlgSave
        '
        Me.fileDlgSave.Title = "Ausgabe speichern"
        '
        'clrDlgChoose
        '
        Me.clrDlgChoose.Color = System.Drawing.SystemColors.MenuHighlight
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStrp_btnNewFile, Me.toolStrp_btnOpenFile, Me.toolStrp_btnSaveFile, Me.ToolStripSeparator1, Me.toolStrp_btnCopy, Me.toolStrp_btnCut, Me.toolStrp_btnPaste, Me.ToolStripSeparator2, Me.toolStrp_btnSort})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(631, 25)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'toolStrp_btnNewFile
        '
        Me.toolStrp_btnNewFile.AutoSize = False
        Me.toolStrp_btnNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStrp_btnNewFile.Image = CType(resources.GetObject("toolStrp_btnNewFile.Image"), System.Drawing.Image)
        Me.toolStrp_btnNewFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStrp_btnNewFile.Name = "toolStrp_btnNewFile"
        Me.toolStrp_btnNewFile.Size = New System.Drawing.Size(23, 22)
        Me.toolStrp_btnNewFile.Text = "Neue leere Datei"
        '
        'toolStrp_btnOpenFile
        '
        Me.toolStrp_btnOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStrp_btnOpenFile.Image = CType(resources.GetObject("toolStrp_btnOpenFile.Image"), System.Drawing.Image)
        Me.toolStrp_btnOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStrp_btnOpenFile.Name = "toolStrp_btnOpenFile"
        Me.toolStrp_btnOpenFile.Size = New System.Drawing.Size(23, 22)
        Me.toolStrp_btnOpenFile.Text = "Datei öffnen"
        '
        'toolStrp_btnSaveFile
        '
        Me.toolStrp_btnSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStrp_btnSaveFile.Enabled = False
        Me.toolStrp_btnSaveFile.Image = CType(resources.GetObject("toolStrp_btnSaveFile.Image"), System.Drawing.Image)
        Me.toolStrp_btnSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStrp_btnSaveFile.Name = "toolStrp_btnSaveFile"
        Me.toolStrp_btnSaveFile.Size = New System.Drawing.Size(23, 22)
        Me.toolStrp_btnSaveFile.Text = "Datei speichern"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'toolStrp_btnCopy
        '
        Me.toolStrp_btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStrp_btnCopy.Enabled = False
        Me.toolStrp_btnCopy.Image = CType(resources.GetObject("toolStrp_btnCopy.Image"), System.Drawing.Image)
        Me.toolStrp_btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStrp_btnCopy.Name = "toolStrp_btnCopy"
        Me.toolStrp_btnCopy.Size = New System.Drawing.Size(23, 22)
        Me.toolStrp_btnCopy.Text = "Kopieren"
        '
        'toolStrp_btnCut
        '
        Me.toolStrp_btnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStrp_btnCut.Enabled = False
        Me.toolStrp_btnCut.Image = CType(resources.GetObject("toolStrp_btnCut.Image"), System.Drawing.Image)
        Me.toolStrp_btnCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStrp_btnCut.Name = "toolStrp_btnCut"
        Me.toolStrp_btnCut.Size = New System.Drawing.Size(23, 22)
        Me.toolStrp_btnCut.Text = "Ausschneiden"
        '
        'toolStrp_btnPaste
        '
        Me.toolStrp_btnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStrp_btnPaste.Image = CType(resources.GetObject("toolStrp_btnPaste.Image"), System.Drawing.Image)
        Me.toolStrp_btnPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStrp_btnPaste.Name = "toolStrp_btnPaste"
        Me.toolStrp_btnPaste.Size = New System.Drawing.Size(23, 22)
        Me.toolStrp_btnPaste.Text = "Einfügen"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'toolStrp_btnSort
        '
        Me.toolStrp_btnSort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStrp_btnSort.Enabled = False
        Me.toolStrp_btnSort.Image = CType(resources.GetObject("toolStrp_btnSort.Image"), System.Drawing.Image)
        Me.toolStrp_btnSort.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStrp_btnSort.Name = "toolStrp_btnSort"
        Me.toolStrp_btnSort.Size = New System.Drawing.Size(23, 22)
        Me.toolStrp_btnSort.Text = "Sortieren"
        '
        'frmSort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 482)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grpInput)
        Me.Controls.Add(Me.grpOutput)
        Me.Controls.Add(Me.mnuStrip)
        Me.MinimumSize = New System.Drawing.Size(647, 520)
        Me.Name = "frmSort"
        Me.Text = "Sortieren"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.grpOutput.ResumeLayout(False)
        Me.grpOutput.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents btnSort As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cboSort As System.Windows.Forms.ComboBox
    Friend WithEvents chkSpecialCharacters As System.Windows.Forms.CheckBox
    Friend WithEvents chkWords As System.Windows.Forms.CheckBox
    Friend WithEvents grpInput As System.Windows.Forms.GroupBox
    Friend WithEvents grpOutput As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents mnuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFile_itmNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFile_itmOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFile_itmSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFile_itmQuit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit_itmCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit_itmCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit_itmPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit_itmSort As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOptions_itmColor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOptions_itmSpecialCharacters As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit_itmColor_itmForm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit_itmColor_itmTextbox As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents fileDlgOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents fileDlgSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents clrDlgChoose As System.Windows.Forms.ColorDialog
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents toolStrp_btnCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStrp_btnNewFile As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStrp_btnOpenFile As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStrp_btnSaveFile As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolStrp_btnCut As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStrp_btnPaste As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolStrp_btnSort As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp_itmInformations As System.Windows.Forms.ToolStripMenuItem

End Class
