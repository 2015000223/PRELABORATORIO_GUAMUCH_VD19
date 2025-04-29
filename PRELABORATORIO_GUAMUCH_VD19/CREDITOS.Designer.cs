namespace PRELABORATORIO_GUAMUCH_VD19
{
    partial class CREDITOS
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
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(222, 32);
            label1.Name = "label1";
            label1.Size = new Size(232, 32);
            label1.TabIndex = 0;
            label1.Text = "PRE LABORATORIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(119, 79);
            label2.Name = "label2";
            label2.Size = new Size(463, 32);
            label2.TabIndex = 1;
            label2.Text = "PRINCIPE DAVID GUAMUCH GRAMAJO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(222, 130);
            label3.Name = "label3";
            label3.Size = new Size(234, 32);
            label3.TabIndex = 2;
            label3.Text = "V BACHILLERATO D";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Me;
            pictureBox1.Location = new Point(184, 185);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(314, 237);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(279, 453);
            label4.Name = "label4";
            label4.Size = new Size(148, 32);
            label4.TabIndex = 4;
            label4.Text = "28/04/2024";
            // 
            // CREDITOS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 503);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CREDITOS";
            Text = "CREDITOS";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
    }
}