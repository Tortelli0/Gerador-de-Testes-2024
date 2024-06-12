namespace GeradorDeTestes2024.ModuloQuestao
{
    partial class TelaQuestaoForm
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
            cmbMateria = new ComboBox();
            label2 = new Label();
            txtEnunciado = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            listAlternativas = new CheckedListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 28);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Matéria:";
            // 
            // cmbMateria
            // 
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(84, 24);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(159, 23);
            cmbMateria.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 2;
            label2.Text = "Enunciado:";
            // 
            // txtEnunciado
            // 
            txtEnunciado.Location = new Point(84, 62);
            txtEnunciado.Multiline = true;
            txtEnunciado.Name = "txtEnunciado";
            txtEnunciado.Size = new Size(289, 70);
            txtEnunciado.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 158);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Resposta:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(84, 147);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 37);
            textBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(295, 147);
            button1.Name = "button1";
            button1.Size = new Size(78, 37);
            button1.TabIndex = 6;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listAlternativas);
            groupBox1.Location = new Point(12, 199);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(361, 171);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alternativas:";
            // 
            // listAlternativas
            // 
            listAlternativas.FormattingEnabled = true;
            listAlternativas.Location = new Point(9, 46);
            listAlternativas.Name = "listAlternativas";
            listAlternativas.Size = new Size(346, 112);
            listAlternativas.TabIndex = 0;
            // 
            // TelaQuestaoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 407);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(txtEnunciado);
            Controls.Add(label2);
            Controls.Add(cmbMateria);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaQuestaoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Questões";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbMateria;
        private Label label2;
        private TextBox txtEnunciado;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private GroupBox groupBox1;
        private CheckedListBox listAlternativas;
    }
}