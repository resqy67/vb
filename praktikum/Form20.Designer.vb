<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form20
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.BtnProses = New System.Windows.Forms.Button()
        Me.TxtNIM = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNAMA = New System.Windows.Forms.TextBox()
        Me.CmbKelamin = New System.Windows.Forms.ComboBox()
        Me.CmbProdi = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(31, 242)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(250, 153)
        Me.ListView1.TabIndex = 15
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'BtnProses
        '
        Me.BtnProses.Location = New System.Drawing.Point(186, 200)
        Me.BtnProses.Name = "BtnProses"
        Me.BtnProses.Size = New System.Drawing.Size(75, 23)
        Me.BtnProses.TabIndex = 14
        Me.BtnProses.Text = "Proses"
        Me.BtnProses.UseVisualStyleBackColor = True
        '
        'TxtNIM
        '
        Me.TxtNIM.Location = New System.Drawing.Point(112, 53)
        Me.TxtNIM.Name = "TxtNIM"
        Me.TxtNIM.Size = New System.Drawing.Size(100, 20)
        Me.TxtNIM.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Prodi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "NIM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Kelamin"
        '
        'TxtNAMA
        '
        Me.TxtNAMA.Location = New System.Drawing.Point(112, 87)
        Me.TxtNAMA.Name = "TxtNAMA"
        Me.TxtNAMA.Size = New System.Drawing.Size(100, 20)
        Me.TxtNAMA.TabIndex = 17
        '
        'CmbKelamin
        '
        Me.CmbKelamin.FormattingEnabled = True
        Me.CmbKelamin.Location = New System.Drawing.Point(112, 126)
        Me.CmbKelamin.Name = "CmbKelamin"
        Me.CmbKelamin.Size = New System.Drawing.Size(121, 21)
        Me.CmbKelamin.TabIndex = 18
        '
        'CmbProdi
        '
        Me.CmbProdi.FormattingEnabled = True
        Me.CmbProdi.Location = New System.Drawing.Point(112, 160)
        Me.CmbProdi.Name = "CmbProdi"
        Me.CmbProdi.Size = New System.Drawing.Size(121, 21)
        Me.CmbProdi.TabIndex = 19
        '
        'Form20
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 450)
        Me.Controls.Add(Me.CmbProdi)
        Me.Controls.Add(Me.CmbKelamin)
        Me.Controls.Add(Me.TxtNAMA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.BtnProses)
        Me.Controls.Add(Me.TxtNIM)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form20"
        Me.Text = "Array Multi Array"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents BtnProses As Button
    Friend WithEvents TxtNIM As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNAMA As TextBox
    Friend WithEvents CmbKelamin As ComboBox
    Friend WithEvents CmbProdi As ComboBox
End Class
