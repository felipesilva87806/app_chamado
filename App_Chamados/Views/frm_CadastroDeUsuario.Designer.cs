namespace App_Chamados.Views {
    partial class frm_CadastroDeUsuario {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox_PesquisaUsers = new System.Windows.Forms.TextBox();
            this.dataGridViewListUsers = new System.Windows.Forms.DataGridView();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_matricula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_senha = new System.Windows.Forms.TextBox();
            this.groupBox_permissoes = new System.Windows.Forms.GroupBox();
            this.btn_InserirDados = new System.Windows.Forms.Button();
            this.btn_ExcluirUsers = new System.Windows.Forms.Button();
            this.btn_CancelarEdit = new System.Windows.Forms.Button();
            this.btn_AtualizarDados = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_PesquisarUsers = new System.Windows.Forms.Button();
            this.btn_AddUserNovo = new System.Windows.Forms.Button();
            this.comboBox_permissao = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListUsers)).BeginInit();
            this.groupBox_permissoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_PesquisaUsers
            // 
            this.textBox_PesquisaUsers.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PesquisaUsers.Location = new System.Drawing.Point(360, 17);
            this.textBox_PesquisaUsers.MaxLength = 200;
            this.textBox_PesquisaUsers.Name = "textBox_PesquisaUsers";
            this.textBox_PesquisaUsers.Size = new System.Drawing.Size(219, 26);
            this.textBox_PesquisaUsers.TabIndex = 3;
            // 
            // dataGridViewListUsers
            // 
            this.dataGridViewListUsers.AllowUserToAddRows = false;
            this.dataGridViewListUsers.AllowUserToDeleteRows = false;
            this.dataGridViewListUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewListUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewListUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewListUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewListUsers.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewListUsers.Name = "dataGridViewListUsers";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewListUsers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewListUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListUsers.Size = new System.Drawing.Size(681, 301);
            this.dataGridViewListUsers.TabIndex = 2;
            this.dataGridViewListUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListUsers_CellClick);
            // 
            // textBox_id
            // 
            this.textBox_id.Enabled = false;
            this.textBox_id.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.Location = new System.Drawing.Point(802, 9);
            this.textBox_id.MaxLength = 100;
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(204, 26);
            this.textBox_id.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(765, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(735, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome:";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Enabled = false;
            this.textBox_nome.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nome.Location = new System.Drawing.Point(801, 105);
            this.textBox_nome.MaxLength = 100;
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(204, 26);
            this.textBox_nome.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(742, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Login:";
            // 
            // textBox_login
            // 
            this.textBox_login.Enabled = false;
            this.textBox_login.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_login.Location = new System.Drawing.Point(802, 41);
            this.textBox_login.MaxLength = 100;
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(204, 26);
            this.textBox_login.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(734, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "E-mail:";
            // 
            // textBox_email
            // 
            this.textBox_email.Enabled = false;
            this.textBox_email.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.Location = new System.Drawing.Point(801, 137);
            this.textBox_email.MaxLength = 100;
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(204, 26);
            this.textBox_email.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(715, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Matricula:";
            // 
            // textBox_matricula
            // 
            this.textBox_matricula.Enabled = false;
            this.textBox_matricula.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_matricula.Location = new System.Drawing.Point(802, 169);
            this.textBox_matricula.MaxLength = 100;
            this.textBox_matricula.Name = "textBox_matricula";
            this.textBox_matricula.Size = new System.Drawing.Size(204, 26);
            this.textBox_matricula.TabIndex = 13;
            this.textBox_matricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_matricula_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(736, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Senha:";
            // 
            // textBox_senha
            // 
            this.textBox_senha.Enabled = false;
            this.textBox_senha.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_senha.Location = new System.Drawing.Point(802, 73);
            this.textBox_senha.MaxLength = 100;
            this.textBox_senha.Name = "textBox_senha";
            this.textBox_senha.Size = new System.Drawing.Size(204, 26);
            this.textBox_senha.TabIndex = 18;
            // 
            // groupBox_permissoes
            // 
            this.groupBox_permissoes.Controls.Add(this.comboBox_permissao);
            this.groupBox_permissoes.Location = new System.Drawing.Point(718, 201);
            this.groupBox_permissoes.Name = "groupBox_permissoes";
            this.groupBox_permissoes.Size = new System.Drawing.Size(287, 64);
            this.groupBox_permissoes.TabIndex = 20;
            this.groupBox_permissoes.TabStop = false;
            this.groupBox_permissoes.Text = "Premissões";
            // 
            // btn_InserirDados
            // 
            this.btn_InserirDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_InserirDados.Enabled = false;
            this.btn_InserirDados.Image = global::App_Chamados.Properties.Resources.verificado;
            this.btn_InserirDados.Location = new System.Drawing.Point(702, 271);
            this.btn_InserirDados.Name = "btn_InserirDados";
            this.btn_InserirDados.Size = new System.Drawing.Size(297, 35);
            this.btn_InserirDados.TabIndex = 21;
            this.btn_InserirDados.Text = "Inserir";
            this.btn_InserirDados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_InserirDados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_InserirDados.UseVisualStyleBackColor = true;
            this.btn_InserirDados.Click += new System.EventHandler(this.btn_Inserir_Click_1);
            // 
            // btn_ExcluirUsers
            // 
            this.btn_ExcluirUsers.Enabled = false;
            this.btn_ExcluirUsers.Image = global::App_Chamados.Properties.Resources.excluir;
            this.btn_ExcluirUsers.Location = new System.Drawing.Point(246, 9);
            this.btn_ExcluirUsers.Name = "btn_ExcluirUsers";
            this.btn_ExcluirUsers.Size = new System.Drawing.Size(108, 35);
            this.btn_ExcluirUsers.TabIndex = 17;
            this.btn_ExcluirUsers.Text = "Excluir";
            this.btn_ExcluirUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ExcluirUsers.UseVisualStyleBackColor = true;
            this.btn_ExcluirUsers.Click += new System.EventHandler(this.btn_ExcluirUsers_Click);
            // 
            // btn_CancelarEdit
            // 
            this.btn_CancelarEdit.Enabled = false;
            this.btn_CancelarEdit.Image = global::App_Chamados.Properties.Resources.cancel;
            this.btn_CancelarEdit.Location = new System.Drawing.Point(854, 312);
            this.btn_CancelarEdit.Name = "btn_CancelarEdit";
            this.btn_CancelarEdit.Size = new System.Drawing.Size(152, 39);
            this.btn_CancelarEdit.TabIndex = 16;
            this.btn_CancelarEdit.Text = "Cancelar";
            this.btn_CancelarEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CancelarEdit.UseVisualStyleBackColor = true;
            this.btn_CancelarEdit.Click += new System.EventHandler(this.btn_CancelarEdit_Click);
            // 
            // btn_AtualizarDados
            // 
            this.btn_AtualizarDados.Enabled = false;
            this.btn_AtualizarDados.Image = global::App_Chamados.Properties.Resources.atualiza;
            this.btn_AtualizarDados.Location = new System.Drawing.Point(702, 312);
            this.btn_AtualizarDados.Name = "btn_AtualizarDados";
            this.btn_AtualizarDados.Size = new System.Drawing.Size(152, 39);
            this.btn_AtualizarDados.TabIndex = 15;
            this.btn_AtualizarDados.Text = "Atualizar Dados";
            this.btn_AtualizarDados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AtualizarDados.UseVisualStyleBackColor = true;
            this.btn_AtualizarDados.Click += new System.EventHandler(this.btn_AtualizarDados_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Alterar.Enabled = false;
            this.btn_Alterar.Image = global::App_Chamados.Properties.Resources.edituser;
            this.btn_Alterar.Location = new System.Drawing.Point(126, 9);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(108, 35);
            this.btn_Alterar.TabIndex = 2;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Alterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_PesquisarUsers
            // 
            this.btn_PesquisarUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PesquisarUsers.Image = global::App_Chamados.Properties.Resources.pesquisauser;
            this.btn_PesquisarUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_PesquisarUsers.Location = new System.Drawing.Point(585, 9);
            this.btn_PesquisarUsers.Name = "btn_PesquisarUsers";
            this.btn_PesquisarUsers.Size = new System.Drawing.Size(108, 35);
            this.btn_PesquisarUsers.TabIndex = 4;
            this.btn_PesquisarUsers.Text = "Pesquisar";
            this.btn_PesquisarUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_PesquisarUsers.UseVisualStyleBackColor = true;
            this.btn_PesquisarUsers.Click += new System.EventHandler(this.btn_PesquisarUsers_Click);
            // 
            // btn_AddUserNovo
            // 
            this.btn_AddUserNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddUserNovo.Image = global::App_Chamados.Properties.Resources.adduser;
            this.btn_AddUserNovo.Location = new System.Drawing.Point(12, 9);
            this.btn_AddUserNovo.Name = "btn_AddUserNovo";
            this.btn_AddUserNovo.Size = new System.Drawing.Size(108, 35);
            this.btn_AddUserNovo.TabIndex = 1;
            this.btn_AddUserNovo.Text = "Novo";
            this.btn_AddUserNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddUserNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AddUserNovo.UseVisualStyleBackColor = true;
            this.btn_AddUserNovo.Click += new System.EventHandler(this.btn_AddUserNovo_Click);
            // 
            // comboBox_permissao
            // 
            this.comboBox_permissao.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_permissao.FormattingEnabled = true;
            this.comboBox_permissao.Items.AddRange(new object[] {
            "0 - Usuário",
            "1 - Adminstrador"});
            this.comboBox_permissao.Location = new System.Drawing.Point(6, 19);
            this.comboBox_permissao.Name = "comboBox_permissao";
            this.comboBox_permissao.Size = new System.Drawing.Size(275, 26);
            this.comboBox_permissao.TabIndex = 0;
            this.comboBox_permissao.Text = "Selecione uma permissão";
            // 
            // frm_CadastroDeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 363);
            this.Controls.Add(this.btn_InserirDados);
            this.Controls.Add(this.groupBox_permissoes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_senha);
            this.Controls.Add(this.btn_ExcluirUsers);
            this.Controls.Add(this.btn_CancelarEdit);
            this.Controls.Add(this.btn_AtualizarDados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_matricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_PesquisarUsers);
            this.Controls.Add(this.dataGridViewListUsers);
            this.Controls.Add(this.textBox_PesquisaUsers);
            this.Controls.Add(this.btn_AddUserNovo);
            this.Name = "frm_CadastroDeUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro De Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListUsers)).EndInit();
            this.groupBox_permissoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddUserNovo;
        private System.Windows.Forms.TextBox textBox_PesquisaUsers;
        private System.Windows.Forms.DataGridView dataGridViewListUsers;
        private System.Windows.Forms.Button btn_PesquisarUsers;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_matricula;
        private System.Windows.Forms.Button btn_AtualizarDados;
        private System.Windows.Forms.Button btn_CancelarEdit;
        private System.Windows.Forms.Button btn_ExcluirUsers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_senha;
        private System.Windows.Forms.GroupBox groupBox_permissoes;
        private System.Windows.Forms.Button btn_InserirDados;
        private System.Windows.Forms.ComboBox comboBox_permissao;
    }
}