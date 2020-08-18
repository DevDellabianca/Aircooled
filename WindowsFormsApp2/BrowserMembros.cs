using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using WindowsFormsApp2.Modelos;

namespace WindowsFormsApp2
{

    public partial class BrowserMembros : Form
    {
        Membro membro = new Membro();
        String tipoclick;
     /*   public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();*/

     
        private MySqlSdk _mysql;

        Panel pnlConteudo = null;

        public BrowserMembros()
        {

            InitializeComponent();
            this.dataGridView1.Font = new Font("Tahoma", 12);
            _mysql = new MySqlSdk();
            if(dataGridView1.Rows.Count == 0)
            {
                BtnVisu.Enabled = false;
                BtnAlter.Enabled = false;
                BtnDel.Enabled = false;
            }
            else
            {
                BtnVisu.Enabled = true;
                BtnAlter.Enabled = true;
                BtnDel.Enabled = true;
            }
        }

        public void PainelMain(Panel pnlConteudo)
        {
            this.pnlConteudo = pnlConteudo;
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

        public Int32 CodigoMem()
        {
            try
            {
                _mysql.Open();
                var query = _mysql.Command("SELECT MAX(id_membro) as Codigo FROM membro");

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
               
                Type t = formulario.GetType();
                if (t.Equals(typeof(UpdateMembro)))
                    ((UpdateMembro)formulario).PainelMain(pnlConteudo);

                if (tipoclick == "novo")
                {
                    membro = new Membro
                    {
                        Codigo = CodigoMem()
                    };
                    
                }
                else if (tipoclick == "visualizar")
                {
                    _mysql.Open();
                    var query = _mysql.CommandRow("Select id_membro, adesao, nome, sexo, nascimento, cpf, endereco, cidade, profissao, apelido, telefone, celular, email, estado, valor, dia_venc from membro where id_membro = " + dataGridView1.CurrentRow.Cells[0].Value); // NAO TESTADO

                    membro = new Membro
                    {
                        Codigo = Convert.ToInt32(query["id_membro"]),
                        Adesao = Convert.ToDateTime(query["adesao"]),
                        Nome = query["nome"].ToString(),
                        Sexo = query["sexo"].ToString(),
                        Nascimento = Convert.ToDateTime(query["nascimento"]),
                        Cpf = query["cpf"].ToString(),
                        Endereco = query["endereco"].ToString(),
                        Cidade = query["cidade"].ToString(),
                        Profissao = query["profissao"].ToString(),
                        Apelido = query["apelido"].ToString(),
                        Telefone = query["telefone"].ToString(),
                        Celular = query["celular"].ToString(),
                        Email = query["email"].ToString(),
                        Estado = query["estado"].ToString(),
                        Valor = Convert.ToDecimal(query["valor"]),
                        Dia_Venc = query["dia_venc"].ToString()
                    };

                    _mysql.Close();
                   // ((UpdateMembro)formulario).BtnAtualizar.Visible = false;
                   // ((UpdateMembro)formulario).BtnGravar.Visible = false;
                }
                else 
                {
                    _mysql.Open();
                    var query = _mysql.CommandRow("Select id_membro, adesao, nome, sexo, nascimento, cpf, endereco, cidade, profissao, apelido, telefone, celular, email, estado, valor, dia_venc from membro where id_membro = " + dataGridView1.CurrentRow.Cells[0].Value); // NAO TESTADO

                    membro = new Membro
                    {
                        Codigo = Convert.ToInt32(query["id_membro"]),
                        Adesao = Convert.ToDateTime(query["adesao"]),
                        Nome = query["nome"].ToString(),
                        Sexo = query["sexo"].ToString(),
                        Nascimento = Convert.ToDateTime(query["nascimento"]),
                        Cpf = query["cpf"].ToString(),
                        Endereco = query["endereco"].ToString(),
                        Cidade = query["cidade"].ToString(),
                        Profissao = query["profissao"].ToString(),
                        Apelido = query["apelido"].ToString(),
                        Telefone = query["telefone"].ToString(),
                        Celular = query["celular"].ToString(),
                        Email = query["email"].ToString(),
                        Estado = query["estado"].ToString(),
                        Valor = Convert.ToDecimal(query["valor"]),
                        Dia_Venc = query["dia_venc"].ToString()
                    };
                    _mysql.Close();
                    
                }


                ((UpdateMembro)formulario).CUpdateMembro(membro);

                pnlConteudo.Controls.Add(formulario);
                pnlConteudo.Tag = formulario;
                if(tipoclick == "novo")
                {
                    ((UpdateMembro)formulario).BtnVeiculo.Visible = false;
                    ((UpdateMembro)formulario).BtnGravar.Visible = true;
                    ((UpdateMembro)formulario).BtnAtualizar.Visible = false;
                }

                 else if(tipoclick == "visualizar")
                 {
                    ((UpdateMembro)formulario).BtnVeiculo.Visible = true;
                    ((UpdateMembro)formulario).BtnAtualizar.Visible = false;
                     ((UpdateMembro)formulario).BtnGravar.Visible = false;
                 }
                 else
                 {
                    ((UpdateMembro)formulario).BtnVeiculo.Visible = true;
                    ((UpdateMembro)formulario).BtnAtualizar.Visible = true;
                    ((UpdateMembro)formulario).BtnGravar.Visible = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            tipoclick = "novo";
            AbrirFormNoPanel<UpdateMembro>();
            /*var membro = new Membro
            {
                Codigo = CodigoMem()
            };
            _frmMembro = new UpdateMembro(membro);

            pnlConteudo.Controls.Add(_frmMembro);
            pnlConteudo.Tag = _frmMembro;

            _frmMembro.Show();
            _frmMembro.BringToFront();*/

            //_frmMembro.BtnAtualizar.Visible = false;
            //_frmMembro.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                tipoclick = "visualizar";
                AbrirFormNoPanel<UpdateMembro>();

                
               /* _frmMembro.BtnGravar.Visible = false;
                _frmMembro.BtnAtualizar.Visible = false;
                _frmMembro.ShowDialog();*/

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                throw new Exception();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                throw new Exception();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                

                if(txtDescricao.Text == "" || cbmFiltro.Text == "")
                {
                    dataGridView1.DataSource = SelecionaMembro();
                }
                else 
                { 
                dataGridView1.DataSource = SelecionarComFiltro();
                }
                if (dataGridView1.Rows.Count == 0)
                {
                    BtnVisu.Enabled = false;
                    BtnAlter.Enabled = false;
                    BtnDel.Enabled = false;
                }
                else
                {
                    BtnVisu.Enabled = true;
                    BtnAlter.Enabled = true;
                    BtnDel.Enabled = true;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                throw new Exception();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
                DeletarRegistro();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try {
                AlterarRegistro();
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
                tipoclick = "alterar";

                AbrirFormNoPanel<UpdateMembro>();

                /*_frmMembro = new UpdateMembro(membro);
                _frmMembro.BtnGravar.Visible = false;
                _frmMembro.ShowDialog();*/
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                throw new Exception();
            }
        }

        private void DeletarRegistro ()
        {

            try
            {
                DialogResult confirm = MessageBox.Show("Deseja Realmente Excluir este Membro?", "Confirmação do Usuário", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (confirm.ToString().ToUpper() == "YES")
                {
                    _mysql.Open();
                    var query = _mysql.Command("DELETE FROM MEMBRO WHERE id_membro = " + dataGridView1.CurrentRow.Cells[0].Value);
                   // query = _mysql.Command("DELETE FROM MEMBRO WHERE id_membro = " + dataGridView1.CurrentRow.Cells[0].Value);
                    _mysql.Close();
                    dataGridView1.DataSource = SelecionaMembro();
                    if (dataGridView1.Rows.Count == 0)
                    {
                        BtnVisu.Enabled = false;
                        BtnAlter.Enabled = false;
                        BtnDel.Enabled = false;
                    }
                    else
                    {
                        BtnVisu.Enabled = true;
                        BtnAlter.Enabled = true;
                        BtnDel.Enabled = true;
                    }
                }




            }
            catch (ApplicationException erro)
            {
                MessageBox.Show(erro.Message);
            }
            catch (SystemException erro)
            {
                MessageBox.Show("Este membro possui financeiros gerados, não será possivel sua exclusão.");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BrowserMembros_Load(object sender, EventArgs e)
        {
            
        }

       /* private void BrowserMembros_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }*/
    }
}
