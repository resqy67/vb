﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form17
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
        Me.TxtAngka = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Angka"
        '
        'TxtAngka
        '
        Me.TxtAngka.Location = New System.Drawing.Point(149, 77)
        Me.TxtAngka.Name = "TxtAngka"
        Me.TxtAngka.Size = New System.Drawing.Size(100, 20)
        Me.TxtAngka.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(204, 126)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Proses"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form17
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 191)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtAngka)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form17"
        Me.Text = "Perulangan DO WHILE … LOOP "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtAngka As TextBox
    Friend WithEvents Button1 As Button
End Class
