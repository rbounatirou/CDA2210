namespace ComposantDefilement
{
    public partial class Form1 : Form
    {

        Color couleurActuelle;
        public Form1()
        {
            InitializeComponent();
            InitPanels();
        }

        public Form1(Color c)
        {
            couleurActuelle = c;
        }

        private void UpdatePanel()
        {
            UpdateRedPanel();
            UpdateGreenPanel();
            UpdateBluePanel();
            panelColor.BackColor = couleurActuelle;
            panelColor.Refresh();
        }

        private void UpdateRedPanel()
        {
            panelRed.BackColor = Color.FromArgb(couleurActuelle.R, 0, 0);
            panelColor.Refresh();
        }

        private void UpdateGreenPanel()
        {
            panelGreen.BackColor = Color.FromArgb(0, couleurActuelle.G, 0);
            panelGreen.Refresh();
        }

        private void UpdateBluePanel()
        {
            panelBlue.BackColor = Color.FromArgb(0, 0, couleurActuelle.B);
            panelBlue.Refresh();
        }

        private void InitPanels()
        {
            UpdateRedPanel();
            UpdateGreenPanel();
            UpdateBluePanel();
            UpdatePanel();
        }

        private void HS_ColorValueChanged(object sender, EventArgs e)
        {
            HScrollBar scrollbar = sender as HScrollBar;

            switch (scrollbar.Tag.ToString())
            {
                case "HSRed":
                    couleurActuelle = Color.FromArgb(scrollbar.Value, couleurActuelle.G, couleurActuelle.B);
                    numericUpDownRed.Value = scrollbar.Value;
                    //UpdateRedPanel();
                    break;
                case "HSGreen":
                    couleurActuelle = Color.FromArgb(couleurActuelle.R, scrollbar.Value, couleurActuelle.B);
                    numericUpDownGreen.Value = scrollbar.Value;
                    //UpdateGreenPanel();
                    break;
                case "HSBlue":
                    couleurActuelle = Color.FromArgb(couleurActuelle.R, couleurActuelle.G, scrollbar.Value);
                    numericUpDownBlue.Value = scrollbar.Value;
                    //UpdateBluePanel();
                    break;
            }
            UpdatePanel();
        }

        private void NUD_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown NUD = sender as NumericUpDown;
            switch (NUD.Tag.ToString())
            {
                case "NumRed":
                    couleurActuelle = Color.FromArgb(Convert.ToInt32(NUD.Value), couleurActuelle.G, couleurActuelle.B);
                    hScrollBarRed.Value = Convert.ToInt32(NUD.Value);
                    //UpdateRedPanel();
                    break;
                case "NumGreen":
                    couleurActuelle = Color.FromArgb(couleurActuelle.R, Convert.ToInt32(NUD.Value), couleurActuelle.B);
                    hScrollBarGreen.Value = Convert.ToInt32(NUD.Value);
                    //UpdateGreenPanel();
                    break;
                case "NumBlue":
                    couleurActuelle = Color.FromArgb(couleurActuelle.R, couleurActuelle.G, Convert.ToInt32(NUD.Value));
                    hScrollBarBlue.Value = Convert.ToInt32(NUD.Value);
                    //UpdateBluePanel();
                    break;
            }
            UpdatePanel();
        }
    }
}