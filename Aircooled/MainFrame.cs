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
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using MySql.Data.MySqlClient;
using System.Windows.Media.Animation;

namespace WindowsFormsApp2
{
    public partial class MainFrame : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private MySqlSdk _mysql = new MySqlSdk();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public MainFrame()
        {
            InitializeComponent();
            btnMaximize.Visible = false;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        public DataTable SelecionaIdMembro()
        {
            try
            {
                _mysql.Open();
                var query = _mysql.Command("Select id_membro, ult_parc_gerada from membro");
                _mysql.Close();
                return query;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                throw new Exception();
            }
        }

        public DataTable SelecionaDiaMembro()
        {
            try
            {
                _mysql.Open();
                var query = _mysql.Command("Select dia_venc from membro");
                _mysql.Close();
                return query;

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                throw new Exception();
            }
        }

        public DataTable SelecionaValor()
        {
            try
            {
                _mysql.Open();
                var query = _mysql.Command("Select valor from membro");
                _mysql.Close();
                return query;

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                throw new Exception();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMinimize.Visible = true;
            btnMaximize.Visible = false;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMinimize.Visible = false;
            btnMaximize.Visible = true;
        }

        private void btnGerador_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja realmente gerar as parcelas do mês " + DateTime.Today.Month + "/" + DateTime.Today.Year + " ?", "Gerador de Parcelas" , MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                var idmembro = SelecionaIdMembro();

                int ano = DateTime.Today.Year;
                int mes = DateTime.Today.Month;
                var dia = SelecionaDiaMembro();

                var valor = SelecionaValor();


                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root; database=aircooled; password=master");
                objcon.Open();
                for (int cont = 0; cont != idmembro.Rows.Count; cont++)
                {
                    if (Convert.ToInt32(idmembro.Rows[cont][1]) != mes )
                    {
                        String vencimento = $"{dia.Rows[cont][0]}-{mes}-{ano}";
                        MySqlCommand objcmd = new MySqlCommand("INSERT INTO FINANCEIRO(id_lancamento, id_membro, vencimento, pagamento, valor, emissao, tipo) VALUES(null, ?, ?, null, ?, ?, 'Receber')", objcon);

                        objcmd.Parameters.Add("@id_membro", MySqlDbType.Int32, 25).Value = idmembro.Rows[cont][0];
                        objcmd.Parameters.Add("@vencimento", MySqlDbType.DateTime, 25).Value = Convert.ToDateTime(vencimento);
                        objcmd.Parameters.Add("@valor", MySqlDbType.Decimal).Value = valor.Rows[cont][0];
                        objcmd.Parameters.Add("@emissao", MySqlDbType.DateTime).Value = DateTime.Today;

                        objcmd.ExecuteNonQuery();

                        objcmd = new MySqlCommand("UPDATE MEMBRO SET ULT_PARC_GERADA = ? WHERE ID_MEMBRO = ?", objcon);

                        objcmd.Parameters.Add("@ULT_PARC_GERADA", MySqlDbType.Int32, 2).Value = mes;
                        objcmd.Parameters.Add("@ID_MEMBRO", MySqlDbType.Int32, 25).Value = idmembro.Rows[cont][0];

                        objcmd.ExecuteNonQuery();
                    }

                }
                objcon.Close();
                MessageBox.Show("As parcelas do mês " + DateTime.Today.Month + "/" + DateTime.Today.Year + " já foram geradas.");
            }
            else if (dr == DialogResult.No)
            {
                MessageBox.Show("As parcelas não foram geradas.");
            }
        }

            private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<BrowserFinanceiro>();

        }

        private void btnMembro_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<BrowserMembros>();
            
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
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
                if (t.Equals(typeof(BrowserMembros)))
                    ((BrowserMembros)formulario).PainelMain(pnlConteudo);
                if (t.Equals(typeof(BrowserFinanceiro)))
                    ((BrowserFinanceiro)formulario).PainelMain(pnlConteudo);

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

        private void pnlConteudo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
