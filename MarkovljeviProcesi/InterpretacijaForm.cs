using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkovljeviProcesi
{
    public partial class InterpretacijaForm : Form
    {
        public InterpretacijaForm()
        {
            InitializeComponent();
            rxtIntepretacija.SelectAll();
            rxtIntepretacija.SelectionAlignment = HorizontalAlignment.Left;
        }
    }
}
