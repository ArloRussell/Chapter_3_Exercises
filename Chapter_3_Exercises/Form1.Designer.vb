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
        Me.TxtCS = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.BtnEx = New System.Windows.Forms.Button()
        Me.TxtPS = New System.Windows.Forms.TextBox()
        Me.TxtInc = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TxtCS
        '
        Me.TxtCS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCS.Location = New System.Drawing.Point(24, 42)
        Me.TxtCS.Multiline = True
        Me.TxtCS.Name = "TxtCS"
        Me.TxtCS.Size = New System.Drawing.Size(88, 28)
        Me.TxtCS.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Current Sales:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(174, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "10% Increase:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(325, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Projected Sales:"
        '
        'BtnCalc
        '
        Me.BtnCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalc.Location = New System.Drawing.Point(220, 120)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(92, 29)
        Me.BtnCalc.TabIndex = 6
        Me.BtnCalc.Text = "Calculate"
        Me.BtnCalc.UseVisualStyleBackColor = True
        '
        'BtnEx
        '
        Me.BtnEx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEx.Location = New System.Drawing.Point(328, 120)
        Me.BtnEx.Name = "BtnEx"
        Me.BtnEx.Size = New System.Drawing.Size(92, 29)
        Me.BtnEx.TabIndex = 7
        Me.BtnEx.Text = "Exit"
        Me.BtnEx.UseVisualStyleBackColor = True
        '
        'TxtPS
        '
        Me.TxtPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPS.Location = New System.Drawing.Point(328, 42)
        Me.TxtPS.Multiline = True
        Me.TxtPS.Name = "TxtPS"
        Me.TxtPS.ReadOnly = True
        Me.TxtPS.Size = New System.Drawing.Size(88, 28)
        Me.TxtPS.TabIndex = 2
        '
        'TxtInc
        '
        Me.TxtInc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInc.Location = New System.Drawing.Point(177, 42)
        Me.TxtInc.Multiline = True
        Me.TxtInc.Name = "TxtInc"
        Me.TxtInc.ReadOnly = True
        Me.TxtInc.Size = New System.Drawing.Size(88, 28)
        Me.TxtInc.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 161)
        Me.Controls.Add(Me.BtnEx)
        Me.Controls.Add(Me.BtnCalc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtPS)
        Me.Controls.Add(Me.TxtInc)
        Me.Controls.Add(Me.TxtCS)
        Me.Name = "Form1"
        Me.Text = "Moonbucks - Arlo Russell"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtCS As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnCalc As Button
    Friend WithEvents BtnEx As Button
    Friend WithEvents TxtPS As TextBox
    Friend WithEvents TxtInc As TextBox
End Class
