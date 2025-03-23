<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Admin))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel1 = New Panel()
        cbdept = New ComboBox()
        Label9 = New Label()
        btnbersih = New Guna.UI2.WinForms.Guna2Button()
        btndel = New Guna.UI2.WinForms.Guna2Button()
        btnedit = New Guna.UI2.WinForms.Guna2Button()
        btnsimpan = New Guna.UI2.WinForms.Guna2Button()
        cbjk = New ComboBox()
        tbalamat = New TextBox()
        tbnohp = New TextBox()
        tbnama = New TextBox()
        tbid = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Label7 = New Label()
        Panel2 = New Panel()
        btnprint = New Guna.UI2.WinForms.Guna2Button()
        btncari = New Guna.UI2.WinForms.Guna2Button()
        tbcari = New TextBox()
        Label8 = New Label()
        btnkembali = New Guna.UI2.WinForms.Guna2Button()
        SaveFileDialog1 = New SaveFileDialog()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.AntiqueWhite
        Panel1.Controls.Add(cbdept)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(btnbersih)
        Panel1.Controls.Add(btndel)
        Panel1.Controls.Add(btnedit)
        Panel1.Controls.Add(btnsimpan)
        Panel1.Controls.Add(cbjk)
        Panel1.Controls.Add(tbalamat)
        Panel1.Controls.Add(tbnohp)
        Panel1.Controls.Add(tbnama)
        Panel1.Controls.Add(tbid)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(31, 34)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(376, 522)
        Panel1.TabIndex = 0
        ' 
        ' cbdept
        ' 
        cbdept.FormattingEnabled = True
        cbdept.Items.AddRange(New Object() {"Restaurant Manager", "Kitchen", "Administrative", "Cleaning and Maintenace", "Customer Relations"})
        cbdept.Location = New Point(176, 250)
        cbdept.Name = "cbdept"
        cbdept.Size = New Size(145, 28)
        cbdept.TabIndex = 17
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(24, 250)
        Label9.Name = "Label9"
        Label9.Size = New Size(85, 18)
        Label9.TabIndex = 16
        Label9.Text = "Department"
        ' 
        ' btnbersih
        ' 
        btnbersih.AutoRoundedCorners = True
        btnbersih.BorderRadius = 18
        btnbersih.CustomizableEdges = CustomizableEdges1
        btnbersih.DisabledState.BorderColor = Color.DarkGray
        btnbersih.DisabledState.CustomBorderColor = Color.DarkGray
        btnbersih.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnbersih.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnbersih.FillColor = Color.LawnGreen
        btnbersih.Font = New Font("Segoe UI", 9F)
        btnbersih.ForeColor = Color.Black
        btnbersih.Image = CType(resources.GetObject("btnbersih.Image"), Image)
        btnbersih.Location = New Point(138, 456)
        btnbersih.Name = "btnbersih"
        btnbersih.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnbersih.Size = New Size(98, 38)
        btnbersih.TabIndex = 15
        ' 
        ' btndel
        ' 
        btndel.AutoRoundedCorners = True
        btndel.BorderRadius = 18
        btndel.CustomizableEdges = CustomizableEdges3
        btndel.DisabledState.BorderColor = Color.DarkGray
        btndel.DisabledState.CustomBorderColor = Color.DarkGray
        btndel.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btndel.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btndel.FillColor = Color.Red
        btndel.Font = New Font("Segoe UI", 9F)
        btndel.ForeColor = Color.Black
        btndel.Image = CType(resources.GetObject("btndel.Image"), Image)
        btndel.Location = New Point(254, 401)
        btndel.Name = "btndel"
        btndel.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btndel.Size = New Size(98, 38)
        btndel.TabIndex = 14
        ' 
        ' btnedit
        ' 
        btnedit.AutoRoundedCorners = True
        btnedit.BorderRadius = 18
        btnedit.CustomizableEdges = CustomizableEdges5
        btnedit.DisabledState.BorderColor = Color.DarkGray
        btnedit.DisabledState.CustomBorderColor = Color.DarkGray
        btnedit.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnedit.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnedit.FillColor = Color.Yellow
        btnedit.Font = New Font("Segoe UI", 9F)
        btnedit.ForeColor = Color.Black
        btnedit.Image = CType(resources.GetObject("btnedit.Image"), Image)
        btnedit.Location = New Point(139, 401)
        btnedit.Name = "btnedit"
        btnedit.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnedit.Size = New Size(98, 38)
        btnedit.TabIndex = 13
        ' 
        ' btnsimpan
        ' 
        btnsimpan.AutoRoundedCorners = True
        btnsimpan.BorderRadius = 18
        btnsimpan.CustomizableEdges = CustomizableEdges7
        btnsimpan.DisabledState.BorderColor = Color.DarkGray
        btnsimpan.DisabledState.CustomBorderColor = Color.DarkGray
        btnsimpan.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnsimpan.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnsimpan.FillColor = SystemColors.MenuHighlight
        btnsimpan.Font = New Font("Segoe UI", 9F)
        btnsimpan.ForeColor = Color.Black
        btnsimpan.Image = CType(resources.GetObject("btnsimpan.Image"), Image)
        btnsimpan.Location = New Point(24, 401)
        btnsimpan.Name = "btnsimpan"
        btnsimpan.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnsimpan.Size = New Size(98, 38)
        btnsimpan.TabIndex = 12
        ' 
        ' cbjk
        ' 
        cbjk.FormattingEnabled = True
        cbjk.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        cbjk.Location = New Point(176, 204)
        cbjk.Name = "cbjk"
        cbjk.Size = New Size(145, 28)
        cbjk.TabIndex = 11
        ' 
        ' tbalamat
        ' 
        tbalamat.Location = New Point(176, 345)
        tbalamat.Name = "tbalamat"
        tbalamat.Size = New Size(145, 27)
        tbalamat.TabIndex = 10
        ' 
        ' tbnohp
        ' 
        tbnohp.Location = New Point(176, 294)
        tbnohp.Name = "tbnohp"
        tbnohp.Size = New Size(145, 27)
        tbnohp.TabIndex = 9
        ' 
        ' tbnama
        ' 
        tbnama.Location = New Point(176, 158)
        tbnama.Name = "tbnama"
        tbnama.Size = New Size(145, 27)
        tbnama.TabIndex = 7
        ' 
        ' tbid
        ' 
        tbid.Location = New Point(176, 108)
        tbid.Name = "tbid"
        tbid.Size = New Size(145, 27)
        tbid.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(24, 342)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 18)
        Label6.TabIndex = 5
        Label6.Text = "Alamat"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(24, 296)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 18)
        Label5.TabIndex = 4
        Label5.Text = "No Handphone"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(24, 204)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 18)
        Label4.TabIndex = 3
        Label4.Text = "Jenis Kelamin"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(24, 158)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 18)
        Label3.TabIndex = 2
        Label3.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(24, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 18)
        Label2.TabIndex = 1
        Label2.Text = "ID Karyawan"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(139, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 25)
        Label1.TabIndex = 0
        Label1.Text = "Karyawan"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(23, 102)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(593, 366)
        DataGridView1.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(247, 18)
        Label7.Name = "Label7"
        Label7.Size = New Size(161, 25)
        Label7.TabIndex = 16
        Label7.Text = "View Karyawan"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.AntiqueWhite
        Panel2.Controls.Add(btnprint)
        Panel2.Controls.Add(btncari)
        Panel2.Controls.Add(tbcari)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(DataGridView1)
        Panel2.Location = New Point(455, 34)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(638, 522)
        Panel2.TabIndex = 1
        ' 
        ' btnprint
        ' 
        btnprint.AutoRoundedCorners = True
        btnprint.BorderRadius = 18
        btnprint.CustomizableEdges = CustomizableEdges9
        btnprint.DisabledState.BorderColor = Color.DarkGray
        btnprint.DisabledState.CustomBorderColor = Color.DarkGray
        btnprint.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnprint.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnprint.FillColor = Color.DarkSlateGray
        btnprint.Font = New Font("Segoe UI", 9F)
        btnprint.ForeColor = Color.Black
        btnprint.Image = CType(resources.GetObject("btnprint.Image"), Image)
        btnprint.Location = New Point(222, 474)
        btnprint.Name = "btnprint"
        btnprint.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btnprint.Size = New Size(209, 38)
        btnprint.TabIndex = 16
        ' 
        ' btncari
        ' 
        btncari.AutoRoundedCorners = True
        btncari.BorderRadius = 18
        btncari.CustomizableEdges = CustomizableEdges11
        btncari.DisabledState.BorderColor = Color.DarkGray
        btncari.DisabledState.CustomBorderColor = Color.DarkGray
        btncari.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btncari.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btncari.FillColor = Color.DarkGray
        btncari.Font = New Font("Segoe UI", 9F)
        btncari.ForeColor = Color.Black
        btncari.Image = CType(resources.GetObject("btncari.Image"), Image)
        btncari.Location = New Point(437, 54)
        btncari.Name = "btncari"
        btncari.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        btncari.Size = New Size(98, 38)
        btncari.TabIndex = 16
        ' 
        ' tbcari
        ' 
        tbcari.Location = New Point(251, 61)
        tbcari.Name = "tbcari"
        tbcari.Size = New Size(161, 27)
        tbcari.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(96, 64)
        Label8.Name = "Label8"
        Label8.Size = New Size(131, 20)
        Label8.TabIndex = 16
        Label8.Text = "Cari Karyawan"
        ' 
        ' btnkembali
        ' 
        btnkembali.AutoRoundedCorners = True
        btnkembali.BorderRadius = 18
        btnkembali.CustomizableEdges = CustomizableEdges13
        btnkembali.DisabledState.BorderColor = Color.DarkGray
        btnkembali.DisabledState.CustomBorderColor = Color.DarkGray
        btnkembali.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnkembali.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnkembali.FillColor = Color.Transparent
        btnkembali.Font = New Font("Segoe UI", 9F)
        btnkembali.ForeColor = Color.Black
        btnkembali.Image = CType(resources.GetObject("btnkembali.Image"), Image)
        btnkembali.Location = New Point(995, 562)
        btnkembali.Name = "btnkembali"
        btnkembali.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        btnkembali.Size = New Size(98, 38)
        btnkembali.TabIndex = 17
        ' 
        ' Menu_Admin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LawnGreen
        ClientSize = New Size(1113, 613)
        Controls.Add(btnkembali)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Menu_Admin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Menu_Admin"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbjk As ComboBox
    Friend WithEvents tbalamat As TextBox
    Friend WithEvents tbnohp As TextBox
    Friend WithEvents tbnama As TextBox
    Friend WithEvents tbid As TextBox
    Friend WithEvents btnsimpan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnedit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btndel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnbersih As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents btncari As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbcari As TextBox
    Friend WithEvents btnkembali As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnprint As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label9 As Label
    Friend WithEvents cbdept As ComboBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
