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
    public partial class PocetnaForm : Form
    {
        public PocetnaForm()
        {
            InitializeComponent();
        }

        private void btnPredvidanjeKoristenjaUsluga_Click(object sender, EventArgs e)
        {
            PredvidanjeKoristenjaUslugaForm predvidanjeKoristenjaUslugaForm = new PredvidanjeKoristenjaUslugaForm();
            this.Hide();
            predvidanjeKoristenjaUslugaForm.ShowDialog();
            this.Show();


        }

        private void btnPrognoziranjeBrojaKorisnika_Click(object sender, EventArgs e)
        {
            PrognoziranjeBrojaKorisnikaForm prognoziranjeBrojaKorisnikaForm = new PrognoziranjeBrojaKorisnikaForm();
            this.Hide();
            prognoziranjeBrojaKorisnikaForm.ShowDialog();
            this.Show();

        }

        private void PocetnaForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                InterpretacijaForm pomoc = new InterpretacijaForm();

                pomoc.Text = "Pomoć";
                RichTextBox richTextBox = (RichTextBox)pomoc.Controls.Find("rxtIntepretacija", true)[0];
                richTextBox.Clear();

                richTextBox.Text = "Help Center\n\n";
                richTextBox.Text += "Nalazite se u izborniku aplikacije, imate dvije mogućnosti:\n\n";
                richTextBox.Text += "1. Klikom na gumb 'Prognoziranje broja korisnika' otvara se forma za prognoziranje broja korinsika\n\n";
                richTextBox.Text += "2. Klikom na gumb 'Predviđanje korištenja usluga' otvara se forma za predviđanje korištenja usluga\n\n";
                pomoc.ShowDialog();
            }
        }
    }
}
