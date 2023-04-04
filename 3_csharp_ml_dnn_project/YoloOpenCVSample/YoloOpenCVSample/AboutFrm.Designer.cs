namespace YoloOpenCVSample
{
    partial class AboutFrm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 100);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 0;
            label1.Text = "정도윤(Doyoon Jung)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 50);
            label2.Name = "label2";
            label2.Size = new Size(526, 31);
            label2.TabIndex = 1;
            label2.Text = "Yolo v5 with Roboflow (Garbage Collection v3)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 128);
            label3.Name = "label3";
            label3.Size = new Size(166, 20);
            label3.TabIndex = 2;
            label3.Text = "rabbitsun2@gmail.com";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 167);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 3;
            label4.Text = "2023-04-04(화)";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(28, 244);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(338, 20);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://github.com/ultralytics/yolov5/issues/4484";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(28, 276);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(288, 20);
            linkLabel2.TabIndex = 5;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "https://github.com/singetta/OnnxSample";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(28, 311);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(310, 20);
            linkLabel3.TabIndex = 6;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "https://076923.github.io/posts/C-opencv4-5/";
            // 
            // AboutFrm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 412);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AboutFrm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AboutFrm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
    }
}