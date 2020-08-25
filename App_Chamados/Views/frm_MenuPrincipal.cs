using System;
using App_Chamados.Entidades;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Chamados.Views {
    public partial class frm_MenuPrincipal : Form {
        public frm_MenuPrincipal() {
            InitializeComponent();
        }

        private void frm_MenuPrincipal_Load(object sender, EventArgs e) {
            if (ValidaLogin.Permissao == 0) {
                cadastroDeUsuárioToolStripMenuItem.Enabled = false;
            }
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void cadastroDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e) {
            frm_CadastroDeUsuario cad = new frm_CadastroDeUsuario();
            cad.ShowDialog();
        }
    }
}
