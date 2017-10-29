<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComicCharacter
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
        Me.picComicCharacter = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblGroupSizeLabel = New System.Windows.Forms.Label()
        Me.txtGroupSize = New System.Windows.Forms.TextBox()
        Me.grpBadgeType = New System.Windows.Forms.GroupBox()
        Me.radConventionSuperhero = New System.Windows.Forms.RadioButton()
        Me.radConventionAutographs = New System.Windows.Forms.RadioButton()
        Me.radConvention = New System.Windows.Forms.RadioButton()
        Me.pnlOptionalPreviewNight = New System.Windows.Forms.Panel()
        Me.chkOptionalPreviewNight = New System.Windows.Forms.CheckBox()
        Me.lblRegistrationCostLabel = New System.Windows.Forms.Label()
        Me.lblRegistrationCost = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.picComicCharacter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBadgeType.SuspendLayout()
        Me.pnlOptionalPreviewNight.SuspendLayout()
        Me.SuspendLayout()
        '
        'picComicCharacter
        '
        Me.picComicCharacter.Image = Global.Comic_Character_Convention.My.Resources.Resources.Comic
        Me.picComicCharacter.Location = New System.Drawing.Point(0, 0)
        Me.picComicCharacter.Name = "picComicCharacter"
        Me.picComicCharacter.Size = New System.Drawing.Size(418, 212)
        Me.picComicCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picComicCharacter.TabIndex = 0
        Me.picComicCharacter.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(59, 224)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(301, 78)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Comic Character Convention Registration"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblGroupSizeLabel
        '
        Me.lblGroupSizeLabel.AutoSize = True
        Me.lblGroupSizeLabel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupSizeLabel.Location = New System.Drawing.Point(117, 323)
        Me.lblGroupSizeLabel.Name = "lblGroupSizeLabel"
        Me.lblGroupSizeLabel.Size = New System.Drawing.Size(101, 23)
        Me.lblGroupSizeLabel.TabIndex = 2
        Me.lblGroupSizeLabel.Text = "Group Size:"
        '
        'txtGroupSize
        '
        Me.txtGroupSize.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupSize.Location = New System.Drawing.Point(220, 320)
        Me.txtGroupSize.Name = "txtGroupSize"
        Me.txtGroupSize.Size = New System.Drawing.Size(56, 30)
        Me.txtGroupSize.TabIndex = 3
        Me.txtGroupSize.Text = "XX"
        Me.txtGroupSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpBadgeType
        '
        Me.grpBadgeType.Controls.Add(Me.radConvention)
        Me.grpBadgeType.Controls.Add(Me.radConventionAutographs)
        Me.grpBadgeType.Controls.Add(Me.radConventionSuperhero)
        Me.grpBadgeType.Font = New System.Drawing.Font("Broadway", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBadgeType.ForeColor = System.Drawing.Color.Red
        Me.grpBadgeType.Location = New System.Drawing.Point(25, 379)
        Me.grpBadgeType.Name = "grpBadgeType"
        Me.grpBadgeType.Size = New System.Drawing.Size(368, 115)
        Me.grpBadgeType.TabIndex = 4
        Me.grpBadgeType.TabStop = False
        Me.grpBadgeType.Text = "Select Badge Type:"
        '
        'radConventionSuperhero
        '
        Me.radConventionSuperhero.AutoSize = True
        Me.radConventionSuperhero.Checked = True
        Me.radConventionSuperhero.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radConventionSuperhero.Location = New System.Drawing.Point(14, 21)
        Me.radConventionSuperhero.Name = "radConventionSuperhero"
        Me.radConventionSuperhero.Size = New System.Drawing.Size(340, 23)
        Me.radConventionSuperhero.TabIndex = 0
        Me.radConventionSuperhero.TabStop = True
        Me.radConventionSuperhero.Text = "Convention + Superhero Experience"
        Me.radConventionSuperhero.UseVisualStyleBackColor = True
        '
        'radConventionAutographs
        '
        Me.radConventionAutographs.AutoSize = True
        Me.radConventionAutographs.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radConventionAutographs.Location = New System.Drawing.Point(14, 47)
        Me.radConventionAutographs.Name = "radConventionAutographs"
        Me.radConventionAutographs.Size = New System.Drawing.Size(246, 23)
        Me.radConventionAutographs.TabIndex = 1
        Me.radConventionAutographs.Text = "Convention + Autographs"
        Me.radConventionAutographs.UseVisualStyleBackColor = True
        '
        'radConvention
        '
        Me.radConvention.AutoSize = True
        Me.radConvention.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radConvention.Location = New System.Drawing.Point(14, 73)
        Me.radConvention.Name = "radConvention"
        Me.radConvention.Size = New System.Drawing.Size(127, 23)
        Me.radConvention.TabIndex = 2
        Me.radConvention.Text = "Convention"
        Me.radConvention.UseVisualStyleBackColor = True
        '
        'pnlOptionalPreviewNight
        '
        Me.pnlOptionalPreviewNight.BackColor = System.Drawing.Color.Yellow
        Me.pnlOptionalPreviewNight.Controls.Add(Me.chkOptionalPreviewNight)
        Me.pnlOptionalPreviewNight.ForeColor = System.Drawing.Color.Black
        Me.pnlOptionalPreviewNight.Location = New System.Drawing.Point(25, 500)
        Me.pnlOptionalPreviewNight.Name = "pnlOptionalPreviewNight"
        Me.pnlOptionalPreviewNight.Size = New System.Drawing.Size(368, 47)
        Me.pnlOptionalPreviewNight.TabIndex = 5
        '
        'chkOptionalPreviewNight
        '
        Me.chkOptionalPreviewNight.AutoSize = True
        Me.chkOptionalPreviewNight.Checked = True
        Me.chkOptionalPreviewNight.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkOptionalPreviewNight.Font = New System.Drawing.Font("Broadway", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOptionalPreviewNight.Location = New System.Drawing.Point(53, 11)
        Me.chkOptionalPreviewNight.Name = "chkOptionalPreviewNight"
        Me.chkOptionalPreviewNight.Size = New System.Drawing.Size(262, 25)
        Me.chkOptionalPreviewNight.TabIndex = 0
        Me.chkOptionalPreviewNight.Text = "Optional Preview Night"
        Me.chkOptionalPreviewNight.UseVisualStyleBackColor = True
        '
        'lblRegistrationCostLabel
        '
        Me.lblRegistrationCostLabel.AutoSize = True
        Me.lblRegistrationCostLabel.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistrationCostLabel.Location = New System.Drawing.Point(67, 579)
        Me.lblRegistrationCostLabel.Name = "lblRegistrationCostLabel"
        Me.lblRegistrationCostLabel.Size = New System.Drawing.Size(168, 23)
        Me.lblRegistrationCostLabel.TabIndex = 6
        Me.lblRegistrationCostLabel.Text = "Registration Cost:"
        '
        'lblRegistrationCost
        '
        Me.lblRegistrationCost.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistrationCost.Location = New System.Drawing.Point(241, 579)
        Me.lblRegistrationCost.Name = "lblRegistrationCost"
        Me.lblRegistrationCost.Size = New System.Drawing.Size(114, 23)
        Me.lblRegistrationCost.TabIndex = 7
        Me.lblRegistrationCost.Text = "$1,256.00"
        Me.lblRegistrationCost.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Yellow
        Me.btnCalculate.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.Black
        Me.btnCalculate.Location = New System.Drawing.Point(63, 624)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(128, 39)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Yellow
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(227, 624)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(128, 39)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'frmComicCharacter
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(418, 684)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblRegistrationCost)
        Me.Controls.Add(Me.lblRegistrationCostLabel)
        Me.Controls.Add(Me.pnlOptionalPreviewNight)
        Me.Controls.Add(Me.grpBadgeType)
        Me.Controls.Add(Me.txtGroupSize)
        Me.Controls.Add(Me.lblGroupSizeLabel)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picComicCharacter)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmComicCharacter"
        Me.Text = "Comic Character Convention"
        CType(Me.picComicCharacter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBadgeType.ResumeLayout(False)
        Me.grpBadgeType.PerformLayout()
        Me.pnlOptionalPreviewNight.ResumeLayout(False)
        Me.pnlOptionalPreviewNight.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picComicCharacter As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblGroupSizeLabel As Label
    Friend WithEvents txtGroupSize As TextBox
    Friend WithEvents grpBadgeType As GroupBox
    Friend WithEvents radConvention As RadioButton
    Friend WithEvents radConventionAutographs As RadioButton
    Friend WithEvents radConventionSuperhero As RadioButton
    Friend WithEvents pnlOptionalPreviewNight As Panel
    Friend WithEvents chkOptionalPreviewNight As CheckBox
    Friend WithEvents lblRegistrationCostLabel As Label
    Friend WithEvents lblRegistrationCost As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
End Class
