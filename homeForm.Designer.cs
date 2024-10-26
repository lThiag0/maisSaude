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
            groupBox1 = new GroupBox();
            label4 = new Label();
            consoleLogGeral = new RichTextBox();
            label3 = new Label();
            label2 = new Label();
            buttonSair = new Button();
            buttonSobre = new Button();
            buttonConfig = new Button();
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
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(consoleLogGeral);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(buttonSair);
            groupBox1.Controls.Add(buttonSobre);
            groupBox1.Controls.Add(buttonConfig);
            groupBox1.Controls.Add(buttonBackup);
            groupBox1.Controls.Add(buttonEditar);
            groupBox1.Controls.Add(buttonCadastrar);
            groupBox1.Location = new Point(20, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(460, 278);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(99, 231, 95);
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(6, 129);
            label4.Name = "label4";
            label4.Size = new Size(447, 23);
            label4.TabIndex = 9;
            label4.Text = "Console Logs do Sistema";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // consoleLogGeral
            // 
            consoleLogGeral.Enabled = false;
            consoleLogGeral.Location = new Point(6, 150);
            consoleLogGeral.Name = "consoleLogGeral";
            consoleLogGeral.Size = new Size(447, 99);
            consoleLogGeral.TabIndex = 8;
            consoleLogGeral.Text = "";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(308, 252);
            label3.Name = "label3";
            label3.Size = new Size(145, 23);
            label3.TabIndex = 7;
            label3.Text = "Versão: 1.0.1.0";
            label3.TextAlign = ContentAlignment.MiddleRight;
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
            buttonSair.BackColor = Color.FromArgb(72, 216, 209);
            buttonSair.FlatStyle = FlatStyle.Flat;
            buttonSair.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSair.Location = new Point(308, 75);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(145, 47);
            buttonSair.TabIndex = 5;
            buttonSair.Text = "Sair do Aplicativo";
            buttonSair.UseVisualStyleBackColor = false;
            // 
            // buttonSobre
            // 
            buttonSobre.BackColor = Color.FromArgb(72, 216, 209);
            buttonSobre.FlatStyle = FlatStyle.Flat;
            buttonSobre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSobre.Location = new Point(157, 75);
            buttonSobre.Name = "buttonSobre";
            buttonSobre.Size = new Size(145, 47);
            buttonSobre.TabIndex = 4;
            buttonSobre.Text = "Sobre +Saude";
            buttonSobre.UseVisualStyleBackColor = false;
            // 
            // buttonConfig
            // 
            buttonConfig.BackColor = Color.FromArgb(72, 216, 209);
            buttonConfig.FlatStyle = FlatStyle.Flat;
            buttonConfig.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonConfig.Location = new Point(6, 75);
            buttonConfig.Name = "buttonConfig";
            buttonConfig.Size = new Size(145, 47);
            buttonConfig.TabIndex = 3;
            buttonConfig.Text = "Configuração";
            buttonConfig.UseVisualStyleBackColor = false;
            // 
            // buttonBackup
            // 
            buttonBackup.BackColor = Color.FromArgb(72, 216, 209);
            buttonBackup.FlatStyle = FlatStyle.Flat;
            buttonBackup.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBackup.Location = new Point(308, 22);
            buttonBackup.Name = "buttonBackup";
            buttonBackup.Size = new Size(145, 47);
            buttonBackup.TabIndex = 2;
            buttonBackup.Text = "Backup de Dados";
            buttonBackup.UseVisualStyleBackColor = false;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.FromArgb(72, 216, 209);
            buttonEditar.FlatStyle = FlatStyle.Flat;
            buttonEditar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEditar.Location = new Point(157, 22);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(145, 47);
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
            buttonCadastrar.Size = new Size(145, 47);
            buttonCadastrar.TabIndex = 0;
            buttonCadastrar.Text = "Cadastra Pessoa";
            buttonCadastrar.UseVisualStyleBackColor = false;
            buttonCadastrar.Click += button1_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = maisSaude.Properties.Resources.Ícone_para_software_;
            pictureBoxLogo.Location = new Point(138, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(233, 55);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 4;
            pictureBoxLogo.TabStop = false;
            // 
            // homeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(500, 352);
            Controls.Add(pictureBoxLogo);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "homeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "+Saude - Inicio";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button buttonCadastrar;
        private Button buttonSobre;
        private Button buttonConfig;
        private Button buttonBackup;
        private Button buttonEditar;
        private Label label3;
        private Label label2;
        private Button buttonSair;
        private Label label4;
        private PictureBox pictureBoxLogo;
        public RichTextBox consoleLogGeral;
    }
}
