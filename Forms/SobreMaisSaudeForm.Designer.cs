namespace maisSaude.Forms
{
    partial class SobreMaisSaudeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SobreMaisSaudeForm));
            pictureBoxLogo = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            textVersao = new Label();
            label2 = new Label();
            buttonSair = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.Ícone_para_software_;
            pictureBoxLogo.Location = new Point(45, 57);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(244, 64);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 50;
            pictureBoxLogo.TabStop = false;
            pictureBoxLogo.Click += pictureBoxLogo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(311, 45);
            label1.TabIndex = 49;
            label1.Text = "Sobre o maisSaude";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textVersao);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 127);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 270);
            groupBox1.TabIndex = 51;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(99, 231, 95);
            label3.Location = new Point(6, 215);
            label3.Name = "label3";
            label3.Size = new Size(299, 23);
            label3.TabIndex = 54;
            label3.Text = "Link do projeto: https://github.com/lThiag0/maisSaude";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click_1;
            // 
            // textVersao
            // 
            textVersao.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textVersao.BackColor = Color.Transparent;
            textVersao.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textVersao.ForeColor = Color.Red;
            textVersao.Location = new Point(6, 244);
            textVersao.Name = "textVersao";
            textVersao.Size = new Size(299, 23);
            textVersao.TabIndex = 53;
            textVersao.Text = "Versão: 1.0.1.0";
            textVersao.TextAlign = ContentAlignment.MiddleCenter;
            textVersao.Click += label3_Click;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.ForeColor = Color.White;
            label2.Location = new Point(6, 13);
            label2.Name = "label2";
            label2.Size = new Size(299, 192);
            label2.TabIndex = 0;
            label2.Text = resources.GetString("label2.Text");
            // 
            // buttonSair
            // 
            buttonSair.BackColor = Color.Gray;
            buttonSair.FlatStyle = FlatStyle.Flat;
            buttonSair.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSair.ForeColor = Color.Black;
            buttonSair.Location = new Point(45, 403);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(244, 36);
            buttonSair.TabIndex = 52;
            buttonSair.Text = "Sair do Sobre maisSaude";
            buttonSair.UseVisualStyleBackColor = false;
            buttonSair.Click += buttonSair_Click;
            // 
            // SobreMaisSaudeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(338, 449);
            Controls.Add(buttonSair);
            Controls.Add(groupBox1);
            Controls.Add(pictureBoxLogo);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SobreMaisSaudeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sobre o MaisSaude";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Button buttonSair;
        private Label textVersao;
        private Label label3;
    }
}