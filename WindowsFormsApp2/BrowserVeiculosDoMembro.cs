using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Modelos;

namespace WindowsFormsApp2
{

    public partial class BrowserVeiculosDoMembro : Form
    {
        Veiculo veiculo = new Veiculo();
        private MySqlSdk _mysql;
        Panel pnlConteudo = null;
        String tipoclick;
        public Int32 CodigoVeic()
        {
            try
            {
                _mysql = new MySqlSdk();
                _mysql.Open();
                var query = _mysql.Command("SELECT MAX(id_veiculo) as Codigo FROM veiculo where id_membro = " + _membroId);

                _mysql.Close();
                var codigo = query.Rows[0]["Codigo"]; //pega o valor do retorno
                return Convert.IsDBNull(codigo) ? 1 : (int)codigo + 1; //verifica se o retorno e dbnull(nao tem resgistro) retorno 1 e se nao for dbnull soma mais 1
                                                                       //return dt.Rows[0]["Codigo"];




            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                throw new Exception();
            }
        }

        private int _membroId;

        public DataTable SelecionarVeiculo()
        {
            try
            {
                _mysql.Open();
                var query = _mysql.Command("SELECT id_veiculo as Numero, Apelido, Marca, Cor, Modelo FROM veiculo where id_membro = " + _membroId);
                _mysql.Close();
                return query;
            }
            catch
            {
                throw new Exception();
            }
        }

        public void CBrowserVeiculosDoMembro(int membroId)
        {
            InitializeComponent();
            this.dataGridView1.Font = new Font("Tahoma", 12);
            _mysql = new MySqlSdk();
            if (dataGridView1.Rows.Count == 0)
            {
                BtnVisualizar.Enabled = false;
                BtnAlterar.Enabled = false;
                BtnExcluir.Enabled = false;
            }
            else
            {
                BtnVisualizar.Enabled = true;
                BtnAlterar.Enabled = true;
                BtnExcluir.Enabled = true;
            }
            _membroId = membroId; 
        }

        public BrowserVeiculosDoMembro()
        {
        }

