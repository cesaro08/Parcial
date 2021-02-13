namespace CafeteriaUnapec
{
    partial class FrmArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArticulos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtBusq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuCafe = new System.Windows.Forms.PictureBox();
            this.BtnAgCafe = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGVArticulos = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuCafe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgCafe)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(637, 38);
            this.panel3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(261, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ARTICULOS";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TxtBusq);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnBuCafe);
            this.panel1.Controls.Add(this.BtnAgCafe);
            this.panel1.Location = new System.Drawing.Point(8, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 69);
            this.panel1.TabIndex = 5;
            // 
            // TxtBusq
            // 
            this.TxtBusq.Location = new System.Drawing.Point(94, 25);
            this.TxtBusq.Name = "TxtBusq";
            this.TxtBusq.Size = new System.Drawing.Size(386, 20);
            this.TxtBusq.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Busqueda";
            // 
            // BtnBuCafe
            // 
            this.BtnBuCafe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuCafe.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuCafe.Image")));
            this.BtnBuCafe.Location = new System.Drawing.Point(502, 9);
            this.BtnBuCafe.Name = "BtnBuCafe";
            this.BtnBuCafe.Size = new System.Drawing.Size(50, 50);
            this.BtnBuCafe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnBuCafe.TabIndex = 1;
            this.BtnBuCafe.TabStop = false;
            this.BtnBuCafe.Click += new System.EventHandler(this.BtnBuCafe_Click);
            // 
            // BtnAgCafe
            // 
            this.BtnAgCafe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgCafe.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgCafe.Image")));
            this.BtnAgCafe.Location = new System.Drawing.Point(560, 9);
            this.BtnAgCafe.Name = "BtnAgCafe";
            this.BtnAgCafe.Size = new System.Drawing.Size(56, 50);
            this.BtnAgCafe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnAgCafe.TabIndex = 0;
            this.BtnAgCafe.TabStop = false;
            this.BtnAgCafe.Click += new System.EventHandler(this.BtnAgCafe_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.DGVArticulos);
            this.panel2.Location = new System.Drawing.Point(7, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(622, 343);
            this.panel2.TabIndex = 6;
            // 
            // DGVArticulos
            // 
            this.DGVArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVArticulos.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVArticulos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVArticulos.EnableHeadersVisualStyles = false;
            this.DGVArticulos.Location = new System.Drawing.Point(2, 3);
            this.DGVArticulos.Name = "DGVArticulos";
            this.DGVArticulos.Size = new System.Drawing.Size(614, 335);
            this.DGVArticulos.TabIndex = 1;
            this.DGVArticulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVArticulos_CellDoubleClick);
            // 
            // FrmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 501);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmArticulos";
            this.Text = "FrmArticulos";
            this.Load += new System.EventHandler(this.FrmArticulos_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuCafe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgCafe)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVArticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtBusq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BtnBuCafe;
        private System.Windows.Forms.PictureBox BtnAgCafe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGVArticulos;
    }
}