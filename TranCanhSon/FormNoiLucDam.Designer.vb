<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNoiLucDam
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnChonVatLieu = New System.Windows.Forms.Button()
        Me.btnSuaNN = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtQmax3 = New System.Windows.Forms.TextBox()
        Me.txtMmax3 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtQmax2 = New System.Windows.Forms.TextBox()
        Me.txtMax2 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtQmax1 = New System.Windows.Forms.TextBox()
        Me.txtMmax1 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvNoiLuc = New System.Windows.Forms.DataGridView()
        Me.STTNN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mmax1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mmax2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mmax3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qmax1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qmax2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qmax3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvNoiLuc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Controls.Add(Me.btnChonVatLieu)
        Me.GroupBox3.Controls.Add(Me.btnSuaNN)
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1183, 198)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Nội lực nguy hiểm"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TranCanhSon.My.Resources.Resources.noilucdam
        Me.PictureBox1.Location = New System.Drawing.Point(702, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(458, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'btnChonVatLieu
        '
        Me.btnChonVatLieu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChonVatLieu.Location = New System.Drawing.Point(1050, 15)
        Me.btnChonVatLieu.Name = "btnChonVatLieu"
        Me.btnChonVatLieu.Size = New System.Drawing.Size(103, 26)
        Me.btnChonVatLieu.TabIndex = 6
        Me.btnChonVatLieu.Text = "Chọn vật liệu >"
        Me.btnChonVatLieu.UseVisualStyleBackColor = True
        '
        'btnSuaNN
        '
        Me.btnSuaNN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSuaNN.Location = New System.Drawing.Point(941, 15)
        Me.btnSuaNN.Name = "btnSuaNN"
        Me.btnSuaNN.Size = New System.Drawing.Size(103, 26)
        Me.btnSuaNN.TabIndex = 6
        Me.btnSuaNN.Text = "Sửa"
        Me.btnSuaNN.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtQmax3)
        Me.GroupBox6.Controls.Add(Me.txtMmax3)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.Label23)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Location = New System.Drawing.Point(475, 41)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(204, 138)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Gối C-C"
        '
        'txtQmax3
        '
        Me.txtQmax3.Location = New System.Drawing.Point(70, 80)
        Me.txtQmax3.Name = "txtQmax3"
        Me.txtQmax3.Size = New System.Drawing.Size(78, 21)
        Me.txtQmax3.TabIndex = 3
        '
        'txtMmax3
        '
        Me.txtMmax3.Location = New System.Drawing.Point(70, 41)
        Me.txtMmax3.Name = "txtMmax3"
        Me.txtMmax3.Size = New System.Drawing.Size(78, 21)
        Me.txtMmax3.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(5, 83)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 15)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Qmax 3:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(5, 44)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(55, 15)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "Mmax 3:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(154, 44)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(46, 15)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "(KN.m)"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(154, 83)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(32, 15)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "(KN)"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtQmax2)
        Me.GroupBox5.Controls.Add(Me.txtMax2)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Location = New System.Drawing.Point(239, 41)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(214, 138)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Nhịp B-B"
        '
        'txtQmax2
        '
        Me.txtQmax2.Location = New System.Drawing.Point(72, 80)
        Me.txtQmax2.Name = "txtQmax2"
        Me.txtQmax2.Size = New System.Drawing.Size(78, 21)
        Me.txtQmax2.TabIndex = 3
        '
        'txtMax2
        '
        Me.txtMax2.Location = New System.Drawing.Point(72, 41)
        Me.txtMax2.Name = "txtMax2"
        Me.txtMax2.Size = New System.Drawing.Size(78, 21)
        Me.txtMax2.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 44)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 15)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Mmax 2:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(156, 83)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(32, 15)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "(KN)"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(156, 44)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 15)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "(KN.m)"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(7, 83)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 15)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Qmax 2:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtQmax1)
        Me.GroupBox4.Controls.Add(Me.txtMmax1)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 41)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(207, 138)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Gối A-A"
        '
        'txtQmax1
        '
        Me.txtQmax1.Location = New System.Drawing.Point(66, 77)
        Me.txtQmax1.Name = "txtQmax1"
        Me.txtQmax1.Size = New System.Drawing.Size(78, 21)
        Me.txtQmax1.TabIndex = 3
        '
        'txtMmax1
        '
        Me.txtMmax1.Location = New System.Drawing.Point(66, 38)
        Me.txtMmax1.Name = "txtMmax1"
        Me.txtMmax1.Size = New System.Drawing.Size(78, 21)
        Me.txtMmax1.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(150, 80)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 15)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "(KN)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(1, 80)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 15)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Qmax 1:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(150, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 15)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "(KN.m)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 15)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Mmax 1:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvNoiLuc)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 198)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1183, 383)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bảng nội lực các dầm:"
        '
        'dgvNoiLuc
        '
        Me.dgvNoiLuc.AllowUserToAddRows = False
        Me.dgvNoiLuc.AllowUserToDeleteRows = False
        Me.dgvNoiLuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvNoiLuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNoiLuc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STTNN, Me.DataGridViewTextBoxColumn2, Me.Mmax1, Me.Mmax2, Me.Mmax3, Me.Qmax1, Me.Qmax2, Me.Qmax3})
        Me.dgvNoiLuc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvNoiLuc.Location = New System.Drawing.Point(3, 17)
        Me.dgvNoiLuc.Name = "dgvNoiLuc"
        Me.dgvNoiLuc.ReadOnly = True
        Me.dgvNoiLuc.RowHeadersVisible = False
        Me.dgvNoiLuc.Size = New System.Drawing.Size(1177, 363)
        Me.dgvNoiLuc.TabIndex = 6
        '
        'STTNN
        '
        Me.STTNN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.STTNN.HeaderText = "Stt"
        Me.STTNN.Name = "STTNN"
        Me.STTNN.ReadOnly = True
        Me.STTNN.Width = 30
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tên dầm"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Mmax1
        '
        Me.Mmax1.HeaderText = "Mmax1 (KN.m)"
        Me.Mmax1.Name = "Mmax1"
        Me.Mmax1.ReadOnly = True
        '
        'Mmax2
        '
        Me.Mmax2.HeaderText = "Mmax2 (KN.m)"
        Me.Mmax2.Name = "Mmax2"
        Me.Mmax2.ReadOnly = True
        '
        'Mmax3
        '
        Me.Mmax3.HeaderText = "Mmax3 (KN.m)"
        Me.Mmax3.Name = "Mmax3"
        Me.Mmax3.ReadOnly = True
        '
        'Qmax1
        '
        Me.Qmax1.HeaderText = "Qmax1 (KN)"
        Me.Qmax1.Name = "Qmax1"
        Me.Qmax1.ReadOnly = True
        '
        'Qmax2
        '
        Me.Qmax2.HeaderText = "Qmax2 (KN)"
        Me.Qmax2.Name = "Qmax2"
        Me.Qmax2.ReadOnly = True
        '
        'Qmax3
        '
        Me.Qmax3.HeaderText = "Qmax3 (KN)"
        Me.Qmax3.Name = "Qmax3"
        Me.Qmax3.ReadOnly = True
        '
        'FormNoiLucDam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1183, 581)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormNoiLucDam"
        Me.Text = "FormNoiLucDam"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvNoiLuc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSuaNN As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txtQmax3 As TextBox
    Friend WithEvents txtMmax3 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtQmax2 As TextBox
    Friend WithEvents txtMax2 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtQmax1 As TextBox
    Friend WithEvents txtMmax1 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvNoiLuc As DataGridView
    Friend WithEvents STTNN As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Mmax1 As DataGridViewTextBoxColumn
    Friend WithEvents Mmax2 As DataGridViewTextBoxColumn
    Friend WithEvents Mmax3 As DataGridViewTextBoxColumn
    Friend WithEvents Qmax1 As DataGridViewTextBoxColumn
    Friend WithEvents Qmax2 As DataGridViewTextBoxColumn
    Friend WithEvents Qmax3 As DataGridViewTextBoxColumn
    Friend WithEvents btnChonVatLieu As Button
End Class
