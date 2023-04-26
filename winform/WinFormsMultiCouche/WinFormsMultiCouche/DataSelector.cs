using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsMultiCouche
{
    public partial class DataSelector : Form
    {
        List<object> data;
        public DataSelector()
        {
            InitializeComponent();
        }

        public DataSelector(List<object> datas)
        {
            InitializeComponent();
            data = datas;
            dataGridViewSelect.DataSource = datas;
        }
    }
}
