namespace App_Chamados.Views {
    partial class frm_ConsultaChamado {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ConsultaChamado));
            this.btn_PesquisaChamados = new System.Windows.Forms.Button();
            this.textBox_PesquisaUsers = new System.Windows.Forms.TextBox();
            this.dataGridView_Chamados = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_descricao = new System.Windows.Forms.RadioButton();
            this.radioButton_nchamado = new System.Windows.Forms.RadioButton();
            this.btn_Atender = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Chamados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_PesquisaChamados
            // 
            this.btn_PesquisaChamados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PesquisaChamados.Image = global::App_Chamados.Properties.Resources.pesquisauser;
            this.btn_PesquisaChamados.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_PesquisaChamados.Location = new System.Drawing.Point(539, 10);
            this.btn_PesquisaChamados.Name = "btn_PesquisaChamados";
            this.btn_PesquisaChamados.Size = new System.Drawing.Size(108, 35);
            this.btn_PesquisaChamados.TabIndex = 7;
            this.btn_PesquisaChamados.Text = "Pesquisar";
            this.btn_PesquisaChamados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_PesquisaChamados.UseVisualStyleBackColor = true;
            this.btn_PesquisaChamados.Click += new System.EventHandler(this.btn_PesquisaChamados_Click);
            // 
            // textBox_PesquisaUsers
            // 
            this.textBox_PesquisaUsers.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PesquisaUsers.Location = new System.Drawing.Point(314, 19);
            this.textBox_PesquisaUsers.MaxLength = 200;
            this.textBox_PesquisaUsers.Name = "textBox_PesquisaUsers";
            this.textBox_PesquisaUsers.Size = new System.Drawing.Size(219, 26);
            this.textBox_PesquisaUsers.TabIndex = 6;
            // 
            // dataGridView_Chamados
            // 
            this.dataGridView_Chamados.AllowUserToAddRows = false;
            this.dataGridView_Chamados.AllowUserToDeleteRows = false;
            this.dataGridView_Chamados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_Chamados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Chamados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Chamados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Chamados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_Chamados.Location = new System.Drawing.Point(12, 77);
            this.dataGridView_Chamados.Name = "dataGridView_Chamados";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_Chamados.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Chamados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Chamados.Size = new System.Drawing.Size(990, 219);
            this.dataGridView_Chamados.TabIndex = 8;
            this.dataGridView_Chamados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Chamados_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_descricao);
            this.groupBox1.Controls.Add(this.radioButton_nchamado);
            this.groupBox1.Controls.Add(this.btn_PesquisaChamados);
            this.groupBox1.Controls.Add(this.textBox_PesquisaUsers);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 59);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa de chamados";
            // 
            // radioButton_descricao
            // 
            this.radioButton_descricao.AutoSize = true;
            this.radioButton_descricao.Location = new System.Drawing.Point(173, 28);
            this.radioButton_descricao.Name = "radioButton_descricao";
            this.radioButton_descricao.Size = new System.Drawing.Size(138, 17);
            this.radioButton_descricao.TabIndex = 1;
            this.radioButton_descricao.Text = "Pesquisa por descrição:";
            this.radioButton_descricao.UseVisualStyleBackColor = true;
            // 
            // radioButton_nchamado
            // 
            this.radioButton_nchamado.AutoSize = true;
            this.radioButton_nchamado.Location = new System.Drawing.Point(6, 28);
            this.radioButton_nchamado.Name = "radioButton_nchamado";
            this.radioButton_nchamado.Size = new System.Drawing.Size(161, 17);
            this.radioButton_nchamado.TabIndex = 0;
            this.radioButton_nchamado.Text = "Pesquisa por n° de chamado";
            this.radioButton_nchamado.UseVisualStyleBackColor = true;
            // 
            // btn_Atender
            // 
            this.btn_Atender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Atender.Enabled = false;
            this.btn_Atender.Image = global::App_Chamados.Properties.Resources.verificado;
            this.btn_Atender.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Atender.Location = new System.Drawing.Point(894, 302);
            this.btn_Atender.Name = "btn_Atender";
            this.btn_Atender.Size = new System.Drawing.Size(108, 35);
            this.btn_Atender.TabIndex = 11;
            this.btn_Atender.Text = "Atender";
            this.btn_Atender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Atender.UseVisualStyleBackColor = true;
            // 
            // frm_ConsultaChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 470);
            this.Controls.Add(this.btn_Atender);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_Chamados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ConsultaChamado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Chamados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Chamados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_PesquisaChamados;
        private System.Windows.Forms.TextBox textBox_PesquisaUsers;
        private System.Windows.Forms.DataGridView dataGridView_Chamados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_descricao;
        private System.Windows.Forms.RadioButton radioButton_nchamado;
        private System.Windows.Forms.Button btn_Atender;
    }
}