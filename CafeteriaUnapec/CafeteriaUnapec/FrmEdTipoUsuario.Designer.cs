namespace CafeteriaUnapec
{
    partial class FrmEdTipoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEdTipoUsuario));
            this.EliminarCafe = new System.Windows.Forms.PictureBox();
            this.GuardarCafe = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CheckActTipo = new System.Windows.Forms.CheckBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EliminarCafe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuardarCafe)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EliminarCafe
            // 
            this.EliminarCafe.Image = ((System.Drawing.Image)(resources.GetObject("EliminarCafe.Image")));
            this.EliminarCafe.Location = new System.Drawing.Point(364, 163);
            this.EliminarCafe.Name = "EliminarCafe";
            this.EliminarCafe.Size = new System.Drawing.Size(100, 50);
            this.EliminarCafe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EliminarCafe.TabIndex = 6;
            this.EliminarCafe.TabStop = false;
            this.EliminarCafe.Click += new System.EventHandler(this.EliminarCafe_Click);
            // 
            // GuardarCafe
            // 
            this.GuardarCafe.Image = ((System.Drawing.Image)(resources.GetObject("GuardarCafe.Image")));
            this.GuardarCafe.Location = new System.Drawing.Point(248, 163);
            this.GuardarCafe.Name = "GuardarCafe";
            this.GuardarCafe.Size = new System.Drawing.Size(100, 50);
            this.GuardarCafe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GuardarCafe.TabIndex = 5;
            this.GuardarCafe.TabStop = false;
            this.GuardarCafe.Click += new System.EventHandler(this.GuardarCafe_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CheckActTipo);
            this.panel1.Controls.Add(this.TxtDescripcion);
            this.panel1.Controls.Add(this.TxtID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 133);
            this.panel1.TabIndex = 4;
            // 
            // CheckActTipo
            // 
            this.CheckActTipo.AutoSize = true;
            this.CheckActTipo.Location = new System.Drawing.Point(98, 101);
            this.CheckActTipo.Name = "CheckActTipo";
            this.CheckActTipo.Size = new System.Drawing.Size(15, 14);
            this.CheckActTipo.TabIndex = 9;
            this.CheckActTipo.UseVisualStyleBackColor = true;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(98, 55);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(310, 20);
            this.TxtDescripcion.TabIndex = 7;
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(98, 15);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(310, 20);
            this.TxtID.TabIndex = 6;
            this.TxtID.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Activo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción";
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
            // FrmEdTipoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 249);
            this.Controls.Add(this.EliminarCafe);
            this.Controls.Add(this.GuardarCafe);
            this.Controls.Add(this.panel1);
            this.Name = "FrmEdTipoUsuario";
            this.Text = "FrmEdTipoUsuario";
            this.Load += new System.EventHandler(this.FrmEdTipoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EliminarCafe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuardarCafe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox EliminarCafe;
        private System.Windows.Forms.PictureBox GuardarCafe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox CheckActTipo;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}