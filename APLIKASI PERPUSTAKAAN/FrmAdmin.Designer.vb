﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdmin
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(126, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FORM ADMIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(20, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Selamat datang,"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(101, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "[Nama Admin]"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Image = Global.APLIKASI_PERPUSTAKAAN.My.Resources.Resources.exit__1_
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(116, 199)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(209, 51)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "                 LOGOUT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Image = Global.APLIKASI_PERPUSTAKAAN.My.Resources.Resources.icons8_group_of_projects_64
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(116, 131)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(209, 51)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "                 MANAJEMEN DATA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(441, 319)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAdmin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
