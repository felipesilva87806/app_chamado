using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace App_Chamados.Entidades {
    class AlteraUsuario {

        MySqlCommand cmd = new MySqlCommand();
        ConexaoBd conn = new ConexaoBd();
        MySqlDataReader dr;

        public int ID { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public int Matricula { get; set; }

        public AlteraUsuario() {

        }

        public AlteraUsuario(int iD, string nome, string login, string email, int matricula) {            
            ID = iD;
            Nome = nome;
            Login = login;
            Email = email;
            Matricula = matricula;
        }

        public bool UpdateUsuario() {
            bool retorno = false;
            cmd.CommandText = "UPDATE" +
                " users set user_login = @Login,user_nome = @Nome,user_email = @Email,user_matricula = @Matricula" +
                " WHERE users_id = @ID";
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@Login", Login);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Matricula", Matricula);

            try {
                DialogResult result = MessageBox.Show("Deseja Realmete alterar o usuário",
                    "ALERTAR",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (result.ToString().ToUpper() == "YES") {
                    cmd.Connection = conn.Conectar();
                    dr = cmd.ExecuteReader();                    
                    retorno = true;
                }                
                else {
                    retorno = false;
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
