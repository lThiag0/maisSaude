using CuidaMais;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace maisSaude.Forms
{
    public partial class BackupCadastroForm : Form
    {
        homeForm formInicial = (homeForm)Application.OpenForms["homeForm"];
        string dataCerta = DateTime.Now.ToString("dd-MM-yyyy_HHmmss");
        public BackupCadastroForm()
        {
            InitializeComponent();
            formInicial.adicionarConsoleLog("Backup de Cadastro de Pessoa foi iniciado");
            textData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            comboBoxTipo.SelectedIndex = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void CriarDiretorio(string NomePath)
        {
            try
            {
                if (Directory.Exists(Application.StartupPath + "/" + NomePath))
                {
                    formInicial.adicionarConsoleLog("Diretorio de " + NomePath + " já existe");
                }
                else
                {
                    DirectoryInfo di = Directory.CreateDirectory(Application.StartupPath + "/" + NomePath);
                    formInicial.adicionarConsoleLog("O diretório foi criado com sucesso em: " + Directory.GetCreationTime(Application.StartupPath + "/" + NomePath));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("O processo falhou: " + e.ToString(), "Opss, ocorreu um error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                formInicial.adicionarConsoleLog("O processo de criação do " + NomePath + " falhou: ");
            }
        }
        private string DiretorioFinal()
        {
            if (comboBoxTipo.SelectedIndex == 0)
            {
                return "BancoDeDadosMaisSaudePrincipal.zip";
            }
            else
            {
                return "BancoDeDadosMaisSaude_" + DateTime.Now.ToString("dd-MM-yyyy_HHmmss") + ".zip";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            carregamentoBarra.Value = 10;
            if (textData.Text != "" && comboBoxTipo.SelectedIndex >= 0)
            {
                CriarDiretorio("Backup");
                carregamentoBarra.Value = 50;
                if (Directory.Exists(Application.StartupPath + "/Backup"))
                {
                    // Pasta existe
                    if (comboBoxTipo.SelectedIndex == 0)
                    {
                        try
                        {
                            carregamentoBarra.Value = 60;
                            File.Delete(Application.StartupPath + "/Backup/BancoDeDadosMaisSaudePrincipal.zip");
                            carregamentoBarra.Value = 70;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocorreu um erro ao deletar o backup principal do banco de dados: " + ex.Message, "Opss, ocorreu um error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            carregamentoBarra.Value = 0;
                        }
                    }
                    carregamentoBarra.Value = 80;
                    try
                    {
                        ZipFile.CreateFromDirectory(Application.StartupPath + "/BancoDeDados", Path.GetFullPath(Path.Combine(Application.StartupPath + "/Backup/", "..\\Backup/" + DiretorioFinal())));
                        carregamentoBarra.Value = 100;
                        MessageBox.Show("Backup do banco de dados feito com sucesso!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        formInicial.adicionarConsoleLog("Backup do banco de dados feito com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao fazer o backup do banco de dados: " + ex.Message, "Opss, ocorreu um error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        carregamentoBarra.Value = 0;
                    }
                }
                else { carregamentoBarra.Value = 0; MessageBox.Show("Diretorio do backup não foi achado!", "Opss, ocorreu um error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { carregamentoBarra.Value = 0; MessageBox.Show("Data do backup não foi achado!", "Opss, ocorreu um error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textData_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonTodosBackups_Click(object sender, EventArgs e)
        {
            var message = "Ao acessar todo os backups do banco de dados isso podera leva um tempo, deseja continuar?\n"
                + "O programa devera ficar carregando ate termina de acessar todos os dados.";
            var title = "+Saude Alerta";
            var result = MessageBox.Show(
                message,
                title,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    TextExtraido.Items.Clear();
                    if (Directory.Exists(Application.StartupPath + "/Backup/"))
                    {
                        //Marca o diretório a ser listado
                        DirectoryInfo diretorio = new DirectoryInfo(Application.StartupPath + "/Backup");
                        //Executa função GetFile(Lista os arquivos desejados de acordo com o parametro)
                        FileInfo[] Arquivos = diretorio.GetFiles("*.zip*");

                        //Começamos a listar os arquivos
                        foreach (FileInfo fileinfo in Arquivos)
                        {
                            ListViewItem item = new ListViewItem(fileinfo.Name);
                            item.SubItems.Add(fileinfo.CreationTime + "");
                            TextExtraido.Items.Add(item);
                            TextExtraido.Items[0].Selected = true;
                        }
                    }
                    else { MessageBox.Show("Não foi encontrado o arquivo do Backup.", "Opss", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    break;
                case DialogResult.No:
                    //Nada aqui
                    break;
                default:
                    MessageBox.Show("Escolha uma das opções disponivel!");
                    break;
            }
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            TextExtraido.Items.Clear();
        }

        private void buttonTodos_Click(object sender, EventArgs e)
        {
            if (TextExtraido.Items.Count > 0)
            {
                foreach (ListViewItem item in TextExtraido.Items)
                {
                    item.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Não foi encontrado nem um backup na lista!", "Opss", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonImportar_Click(object sender, EventArgs e)
        {
            if (TextExtraido.SelectedItems.Count == 1)
            {
                carregamentoBarra.Value = 10;
                var message = "Ao importar os dados, você mudara o banco de dados para obter novos dados, deseja continuar?\n"
            + "O programa devera ficar carregando ate termina de acessar todos os dados.";
                var title = "+Saude Alerta";
                var result = MessageBox.Show(
                    message,
                    title,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                switch (result)
                {
                    case DialogResult.Yes:
                        carregamentoBarra.Value = 0;
                        if (Directory.Exists(Application.StartupPath + "/BancoDeDados/"))
                        {
                            //Diretorio exite
                            try
                            {
                                carregamentoBarra.Value = 30;
                                Directory.Delete(Application.StartupPath + "/BancoDeDados", true);
                                carregamentoBarra.Value = 50;
                                CriarDiretorio("BancoDeDados");
                                carregamentoBarra.Value = 70;
                                ZipFile.ExtractToDirectory(Path.GetFullPath(Path.Combine(Application.StartupPath + "/Backup/", "..\\Backup/" + TextExtraido.SelectedItems[0].SubItems[0].Text)), Application.StartupPath + "/BancoDeDados");
                                carregamentoBarra.Value = 90;
                                MessageBox.Show("Importação do backup do banco de dados feito com sucesso!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                formInicial.adicionarConsoleLog("Importação do backup do banco de dados feito com sucesso!");
                                carregamentoBarra.Value = 100;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro ao importa o arquivo do banco de dados: " + ex.Message, "Opss, ocorreu um error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                carregamentoBarra.Value = 0;
                            }

                        }
                        else
                        {
                            // Diretorio não existe
                            try
                            {
                                carregamentoBarra.Value = 30;
                                CriarDiretorio("BancoDeDados");
                                carregamentoBarra.Value = 70;
                                ZipFile.ExtractToDirectory(Path.GetFullPath(Path.Combine(Application.StartupPath + "/Backup/", "..\\Backup/" + TextExtraido.SelectedItems[0].SubItems[0].Text)), Application.StartupPath + "/BancoDeDados");
                                carregamentoBarra.Value = 90;
                                MessageBox.Show("Importação do backup do banco de dados feito com sucesso!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                formInicial.adicionarConsoleLog("Importação do backup do banco de dados feito com sucesso!");
                                carregamentoBarra.Value = 100;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro ao importa o arquivo do banco de dados: " + ex.Message, "Opss, ocorreu um error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                carregamentoBarra.Value = 0;
                            }
                        }
                        break;
                    case DialogResult.No:
                        //Nada aqui
                        carregamentoBarra.Value = 0;
                        break;
                    default:
                        MessageBox.Show("Escolha uma das opções disponivel!");
                        carregamentoBarra.Value = 0;
                        break;
                }
            }
            else
            {
                carregamentoBarra.Value = 0;
                MessageBox.Show("Escolha apenas 1 opção de backup!", "Opss, ocorreu um error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonPasta_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Application.StartupPath + "/Backup/"))
            {
                try
                {
                    Process.Start("explorer.exe", Path.GetFullPath(Path.Combine(Application.StartupPath + "/Backup/", "..\\Backup/")));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao abrir a pasta do backups: " + ex.Message, "Opss, ocorreu um error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else { MessageBox.Show("Pasta do backups n foi encontrado!", "Opss, ocorreu um error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
