<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        tbuser = New TextBox()
        tbpass = New TextBox()
        btnlogin2 = New Guna.UI2.WinForms.Guna2Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.icons8_restaurant_96
        PictureBox1.Location = New Point(131, 119)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(96, 100)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(119, 280)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 20)
        Label1.TabIndex = 2
        Label1.Text = "User Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(119, 348)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' tbuser
        ' 
        tbuser.Location = New Point(119, 303)
        tbuser.Name = "tbuser"
        tbuser.Size = New Size(125, 27)
        tbuser.TabIndex = 4
        ' 
        ' tbpass
        ' 
        tbpass.Location = New Point(119, 371)
        tbpass.Name = "tbpass"
        tbpass.PasswordChar = "*"c
        tbpass.Size = New Size(125, 27)
        tbpass.TabIndex = 5
        ' 
        ' btnlogin2
        ' 
        btnlogin2.AutoRoundedCorners = True
        btnlogin2.BorderRadius = 20
        btnlogin2.CustomizableEdges = CustomizableEdges1
        btnlogin2.DisabledState.BorderColor = Color.DarkGray
        btnlogin2.DisabledState.CustomBorderColor = Color.DarkGray
        btnlogin2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnlogin2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnlogin2.FillColor = SystemColors.Control
        btnlogin2.Font = New Font("Segoe UI", 9F)
        btnlogin2.ForeColor = Color.Black
        btnlogin2.Location = New Point(96, 437)
        btnlogin2.Name = "btnlogin2"
        btnlogin2.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnlogin2.Size = New Size(173, 43)
        btnlogin2.TabIndex = 6
        btnlogin2.Text = "Login"
        ' 
        ' form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LawnGreen
        ClientSize = New Size(350, 550)
        Controls.Add(btnlogin2)
        Controls.Add(tbpass)
        Controls.Add(tbuser)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbuser As TextBox
    Friend WithEvents tbpass As TextBox
    Friend WithEvents btnlogin2 As Guna.UI2.WinForms.Guna2Button
End Class
