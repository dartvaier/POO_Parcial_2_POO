using POO_2.Telas_Secundarias.telas_secundarias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_2
{
    public partial class Tela_principal : Form
    {
        public Tela_principal()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void estToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Janela_cadastro_produtos = new Janela_cadastro_produtos();
            Janela_cadastro_produtos.MdiParent = this;
            Janela_cadastro_produtos.WindowState = FormWindowState.Maximized;
            Janela_cadastro_produtos.Show();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Janela_cadastro_produtos = new Janela_Cadastro_funcionarios();
            Janela_cadastro_produtos.MdiParent = this;

            Janela_cadastro_produtos.WindowState = FormWindowState.Maximized;
            Janela_cadastro_produtos.Show();
        }

        private void Tela_principal_Load(object sender, EventArgs e)
        {

        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Janela_vendas = new Janela_vendas();
            Janela_vendas.MdiParent = this;

            Janela_vendas.WindowState = FormWindowState.Maximized;
            Janela_vendas.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Janela_estoque = new Janela_estoque();
            Janela_estoque.MdiParent = this;

            Janela_estoque.WindowState = FormWindowState.Maximized;
            Janela_estoque.Show();
        }
    }
}
