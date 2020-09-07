using App_Chamados.Exceptions;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace App_Chamados.Entidades {
    class InsertChamado {

        MySqlCommand cmd = new MySqlCommand();
        ConexaoBd conn = new ConexaoBd();
        MySqlDataReader dr;

        public string Loja { get; set; }
        public string Solicitante { get; set; }
        public string Titulo { get; set; }
        public string Departamento { get; set; }
        public string Incidente { get; set; }

        public string Subincidente { get; set; }
        public string Descricao { get; set; }
        public string Prioridade { get; set; }

        public string Retorno { get; set; }

        public InsertChamado(string loja, string solicitante, string titulo, string departamento, string incidente, string subincidente, string descricao, string prioridade) {
            if (loja == string.Empty || solicitante == string.Empty || titulo == string.Empty || departamento == string.Empty || incidente == string.Empty || subincidente == string.Empty || descricao == string.Empty || prioridade == string.Empty) {
                throw new TrataErros("Campos *OBRIGATÓRIOS estão em branco, Verifique!");                
            }
            else {
                Loja = loja;
                Solicitante = solicitante;
                Titulo = titulo;
                Departamento = departamento;
                Incidente = incidente;
                Subincidente = subincidente;
                Descricao = descricao;
                Prioridade = prioridade;
            }
            
        }

        public bool InserirChamado() {
            bool retorno = false;
            try {
                cmd.Connection = conn.Conectar();
                cmd.Parameters.Clear();
                cmd.CommandText = "INSERT INTO tbl_chamados VALUES (null,@loja,@solicitante,@titulo,@departamento,@incidente,@subincidente,@descricao,@prioridade,'Aberto',null,current_timestamp(),null)";
                cmd.Parameters.AddWithValue("@loja", Loja);
                cmd.Parameters.AddWithValue("@solicitante", Solicitante);
                cmd.Parameters.AddWithValue("@titulo", Titulo);
                cmd.Parameters.AddWithValue("@departamento", Departamento);
                cmd.Parameters.AddWithValue("@incidente", Incidente);
                cmd.Parameters.AddWithValue("@subincidente", Subincidente);
                cmd.Parameters.AddWithValue("@descricao", Descricao);
                cmd.Parameters.AddWithValue("@prioridade", Prioridade);


                int i = cmd.ExecuteNonQuery();
                if (i > 0) {
                    retorno = true;
                    UltimoInsert();
                }
            }
            catch (MySqlException ex) {
                if (ex.Number == 1064) {
                    MessageBox.Show("ERRO de syntax SQL, verifique o comando enviado para o banco",
                       "ERRO!!",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                }
                else {
                    MessageBox.Show(ex.Message);
                }
            }
            
            finally {
                conn.desconectar();
            }
            return retorno;
        }

        public string UltimoInsert() {
            string Retorno = string.Empty;
            try {
                cmd.CommandText = "SELECT id FROM tbl_chamados ORDER BY id DESC LIMIT 1";
                cmd.Connection = conn.Conectar();                
                dr = cmd.ExecuteReader();
                if (dr.Read()) {
                    Retorno = dr[0].ToString();
                }
            }
            catch (MySqlException ex) {
                if (ex.Number == 1064) {
                    MessageBox.Show("ERRO de syntax SQL, verifique com comando enviado para o banco",
                       "ERRO!!",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                }
            }
            finally {
                conn.desconectar();
            }
            return Retorno;
        }


    }
}
