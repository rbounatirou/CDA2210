namespace CreerFormulaires
{
    public partial class FormListProp : Form
    {

        public FormListProp()
        {
            InitializeComponent();            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkForSelected(sender as ListBox);
        }

        private void checkForSelected(ListBox? listfrom = null)
        {
            listfrom??=list_personnes;
            textContent.Text = (string)listfrom.SelectedItem;
            textCount.Text = listfrom.Items.Count.ToString();
            textSelectedIndex.Text = listfrom.SelectedIndex.ToString();
        }

        private void btAjout_Click(object sender, EventArgs e)
        {
            string els = textNouvelElement.Text.Trim();
            if (!ExistOnListBox(els, list_personnes))
            {
                list_personnes.Items.Add(els);
            }
                       
            textNouvelElement.Focus();

        }

        private bool ExistOnListBox(string text, ListBox list)
        {
            bool found = false;
            int i = 0;
            while (!found && i < list.Items.Count)
            {
                found = (list.Items[i].ToString() == text);
                i++;
                    
            }
            return found;
        }

        private void buttonVider_Click(object sender, EventArgs e)
        {
            list_personnes.Items.Clear();
            textContent.Text = "";
            textCount.Text = "";
            textSelectedIndex.Text = "";
        }

        private void btSelectionner_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textIndexElement.Text, out int nbSelect))
            {
                if (nbSelect >= list_personnes.Items.Count || nbSelect < 0)
                {
                    ErrorMessage("Index inexistant");
                } else
                {
                    list_personnes.SelectedIndex = nbSelect;
                }
            } else
            {
                ErrorMessage("Veuillez n'utiliser que des valeurs numériques entiéres svp");
            }
        }

        public void ErrorMessage(string str)
        {
            MessageBox.Show(str, "Avertissement de mauvaise utilisation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}