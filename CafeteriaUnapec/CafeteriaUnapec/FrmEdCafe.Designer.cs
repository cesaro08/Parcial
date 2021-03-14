namespace CafeteriaUnapec
{
    partial class FrmEdCafe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEdCafe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbEmpleado = new System.Windows.Forms.ComboBox();
            this.CheckActCafe = new System.Windows.Forms.CheckBox();
            this.TxtDesCafe = new System.Windows.Forms.TextBox();
            this.TxtIDcaf = new System.Windows.Forms.TextBox();
            this.CBCampus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GuardarCafe = new System.Windows.Forms.PictureBox();
            this.EliminarCafe = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GuardarCafe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EliminarCafe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbEmpleado);
            this.panel1.Controls.Add(this.CheckActCafe);
            this.panel1.Controls.Add(this.TxtDesCafe);
            this.panel1.Controls.Add(this.TxtIDcaf);
            this.panel1.Controls.Add(this.CBCampus);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 222);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbEmpleado
            // 
            this.cbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpleado.FormattingEnabled = true;
            this.cbEmpleado.Location = new System.Drawing.Point(98, 125);
            this.cbEmpleado.Name = "cbEmpleado";
            this.cbEmpleado.Size = new System.Drawing.Size(310, 21);
            this.cbEmpleado.TabIndex = 10;
            // 
            // CheckActCafe
            // 
            this.CheckActCafe.AutoSize = true;
            this.CheckActCafe.Location = new System.Drawing.Point(98, 171);
            this.CheckActCafe.Name = "CheckActCafe";
            this.CheckActCafe.Size = new System.Drawing.Size(15, 14);
            this.CheckActCafe.TabIndex = 9;
            this.CheckActCafe.UseVisualStyleBackColor = true;
            // 
            // TxtDesCafe
            // 
            this.TxtDesCafe.Location = new System.Drawing.Point(98, 91);
            this.TxtDesCafe.Name = "TxtDesCafe";
            this.TxtDesCafe.Size = new System.Drawing.Size(310, 20);
            this.TxtDesCafe.TabIndex = 7;
            // 
            // TxtIDcaf
            // 
            this.TxtIDcaf.Enabled = false;
            this.TxtIDcaf.Location = new System.Drawing.Point(98, 15);
            this.TxtIDcaf.Name = "TxtIDcaf";
            this.TxtIDcaf.Size = new System.Drawing.Size(310, 20);
            this.TxtIDcaf.TabIndex = 6;
            this.TxtIDcaf.Text = "0";
            // 
            // CBCampus
            // 
            this.CBCampus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCampus.FormattingEnabled = true;
            this.CBCampus.Location = new System.Drawing.Point(98, 52);
            this.CBCampus.Name = "CBCampus";
            this.CBCampus.Size = new System.Drawing.Size(310, 21);
            this.CBCampus.TabIndex = 5;
            this.CBCampus.SelectedIndexChanged += new System.EventHandler(this.CBCampus_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Activo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Encargado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Campus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // GuardarCafe
            // 
            this.GuardarCafe.Image = ((System.Drawing.Image)(resources.GetObject("GuardarCafe.Image")));
            this.GuardarCafe.Location = new System.Drawing.Point(281, 240);
            this.GuardarCafe.Name = "GuardarCafe";
            this.GuardarCafe.Size = new System.Drawing.Size(100, 50);
            this.GuardarCafe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GuardarCafe.TabIndex = 2;
            this.GuardarCafe.TabStop = false;
            this.GuardarCafe.Click += new System.EventHandler(this.GuardarCafe_Click);
            // 
            // EliminarCafe
            // 
            this.EliminarCafe.Image = ((System.Drawing.Image)(resources.GetObject("EliminarCafe.Image")));
            this.EliminarCafe.Location = new System.Drawing.Point(397, 240);
            this.EliminarCafe.Name = "EliminarCafe";
            this.EliminarCafe.Size = new System.Drawing.Size(100, 50);
            this.EliminarCafe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EliminarCafe.TabIndex = 3;
            this.EliminarCafe.TabStop = false;
            this.EliminarCafe.Click += new System.EventHandler(this.EliminarCafe_Click);
            // 
            // FrmEdCafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 294);
            this.Controls.Add(this.EliminarCafe);
            this.Controls.Add(this.GuardarCafe);
            this.Controls.Add(this.panel1);
            this.Name = "FrmEdCafe";
            this.Text = "Edición ";
            this.Load += new System.EventHandler(this.FrmEdCafe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GuardarCafe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EliminarCafe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CheckActCafe;
        private System.Windows.Forms.TextBox TxtDesCafe;
        private System.Windows.Forms.TextBox TxtIDcaf;
        private System.Windows.Forms.ComboBox CBCampus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox GuardarCafe;
        private System.Windows.Forms.PictureBox EliminarCafe;
        private System.Windows.Forms.ComboBox cbEmpleado;
    }
}