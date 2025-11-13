namespace Music_Player_App
{
    partial class MusicPlayerApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayerApp));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.Maximise = new System.Windows.Forms.PictureBox();
            this.Minimise = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.LabelLogo = new System.Windows.Forms.Label();
            this.TaskPanel = new System.Windows.Forms.Panel();
            this.comboBoxTheme = new System.Windows.Forms.ComboBox();
            this.ButtonSelectInfo = new System.Windows.Forms.Label();
            this.ButtonSelectFiles = new System.Windows.Forms.Label();
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.toolTipClose = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipMinimise = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSelectFile = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipTheme = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipMaximise = new System.Windows.Forms.ToolTip(this.components);
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Maximise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.TaskPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TopPanel.Controls.Add(this.Maximise);
            this.TopPanel.Controls.Add(this.Minimise);
            this.TopPanel.Controls.Add(this.Close);
            this.TopPanel.Controls.Add(this.pictureBoxLogo);
            this.TopPanel.Controls.Add(this.LabelLogo);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 55);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanel_Paint);
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // Maximise
            // 
            this.Maximise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Maximise.Image = ((System.Drawing.Image)(resources.GetObject("Maximise.Image")));
            this.Maximise.Location = new System.Drawing.Point(653, 0);
            this.Maximise.Name = "Maximise";
            this.Maximise.Size = new System.Drawing.Size(48, 45);
            this.Maximise.TabIndex = 4;
            this.Maximise.TabStop = false;
            this.toolTipMaximise.SetToolTip(this.Maximise, "Miximise");
            this.Maximise.Click += new System.EventHandler(this.Maximise_Click);
            // 
            // Minimise
            // 
            this.Minimise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimise.Image = ((System.Drawing.Image)(resources.GetObject("Minimise.Image")));
            this.Minimise.Location = new System.Drawing.Point(707, 4);
            this.Minimise.Name = "Minimise";
            this.Minimise.Size = new System.Drawing.Size(42, 40);
            this.Minimise.TabIndex = 3;
            this.Minimise.TabStop = false;
            this.toolTipMinimise.SetToolTip(this.Minimise, "Minimise");
            this.Minimise.Click += new System.EventHandler(this.Minimise_Click);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.Location = new System.Drawing.Point(755, 5);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(42, 44);
            this.Close.TabIndex = 2;
            this.Close.TabStop = false;
            this.toolTipClose.SetToolTip(this.Close, "Close");
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(6, 4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LabelLogo
            // 
            this.LabelLogo.AutoSize = true;
            this.LabelLogo.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLogo.ForeColor = System.Drawing.Color.White;
            this.LabelLogo.Location = new System.Drawing.Point(60, 9);
            this.LabelLogo.Name = "LabelLogo";
            this.LabelLogo.Size = new System.Drawing.Size(229, 38);
            this.LabelLogo.TabIndex = 0;
            this.LabelLogo.Text = "Music Player App";
            this.LabelLogo.Click += new System.EventHandler(this.LabelLogo_Click);
            // 
            // TaskPanel
            // 
            this.TaskPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TaskPanel.Controls.Add(this.comboBoxTheme);
            this.TaskPanel.Controls.Add(this.ButtonSelectInfo);
            this.TaskPanel.Controls.Add(this.ButtonSelectFiles);
            this.TaskPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TaskPanel.Location = new System.Drawing.Point(0, 55);
            this.TaskPanel.Name = "TaskPanel";
            this.TaskPanel.Size = new System.Drawing.Size(800, 30);
            this.TaskPanel.TabIndex = 1;
            // 
            // comboBoxTheme
            // 
            this.comboBoxTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTheme.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTheme.FormattingEnabled = true;
            this.comboBoxTheme.Items.AddRange(new object[] {
            "Default",
            "Pink",
            "Light",
            "Dark"});
            this.comboBoxTheme.Location = new System.Drawing.Point(172, -3);
            this.comboBoxTheme.Name = "comboBoxTheme";
            this.comboBoxTheme.Size = new System.Drawing.Size(95, 34);
            this.comboBoxTheme.TabIndex = 2;
            this.toolTipTheme.SetToolTip(this.comboBoxTheme, "Changes theme");
            this.comboBoxTheme.SelectedIndexChanged += new System.EventHandler(this.comboBoxTheme_SelectedIndexChanged);
            // 
            // ButtonSelectInfo
            // 
            this.ButtonSelectInfo.AutoSize = true;
            this.ButtonSelectInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSelectInfo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSelectInfo.Location = new System.Drawing.Point(114, 0);
            this.ButtonSelectInfo.Name = "ButtonSelectInfo";
            this.ButtonSelectInfo.Size = new System.Drawing.Size(52, 26);
            this.ButtonSelectInfo.TabIndex = 1;
            this.ButtonSelectInfo.Text = "Info";
            this.toolTipInfo.SetToolTip(this.ButtonSelectInfo, "Click for Info");
            this.ButtonSelectInfo.Click += new System.EventHandler(this.ButtonSelectInfo_Click);
            // 
            // ButtonSelectFiles
            // 
            this.ButtonSelectFiles.AutoSize = true;
            this.ButtonSelectFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSelectFiles.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSelectFiles.Location = new System.Drawing.Point(3, 0);
            this.ButtonSelectFiles.Name = "ButtonSelectFiles";
            this.ButtonSelectFiles.Size = new System.Drawing.Size(105, 26);
            this.ButtonSelectFiles.TabIndex = 0;
            this.ButtonSelectFiles.Text = "Select File";
            this.toolTipSelectFile.SetToolTip(this.ButtonSelectFiles, "Select File");
            this.ButtonSelectFiles.Click += new System.EventHandler(this.ButtonSelectFiles_Click);
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBoxSongs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxSongs.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.ItemHeight = 15;
            this.listBoxSongs.Location = new System.Drawing.Point(610, 120);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(178, 315);
            this.listBoxSongs.TabIndex = 3;
            this.listBoxSongs.SelectedIndexChanged += new System.EventHandler(this.listBoxSongs_SelectedIndexChanged);
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(12, 120);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(592, 319);
            this.axWindowsMediaPlayer.TabIndex = 2;
            // 
            // MusicPlayerApp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxSongs);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.Controls.Add(this.TaskPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MusicPlayerApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player App";
            this.Load += new System.EventHandler(this.MusicPlayerApp_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Maximise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.TaskPanel.ResumeLayout(false);
            this.TaskPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel TaskPanel;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.Label LabelLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox Minimise;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.Label ButtonSelectFiles;
        private System.Windows.Forms.Label ButtonSelectInfo;
        private System.Windows.Forms.ListBox listBoxSongs;
        private System.Windows.Forms.PictureBox Maximise;
        public System.Windows.Forms.ComboBox comboBoxTheme;
        private System.Windows.Forms.ToolTip toolTipClose;
        private System.Windows.Forms.ToolTip toolTipMinimise;
        private System.Windows.Forms.ToolTip toolTipMaximise;
        private System.Windows.Forms.ToolTip toolTipTheme;
        private System.Windows.Forms.ToolTip toolTipInfo;
        private System.Windows.Forms.ToolTip toolTipSelectFile;
    }
}

