<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inventorymain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inventorymain))
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'RadioButton1
        '
        Me.RadioButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.RadioButton1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RadioButton1.Location = New System.Drawing.Point(71, 61)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(97, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "ADD RECORD"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.RadioButton2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RadioButton2.Location = New System.Drawing.Point(71, 106)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(116, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "DELETE RECORD"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RadioButton3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RadioButton3.Location = New System.Drawing.Point(71, 143)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(105, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "CHANGE PRICE"
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(69, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "SELECT OPTION"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(138, 259)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(34, 259)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "<< BACK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(246, 259)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(74, 23)
        Me.Button4.TabIndex = 47
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.BackColor = System.Drawing.SystemColors.HighlightText
        Me.RadioButton4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RadioButton4.Location = New System.Drawing.Point(72, 181)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(109, 17)
        Me.RadioButton4.TabIndex = 48
        Me.RadioButton4.Text = "VIEW RECODRS"
        Me.RadioButton4.UseVisualStyleBackColor = False
        '
        'inventorymain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(380, 319)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Name = "inventorymain"
        Me.Text = "inventorymain"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Button4 As Button
    Friend WithEvents RadioButton4 As RadioButton
End Class
