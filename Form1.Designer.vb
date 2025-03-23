<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        BindingSource1 = New BindingSource(components)
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        btnlogin1 = New Guna.UI2.WinForms.Guna2Button()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.icons8_restaurant_96
        PictureBox1.Location = New Point(132, 163)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(96, 100)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(56, 276)
        Label2.Name = "Label2"
        Label2.Size = New Size(250, 23)
        Label2.TabIndex = 2
        Label2.Text = "Restaurant Management"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(132, 299)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 23)
        Label1.TabIndex = 3
        Label1.Text = "System"
        ' 
        ' btnlogin1
        ' 
        btnlogin1.AutoRoundedCorners = True
        btnlogin1.BorderRadius = 20
        btnlogin1.CustomizableEdges = CustomizableEdges1
        btnlogin1.DisabledState.BorderColor = Color.DarkGray
        btnlogin1.DisabledState.CustomBorderColor = Color.DarkGray
        btnlogin1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnlogin1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnlogin1.FillColor = SystemColors.Control
        btnlogin1.Font = New Font("Segoe UI", 9F)
        btnlogin1.ForeColor = Color.Black
        btnlogin1.Location = New Point(90, 429)
        btnlogin1.Name = "btnlogin1"
        btnlogin1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnlogin1.Size = New Size(173, 43)
        btnlogin1.TabIndex = 4
        btnlogin1.Text = "Login"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LawnGreen
        ClientSize = New Size(350, 580)
        Controls.Add(btnlogin1)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "login"
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnlogin1 As Guna.UI2.WinForms.Guna2Button

End Class
