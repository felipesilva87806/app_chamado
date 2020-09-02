using App_Chamados.Entidades;
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
    public partial class frm_AberturaDeChamados : Form {
        public frm_AberturaDeChamados() {
            InitializeComponent();
        }

        private void frm_AberturaDeChamados_Load(object sender, EventArgs e) {
            MySqlCommand cmd = new MySqlCommand();
            ConexaoBd conn = new ConexaoBd();

            cmd.CommandText = "select nome_loja as LOJAS from lojas order by id_loja";
            cmd.Connection = conn.Conectar();

            try {
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                comboBox_loja.DisplayMember = "LOJAS";
                comboBox_loja.DataSource = dt;
            }
            catch (MySqlException ex) {
                MessageBox.Show("Ocorreu um erro: " + ex.ToString());
            }
            finally {
                conn.desconectar();
            }
        }
    }
}
