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
    public partial class SelectMembro : Form
    {
        
        Panel pnlConteudo = null;

        private MySqlSdk _mysql;

        public  SelectMembro()

        {
            
            _mysql = new MySqlSdk();
            InitializeComponent();
            dataGridView1.Font = new Font("Tahoma", 12);
        }

        public void PainelMain(Panel pnlConteudo)
        {
            this.pnlConteudo = pnlConteudo;
        }

        private void SelectMembro_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SelecionaMembro();
        }

        public DataTable SelecionaMembro()
        {
            try
            {
                _mysql.Open();
                var query = _mysql.Command("SELECT id_membro as Numero, Nome, Endereco, Cidade, Telefone, Email FROM membro");
                _mysql.Close();
                return query;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                throw new Exception();
            }
        }

        private void BtnFiltro_Click(object sender, EventArgs e)
        {
            try 
            { 
            dataGridView1.DataSource = SelecionarComFiltro();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable SelecionarComFiltro()
        {
            try
            {
                _mysql.Open();
                var query = _mysql.Command("SELECT id_membro as Numero, Nome, Endereco, Cidade, Telefone, Email FROM membro where " + cbmFiltro.Text + " like '%" + txtDescricao.Text + "%';");
                _mysql.Close();
                return query;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                throw new Exception();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateFinanceiro.txtNomeMembro.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            UpdateFinanceiro.txtIdMembro.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.Close();
        }
    }
}
