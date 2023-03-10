using PaysBibli;

namespace ListEtCombo
{
    public partial class Form1 : Form
    {

        ListePays paysList;
        public Form1()
        {
            InitializeComponent();

            paysList = new ListePays();
            paysList.AjouterPays("France");
            paysList.AjouterPays("Belgique");
            paysList.AjouterPays("Bulgarie");
            paysList.AjouterPays("Allemagne");
            paysList.AjouterPays("Espagne");
            paysList.AjouterPays("Japon");
            paysList.AjouterPays("Portugal");
            paysList.AjouterPays("Grece");
            foreach (string s in paysList.GetUnselectedListOfPays())
            {
                comboSource.Items.Add(s);
            }
            comboSource.SelectedIndex = 0;
        }

        public Form1(ListePays _paysList)
        {
            InitializeComponent();
            paysList = new ListePays(
                _paysList);
            foreach (string s in paysList.GetUnselectedListOfPays())
            {
                comboSource.Items.Add(s);
            }


            if (comboSource.Items.Count > 0)
            {
                comboSource.SelectedIndex = 0;
                comboSource.Text = comboSource.Items[comboSource.SelectedIndex].ToString();
            } else
            {
                comboSource.SelectedIndex = -1;
            }
            
            foreach (string s in paysList.GetSelectedListOfPays())
            {
                listBox_Cible.Items.Add(s);
            }
            listBox_Cible.SelectedItem = (listBox_Cible.Items.Count > 0 ? 0 : -1);
            RefreshButtonLock();
        }
        #region btGaucheDroite
        private void BtRight_Click(object sender, EventArgs e)
        {
            ShiftFromSourceComboToTargetList(comboSource.SelectedIndex);
            listBox_Cible.SelectedIndex = listBox_Cible.Items.Count - 1;
            RefreshButtonLock();
        }
        private void BtAllRight_Click(object sender, EventArgs e)
        {
            int nbTurn = comboSource.Items.Count;
            for (int i = 0; i < nbTurn; i++)
            {
                ShiftFromSourceComboToTargetList(0);
            }
            RefreshButtonLock();

        }
        
        private void BtLeft_Click(object sender, EventArgs e)
        {
            ShiftFromTargetListToSourceCombo(listBox_Cible.SelectedIndex);
            if (comboSource.Items.Count == 0)
            {
                buttonLeft.Enabled = false;
            }
            RefreshButtonLock();
            comboSource.SelectedIndex = comboSource.Items.Count - 1;
        }

        private void BtAllLeft_Click(object sender, EventArgs e)
        {
            int nbTurn = listBox_Cible.Items.Count;
            for (int i = 0; i < nbTurn; i++)
            {
                ShiftFromTargetListToSourceCombo(0);
            }
            if (nbTurn >= 1 && comboSource.SelectedIndex == -1)
                comboSource.SelectedIndex = 0;
            RefreshLockRightButtons();
            RefreshLockLeftButtons();
        }
        #endregion

        #region actualisationController
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

        public void RefreshUpButton()
        {
            btUp.Enabled = (listBox_Cible.SelectedIndex > 0);
        }

        public void RefreshDownButton()
        {
            btDown.Enabled = (listBox_Cible.SelectedIndex != -1 &&
                listBox_Cible.SelectedIndex < listBox_Cible.Items.Count - 1);
        }

        public void RefreshButtonLock()
        {
            RefreshDownButton();
            RefreshLockLeftButtons();
            RefreshLockRightButtons();
            RefreshUpButton();
        }

        #endregion

        #region deplacementDesDonees (+bt Haut et bas)
        private void ShiftFromSourceComboToTargetList(int ind)
        {
            if (ind == -1)
                return;

            string val = comboSource.Items[ind].ToString();
            if (paysList.SelectByKeyName(val))
            {
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

        }

        private void ShiftFromTargetListToSourceCombo(int ind)
        {
            if (ind == -1)
                return;

            string val = listBox_Cible.Items[ind].ToString();
            if (paysList.UnselectByKeyName(val))
            {
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
            listBox_Cible.Items.RemoveAt(selected);
            listBox_Cible.SelectedIndex = selected + 1;
        }
        #endregion

        #region autres controlleurs
        private void ListCible_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonLeft.Enabled = (listBox_Cible.SelectedIndex != -1);
            RefreshUpButton();
            RefreshDownButton();
        }

        private void ComboSource_DropDown(object sender, EventArgs e)
        {
            if (!StringExists(comboSource.Text))
            {
                if(paysList.AjouterPays(comboSource.Text))
                    comboSource.Items.Add(comboSource.Text);

            }
            comboSource.SelectedIndex = comboSource.Items.Count - 1;
            RefreshLockRightButtons();
            
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonRight.Enabled = (comboSource.SelectedIndex != -1);
        }
        #endregion

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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1(paysList);
            fr.Show();
        }
    }
}