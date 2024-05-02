namespace Ha_Noi_Tower
{
    partial class THN
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
            this.A = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmrCountTime = new System.Windows.Forms.Timer(this.components);
            this.lblMoveCount = new System.Windows.Forms.Label();
            this.nudLevel = new System.Windows.Forms.NumericUpDown();
            this.label = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnShowRule = new System.Windows.Forms.Button();
            this.btnGiveup = new System.Windows.Forms.Button();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic8 = new System.Windows.Forms.PictureBox();
            this.pic7 = new System.Windows.Forms.PictureBox();
            this.pic6 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.picRodC = new System.Windows.Forms.PictureBox();
            this.picRodB = new System.Windows.Forms.PictureBox();
            this.picRodA = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMoveCountDisplay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBestMoveCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRodC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRodB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRodA)).BeginInit();
            this.SuspendLayout();
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A.Location = new System.Drawing.Point(137, 374);
            this.A.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(24, 24);
            this.A.TabIndex = 1;
            this.A.Text = "A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 374);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(531, 374);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "C";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.SystemColors.Info;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(8, 6);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(145, 22);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "Thời gian: 00:00:00";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // tmrCountTime
            // 
            this.tmrCountTime.Interval = 1000;
            this.tmrCountTime.Tick += new System.EventHandler(this.tmrCountTime_Tick);
            // 
            // lblMoveCount
            // 
            this.lblMoveCount.AutoSize = true;
            this.lblMoveCount.BackColor = System.Drawing.SystemColors.Info;
            this.lblMoveCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMoveCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveCount.Location = new System.Drawing.Point(8, 36);
            this.lblMoveCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoveCount.Name = "lblMoveCount";
            this.lblMoveCount.Size = new System.Drawing.Size(169, 22);
            this.lblMoveCount.TabIndex = 15;
            this.lblMoveCount.Text = "Số lần di chuyển: 0 lần";
            this.lblMoveCount.Click += new System.EventHandler(this.label3_Click);
            // 
            // nudLevel
            // 
            this.nudLevel.BackColor = System.Drawing.SystemColors.Info;
            this.nudLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLevel.Location = new System.Drawing.Point(351, 61);
            this.nudLevel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudLevel.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudLevel.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudLevel.Name = "nudLevel";
            this.nudLevel.Size = new System.Drawing.Size(30, 26);
            this.nudLevel.TabIndex = 16;
            this.nudLevel.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudLevel.ValueChanged += new System.EventHandler(this.nudLevel_ValueChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.Info;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(295, 62);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(58, 20);
            this.label.TabIndex = 17;
            this.label.Text = "Số đĩa:";
            this.label.Click += new System.EventHandler(this.lblMoveCount_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlay.Location = new System.Drawing.Point(222, 90);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 25);
            this.btnPlay.TabIndex = 18;
            this.btnPlay.Text = "Chơi";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnShowRule
            // 
            this.btnShowRule.BackColor = System.Drawing.SystemColors.Control;
            this.btnShowRule.Location = new System.Drawing.Point(381, 90);
            this.btnShowRule.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnShowRule.Name = "btnShowRule";
            this.btnShowRule.Size = new System.Drawing.Size(75, 25);
            this.btnShowRule.TabIndex = 19;
            this.btnShowRule.Text = "Luật chơi";
            this.btnShowRule.UseVisualStyleBackColor = false;
            this.btnShowRule.Click += new System.EventHandler(this.btnShowRule_Click);
            // 
            // btnGiveup
            // 
            this.btnGiveup.BackColor = System.Drawing.SystemColors.Control;
            this.btnGiveup.Enabled = false;
            this.btnGiveup.Location = new System.Drawing.Point(301, 90);
            this.btnGiveup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGiveup.Name = "btnGiveup";
            this.btnGiveup.Size = new System.Drawing.Size(75, 25);
            this.btnGiveup.TabIndex = 20;
            this.btnGiveup.Text = "Chịu thua";
            this.btnGiveup.UseVisualStyleBackColor = false;
            this.btnGiveup.Click += new System.EventHandler(this.btnGiveup_Click);
            // 
            // pic4
            // 
            this.pic4.Image = global::Ha_Noi_Tower.Properties.Resources.So4;
            this.pic4.Location = new System.Drawing.Point(463, 233);
            this.pic4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(154, 18);
            this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic4.TabIndex = 13;
            this.pic4.TabStop = false;
            this.pic4.Tag = "4";
            this.pic4.Visible = false;
            this.pic4.Click += new System.EventHandler(this.picDisk_Click);
            // 
            // pic3
            // 
            this.pic3.Image = global::Ha_Noi_Tower.Properties.Resources.So3;
            this.pic3.Location = new System.Drawing.Point(463, 214);
            this.pic3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(154, 18);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic3.TabIndex = 12;
            this.pic3.TabStop = false;
            this.pic3.Tag = "3";
            this.pic3.Visible = false;
            this.pic3.Click += new System.EventHandler(this.picDisk_Click);
            // 
            // pic2
            // 
            this.pic2.Image = global::Ha_Noi_Tower.Properties.Resources.So2;
            this.pic2.Location = new System.Drawing.Point(267, 316);
            this.pic2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(154, 18);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic2.TabIndex = 11;
            this.pic2.TabStop = false;
            this.pic2.Tag = "2";
            this.pic2.Visible = false;
            this.pic2.Click += new System.EventHandler(this.picDisk_Click);
            // 
            // pic8
            // 
            this.pic8.Image = global::Ha_Noi_Tower.Properties.Resources.So8;
            this.pic8.Location = new System.Drawing.Point(463, 316);
            this.pic8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pic8.Name = "pic8";
            this.pic8.Size = new System.Drawing.Size(154, 18);
            this.pic8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic8.TabIndex = 10;
            this.pic8.TabStop = false;
            this.pic8.Tag = "8";
            this.pic8.Visible = false;
            this.pic8.Click += new System.EventHandler(this.picDisk_Click);
            // 
            // pic7
            // 
            this.pic7.Image = global::Ha_Noi_Tower.Properties.Resources.So7;
            this.pic7.Location = new System.Drawing.Point(463, 299);
            this.pic7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pic7.Name = "pic7";
            this.pic7.Size = new System.Drawing.Size(154, 18);
            this.pic7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic7.TabIndex = 9;
            this.pic7.TabStop = false;
            this.pic7.Tag = "7";
            this.pic7.Visible = false;
            this.pic7.Click += new System.EventHandler(this.picDisk_Click);
            // 
            // pic6
            // 
            this.pic6.Image = global::Ha_Noi_Tower.Properties.Resources.So6;
            this.pic6.Location = new System.Drawing.Point(463, 273);
            this.pic6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pic6.Name = "pic6";
            this.pic6.Size = new System.Drawing.Size(154, 18);
            this.pic6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic6.TabIndex = 8;
            this.pic6.TabStop = false;
            this.pic6.Tag = "6";
            this.pic6.Visible = false;
            this.pic6.Click += new System.EventHandler(this.picDisk_Click);
            // 
            // pic5
            // 
            this.pic5.Image = global::Ha_Noi_Tower.Properties.Resources.So5;
            this.pic5.Location = new System.Drawing.Point(463, 253);
            this.pic5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(154, 18);
            this.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic5.TabIndex = 7;
            this.pic5.TabStop = false;
            this.pic5.Tag = "5";
            this.pic5.Visible = false;
            this.pic5.Click += new System.EventHandler(this.picDisk_Click);
            // 
            // pic1
            // 
            this.pic1.Image = global::Ha_Noi_Tower.Properties.Resources.so1;
            this.pic1.Location = new System.Drawing.Point(71, 316);
            this.pic1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(154, 18);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic1.TabIndex = 6;
            this.pic1.TabStop = false;
            this.pic1.Tag = "1";
            this.pic1.Visible = false;
            this.pic1.Click += new System.EventHandler(this.picDisk_Click);
            // 
            // picRodC
            // 
            this.picRodC.Image = global::Ha_Noi_Tower.Properties.Resources.CỌC;
            this.picRodC.Location = new System.Drawing.Point(444, 159);
            this.picRodC.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picRodC.Name = "picRodC";
            this.picRodC.Size = new System.Drawing.Size(192, 213);
            this.picRodC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRodC.TabIndex = 4;
            this.picRodC.TabStop = false;
            this.picRodC.Click += new System.EventHandler(this.picRod_Click);
            // 
            // picRodB
            // 
            this.picRodB.Image = global::Ha_Noi_Tower.Properties.Resources.CỌC;
            this.picRodB.Location = new System.Drawing.Point(247, 159);
            this.picRodB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picRodB.Name = "picRodB";
            this.picRodB.Size = new System.Drawing.Size(192, 213);
            this.picRodB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRodB.TabIndex = 2;
            this.picRodB.TabStop = false;
            this.picRodB.Click += new System.EventHandler(this.picRod_Click);
            // 
            // picRodA
            // 
            this.picRodA.Image = global::Ha_Noi_Tower.Properties.Resources.CỌC;
            this.picRodA.Location = new System.Drawing.Point(51, 159);
            this.picRodA.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picRodA.Name = "picRodA";
            this.picRodA.Size = new System.Drawing.Size(192, 213);
            this.picRodA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRodA.TabIndex = 0;
            this.picRodA.TabStop = false;
            this.picRodA.Click += new System.EventHandler(this.picRod_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(301, 120);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 21;
            this.button1.Text = "Lời giải";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // lblMoveCountDisplay
            // 
            this.lblMoveCountDisplay.AutoSize = true;
            this.lblMoveCountDisplay.BackColor = System.Drawing.SystemColors.Info;
            this.lblMoveCountDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMoveCountDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveCountDisplay.Location = new System.Drawing.Point(632, 6);
            this.lblMoveCountDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoveCountDisplay.Name = "lblMoveCountDisplay";
            this.lblMoveCountDisplay.Size = new System.Drawing.Size(20, 22);
            this.lblMoveCountDisplay.TabIndex = 22;
            this.lblMoveCountDisplay.Text = "0";
            this.lblMoveCountDisplay.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(406, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "Số lần di chuyển ít nhất để giải:";
            this.label3.Click += new System.EventHandler(this.label3_Click_2);
            // 
            // lblBestMoveCount
            // 
            this.lblBestMoveCount.AutoSize = true;
            this.lblBestMoveCount.BackColor = System.Drawing.SystemColors.Info;
            this.lblBestMoveCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBestMoveCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestMoveCount.Location = new System.Drawing.Point(8, 64);
            this.lblBestMoveCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBestMoveCount.Name = "lblBestMoveCount";
            this.lblBestMoveCount.Size = new System.Drawing.Size(56, 22);
            this.lblBestMoveCount.TabIndex = 25;
            this.lblBestMoveCount.Text = "Kỷ lục:";
            this.lblBestMoveCount.Click += new System.EventHandler(this.lblBestMoveCount_Click);
            // 
            // THN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(659, 406);
            this.Controls.Add(this.lblBestMoveCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMoveCountDisplay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGiveup);
            this.Controls.Add(this.btnShowRule);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.label);
            this.Controls.Add(this.nudLevel);
            this.Controls.Add(this.lblMoveCount);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic8);
            this.Controls.Add(this.pic7);
            this.Controls.Add(this.pic6);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picRodC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picRodB);
            this.Controls.Add(this.A);
            this.Controls.Add(this.picRodA);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimizeBox = false;
            this.Name = "THN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRodC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRodB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRodA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picRodA;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picRodB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picRodC;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.PictureBox pic6;
        private System.Windows.Forms.PictureBox pic7;
        private System.Windows.Forms.PictureBox pic8;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrCountTime;
        private System.Windows.Forms.Label lblMoveCount;
        private System.Windows.Forms.NumericUpDown nudLevel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnShowRule;
        private System.Windows.Forms.Button btnGiveup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMoveCountDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBestMoveCount;
    }
}

