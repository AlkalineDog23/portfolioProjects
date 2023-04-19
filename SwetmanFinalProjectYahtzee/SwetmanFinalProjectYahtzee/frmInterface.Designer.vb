<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInterface
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInterface))
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStsProgrammerName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.lblScoreCard = New System.Windows.Forms.Label()
        Me.lblAces = New System.Windows.Forms.Label()
        Me.lblTwos = New System.Windows.Forms.Label()
        Me.gbUpperScoreCard = New System.Windows.Forms.GroupBox()
        Me.lblSixesBox = New System.Windows.Forms.Label()
        Me.lblSixes = New System.Windows.Forms.Label()
        Me.lblUpperTotalActualBox = New System.Windows.Forms.Label()
        Me.lblBonusBox = New System.Windows.Forms.Label()
        Me.lblTotalScoreUpperBox = New System.Windows.Forms.Label()
        Me.lblFivesBox = New System.Windows.Forms.Label()
        Me.lblFoursBox = New System.Windows.Forms.Label()
        Me.lblThreesBox = New System.Windows.Forms.Label()
        Me.lblTwosBox = New System.Windows.Forms.Label()
        Me.lblAcesBox = New System.Windows.Forms.Label()
        Me.lblUpperTotalActual = New System.Windows.Forms.Label()
        Me.lblBonusUpper = New System.Windows.Forms.Label()
        Me.lblTotalScoreUpper = New System.Windows.Forms.Label()
        Me.lblFives = New System.Windows.Forms.Label()
        Me.lblFours = New System.Windows.Forms.Label()
        Me.lblThrees = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gbxLowerScoreCard = New System.Windows.Forms.GroupBox()
        Me.lblTotalScoreLowerBox = New System.Windows.Forms.Label()
        Me.lblChanceBox = New System.Windows.Forms.Label()
        Me.lblYahtzeeBox = New System.Windows.Forms.Label()
        Me.lblLargeStraightBox = New System.Windows.Forms.Label()
        Me.lblSmallStraightBox = New System.Windows.Forms.Label()
        Me.lblFullHouseBox = New System.Windows.Forms.Label()
        Me.lblFourOfAKindBox = New System.Windows.Forms.Label()
        Me.lblThreeOfAKindBox = New System.Windows.Forms.Label()
        Me.lblTotalScoreLower = New System.Windows.Forms.Label()
        Me.lblChance = New System.Windows.Forms.Label()
        Me.lblYahtzee = New System.Windows.Forms.Label()
        Me.lblLargeStraight = New System.Windows.Forms.Label()
        Me.lblSmallStraight = New System.Windows.Forms.Label()
        Me.lblFullHouse = New System.Windows.Forms.Label()
        Me.lblThreeOfAKind = New System.Windows.Forms.Label()
        Me.lblFourOfAKind = New System.Windows.Forms.Label()
        Me.lblAdvice = New System.Windows.Forms.Label()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.lblGrandActual = New System.Windows.Forms.Label()
        Me.lblNumRolls = New System.Windows.Forms.Label()
        Me.lblNumRollsActual = New System.Windows.Forms.Label()
        Me.lblNumTurns = New System.Windows.Forms.Label()
        Me.lblNumTurnsLeft = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblGameOver = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picDieOne = New System.Windows.Forms.PictureBox()
        Me.picDieFive = New System.Windows.Forms.PictureBox()
        Me.picDieFour = New System.Windows.Forms.PictureBox()
        Me.picDieThree = New System.Windows.Forms.PictureBox()
        Me.picDieTwo = New System.Windows.Forms.PictureBox()
        Me.picDie5 = New System.Windows.Forms.PictureBox()
        Me.picDie4 = New System.Windows.Forms.PictureBox()
        Me.picDie3 = New System.Windows.Forms.PictureBox()
        Me.picDie2 = New System.Windows.Forms.PictureBox()
        Me.picDie1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1.SuspendLayout()
        Me.gbUpperScoreCard.SuspendLayout()
        Me.gbxLowerScoreCard.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDieOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDieFive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDieFour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDieThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDieTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDie5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDie4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDie3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDie2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDie1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(342, 9)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(108, 24)
        Me.lblUserName.TabIndex = 0
        Me.lblUserName.Text = "UserName"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStsProgrammerName, Me.lblDate})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 727)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1266, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStsProgrammerName
        '
        Me.lblStsProgrammerName.BackColor = System.Drawing.SystemColors.Control
        Me.lblStsProgrammerName.Name = "lblStsProgrammerName"
        Me.lblStsProgrammerName.Size = New System.Drawing.Size(102, 17)
        Me.lblStsProgrammerName.Text = "Stephen Swetman"
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.SystemColors.Control
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(31, 17)
        Me.lblDate.Text = "Date"
        '
        'btnRoll
        '
        Me.btnRoll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRoll.Location = New System.Drawing.Point(335, 158)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(81, 32)
        Me.btnRoll.TabIndex = 3
        Me.btnRoll.Text = "&Roll!"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'lblScoreCard
        '
        Me.lblScoreCard.AutoSize = True
        Me.lblScoreCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreCard.Location = New System.Drawing.Point(317, 193)
        Me.lblScoreCard.Name = "lblScoreCard"
        Me.lblScoreCard.Size = New System.Drawing.Size(123, 25)
        Me.lblScoreCard.TabIndex = 4
        Me.lblScoreCard.Text = "ScoreCard"
        '
        'lblAces
        '
        Me.lblAces.AutoSize = True
        Me.lblAces.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAces.Location = New System.Drawing.Point(19, 26)
        Me.lblAces.Name = "lblAces"
        Me.lblAces.Size = New System.Drawing.Size(49, 20)
        Me.lblAces.TabIndex = 5
        Me.lblAces.Text = "Aces"
        '
        'lblTwos
        '
        Me.lblTwos.AutoSize = True
        Me.lblTwos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTwos.Location = New System.Drawing.Point(18, 57)
        Me.lblTwos.Name = "lblTwos"
        Me.lblTwos.Size = New System.Drawing.Size(53, 20)
        Me.lblTwos.TabIndex = 6
        Me.lblTwos.Text = "Twos"
        '
        'gbUpperScoreCard
        '
        Me.gbUpperScoreCard.Controls.Add(Me.lblSixesBox)
        Me.gbUpperScoreCard.Controls.Add(Me.lblSixes)
        Me.gbUpperScoreCard.Controls.Add(Me.lblUpperTotalActualBox)
        Me.gbUpperScoreCard.Controls.Add(Me.lblBonusBox)
        Me.gbUpperScoreCard.Controls.Add(Me.lblTotalScoreUpperBox)
        Me.gbUpperScoreCard.Controls.Add(Me.lblFivesBox)
        Me.gbUpperScoreCard.Controls.Add(Me.lblFoursBox)
        Me.gbUpperScoreCard.Controls.Add(Me.lblThreesBox)
        Me.gbUpperScoreCard.Controls.Add(Me.lblTwosBox)
        Me.gbUpperScoreCard.Controls.Add(Me.lblAcesBox)
        Me.gbUpperScoreCard.Controls.Add(Me.lblUpperTotalActual)
        Me.gbUpperScoreCard.Controls.Add(Me.lblBonusUpper)
        Me.gbUpperScoreCard.Controls.Add(Me.lblTotalScoreUpper)
        Me.gbUpperScoreCard.Controls.Add(Me.lblFives)
        Me.gbUpperScoreCard.Controls.Add(Me.lblFours)
        Me.gbUpperScoreCard.Controls.Add(Me.lblThrees)
        Me.gbUpperScoreCard.Controls.Add(Me.lblAces)
        Me.gbUpperScoreCard.Controls.Add(Me.lblTwos)
        Me.gbUpperScoreCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbUpperScoreCard.ForeColor = System.Drawing.SystemColors.Control
        Me.gbUpperScoreCard.Location = New System.Drawing.Point(48, 269)
        Me.gbUpperScoreCard.Name = "gbUpperScoreCard"
        Me.gbUpperScoreCard.Size = New System.Drawing.Size(324, 294)
        Me.gbUpperScoreCard.TabIndex = 7
        Me.gbUpperScoreCard.TabStop = False
        Me.gbUpperScoreCard.Text = "Upper Section"
        '
        'lblSixesBox
        '
        Me.lblSixesBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblSixesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSixesBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSixesBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSixesBox.Location = New System.Drawing.Point(150, 179)
        Me.lblSixesBox.Name = "lblSixesBox"
        Me.lblSixesBox.Size = New System.Drawing.Size(58, 20)
        Me.lblSixesBox.TabIndex = 22
        '
        'lblSixes
        '
        Me.lblSixes.AutoSize = True
        Me.lblSixes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblSixes.Location = New System.Drawing.Point(19, 180)
        Me.lblSixes.Name = "lblSixes"
        Me.lblSixes.Size = New System.Drawing.Size(52, 20)
        Me.lblSixes.TabIndex = 21
        Me.lblSixes.Text = "Sixes"
        '
        'lblUpperTotalActualBox
        '
        Me.lblUpperTotalActualBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblUpperTotalActualBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUpperTotalActualBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpperTotalActualBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblUpperTotalActualBox.Location = New System.Drawing.Point(150, 267)
        Me.lblUpperTotalActualBox.Name = "lblUpperTotalActualBox"
        Me.lblUpperTotalActualBox.Size = New System.Drawing.Size(58, 20)
        Me.lblUpperTotalActualBox.TabIndex = 20
        '
        'lblBonusBox
        '
        Me.lblBonusBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblBonusBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBonusBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBonusBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBonusBox.Location = New System.Drawing.Point(150, 239)
        Me.lblBonusBox.Name = "lblBonusBox"
        Me.lblBonusBox.Size = New System.Drawing.Size(58, 20)
        Me.lblBonusBox.TabIndex = 19
        '
        'lblTotalScoreUpperBox
        '
        Me.lblTotalScoreUpperBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblTotalScoreUpperBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalScoreUpperBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalScoreUpperBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotalScoreUpperBox.Location = New System.Drawing.Point(150, 209)
        Me.lblTotalScoreUpperBox.Name = "lblTotalScoreUpperBox"
        Me.lblTotalScoreUpperBox.Size = New System.Drawing.Size(58, 20)
        Me.lblTotalScoreUpperBox.TabIndex = 18
        '
        'lblFivesBox
        '
        Me.lblFivesBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblFivesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFivesBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFivesBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFivesBox.Location = New System.Drawing.Point(150, 149)
        Me.lblFivesBox.Name = "lblFivesBox"
        Me.lblFivesBox.Size = New System.Drawing.Size(58, 20)
        Me.lblFivesBox.TabIndex = 17
        '
        'lblFoursBox
        '
        Me.lblFoursBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblFoursBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFoursBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoursBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFoursBox.Location = New System.Drawing.Point(150, 115)
        Me.lblFoursBox.Name = "lblFoursBox"
        Me.lblFoursBox.Size = New System.Drawing.Size(58, 20)
        Me.lblFoursBox.TabIndex = 16
        '
        'lblThreesBox
        '
        Me.lblThreesBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblThreesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblThreesBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThreesBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblThreesBox.Location = New System.Drawing.Point(150, 87)
        Me.lblThreesBox.Name = "lblThreesBox"
        Me.lblThreesBox.Size = New System.Drawing.Size(58, 20)
        Me.lblThreesBox.TabIndex = 15
        '
        'lblTwosBox
        '
        Me.lblTwosBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblTwosBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTwosBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTwosBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTwosBox.Location = New System.Drawing.Point(150, 57)
        Me.lblTwosBox.Name = "lblTwosBox"
        Me.lblTwosBox.Size = New System.Drawing.Size(58, 20)
        Me.lblTwosBox.TabIndex = 14
        '
        'lblAcesBox
        '
        Me.lblAcesBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblAcesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAcesBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcesBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAcesBox.Location = New System.Drawing.Point(150, 26)
        Me.lblAcesBox.Name = "lblAcesBox"
        Me.lblAcesBox.Size = New System.Drawing.Size(58, 20)
        Me.lblAcesBox.TabIndex = 13
        '
        'lblUpperTotalActual
        '
        Me.lblUpperTotalActual.AutoSize = True
        Me.lblUpperTotalActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblUpperTotalActual.Location = New System.Drawing.Point(18, 267)
        Me.lblUpperTotalActual.Name = "lblUpperTotalActual"
        Me.lblUpperTotalActual.Size = New System.Drawing.Size(110, 20)
        Me.lblUpperTotalActual.TabIndex = 12
        Me.lblUpperTotalActual.Text = "Score Upper"
        '
        'lblBonusUpper
        '
        Me.lblBonusUpper.AutoSize = True
        Me.lblBonusUpper.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBonusUpper.Location = New System.Drawing.Point(18, 240)
        Me.lblBonusUpper.Name = "lblBonusUpper"
        Me.lblBonusUpper.Size = New System.Drawing.Size(60, 20)
        Me.lblBonusUpper.TabIndex = 11
        Me.lblBonusUpper.Text = "Bonus"
        '
        'lblTotalScoreUpper
        '
        Me.lblTotalScoreUpper.AutoSize = True
        Me.lblTotalScoreUpper.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalScoreUpper.Location = New System.Drawing.Point(18, 210)
        Me.lblTotalScoreUpper.Name = "lblTotalScoreUpper"
        Me.lblTotalScoreUpper.Size = New System.Drawing.Size(49, 20)
        Me.lblTotalScoreUpper.TabIndex = 10
        Me.lblTotalScoreUpper.Text = "Total"
        '
        'lblFives
        '
        Me.lblFives.AutoSize = True
        Me.lblFives.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblFives.Location = New System.Drawing.Point(19, 149)
        Me.lblFives.Name = "lblFives"
        Me.lblFives.Size = New System.Drawing.Size(51, 20)
        Me.lblFives.TabIndex = 9
        Me.lblFives.Text = "Fives"
        '
        'lblFours
        '
        Me.lblFours.AutoSize = True
        Me.lblFours.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblFours.Location = New System.Drawing.Point(19, 115)
        Me.lblFours.Name = "lblFours"
        Me.lblFours.Size = New System.Drawing.Size(55, 20)
        Me.lblFours.TabIndex = 8
        Me.lblFours.Text = "Fours"
        '
        'lblThrees
        '
        Me.lblThrees.AutoSize = True
        Me.lblThrees.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThrees.Location = New System.Drawing.Point(18, 87)
        Me.lblThrees.Name = "lblThrees"
        Me.lblThrees.Size = New System.Drawing.Size(64, 20)
        Me.lblThrees.TabIndex = 7
        Me.lblThrees.Text = "Threes"
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExit.Location = New System.Drawing.Point(335, 579)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(81, 33)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'gbxLowerScoreCard
        '
        Me.gbxLowerScoreCard.Controls.Add(Me.lblTotalScoreLowerBox)
        Me.gbxLowerScoreCard.Controls.Add(Me.lblChanceBox)
        Me.gbxLowerScoreCard.Controls.Add(Me.lblYahtzeeBox)
        Me.gbxLowerScoreCard.Controls.Add(Me.lblLargeStraightBox)
        Me.gbxLowerScoreCard.Controls.Add(Me.lblSmallStraightBox)
        Me.gbxLowerScoreCard.Controls.Add(Me.lblFullHouseBox)
        Me.gbxLowerScoreCard.Controls.Add(Me.lblFourOfAKindBox)
        Me.gbxLowerScoreCard.Controls.Add(Me.lblThreeOfAKindBox)
        Me.gbxLowerScoreCard.Controls.Add(Me.lblTotalScoreLower)
        Me.gbxLowerScoreCard.Controls.Add(Me.lblChance)
        Me.gbxLowerScoreCard.Controls.Add(Me.lblYahtzee)
        Me.gbxLowerScoreCard.Controls.Add(Me.lblLargeStraight)
        Me.gbxLowerScoreCard.Controls.Add(Me.lblSmallStraight)
        Me.gbxLowerScoreCard.Controls.Add(Me.lblFullHouse)
        Me.gbxLowerScoreCard.Controls.Add(Me.lblThreeOfAKind)
        Me.gbxLowerScoreCard.Controls.Add(Me.lblFourOfAKind)
        Me.gbxLowerScoreCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxLowerScoreCard.ForeColor = System.Drawing.SystemColors.Control
        Me.gbxLowerScoreCard.Location = New System.Drawing.Point(394, 269)
        Me.gbxLowerScoreCard.Name = "gbxLowerScoreCard"
        Me.gbxLowerScoreCard.Size = New System.Drawing.Size(313, 294)
        Me.gbxLowerScoreCard.TabIndex = 9
        Me.gbxLowerScoreCard.TabStop = False
        Me.gbxLowerScoreCard.Text = "Lower Section"
        '
        'lblTotalScoreLowerBox
        '
        Me.lblTotalScoreLowerBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblTotalScoreLowerBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalScoreLowerBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalScoreLowerBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotalScoreLowerBox.Location = New System.Drawing.Point(175, 239)
        Me.lblTotalScoreLowerBox.Name = "lblTotalScoreLowerBox"
        Me.lblTotalScoreLowerBox.Size = New System.Drawing.Size(58, 20)
        Me.lblTotalScoreLowerBox.TabIndex = 21
        '
        'lblChanceBox
        '
        Me.lblChanceBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblChanceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblChanceBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChanceBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblChanceBox.Location = New System.Drawing.Point(175, 210)
        Me.lblChanceBox.Name = "lblChanceBox"
        Me.lblChanceBox.Size = New System.Drawing.Size(58, 20)
        Me.lblChanceBox.TabIndex = 20
        '
        'lblYahtzeeBox
        '
        Me.lblYahtzeeBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblYahtzeeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYahtzeeBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYahtzeeBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblYahtzeeBox.Location = New System.Drawing.Point(175, 179)
        Me.lblYahtzeeBox.Name = "lblYahtzeeBox"
        Me.lblYahtzeeBox.Size = New System.Drawing.Size(58, 20)
        Me.lblYahtzeeBox.TabIndex = 19
        '
        'lblLargeStraightBox
        '
        Me.lblLargeStraightBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblLargeStraightBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLargeStraightBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLargeStraightBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblLargeStraightBox.Location = New System.Drawing.Point(175, 149)
        Me.lblLargeStraightBox.Name = "lblLargeStraightBox"
        Me.lblLargeStraightBox.Size = New System.Drawing.Size(58, 20)
        Me.lblLargeStraightBox.TabIndex = 18
        '
        'lblSmallStraightBox
        '
        Me.lblSmallStraightBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblSmallStraightBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSmallStraightBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSmallStraightBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSmallStraightBox.Location = New System.Drawing.Point(175, 116)
        Me.lblSmallStraightBox.Name = "lblSmallStraightBox"
        Me.lblSmallStraightBox.Size = New System.Drawing.Size(58, 20)
        Me.lblSmallStraightBox.TabIndex = 17
        '
        'lblFullHouseBox
        '
        Me.lblFullHouseBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblFullHouseBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFullHouseBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullHouseBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFullHouseBox.Location = New System.Drawing.Point(175, 88)
        Me.lblFullHouseBox.Name = "lblFullHouseBox"
        Me.lblFullHouseBox.Size = New System.Drawing.Size(58, 20)
        Me.lblFullHouseBox.TabIndex = 16
        '
        'lblFourOfAKindBox
        '
        Me.lblFourOfAKindBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblFourOfAKindBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFourOfAKindBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFourOfAKindBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFourOfAKindBox.Location = New System.Drawing.Point(175, 57)
        Me.lblFourOfAKindBox.Name = "lblFourOfAKindBox"
        Me.lblFourOfAKindBox.Size = New System.Drawing.Size(58, 20)
        Me.lblFourOfAKindBox.TabIndex = 15
        '
        'lblThreeOfAKindBox
        '
        Me.lblThreeOfAKindBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblThreeOfAKindBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblThreeOfAKindBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThreeOfAKindBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblThreeOfAKindBox.Location = New System.Drawing.Point(175, 27)
        Me.lblThreeOfAKindBox.Name = "lblThreeOfAKindBox"
        Me.lblThreeOfAKindBox.Size = New System.Drawing.Size(58, 20)
        Me.lblThreeOfAKindBox.TabIndex = 14
        '
        'lblTotalScoreLower
        '
        Me.lblTotalScoreLower.AutoSize = True
        Me.lblTotalScoreLower.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalScoreLower.Location = New System.Drawing.Point(24, 240)
        Me.lblTotalScoreLower.Name = "lblTotalScoreLower"
        Me.lblTotalScoreLower.Size = New System.Drawing.Size(109, 20)
        Me.lblTotalScoreLower.TabIndex = 12
        Me.lblTotalScoreLower.Text = "Score Lower"
        '
        'lblChance
        '
        Me.lblChance.AutoSize = True
        Me.lblChance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChance.Location = New System.Drawing.Point(27, 210)
        Me.lblChance.Name = "lblChance"
        Me.lblChance.Size = New System.Drawing.Size(70, 20)
        Me.lblChance.TabIndex = 11
        Me.lblChance.Text = "Chance"
        '
        'lblYahtzee
        '
        Me.lblYahtzee.AutoSize = True
        Me.lblYahtzee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYahtzee.Location = New System.Drawing.Point(27, 180)
        Me.lblYahtzee.Name = "lblYahtzee"
        Me.lblYahtzee.Size = New System.Drawing.Size(91, 20)
        Me.lblYahtzee.TabIndex = 10
        Me.lblYahtzee.Text = "YAHTZEE"
        '
        'lblLargeStraight
        '
        Me.lblLargeStraight.AutoSize = True
        Me.lblLargeStraight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLargeStraight.Location = New System.Drawing.Point(24, 150)
        Me.lblLargeStraight.Name = "lblLargeStraight"
        Me.lblLargeStraight.Size = New System.Drawing.Size(124, 20)
        Me.lblLargeStraight.TabIndex = 9
        Me.lblLargeStraight.Text = "Large Straight"
        '
        'lblSmallStraight
        '
        Me.lblSmallStraight.AutoSize = True
        Me.lblSmallStraight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSmallStraight.Location = New System.Drawing.Point(24, 116)
        Me.lblSmallStraight.Name = "lblSmallStraight"
        Me.lblSmallStraight.Size = New System.Drawing.Size(122, 20)
        Me.lblSmallStraight.TabIndex = 8
        Me.lblSmallStraight.Text = "Small Straight"
        '
        'lblFullHouse
        '
        Me.lblFullHouse.AutoSize = True
        Me.lblFullHouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullHouse.Location = New System.Drawing.Point(26, 88)
        Me.lblFullHouse.Name = "lblFullHouse"
        Me.lblFullHouse.Size = New System.Drawing.Size(95, 20)
        Me.lblFullHouse.TabIndex = 7
        Me.lblFullHouse.Text = "Full House"
        '
        'lblThreeOfAKind
        '
        Me.lblThreeOfAKind.AutoSize = True
        Me.lblThreeOfAKind.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThreeOfAKind.ForeColor = System.Drawing.Color.White
        Me.lblThreeOfAKind.Location = New System.Drawing.Point(24, 27)
        Me.lblThreeOfAKind.Name = "lblThreeOfAKind"
        Me.lblThreeOfAKind.Size = New System.Drawing.Size(93, 20)
        Me.lblThreeOfAKind.TabIndex = 5
        Me.lblThreeOfAKind.Text = "3 of a kind"
        '
        'lblFourOfAKind
        '
        Me.lblFourOfAKind.AutoSize = True
        Me.lblFourOfAKind.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFourOfAKind.Location = New System.Drawing.Point(24, 58)
        Me.lblFourOfAKind.Name = "lblFourOfAKind"
        Me.lblFourOfAKind.Size = New System.Drawing.Size(93, 20)
        Me.lblFourOfAKind.TabIndex = 6
        Me.lblFourOfAKind.Text = "4 of a kind"
        '
        'lblAdvice
        '
        Me.lblAdvice.AutoSize = True
        Me.lblAdvice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdvice.Location = New System.Drawing.Point(269, 227)
        Me.lblAdvice.Name = "lblAdvice"
        Me.lblAdvice.Size = New System.Drawing.Size(228, 20)
        Me.lblAdvice.TabIndex = 10
        Me.lblAdvice.Text = "(Click the box to execute move)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.AutoSize = True
        Me.lblGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandTotal.Location = New System.Drawing.Point(902, 527)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(158, 29)
        Me.lblGrandTotal.TabIndex = 11
        Me.lblGrandTotal.Text = "Grand Total:"
        Me.lblGrandTotal.Visible = False
        '
        'lblGrandActual
        '
        Me.lblGrandActual.AutoSize = True
        Me.lblGrandActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandActual.Location = New System.Drawing.Point(1050, 527)
        Me.lblGrandActual.Name = "lblGrandActual"
        Me.lblGrandActual.Size = New System.Drawing.Size(67, 29)
        Me.lblGrandActual.TabIndex = 12
        Me.lblGrandActual.Text = "XXX"
        Me.lblGrandActual.Visible = False
        '
        'lblNumRolls
        '
        Me.lblNumRolls.AutoSize = True
        Me.lblNumRolls.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblNumRolls.Location = New System.Drawing.Point(517, 170)
        Me.lblNumRolls.Name = "lblNumRolls"
        Me.lblNumRolls.Size = New System.Drawing.Size(166, 20)
        Me.lblNumRolls.TabIndex = 19
        Me.lblNumRolls.Text = "Number of rolls left:"
        '
        'lblNumRollsActual
        '
        Me.lblNumRollsActual.AutoSize = True
        Me.lblNumRollsActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblNumRollsActual.Location = New System.Drawing.Point(678, 170)
        Me.lblNumRollsActual.Name = "lblNumRollsActual"
        Me.lblNumRollsActual.Size = New System.Drawing.Size(19, 20)
        Me.lblNumRollsActual.TabIndex = 20
        Me.lblNumRollsActual.Text = "3"
        '
        'lblNumTurns
        '
        Me.lblNumTurns.AutoSize = True
        Me.lblNumTurns.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblNumTurns.Location = New System.Drawing.Point(2, 170)
        Me.lblNumTurns.Name = "lblNumTurns"
        Me.lblNumTurns.Size = New System.Drawing.Size(174, 20)
        Me.lblNumTurns.TabIndex = 21
        Me.lblNumTurns.Text = "Number of turns left:"
        '
        'lblNumTurnsLeft
        '
        Me.lblNumTurnsLeft.AutoSize = True
        Me.lblNumTurnsLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblNumTurnsLeft.Location = New System.Drawing.Point(176, 170)
        Me.lblNumTurnsLeft.Name = "lblNumTurnsLeft"
        Me.lblNumTurnsLeft.Size = New System.Drawing.Size(29, 20)
        Me.lblNumTurnsLeft.TabIndex = 22
        Me.lblNumTurnsLeft.Text = "13"
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnReset.Location = New System.Drawing.Point(335, 627)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(81, 33)
        Me.btnReset.TabIndex = 23
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblGameOver
        '
        Me.lblGameOver.AutoSize = True
        Me.lblGameOver.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameOver.Location = New System.Drawing.Point(931, 470)
        Me.lblGameOver.Name = "lblGameOver"
        Me.lblGameOver.Size = New System.Drawing.Size(186, 31)
        Me.lblGameOver.TabIndex = 30
        Me.lblGameOver.Text = "GAME OVER"
        Me.lblGameOver.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkGreen
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(772, -10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Padding = New System.Windows.Forms.Padding(3)
        Me.PictureBox1.Size = New System.Drawing.Size(550, 237)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'picDieOne
        '
        Me.picDieOne.Location = New System.Drawing.Point(951, 244)
        Me.picDieOne.Name = "picDieOne"
        Me.picDieOne.Padding = New System.Windows.Forms.Padding(3)
        Me.picDieOne.Size = New System.Drawing.Size(82, 81)
        Me.picDieOne.TabIndex = 29
        Me.picDieOne.TabStop = False
        '
        'picDieFive
        '
        Me.picDieFive.BackColor = System.Drawing.Color.DarkGreen
        Me.picDieFive.Location = New System.Drawing.Point(1169, 449)
        Me.picDieFive.Name = "picDieFive"
        Me.picDieFive.Padding = New System.Windows.Forms.Padding(3)
        Me.picDieFive.Size = New System.Drawing.Size(85, 82)
        Me.picDieFive.TabIndex = 27
        Me.picDieFive.TabStop = False
        '
        'picDieFour
        '
        Me.picDieFour.Location = New System.Drawing.Point(997, 493)
        Me.picDieFour.Name = "picDieFour"
        Me.picDieFour.Padding = New System.Windows.Forms.Padding(3)
        Me.picDieFour.Size = New System.Drawing.Size(81, 81)
        Me.picDieFour.TabIndex = 26
        Me.picDieFour.TabStop = False
        '
        'picDieThree
        '
        Me.picDieThree.Location = New System.Drawing.Point(855, 388)
        Me.picDieThree.Name = "picDieThree"
        Me.picDieThree.Padding = New System.Windows.Forms.Padding(3)
        Me.picDieThree.Size = New System.Drawing.Size(82, 81)
        Me.picDieThree.TabIndex = 25
        Me.picDieThree.TabStop = False
        '
        'picDieTwo
        '
        Me.picDieTwo.Location = New System.Drawing.Point(1133, 296)
        Me.picDieTwo.Name = "picDieTwo"
        Me.picDieTwo.Padding = New System.Windows.Forms.Padding(3)
        Me.picDieTwo.Size = New System.Drawing.Size(83, 82)
        Me.picDieTwo.TabIndex = 24
        Me.picDieTwo.TabStop = False
        '
        'picDie5
        '
        Me.picDie5.Image = CType(resources.GetObject("picDie5.Image"), System.Drawing.Image)
        Me.picDie5.Location = New System.Drawing.Point(569, 44)
        Me.picDie5.Name = "picDie5"
        Me.picDie5.Padding = New System.Windows.Forms.Padding(3)
        Me.picDie5.Size = New System.Drawing.Size(82, 82)
        Me.picDie5.TabIndex = 18
        Me.picDie5.TabStop = False
        '
        'picDie4
        '
        Me.picDie4.BackColor = System.Drawing.Color.DarkGreen
        Me.picDie4.Image = Global.SwetmanFinalProjectYahtzee.My.Resources.Resources._5a
        Me.picDie4.Location = New System.Drawing.Point(453, 45)
        Me.picDie4.Name = "picDie4"
        Me.picDie4.Padding = New System.Windows.Forms.Padding(3)
        Me.picDie4.Size = New System.Drawing.Size(85, 82)
        Me.picDie4.TabIndex = 17
        Me.picDie4.TabStop = False
        '
        'picDie3
        '
        Me.picDie3.Image = Global.SwetmanFinalProjectYahtzee.My.Resources.Resources._4a
        Me.picDie3.Location = New System.Drawing.Point(335, 45)
        Me.picDie3.Name = "picDie3"
        Me.picDie3.Padding = New System.Windows.Forms.Padding(3)
        Me.picDie3.Size = New System.Drawing.Size(81, 81)
        Me.picDie3.TabIndex = 16
        Me.picDie3.TabStop = False
        '
        'picDie2
        '
        Me.picDie2.Image = Global.SwetmanFinalProjectYahtzee.My.Resources.Resources._3a
        Me.picDie2.Location = New System.Drawing.Point(223, 45)
        Me.picDie2.Name = "picDie2"
        Me.picDie2.Padding = New System.Windows.Forms.Padding(3)
        Me.picDie2.Size = New System.Drawing.Size(82, 81)
        Me.picDie2.TabIndex = 15
        Me.picDie2.TabStop = False
        '
        'picDie1
        '
        Me.picDie1.Image = Global.SwetmanFinalProjectYahtzee.My.Resources.Resources._2a
        Me.picDie1.Location = New System.Drawing.Point(115, 44)
        Me.picDie1.Name = "picDie1"
        Me.picDie1.Padding = New System.Windows.Forms.Padding(3)
        Me.picDie1.Size = New System.Drawing.Size(83, 82)
        Me.picDie1.TabIndex = 14
        Me.picDie1.TabStop = False
        '
        'frmInterface
        '
        Me.AcceptButton = Me.btnRoll
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(1266, 749)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblGameOver)
        Me.Controls.Add(Me.picDieOne)
        Me.Controls.Add(Me.picDieFive)
        Me.Controls.Add(Me.picDieFour)
        Me.Controls.Add(Me.picDieThree)
        Me.Controls.Add(Me.picDieTwo)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblNumTurnsLeft)
        Me.Controls.Add(Me.lblNumTurns)
        Me.Controls.Add(Me.lblNumRollsActual)
        Me.Controls.Add(Me.lblNumRolls)
        Me.Controls.Add(Me.picDie5)
        Me.Controls.Add(Me.picDie4)
        Me.Controls.Add(Me.picDie3)
        Me.Controls.Add(Me.picDie2)
        Me.Controls.Add(Me.picDie1)
        Me.Controls.Add(Me.lblGrandActual)
        Me.Controls.Add(Me.lblGrandTotal)
        Me.Controls.Add(Me.lblAdvice)
        Me.Controls.Add(Me.gbxLowerScoreCard)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.gbUpperScoreCard)
        Me.Controls.Add(Me.lblScoreCard)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblUserName)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInterface"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Yahtzee!"
        Me.TransparencyKey = System.Drawing.Color.Gray
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.gbUpperScoreCard.ResumeLayout(False)
        Me.gbUpperScoreCard.PerformLayout()
        Me.gbxLowerScoreCard.ResumeLayout(False)
        Me.gbxLowerScoreCard.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDieOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDieFive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDieFour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDieThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDieTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDie5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDie4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDie3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDie2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDie1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUserName As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStsProgrammerName As ToolStripStatusLabel
    Friend WithEvents lblDate As ToolStripStatusLabel
    Friend WithEvents btnRoll As Button
    Friend WithEvents lblScoreCard As Label
    Friend WithEvents lblAces As Label
    Friend WithEvents lblTwos As Label
    Friend WithEvents gbUpperScoreCard As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents lblUpperTotalActual As Label
    Friend WithEvents lblBonusUpper As Label
    Friend WithEvents lblTotalScoreUpper As Label
    Friend WithEvents lblFives As Label
    Friend WithEvents lblFours As Label
    Friend WithEvents lblThrees As Label
    Friend WithEvents gbxLowerScoreCard As GroupBox
    Friend WithEvents lblTotalScoreLower As Label
    Friend WithEvents lblChance As Label
    Friend WithEvents lblYahtzee As Label
    Friend WithEvents lblLargeStraight As Label
    Friend WithEvents lblSmallStraight As Label
    Friend WithEvents lblFullHouse As Label
    Friend WithEvents lblThreeOfAKind As Label
    Friend WithEvents lblFourOfAKind As Label
    Friend WithEvents lblAdvice As Label
    Friend WithEvents lblUpperTotalActualBox As Label
    Friend WithEvents lblBonusBox As Label
    Friend WithEvents lblTotalScoreUpperBox As Label
    Friend WithEvents lblFivesBox As Label
    Friend WithEvents lblFoursBox As Label
    Friend WithEvents lblThreesBox As Label
    Friend WithEvents lblTwosBox As Label
    Friend WithEvents lblAcesBox As Label
    Friend WithEvents lblTotalScoreLowerBox As Label
    Friend WithEvents lblChanceBox As Label
    Friend WithEvents lblYahtzeeBox As Label
    Friend WithEvents lblLargeStraightBox As Label
    Friend WithEvents lblSmallStraightBox As Label
    Friend WithEvents lblFullHouseBox As Label
    Friend WithEvents lblFourOfAKindBox As Label
    Friend WithEvents lblThreeOfAKindBox As Label
    Friend WithEvents lblGrandTotal As Label
    Friend WithEvents lblGrandActual As Label
    Friend WithEvents picDie1 As PictureBox
    Friend WithEvents picDie2 As PictureBox
    Friend WithEvents picDie3 As PictureBox
    Friend WithEvents picDie4 As PictureBox
    Friend WithEvents picDie5 As PictureBox
    Friend WithEvents lblNumRolls As Label
    Friend WithEvents lblNumRollsActual As Label
    Friend WithEvents lblNumTurns As Label
    Friend WithEvents lblNumTurnsLeft As Label
    Friend WithEvents lblSixes As Label
    Friend WithEvents lblSixesBox As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents picDieTwo As PictureBox
    Friend WithEvents picDieThree As PictureBox
    Friend WithEvents picDieFour As PictureBox
    Friend WithEvents picDieFive As PictureBox
    Friend WithEvents picDieOne As PictureBox
    Friend WithEvents lblGameOver As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
