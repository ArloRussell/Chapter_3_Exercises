<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grades
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
        Me.TxtP = New System.Windows.Forms.TextBox()
        Me.TxtF = New System.Windows.Forms.TextBox()
        Me.TxtFPer = New System.Windows.Forms.TextBox()
        Me.TxtPPer = New System.Windows.Forms.TextBox()
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtP
        '
        Me.TxtP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtP.Location = New System.Drawing.Point(125, 47)
        Me.TxtP.Multiline = True
        Me.TxtP.Name = "TxtP"
        Me.TxtP.Size = New System.Drawing.Size(71, 27)
        Me.TxtP.TabIndex = 0
        '
        'TxtF
        '
        Me.TxtF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtF.Location = New System.Drawing.Point(125, 97)
        Me.TxtF.Multiline = True
        Me.TxtF.Name = "TxtF"
        Me.TxtF.Size = New System.Drawing.Size(71, 27)
        Me.TxtF.TabIndex = 1
        '
        'TxtFPer
        '
        Me.TxtFPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFPer.Location = New System.Drawing.Point(222, 97)
        Me.TxtFPer.Multiline = True
        Me.TxtFPer.Name = "TxtFPer"
        Me.TxtFPer.ReadOnly = True
        Me.TxtFPer.Size = New System.Drawing.Size(98, 27)
        Me.TxtFPer.TabIndex = 3
        '
        'TxtPPer
        '
        Me.TxtPPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPPer.Location = New System.Drawing.Point(222, 47)
        Me.TxtPPer.Multiline = True
        Me.TxtPPer.Name = "TxtPPer"
        Me.TxtPPer.ReadOnly = True
        Me.TxtPPer.Size = New System.Drawing.Size(98, 27)
        Me.TxtPPer.TabIndex = 2
        '
        'BtnCalc
        '
        Me.BtnCalc.Location = New System.Drawing.Point(357, 47)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(96, 27)
        Me.BtnCalc.TabIndex = 4
        Me.BtnCalc.Text = "Calculate"
        Me.BtnCalc.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(357, 97)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(96, 27)
        Me.BtnExit.TabIndex = 5
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Grade P Students:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Grade F Students:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(222, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Percentages:"
        '
        'Grades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 180)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnCalc)
        Me.Controls.Add(Me.TxtFPer)
        Me.Controls.Add(Me.TxtPPer)
        Me.Controls.Add(Me.TxtF)
        Me.Controls.Add(Me.TxtP)
        Me.Name = "Grades"
        Me.Text = "Grade Percentages - Arlo Russell"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtP As TextBox
    Friend WithEvents TxtF As TextBox
    Friend WithEvents TxtFPer As TextBox
    Friend WithEvents TxtPPer As TextBox
    Friend WithEvents BtnCalc As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
