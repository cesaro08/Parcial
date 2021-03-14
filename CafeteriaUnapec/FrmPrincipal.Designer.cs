using System;
using System.Windows.Forms;

namespace CafeteriaUnapec
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.btCerrar = new System.Windows.Forms.Button();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.BtnUsuarios = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnCafeteria = new System.Windows.Forms.Button();
            this.BtnFact = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.BtnProvee = new System.Windows.Forms.Button();
            this.BtnMarcas = new System.Windows.Forms.Button();
            this.BtnEmpleados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnUsers = new System.Windows.Forms.Button();
            this.BtnTipoUser = new System.Windows.Forms.Button();
            this.BtnUni = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PnlSubF = new System.Windows.Forms.Panel();
            this.PnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMenu
            // 
            this.PnlMenu.BackColor = System.Drawing.Color.LightSlateGray;
            this.PnlMenu.Controls.Add(this.btCerrar);
            this.PnlMenu.Controls.Add(this.lbUsuario);
            this.PnlMenu.Controls.Add(this.pictureBox5);
            this.PnlMenu.Controls.Add(this.BtnUsuarios);
            this.PnlMenu.Controls.Add(this.pictureBox2);
            this.PnlMenu.Controls.Add(this.BtnCafeteria);
            this.PnlMenu.Controls.Add(this.BtnFact);
            this.PnlMenu.Controls.Add(this.pictureBox9);
            this.PnlMenu.Controls.Add(this.pictureBox8);
            this.PnlMenu.Controls.Add(this.pictureBox4);
            this.PnlMenu.Controls.Add(this.pictureBox3);
            this.PnlMenu.Controls.Add(this.pictureBox7);
            this.PnlMenu.Controls.Add(this.pictureBox6);
            this.PnlMenu.Controls.Add(this.BtnProvee);
            this.PnlMenu.Controls.Add(this.BtnMarcas);
            this.PnlMenu.Controls.Add(this.BtnEmpleados);
            this.PnlMenu.Controls.Add(this.label1);
            this.PnlMenu.Controls.Add(this.BtnUsers);
            this.PnlMenu.Controls.Add(this.BtnTipoUser);
            this.PnlMenu.Controls.Add(this.BtnUni);
            this.PnlMenu.Controls.Add(this.pictureBox1);
            this.PnlMenu.Controls.Add(this.panel2);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(188, 588);
            this.PnlMenu.TabIndex = 0;
            this.PnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlMenu_Paint);
            // 
            // btCerrar
            // 
            this.btCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCerrar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCerrar.Location = new System.Drawing.Point(0, 524);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(188, 40);
            this.btCerrar.TabIndex = 20;
            this.btCerrar.Text = "Cerrar sesion";
            this.btCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbUsuario.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbUsuario.Location = new System.Drawing.Point(27, 132);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(10, 13);
            this.lbUsuario.TabIndex = 19;
            this.lbUsuario.Text = ".";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(7, 315);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 31);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuarios.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnUsuarios.Location = new System.Drawing.Point(0, 311);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Size = new System.Drawing.Size(188, 40);
            this.BtnUsuarios.TabIndex = 5;
            this.BtnUsuarios.Text = "Usuarios";
            this.BtnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUsuarios.UseVisualStyleBackColor = true;
            this.BtnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 232);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // BtnCafeteria
            // 
            this.BtnCafeteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCafeteria.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCafeteria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCafeteria.Location = new System.Drawing.Point(1, 228);
            this.BtnCafeteria.Name = "BtnCafeteria";
            this.BtnCafeteria.Size = new System.Drawing.Size(188, 40);
            this.BtnCafeteria.TabIndex = 3;
            this.BtnCafeteria.Text = "Cafeterias";
            this.BtnCafeteria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCafeteria.UseVisualStyleBackColor = true;
            this.BtnCafeteria.Click += new System.EventHandler(this.BtnCafeteria_Click);
            // 
            // BtnFact
            // 
            this.BtnFact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFact.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFact.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnFact.Location = new System.Drawing.Point(0, 478);
            this.BtnFact.Name = "BtnFact";
            this.BtnFact.Size = new System.Drawing.Size(188, 40);
            this.BtnFact.TabIndex = 16;
            this.BtnFact.Text = "Facturaciones";
            this.BtnFact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFact.UseVisualStyleBackColor = true;
            this.BtnFact.Click += new System.EventHandler(this.BtnFact_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(7, 437);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(31, 36);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 2;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(7, 398);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(30, 31);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 15;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(7, 274);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(4, 151);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(7, 195);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 31);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 1;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(6, 357);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 31);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // BtnProvee
            // 
            this.BtnProvee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProvee.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProvee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnProvee.Location = new System.Drawing.Point(0, 435);
            this.BtnProvee.Name = "BtnProvee";
            this.BtnProvee.Size = new System.Drawing.Size(188, 40);
            this.BtnProvee.TabIndex = 9;
            this.BtnProvee.Text = "Proveedores";
            this.BtnProvee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnProvee.UseVisualStyleBackColor = true;
            this.BtnProvee.Click += new System.EventHandler(this.BtnProvee_Click);
            // 
            // BtnMarcas
            // 
            this.BtnMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMarcas.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMarcas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnMarcas.Location = new System.Drawing.Point(0, 394);
            this.BtnMarcas.Name = "BtnMarcas";
            this.BtnMarcas.Size = new System.Drawing.Size(188, 40);
            this.BtnMarcas.TabIndex = 8;
            this.BtnMarcas.Text = "Marcas";
            this.BtnMarcas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMarcas.UseVisualStyleBackColor = true;
            this.BtnMarcas.Click += new System.EventHandler(this.BtnMarcas_Click);
            // 
            // BtnEmpleados
            // 
            this.BtnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpleados.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpleados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEmpleados.Location = new System.Drawing.Point(0, 190);
            this.BtnEmpleados.Name = "BtnEmpleados";
            this.BtnEmpleados.Size = new System.Drawing.Size(188, 40);
            this.BtnEmpleados.TabIndex = 7;
            this.BtnEmpleados.Text = "Empleados";
            this.BtnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEmpleados.UseVisualStyleBackColor = true;
            this.BtnEmpleados.Click += new System.EventHandler(this.BtnEmpleados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(27, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAFETERIA DE UNAPEC";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // BtnUsers
            // 
            this.BtnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsers.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnUsers.Location = new System.Drawing.Point(-1, 352);
            this.BtnUsers.Name = "BtnUsers";
            this.BtnUsers.Size = new System.Drawing.Size(188, 40);
            this.BtnUsers.TabIndex = 6;
            this.BtnUsers.Text = "Artículos";
            this.BtnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUsers.UseVisualStyleBackColor = true;
            this.BtnUsers.Click += new System.EventHandler(this.BtnUsers_Click);
            // 
            // BtnTipoUser
            // 
            this.BtnTipoUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTipoUser.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTipoUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnTipoUser.Location = new System.Drawing.Point(0, 269);
            this.BtnTipoUser.Name = "BtnTipoUser";
            this.BtnTipoUser.Size = new System.Drawing.Size(188, 40);
            this.BtnTipoUser.TabIndex = 4;
            this.BtnTipoUser.Text = "Tipo Usuarios";
            this.BtnTipoUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnTipoUser.UseVisualStyleBackColor = true;
            this.BtnTipoUser.Click += new System.EventHandler(this.BtnTipoUser_Click);
            // 
            // BtnUni
            // 
            this.BtnUni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUni.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnUni.Location = new System.Drawing.Point(-1, 149);
            this.BtnUni.Name = "BtnUni";
            this.BtnUni.Size = new System.Drawing.Size(188, 40);
            this.BtnUni.TabIndex = 4;
            this.BtnUni.Text = "Campus";
            this.BtnUni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUni.UseVisualStyleBackColor = true;
            this.BtnUni.Click += new System.EventHandler(this.BtnUni_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(194, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 360);
            this.panel2.TabIndex = 1;
            // 
            // PnlSubF
            // 
            this.PnlSubF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PnlSubF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlSubF.Location = new System.Drawing.Point(188, 0);
            this.PnlSubF.Name = "PnlSubF";
            this.PnlSubF.Size = new System.Drawing.Size(683, 588);
            this.PnlSubF.TabIndex = 2;
            this.PnlSubF.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlSubF_Paint);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(871, 588);
            this.Controls.Add(this.PnlSubF);
            this.Controls.Add(this.PnlMenu);
            this.Name = "FrmPrincipal";
            this.Text = "Cafeteria de Unapec";
            this.Activated += new System.EventHandler(this.FrmPrincipal_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PnlMenu.ResumeLayout(false);
            this.PnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //if (!useractivo.Id_TipoUser.Equals(2))
            //{

                
            //    rol = true;

            //}
            //else rol = false;
            //MessageBox.Show("" + rol);
            lbUsuario.Text = useractivo.Nombre_Usuario.ToString();
            AbrirForm(new FrmCAFETERIA());
        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PnlSubF;
        private System.Windows.Forms.Button BtnUsers;
        private System.Windows.Forms.Button BtnUsuarios;
        private System.Windows.Forms.Button BtnTipoUser;
        private System.Windows.Forms.Button BtnUni;
        private System.Windows.Forms.Button BtnCafeteria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEmpleados;
        private System.Windows.Forms.Button BtnProvee;
        private System.Windows.Forms.Button BtnMarcas;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button BtnFact;
        private System.Windows.Forms.Label lbUsuario;
        private Button btCerrar;
    }
}

