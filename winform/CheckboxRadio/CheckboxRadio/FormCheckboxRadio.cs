using System.Security.Cryptography;

namespace CreerFormulaires
{
    public partial class FormCheckBoxRadio : Form
    {
        public FormCheckBoxRadio()
        {
            InitializeComponent();
        }

        private void textbox_input_Changed(object sender, EventArgs e)
        {
            lbl_result.Text = textbox_input.Text;
            if (checkBoxCase.Checked)
            {
                if (rd_case_lower.Checked)
                {
                    lbl_result.Text = lbl_result.Text.ToLower();
                }
                else if (rd_case_upper.Checked)
                {
                    lbl_result.Text = lbl_result.Text.ToUpper();
                }
            }
            groupBox_choix.Enabled = (textbox_input.Text != "");
        }

        private void checkBoxBackground_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = sender as CheckBox;
            groupBox_bg.Visible = c.Checked;
            if (!c.Checked)
            {
                lbl_result.BackColor = Color.FromArgb(0,0,0,0);
            }
        }

        private void checkBoxFont_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = sender as CheckBox;
            groupBox_font.Visible = c.Checked;
            if (!c.Checked)
            {
                lbl_result.ForeColor = Color.Black;
            }
        }

        private void checkBoxCase_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = sender as CheckBox;
            groupBox_case.Visible = c.Checked;
        }

        private void radioBg_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            switch (rb.Tag)
            {
                case "BgRouge":
                    lbl_result.BackColor = Color.Red;
                    break;
                case "BgVert":
                    lbl_result.BackColor = Color.Green;
                    break;
                default:
                    lbl_result.BackColor = Color.Blue;
                    break;

            }
        }

        private void radioFont_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            switch (rb.Tag)
            {
                case "FontRouge":
                    lbl_result.ForeColor = Color.Red;
                    break;
                case "FontBlanc":
                    lbl_result.ForeColor = Color.White;
                    break;
                default:
                    lbl_result.ForeColor = Color.Black;
                    break;
            }
        }

        private void radioCase_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            lbl_result.Text = (rb.Tag == "CaseLower" ? lbl_result.Text.ToLower() : lbl_result.Text.ToUpper());

        }
    }
}