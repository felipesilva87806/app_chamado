using App_Chamados.Exceptions;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace App_Chamados.Entidades {
    class InsertUsuarios {

        MySqlCommand cmd = new MySqlCommand();
        ConexaoBd conn = new ConexaoBd();
        private MySqlDataReader dr;

        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Matricula { get; set; }

        public string Permissao { get; set; }

        public InsertUsuarios(string login, string senha, string nome, string email, int matricula, string permissao) {
            switch (permissao) {
                case "0 - Usuário":
                    permissao = "0";
                    break;
                case "1 - Administrador":
                    permissao = "1";
                    break;
            }
            if (login == string.Empty || senha == string.Empty || nome == string.Empty || email == string.Empty || matricula < 0) {
                throw new TrataErros("Campos *OBRIGATÓRIOS estão em branco!, Verifique");
            }
            else {
                Login = login;
                Senha = senha;
                Nome = nome;
                Email = email;
                Matricula = matricula;
                Permissao = permissao;
            }
        }

        public bool InsereNewUsuario() {
            bool retorno = false;
            cmd.CommandText = "sp_InsereUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("login", MySqlDbType.Text).Value = Login;
            cmd.Parameters.Add("senha", MySqlDbType.Text).Value = Senha;
            cmd.Parameters.Add("nome", MySqlDbType.Text).Value = Nome;
            cmd.Parameters.Add("email", MySqlDbType.Text).Value = Email;
            cmd.Parameters.Add("matricula", MySqlDbType.Text).Value = Matricula;
            cmd.Parameters.Add("acesso", MySqlDbType.Text).Value = Permissao;

            try {
                cmd.Connection = conn.Conectar();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) {
                    retorno = true;
                }
            }
            catch (MySqlException ex) {
                MessageBox.Show("ERRO Exceptions: " + ex.Message);
            }
            finally {
                conn.desconectar();
            }
            return retorno;
        }
    }
}
