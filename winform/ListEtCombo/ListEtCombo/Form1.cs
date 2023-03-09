namespace ListEtCombo
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
            comboSource.SelectedIndex = 0;
        }

        private void BtRight_Click(object sender, EventArgs e)
        {
            DecaleFromComboSource(comboSource.SelectedIndex);
            RefreshLockRightButtons();
            RefreshLockLeftButtons();
        }

        public void RefreshLockRightButtons()
        {
            buttonRight.Enabled = (comboSource.SelectedIndex != -1);
            buttonAllRight.Enabled = (comboSource.Items.Count != 0);
        }

        public void RefreshLockLeftButtons()
        {
            buttonLeft.Enabled = (listBox_Cible.SelectedIndex != -1);
            buttonAllLeft.Enabled = (listBox_Cible.Items.Count != 0);
        }

        private void BtAllRight_Click(object sender, EventArgs e)
        {
            int nbTurn = comboSource.Items.Count;
            for (int i = 0; i < nbTurn; i++)
            {
                DecaleFromComboSource(0);
            }
            RefreshLockRightButtons();
            RefreshLockLeftButtons();
           
        }

        private void DecaleFromComboSource(int ind)
        {
            if (ind == -1)
                return;

            string val = comboSource.Items[ind].ToString();
            listBox_Cible.Items.Add(val);
            if (comboSource.Items.Count > ind + 1)
            {
                comboSource.SelectedIndex = ind + 1;
            }
            else if (comboSource.Items.Count > ind - 1)
            {
                comboSource.SelectedIndex = ind - 1;
            }

            comboSource.Items.RemoveAt(ind);
        }

        private void DecaleFromListCible(int ind)
        {
            if (ind == -1)
                return;

            string val = listBox_Cible.Items[ind].ToString();
            comboSource.Items.Add(val);
            if (listBox_Cible.Items.Count > ind + 1)
            {
                listBox_Cible.SelectedIndex = ind + 1;
            }
            else if (listBox_Cible.Items.Count > ind - 1)
            {
                listBox_Cible.SelectedIndex = ind - 1;
            }

            listBox_Cible.Items.RemoveAt(ind);
        }



        private void BtLeft_Click(object sender, EventArgs e)
        {
            DecaleFromListCible(listBox_Cible.SelectedIndex);
            if (comboSource.Items.Count == 0)
            {
                buttonLeft.Enabled = false;
            }
            RefreshLockRightButtons();
            RefreshLockLeftButtons();
        }

        private void BtAllLeft_Click(object sender, EventArgs e)
        {
            int nbTurn = listBox_Cible.Items.Count;
            for (int i = 0; i < nbTurn; i++)
            {
                DecaleFromListCible(0);
            }
            if (nbTurn >= 1 && comboSource.SelectedIndex == -1)
                comboSource.SelectedIndex = 0;
            RefreshLockRightButtons();
            RefreshLockLeftButtons();
        }

        private void BtUp_Click(object sender, EventArgs e)
        {
            int selected = listBox_Cible.SelectedIndex;
            
            if (selected <= 0)
                return;
            listBox_Cible.Items.Insert(selected - 1, listBox_Cible.Items[selected]);
            listBox_Cible.Items.RemoveAt(selected+1);
            listBox_Cible.SelectedIndex = selected - 1;

        }

        private void BtDown_Click(object sender, EventArgs e)
        {
            int selected = listBox_Cible.SelectedIndex;

            if (selected < 0 || selected == listBox_Cible.Items.Count -1)
                return;
            listBox_Cible.Items.Insert(selected + 2, listBox_Cible.Items[selected]);
            listBox_Cible.Items.RemoveAt(selected );
            listBox_Cible.SelectedIndex = selected + 1;
        }

        private void ListCible_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonLeft.Enabled = (listBox_Cible.SelectedIndex != -1);
        }

        private void ComboSource_DropDown(object sender, EventArgs e)
        {
            if (!StringExists(comboSource.Text))
            {
                comboSource.Items.Add(comboSource.Text);
                
            }
            comboSource.SelectedIndex = comboSource.Items.Count - 1;
            RefreshLockRightButtons();
        }

        private bool StringExists(string str)
        {
            bool exists = false;
            int i = 0;
            while (!exists  && i < comboSource.Items.Count)
            {
                exists = comboSource.Items[i].ToString() == str;
                i++;
            }
            i = 0;
            while (!exists && i < listBox_Cible.Items.Count)
            {
                exists = listBox_Cible.Items[i].ToString() == str;
                i++;
            }
            return exists;
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonRight.Enabled = (comboSource.SelectedIndex != -1);
        }
    }
}