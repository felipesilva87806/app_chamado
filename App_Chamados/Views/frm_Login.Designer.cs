namespace App_Chamados {
    partial class frm_Login {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_usuario = new System.Windows.Forms.TextBox();
            this.textBox_senha = new System.Windows.Forms.TextBox();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.progressBar_login = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App_Chamados.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_usuario.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_usuario.Location = new System.Drawing.Point(13, 187);
            this.textBox_usuario.MaxLength = 100;
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(277, 26);
            this.textBox_usuario.TabIndex = 1;
            this.textBox_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_senha
            // 
            this.textBox_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_senha.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_senha.Location = new System.Drawing.Point(13, 246);
            this.textBox_senha.MaxLength = 100;
            this.textBox_senha.Name = "textBox_senha";
            this.textBox_senha.PasswordChar = '*';
            this.textBox_senha.Size = new System.Drawing.Size(277, 26);
            this.textBox_senha.TabIndex = 2;
            this.textBox_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_entrar
            // 
            this.btn_entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_entrar.Location = new System.Drawing.Point(13, 278);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(276, 35);
            this.btn_entrar.TabIndex = 3;
            this.btn_entrar.Text = "ENTRAR";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.Location = new System.Drawing.Point(13, 323);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(276, 35);
            this.btn_sair.TabIndex = 4;
            this.btn_sair.Text = "SAIR";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // progressBar_login
            // 
            this.progressBar_login.Location = new System.Drawing.Point(13, 365);
            this.progressBar_login.Name = "progressBar_login";
            this.progressBar_login.Size = new System.Drawing.Size(276, 23);
            this.progressBar_login.TabIndex = 5;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 411);
            this.Controls.Add(this.progressBar_login);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.textBox_senha);
            this.Controls.Add(this.textBox_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Chamado By: Felipe SIlva";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_usuario;
        private System.Windows.Forms.TextBox textBox_senha;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.ProgressBar progressBar_login;
        private System.Windows.Forms.Timer timer;
    }
}

