using MySql.Data.MySqlClient;
using App_Chamados.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Chamados.Entidades {
	class ExcluirUsuario {

		MySqlCommand cmd = new MySqlCommand();
		ConexaoBd conn = new ConexaoBd();
        MySqlDataReader dr;

        public int ID { get; set; }

		public ExcluirUsuario(int id) {
			ID = id;
		}
        public bool DeletUsers() {
            bool retorno = false;
            cmd.CommandText = "DELETE FROM users WHERE users_id = @ID";
            cmd.Parameters.AddWithValue("@ID", ID);

            try {
                DialogResult result = MessageBox.Show($"Deseja Realmete Excluir o usuário selecionado ?",
                    "ATENÇÃO",
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