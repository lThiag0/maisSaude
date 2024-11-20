namespace CuidaMais
{
    partial class homeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homeForm));
            groupBox1 = new GroupBox();
            label4 = new Label();
            consoleLogGeral = new RichTextBox();
            buttonExporta = new Button();
            textVersao = new Label();
            label2 = new Label();
            buttonSair = new Button();
            buttonSobre = new Button();
            buttonBackup = new Button();
            buttonEditar = new Button();
            buttonCadastrar = new Button();
            pictureBoxLogo = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(consoleLogGeral);
            groupBox1.Controls.Add(buttonExporta);
            groupBox1.Controls.Add(textVersao);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(buttonSair);
            groupBox1.Controls.Add(buttonSobre);
            groupBox1.Controls.Add(buttonBackup);
            groupBox1.Controls.Add(buttonEditar);
            groupBox1.Controls.Add(buttonCadastrar);
            groupBox1.Location = new Point(20, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(529, 278);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = Color.FromArgb(99, 231, 95);
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(6, 129);
            label4.Name = "label4";
            label4.Size = new Size(513, 23);
            label4.TabIndex = 9;
            label4.Text = "Console Logs do Sistema";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // consoleLogGeral
            // 
            consoleLogGeral.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            consoleLogGeral.Location = new Point(6, 150);
            consoleLogGeral.Name = "consoleLogGeral";
            consoleLogGeral.ReadOnly = true;
            consoleLogGeral.Size = new Size(513, 99);
            consoleLogGeral.TabIndex = 8;
            consoleLogGeral.Text = "";
            // 
            // buttonExporta
            // 
            buttonExporta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonExporta.BackColor = Color.FromArgb(72, 216, 209);
            buttonExporta.FlatStyle = FlatStyle.Flat;
            buttonExporta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExporta.Location = new Point(352, 22);
            buttonExporta.Name = "buttonExporta";
            buttonExporta.Size = new Size(167, 47);
            buttonExporta.TabIndex = 3;
            buttonExporta.Text = "Exporta Cadastro";
            buttonExporta.UseVisualStyleBackColor = false;
            buttonExporta.Click += buttonExporta_Click;
            // 
            // textVersao
            // 
            textVersao.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textVersao.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textVersao.ForeColor = Color.Red;
            textVersao.Location = new Point(308, 252);
            textVersao.Name = "textVersao";
            textVersao.Size = new Size(211, 23);
            textVersao.TabIndex = 7;
            textVersao.Text = "Versão: 1.0.1.0";
            textVersao.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(6, 252);
            label2.Name = "label2";
            label2.Size = new Size(296, 23);
            label2.TabIndex = 6;
            label2.Text = "Desenvolvido pela Turma de ADS Uninassau";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonSair
            // 
            buttonSair.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSair.BackColor = Color.FromArgb(72, 216, 209);
            buttonSair.FlatStyle = FlatStyle.Flat;
            buttonSair.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSair.Location = new Point(352, 75);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(167, 47);
            buttonSair.TabIndex = 5;
            buttonSair.Text = "Sair do Aplicativo";
            buttonSair.UseVisualStyleBackColor = false;
            buttonSair.Click += buttonSair_Click;
            // 
            // buttonSobre
            // 
            buttonSobre.Anchor = AnchorStyles.Top;
            buttonSobre.BackColor = Color.FromArgb(72, 216, 209);
            buttonSobre.FlatStyle = FlatStyle.Flat;
            buttonSobre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSobre.Location = new Point(179, 75);
            buttonSobre.Name = "buttonSobre";
            buttonSobre.Size = new Size(167, 47);
            buttonSobre.TabIndex = 4;
            buttonSobre.Text = "Sobre +Saude";
            buttonSobre.UseVisualStyleBackColor = false;
            buttonSobre.Click += buttonSobre_Click;
            // 
            // buttonBackup
            // 
            buttonBackup.BackColor = Color.FromArgb(72, 216, 209);
            buttonBackup.FlatStyle = FlatStyle.Flat;
            buttonBackup.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBackup.Location = new Point(6, 75);
            buttonBackup.Name = "buttonBackup";
            buttonBackup.Size = new Size(167, 47);
            buttonBackup.TabIndex = 2;
            buttonBackup.Text = "Backup de Dados";
            buttonBackup.UseVisualStyleBackColor = false;
            buttonBackup.Click += buttonBackup_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Anchor = AnchorStyles.Top;
            buttonEditar.BackColor = Color.FromArgb(72, 216, 209);
            buttonEditar.FlatStyle = FlatStyle.Flat;
            buttonEditar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEditar.Location = new Point(179, 22);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(167, 47);
            buttonEditar.TabIndex = 1;
            buttonEditar.Text = "Editar Cadastro";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.BackColor = Color.FromArgb(72, 216, 209);
            buttonCadastrar.FlatStyle = FlatStyle.Flat;
            buttonCadastrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCadastrar.Location = new Point(6, 22);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(167, 47);
            buttonCadastrar.TabIndex = 0;
            buttonCadastrar.Text = "Cadastra Pessoa";
            buttonCadastrar.UseVisualStyleBackColor = false;
            buttonCadastrar.Click += button1_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxLogo.Image = maisSaude.Properties.Resources.Ícone_para_software_;
            pictureBoxLogo.Location = new Point(180, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(230, 55);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 4;
            pictureBoxLogo.TabStop = false;
            // 
            // homeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(568, 355);
            Controls.Add(pictureBoxLogo);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "homeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "+Saude - Inicio";
            Load += homeForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button buttonCadastrar;
        private Button buttonSobre;
        private Button buttonExporta;
        private Button buttonBackup;
        private Button buttonEditar;
        private Label textVersao;
        private Label label2;
        private Button buttonSair;
        private Label label4;
        private PictureBox pictureBoxLogo;
        public RichTextBox consoleLogGeral;
    }
}
