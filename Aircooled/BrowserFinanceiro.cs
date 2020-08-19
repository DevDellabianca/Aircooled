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
    public partial class BrowserFinanceiro : Form
    {
        Financeiro financeiro = new Financeiro();
     
        private MySqlSdk _mysql;
        Panel pnlConteudo = null;
        String tipoclick;
        public BrowserFinanceiro()
        {
            _mysql = new MySqlSdk();
            InitializeComponent();
            CmbPag.SelectedItem = "A Pagar";
            cmbTipo.SelectedItem = "Todos";
            CmbFiltro.SelectedItem = "Nome";
            this.dataGridView1.Font = new Font("Tahoma", 12);
            dataGridView1.DataSource = SelecionarFinanceiro();
            if (dataGridView1.Rows.Count == 0)
            {
                BtnVisu.Enabled = false;
                BtnAlter.Enabled = false;
                BtnDel.Enabled = false;
                BtnBaixar.Enabled = false;
                btnReabrir.Enabled = false;
            }
            else
            {
                BtnVisu.Enabled = true;
                BtnAlter.Enabled = true;
                BtnDel.Enabled = true;
                BtnBaixar.Enabled = true;
                btnReabrir.Enabled = true;
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
                String nomeDoMembro;

                Type t = formulario.GetType();
                if (t.Equals(typeof(UpdateFinanceiro)))
                    ((UpdateFinanceiro)formulario).PainelMain(pnlConteudo);

                if (tipoclick == "novo")
                {
                    nomeDoMembro = null;
                    financeiro = new Financeiro();
                    //usuario clicou em novo
                }
                else if (tipoclick == "visualizar")
                {
                    nomeDoMembro = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    _mysql.Open();
                    var query = _mysql.CommandRow("Select id_lancamento,id_membro, vencimento, pagamento, valor, emissao, tipo from financeiro where id_lancamento = " + dataGridView1.CurrentRow.Cells[0].Value);
                    financeiro = new Financeiro
                    {
                        Lancamento = Convert.ToInt32(query["id_lancamento"]),
                        Codigo = Convert.ToInt32(query["id_membro"]),
                        Vencimento = Convert.ToDateTime(query["vencimento"]),
                        Pagamento = query["pagamento"].ToString(),
                        Valor = Convert.ToDecimal(query["valor"]),
                        Emissao = Convert.ToDateTime(query["emissao"]),
                        Tipo = query["tipo"].ToString(),
                    };
                    _mysql.Close();
                }
                else
                {
                    nomeDoMembro = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    _mysql.Open();
                    var query = _mysql.CommandRow("Select id_lancamento,id_membro, vencimento, pagamento, valor, emissao, tipo from financeiro where id_lancamento = " + dataGridView1.CurrentRow.Cells[0].Value);

                    financeiro = new Financeiro
                    {
                        Lancamento = Convert.ToInt32(query["id_lancamento"]),
                        Codigo = Convert.ToInt32(query["id_membro"]),
                        Vencimento = Convert.ToDateTime(query["vencimento"]),
                        Pagamento = query["pagamento"].ToString(),
                        Valor = Convert.ToDecimal(query["valor"]),
                        Emissao = Convert.ToDateTime(query["emissao"]),
                        Tipo = query["tipo"].ToString(),
                    };
                    _mysql.Close();

                }


                ((UpdateFinanceiro)formulario).CUpdateFinanceiro(financeiro, nomeDoMembro);

                pnlConteudo.Controls.Add(formulario);
                pnlConteudo.Tag = formulario;
                if (tipoclick == "novo")
                {
                    ((UpdateFinanceiro)formulario).BtnAtualizar.Visible = false;
                }

                else if (tipoclick == "visualizar")
                {
                    ((UpdateFinanceiro)formulario).BtnAtualizar.Visible = false;
                    ((UpdateFinanceiro)formulario).BtnGravar.Visible = false;
                }
                else
                {
                    ((UpdateFinanceiro)formulario).BtnGravar.Visible = false;
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
        public DataTable SelecionarComFiltro()
        {
            try 
            { 
                if (cmbTipo.SelectedItem.ToString() == "Todos")
                {
                    if (CmbPag.SelectedItem == null)
                    {
                        _mysql.Open();
                        var query = _mysql.Command("select f.id_lancamento as Numero,m.nome,f.tipo,f.valor,f.vencimento,f.pagamento from financeiro as f inner join membro as m on f.id_membro = m.id_membro where f.pagamento is null and m.nome like '%" + txtDescricao.Text + "%' order by vencimento, nome;");
                        _mysql.Close();
                        return query;
                    }
                    if (CmbPag.SelectedItem.ToString() == "A Pagar")
                    {
                        _mysql.Open();
                        var query = _mysql.Command("select f.id_lancamento as Numero,m.nome,f.tipo,f.valor,f.vencimento,f.pagamento from financeiro as f inner join membro as m on f.id_membro = m.id_membro where f.pagamento is null and m.nome like '%" + txtDescricao.Text + "%' order by vencimento, nome;");
                        _mysql.Close();
                        return query;
                    }
                    else if (CmbPag.SelectedItem.ToString() == "Pago")
                    {
                        _mysql.Open();
                        var query = _mysql.Command("select f.id_lancamento as Numero,m.nome,f.tipo,f.valor,f.vencimento,f.pagamento from financeiro as f inner join membro as m on f.id_membro = m.id_membro where f.pagamento is not null and m.nome like '%" + txtDescricao.Text + "%' order by vencimento, nome;");
                        _mysql.Close();
                        return query;
                    }
                    else
                    {
                        _mysql.Open();
                        var query = _mysql.Command("select f.id_lancamento as Numero,m.nome,f.tipo,f.valor,f.vencimento,f.pagamento from financeiro as f inner join membro as m on f.id_membro = m.id_membro where m.nome like '%" + txtDescricao.Text + "%' order by vencimento, nome;");
                        _mysql.Close();
                        return query;
                    }
                    
                }
                else
                {
                    String tipo = cmbTipo.SelectedItem.ToString();
                    if (CmbPag.SelectedItem == null)
                    {
                        _mysql.Open();
                        var query = _mysql.Command("select f.id_lancamento as Numero,m.nome,f.tipo,f.valor,f.vencimento,f.pagamento from financeiro as f inner join membro as m on f.id_membro = m.id_membro where f.tipo = '" + tipo + "'  and f.pagamento is null and m.nome like '%" + txtDescricao.Text + "%' order by vencimento, nome;");
                        _mysql.Close();
                        return query;
                    }
                    if (CmbPag.SelectedItem.ToString() == "A Pagar")
                    {
                        _mysql.Open();
                        var query = _mysql.Command("select f.id_lancamento as Numero,m.nome,f.tipo,f.valor,f.vencimento,f.pagamento from financeiro as f inner join membro as m on f.id_membro = m.id_membro where f.tipo = '" + tipo + "'  and f.pagamento is null and m.nome like '%" + txtDescricao.Text + "%' order by vencimento, nome;");
                        _mysql.Close();
                        return query;
                    }
                    else if (CmbPag.SelectedItem.ToString() == "Pago")
                    {
                        _mysql.Open();
                        var query = _mysql.Command("select f.id_lancamento as Numero,m.nome,f.tipo,f.valor,f.vencimento,f.pagamento from financeiro as f inner join membro as m on f.id_membro = m.id_membro where f.tipo = '" + tipo + "'  and f.pagamento is not null and m.nome like '%" + txtDescricao.Text + "%' order by vencimento, nome;");
                        _mysql.Close();
                        return query;
                    }
                    else
                    {
                        _mysql.Open();
                        var query = _mysql.Command("select f.id_lancamento as Numero,m.nome,f.tipo,f.valor,f.vencimento,f.pagamento from financeiro as f inner join membro as m on f.id_membro = m.id_membro where f.tipo = '" + tipo + "'  and m.nome like '%" + txtDescricao.Text + "%' order by vencimento, nome;");
                        _mysql.Close();
                        return query;
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                throw new Exception();
            }
        }



        public DataTable SelecionarFinanceiro()
        {
            try
            {
                if (cmbTipo.SelectedItem.ToString() == "Todos")
                {
                    if (CmbPag.SelectedItem == null)
                    {
                        _mysql.Open();
                        var query = _mysql.Command("select f.id_lancamento as Numero,m.nome,f.tipo,f.valor,f.vencimento,f.pagamento from financeiro as f inner join membro as m on f.id_membro = m.id_membro where f.pagamento is null order by vencimento, nome;");
                        _mysql.Close();
                        return query;
                    }
                    if (CmbPag.SelectedItem.ToString() == "A Pagar")
                    {
                        _mysql.Open();
                        var query = _mysql.Command("select f.id_lancamento as Numero,m.nome,f.tipo,f.valor,f.vencimento,f.pagamento from financeiro as f inner join membro as m on f.id_membro = m.id_membro where f.pagamento is null order by vencimento, nome;");
                        _mysql.Close();
                        return query;
                    }
                    else if (CmbPag.SelectedItem.ToString() == "Pago")
                    {
                        _mysql.Open();
                        var query = _mysql.Command("select f.id_lancamento as Numero,m.nome,f.tipo,f.valor,f.vencimento,f.pagamento from financeiro as f inner join membro as m on f.id_membro = m.id_membro where f.pagamento is not null order by vencimento, nome;");
                        _mysql.Close();
                        return query;
                    }
                    else
                    {
                        _mysql.Open();
                        var query = _mysql.Command("select f.id_lancamento as Numero,m.nome,f.tipo,f.valor,f.vencimento,f.pagamento from financeiro as f inner join membro as m on f.id_membro = m.id_membro order by vencimento, nome;");
                        _mysql.Close();
                        return query;
                    }
                }
                else 
                { 
                    String tipo = cmbTipo.SelectedItem.ToString();
                    if (CmbPag.SelectedItem == null)
                    {
                        _mysql.Open();
                        var query = _mysql.Command("select f.id_lancamento as Numero,m.nome,f.tipo,f.valor,f.vencimento,f.pagamento from financeiro as f inner join membro as m on f.id_membro = m.id_membro where f.tipo = '" + tipo + "'  and f.pagamento is null order by vencimento, nome;");
                        _mysql.Close();
                        return query;
                    }
                    if (CmbPag.SelectedItem.ToString() == "A Pagar")
                    {
                        _mysql.Open();
                        var query = _mysql.Command("select f.id_lancamento as Numero,m.nome,f.tipo,f.valor,f.vencimento,f.pagamento from financeiro as f inner join membro as m on f.id_membro = m.id_membro where f.tipo = '" + tipo + "'  and f.pagamento is null order by vencimento, nome;");
                        _mysql.Close();
                        return query;
                    }
                    else if (CmbPag.SelectedItem.ToString() == "Pago")
                    {
                        _mysql.Open();
                        var query = _mysql.Command("select f.id_lancamento as Numero,m.nome,f.tipo,f.valor,f.vencimento,f.pagamento from financeiro as f inner join membro as m on f.id_membro = m.id_membro where f.tipo = '" + tipo + "'  and f.pagamento is not null order by vencimento, nome;");
                        _mysql.Close();
                        return query;
                    }
                    else
                    {
                        _mysql.Open();
                        var query = _mysql.Command("select f.id_lancamento as Numero,m.nome,f.tipo,f.valor,f.vencimento,f.pagamento from financeiro as f inner join membro as m on f.id_membro = m.id_membro where f.tipo = '" + tipo + "' order by vencimento, nome;");
                        _mysql.Close();
                        return query;
                    }
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                throw new Exception();
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            tipoclick = "novo";
            AbrirFormNoPanel<UpdateFinanceiro>();
        }


        private void BtnVisu_Click(object sender, EventArgs e)
        {
            tipoclick = "visualizar";
            AbrirFormNoPanel<UpdateFinanceiro>();
        }
       
        private void BtnAlter_Click(object sender, EventArgs e)
        {
            tipoclick = "Alterar";
            AbrirFormNoPanel<UpdateFinanceiro>();

        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirm = MessageBox.Show("Deseja realmente excluir o lançamento?", "Confirmação do usuário", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (confirm.ToString().ToUpper() == "YES")
                {
                    _mysql.Open();
                    var query = _mysql.Command("DELETE FROM FINANCEIRO WHERE id_lancamento = " + dataGridView1.CurrentRow.Cells[0].Value);
                    _mysql.Close();
                    dataGridView1.DataSource = SelecionarFinanceiro();
                    if (dataGridView1.Rows.Count == 0)
                    {
                        BtnVisu.Enabled = false;
                        BtnAlter.Enabled = false;
                        BtnDel.Enabled = false;
                        BtnBaixar.Enabled = false;
                        btnReabrir.Enabled = false;
                    }
                    else
                    {
                        BtnVisu.Enabled = true;
                        BtnAlter.Enabled = true;
                        BtnDel.Enabled = true;
                        BtnBaixar.Enabled = true;
                        btnReabrir.Enabled = true;
                    }

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                throw new Exception();
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
           
            try 
            {
                if (CmbFiltro.SelectedItem != null && txtDescricao.Text != null)
                {
                    dataGridView1.DataSource = SelecionarComFiltro();
                    if (dataGridView1.Rows.Count == 0)
                    {
                        BtnVisu.Enabled = false;
                        BtnAlter.Enabled = false;
                        BtnDel.Enabled = false;
                        BtnBaixar.Enabled = false;
                        btnReabrir.Enabled = false;
                    }
                    else
                    {
                        BtnVisu.Enabled = true;
                        BtnAlter.Enabled = true;
                        BtnDel.Enabled = true;
                        BtnBaixar.Enabled = true;
                        btnReabrir.Enabled = true;
                    }
                }
                else
                {
                    dataGridView1.DataSource = SelecionarFinanceiro();
                    if (dataGridView1.Rows.Count == 0)
                    {
                        BtnVisu.Enabled = false;
                        BtnAlter.Enabled = false;
                        BtnDel.Enabled = false;
                        BtnBaixar.Enabled = false;
                        btnReabrir.Enabled = false;
                    }
                    else
                    {
                        BtnVisu.Enabled = true;
                        BtnAlter.Enabled = true;
                        BtnDel.Enabled = true;
                        BtnBaixar.Enabled = true;
                        btnReabrir.Enabled = true;
                    }
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("O seguinte erro foi encontrado : " + erro.Message);
            }

        }

        private void BtnBaixar_Click(object sender, EventArgs e)
        {
            try
            {
                String[] pagamento = DateTime.Today.GetDateTimeFormats(format: 'd');


                _mysql.Open();

                var query = _mysql.Command("update financeiro set pagamento = '" + pagamento[13] + "' where id_lancamento =" + dataGridView1.CurrentRow.Cells[0].Value);
                _mysql.Close();

                dataGridView1.DataSource = SelecionarFinanceiro();
                if (dataGridView1.Rows.Count == 0)
                {
                    BtnVisu.Visible = false;
                    BtnAlter.Visible = false;
                    BtnDel.Visible = false;
                    BtnBaixar.Visible = false;
                }
                else
                {
                    BtnVisu.Visible = true;
                    BtnAlter.Visible = true;
                    BtnDel.Visible = true;
                    BtnBaixar.Visible = true;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _mysql.Open();
                var query = _mysql.Command("update financeiro set pagamento = null where id_lancamento =" + dataGridView1.CurrentRow.Cells[0].Value);
                _mysql.Close();

                dataGridView1.DataSource = SelecionarFinanceiro();
                if (dataGridView1.Rows.Count == 0)
                {
                    BtnVisu.Visible = false;
                    BtnAlter.Visible = false;
                    BtnDel.Visible = false;
                    BtnBaixar.Visible = false;
                }
                else
                {
                    BtnVisu.Visible = true;
                    BtnAlter.Visible = true;
                    BtnDel.Visible = true;
                    BtnBaixar.Visible = true;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                throw new Exception();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAlter_Click(null,null);
            }
            if (e.KeyCode == Keys.Delete)
            {
                BtnDel_Click(null,null);
            }
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
