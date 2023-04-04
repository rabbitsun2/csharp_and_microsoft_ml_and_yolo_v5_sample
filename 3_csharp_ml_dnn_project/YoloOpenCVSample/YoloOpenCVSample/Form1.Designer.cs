namespace YoloOpenCVSample
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            videoBox = new PictureBox();
            btnStart = new Button();
            btnStop = new Button();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            btnCameraOff = new Button();
            btnCameraOn = new Button();
            label2 = new Label();
            cameraBox = new PictureBox();
            tabPage3 = new TabPage();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            tabPage4 = new TabPage();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            tabPage5 = new TabPage();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            tabPage6 = new TabPage();
            pictureBox7 = new PictureBox();
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            기능ToolStripMenuItem = new ToolStripMenuItem();
            정보ToolStripMenuItem1 = new ToolStripMenuItem();
            종료ToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)videoBox).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cameraBox).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // videoBox
            // 
            videoBox.BorderStyle = BorderStyle.FixedSingle;
            videoBox.Location = new Point(24, 50);
            videoBox.Name = "videoBox";
            videoBox.Size = new Size(640, 480);
            videoBox.TabIndex = 0;
            videoBox.TabStop = false;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(24, 543);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(136, 29);
            btnStart.TabIndex = 1;
            btnStart.Text = "Play";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(179, 543);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(136, 29);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 18);
            label1.Name = "label1";
            label1.Size = new Size(169, 20);
            label1.TabIndex = 3;
            label1.Text = "재활용품 처리장 동영상";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Location = new Point(28, 74);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1181, 630);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(videoBox);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnStart);
            tabPage1.Controls.Add(btnStop);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1173, 597);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "실험 영상";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.BorderStyle = BorderStyle.FixedSingle;
            tabPage2.Controls.Add(btnCameraOff);
            tabPage2.Controls.Add(btnCameraOn);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(cameraBox);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1173, 597);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "카메라";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCameraOff
            // 
            btnCameraOff.Location = new Point(170, 545);
            btnCameraOff.Name = "btnCameraOff";
            btnCameraOff.Size = new Size(130, 29);
            btnCameraOff.TabIndex = 6;
            btnCameraOff.Text = "Camera Off";
            btnCameraOff.UseVisualStyleBackColor = true;
            btnCameraOff.Click += btnCameraOff_Click;
            // 
            // btnCameraOn
            // 
            btnCameraOn.Location = new Point(22, 545);
            btnCameraOn.Name = "btnCameraOn";
            btnCameraOn.Size = new Size(130, 29);
            btnCameraOn.TabIndex = 5;
            btnCameraOn.Text = "Camera On";
            btnCameraOn.UseVisualStyleBackColor = true;
            btnCameraOn.Click += btnCameraOn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 17);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 4;
            label2.Text = "카메라";
            // 
            // cameraBox
            // 
            cameraBox.BorderStyle = BorderStyle.FixedSingle;
            cameraBox.Location = new Point(22, 50);
            cameraBox.Name = "cameraBox";
            cameraBox.Size = new Size(640, 480);
            cameraBox.TabIndex = 0;
            cameraBox.TabStop = false;
            // 
            // tabPage3
            // 
            tabPage3.BorderStyle = BorderStyle.FixedSingle;
            tabPage3.Controls.Add(pictureBox2);
            tabPage3.Controls.Add(pictureBox1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1173, 597);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "사진1";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(593, 64);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(568, 456);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(11, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(568, 456);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabPage4
            // 
            tabPage4.BorderStyle = BorderStyle.FixedSingle;
            tabPage4.Controls.Add(pictureBox4);
            tabPage4.Controls.Add(pictureBox3);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1173, 597);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "사진2";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Location = new Point(591, 62);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(568, 456);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(12, 62);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(568, 456);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // tabPage5
            // 
            tabPage5.BorderStyle = BorderStyle.FixedSingle;
            tabPage5.Controls.Add(pictureBox6);
            tabPage5.Controls.Add(pictureBox5);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1173, 597);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "사진3";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            pictureBox6.Location = new Point(592, 75);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(568, 456);
            pictureBox6.TabIndex = 2;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Location = new Point(13, 75);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(568, 456);
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // tabPage6
            // 
            tabPage6.BorderStyle = BorderStyle.FixedSingle;
            tabPage6.Controls.Add(pictureBox7);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(1173, 597);
            tabPage6.TabIndex = 6;
            tabPage6.Text = "사진4";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // pictureBox7
            // 
            pictureBox7.BorderStyle = BorderStyle.FixedSingle;
            pictureBox7.Location = new Point(16, 66);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(568, 456);
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 28);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1238, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { 기능ToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1238, 28);
            menuStrip2.TabIndex = 6;
            menuStrip2.Text = "menuStrip2";
            // 
            // 기능ToolStripMenuItem
            // 
            기능ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 정보ToolStripMenuItem1, 종료ToolStripMenuItem });
            기능ToolStripMenuItem.Name = "기능ToolStripMenuItem";
            기능ToolStripMenuItem.Size = new Size(53, 24);
            기능ToolStripMenuItem.Text = "기능";
            // 
            // 정보ToolStripMenuItem1
            // 
            정보ToolStripMenuItem1.Name = "정보ToolStripMenuItem1";
            정보ToolStripMenuItem1.Size = new Size(224, 26);
            정보ToolStripMenuItem1.Text = "정보";
            정보ToolStripMenuItem1.Click += 정보ToolStripMenuItem1_Click;
            // 
            // 종료ToolStripMenuItem
            // 
            종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            종료ToolStripMenuItem.Size = new Size(224, 26);
            종료ToolStripMenuItem.Text = "종료";
            종료ToolStripMenuItem.Click += 종료ToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 734);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)videoBox).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cameraBox).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox videoBox;
        private Button btnStart;
        private Button btnStop;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private PictureBox cameraBox;
        private Label label2;
        private Button btnCameraOff;
        private Button btnCameraOn;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox7;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem 기능ToolStripMenuItem;
        private ToolStripMenuItem 정보ToolStripMenuItem1;
        private ToolStripMenuItem 종료ToolStripMenuItem;
    }
}