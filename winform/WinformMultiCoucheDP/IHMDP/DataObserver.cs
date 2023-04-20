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
    public partial class DataObserver : Form
    {
        public DataObserver()
        {
            InitializeComponent();
        }

        public DataObserver(List<object> src)
        {
            InitializeComponent();
            dataGridViewObserver.DataSource = src;
        }
    }
}
