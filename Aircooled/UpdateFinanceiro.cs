using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using WindowsFormsApp2.Modelos;



namespace WindowsFormsApp2
{


    public partial class UpdateFinanceiro : Form
    {
        private Financeiro _financeiro;
        Panel pnlConteudo = null;
        Form formulario;

        public UpdateFinanceiro()
        {
        }

        public UpdateFinanceiro(Financeiro financeiro, String nomeDoMembro)
        {
            CUpdateFinanceiro(financeiro, nomeDoMembro);
        }
        public void CUpdateFinanceiro(Financeiro financeiro, String nomeDoMembro)
        {
            InitializeComponent();
            cmbTipo.SelectedItem = "Receber";
            txtNomeMembro.Text = nomeDoMembro;
            _financeiro = financeiro;
        }

        public void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {

            formulario = pnlConteudo.Controls.OfType<Forms>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                formulario.WindowState = FormWindowState.Normal;

                Type t = formulario.GetType();
                if (t.Equals(typeof(SelectMembro)))
                    ((SelectMembro)formulario).PainelMain(pnlConteudo);

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

        public void PainelMain(Panel pnlConteudo)
        {
            this.pnlConteudo = pnlConteudo;
        }


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



        private void BtnGravar_Click(object sender, EventArgs e) //VERIFICAR COMO MELHORAR COM O RENATO (PAGAMENTO PODE OU NAO SER PREENCHIDO PELO USUARIO)
        {
            if (txtIdMembro.Text == null)
            {
                MessageBox.Show("Favor informar o favorecido.");
            }
            else
            {
                
                try
                {
                    MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root; database=aircooled; password=master");
                    objcon.Open();

                    MySqlCommand objcmd = new MySqlCommand("INSERT INTO FINANCEIRO( id_lancamento, id_membro, vencimento, pagamento, valor, emissao, tipo) values (null, ?, ?, ?, ?, ?, ?)", objcon);
                   
                    DateTime pagamento = DateTime.ParseExact(txtPag.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    objcmd.Parameters.Add("@id_membro", MySqlDbType.Int32).Value = txtIdMembro.Text;
                    objcmd.Parameters.Add("@vencimento", MySqlDbType.Date, 12).Value = dateVenc.Value;
                    objcmd.Parameters.Add("@pagamento", MySqlDbType.Date, 12).Value = pagamento;
                    objcmd.Parameters.Add("@valor", MySqlDbType.Decimal).Value = numValor.Value;
                    objcmd.Parameters.Add("@emissao", MySqlDbType.Date, 12).Value = dateEmissao.Value;
                    objcmd.Parameters.Add("@tipo", MySqlDbType.VarChar).Value = cmbTipo.SelectedItem;
                    objcmd.ExecuteNonQuery();

                    objcon.Close();
                    ClearForm(this);
                    Close();
                }
                catch
                {
                    try { 
                    MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root; database=aircooled; password=master");
                    objcon.Open();

                    MySqlCommand objcmd = new MySqlCommand("INSERT INTO FINANCEIRO( id_lancamento, id_membro, vencimento, pagamento, valor, emissao, tipo) values (null, ?, ?, null, ?, ?, ?)", objcon);

                    objcmd.Parameters.Add("@id_membro", MySqlDbType.Int32).Value = txtIdMembro.Text;
                    objcmd.Parameters.Add("@vencimento", MySqlDbType.Date, 12).Value = dateVenc.Value;
                    objcmd.Parameters.Add("@valor", MySqlDbType.Decimal).Value = numValor.Value;
                    objcmd.Parameters.Add("@emissao", MySqlDbType.Date, 12).Value = dateEmissao.Value;
                    objcmd.Parameters.Add("@tipo", MySqlDbType.VarChar).Value = cmbTipo.SelectedItem;
                    objcmd.ExecuteNonQuery();

                    objcon.Close();
                    ClearForm(this);
                    Close();
                    }
                    catch(Exception erro)
                    {
                        MessageBox.Show("Não Foi possivel adicionar este membro lista de erro: " + erro.Message);
                    }
                }
            }
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtIdMembro.Text == null)
            {
                MessageBox.Show("Favor informar o favorecido.");
            }
            else
            {
                try
                {
                    
                    MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root; database=aircooled; password=master");
                    objcon.Open();

                    MySqlCommand objcmd = new MySqlCommand("UPDATE financeiro SET id_membro = @id_membro ,vencimento=@vencimento, pagamento = @pagamento, valor = @valor, emissao= @emissao, tipo = @tipo WHERE id_lancamento = " + _financeiro.Lancamento, objcon);

                    DateTime pagamento = DateTime.ParseExact(txtPag.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    objcmd.Parameters.Add("@id_membro", MySqlDbType.Int32).Value = txtIdMembro.Text;
                    objcmd.Parameters.Add("@vencimento", MySqlDbType.Date, 12).Value = dateVenc.Value;
                    objcmd.Parameters.Add("@pagamento", MySqlDbType.Date).Value = pagamento;
                    objcmd.Parameters.Add("@valor", MySqlDbType.Decimal).Value = numValor.Value;
                    objcmd.Parameters.Add("@emissao", MySqlDbType.Date, 12).Value = dateEmissao.Value;
                    objcmd.Parameters.Add("@tipo", MySqlDbType.VarChar).Value = cmbTipo.SelectedItem;

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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            ClearForm(this);
            Close();
        }

        private void FrmFinanceiro_Load(object sender, EventArgs e)
        {
            txtIdMembro.Text = _financeiro.Codigo.ToString();
            numValor.Value = _financeiro.Valor;
            dateEmissao.Value = _financeiro.Emissao;
            dateVenc.Value = _financeiro.Vencimento;
            txtPag.Text = _financeiro.Pagamento;
            cmbTipo.Text = _financeiro.Tipo;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<SelectMembro>();

        }

        private void txtIdMembro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
