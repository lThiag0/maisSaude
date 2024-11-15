using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Reflection.Metadata;
using iTextSharp.text;
using Document = iTextSharp.text.Document;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using iTextSharp.text.pdf.codec.wmf;
using System.Drawing.Imaging;
using CuidaMais;
using maisSaude.Properties;

namespace maisSaude.Forms
{
    public partial class ExportarCadastroForm : Form
    {
        homeForm formInicial = (homeForm)Application.OpenForms["homeForm"];
        public ExportarCadastroForm()
        {
            InitializeComponent();
            formInicial.adicionarConsoleLog("Exportador de formulario de  Cadastro de Pessoa foi iniciado");
        }
        private string ConverterCPF(string cpf)
        {
            string cpftexto = cpf.Replace(",", "").Replace("-", "");

            return cpftexto;
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
                    TextExtraido.Items.Clear();
                    if (File.Exists(Application.StartupPath + "/BancoDeDados/Dados/DadosGerais.xml"))
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
                                item.SubItems.Add(es.Element("cidade").Value);
                                item.SubItems.Add(es.Element("estado").Value);
                                item.SubItems.Add(es.Element("estadoCivil").Value);
                                item.SubItems.Add(es.Element("dataDeNascimento").Value);
                                item.SubItems.Add(es.Element("profissao").Value);
                                item.SubItems.Add(es.Element("rg").Value);
                                item.SubItems.Add(es.Element("orgaoExpeditor").Value);
                                item.SubItems.Add(es.Element("condSaude").Value);
                                item.SubItems.Add(es.Element("rendimento").Value);
                                item.SubItems.Add(es.Element("apto").Value);
                                item.SubItems.Add(es.Element("medicacoes").Value);
                                item.SubItems.Add(es.Element("alergico").Value);
                                item.SubItems.Add(es.Element("endereco").Value);
                                item.SubItems.Add(es.Element("alergias").Value);
                                item.SubItems.Add(es.Element("data").Value);
                                item.SubItems.Add(es.Element("foto").Value);
                                item.SubItems.Add(es.Element("numero").Value);
                                TextExtraido.Items.Add(item);
                                TextExtraido.Items[0].Selected = true;
                            }
                        }
                        else
                        {
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

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (textBoxNomeEdit.Text != "" || maskedTextBoxCPFEdit.MaskCompleted)
            {
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
                                item.SubItems.Add(es.Element("cidade").Value);
                                item.SubItems.Add(es.Element("estado").Value);
                                item.SubItems.Add(es.Element("estadoCivil").Value);
                                item.SubItems.Add(es.Element("dataDeNascimento").Value);
                                item.SubItems.Add(es.Element("profissao").Value);
                                item.SubItems.Add(es.Element("rg").Value);
                                item.SubItems.Add(es.Element("orgaoExpeditor").Value);
                                item.SubItems.Add(es.Element("condSaude").Value);
                                item.SubItems.Add(es.Element("rendimento").Value);
                                item.SubItems.Add(es.Element("apto").Value);
                                item.SubItems.Add(es.Element("medicacoes").Value);
                                item.SubItems.Add(es.Element("alergico").Value);
                                item.SubItems.Add(es.Element("endereco").Value);
                                item.SubItems.Add(es.Element("alergias").Value);
                                item.SubItems.Add(es.Element("data").Value);
                                item.SubItems.Add(es.Element("foto").Value);
                                item.SubItems.Add(es.Element("numero").Value);

                                TextExtraido.Items.Add(item);
                                TextExtraido.Items[0].Selected = true;
                            }
                        }
                        else
                        {
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
                                item.SubItems.Add(es.Element("cidade").Value);
                                item.SubItems.Add(es.Element("estado").Value);
                                item.SubItems.Add(es.Element("estadoCivil").Value);
                                item.SubItems.Add(es.Element("dataDeNascimento").Value);
                                item.SubItems.Add(es.Element("profissao").Value);
                                item.SubItems.Add(es.Element("rg").Value);
                                item.SubItems.Add(es.Element("orgaoExpeditor").Value);
                                item.SubItems.Add(es.Element("condSaude").Value);
                                item.SubItems.Add(es.Element("rendimento").Value);
                                item.SubItems.Add(es.Element("apto").Value);
                                item.SubItems.Add(es.Element("medicacoes").Value);
                                item.SubItems.Add(es.Element("alergico").Value);
                                item.SubItems.Add(es.Element("endereco").Value);
                                item.SubItems.Add(es.Element("alergias").Value);
                                item.SubItems.Add(es.Element("data").Value);
                                item.SubItems.Add(es.Element("foto").Value);
                                item.SubItems.Add(es.Element("numero").Value);
                                TextExtraido.Items.Add(item);
                                TextExtraido.Items[0].Selected = true;
                            }
                        }
                        else
                        {
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

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in TextExtraido.Items)
            {
                if (item.Checked)
                {
                    item.Checked = false;
                }
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string mostraIMG(string img)
        {
            System.Reflection.Assembly thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream file = thisExe.GetManifestResourceStream("Properties.Resources.avatar.jpg");
            try
            {
                if (File.Exists(img))
                {
                    return img;
                }
                else
                {
                    formInicial.adicionarConsoleLog("Imagem do cadastro da pessoa não foi encontrado!");
                    return file + "";
                }
            }
            catch
            {
                // Esse aquivo não é uma imagem.
                //pictureBoxFoto3x4.Image = Properties.Resources.avatar;
                MessageBox.Show("Imagem do cadastro da pessoa está corrompido!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formInicial.adicionarConsoleLog("Imagem do cadastro da pessoa está corrompido!");
                return file + "";
            }
        }

        private void buttonExporta_Click(object sender, EventArgs e)
        {
            if (TextExtraido.CheckedItems.Count > 0)
            {
                if (!Directory.Exists(Application.StartupPath + "/BancoDeDados/Dados/DadosGerais.xml"))
                {
                    FolderBrowserDialog sfd = new FolderBrowserDialog();

                    if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        using (FileStream stream = new FileStream(sfd.SelectedPath + "/RelatorioDeCadastros" + DateTime.Now.ToString("ddMMyyyy_HHmmss") + ".pdf", FileMode.Create))
                        {
                            Paragraph paragrafo = new Paragraph("RELATÓRIO DE CADASTRO +SAUDE ", iTextSharp.text.FontFactory.GetFont("Calibri", 22));
                            paragrafo.Alignment = Element.ALIGN_CENTER;

                            Document pdfDoc = new Document(PageSize.A4);
                            PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();
                            pdfDoc.Add(paragrafo);
                            pdfDoc.Add(new iTextSharp.text.Chunk("\n"));

                            foreach (ListViewItem itemRow in TextExtraido.CheckedItems)
                            {
                                int i = 0;
                                List<string> relatorioGeralList = new List<string>();
                                for (i = 0; i < itemRow.SubItems.Count; i++)
                                {
                                    relatorioGeralList.Add(itemRow.SubItems[i].Text);
                                }
                                try
                                {
                                    iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(relatorioGeralList[18]);
                                    image.ScaleAbsolute(90, 90);
                                    image.Alignment = 6; //4 - 6
                                    image.SpacingAfter = 0;
                                    PdfPTable table = new PdfPTable(2);
                                    table.WidthPercentage = 102.0f;
                                    table.HorizontalAlignment = 0;
                                    table.TotalWidth = 500f;
                                    table.LockedWidth = true;
                                    table.KeepTogether = true;
                                    float[] widths = new float[] { 14f, 60f };
                                    table.SetWidths(widths);
                                    PdfPCell cell = new PdfPCell(new Phrase("NOME: " + relatorioGeralList[1]));
                                    cell.PaddingBottom = 10f;
                                    cell.PaddingTop = 10f;
                                    cell.Colspan = 2;
                                    cell.BackgroundColor = new BaseColor(System.Drawing.ColorTranslator.FromHtml("#63E75F"));
                                    cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                                    table.AddCell(cell);
                                    PdfPCell cellImage = new PdfPCell(image);
                                    cellImage.Padding = 1f;
                                    cellImage.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                                    table.AddCell(cellImage);
                                    table.AddCell("ID: " + relatorioGeralList[0] +
                                        "\nCPF: " + relatorioGeralList[2] +
                                        "\nCIDADE: " + relatorioGeralList[3] +
                                        "\nESTADO: " + relatorioGeralList[4] +
                                        "\nDATA DE NASCIMENTO: " + relatorioGeralList[6] +
                                        "\nPROFISSÃO: " + relatorioGeralList[7] +
                                        "\nORGÃO EXPEDITOR: " + relatorioGeralList[9]
                                        );
                                    table.AddCell("RENDIMENTO: " + relatorioGeralList[11]);
                                    table.AddCell("CONDIÇÕES DE SAUDE: " + relatorioGeralList[10]);
                                    table.AddCell("APTO: " + relatorioGeralList[12]);
                                    table.AddCell("MEDICAÇÕES: " + relatorioGeralList[13]);
                                    table.AddCell("ALERGICO: " + relatorioGeralList[14]);
                                    table.AddCell("ENDEREÇO: " + relatorioGeralList[15]);
                                    table.AddCell("ALERGIAS: " + relatorioGeralList[16]);
                                    table.AddCell("TELEFONE: " + relatorioGeralList[19]);
                                    table.AddCell("SISTEMA: +Saude");
                                    table.AddCell("DATA DO CADASTRO: " + relatorioGeralList[17]);

                                    pdfDoc.Add(table);
                                    pdfDoc.Add(new iTextSharp.text.Chunk("\n"));
                                }
                                catch
                                {
                                    // Esse aquivo não é uma imagem.
                                    var images = iTextSharp.text.Image.GetInstance(Resources.avatar, ImageFormat.Png);
                                    iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(images);
                                    image.ScaleAbsolute(90, 90);
                                    image.Alignment = 6; //4 - 6
                                    image.SpacingAfter = 0;
                                    PdfPTable table = new PdfPTable(2);
                                    table.WidthPercentage = 102.0f;
                                    table.HorizontalAlignment = 0;
                                    table.TotalWidth = 500f;
                                    table.LockedWidth = true;
                                    table.KeepTogether = true;
                                    float[] widths = new float[] { 14f, 60f };
                                    table.SetWidths(widths);
                                    PdfPCell cell = new PdfPCell(new Phrase("NOME: " + relatorioGeralList[1]));
                                    cell.PaddingBottom = 10f;
                                    cell.PaddingTop = 10f;
                                    cell.Colspan = 2;
                                    cell.BackgroundColor = new BaseColor(System.Drawing.ColorTranslator.FromHtml("#63E75F"));
                                    cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                                    table.AddCell(cell);
                                    PdfPCell cellImage = new PdfPCell(image);
                                    cellImage.Padding = 1f;
                                    cellImage.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                                    table.AddCell(cellImage);
                                    table.AddCell("ID: " + relatorioGeralList[0] +
                                        "\nCPF: " + relatorioGeralList[2] +
                                        "\nCIDADE: " + relatorioGeralList[3] +
                                        "\nESTADO: " + relatorioGeralList[4] +
                                        "\nDATA DE NASCIMENTO: " + relatorioGeralList[6] +
                                        "\nPROFISSÃO: " + relatorioGeralList[7] +
                                        "\nORGÃO EXPEDITOR: " + relatorioGeralList[9]
                                        );
                                    table.AddCell("RENDIMENTO: " + relatorioGeralList[11]);
                                    table.AddCell("CONDIÇÕES DE SAUDE: " + relatorioGeralList[10]);
                                    table.AddCell("APTO: " + relatorioGeralList[12]);
                                    table.AddCell("MEDICAÇÕES: " + relatorioGeralList[13]);
                                    table.AddCell("ALERGICO: " + relatorioGeralList[14]);
                                    table.AddCell("ENDEREÇO: " + relatorioGeralList[15]);
                                    table.AddCell("ALERGIAS: " + relatorioGeralList[16]);
                                    table.AddCell("TELEFONE: " + relatorioGeralList[19]);
                                    table.AddCell("SISTEMA: +Saude");
                                    table.AddCell("DATA DO CADASTRO: " + relatorioGeralList[17]);

                                    pdfDoc.Add(table);
                                    pdfDoc.Add(new iTextSharp.text.Chunk("\n"));


                                    MessageBox.Show("Imagem do cadastro da pessoa está corrompido!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    formInicial.adicionarConsoleLog("Imagem do cadastro da pessoa está corrompido!");
                                }
                            }

                            pdfDoc.Close();
                            stream.Close();
                            MessageBox.Show("Cadastro exportado com sucesso!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            formInicial.adicionarConsoleLog("Cadastro foi exportado com sucesso!");
                        }
                    }
                }
                else { MessageBox.Show("Não foi encontrado o arquivo do banco de dados.", "Opss", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else
            {
                MessageBox.Show("Escolha os registro de cadastro que deseja exportar!", "Opss", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                MessageBox.Show("Não foi encontrado nem um cadastro na lista!", "Opss", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
