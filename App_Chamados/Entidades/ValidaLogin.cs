using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;
using System.Data;
using App_Chamados.Exceptions;

namespace App_Chamados.Entidades {
    class ValidaLogin {
        MySqlCommand cmd = new MySqlCommand();
        ConexaoBd conn = new ConexaoBd();
        MySqlDataReader dr;

        public string Usuario { get; set; }
        public string Senha { get; set; }
        public static int Permissao { get; set; }

        public ValidaLogin(string usuario, string senha) {
            if (usuario == string.Empty || senha == string.Empty) {
                throw new TrataErros("Campos *OBRIGATÓRIOS estão em branco, Verifique!");
            }
            else {
                Usuario = usuario;
                Senha = senha;
            }
        }

        public bool BuscaRegistro() {
            bool retorno = false;
            cmd.CommandText = "sp_ValidaLogin";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("usuario", MySqlDbType.Text).Value = Usuario;
            cmd.Parameters.Add("senha", MySqlDbType.Text).Value = Senha;

            try {
                cmd.Connection = conn.Conectar();
                dr = cmd.ExecuteReader();
                // valida permissão do usuario para carregar o menu
                if (dr.Read()) {
                    Permissao = Convert.ToInt32(dr[7].ToString());
                    retorno = true;
                }
                else {
                    Permissao = 0;
                }
            }
            catch (Exception ex) {
                MessageBox.Show("ERRO Exceptions: " + ex.Message);
            }
            finally {
                conn.desconectar();
            }
            return retorno;
        }
    }
}
