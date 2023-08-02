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
        MenuStrip1 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        BukaFileToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripSeparator()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        ProssesToolStripMenuItem = New ToolStripMenuItem()
        KonfersiWarnaToolStripMenuItem = New ToolStripMenuItem()
        BlueToolStripMenuItem = New ToolStripMenuItem()
        GrayToolStripMenuItem = New ToolStripMenuItem()
        GreenToolStripMenuItem = New ToolStripMenuItem()
        NegativeToolStripMenuItem = New ToolStripMenuItem()
        RedToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripSeparator()
        PenajamanToolStripMenuItem = New ToolStripMenuItem()
        PenajamanToolStripMenuItem1 = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        PictureBox2 = New PictureBox()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        StatusStrip1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, ProssesToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1455, 33)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {BukaFileToolStripMenuItem, ToolStripMenuItem2, KeluarToolStripMenuItem})
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(54, 29)
        ToolStripMenuItem1.Text = "File"
        ' 
        ' BukaFileToolStripMenuItem
        ' 
        BukaFileToolStripMenuItem.Name = "BukaFileToolStripMenuItem"
        BukaFileToolStripMenuItem.Size = New Size(270, 34)
        BukaFileToolStripMenuItem.Text = "Buka File"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(267, 6)
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(270, 34)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' ProssesToolStripMenuItem
        ' 
        ProssesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {KonfersiWarnaToolStripMenuItem, ToolStripMenuItem3, PenajamanToolStripMenuItem})
        ProssesToolStripMenuItem.Name = "ProssesToolStripMenuItem"
        ProssesToolStripMenuItem.Size = New Size(88, 29)
        ProssesToolStripMenuItem.Text = "Prosses"
        ' 
        ' KonfersiWarnaToolStripMenuItem
        ' 
        KonfersiWarnaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BlueToolStripMenuItem, GrayToolStripMenuItem, GreenToolStripMenuItem, NegativeToolStripMenuItem, RedToolStripMenuItem})
        KonfersiWarnaToolStripMenuItem.Name = "KonfersiWarnaToolStripMenuItem"
        KonfersiWarnaToolStripMenuItem.Size = New Size(270, 34)
        KonfersiWarnaToolStripMenuItem.Text = "Citra Warna"
        ' 
        ' BlueToolStripMenuItem
        ' 
        BlueToolStripMenuItem.Name = "BlueToolStripMenuItem"
        BlueToolStripMenuItem.Size = New Size(184, 34)
        BlueToolStripMenuItem.Text = "Combine"
        ' 
        ' GrayToolStripMenuItem
        ' 
        GrayToolStripMenuItem.Name = "GrayToolStripMenuItem"
        GrayToolStripMenuItem.Size = New Size(184, 34)
        GrayToolStripMenuItem.Text = "Gray"
        ' 
        ' GreenToolStripMenuItem
        ' 
        GreenToolStripMenuItem.Name = "GreenToolStripMenuItem"
        GreenToolStripMenuItem.Size = New Size(184, 34)
        GreenToolStripMenuItem.Text = "Green"
        ' 
        ' NegativeToolStripMenuItem
        ' 
        NegativeToolStripMenuItem.Name = "NegativeToolStripMenuItem"
        NegativeToolStripMenuItem.Size = New Size(184, 34)
        NegativeToolStripMenuItem.Text = "Negative"
        ' 
        ' RedToolStripMenuItem
        ' 
        RedToolStripMenuItem.Name = "RedToolStripMenuItem"
        RedToolStripMenuItem.Size = New Size(184, 34)
        RedToolStripMenuItem.Text = "Red"
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(267, 6)
        ' 
        ' PenajamanToolStripMenuItem
        ' 
        PenajamanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PenajamanToolStripMenuItem1})
        PenajamanToolStripMenuItem.Name = "PenajamanToolStripMenuItem"
        PenajamanToolStripMenuItem.Size = New Size(270, 34)
        PenajamanToolStripMenuItem.Text = "Thresold"
        ' 
        ' PenajamanToolStripMenuItem1
        ' 
        PenajamanToolStripMenuItem1.Name = "PenajamanToolStripMenuItem1"
        PenajamanToolStripMenuItem1.Size = New Size(270, 34)
        PenajamanToolStripMenuItem1.Text = "Penajaman"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._424f66998934ce0a53309d59a4a77368
        PictureBox1.Location = New Point(12, 51)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(675, 510)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(24, 24)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1})
        StatusStrip1.Location = New Point(0, 621)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(1455, 32)
        StatusStrip1.TabIndex = 3
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(392, 25)
        ToolStripStatusLabel1.Text = "Alvin Christoper Sebayang TI20F (20200040143)"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources._424f66998934ce0a53309d59a4a77368
        PictureBox2.Location = New Point(752, 51)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(675, 510)
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1455, 653)
        Controls.Add(PictureBox2)
        Controls.Add(StatusStrip1)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Pengolahan Citra"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BukaFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProssesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KonfersiWarnaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GrayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NegativeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PenajamanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenajamanToolStripMenuItem1 As ToolStripMenuItem
End Class
