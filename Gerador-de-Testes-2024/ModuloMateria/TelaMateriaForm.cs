using GeradorDeTestes.WinForm;
using GeradorDeTestes2024.ModuloDisciplina;
using System.Diagnostics.Eventing.Reader;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GeradorDeTestes2024.ModuloMateria
{
    public partial class TelaMateriaForm : Form
    {
        private Materia materia;
        public Materia Materia
        {
            set
            {
                txtNomeMateria.Text = value.Nome;
                radioButtonSerie1.Checked = value.PrimeiraSerieMarcada();
                if (!radioButtonSerie1.Checked)
                    radioButtonSerie2.Checked = true;
                comboBoxMateriaDisciplina.SelectedItem = value.Disciplina;
            }
            get
            {
                return materia;
            }
        }

        public TelaMateriaForm(List<Disciplina> disciplinas)
        {
            InitializeComponent();

            CarregarComboBox(disciplinas);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeMateria.Text.Trim();
            string serie = "";
            if (radioButtonSerie1.Checked)
                serie = "1ª Série";
            else if (radioButtonSerie2.Checked)
                serie = "2ª Série";

            Disciplina disciplina = (Disciplina)comboBoxMateriaDisciplina.SelectedItem;

            materia = new Materia(nome, serie, disciplina);

            List<string> erros = materia.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }          
        }

        private void CarregarComboBox(List<Disciplina> disciplinas)
        {
            foreach (Disciplina d in disciplinas)
                comboBoxMateriaDisciplina.Items.Add(d);

            comboBoxMateriaDisciplina.SelectedIndex = 0;
        }
    }
}
