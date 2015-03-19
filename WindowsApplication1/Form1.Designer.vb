<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PlikToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtwórzToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZapiszToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrzekształceniaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeometryczneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OdbicieWPionieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OdbicieWPoziomieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PunktoweToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NegacjaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OdcienieSzarościToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZmianaJasnosciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZmianaKontrastuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WyrównanieHostogramuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutomatycznyKontrastToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KontekstoweToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FiltrUsredniajacyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlikToolStripMenuItem, Me.PrzekształceniaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1083, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PlikToolStripMenuItem
        '
        Me.PlikToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OtwórzToolStripMenuItem, Me.ZapiszToolStripMenuItem})
        Me.PlikToolStripMenuItem.Name = "PlikToolStripMenuItem"
        Me.PlikToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.PlikToolStripMenuItem.Text = "Plik"
        '
        'OtwórzToolStripMenuItem
        '
        Me.OtwórzToolStripMenuItem.Name = "OtwórzToolStripMenuItem"
        Me.OtwórzToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OtwórzToolStripMenuItem.Text = "Otwórz"
        '
        'ZapiszToolStripMenuItem
        '
        Me.ZapiszToolStripMenuItem.Name = "ZapiszToolStripMenuItem"
        Me.ZapiszToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ZapiszToolStripMenuItem.Text = "Zapisz"
        '
        'PrzekształceniaToolStripMenuItem
        '
        Me.PrzekształceniaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeometryczneToolStripMenuItem, Me.PunktoweToolStripMenuItem, Me.KontekstoweToolStripMenuItem})
        Me.PrzekształceniaToolStripMenuItem.Name = "PrzekształceniaToolStripMenuItem"
        Me.PrzekształceniaToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.PrzekształceniaToolStripMenuItem.Text = "Przekształcenia"
        '
        'GeometryczneToolStripMenuItem
        '
        Me.GeometryczneToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OdbicieWPionieToolStripMenuItem, Me.OdbicieWPoziomieToolStripMenuItem})
        Me.GeometryczneToolStripMenuItem.Name = "GeometryczneToolStripMenuItem"
        Me.GeometryczneToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.GeometryczneToolStripMenuItem.Text = "Geometryczne"
        '
        'OdbicieWPionieToolStripMenuItem
        '
        Me.OdbicieWPionieToolStripMenuItem.Name = "OdbicieWPionieToolStripMenuItem"
        Me.OdbicieWPionieToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.OdbicieWPionieToolStripMenuItem.Text = "Odbicie w pionie"
        '
        'OdbicieWPoziomieToolStripMenuItem
        '
        Me.OdbicieWPoziomieToolStripMenuItem.Name = "OdbicieWPoziomieToolStripMenuItem"
        Me.OdbicieWPoziomieToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.OdbicieWPoziomieToolStripMenuItem.Text = "Odbicie w poziomie"
        '
        'PunktoweToolStripMenuItem
        '
        Me.PunktoweToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NegacjaToolStripMenuItem, Me.OdcienieSzarościToolStripMenuItem, Me.ZmianaJasnosciToolStripMenuItem, Me.ZmianaKontrastuToolStripMenuItem, Me.WyrównanieHostogramuToolStripMenuItem, Me.AutomatycznyKontrastToolStripMenuItem})
        Me.PunktoweToolStripMenuItem.Name = "PunktoweToolStripMenuItem"
        Me.PunktoweToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.PunktoweToolStripMenuItem.Text = "Punktowe"
        '
        'NegacjaToolStripMenuItem
        '
        Me.NegacjaToolStripMenuItem.Name = "NegacjaToolStripMenuItem"
        Me.NegacjaToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.NegacjaToolStripMenuItem.Text = "Negacja"
        '
        'OdcienieSzarościToolStripMenuItem
        '
        Me.OdcienieSzarościToolStripMenuItem.Name = "OdcienieSzarościToolStripMenuItem"
        Me.OdcienieSzarościToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.OdcienieSzarościToolStripMenuItem.Text = "Odcienie szarości"
        '
        'ZmianaJasnosciToolStripMenuItem
        '
        Me.ZmianaJasnosciToolStripMenuItem.Name = "ZmianaJasnosciToolStripMenuItem"
        Me.ZmianaJasnosciToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ZmianaJasnosciToolStripMenuItem.Text = "Zmiana jasnosci"
        '
        'ZmianaKontrastuToolStripMenuItem
        '
        Me.ZmianaKontrastuToolStripMenuItem.Name = "ZmianaKontrastuToolStripMenuItem"
        Me.ZmianaKontrastuToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ZmianaKontrastuToolStripMenuItem.Text = "Zmiana kontrastu"
        '
        'WyrównanieHostogramuToolStripMenuItem
        '
        Me.WyrównanieHostogramuToolStripMenuItem.Name = "WyrównanieHostogramuToolStripMenuItem"
        Me.WyrównanieHostogramuToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.WyrównanieHostogramuToolStripMenuItem.Text = "Wyrównanie histogramu"
        '
        'AutomatycznyKontrastToolStripMenuItem
        '
        Me.AutomatycznyKontrastToolStripMenuItem.Name = "AutomatycznyKontrastToolStripMenuItem"
        Me.AutomatycznyKontrastToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.AutomatycznyKontrastToolStripMenuItem.Text = "Automatyczny kontrast"
        '
        'KontekstoweToolStripMenuItem
        '
        Me.KontekstoweToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FiltrUsredniajacyToolStripMenuItem})
        Me.KontekstoweToolStripMenuItem.Name = "KontekstoweToolStripMenuItem"
        Me.KontekstoweToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.KontekstoweToolStripMenuItem.Text = "Kontekstowe"
        '
        'FiltrUsredniajacyToolStripMenuItem
        '
        Me.FiltrUsredniajacyToolStripMenuItem.Name = "FiltrUsredniajacyToolStripMenuItem"
        Me.FiltrUsredniajacyToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.FiltrUsredniajacyToolStripMenuItem.Text = "filtr usredniajacy"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.OldLace
        Me.PictureBox1.Location = New System.Drawing.Point(12, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 516)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 575)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(800, 18)
        Me.ProgressBar1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(826, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(245, 168)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(826, 403)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(245, 168)
        Me.Panel2.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(826, 229)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(245, 168)
        Me.Panel3.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(863, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "HISTOGRAMY dla kanałów R G B"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(975, 583)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "A.Knapik, J.Musiał"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1083, 605)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Ćwiczenie 1 - CPO"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PlikToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtwórzToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZapiszToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrzekształceniaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PunktoweToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeometryczneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents NegacjaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents OdcienieSzarościToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OdbicieWPionieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OdbicieWPoziomieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ZmianaJasnosciToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZmianaKontrastuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WyrównanieHostogramuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KontekstoweToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FiltrUsredniajacyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutomatycznyKontrastToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