        public BrowserVeiculosDoMembro(int membroId)
        {
            CBrowserVeiculosDoMembro(membroId);
            this.dataGridView1.Font = new Font("Tahoma", 12);
            //_membroId = membroId;
            if (dataGridView1.Rows.Count == 0)
            {
                BtnAlterar.Enabled = false;
                BtnExcluir.Enabled = false;
                BtnVisualizar.Enabled = false;
            }
            else
            {
                BtnAlterar.Enabled = true;
                BtnExcluir.Enabled = true;
                BtnVisualizar.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tipoclick = "novo";
            AbrirFormNoPanel<UpdateVeiculoDoMembro>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeletarRegistro();
        }

        private void BrowserVeiculosDoMembro_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try { 
            dataGridView1.DataSource = SelecionarVeiculo();
                if (dataGridView1.Rows.Count == 0)
                {
                    BtnAlterar.Enabled = false;
                    BtnExcluir.Enabled = false;
                    BtnVisualizar.Enabled = false;
                }
                else
                {
                    BtnAlterar.Enabled = true;
                    BtnExcluir.Enabled = true;
                    BtnVisualizar.Enabled = true;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                tipoclick = "visualizar";
                AbrirFormNoPanel<UpdateVeiculoDoMembro>();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                throw new Exception();
            }

        }


        public void PainelMain(Panel pnlConteudo)
        {
            this.pnlConteudo = pnlConteudo;
        }


        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = pnlConteudo.Controls.OfType<Forms>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                formulario.WindowState = FormWindowState.Normal;

               /* Type t = formulario.GetType();
                if (t.Equals(typeof(UpdateVeiculoDoMembro)))
                    ((UpdateVeiculoDoMembro)formulario).PainelMain(pnlConteudo);*/
                
                if (tipoclick == "novo")
                {
                    veiculo = new Veiculo
                    {
                        Codigo = CodigoVeic()
                    };
                }
                else if (tipoclick == "visualizar")
                {
                    _mysql.Open();
                    var query = _mysql.CommandRow("select marca, modelo, fabricacao, anomodelo, combustivel, motorizacao, cor, apelido, observacoes from veiculo where id_veiculo = " + dataGridView1.CurrentRow.Cells[0].Value); // NAO TESTADO

                    veiculo = new Veiculo
                    {
                        Marca = query["marca"].ToString(),
                        Modelo = query["modelo"].ToString(),
                        Fabricacao = query["fabricacao"].ToString(),
                        AnoModelo = query["anomodelo"].ToString(),
                        Combustivel = query["combustivel"].ToString(),
                        Motorizacao = query["motorizacao"].ToString(),
                        Cor = query["cor"].ToString(),
                        Apelido = query["apelido"].ToString(),
                        Observacoes = query["observacoes"].ToString(),

                    };
                    _mysql.Close();
                    // ((UpdateMembro)formulario).BtnAtualizar.Visible = false;
                    // ((UpdateMembro)formulario).BtnGravar.Visible = false;
                }
                else
                {
                    _mysql.Open();
                    var query = _mysql.CommandRow("select id_veiculo,marca, modelo, fabricacao, anomodelo, combustivel, motorizacao, cor, apelido, observacoes from veiculo where id_veiculo = " + dataGridView1.CurrentRow.Cells[0].Value);
                    veiculo = new Veiculo
                    {
                        Codigo = Convert.ToInt32(query["id_veiculo"]),
                        Marca = query["marca"].ToString(),
                        Modelo = query["modelo"].ToString(),
                        Fabricacao = query["fabricacao"].ToString(),
                        AnoModelo = query["anomodelo"].ToString(),
                        Combustivel = query["combustivel"].ToString(),
                        Motorizacao = query["motorizacao"].ToString(),
                        Cor = query["cor"].ToString(),
                        Apelido = query["apelido"].ToString(),
                        Observacoes = query["observacoes"].ToString(),

                    };
                    _mysql.Close();

                }


                ((UpdateVeiculoDoMembro)formulario).CUpdateVeiculoDoMembro(_membroId, veiculo);

                pnlConteudo.Controls.Add(formulario);
                pnlConteudo.Tag = formulario;
                if (tipoclick == "novo")
                {
                    ((UpdateVeiculoDoMembro)formulario).BtnGravar.Visible = true;
                    ((UpdateVeiculoDoMembro)formulario).BtnAtu.Visible = false;
                }

                else if (tipoclick == "visualizar")
                {
                    ((UpdateVeiculoDoMembro)formulario).BtnAtu.Visible = false;
                    ((UpdateVeiculoDoMembro)formulario).BtnGravar.Visible = false;
                }
                else
                {
                    ((UpdateVeiculoDoMembro)formulario).BtnAtu.Visible = true;
                    ((UpdateVeiculoDoMembro)formulario).BtnGravar.Visible = false;
                }

                formulario.Show();

                formulario.BringToFront();
            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                    formulario.WindowState = FormWindowState.Normal;
                formulario.BringToFront();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlterarRegistro();
        }
        private void DeletarRegistro() 
        {
            try
            {
                DialogResult confirm = MessageBox.Show("Deseja Realmente Excluir o Veiculo?", "Confirmação do Veiculo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (confirm.ToString().ToUpper() == "YES")
                {              
                    _mysql = new MySqlSdk();
                    _mysql.Open();
                    var query = _mysql.Command("DELETE FROM veiculo WHERE id_veiculo = " + dataGridView1.CurrentRow.Cells[0].Value);
                    _mysql.Close();
                    dataGridView1.DataSource = SelecionarVeiculo();
                    if (dataGridView1.Rows.Count == 0)
                    {
                        BtnAlterar.Enabled = false;
                        BtnExcluir.Enabled = false;
                        BtnVisualizar.Enabled = false;
                    }
                    else
                    {
                        BtnAlterar.Enabled = true;
                        BtnExcluir.Enabled = true;
                        BtnVisualizar.Enabled = true;
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                throw new Exception();
            }
        }

        private void AlterarRegistro()
        {
            try
            {
                tipoclick = "";
                AbrirFormNoPanel<UpdateVeiculoDoMembro>();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                throw new Exception();
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                AlterarRegistro();
            }
            if (e.KeyCode == Keys.Delete)
            {
                DeletarRegistro();
            }
        }

        private void BrowserVeiculosDoMembro_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
