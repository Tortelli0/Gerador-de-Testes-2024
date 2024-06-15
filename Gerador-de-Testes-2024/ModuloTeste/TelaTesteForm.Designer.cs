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
            listQuestoes = new ListBox();
            btnSortear = new Button();
            btnGravar = new Button();
            btnCancelar = new Button();
            label5 = new Label();
            groupBox2 = new GroupBox();
            rdbSegundaSerie = new RadioButton();
            rdbPrimeiraSerie = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)numQuestoes).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 35);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Título:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 69);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "Disciplina:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 104);
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
            txtTitulo.TabIndex = 0;
            // 
            // cmbDisciplina
            // 
            cmbDisciplina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDisciplina.FormattingEnabled = true;
            cmbDisciplina.Location = new Point(85, 65);
            cmbDisciplina.Name = "cmbDisciplina";
            cmbDisciplina.Size = new Size(142, 23);
            cmbDisciplina.TabIndex = 1;
            cmbDisciplina.SelectedIndexChanged += cmbDisciplina_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(242, 137);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 5;
            label4.Text = "Qtd. Questões:";
            // 
            // numQuestoes
            // 
            numQuestoes.Location = new Point(333, 133);
            numQuestoes.Name = "numQuestoes";
            numQuestoes.Size = new Size(53, 23);
            numQuestoes.TabIndex = 5;
            // 
            // cmbMateria
            // 
            cmbMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(85, 100);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(142, 23);
            cmbMateria.TabIndex = 3;
            cmbMateria.SelectedIndexChanged += cmbMateria_SelectedIndexChanged;
            // 
            // checkBoxRecuperacao
            // 
            checkBoxRecuperacao.AutoSize = true;
            checkBoxRecuperacao.Location = new Point(242, 67);
            checkBoxRecuperacao.Name = "checkBoxRecuperacao";
            checkBoxRecuperacao.Size = new Size(143, 19);
            checkBoxRecuperacao.TabIndex = 2;
            checkBoxRecuperacao.Text = "Prova de Recuperação";
            checkBoxRecuperacao.UseVisualStyleBackColor = true;
            checkBoxRecuperacao.CheckedChanged += checkBoxRecuperacao_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listQuestoes);
            groupBox1.Controls.Add(btnSortear);
            groupBox1.Location = new Point(27, 163);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(359, 278);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Questões Selecionadas:";
            // 
            // listQuestoes
            // 
            listQuestoes.FormattingEnabled = true;
            listQuestoes.ItemHeight = 15;
            listQuestoes.Location = new Point(1, 50);
            listQuestoes.Name = "listQuestoes";
            listQuestoes.SelectionMode = SelectionMode.None;
            listQuestoes.Size = new Size(358, 229);
            listQuestoes.TabIndex = 2;
            // 
            // btnSortear
            // 
            btnSortear.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSortear.Location = new Point(9, 19);
            btnSortear.Name = "btnSortear";
            btnSortear.Size = new Size(121, 25);
            btnSortear.TabIndex = 1;
            btnSortear.Text = "Sortear Questões";
            btnSortear.UseVisualStyleBackColor = true;
            btnSortear.Click += btnSortear_Click;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(230, 447);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 7;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(311, 447);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 137);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 12;
            label5.Text = "Série:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdbSegundaSerie);
            groupBox2.Controls.Add(rdbPrimeiraSerie);
            groupBox2.Location = new Point(83, 124);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(144, 33);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // rdbSegundaSerie
            // 
            rdbSegundaSerie.AutoSize = true;
            rdbSegundaSerie.Location = new Point(74, 11);
            rdbSegundaSerie.Name = "rdbSegundaSerie";
            rdbSegundaSerie.Size = new Size(64, 19);
            rdbSegundaSerie.TabIndex = 1;
            rdbSegundaSerie.TabStop = true;
            rdbSegundaSerie.Text = "2º Série";
            rdbSegundaSerie.UseVisualStyleBackColor = true;
            rdbSegundaSerie.CheckedChanged += rdbSegundaSerie_CheckedChanged;
            // 
            // rdbPrimeiraSerie
            // 
            rdbPrimeiraSerie.AutoSize = true;
            rdbPrimeiraSerie.Location = new Point(4, 11);
            rdbPrimeiraSerie.Name = "rdbPrimeiraSerie";
            rdbPrimeiraSerie.Size = new Size(64, 19);
            rdbPrimeiraSerie.TabIndex = 0;
            rdbPrimeiraSerie.TabStop = true;
            rdbPrimeiraSerie.Text = "1º Série";
            rdbPrimeiraSerie.UseVisualStyleBackColor = true;
            rdbPrimeiraSerie.CheckedChanged += rdbPrimeiraSerie_CheckedChanged;
            // 
            // TelaTesteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 478);
            Controls.Add(groupBox2);
            Controls.Add(label5);
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
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private Button btnSortear;
        private Button btnGravar;
        private Button btnCancelar;
        private ListBox listQuestoes;
        private Label label5;
        private GroupBox groupBox2;
        private RadioButton rdbSegundaSerie;
        private RadioButton rdbPrimeiraSerie;
    }
}