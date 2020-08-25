using App_Chamados.Entidades;
using App_Chamados.Exceptions;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace App_Chamados.Views {
    public partial class frm_CadastroDeUsuario : Form {
        public frm_CadastroDeUsuario() {
            InitializeComponent();
        }

        private void btn_PesquisarUsers_Click(object sender, EventArgs e) {
            try {
                PesquisaUsuario pes = new PesquisaUsuario(textBox_PesquisaUsers.Text);
                DataTable retorno = pes.ListaUsers();
                if (pes.Retorno == true) {
                    dataGridViewListUsers.DataSource = retorno;
                }
                else {
                    MessageBox.Show("Nenhum registro localizado!!",
                        "ERRO!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (TrataErros ex) {
                MessageBox.Show($"{ex.Message}", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_PesquisaUsers.Focus();
            }
            catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewListUsers_CellClick(object sender, DataGridViewCellEventArgs e) {
            btn_AddUserNovo.Enabled = false;
            btn_ExcluirUsers.Enabled = true;
            btn_Alterar.Enabled = true;
            btn_CancelarEdit.Enabled = true;

            int column = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            DataGridViewRow row = this.dataGridViewListUsers.Rows[rowIndex];

            this.textBox_id.Text = row.Cells[0].Value.ToString();
            this.textBox_login.Text = row.Cells[1].Value.ToString();
            this.textBox_senha.Text = row.Cells[2].Value.ToString();
            this.textBox_nome.Text = row.Cells[3].Value.ToString();            
            this.textBox_email.Text = row.Cells[4].Value.ToString();
            this.textBox_matricula.Text = row.Cells[6].Value.ToString();

        }

        private void btn_Alterar_Click(object sender, EventArgs e) {
            textBox_nome.Enabled = true;
            textBox_login.Enabled = true;
            textBox_email.Enabled = true;
            textBox_matricula.Enabled = true;
            btn_AtualizarDados.Enabled = true;
            btn_CancelarEdit.Enabled = true;
        }

        private void btn_AtualizarDados_Click(object sender, EventArgs e) {
            try {
                AlteraUsuario alt = new AlteraUsuario(Convert.ToInt32(textBox_id.Text), textBox_nome.Text, textBox_login.Text, textBox_email.Text, Convert.ToInt32(textBox_matricula.Text));
                bool retorno = alt.UpdateUsuario();
                if (retorno == true) {
                    MessageBox.Show("Alterado com sucesso!",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    textBox_id.Text = string.Empty;
                    textBox_nome.Text = string.Empty;
                    textBox_login.Text = string.Empty;
                    textBox_email.Text = string.Empty;
                    textBox_matricula.Text = string.Empty;
                    textBox_id.Enabled = false;
                    textBox_nome.Enabled = false;
                    textBox_login.Enabled = false;
                    textBox_email.Enabled = false;
                    textBox_matricula.Enabled = false;
                    btn_AtualizarDados.Enabled = false;
                    btn_Alterar.Enabled = false;
                    btn_CancelarEdit.Enabled = false;
                    btn_ExcluirUsers.Enabled = false;

                }
                else {
                    MessageBox.Show("Alteração NÃO realizada!",
                        "Alerta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    textBox_id.Text = string.Empty;
                    textBox_nome.Text = string.Empty;
                    textBox_login.Text = string.Empty;
                    textBox_email.Text = string.Empty;
                    textBox_matricula.Text = string.Empty;
                    textBox_id.Enabled = false;
                    textBox_nome.Enabled = false;
                    textBox_login.Enabled = false;
                    textBox_email.Enabled = false;
                    textBox_matricula.Enabled = false;
                    btn_AtualizarDados.Enabled = false;
                    btn_Alterar.Enabled = false;
                    btn_CancelarEdit.Enabled = false;
                    btn_ExcluirUsers.Enabled = false;
                }
            }
            catch (TrataErros ex) {
                MessageBox.Show($"{ex.Message}", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_CancelarEdit_Click(object sender, EventArgs e) {
            textBox_id.Text = string.Empty;
            textBox_nome.Text = string.Empty;
            textBox_login.Text = string.Empty;
            textBox_senha.Text = string.Empty;
            textBox_email.Text = string.Empty;
            textBox_matricula.Text = string.Empty;
            textBox_id.Enabled = false;
            textBox_nome.Enabled = false;
            textBox_senha.Enabled = false;
            textBox_login.Enabled = false;
            textBox_email.Enabled = false;
            textBox_matricula.Enabled = false;
            textBox_PesquisaUsers.Enabled = true;
            btn_PesquisarUsers.Enabled = true;
            btn_AtualizarDados.Enabled = false;
            btn_Alterar.Enabled = false;
            btn_CancelarEdit.Enabled = false;
            btn_InserirDados.Enabled = false;
            btn_AddUserNovo.Enabled = true;
            btn_ExcluirUsers.Enabled = false;
        }

        private void btn_ExcluirUsers_Click(object sender, EventArgs e) {

            try {
                ExcluirUsuario ex = new ExcluirUsuario(Convert.ToInt32(textBox_id.Text));
                bool retorno = ex.DeletUsers();
                if (retorno == true) {
                    MessageBox.Show("Usuário Excluido com Sucesso!",
                        "Sucesso!!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    textBox_id.Text = string.Empty;
                    textBox_nome.Text = string.Empty;
                    textBox_login.Text = string.Empty;
                    textBox_senha.Text = string.Empty;
                    textBox_email.Text = string.Empty;
                    textBox_matricula.Text = string.Empty;
                    textBox_id.Enabled = false;
                    textBox_nome.Enabled = false;
                    textBox_login.Enabled = false;
                    textBox_email.Enabled = false;
                    textBox_matricula.Enabled = false;
                    btn_AtualizarDados.Enabled = false;
                    btn_Alterar.Enabled = false;
                    btn_CancelarEdit.Enabled = false;
                    btn_ExcluirUsers.Enabled = false;
                    btn_AddUserNovo.Enabled = true;
                    comboBox_permissao.Enabled = false;
                }
                else {
                    MessageBox.Show("Exclusão NÃO realizada!",
                        "ERRO!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    textBox_id.Text = string.Empty;
                    textBox_nome.Text = string.Empty;
                    textBox_login.Text = string.Empty;
                    textBox_senha.Text = string.Empty;
                    textBox_email.Text = string.Empty;
                    textBox_matricula.Text = string.Empty;
                    textBox_id.Enabled = false;
                    textBox_nome.Enabled = false;
                    textBox_login.Enabled = false;
                    textBox_email.Enabled = false;
                    textBox_matricula.Enabled = false;
                    btn_AtualizarDados.Enabled = false;
                    btn_Alterar.Enabled = false;
                    btn_CancelarEdit.Enabled = false;
                    btn_ExcluirUsers.Enabled = false;
                    comboBox_permissao.Enabled = false;
                }
            }
            catch (TrataErros ex) {
                MessageBox.Show($"{ex.Message}", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_AddUserNovo_Click(object sender, EventArgs e) {
            textBox_id.Enabled = false;
            textBox_login.Enabled = true;
            textBox_senha.Enabled = true;
            textBox_nome.Enabled = true;            
            textBox_email.Enabled = true;
            textBox_matricula.Enabled = true;
            textBox_PesquisaUsers.Enabled = false;
            btn_PesquisarUsers.Enabled = false;
            btn_AtualizarDados.Enabled = false;
            btn_Alterar.Enabled = false;
            btn_CancelarEdit.Enabled = true;
            btn_ExcluirUsers.Enabled = false;
            btn_InserirDados.Enabled = true;
            textBox_login.Focus();
        }       

        private void btn_Inserir_Click_1(object sender, EventArgs e) {
            try {
                InsertUsuarios insert = new InsertUsuarios(textBox_login.Text, textBox_senha.Text, textBox_nome.Text, textBox_email.Text, Convert.ToInt32(textBox_matricula.Text), comboBox_permissao.Text);
                bool retorno = insert.InsereNewUsuario();
                if (retorno == true) {
                    MessageBox.Show("Usuário cadastrado com sucesso!",
                        "Sucesso!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    textBox_id.Text = string.Empty;
                    textBox_nome.Text = string.Empty;
                    textBox_login.Text = string.Empty;
                    textBox_senha.Text = string.Empty;
                    textBox_email.Text = string.Empty;
                    textBox_matricula.Text = string.Empty;
                    textBox_id.Enabled = false;
                    textBox_nome.Enabled = false;
                    textBox_senha.Enabled = false;
                    textBox_login.Enabled = false;
                    textBox_email.Enabled = false;
                    textBox_matricula.Enabled = false;
                    textBox_PesquisaUsers.Enabled = true;
                    btn_PesquisarUsers.Enabled = true;
                    btn_AtualizarDados.Enabled = false;
                    btn_Alterar.Enabled = false;
                    btn_CancelarEdit.Enabled = false;
                    btn_InserirDados.Enabled = false;
                    btn_AddUserNovo.Enabled = true;
                    btn_ExcluirUsers.Enabled = false;
                }
                else {
                    MessageBox.Show("Usuário JÁ CADASTRADO tente novamente!",
                        "ERRO!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    textBox_nome.Text = string.Empty;
                    textBox_login.Text = string.Empty;
                    textBox_senha.Text = string.Empty;
                    textBox_email.Text = string.Empty;
                    textBox_matricula.Text = string.Empty;
                    textBox_login.Focus();
                }

            }
            catch (TrataErros ex) {
                MessageBox.Show($"{ex.Message}", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_matricula_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) {

                e.Handled = true;

            }
        }
    }
}