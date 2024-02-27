<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salaries
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
        Me.TxtCurrent = New System.Windows.Forms.TextBox()
        Me.Txt5 = New System.Windows.Forms.TextBox()
        Me.Txt5New = New System.Windows.Forms.TextBox()
        Me.Txt8New = New System.Windows.Forms.TextBox()
        Me.Txt8 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtCurrent
        '
        Me.TxtCurrent.Location = New System.Drawing.Point(155, 42)
        Me.TxtCurrent.Multiline = True
        Me.TxtCurrent.Name = "TxtCurrent"
        Me.TxtCurrent.Size = New System.Drawing.Size(94, 20)
        Me.TxtCurrent.TabIndex = 0
        '
        'Txt5
        '
        Me.Txt5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt5.Location = New System.Drawing.Point(39, 138)
        Me.Txt5.Multiline = True
        Me.Txt5.Name = "Txt5"
        Me.Txt5.ReadOnly = True
        Me.Txt5.Size = New System.Drawing.Size(94, 31)
        Me.Txt5.TabIndex = 1
        Me.Txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt5New
        '
        Me.Txt5New.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt5New.Location = New System.Drawing.Point(184, 138)
        Me.Txt5New.Multiline = True
        Me.Txt5New.Name = "Txt5New"
        Me.Txt5New.ReadOnly = True
        Me.Txt5New.Size = New System.Drawing.Size(94, 31)
        Me.Txt5New.TabIndex = 2
        Me.Txt5New.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt8New
        '
        Me.Txt8New.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt8New.Location = New System.Drawing.Point(184, 222)
        Me.Txt8New.Multiline = True
        Me.Txt8New.Name = "Txt8New"
        Me.Txt8New.ReadOnly = True
        Me.Txt8New.Size = New System.Drawing.Size(94, 31)
        Me.Txt8New.TabIndex = 4
        Me.Txt8New.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt8
        '
        Me.Txt8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt8.Location = New System.Drawing.Point(39, 222)
        Me.Txt8.Multiline = True
        Me.Txt8.Name = "Txt8"
        Me.Txt8.ReadOnly = True
        Me.Txt8.Size = New System.Drawing.Size(94, 31)
        Me.Txt8.TabIndex = 3
        Me.Txt8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Current Salary:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "5% Raise:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(181, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "New Salary:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(181, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "New Salary:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "8% Raise:"
        '
        'BtnCalc
        '
        Me.BtnCalc.Location = New System.Drawing.Point(317, 31)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(108, 31)
        Me.BtnCalc.TabIndex = 10
        Me.BtnCalc.Text = "Calculate"
        Me.BtnCalc.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(317, 68)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(108, 31)
        Me.BtnClear.TabIndex = 11
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(317, 105)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(108, 31)
        Me.BtnExit.TabIndex = 12
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Salaries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 316)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnCalc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt8New)
        Me.Controls.Add(Me.Txt8)
        Me.Controls.Add(Me.Txt5New)
        Me.Controls.Add(Me.Txt5)
        Me.Controls.Add(Me.TxtCurrent)
        Me.Name = "Salaries"
        Me.Text = "Raises and New Salaries - Arlo Russell"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtCurrent As TextBox
    Friend WithEvents Txt5 As TextBox
    Friend WithEvents Txt5New As TextBox
    Friend WithEvents Txt8New As TextBox
    Friend WithEvents Txt8 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnCalc As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnExit As Button
End Class
