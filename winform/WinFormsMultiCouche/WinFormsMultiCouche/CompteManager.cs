using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsMultiCouche.Models;
using WinFormsMultiCouche.src;

namespace WinFormsMultiCouche
{
    public partial class CompteManager : Form
    {
        private DbJeuContext dbJeu;
        private readonly EnumTypeRequete typeRequete;
        public CompteManager()
        {
            InitializeComponent();
        }

        public CompteManager(EnumTypeRequete e)
        {
            InitializeComponent();
            textBoxPseudo.Enabled = e != EnumTypeRequete.DELETE && e!= EnumTypeRequete.SELECT;
            textBoxId.Enabled = e != EnumTypeRequete.INSERT;
            textBoxTypeRequete.Text = e.ToString();
            typeRequete = e;
            dbJeu = new DbJeuContext();
            dbJeu.Comptes.Load();
        }

        private void Insert()
        {
            if (typeRequete != EnumTypeRequete.INSERT)
                return;
            // CONTROLE SAISIE
            Compte c = new Compte();
            
            c.Pseudo = textBoxPseudo.Text;
            dbJeu.Comptes.Add(c);
            dbJeu.SaveChanges();
            this.Close();
        }

        private void Update()
        {
            if (typeRequete != EnumTypeRequete.UPDATE)
                return;
            // CONTROLE SAISIE
            Compte? c = RecupererElement();
            c.Pseudo = textBoxPseudo.Text;
            if (c != null)
            {

                dbJeu.Comptes.Update(c);
                dbJeu.SaveChanges();
                this.Close();
            }
        }

        private void Delete()
        {
            if (typeRequete != EnumTypeRequete.DELETE)
                return;
            // CONTROLE SAISIE
            Compte? c = RecupererElement();
            if (c != null)
            {
                dbJeu.Comptes.Remove(c);
                dbJeu.SaveChanges();
                this.Close();
            } 
            

        }

        private void Select()
        {
            if (typeRequete != EnumTypeRequete.SELECT)
                return;
            // CONTROLE SAISIE
            Compte? c = RecupererElement();
            if (c!=null)
            {
                OpenDataSelector(new List<object> { c });
                this.Close();
            } else
            {
                MessageBox.Show("Identifiant introuvable");
            }
        }

        private void OpenDataSelector(List<object> datas)
        {
            DataSelector ds = new DataSelector(datas);
            if (this.MdiParent != null) {
                ds.MdiParent = this.MdiParent;
            }
            ds.Show();
        }

        private Compte? RecupererElement() => dbJeu.Comptes.Find(Convert.ToInt32(textBoxId.Text));

        private void btValider_Click(object sender, EventArgs e)
        {
            switch (typeRequete)
            {
                case EnumTypeRequete.UPDATE:
                    Update();
                    break;
                case EnumTypeRequete.INSERT:
                    Insert();
                    break;
                case EnumTypeRequete.DELETE:
                    Delete();
                    break;
                case EnumTypeRequete.SELECT:
                    Select();
                    break;
            }
        }
    }
}
