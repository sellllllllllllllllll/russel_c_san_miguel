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
        Me.science_textbox = New System.Windows.Forms.TextBox()
        Me.math_textbox = New System.Windows.Forms.TextBox()
        Me.english_textbox = New System.Windows.Forms.TextBox()
        Me.evaluate_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'science_textbox
        '
        Me.science_textbox.Location = New System.Drawing.Point(68, 168)
        Me.science_textbox.Multiline = True
        Me.science_textbox.Name = "science_textbox"
        Me.science_textbox.Size = New System.Drawing.Size(336, 32)
        Me.science_textbox.TabIndex = 1
        '
        'math_textbox
        '
        Me.math_textbox.Location = New System.Drawing.Point(68, 98)
        Me.math_textbox.Multiline = True
        Me.math_textbox.Name = "math_textbox"
        Me.math_textbox.Size = New System.Drawing.Size(336, 32)
        Me.math_textbox.TabIndex = 2
        '
        'english_textbox
        '
        Me.english_textbox.Location = New System.Drawing.Point(68, 234)
        Me.english_textbox.Multiline = True
        Me.english_textbox.Name = "english_textbox"
        Me.english_textbox.Size = New System.Drawing.Size(336, 32)
        Me.english_textbox.TabIndex = 3
        '
        'evaluate_btn
        '
        Me.evaluate_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.evaluate_btn.Location = New System.Drawing.Point(163, 294)
        Me.evaluate_btn.Name = "evaluate_btn"
        Me.evaluate_btn.Size = New System.Drawing.Size(147, 39)
        Me.evaluate_btn.TabIndex = 4
        Me.evaluate_btn.Text = "EVALUATE"
        Me.evaluate_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "MATH"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "SCIENCE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ENGLISH"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 411)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.evaluate_btn)
        Me.Controls.Add(Me.english_textbox)
        Me.Controls.Add(Me.math_textbox)
        Me.Controls.Add(Me.science_textbox)
        Me.Name = "Form1"
        Me.Text = "GradeForm1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents science_textbox As TextBox
    Friend WithEvents math_textbox As TextBox
    Friend WithEvents english_textbox As TextBox
    Friend WithEvents evaluate_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
