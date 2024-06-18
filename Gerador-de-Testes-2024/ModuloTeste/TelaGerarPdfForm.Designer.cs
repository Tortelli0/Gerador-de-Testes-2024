namespace GeradorDeTestes2024.ModuloTeste
{
    partial class TelaGerarPdfForm
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
            button1 = new Button();
            btnGravar = new Button();
            cbGabarito = new CheckBox();
            txtCaminho = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            lblTeste = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(397, 102);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(316, 102);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 1;
            btnGravar.Text = "Gerar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // cbGabarito
            // 
            cbGabarito.AutoSize = true;
            cbGabarito.Location = new Point(82, 75);
            cbGabarito.Name = "cbGabarito";
            cbGabarito.Size = new Size(128, 19);
            cbGabarito.TabIndex = 0;
            cbGabarito.Text = "Gerar com gabarito";
            cbGabarito.UseVisualStyleBackColor = true;
            // 
            // txtCaminho
            // 
            txtCaminho.Enabled = false;
            txtCaminho.Location = new Point(82, 46);
            txtCaminho.Name = "txtCaminho";
            txtCaminho.Size = new Size(309, 23);
            txtCaminho.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(397, 46);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Selecionar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 50);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 5;
            label1.Text = "Caminho:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 21);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 6;
            label2.Text = "Teste:";
            // 
            // lblTeste
            // 
            lblTeste.AutoSize = true;
            lblTeste.Location = new Point(82, 21);
            lblTeste.Name = "lblTeste";
            lblTeste.Size = new Size(38, 15);
            lblTeste.TabIndex = 7;
            lblTeste.Text = "label3";
            // 
            // TelaGerarPdfForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 137);
            Controls.Add(lblTeste);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(txtCaminho);
            Controls.Add(cbGabarito);
            Controls.Add(btnGravar);
            Controls.Add(button1);
            Name = "TelaGerarPdfForm";
            Text = "Gerar PDF";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnGravar;
        private CheckBox cbGabarito;
        private TextBox txtCaminho;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label lblTeste;
    }
}