using LibVLCSharp.Shared;
using System.Windows.Forms;

namespace LibVLCSharp.WinForms.Sample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                this._mp?.Dispose();
                this._libVLC?.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.videoView1 = new LibVLCSharp.WinForms.VideoView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cklistbox = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRate = new System.Windows.Forms.ComboBox();
            this.lbl_End = new System.Windows.Forms.Label();
            this.lbl_Start = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbSpeed = new System.Windows.Forms.ComboBox();
            this.trBar = new System.Windows.Forms.TrackBar();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_bkn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_length = new System.Windows.Forms.Label();
            this.btn_frn = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.lbl_time = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_OpAudio = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.videoView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trBar)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoView1
            // 
            this.videoView1.BackColor = System.Drawing.Color.Black;
            this.videoView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView1.Location = new System.Drawing.Point(0, 0);
            this.videoView1.MediaPlayer = null;
            this.videoView1.Name = "videoView1";
            this.videoView1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.videoView1.Size = new System.Drawing.Size(725, 367);
            this.videoView1.TabIndex = 3;
            this.videoView1.Text = "videoView1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 367);
            this.panel3.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cklistbox);
            this.groupBox2.Location = new System.Drawing.Point(0, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 296);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách ghi âm";
            // 
            // cklistbox
            // 
            this.cklistbox.CheckOnClick = true;
            this.cklistbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cklistbox.FormattingEnabled = true;
            this.cklistbox.Location = new System.Drawing.Point(3, 16);
            this.cklistbox.Name = "cklistbox";
            this.cklistbox.Size = new System.Drawing.Size(221, 277);
            this.cklistbox.TabIndex = 1;
            this.cklistbox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cklistbox_ItemCheck);
      
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbRate);
            this.groupBox1.Controls.Add(this.lbl_End);
            this.groupBox1.Controls.Add(this.lbl_Start);
            this.groupBox1.Controls.Add(this.lbl_Name);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin video";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(1);
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tốc độ";
            // 
            // cbRate
            // 
            this.cbRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRate.FormattingEnabled = true;
            this.cbRate.Items.AddRange(new object[] {
            "x1",
            "x2",
            "x3",
            "x4"});
            this.cbRate.Location = new System.Drawing.Point(100, 73);
            this.cbRate.Name = "cbRate";
            this.cbRate.Size = new System.Drawing.Size(121, 21);
            this.cbRate.TabIndex = 3;
            this.cbRate.SelectedIndexChanged += new System.EventHandler(this.cbRate_SelectedIndexChanged);
            // 
            // lbl_End
            // 
            this.lbl_End.AutoSize = true;
            this.lbl_End.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_End.Location = new System.Drawing.Point(3, 46);
            this.lbl_End.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbl_End.Name = "lbl_End";
            this.lbl_End.Padding = new System.Windows.Forms.Padding(1);
            this.lbl_End.Size = new System.Drawing.Size(49, 15);
            this.lbl_End.TabIndex = 2;
            this.lbl_End.Text = "Kết thúc";
            // 
            // lbl_Start
            // 
            this.lbl_Start.AutoSize = true;
            this.lbl_Start.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Start.Location = new System.Drawing.Point(3, 31);
            this.lbl_Start.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbl_Start.Name = "lbl_Start";
            this.lbl_Start.Padding = new System.Windows.Forms.Padding(1);
            this.lbl_Start.Size = new System.Drawing.Size(47, 15);
            this.lbl_Start.TabIndex = 1;
            this.lbl_Start.Text = "Bắt đầu";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Name.Location = new System.Drawing.Point(3, 16);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Padding = new System.Windows.Forms.Padding(1);
            this.lbl_Name.Size = new System.Drawing.Size(28, 15);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Tên";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(956, 461);
            this.splitContainer1.SplitterDistance = 725;
            this.splitContainer1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 461);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.videoView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 367);
            this.panel1.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbSpeed);
            this.panel5.Controls.Add(this.trBar);
            this.panel5.Controls.Add(this.btn_Stop);
            this.panel5.Controls.Add(this.btn_bkn);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.lbl_length);
            this.panel5.Controls.Add(this.btn_frn);
            this.panel5.Controls.Add(this.btn_play);
            this.panel5.Controls.Add(this.lbl_time);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 367);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(725, 94);
            this.panel5.TabIndex = 3;
            // 
            // cbSpeed
            // 
            this.cbSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSpeed.FormattingEnabled = true;
            this.cbSpeed.Items.AddRange(new object[] {
            "5",
            "10",
            "15"});
            this.cbSpeed.Location = new System.Drawing.Point(661, 52);
            this.cbSpeed.Name = "cbSpeed";
            this.cbSpeed.Size = new System.Drawing.Size(52, 32);
            this.cbSpeed.TabIndex = 16;
            // 
            // trBar
            // 
            this.trBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.trBar.Enabled = false;
            this.trBar.Location = new System.Drawing.Point(0, 0);
            this.trBar.Name = "trBar";
            this.trBar.Size = new System.Drawing.Size(725, 45);
            this.trBar.TabIndex = 15;
            this.trBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trBar.Scroll += new System.EventHandler(this.trBar_Scroll);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(93, 46);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 37);
            this.btn_Stop.TabIndex = 14;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_bkn
            // 
            this.btn_bkn.Image = ((System.Drawing.Image)(resources.GetObject("btn_bkn.Image")));
            this.btn_bkn.Location = new System.Drawing.Point(174, 46);
            this.btn_bkn.Name = "btn_bkn";
            this.btn_bkn.Size = new System.Drawing.Size(49, 38);
            this.btn_bkn.TabIndex = 13;
            this.btn_bkn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_bkn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_bkn.UseVisualStyleBackColor = true;
            this.btn_bkn.Click += new System.EventHandler(this.btn_bkn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "-";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_length
            // 
            this.lbl_length.AutoSize = true;
            this.lbl_length.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_length.Location = new System.Drawing.Point(406, 61);
            this.lbl_length.Name = "lbl_length";
            this.lbl_length.Size = new System.Drawing.Size(56, 16);
            this.lbl_length.TabIndex = 11;
            this.lbl_length.Text = "00:00:00";
            // 
            // btn_frn
            // 
            this.btn_frn.Image = global::LibVLCSharp.WinForms.Sample.Properties.Resources.forward_icon;
            this.btn_frn.Location = new System.Drawing.Point(229, 46);
            this.btn_frn.Name = "btn_frn";
            this.btn_frn.Size = new System.Drawing.Size(49, 38);
            this.btn_frn.TabIndex = 10;
            this.btn_frn.UseVisualStyleBackColor = true;
            this.btn_frn.Click += new System.EventHandler(this.btn_frn_Click);
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(12, 46);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(75, 36);
            this.btn_play.TabIndex = 9;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(344, 61);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(56, 16);
            this.lbl_time.TabIndex = 8;
            this.lbl_time.Text = "00:00:00";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_OpAudio);
            this.panel4.Controls.Add(this.btn_open);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 367);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(227, 94);
            this.panel4.TabIndex = 11;
            // 
            // btn_OpAudio
            // 
            this.btn_OpAudio.Location = new System.Drawing.Point(131, 46);
            this.btn_OpAudio.Name = "btn_OpAudio";
            this.btn_OpAudio.Size = new System.Drawing.Size(78, 38);
            this.btn_OpAudio.TabIndex = 9;
            this.btn_OpAudio.Text = "Open Audio";
            this.btn_OpAudio.UseVisualStyleBackColor = true;
            this.btn_OpAudio.Click += new System.EventHandler(this.btn_OpAudio_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(22, 46);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 37);
            this.btn_open.TabIndex = 10;
            this.btn_open.Text = "Open Video";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer2.Size = new System.Drawing.Size(956, 490);
            this.splitContainer2.SplitterDistance = 461;
            this.splitContainer2.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(956, 25);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(820, 20);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Nguyễn Đức Toàn-Đội CNTT-Trung tâm BĐKT";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(121, 20);
            this.toolStripStatusLabel2.Text = "30/07/2020 Ver 1.0.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 490);
            this.Controls.Add(this.splitContainer2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MIRATS A&V Playback;";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trBar)).EndInit();
            this.panel4.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private VideoView videoView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_End;
        private System.Windows.Forms.Label lbl_Start;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_OpAudio;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TrackBar trBar;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_bkn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_length;
        private System.Windows.Forms.Button btn_frn;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.ComboBox cbSpeed;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private CheckedListBox cklistbox;
        private Label label3;
        private ComboBox cbRate;
    }
}