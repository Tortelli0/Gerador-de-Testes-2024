namespace GeradorDeTestes2024.ModuloMateria
{
    partial class TelaMateriaForm
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
            btnGravar = new Button();
            button2 = new Button();
            label2 = new Label();
            txtNomeMateria = new TextBox();
            label3 = new Label();
            comboBoxMateriaDisciplina = new ComboBox();
            label4 = new Label();
            radioButtonSerie2 = new RadioButton();
            radioButtonSerie1 = new RadioButton();
            groupBoxMateria = new GroupBox();
            groupBoxMateria.SuspendLayout();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(146, 226);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(88, 29);
            btnGravar.TabIndex = 2;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(242, 226);
            button2.Name = "button2";
            button2.Size = new Size(88, 29);
            button2.TabIndex = 2;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 88);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // txtNomeMateria
            // 
            txtNomeMateria.Location = new Point(92, 85);
            txtNomeMateria.Name = "txtNomeMateria";
            txtNomeMateria.Size = new Size(238, 23);
            txtNomeMateria.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 124);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 1;
            label3.Text = "Disciplina:";
            // 
            // comboBoxMateriaDisciplina
            // 
            comboBoxMateriaDisciplina.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMateriaDisciplina.FormattingEnabled = true;
            comboBoxMateriaDisciplina.Location = new Point(92, 121);
            comboBoxMateriaDisciplina.Name = "comboBoxMateriaDisciplina";
            comboBoxMateriaDisciplina.Size = new Size(106, 23);
            comboBoxMateriaDisciplina.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 172);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 1;
            label4.Text = "Série:";
            // 
            // radioButtonSerie2
            // 
            radioButtonSerie2.AutoSize = true;
            radioButtonSerie2.Location = new Point(48, 22);
            radioButtonSerie2.Name = "radioButtonSerie2";
            radioButtonSerie2.Size = new Size(36, 19);
            radioButtonSerie2.TabIndex = 4;
            radioButtonSerie2.TabStop = true;
            radioButtonSerie2.Text = "2ª";
            radioButtonSerie2.UseVisualStyleBackColor = true;
            // 
            // radioButtonSerie1
            // 
            radioButtonSerie1.AutoSize = true;
            radioButtonSerie1.Location = new Point(6, 22);
            radioButtonSerie1.Name = "radioButtonSerie1";
            radioButtonSerie1.Size = new Size(36, 19);
            radioButtonSerie1.TabIndex = 4;
            radioButtonSerie1.TabStop = true;
            radioButtonSerie1.Text = "1ª";
            radioButtonSerie1.UseVisualStyleBackColor = true;
            // 
            // groupBoxMateria
            // 
            groupBoxMateria.Controls.Add(radioButtonSerie2);
            groupBoxMateria.Controls.Add(radioButtonSerie1);
            groupBoxMateria.Location = new Point(92, 152);
            groupBoxMateria.Name = "groupBoxMateria";
            groupBoxMateria.Size = new Size(85, 54);
            groupBoxMateria.TabIndex = 5;
            groupBoxMateria.TabStop = false;
            // 
            // TelaMateriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 267);
            Controls.Add(groupBoxMateria);
            Controls.Add(comboBoxMateriaDisciplina);
            Controls.Add(button2);
            Controls.Add(btnGravar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNomeMateria);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaMateriaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Matérias";
            groupBoxMateria.ResumeLayout(false);
            groupBoxMateria.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnGravar;
        private Button button2;
        private Label label2;
        private TextBox txtNomeMateria;
        private Label label3;
        private ComboBox comboBoxMateriaDisciplina;
        private Label label4;
        private RadioButton radioButtonSerie2;
        private RadioButton radioButtonSerie1;
        private GroupBox groupBoxMateria;
    }
}