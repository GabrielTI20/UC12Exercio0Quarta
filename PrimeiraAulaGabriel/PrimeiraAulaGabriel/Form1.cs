using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiraAulaGabriel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Mensagem1.Visible = false;
            mensagemAmarela.Visible = false;
            mensagemVerde.Visible = false;
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            mensagemAmarela.Visible=false;
            mensagemVerde.Visible=false;
            Mensagem1.Visible = true;
            Mensagem1.Text = "Pare!!! ";
            
               
        }

        private void Verde1_Click(object sender, EventArgs e)
        {
            Mensagem1.Visible = false;
            mensagemAmarela.Visible=false;
            mensagemVerde.Visible = true;
            mensagemVerde.Text = "Siga em Frente ";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void Amarelo(object sender, EventArgs e)
        {
            mensagemVerde.Visible=false;
            Mensagem1.Visible=false;
            mensagemAmarela.Visible = true;
            mensagemAmarela.Text = "Atenção ";
        }
    }
}
