Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports libzkfpcsharp
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.IO
Imports Sample
Namespace zk4500
    Partial Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.prompt = New System.Windows.Forms.Label()
            Me.fpicture = New System.Windows.Forms.PictureBox()
            Me.deviceSerial = New System.Windows.Forms.Label()
            Me.txtTemplate = New System.Windows.Forms.TextBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.btnregistrpf = New System.Windows.Forms.Button()
            Me.btnVerifyfp = New System.Windows.Forms.Button()
            Me.btnclearfp = New System.Windows.Forms.Button()
            CType(Me.fpicture, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'prompt
            '
            Me.prompt.AutoSize = True
            Me.prompt.Location = New System.Drawing.Point(139, 352)
            Me.prompt.Name = "prompt"
            Me.prompt.Size = New System.Drawing.Size(50, 13)
            Me.prompt.TabIndex = 3
            Me.prompt.Text = "Ready ..."
            '
            'fpicture
            '
            Me.fpicture.BackColor = System.Drawing.SystemColors.Window
            Me.fpicture.Location = New System.Drawing.Point(142, 56)
            Me.fpicture.Name = "fpicture"
            Me.fpicture.Size = New System.Drawing.Size(268, 283)
            Me.fpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
            Me.fpicture.TabIndex = 21
            Me.fpicture.TabStop = False
            '
            'deviceSerial
            '
            Me.deviceSerial.AutoSize = True
            Me.deviceSerial.Location = New System.Drawing.Point(465, 176)
            Me.deviceSerial.Name = "deviceSerial"
            Me.deviceSerial.Size = New System.Drawing.Size(76, 13)
            Me.deviceSerial.TabIndex = 3
            Me.deviceSerial.Text = "Device Serial: "
            '
            'txtTemplate
            '
            Me.txtTemplate.Location = New System.Drawing.Point(468, 214)
            Me.txtTemplate.Multiline = True
            Me.txtTemplate.Name = "txtTemplate"
            Me.txtTemplate.Size = New System.Drawing.Size(424, 82)
            Me.txtTemplate.TabIndex = 23
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(465, 198)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(57, 13)
            Me.label1.TabIndex = 3
            Me.label1.Text = "Template: "
            '
            'btnregistrpf
            '
            Me.btnregistrpf.Location = New System.Drawing.Point(444, 20)
            Me.btnregistrpf.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.btnregistrpf.Name = "btnregistrpf"
            Me.btnregistrpf.Size = New System.Drawing.Size(91, 43)
            Me.btnregistrpf.TabIndex = 24
            Me.btnregistrpf.Text = "&Register"
            Me.btnregistrpf.UseVisualStyleBackColor = True
            '
            'btnVerifyfp
            '
            Me.btnVerifyfp.Location = New System.Drawing.Point(566, 20)
            Me.btnVerifyfp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.btnVerifyfp.Name = "btnVerifyfp"
            Me.btnVerifyfp.Size = New System.Drawing.Size(95, 48)
            Me.btnVerifyfp.TabIndex = 25
            Me.btnVerifyfp.Text = "&Verify"
            Me.btnVerifyfp.UseVisualStyleBackColor = True
            '
            'btnclearfp
            '
            Me.btnclearfp.Location = New System.Drawing.Point(444, 319)
            Me.btnclearfp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.btnclearfp.Name = "btnclearfp"
            Me.btnclearfp.Size = New System.Drawing.Size(86, 20)
            Me.btnclearfp.TabIndex = 26
            Me.btnclearfp.Text = "&Clear"
            Me.btnclearfp.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(936, 415)
            Me.Controls.Add(Me.btnclearfp)
            Me.Controls.Add(Me.btnVerifyfp)
            Me.Controls.Add(Me.btnregistrpf)
            Me.Controls.Add(Me.txtTemplate)
            Me.Controls.Add(Me.fpicture)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.deviceSerial)
            Me.Controls.Add(Me.prompt)
            Me.Name = "Form1"
            Me.Text = "ZK4500"
            CType(Me.fpicture, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region
        Private prompt As Windows.Forms.Label
        Private fpicture As Windows.Forms.PictureBox
        Private deviceSerial As Windows.Forms.Label
        Private txtTemplate As Windows.Forms.TextBox
        Private label1 As Windows.Forms.Label
        Friend WithEvents btnregistrpf As Button
        Friend WithEvents btnVerifyfp As Button
        Friend WithEvents btnclearfp As Button
    End Class
End Namespace
