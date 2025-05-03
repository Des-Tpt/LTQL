namespace QLTT.Forms
{
    partial class ucNgay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblSuKien = new Label();
            lblNgay = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblSuKien);
            panel1.Controls.Add(lblNgay);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(103, 70);
            panel1.TabIndex = 0;
            // 
            // lblSuKien
            // 
            lblSuKien.Location = new Point(3, 34);
            lblSuKien.Name = "lblSuKien";
            lblSuKien.Size = new Size(97, 36);
            lblSuKien.TabIndex = 1;
            lblSuKien.Text = "Sự kiện giao hữu Việt - Nhật";
            // 
            // lblNgay
            // 
            lblNgay.AutoSize = true;
            lblNgay.Location = new Point(78, 6);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(19, 15);
            lblNgay.TabIndex = 0;
            lblNgay.Text = "00";
            // 
            // ucNgay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ucNgay";
            Size = new Size(103, 70);
            Load += ucNgay_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblNgay;
        private Label lblSuKien;
    }
}
