<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPenyimpanan
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
        Me.LblJdul = New System.Windows.Forms.Label()
        Me.LblMerek = New System.Windows.Forms.Label()
        Me.LblTipe = New System.Windows.Forms.Label()
        Me.LblDis = New System.Windows.Forms.Label()
        Me.LblJumlah = New System.Windows.Forms.Label()
        Me.TxtMerek = New System.Windows.Forms.TextBox()
        Me.TxtTipe = New System.Windows.Forms.TextBox()
        Me.TxtDis = New System.Windows.Forms.TextBox()
        Me.TxtJumlah = New System.Windows.Forms.TextBox()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.LblKode = New System.Windows.Forms.Label()
        Me.TxtKode = New System.Windows.Forms.TextBox()
        Me.DGVBarang = New System.Windows.Forms.DataGridView()
        CType(Me.DGVBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblJdul
        '
        Me.LblJdul.AutoSize = True
        Me.LblJdul.BackColor = System.Drawing.Color.Transparent
        Me.LblJdul.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJdul.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblJdul.Location = New System.Drawing.Point(353, 43)
        Me.LblJdul.Name = "LblJdul"
        Me.LblJdul.Size = New System.Drawing.Size(268, 29)
        Me.LblJdul.TabIndex = 0
        Me.LblJdul.Text = "Silahkan Simpan Data"
        '
        'LblMerek
        '
        Me.LblMerek.AutoSize = True
        Me.LblMerek.BackColor = System.Drawing.Color.Transparent
        Me.LblMerek.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblMerek.Location = New System.Drawing.Point(548, 163)
        Me.LblMerek.Name = "LblMerek"
        Me.LblMerek.Size = New System.Drawing.Size(70, 17)
        Me.LblMerek.TabIndex = 1
        Me.LblMerek.Text = "Merek HP"
        '
        'LblTipe
        '
        Me.LblTipe.AutoSize = True
        Me.LblTipe.BackColor = System.Drawing.Color.Transparent
        Me.LblTipe.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblTipe.Location = New System.Drawing.Point(548, 204)
        Me.LblTipe.Name = "LblTipe"
        Me.LblTipe.Size = New System.Drawing.Size(59, 17)
        Me.LblTipe.TabIndex = 2
        Me.LblTipe.Text = "Tipe HP"
        '
        'LblDis
        '
        Me.LblDis.AutoSize = True
        Me.LblDis.BackColor = System.Drawing.Color.Transparent
        Me.LblDis.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblDis.Location = New System.Drawing.Point(548, 247)
        Me.LblDis.Name = "LblDis"
        Me.LblDis.Size = New System.Drawing.Size(73, 17)
        Me.LblDis.TabIndex = 3
        Me.LblDis.Text = "Distributor"
        '
        'LblJumlah
        '
        Me.LblJumlah.AutoSize = True
        Me.LblJumlah.BackColor = System.Drawing.Color.Transparent
        Me.LblJumlah.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblJumlah.Location = New System.Drawing.Point(548, 285)
        Me.LblJumlah.Name = "LblJumlah"
        Me.LblJumlah.Size = New System.Drawing.Size(103, 17)
        Me.LblJumlah.TabIndex = 4
        Me.LblJumlah.Text = "Jumlah Barang"
        '
        'TxtMerek
        '
        Me.TxtMerek.Location = New System.Drawing.Point(688, 163)
        Me.TxtMerek.Name = "TxtMerek"
        Me.TxtMerek.Size = New System.Drawing.Size(201, 22)
        Me.TxtMerek.TabIndex = 2
        '
        'TxtTipe
        '
        Me.TxtTipe.Location = New System.Drawing.Point(688, 204)
        Me.TxtTipe.Name = "TxtTipe"
        Me.TxtTipe.Size = New System.Drawing.Size(201, 22)
        Me.TxtTipe.TabIndex = 3
        '
        'TxtDis
        '
        Me.TxtDis.Location = New System.Drawing.Point(688, 247)
        Me.TxtDis.Name = "TxtDis"
        Me.TxtDis.Size = New System.Drawing.Size(201, 22)
        Me.TxtDis.TabIndex = 4
        '
        'TxtJumlah
        '
        Me.TxtJumlah.Location = New System.Drawing.Point(688, 285)
        Me.TxtJumlah.Name = "TxtJumlah"
        Me.TxtJumlah.Size = New System.Drawing.Size(201, 22)
        Me.TxtJumlah.TabIndex = 5
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(552, 349)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(99, 30)
        Me.BtnSimpan.TabIndex = 6
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(675, 349)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(99, 30)
        Me.BtnUpdate.TabIndex = 7
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(800, 349)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(99, 30)
        Me.BtnHapus.TabIndex = 8
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(13, 13)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(40, 36)
        Me.BtnBack.TabIndex = 9
        Me.BtnBack.Text = "←"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'LblKode
        '
        Me.LblKode.AutoSize = True
        Me.LblKode.BackColor = System.Drawing.Color.Transparent
        Me.LblKode.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblKode.Location = New System.Drawing.Point(548, 125)
        Me.LblKode.Name = "LblKode"
        Me.LblKode.Size = New System.Drawing.Size(73, 17)
        Me.LblKode.TabIndex = 0
        Me.LblKode.Text = "Kode Unik"
        '
        'TxtKode
        '
        Me.TxtKode.Location = New System.Drawing.Point(688, 125)
        Me.TxtKode.Name = "TxtKode"
        Me.TxtKode.Size = New System.Drawing.Size(201, 22)
        Me.TxtKode.TabIndex = 1
        '
        'DGVBarang
        '
        Me.DGVBarang.AllowUserToAddRows = False
        Me.DGVBarang.AllowUserToDeleteRows = False
        Me.DGVBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVBarang.Location = New System.Drawing.Point(13, 109)
        Me.DGVBarang.Name = "DGVBarang"
        Me.DGVBarang.ReadOnly = True
        Me.DGVBarang.RowHeadersWidth = 51
        Me.DGVBarang.RowTemplate.Height = 24
        Me.DGVBarang.Size = New System.Drawing.Size(496, 317)
        Me.DGVBarang.TabIndex = 10
        '
        'FrmPenyimpanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.BackgroundImage = Global.TOKOHP.My.Resources.Resources.Abu_Tua
        Me.ClientSize = New System.Drawing.Size(936, 471)
        Me.Controls.Add(Me.DGVBarang)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.TxtJumlah)
        Me.Controls.Add(Me.TxtDis)
        Me.Controls.Add(Me.TxtTipe)
        Me.Controls.Add(Me.TxtKode)
        Me.Controls.Add(Me.TxtMerek)
        Me.Controls.Add(Me.LblJumlah)
        Me.Controls.Add(Me.LblDis)
        Me.Controls.Add(Me.LblKode)
        Me.Controls.Add(Me.LblTipe)
        Me.Controls.Add(Me.LblMerek)
        Me.Controls.Add(Me.LblJdul)
        Me.Name = "FrmPenyimpanan"
        Me.Text = "Form Penyimpanan"
        CType(Me.DGVBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblJdul As Label
    Friend WithEvents LblMerek As Label
    Friend WithEvents LblTipe As Label
    Friend WithEvents LblDis As Label
    Friend WithEvents LblJumlah As Label
    Friend WithEvents TxtMerek As TextBox
    Friend WithEvents TxtTipe As TextBox
    Friend WithEvents TxtDis As TextBox
    Friend WithEvents TxtJumlah As TextBox
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents LblKode As Label
    Friend WithEvents TxtKode As TextBox
    Friend WithEvents DGVBarang As DataGridView
End Class
