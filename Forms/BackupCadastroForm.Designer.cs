namespace maisSaude.Forms
{
    partial class BackupCadastroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupCadastroForm));
            buttonTodosBackups = new Button();
            buttonSair = new Button();
            groupBox1 = new GroupBox();
            buttonPasta = new Button();
            buttonDeletar = new Button();
            buttonImportar = new Button();
            TextExtraido = new ListView();
            nomeArquivo = new ColumnHeader();
            dataArquivo = new ColumnHeader();
            pictureBoxLogo = new PictureBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            comboBoxTipo = new ComboBox();
            label16 = new Label();
            carregamentoBarra = new ProgressBar();
            fazerBackup = new Button();
            textData = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonTodosBackups
            // 
            buttonTodosBackups.BackColor = Color.SteelBlue;
            buttonTodosBackups.FlatStyle = FlatStyle.Flat;
            buttonTodosBackups.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonTodosBackups.ForeColor = Color.Black;
            buttonTodosBackups.Location = new Point(13, 402);
            buttonTodosBackups.Name = "buttonTodosBackups";
            buttonTodosBackups.Size = new Size(292, 36);
            buttonTodosBackups.TabIndex = 57;
            buttonTodosBackups.Text = "Acessar todos os backups";
            buttonTodosBackups.UseVisualStyleBackColor = false;
            buttonTodosBackups.Click += buttonTodosBackups_Click;
            // 
            // buttonSair
            // 
            buttonSair.BackColor = Color.Gray;
            buttonSair.FlatStyle = FlatStyle.Flat;
            buttonSair.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSair.ForeColor = Color.Black;
            buttonSair.Location = new Point(514, 402);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(229, 36);
            buttonSair.TabIndex = 56;
            buttonSair.Text = "Sair do Backup";
            buttonSair.UseVisualStyleBackColor = false;
            buttonSair.Click += buttonSair_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonPasta);
            groupBox1.Controls.Add(buttonDeletar);
            groupBox1.Controls.Add(buttonImportar);
            groupBox1.Controls.Add(TextExtraido);
            groupBox1.Location = new Point(13, 117);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(730, 279);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // buttonPasta
            // 
            buttonPasta.BackColor = Color.LightSeaGreen;
            buttonPasta.FlatStyle = FlatStyle.Flat;
            buttonPasta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPasta.ForeColor = Color.Black;
            buttonPasta.Location = new Point(194, 235);
            buttonPasta.Name = "buttonPasta";
            buttonPasta.Size = new Size(179, 36);
            buttonPasta.TabIndex = 54;
            buttonPasta.Text = "Abrir pasta de Backups";
            buttonPasta.UseVisualStyleBackColor = false;
            buttonPasta.Click += buttonPasta_Click;
            // 
            // buttonDeletar
            // 
            buttonDeletar.BackColor = Color.Red;
            buttonDeletar.FlatStyle = FlatStyle.Flat;
            buttonDeletar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDeletar.ForeColor = Color.Black;
            buttonDeletar.Location = new Point(9, 235);
            buttonDeletar.Name = "buttonDeletar";
            buttonDeletar.Size = new Size(179, 36);
            buttonDeletar.TabIndex = 53;
            buttonDeletar.Text = "Limpar lista de Backups";
            buttonDeletar.UseVisualStyleBackColor = false;
            buttonDeletar.Click += buttonDeletar_Click;
            // 
            // buttonImportar
            // 
            buttonImportar.BackColor = Color.FromArgb(99, 231, 95);
            buttonImportar.FlatStyle = FlatStyle.Flat;
            buttonImportar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonImportar.ForeColor = Color.Black;
            buttonImportar.Location = new Point(495, 235);
            buttonImportar.Name = "buttonImportar";
            buttonImportar.Size = new Size(229, 36);
            buttonImportar.TabIndex = 53;
            buttonImportar.Text = "Importa Backup";
            buttonImportar.UseVisualStyleBackColor = false;
            buttonImportar.Click += buttonImportar_Click;
            // 
            // TextExtraido
            // 
            TextExtraido.Columns.AddRange(new ColumnHeader[] { nomeArquivo, dataArquivo });
            TextExtraido.FullRowSelect = true;
            TextExtraido.Location = new Point(9, 15);
            TextExtraido.MultiSelect = false;
            TextExtraido.Name = "TextExtraido";
            TextExtraido.Size = new Size(715, 214);
            TextExtraido.TabIndex = 47;
            TextExtraido.UseCompatibleStateImageBehavior = false;
            TextExtraido.View = View.Details;
            // 
            // nomeArquivo
            // 
            nomeArquivo.Tag = "nomeArquivo";
            nomeArquivo.Text = "NOME";
            nomeArquivo.Width = 500;
            // 
            // dataArquivo
            // 
            dataArquivo.Tag = "dataArquivo";
            dataArquivo.Text = "DATA";
            dataArquivo.TextAlign = HorizontalAlignment.Center;
            dataArquivo.Width = 210;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.Ícone_para_software_;
            pictureBoxLogo.Location = new Point(577, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(166, 42);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 54;
            pictureBoxLogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(2, 9);
            label1.Name = "label1";
            label1.Size = new Size(485, 45);
            label1.TabIndex = 53;
            label1.Text = "Backup de Cadastro de Pessoa";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxTipo);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(carregamentoBarra);
            groupBox2.Controls.Add(fazerBackup);
            groupBox2.Controls.Add(textData);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(13, 64);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(730, 47);
            groupBox2.TabIndex = 58;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FlatStyle = FlatStyle.System;
            comboBoxTipo.Font = new Font("Segoe UI", 11.25F);
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Principal", "Novo" });
            comboBoxTipo.Location = new Point(411, 13);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(103, 28);
            comboBoxTipo.TabIndex = 59;
            // 
            // label16
            // 
            label16.BackColor = Color.FromArgb(99, 231, 95);
            label16.BorderStyle = BorderStyle.FixedSingle;
            label16.FlatStyle = FlatStyle.Flat;
            label16.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(357, 13);
            label16.Name = "label16";
            label16.Size = new Size(56, 27);
            label16.TabIndex = 58;
            label16.Text = "Tipo:";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // carregamentoBarra
            // 
            carregamentoBarra.ForeColor = Color.FromArgb(99, 231, 95);
            carregamentoBarra.Location = new Point(520, 13);
            carregamentoBarra.Name = "carregamentoBarra";
            carregamentoBarra.Size = new Size(204, 27);
            carregamentoBarra.TabIndex = 57;
            // 
            // fazerBackup
            // 
            fazerBackup.BackColor = Color.Orange;
            fazerBackup.FlatStyle = FlatStyle.Popup;
            fazerBackup.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fazerBackup.ForeColor = Color.Black;
            fazerBackup.Location = new Point(233, 13);
            fazerBackup.Name = "fazerBackup";
            fazerBackup.Size = new Size(118, 28);
            fazerBackup.TabIndex = 55;
            fazerBackup.Text = "Exportar Backup";
            fazerBackup.UseVisualStyleBackColor = false;
            fazerBackup.Click += button1_Click;
            // 
            // textData
            // 
            textData.BorderStyle = BorderStyle.FixedSingle;
            textData.Enabled = false;
            textData.Font = new Font("Segoe UI", 11.25F);
            textData.Location = new Point(76, 13);
            textData.Name = "textData";
            textData.Size = new Size(151, 27);
            textData.TabIndex = 56;
            textData.TextChanged += textData_TextChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(99, 231, 95);
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 13);
            label2.Name = "label2";
            label2.Size = new Size(69, 27);
            label2.TabIndex = 55;
            label2.Text = "Data:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackupCadastroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(755, 451);
            Controls.Add(groupBox2);
            Controls.Add(buttonTodosBackups);
            Controls.Add(buttonSair);
            Controls.Add(groupBox1);
            Controls.Add(pictureBoxLogo);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BackupCadastroForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Backup  Cadastro de Pessoa - +Saude";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonTodosBackups;
        private Button buttonSair;
        private GroupBox groupBox1;
        private Button buttonDeletar;
        private Button buttonImportar;
        private ListView TextExtraido;
        private ColumnHeader nomeArquivo;
        private ColumnHeader dataArquivo;
        private PictureBox pictureBoxLogo;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox textData;
        private Label label2;
        private Button fazerBackup;
        private ProgressBar carregamentoBarra;
        private ComboBox comboBoxTipo;
        private Label label16;
        private Button buttonPasta;
    }
}