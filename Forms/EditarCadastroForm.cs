using CuidaMais;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace maisSaude.Forms
{
    public partial class EditarCadastroForm : Form
    {
        homeForm formInicial = (homeForm)Application.OpenForms["homeForm"];
        public EditarCadastroForm()
        {
            InitializeComponent();
            formInicial.adicionarConsoleLog("Editor de formulario de Cadastro de Pessoa foi iniciado");
        }
        private string ConverterCPF(string cpf)
        {
            string cpftexto = cpf.Replace(",", "").Replace("-", "");

            return cpftexto;
        }

        private void mostraIMG(string img)
        {
            try
            {
                if (File.Exists(img))
                {
                    //return new Bitmap(img);
                    FileStream fs = new FileStream(img, FileMode.Open, FileAccess.Read);
                    pictureBoxFoto3x4.Image = Image.FromStream(fs);
                    fs.Close();
                }
                else { pictureBoxFoto3x4.Image = Properties.Resources.avatar; }
            }
            catch
            {
                // Esse aquivo não é uma imagem.
                pictureBoxFoto3x4.Image = Properties.Resources.avatar;
                formInicial.adicionarConsoleLog("Imagem do cadastro da pessoa com id " + idCadastro.Text + " está corrompido!");
            }
        }

        private void LimparEditar()
        {
            idCadastro.Text = "";
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
            boxData.Text = "";
            boxDataDeNascimento.Text = "";
            boxNumero.Text = "";
            boxRendValor.Value = 0;
            boxRg.Text = "";
            comboBoxAlergico.SelectedIndex = 0;
            comboBoxCivil.SelectedIndex = 0;
            comboBoxEstado.SelectedIndex = 0;
            pictureBoxFoto3x4.Image = Properties.Resources.avatar;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (textBoxNomeEdit.Text != "" || maskedTextBoxCPFEdit.MaskCompleted)
            {
                LimparEditar();
                TextExtraido.Items.Clear();
                if (!Directory.Exists(Application.StartupPath + "/BancoDeDados/Dados/DadosGerais.xml"))
                {
                    //groupBox1.Enabled = false;
                    XDocument root = XDocument.Load(Application.StartupPath + "/BancoDeDados/Dados/DadosGerais.xml");
                    if (textBoxNomeEdit.Text != "")
                    {
                        var query = from element in root.Descendants("pessoa").
                                Where(x => x.Attribute("nome").Value == textBoxNomeEdit.Text)
                                    select element;

                        if (query.Count() > 0)
                        {
                            foreach (var es in query)
                            {
                                ListViewItem item = new ListViewItem(es.Attribute("id").Value);
                                item.SubItems.Add(es.Element("nome").Value);
                                item.SubItems.Add(es.Element("cpf").Value);
                                item.SubItems.Add(es.Element("dataDeNascimento").Value);
                                TextExtraido.Items.Add(item);
                                TextExtraido.Items[0].Selected = true;
                            }
                        }
                        else
                        {
                            groupBox2.Enabled = false;
                            MessageBox.Show("Não foi encontrado nem um cadastro com essas informações no banco de dados.", "Opss", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        var query = from element in root.Descendants("pessoa").
                                Where(x => x.Attribute("idcpf").Value == ConverterCPF(maskedTextBoxCPFEdit.Text))
                                    select element;

                        if (query.Count() > 0)
                        {
                            foreach (var es in query)
                            {
                                ListViewItem item = new ListViewItem(es.Attribute("id").Value);
                                item.SubItems.Add(es.Element("nome").Value);
                                item.SubItems.Add(es.Element("cpf").Value);
                                item.SubItems.Add(es.Element("dataDeNascimento").Value);
                                TextExtraido.Items.Add(item);
                                TextExtraido.Items[0].Selected = true;
                            }
                        }
                        else
                        {
                            groupBox2.Enabled = false;
                            MessageBox.Show("Não foi encontrado nem um cadastro com essas informações no banco de dados.", "Opss", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else { MessageBox.Show("Não foi encontrado o arquivo do banco de dados.", "Opss", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else
            {
                MessageBox.Show("Digite o nome ou o cpf da pessoa para buscar o cadastro", "Opss", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBoxNomeEdit_TextChanged(object sender, EventArgs e)
        {
            maskedTextBoxCPFEdit.Text = "";
        }

        private void maskedTextBoxCPFEdit_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            textBoxNomeEdit.Text = "";
        }

        private void TextExtraido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TextExtraido.SelectedItems.Count > 0)
            {
                if (File.Exists(Application.StartupPath + "/BancoDeDados/Dados/DadosGerais.xml"))
                {
                    // O arquivo existe!
                    groupBox2.Enabled = true;
                    XDocument doc = XDocument.Load(Application.StartupPath + "/BancoDeDados/Dados/DadosGerais.xml");
                    var prods = from p in doc.Descendants("pessoa").
                                    Where(x => x.Attribute("id").Value == TextExtraido.SelectedItems[0].SubItems[0].Text)
                                select new
                                {
                                    edit_id = p.Attribute("id").Value,
                                    edit_nome = p.Element("nome").Value,
                                    edit_cpf = p.Element("cpf").Value,
                                    edit_cidade = p.Element("cidade").Value,
                                    edit_estado = p.Element("estado").Value,
                                    edit_estadoCivil = p.Element("estadoCivil").Value,
                                    edit_dataDeNascimento = p.Element("dataDeNascimento").Value,
                                    edit_profissao = p.Element("profissao").Value,
                                    edit_rg = p.Element("rg").Value,
                                    edit_orgaoExpeditor = p.Element("orgaoExpeditor").Value,
                                    edit_condSaude = p.Element("condSaude").Value,
                                    edit_rendimento = p.Element("rendimento").Value,
                                    edit_apto = p.Element("apto").Value,
                                    edit_medicacoes = p.Element("medicacoes").Value,
                                    edit_alergico = p.Element("alergico").Value,
                                    edit_endereco = p.Element("endereco").Value,
                                    edit_alergias = p.Element("alergias").Value,
                                    edit_data = p.Element("data").Value,
                                    edit_foto = p.Element("foto").Value,
                                    edit_numero = p.Element("numero").Value,
                                };

                    foreach (var p in prods)
                    {
                        idCadastro.Text = p.edit_id;
                        textBoxNome.Text = p.edit_nome;
                        boxCpf.Text = p.edit_cpf;
                        textBoxCidade.Text = p.edit_cidade;
                        comboBoxEstado.SelectedItem = p.edit_estado;
                        comboBoxCivil.SelectedItem = p.edit_estadoCivil;
                        boxDataDeNascimento.Text = p.edit_dataDeNascimento;
                        textBoxProfissao.Text = p.edit_profissao;
                        boxRg.Text = p.edit_rg;
                        textBoxExpeditor.Text = p.edit_orgaoExpeditor;
                        textBoxCondSaude.Text = p.edit_condSaude;
                        boxRendValor.Value = decimal.Parse(p.edit_rendimento);
                        textBoxApto.Text = p.edit_apto;
                        textBoxMedicacoes.Text = p.edit_medicacoes;
                        comboBoxAlergico.SelectedItem = p.edit_alergico;
                        textBoxEndereco.Text = p.edit_endereco;
                        textBoxAlergias.Text = p.edit_alergias;
                        boxData.Text = p.edit_data;
                        mostraIMG(p.edit_foto);
                        boxNumero.Text = p.edit_numero;
                    }

                }
                else { MessageBox.Show("Não foi encontrado o arquivo do banco de dados.", "Opss", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonTodosCadastros_Click(object sender, EventArgs e)
        {
            var message = "Ao acessar todo os cadastro do banco de dados isso podera leva um tempo, deseja continuar?\n"
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
                    LimparEditar();
                    TextExtraido.Items.Clear();
                    if (!Directory.Exists(Application.StartupPath + "/BancoDeDados/Dados/DadosGerais.xml"))
                    {
                        //groupBox1.Enabled = false;
                        XDocument root = XDocument.Load(Application.StartupPath + "/BancoDeDados/Dados/DadosGerais.xml");
                        var query = from element in root.Descendants("pessoa")
                                    select element;

                        if (query.Count() > 0)
                        {
                            foreach (var es in query)
                            {
                                ListViewItem item = new ListViewItem(es.Attribute("id").Value);
                                item.SubItems.Add(es.Element("nome").Value);
                                item.SubItems.Add(es.Element("cpf").Value);
                                item.SubItems.Add(es.Element("dataDeNascimento").Value);
                                TextExtraido.Items.Add(item);
                                TextExtraido.Items[0].Selected = true;
                            }
                        }
                        else
                        {
                            groupBox2.Enabled = false;
                            MessageBox.Show("Não foi encontrado nem um cadastro com essas informações no banco de dados.", "Opss", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else { MessageBox.Show("Não foi encontrado o arquivo do banco de dados.", "Opss", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    break;
                case DialogResult.No:
                    //Nada aqui
                    break;
                default:
                    MessageBox.Show("Escolha uma das opções disponivel!");
                    break;
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
                boxRg.MaskCompleted &&
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

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (CamposPreenchidos())
            {

                XDocument xDoc = XDocument.Load(Application.StartupPath + "/BancoDeDados/Dados/DadosGerais.xml");
                var _idcpf = xDoc.Root.Descendants("pessoa").FirstOrDefault(_ => _.Attribute("id").Value.Equals(idCadastro.Text));
                if (_idcpf is XElement)
                {
                    //Element
                    _idcpf.Attribute("id").Value = idCadastro.Text;
                    _idcpf.Attribute("idcpf").Value = ConverterCPF(boxCpf.Text);
                    _idcpf.Attribute("nome").Value = textBoxNome.Text;
                    _idcpf.Attribute("data").Value = boxData.Text;
                    _idcpf.Element("nome").Value = textBoxNome.Text;
                    _idcpf.Element("cpf").Value = boxCpf.Text;
                    _idcpf.Element("cidade").Value = textBoxCidade.Text;
                    _idcpf.Element("estado").Value = comboBoxEstado.SelectedItem.ToString();
                    _idcpf.Element("estadoCivil").Value = comboBoxCivil.SelectedItem.ToString();
                    _idcpf.Element("dataDeNascimento").Value = boxDataDeNascimento.Text;
                    _idcpf.Element("profissao").Value = textBoxProfissao.Text;
                    _idcpf.Element("rg").Value = boxRg.Text;
                    _idcpf.Element("orgaoExpeditor").Value = textBoxExpeditor.Text;
                    _idcpf.Element("condSaude").Value = textBoxCondSaude.Text;
                    _idcpf.Element("rendimento").Value = "" + boxRendValor.Value;
                    _idcpf.Element("apto").Value = textBoxApto.Text;
                    _idcpf.Element("medicacoes").Value = textBoxMedicacoes.Text;
                    _idcpf.Element("alergico").Value = comboBoxAlergico.SelectedItem.ToString();
                    _idcpf.Element("endereco").Value = textBoxEndereco.Text;
                    _idcpf.Element("alergias").Value = textBoxAlergias.Text;
                    _idcpf.Element("foto").Value = Application.StartupPath + "/BancoDeDados/Fotos/" + ConverterCPF(boxCpf.Text) + ".jpg";
                    _idcpf.Element("numero").Value = boxNumero.Text;

                    try
                    {
                        if (File.Exists(Application.StartupPath + "/BancoDeDados/Fotos/" + ConverterCPF(boxCpf.Text) + ".jpg"))
                        {
                            // Tem que iniciar o aplicativo como adm 
                            File.Delete(Application.StartupPath + "/BancoDeDados/Fotos/" + ConverterCPF(boxCpf.Text) + ".jpg");
                            pictureBoxFoto3x4.Image.Save(Application.StartupPath + "/BancoDeDados/Fotos/" + ConverterCPF(boxCpf.Text) + ".jpg", ImageFormat.Jpeg);
                        }
                        else
                        { 
                            pictureBoxFoto3x4.Image.Save(Application.StartupPath + "/BancoDeDados/Fotos/" + ConverterCPF(boxCpf.Text) + ".jpg", ImageFormat.Jpeg);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao salvar a foto 3x4: " + ex.Message, "Opss, ocorreu um error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    xDoc.Save(Application.StartupPath + "/BancoDeDados/Dados/DadosGerais.xml");

                    MessageBox.Show("Cadastro com id " + idCadastro.Text + " editado com sucesso!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formInicial.adicionarConsoleLog("Cadastro da pessoa com id " + idCadastro.Text + " foi editado com sucesso!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Não foi possicel deletar esse cadastro, dados não encontrados.", "Opss", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os dados necessarios para salva esse cadastro.", "Opss", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel carregar a foto 3x4: " + ex.Message, "Opss, ocorreu um error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            dlg.Dispose();
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

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            if (idCadastro.Text != "")
            {
                if (File.Exists(Application.StartupPath + "/BancoDeDados/Dados/DadosGerais.xml"))
                {
                    groupBox2.Enabled = false;
                    var xmlDoc = XDocument.Load(Application.StartupPath + "/BancoDeDados/Dados/DadosGerais.xml");
                    var element = (
                        from x in xmlDoc.Root.Elements("pessoa")
                        where x.Attribute("id").Value == idCadastro.Text
                        select x
                        ).FirstOrDefault();
                    element.Remove();
                    xmlDoc.Save(Application.StartupPath + "/BancoDeDados/Dados/DadosGerais.xml");

                    MessageBox.Show("Cadastro com id " + idCadastro.Text + " foi excluido com sucesso!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formInicial.adicionarConsoleLog("Cadastro com id " + idCadastro.Text + " foi excluido com sucesso!");
                    Close();
                }
                else { MessageBox.Show("Não foi encontrado o arquivo do banco de dados.", "Opss", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else { MessageBox.Show("Não foi encontrado esse id no banco de dados.", "Opss", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void EditarCadastroForm_Load(object sender, EventArgs e)
        {

        }
    }
}
