using App_Chamados.Entidades;
using App_Chamados.Exceptions;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace App_Chamados.Views {
    public partial class frm_AberturaDeChamados : Form {
        public frm_AberturaDeChamados() {
            InitializeComponent();
            CarregaComboboxLoja();
            CarregaComboboxDepart();
        }

        public void CarregaComboboxLoja() {
            ConexaoBd conn = new ConexaoBd();
            MySqlCommand cmd = new MySqlCommand("select * from lojas order by numero_loja",conn.Conectar());  
            try {
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow coluna = dt.NewRow();
                coluna["nome_loja"] = ""; // adiciona uma linha com a descrição
                dt.Rows.InsertAt(coluna, 0);// insere o valor texto informado na posição 0 da lista do combobox
                comboBox_loja.ValueMember = "numero_loja";// valor selecionado do item selecionado dentro do combobox
                comboBox_loja.DisplayMember = "nome_loja";// campo que vem da tabela do banco que será exibido dentro da combobox
                comboBox_loja.DataSource = dt;
            }
            catch (MySqlException ex) {
                MessageBox.Show("Ocorreu um erro: " + ex.ToString());
            }
            finally {
                conn.desconectar();
            }
        }

        public void CarregaComboboxDepart() {
            ConexaoBd conn = new ConexaoBd();
            MySqlCommand cmd = new MySqlCommand("select * from tbl_departamentos", conn.Conectar());
            try {
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow coluna = dt.NewRow();
                coluna["nome_departamento"] = "";
                dt.Rows.InsertAt(coluna, 0);
                comboBox_departamento.ValueMember = "id";
                comboBox_departamento.DisplayMember = "nome_departamento";
                comboBox_departamento.DataSource = dt;
            }
            catch (MySqlException ex) {
                MessageBox.Show("Ocorreu um erro: " + ex.ToString());
            }
            finally {
                conn.desconectar();
            }
        }

        public void CarregaComboboxIncident(string id) {
            ConexaoBd conn = new ConexaoBd();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_incidentes where id_departamentos = @id", conn.Conectar());
            cmd.Parameters.AddWithValue("@id", id);
            try {
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow coluna = dt.NewRow();
                coluna["nome_incidentes"] = "";
                dt.Rows.InsertAt(coluna, 0);
                comboBox_incidente.ValueMember = "id";
                comboBox_incidente.DisplayMember = "nome_incidentes";
                comboBox_incidente.DataSource = dt;
            }
            catch (MySqlException ex) {
                MessageBox.Show("Ocorreu um erro: " + ex.ToString());
            }
            finally {
                conn.desconectar();
            }
        }

        public void CarregaComboboxSubinc(string id) {
            ConexaoBd conn = new ConexaoBd();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_subincidentes where id_incidente = @id", conn.Conectar());
            cmd.Parameters.AddWithValue("@id", id);
            try {
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow coluna = dt.NewRow();
                coluna["nome_subincidentes"] = "";
                dt.Rows.InsertAt(coluna, 0);
                comboBox_subincidente.ValueMember = "id";
                comboBox_subincidente.DisplayMember = "nome_subincidentes";
                comboBox_subincidente.DataSource = dt;
            }
            catch (MySqlException ex) {
                MessageBox.Show("Ocorreu um erro: " + ex.ToString());
            }
            finally {
                conn.desconectar();
            }
        }




        private void frm_AberturaDeChamados_Load(object sender, EventArgs e) {
            /*
            MySqlCommand cmd = new MySqlCommand();
            ConexaoBd conn = new ConexaoBd();

            cmd.CommandText = "select nome_loja as LOJAS from lojas order by numero_loja";
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
            */
        }

        private void comboBox_loja_SelectedIndexChanged(object sender, EventArgs e) {
           /* MySqlCommand cmd = new MySqlCommand();
            ConexaoBd conn = new ConexaoBd();

            cmd.CommandText = "SELECT * FROM tbl_departamentos ORDER BY id";
            cmd.Connection = conn.Conectar();

            try {
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                comboBox_departamento.DisplayMember = "nome_departamento";
                comboBox_departamento.DataSource = dt;
            }
            catch (MySqlException ex) {
                MessageBox.Show("Ocorreu um erro: " + ex.ToString());
            }
            finally {
                conn.desconectar();
            }*/
        }

        private void comboBox_departamento_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBox_departamento.SelectedValue.ToString() != null) {
                string id = comboBox_departamento.SelectedValue.ToString();
                CarregaComboboxIncident(id);
            }
            /*int posicao = comboBox_departamento.SelectedIndex + 1;
            MySqlCommand cmd = new MySqlCommand();
            ConexaoBd conn = new ConexaoBd();

            cmd.CommandText = $"SELECT * FROM tbl_incidentes WHERE id_departamentos = {posicao}";
            cmd.Connection = conn.Conectar();

            try {
                
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                comboBox_incidente.DataSource = dt;
                comboBox_incidente.DisplayMember = "nome_incidentes";
                //comboBox_incidente.ValueMember = "";
                
            }
            catch (MySqlException ex) {
                MessageBox.Show("Ocorreu um erro: " + ex.ToString());
            }
            finally {
                conn.desconectar();
            }*/
        }
        

        private void comboBox_incidente_SelectedIndexChanged(object sender, EventArgs e) {

            if (comboBox_incidente.SelectedValue.ToString() != null) {
                string id = comboBox_incidente.SelectedValue.ToString();
                CarregaComboboxSubinc(id);
            }


            /* MySqlCommand cmd = new MySqlCommand();
             ConexaoBd conn = new ConexaoBd();

             cmd.CommandText = $"SELECT s.nome_subincidentes FROM tbl_incidentes i  inner join tbl_subincidentes s on i.id = s.id_incidente where i.nome_incidentes = '{comboBox_incidente.Text}'";            
             cmd.Connection = conn.Conectar();

             try {
                 MySqlDataReader dr = cmd.ExecuteReader();                
                 DataTable dt = new DataTable();
                 dt.Load(dr);
                 comboBox_subincidente.DataSource = dt;
                 comboBox_subincidente.DisplayMember = "nome_subincidentes"; 

             }
             catch (MySqlException ex) {
                 MessageBox.Show("Ocorreu um erro: " + ex.ToString());
             }
             finally {
                 conn.desconectar();
             }*/
        }

        private void btn_enviar_Click(object sender, EventArgs e) {
            try {
                InsertChamado ch = new InsertChamado(comboBox_loja.Text, textBox_solicitante.Text, textBox_titulo.Text, comboBox_departamento.Text, comboBox_incidente.Text, comboBox_subincidente.Text, textBox_descricao.Text, comboBox_prioridade.Text);
                bool retorno = ch.InserirChamado();
                string nchamado = ch.UltimoInsert();
                if (retorno == true) {
                    MessageBox.Show($"Chamado #{nchamado} aberto com sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBox_solicitante.Text = string.Empty;
                    textBox_titulo.Text = string.Empty;
                    textBox_descricao.Text = string.Empty;
                    textBox_solicitante.Focus();
                }
                else MessageBox.Show("Não foi possivel realizar o cadastro!!",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

            }
            catch (TrataErros ex) {
                MessageBox.Show($"{ex.Message}",
                    "ERRO!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textBox_solicitante.Text = string.Empty;
                textBox_titulo.Text = string.Empty;
                textBox_descricao.Text = string.Empty;
                textBox_solicitante.Focus();
            }
            catch (MySqlException er) {
                MessageBox.Show($"{er.Message}",
                    "ERRO!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }

}
