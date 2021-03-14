namespace CafeteriaUnapec
{
    partial class FrmEdUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEdUsuario));
            this.EliminarUsuario = new System.Windows.Forms.PictureBox();
            this.GuardarUsuario = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.CheckActivo = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCedulaUsuario = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtIDUsuario = new System.Windows.Forms.TextBox();
            this.CBTipoUsuario = new System.Windows.Forms.ComboBox();
            this.tipousuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EliminarUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuardarUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipousuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EliminarUsuario
            // 
            this.EliminarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("EliminarUsuario.Image")));
            this.EliminarUsuario.Location = new System.Drawing.Point(373, 352);
            this.EliminarUsuario.Name = "EliminarUsuario";
            this.EliminarUsuario.Size = new System.Drawing.Size(100, 50);
            this.EliminarUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EliminarUsuario.TabIndex = 6;
            this.EliminarUsuario.TabStop = false;
            this.EliminarUsuario.Click += new System.EventHandler(this.EliminarUsuario_Click);
            // 
            // GuardarUsuario
            // 
            this.GuardarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("GuardarUsuario.Image")));
            this.GuardarUsuario.Location = new System.Drawing.Point(257, 352);
            this.GuardarUsuario.Name = "GuardarUsuario";
            this.GuardarUsuario.Size = new System.Drawing.Size(100, 50);
            this.GuardarUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GuardarUsuario.TabIndex = 5;
            this.GuardarUsuario.TabStop = false;
            this.GuardarUsuario.Click += new System.EventHandler(this.GuardarUsuario_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtContraseña);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dtFecha);
            this.panel1.Controls.Add(this.CheckActivo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtCredito);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtCedulaUsuario);
            this.panel1.Controls.Add(this.txtNombreUsuario);
            this.panel1.Controls.Add(this.txtIDUsuario);
            this.panel1.Controls.Add(this.CBTipoUsuario);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 334);
            this.panel1.TabIndex = 4;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(124, 129);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(310, 20);
            this.txtContraseña.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(124, 89);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(310, 20);
            this.txtUsuario.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Usuario";
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(124, 276);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 14;
            // 
            // CheckActivo
            // 
            this.CheckActivo.AutoSize = true;
            this.CheckActivo.Location = new System.Drawing.Point(232, 304);
            this.CheckActivo.Name = "CheckActivo";
            this.CheckActivo.Size = new System.Drawing.Size(15, 14);
            this.CheckActivo.TabIndex = 13;
            this.CheckActivo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Activo";
            // 
            // txtCredito
            // 
            this.txtCredito.Location = new System.Drawing.Point(124, 237);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(310, 20);
            this.txtCredito.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Limite de credito";
            // 
            // txtCedulaUsuario
            // 
            this.txtCedulaUsuario.Location = new System.Drawing.Point(124, 167);
            this.txtCedulaUsuario.Name = "txtCedulaUsuario";
            this.txtCedulaUsuario.Size = new System.Drawing.Size(310, 20);
            this.txtCedulaUsuario.TabIndex = 8;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(124, 53);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(310, 20);
            this.txtNombreUsuario.TabIndex = 7;
            // 
            // txtIDUsuario
            // 
            this.txtIDUsuario.Enabled = false;
            this.txtIDUsuario.Location = new System.Drawing.Point(124, 16);
            this.txtIDUsuario.Name = "txtIDUsuario";
            this.txtIDUsuario.Size = new System.Drawing.Size(310, 20);
            this.txtIDUsuario.TabIndex = 6;
            this.txtIDUsuario.Text = "0";
            // 
            // CBTipoUsuario
            // 
            this.CBTipoUsuario.DataSource = this.tipousuariosBindingSource;
            this.CBTipoUsuario.DisplayMember = "Descripcion";
            this.CBTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTipoUsuario.FormattingEnabled = true;
            this.CBTipoUsuario.Location = new System.Drawing.Point(124, 203);
            this.CBTipoUsuario.Name = "CBTipoUsuario";
            this.CBTipoUsuario.Size = new System.Drawing.Size(310, 21);
            this.CBTipoUsuario.TabIndex = 5;
            // 
            // tipousuariosBindingSource
            // 
            this.tipousuariosBindingSource.DataSource = typeof(CafeteriaUnapec.Tipo_usuarios);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de registro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
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
            // FrmEdUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 414);
            this.Controls.Add(this.EliminarUsuario);
            this.Controls.Add(this.GuardarUsuario);
            this.Controls.Add(this.panel1);
            this.Name = "FrmEdUsuario";
            this.Text = "Edicion de Usuario";
            this.Load += new System.EventHandler(this.FrmEdUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EliminarUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuardarUsuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipousuariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox EliminarUsuario;
        private System.Windows.Forms.PictureBox GuardarUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCedulaUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtIDUsuario;
        private System.Windows.Forms.ComboBox CBTipoUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCredito;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox CheckActivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource tipousuariosBindingSource;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label8;
    }
}