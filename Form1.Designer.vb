<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btn_preview = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.btn_play = New System.Windows.Forms.Button()
        Me.btn_pause = New System.Windows.Forms.Button()
        Me.btn_stop = New System.Windows.Forms.Button()
        Me.btn_open = New System.Windows.Forms.Button()
        Me.p_bar = New System.Windows.Forms.ProgressBar()
        Me.track_list = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.player = New AxWMPLib.AxWindowsMediaPlayer()
        Me.track_volume = New System.Windows.Forms.TrackBar()
        Me.volume = New System.Windows.Forms.Label()
        Me.lbl_volume = New System.Windows.Forms.Label()
        Me.lbl_track_start = New System.Windows.Forms.Label()
        Me.lbl_track_end = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.track_volume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_preview
        '
        Me.btn_preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_preview.ForeColor = System.Drawing.Color.DarkSalmon
        Me.btn_preview.Location = New System.Drawing.Point(34, 304)
        Me.btn_preview.Name = "btn_preview"
        Me.btn_preview.Size = New System.Drawing.Size(80, 29)
        Me.btn_preview.TabIndex = 0
        Me.btn_preview.Text = "Preview"
        Me.btn_preview.UseVisualStyleBackColor = True
        '
        'btn_next
        '
        Me.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_next.ForeColor = System.Drawing.Color.DarkSalmon
        Me.btn_next.Location = New System.Drawing.Point(120, 304)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(83, 29)
        Me.btn_next.TabIndex = 1
        Me.btn_next.Text = "Next"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'btn_play
        '
        Me.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_play.ForeColor = System.Drawing.Color.DarkSalmon
        Me.btn_play.Location = New System.Drawing.Point(206, 304)
        Me.btn_play.Name = "btn_play"
        Me.btn_play.Size = New System.Drawing.Size(86, 29)
        Me.btn_play.TabIndex = 2
        Me.btn_play.Text = "Play"
        Me.btn_play.UseVisualStyleBackColor = True
        '
        'btn_pause
        '
        Me.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pause.ForeColor = System.Drawing.Color.DarkSalmon
        Me.btn_pause.Location = New System.Drawing.Point(298, 304)
        Me.btn_pause.Name = "btn_pause"
        Me.btn_pause.Size = New System.Drawing.Size(78, 29)
        Me.btn_pause.TabIndex = 3
        Me.btn_pause.Text = "Pause"
        Me.btn_pause.UseVisualStyleBackColor = True
        '
        'btn_stop
        '
        Me.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stop.ForeColor = System.Drawing.Color.DarkSalmon
        Me.btn_stop.Location = New System.Drawing.Point(382, 304)
        Me.btn_stop.Name = "btn_stop"
        Me.btn_stop.Size = New System.Drawing.Size(80, 29)
        Me.btn_stop.TabIndex = 4
        Me.btn_stop.Text = "Stop"
        Me.btn_stop.UseVisualStyleBackColor = True
        '
        'btn_open
        '
        Me.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_open.ForeColor = System.Drawing.Color.DarkSalmon
        Me.btn_open.Location = New System.Drawing.Point(468, 304)
        Me.btn_open.Name = "btn_open"
        Me.btn_open.Size = New System.Drawing.Size(176, 29)
        Me.btn_open.TabIndex = 5
        Me.btn_open.Text = "Open"
        Me.btn_open.UseVisualStyleBackColor = True
        '
        'p_bar
        '
        Me.p_bar.Location = New System.Drawing.Point(34, 273)
        Me.p_bar.Name = "p_bar"
        Me.p_bar.Size = New System.Drawing.Size(608, 10)
        Me.p_bar.TabIndex = 6
        '
        'track_list
        '
        Me.track_list.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.track_list.ForeColor = System.Drawing.Color.LightSalmon
        Me.track_list.FormattingEnabled = True
        Me.track_list.ItemHeight = 15
        Me.track_list.Location = New System.Drawing.Point(184, 12)
        Me.track_list.Name = "track_list"
        Me.track_list.Size = New System.Drawing.Size(376, 154)
        Me.track_list.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ジョンセロム_インタン.My.Resources.Resources._5
        Me.PictureBox1.Location = New System.Drawing.Point(15, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(163, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'player
        '
        Me.player.Dock = System.Windows.Forms.DockStyle.Top
        Me.player.Enabled = True
        Me.player.Location = New System.Drawing.Point(0, 0)
        Me.player.Name = "player"
        Me.player.OcxState = CType(resources.GetObject("player.OcxState"), System.Windows.Forms.AxHost.State)
        Me.player.Size = New System.Drawing.Size(684, 52)
        Me.player.TabIndex = 9
        '
        'track_volume
        '
        Me.track_volume.Location = New System.Drawing.Point(577, 34)
        Me.track_volume.Maximum = 100
        Me.track_volume.Name = "track_volume"
        Me.track_volume.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.track_volume.Size = New System.Drawing.Size(45, 125)
        Me.track_volume.TabIndex = 10
        Me.track_volume.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'volume
        '
        Me.volume.AutoSize = True
        Me.volume.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.volume.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.volume.Location = New System.Drawing.Point(566, 161)
        Me.volume.Name = "volume"
        Me.volume.Size = New System.Drawing.Size(49, 15)
        Me.volume.TabIndex = 11
        Me.volume.Text = "Volume"
        '
        'lbl_volume
        '
        Me.lbl_volume.AutoSize = True
        Me.lbl_volume.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_volume.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_volume.Location = New System.Drawing.Point(573, 11)
        Me.lbl_volume.Name = "lbl_volume"
        Me.lbl_volume.Size = New System.Drawing.Size(38, 15)
        Me.lbl_volume.TabIndex = 12
        Me.lbl_volume.Text = "100%"
        '
        'lbl_track_start
        '
        Me.lbl_track_start.AutoSize = True
        Me.lbl_track_start.Font = New System.Drawing.Font("OCR A Std", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_track_start.ForeColor = System.Drawing.Color.GreenYellow
        Me.lbl_track_start.Location = New System.Drawing.Point(24, 27)
        Me.lbl_track_start.Name = "lbl_track_start"
        Me.lbl_track_start.Size = New System.Drawing.Size(102, 25)
        Me.lbl_track_start.TabIndex = 13
        Me.lbl_track_start.Text = "00:00"
        '
        'lbl_track_end
        '
        Me.lbl_track_end.AutoSize = True
        Me.lbl_track_end.Font = New System.Drawing.Font("OCR A Std", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_track_end.ForeColor = System.Drawing.Color.GreenYellow
        Me.lbl_track_end.Location = New System.Drawing.Point(561, 27)
        Me.lbl_track_end.Name = "lbl_track_end"
        Me.lbl_track_end.Size = New System.Drawing.Size(102, 25)
        Me.lbl_track_end.TabIndex = 14
        Me.lbl_track_end.Text = "00:00"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RosyBrown
        Me.Panel1.Controls.Add(Me.volume)
        Me.Panel1.Controls.Add(Me.track_volume)
        Me.Panel1.Controls.Add(Me.lbl_volume)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.track_list)
        Me.Panel1.Location = New System.Drawing.Point(29, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(634, 191)
        Me.Panel1.TabIndex = 15
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(684, 361)
        Me.Controls.Add(Me.lbl_track_end)
        Me.Controls.Add(Me.lbl_track_start)
        Me.Controls.Add(Me.player)
        Me.Controls.Add(Me.p_bar)
        Me.Controls.Add(Me.btn_open)
        Me.Controls.Add(Me.btn_stop)
        Me.Controls.Add(Me.btn_pause)
        Me.Controls.Add(Me.btn_play)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.btn_preview)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form1"
        Me.Text = "Audio player"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.track_volume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_preview As Button
    Friend WithEvents btn_next As Button
    Friend WithEvents btn_play As Button
    Friend WithEvents btn_pause As Button
    Friend WithEvents btn_stop As Button
    Friend WithEvents btn_open As Button
    Friend WithEvents p_bar As ProgressBar
    Friend WithEvents track_list As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents player As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents track_volume As TrackBar
    Friend WithEvents volume As Label
    Friend WithEvents lbl_volume As Label
    Friend WithEvents lbl_track_start As Label
    Friend WithEvents lbl_track_end As Label
    Friend WithEvents Panel1 As Panel

End Class
