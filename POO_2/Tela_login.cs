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
    public partial class Tela_login : Form
    {
        public Tela_login()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text == "admin" && txtSenha.Text == "admin")
                {
                    this.Visible = false;
                    txtUsuario.Text = "";
                    txtSenha.Text = "";
                    var tela_principal = new Tela_principal();
                    tela_principal.ShowDialog();
                    
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuarío ou senha incorreto",
                                    "Ops",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                    txtUsuario.Focus();
                    txtUsuario.Text = "";
                    txtSenha.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desculpe",
                                ex.Message,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void Tela_login_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetterOrDigit(e.KeyChar))   
            {

                int tecla = (int)e.KeyChar;

                if (!char.IsLetterOrDigit(e.KeyChar) && tecla != 8 )
                {
                    e.Handled = true;
                    MessageBox.Show("Digite apenas letras ou numeros",
                                    "Ops",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                    txtUsuario.SelectionStart = 0;
                    txtUsuario.SelectionLength = txtUsuario.Text.Length;

                    txtUsuario.Focus();
                }
                
            }
        }
    }
}
