namespace maisSaude.Forms
{
    partial class ExportarCadastroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportarCadastroForm));
            buttonTodosCadastros = new Button();
            buttonSair = new Button();
            groupBox1 = new GroupBox();
            buttonTodos = new Button();
            buttonDeletar = new Button();
            buttonExporta = new Button();
            TextExtraido = new ListView();
            ID = new ColumnHeader();
            nome = new ColumnHeader();
            CPF = new ColumnHeader();
            cidade = new ColumnHeader();
            Estado = new ColumnHeader();
            estadoCivil = new ColumnHeader();
            dataDeNascimento = new ColumnHeader();
            profissao = new ColumnHeader();
            rg = new ColumnHeader();
            orgaoExpeditor = new ColumnHeader();
            condSaude = new ColumnHeader();
            rendimento = new ColumnHeader();
            apto = new ColumnHeader();
            medicacoes = new ColumnHeader();
            alergico = new ColumnHeader();
            endereco = new ColumnHeader();
            alergias = new ColumnHeader();
            data = new ColumnHeader();
            foto = new ColumnHeader();
            numero = new ColumnHeader();
            buttonBuscar = new Button();
            label23 = new Label();
            maskedTextBoxCPFEdit = new MaskedTextBox();
            label22 = new Label();
            textBoxNomeEdit = new TextBox();
            label21 = new Label();
            pictureBoxLogo = new PictureBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // buttonTodosCadastros
            // 
            buttonTodosCadastros.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonTodosCadastros.BackColor = Color.SteelBlue;
            buttonTodosCadastros.FlatStyle = FlatStyle.Flat;
            buttonTodosCadastros.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonTodosCadastros.ForeColor = Color.Black;
            buttonTodosCadastros.Location = new Point(12, 500);
            buttonTodosCadastros.Name = "buttonTodosCadastros";
            buttonTodosCadastros.Size = new Size(292, 36);
            buttonTodosCadastros.TabIndex = 52;
            buttonTodosCadastros.Text = "Acessar todos os cadastro";
            buttonTodosCadastros.UseVisualStyleBackColor = false;
            buttonTodosCadastros.Click += buttonTodosCadastros_Click;
            // 
            // buttonSair
            // 
            buttonSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSair.BackColor = Color.Gray;
            buttonSair.FlatStyle = FlatStyle.Flat;
            buttonSair.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSair.ForeColor = Color.Black;
            buttonSair.Location = new Point(513, 500);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(229, 36);
            buttonSair.TabIndex = 51;
            buttonSair.Text = "Sair do Exportar Cadastro";
            buttonSair.UseVisualStyleBackColor = false;
            buttonSair.Click += buttonSair_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(buttonTodos);
            groupBox1.Controls.Add(buttonDeletar);
            groupBox1.Controls.Add(buttonExporta);
            groupBox1.Controls.Add(TextExtraido);
            groupBox1.Controls.Add(buttonBuscar);
            groupBox1.Controls.Add(label23);
            groupBox1.Controls.Add(maskedTextBoxCPFEdit);
            groupBox1.Controls.Add(label22);
            groupBox1.Controls.Add(textBoxNomeEdit);
            groupBox1.Controls.Add(label21);
            groupBox1.Location = new Point(12, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(730, 432);
            groupBox1.TabIndex = 49;
            groupBox1.TabStop = false;
            // 
            // buttonTodos
            // 
            buttonTodos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonTodos.BackColor = Color.LightSeaGreen;
            buttonTodos.FlatStyle = FlatStyle.Flat;
            buttonTodos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonTodos.ForeColor = Color.Black;
            buttonTodos.Location = new Point(193, 390);
            buttonTodos.Name = "buttonTodos";
            buttonTodos.Size = new Size(190, 36);
            buttonTodos.TabIndex = 54;
            buttonTodos.Text = "Selecionar Todos";
            buttonTodos.UseVisualStyleBackColor = false;
            buttonTodos.Click += buttonTodos_Click;
            // 
            // buttonDeletar
            // 
            buttonDeletar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonDeletar.BackColor = Color.Red;
            buttonDeletar.FlatStyle = FlatStyle.Flat;
            buttonDeletar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDeletar.ForeColor = Color.Black;
            buttonDeletar.Location = new Point(8, 390);
            buttonDeletar.Name = "buttonDeletar";
            buttonDeletar.Size = new Size(179, 36);
            buttonDeletar.TabIndex = 53;
            buttonDeletar.Text = "Limpar Selecionados";
            buttonDeletar.UseVisualStyleBackColor = false;
            buttonDeletar.Click += buttonDeletar_Click;
            // 
            // buttonExporta
            // 
            buttonExporta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonExporta.BackColor = Color.FromArgb(99, 231, 95);
            buttonExporta.FlatStyle = FlatStyle.Flat;
            buttonExporta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExporta.ForeColor = Color.Black;
            buttonExporta.Location = new Point(494, 390);
            buttonExporta.Name = "buttonExporta";
            buttonExporta.Size = new Size(229, 36);
            buttonExporta.TabIndex = 53;
            buttonExporta.Text = "Exporta Cadastro";
            buttonExporta.UseVisualStyleBackColor = false;
            buttonExporta.Click += buttonExporta_Click;
            // 
            // TextExtraido
            // 
            TextExtraido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextExtraido.CheckBoxes = true;
            TextExtraido.Columns.AddRange(new ColumnHeader[] { ID, nome, CPF, cidade, Estado, estadoCivil, dataDeNascimento, profissao, rg, orgaoExpeditor, condSaude, rendimento, apto, medicacoes, alergico, endereco, alergias, data, foto, numero });
            TextExtraido.FullRowSelect = true;
            TextExtraido.Location = new Point(8, 46);
            TextExtraido.Name = "TextExtraido";
            TextExtraido.Size = new Size(715, 338);
            TextExtraido.TabIndex = 47;
            TextExtraido.UseCompatibleStateImageBehavior = false;
            TextExtraido.View = View.Details;
            // 
            // ID
            // 
            ID.Tag = "id";
            ID.Text = "ID";
            ID.Width = 70;
            // 
            // nome
            // 
            nome.Tag = "nome";
            nome.Text = "NOME";
            nome.TextAlign = HorizontalAlignment.Center;
            nome.Width = 340;
            // 
            // CPF
            // 
            CPF.Tag = "cpf";
            CPF.Text = "CPF";
            CPF.TextAlign = HorizontalAlignment.Center;
            CPF.Width = 150;
            // 
            // cidade
            // 
            cidade.DisplayIndex = 4;
            cidade.Text = "CIDADE";
            cidade.TextAlign = HorizontalAlignment.Center;
            cidade.Width = 120;
            // 
            // Estado
            // 
            Estado.DisplayIndex = 5;
            Estado.Text = "ESTADO";
            Estado.TextAlign = HorizontalAlignment.Center;
            // 
            // estadoCivil
            // 
            estadoCivil.DisplayIndex = 6;
            estadoCivil.Text = "Estado Civil";
            estadoCivil.TextAlign = HorizontalAlignment.Center;
            estadoCivil.Width = 120;
            // 
            // dataDeNascimento
            // 
            dataDeNascimento.DisplayIndex = 3;
            dataDeNascimento.Tag = "dataDeNascimento";
            dataDeNascimento.Text = "DATA DE NASCIMENTO";
            dataDeNascimento.TextAlign = HorizontalAlignment.Center;
            dataDeNascimento.Width = 150;
            // 
            // profissao
            // 
            profissao.Text = "PROFISSÃO";
            profissao.TextAlign = HorizontalAlignment.Center;
            profissao.Width = 150;
            // 
            // rg
            // 
            rg.Text = "RG";
            rg.TextAlign = HorizontalAlignment.Center;
            rg.Width = 80;
            // 
            // orgaoExpeditor
            // 
            orgaoExpeditor.Text = "ORGÃO EXPEDITOR";
            orgaoExpeditor.TextAlign = HorizontalAlignment.Center;
            orgaoExpeditor.Width = 70;
            // 
            // condSaude
            // 
            condSaude.Text = "CONDIÇÃO DE SAUDE";
            condSaude.TextAlign = HorizontalAlignment.Center;
            condSaude.Width = 150;
            // 
            // rendimento
            // 
            rendimento.Text = "RENDIMENTO";
            rendimento.TextAlign = HorizontalAlignment.Center;
            rendimento.Width = 120;
            // 
            // apto
            // 
            apto.Text = "APTO";
            apto.TextAlign = HorizontalAlignment.Center;
            apto.Width = 90;
            // 
            // medicacoes
            // 
            medicacoes.Text = "MEDICAÇÕES";
            medicacoes.TextAlign = HorizontalAlignment.Center;
            medicacoes.Width = 150;
            // 
            // alergico
            // 
            alergico.Text = "ALERGICO";
            alergico.TextAlign = HorizontalAlignment.Center;
            alergico.Width = 90;
            // 
            // endereco
            // 
            endereco.Text = "ENDEREÇO";
            endereco.TextAlign = HorizontalAlignment.Center;
            endereco.Width = 150;
            // 
            // alergias
            // 
            alergias.Text = "ALERGIAS";
            alergias.TextAlign = HorizontalAlignment.Center;
            alergias.Width = 120;
            // 
            // data
            // 
            data.Text = "DATA DO CADASTRO";
            data.TextAlign = HorizontalAlignment.Center;
            data.Width = 100;
            // 
            // foto
            // 
            foto.Text = "FOTO 3X4";
            foto.TextAlign = HorizontalAlignment.Center;
            foto.Width = 100;
            // 
            // numero
            // 
            numero.Text = "TELEFONE";
            numero.TextAlign = HorizontalAlignment.Center;
            numero.Width = 120;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonBuscar.BackColor = Color.Orange;
            buttonBuscar.FlatStyle = FlatStyle.Popup;
            buttonBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBuscar.ForeColor = Color.Black;
            buttonBuscar.Location = new Point(605, 13);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(118, 27);
            buttonBuscar.TabIndex = 45;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.White;
            label23.Location = new Point(382, 17);
            label23.Name = "label23";
            label23.Size = new Size(35, 23);
            label23.TabIndex = 8;
            label23.Text = "OU";
            // 
            // maskedTextBoxCPFEdit
            // 
            maskedTextBoxCPFEdit.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBoxCPFEdit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBoxCPFEdit.Location = new Point(468, 13);
            maskedTextBoxCPFEdit.Mask = "000.000.000-00";
            maskedTextBoxCPFEdit.Name = "maskedTextBoxCPFEdit";
            maskedTextBoxCPFEdit.Size = new Size(131, 27);
            maskedTextBoxCPFEdit.TabIndex = 46;
            maskedTextBoxCPFEdit.ValidatingType = typeof(int);
            // 
            // label22
            // 
            label22.BackColor = Color.FromArgb(99, 231, 95);
            label22.BorderStyle = BorderStyle.FixedSingle;
            label22.FlatStyle = FlatStyle.Flat;
            label22.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.Location = new Point(423, 13);
            label22.Name = "label22";
            label22.Size = new Size(48, 27);
            label22.TabIndex = 45;
            label22.Text = "CPF:";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxNomeEdit
            // 
            textBoxNomeEdit.BorderStyle = BorderStyle.FixedSingle;
            textBoxNomeEdit.Font = new Font("Segoe UI", 11.25F);
            textBoxNomeEdit.Location = new Point(76, 13);
            textBoxNomeEdit.Name = "textBoxNomeEdit";
            textBoxNomeEdit.Size = new Size(299, 27);
            textBoxNomeEdit.TabIndex = 46;
            // 
            // label21
            // 
            label21.BackColor = Color.FromArgb(99, 231, 95);
            label21.BorderStyle = BorderStyle.FixedSingle;
            label21.FlatStyle = FlatStyle.Flat;
            label21.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(8, 13);
            label21.Name = "label21";
            label21.Size = new Size(69, 27);
            label21.TabIndex = 45;
            label21.Text = "Nome:";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.Ícone_para_software_;
            pictureBoxLogo.Location = new Point(576, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(166, 42);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 48;
            pictureBoxLogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1, 9);
            label1.Name = "label1";
            label1.Size = new Size(458, 45);
            label1.TabIndex = 47;
            label1.Text = "Exportar Cadastro de Pessoa";
            // 
            // ExportarCadastroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(756, 549);
            Controls.Add(buttonTodosCadastros);
            Controls.Add(buttonSair);
            Controls.Add(groupBox1);
            Controls.Add(pictureBoxLogo);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ExportarCadastroForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exportar  Cadastro de Pessoa - +Saude";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonTodosCadastros;
        private Button buttonSair;
        private GroupBox groupBox1;
        private ListView TextExtraido;
        private ColumnHeader ID;
        private ColumnHeader nome;
        private ColumnHeader CPF;
        private ColumnHeader dataDeNascimento;
        private Button buttonBuscar;
        private Label label23;
        private MaskedTextBox maskedTextBoxCPFEdit;
        private Label label22;
        private TextBox textBoxNomeEdit;
        private Label label21;
        private PictureBox pictureBoxLogo;
        private Label label1;
        private Button buttonExporta;
        private Button buttonDeletar;
        private ColumnHeader cidade;
        private ColumnHeader Estado;
        private ColumnHeader estadoCivil;
        private ColumnHeader profissao;
        private ColumnHeader rg;
        private ColumnHeader orgaoExpeditor;
        private ColumnHeader condSaude;
        private ColumnHeader rendimento;
        private ColumnHeader apto;
        private ColumnHeader medicacoes;
        private ColumnHeader alergico;
        private ColumnHeader endereco;
        private ColumnHeader alergias;
        private ColumnHeader data;
        private ColumnHeader foto;
        private ColumnHeader numero;
        private Button buttonTodos;
    }
}