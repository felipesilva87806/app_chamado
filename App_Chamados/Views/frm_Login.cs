using App_Chamados.Entidades;
using App_Chamados.Exceptions;
using App_Chamados.Views;
using System;
using System.Windows.Forms;

namespace App_Chamados {
    public partial class frm_Login : Form {
        public frm_Login() {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e) {

            try {
                ValidaLogin valid = new ValidaLogin(textBox_usuario.Text, textBox_senha.Text);
                bool retorno = valid.BuscaRegistro();
                if (retorno == true) {
                    timer.Start();
                }
                else {
                    MessageBox.Show("Usuário não cadastrado! Verifique!!",
                        "ERRO!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    textBox_usuario.Text = string.Empty;
                    textBox_senha.Text = string.Empty;
                    textBox_usuario.Focus();
                }
            }
            catch (TrataErros ex) {
                MessageBox.Show($"{ex.Message}", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_usuario.Focus();
            }
        }

        private void timer_Tick(object sender, EventArgs e) {
            progressBar_login.Increment(2);
            if (progressBar_login.Value == 100) {
                timer.Stop();
                frm_MenuPrincipal menu = new frm_MenuPrincipal();
                this.Hide();
                menu.Closed += (s, args) => this.Close();
                menu.ShowDialog();
            }

        }

        private void btn_sair_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
