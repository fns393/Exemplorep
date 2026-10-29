using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pessoa p1 = new Pessoa();
            if (p1.genero == "Feminina")
            {
                Mulher_foto.Image = Image.FromFile($@"C:\Users\{Environment.UserName}\Desktop\Trabalhos\Aula4a6\Ex4\Imgs\Mulher.jpg");
                Homem_foto.Visible = false;
            } else
            {
                Homem_foto.Image = Image.FromFile($@"C:\Users\{Environment.UserName}\Desktop\Trabalhos\Aula4a6\Ex4\Imgs\Homem.jpg");
                Mulher_foto.Visible = false;
            }
            lblOutput.Text = p1.Dados;
        }
    }
}
