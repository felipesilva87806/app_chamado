using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Chamados.Entidades {
    class PesquisaChamados {

        MySqlCommand cmd = new MySqlCommand();
        ConexaoBd conn = new ConexaoBd();

        public string Pesquisa { get; set; }
        public bool Retorno { get; set; }

        public PesquisaChamados(string pesquisa,int filtro) {
            Pesquisa = pesquisa;
            if (pesquisa == string.Empty || filtro == 0) {
                cmd.CommandText = "SELECT * FROM tbl_chamados";
            }
            else if (filtro == 1) {
                cmd.CommandText = $"SELECT * FROM tbl_chamados WHERE id = {Pesquisa}";
            }
            else if (filtro == 2) {
                cmd.CommandText = "SELECT * FROM tbl_chamados WHERE titulo LIKE '" + Pesquisa + "%' OR descricao LIKE '" + Pesquisa + "%'";
            }
        }

        public DataTable ListaUsers() {
            DataTable tabela = null;
            
            cmd.Connection = conn.Conectar();
            try {

                tabela = new DataTable();
                MySqlDataAdapter dados = new MySqlDataAdapter();
                dados.SelectCommand = cmd;
                dados.Fill(tabela);
                int i = tabela.Rows.Count;
                if (i > 0) {
                    Retorno = true;
                }
            }
            catch (MySqlException ex) {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            finally {
                conn.desconectar();
            }
            return tabela;
        }
    }
}
