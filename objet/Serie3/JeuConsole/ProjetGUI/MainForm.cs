using JeuClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetGUI
{
    public partial class MainForm : Form
    {
        private Partie partie;
        bool[] selectedDice;
        public MainForm()
        {
            InitializeComponent();
            /*des = new();
            des.Add(new De(1, 6));
            des.Add(new De(1, 6));
            des.Add(new De(1, 6));*/

            partie = new Partie();
            selectedDice = new bool[] { false, false, false};
            dicerollButton.Enabled = false;
            
            CheckIfWin();
        }

        private void dicePanel_Paint(object sender, PaintEventArgs e)
        {
            De[] des = partie.MancheCourrante.Des;
            Rectangle rc = new Rectangle(0, 0, 100, 100);
            Rectangle rc2 = new Rectangle(110, 0, 100, 100);
            Rectangle rc3 = new Rectangle(220, 0, 100, 100);
            Pen p = new Pen(Color.Black, 3);
            Pen p2 = new Pen(Color.Red, 3);
            SolidBrush b = new SolidBrush(Color.White);
            e.Graphics.FillRectangle(b, rc);
            e.Graphics.FillRectangle(b, rc2);
            e.Graphics.FillRectangle(b, rc3);
            e.Graphics.DrawRectangle((selectedDice[0] ? p2 : p), rc);
            e.Graphics.DrawRectangle((selectedDice[1] ? p2 : p), rc2);
            e.Graphics.DrawRectangle((selectedDice[2] ? p2 : p), rc3);
            
            DrawDiceCircle(des[0].GetValeur(), e, rc);
            DrawDiceCircle(des[1].GetValeur(), e, rc2);
            DrawDiceCircle(des[2].GetValeur(), e, rc3);
        }

        private void DrawDiceCircle(int val, PaintEventArgs e, Rectangle diceBox)
        {
            
            SolidBrush b = new SolidBrush(Color.Black);
            if (val %2 == 1)
            {
                // X = diceBox.X + (diceBox.Width/2) - (20 / 2)
                // Y = diceBox.X + (diceBox.Width/2) - (20 / 2)
                // W = 20
                // H = 20
                Rectangle el = new Rectangle(diceBox.X + (diceBox.Width / 2) - (20 / 2), diceBox.Y + (diceBox.Height / 2) - (20 / 2), 20, 20);
                e.Graphics.FillEllipse(b, el);
            }
            if (val != 1)
            {
                Rectangle el = new Rectangle(diceBox.X + diceBox.Width - 30, diceBox.Y + 15 , 20, 20);
                Rectangle el2 = new Rectangle(diceBox.X + 15, diceBox.Y + diceBox.Height - 30 , 20, 20);
                e.Graphics.FillEllipse(b, el);
                e.Graphics.FillEllipse(b, el2);
            }
            if (val > 3)
            {
                Rectangle el = new Rectangle(diceBox.X + 15, diceBox.Y + 15, 20, 20);
                Rectangle el2 = new Rectangle(diceBox.X + diceBox.Width - 30, diceBox.Y + diceBox.Height - 30, 20, 20);
                e.Graphics.FillEllipse(b, el);
                e.Graphics.FillEllipse(b, el2);
            }
            if (val == 6)
            {
                Rectangle el = new Rectangle(diceBox.X + 15, diceBox.Y + (diceBox.Height / 2) - (20 / 2), 20, 20);
                Rectangle el2 = new Rectangle(diceBox.X + diceBox.Width - 30, diceBox.Y + (diceBox.Height / 2) - (20 / 2), 20, 20);
                e.Graphics.FillEllipse(b, el);
                e.Graphics.FillEllipse(b, el2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            De[] des = partie.MancheCourrante.Des;

            List<byte> diceToReroll = new();
            for (int i = 0; i < selectedDice.Length; i++)
            {
                if (selectedDice[i])
                {
                    
                    
                    selectedDice[i] = false;
                    diceToReroll.Add((byte)i);
                }
            }
            //dicePanel_Paint(sender, (PaintEventArgs)e);
            partie.RelancerDes(diceToReroll.ToArray());
            if (diceToReroll.Count() > 0)
            {
                partie.MancheCourrante.Trier();
                dicePanel.Refresh();
                CheckIfWin();
            }
                
            dicerollButton.Enabled = false;
        }


        private void dicePanel_Click(object sender, EventArgs e)
        {
            if (!partie.EstCeQueLaMancheCourranteAEncoreUnLancer())
                return;
            int x = ((MouseEventArgs)e).X;
            bool changeState = false;
            if (x > 0 && x <= 100)
            {
                selectedDice[0] = !selectedDice[0];
                changeState = true;
                
            } else if (x > 110 && x<= 210)
            {
                selectedDice[1] = !selectedDice[1];
                changeState = true;
            } else if (x > 220 && x <= 320)
            {
                selectedDice[2] = !selectedDice[2];
                changeState = true;
            }
            if (changeState)
            {
                dicePanel.Refresh();
                dicerollButton.Enabled = OneIsSelected();
            }
        }

        private bool OneIsSelected()
        {
            int i = 0;
            while (i < selectedDice.Length && !selectedDice[i])
                i++;
            return i < selectedDice.Length || selectedDice[selectedDice.Length-1];
        }


        public void CheckIfWin()
        {
            if (partie.EstCeQueLaMancheCourranteEstGagne())
            {
                //partie.CreerUneNouvelleManche();
                partie.AjouterPoint();
                labelScore.Text = String.Format("Score:{0}",partie.Score);
            } else if (!partie.EstCeQueLaMancheCourranteAEncoreUnLancer())
            {
                partie.RetirePoint();
                labelScore.Text = String.Format("Score:{0}", partie.Score);
            }
        }
    }
}
