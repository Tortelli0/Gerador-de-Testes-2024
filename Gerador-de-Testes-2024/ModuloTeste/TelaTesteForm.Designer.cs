namespace GeradorDeTestes2024.ModuloTeste
{
    partial class TelaTesteForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTitulo = new TextBox();
            cmbDisciplina = new ComboBox();
            label4 = new Label();
            numQuestoes = new NumericUpDown();
            cmbMateria = new ComboBox();
            checkBoxRecuperacao = new CheckBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnSortear = new Button();
            btnGravar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numQuestoes).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 35);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Título:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 69);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "Disciplina:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 104);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Matéria:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(85, 31);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(301, 23);
            txtTitulo.TabIndex = 3;
            // 
            // cmbDisciplina
            // 
            cmbDisciplina.FormattingEnabled = true;
            cmbDisciplina.Location = new Point(85, 65);
            cmbDisciplina.Name = "cmbDisciplina";
            cmbDisciplina.Size = new Size(142, 23);
            cmbDisciplina.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(242, 69);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 5;
            label4.Text = "Qtd. Questões:";
            // 
            // numQuestoes
            // 
            numQuestoes.Location = new Point(333, 65);
            numQuestoes.Name = "numQuestoes";
            numQuestoes.Size = new Size(53, 23);
            numQuestoes.TabIndex = 6;
            // 
            // cmbMateria
            // 
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(85, 100);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(142, 23);
            cmbMateria.TabIndex = 7;
            // 
            // checkBoxRecuperacao
            // 
            checkBoxRecuperacao.AutoSize = true;
            checkBoxRecuperacao.Location = new Point(242, 104);
            checkBoxRecuperacao.Name = "checkBoxRecuperacao";
            checkBoxRecuperacao.Size = new Size(143, 19);
            checkBoxRecuperacao.TabIndex = 8;
            checkBoxRecuperacao.Text = "Prova de Recuperação";
            checkBoxRecuperacao.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSortear);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(27, 152);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(359, 278);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Questões Selecionadas:";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(3, 44);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(353, 231);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btnSortear
            // 
            btnSortear.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSortear.Location = new Point(9, 19);
            btnSortear.Name = "btnSortear";
            btnSortear.Size = new Size(121, 25);
            btnSortear.TabIndex = 2;
            btnSortear.Text = "Sortear Questões";
            btnSortear.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(230, 436);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 10;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(311, 436);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaTesteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 472);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(groupBox1);
            Controls.Add(checkBoxRecuperacao);
            Controls.Add(cmbMateria);
            Controls.Add(numQuestoes);
            Controls.Add(label4);
            Controls.Add(cmbDisciplina);
            Controls.Add(txtTitulo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaTesteForm";
            Text = "Cadastro de Testes";
            ((System.ComponentModel.ISupportInitialize)numQuestoes).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTitulo;
        private ComboBox cmbDisciplina;
        private Label label4;
        private NumericUpDown numQuestoes;
        private ComboBox cmbMateria;
        private CheckBox checkBoxRecuperacao;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnSortear;
        private Button btnGravar;
        private Button btnCancelar;
    }
}