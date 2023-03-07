using System.Runtime.CompilerServices;
using ValidationSaisieBibli;
using TransactionBibli;

namespace ValidationSaisieIHM
{
    public partial class Form1 : Form
    {
        MaTransaction? transac;
        public Form1()
        {
            InitializeComponent();
            setMessageToProvider(errorProviderNom, textName, "Longueur invalide");
            setMessageToProvider(errorProviderDate, textDate, "Date incorrecte");
            setMessageToProvider(errorProviderMontant, textMontant, "Montant invalide");
            setMessageToProvider(errorProviderCodePostal, textCodePostal, "Code postal invalide");
            this.errorProviderNom.SetError(this.textName, "Format de nom invalide: " + Environment.NewLine + " ne doit contenir que des champ");
            transac = null;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            bool valid = true;
            this.errorProviderNom.SetError(this.textName, "");

            if (!VerificationSaisie.MatchForAlphabetics(textName.Text))
            {
                setMessageToProvider(errorProviderNom, textName, "Caract�res non autoris�s");
                valid = false;
            }
            if (!VerificationSaisie.MatchForcharactersLength(textName.Text, 1, 30))
            {
                setMessageToProvider(errorProviderNom, textName, "Longueur invalide");
                valid = false;

            }
            btValider.Enabled = (valid ? CanClick() : false);
        }

        private void setMessageToProvider(ErrorProvider err, TextBox text, string reason)
        {

            if (err.GetError(text) == "")
            {
                err.SetError(text, String.Format("Format de {0} invalide:{1}{2}", text.Tag.ToString(), Environment.NewLine, reason));
            }
            else
            {
                err.SetError(text, String.Format("{0}{1}{2}", err.GetError(text), Environment.NewLine, reason));
            }

        }

        private bool CanClick()
        {
            return (VerificationSaisie.MatchForAlphabetics(textName.Text) &&
               VerificationSaisie.MatchForcharactersLength(textName.Text, 1, 30) &&
               VerificationSaisie.MatchForDate(textDate.Text) &&
               VerificationSaisie.MatchForPrice(textMontant.Text) &&
               VerificationSaisie.MatchForPostalCode(textCodePostal.Text));
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            if (CanClick())
            {
                transac = new MaTransaction(
                        textName.Text,
                        Convert.ToDouble(textMontant.Text),
                        DateTime.Parse(textDate.Text), 
                        textCodePostal.Text);

                MessageBox.Show(transac.ToString()
                    , "Validation effectu�e");
            }
        }

        private void btEffacer_Click(object sender, EventArgs e)
        {
            textName.Text = "";
            textDate.Text = "";
            textMontant.Text = "";
            textCodePostal.Text = "";
            btValider.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult diag = MessageBox.Show("Fin de l'application"
                , "FIN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diag != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void textDate_TextChanged(object sender, EventArgs e)
        {
            bool valid = true;
            this.errorProviderDate.SetError(this.textDate, "");
            DateTime dt;
            if (!DateTime.TryParse(textDate.Text, out dt))
            {
                setMessageToProvider(errorProviderDate, textDate, "Date incorrecte");
                valid = false;
            } else if (DateTime.Today >= dt)
            {
                setMessageToProvider(errorProviderDate, textDate, "La date doit etre apr�s la date actuelle");
                valid = false;
            }
            
            btValider.Enabled = (valid ? CanClick() : false);
        }



        private void textMontant_TextChanged(object sender, EventArgs e)
        {
            this.errorProviderMontant.SetError(this.textMontant, "");
            bool valid = VerificationSaisie.MatchForPrice(textMontant.Text);
            if (!valid)
            {
                setMessageToProvider(errorProviderMontant, textMontant, "Montant incorrect");
            }
            btValider.Enabled = (valid ? CanClick() : false);
        }

        private void textCodePostal_TextChanged(object sender, EventArgs e)
        {
            this.errorProviderCodePostal.SetError(this.textCodePostal, "");
            bool valid = VerificationSaisie.MatchForPostalCode(textCodePostal.Text);
            if (!valid)
            {
                setMessageToProvider(errorProviderCodePostal, textCodePostal, "CodePostal incorrect");
            }
            btValider.Enabled = (valid ? CanClick() : false);
        }
    }
}