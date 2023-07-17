using CompositeFigure;
using CompositeFigure.Shapes.ConcreteShapes;

namespace ProjectWinform
{
    public partial class Form1 : Form
    {
        private VisiteurDeFigureWinform vfw;
        private EnsembleFigure ef;
        public Form1()
        {            
            InitializeComponent();
            vfw = new VisiteurDeFigureWinform(panelDessiner);
            ef = new EnsembleFigure();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {            
            Carre c = new Carre(new Coordonnee(100, 0), 100);
            Rond c2 = new Rond(new Coordonnee(50,50),0,50);
            Rond c3 = new Rond(new Coordonnee(50,50),0,50);
            ef.AjouterFigure(c);
            ef.AjouterFigure(c2);
            ef.AjouterFigure(c3);
            ef.RegrouperElementEnUnGroupe(0, 2, 1);
            ef.DissocierElementEnPlusieurs(0);
            ef.AccepterVisite(vfw);
        }

        private void panelDessiner_Paint(object sender, PaintEventArgs e)
        {
            


            
        }
    }
}