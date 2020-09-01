namespace App_Chamados.Views {
    partial class frm_AberturaDeChamados {
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
            this.groupBox_dados = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_loja = new System.Windows.Forms.ComboBox();
            this.comboBox_solicitante = new System.Windows.Forms.ComboBox();
            this.textBox_titulo = new System.Windows.Forms.TextBox();
            this.textBox_descricao = new System.Windows.Forms.TextBox();
            this.comboBox_prioridade = new System.Windows.Forms.ComboBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.groupBox_dados.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_dados
            // 
            this.groupBox_dados.Controls.Add(this.btn_cancelar);
            this.groupBox_dados.Controls.Add(this.comboBox_prioridade);
            this.groupBox_dados.Controls.Add(this.textBox_descricao);
            this.groupBox_dados.Controls.Add(this.textBox_titulo);
            this.groupBox_dados.Controls.Add(this.comboBox_solicitante);
            this.groupBox_dados.Controls.Add(this.comboBox_loja);
            this.groupBox_dados.Controls.Add(this.label5);
            this.groupBox_dados.Controls.Add(this.label4);
            this.groupBox_dados.Controls.Add(this.label3);
            this.groupBox_dados.Controls.Add(this.label2);
            this.groupBox_dados.Controls.Add(this.label1);
            this.groupBox_dados.Controls.Add(this.btn_enviar);
            this.groupBox_dados.Location = new System.Drawing.Point(12, 12);
            this.groupBox_dados.Name = "groupBox_dados";
            this.groupBox_dados.Size = new System.Drawing.Size(516, 479);
            this.groupBox_dados.TabIndex = 0;
            this.groupBox_dados.TabStop = false;
            this.groupBox_dados.Text = "Abertura de Chamados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Solicitante:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Titulo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descrição:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prioridade:";
            // 
            // comboBox_loja
            // 
            this.comboBox_loja.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_loja.FormattingEnabled = true;
            this.comboBox_loja.Location = new System.Drawing.Point(105, 29);
            this.comboBox_loja.Name = "comboBox_loja";
            this.comboBox_loja.Size = new System.Drawing.Size(376, 26);
            this.comboBox_loja.TabIndex = 5;
            // 
            // comboBox_solicitante
            // 
            this.comboBox_solicitante.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_solicitante.FormattingEnabled = true;
            this.comboBox_solicitante.Location = new System.Drawing.Point(105, 81);
            this.comboBox_solicitante.Name = "comboBox_solicitante";
            this.comboBox_solicitante.Size = new System.Drawing.Size(376, 26);
            this.comboBox_solicitante.TabIndex = 6;
            // 
            // textBox_titulo
            // 
            this.textBox_titulo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_titulo.Location = new System.Drawing.Point(105, 133);
            this.textBox_titulo.Name = "textBox_titulo";
            this.textBox_titulo.Size = new System.Drawing.Size(376, 26);
            this.textBox_titulo.TabIndex = 7;
            // 
            // textBox_descricao
            // 
            this.textBox_descricao.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_descricao.Location = new System.Drawing.Point(105, 199);
            this.textBox_descricao.Multiline = true;
            this.textBox_descricao.Name = "textBox_descricao";
            this.textBox_descricao.Size = new System.Drawing.Size(376, 129);
            this.textBox_descricao.TabIndex = 8;
            // 
            // comboBox_prioridade
            // 
            this.comboBox_prioridade.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_prioridade.FormattingEnabled = true;
            this.comboBox_prioridade.Location = new System.Drawing.Point(105, 357);
            this.comboBox_prioridade.Name = "comboBox_prioridade";
            this.comboBox_prioridade.Size = new System.Drawing.Size(376, 26);
            this.comboBox_prioridade.TabIndex = 9;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(42, 402);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(157, 44);
            this.btn_cancelar.TabIndex = 10;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(293, 402);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(157, 44);
            this.btn_enviar.TabIndex = 11;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            // 
            // frm_AberturaDeChamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 523);
            this.Controls.Add(this.groupBox_dados);
            this.Name = "frm_AberturaDeChamados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abertura de Chamado";
            this.groupBox_dados.ResumeLayout(false);
            this.groupBox_dados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_dados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_loja;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.ComboBox comboBox_prioridade;
        private System.Windows.Forms.TextBox textBox_descricao;
        private System.Windows.Forms.TextBox textBox_titulo;
        private System.Windows.Forms.ComboBox comboBox_solicitante;
        private System.Windows.Forms.Button btn_enviar;
    }
}