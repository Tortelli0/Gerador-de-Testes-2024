using GeradorDeTestes.WinForm;

namespace GeradorDeTestes2024.ModuloDisciplina
{
    public partial class TelaDisciplinaForm : Form
    {
        private Disciplina disciplina;
        private List<Disciplina> disciplinas;
        public Disciplina Disciplina
        {
            set
            {
                txtIdDisciplina.Text = value.Id.ToString();
                txtNomeDisciplina.Text = value.Nome;
            }
            get
            {
                return disciplina;
            }
        }

        public TelaDisciplinaForm(List<Disciplina> disciplinas)
        {
            InitializeComponent();
            this.disciplinas = disciplinas;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeDisciplina.Text;

            disciplina = new Disciplina(nome);

            List<string> erros = disciplina.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }

            if (disciplina.ExisteDisciplina(disciplinas, disciplina))
            {
                TelaPrincipalForm.Instancia.AtualizarRodape("Já existe uma Disciplina com este nome!");

                DialogResult = DialogResult.None;
            }
        }
    }
}