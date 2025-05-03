namespace QLTT.Forms
{
    partial class frmLich
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLich));
            flpLich = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblThang = new Label();
            pcLeft = new PictureBox();
            pcRight = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcRight).BeginInit();
            SuspendLayout();
            // 
            // flpLich
            // 
            flpLich.AutoScroll = true;
            flpLich.Location = new Point(4, 112);
            flpLich.Name = "flpLich";
            flpLich.Size = new Size(767, 389);
            flpLich.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(22, 74);
            label1.Name = "label1";
            label1.Size = new Size(73, 19);
            label1.TabIndex = 1;
            label1.Text = "Chủ nhật";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(138, 74);
            label2.Name = "label2";
            label2.Size = new Size(64, 19);
            label2.TabIndex = 2;
            label2.Text = "Thứ hai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(251, 74);
            label3.Name = "label3";
            label3.Size = new Size(59, 19);
            label3.TabIndex = 3;
            label3.Text = "Thứ ba";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(355, 74);
            label4.Name = "label4";
            label4.Size = new Size(58, 19);
            label4.TabIndex = 4;
            label4.Text = "Thứ tư";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(455, 74);
            label5.Name = "label5";
            label5.Size = new Size(73, 19);
            label5.TabIndex = 5;
            label5.Text = "Thứ năm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(573, 74);
            label6.Name = "label6";
            label6.Size = new Size(65, 19);
            label6.TabIndex = 6;
            label6.Text = "Thứ sáu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(679, 74);
            label7.Name = "label7";
            label7.Size = new Size(67, 19);
            label7.TabIndex = 7;
            label7.Text = "Thứ bảy";
            // 
            // lblThang
            // 
            lblThang.AutoSize = true;
            lblThang.Font = new Font("Constantia", 20.25F, FontStyle.Bold);
            lblThang.Location = new Point(80, 12);
            lblThang.Name = "lblThang";
            lblThang.Size = new Size(112, 33);
            lblThang.TabIndex = 9;
            lblThang.Text = "THÁNG";
            // 
            // pcLeft
            // 
            pcLeft.Image = (Image)resources.GetObject("pcLeft.Image");
            pcLeft.Location = new Point(248, 17);
            pcLeft.Name = "pcLeft";
            pcLeft.Size = new Size(28, 28);
            pcLeft.SizeMode = PictureBoxSizeMode.StretchImage;
            pcLeft.TabIndex = 10;
            pcLeft.TabStop = false;
            pcLeft.Click += pcLeft_Click;
            // 
            // pcRight
            // 
            pcRight.Image = (Image)resources.GetObject("pcRight.Image");
            pcRight.Location = new Point(282, 17);
            pcRight.Name = "pcRight";
            pcRight.Size = new Size(28, 28);
            pcRight.SizeMode = PictureBoxSizeMode.StretchImage;
            pcRight.TabIndex = 11;
            pcRight.TabStop = false;
            pcRight.Click += pcRight_Click;
            // 
            // frmLich
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 503);
            Controls.Add(pcRight);
            Controls.Add(pcLeft);
            Controls.Add(lblThang);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flpLich);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLich";
            Text = "frmLich";
            ((System.ComponentModel.ISupportInitialize)pcLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcRight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpLich;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblThang;
        private PictureBox pcLeft;
        private PictureBox pcRight;
    }
}