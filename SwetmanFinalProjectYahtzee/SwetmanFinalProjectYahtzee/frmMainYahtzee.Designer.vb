<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmYahtzee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmYahtzee))
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.lblYahtzeeWelcome = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStsProgrammerName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStsDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.SystemColors.Control
        Me.btnPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.ForeColor = System.Drawing.Color.Black
        Me.btnPlay.Location = New System.Drawing.Point(173, 277)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(110, 37)
        Me.btnPlay.TabIndex = 3
        Me.btnPlay.Text = "&Play"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'lblYahtzeeWelcome
        '
        Me.lblYahtzeeWelcome.AutoSize = True
        Me.lblYahtzeeWelcome.BackColor = System.Drawing.Color.Green
        Me.lblYahtzeeWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYahtzeeWelcome.ForeColor = System.Drawing.Color.Black
        Me.lblYahtzeeWelcome.Location = New System.Drawing.Point(186, 9)
        Me.lblYahtzeeWelcome.Name = "lblYahtzeeWelcome"
        Me.lblYahtzeeWelcome.Size = New System.Drawing.Size(202, 24)
        Me.lblYahtzeeWelcome.TabIndex = 1
        Me.lblYahtzeeWelcome.Text = "Welcome to Yahtzee"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Green
        Me.txtName.Location = New System.Drawing.Point(307, 67)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(134, 21)
        Me.txtName.TabIndex = 2
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Green
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(120, 68)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(163, 20)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Please Enter Name"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(307, 277)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 37)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStsProgrammerName, Me.lblStsDate})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 351)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(600, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStsProgrammerName
        '
        Me.lblStsProgrammerName.BackColor = System.Drawing.Color.White
        Me.lblStsProgrammerName.Name = "lblStsProgrammerName"
        Me.lblStsProgrammerName.Size = New System.Drawing.Size(102, 17)
        Me.lblStsProgrammerName.Text = "Stephen Swetman"
        '
        'lblStsDate
        '
        Me.lblStsDate.BackColor = System.Drawing.Color.White
        Me.lblStsDate.Name = "lblStsDate"
        Me.lblStsDate.Size = New System.Drawing.Size(31, 17)
        Me.lblStsDate.Text = "Date"
        '
        'frmYahtzee
        '
        Me.AcceptButton = Me.btnPlay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.SwetmanFinalProjectYahtzee.My.Resources.Resources.yahtzee_dice4
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(600, 373)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblYahtzeeWelcome)
        Me.Controls.Add(Me.btnPlay)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmYahtzee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Yahtzee!"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPlay As Button
    Friend WithEvents lblYahtzeeWelcome As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStsProgrammerName As ToolStripStatusLabel
    Friend WithEvents lblStsDate As ToolStripStatusLabel
End Class
