using App_Chamados.Exceptions;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace App_Chamados.Entidades {
    class PesquisaUsuario {

        MySqlCommand cmd = new MySqlCommand();
        ConexaoBd conn = new ConexaoBd();

        public string Pesquisa { get; set; }
        public bool Retorno { get; set; }

        public PesquisaUsuario(string pesquisa) {
            if (pesquisa == string.Empty) {// caso o combox ficar em branco
                cmd.CommandText = "SELECT " +
                    "users_id AS ID,user_login AS LOGIN,user_senha AS SENHA,user_nome AS NOME,user_email AS EMAIL,date_criado AS DATA_CRIAÇÃO,user_matricula AS MATRICULA,user_acesso AS PERMISSÕES" +
                    " FROM users";
            }
            else {// caso receba parametros de pesquisa
                Pesquisa = pesquisa;
                cmd.CommandText = "SELECT " +
                "users_id AS ID,user_login AS LOGIN,user_senha AS SENHA,user_nome AS NOME,user_email AS EMAIL,date_criado AS DATA_CRIAÇÃO,user_matricula AS MATRICULA,user_acesso AS PERMISSÕES" +
                " FROM users " +
                "WHERE user_nome LIKE '" + Pesquisa + "%' OR user_login LIKE '" + Pesquisa + "%'  ORDER BY user_nome";                
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
