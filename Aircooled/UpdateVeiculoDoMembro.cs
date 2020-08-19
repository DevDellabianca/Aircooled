using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsApp2.Modelos;

namespace WindowsFormsApp2
{
    public partial class UpdateVeiculoDoMembro : Form
    {
        Panel pnlConteudo = null;
        private int _membroId;
        private Veiculo _veiculo;

        private void FrmVeiculo_Load(object sender, EventArgs e)
        {

        }
       /* public void PainelMain(Panel pnlConteudo)
        {
            
            Form formulario;
            formulario = pnlConteudo.Controls.OfType<Form>().FirstOrDefault();
            Type t = formulario.GetType();
            if (t.Equals(typeof(BrowserVeiculosDoMembro)))
                ((BrowserVeiculosDoMembro)formulario).PainelMain(pnlConteudo);
            this.pnlConteudo = pnlConteudo;
        }*/
        public void CUpdateVeiculoDoMembro(int membroId, Veiculo veiculo)
        {
            InitializeComponent();

            _membroId = membroId;
            _veiculo = veiculo;
        }
        public UpdateVeiculoDoMembro()
        {

        }
        public UpdateVeiculoDoMembro(int membroId, Veiculo veiculo)
        {

            CUpdateVeiculoDoMembro(membroId, veiculo);
        }

        private void FrmVeiculoDoMembro_Load(object sender, EventArgs e)
        {
            txtmarca.Text = _veiculo.Marca;
            txtmod.Text = _veiculo.AnoModelo;
            txtfab.Text = _veiculo.Fabricacao;
            txtapeli.Text = _veiculo.Apelido;
            txtobs.Text = _veiculo.Observacoes;
            txtmodelo.Text = _veiculo.Modelo;
            cmbcomb.Text = _veiculo.Combustivel;
            txtcor.Text = _veiculo.Cor;
            txtmotor.Text = _veiculo.Motorizacao;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtmarca.Text == null)
                {
                    MessageBox.Show("Favor informar os requisitos basicos do cadastro (Marca)");
                }
                if (txtfab.Text == null)
                {
                    MessageBox.Show("Favor informar os requisitos basicos do cadastro (Ano de Fabricação)");
                }
                if (txtmod.Text == null)
                {
                    MessageBox.Show("Favor informar os requisitos basicos do cadastro (Ano Modelo)");
                }
                if (txtmodelo.Text == null)
                {
                    MessageBox.Show("Favor informar os requisitos basicos do cadastro (Marca)");
                }
                if (cmbcomb.SelectedItem == null)
                {
                    MessageBox.Show("Favor informar os requisitos basicos do cadastro (Combustivel)");
                }
                else
                {
                    MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root; database=aircooled; password=master");
                    objcon.Open();
                    MySqlCommand objcmd = new MySqlCommand("INSERT INTO Veiculo(id_veiculo, id_membro, marca, modelo, fabricacao, anomodelo, combustivel, motorizacao, cor, apelido, observacoes) VALUES(null, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", objcon);

                    objcmd.Parameters.Add("@id_membro", MySqlDbType.Int32, 25).Value = _membroId;
                    objcmd.Parameters.Add("@marca", MySqlDbType.VarChar, 25).Value = txtmarca.Text;
                    objcmd.Parameters.Add("@modelo", MySqlDbType.VarChar, 25).Value = txtmodelo.Text;
                    objcmd.Parameters.Add("@fabricacao", MySqlDbType.VarChar, 4).Value = txtfab.Text;
                    objcmd.Parameters.Add("@anomodelo", MySqlDbType.VarChar, 4).Value = txtmod.Text;
                    objcmd.Parameters.Add("@combustivel", MySqlDbType.VarChar, 10).Value = cmbcomb.SelectedItem;
                    objcmd.Parameters.Add("@motorizacao", MySqlDbType.VarChar, 5).Value = txtmotor.Text;
                    objcmd.Parameters.Add("@cor", MySqlDbType.VarChar, 10).Value = txtcor.Text;
                    objcmd.Parameters.Add("@apelido", MySqlDbType.VarChar, 30).Value = txtapeli.Text;
                    objcmd.Parameters.Add("@observacoes", MySqlDbType.VarChar, 60).Value = txtobs.Text;

                    objcmd.ExecuteNonQuery();

                    objcon.Close();
                    Close();
                }
            }

            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmodelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnatu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmarca.Text == null)
                {
                    MessageBox.Show("Favor informar os requisitos basicos do cadastro (Marca)");
                }
                if (txtfab.Text == null)
                {
                    MessageBox.Show("Favor informar os requisitos basicos do cadastro (Ano de Fabricação)");
                }
                if (txtmod.Text == null)
                {
                    MessageBox.Show("Favor informar os requisitos basicos do cadastro (Ano Modelo)");
                }
                if (txtmodelo.Text == null)
                {
                    MessageBox.Show("Favor informar os requisitos basicos do cadastro (Marca)");
                }
                if (cmbcomb.SelectedItem == null)
                {
                    MessageBox.Show("Favor informar os requisitos basicos do cadastro (Combustivel)");
                }
                else
                {
                    MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root; database=aircooled; password=master");
                    objcon.Open();

                    MySqlCommand objcmd = new MySqlCommand("UPDATE Veiculo SET marca = @marca ,modelo=@modelo, fabricacao = @fabricacao, anomodelo = @anomodelo, combustivel = @combustivel, motorizacao = @motorizacao, cor = @cor, apelido = @apelido, observacoes = @observacoes WHERE id_veiculo = " + _veiculo.Codigo, objcon);

                    objcmd.Parameters.AddWithValue("@marca", txtmarca.Text);
                    objcmd.Parameters.AddWithValue("@modelo", txtmodelo.Text);
                    objcmd.Parameters.AddWithValue("@fabricacao", txtfab.Text);
                    objcmd.Parameters.AddWithValue("@anomodelo", txtmod.Text);
                    objcmd.Parameters.AddWithValue("@combustivel", cmbcomb.Text);
                    objcmd.Parameters.AddWithValue("@motorizacao", txtmotor.Text);
                    objcmd.Parameters.AddWithValue("@cor", txtcor.Text);
                    objcmd.Parameters.AddWithValue("@apelido", txtapeli.Text);
                    objcmd.Parameters.AddWithValue("@observacoes", txtobs.Text);

                    objcmd.ExecuteNonQuery();

                    objcon.Close();

                    Close();
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não Foi possivel adicionar este membro lista de erro: " + erro.Message);

            }
        }
    }
}
