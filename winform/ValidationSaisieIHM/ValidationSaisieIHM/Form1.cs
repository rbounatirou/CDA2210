using ValidationSaisieBibli;

namespace ValidationSaisieIHM
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (VerificationSaisie.MatchForAlphabetics(textName.Text) &&
                VerificationSaisie.MatchForDate(textDate.Text) &&
                VerificationSaisie.MatchForDecimal(textMontant.Text) &&
                VerificationSaisie.MatchForPostalCode(textCodePostal.Text))
            {
                btValider.Enabled = true;
            } else
            {
                btValider.Enabled = false;
            }
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nom : " + textName.Text + Environment.NewLine +
                "Date: " + textDate.Text + Environment.NewLine +
                "Montant: " + textMontant.Text + Environment.NewLine +
                "Code postal: " + textCodePostal.Text
                , "Validation effectuée");
        }

        private void btEffacer_Click(object sender, EventArgs e)
        {
            textName.Text = "";
            textDate.Text = "";
            textMontant.Text = "";
            textCodePostal.Text = "";
            btValider.Enabled = false;
        }
    }
}