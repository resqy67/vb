﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form21
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtKodeBrg = New System.Windows.Forms.TextBox()
        Me.TxtNamaBrg = New System.Windows.Forms.TextBox()
        Me.TxtSatuan = New System.Windows.Forms.TextBox()
        Me.TxtHrgSatuan = New System.Windows.Forms.TextBox()
        Me.TxtHarga = New System.Windows.Forms.TextBox()
        Me.TxtTot = New System.Windows.Forms.TextBox()
        Me.BtnHitung = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Barang "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Satuan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jumlah"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 317)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total Harga"
        '
        'TxtKodeBrg
        '
        Me.TxtKodeBrg.Location = New System.Drawing.Point(110, 63)
        Me.TxtKodeBrg.Name = "TxtKodeBrg"
        Me.TxtKodeBrg.Size = New System.Drawing.Size(100, 20)
        Me.TxtKodeBrg.TabIndex = 6
        '
        'TxtNamaBrg
        '
        Me.TxtNamaBrg.Location = New System.Drawing.Point(110, 108)
        Me.TxtNamaBrg.Name = "TxtNamaBrg"
        Me.TxtNamaBrg.Size = New System.Drawing.Size(171, 20)
        Me.TxtNamaBrg.TabIndex = 7
        '
        'TxtSatuan
        '
        Me.TxtSatuan.Location = New System.Drawing.Point(110, 152)
        Me.TxtSatuan.Name = "TxtSatuan"
        Me.TxtSatuan.Size = New System.Drawing.Size(100, 20)
        Me.TxtSatuan.TabIndex = 8
        '
        'TxtHrgSatuan
        '
        Me.TxtHrgSatuan.Location = New System.Drawing.Point(110, 204)
        Me.TxtHrgSatuan.Name = "TxtHrgSatuan"
        Me.TxtHrgSatuan.Size = New System.Drawing.Size(100, 20)
        Me.TxtHrgSatuan.TabIndex = 9
        '
        'TxtHarga
        '
        Me.TxtHarga.Location = New System.Drawing.Point(110, 260)
        Me.TxtHarga.Name = "TxtHarga"
        Me.TxtHarga.Size = New System.Drawing.Size(100, 20)
        Me.TxtHarga.TabIndex = 10
        '
        'TxtTot
        '
        Me.TxtTot.Location = New System.Drawing.Point(110, 310)
        Me.TxtTot.Name = "TxtTot"
        Me.TxtTot.Size = New System.Drawing.Size(100, 20)
        Me.TxtTot.TabIndex = 11
        '
        'BtnHitung
        '
        Me.BtnHitung.Location = New System.Drawing.Point(29, 361)
        Me.BtnHitung.Name = "BtnHitung"
        Me.BtnHitung.Size = New System.Drawing.Size(75, 23)
        Me.BtnHitung.TabIndex = 12
        Me.BtnHitung.Text = "Hitung"
        Me.BtnHitung.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(110, 361)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 23)
        Me.BtnClear.TabIndex = 13
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(223, 361)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 14
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Form21
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 450)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnHitung)
        Me.Controls.Add(Me.TxtTot)
        Me.Controls.Add(Me.TxtHarga)
        Me.Controls.Add(Me.TxtHrgSatuan)
        Me.Controls.Add(Me.TxtSatuan)
        Me.Controls.Add(Me.TxtNamaBrg)
        Me.Controls.Add(Me.TxtKodeBrg)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form21"
        Me.Text = "Barang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtKodeBrg As TextBox
    Friend WithEvents TxtNamaBrg As TextBox
    Friend WithEvents TxtSatuan As TextBox
    Friend WithEvents TxtHrgSatuan As TextBox
    Friend WithEvents TxtHarga As TextBox
    Friend WithEvents TxtTot As TextBox
    Friend WithEvents BtnHitung As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnExit As Button
End Class
