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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 87);
            label1.Name = "label1";
            label1.Size = new Size(193, 20);
            label1.TabIndex = 0;
            label1.Text = "제작: 정도윤(Doyoon Jung)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 148);
            label3.Name = "label3";
            label3.Size = new Size(166, 20);
            label3.TabIndex = 2;
            label3.Text = "rabbitsun2@gmail.com";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 168);
            label4.Name = "label4";
            label4.Size = new Size(178, 20);
            label4.TabIndex = 3;
            label4.Text = "작성일자: 2023-04-05(수)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(20, 50);
            label5.Name = "label5";
            label5.Size = new Size(571, 28);
            label5.TabIndex = 7;
            label5.Text = "실험 - Yolo v5 and OpenCVSharp4, Microsoft ML, ML.DNN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 50);
            label2.Name = "label2";
            label2.Size = new Size(0, 31);
            label2.TabIndex = 1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(20, 213);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(529, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://github.com/rabbitsun2/csharp_and_microsoft_ml_and_yolo_v5_sample";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 108);
            label6.Name = "label6";
            label6.Size = new Size(134, 20);
            label6.TabIndex = 9;
            label6.Text = "호남대학교 대학원";
            // 
            // AboutFrm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 267);
            Controls.Add(label6);
            Controls.Add(linkLabel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutFrm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AboutFrm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label2;
        private LinkLabel linkLabel1;
        private Label label6;
    }
}