﻿
using GeradorDeTestes.WinForm;

namespace GeradorDeTestes2024.ModuloQuestao
{
    public partial class TelaQuestaoForm : Form
    {
        private Alternativa alternativa;
        private Questao questao;
        public Questao Questao
        {
            get { return questao; }
            set
            {
                cmbMateria.SelectedItem = value.Materia;
                txtEnunciado.Text = value.Enunciado;
                CarregarLista(value);
            }
        }

        private void CarregarLista(Questao questao)
        {
            int i = 0;
            foreach (Alternativa a in questao.Alternativas)
            {
                listAlternativas.Items.Add(a);
                if (a.Correta)
                    listAlternativas.SetItemChecked(i, true);
                i++;
            }
        }

        public TelaQuestaoForm()
        {
            InitializeComponent();
            CarregarComboBox();
        }

        private void CarregarComboBox()
        {
            List<string> materias = new List<string>() { "Adição, 1ª Série", "Subtração, 1ª Série", "Multiplicação, 1ª Série", "Divisão, 1ª Série" };
            foreach (string m in materias)
            {
                cmbMateria.Items.Add(m);
            }
            cmbMateria.SelectedIndex = 0;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string descricao = txtResposta.Text;
            alternativa = new Alternativa(descricao);
            listAlternativas.Items.Add(alternativa);
            RefatorarAlternativasDinamicamente();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listAlternativas.SelectedIndex != -1)
            {
                listAlternativas.Items.RemoveAt(listAlternativas.SelectedIndex);
                RefatorarAlternativasDinamicamente();

            }

            else
                MessageBox.Show(
                    "Não é possível realizar esta ação sem uma alternativa selecionada.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string materia = (string)cmbMateria.SelectedItem;
            string enunciado = txtEnunciado.Text;

            List<Alternativa> alternativas = new List<Alternativa>();

            foreach (Alternativa a in listAlternativas.Items)
            {
                a.LimparRespostaCorreta();
                if (listAlternativas.CheckedItems.Contains(a))
                {
                    a.Correta = true;
                }
                alternativas.Add(a);
            }

            questao = new Questao(materia, enunciado, alternativas);

            List<string> erros = questao.Validar();
            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }
        }
        private void RefatorarAlternativasDinamicamente()
        {
            int x = 0;
            foreach (Alternativa a in listAlternativas.Items)
            {
                a.RefatorarModeloAlternativa(x);
                x++;
            }
        }
    }
}