namespace maisSaude.Forms
{
    partial class EditarCadastroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarCadastroForm));
            pictureBoxLogo = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            TextExtraido = new ListView();
            ID = new ColumnHeader();
            nome = new ColumnHeader();
            CPF = new ColumnHeader();
            dataDeNascimento = new ColumnHeader();
            buttonBuscar = new Button();
            label23 = new Label();
            maskedTextBoxCPFEdit = new MaskedTextBox();
            label22 = new Label();
            textBoxNomeEdit = new TextBox();
            label21 = new Label();
            groupBox2 = new GroupBox();
            buttonDeletar = new Button();
            buttonSalvar = new Button();
            boxData = new MaskedTextBox();
            label20 = new Label();
            boxNumero = new MaskedTextBox();
            label19 = new Label();
            textBoxEndereco = new TextBox();
            label18 = new Label();
            textBoxAlergias = new TextBox();
            label17 = new Label();
            comboBoxAlergico = new ComboBox();
            label16 = new Label();
            textBoxMedicacoes = new TextBox();
            label15 = new Label();
            textBoxApto = new TextBox();
            label14 = new Label();
            boxRendValor = new NumericUpDown();
            label13 = new Label();
            textBoxCondSaude = new TextBox();
            label12 = new Label();
            boxCpf = new MaskedTextBox();
            label11 = new Label();
            textBoxExpeditor = new TextBox();
            label10 = new Label();
            boxRg = new MaskedTextBox();
            label9 = new Label();
            textBoxProfissao = new TextBox();
            label8 = new Label();
            boxDataDeNascimento = new MaskedTextBox();
            label7 = new Label();
            comboBoxCivil = new ComboBox();
            label6 = new Label();
            comboBoxEstado = new ComboBox();
            label5 = new Label();
            textBoxCidade = new TextBox();
            label4 = new Label();
            buttonUploadFoto = new Button();
            pictureBoxFoto3x4 = new PictureBox();
            textBoxNome = new TextBox();
            label3 = new Label();
            label2 = new Label();
            idCadastro = new MaskedTextBox();
            buttonSair = new Button();
            buttonTodosCadastros = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)boxRendValor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto3x4).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.Ícone_para_software_;
            pictureBoxLogo.Location = new Point(576, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(166, 42);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 5;
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
            label1.Size = new Size(416, 45);
            label1.TabIndex = 4;
            label1.Text = "Editar Cadastro de Pessoa";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TextExtraido);
            groupBox1.Controls.Add(buttonBuscar);
            groupBox1.Controls.Add(label23);
            groupBox1.Controls.Add(maskedTextBoxCPFEdit);
            groupBox1.Controls.Add(label22);
            groupBox1.Controls.Add(textBoxNomeEdit);
            groupBox1.Controls.Add(label21);
            groupBox1.Location = new Point(12, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(730, 134);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // TextExtraido
            // 
            TextExtraido.Columns.AddRange(new ColumnHeader[] { ID, nome, CPF, dataDeNascimento });
            TextExtraido.FullRowSelect = true;
            TextExtraido.Location = new Point(8, 46);
            TextExtraido.MultiSelect = false;
            TextExtraido.Name = "TextExtraido";
            TextExtraido.Size = new Size(715, 82);
            TextExtraido.TabIndex = 47;
            TextExtraido.UseCompatibleStateImageBehavior = false;
            TextExtraido.View = View.Details;
            TextExtraido.SelectedIndexChanged += TextExtraido_SelectedIndexChanged;
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
            // dataDeNascimento
            // 
            dataDeNascimento.Tag = "dataDeNascimento";
            dataDeNascimento.Text = "DATA DE NASCIMENTO";
            dataDeNascimento.TextAlign = HorizontalAlignment.Center;
            dataDeNascimento.Width = 150;
            // 
            // buttonBuscar
            // 
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
            maskedTextBoxCPFEdit.MaskInputRejected += maskedTextBoxCPFEdit_MaskInputRejected;
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
            textBoxNomeEdit.TextChanged += textBoxNomeEdit_TextChanged;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonDeletar);
            groupBox2.Controls.Add(buttonSalvar);
            groupBox2.Controls.Add(boxData);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(boxNumero);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(textBoxEndereco);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(textBoxAlergias);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(comboBoxAlergico);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(textBoxMedicacoes);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(textBoxApto);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(boxRendValor);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(textBoxCondSaude);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(boxCpf);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(textBoxExpeditor);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(boxRg);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBoxProfissao);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(boxDataDeNascimento);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(comboBoxCivil);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(comboBoxEstado);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBoxCidade);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(buttonUploadFoto);
            groupBox2.Controls.Add(pictureBoxFoto3x4);
            groupBox2.Controls.Add(textBoxNome);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(idCadastro);
            groupBox2.Enabled = false;
            groupBox2.Location = new Point(12, 202);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(730, 402);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // buttonDeletar
            // 
            buttonDeletar.BackColor = Color.Red;
            buttonDeletar.FlatStyle = FlatStyle.Flat;
            buttonDeletar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDeletar.ForeColor = Color.Black;
            buttonDeletar.Location = new Point(11, 358);
            buttonDeletar.Name = "buttonDeletar";
            buttonDeletar.Size = new Size(179, 36);
            buttonDeletar.TabIndex = 44;
            buttonDeletar.Text = "Deletar Cadastro";
            buttonDeletar.UseVisualStyleBackColor = false;
            buttonDeletar.Click += buttonDeletar_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = Color.FromArgb(99, 231, 95);
            buttonSalvar.FlatStyle = FlatStyle.Flat;
            buttonSalvar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSalvar.ForeColor = Color.Black;
            buttonSalvar.Location = new Point(494, 358);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(229, 36);
            buttonSalvar.TabIndex = 42;
            buttonSalvar.Text = "Salvar Cadastro";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // boxData
            // 
            boxData.BorderStyle = BorderStyle.FixedSingle;
            boxData.Enabled = false;
            boxData.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxData.Location = new Point(340, 325);
            boxData.Mask = "00/00/0000";
            boxData.Name = "boxData";
            boxData.Size = new Size(110, 27);
            boxData.TabIndex = 41;
            boxData.ValidatingType = typeof(DateTime);
            // 
            // label20
            // 
            label20.BackColor = Color.FromArgb(99, 231, 95);
            label20.BorderStyle = BorderStyle.FixedSingle;
            label20.FlatStyle = FlatStyle.Flat;
            label20.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.Location = new Point(196, 325);
            label20.Name = "label20";
            label20.Size = new Size(147, 27);
            label20.TabIndex = 40;
            label20.Text = "Data do Cadastro:";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // boxNumero
            // 
            boxNumero.BorderStyle = BorderStyle.FixedSingle;
            boxNumero.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxNumero.Location = new Point(76, 325);
            boxNumero.Mask = "(99) 00000-0000";
            boxNumero.Name = "boxNumero";
            boxNumero.Size = new Size(114, 27);
            boxNumero.TabIndex = 39;
            // 
            // label19
            // 
            label19.BackColor = Color.FromArgb(99, 231, 95);
            label19.BorderStyle = BorderStyle.FixedSingle;
            label19.FlatStyle = FlatStyle.Flat;
            label19.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(11, 325);
            label19.Name = "label19";
            label19.Size = new Size(68, 27);
            label19.TabIndex = 38;
            label19.Text = "Numero:";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxEndereco
            // 
            textBoxEndereco.BorderStyle = BorderStyle.FixedSingle;
            textBoxEndereco.Font = new Font("Segoe UI", 11.25F);
            textBoxEndereco.Location = new Point(98, 291);
            textBoxEndereco.Name = "textBoxEndereco";
            textBoxEndereco.Size = new Size(352, 27);
            textBoxEndereco.TabIndex = 37;
            // 
            // label18
            // 
            label18.BackColor = Color.FromArgb(99, 231, 95);
            label18.BorderStyle = BorderStyle.FixedSingle;
            label18.FlatStyle = FlatStyle.Flat;
            label18.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(11, 291);
            label18.Name = "label18";
            label18.Size = new Size(90, 27);
            label18.TabIndex = 36;
            label18.Text = "Endereço:";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxAlergias
            // 
            textBoxAlergias.BorderStyle = BorderStyle.FixedSingle;
            textBoxAlergias.Font = new Font("Segoe UI", 11.25F);
            textBoxAlergias.Location = new Point(581, 291);
            textBoxAlergias.Multiline = true;
            textBoxAlergias.Name = "textBoxAlergias";
            textBoxAlergias.Size = new Size(142, 61);
            textBoxAlergias.TabIndex = 35;
            // 
            // label17
            // 
            label17.BackColor = Color.FromArgb(99, 231, 95);
            label17.BorderStyle = BorderStyle.FixedSingle;
            label17.FlatStyle = FlatStyle.Flat;
            label17.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(456, 291);
            label17.Name = "label17";
            label17.Size = new Size(128, 61);
            label17.TabIndex = 34;
            label17.Text = "Medicações\r\nAlergicas:";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxAlergico
            // 
            comboBoxAlergico.FlatStyle = FlatStyle.System;
            comboBoxAlergico.Font = new Font("Segoe UI", 11.25F);
            comboBoxAlergico.FormattingEnabled = true;
            comboBoxAlergico.Items.AddRange(new object[] { "", "SIM", "NÃO" });
            comboBoxAlergico.Location = new Point(638, 255);
            comboBoxAlergico.Name = "comboBoxAlergico";
            comboBoxAlergico.Size = new Size(85, 28);
            comboBoxAlergico.TabIndex = 33;
            comboBoxAlergico.SelectedIndexChanged += comboBoxAlergico_SelectedIndexChanged;
            // 
            // label16
            // 
            label16.BackColor = Color.FromArgb(99, 231, 95);
            label16.BorderStyle = BorderStyle.FixedSingle;
            label16.FlatStyle = FlatStyle.Flat;
            label16.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(456, 256);
            label16.Name = "label16";
            label16.Size = new Size(186, 27);
            label16.TabIndex = 32;
            label16.Text = "Alergico a medicações?:";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxMedicacoes
            // 
            textBoxMedicacoes.BorderStyle = BorderStyle.FixedSingle;
            textBoxMedicacoes.Font = new Font("Segoe UI", 11.25F);
            textBoxMedicacoes.Location = new Point(176, 256);
            textBoxMedicacoes.Name = "textBoxMedicacoes";
            textBoxMedicacoes.Size = new Size(274, 27);
            textBoxMedicacoes.TabIndex = 31;
            // 
            // label15
            // 
            label15.BackColor = Color.FromArgb(99, 231, 95);
            label15.BorderStyle = BorderStyle.FixedSingle;
            label15.FlatStyle = FlatStyle.Flat;
            label15.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(11, 256);
            label15.Name = "label15";
            label15.Size = new Size(168, 27);
            label15.TabIndex = 30;
            label15.Text = "Medicações Utilizadas:";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxApto
            // 
            textBoxApto.BorderStyle = BorderStyle.FixedSingle;
            textBoxApto.Font = new Font("Segoe UI", 11.25F);
            textBoxApto.Location = new Point(542, 224);
            textBoxApto.Name = "textBoxApto";
            textBoxApto.Size = new Size(181, 27);
            textBoxApto.TabIndex = 29;
            // 
            // label14
            // 
            label14.BackColor = Color.FromArgb(99, 231, 95);
            label14.BorderStyle = BorderStyle.FixedSingle;
            label14.FlatStyle = FlatStyle.Flat;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(456, 224);
            label14.Name = "label14";
            label14.Size = new Size(88, 27);
            label14.TabIndex = 28;
            label14.Text = "Apto para:";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // boxRendValor
            // 
            boxRendValor.DecimalPlaces = 2;
            boxRendValor.Font = new Font("Segoe UI", 11.25F);
            boxRendValor.Location = new Point(359, 224);
            boxRendValor.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            boxRendValor.Name = "boxRendValor";
            boxRendValor.Size = new Size(91, 27);
            boxRendValor.TabIndex = 27;
            // 
            // label13
            // 
            label13.BackColor = Color.FromArgb(99, 231, 95);
            label13.BorderStyle = BorderStyle.FixedSingle;
            label13.FlatStyle = FlatStyle.Flat;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(164, 224);
            label13.Name = "label13";
            label13.Size = new Size(195, 27);
            label13.TabIndex = 25;
            label13.Text = "Rendimento Financeiro R$:";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxCondSaude
            // 
            textBoxCondSaude.BorderStyle = BorderStyle.FixedSingle;
            textBoxCondSaude.Font = new Font("Segoe UI", 11.25F);
            textBoxCondSaude.Location = new Point(291, 153);
            textBoxCondSaude.Multiline = true;
            textBoxCondSaude.Name = "textBoxCondSaude";
            textBoxCondSaude.Size = new Size(432, 67);
            textBoxCondSaude.TabIndex = 24;
            // 
            // label12
            // 
            label12.BackColor = Color.FromArgb(99, 231, 95);
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(164, 153);
            label12.Name = "label12";
            label12.Size = new Size(128, 67);
            label12.TabIndex = 23;
            label12.Text = "Condições \r\nde Saúde:";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // boxCpf
            // 
            boxCpf.BorderStyle = BorderStyle.FixedSingle;
            boxCpf.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxCpf.Location = new Point(563, 120);
            boxCpf.Mask = "000.000.000-00";
            boxCpf.Name = "boxCpf";
            boxCpf.Size = new Size(160, 27);
            boxCpf.TabIndex = 22;
            boxCpf.ValidatingType = typeof(int);
            // 
            // label11
            // 
            label11.BackColor = Color.FromArgb(99, 231, 95);
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(518, 120);
            label11.Name = "label11";
            label11.Size = new Size(48, 27);
            label11.TabIndex = 21;
            label11.Text = "CPF:";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxExpeditor
            // 
            textBoxExpeditor.BorderStyle = BorderStyle.FixedSingle;
            textBoxExpeditor.Font = new Font("Segoe UI", 11.25F);
            textBoxExpeditor.Location = new Point(429, 120);
            textBoxExpeditor.Name = "textBoxExpeditor";
            textBoxExpeditor.Size = new Size(83, 27);
            textBoxExpeditor.TabIndex = 20;
            // 
            // label10
            // 
            label10.BackColor = Color.FromArgb(99, 231, 95);
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(298, 120);
            label10.Name = "label10";
            label10.Size = new Size(134, 27);
            label10.TabIndex = 19;
            label10.Text = "Órgão Expeditor:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // boxRg
            // 
            boxRg.BorderStyle = BorderStyle.FixedSingle;
            boxRg.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxRg.Location = new Point(232, 120);
            boxRg.Mask = "000000";
            boxRg.Name = "boxRg";
            boxRg.Size = new Size(60, 27);
            boxRg.TabIndex = 18;
            boxRg.ValidatingType = typeof(int);
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(99, 231, 95);
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(164, 120);
            label9.Name = "label9";
            label9.Size = new Size(69, 27);
            label9.TabIndex = 17;
            label9.Text = "RG n.º:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxProfissao
            // 
            textBoxProfissao.BorderStyle = BorderStyle.FixedSingle;
            textBoxProfissao.Font = new Font("Segoe UI", 11.25F);
            textBoxProfissao.Location = new Point(509, 87);
            textBoxProfissao.Name = "textBoxProfissao";
            textBoxProfissao.Size = new Size(214, 27);
            textBoxProfissao.TabIndex = 16;
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(99, 231, 95);
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(426, 87);
            label8.Name = "label8";
            label8.Size = new Size(86, 27);
            label8.TabIndex = 15;
            label8.Text = "Profissão:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // boxDataDeNascimento
            // 
            boxDataDeNascimento.BorderStyle = BorderStyle.FixedSingle;
            boxDataDeNascimento.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxDataDeNascimento.Location = new Point(319, 87);
            boxDataDeNascimento.Mask = "00/00/0000";
            boxDataDeNascimento.Name = "boxDataDeNascimento";
            boxDataDeNascimento.Size = new Size(101, 27);
            boxDataDeNascimento.TabIndex = 14;
            boxDataDeNascimento.ValidatingType = typeof(DateTime);
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(99, 231, 95);
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(164, 87);
            label7.Name = "label7";
            label7.Size = new Size(158, 27);
            label7.TabIndex = 13;
            label7.Text = "Data de Nascimento:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxCivil
            // 
            comboBoxCivil.FlatStyle = FlatStyle.System;
            comboBoxCivil.Font = new Font("Segoe UI", 11.25F);
            comboBoxCivil.FormattingEnabled = true;
            comboBoxCivil.Items.AddRange(new object[] { "", "Solteiro", "Casado", "Separado", "Divorciado", "Viúvo" });
            comboBoxCivil.Location = new Point(614, 53);
            comboBoxCivil.Name = "comboBoxCivil";
            comboBoxCivil.Size = new Size(109, 28);
            comboBoxCivil.TabIndex = 12;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(99, 231, 95);
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(518, 53);
            label6.Name = "label6";
            label6.Size = new Size(99, 27);
            label6.TabIndex = 11;
            label6.Text = "Estado Civil:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FlatStyle = FlatStyle.System;
            comboBoxEstado.Font = new Font("Segoe UI", 11.25F);
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "", "AC", "AL", "AP", "AM", "BA", "CE", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO", "DF" });
            comboBoxEstado.Location = new Point(446, 53);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(66, 28);
            comboBoxEstado.TabIndex = 10;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(99, 231, 95);
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(381, 53);
            label5.Name = "label5";
            label5.Size = new Size(69, 27);
            label5.TabIndex = 9;
            label5.Text = "Estado:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxCidade
            // 
            textBoxCidade.BorderStyle = BorderStyle.FixedSingle;
            textBoxCidade.Font = new Font("Segoe UI", 11.25F);
            textBoxCidade.Location = new Point(232, 53);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(143, 27);
            textBoxCidade.TabIndex = 8;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(99, 231, 95);
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(164, 53);
            label4.Name = "label4";
            label4.Size = new Size(69, 27);
            label4.TabIndex = 7;
            label4.Text = "Cidade:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonUploadFoto
            // 
            buttonUploadFoto.BackColor = Color.FromArgb(99, 231, 95);
            buttonUploadFoto.FlatStyle = FlatStyle.Flat;
            buttonUploadFoto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonUploadFoto.Location = new Point(11, 224);
            buttonUploadFoto.Name = "buttonUploadFoto";
            buttonUploadFoto.Size = new Size(147, 27);
            buttonUploadFoto.TabIndex = 6;
            buttonUploadFoto.Text = "Escolhe Foto 3x4";
            buttonUploadFoto.UseVisualStyleBackColor = false;
            buttonUploadFoto.Click += buttonUploadFoto_Click;
            // 
            // pictureBoxFoto3x4
            // 
            pictureBoxFoto3x4.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxFoto3x4.Image = Properties.Resources.avatar;
            pictureBoxFoto3x4.InitialImage = Properties.Resources.avatar;
            pictureBoxFoto3x4.Location = new Point(11, 53);
            pictureBoxFoto3x4.Name = "pictureBoxFoto3x4";
            pictureBoxFoto3x4.Size = new Size(147, 167);
            pictureBoxFoto3x4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFoto3x4.TabIndex = 5;
            pictureBoxFoto3x4.TabStop = false;
            // 
            // textBoxNome
            // 
            textBoxNome.BorderStyle = BorderStyle.FixedSingle;
            textBoxNome.Font = new Font("Segoe UI", 11.25F);
            textBoxNome.Location = new Point(232, 19);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(491, 27);
            textBoxNome.TabIndex = 4;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(99, 231, 95);
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(164, 19);
            label3.Name = "label3";
            label3.Size = new Size(69, 27);
            label3.TabIndex = 3;
            label3.Text = "Nome:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(99, 231, 95);
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 19);
            label2.Name = "label2";
            label2.Size = new Size(38, 27);
            label2.TabIndex = 2;
            label2.Text = "n.º";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // idCadastro
            // 
            idCadastro.BorderStyle = BorderStyle.FixedSingle;
            idCadastro.Enabled = false;
            idCadastro.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idCadastro.Location = new Point(46, 19);
            idCadastro.Mask = "0000000000000000000";
            idCadastro.Name = "idCadastro";
            idCadastro.Size = new Size(112, 27);
            idCadastro.TabIndex = 1;
            idCadastro.ValidatingType = typeof(int);
            // 
            // buttonSair
            // 
            buttonSair.BackColor = Color.Gray;
            buttonSair.FlatStyle = FlatStyle.Flat;
            buttonSair.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSair.ForeColor = Color.Black;
            buttonSair.Location = new Point(513, 610);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(229, 36);
            buttonSair.TabIndex = 45;
            buttonSair.Text = "Sair do Editar Cadastro";
            buttonSair.UseVisualStyleBackColor = false;
            buttonSair.Click += buttonSair_Click;
            // 
            // buttonTodosCadastros
            // 
            buttonTodosCadastros.BackColor = Color.SteelBlue;
            buttonTodosCadastros.FlatStyle = FlatStyle.Flat;
            buttonTodosCadastros.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonTodosCadastros.ForeColor = Color.Black;
            buttonTodosCadastros.Location = new Point(12, 610);
            buttonTodosCadastros.Name = "buttonTodosCadastros";
            buttonTodosCadastros.Size = new Size(292, 36);
            buttonTodosCadastros.TabIndex = 46;
            buttonTodosCadastros.Text = "Acessar todos os cadastro";
            buttonTodosCadastros.UseVisualStyleBackColor = false;
            buttonTodosCadastros.Click += buttonTodosCadastros_Click;
            // 
            // EditarCadastroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(755, 655);
            Controls.Add(buttonTodosCadastros);
            Controls.Add(buttonSair);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBoxLogo);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "EditarCadastroForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Cadastro de Pessoa - +Saude";
            Load += EditarCadastroForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)boxRendValor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto3x4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private Label label1;
        private GroupBox groupBox1;
        private MaskedTextBox maskedTextBoxCPFEdit;
        private Label label22;
        private TextBox textBoxNomeEdit;
        private Label label21;
        private GroupBox groupBox2;
        private Button buttonDeletar;
        private Button buttonSalvar;
        private MaskedTextBox boxData;
        private Label label20;
        private MaskedTextBox boxNumero;
        private Label label19;
        private TextBox textBoxEndereco;
        private Label label18;
        private TextBox textBoxAlergias;
        private Label label17;
        private ComboBox comboBoxAlergico;
        private Label label16;
        private TextBox textBoxMedicacoes;
        private Label label15;
        private TextBox textBoxApto;
        private Label label14;
        private NumericUpDown boxRendValor;
        private Label label13;
        private TextBox textBoxCondSaude;
        private Label label12;
        private MaskedTextBox boxCpf;
        private Label label11;
        private TextBox textBoxExpeditor;
        private Label label10;
        private MaskedTextBox boxRg;
        private Label label9;
        private TextBox textBoxProfissao;
        private Label label8;
        private MaskedTextBox boxDataDeNascimento;
        private Label label7;
        private ComboBox comboBoxCivil;
        private Label label6;
        private ComboBox comboBoxEstado;
        private Label label5;
        private TextBox textBoxCidade;
        private Label label4;
        private Button buttonUploadFoto;
        private PictureBox pictureBoxFoto3x4;
        private TextBox textBoxNome;
        private Label label3;
        private Label label2;
        private MaskedTextBox idCadastro;
        private Label label23;
        private Button buttonBuscar;
        private ListView TextExtraido;
        private ColumnHeader ID;
        private ColumnHeader CPF;
        private ColumnHeader nome;
        private ColumnHeader dataDeNascimento;
        private Button buttonSair;
        private Button buttonTodosCadastros;
    }
}