using MySql.Data.MySqlClient;

namespace App_Chamados.Entidades {
    class ConexaoBd {
        MySqlConnection conn = new MySqlConnection();

        public ConexaoBd() {
            conn.ConnectionString = "server=localhost; port=3306; user id=root; database=bd_chamados; password=";
        }

        public MySqlConnection Conectar() {
            if (conn.State == System.Data.ConnectionState.Closed) {
                conn.Open();
            }
            return conn;
        }

        public MySqlConnection desconectar() {
            if (conn.State == System.Data.ConnectionState.Open) {
                conn.Close();
            }
            return conn;
        }
    }
}
