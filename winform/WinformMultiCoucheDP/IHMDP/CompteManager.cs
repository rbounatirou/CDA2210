using Domain;
using Persistence.Persistent;
using IHMDP.utils;
using InterfaceDP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHMDP
{
    public partial class CompteManager : Form
    {
        private EnumTypeRequete typeRequete;
        private CCompte compte;
        public CompteManager()
        {
            InitializeComponent();
        }

        public CompteManager(EnumTypeRequete e, ICrudCompte _config)
        {
            InitializeComponent();
            typeRequete = e;
            textBoxPseudo.Enabled = (e == EnumTypeRequete.INSERT || e == EnumTypeRequete.SELECT);
            textBoxId.Enabled = e != EnumTypeRequete.INSERT;
            compte = new CCompte(_config);
            textBoxTypeRequete.Text = e.ToString();
        }

        private void SendQuery(object sender, EventArgs e)
        {
            if (typeRequete != EnumTypeRequete.INSERT)
                compte.Id = Convert.ToInt32(textBoxId.Text);
            if (typeRequete == EnumTypeRequete.INSERT ||
                typeRequete == EnumTypeRequete.SELECT)
                compte.Pseudo = textBoxPseudo.Text;
            switch (typeRequete)
            {
                case EnumTypeRequete.INSERT:
                    compte.Ajouter();
                    this.Close();
                    break;
                case EnumTypeRequete.SELECT:
                    if (compte.Selectionner())
                    {
                        MessageBox.Show("err");
                    } else
                    {
                        DataObserver dob = new DataObserver(new List<object> { compte });
                        dob.MdiParent = this.MdiParent;
                        dob.Show();
                    }
                    this.Close();
                    break;
                case EnumTypeRequete.DELETE:
                    if (!compte.Supprimer())
                    {
                        MessageBox.Show("err");
                    }
                    this.Close();
                    break;
                case EnumTypeRequete.UPDATE:
                    if (!compte.Modifier())
                    {
                        MessageBox.Show("err");
                    }
                    this.Show();
                    break;
            }
        }
    }
}
