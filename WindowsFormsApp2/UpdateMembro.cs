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
    public partial class UpdateMembro : Form
    {
        private Membro _membro;

        public static void ClearForm(System.Windows.Forms.Control parent)//ClearForm
        {
            foreach (System.Windows.Forms.Control ctrControl in parent.Controls)
            {
                //Loop through all controls
                if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.TextBox)))
                {
                    //Check to see if it's a textbox
                    ((System.Windows.Forms.TextBox)ctrControl).Text = string.Empty;
                    //If it is then set the text to String.Empty (empty textbox)
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RichTextBox)))
                {
                    //If its a RichTextBox clear the text
                    ((System.Windows.Forms.RichTextBox)ctrControl).Text = string.Empty;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.ComboBox)))
                {
                    //Next check if it's a dropdown list
                    ((System.Windows.Forms.ComboBox)ctrControl).SelectedIndex = -1;
                    //If it is then set its SelectedIndex to 0
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.CheckBox)))
                {
                    //Next uncheck all checkboxes
                    ((System.Windows.Forms.CheckBox)ctrControl).Checked = false;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RadioButton)))
                {
                    //Unselect all RadioButtons
                    ((System.Windows.Forms.RadioButton)ctrControl).Checked = false;
                }
                if (ctrControl.Controls.Count > 0)
                {
                    //Call itself to get all other controls in other containers
                    ClearForm(ctrControl);
                }
            }
        }
        Panel pnlConteudo = null;
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

                Type t = formulario.GetType();
                if (t.Equals(typeof(BrowserVeiculosDoMembro)))
                    ((BrowserVeiculosDoMembro)formulario).PainelMain(pnlConteudo);

                ((BrowserVeiculosDoMembro)formulario).CBrowserVeiculosDoMembro(_membro.Codigo);

                pnlConteudo.Controls.Add(formulario);
                pnlConteudo.Tag = formulario;

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

        public UpdateMembro()
        {
        }
        public UpdateMembro(Membro membro)
        {
            CUpdateMembro(membro);
        }


        public void CUpdateMembro(Membro membro)
        {
            InitializeComponent();

            _membro = membro;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<BrowserVeiculosDoMembro>();
            //var veic = new BrowserVeiculosDoMembro(_membro.Codigo);
           // this.AddOwnedForm(veic);
            //veic.ShowDialog();
        }

        private void FrmMembro_Load(object sender, EventArgs e)
        {
            txtnumero.Text = _membro.Codigo.ToString();
            dateadesao.Value = _membro.Adesao;
            txtnome.Text = _membro.Nome;
            cmbsexo.Text = _membro.Sexo;
            datenasc.Value = _membro.Nascimento;
            txtcpf.Text = _membro.Cpf;
            txtend.Text = _membro.Endereco;
            txtcidade.Text = _membro.Cidade;
            txtprof.Text = _membro.Profissao;
            txtapelido.Text = _membro.Apelido;
            txttel.Text = _membro.Telefone;
            txtcel.Text = _membro.Celular;
            txtemail.Text = _membro.Email;
            cmbestado.Text = _membro.Estado;
            nummensal.Value = _membro.Valor;
            TxtVencimento.Text = _membro.Dia_Venc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearForm(this);
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnome.Text == null)
            {
                MessageBox.Show("Favor informar os requisitos basicos do cadastro (Nome)");
            }
            if (cmbsexo.SelectedItem == null)
            {
                MessageBox.Show("Favor informar os requisitos basicos do cadastro (Sexo)");
            }
            if (cmbestado.SelectedItem == null)
            {
                MessageBox.Show("Favor informar os requisitos basicos do cadastro (Estado)");
            }
            if (TxtVencimento.Text == null)
            {
                MessageBox.Show("Favor informar os requisitos basicos do cadastro (Dia De Vencimento)");
            }
            else
            {
                try
                {
                    MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root; database=aircooled; password=master");
                    objcon.Open();

                    

                    MySqlCommand objcmd = new MySqlCommand("INSERT INTO MEMBRO(id_membro, adesao, nome, sexo, nascimento, cpf, endereco, cidade, profissao, apelido, telefone, celular, email, estado, valor, dia_venc) VALUES( ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", objcon);

                    objcmd.Parameters.Add("@id_membro", MySqlDbType.Int64, 4).Value = txtnumero.Text;
                    objcmd.Parameters.Add("@adesao", MySqlDbType.DateTime, 12).Value = dateadesao.Value;
                    objcmd.Parameters.Add("@nome", MySqlDbType.VarChar, 60).Value = txtnome.Text;
                    objcmd.Parameters.Add("@sexo", MySqlDbType.VarChar, 10).Value = cmbsexo.SelectedItem;
                    objcmd.Parameters.Add("@nascimento", MySqlDbType.DateTime, 12).Value = datenasc.Value;
                    objcmd.Parameters.Add("@cpf", MySqlDbType.VarChar, 11).Value = txtcpf.Text;
                    objcmd.Parameters.Add("@endereco", MySqlDbType.VarChar, 60).Value = txtend.Text;
                    objcmd.Parameters.Add("@cidade", MySqlDbType.VarChar, 25).Value = txtcidade.Text;
                    objcmd.Parameters.Add("@profissao", MySqlDbType.VarChar, 30).Value = txtprof.Text;
                    objcmd.Parameters.Add("@apelido", MySqlDbType.VarChar, 60).Value = txtapelido.Text;
                    objcmd.Parameters.Add("@telefone", MySqlDbType.VarChar, 11).Value = txttel.Text;
                    objcmd.Parameters.Add("@celular", MySqlDbType.VarChar, 11).Value = txtcel.Text;
                    objcmd.Parameters.Add("@email", MySqlDbType.VarChar, 60).Value = txtemail.Text;
                    objcmd.Parameters.Add("@estado", MySqlDbType.VarChar, 10).Value = cmbestado.SelectedItem;
                    objcmd.Parameters.Add("@valor", MySqlDbType.Decimal).Value = nummensal.Value;
                    objcmd.Parameters.Add("@dia_venc", MySqlDbType.VarChar, 2).Value = TxtVencimento.Text;                 

                    objcmd.ExecuteNonQuery();

                    objcon.Close();
                    ClearForm(this);
                    Close();
                    
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Não Foi possivel adicionar este membro lista de erro: " + erro.Message);

                }
            }
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void combosexo_SelectedIndexChanged(object sender, EventArgs e)
        {
     
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtnome.Text == null)
            {
                MessageBox.Show("Favor informar os requisitos basicos do cadastro (Nome)");
            }
            if (cmbsexo.SelectedItem == null)
            {
                MessageBox.Show("Favor informar os requisitos basicos do cadastro (Sexo)");
            }
            if (cmbestado.SelectedItem == null)
            {
                MessageBox.Show("Favor informar os requisitos basicos do cadastro (Estado)");
            }
            if (TxtVencimento.Text == null)
            {
                MessageBox.Show("Favor informar os requisitos basicos do cadastro (Dia De Vencimento)");
            }
            else
            {
                try
                {
                    MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root; database=aircooled; password=master");
                    objcon.Open();
                    
                    MySqlCommand objcmd = new MySqlCommand("UPDATE MEMBRO SET adesao = @adesao ,nome=@nome, sexo = @sexo, nascimento = @nascimento, cpf = @cpf, endereco = @endereco, cidade = @cidade, profissao = @profissao, apelido = @apelido, telefone = @telefone, celular = @celular, email = @email , estado = @estado, valor = @valor, dia_venc = @dia_venc WHERE id_membro = " + txtnumero.Text, objcon);
                    
                    objcmd.Parameters.Add("@adesao", MySqlDbType.DateTime, 12).Value = dateadesao.Value;
                    objcmd.Parameters.AddWithValue("@nome", txtnome.Text);
                    objcmd.Parameters.Add("@sexo", MySqlDbType.VarChar, 10).Value = cmbsexo.SelectedItem;
                    objcmd.Parameters.Add("@nascimento", MySqlDbType.DateTime, 12).Value = datenasc.Value;
                    objcmd.Parameters.Add("@cpf", MySqlDbType.VarChar, 11).Value = txtcpf.Text;
                    objcmd.Parameters.Add("@endereco", MySqlDbType.VarChar, 60).Value = txtend.Text;
                    objcmd.Parameters.Add("@cidade", MySqlDbType.VarChar, 25).Value = txtcidade.Text;
                    objcmd.Parameters.Add("@profissao", MySqlDbType.VarChar, 30).Value = txtprof.Text;
                    objcmd.Parameters.Add("@apelido", MySqlDbType.VarChar, 60).Value = txtapelido.Text;
                    objcmd.Parameters.Add("@telefone", MySqlDbType.VarChar, 11).Value = txttel.Text;
                    objcmd.Parameters.Add("@celular", MySqlDbType.VarChar, 11).Value = txtcel.Text;
                    objcmd.Parameters.Add("@email", MySqlDbType.VarChar, 60).Value = txtemail.Text;
                    objcmd.Parameters.Add("@estado", MySqlDbType.VarChar, 10).Value = cmbestado.SelectedItem;
                    objcmd.Parameters.Add("@valor", MySqlDbType.Decimal).Value = nummensal.Value;
                    objcmd.Parameters.Add("@dia_venc", MySqlDbType.VarChar, 2).Value = TxtVencimento.Text;

                    objcmd.ExecuteNonQuery();
                    
                    objcon.Close();
                    
                    ClearForm(this);
                    Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Não Foi possivel adicionar este membro lista de erro: " + erro.Message);

                }
            }
        }

        private void DatePagamento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
 
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void cmbestado_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void nummensal_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtVencimento_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
