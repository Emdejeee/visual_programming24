<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pilihan
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        btnadmin = New Guna.UI2.WinForms.Guna2Button()
        btnmenu = New Guna.UI2.WinForms.Guna2Button()
        btnlogout = New Guna.UI2.WinForms.Guna2Button()
        btnexit = New Guna.UI2.WinForms.Guna2Button()
        btncustomer = New Guna.UI2.WinForms.Guna2Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.icons8_restaurant_96
        PictureBox1.Location = New Point(123, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(96, 100)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calisto MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(70, 147)
        Label1.Name = "Label1"
        Label1.Size = New Size(190, 26)
        Label1.TabIndex = 3
        Label1.Text = "Selamat Datang !"
        ' 
        ' btnadmin
        ' 
        btnadmin.AutoRoundedCorners = True
        btnadmin.BackColor = Color.LawnGreen
        btnadmin.BorderRadius = 20
        btnadmin.CustomizableEdges = CustomizableEdges1
        btnadmin.DisabledState.BorderColor = Color.DarkGray
        btnadmin.DisabledState.CustomBorderColor = Color.DarkGray
        btnadmin.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnadmin.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnadmin.FillColor = Color.LightYellow
        btnadmin.Font = New Font("Segoe UI", 9F)
        btnadmin.ForeColor = Color.Black
        btnadmin.Location = New Point(56, 249)
        btnadmin.Name = "btnadmin"
        btnadmin.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnadmin.Size = New Size(218, 42)
        btnadmin.TabIndex = 4
        btnadmin.Text = "Masuk Admin"
        ' 
        ' btnmenu
        ' 
        btnmenu.AutoRoundedCorners = True
        btnmenu.BackColor = Color.LawnGreen
        btnmenu.BorderRadius = 20
        btnmenu.CustomizableEdges = CustomizableEdges3
        btnmenu.DisabledState.BorderColor = Color.DarkGray
        btnmenu.DisabledState.CustomBorderColor = Color.DarkGray
        btnmenu.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnmenu.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnmenu.FillColor = Color.LightYellow
        btnmenu.Font = New Font("Segoe UI", 9F)
        btnmenu.ForeColor = Color.Black
        btnmenu.Location = New Point(56, 294)
        btnmenu.Name = "btnmenu"
        btnmenu.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnmenu.Size = New Size(218, 42)
        btnmenu.TabIndex = 5
        btnmenu.Text = "Masuk Menu"
        ' 
        ' btnlogout
        ' 
        btnlogout.AutoRoundedCorners = True
        btnlogout.BackColor = Color.LawnGreen
        btnlogout.BorderRadius = 20
        btnlogout.CustomizableEdges = CustomizableEdges5
        btnlogout.DisabledState.BorderColor = Color.DarkGray
        btnlogout.DisabledState.CustomBorderColor = Color.DarkGray
        btnlogout.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnlogout.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnlogout.FillColor = Color.LightYellow
        btnlogout.Font = New Font("Segoe UI", 9F)
        btnlogout.ForeColor = Color.Black
        btnlogout.Location = New Point(56, 384)
        btnlogout.Name = "btnlogout"
        btnlogout.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnlogout.Size = New Size(218, 42)
        btnlogout.TabIndex = 6
        btnlogout.Text = "Log Out"
        ' 
        ' btnexit
        ' 
        btnexit.AutoRoundedCorners = True
        btnexit.BackColor = Color.LawnGreen
        btnexit.BorderRadius = 20
        btnexit.CustomizableEdges = CustomizableEdges7
        btnexit.DisabledState.BorderColor = Color.DarkGray
        btnexit.DisabledState.CustomBorderColor = Color.DarkGray
        btnexit.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnexit.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnexit.FillColor = Color.LightYellow
        btnexit.Font = New Font("Segoe UI", 9F)
        btnexit.ForeColor = Color.Black
        btnexit.Location = New Point(56, 429)
        btnexit.Name = "btnexit"
        btnexit.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnexit.Size = New Size(218, 42)
        btnexit.TabIndex = 7
        btnexit.Text = "Exit"
        ' 
        ' btncustomer
        ' 
        btncustomer.AutoRoundedCorners = True
        btncustomer.BackColor = Color.LawnGreen
        btncustomer.BorderRadius = 20
        btncustomer.CustomizableEdges = CustomizableEdges9
        btncustomer.DisabledState.BorderColor = Color.DarkGray
        btncustomer.DisabledState.CustomBorderColor = Color.DarkGray
        btncustomer.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btncustomer.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btncustomer.FillColor = Color.LightYellow
        btncustomer.Font = New Font("Segoe UI", 9F)
        btncustomer.ForeColor = Color.Black
        btncustomer.Location = New Point(56, 339)
        btncustomer.Name = "btncustomer"
        btncustomer.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btncustomer.Size = New Size(218, 42)
        btncustomer.TabIndex = 8
        btncustomer.Text = "Pesan Customer"
        ' 
        ' pilihan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LawnGreen
        ClientSize = New Size(332, 533)
        Controls.Add(btncustomer)
        Controls.Add(btnexit)
        Controls.Add(btnlogout)
        Controls.Add(btnmenu)
        Controls.Add(btnadmin)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "pilihan"
        StartPosition = FormStartPosition.CenterScreen
        Text = "pilihan"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnadmin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnmenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnlogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnexit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btncustomer As Guna.UI2.WinForms.Guna2Button
End Class
