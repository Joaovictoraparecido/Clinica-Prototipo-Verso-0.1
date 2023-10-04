using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Clinica
{

    public partial class tela_inicial : Form
    {
        Thread ny;

        public tela_inicial()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/jo%C3%A3o-victor-aparecido-jesus-de-oliveira-5b1400208/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/caiquemaa//");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ny = new Thread(novoform1);
            ny.SetApartmentState(ApartmentState.STA);
            ny.Start();
        } //final do admin de senha
        private void novoform1()
        {
            Application.Run(new cadastro_clientes());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

   
    }

