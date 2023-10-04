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
    public partial class Form1 : Form
    {
        Thread nt;
        public Form1()
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
            if(textBox1.Text == "admin" && textBox2.Text == "admin")
            
                {
                /// normal deixar em branco pois é pra adicionar outro usuarios
                }
           
                    if (textBox1.Text == "joao" && textBox2.Text == "joao") /// add outros usuarios é com if 
                 
           
                
                {
                this.Close();
                nt = new Thread(novoform);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
                } //final do admin de senha

            else

            {
                    MessageBox.Show("Login ou Senha Invalida!!!");
                }
          

            
        }

        private void novoform()
        {
            Application.Run(new  tela_inicial());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
