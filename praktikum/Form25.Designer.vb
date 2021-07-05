<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form25
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
        Me.BtnKoneksi = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnKoneksi
        '
        Me.BtnKoneksi.Location = New System.Drawing.Point(256, 297)
        Me.BtnKoneksi.Name = "BtnKoneksi"
        Me.BtnKoneksi.Size = New System.Drawing.Size(75, 23)
        Me.BtnKoneksi.TabIndex = 0
        Me.BtnKoneksi.Text = "Koneksi"
        Me.BtnKoneksi.UseVisualStyleBackColor = True
        '
        'Form25
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 450)
        Me.Controls.Add(Me.BtnKoneksi)
        Me.Name = "Form25"
        Me.Text = "Form25"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnKoneksi As Button
End Class
