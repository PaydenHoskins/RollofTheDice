<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RollofTheDice
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
        Me.DiceListBox = New System.Windows.Forms.ListBox()
        Me.RollButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.EndButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DiceListBox
        '
        Me.DiceListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DiceListBox.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiceListBox.FormattingEnabled = True
        Me.DiceListBox.ItemHeight = 19
        Me.DiceListBox.Location = New System.Drawing.Point(5, 15)
        Me.DiceListBox.Margin = New System.Windows.Forms.Padding(100, 3, 3, 3)
        Me.DiceListBox.Name = "DiceListBox"
        Me.DiceListBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DiceListBox.Size = New System.Drawing.Size(783, 251)
        Me.DiceListBox.TabIndex = 0
        '
        'RollButton
        '
        Me.RollButton.Location = New System.Drawing.Point(5, 324)
        Me.RollButton.Name = "RollButton"
        Me.RollButton.Size = New System.Drawing.Size(260, 105)
        Me.RollButton.TabIndex = 1
        Me.RollButton.Text = "Roll"
        Me.RollButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(271, 324)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(260, 105)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'EndButton
        '
        Me.EndButton.Location = New System.Drawing.Point(537, 324)
        Me.EndButton.Name = "EndButton"
        Me.EndButton.Size = New System.Drawing.Size(260, 105)
        Me.EndButton.TabIndex = 3
        Me.EndButton.Text = "End"
        Me.EndButton.UseVisualStyleBackColor = True
        '
        'RollofTheDice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.EndButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.RollButton)
        Me.Controls.Add(Me.DiceListBox)
        Me.Name = "RollofTheDice"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DiceListBox As ListBox
    Friend WithEvents RollButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents EndButton As Button
End Class
