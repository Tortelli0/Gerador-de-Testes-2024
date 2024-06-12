namespace GeradorDeTestes2024.ModuloDisciplina
{
    partial class TelaDisciplinaForm
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
            labelId = new Label();
            labelNome = new Label();
            txtIdDisciplina = new TextBox();
            txtNomeDisciplina = new TextBox();
            btnGravar = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(76, 94);
            labelId.Name = "labelId";
            labelId.Size = new Size(20, 15);
            labelId.TabIndex = 0;
            labelId.Text = "Id:";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(53, 134);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(43, 15);
            labelNome.TabIndex = 1;
            labelNome.Text = "Nome:";
            // 
            // txtIdDisciplina
            // 
            txtIdDisciplina.Enabled = false;
            txtIdDisciplina.Location = new Point(102, 91);
            txtIdDisciplina.Name = "txtIdDisciplina";
            txtIdDisciplina.Size = new Size(52, 23);
            txtIdDisciplina.TabIndex = 2;
            // 
            // txtNomeDisciplina
            // 
            txtNomeDisciplina.Location = new Point(102, 131);
            txtNomeDisciplina.Name = "txtNomeDisciplina";
            txtNomeDisciplina.Size = new Size(199, 23);
            txtNomeDisciplina.TabIndex = 3;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(176, 228);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(81, 26);
            btnGravar.TabIndex = 4;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(263, 228);
            button2.Name = "button2";
            button2.Size = new Size(81, 26);
            button2.TabIndex = 5;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // TelaDisciplinaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 265);
            Controls.Add(button2);
            Controls.Add(btnGravar);
            Controls.Add(txtNomeDisciplina);
            Controls.Add(txtIdDisciplina);
            Controls.Add(labelNome);
            Controls.Add(labelId);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaDisciplinaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Disciplinas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelId;
        private Label labelNome;
        private TextBox txtIdDisciplina;
        private TextBox txtNomeDisciplina;
        private Button btnGravar;
        private Button button2;
    }
}