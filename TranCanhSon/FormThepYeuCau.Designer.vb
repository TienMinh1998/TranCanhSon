<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormThepYeuCau
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormThepYeuCau))
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.dgvThepYC = New System.Windows.Forms.DataGridView()
        Me.Stt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TietDien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.h = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mtt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dttt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HamLuong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnTinhToan = New System.Windows.Forms.Button()
        Me.GroupBox10.SuspendLayout()
        CType(Me.dgvThepYC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox10
        '
        Me.GroupBox10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox10.Controls.Add(Me.dgvThepYC)
        Me.GroupBox10.Location = New System.Drawing.Point(0, 162)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(1120, 475)
        Me.GroupBox10.TabIndex = 2
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Bảng diện tích thép yc"
        '
        'dgvThepYC
        '
        Me.dgvThepYC.AllowUserToAddRows = False
        Me.dgvThepYC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvThepYC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvThepYC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Stt, Me.DataGridViewTextBoxColumn4, Me.TietDien, Me.b, Me.h, Me.Mtt, Me.Dttt, Me.HamLuong})
        Me.dgvThepYC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvThepYC.Location = New System.Drawing.Point(3, 17)
        Me.dgvThepYC.Name = "dgvThepYC"
        Me.dgvThepYC.RowHeadersVisible = False
        Me.dgvThepYC.Size = New System.Drawing.Size(1114, 455)
        Me.dgvThepYC.TabIndex = 1
        '
        'Stt
        '
        Me.Stt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Stt.HeaderText = "Stt"
        Me.Stt.Name = "Stt"
        Me.Stt.Width = 60
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tên dầm"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'TietDien
        '
        Me.TietDien.HeaderText = "Tiết diện"
        Me.TietDien.Name = "TietDien"
        '
        'b
        '
        Me.b.HeaderText = "b (m)"
        Me.b.Name = "b"
        '
        'h
        '
        Me.h.HeaderText = "h (m)"
        Me.h.Name = "h"
        '
        'Mtt
        '
        Me.Mtt.HeaderText = "Mtt (KN.m)"
        Me.Mtt.Name = "Mtt"
        '
        'Dttt
        '
        Me.Dttt.HeaderText = "As (cm2)"
        Me.Dttt.Name = "Dttt"
        '
        'HamLuong
        '
        Me.HamLuong.HeaderText = "μ (%)"
        Me.HamLuong.Name = "HamLuong"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(7, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(594, 150)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 47
        Me.PictureBox2.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNext.Location = New System.Drawing.Point(607, 46)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(156, 34)
        Me.btnNext.TabIndex = 48
        Me.btnNext.Text = "Tiếp tục tính toán >"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnTinhToan
        '
        Me.btnTinhToan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTinhToan.Location = New System.Drawing.Point(607, 6)
        Me.btnTinhToan.Name = "btnTinhToan"
        Me.btnTinhToan.Size = New System.Drawing.Size(156, 34)
        Me.btnTinhToan.TabIndex = 50
        Me.btnTinhToan.Text = "Tính toán"
        Me.btnTinhToan.UseVisualStyleBackColor = True
        '
        'FormThepYeuCau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1123, 649)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnTinhToan)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox10)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormThepYeuCau"
        Me.Text = "FormThepYeuCau"
        Me.GroupBox10.ResumeLayout(False)
        CType(Me.dgvThepYC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents dgvThepYC As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnTinhToan As Button
    Friend WithEvents Stt As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents TietDien As DataGridViewTextBoxColumn
    Friend WithEvents b As DataGridViewTextBoxColumn
    Friend WithEvents h As DataGridViewTextBoxColumn
    Friend WithEvents Mtt As DataGridViewTextBoxColumn
    Friend WithEvents Dttt As DataGridViewTextBoxColumn
    Friend WithEvents HamLuong As DataGridViewTextBoxColumn
End Class
