<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Toys
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt12 = New System.Windows.Forms.TextBox()
        Me.Txt5 = New System.Windows.Forms.TextBox()
        Me.Txt2 = New System.Windows.Forms.TextBox()
        Me.Txt2Cost = New System.Windows.Forms.TextBox()
        Me.Txt5Cost = New System.Windows.Forms.TextBox()
        Me.Txt12Cost = New System.Windows.Forms.TextBox()
        Me.TxtShip = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCostTot = New System.Windows.Forms.TextBox()
        Me.TxtPackTot = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "12 Pack:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "5 Pack:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "2 Pack:"
        '
        'Txt12
        '
        Me.Txt12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt12.Location = New System.Drawing.Point(102, 40)
        Me.Txt12.Multiline = True
        Me.Txt12.Name = "Txt12"
        Me.Txt12.Size = New System.Drawing.Size(78, 32)
        Me.Txt12.TabIndex = 3
        '
        'Txt5
        '
        Me.Txt5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt5.Location = New System.Drawing.Point(101, 78)
        Me.Txt5.Multiline = True
        Me.Txt5.Name = "Txt5"
        Me.Txt5.Size = New System.Drawing.Size(78, 32)
        Me.Txt5.TabIndex = 4
        '
        'Txt2
        '
        Me.Txt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt2.Location = New System.Drawing.Point(101, 116)
        Me.Txt2.Multiline = True
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(78, 32)
        Me.Txt2.TabIndex = 5
        '
        'Txt2Cost
        '
        Me.Txt2Cost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt2Cost.Location = New System.Drawing.Point(185, 116)
        Me.Txt2Cost.Multiline = True
        Me.Txt2Cost.Name = "Txt2Cost"
        Me.Txt2Cost.ReadOnly = True
        Me.Txt2Cost.Size = New System.Drawing.Size(120, 32)
        Me.Txt2Cost.TabIndex = 8
        '
        'Txt5Cost
        '
        Me.Txt5Cost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt5Cost.Location = New System.Drawing.Point(185, 78)
        Me.Txt5Cost.Multiline = True
        Me.Txt5Cost.Name = "Txt5Cost"
        Me.Txt5Cost.ReadOnly = True
        Me.Txt5Cost.Size = New System.Drawing.Size(120, 32)
        Me.Txt5Cost.TabIndex = 7
        '
        'Txt12Cost
        '
        Me.Txt12Cost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt12Cost.Location = New System.Drawing.Point(186, 40)
        Me.Txt12Cost.Multiline = True
        Me.Txt12Cost.Name = "Txt12Cost"
        Me.Txt12Cost.ReadOnly = True
        Me.Txt12Cost.Size = New System.Drawing.Size(120, 32)
        Me.Txt12Cost.TabIndex = 6
        '
        'TxtShip
        '
        Me.TxtShip.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtShip.Location = New System.Drawing.Point(186, 180)
        Me.TxtShip.Multiline = True
        Me.TxtShip.Name = "TxtShip"
        Me.TxtShip.Size = New System.Drawing.Size(120, 32)
        Me.TxtShip.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(98, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Shipping:"
        '
        'TxtCostTot
        '
        Me.TxtCostTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCostTot.Location = New System.Drawing.Point(186, 254)
        Me.TxtCostTot.Multiline = True
        Me.TxtCostTot.Name = "TxtCostTot"
        Me.TxtCostTot.ReadOnly = True
        Me.TxtCostTot.Size = New System.Drawing.Size(120, 32)
        Me.TxtCostTot.TabIndex = 15
        '
        'TxtPackTot
        '
        Me.TxtPackTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPackTot.Location = New System.Drawing.Point(102, 254)
        Me.TxtPackTot.Multiline = True
        Me.TxtPackTot.Name = "TxtPackTot"
        Me.TxtPackTot.ReadOnly = True
        Me.TxtPackTot.Size = New System.Drawing.Size(78, 32)
        Me.TxtPackTot.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Totals:"
        '
        'BtnCalc
        '
        Me.BtnCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalc.Location = New System.Drawing.Point(66, 331)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(107, 37)
        Me.BtnCalc.TabIndex = 16
        Me.BtnCalc.Text = "Calculate"
        Me.BtnCalc.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(198, 331)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(107, 37)
        Me.BtnExit.TabIndex = 17
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Toys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 391)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnCalc)
        Me.Controls.Add(Me.TxtCostTot)
        Me.Controls.Add(Me.TxtPackTot)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtShip)
        Me.Controls.Add(Me.Txt2Cost)
        Me.Controls.Add(Me.Txt5Cost)
        Me.Controls.Add(Me.Txt12Cost)
        Me.Controls.Add(Me.Txt2)
        Me.Controls.Add(Me.Txt5)
        Me.Controls.Add(Me.Txt12)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Toys"
        Me.Text = "Chopkins Toys - Arlo Russell"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt12 As TextBox
    Friend WithEvents Txt5 As TextBox
    Friend WithEvents Txt2 As TextBox
    Friend WithEvents Txt2Cost As TextBox
    Friend WithEvents Txt5Cost As TextBox
    Friend WithEvents Txt12Cost As TextBox
    Friend WithEvents TxtShip As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCostTot As TextBox
    Friend WithEvents TxtPackTot As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnCalc As Button
    Friend WithEvents BtnExit As Button
End Class
