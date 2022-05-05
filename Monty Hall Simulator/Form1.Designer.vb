<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.iterations = New System.Windows.Forms.TextBox()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.stayingResult = New System.Windows.Forms.Label()
    Me.switchingResult = New System.Windows.Forms.Label()
    Me.Button1 = New System.Windows.Forms.Button()
    Me.GroupBox1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(56, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Iterations: "
    '
    'iterations
    '
    Me.iterations.Location = New System.Drawing.Point(74, 6)
    Me.iterations.Name = "iterations"
    Me.iterations.Size = New System.Drawing.Size(100, 20)
    Me.iterations.TabIndex = 1
    Me.iterations.Text = "10000"
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.switchingResult)
    Me.GroupBox1.Controls.Add(Me.stayingResult)
    Me.GroupBox1.Controls.Add(Me.Label3)
    Me.GroupBox1.Controls.Add(Me.Label2)
    Me.GroupBox1.Location = New System.Drawing.Point(12, 43)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(162, 100)
    Me.GroupBox1.TabIndex = 2
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Results"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(6, 26)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(85, 13)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Staying win rate:"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(6, 50)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(96, 13)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "Switching win rate:"
    '
    'stayingResult
    '
    Me.stayingResult.AutoSize = True
    Me.stayingResult.Location = New System.Drawing.Point(123, 26)
    Me.stayingResult.Name = "stayingResult"
    Me.stayingResult.Size = New System.Drawing.Size(21, 13)
    Me.stayingResult.TabIndex = 5
    Me.stayingResult.Text = "0%"
    '
    'switchingResult
    '
    Me.switchingResult.AutoSize = True
    Me.switchingResult.Location = New System.Drawing.Point(123, 50)
    Me.switchingResult.Name = "switchingResult"
    Me.switchingResult.Size = New System.Drawing.Size(21, 13)
    Me.switchingResult.TabIndex = 6
    Me.switchingResult.Text = "0%"
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(99, 149)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(75, 23)
    Me.Button1.TabIndex = 3
    Me.Button1.Text = "Go"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(187, 181)
    Me.Controls.Add(Me.Button1)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.iterations)
    Me.Controls.Add(Me.Label1)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Form1"
    Me.Text = "Simulator"
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents iterations As System.Windows.Forms.TextBox
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents switchingResult As System.Windows.Forms.Label
  Friend WithEvents stayingResult As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
