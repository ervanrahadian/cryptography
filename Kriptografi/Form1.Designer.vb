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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Enkripsi = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Dekripsi = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Enkripsi.SuspendLayout()
        Me.Dekripsi.SuspendLayout()
        Me.SuspendLayout()
        '
        'Enkripsi
        '
        Me.Enkripsi.BackColor = System.Drawing.Color.Transparent
        Me.Enkripsi.Controls.Add(Me.Button1)
        Me.Enkripsi.Controls.Add(Me.TextBox2)
        Me.Enkripsi.Controls.Add(Me.TextBox1)
        Me.Enkripsi.Controls.Add(Me.Label3)
        Me.Enkripsi.Controls.Add(Me.Label2)
        Me.Enkripsi.Font = New System.Drawing.Font("Algerian", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Enkripsi.ForeColor = System.Drawing.Color.Silver
        Me.Enkripsi.Location = New System.Drawing.Point(12, 140)
        Me.Enkripsi.Name = "Enkripsi"
        Me.Enkripsi.Size = New System.Drawing.Size(758, 226)
        Me.Enkripsi.TabIndex = 0
        Me.Enkripsi.TabStop = False
        Me.Enkripsi.Text = "Enkripsi"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(311, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 48)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Enkrip"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(172, 109)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(560, 34)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(172, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(560, 34)
        Me.TextBox1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 26)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Output"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Input"
        '
        'Dekripsi
        '
        Me.Dekripsi.BackColor = System.Drawing.Color.Transparent
        Me.Dekripsi.Controls.Add(Me.Button2)
        Me.Dekripsi.Controls.Add(Me.TextBox4)
        Me.Dekripsi.Controls.Add(Me.TextBox3)
        Me.Dekripsi.Controls.Add(Me.Label4)
        Me.Dekripsi.Controls.Add(Me.Label5)
        Me.Dekripsi.Font = New System.Drawing.Font("Algerian", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dekripsi.ForeColor = System.Drawing.Color.Silver
        Me.Dekripsi.Location = New System.Drawing.Point(12, 388)
        Me.Dekripsi.Name = "Dekripsi"
        Me.Dekripsi.Size = New System.Drawing.Size(758, 226)
        Me.Dekripsi.TabIndex = 1
        Me.Dekripsi.TabStop = False
        Me.Dekripsi.Text = "Dekripsi"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(311, 172)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 48)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Dekrip"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(172, 111)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(560, 34)
        Me.TextBox4.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(172, 56)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(560, 34)
        Me.TextBox3.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 26)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Output"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(42, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 26)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Input"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Algerian", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(113, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(407, 66)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Kriptografi"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(621, 638)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 48)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Reset"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(621, 86)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(149, 48)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Keluar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(8, 666)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(417, 23)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Copyright © 2019 - Ervan Rahadian Hakim"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Algerian", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Silver
        Me.Label7.Location = New System.Drawing.Point(526, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 26)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "With ASCII"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(782, 698)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Dekripsi)
        Me.Controls.Add(Me.Enkripsi)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 745)
        Me.MinimumSize = New System.Drawing.Size(800, 745)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kriptografi"
        Me.Enkripsi.ResumeLayout(False)
        Me.Enkripsi.PerformLayout()
        Me.Dekripsi.ResumeLayout(False)
        Me.Dekripsi.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Enkripsi As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Dekripsi As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
