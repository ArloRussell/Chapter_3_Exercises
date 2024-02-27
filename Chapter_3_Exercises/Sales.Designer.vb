<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
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
        Me.TxtJim = New System.Windows.Forms.TextBox()
        Me.TxtJimPer = New System.Windows.Forms.TextBox()
        Me.TxtKarenPer = New System.Windows.Forms.TextBox()
        Me.TxtKaren = New System.Windows.Forms.TextBox()
        Me.TxtMartinPer = New System.Windows.Forms.TextBox()
        Me.TxtMartin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtJim
        '
        Me.TxtJim.Location = New System.Drawing.Point(86, 66)
        Me.TxtJim.Multiline = True
        Me.TxtJim.Name = "TxtJim"
        Me.TxtJim.Size = New System.Drawing.Size(100, 28)
        Me.TxtJim.TabIndex = 0
        '
        'TxtJimPer
        '
        Me.TxtJimPer.Location = New System.Drawing.Point(223, 66)
        Me.TxtJimPer.Multiline = True
        Me.TxtJimPer.Name = "TxtJimPer"
        Me.TxtJimPer.ReadOnly = True
        Me.TxtJimPer.Size = New System.Drawing.Size(117, 28)
        Me.TxtJimPer.TabIndex = 1
        '
        'TxtKarenPer
        '
        Me.TxtKarenPer.Location = New System.Drawing.Point(223, 100)
        Me.TxtKarenPer.Multiline = True
        Me.TxtKarenPer.Name = "TxtKarenPer"
        Me.TxtKarenPer.ReadOnly = True
        Me.TxtKarenPer.Size = New System.Drawing.Size(117, 28)
        Me.TxtKarenPer.TabIndex = 3
        '
        'TxtKaren
        '
        Me.TxtKaren.Location = New System.Drawing.Point(86, 100)
        Me.TxtKaren.Multiline = True
        Me.TxtKaren.Name = "TxtKaren"
        Me.TxtKaren.Size = New System.Drawing.Size(100, 28)
        Me.TxtKaren.TabIndex = 2
        '
        'TxtMartinPer
        '
        Me.TxtMartinPer.Location = New System.Drawing.Point(223, 134)
        Me.TxtMartinPer.Multiline = True
        Me.TxtMartinPer.Name = "TxtMartinPer"
        Me.TxtMartinPer.ReadOnly = True
        Me.TxtMartinPer.Size = New System.Drawing.Size(117, 28)
        Me.TxtMartinPer.TabIndex = 5
        '
        'TxtMartin
        '
        Me.TxtMartin.Location = New System.Drawing.Point(86, 134)
        Me.TxtMartin.Multiline = True
        Me.TxtMartin.Name = "TxtMartin"
        Me.TxtMartin.Size = New System.Drawing.Size(100, 28)
        Me.TxtMartin.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Jim:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Karen:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Martin:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(103, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Sales:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(219, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 24)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Percentages:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCalc
        '
        Me.BtnCalc.Location = New System.Drawing.Point(384, 66)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(117, 28)
        Me.BtnCalc.TabIndex = 11
        Me.BtnCalc.Text = "Calculate"
        Me.BtnCalc.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(384, 100)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(117, 28)
        Me.BtnExit.TabIndex = 12
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 192)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnCalc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtMartinPer)
        Me.Controls.Add(Me.TxtMartin)
        Me.Controls.Add(Me.TxtKarenPer)
        Me.Controls.Add(Me.TxtKaren)
        Me.Controls.Add(Me.TxtJimPer)
        Me.Controls.Add(Me.TxtJim)
        Me.Name = "Sales"
        Me.Text = "Sales Percentages - Arlo Russell"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtJim As TextBox
    Friend WithEvents TxtJimPer As TextBox
    Friend WithEvents TxtKarenPer As TextBox
    Friend WithEvents TxtKaren As TextBox
    Friend WithEvents TxtMartinPer As TextBox
    Friend WithEvents TxtMartin As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnCalc As Button
    Friend WithEvents BtnExit As Button
End Class
