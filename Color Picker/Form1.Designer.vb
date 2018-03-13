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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.start = New System.Windows.Forms.Button()
        Me.done = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.redtxt = New System.Windows.Forms.TextBox()
        Me.greentxt = New System.Windows.Forms.TextBox()
        Me.bluetxt = New System.Windows.Forms.TextBox()
        Me.red = New System.Windows.Forms.Label()
        Me.green = New System.Windows.Forms.Label()
        Me.blue = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.hexbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.SuspendLayout()
        '
        'start
        '
        Me.start.Location = New System.Drawing.Point(12, 13)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(157, 30)
        Me.start.TabIndex = 0
        Me.start.Text = "Start (F6)"
        Me.start.UseVisualStyleBackColor = True
        '
        'done
        '
        Me.done.Location = New System.Drawing.Point(12, 52)
        Me.done.Name = "done"
        Me.done.Size = New System.Drawing.Size(157, 30)
        Me.done.TabIndex = 1
        Me.done.Text = "Done (F7)"
        Me.done.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(184, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(175, 157)
        Me.Panel1.TabIndex = 2
        '
        'redtxt
        '
        Me.redtxt.Location = New System.Drawing.Point(69, 96)
        Me.redtxt.Name = "redtxt"
        Me.redtxt.Size = New System.Drawing.Size(100, 20)
        Me.redtxt.TabIndex = 3
        '
        'greentxt
        '
        Me.greentxt.Location = New System.Drawing.Point(69, 122)
        Me.greentxt.Name = "greentxt"
        Me.greentxt.Size = New System.Drawing.Size(100, 20)
        Me.greentxt.TabIndex = 4
        '
        'bluetxt
        '
        Me.bluetxt.Location = New System.Drawing.Point(69, 148)
        Me.bluetxt.Name = "bluetxt"
        Me.bluetxt.Size = New System.Drawing.Size(100, 20)
        Me.bluetxt.TabIndex = 5
        '
        'red
        '
        Me.red.AutoSize = True
        Me.red.Location = New System.Drawing.Point(19, 99)
        Me.red.Name = "red"
        Me.red.Size = New System.Drawing.Size(33, 13)
        Me.red.TabIndex = 6
        Me.red.Text = "Red :"
        '
        'green
        '
        Me.green.AutoSize = True
        Me.green.Location = New System.Drawing.Point(19, 125)
        Me.green.Name = "green"
        Me.green.Size = New System.Drawing.Size(42, 13)
        Me.green.TabIndex = 7
        Me.green.Text = "Green :"
        '
        'blue
        '
        Me.blue.AutoSize = True
        Me.blue.Location = New System.Drawing.Point(19, 151)
        Me.blue.Name = "blue"
        Me.blue.Size = New System.Drawing.Size(34, 13)
        Me.blue.TabIndex = 8
        Me.blue.Text = "Blue :"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'hexbox
        '
        Me.hexbox.Location = New System.Drawing.Point(69, 175)
        Me.hexbox.Name = "hexbox"
        Me.hexbox.Size = New System.Drawing.Size(100, 20)
        Me.hexbox.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Hex :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(184, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Color Dialog"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 211)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.hexbox)
        Me.Controls.Add(Me.blue)
        Me.Controls.Add(Me.green)
        Me.Controls.Add(Me.red)
        Me.Controls.Add(Me.bluetxt)
        Me.Controls.Add(Me.greentxt)
        Me.Controls.Add(Me.redtxt)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.done)
        Me.Controls.Add(Me.start)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Color Picker"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents start As System.Windows.Forms.Button
    Friend WithEvents done As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents redtxt As System.Windows.Forms.TextBox
    Friend WithEvents greentxt As System.Windows.Forms.TextBox
    Friend WithEvents bluetxt As System.Windows.Forms.TextBox
    Friend WithEvents red As System.Windows.Forms.Label
    Friend WithEvents green As System.Windows.Forms.Label
    Friend WithEvents blue As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents hexbox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog

End Class
