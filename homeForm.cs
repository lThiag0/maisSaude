using CuidaMais.Forms;
using maisSaude.Forms;
using System.Globalization;

namespace CuidaMais
{
    public partial class homeForm : Form
    {
        public homeForm()
        {
            InitializeComponent();
            adicionarConsoleLog("Sistema de +Saude foi iniciado com sucesso");
        }

        public void adicionarConsoleLog(string text)
        {
            consoleLogGeral.Text = consoleLogGeral.Text + "[" + DateTime.UtcNow.ToString(CultureInfo.CreateSpecificCulture("pt-BR")) + "] - " + text + "\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroForm formCadastro = new CadastroForm();
            formCadastro.Show();

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            EditarCadastroForm formEditarCadastro = new EditarCadastroForm();
            formEditarCadastro.Show();
        }
    }
}
