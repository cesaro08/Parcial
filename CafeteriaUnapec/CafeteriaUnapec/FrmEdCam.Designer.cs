namespace CafeteriaUnapec
{
    partial class FrmEdCam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEdCam));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBCam = new System.Windows.Forms.CheckBox();
            this.TxtDesCamp = new System.Windows.Forms.TextBox();
            this.TxtIDCam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnEliminarCam = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEliminarCam)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CBCam);
            this.panel1.Controls.Add(this.TxtDesCamp);
            this.panel1.Controls.Add(this.TxtIDCam);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 162);
            this.panel1.TabIndex = 0;
            // 
            // CBCam
            // 
            this.CBCam.AutoSize = true;
            this.CBCam.Location = new System.Drawing.Point(115, 111);
            this.CBCam.Name = "CBCam";
            this.CBCam.Size = new System.Drawing.Size(15, 14);
            this.CBCam.TabIndex = 5;
            this.CBCam.UseVisualStyleBackColor = true;
            // 
            // TxtDesCamp
            // 
            this.TxtDesCamp.Location = new System.Drawing.Point(115, 67);
            this.TxtDesCamp.Name = "TxtDesCamp";
            this.TxtDesCamp.Size = new System.Drawing.Size(324, 20);
            this.TxtDesCamp.TabIndex = 4;
            // 
            // TxtIDCam
            // 
            this.TxtIDCam.Enabled = false;
            this.TxtIDCam.Location = new System.Drawing.Point(115, 24);
            this.TxtIDCam.Name = "TxtIDCam";
            this.TxtIDCam.Size = new System.Drawing.Size(69, 20);
            this.TxtIDCam.TabIndex = 3;
            this.TxtIDCam.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Location = new System.Drawing.Point(20, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Activo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(284, 180);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(100, 50);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 1;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // BtnEliminarCam
            // 
            this.BtnEliminarCam.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminarCam.Image")));
            this.BtnEliminarCam.Location = new System.Drawing.Point(401, 180);
            this.BtnEliminarCam.Name = "BtnEliminarCam";
            this.BtnEliminarCam.Size = new System.Drawing.Size(100, 50);
            this.BtnEliminarCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnEliminarCam.TabIndex = 2;
            this.BtnEliminarCam.TabStop = false;
            this.BtnEliminarCam.Click += new System.EventHandler(this.BtnEliminarCam_Click);
            // 
            // FrmEdCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 234);
            this.Controls.Add(this.BtnEliminarCam);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmEdCam";
            this.Text = "FrmEdCaf";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmEdCam_FormClosed);
            this.Load += new System.EventHandler(this.FrmEdCam_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEliminarCam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox CBCam;
        private System.Windows.Forms.TextBox TxtDesCamp;
        private System.Windows.Forms.TextBox TxtIDCam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.PictureBox BtnEliminarCam;
    }
}