using App_Chamados.Entidades;
using App_Chamados.Exceptions;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Chamados.Views {
    public partial class frm_ConsultaChamado : Form {
        public frm_ConsultaChamado() {
            InitializeComponent();
        }

        public int Checked { get; set; }

        private void btn_PesquisaChamados_Click(object sender, EventArgs e) {
            try {
                if (radioButton_nchamado.Checked) {
                    Checked = 1;
                }
                else if (radioButton_descricao.Checked) {
                    Checked = 2;
                }
                else {
                    Checked = 0;
                }
                PesquisaChamados pes = new PesquisaChamados(textBox_PesquisaUsers.Text,Checked);
                DataTable retorno = pes.ListaUsers();
                if (pes.Retorno == true) {
                    dataGridView_Chamados.DataSource = retorno;
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

        private void dataGridView_Chamados_CellClick(object sender, DataGridViewCellEventArgs e) {
            btn_Atender.Enabled = true;

            int rowIndex = e.RowIndex;

            DataGridViewRow row = this.dataGridView_Chamados.Rows[rowIndex];

            //parei aqui

            /*
            this.textBox_id.Text = row.Cells[0].Value.ToString();
            this.textBox_login.Text = row.Cells[1].Value.ToString();
            this.textBox_senha.Text = row.Cells[2].Value.ToString();
            this.textBox_nome.Text = row.Cells[3].Value.ToString();
            this.textBox_email.Text = row.Cells[4].Value.ToString();
            this.textBox_matricula.Text = row.Cells[6].Value.ToString();
            */
        }
    }
}
