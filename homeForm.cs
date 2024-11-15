using CuidaMais.Forms;
using maisSaude.Forms;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;

namespace CuidaMais
{
    public partial class homeForm : Form
    {
        public homeForm()
        {
            InitializeComponent();
            textVersao.Text = "Versão: " + FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
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

        private void buttonExporta_Click(object sender, EventArgs e)
        {
            ExportarCadastroForm formExportarCadastro = new ExportarCadastroForm();
            formExportarCadastro.Show();
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            BackupCadastroForm formBackupCadastro = new BackupCadastroForm();
            formBackupCadastro.Show();
        }

        private void buttonSobre_Click(object sender, EventArgs e)
        {
            SobreMaisSaudeForm formSobreMaisSaude = new SobreMaisSaudeForm();
            formSobreMaisSaude.Show();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
