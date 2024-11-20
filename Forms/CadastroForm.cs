using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Drawing.Imaging;
using System.IO;
using CuidaMais;
using static System.Windows.Forms.DataFormats;
using System.Diagnostics;

namespace CuidaMais.Forms
{
    public partial class CadastroForm : Form
    {
        homeForm formInicial = (homeForm)Application.OpenForms["homeForm"];
        public CadastroForm()
        {
            InitializeComponent();
            idCadastro.Text = quantID() + DateTime.Now.ToString("HHmmss");
            textBoxAlergias.Enabled = false;
            boxData.Text = DateTime.Now.ToString(new CultureInfo("pt-BR", false).DateTimeFormat.ShortDatePattern);
            formInicial.adicionarConsoleLog("Formulario de  Cadastro de Pessoa foi iniciado");
        }

        private int quantID()
        {
            if (File.Exists(Application.StartupPath + "/BancoDeDados/Dados/DadosGerais.xml"))
            {
                XDocument xdoc = XDocument.Load(Application.StartupPath + "/BancoDeDados/Dados/DadosGerais.xml");
                int countElement = xdoc.Descendants("pessoa").Count();
                return countElement + 1;
            }
            else
            {
                return 1;
            }
        }

        private void buttonUploadFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Abrir Foto";
            dlg.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF"
                + "|All files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxFoto3x4.Image = new Bitmap(dlg.OpenFile());
                    formInicial.adicionarConsoleLog("Foto 3x4 foi carregada com sucesso");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel carregar a foto 3x4: " + ex.Message, "Opss, ocorreu um error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    formInicial.adicionarConsoleLog("Não foi possivel carregar a foto 3x4");
                }
            }

            dlg.Dispose();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = "";
            textBoxCidade.Text = "";
            textBoxAlergias.Text = "";
            textBoxApto.Text = "";
            textBoxCondSaude.Text = "";
            textBoxEndereco.Text = "";
            textBoxExpeditor.Text = "";
            textBoxMedicacoes.Text = "";
            textBoxProfissao.Text = "";
            boxCpf.Text = "";
            boxData.Text = DateTime.Now.ToString(new CultureInfo("pt-BR", false).DateTimeFormat.ShortDatePattern);
            boxDataDeNascimento.Text = "";
            boxNumero.Text = "";
            boxRendValor.Value = 0;
            boxRg.Text = "";
            comboBoxAlergico.SelectedIndex = 0;
            comboBoxCivil.SelectedIndex = 0;
            comboBoxEstado.SelectedIndex = 0;
            pictureBoxFoto3x4.Image = maisSaude.Properties.Resources.avatar;
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CriarDiretorio(string NomePath)
        {
            try
            {
                if (Directory.Exists(Application.StartupPath + "/BancoDeDados/" + NomePath))
                {
                    formInicial.adicionarConsoleLog("Diretorio do banco de dados já existe");
                }
                else
                {
                    DirectoryInfo di = Directory.CreateDirectory(Application.StartupPath + "/BancoDeDados/" + NomePath);
                    formInicial.adicionarConsoleLog("O diretório foi criado com sucesso em: " + Directory.GetCreationTime(Application.StartupPath + "/BancoDeDados/" + NomePath));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("O processo falhou: " + e.ToString(), "Opss, ocorreu um error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                formInicial.adicionarConsoleLog("O processo de criação do banco de dados falhou: ");
            }
        }

        private Boolean CamposPreenchidos()
        {
            if (idCadastro.Text != "" &&
                boxCpf.MaskCompleted &&
                boxData.MaskCompleted &&
                textBoxNome.Text != "" &&
                textBoxCidade.Text != "" &&
                boxDataDeNascimento.MaskCompleted &&
                textBoxProfissao.Text != "" &&
                boxRg.Text != "" &&
                textBoxExpeditor.Text != "" &&
                textBoxEndereco.Text != "" &&
                comboBoxEstado.SelectedIndex >= 0 &&
                comboBoxCivil.SelectedIndex >= 0 &&
                comboBoxAlergico.SelectedIndex >= 0 &&
                boxNumero.MaskCompleted)
            {
                return true;
            }
            else { return false; }
        }

        private string ConverterCPF(string cpf)
        {
            string cpftexto = cpf.Replace(",", "").Replace("-", "");

            return cpftexto;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (CamposPreenchidos())
            {
                CriarDiretorio("Dados");
                CriarDiretorio("Fotos");
                if (!File.Exists(Application.StartupPath + "/BancoDeDados/Dados/DadosGerais.xml"))
                {
                    //Novo documento
                    XDocument doc = new XDocument();
                    //XDocument doc = XDocument.Load(Application.StartupPath + "/BancoDeDados/Dados/DadosGerais.xml");
                    doc.Add(new XComment("Início"));
                    doc.Add(new XElement("root",
                        new XElement("pessoa",
                            new XAttribute("id", idCadastro.Text),
                            new XAttribute("idcpf", ConverterCPF(boxCpf.Text)),
                            new XAttribute("nome", ConverterCPF(textBoxNome.Text)),
                            new XAttribute("data", boxData.Text),
                            new XElement("nome", textBoxNome.Text),
                            new XElement("cpf", boxCpf.Text),
                            new XElement("cidade", textBoxCidade.Text),
                            new XElement("estado", comboBoxEstado.SelectedItem.ToString()),
                            new XElement("estadoCivil", comboBoxCivil.SelectedItem.ToString()),
                            new XElement("dataDeNascimento", boxDataDeNascimento.Text),
                            new XElement("profissao", textBoxProfissao.Text),
                            new XElement("rg", boxRg.Text),
                            new XElement("orgaoExpeditor", textBoxExpeditor.Text),
                            new XElement("condSaude", textBoxCondSaude.Text),
                            new XElement("rendimento", boxRendValor.Value),
                            new XElement("apto", textBoxApto.Text),
                            new XElement("medicacoes", textBoxMedicacoes.Text),
                            new XElement("alergico", comboBoxAlergico.SelectedItem.ToString()),
                            new XElement("endereco", textBoxEndereco.Text),
                            new XElement("alergias", textBoxAlergias.Text),
                            new XElement("data", boxData.Text),
                            new XElement("foto", Application.StartupPath + "/BancoDeDados/Fotos/" + ConverterCPF(boxCpf.Text) + ".jpg"),
                             new XElement("numero", boxNumero.Text)
                            )));
                    doc.Add(new XComment("Fim"));
                    doc.Save(Application.StartupPath + "/BancoDeDados/Dados/DadosGerais.xml");

                    try
                    {
                        pictureBoxFoto3x4.Image.Save(Application.StartupPath + "/BancoDeDados/Fotos/" + ConverterCPF(boxCpf.Text) + ".jpg", ImageFormat.Jpeg);
                        formInicial.adicionarConsoleLog("Foto 3x4 salva com sucesso");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao salvar a foto 3x4: " + ex.Message, "Opss, ocorreu um error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        formInicial.adicionarConsoleLog("Erro ao salvar a foto 3x4");
                    }

                    MessageBox.Show("Cadastro criado com sucesso!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formInicial.adicionarConsoleLog("Cadastro da pessoa criado com sucesso!");
                    Close();
                }
                else
                {
                    //Editar documento
                    //XDocument doc = new XDocument();
                    XDocument doc = XDocument.Load(Application.StartupPath + "/BancoDeDados/Dados/DadosGerais.xml");
                    var query = from element in doc.Root.Descendants("pessoa").Where(x => x.Attribute("idcpf").Value == ConverterCPF(boxCpf.Text)) select element;

                    if (query.Count() == 0)
                    {
                        doc.Root.Add(
                        new XElement("pessoa",
                            new XAttribute("id", idCadastro.Text),
                            new XAttribute("idcpf", ConverterCPF(boxCpf.Text)),
                            new XAttribute("nome", ConverterCPF(textBoxNome.Text)),
                            new XAttribute("data", boxData.Text),
                            new XElement("nome", textBoxNome.Text),
                            new XElement("cpf", boxCpf.Text),
                            new XElement("cidade", textBoxCidade.Text),
                            new XElement("estado", comboBoxEstado.SelectedItem.ToString()),
                            new XElement("estadoCivil", comboBoxCivil.SelectedItem.ToString()),
                            new XElement("dataDeNascimento", boxDataDeNascimento.Text),
                            new XElement("profissao", textBoxProfissao.Text),
                            new XElement("rg", boxRg.Text),
                            new XElement("orgaoExpeditor", textBoxExpeditor.Text),
                            new XElement("condSaude", textBoxCondSaude.Text),
                            new XElement("rendimento", boxRendValor.Value),
                            new XElement("apto", textBoxApto.Text),
                            new XElement("medicacoes", textBoxMedicacoes.Text),
                            new XElement("alergico", comboBoxAlergico.SelectedItem.ToString()),
                            new XElement("endereco", textBoxEndereco.Text),
                            new XElement("alergias", textBoxAlergias.Text),
                            new XElement("data", boxData.Text),
                            new XElement("foto", Application.StartupPath + "/BancoDeDados/Fotos/" + ConverterCPF(boxCpf.Text) + ".jpg"),
                             new XElement("numero", boxNumero.Text)
                            ));
                        doc.Save(Application.StartupPath + "/BancoDeDados/Dados/DadosGerais.xml");

                        try
                        {
                            pictureBoxFoto3x4.Image.Save(Application.StartupPath + "/BancoDeDados/Fotos/" + ConverterCPF(boxCpf.Text) + ".jpg", ImageFormat.Jpeg);
                            //pictureBoxFoto3x4.Image.Dispose();
                            //pictureBoxFoto3x4.Image = null;
                            formInicial.adicionarConsoleLog("Foto 3x4 salva com sucesso");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao salvar a foto 3x4: " + ex.Message, "Opss, ocorreu um error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            formInicial.adicionarConsoleLog("Erro ao salvar a foto 3x4");
                        }

                        MessageBox.Show("Cadastro criado com sucesso!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        formInicial.adicionarConsoleLog("Cadastro da pessoa criado com sucesso!");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Esse CPF ja foi cadastrado no sistema!", "Opss", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            else
            {
                MessageBox.Show("Preencha todos os dados necessarios para salva esse cadastro.", "Opss", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBoxAlergico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAlergico.SelectedIndex == 1)
            {
                textBoxAlergias.Enabled = true;
                textBoxAlergias.Text = "";
            }
            else
            {
                textBoxAlergias.Enabled = false;
                textBoxAlergias.Text = "";
            }
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxProfissao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void boxRg_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void comboBoxCivil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void boxDataDeNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
