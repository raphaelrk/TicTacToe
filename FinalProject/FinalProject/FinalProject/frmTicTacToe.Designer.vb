<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicTacToe
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTopCenter = New System.Windows.Forms.Label()
        Me.lblTopRight = New System.Windows.Forms.Label()
        Me.lblMiddleLeft = New System.Windows.Forms.Label()
        Me.lblMiddleCenter = New System.Windows.Forms.Label()
        Me.lblMiddleRight = New System.Windows.Forms.Label()
        Me.lblBottomLeft = New System.Windows.Forms.Label()
        Me.lblBottomCenter = New System.Windows.Forms.Label()
        Me.lblBottomRight = New System.Windows.Forms.Label()
        Me.lblRow1 = New System.Windows.Forms.Label()
        Me.lblRow2 = New System.Windows.Forms.Label()
        Me.lblRow3 = New System.Windows.Forms.Label()
        Me.lblCol1 = New System.Windows.Forms.Label()
        Me.lblCol2 = New System.Windows.Forms.Label()
        Me.lblCol3 = New System.Windows.Forms.Label()
        Me.mskRow = New System.Windows.Forms.MaskedTextBox()
        Me.mskCol = New System.Windows.Forms.MaskedTextBox()
        Me.lblRow = New System.Windows.Forms.Label()
        Me.lblCol = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblPlayer = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblTopLeft = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNewGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSubmit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGameMode = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTopCenter
        '
        Me.lblTopCenter.AutoSize = True
        Me.lblTopCenter.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopCenter.Location = New System.Drawing.Point(129, 50)
        Me.lblTopCenter.Name = "lblTopCenter"
        Me.lblTopCenter.Size = New System.Drawing.Size(68, 75)
        Me.lblTopCenter.TabIndex = 1
        Me.lblTopCenter.Text = "_"
        '
        'lblTopRight
        '
        Me.lblTopRight.AutoSize = True
        Me.lblTopRight.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopRight.Location = New System.Drawing.Point(223, 50)
        Me.lblTopRight.Name = "lblTopRight"
        Me.lblTopRight.Size = New System.Drawing.Size(68, 75)
        Me.lblTopRight.TabIndex = 2
        Me.lblTopRight.Text = "_"
        '
        'lblMiddleLeft
        '
        Me.lblMiddleLeft.AutoSize = True
        Me.lblMiddleLeft.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddleLeft.Location = New System.Drawing.Point(35, 124)
        Me.lblMiddleLeft.Name = "lblMiddleLeft"
        Me.lblMiddleLeft.Size = New System.Drawing.Size(68, 75)
        Me.lblMiddleLeft.TabIndex = 3
        Me.lblMiddleLeft.Text = "_"
        '
        'lblMiddleCenter
        '
        Me.lblMiddleCenter.AutoSize = True
        Me.lblMiddleCenter.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddleCenter.Location = New System.Drawing.Point(129, 125)
        Me.lblMiddleCenter.Name = "lblMiddleCenter"
        Me.lblMiddleCenter.Size = New System.Drawing.Size(68, 75)
        Me.lblMiddleCenter.TabIndex = 4
        Me.lblMiddleCenter.Text = "_"
        '
        'lblMiddleRight
        '
        Me.lblMiddleRight.AutoSize = True
        Me.lblMiddleRight.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddleRight.Location = New System.Drawing.Point(223, 124)
        Me.lblMiddleRight.Name = "lblMiddleRight"
        Me.lblMiddleRight.Size = New System.Drawing.Size(68, 75)
        Me.lblMiddleRight.TabIndex = 5
        Me.lblMiddleRight.Text = "_"
        '
        'lblBottomLeft
        '
        Me.lblBottomLeft.AutoSize = True
        Me.lblBottomLeft.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBottomLeft.Location = New System.Drawing.Point(35, 198)
        Me.lblBottomLeft.Name = "lblBottomLeft"
        Me.lblBottomLeft.Size = New System.Drawing.Size(68, 75)
        Me.lblBottomLeft.TabIndex = 6
        Me.lblBottomLeft.Text = "_"
        '
        'lblBottomCenter
        '
        Me.lblBottomCenter.AutoSize = True
        Me.lblBottomCenter.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBottomCenter.Location = New System.Drawing.Point(129, 198)
        Me.lblBottomCenter.Name = "lblBottomCenter"
        Me.lblBottomCenter.Size = New System.Drawing.Size(68, 75)
        Me.lblBottomCenter.TabIndex = 7
        Me.lblBottomCenter.Text = "_"
        '
        'lblBottomRight
        '
        Me.lblBottomRight.AutoSize = True
        Me.lblBottomRight.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBottomRight.Location = New System.Drawing.Point(223, 198)
        Me.lblBottomRight.Name = "lblBottomRight"
        Me.lblBottomRight.Size = New System.Drawing.Size(68, 75)
        Me.lblBottomRight.TabIndex = 8
        Me.lblBottomRight.Text = "_"
        '
        'lblRow1
        '
        Me.lblRow1.AutoSize = True
        Me.lblRow1.Location = New System.Drawing.Point(12, 81)
        Me.lblRow1.Name = "lblRow1"
        Me.lblRow1.Size = New System.Drawing.Size(13, 13)
        Me.lblRow1.TabIndex = 9
        Me.lblRow1.Text = "1"
        '
        'lblRow2
        '
        Me.lblRow2.AutoSize = True
        Me.lblRow2.Location = New System.Drawing.Point(12, 155)
        Me.lblRow2.Name = "lblRow2"
        Me.lblRow2.Size = New System.Drawing.Size(13, 13)
        Me.lblRow2.TabIndex = 10
        Me.lblRow2.Text = "2"
        '
        'lblRow3
        '
        Me.lblRow3.AutoSize = True
        Me.lblRow3.Location = New System.Drawing.Point(12, 229)
        Me.lblRow3.Name = "lblRow3"
        Me.lblRow3.Size = New System.Drawing.Size(13, 13)
        Me.lblRow3.TabIndex = 11
        Me.lblRow3.Text = "3"
        '
        'lblCol1
        '
        Me.lblCol1.AutoSize = True
        Me.lblCol1.Location = New System.Drawing.Point(70, 29)
        Me.lblCol1.Name = "lblCol1"
        Me.lblCol1.Size = New System.Drawing.Size(13, 13)
        Me.lblCol1.TabIndex = 12
        Me.lblCol1.Text = "1"
        '
        'lblCol2
        '
        Me.lblCol2.AutoSize = True
        Me.lblCol2.Location = New System.Drawing.Point(164, 29)
        Me.lblCol2.Name = "lblCol2"
        Me.lblCol2.Size = New System.Drawing.Size(13, 13)
        Me.lblCol2.TabIndex = 13
        Me.lblCol2.Text = "2"
        '
        'lblCol3
        '
        Me.lblCol3.AutoSize = True
        Me.lblCol3.Location = New System.Drawing.Point(258, 29)
        Me.lblCol3.Name = "lblCol3"
        Me.lblCol3.Size = New System.Drawing.Size(13, 13)
        Me.lblCol3.TabIndex = 14
        Me.lblCol3.Text = "3"
        '
        'mskRow
        '
        Me.mskRow.BackColor = System.Drawing.Color.Bisque
        Me.mskRow.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskRow.Location = New System.Drawing.Point(367, 101)
        Me.mskRow.Mask = "0"
        Me.mskRow.Name = "mskRow"
        Me.mskRow.Size = New System.Drawing.Size(20, 30)
        Me.mskRow.TabIndex = 15
        '
        'mskCol
        '
        Me.mskCol.BackColor = System.Drawing.Color.Bisque
        Me.mskCol.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCol.Location = New System.Drawing.Point(367, 149)
        Me.mskCol.Mask = "0"
        Me.mskCol.Name = "mskCol"
        Me.mskCol.Size = New System.Drawing.Size(20, 30)
        Me.mskCol.TabIndex = 16
        '
        'lblRow
        '
        Me.lblRow.AutoSize = True
        Me.lblRow.Location = New System.Drawing.Point(300, 112)
        Me.lblRow.Name = "lblRow"
        Me.lblRow.Size = New System.Drawing.Size(32, 13)
        Me.lblRow.TabIndex = 17
        Me.lblRow.Text = "Row:"
        '
        'lblCol
        '
        Me.lblCol.AutoSize = True
        Me.lblCol.Location = New System.Drawing.Point(300, 160)
        Me.lblCol.Name = "lblCol"
        Me.lblCol.Size = New System.Drawing.Size(45, 13)
        Me.lblCol.TabIndex = 18
        Me.lblCol.Text = "Column:"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Snow
        Me.btnSubmit.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(303, 196)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(107, 34)
        Me.btnSubmit.TabIndex = 19
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'lblPlayer
        '
        Me.lblPlayer.AutoSize = True
        Me.lblPlayer.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer.Location = New System.Drawing.Point(297, 29)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Size = New System.Drawing.Size(128, 66)
        Me.lblPlayer.TabIndex = 20
        Me.lblPlayer.Text = "Player 1's" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Turn"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FinalProject.My.Resources.Resources.Black1
        Me.PictureBox1.Location = New System.Drawing.Point(109, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(5, 230)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'btnNewGame
        '
        Me.btnNewGame.BackColor = System.Drawing.Color.Snow
        Me.btnNewGame.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNewGame.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewGame.Location = New System.Drawing.Point(303, 241)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(107, 34)
        Me.btnNewGame.TabIndex = 22
        Me.btnNewGame.Text = "New Game"
        Me.btnNewGame.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.FinalProject.My.Resources.Resources.Black1
        Me.PictureBox2.Location = New System.Drawing.Point(203, 50)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(5, 230)
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.FinalProject.My.Resources.Resources.Black1
        Me.PictureBox3.Location = New System.Drawing.Point(31, 203)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(260, 5)
        Me.PictureBox3.TabIndex = 24
        Me.PictureBox3.TabStop = False
        '
        'lblTopLeft
        '
        Me.lblTopLeft.AutoSize = True
        Me.lblTopLeft.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopLeft.Location = New System.Drawing.Point(35, 50)
        Me.lblTopLeft.Name = "lblTopLeft"
        Me.lblTopLeft.Size = New System.Drawing.Size(68, 75)
        Me.lblTopLeft.TabIndex = 0
        Me.lblTopLeft.Text = "_"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.FinalProject.My.Resources.Resources.Black1
        Me.PictureBox4.Location = New System.Drawing.Point(31, 128)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(260, 5)
        Me.PictureBox4.TabIndex = 25
        Me.PictureBox4.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Moccasin
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(422, 24)
        Me.MenuStrip1.TabIndex = 26
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewGame, Me.mnuSubmit, Me.mnuAbout, Me.mnuGameMode, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuNewGame
        '
        Me.mnuNewGame.Name = "mnuNewGame"
        Me.mnuNewGame.Size = New System.Drawing.Size(152, 22)
        Me.mnuNewGame.Text = "&New Game"
        '
        'mnuSubmit
        '
        Me.mnuSubmit.Name = "mnuSubmit"
        Me.mnuSubmit.Size = New System.Drawing.Size(152, 22)
        Me.mnuSubmit.Text = "&Submit"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(152, 22)
        Me.mnuAbout.Text = "&About"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'mnuGameMode
        '
        Me.mnuGameMode.Name = "mnuGameMode"
        Me.mnuGameMode.Size = New System.Drawing.Size(152, 22)
        Me.mnuGameMode.Text = "&Game Mode"
        '
        'frmTicTacToe
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Moccasin
        Me.CancelButton = Me.btnNewGame
        Me.ClientSize = New System.Drawing.Size(422, 283)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnNewGame)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblPlayer)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblCol)
        Me.Controls.Add(Me.lblRow)
        Me.Controls.Add(Me.mskCol)
        Me.Controls.Add(Me.mskRow)
        Me.Controls.Add(Me.lblCol3)
        Me.Controls.Add(Me.lblCol2)
        Me.Controls.Add(Me.lblCol1)
        Me.Controls.Add(Me.lblRow3)
        Me.Controls.Add(Me.lblRow2)
        Me.Controls.Add(Me.lblRow1)
        Me.Controls.Add(Me.lblBottomRight)
        Me.Controls.Add(Me.lblBottomCenter)
        Me.Controls.Add(Me.lblBottomLeft)
        Me.Controls.Add(Me.lblMiddleRight)
        Me.Controls.Add(Me.lblMiddleCenter)
        Me.Controls.Add(Me.lblMiddleLeft)
        Me.Controls.Add(Me.lblTopRight)
        Me.Controls.Add(Me.lblTopCenter)
        Me.Controls.Add(Me.lblTopLeft)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmTicTacToe"
        Me.Text = "Tic Tac Toe"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTopCenter As System.Windows.Forms.Label
    Friend WithEvents lblTopRight As System.Windows.Forms.Label
    Friend WithEvents lblMiddleLeft As System.Windows.Forms.Label
    Friend WithEvents lblMiddleCenter As System.Windows.Forms.Label
    Friend WithEvents lblMiddleRight As System.Windows.Forms.Label
    Friend WithEvents lblBottomLeft As System.Windows.Forms.Label
    Friend WithEvents lblBottomCenter As System.Windows.Forms.Label
    Friend WithEvents lblBottomRight As System.Windows.Forms.Label
    Friend WithEvents lblRow1 As System.Windows.Forms.Label
    Friend WithEvents lblRow2 As System.Windows.Forms.Label
    Friend WithEvents lblRow3 As System.Windows.Forms.Label
    Friend WithEvents lblCol1 As System.Windows.Forms.Label
    Friend WithEvents lblCol2 As System.Windows.Forms.Label
    Friend WithEvents lblCol3 As System.Windows.Forms.Label
    Friend WithEvents mskRow As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskCol As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblRow As System.Windows.Forms.Label
    Friend WithEvents lblCol As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents lblPlayer As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnNewGame As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTopLeft As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNewGame As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSubmit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGameMode As System.Windows.Forms.ToolStripMenuItem

End Class
