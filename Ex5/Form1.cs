using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriarPessoa_Click(object sender, EventArgs e)
        {
            Cargo cargo = new Cargo();

            cargo.introduzir("Alberto", "Gerente", 865.54, "LSPD", 12);

            if(cargo.cargo == "Gerente")
            {
                Gerente.Visible = false;
                Assistente.Image = Image.FromFile(@"C:\Users\User\Desktop\Trabalhos\Aula4a6\Ex5\Imgs\Gerente.jpg");
            } if ( cargo.cargo == "Assistente")
            {
                Assistente.Visible = false;
                Gerente.Image = Image.FromFile(@"C:\Users\User\Desktop\Trabalhos\Aula4a6\Ex5\Imgs\Assistente.jpg");
            }
            lblOutput.Text = cargo.dados();
        }
    }
}
