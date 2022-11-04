namespace P620223_MauricioArroyo.Formularios
{
    partial class FrmLogin
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
            this.LblRecuperarContrasennia = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtNombreUsuario = new System.Windows.Forms.TextBox();
            this.TxtContrasennia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblRecuperarContra = new System.Windows.Forms.LinkLabel();
            this.BtnVerPassword = new System.Windows.Forms.Button();
            this.LblRecuperarContrasennia.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblRecuperarContrasennia
            // 
            this.LblRecuperarContrasennia.Controls.Add(this.BtnVerPassword);
            this.LblRecuperarContrasennia.Controls.Add(this.LblRecuperarContra);
            this.LblRecuperarContrasennia.Controls.Add(this.label2);
            this.LblRecuperarContrasennia.Controls.Add(this.label1);
            this.LblRecuperarContrasennia.Controls.Add(this.TxtContrasennia);
            this.LblRecuperarContrasennia.Controls.Add(this.TxtNombreUsuario);
            this.LblRecuperarContrasennia.Controls.Add(this.BtnCancelar);
            this.LblRecuperarContrasennia.Controls.Add(this.BtnIngresar);
            this.LblRecuperarContrasennia.Location = new System.Drawing.Point(12, 12);
            this.LblRecuperarContrasennia.Name = "LblRecuperarContrasennia";
            this.LblRecuperarContrasennia.Size = new System.Drawing.Size(378, 338);
            this.LblRecuperarContrasennia.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::P620223_MauricioArroyo.Properties.Resources.LOgin;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(407, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 241);
            this.panel2.TabIndex = 1;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnIngresar.Location = new System.Drawing.Point(33, 264);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(145, 36);
            this.BtnIngresar.TabIndex = 0;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(200, 264);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(146, 36);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreUsuario.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.TxtNombreUsuario.Location = new System.Drawing.Point(29, 78);
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.Size = new System.Drawing.Size(317, 29);
            this.TxtNombreUsuario.TabIndex = 2;
            this.TxtNombreUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtContrasennia
            // 
            this.TxtContrasennia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContrasennia.Location = new System.Drawing.Point(29, 167);
            this.TxtContrasennia.Name = "TxtContrasennia";
            this.TxtContrasennia.Size = new System.Drawing.Size(274, 29);
            this.TxtContrasennia.TabIndex = 3;
            this.TxtContrasennia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtContrasennia.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(29, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOMBRE USUARIO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(29, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "CONTRASEÑA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblRecuperarContra
            // 
            this.LblRecuperarContra.AutoSize = true;
            this.LblRecuperarContra.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblRecuperarContra.Location = new System.Drawing.Point(197, 210);
            this.LblRecuperarContra.Name = "LblRecuperarContra";
            this.LblRecuperarContra.Size = new System.Drawing.Size(106, 13);
            this.LblRecuperarContra.TabIndex = 6;
            this.LblRecuperarContra.TabStop = true;
            this.LblRecuperarContra.Text = "Olvidé mi contraseña";
            this.LblRecuperarContra.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // BtnVerPassword
            // 
            this.BtnVerPassword.Location = new System.Drawing.Point(309, 167);
            this.BtnVerPassword.Name = "BtnVerPassword";
            this.BtnVerPassword.Size = new System.Drawing.Size(37, 29);
            this.BtnVerPassword.TabIndex = 7;
            this.BtnVerPassword.Text = "Ver";
            this.BtnVerPassword.UseVisualStyleBackColor = true;
            this.BtnVerPassword.Click += new System.EventHandler(this.BtnVerPassword_Click);
            this.BtnVerPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnVerPassword_MouseDown);
            this.BtnVerPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnVerPassword_MouseUp);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(692, 362);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LblRecuperarContrasennia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.LblRecuperarContrasennia.ResumeLayout(false);
            this.LblRecuperarContrasennia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LblRecuperarContrasennia;
        private System.Windows.Forms.Button BtnVerPassword;
        private System.Windows.Forms.LinkLabel LblRecuperarContra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtContrasennia;
        private System.Windows.Forms.TextBox TxtNombreUsuario;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Panel panel2;
    }
}