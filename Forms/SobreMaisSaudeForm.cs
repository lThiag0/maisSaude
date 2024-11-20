using CuidaMais;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace maisSaude.Forms
{
    public partial class SobreMaisSaudeForm : Form
    {
        homeForm formInicial = (homeForm)Application.OpenForms["homeForm"];
        public SobreMaisSaudeForm()
        {
            InitializeComponent();
            formInicial.adicionarConsoleLog("Sobre o maisSaude foi iniciado");
            textVersao.Text = "Versão: " + FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
