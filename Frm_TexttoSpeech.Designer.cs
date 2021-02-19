namespace TextToSpeech
{
    partial class Frm_TexttoSpeech
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TexttoSpeech));
            this.xuiObjectEllipse1 = new XanderUI.XUIObjectEllipse();
            this.xuiFormDesign1 = new XanderUI.XUIFormDesign();
            this.xuiSegment1 = new XanderUI.XUISegment();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_resume = new System.Windows.Forms.Button();
            this.btn_speak = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.xuiFormDesign1.WorkingArea.SuspendLayout();
            this.xuiFormDesign1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // xuiObjectEllipse1
            // 
            this.xuiObjectEllipse1.CornerRadius = 10;
            this.xuiObjectEllipse1.EffectedControl = this;
            this.xuiObjectEllipse1.EffectedForm = this;
            // 
            // xuiFormDesign1
            // 
            this.xuiFormDesign1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.xuiFormDesign1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.ExitApplication = true;
            this.xuiFormDesign1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiFormDesign1.FormStyle = XanderUI.XUIFormDesign.Style.MacOS;
            this.xuiFormDesign1.Location = new System.Drawing.Point(0, 0);
            this.xuiFormDesign1.MaterialBackColor = System.Drawing.Color.DodgerBlue;
            this.xuiFormDesign1.MaterialForeColor = System.Drawing.Color.White;
            this.xuiFormDesign1.Name = "xuiFormDesign1";
            this.xuiFormDesign1.ShowMaximize = true;
            this.xuiFormDesign1.ShowMinimize = true;
            this.xuiFormDesign1.Size = new System.Drawing.Size(940, 526);
            this.xuiFormDesign1.TabIndex = 0;
            this.xuiFormDesign1.TitleText = "Text To Speech";
            // 
            // xuiFormDesign1.WorkingArea
            // 
            this.xuiFormDesign1.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.xuiSegment1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.label1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.rtb);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.panel1);
            this.xuiFormDesign1.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.WorkingArea.Location = new System.Drawing.Point(0, 39);
            this.xuiFormDesign1.WorkingArea.Name = "WorkingArea";
            this.xuiFormDesign1.WorkingArea.Size = new System.Drawing.Size(940, 487);
            this.xuiFormDesign1.WorkingArea.TabIndex = 0;
            // 
            // xuiSegment1
            // 
            this.xuiSegment1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuiSegment1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xuiSegment1.Items = "Speak, Pause, Resume, Exit";
            this.xuiSegment1.Location = new System.Drawing.Point(255, 0);
            this.xuiSegment1.Name = "xuiSegment1";
            this.xuiSegment1.SegmentActiveTextColor = System.Drawing.Color.White;
            this.xuiSegment1.SegmentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(142)))), ((int)(((byte)(244)))));
            this.xuiSegment1.SegmentColor = System.Drawing.Color.White;
            this.xuiSegment1.SegmentInactiveTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.xuiSegment1.SegmentStyle = XanderUI.XUISegment.Style.iOS;
            this.xuiSegment1.SelectedIndex = 0;
            this.xuiSegment1.Size = new System.Drawing.Size(685, 47);
            this.xuiSegment1.TabIndex = 5;
            this.xuiSegment1.Text = "xuiSegment1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Provide the text to convert";
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(255, 90);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(682, 397);
            this.rtb.TabIndex = 3;
            this.rtb.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(98)))), ((int)(((byte)(195)))));
            this.panel1.Controls.Add(this.btn_pause);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_resume);
            this.panel1.Controls.Add(this.btn_speak);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 487);
            this.panel1.TabIndex = 2;
            // 
            // btn_pause
            // 
            this.btn_pause.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(142)))), ((int)(((byte)(244)))));
            this.btn_pause.FlatAppearance.BorderSize = 0;
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pause.ForeColor = System.Drawing.Color.White;
            this.btn_pause.Image = ((System.Drawing.Image)(resources.GetObject("btn_pause.Image")));
            this.btn_pause.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pause.Location = new System.Drawing.Point(0, 207);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(255, 50);
            this.btn_pause.TabIndex = 1;
            this.btn_pause.Text = "       Pause";
            this.btn_pause.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_pause.UseVisualStyleBackColor = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(142)))), ((int)(((byte)(244)))));
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(0, 307);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(255, 50);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "       Exit";
            this.btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_resume
            // 
            this.btn_resume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_resume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(142)))), ((int)(((byte)(244)))));
            this.btn_resume.FlatAppearance.BorderSize = 0;
            this.btn_resume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_resume.ForeColor = System.Drawing.Color.White;
            this.btn_resume.Image = ((System.Drawing.Image)(resources.GetObject("btn_resume.Image")));
            this.btn_resume.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_resume.Location = new System.Drawing.Point(0, 257);
            this.btn_resume.Name = "btn_resume";
            this.btn_resume.Size = new System.Drawing.Size(255, 50);
            this.btn_resume.TabIndex = 1;
            this.btn_resume.Text = "       Resume";
            this.btn_resume.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_resume.UseVisualStyleBackColor = false;
            this.btn_resume.Click += new System.EventHandler(this.btn_resume_Click);
            // 
            // btn_speak
            // 
            this.btn_speak.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_speak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(142)))), ((int)(((byte)(244)))));
            this.btn_speak.FlatAppearance.BorderSize = 0;
            this.btn_speak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_speak.ForeColor = System.Drawing.Color.White;
            this.btn_speak.Image = ((System.Drawing.Image)(resources.GetObject("btn_speak.Image")));
            this.btn_speak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_speak.Location = new System.Drawing.Point(0, 157);
            this.btn_speak.Name = "btn_speak";
            this.btn_speak.Size = new System.Drawing.Size(255, 50);
            this.btn_speak.TabIndex = 1;
            this.btn_speak.Text = "       Speak";
            this.btn_speak.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_speak.UseVisualStyleBackColor = false;
            this.btn_speak.Click += new System.EventHandler(this.btn_speak_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_TexttoSpeech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 526);
            this.Controls.Add(this.xuiFormDesign1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_TexttoSpeech";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speech";
            this.xuiFormDesign1.WorkingArea.ResumeLayout(false);
            this.xuiFormDesign1.WorkingArea.PerformLayout();
            this.xuiFormDesign1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIObjectEllipse xuiObjectEllipse1;
        private XanderUI.XUIFormDesign xuiFormDesign1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_resume;
        private System.Windows.Forms.Button btn_speak;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb;
        private XanderUI.XUISegment xuiSegment1;

    }
}

